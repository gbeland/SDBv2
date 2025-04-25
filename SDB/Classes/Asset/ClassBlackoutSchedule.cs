using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public class ClassBlackoutSchedule
	{
		public const int MAX_ENTRIES = 14;
		public List<ClassBlackoutScheduleEntry> Entries { get; set; }

		public ClassBlackoutSchedule()
		{
			Entries = new List<ClassBlackoutScheduleEntry>();
		}

		public static bool IsBlackedOut(int assetID)
		{
			var entries = new List<ClassBlackoutScheduleEntry>();
			var atTime = DateTime.Now;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM asset_blackout
						WHERE asset_id = @asset_ID
						ORDER BY id ASC;";
					cmd.Parameters.AddWithValue("asset_id", assetID);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.HasRows)
							while (reader.Read())
								entries.Add(GetEntryFromReader(reader));
					}
				}
				conn.Close();
			}

			var minutes = (int)atTime.TimeOfDay.TotalMinutes;
			// StopMinute can be 0 for midnight the following day. To allow this, the following comparison uses 1441 instead of 0 (1 more minute than in a day).
			return entries.Any(e => e.IsDayOfWeekInMask(atTime.DayOfWeek) && e.StartMinute <= minutes && minutes < (e.StopMinute == 0 ? 1441 : e.StopMinute));
		}

		/// <summary>
		/// Get the Blackout Schedule for the asset with ID <paramref name="assetID"/>
		/// </summary>
		public ClassBlackoutSchedule(int assetID)
		{
			Entries = new List<ClassBlackoutScheduleEntry>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM asset_blackout
						WHERE asset_id = @asset_ID
						ORDER BY id ASC;";
					cmd.Parameters.AddWithValue("asset_id", assetID);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.HasRows)
							while (reader.Read())
								Entries.Add(GetEntryFromReader(reader));
					}

				}
				conn.Close();
			}
		}

		/// <summary>
		/// Reports whether the sign is intended to be blacked out during the specified <paramref name="atTime"/>.
		/// </summary>
		public bool IsBlack(DateTime atTime)
		{
			var minutes = (int)atTime.TimeOfDay.TotalMinutes;
			// StopMinute can be 0 for midnight the following day. To allow this, the following comparison uses 1441 instead of 0 (1 more minute than in a day).
			return Entries.Any(e => e.IsDayOfWeekInMask(atTime.DayOfWeek) && e.StartMinute <= minutes && minutes < (e.StopMinute == 0 ? 1441 : e.StopMinute));
		}

		/// <summary>
		/// Reports whether the sign is intended to be blacked out at current time.
		/// </summary>
		public bool IsBlack()
		{
			return IsBlack(DateTime.Now);
		}

		public string ScheduleAsText()
		{
			if (Entries == null || Entries.Count < 1)
				return null;

			var sb = new StringBuilder();

			foreach (var entry in Entries)
				sb.AppendFormat("{0:HHmm}-{1:HHmm} {2}", entry.StartTime, entry.StopTime, entry.DaysAsText()).AppendLine();

			return sb.ToString();
		}

		private static ClassBlackoutScheduleEntry GetEntryFromReader(MySqlDataReader reader)
		{
			return new ClassBlackoutScheduleEntry(reader.GetDBInt("asset_id"))
			{
				ID = reader.GetDBInt("id"),
				DayMask = reader.GetDBInt("daymask"),
				StartMinute = reader.GetDBInt("start"),
				StopMinute = reader.GetDBInt("stop")
			};
		}
	}
}