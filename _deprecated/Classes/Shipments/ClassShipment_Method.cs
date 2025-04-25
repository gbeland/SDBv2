using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Shipments
{
	public class ClassShipment_Method
	{
		public int ID { get; set; }
		public int DisplayIndex { get; set; }
		public string Description { get; set; }
		public bool Default { get; set; }
		public string Abbreviation { get; set; }

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Description, ID);
		}

		public static IEnumerable<ClassShipment_Method> GetAll()
		{
			List<ClassShipment_Method> shipmentMethods = new List<ClassShipment_Method>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = @"SELECT * FROM shipment_methods ORDER BY display_index ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							shipmentMethods.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return shipmentMethods;
		}

		public static ClassShipment_Method GetByID(int? shipmentMethodID)
		{
			if (!shipmentMethodID.HasValue)
				return null;

			ClassShipment_Method shipmentMethod;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM shipment_methods
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", shipmentMethodID.Value);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							shipmentMethod = GetFromReader(reader);
						}
						else
							return null;
				}
				conn.Close();
			}
			return shipmentMethod;
		}

		/// <summary>
		/// Adds a new shipment method to the database.
		/// Automatically assigns a new display index (highest, to appear at end of list).
		/// </summary>
		public static void AddNew(ref ClassShipment_Method newShipmentMethod)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					// Determine highest display index
					cmd.CommandText =
						@"SELECT MAX(display_index)
						FROM shipment_methods;";
					int highestShipmentIndex = Convert.ToInt32(cmd.ExecuteScalar());


					cmd.CommandText =
						@"INSERT INTO shipment_methods
						(display_index, description, abbreviation)
						VALUES
						(@displayIndex, @description, @abbreviation);";
					cmd.Parameters.AddWithValue("displayIndex", ++highestShipmentIndex);
					cmd.Parameters.AddWithValue("description", newShipmentMethod.Description);
					cmd.Parameters.AddWithValue("abbreviation", newShipmentMethod.Abbreviation);

					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					newShipmentMethod.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}

			if (newShipmentMethod.Default)
				SetDefault(newShipmentMethod.ID);
		}

		/// <summary>
		/// Updates specified shipment method, but does not change its display index.
		/// If its <see cref="ClassShipment_Method.Default"/> property is true, all others will be set false.
		/// </summary>
		/// <param name="shipmentMethod"></param>
		public static void Update(ClassShipment_Method shipmentMethod)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipment_methods SET
							description = @description,
							abbreviation = @abbreviation
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", shipmentMethod.ID);
					cmd.Parameters.AddWithValue("description", shipmentMethod.Description);
					cmd.Parameters.AddWithValue("abbreviation", shipmentMethod.Abbreviation);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			if (shipmentMethod.Default)
				SetDefault(shipmentMethod.ID);
		}

		/// <summary>
		/// Sets the specified Shipment Method as the default.
		/// </summary>
		public static void SetDefault(int shipmentMethodID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipment_methods SET
							`default` = FALSE;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE shipment_methods SET
							`default` = TRUE
						WHERE id = @ShipmentMethodID;";
					cmd.Parameters.AddWithValue("ShipmentMethodID", shipmentMethodID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Gets the default shipment method ID or null if none specified.
		/// </summary>
		/// <returns></returns>
		public static int? GetDefaultMethodID()
		{
			int? defaultShipmentMethodID = null;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT `id`
						FROM shipment_methods
						WHERE `default` = 1;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							defaultShipmentMethodID = reader.GetDBInt_Null("id");
						}
				}
				conn.Close();
			}
			return defaultShipmentMethodID;
		}

		/// <summary>
		/// Returns the number of times the specified shipment method is used in the database.
		/// </summary>
		public static int GetUsedQty(int shipmentMethodID)
		{
			int usedQty;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM shipments
						WHERE ship_method = @ShipmentMethodID;";
					cmd.Parameters.AddWithValue("ShipmentMethodID", shipmentMethodID);
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Deletes the specified shipment method.
		/// </summary>
		public static void Delete(int shipmentMethodID)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM shipment_methods
						WHERE id = @ShipmentMethodID;";
					cmd.Parameters.AddWithValue("ShipmentMethodID", shipmentMethodID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Moves the specified shipment method up in the list (decreases its display index).
		/// </summary>
		public static void MoveUp(int shipmentMethodID)
		{
			// Get all shipment methods
			List<ClassShipment_Method> allShipmentMethods = GetAll().ToList();

			// If the specified shipment method is already top display index, do nothing
			ClassShipment_Method promotedShipmentMethod = allShipmentMethods.Single(s => s.ID == shipmentMethodID);
			if (promotedShipmentMethod.DisplayIndex <= 1)
				return;

			// Order by display index and reassign all display indices from 1 to end
			allShipmentMethods = allShipmentMethods.OrderBy(s => s.DisplayIndex).ToList();
			for (int p = 0; p < allShipmentMethods.Count; p++)
				allShipmentMethods[p].DisplayIndex = p + 1;

			// Figure out intended new display index of specified shipment method
			int newDisplayIndex = promotedShipmentMethod.DisplayIndex - 1;

			// Demote shipment methods with this priority
			foreach (ClassShipment_Method s in allShipmentMethods.Where(s => s.DisplayIndex == newDisplayIndex))
				s.DisplayIndex++;

			// Promote shipment method
			promotedShipmentMethod.DisplayIndex--;

			// Update database
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					foreach (ClassShipment_Method sm in allShipmentMethods)
					{
						cmd.Parameters.Clear();
						cmd.CommandText =
							@"UPDATE shipment_methods
							SET display_index = @DisplayIndex
							WHERE id = @ShipmentMethodID;";
						cmd.Parameters.AddWithValue("DisplayIndex", sm.DisplayIndex);
						cmd.Parameters.AddWithValue("ShipmentMethodID", sm.ID);
						cmd.ExecuteNonQuery();
					}
				}
				conn.Close();
			}
		}

		private static ClassShipment_Method GetFromReader(MySqlDataReader reader)
		{
			ClassShipment_Method sm = new ClassShipment_Method();
			int? id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			sm.ID = id.Value;
			sm.DisplayIndex = reader.GetDBInt("display_index");
			sm.Description = reader.GetDBString("description");
			sm.Default = reader.GetDBBool("default");
			sm.Abbreviation = reader.GetDBString("abbreviation");

			return sm;
		}
	}
}