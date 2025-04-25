using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	/// <summary>
	/// A discrete electronic component, used in RMA assembly repairs.
	/// </summary>
	public class ClassComponent
	{
		public int ID { get; set; }
		public string ComponentNumber { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public double? Cost { get; set; }
		public int? InventoryQty { get; set; }

		/// <summary>
		/// Indicates that the component is disabled for use (but not deleted for report purposes).
		/// </summary>
		public bool Disabled { get; set; }

		[UsedImplicitly]
		public string DisplayMember => string.Format("{0}  {1}", ComponentNumber.PadRight(32, ' '), Description);

		public override string ToString()
		{
			return string.Format("{0} {1} [{2}]", ComponentNumber, Description, ID);
		}

		/// <summary>
		/// Gets all components in the database.
		/// </summary>
		public static IEnumerable<ClassComponent> GetAll()
		{
			var components = new List<ClassComponent>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT c.id, c.component_number, c.description, c.location, c.cost, c.inventory_qty, c.disabled
						FROM components c;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var component = GetFromReader(reader);
							if (component == null)
								continue;
							components.Add(component);
						}
					conn.Close();
				}
			}
			return components;
		}

		public static ClassComponent GetByID(int componentID)
		{
			var component = new ClassComponent();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM components
						WHERE id = @ComponentID;";
					cmd.Parameters.AddWithValue("ComponentID", componentID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							component = GetFromReader(reader);
				}
				conn.Close();
			}
			return component;
		}

		private static ClassComponent GetFromReader(MySqlDataReader reader)
		{
			var component = new ClassComponent();
			int? id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			component.ID = id.Value;
			component.ComponentNumber = reader.GetDBString("component_number");
			component.Description = reader.GetDBString("description");
			component.Location = reader.GetDBString("location");
			component.Cost = reader.GetDBFloat_Null("cost");
			component.InventoryQty = reader.GetDBInt_Null("inventory_qty");
			component.Disabled = reader.GetDBBool("disabled");
			return component;
		}

		public static int GetUsedQty(int componentID)
		{
			int usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("ComponentID", componentID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_assembly_components
						WHERE component_id = @ComponentID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		public static void Update(ClassComponent component)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE components
						SET component_number = @ComponentNumber,
						description = @Description,
						location = @Location,
						cost = @Cost,
						inventory_qty = @InventoryQty
						WHERE id = @ComponentID;";
					cmd.Parameters.AddWithValue("ComponentID", component.ID);
					cmd.Parameters.AddWithValue("ComponentNumber", component.ComponentNumber);
					cmd.Parameters.AddWithValue("Description", component.Description);
					cmd.Parameters.AddWithValue("Location", component.Location);
					cmd.Parameters.AddWithValue("Cost", component.Cost);
					cmd.Parameters.AddWithValue("InventoryQty", component.InventoryQty);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Component, component.ID, component.Description);
		}

		public static void AddNew(ref ClassComponent component)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO components
						(component_number, description, location, cost, inventory_qty)
						VALUES
						(@ComponentNumber, @Description, @Location, @Cost, @InventoryQty);";
					cmd.Parameters.AddWithValue("ComponentNumber", component.ComponentNumber);
					cmd.Parameters.AddWithValue("Description", component.Description);
					cmd.Parameters.AddWithValue("Location", component.Location);
					cmd.Parameters.AddWithValue("Cost", component.Cost);
					cmd.Parameters.AddWithValue("InventoryQty", component.InventoryQty);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					component.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Component, component.ID, component.Description);
		}

		/// <summary>
		/// Permanently deletes specified component from the database.
		/// Use Component_UsedQty() first to determine if it is used somewhere first.
		/// </summary>
		public static void Delete(ClassComponent component)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM components WHERE id = @ComponentID;";
					cmd.Parameters.AddWithValue("ComponentID", component.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Component, component.ID, component.Description);
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedComponentID with ReplacementComponentID throughout the database.
		/// (In rma_assembly_components)
		/// </summary>
		public static void Merge(int deprecatedComponentID, int replacementComponentID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("DeprecatedComponentID", deprecatedComponentID);
					cmd.Parameters.AddWithValue("ReplacementComponentID", replacementComponentID);

					cmd.CommandText =
						@"UPDATE rma_assembly_components
						SET component_id = @ReplacementComponentID
						WHERE component_id = @DeprecatedComponentID;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Disables (or enables) a component. If disabled, it is not selectable for RMAs but is retained for reporting, history, etc.
		/// </summary>
		public static void Disable(int componentID, bool disable)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE components
						SET disabled = @Disabled
						WHERE id = @ComponentID;";
					cmd.Parameters.AddWithValue("Disabled", disable);
					cmd.Parameters.AddWithValue("ComponentID", componentID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}
	}
}