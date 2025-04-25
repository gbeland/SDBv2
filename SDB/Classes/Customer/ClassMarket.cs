using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.Interfaces;

namespace SDB.Classes.Customer
{
	public class ClassMarket : IExportableToCsv
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		private static readonly string[] _marketDBFields = {
			                                                   "customer_id", "designation",
			                                                   "name", "address", "city", "state", "zip", "country",
			                                                   "telephone",
			                                                   "c1_name", "c2_name", "c3_name",
			                                                   "c1_position", "c2_position", "c3_position",
			                                                   "c1_number", "c2_number", "c3_number",
			                                                   "email", "automated_email", "send_open", "send_close", "send_techonsite", "notes"
		                                                   };

		public int ID { get; set; }
		public int CustomerID { get; set; }
		#endregion

		#region Public Properties
		/// <summary>
		/// Prefix is ID to the GUI
		/// </summary>
		public string Prefix { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Telephone { get; set; }
		public string Notes { get; set; }
		public string Contact1_Name { get; set; }
		public string Contact2_Name { get; set; }
		public string Contact3_Name { get; set; }
		public string Contact1_Position { get; set; }
		public string Contact2_Position { get; set; }
		public string Contact3_Position { get; set; }
		public string Contact1_Number { get; set; }
		public string Contact2_Number { get; set; }
		public string Contact3_Number { get; set; }
		public string Email_Addresses { get; set; }
		public string Automated_Email_List { get; set; }
		public bool SendEmail_Open { get; set; }
		public bool SendEmail_Close { get; set; }
		public bool SendEmail_TechOnSite { get; set; }
		public bool SendEmail_RmaCreated { get; set; }
		public int? SalespersonID { get; set; }

		// Extra properties outside of market table
		/// <summary>
		/// Optional for certain views (must join customers table to populate)
		/// </summary>
		public string CustomerPrefix { get; set; }

		/// <summary>
		/// Optional for certain views (must join customers table to populate)
		/// </summary>
		public string CustomerName { get; set; }
		public bool CustomerIsFrozen { get; set; }
		public int AssetQty { get; set; }
		public string CustomerPrefixAndName => $"{CustomerPrefix} {Name}";
		public string DisplayMember => $"{Name} [{Prefix}] ({AssetQty} asset{(AssetQty == 1 ? string.Empty : "s")})";
		public string NameWithCustomerName => $"{Name} ({CustomerName})";
		public Color StatusColor => CustomerIsFrozen ? Color.Red : SystemColors.ControlText;
		#endregion

		#region Constructor
		public ClassMarket()
		{
			ID = -1;
			CustomerID = -1;
			Prefix = string.Empty;
			Name = string.Empty;
			Address = string.Empty;
			City = string.Empty;
			State = string.Empty;
			Zip = string.Empty;
			Notes = string.Empty;
			Contact1_Name = string.Empty;
			Contact2_Name = string.Empty;
			Contact3_Name = string.Empty;
			Contact1_Position = string.Empty;
			Contact2_Position = string.Empty;
			Contact3_Position = string.Empty;
			Contact1_Number = string.Empty;
			Contact2_Number = string.Empty;
			Contact3_Number = string.Empty;
			Email_Addresses = string.Empty;
			Automated_Email_List = string.Empty;
			SendEmail_Open = true;
			SendEmail_Close = true;
			SendEmail_TechOnSite = true;
			SendEmail_RmaCreated = true;
			SalespersonID = null;
		}
		#endregion

		#region Private Methods
		private static ClassMarket GetFromReader(MySqlDataReader reader)
		{
			var marketID = reader.GetDBInt_Null("id");
			if (!marketID.HasValue)
				return null;

			return new ClassMarket
			       {
				       ID = marketID.Value,
				       CustomerID = reader.GetDBInt("customer_id"),
				       Prefix = reader.GetDBString("designation"),
				       Name = reader.GetDBString("name"),
				       Address = reader.GetDBString("address"),
				       City = reader.GetDBString("city"),
				       State = reader.GetDBString("state"),
				       Zip = reader.GetDBString("zip"),
				       Country = reader.GetDBString("country"),
				       Telephone = reader.GetDBString("telephone"),
				       Notes = reader.GetDBString("notes"),
				       Contact1_Name = reader.GetDBString("c1_name"),
				       Contact2_Name = reader.GetDBString("c2_name"),
				       Contact3_Name = reader.GetDBString("c3_name"),
				       Contact1_Position = reader.GetDBString("c1_position"),
				       Contact2_Position = reader.GetDBString("c2_position"),
				       Contact3_Position = reader.GetDBString("c3_position"),
				       Contact1_Number = reader.GetDBString("c1_number"),
				       Contact2_Number = reader.GetDBString("c2_number"),
				       Contact3_Number = reader.GetDBString("c3_number"),
				       SendEmail_Open = reader.GetDBBool("send_open"),
				       SendEmail_Close = reader.GetDBBool("send_close"),
				       SendEmail_TechOnSite = reader.GetDBBool("send_techonsite"),
				       SendEmail_RmaCreated = reader.GetDBBool("send_rma"),
				       Email_Addresses = reader.GetDBString("email"),
				       Automated_Email_List = reader.GetDBString("automated_email"),
				       SalespersonID = reader.GetDBInt("salesperson_id")
			       };
		}
		#endregion

		#region Public Methods
		public override string ToString()
		{
			return $"[{Prefix}] {Name} [{ID}]";
		}

		public string GetCombinedEmailList()
		{
			if (Email_Addresses == string.Empty && Automated_Email_List == string.Empty)
				return string.Empty;

			if (Email_Addresses == string.Empty)
				return Automated_Email_List;

			if (Automated_Email_List == string.Empty)
				return Email_Addresses;

			return Email_Addresses + ", " + Automated_Email_List;
		}

		public static ClassMarket GetByID(int marketID)
		{
			var market = new ClassMarket();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT m.*, c.name customer_name, c.prefix customer_prefix
						FROM markets m
							JOIN customers c ON m.customer_id = c.id
						WHERE m.id = @MarketID
						AND m.customer_id = c.id;";
					cmd.Parameters.AddWithValue("MarketID", marketID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							market = GetFromReader(reader);
							market.CustomerPrefix = reader.GetDBString("customer_prefix");
							market.CustomerName = reader.GetDBString("customer_name");
						}
				}
				conn.Close();
			}
			return market;
		}

		/// <summary>
		/// Gets all markets, parent company names, and number of assets managed.
		/// </summary>
		/// <param name="pageOffset">Which page of results to return. Null for no paging.</param>
		/// <param name="maxResults">Maximum number of results to return.</param>
		/// <param name="totalQty">Total number of assets.</param>
		public static List<ClassMarket> GetAll(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = 0;
			var markets = new List<ClassMarket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(m.id) qty
						FROM markets m;";
					totalQty = Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						$@"SELECT m.*,
						c.name customer_name, c.prefix customer_prefix, c.frozen_flag customer_is_frozen
						FROM markets m
							JOIN customers c ON m.customer_id = c.id
						WHERE m.customer_id = c.id
						ORDER BY m.name ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var market = GetFromReader(reader);
							market.CustomerPrefix = reader.GetDBString("customer_prefix");
							market.CustomerName = reader.GetDBString("customer_name");
							market.CustomerIsFrozen = reader.GetDBBool("customer_is_frozen");
							markets.Add(market);
						}
				}

				// Get asset quantities
				var marketAssetQty = new Dictionary<int, int>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT market_id, COUNT(id) AS qty
						FROM assets
						GROUP BY market_id;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							marketAssetQty.Add(reader.GetDBInt("market_id"), reader.GetDBInt("qty"));
				}

				// Populate asset quantities
				foreach (var market in markets.Where(m => marketAssetQty.ContainsKey(m.ID)))
					market.AssetQty = marketAssetQty[market.ID];

				conn.Close();
			}
			return markets;
		}

        public static bool AdvancedEmailOptions_Enabled(int marketID)
        {
            ClassMarket m = new ClassMarket();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT m.*
						FROM markets m
						WHERE m.adv_email_options = 1 && m.id = @marketID
						ORDER BY m.name ASC;";
                    cmd.Parameters.AddWithValue("marketID", marketID);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            m = GetFromReader(reader);
                        }
                }
                conn.Close();
            }
            if (m.ID != -1)
                return true;
            else return false;
        }

        public static void SetAdvancedEmailOptions(int marketID, bool enable)
        {
            
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText =
                        @"Update markets m
						SET adv_email_options = @adv_email_options
						WHERE m.id = @marketID
						ORDER BY m.name ASC;";
                    cmd.Parameters.AddWithValue("marketID", marketID);
                    cmd.Parameters.AddWithValue("adv_email_options", enable);
                    cmd.ExecuteReader();
                    
                }
                conn.Close();
            }
        }

        public static void UpsertMarketAdvEmails(int market_id, int symptom_id, bool enabled)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT s.*
						FROM market_email_symptoms s
						WHERE s.market_id = @marketID && s.symptom_id = @symptom_id;";
                    cmd.Parameters.AddWithValue("marketID", market_id);
                    cmd.Parameters.AddWithValue("symptom_id", symptom_id);

                    var i = cmd.ExecuteScalar();
                    if(i != null)
                    {
                        //update
                        cmd.Parameters.Clear();
                        cmd.CommandText =
                         @"Update market_email_symptoms m
						SET enabled = @enabled
						WHERE m.market_id = @marketID && m.symptom_id = @symptom_id;";
                        cmd.Parameters.AddWithValue("marketID", market_id);
                        cmd.Parameters.AddWithValue("symptom_id", symptom_id);
                        cmd.Parameters.AddWithValue("enabled", enabled);
                        cmd.ExecuteReader();
                    }
                    else
                    {
                        //insert
                        cmd.Parameters.Clear();
                        cmd.CommandText =
                         @"INSERT INTO market_email_symptoms
						(market_id, symptom_id, enabled)
                        VALUES (@market_id, @symptom_id, @enabled);";
                        cmd.Parameters.AddWithValue("market_id", market_id);
                        cmd.Parameters.AddWithValue("symptom_id", symptom_id);
                        cmd.Parameters.AddWithValue("enabled", enabled);
                        cmd.ExecuteReader();
                    }

                }
                conn.Close();
            }


        }

        public static bool EmailForSymptom(int marketID, int symptomID)
        {
            bool enabled = false;
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT s.*
						FROM market_email_symptoms s
						WHERE s.market_id = @marketID && enabled = 1 && s.symptom_id = @symptom_id;";
                    cmd.Parameters.AddWithValue("marketID", marketID);
                    cmd.Parameters.AddWithValue("symptom_id", symptomID);
                    var i = cmd.ExecuteScalar();
                    if (i != null)
                        enabled = true;
                }
                conn.Close();
            }
            return enabled;
        }

        public static List<ClassTicket_Symptom> GetEmailSymptoms(int marketID)
        {
            List<ClassTicket_Symptom> list = ClassTicket_Symptom.GetAll().ToList();

            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT s.*
						FROM market_email_symptoms s
						WHERE s.market_id = @marketID && enabled = 1;";
                    cmd.Parameters.AddWithValue("marketID", marketID);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            int i = reader.GetDBInt("symptom_id");
                            foreach (ClassTicket_Symptom s in list)
                            {
                                if (i == s.ID)
                                    s.Selected = true;
                            }
                        }
                }
                conn.Close();
            }
            return list;
        }

		/// <summary>
		/// Gets markets for the specified customer ID.
		/// </summary>
		public static List<ClassMarket> GetByCustomer(int customerID)
		{
			var customerMarkets = new List<ClassMarket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT m.*, c.name customer_name, c.prefix customer_prefix
						FROM markets m
							JOIN customers c ON m.customer_id = c.id
						WHERE m.customer_id = @CustomerID
						ORDER BY m.name ASC;";
					cmd.Parameters.AddWithValue("CustomerID", customerID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var m = GetFromReader(reader);
							m.CustomerName = reader.GetDBString("customer_name");
							m.CustomerPrefix = reader.GetDBString("customer_prefix");
							customerMarkets.Add(m);
						}
				}
				conn.Close();
			}
			return customerMarkets;
		}

		/// <summary>
		/// Gets the parent market ID of the specified asset.
		/// </summary>
		public static int GetMarketIDByAsset(int assetID)
		{
			var marketID = -1;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT market_id
						FROM assets
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", assetID);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							marketID = reader.GetDBInt("market_id");
				}
				conn.Close();
			}
			return marketID;
		}

		/// <summary>
		/// Gets all market names as dictionary indexed by primary key for lists.
		/// If <paramref name="marketIds"/> is supplied, only that subset of market names is retrieved.
		/// </summary>
		public static Dictionary<int, string> GetNames(List<int> marketIds = null)
		{
			var marketNames = new Dictionary<int, string>();
			var conditional = marketIds != null && marketIds.Any() ? $@"WHERE m.id IN ({string.Join(",", marketIds.Distinct())})" : string.Empty;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT m.id, m.name
						FROM markets m
						{conditional};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var id = reader.GetDBInt("id");
							var marketName = reader.GetDBString("name");
							marketNames.Add(id, marketName);
						}
				}

				conn.Close();
			}

			return marketNames;
		}
		
		/// <summary>
		/// Inserts a new <see cref="ClassMarket"/> into the database and populates its ID.
		/// </summary>
		public static void AddNew(ref ClassMarket market)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"INSERT INTO markets
							({0})
						VALUES
							(@{1});", string.Join(", ", _marketDBFields), string.Join(", @", _marketDBFields));
					cmd.Parameters.AddWithValue("customer_id", market.CustomerID);
					cmd.Parameters.AddWithValue("designation", market.Prefix);
					cmd.Parameters.AddWithValue("name", market.Name);
					cmd.Parameters.AddWithValue("address", market.Address);
					cmd.Parameters.AddWithValue("city", market.City);
					cmd.Parameters.AddWithValue("state", market.State);
					cmd.Parameters.AddWithValue("zip", market.Zip);
					cmd.Parameters.AddWithValue("country", market.Country);
					cmd.Parameters.AddWithValue("telephone", market.Telephone);
					cmd.Parameters.AddWithValue("c1_name", market.Contact1_Name);
					cmd.Parameters.AddWithValue("c2_name", market.Contact2_Name);
					cmd.Parameters.AddWithValue("c3_name", market.Contact3_Name);
					cmd.Parameters.AddWithValue("c1_position", market.Contact1_Position);
					cmd.Parameters.AddWithValue("c2_position", market.Contact2_Position);
					cmd.Parameters.AddWithValue("c3_position", market.Contact3_Position);
					cmd.Parameters.AddWithValue("c1_number", market.Contact1_Number);
					cmd.Parameters.AddWithValue("c2_number", market.Contact2_Number);
					cmd.Parameters.AddWithValue("c3_number", market.Contact3_Number);
					cmd.Parameters.AddWithValue("email", market.Email_Addresses);
					cmd.Parameters.AddWithValue("automated_email", market.Automated_Email_List);
					cmd.Parameters.AddWithValue("send_open", market.SendEmail_Open);
					cmd.Parameters.AddWithValue("send_close", market.SendEmail_Close);
					cmd.Parameters.AddWithValue("send_techonsite", market.SendEmail_TechOnSite);
					cmd.Parameters.AddWithValue("notes", market.Notes);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					market.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Market, market.ID, market.NameWithCustomerName);
		}

		public static void Update(ClassMarket market)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE markets
						SET designation = @Designation, name = @Name,
						address = @Address, city = @City, state = @State, zip = @Zip, country = @Country,
						telephone = @Telephone,
						c1_name = @C1Name, c2_name = @C2Name, c3_name = @C3Name,
						c1_position = @C1Position, c2_position = @C2Position, c3_position = @C3Position,
						c1_number = @C1Number, c2_number = @C2Number, c3_number = @C3Number,
						email = @Email, automated_email = @Automated_Email, send_open = @SendOpen, send_close = @SendClose, send_techonsite = @SendToS, send_rma = @SendRmaCreated,
						notes = @Notes, salesperson_id = @SalespersonID, customer_id = @CustomerID
						WHERE id = @MarketID;";
					cmd.Parameters.AddWithValue("Designation", market.Prefix);
					cmd.Parameters.AddWithValue("Name", market.Name);
					cmd.Parameters.AddWithValue("Address", market.Address);
					cmd.Parameters.AddWithValue("City", market.City);
					cmd.Parameters.AddWithValue("State", market.State);
					cmd.Parameters.AddWithValue("Zip", market.Zip);
					cmd.Parameters.AddWithValue("Country", market.Country);
					cmd.Parameters.AddWithValue("Telephone", market.Telephone);
					cmd.Parameters.AddWithValue("C1Name", market.Contact1_Name);
					cmd.Parameters.AddWithValue("C2Name", market.Contact2_Name);
					cmd.Parameters.AddWithValue("C3Name", market.Contact3_Name);
					cmd.Parameters.AddWithValue("C1Position", market.Contact1_Position);
					cmd.Parameters.AddWithValue("C2Position", market.Contact2_Position);
					cmd.Parameters.AddWithValue("C3Position", market.Contact3_Position);
					cmd.Parameters.AddWithValue("C1Number", market.Contact1_Number);
					cmd.Parameters.AddWithValue("C2Number", market.Contact2_Number);
					cmd.Parameters.AddWithValue("C3Number", market.Contact3_Number);
					cmd.Parameters.AddWithValue("Email", market.Email_Addresses);
					cmd.Parameters.AddWithValue("Automated_Email", market.Automated_Email_List);
					cmd.Parameters.AddWithValue("SendOpen", market.SendEmail_Open);
					cmd.Parameters.AddWithValue("SendClose", market.SendEmail_Close);
					cmd.Parameters.AddWithValue("SendToS", market.SendEmail_TechOnSite);
					cmd.Parameters.AddWithValue("SendRmaCreated", market.SendEmail_RmaCreated);
					cmd.Parameters.AddWithValue("Notes", market.Notes);
					cmd.Parameters.AddWithValue("SalespersonID", market.SalespersonID);
					cmd.Parameters.AddWithValue("MarketID", market.ID);
					cmd.Parameters.AddWithValue("CustomerID", market.CustomerID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Market, market.ID, market.NameWithCustomerName);
		}

		/// <summary>
		/// Perma-deletes specified market.
		/// Ensure no assets exist assigned to the market first.
		/// </summary>
		public static void Delete(ClassMarket market)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("MarketID", market.ID);

					cmd.CommandText = @"DELETE FROM markets WHERE id = @MarketID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM user_subscriptions WHERE obj_id = @MarketID AND obj_type = 'Market';";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Market, market.ID, market.NameWithCustomerName);
		}

		/// <summary>
		/// Returns how many times specified market is utilized by the database.
		/// (By assets)
		/// </summary>
		public static int GetUsedQty(int marketID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("MarketID", marketID);

					// ASSETS
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM assets
						WHERE market_id = @MarketID;";
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());

					// SHIPMENTS
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM shipments
						WHERE market_id = @MarketID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Finds markets having SearchTerm in the Name or Customer Name.
		/// </summary>
		public static IEnumerable<ClassMarket> Search(string searchTerm)
		{
			var foundMarkets = new List<ClassMarket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT m.*, c.name customer_name, c.prefix customer_prefix, c.frozen_flag customer_is_frozen
						FROM markets m
							JOIN customers c ON m.customer_id = c.id
						WHERE m.name LIKE @SearchTerm
						OR c.name LIKE @SearchTerm
						GROUP BY c.name, m.name ASC;";
					cmd.Parameters.AddWithValue("SearchTerm", $"%{searchTerm}%");
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var market = GetFromReader(reader);
							market.CustomerPrefix = reader.GetDBString("customer_prefix");
							market.CustomerName = reader.GetDBString("customer_name");
							market.CustomerIsFrozen = reader.GetDBBool("customer_is_frozen");
							foundMarkets.Add(market);
						}
				}
				conn.Close();
			}
			return foundMarkets;
		}

		public string ExportHeadersAsCsvString()
		{
			return "\"" + string.Join("\",\"",
					   "Customer Prefix", "Customer Name",
					   "Market Prefix", "Market Name", "Address", "City", "State", "Zip", "Country", "Telephone",
					   "Contact1 Name", "Contact1 Number", "Contact1 Position",
				       "Contact2 Name", "Contact2 Number", "Contact2 Position",
				       "Contact3 Name", "Contact3 Number", "Contact3 Position",
					   "Send Email on Ticket Open",
					   "Send Email on Ticket Close",
					   "Send Email when Tech on Site",
					   "Send Email when RMA Created"
					   ) + "\"";
		}

		public string ExportPropertiesAsCsvString()
		{
			return "\"" + string.Join("\",\"",
				       CustomerPrefix, CustomerName,
				       Prefix, Name, Address, City, State, Zip, Country, Telephone,
				       Contact1_Name, Contact1_Number, Contact1_Position,
				       Contact2_Name, Contact2_Number, Contact2_Position,
				       Contact3_Name, Contact3_Number, Contact3_Position,
				       SendEmail_Open,
				       SendEmail_Close,
				       SendEmail_TechOnSite,
				       SendEmail_RmaCreated
				       ) + "\"";
		}
		#endregion
	}
}