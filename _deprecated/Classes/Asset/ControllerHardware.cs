using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public class ControllerHardware
	{
		private const string _SQL_TABLE_NAME  = "asset_controller_hw";
		private const string _SQL_ASSET_TABLE_COL = "controller_hw";

		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return $"{Description} [{ID}]";
		}

		public static ControllerHardware GetByID(int? controllerHardwareID)
		{
			if (!controllerHardwareID.HasValue)
				return null;

			ControllerHardware controllerHardware;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT *
						FROM {_SQL_TABLE_NAME}
						WHERE id = @ControllerHardwareID;";
					cmd.Parameters.AddWithValue("ControllerHardwareID", controllerHardwareID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							controllerHardware = GetFromReader(reader);
						}
						else
							return null;
				}
				conn.Close();
			}
			return controllerHardware;
		}

		public static IEnumerable<ControllerHardware> GetAll()
		{
			var allControllerHardware = new List<ControllerHardware>();
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
							allControllerHardware.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return allControllerHardware;
		}

		public static void AddNew(ref ControllerHardware controllerHardware)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"INSERT INTO {_SQL_TABLE_NAME}
							(description)
						VALUES
							(@description)";
					cmd.Parameters.AddWithValue("description", controllerHardware.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					controllerHardware.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ControllerHardware controllerHardware)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"UPDATE {_SQL_TABLE_NAME} SET
							description = @description
						WHERE id = @ControllerHardwareID;";
					cmd.Parameters.AddWithValue("ControllerHardwareID", controllerHardware.ID);
					cmd.Parameters.AddWithValue("description", controllerHardware.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Reports how many times the specified <see cref="ControllerHardware"/> is used throughout the database.
		/// </summary>
		public static int GetUsedQty(int controllerHardwareID)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.AddWithValue("ControllerHardwareID", controllerHardwareID);

					cmd.CommandText =
						$@"SELECT COUNT(*) qty
						FROM assets
						WHERE {_SQL_ASSET_TABLE_COL} = @ControllerHardwareID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of <param name="deprecatedID"/> with <param name="replacementID"/> throughout the database.
		/// Removes <paramref name="deprecatedID"/> from the controller hardware table.
		/// *** It is not necessary to delete the deprecated controller hardware after calling this method.
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

					// Delete deprecated controller hardware
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

		public static void Delete(int controllerHardwareID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						$@"DELETE FROM {_SQL_TABLE_NAME}
						WHERE id = @ControllerHardwareID;";
					cmd.Parameters.AddWithValue("ControllerHardwareID", controllerHardwareID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		private static ControllerHardware GetFromReader(MySqlDataReader reader)
		{
			var controllerHardware = new ControllerHardware();
			var id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			controllerHardware.ID = id.Value;
			controllerHardware.Description = reader.GetDBString("description");
			return controllerHardware;
		}
	}
}