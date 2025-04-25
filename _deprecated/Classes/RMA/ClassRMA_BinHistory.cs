using System;
using System.Collections.Generic;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public class ClassRMA_BinHistory
	{
		public int BinID { get; set; }
		public int UserID { get; private set; }
		public BinEventType EventType { get; private set; }
		public string Location { get; private set; }
		public DateTime HistoryDate { get; private set; }
		public string AssemblySerialNumber { get; private set; }

		public enum BinEventType
		{
			Created,
			Moved,
			Deleted,
			AddAssembly,
			RemoveAssembly
		};

		public static IEnumerable<ClassRMA_BinHistory> GetHistoryForBin(int binID)
		{
			var history = new List<ClassRMA_BinHistory>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rma_bin_history
						WHERE bin_id = @binID
						ORDER BY `datetime` ASC;";
					cmd.Parameters.AddWithValue("binID", binID);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							history.Add(
								new ClassRMA_BinHistory
									{
										BinID = reader.GetDBInt("bin_id"),
										UserID = reader.GetDBInt("user_id"),
										EventType = reader.GetDBString("event_type").ToEnum<BinEventType>(),
										Location = reader.GetDBString("rma_area_zone_name"),
										HistoryDate = reader.GetDBDateTime("datetime"),
										AssemblySerialNumber = reader.GetDBString_Null("assy_sn")
									}
								);
						}
					}
				}
				conn.Close();
			}
			return history;
		}
	}
}