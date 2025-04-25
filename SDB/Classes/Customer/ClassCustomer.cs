using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.General;

namespace SDB.Classes.Customer
{
	public class ClassCustomer
	{
		public static readonly Color GOOD_STANDING_COLOR = Color.LightGray;
		public static readonly Color FROZEN_STANDING_COLOR = Color.Red;

		private static readonly string[] _customerDBFields =
		{
			"name", "prefix"
		};

		public int ID { get; set; }
		public string Name { get; set; }
		public string Prefix { get; set; }
		public bool IsFrozen { get; set; }
		public int? AssignedSSR { get; set; }
		public int? AssetTag { get; set; }

		public List<ClassMarket> Markets { get; set; }

		public string DisplayMember
		{
			get
			{
				var marketQty = Markets?.Count ?? 0;
				return $"{Name} [{Prefix}] ({marketQty} market{(marketQty == 1 ? string.Empty : "s")})";
			}
		}

		public override string ToString()
		{
			return $"[{Prefix}] {Name} [{ID}]";
		}

		public ClassMarket Market(int marketID)
		{
			return Markets.FirstOrDefault(m => m.ID == marketID);
		}

		public ClassCustomer()
		{
			Markets = new List<ClassMarket>();
		}

		public static ClassCustomer GetByID(int customerID)
		{
			var customer = new ClassCustomer();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM customers
						WHERE id = @CustomerID;";
					cmd.Parameters.AddWithValue("CustomerID", customerID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							customer = GetFromReader(reader);
						}
					customer.Markets = ClassMarket.GetByCustomer(customer.ID).ToList();
				}
				conn.Close();
			}
			return customer;
		}

		public static ClassCustomer GetByAsset(ClassAsset asset)
		{
			var customer = new ClassCustomer();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT c.*
						FROM assets a
							JOIN markets m ON a.market_id = m.id
							JOIN customers c ON m.customer_id = c.id
						WHERE a.id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							customer = GetFromReader(reader);
						}
					customer.Markets = ClassMarket.GetByCustomer(customer.ID).ToList();
				}
				conn.Close();
			}
			return customer;
		}

		/// <summary>
		/// Gets all customer names as dictionary indexed by primary key for lists.
		/// If <paramref name="customerIds"/> is supplied, only that subset of customer names is retrieved.
		/// </summary>
		public static Dictionary<int, string> GetNames(List<int> customerIds = null)
		{
			var customerNames = new Dictionary<int, string>();
			var conditional = customerIds != null && customerIds.Any() ? $@"WHERE c.id IN ({string.Join(",", customerIds.Distinct())})" : string.Empty;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT c.id, m.name
						FROM customers c
						{conditional};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var id = reader.GetDBInt("id");
							var customerName = reader.GetDBString("name");
							customerNames.Add(id, customerName);
						}
				}
				conn.Close();
			}
			return customerNames;
		}

		/// <summary>
		/// Gets all market and customer names as dictionary indexed by primary key for lists.
		/// If <paramref name="marketIds"/> is supplied, only that subset of market & customer names is retrieved.
		/// </summary>
		public static Dictionary<int, string[]> GetNamesByMarket(List<int> marketIds = null)
		{
			var customerNames = new Dictionary<int, string[]>();
			var conditional = marketIds != null && marketIds.Any() ? $@"WHERE m.id IN ({string.Join(",", marketIds.Distinct())})" : string.Empty;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT m.id, m.name market_name, c.name customer_name
						FROM markets m
						JOIN customers c ON m.customer_id = c.id
						{conditional};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var marketId = reader.GetDBInt("id");
							var marketName = reader.GetDBString("market_name");
							var customerName = reader.GetDBString("customer_name");
							customerNames.Add(marketId, new[] {marketName, customerName});
						}
				}
				conn.Close();
			}
			return customerNames;
		}

		public string GetCustomerAssetTag()
		{
			var assetTag = "No Tag Assigned";

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM asset_tags
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", AssetTag);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
							assetTag = reader.GetDBString("tag");
					}
				}
				conn.Close();
			}
			return assetTag;
		}

		/// <summary>
		/// Gets all customers and their markets from the database.
		/// </summary>
		public static IEnumerable<ClassCustomer> GetCustomers()
		{
			var customers = new List<ClassCustomer>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT *
						FROM customers
						ORDER BY name ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							customers.Add(GetFromReader(reader));
					conn.Close();
				}
				var allMarkets = ClassMarket.GetAll(null, int.MaxValue, out _).ToList();
				foreach (var c in customers)
				{
					var customer = c;
					c.Markets = allMarkets.Where(m => m.CustomerID == customer.ID).ToList();
				}
			}
			return customers;
		}

		/// <summary>
		/// Gets the customer ID for specified market ID.
		/// </summary>
		public static int GetCustomerIDByMarket(int marketID)
		{
			var customerID = -1;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT customer_id
						FROM markets
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", marketID);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							customerID = reader.GetDBInt("customer_id");
				}
				conn.Close();
			}
			return customerID;
		}

		/// <summary>
		/// Inserts a new customer into the database and populates its ID. Also creates a default market.
		/// </summary>
		public static void AddNew(ref ClassCustomer customer)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"INSERT INTO customers
							({string.Join(", ", _customerDBFields)})
						VALUES
							(@{string.Join(", @", _customerDBFields)});";
					cmd.Parameters.AddWithValue("name", customer.Name);
					cmd.Parameters.AddWithValue("prefix", customer.Prefix);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					customer.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}

			// Add new default market
			var newDefaultMarket = new ClassMarket { Name = "Default Market", CustomerID = customer.ID, CustomerName = customer.Name, Prefix = "000" };
			ClassMarket.AddNew(ref newDefaultMarket);
			customer.Markets.Add(newDefaultMarket);

			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Customer, customer.ID, customer.Name);
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Market, newDefaultMarket.ID, string.Format("{0} ({1})", newDefaultMarket.Name, customer.Name));
		}

		public static void Update(ClassCustomer customer)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE customers
						SET prefix = @prefix,
							name = @name,
							frozen_flag = @isFrozen,
                            asset_tag = @AssetTag,
                            assigned_ssr = @AssignedSSR
						WHERE id = @company_id;";
					cmd.Parameters.AddWithValue("company_id", customer.ID);
					cmd.Parameters.AddWithValue("name", customer.Name);
					cmd.Parameters.AddWithValue("prefix", customer.Prefix);
					cmd.Parameters.AddWithValue("isFrozen", customer.IsFrozen);
					cmd.Parameters.AddWithValue("AssetTag", customer.AssetTag);
					cmd.Parameters.AddWithValue("AssignedSSR", customer.AssignedSSR);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Customer, customer.ID, customer.Name);
		}

		/// <summary>
		/// Permanently deletes specified customer from the database.
		/// Ensure no markets exist assigned to the customer first.
		/// </summary>
		public static void Delete(ClassCustomer customer)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("CustomerID", customer.ID);

					cmd.CommandText = @"DELETE FROM customers WHERE id = @CustomerID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM user_subscriptions WHERE obj_id = @CustomerID AND obj_type = 'Customer';";
					cmd.ExecuteNonQuery();

					//cmd.CommandText = @"DELETE FROM user_notifications WHERE obj_id = @CustomerID AND obj_type = 'Customer';";
					//cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Customer, customer.ID, customer.Name);
		}

		/// <summary>
		/// Returns how many times specified customer is utilized by the database.
		/// (By markets)
		/// </summary>
		public static int GetUsedQty(int customerID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("CustomerID", customerID);

					// MARKETS
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM markets
						WHERE customer_id = @CustomerID;";
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Finds customers having SearchTerm in the Name or any Market Name.
		/// </summary>
		public static IEnumerable<ClassCustomer> Search(string searchTerm)
		{
			var foundCustomers = new List<ClassCustomer>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT c.*
						FROM customers c
							LEFT JOIN markets m ON m.customer_id = c.id
						WHERE c.name LIKE @SearchTerm
						OR m.name LIKE @SearchTerm
						GROUP BY c.name ASC;";
					cmd.Parameters.AddWithValue("SearchTerm", $"%{searchTerm}%");
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							foundCustomers.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return foundCustomers;
		}

		private static ClassCustomer GetFromReader(MySqlDataReader reader)
		{
			var customerID = reader.GetDBInt_Null("id");
			if (!customerID.HasValue)
				return null;
			return new ClassCustomer
			{
				ID = customerID.Value,
				Name = reader.GetDBString("name"),
				Prefix = reader.GetDBString("prefix"),
				IsFrozen = reader.GetDBBool("frozen_flag"),
				AssetTag = reader.GetDBInt_Null("asset_tag"),
				AssignedSSR = reader.GetDBInt_Null("assigned_ssr")
			};
		}
	}
}