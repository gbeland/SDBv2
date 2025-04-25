using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public class ClassRMA_RepairType
	{
		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Description, ID);
		}

		public static IEnumerable<ClassRMA_RepairType> GetAll()
		{
			List<ClassRMA_RepairType> rmaRepairTypes = new List<ClassRMA_RepairType>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT id, description
						FROM rma_repair_types
						ORDER BY description ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							ClassRMA_RepairType rt = new ClassRMA_RepairType();
							rt.ID = reader.GetDBInt("id");
							rt.Description = reader.GetDBString("description");
							rmaRepairTypes.Add(rt);
						}
					conn.Close();
				}
			}
			return rmaRepairTypes;
		}

		public static void AddNew(string description)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"INSERT INTO rma_repair_types
						(description)
						VALUES
						(@Description);";
					cmd.Parameters.AddWithValue("Description", description);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		public static void Update(ClassRMA_RepairType rmaRepairType)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"UPDATE rma_repair_types
						SET description = @Description
						WHERE id = @ID;";
					cmd.Parameters.AddWithValue("ID", rmaRepairType.ID);
					cmd.Parameters.AddWithValue("Description", rmaRepairType.Description);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		/// <summary>
		/// Returns how many times specified Repair Type is utilized by the database.
		/// </summary>
		static public int GetUsedQty(int repairTypeID)
		{
			int usedQty;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_assembly_repairs
						WHERE rma_repair_type = @RepairTypeID;";
					cmd.Parameters.AddWithValue("RepairTypeID", repairTypeID);

					usedQty = Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedRepairTypeID with ReplacementRepairTypeID throughout the database.
		/// </summary>
		public static void Merge(int deprecatedRepairTypeID, int replacementRepairTypeID)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();

					cmd.CommandText =
						@"UPDATE rma_assembly_repairs
						SET rma_repair_type = @ReplacementRepairTypeID
						WHERE rma_repair_type = @DeprecatedRepairTypeID;";
					cmd.Parameters.AddWithValue("DeprecatedRepairTypeID", deprecatedRepairTypeID);
					cmd.Parameters.AddWithValue("ReplacementRepairTypeID", replacementRepairTypeID);
					cmd.ExecuteNonQuery();

					conn.Close();
				}
			}
		}

		/// <summary>
		/// Removes the specified RMA Repair Type. (Ensure not used with RMA_RepairType_UsedQty first.)
		/// </summary>
		public static void Delete(int deletedRepairTypeID)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();

					cmd.CommandText =
						@"DELETE FROM rma_repair_types
						WHERE id = @DeletedRepairTypeID;";
					cmd.Parameters.AddWithValue("DeletedRepairTypeID", deletedRepairTypeID);
					cmd.ExecuteNonQuery();

					conn.Close();
				}
			}
		}
	}
}