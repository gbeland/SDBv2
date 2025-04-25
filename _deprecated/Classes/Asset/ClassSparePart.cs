using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Assembly;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	/// <summary>
	/// Spare part for asset.
	/// </summary>
	public class ClassSparePart
	{
		private int _quantity;
		private int _expected;

		public int Quantity
		{
			get => _quantity;
			set { _quantity = value < 0 ? 0 : value; }
		}
		public int Expected
		{
			get => _expected;
			set { _expected = value < 1 ? 1 : value; }
		}
		public ClassAssembly Assembly { get; set; }

		/// <summary>
		/// Gets the collection of <see cref="ClassSparePart"/>s associated with specified asset.
		/// </summary>
		public static IEnumerable<ClassSparePart> GetByAsset(int assetID)
		{
			List<ClassSparePart> spareParts = new List<ClassSparePart>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT asp.*,
						y.id assembly_id, y.assembly_type, y.assembly_number, y.description, y.location, y.cost, y.inventory_qty, y.disabled, y.replaced_by
						FROM asset_spare_parts asp
							JOIN assemblies y ON asp.assembly_id = y.id
						WHERE asp.asset_id = @asset_id;";
					cmd.Parameters.AddWithValue("asset_id", assetID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							ClassSparePart sparePart = GetFromReader(reader);
							sparePart.Assembly = new ClassAssembly
								                     {
									                     ID = reader.GetDBInt("assembly_id"),
									                     AssemblyTypeID = reader.GetDBInt("assembly_type"),
									                     AssemblyNumber = reader.GetDBString("assembly_number"),
									                     Description = reader.GetDBString("description"),
									                     Location = reader.GetDBString("location"),
									                     Cost = reader.GetDBDouble_Null("cost"),
									                     InventoryQty = reader.GetDBInt_Null("inventory_qty"),
									                     Disabled = reader.GetDBBool("disabled"),
									                     ReplacedBy = reader.GetDBInt_Null("replaced_by")
								                     };
							spareParts.Add(sparePart);
						}
					}
				}
				conn.Close();
			}
			return spareParts;
		}

		// If needed for spare parts by type -- would require a property for asset associated be added to ClassSparePart
//        /// <summary>
//        /// Gets a collection of <see cref="ClassSparePart"/> of type specified.
//        /// </summary>
//        public static IEnumerable<ClassSparePart> GetByPart(int assemblyID)
//        {
//            List<ClassSparePart> spareParts = new List<ClassSparePart>();
//            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
//            {
//                conn.Open();
//                using (MySqlCommand cmd = conn.CreateCommand())
//                {
//                    cmd.CommandText =
//                        @"SELECT asp.*,
//						y.id assembly_id, y.assembly_type, y.assembly_number, y.description, y.location, y.cost, y.inventory_qty, y.disabled, y.replaced_by
//						FROM asset_spare_parts asp
//						JOIN assemblies y ON asp.assembly_id = y.id
//						WHERE asp.assembly_id = @assembly_id;";
//                    cmd.Parameters.AddWithValue("assembly_id", assemblyID);
//                    using (MySqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            ClassSparePart sparePart = GetFromReader(reader);
//                            sparePart.Assembly = new ClassAssembly
//                                                     {
//                                                         ID = reader.GetDBInt("assembly_id"),
//                                                         AssemblyTypeID = reader.GetDBInt("assembly_type"),
//                                                         AssemblyNumber = reader.GetDBString("assembly_number"),
//                                                         Description = reader.GetDBString("desciption"),
//                                                         Location = reader.GetDBString("location"),
//                                                         Cost = reader.GetDBDouble_Null("cost"),
//                                                         InventoryQty = reader.GetDBInt_Null("inventory_qty"),
//                                                         Disabled = reader.GetDBBool("disabled"),
//                                                         ReplacedBy = reader.GetDBInt_Null("replaced_by")
//                                                     };
//                            spareParts.Add(sparePart);
//                        }
//                    }
//                }
//                conn.Close();
//            }
//            return spareParts;
//        }

		/// <summary>
		/// Adds a <see cref="ClassSparePart"/> to the specified asset.
		/// </summary>
		public static void AddNew(int assetID, ClassSparePart sparePart)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO asset_spare_parts
							(asset_id, assembly_id, current_qty, expected_qty)
							VALUES
							(@asset_id, @assembly_id, @current_qty, @expected_qty);";
					cmd.Parameters.AddWithValue("asset_id", assetID);
					cmd.Parameters.AddWithValue("assembly_id", sparePart.Assembly.ID);
					cmd.Parameters.AddWithValue("current_qty", sparePart.Quantity);
					cmd.Parameters.AddWithValue("expected_qty", sparePart.Expected);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Removes a <see cref="ClassSparePart"/> from the specified asset.
		/// </summary>
		public static void Remove(int assetID, ClassSparePart sparePart)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM asset_spare_parts
						WHERE asset_id = @asset_id
						AND assembly_id = @assembly_id;";
					cmd.Parameters.AddWithValue("asset_id", assetID);
					cmd.Parameters.AddWithValue("assembly_id", sparePart.Assembly.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Updates the quantities of <see cref="ClassSparePart"/> for the specified asset.
		/// Changes the assembly as well if <paramref name="sparePart"/> uses a different Assembly ID.
		/// </summary>
		public static void Update(int assetID, int originalAssemblyID, ClassSparePart sparePart)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE asset_spare_parts
							SET current_qty = @current_qty,
							expected_qty = @expected_qty,
							assembly_id = @new_assembly_id
						WHERE asset_id = @asset_id
						AND assembly_id = @original_assembly_id;";
					cmd.Parameters.AddWithValue("asset_id", assetID);
					cmd.Parameters.AddWithValue("original_assembly_id", originalAssemblyID);
					cmd.Parameters.AddWithValue("current_qty", sparePart.Quantity);
					cmd.Parameters.AddWithValue("expected_qty", sparePart.Expected);
					cmd.Parameters.AddWithValue("new_assembly_id", sparePart.Assembly.ID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static ClassSparePart GetFromReader(MySqlDataReader reader)
		{
			return new ClassSparePart
			{
				Quantity = reader.GetDBInt("current_qty"),
				Expected = reader.GetDBInt("expected_qty")
			};
		}
	}
}