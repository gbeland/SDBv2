using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public class ClassBlackoutScheduleEntry
	{
		private int _id;
		private int _assetId;
		private int _startMinute;
		private int _stopMinute;
		private int _daymask;

		/// <summary>
		/// 7-bit bitmask representing days of the week, Sunday being the most significant bit
		/// A weekend-enabled mask would be: 1000001
		/// A weekday-enabled mask would be: 0111110
		/// Monday, Wednesday, Friday: 0101010
		/// </summary>
		public static readonly Dictionary<string, int> DAY_SHORTCUT = new Dictionary<string, int>
			                                                      {
				                                                      {"Every Day", 127}, // 1111111
				                                                      {"Weekdays", 62}, // 0111110
				                                                      {"Weekends", 65}, // 1000001
				                                                      {"Sunday", 64}, // 1000000
				                                                      {"Monday", 32}, // 0100000
				                                                      {"Tuesday", 16}, // 0010000
				                                                      {"Wednesday", 8}, // 0001000
				                                                      {"Thursday", 4}, // 0000100
				                                                      {"Friday", 2}, // 0000010
				                                                      {"Saturday", 1} // 0000001
			                                                      };

		/// <summary>
		/// Schedule Entries must always have an asset ID.
		/// New entries initially have an ID of -1.
		/// </summary>
		public ClassBlackoutScheduleEntry(int assetID)
		{
			ID = -1;
			AssetID = assetID;
			DayMask = DAY_SHORTCUT["Every Day"];
		}

		public int ID
		{
			get => _id;
			set { _id = value; }
		}

		public int AssetID
		{
			get => _assetId;
			set { _assetId = value; }
		}

		public DateTime StartTime
		{
			get => DateTime.Today.AddMinutes(_startMinute);
			set { _startMinute = (int)value.TimeOfDay.TotalMinutes; }
		}

		public int StartMinute
		{
			get => _startMinute;
			set { _startMinute = value; }
		}

		public DateTime StopTime
		{
			get => DateTime.Today.AddMinutes(_stopMinute);
			set { _stopMinute = (int)value.TimeOfDay.TotalMinutes; }
		}

		public int StopMinute
		{
			get => _stopMinute;
			set { _stopMinute = value; }
		}

		public int DayMask
		{
			get => _daymask;
			set { _daymask = value; }
		}

		public override string ToString()
		{
			return string.Format("[{0}] AssetID {1}; {2:HHmm}-{3:HHmm}; Days {4}", ID, AssetID, StartTime, StopTime, Convert.ToString(DayMask, 2).PadLeft(7, '0'));
		}

		/// <summary>
		/// Not stored in database. Indicates this schedule entry is flagged to be deleted.
		/// </summary>
		public bool DeleteFlag { get; set; }

		/// <summary>
		/// True if the <paramref name="dayOfWeek"/> is among the enabled days in <see cref="DayMask"/>.
		/// </summary>
		public bool IsDayOfWeekInMask(DayOfWeek dayOfWeek)
		{
			return IsDayOfWeekInMask((int)dayOfWeek);
		}

		public bool IsDayOfWeekInMask(int dayOfWeekValue)
		{
			int shift = 6 - dayOfWeekValue;
			return (1 & (_daymask >> shift)) == 1;
		}

		public string DaysAsText()
		{
			if (DayMask == DAY_SHORTCUT["Every Day"])
				return "Every Day";

			if (DayMask == DAY_SHORTCUT["Weekends"])
				return "Weekends";

			if (DayMask == DAY_SHORTCUT["Weekdays"])
				return "Weekdays";

			Dictionary<int, string> days = new Dictionary<int, string>
				                               {
					                               {0, "Sun"},
					                               {1, "Mon"},
					                               {2, "Tue"},
					                               {3, "Wed"},
					                               {4, "Thu"},
					                               {5, "Fri"},
					                               {6, "Sat"}
				                               };

			List<string> selectedDays = days.Where(d => IsDayOfWeekInMask(d.Key)).Select(d => d.Value).ToList();
			return string.Join(", ", selectedDays);
		}

		/// <summary>
		/// Deletes this schedule entry from the database.
		/// </summary>
		public void Delete()
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE
						FROM asset_blackout
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", _id);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public void Update()
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE
						asset_blackout SET
							asset_id = @asset_id,
							start = @start,
							stop = @stop,
							daymask = @daymask
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", _id);
					cmd.Parameters.AddWithValue("asset_id", _assetId);
					cmd.Parameters.AddWithValue("start", _startMinute);
					cmd.Parameters.AddWithValue("stop", _stopMinute);
					cmd.Parameters.AddWithValue("daymask", _daymask);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public void AddNew()
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO 
						asset_blackout
							(asset_id, start, stop, daymask)
						VALUES
							(@asset_id, @start, @stop, @daymask);";
					cmd.Parameters.AddWithValue("asset_id", _assetId);
					cmd.Parameters.AddWithValue("start", _startMinute);
					cmd.Parameters.AddWithValue("stop", _stopMinute);
					cmd.Parameters.AddWithValue("daymask", _daymask);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}
	}
}