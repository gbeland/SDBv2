using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.Classes.Assembly
{
	/// <summary>
	/// A category of assemblies, for selecting a nonspecific assembly or for grouping assemblies.
	/// </summary>
	public class ClassAssemblyType
	{
		public int ID { get; set; }
		public int CategoryID { get; set; }
		public string Description { get; set; }
		public bool IsComputer { get; set; }
		public bool AllowDiscard { get; set; }
		public string SerialNumberFormat { get; set; }
		public string CustomsDescription { get; set; }
		public string TariffCode { get; set; }

        public bool NeedsPrep { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Description, ID);
		}

		public static IEnumerable<ClassAssemblyType> GetAll()
		{
			var assyTypes = new List<ClassAssemblyType>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM assembly_types
						ORDER BY description ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assyTypes.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return assyTypes;
		}

		/// <summary>
		/// Gets assembly types that belong to the specified category, or all assemblies if not specified.
		/// </summary>
		public static IEnumerable<ClassAssemblyType> GetByCategory(ClassAssemblyCategory assemblyCategory = null)
		{
			var assyTypes = new List<ClassAssemblyType>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT *
						FROM assembly_types
						{0}
						ORDER BY description ASC;",
						assemblyCategory != null ? @"WHERE category_id = @CategoryID" : string.Empty);
					if (assemblyCategory != null)
						cmd.Parameters.AddWithValue("CategoryID", assemblyCategory.ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assyTypes.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return assyTypes;
		}

		public static ClassAssemblyType GetByID(int assemblyTypeID)
		{
			var assyType = new ClassAssemblyType();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM assembly_types
						WHERE id = @AssemblyTypeID;";
					cmd.Parameters.AddWithValue("AssemblyTypeID", assemblyTypeID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							assyType = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return assyType;
		}

		private static ClassAssemblyType GetFromReader(MySqlDataReader reader)
		{
			return new ClassAssemblyType
					   {
						   ID = reader.GetDBInt("id"),
						   CategoryID = reader.GetDBInt("category_id"),
						   Description = reader.GetDBString("description"),
						   IsComputer = reader.GetDBBool("is_computer"),
						   AllowDiscard = reader.GetDBBool("allow_discard"),
						   SerialNumberFormat = reader.GetDBString("serial_number_format"),
						   CustomsDescription = reader.GetDBString("customs_description"),
						   TariffCode = reader.GetDBString("tariff_code"),
                           NeedsPrep = reader.GetDBBool("need_prep")
					   };
		}

		/// <summary>
		/// Returns how many times specified assembly_type is utilized by the database.
		/// (In Assemblies, Shipment Inventory, Ticket Assembly Types, and RMA Assemblies)
		/// </summary>
		public static int GetUsedQty(int assemblyTypeID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("AssemblyTypeID", assemblyTypeID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM assemblies
						WHERE assembly_type = @AssemblyTypeID;";
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM shipment_inventory
						WHERE assembly_type_id = @AssemblyTypeID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_assemblies
						WHERE assembly_type = @AssemblyTypeID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Updates the specified AssemblyType.
		/// Call <see cref="ClassRMA.ValidateComputerAssemblyTypes"/> after this!
		/// </summary>
		public static void Update(ClassAssemblyType assemblyType)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
                        @"UPDATE assembly_types SET
							category_id = @CategoryID,
							description = @Description,
							is_computer = @IsComputer,
							allow_discard = @AllowDiscard,
							serial_number_format = @SerialNumberFormat,
							customs_description = @CustomsDescription,
							tariff_code = @TariffCode,
                            need_prep = @need_prep
						WHERE id = @AssemblyTypeID;";
					cmd.Parameters.AddWithValue("AssemblyTypeID", assemblyType.ID);
					cmd.Parameters.AddWithValue("CategoryID", assemblyType.CategoryID);
					cmd.Parameters.AddWithValue("Description", assemblyType.Description);
					cmd.Parameters.AddWithValue("IsComputer", assemblyType.IsComputer);
					cmd.Parameters.AddWithValue("AllowDiscard", assemblyType.AllowDiscard);
					cmd.Parameters.AddWithValue("SerialNumberFormat", assemblyType.SerialNumberFormat);
					cmd.Parameters.AddWithValue("CustomsDescription", assemblyType.CustomsDescription);
					cmd.Parameters.AddWithValue("TariffCode", assemblyType.TariffCode);
                    cmd.Parameters.AddWithValue("need_prep", assemblyType.NeedsPrep);
                    cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.AssemblyType, assemblyType.ID, assemblyType.Description);
		}

		public static void AddNew(ref ClassAssemblyType assemblyType)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
                        @"INSERT INTO assembly_types
						(category_id, description, is_computer, allow_discard, serial_number_format, customs_description, tariff_code, need_prep)
						VALUES
						(@CategoryID, @Description, @IsComputer, @AllowDiscard, @SerialNumberFormat, @CustomsDescription, @TariffCode, @need_prep);";
					cmd.Parameters.AddWithValue("CategoryID", assemblyType.CategoryID);
					cmd.Parameters.AddWithValue("Description", assemblyType.Description);
					cmd.Parameters.AddWithValue("IsComputer", assemblyType.IsComputer);
					cmd.Parameters.AddWithValue("AllowDiscard", assemblyType.AllowDiscard);
					cmd.Parameters.AddWithValue("SerialNumberFormat", assemblyType.SerialNumberFormat);
					cmd.Parameters.AddWithValue("CustomsDescription", assemblyType.CustomsDescription);
					cmd.Parameters.AddWithValue("TariffCode", assemblyType.TariffCode);
                    cmd.Parameters.AddWithValue("need_prep", assemblyType.NeedsPrep);
                    cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					assemblyType.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.AssemblyType, assemblyType.ID, assemblyType.Description);
		}

		/// <summary>
		/// Permanently deletes specified assembly type from the database.
		/// Use AssemblyType_UsedQty() first to determine if it is used somewhere first.
		/// </summary>
		public static void Delete(ClassAssemblyType assemblyType)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM assembly_types WHERE id = @AssemblyTypeID;";
					cmd.Parameters.AddWithValue("AssemblyTypeID", assemblyType.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.AssemblyType, assemblyType.ID, assemblyType.Description);
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedAssemblyTypeID with ReplacementAssemblyTypeID throughout the database.
		/// (In Assemblies, Shipment Inventory, Ticket Assembly Types, and RMA Assemblies)
		/// </summary>
		public static void Merge(int deprecatedAssemblyTypeID, int replacementAssemblyTypeID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Move assemblies from the old assembly type to the new
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE assemblies
						SET assembly_type = @ReplacementAssemblyTypeID
						WHERE assembly_type = @DeprecatedAssemblyTypeID;";
					cmd.Parameters.AddWithValue("DeprecatedAssemblyTypeID", deprecatedAssemblyTypeID);
					cmd.Parameters.AddWithValue("ReplacementAssemblyTypeID", replacementAssemblyTypeID);
					cmd.ExecuteNonQuery();


					// The shipment_inventory table can have multiple line items of the same assembly type.
					// Therefore if the replaced part is already on a shipment, it will have a duplicate
					// line item. Each line item may belong to different signs though, so we cannot simply
					// increment an existing line item quantity without first checking additional columns.
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE shipment_inventory
						SET assembly_type_id = @ReplacementAssemblyTypeID
						WHERE assembly_type_id = @DeprecatedAssemblyTypeID;";
					cmd.Parameters.AddWithValue("DeprecatedAssemblyTypeID", deprecatedAssemblyTypeID);
					cmd.Parameters.AddWithValue("ReplacementAssemblyTypeID", replacementAssemblyTypeID);
					cmd.ExecuteNonQuery();


					// rma_assemblies work just like assemblies (except they're assigned to an RMA) so changing the parent type ID
					// doesn't have any index conflicts.
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE rma_assemblies
						SET assembly_type = @ReplacementAssemblyTypeID
						WHERE assembly_type = @DeprecatedAssemblyTypeID;";
					cmd.Parameters.AddWithValue("DeprecatedAssemblyTypeID", deprecatedAssemblyTypeID);
					cmd.Parameters.AddWithValue("ReplacementAssemblyTypeID", replacementAssemblyTypeID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Verifies if a serial number string matches the assembly type's specified serial number format.
		/// If the assembly type serial number format is blank, any string will pass.
		/// </summary>
		public bool ValidateSerialNumber(string serialNumber)
		{
			if (string.IsNullOrEmpty(SerialNumberFormat))
				return true;

			try
			{
				var r = new Regex(@"^" + SerialNumberFormat + @"$");
				return r.IsMatch(serialNumber);
			}
			catch
			{
				return false;
			}
		}
	}
}