using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
// ReSharper disable RedundantVerbatimStringPrefix

namespace SDB.Classes.Tech
{
    public class ClassTech
    {
        #region Delegates and Events
        #endregion

        #region Enums and Structs
        #endregion

        #region Private Fields
        private string _shippingAddress;
        private string _shippingCity;
        private string _shippingState;
        private string _shippingZip;
        private string _shippingCountry;
        #endregion

        #region Public Properties
        public int ID { get; private set; }

        /// <summary>
        /// tech
        /// </summary>
        public string TechName { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool Shipping_UseMailingAddress { get; set; }

        /// <summary>
        /// The shipping address; if <see cref="Shipping_UseMailingAddress"/> is true, the mailing address.
        /// </summary>
        public string Shipping_Address
        {
            get => Shipping_UseMailingAddress ? Address : _shippingAddress;
            set => _shippingAddress = value;
        }

        /// <summary>
        /// The shipping city; if <see cref="Shipping_UseMailingAddress"/> is true, the mailing city.
        /// </summary>
        public string Shipping_City
        {
            get => Shipping_UseMailingAddress ? City : _shippingCity;
            set => _shippingCity = value;
        }

        /// <summary>
        /// The shipping state; if <see cref="Shipping_UseMailingAddress"/> is true, the mailing state.
        /// </summary>
        public string Shipping_State
        {
            get => Shipping_UseMailingAddress ? State : _shippingState;
            set => _shippingState = value;
        }

        /// <summary>
        /// The shipping zip; if <see cref="Shipping_UseMailingAddress"/> is true, the mailing zip.
        /// </summary>
        public string Shipping_Zip
        {
            get => Shipping_UseMailingAddress ? Zip : _shippingZip;
            set => _shippingZip = value;
        }

        /// <summary>
        /// The shipping country; if <see cref="Shipping_UseMailingAddress"/> is true, the mailing country.
        /// </summary>
        public string Shipping_Country
        {
            get => Shipping_UseMailingAddress ? Country : _shippingCountry;
            set => _shippingCountry = value;
        }

        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// alttech1
        /// </summary>
        public string Contact1_Name { get; set; }

        /// <summary>
        /// alttel1
        /// </summary>
        public string Contact1_Telephone { get; set; }

        /// <summary>
        /// alttech2
        /// </summary>
        public string Contact2_Name { get; set; }

        public string Contact2_Telephone { get; set; }
        public string Contact3_Name { get; set; }
        public string Contact3_Telephone { get; set; }
        public string Notes { get; set; }
        public ClassTech_Status TechStatus { get; set; }
        public float Rate_Normal { get; set; }
        public float Rate_AfterHours { get; set; }
        public float Rate_Emergency { get; set; }

        /// <summary>
        /// Used only in the context of a single asset (not a standard tech property).
        /// </summary>
        public bool Assigned { get; set; }

        /// <summary>
        /// Used only in the context of techs assigned to assets (not a standard tech property).
        /// Defaults to null, but requires a value when used in the database.
        /// </summary>
        public int? Priority { get; set; }

        public override string ToString()
        {
            return string.Format("{0} [{1}]", TechName, ID);
        }

        public string DisplayMemberWithPriority => "[#" + Priority + "] " + TechName;

		[UsedImplicitly]
		public string DisplayMember => TechName;
		#endregion

		#region Constructor
		public ClassTech()
		{
			ID = -1;
			TechName = "** Unknown **";
			Priority = null;
			Shipping_UseMailingAddress = true;
		}
		#endregion

		#region Private Methods
		private static ClassTech GetFromReader(MySqlDataReader reader)
		{
			var techID = reader.GetDBInt_Null("id");
			if (!techID.HasValue)
				return null;

			return new ClassTech
			{
				ID = techID.Value,
				TechName = reader.GetDBString("tech"),
				Address = reader.GetDBString("address"),
				City = reader.GetDBString("city"),
				State = reader.GetDBString("state"),
				Zip = reader.GetDBString("zip"),
				Country = reader.GetDBString("country"),
				Shipping_UseMailingAddress = reader.GetDBBool("shiptomailing"),
				Shipping_Address = reader.GetDBString("shippingaddress"),
				Shipping_City = reader.GetDBString("shippingcity"),
				Shipping_State = reader.GetDBString("shippingstate"),
				Shipping_Zip = reader.GetDBString("shippingzip"),
				Shipping_Country = reader.GetDBString("shippingcountry"),
				Telephone = reader.GetDBString("telno"),
				Fax = reader.GetDBString("faxno"),
				Email = reader.GetDBString("email"),
				Contact1_Name = reader.GetDBString("alttech1"),
				Contact1_Telephone = reader.GetDBString("alttel1"),
				Contact2_Name = reader.GetDBString("alttech2"),
				Contact2_Telephone = reader.GetDBString("alttel2"),
				Contact3_Name = reader.GetDBString("alttech3"),
				Contact3_Telephone = reader.GetDBString("alttel3"),
				Notes = reader.GetDBString("notes"),
				TechStatus = ClassDefinitions.TECH_STATUS_TYPES.FirstOrDefault(d => d.Value == reader.GetDBInt("techstatus")),
				Rate_Normal = reader.GetDBFloat("rate_normal"),
				Rate_AfterHours = reader.GetDBFloat("rate_afterhours"),
				Rate_Emergency = reader.GetDBFloat("rate_emergency")
			};
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Gets all techs.
		/// If <paramref name="techIds"/> is supplied, only that subset of techs is retrieved.
		/// </summary>
		public static IEnumerable<ClassTech> GetAll(List<int> techIds = null)
		{
			var techs = new List<ClassTech>();
			var conditional = techIds != null && techIds.Any() ? $@"WHERE h.id IN ({string.Join(",", techIds.Distinct())})" : string.Empty;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = $@"SELECT h.* FROM techs h {conditional};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							techs.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return techs;
		}

		/// <summary>
		/// Gets all tech names as dictionary indexed by primary key for lists.
		/// If <paramref name="techIds"/> is supplied, only that subset of tech names is retrieved.
		/// </summary>
		public static Dictionary<int, string> GetNames(List<int> techIds = null)
		{
			var techNames = new Dictionary<int, string>();
			var conditional = techIds != null && techIds.Any() ? $@"WHERE h.id IN ({string.Join(",", techIds.Distinct())})" : string.Empty;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT h.id, h.tech
						FROM techs h
						{conditional};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var id = reader.GetDBInt("id");
							var techName = reader.GetDBString("tech");
							techNames.Add(id, techName);
						}
				}

				conn.Close();
			}

