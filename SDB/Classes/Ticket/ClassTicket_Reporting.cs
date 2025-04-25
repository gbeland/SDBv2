using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	/// <summary>
	/// A proprietary class for reporting, which gets some details about the ticket as well as customer, market, asset and tech.
	/// </summary>
	public class ClassTicket_Reporting
	{
		public readonly ClassRTicket Ticket;
		public readonly ClassRCustomer Customer;
		public readonly ClassRMarket Market;
		public readonly ClassRAsset Asset;
		public readonly ClassRTech Tech;

		public class ClassRTicket
		{
			public int ID;
			public DateTime OpenDT;
			public DateTime? CloseDT;
			[UsedImplicitly] public string Issue;
			[UsedImplicitly] public string ReportedType;
			[UsedImplicitly] public string OSA_Notes;
			[UsedImplicitly] public string Symptoms;
			[UsedImplicitly] public string Solutions;
			[UsedImplicitly] public string Symptom_Other;
			[UsedImplicitly] public string Solution_Notes;
			[UsedImplicitly] public DateTime? FirstTechArrivalDateTime;
			public string Status;

			public Color StatusColor_FG
			{
				get
				{
					if (Status == "Open")
						return ClassTicket.COL_TICKET_OPEN_OSA_FG;

					if (Status == "Monitoring")
						return ClassTicket.COL_TICKET_OPEN_FG;

					if (Status == "Pending")
						return ClassTicket.COL_TICKET_HELD_FG;

					if (Status == "Closed")
						return ClassTicket.COL_TICKET_CLOSED_FG;

					return SystemColors.Control;
				}
			}
			public Color StatusColor_BG
			{
				get
				{
					if (Status == "Open")
						return ClassTicket.COL_TICKET_OPEN_OSA_BG;

					if (Status == "Monitoring")
						return ClassTicket.COL_TICKET_OPEN_BG;

					if (Status == "Pending")
						return ClassTicket.COL_TICKET_HELD_BG;

					if (Status == "Closed")
						return ClassTicket.COL_TICKET_CLOSED_BG;

					return SystemColors.Control;
				}
			}

			public TimeSpan Duration => CloseDT.HasValue ? CloseDT.Value - OpenDT : DateTime.Now - OpenDT;
			[UsedImplicitly]
			public TimeSpan? TechArrivedDuration => FirstTechArrivalDateTime.HasValue ? FirstTechArrivalDateTime.Value - OpenDT : (TimeSpan?)null;

			public override string ToString()
			{
				return $"{ID} {Status}";
			}
		}

		public class ClassRCustomer
		{
			public int ID;
			public string Name;

			public override string ToString()
			{
				return $"{Name} [{ID}]";
			}
		}

		public class ClassRMarket
		{
			public int ID;
			public string Name;

			public override string ToString()
			{
				return $"{Name} [{ID}]";
			}
		}

		public class ClassRAsset
		{
			public int ID;
			public string Asset;
			public string Panel;
			public string Location;

			public override string ToString()
			{
				return $"{Asset} ({Panel}) [{ID}]";
			}
		}

		public class ClassRTech
		{
			public int ID;
			public string Name;

			public override string ToString()
			{
				return $"{Name} [{ID}]";
			}
		}

		public ClassTicket_Reporting()
		{
			Ticket = new ClassRTicket();
			Customer = new ClassRCustomer();
			Market = new ClassRMarket();
			Asset = new ClassRAsset();
			Tech = new ClassRTech();
		}

		/// <summary>
		/// Gets list of ClassTicketReporting for specified ReportRequest.
		/// </summary>
		public static IEnumerable<ClassTicket_Reporting> GetTicketsForReporting(ClassReporting.ClassReportRequestObject reportRequest)
		{
			var rptTickets = new List<ClassTicket_Reporting>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();

					#region CommandText
					var dateFrom = reportRequest.OpenFrom.HasValue ? @"AND t.open_dt >= @DateFrom" : string.Empty;
					var dateTo = reportRequest.OpenTo.HasValue ? @"AND t.open_dt <= @DateTo" : string.Empty;
					var customers = reportRequest.Customers.Count > 0 ? $@"AND c.id IN ({string.Join(",", reportRequest.Customers.Select(c => c.ID).ToArray())})" : string.Empty;
					var assets = reportRequest.Assets.Count > 0 ? $@"AND a.id IN ({string.Join(",", reportRequest.Assets.Select(a => a.ID).ToArray())})" : string.Empty;
					var techs = reportRequest.Techs.Count > 0 ? $@"AND h.id IN ({string.Join(",", reportRequest.Techs.Select(t => t.ID).ToArray())})" : string.Empty;
					var symptoms = reportRequest.TicketReportOptions.IsSymptomsFiltered ? $@"AND sym.id IN ({string.Join(",", reportRequest.TicketReportOptions.Filters.Symptoms.Select(sym => sym.ID).ToArray())})" : string.Empty;
					var solutions = reportRequest.TicketReportOptions.IsSolutionsFiltered ? $@"AND sol.id IN ({string.Join(",", reportRequest.TicketReportOptions.Filters.Solutions.Select(sol => sol.ID).ToArray())})" : string.Empty;
					var ticketTypes = GetTicketTypeSQL(reportRequest.TicketReportOptions);
					cmd.CommandText =
						$@"SELECT t.id, t.open_dt, t.close_dt, t.techarrived_dt, t.issue, t.reported_type,
						c.id customer_id, c.name customer,
						m.id market_id, m.name market,
						a.id asset_id, a.asset, a.panel, a.location,
						h.id tech_id, h.tech,
						GROUP_CONCAT(DISTINCT sym.symptom SEPARATOR ', ') symptoms, t.notes osa_notes, t.symptom_other,
						GROUP_CONCAT(DISTINCT sol.solution SEPARATOR ', ') solutions, t.solution_notes,
						IF(t.close_dt IS NOT NULL, 'Closed',
							IF(t.held = TRUE, 'On Hold', 'Open')) ticket_status
						FROM assets a
						INNER JOIN markets m ON (a.market_id = m.id)
						INNER JOIN customers c ON (m.customer_id = c.id)
						INNER JOIN tickets t ON (t.asset_id = a.id)
						LEFT JOIN techs h ON (t.tech_id = h.id)
						LEFT OUTER JOIN ticket_solutions tsol
							INNER JOIN solutions sol ON (tsol.solution_id = sol.id)
							ON (tsol.ticket_id = t.id)
						LEFT OUTER JOIN ticket_symptoms tsym
							INNER JOIN symptoms sym ON (tsym.symptom_id = sym.id)
							ON (tsym.ticket_id = t.id)
						WHERE t.deleted IS FALSE
						{dateFrom}
						{dateTo}
						{customers}
						{assets}
						{techs}
						{symptoms}
						{solutions}
						{ticketTypes}
						GROUP BY t.id DESC;";
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
							rptTickets.Add(GetTicketReportingFromReader(reader));

					conn.Close();
				}
			}
			return rptTickets;
		}

		/// <summary>
		/// Generates the proper SQL clause for selecting the various ticket types (Open, Closed, Pending, Monitoring).
		/// </summary>
		private static string GetTicketTypeSQL(ClassReporting.ClassReportRequestObject.ClassTicketReportOptions tro)
		{
			var ticketTypeOptions = 0;
			if (tro.IncludeClosed)
				ticketTypeOptions += 1;
			if (tro.IncludeHeld)
				ticketTypeOptions += 2;
			if (tro.IncludeOpen)
				ticketTypeOptions += 4;

			#region Validation
			if (ticketTypeOptions == 0)
				throw new ArgumentException("At least one Ticket Type reporting option must be set true.");
			#endregion

			switch (ticketTypeOptions)
			{
				case 1: // C Only
					return @"AND t.close_dt IS NOT NULL";
				case 2: // H Only
					return @"AND t.close_dt IS NULL AND t.held IS TRUE";
				case 3: // H + C
					return @"AND (t.close_dt IS NOT NULL OR t.held IS TRUE)";
				case 4: // O Only
					return @"AND t.close_dt IS NULL AND t.held IS FALSE";
				case 5: // O + C
					return @"AND (t.close_dt IS NOT NULL OR (t.close_dt IS NULL AND t.held = FALSE))";
				case 6: // O + H
					return @"AND t.close_dt IS NULL";
				default: // O + H + C (All)
					return string.Empty;
			}
		}

		private static ClassTicket_Reporting GetTicketReportingFromReader(MySqlDataReader reader)
		{
			var rptTicket = new ClassTicket_Reporting();

			rptTicket.Ticket.ID = reader.GetDBInt("id");
			rptTicket.Ticket.OpenDT = reader.GetDBDateTime("open_dt");
			rptTicket.Ticket.CloseDT = reader.GetDBDateTime_Null("close_dt");
			rptTicket.Ticket.Issue = reader.GetDBString("issue");
			rptTicket.Ticket.ReportedType = reader.GetDBString("reported_type");
			rptTicket.Ticket.OSA_Notes = reader.GetDBString("osa_notes");
			rptTicket.Ticket.Symptoms = reader.GetDBString("symptoms");
			rptTicket.Ticket.Symptom_Other = reader.GetDBString("symptom_other");
			rptTicket.Ticket.Solutions = reader.GetDBString("solutions");
			rptTicket.Ticket.Solution_Notes = reader.GetDBString("solution_notes");
			rptTicket.Ticket.Status = reader.GetDBString("ticket_status");
			rptTicket.Ticket.FirstTechArrivalDateTime = reader.GetDBDateTime_Null("techarrived_dt");

			rptTicket.Customer.ID = reader.GetDBInt("customer_id");
			rptTicket.Customer.Name = reader.GetDBString("customer");

			rptTicket.Market.ID = reader.GetDBInt("market_id");
			rptTicket.Market.Name = reader.GetDBString("market");

			rptTicket.Asset.ID = reader.GetDBInt("asset_id");
			rptTicket.Asset.Asset = reader.GetDBString("asset");
			rptTicket.Asset.Panel = reader.GetDBString("panel");
			rptTicket.Asset.Location = reader.GetDBString("location");

			rptTicket.Tech.ID = reader.GetDBInt("tech_id");
			rptTicket.Tech.Name = reader.GetDBString("tech");

			return rptTicket;
		}
	}
}