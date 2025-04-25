using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public class ControllerConnection
	{
		private const string _SQL_TABLE_NAME = "asset_controller_conn";
		private const string _SQL_ASSET_TABLE_COL = "controller_conn";

		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return $"{Description} [{ID}]";
		}

		public static ControllerConnection GetByID(int? controllerConnectionID)
		{
			if (!controllerConnectionID.HasValue)
				return null;

			ControllerConnection controllerConnection;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT *
						FROM {_SQL_TABLE_NAME}
						WHERE id = @ControllerConnectionID;";
					cmd.Parameters.AddWithValue("ControllerConnectionID", controllerConnectionID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							controllerConnection = GetFromReader(reader);
						}
						else
							return null;
				}
				conn.Close();
			}
			return controllerConnection;
		}

		public static IEnumerable<ControllerConnection> GetAll()
		{
			var allControllerConnection = new List<ControllerConnection>();
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
							allControllerConnection.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return allControllerConnection;
		}

		public static void AddNew(ref ControllerConnection controllerConnection)
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
					cmd.Parameters.AddWithValue("description", controllerConnection.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					controllerConnection.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ControllerConnection controllerConnection)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"UPDATE {_SQL_TABLE_NAME} SET
							description = @description
						WHERE id = @ControllerConnectionID;";
					cmd.Parameters.AddWithValue("ControllerConnectionID", controllerConnection.ID);
					cmd.Parameters.AddWithValue("description", controllerConnection.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Reports how many times the specified <see cref="ControllerConnection"/> is used throughout the database.
		/// </summary>
		public static int GetUsedQty(int controllerConnectionID)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.AddWithValue("ControllerConnectionID", controllerConnectionID);

					cmd.CommandText =
						$@"SELECT COUNT(*) qty
						FROM assets
						WHERE {_SQL_ASSET_TABLE_COL} = @ControllerConnectionID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		/// <summary>
		/// Replaces all occurrences of <param name="deprecatedID"/> with <param name="replacementID"/> throughout the database.
		/// Removes <paramref name="deprecatedID"/> from the controller connection table.
		/// *** It is not necessary to delete the deprecated controller connection after calling this method.
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

					// Delete deprecated controller connection
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

		public static void Delete(int controllerConnectionID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						$@"DELETE FROM {_SQL_TABLE_NAME}
						WHERE id = @ControllerConnectionID;";
					cmd.Parameters.AddWithValue("ControllerConnectionID", controllerConnectionID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		private static ControllerConnection GetFromReader(MySqlDataReader reader)
		{
			var controllerConnection = new ControllerConnection();
			var id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			controllerConnection.ID = id.Value;
			controllerConnection.Description = reader.GetDBString("description");
			return controllerConnection;
		}
	}
}