			return techNames;
		}

        public static ClassTech GetByName(string name)
        {
            var tech = new ClassTech();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM techs WHERE tech = @TechName;";
                    cmd.Parameters.AddWithValue("TechName", name);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tech = GetFromReader(reader);
                        }
                }
                conn.Close();
            }
            return tech;
        }

		/// <summary>
		/// Gets techs assigned to specified asset. Includes <see cref="Priority"/> for the asset as defined by the asset_techs table.
		/// </summary>
		public static IEnumerable<ClassTech> GetByAsset(int assetID)
		{
			var assetAssignedTechs = new List<ClassTech>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT
							h.*, `at`.priority
						FROM
							techs h
						JOIN asset_techs `at` ON `at`.tech_id = h.id
						WHERE
							`at`.asset_id = @AssetID
						ORDER BY `at`.priority ASC;";
					cmd.Parameters.AddWithValue("AssetID", assetID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var tech = GetFromReader(reader);
							tech.Priority = reader.GetDBInt("priority");
							assetAssignedTechs.Add(tech);
						}
				}
				conn.Close();
			}
			return assetAssignedTechs;
		}

		public static ClassTech GetByID(int? techID)
		{
			if (!techID.HasValue)
				return null;

			var tech = new ClassTech();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT * FROM techs WHERE id = @TechID;";
					cmd.Parameters.AddWithValue("TechID", techID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							tech = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return tech;
		}

		public static string GetName(int? techID)
		{
			if (!techID.HasValue)
				return null;

			var techName = string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT tech FROM techs WHERE id = @techID;";
					cmd.Parameters.AddWithValue("techID", techID);

					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							techName = reader.GetDBString("tech");
				}
				conn.Close();
			}
			return techName;
		}

		/// <summary>
		/// Finds techs having SearchTerm in the Name, Address, City, State, Country, or one of the Technician Contact Names.
		/// </summary>
		public static IEnumerable<ClassTech> Search(string searchTerm)
		{
			var foundTechs = new List<ClassTech>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM techs
						WHERE tech LIKE @SearchTerm
						OR city LIKE @SearchTerm
						OR state LIKE @SearchTerm
						OR country LIKE @SearchTerm
						OR alttech1 LIKE @SearchTerm
						OR alttech2 LIKE @SearchTerm
						OR alttech3 LIKE @SearchTerm
						ORDER BY tech ASC;";
					cmd.Parameters.AddWithValue("SearchTerm", $"%{searchTerm}%");
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							foundTechs.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return foundTechs;
		}

		public static void Update(ClassTech tech)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE techs SET
						tech = @Tech, address = @Address, city = @City, state = @State, zip = @Zip, country = @Country,
						shiptomailing = @Shipping_UseMailingAddress,
						shippingaddress = @Shipping_Address, shippingcity = @Shipping_City, shippingstate = @Shipping_State, shippingzip = @Shipping_Zip, shippingcountry = @Shipping_Country,
						telno = @Telephone, faxno = @Fax, email = @Email,
						alttech1 = @Contact1_Name, alttel1 = @Contact1_Telephone,
						alttech2 = @Contact2_Name, alttel2 = @Contact2_Telephone, 
						alttech3 = @Contact3_Name, alttel3 = @Contact3_Telephone,
						techstatus = @TechStatus,
						rate_normal = @Rate_Normal, rate_afterhours = @Rate_AfterHours, rate_emergency = @Rate_Emergency,
						notes = @Notes
						WHERE id = @TechID;";
					cmd.Parameters.AddWithValue("TechID", tech.ID);
					cmd.Parameters.AddWithValue("Tech", tech.TechName);
					cmd.Parameters.AddWithValue("Address", tech.Address);
					cmd.Parameters.AddWithValue("City", tech.City);
					cmd.Parameters.AddWithValue("State", tech.State);
					cmd.Parameters.AddWithValue("Zip", tech.Zip);
					cmd.Parameters.AddWithValue("Country", tech.Country);
					cmd.Parameters.AddWithValue("Shipping_UseMailingAddress", tech.Shipping_UseMailingAddress);
					cmd.Parameters.AddWithValue("Shipping_Address", tech.Shipping_Address);
					cmd.Parameters.AddWithValue("Shipping_City", tech.Shipping_City);
					cmd.Parameters.AddWithValue("Shipping_State", tech.Shipping_State);
					cmd.Parameters.AddWithValue("Shipping_Zip", tech.Shipping_Zip);
					cmd.Parameters.AddWithValue("Shipping_Country", tech.Shipping_Country);
					cmd.Parameters.AddWithValue("Telephone", tech.Telephone);
					cmd.Parameters.AddWithValue("Fax", tech.Fax);
					cmd.Parameters.AddWithValue("Email", tech.Email);
					cmd.Parameters.AddWithValue("Contact1_Name", tech.Contact1_Name);
					cmd.Parameters.AddWithValue("Contact2_Name", tech.Contact2_Name);
					cmd.Parameters.AddWithValue("Contact3_Name", tech.Contact3_Name);
					cmd.Parameters.AddWithValue("Contact1_Telephone", tech.Contact1_Telephone);
					cmd.Parameters.AddWithValue("Contact2_Telephone", tech.Contact2_Telephone);
					cmd.Parameters.AddWithValue("Contact3_Telephone", tech.Contact3_Telephone);
					cmd.Parameters.AddWithValue("TechStatus", tech.TechStatus.Value);
					cmd.Parameters.AddWithValue("Rate_Normal", tech.Rate_Normal);
					cmd.Parameters.AddWithValue("Rate_AfterHours", tech.Rate_AfterHours);
					cmd.Parameters.AddWithValue("Rate_Emergency", tech.Rate_Emergency);
					cmd.Parameters.AddWithValue("Notes", tech.Notes);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Tech, tech.ID, tech.TechName);
		}

		/// <summary>
		/// Inserts a new tech into the database and populates its ID.
		/// </summary>
		public static void AddNew(ref ClassTech tech)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO techs
							(tech, address, city, state, zip, country,
							shiptomailing,
							shippingaddress, shippingcity, shippingstate, shippingzip, shippingcountry,
							telno, faxno, email,
							alttech1, alttel1,
							alttech2, alttel2,
							alttech3, alttel3,
							techstatus,
							rate_normal, rate_afterhours, rate_emergency,
							notes)
						VALUES
							(@Tech, @Address, @City, @State, @Zip, @Country,
							@Shipping_UseMailingAddress,
							@Shipping_Address, @Shipping_City, @Shipping_State, @Shipping_Zip, @Shipping_Country,
							@Telephone, @Fax, @Email,
							@Contact1_Name, @Contact1_Telephone,
							@Contact2_Name, @Contact2_Telephone, 
							@Contact3_Name, @Contact3_Telephone,
							@TechStatus,
							@Rate_Normal, @Rate_AfterHours, @Rate_Emergency,
							@Notes);";
					cmd.Parameters.AddWithValue("Tech", tech.TechName);
					cmd.Parameters.AddWithValue("Address", tech.Address);
					cmd.Parameters.AddWithValue("City", tech.City);
					cmd.Parameters.AddWithValue("State", tech.State);
					cmd.Parameters.AddWithValue("Zip", tech.Zip);
					cmd.Parameters.AddWithValue("Country", tech.Country);
					cmd.Parameters.AddWithValue("Shipping_UseMailingAddress", tech.Shipping_UseMailingAddress);
					cmd.Parameters.AddWithValue("Shipping_Address", tech.Shipping_Address);
					cmd.Parameters.AddWithValue("Shipping_City", tech.Shipping_City);
					cmd.Parameters.AddWithValue("Shipping_State", tech.Shipping_State);
					cmd.Parameters.AddWithValue("Shipping_Zip", tech.Shipping_Zip);
					cmd.Parameters.AddWithValue("Shipping_Country", tech.Shipping_Country);
					cmd.Parameters.AddWithValue("Telephone", tech.Telephone);
					cmd.Parameters.AddWithValue("Fax", tech.Fax);
					cmd.Parameters.AddWithValue("Email", tech.Email);
					cmd.Parameters.AddWithValue("Contact1_Name", tech.Contact1_Name);
					cmd.Parameters.AddWithValue("Contact2_Name", tech.Contact2_Name);
					cmd.Parameters.AddWithValue("Contact3_Name", tech.Contact3_Name);
					cmd.Parameters.AddWithValue("Contact1_Telephone", tech.Contact1_Telephone);
					cmd.Parameters.AddWithValue("Contact2_Telephone", tech.Contact2_Telephone);
					cmd.Parameters.AddWithValue("Contact3_Telephone", tech.Contact3_Telephone);
					cmd.Parameters.AddWithValue("TechStatus", tech.TechStatus.Value);
					cmd.Parameters.AddWithValue("Rate_Normal", tech.Rate_Normal);
					cmd.Parameters.AddWithValue("Rate_AfterHours", tech.Rate_AfterHours);
					cmd.Parameters.AddWithValue("Rate_Emergency", tech.Rate_Emergency);
					cmd.Parameters.AddWithValue("Notes", tech.Notes);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					tech.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Tech, tech.ID, tech.TechName);
		}

		public static int GetUsedQty(ClassTech tech)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("TechID", tech.ID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM tickets
						WHERE tech_id = @TechID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM shipments
						WHERE tech_id = @TechID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma
						WHERE tech_id = @TechID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		public static void Delete(ClassTech tech)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM techs WHERE id = @TechID;";
					cmd.Parameters.AddWithValue("TechID", tech.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Tech, tech.ID, tech.TechName);
		}
		#endregion
	}
}