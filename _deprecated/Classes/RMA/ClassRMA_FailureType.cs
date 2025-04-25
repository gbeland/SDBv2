using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public class ClassRMA_FailureType
	{
		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Description, ID);
		}

		public static IEnumerable<ClassRMA_FailureType> GetAll()
		{
			List<ClassRMA_FailureType> rmaFailureTypes = new List<ClassRMA_FailureType>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT id, description
						FROM rma_failure_types
						ORDER BY description ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							ClassRMA_FailureType ft = new ClassRMA_FailureType();
							ft.ID = reader.GetDBInt("id");
							ft.Description = reader.GetDBString("description");
							rmaFailureTypes.Add(ft);
						}
					conn.Close();
				}
			}
			return rmaFailureTypes;
		}

		public static void AddNew(string description)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"INSERT INTO rma_failure_types
						(description)
						VALUES
						(@Description);";
					cmd.Parameters.AddWithValue("Description", description);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		public static void Update(ClassRMA_FailureType rmaFailureType)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"UPDATE rma_failure_types
						SET description = @Description
						WHERE id = @ID;";
					cmd.Parameters.AddWithValue("ID", rmaFailureType.ID);
					cmd.Parameters.AddWithValue("Description", rmaFailureType.Description);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		/// <summary>
		/// Returns how many times specified failure type is utilized by the database.
		/// </summary>
		static public int GetUsedQty(int failureTypeID)
		{
			int usedQty;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_assemblies
						WHERE failure_type = @FailureTypeID;";
					cmd.Parameters.AddWithValue("FailureTypeID", failureTypeID);

					usedQty = Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedFailureTypeID with ReplacementFailureTypeID throughout the database.
		/// </summary>
		public static void Merge(int deprecatedFailureTypeID, int replacementFailureTypeID)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();

					cmd.CommandText =
						@"UPDATE rma_assemblies
						SET failure_type = @ReplacementFailureTypeID
						WHERE failure_type = @DeprecatedFailureTypeID;";
					cmd.Parameters.AddWithValue("DeprecatedFailureTypeID", deprecatedFailureTypeID);
					cmd.Parameters.AddWithValue("ReplacementFailureTypeID", replacementFailureTypeID);
					cmd.ExecuteNonQuery();

					conn.Close();
				}
			}
		}

		/// <summary>
		/// Removes the specified RMA failure type. (Ensure not used with RMA_FailureType_UsedQty first.)
		/// </summary>
		public static void Delete(int deletedFailureTypeID)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();

					cmd.CommandText =
						@"DELETE FROM rma_failure_types
						WHERE id = @DeletedFailureTypeID;";
					cmd.Parameters.AddWithValue("DeletedFailureTypeID", deletedFailureTypeID);
					cmd.ExecuteNonQuery();

					conn.Close();
				}
			}
		}
	}
}