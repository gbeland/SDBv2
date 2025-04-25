using System.Collections.Generic;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	/// <summary>
	/// A <see cref="ClassComponent"/> but with additional properties for RMA repair purposes.
	/// </summary>
	public class ClassRMA_Component
	{
		public const int MAX_SILKSCREEN_ID_LENGTH = 8;

		public int ID { get; private set; }
		public int RMAAssemblyID { get; private set; }
		public ClassComponent Component { get; set; }
		public string SilkscreenID { get; set; }

		/// <summary>
		/// Quantity is not used in the DB; only for adding multiple of the same component at once. (FormRMA_Component_Select)
		/// </summary>
		public int Quantity { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Component.Description;

		/// <summary>
		/// Gets all components used on all assemblies for the specified RMA.
		/// </summary>
		public static IEnumerable<ClassRMA_Component> GetComponentsByRma(int rmaID)
		{
			var rmaComponents = new List<ClassRMA_Component>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT
								c.id component_id, c.component_number, c.description, c.location, c.cost, c.inventory_qty, c.disabled,
								rac.id, rac.rma_assembly_id, rac.silkscreen_id
							FROM rma_assembly_components rac
								JOIN rma_assemblies ra ON ra.id = rac.rma_assembly_id
								JOIN components c on rac.component_id = c.id
							WHERE ra.rma_id = @rmaID;";
					cmd.Parameters.AddWithValue("rmaID", rmaID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rc = new ClassRMA_Component
								         {
									         ID = reader.GetDBInt("id"),
									         SilkscreenID = reader.GetDBString("silkscreen_id"),
									         RMAAssemblyID = reader.GetDBInt("rma_assembly_id"),
									         Component = new ClassComponent
										                     {
											                     ID = reader.GetDBInt("component_id"),
											                     ComponentNumber = reader.GetDBString("component_number"),
											                     Description = reader.GetDBString("description"),
											                     Location = reader.GetDBString("location"),
											                     Cost = reader.GetDBDouble_Null("cost"),
											                     InventoryQty = reader.GetDBInt_Null("inventory_qty"),
											                     Disabled = reader.GetDBBool("disabled")
										                     }
								         };
							rmaComponents.Add(rc);
						}
				}
				conn.Close();
			}
			return rmaComponents;
		}

		/// <summary>
		/// Gets all components used on specified RMA assembly.
		/// </summary>
		public static IEnumerable<ClassRMA_Component> GetComponentsByAssembly(int rmaAssemblyID)
		{
			var rmaAssemblyComponents = new List<ClassRMA_Component>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT c.id component_id, c.component_number, c.description, c.location, c.cost, c.inventory_qty, c.disabled,
								rac.id, rac.rma_assembly_id, rac.silkscreen_id
							FROM rma_assembly_components rac
								JOIN components c ON rac.component_id = c.id
							WHERE rac.rma_assembly_id = @rmaAssemblyID;";
					cmd.Parameters.AddWithValue("rmaAssemblyID", rmaAssemblyID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rc = new ClassRMA_Component
								         {
									         ID = reader.GetDBInt("id"),
									         SilkscreenID = reader.GetDBString("silkscreen_id"),
									         RMAAssemblyID = reader.GetDBInt("rma_assembly_id"),
									         Component = new ClassComponent
										                     {
											                     ID = reader.GetDBInt("component_id"),
											                     ComponentNumber = reader.GetDBString("component_number"),
											                     Description = reader.GetDBString("description"),
											                     Location = reader.GetDBString("location"),
											                     Cost = reader.GetDBDouble_Null("cost"),
											                     InventoryQty = reader.GetDBInt_Null("inventory_qty"),
											                     Disabled = reader.GetDBBool("disabled")
										                     }
								         };
							rmaAssemblyComponents.Add(rc);
						}
				}
				conn.Close();
			}
			return rmaAssemblyComponents;
		}
	}
}