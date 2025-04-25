using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.General;
// ReSharper disable RedundantVerbatimStringPrefix

namespace SDB.Classes.RMA
{
	public class ClassRMA_Reporting : ClassRMA
	{
		public string AssemblyFailureTypes { get; set; }
		public string AssemblyRepairTypes { get; set; }
		public string AssemblyRootCauses { get; set; }

		public ClassRTicket Ticket;
		public ClassRTech Tech;
		public ClassRAsset Asset;

		public class ClassRTicket
		{
			public int ID { get; set; }
			public string IssueNum { get; set; }
			public string OrderNum { get; set; }
			public DateTime OpenDT { get; set; }
			public DateTime? CloseDT { get; set; }
			public string OSANotes { get; set; }
		}

		public class ClassRTech
		{
			public int ID { get; set; }
			public string Name { get; set; }
		}

		public class ClassRAsset
		{
			public int ID { get; set; }
			public string AssetName { get; set; }
			public string Panel { get; set; }
		}

		private ClassRMA_Reporting()
		{
			Ticket = new ClassRTicket();
			Tech = new ClassRTech();
			Asset = new ClassRAsset();
		}

		/// <summary>
		/// Gets list of ClassRMAReporting for specified ReportRequest.
		/// </summary>
		public static IEnumerable<ClassRMA_Reporting> GetRmasForReporting(ClassReporting.ClassReportRequestObject reportRequest)
		{
			var rmas = new List<ClassRMA_Reporting>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					#region CommandText
					// TODO: This query needs to be fixed/optimized
					cmd.CommandText =
						string.Format(
							@"SELECT
								r.id rma_id, r.creation_date, r.creation_user,
								CONCAT(u.firstname, LEFT(u.lastname, 1)) creation_username,
								r.job_number, r.po_number, r.legacy_rma,
								r.flag_apr, r.flag_hot, r.flag_pending, r.flag_computer, r.pending_type, r.pending_reason,
								r.completed_date, r.finalized_date, r.notes,
								t.id ticket_id, t.open_dt, t.close_dt, t.issue,
								c.id customer_id, c.name customer,
								m.id market_id, m.name market,
								a.id asset_id, a.asset, a.panel, a.location,
								h.id tech_id, h.tech,
							COUNT(ra.id) assembly_qty,
							SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
							SUM(IF(ra.repair_start_date IS NOT NULL, 1, 0)) repair_start_qty,
							MIN(ra.receive_date) first_received,
							GROUP_CONCAT(DISTINCT rft.description SEPARATOR ', ') failure_types,
							GROUP_CONCAT(DISTINCT rrt.description SEPARATOR ', ') repair_types,
							(SELECT GROUP_CONCAT(DISTINCT(rrt.description) SEPARATOR ', ')
								FROM rma_assemblies ra
								LEFT JOIN rma_assembly_repairs rar
									JOIN rma_repair_types rrt ON rrt.id = rar.rma_repair_type
									ON rar.rma_assembly_id = ra.id
								WHERE ra.rma_id = r.id) AS repair_types,
							GROUP_CONCAT(DISTINCT rrc.description SEPARATOR ', ') root_causes
						FROM rma r
							JOIN assets a
								USE INDEX (PRIMARY)
								ON r.asset_id = a.id
							JOIN techs h ON r.tech_id = h.id
							JOIN markets m ON a.market_id = m.id
							JOIN customers c ON m.customer_id = c.id
							LEFT JOIN tickets t ON t.id = r.ticket_id
							LEFT JOIN rma_assemblies ra ON r.id = ra.rma_id
							LEFT JOIN users u ON r.creation_user = u.userid
							LEFT JOIN rma_failure_types rft ON ra.failure_type = rft.id
							LEFT JOIN rma_assembly_repairs rar
								JOIN rma_repair_types rrt
									ON rar.rma_repair_type = rrt.id
								ON ra.id = rar.rma_assembly_id
							LEFT JOIN rma_root_causes rrc ON ra.finalize_root_cause = rrc.id
						WHERE r.deleted IS FALSE
							{0}
							{1}
							{2}
							{3}
							{4}
							{5}
							{6}
							{7}
							{8}
						GROUP BY r.id DESC
						{9};",
						              reportRequest.OpenFrom.HasValue ? @"AND r.creation_date >= @DateFrom" : string.Empty,
						              reportRequest.OpenTo.HasValue ? @"AND r.creation_date <= @DateTo" : string.Empty,
						              reportRequest.Customers.Count > 0 ? $@"AND c.id IN ({string.Join(",", reportRequest.Customers.Select(c => c.ID).ToArray())})" : string.Empty,
						              reportRequest.Assets.Count > 0 ? $@"AND a.id IN ({string.Join(",", reportRequest.Assets.Select(a => a.ID).ToArray())})" : string.Empty,
						              reportRequest.Techs.Count > 0 ? $@"AND h.id IN ({string.Join(",", reportRequest.Techs.Select(t => t.ID).ToArray())})" : string.Empty,
						              reportRequest.RMAReportOptions.IsAssemblyTypeFiltered ? $@"AND ra.assembly_type IN ({string.Join(",", reportRequest.RMAReportOptions.Filters.AssemblyTypes.Select(at => at.ID).ToArray())})" : string.Empty,
						              reportRequest.RMAReportOptions.IsFailureTypeFiltered ? $@"AND ra.failure_type IN ({string.Join(",", reportRequest.RMAReportOptions.Filters.FailureTypes.Select(ft => ft.ID).ToArray())})" : string.Empty,
						              reportRequest.RMAReportOptions.IsRepairTypeFiltered ? $@"AND rrt.id IN ({string.Join(",", reportRequest.RMAReportOptions.Filters.RepairTypes.Select(rt => rt.ID).ToArray())})" : string.Empty,
						              reportRequest.RMAReportOptions.IsRootCauseFiltered ? $@"AND ra.finalize_root_cause IN ({string.Join(",", reportRequest.RMAReportOptions.Filters.RootCauses.Select(rc => rc.ID).ToArray())})" : string.Empty,
						              GetRMATypeSQL(reportRequest.RMAReportOptions));
					#endregion

					#region Parameters
					if (reportRequest.OpenFrom.HasValue)
						cmd.Parameters.AddWithValue("DateFrom", reportRequest.OpenFrom);
					if (reportRequest.OpenTo.HasValue)
						cmd.Parameters.AddWithValue("DateTo", reportRequest.OpenTo);
					#endregion

					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							rmas.Add(GetRMAReportingFromReader(reader));
				}
				conn.Close();
			}
			return rmas;
		}

		private static ClassRMA_Reporting GetRMAReportingFromReader(MySqlDataReader reader)
		{
			var rptRMA = new ClassRMA_Reporting
				                           {
					                           ID = reader.GetDBInt("rma_id"),
					                           Creation_Date = reader.GetDBDateTime("creation_date"),
					                           Creation_UserID = reader.GetDBInt("creation_user"),
					                           Creation_UserName = reader.GetDBString("creation_username"),
					                           JobNumber = reader.GetDBString("job_number"),
					                           PONumber = reader.GetDBString("po_number"),
					                           LegacyRMANumber = reader.GetDBInt_Null("legacy_rma"),
					                           IsAPR = reader.GetDBBool("flag_apr"),
					                           IsHot = reader.GetDBBool("flag_hot"),
					                           IsPending = reader.GetDBBool("flag_pending"),
					                           HasComputer = reader.GetDBBool("flag_computer"),
					                           Pending_Type = reader.GetDBString("pending_type"),
					                           Pending_Reason = reader.GetDBString("pending_reason"),
					                           TicketID = reader.GetDBInt("ticket_id"),
					                           Completed_Date = reader.GetDBDateTime_Null("completed_date"),
					                           Finalized_Date = reader.GetDBDateTime_Null("finalized_date"),

					                           AssemblyQty = reader.GetDBInt("assembly_qty"),
					                           Assemblies_ReceivedOrDiscarded_Qty = reader.GetDBInt("received_or_discarded_qty"),
					                           Assemblies_RepairStarted_Qty = reader.GetDBInt("repair_start_qty"),
					                           FirstAssemblyReceived = reader.GetDBDateTime_Null("first_received"),

					                           AssemblyFailureTypes = reader.GetDBString("failure_types"),
					                           AssemblyRepairTypes = reader.GetDBString("repair_Types"),
					                           AssemblyRootCauses = reader.GetDBString("root_causes")
				                           };

			rptRMA.Ticket = new ClassRTicket
			                {
				                ID = reader.GetDBInt("ticket_id"),
				                OpenDT = reader.GetDBDateTime("open_dt"),
				                CloseDT = reader.GetDBDateTime_Null("close_dt"),
				                IssueNum = reader.GetDBString("issue")
			                };

			rptRMA.Asset = new ClassRAsset
				               {
					               ID = reader.GetDBInt("asset_id"),
					               AssetName = reader.GetDBString("asset"),
					               Panel = reader.GetDBString("panel")
				               };

			rptRMA.Tech = new ClassRTech
				              {
					              ID = reader.GetDBInt("tech_id"),
					              Name = reader.GetDBString("tech")
				              };

			return rptRMA;
		}

		private static string GetRMATypeSQL(ClassReporting.ClassReportRequestObject.ClassRMAReportOptions rro)
		{
			var rmaTypeOptions = 0;
			if (rro.IncludeUnreceived) rmaTypeOptions += 1;
			if (rro.IncludeReceived) rmaTypeOptions += 2;
			if (rro.IncludeInProgress) rmaTypeOptions += 4;
			if (rro.IncludePending) rmaTypeOptions += 8;
			if (rro.IncludeCompleted) rmaTypeOptions += 16;
			if (rro.IncludeFinalized) rmaTypeOptions += 32;

			#region Validation
			if (rmaTypeOptions == 0)
				throw new ArgumentException("At least one RMA Type reporting option must be set true.");
			#endregion

			if (rmaTypeOptions == 63)
				return string.Empty;

			string[] rmaTypeSQLSelectors =
				{
					"(received_or_discarded_qty = 0 AND r.completed_date IS NULL)",
					"(received_or_discarded_qty > 0 AND repair_start_qty = 0 AND r.completed_date IS NULL)",
					"(repair_start_qty > 0 AND r.completed_date IS NULL)",
					"(r.flag_pending IS TRUE)",
					"(r.completed_date IS NOT NULL)",
					"(r.finalized_date IS NOT NULL)"
				};
			var bitMask = new BitArray(new[] { rmaTypeOptions });
			return "HAVING " + string.Join(" OR ", rmaTypeSQLSelectors.Where((c, i) => bitMask.Get(i)).ToArray());
		}
	}
}