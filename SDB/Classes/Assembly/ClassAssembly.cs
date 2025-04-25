using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Assembly
{
	/// <summary>
	/// A specific assembly including part/assembly number.
	/// </summary>
	public class ClassAssembly
	{
		public int ID { get; set; }
		public int AssemblyTypeID { get; set; }
		public string AssemblyNumber { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public double? Cost { get; set; }
		public int? InventoryQty { get; set; }

        public bool ThirdParty { get; set; }

		/// <summary>
		/// Indicates that the assembly is disabled for use (but not deleted for report purposes).
		/// </summary>
		public bool Disabled { get; set; }

		/// <summary>
		/// Assembly ID that replaces this assembly (if applicable).
		/// </summary>
		public int? ReplacedBy { get; set; }

		[UsedImplicitly]
		public string DisplayMember => string.Format("{0} {1}", AssemblyNumber.PadRight(32, ' '), Description);

		public override string ToString()
		{
			return string.Format("{0} {1} [{2}]", AssemblyNumber, Description, ID);
		}

		public static ClassAssembly GetByID(int assemblyID)
		{
			var assembly = new ClassAssembly();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM assemblies
						WHERE id = @AssemblyID;";
					cmd.Parameters.AddWithValue("AssemblyID", assemblyID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							assembly = GetAssemblyFromReader(reader);
						}
				}
				conn.Close();
			}
			return assembly;
		}

		/// <summary>
		/// Gets assemblies that belong to the specified assembly type, or all assemblies if not specified.
		/// </summary>
		public static IEnumerable<ClassAssembly> GetByType(ClassAssemblyType assemblyType = null)
		{
			var assemblies = new List<ClassAssembly>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT *
						FROM assemblies
						{0}
						ORDER BY description ASC;",
						assemblyType != null ? @"WHERE assembly_type = @AssemblyTypeID" : string.Empty);
					if (assemblyType != null)
						cmd.Parameters.AddWithValue("AssemblyTypeID", assemblyType.ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assemblies.Add(GetAssemblyFromReader(reader));
				}
				conn.Close();
			}
			return assemblies;
		}

		/// <summary>
		/// Gets assemblies that belong to the specified assembly type ID.
		/// </summary>
		public static IEnumerable<ClassAssembly> GetAssemblies(int assemblyTypeID)
		{
			var assemblies = new List<ClassAssembly>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM assemblies
						WHERE assembly_type = @AssemblyTypeID
						ORDER BY description ASC;";
					cmd.Parameters.AddWithValue("AssemblyTypeID", assemblyTypeID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assemblies.Add(GetAssemblyFromReader(reader));
				}
				conn.Close();
			}
			return assemblies;
		}

		private static ClassAssembly GetAssemblyFromReader(MySqlDataReader reader)
		{
			return new ClassAssembly
					   {
						   ID = reader.GetDBInt("id"),
						   AssemblyTypeID = reader.GetDBInt("assembly_type"),
						   AssemblyNumber = reader.GetDBString("assembly_number"),
						   Description = reader.GetDBString("description"),
						   Location = reader.GetDBString("location"),
						   Cost = reader.GetDBFloat_Null("cost"),
						   InventoryQty = reader.GetDBInt_Null("inventory_qty"),
						   Disabled = reader.GetDBBool("disabled"),
						   ReplacedBy = reader.GetDBInt_Null("replaced_by"),
                           ThirdParty = reader.GetDBBool("is_third_party")
                           
					   };
		}

		/// <summary>
		/// Returns how many times the specified assembly is utilized by the database.
		/// </summary>
		public static int GetUsedQty(int assemblyID)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("AssemblyID", assemblyID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_assemblies
						WHERE assembly_id = @AssemblyID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM shipment_inventory
						WHERE assembly_id = @AssemblyID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM asset_spare_parts
						WHERE assembly_id = @AssemblyID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		public static void Update(ClassAssembly assembly)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
                        @"UPDATE assemblies
						SET assembly_type = @AssemblyType,
						assembly_number = @AssemblyNumber,
						description = @Description,
						location = @Location,
						cost = @Cost,
						inventory_qty = @InventoryQty,
						disabled = @Disabled,
						replaced_by = @ReplacedBy,
                        is_third_party = @is_third_party 
						WHERE id = @AssemblyID;";
					cmd.Parameters.AddWithValue("AssemblyID", assembly.ID);
					cmd.Parameters.AddWithValue("AssemblyType", assembly.AssemblyTypeID);
					cmd.Parameters.AddWithValue("AssemblyNumber", assembly.AssemblyNumber);
					cmd.Parameters.AddWithValue("Description", assembly.Description);
					cmd.Parameters.AddWithValue("Location", assembly.Location);
					cmd.Parameters.AddWithValue("Cost", assembly.Cost);
					cmd.Parameters.AddWithValue("InventoryQty", assembly.InventoryQty);
					cmd.Parameters.AddWithValue("Disabled", assembly.Disabled);
					cmd.Parameters.AddWithValue("ReplacedBy", assembly.ReplacedBy);
                    cmd.Parameters.AddWithValue("is_third_party", assembly.ThirdParty);
                    cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Assembly, assembly.ID, assembly.Description);
		}

		public static void AddNew(ref ClassAssembly assembly)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
                        @"INSERT INTO assemblies
						(assembly_type, assembly_number, description, location, cost, inventory_qty, is_third_party)
						VALUES
						(@AssemblyType, @AssemblyNumber, @Description, @Location, @Cost, @InventoryQty, @is_third_party);";
					cmd.Parameters.AddWithValue("AssemblyType", assembly.AssemblyTypeID);
					cmd.Parameters.AddWithValue("AssemblyNumber", assembly.AssemblyNumber);
					cmd.Parameters.AddWithValue("Description", assembly.Description);
					cmd.Parameters.AddWithValue("Location", assembly.Location);
					cmd.Parameters.AddWithValue("Cost", assembly.Cost);
					cmd.Parameters.AddWithValue("InventoryQty", assembly.InventoryQty);
                    cmd.Parameters.AddWithValue("is_third_party", assembly.ThirdParty);
                    cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					assembly.ID = Convert.ToInt32(cmd.ExecuteScalar());

				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Assembly, assembly.ID, assembly.Description);
		}

		/// <summary>
		/// Permanently deletes specified assembly from the database.
		/// Use Assembly_UsedQty() first to determine if it is used somewhere first.
		/// </summary>
		public static void Delete(ClassAssembly assembly)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM assemblies WHERE id = @AssemblyID;";
					cmd.Parameters.AddWithValue("AssemblyID", assembly.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Assembly, assembly.ID, assembly.Description);
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedAssemblyID with ReplacementAssemblyID throughout the database.
		/// (In RMA Assemblies)
		/// </summary>
		public static void Merge(ClassAssembly deprecatedAssembly, ClassAssembly replacementAssembly)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("DeprecatedAssemblyID", deprecatedAssembly.ID);
					cmd.Parameters.AddWithValue("ReplacementAssemblyID", replacementAssembly.ID);

					cmd.CommandText =
						@"UPDATE rma_assemblies
						SET assembly_id = @ReplacementAssemblyID
						WHERE assembly_id = @DeprecatedAssemblyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE shipment_inventory
						SET assembly_id = @ReplacementAssemblyID
						WHERE assembly_id = @DeprecatedAssemblyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE asset_spare_parts
						SET assembly_id = @ReplacementAssemblyID
						WHERE assembly_id = @DeprecatedAssemblyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE camera_types
						SET assembly_id = @ReplacementAssemblyID
						WHERE assembly_id = @DeprecatedAssemblyID;";
					cmd.ExecuteNonQuery();

				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Assembly, deprecatedAssembly.ID, string.Format("Merged '{0}' into '{1}'.", deprecatedAssembly.Description, replacementAssembly.Description));
		}

		/// <summary>
		/// Disables (or enables) an assembly. If disabled, it is not selectable for new shipments/tickets/RMAs but is retained for reporting, history, etc.
		/// </summary>
		public static void Disable(ClassAssembly assembly, bool disable)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"UPDATE assemblies
						SET disabled = @Disabled
						WHERE id = @AssemblyID;";
					cmd.Parameters.AddWithValue("Disabled", disable);
					cmd.Parameters.AddWithValue("AssemblyID", assembly.ID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Assembly, assembly.ID, (disable ? "Disabled " : "Enabled ") + assembly.Description);
		}

		/// <summary>
		/// Given an assembly, will return the most current replacement by traversing assemblies until one is found that is not disabled and does not have a replacement ID.
		/// If an assembly is found that is not disabled or does not have a replacement ID, that assembly is returned.
		/// </summary>
		public static ClassAssembly FindCurrentReplacement(ClassAssembly deprecatedAssembly)
		{
			if (!deprecatedAssembly.Disabled)
				return deprecatedAssembly;

			if (!deprecatedAssembly.ReplacedBy.HasValue)
				return deprecatedAssembly;

			return FindCurrentReplacement(GetByID(deprecatedAssembly.ReplacedBy.Value));
		}
	}
}