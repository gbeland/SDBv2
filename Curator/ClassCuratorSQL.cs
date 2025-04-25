using System;
using System.Collections.Generic;
using System.Globalization;
using MySql.Data.MySqlClient;
using SDB.Classes;
using System.Linq;
using SDB.Classes.General;

namespace Curator
{
	internal static class ClassCuratorSQL
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		public class UnreceivedRmaData
		{
			public int TechID { get; set; }
			public int RmaID { get; set; }
			public DateTime RmaCreated { get; set; }
			public string AssetName { get; set; }
			public string AssetLocation { get; set; }
			public string AssetCity { get; set; }
			public string AssetState { get; set; }

			public string AssetInfo
			{
				get { return string.Format("{0}; {1}, {2} {3}", AssetName, AssetLocation, AssetCity, AssetState); }
			}
		}

		public struct RMAAssemblyLineItem
		{
			public int Qty { get; set; }
			public string Assembly { get; set; }
		}

		public struct TechData
		{
			public int ID { get; set; }
			public string Name { get; set; }
			public string Email { get; set; }
		}
		#endregion

		#region Private Fields
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		#endregion

		#region Private Methods
		#endregion

		#region Public Methods
		/// <summary>
		/// Returns a list of RMA IDs which are unreceived, are older than <paramref name="daysOlderThan"/> but not older than <paramref name="daysNotOlderThan"/>.
		/// Excludes RMAs that have had a notice within <paramref name="excludeNotifiedWithinDays"/> days.
		/// </summary>
		/// <param name="daysOlderThan">RMA was created more than this number of days ago.</param>
		/// <param name="daysNotOlderThan">RMA was creatred less than this number of days ago.</param>
		/// <param name="excludeNotifiedWithinDays">Do not include RMAs which have notices issued within this number of days.</param>
		public static IEnumerable<UnreceivedRmaData> GetUnreceivedRmas(int daysOlderThan, int daysNotOlderThan, int excludeNotifiedWithinDays, bool OnlyAPR)
		{
			var unreceivedRmas = new List<UnreceivedRmaData>();

			#region validation
			if (daysNotOlderThan != 0 && daysNotOlderThan <= daysOlderThan)
				throw new ArgumentException("daysOlderThan must be less than daysNotOlderThan");
			#endregion

			using (var conn = CreateConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					if (OnlyAPR == false)
					{
						cmd.CommandText =
							string.Format(@"SELECT
								r.id, r.tech_id, r.creation_date,
								a.asset asset_name, a.location asset_location, a.city asset_city, a.state asset_state,
								COUNT(ra.id) assembly_qty,
								SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
								DATEDIFF(NOW(), r.creation_date) days_old,
								DATEDIFF(NOW(), last_notice_date) last_notice_days_ago

							FROM rma r
								LEFT JOIN rma_assemblies ra
									ON (r.id = ra.rma_id)
								LEFT JOIN
									(
										SELECT rnl.rma_id, MAX(rnl.notice_date) last_notice_date
										FROM rma_notice_log rnl
										GROUP BY rnl.rma_id
									) rma_notices
									ON (r.id = rma_notices.rma_id)
								JOIN assets a
									ON (r.asset_id = a.id)

							WHERE r.deleted IS FALSE
								AND r.completed_date IS NULL
								AND
								(
									r.creation_date <= DATE_SUB(NOW(), INTERVAL {0} DAY) AND 
									r.creation_date > DATE_SUB(NOW(), INTERVAL {1} DAY)
								)
								AND
								(
									rma_notices.last_notice_date IS NULL OR
									rma_notices.last_notice_date <= DATE_SUB(NOW(), INTERVAL {2} DAY)
								)

							GROUP BY r.id ASC

							HAVING received_or_discarded_qty = 0;",
										  daysOlderThan, daysNotOlderThan, excludeNotifiedWithinDays);
					}
					else
					{
						cmd.CommandText =
							string.Format(@"SELECT
								r.id, r.tech_id, r.creation_date,
								a.asset asset_name, a.location asset_location, a.city asset_city, a.state asset_state,
								COUNT(ra.id) assembly_qty,
								SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
								DATEDIFF(NOW(), r.creation_date) days_old,
								DATEDIFF(NOW(), last_notice_date) last_notice_days_ago

							FROM rma r
								LEFT JOIN rma_assemblies ra
									ON (r.id = ra.rma_id)
								LEFT JOIN
									(
										SELECT rnl.rma_id, MAX(rnl.notice_date) last_notice_date
										FROM rma_notice_log rnl
										GROUP BY rnl.rma_id
									) rma_notices
									ON (r.id = rma_notices.rma_id)
								JOIN assets a
									ON (r.asset_id = a.id)

							WHERE r.deleted IS FALSE
								AND r.completed_date IS NULL
								AND
								(
									r.creation_date <= DATE_SUB(NOW(), INTERVAL {0} DAY) AND 
									r.creation_date > DATE_SUB(NOW(), INTERVAL {1} DAY)
								)
								AND
								(
									rma_notices.last_notice_date IS NULL OR
									rma_notices.last_notice_date <= DATE_SUB(NOW(), INTERVAL {2} DAY)
								)
								AND r.flag_apr = true
							GROUP BY r.id ASC

							HAVING received_or_discarded_qty = 0;",
										  daysOlderThan, daysNotOlderThan, excludeNotifiedWithinDays);
					}
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var rma = new UnreceivedRmaData
							          {
								          RmaID = reader.GetDBInt("id"),
										  TechID = reader.GetDBInt("tech_id"),
										  RmaCreated = reader.GetDBDateTime("creation_date"),
										  AssetName = reader.GetDBString("asset_name"),
										  AssetLocation = reader.GetDBString("asset_location"),
										  AssetCity = reader.GetDBString("asset_city"),
								          AssetState = reader.GetDBString("asset_state")
							          };
							unreceivedRmas.Add(rma);
						}
					}
				}
				conn.Close();
			}
			return unreceivedRmas;
		}

		/// <summary>
		/// Retrieves a list of assemblies for specified RMA.
		/// </summary>
		public static IEnumerable<RMAAssemblyLineItem> GetAssemblyList(int rmaID)
		{
			var assemblyList = new List<RMAAssemblyLineItem>();
			using (var conn = CreateConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(ra.id) `Qty`, CONCAT(atype.description, ': ', assy.description) `Assembly`
						FROM rma_assemblies ra
							JOIN assemblies assy
							ON ra.assembly_id = assy.id
							JOIN assembly_types atype
							ON assy.assembly_type = atype.id
						WHERE ra.rma_id = @rma_id;";
					cmd.Parameters.AddWithValue("rma_id", rmaID);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var assembly = new RMAAssemblyLineItem
							{
								Qty = reader.GetDBInt("Qty"),
								Assembly = reader.GetDBString("Assembly")
							};
							assemblyList.Add(assembly);
						}
					}
				}
				conn.Close();
			}
			return assemblyList;
		}

		public static TechData GetTechData(int techID)
		{
			var tech = new TechData();
			using (var conn = CreateConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, tech, email
						FROM techs
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", techID);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.HasRows)
						{
							reader.Read();
							tech = new TechData
								       {
									       ID = reader.GetDBInt("id"),
									       Name = reader.GetDBString("tech"),
									       Email = reader.GetDBString("email")
								       };
						}
					}
				}
				conn.Close();
			}
			return tech;
		}

		/// <summary>
		/// Creates entries in the rma_notice_log for the specified RMAs using current date.
		/// </summary>
		/// <param name="associatedRmas">List of RMAs to create entries for.</param>
		public static void WriteRmaNotifications(IEnumerable<int> associatedRmas)
		{
			using (var conn = CreateConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"INSERT INTO rma_notice_log (rma_id)
						VALUES {0}", string.Format("({0})", String.Join("),(", associatedRmas.ToArray())));
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static MySqlConnection CreateConnection()
		{
			return ClassDatabase.CreateMySqlConnection(
				FormCurator.Settings.SQLServer,
				FormCurator.Settings.SQLDatabase,
				FormCurator.Settings.SQLUser,
				FormCurator.Settings.SQLPassword,
				FormCurator.Settings.SQLTimeout.ToString(CultureInfo.InvariantCulture));
		}
		#endregion
	}
}