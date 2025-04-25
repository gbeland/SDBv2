using System;
using System.Collections.Generic;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public class ClassRMA_RootCause
	{
		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Description, ID);
		}

		public static IEnumerable<ClassRMA_RootCause> GetAll()
		{
			var rmaRootCauses = new List<ClassRMA_RootCause>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, description
						FROM rma_root_causes
						ORDER BY description ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rc = new ClassRMA_RootCause
							         {
								         ID = reader.GetDBInt("id"),
								         Description = reader.GetDBString("description")
							         };
							rmaRootCauses.Add(rc);
						}
				}
				conn.Close();
			}
			return rmaRootCauses;
		}

		public static void AddNew(string description)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rma_root_causes
						(description)
						VALUES
						(@Description);";
					cmd.Parameters.AddWithValue("Description", description);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Update(ClassRMA_RootCause rmaRootCause)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_root_causes
						SET description = @Description
						WHERE id = @ID;";
					cmd.Parameters.AddWithValue("ID", rmaRootCause.ID);
					cmd.Parameters.AddWithValue("Description", rmaRootCause.Description);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Returns how many times specified Root Cause is utilized by the database.
		/// </summary>
		public static int GetUsedQty(int rootCauseID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_assemblies
						WHERE finalize_root_cause = @RootCauseID;";
					cmd.Parameters.AddWithValue("RootCauseID", rootCauseID);

					usedQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedRootCauseID with ReplacementRootCauseID throughout the database.
		/// </summary>
		public static void Merge(int deprecatedRootCauseID, int replacementRootCauseID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_assemblies
						SET finalize_root_cause = @ReplacementRootCauseID
						WHERE finalize_root_cause = @DeprecatedRootCauseID;";
					cmd.Parameters.AddWithValue("DeprecatedRootCauseID", deprecatedRootCauseID);
					cmd.Parameters.AddWithValue("ReplacementRootCauseID", replacementRootCauseID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Removes the specified RMA Root Cause. (Ensure not used with RMA_RootCause_UsedQty first.)
		/// </summary>
		public static void Delete(int deletedRootCauseID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM rma_root_causes
						WHERE id = @DeletedRootCauseID;";
					cmd.Parameters.AddWithValue("DeletedRootCauseID", deletedRootCauseID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}
	}
}