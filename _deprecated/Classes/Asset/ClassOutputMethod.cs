using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public class ClassOutputMethod
	{
		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return $"{Description} [{ID}]";
		}

		public static ClassOutputMethod GetByID(int? outputMethodID)
		{
			if (!outputMethodID.HasValue)
				return null;

			ClassOutputMethod outputMethod;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM output_methods
						WHERE id = @OutputMethodID;";
					cmd.Parameters.AddWithValue("OutputMethodID", outputMethodID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							outputMethod = GetFromReader(reader);
						}
						else
							return null;
				}
				conn.Close();
			}
			return outputMethod;
		}

		public static IEnumerable<ClassOutputMethod> GetAll()
		{
			var allOutputMethods = new List<ClassOutputMethod>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM output_methods;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							allOutputMethods.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return allOutputMethods;
		}

		public static void AddNew(ref ClassOutputMethod outputMethod)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO output_methods
							(description)
						VALUES
							(@description)";
					cmd.Parameters.AddWithValue("description", outputMethod.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					outputMethod.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ClassOutputMethod outputMethod)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE output_methods SET
							description = @description
						WHERE id = @OutputMethodID;";
					cmd.Parameters.AddWithValue("OutputMethodID", outputMethod.ID);
					cmd.Parameters.AddWithValue("description", outputMethod.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Reports how many times the specified <see cref="ClassOutputMethod"/> is used throughout the database.
		/// </summary>
		public static int GetUsedQty(int outputMethodID)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.AddWithValue("OutputMethodID", outputMethodID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM assets
						WHERE output_method = @OutputMethodID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of <param name="deprecatedID"/> with <param name="replacementID"/> throughout the database.
		/// Removes <paramref name="deprecatedID"/> from the output methods table.
		/// *** It is not necessary to delete the deprecated output method after calling this method.
		/// </summary>
		public static void Merge(int deprecatedID, int replacementID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Update Assets
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE assets
						SET output_method = @replacementID
						WHERE output_method = @deprecatedID;";
					cmd.Parameters.AddWithValue("deprecatedID", deprecatedID);
					cmd.Parameters.AddWithValue("replacementID", replacementID);
					cmd.ExecuteNonQuery();

					// Delete deprecated output method
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"DELETE FROM output_methods
						WHERE id = @deprecatedID;";
					cmd.Parameters.AddWithValue("deprecatedID", deprecatedID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Delete(int outputMethodID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"DELETE FROM output_methods
						WHERE id = @OutputMethodID;";
					cmd.Parameters.AddWithValue("OutputMethodID", outputMethodID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		private static ClassOutputMethod GetFromReader(MySqlDataReader reader)
		{
			var outputMethod = new ClassOutputMethod();
			var id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			outputMethod.ID = id.Value;
			outputMethod.Description = reader.GetDBString("description");
			return outputMethod;
		}
	}
}