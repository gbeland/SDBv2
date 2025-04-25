using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public class ClassRMA_Zone
	{
		public const string RMA_ZONE_LABEL_DOCUMENT = "RMA Zone Label.btw";

		private static readonly Regex _zoneIDRegex = new Regex("^Z(?<zoneID>[0-9]{1,6})$");

		public int ID { get; set; }
		public string ZoneName { get; set; }
		public int Area_ID { get; set; }
		public bool IsDefault { get; set; }

		[UsedImplicitly]
		public string DisplayMember => ZoneName;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", ZoneName, ID);
		}

		/// <summary>
		/// Provides the integer value of a zone ID string (Z00001).
		/// Does not validate that the zone exists.
		/// </summary>
		public static int GetIDFromString(string zoneIDString)
		{
			var match = _zoneIDRegex.Match(zoneIDString);
			return match.Success ? int.Parse(match.Result("${zoneID}")) : 0;
		}

		/// <summary>
		/// Retrieves an RMA Zone specified by its ID.
		/// </summary>
		public static ClassRMA_Zone GetByID(int? zoneID)
		{
			if (zoneID == null)
				return null;

			ClassRMA_Zone rmaZone = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, zone, area_id, is_default
						FROM rma_zones
						WHERE id = @zoneID;";
					cmd.Parameters.AddWithValue("zoneID", zoneID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
						{
							rmaZone = new ClassRMA_Zone
							          {
								          ID = reader.GetDBInt("id"),
								          ZoneName = reader.GetDBString("zone"),
								          Area_ID = reader.GetDBInt("area_id"),
								          IsDefault = reader.GetDBBool("is_default")
							          };
						}
				}
				conn.Close();
			}
			return rmaZone;
		}

		/// <summary>
		/// Returns the name for both area and zone for specified zone.
		/// Example: "INVENTORY-R1A1"
		/// </summary>
		public string AreaAndZoneName()
		{
			var z = GetByID(ID);
			var a = ClassRMA_Area.GetByID(z.Area_ID);
			return $"{a.AreaName}-{z.ZoneName}";
		}

		/// <summary>
		/// Gets a list of all RMA Zones for specified area.
		/// </summary>
		public static List<ClassRMA_Zone> GetByArea(int areaID)
		{
			var rmaZones = new List<ClassRMA_Zone>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, zone, area_id, is_default
						FROM rma_zones
						WHERE area_id = @areaID
						ORDER BY zone ASC;";
					cmd.Parameters.AddWithValue("areaID", areaID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rz = new ClassRMA_Zone();
							rz.ID = reader.GetDBInt("id");
							rz.ZoneName = reader.GetDBString("zone");
							rz.Area_ID = reader.GetDBInt("area_id");
							rz.IsDefault = reader.GetDBBool("is_default");
							rmaZones.Add(rz);
						}
				}
				conn.Close();
			}
			return rmaZones;
		}

		/// <summary>
		/// Gets the RMA Zone that is set to default (for new bin creation). Null if none defined.
		/// </summary>
		public static ClassRMA_Zone GetDefault()
		{
			ClassRMA_Zone defaultZone = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, zone, area_id, is_default
						FROM rma_zones
						WHERE `is_default` IS TRUE;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							defaultZone = new ClassRMA_Zone();
							defaultZone.ID = reader.GetDBInt("id");
							defaultZone.ZoneName = reader.GetDBString("zone");
							defaultZone.Area_ID = reader.GetDBInt("area_id");
							defaultZone.IsDefault = reader.GetDBBool("is_default");
						}
				}
				conn.Close();
			}
			return defaultZone;
		}

		/// <summary>
		/// Gets a list of all RMA Zones from the database.
		/// </summary>
		public static IEnumerable<ClassRMA_Zone> GetAll()
		{
			var rmaZones = new List<ClassRMA_Zone>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, zone, area_id, is_default
						FROM rma_zones
						ORDER BY zone ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rz = new ClassRMA_Zone
							         {
								         ID = reader.GetDBInt("id"),
								         ZoneName = reader.GetDBString("zone"),
								         Area_ID = reader.GetDBInt("area_id"),
								         IsDefault = reader.GetDBBool("is_default")
							         };
							rmaZones.Add(rz);
						}
				}
				conn.Close();
			}
			return rmaZones;
		}

		/// <summary>
		/// Adds a new RMA zone to the database.
		/// </summary>
		public static void AddNew(string zone, int areaID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rma_zones
						(zone, area_id)
						VALUES
						(@Zone, @areaID);";
					cmd.Parameters.AddWithValue("areaID", areaID);
					cmd.Parameters.AddWithValue("Zone", zone.ToUpper());
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Changes the zone name for specified rma zone.
		/// </summary>
		public static void Update(ClassRMA_Zone rmaZone)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_zones
							SET zone = @Zone,
							area_id = @areaID
						WHERE id = @ID;";
					cmd.Parameters.AddWithValue("ID", rmaZone.ID);
					cmd.Parameters.AddWithValue("areaID", rmaZone.Area_ID);
					cmd.Parameters.AddWithValue("Zone", rmaZone.ZoneName.ToUpper());
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Sets the specified RMA Zone as the default for new bins.
		/// </summary>
		public static void SetDefault(int zoneID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_zones SET
							`is_default` = FALSE;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE rma_zones SET
							`is_default` = TRUE
						WHERE id = @zoneID;";
					cmd.Parameters.AddWithValue("zoneID", zoneID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Returns how many times specified RMA Zone is utilized by the database.
		/// </summary>
		public static int GetUsedQty(int zoneID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("ZoneID", zoneID);
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_assemblies
						WHERE receive_zone = @ZoneID;";
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_bins
						WHERE zone_id = @ZoneID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedZoneID with ReplacementZoneID throughout the database.
		/// </summary>
		public static void Merge(int deprecatedZoneID, int replacementZoneID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_assemblies
						SET receive_zone = @ReplacementZoneID
						WHERE receive_zone = @DeprecatedZoneID;";
					cmd.Parameters.AddWithValue("DeprecatedZoneID", deprecatedZoneID);
					cmd.Parameters.AddWithValue("ReplacementZoneID", replacementZoneID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Removes the specified RMA Zone. (Ensure not used with <see cref="GetUsedQty"/> first.)
		/// </summary>
		public static void Delete(int deletedZoneID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM rma_zones
						WHERE id = @DeletedZoneID;";
					cmd.Parameters.AddWithValue("DeletedZoneID", deletedZoneID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Checks if supplied zone name is valid.
		/// </summary>
		public static bool ValidateZoneName(string zoneName)
		{
			var match = _zoneIDRegex.Match(zoneName);
			return match.Success;
		}

	}
}