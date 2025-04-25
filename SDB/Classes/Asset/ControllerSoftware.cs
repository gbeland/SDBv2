using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public class ControllerSoftware
	{
		private const string _SQL_TABLE_NAME = "asset_controller_sw";
		private const string _SQL_ASSET_TABLE_COL = "controller_sw";

		public int ID { get; set; }
		public string Description { get; set; }
		/// <summary>
		/// Assets using controller software which is Weave-enabled are monitored differently. (PVM checks this value.)
		/// </summary>
		public bool IsWeaveEnabled { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return $"{Description} [{ID}]";
		}

		public static ControllerSoftware GetByID(int? controllerSoftwareID)
		{
			if (!controllerSoftwareID.HasValue)
				return null;

			ControllerSoftware controllerSoftware;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT *
						FROM {_SQL_TABLE_NAME}
						WHERE id = @ControllerSoftwareID;";
					cmd.Parameters.AddWithValue("ControllerSoftwareID", controllerSoftwareID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							controllerSoftware = GetFromReader(reader);
						}
						else
							return null;
				}
				conn.Close();
			}
			return controllerSoftware;
		}

		public static IEnumerable<ControllerSoftware> GetAll()
		{
			var allControllerSoftware = new List<ControllerSoftware>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT *
						FROM {_SQL_TABLE_NAME};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							allControllerSoftware.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return allControllerSoftware;
		}

		public static void AddNew(ref ControllerSoftware controllerSoftware)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"INSERT INTO {_SQL_TABLE_NAME}
							(description, weave_enabled)
						VALUES
							(@description, @isWeaveEnabled)";
					cmd.Parameters.AddWithValue("description", controllerSoftware.Description);
					cmd.Parameters.AddWithValue("isWeaveEnabled", controllerSoftware.IsWeaveEnabled);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					controllerSoftware.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ControllerSoftware controllerSoftware)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"UPDATE {_SQL_TABLE_NAME} SET
							description = @description,
							weave_enabled = @isWeaveEnabled
						WHERE id = @controllerSoftwareId;";
					cmd.Parameters.AddWithValue("controllerSoftwareId", controllerSoftware.ID);
					cmd.Parameters.AddWithValue("description", controllerSoftware.Description);
					cmd.Parameters.AddWithValue("isWeaveEnabled", controllerSoftware.IsWeaveEnabled);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Reports how many times the specified <see cref="ControllerSoftware"/> is used throughout the database.
		/// </summary>
		public static int GetUsedQty(int controllerSoftwareID)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.AddWithValue("ControllerSoftwareID", controllerSoftwareID);

					cmd.CommandText =
						$@"SELECT COUNT(*) qty
						FROM assets
						WHERE {_SQL_ASSET_TABLE_COL} = @ControllerSoftwareID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of <param name="deprecatedID"/> with <param name="replacementID"/> throughout the database.
		/// Removes <paramref name="deprecatedID"/> from the controller software table.
		/// *** It is not necessary to delete the deprecated controller software after calling this method.
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
						$@"UPDATE assets
						SET {_SQL_ASSET_TABLE_COL} = @replacementID
						WHERE {_SQL_ASSET_TABLE_COL} = @deprecatedID;";
					cmd.Parameters.AddWithValue("deprecatedID", deprecatedID);
					cmd.Parameters.AddWithValue("replacementID", replacementID);
					cmd.ExecuteNonQuery();

					// Delete deprecated controller software
					cmd.Parameters.Clear();
					cmd.CommandText =
						$@"DELETE FROM {_SQL_TABLE_NAME}
						WHERE id = @deprecatedID;";
					cmd.Parameters.AddWithValue("deprecatedID", deprecatedID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Delete(int controllerSoftwareID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						$@"DELETE FROM {_SQL_TABLE_NAME}
						WHERE id = @ControllerSoftwareID;";
					cmd.Parameters.AddWithValue("ControllerSoftwareID", controllerSoftwareID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		private static ControllerSoftware GetFromReader(MySqlDataReader reader)
		{
			var controllerSoftware = new ControllerSoftware();
			var id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			controllerSoftware.ID = id.Value;
			controllerSoftware.Description = reader.GetDBString("description");
			controllerSoftware.IsWeaveEnabled = reader.GetDBBool("weave_enabled");
			return controllerSoftware;
		}
	}
}