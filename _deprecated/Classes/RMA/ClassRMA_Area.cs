using System;
using System.Collections.Generic;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public class ClassRMA_Area
	{
		public int ID { get; set; }
		public string AreaName { get; set; }

		[UsedImplicitly]
		public string DisplayMember => AreaName;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", AreaName, ID);
		}

		/// <summary>
		/// Retrieves an RMA Area specified by its ID.
		/// </summary>
		public static ClassRMA_Area GetByID(int areaID)
		{
			var rmaArea = new ClassRMA_Area();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, area
						FROM rma_areas
						WHERE id = @areaID;";
					cmd.Parameters.AddWithValue("areaID", areaID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
						{
							rmaArea.ID = reader.GetDBInt("id");
							rmaArea.AreaName = reader.GetDBString("area");
						}
				}
				conn.Close();
			}
			return rmaArea;
		}

		/// <summary>
		/// Gets a list of all RMA Zones from the database.
		/// </summary>
		public static IEnumerable<ClassRMA_Area> GetAll()
		{
			var rmaAreas = new List<ClassRMA_Area>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, area
						FROM rma_areas
						ORDER BY area ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var area = new ClassRMA_Area();
							area.ID = reader.GetDBInt("id");
							area.AreaName = reader.GetDBString("area");
							rmaAreas.Add(area);
						}
				}
				conn.Close();
			}
			return rmaAreas;
		}

		/// <summary>
		/// Adds a new RMA area to the database.
		/// </summary>
		public static void AddNew(string areaName)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rma_areas
						(area)
						VALUES
						(@areaName);";
					cmd.Parameters.AddWithValue("areaName", areaName.ToUpper());
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Changes the zone name for specified rma zone.
		/// </summary>
		public static void Update(ClassRMA_Area rmaArea)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_areas
							SET area = @areaName,
						WHERE id = @ID;";
					cmd.Parameters.AddWithValue("ID", rmaArea.ID);
					cmd.Parameters.AddWithValue("areaName", rmaArea.AreaName.ToUpper());
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Returns how many times specified RMA Area is utilized by the database.
		/// </summary>
		static public int GetUsedQty(int areaID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_zones
						WHERE area_id = @areaID;";
					cmd.Parameters.AddWithValue("areaID", areaID);

					usedQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedAreaID with ReplacementAreaID throughout the database.
		/// </summary>
		public static void Merge(int deprecatedAreaID, int replacementAreaID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_zones
						SET area_id = @ReplacementAreaID
						WHERE area_id = @DeprecatedAreaID;";
					cmd.Parameters.AddWithValue("DeprecatedAreaID", deprecatedAreaID);
					cmd.Parameters.AddWithValue("ReplacementAreaID", replacementAreaID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Removes the specified RMA Area. (Ensure not used with <see cref="GetUsedQty"/> first.)
		/// </summary>
		public static void Delete(int deletedAreaID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM rma_areas
						WHERE id = @DeletedAreaID;";
					cmd.Parameters.AddWithValue("DeletedAreaID", deletedAreaID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}
	}
}
