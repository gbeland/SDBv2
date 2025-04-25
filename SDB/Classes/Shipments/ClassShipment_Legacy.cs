using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.Assembly;
using SDB.Classes.General;
using SDB.Interfaces;

namespace SDB.Classes.Shipments
{
	public class ClassShipment: ISupportsJournal
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		/// <summary>
		/// Business or Residential
		/// </summary>
		public enum AddressTypeEnum
		{
			Business,
			Residential
		};

		public class ClassShippingAddressInfo
		{
			public string Company { get; set; }
			public string Attention { get; set; }
			public string Address { get; set; }
			public string City { get; set; }
			public string State { get; set; }
			public string Zip { get; set; }
			public string Country { get; set; }
			public string Telephone { get; set; }
			public AddressTypeEnum AddressType { get; set; }

			public override string ToString()
			{
				return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", Company, Attention, Address, City, State, Zip, Country, Telephone, AddressType);
			}

			protected bool Equals(ClassShippingAddressInfo other)
			{
				return string.Equals(Company, other.Company, StringComparison.OrdinalIgnoreCase) && string.Equals(Attention, other.Attention, StringComparison.OrdinalIgnoreCase) && string.Equals(Address, other.Address, StringComparison.OrdinalIgnoreCase) && string.Equals(City, other.City, StringComparison.OrdinalIgnoreCase) && string.Equals(State, other.State, StringComparison.OrdinalIgnoreCase) && string.Equals(Zip, other.Zip, StringComparison.OrdinalIgnoreCase) && string.Equals(Country, other.Country, StringComparison.OrdinalIgnoreCase) && string.Equals(Telephone, other.Telephone, StringComparison.OrdinalIgnoreCase) && AddressType == other.AddressType;
			}

			public override int GetHashCode()
			{
				unchecked
				{
					var hashCode = (Company != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Company) : 0);
					hashCode = (hashCode * 397) ^ (Attention != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Attention) : 0);
					hashCode = (hashCode * 397) ^ (Address != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Address) : 0);
					hashCode = (hashCode * 397) ^ (City != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(City) : 0);
					hashCode = (hashCode * 397) ^ (State != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(State) : 0);
					hashCode = (hashCode * 397) ^ (Zip != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Zip) : 0);
					hashCode = (hashCode * 397) ^ (Country != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Country) : 0);
					hashCode = (hashCode * 397) ^ (Telephone != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Telephone) : 0);
					hashCode = (hashCode * 397) ^ (int)AddressType;
					return hashCode;
				}
			}

			public override bool Equals(object obj)
			{
				if (ReferenceEquals(null, obj))
					return false;
				if (ReferenceEquals(this, obj))
					return true;
				if (obj.GetType() != GetType())
					return false;

				return Equals((ClassShippingAddressInfo)obj);
			}
		}
		#endregion

		#region Private Fields
		/// <summary>
		/// Note that the delete-related fields are accessed and changed through their own methods.
		/// </summary>
		private static readonly string[] _shipmentDBFields =
		{
			"requested_by", "requested_dt", "purchase_order",
			"market_id", "tech_id",
			"dest_company", "dest_attn", "dest_address", "dest_city", "dest_state", "dest_zip", "dest_country", "dest_telephone", "dest_address_type",
			"flag_computer", "flag_ready", "eparts_email_list", "is_eparts",
            "ready_date",
			"ship_method", "ship_packages", "ship_weight", "ship_insurance", 

            "picking_by", "picking_dt",
			"fulfilled_by", "fulfilled_dt", "fulfilled_cost",
			"tracking", "notes"
		};

		private static readonly string[] _shipmentUpdateFields =
		{
			"requested_by", "requested_dt", "purchase_order",
			"market_id", "tech_id",
			"dest_company", "dest_attn", "dest_address", "dest_city", "dest_state", "dest_zip", "dest_country", "dest_telephone", "dest_address_type",
			"flag_computer", "flag_ready", "eparts_email_list", "is_eparts",
            "ready_date",
			"ship_method",
			"notes"
		};

		#region SHIPMENT_BASE_QUERY
		private const string _SHIPMENT_BASE_QUERY =
            @"SELECT s.id,

				CONCAT(u1.firstname, LEFT(u1.lastname, 1)) request_user,
				s.requested_dt, s.purchase_order,
				s.market_id, s.tech_id,

				s.dest_company, s.dest_attn, s.dest_address, s.dest_city, s.dest_state, s.dest_zip, s.dest_country,
				s.dest_telephone, s.dest_address_type,
				s.flag_computer, s.flag_ready, s.flag_onhold, s.ready_date, s.eparts_email_list, s.is_eparts,
				s.ship_method, methods.description ship_method_name, methods.abbreviation ship_method_abbreviation, s.ship_packages, s.ship_weight, s.ship_insurance,

				# Journal properties
					(CASE WHEN EXISTS (
						SELECT 1 FROM shipment_journal j
						WHERE j.system_msg IS FALSE
						AND j.shipment_id = s.id)
					THEN TRUE ELSE FALSE END) AS flag_nonsystemjournal,

				CONCAT(u2.firstname, LEFT(u2.lastname, 1)) picked_user,
				s.picking_dt, 

				CONCAT(u3.firstname, LEFT(u3.lastname, 1)) fulfilled_user,
				s.fulfilled_dt, s.fulfilled_cost,

				s.tracking, s.notes, s.deleted,

				inv.qty inventory_qty

	 			FROM shipments s
				LEFT JOIN users u1 ON (s.requested_by = u1.userid)
				LEFT JOIN users u2 ON (s.picking_by = u2.userid)
				LEFT JOIN users u3 ON (s.fulfilled_by = u3.userid)
				LEFT JOIN 
				(
					SELECT COUNT(id) qty, shipment_id
					FROM shipment_inventory
					GROUP BY shipment_id
				) inv ON inv.shipment_id = s.id
				LEFT JOIN shipment_methods methods ON (methods.id = s.ship_method)
				";
		#endregion

		private const string _SHIPMENT_LIST_QUERY =
            @"SELECT s.id,
				s.flag_computer,
				s.flag_onhold,
				s.flag_ready,
				s.ready_date,
					(CASE WHEN EXISTS (
						SELECT 1 FROM shipment_journal j
						WHERE j.system_msg IS FALSE
						AND j.shipment_id = s.id)
					THEN TRUE ELSE FALSE END) AS flag_nonsystemjournal,
				s.requested_by,
				s.requested_dt,
				s.market_id,
                s.is_eparts,
                s.eparts_email_list,
				s.tech_id,
				s.dest_company,
				s.dest_attn,
				s.dest_address,
				methods.description ship_method_name,
				methods.abbreviation ship_method_abbreviation,
				inv.qty inventory_qty,
				s.picking_by,
				s.picking_dt,
				s.fulfilled_by,
				s.fulfilled_dt,
				s.tracking,
				s.deleted,
				LEFT(s.notes, 1) notes
			FROM shipments s
			LEFT JOIN shipment_inventory v ON (v.shipment_id = s.id)
			LEFT JOIN shipment_methods methods ON (methods.id = s.ship_method)
			LEFT JOIN 
			(
				SELECT SUM(qty) qty, shipment_id
				FROM shipment_inventory
				GROUP BY shipment_id
			) inv ON inv.shipment_id = s.id
			";

		#region SHIPMENT_FILTER_QUERIES
		private const string _SHIPMENT_WHERE_REQUESTED =
			@"WHERE s.fulfilled_dt IS NULL
							AND s.deleted IS FALSE
							AND s.flag_ready iS FALSE
							AND s.flag_onhold is FALSE
			";

		private const string _SHIPMENT_WHERE_ONHOLD =
			@"WHERE s.fulfilled_dt IS NULL
							AND s.deleted IS FALSE
							AND s.flag_onhold iS TRUE
			";

		private const string _SHIPMENT_WHERE_READY =
			@"WHERE s.picking_dt IS NULL
							AND s.fulfilled_dt IS NULL
							AND s.deleted IS FALSE
							AND s.flag_ready IS TRUE
							AND s.flag_onhold IS FALSE
			";

		private const string _SHIPMENT_WHERE_PICKED =
			@"WHERE s.picking_dt IS NOT NULL
						AND s.fulfilled_dt IS NULL
						AND s.deleted IS FALSE
						AND s.flag_onhold IS FALSE
			";

		private const string _SHIPMENT_WHERE_SHIPPED =
			@"WHERE s.fulfilled_dt IS NOT NULL
						AND s.deleted IS FALSE
						AND s.flag_onhold IS FALSE
			";

		private const string _SHIPMENT_WHERE_DELETED =
			@"WHERE s.deleted IS TRUE
			";
		#endregion

		#endregion

		#region Public Properties
		// ReSharper disable InconsistentNaming
		public static readonly Color SHIPMENT_REQUESTED = Color.DimGray;
		public static readonly Color SHIPMENT_REQUESTED_BG = SystemColors.Window;

		public static readonly Color SHIPMENT_READY = Color.Black;
		public static readonly Color SHIPMENT_READY_BG = Color.Gold;

		public static readonly Color SHIPMENT_ONHOLD = Color.Black;
        public static readonly Color SHIPMENT_ONHOLD_BG = Color.LightGray; 

		public static readonly Color SHIPMENT_PICKED = Color.Black;
        public static readonly Color SHIPMENT_PICKED_BG = Color.LightBlue;

		public static readonly Color SHIPMENT_CLOSED = Color.Black;
        public static readonly Color SHIPMENT_CLOSED_BG = Color.LightGreen;

		public static readonly Color SHIPMENT_DELETED = Color.DarkMagenta;
		public static readonly Color SHIPMENT_DELETED_BG = Color.LightPink;

		internal static readonly TimeSpan MAX_JOURNAL_EXPIRATION = TimeSpan.FromDays(14);
		// ReSharper restore InconsistentNaming

		public int ID { get; set; }
		public int Requested_UserId { get; set; }
		public string Requested_By { get; set; }
		public DateTime Requested_Date { get; set; }
		public string Purchase_Order { get; set; }
		/// <summary>
		/// Associates with a Tech by ID (to show list of shipments belonging to tech)
		/// </summary>
		public int? TechID { get; set; }
		/// <summary>
		/// Associates with a Market by ID (to show list of shipments belonging to market)
		/// </summary>
		public int? MarketID { get; set; }
		public ClassShippingAddressInfo Destination;
		public int ShipMethod { get; set; }

		/// <summary>
		/// Optional for certain views (must join shipment_methods table to populate)
		/// </summary>
		public string ShipMethod_Name { get; set; }

		/// <summary>
		/// Optional for certain views (must join shipment_methods table to populate)
		/// </summary>
		public string ShipMethod_Abbreviation { get; set; }

		public bool HasComputer { get; set; }
		public bool HasNonSystemInfo { get; set; }
		public bool IsReady { get; set; }
		public bool IsOnHold { get; set; }
        public bool IsEparts { get; set; }
        public string EmailList { get; set; }
		public DateTime? ReadyDate { get; set; }
		public int? Packages { get; set; }
		public float? Weight { get; set; }
		public float? Insurance_Amount { get; set; }
		public int? Picked_UserId { get; set; }
		public string Picked_By { get; set; }
		public DateTime? Picked_Date { get; set; }
		public int? Fulfilled_UserId { get; set; }
		public string Fulfilled_By { get; set; }
		public DateTime? Fulfilled_Date { get; set; }
		public float? Fulfillment_Cost { get; set; }
		public string Tracking { get; set; }
		public string Notes { get; set; }
		public bool IsDeleted { get; set; }

		/// <summary>
		/// How many items are in the shipments' inventory.
		/// </summary>
		public int InventoryQty { get; set; }

		public string URL_TrackingLink
		{
			get
			{
				if (Tracking.StartsWith("1Z"))
					return string.Format("http://wwwapps.ups.com/WebTracking/track?track=yes&trackNums={0}", Tracking);
				return string.Format("http://fedex.com/Tracking?action=track&cntry_code=us&tracknumber_list={0}", Tracking);
			}
		}

		[UsedImplicitly]
		public string Status
		{
			get
			{
				if (IsDeleted)
					return "Deleted";
				if (Fulfilled_Date.HasValue)
					return "Shipped";
				if (IsOnHold)
					return "On Hold";
				if (Picked_Date.HasValue)
					return "Picked";
				if (IsReady)
					return "Ready";
				return "Requested";
			}
		}

		public Color StatusColor
		{
			get
			{
				if (IsDeleted)
					return SHIPMENT_DELETED;
				if (Fulfilled_Date.HasValue)
					return SHIPMENT_CLOSED;
				if (IsOnHold)
					return SHIPMENT_ONHOLD;
				if (Picked_Date.HasValue)
					return SHIPMENT_PICKED;
				if (IsReady)
					return SHIPMENT_READY;
				return SHIPMENT_REQUESTED;
			}
		}

		public Color StatusColorBackground
		{
			get
			{
				if (IsDeleted)
					return SHIPMENT_DELETED_BG;
				if (Fulfilled_Date.HasValue)
					return SHIPMENT_CLOSED_BG;
				if (IsOnHold)
					return SHIPMENT_ONHOLD_BG;
				if (Picked_Date.HasValue)
					return SHIPMENT_PICKED_BG;
				if (IsReady)
					return SHIPMENT_READY_BG;
				return SHIPMENT_REQUESTED_BG;
			}
		}

		public ClassJournal.JournalTableInfo JournalTableInfo =>
			new ClassJournal.JournalTableInfo
			{
				TableName = "shipment_journal",
				LinkerName = "shipment_id"
			};
		#endregion

		#region Constructor
		public ClassShipment()
		{
			ID = -1;
			Destination = new ClassShippingAddressInfo();
		}
		#endregion

		#region Private Methods
		private static ClassShipment GetFromReader(MySqlDataReader reader)
		{
			var s = new ClassShipment();
			var shipmentID = reader.GetDBInt_Null("id");
			if (!shipmentID.HasValue)
				return null;
			s.ID = shipmentID.Value;
			s.Requested_By = reader.GetDBString("request_user");
			s.Requested_Date = reader.GetDBDateTime("requested_dt");
			s.Purchase_Order = reader.GetDBString("purchase_order");
			s.MarketID = reader.GetDBInt_Null("market_id");
			s.TechID = reader.GetDBInt_Null("tech_id");
			s.Destination = new ClassShippingAddressInfo
			                {
				                Company = reader.GetDBString("dest_company"),
				                Attention = reader.GetDBString("dest_attn"),
				                Address = reader.GetDBString("dest_address"),
				                City = reader.GetDBString("dest_city"),          
				                State = reader.GetDBString("dest_state"),
				                Zip = reader.GetDBString("dest_zip"),
				                Country = reader.GetDBString("dest_country"),
				                Telephone = reader.GetDBString("dest_telephone"),
				                AddressType = reader.GetDBString("dest_address_type") == "Residential" ? AddressTypeEnum.Residential : AddressTypeEnum.Business
			                };
			s.HasComputer = reader.GetDBBool("flag_computer");
			s.IsReady = reader.GetDBBool("flag_ready");
			s.IsOnHold = reader.GetDBBool("flag_onhold");
			s.ReadyDate = reader.GetDBDateTime_Null("ready_date");
            s.IsEparts = reader.GetDBBool("is_eparts");
            s.EmailList = reader.GetDBString("eparts_email_list");
			s.ShipMethod = reader.GetDBInt("ship_method");
			s.ShipMethod_Name = reader.GetDBString("ship_method_name");
			s.ShipMethod_Abbreviation = reader.GetDBString("ship_method_abbreviation");
			s.Packages = reader.GetDBInt_Null("ship_packages");
			s.Weight = reader.GetDBFloat_Null("ship_weight");
			s.Insurance_Amount = reader.GetDBFloat_Null("ship_insurance");
			s.Picked_By = reader.GetDBString("picked_user");
			s.Picked_Date = reader.GetDBDateTime_Null("picking_dt");
			s.Fulfilled_By = reader.GetDBString("fulfilled_user");
			s.Fulfilled_Date = reader.GetDBDateTime_Null("fulfilled_dt");
			s.Fulfillment_Cost = reader.GetDBFloat_Null("fulfilled_cost");
			s.Tracking = reader.GetDBString("tracking");
			s.Notes = reader.GetDBString("notes");
			s.HasNonSystemInfo = !string.IsNullOrEmpty(s.Notes) || reader.GetDBBool("flag_nonsystemjournal");
			s.IsDeleted = reader.GetDBBool("deleted");
			s.InventoryQty = reader.GetDBInt("inventory_qty");
			return s;
		}

		/// <summary>
		/// Gets limited subset of Shipment properties for use in a list.
		/// </summary>
		private static ClassShipment GetFromReaderForList(MySqlDataReader reader)
		{
			var s = new ClassShipment();
			var shipmentID = reader.GetDBInt_Null("id");
			if (!shipmentID.HasValue)
				return null;
			s.ID = shipmentID.Value;
			s.Requested_UserId = reader.GetDBInt("requested_by");
			s.Requested_Date = reader.GetDBDateTime("requested_dt");
			s.MarketID = reader.GetDBInt_Null("market_id");
			s.TechID = reader.GetDBInt_Null("tech_id");
			s.Destination = new ClassShippingAddressInfo
			                {
				                Company = reader.GetDBString("dest_company")
			                };
			s.HasComputer = reader.GetDBBool("flag_computer");
			s.Notes = reader.GetDBString("notes");
			s.HasNonSystemInfo = !string.IsNullOrEmpty(s.Notes) || reader.GetDBBool("flag_nonsystemjournal");
			s.IsReady = reader.GetDBBool("flag_ready");
			s.IsOnHold = reader.GetDBBool("flag_onhold");
			s.ReadyDate = reader.GetDBDateTime_Null("ready_date");
			s.ShipMethod_Name = reader.GetDBString("ship_method_name");
			s.ShipMethod_Abbreviation = reader.GetDBString("ship_method_abbreviation");
			s.InventoryQty = reader.GetDBInt("inventory_qty");
			s.Picked_Date = reader.GetDBDateTime_Null("picking_dt");
			s.Picked_UserId = reader.GetDBInt_Null("picking_by");
			s.Fulfilled_Date = reader.GetDBDateTime_Null("fulfilled_dt");
			s.Fulfilled_UserId = reader.GetDBInt_Null("fulfilled_by");
			s.Tracking = reader.GetDBString("tracking");
			s.IsDeleted = reader.GetDBBool("deleted");
			return s;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Gets shipment by ID (deleted or not)
		/// </summary>
		public static ClassShipment GetByID(int shipmentID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_BASE_QUERY + @"WHERE s.id = @ShipmentID;";
					cmd.Parameters.AddWithValue("ShipmentID", shipmentID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							return GetFromReader(reader);
				}
				conn.Close();
			}
			return null;
		}

		/// <summary>
		/// Get count of shipments that are requested but not ready. These are shipments with at least one inventory
		/// item that requires preparation. The shipment has not been marked as ready.
		/// </summary>
		public static int GetRequestedCount()
		{
			int requestedShipmentCount;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id) qty
						FROM shipments s " + _SHIPMENT_WHERE_REQUESTED;
					requestedShipmentCount = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return requestedShipmentCount;
		}

		/// <summary>
		/// Gets a list of shipments that are requested but not ready. These are shipments with at least one inventory
		/// item that requires preparation. The shipment has not been marked as ready.
		/// </summary>
		public static List<ClassShipment> GetRequestedList(int page, int resultLimit)
		{
			var requestedShipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = _SHIPMENT_LIST_QUERY + _SHIPMENT_WHERE_REQUESTED +
					                  string.Format(@"GROUP BY s.id
							ORDER BY s.requested_dt DESC
							LIMIT {0},{1};", page * resultLimit, resultLimit);

					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								requestedShipments.Add(s);
						}
					conn.Close();
				}
			}
			return requestedShipments;
		}

		/// <summary>
		/// Get count of shipments that have been marked as on hold.
		/// </summary>
		public static int GetOnHoldCount()
		{
			int onHoldShipmentCount;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id) qty
						FROM shipments s " + _SHIPMENT_WHERE_ONHOLD;
					onHoldShipmentCount = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return onHoldShipmentCount;
		}

		/// <summary>
		/// Gets a list of shipments that have been marked as on hold.
		/// </summary>
		public static List<ClassShipment> GetOnHoldList(int page, int resultLimit)
		{
			var onHoldShipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY + _SHIPMENT_WHERE_ONHOLD +
					                  string.Format(@"GROUP BY s.id
										ORDER BY s.requested_dt DESC
										LIMIT {0},{1};", page * resultLimit, resultLimit);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								onHoldShipments.Add(s);
						}
				}
				conn.Close();
			}
			return onHoldShipments;
		}

		/// <summary>
		/// Get count of shipments that are ready. Ready shipments either have no inventory items that require
		/// preparation, or the shipment which contains such items has been marked as ready.
		/// </summary>
		public static int GetReadyCount()
		{
			int readyShipmentCount;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id) qty
						FROM shipments s " + _SHIPMENT_WHERE_READY;
					readyShipmentCount = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return readyShipmentCount;
		}

		/// <summary>
		/// Gets a list of shipments that are ready. Ready shipments either have no inventory items that require
		/// preparation, or the shipment which contains such items has been marked as ready.
		/// </summary>
		public static List<ClassShipment> GetReadyList(int page, int resultLimit)
		{
			var readyShipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = _SHIPMENT_LIST_QUERY + _SHIPMENT_WHERE_READY +
					                  string.Format(@"GROUP BY s.id
							ORDER BY s.requested_dt DESC
							LIMIT {0},{1};", page * resultLimit, resultLimit);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								readyShipments.Add(s);
						}
					conn.Close();
				}
			}
			return readyShipments;
		}

		/// <summary>
		/// Get count of shipments that are picked.
		/// </summary>
		public static int GetPickedCount()
		{
			int pickedShipmentCount;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id) qty
						FROM shipments s " + _SHIPMENT_WHERE_PICKED;
					pickedShipmentCount = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return pickedShipmentCount;
		}

		/// <summary>
		/// Gets a list of shipments that are picked.
		/// </summary>
		public static List<ClassShipment> GetPickedList(int page, int resultLimit)
		{
			var pickedShipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY + _SHIPMENT_WHERE_PICKED +
					                  string.Format(@"GROUP BY s.id
							ORDER BY s.requested_dt DESC
							LIMIT {0},{1};", page * resultLimit, resultLimit);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								pickedShipments.Add(s);
						}
				}
				conn.Close();
			}
			return pickedShipments;
		}

		/// <summary>
		/// Get count of shipments that have been marked as shipped (closed).
		/// </summary>
		public static int GetShippedCount()
		{
			int shippedShipmentCount;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id) qty
						FROM shipments s " + _SHIPMENT_WHERE_SHIPPED;
					shippedShipmentCount = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return shippedShipmentCount;
		}

		/// <summary>
		/// Gets a list of shipments that have been marked as shipped (closed).
		/// </summary>
		public static List<ClassShipment> GetShippedList(int page, int resultLimit)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY + _SHIPMENT_WHERE_SHIPPED +
					                  string.Format(@"GROUP BY s.id
						ORDER BY s.requested_dt DESC
						LIMIT {0},{1};", page * resultLimit, resultLimit);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		/// <summary>
		/// Get count of shipments that have been marked as deleted.
		/// </summary>
		public static int GetDeletedCount()
		{
			int deletedShipmentCount;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id) qty
						FROM shipments s " + _SHIPMENT_WHERE_DELETED;
					deletedShipmentCount = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return deletedShipmentCount;
		}

		/// <summary>
		/// Gets a list of shipments that have been marked as deleted.
		/// </summary>
		public static List<ClassShipment> GetDeletedList(int page, int resultLimit)
		{
			var deletedShipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY + _SHIPMENT_WHERE_DELETED +
					                  string.Format(@"GROUP BY s.id
						ORDER BY s.requested_dt DESC
						LIMIT {0},{1};", page * resultLimit, resultLimit);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								deletedShipments.Add(s);
						}
				}
				conn.Close();
			}
			return deletedShipments;
		}

		public static List<ClassShipment> GetListByLegacyRMA(int legacyRMANumber)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();

				// Search shipment_inventory for matching RMA's; get shipment id's
				var shipmentsHavingRMANumber = new List<int>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT si.shipment_id
						FROM shipment_inventory si, shipments s
						WHERE si.rma_id = @RMANumber
						AND s.deleted IS FALSE
						AND si.shipment_id = s.id;";
					cmd.Parameters.AddWithValue("RMANumber", legacyRMANumber);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							shipmentsHavingRMANumber.Add(reader.GetDBInt("shipment_id"));
				}
				if (shipmentsHavingRMANumber.Count < 1)
					return shipments;

				// Get shipments containing the shipment ID's found
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  string.Format(@"WHERE s.id IN ({0}) GROUP BY s.id;", string.Join(",", shipmentsHavingRMANumber.Select(t => t.ToString(CultureInfo.InvariantCulture)).ToArray()));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> GetListByRMA(int rmaNumber)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();

				// Search shipment_inventory for matching RMA's; get shipment id's
				var shipmentsHavingRMANumber = new List<int>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT si.shipment_id
						FROM shipment_inventory si
							JOIN shipments s ON si.shipment_id = s.id
						WHERE si.rma_id = @RMANumber
						AND s.deleted IS FALSE;";
					cmd.Parameters.AddWithValue("RMANumber", rmaNumber);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							shipmentsHavingRMANumber.Add(reader.GetDBInt("shipment_id"));
				}
				if (shipmentsHavingRMANumber.Count < 1)
					return shipments;

				// Get shipments containing the shipment ID's found
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  string.Format(@"WHERE s.id IN ({0}) GROUP BY s.id;", string.Join(",", shipmentsHavingRMANumber.Select(t => t.ToString(CultureInfo.InvariantCulture)).ToArray()));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> GetListByJobNumber(string jobNumber)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();

				// Search shipment_inventory for items with a matching job number (parts contract/warranty); get shipment id's
				var shipmentsHavingJobNumber = new List<int>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT i.shipment_id
						FROM shipment_inventory i
						WHERE i.job_number = @JobNumber;";
					cmd.Parameters.AddWithValue("JobNumber", jobNumber);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							shipmentsHavingJobNumber.Add(reader.GetDBInt("shipment_id"));
				}
				if (shipmentsHavingJobNumber.Count < 1)
					return shipments;

				// Get shipments containing the shipment ID's found
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  string.Format(@"WHERE s.id IN ({0}) AND s.deleted IS FALSE GROUP BY s.id;", string.Join(",", shipmentsHavingJobNumber.Select(t => t.ToString(CultureInfo.InvariantCulture)).ToArray()));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> GetListByAsset(int assetID)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();

				// Search shipment_inventory for matching Asset IDs; get shipment id's
				var shipmentsHavingAssetID = new List<int>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT shipment_id
						FROM shipment_inventory
						WHERE asset_id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", assetID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							shipmentsHavingAssetID.Add(reader.GetDBInt("shipment_id"));
				}
				if (shipmentsHavingAssetID.Count < 1)
					return shipments;

				// Get shipments containing the shipment ID's found
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  string.Format(@"WHERE s.id IN ({0}) AND s.deleted IS FALSE GROUP BY s.id;", string.Join(",", shipmentsHavingAssetID.Select(t => t.ToString(CultureInfo.InvariantCulture)).ToArray()));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> GetListByTicket(int ticketID)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();

				// Search shipment_inventory for matching Asset IDs; get shipment id's
				var shipmentsHavingTicketID = new List<int>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT shipment_id
						FROM shipment_inventory
						WHERE ticket_id = @TicketID;";
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var shipmentID = reader.GetDBInt("shipment_id");
							if (!shipmentsHavingTicketID.Contains(shipmentID))
								shipmentsHavingTicketID.Add(shipmentID);
						}
				}
				if (shipmentsHavingTicketID.Count < 1)
					return shipments;

				// Get shipments containing the shipment ID's found
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  string.Format(@"WHERE s.id IN ({0}) AND s.deleted IS FALSE GROUP BY s.id;", string.Join(",", shipmentsHavingTicketID.Select(t => t.ToString(CultureInfo.InvariantCulture)).ToArray()));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> GetListByTech(int techID)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY + @"WHERE s.tech_id = @TechID AND s.deleted IS FALSE GROUP BY s.id;";
					cmd.Parameters.AddWithValue("TechID", techID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> GetListByCustomer(int customerID)
		{
			var customerShipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					var customerMarketIDs = new List<int>();
					cmd.CommandText = @"SELECT m.id
						FROM markets m
						WHERE m.customer_id = @CustomerID;";
					cmd.Parameters.AddWithValue("CustomerID", customerID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							customerMarketIDs.Add(reader.GetDBInt("id"));

					if (customerMarketIDs.Count == 0)
						return null;

					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  string.Format(@"WHERE s.market_id IN ({0}) AND s.deleted IS FALSE
						GROUP BY s.id;", string.Join(",", customerMarketIDs.ToArray()));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								customerShipments.Add(s);
						}
				}
				conn.Close();
			}
			return customerShipments;
		}

		public static List<ClassShipment> GetListByMarket(int marketID)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  @"WHERE s.market_id = @MarketID
						AND s.deleted IS FALSE
						GROUP BY s.id;";
					cmd.Parameters.AddWithValue("MarketID", marketID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> GetListByAssemblyType(int assemblyTypeID)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
						@"WHERE v.assembly_type_id = @AssemblyTypeID
						AND s.deleted IS FALSE						
						GROUP BY s.id;";
					cmd.Parameters.AddWithValue("AssemblyTypeID", assemblyTypeID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static List<ClassShipment> Search(string searchTerm)
		{
			var shipments = new List<ClassShipment>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  @"WHERE s.deleted IS FALSE
						AND (s.dest_company LIKE @SearchTerm
							OR s.dest_attn LIKE @SearchTerm
							OR s.dest_address LIKE @SearchTerm)
						GROUP BY s.id;";
					cmd.Parameters.AddWithValue("SearchTerm", string.Format("%{0}%", searchTerm));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		/// <summary>
		/// Gets shipment within the specified date range. ByRequestDate and ByShipDate specify the date to search.
		/// ByRequestDate and ByShipDate cannot both be false.
		/// </summary>
		public static List<ClassShipment> GetListByDateRange(DateTime dtFrom, DateTime dtTo, bool byRequestDate, bool byShipDate)
		{
			var shipments = new List<ClassShipment>();
			dtFrom = new DateTime(dtFrom.Year, dtFrom.Month, dtFrom.Day);
			dtTo = new DateTime(dtTo.Year, dtTo.Month, dtTo.Day, 23, 59, 59);
			if (dtTo <= dtFrom || (!byRequestDate && !byShipDate))
				return shipments;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _SHIPMENT_LIST_QUERY +
					                  string.Format(@"WHERE
						{0}
						{1}
						{2}
						AND s.deleted IS FALSE
						GROUP BY s.id;",
						                  byRequestDate ? @"(s.requested_dt >= @StartDate AND s.requested_dt <= @EndDate)" : string.Empty,
						                  byRequestDate && byShipDate ? @"AND" : string.Empty,
						                  byShipDate ? @"(s.fulfilled_dt >= @StartDate AND s.fulfilled_dt <= @EndDate)" : string.Empty);
					cmd.Parameters.AddWithValue("StartDate", dtFrom);
					cmd.Parameters.AddWithValue("EndDate", dtTo);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var s = GetFromReaderForList(reader);
							if (s != null)
								shipments.Add(s);
						}
				}
				conn.Close();
			}
			return shipments;
		}

		public static IEnumerable<ClassShipment_Item> GetInventory(int shipmentID)
		{
			var inventory = new List<ClassShipment_Item>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT i.*, a.asset asset_name
						FROM shipment_inventory i
						LEFT JOIN assets a ON (i.asset_id = a.id)
						WHERE shipment_id = @ShipmentID;";
					cmd.Parameters.AddWithValue("ShipmentID", shipmentID);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var item = new ClassShipment_Item();
							item.ID = reader.GetDBInt("id");
							item.ShipmentID = reader.GetDBInt("shipment_id");
							item.AssemblyType = ClassAssemblyType.GetByID(reader.GetDBInt("assembly_type_id"));
							// Shipments before 29 Nov 2013 did not require an assembly ID so it could be null
							var assemblyID = reader.GetDBInt_Null("assembly_id");
							if (assemblyID.HasValue)
								item.Assembly = ClassAssembly.GetByID(assemblyID.Value);
							item.RMA_ID = reader.GetDBInt_Null("rma_id");
							item.Ticket_ID = reader.GetDBInt_Null("ticket_id");
							item.Asset_ID = reader.GetDBInt_Null("asset_id");
							item.Asset_Name = reader.GetDBString_Null("asset_name");
							item.Job_Number = reader.GetDBString("job_number");
							item.Quantity = reader.GetDBInt("qty");
							item.Serial_Number = reader.GetDBString("serial_number");
							inventory.Add(item);
						}
					}
				}
				conn.Close();
			}
			return inventory;
		}

		/// <summary>
		/// Inserts a new shipment into the database and populates its ID. Uses currently logged in user for requested_by
		/// <see cref="ClassShipment.Destination"/> must not be null.
		/// </summary>
		public static void AddNew(ref ClassShipment shipment, IEnumerable<ClassShipment_Item> ledger)
		{
			if (shipment.Destination == null)
				return;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Insert new shipment
					cmd.CommandText =
						string.Format(@"INSERT INTO shipments
							({0})
						VALUES
							(@{1});", string.Join(", ", _shipmentDBFields), string.Join(", @", _shipmentDBFields));
					cmd.Parameters.AddWithValue("requested_by", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("requested_dt", shipment.Requested_Date);
					cmd.Parameters.AddWithValue("purchase_order", shipment.Purchase_Order);
					cmd.Parameters.AddWithValue("market_id", shipment.MarketID);
					cmd.Parameters.AddWithValue("tech_id", shipment.TechID);
					cmd.Parameters.AddWithValue("dest_company", shipment.Destination.Company);
					cmd.Parameters.AddWithValue("dest_attn", shipment.Destination.Attention);
					cmd.Parameters.AddWithValue("dest_address", shipment.Destination.Address);
					cmd.Parameters.AddWithValue("dest_city", shipment.Destination.City);
					cmd.Parameters.AddWithValue("dest_state", shipment.Destination.State);
					cmd.Parameters.AddWithValue("dest_zip", shipment.Destination.Zip);
					cmd.Parameters.AddWithValue("dest_country", shipment.Destination.Country);
					cmd.Parameters.AddWithValue("dest_telephone", shipment.Destination.Telephone);
					cmd.Parameters.AddWithValue("dest_address_type", shipment.Destination.AddressType == AddressTypeEnum.Business ? "Business" : "Residential");
					cmd.Parameters.AddWithValue("flag_computer", shipment.HasComputer);
					cmd.Parameters.AddWithValue("flag_ready", shipment.IsReady);
					cmd.Parameters.AddWithValue("ready_date", shipment.ReadyDate);
					cmd.Parameters.AddWithValue("ship_method", shipment.ShipMethod);
                    cmd.Parameters.AddWithValue("eparts_email_list", shipment.EmailList);
                    cmd.Parameters.AddWithValue("is_eparts", shipment.IsEparts);
                    cmd.Parameters.AddWithValue("ship_packages", null);
					cmd.Parameters.AddWithValue("ship_weight", null);
					cmd.Parameters.AddWithValue("ship_insurance", null);
					cmd.Parameters.AddWithValue("picking_by", null);
					cmd.Parameters.AddWithValue("picking_dt", null);
					cmd.Parameters.AddWithValue("fulfilled_by", null);
					cmd.Parameters.AddWithValue("fulfilled_dt", null);
					cmd.Parameters.AddWithValue("fulfilled_cost", null);
					cmd.Parameters.AddWithValue("tracking", null);
					cmd.Parameters.AddWithValue("notes", shipment.Notes);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					shipment.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}

				SetInventory(shipment.ID, ledger, conn);
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Shipment, shipment.ID, shipment.Destination.Company);
		}

		/// <summary>
		/// Updates shipment and ledger in the database.
		/// <see cref="ClassShipment.Destination"/> must not be null.
		/// </summary>
		public static void Update(ClassShipment shipment, List<ClassShipment_Item> ledger)
		{
			if (shipment.Destination == null)
				return;

			shipment.HasComputer = ledger.Any(l => l.AssemblyType.IsComputer);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(@"UPDATE shipments SET {0} WHERE id = @ShipmentID;",
						string.Join(",", _shipmentUpdateFields.Select(s => string.Format("{0} = @{0}", s)).ToArray()));

					cmd.Parameters.AddWithValue("ShipmentID", shipment.ID);
					cmd.Parameters.AddWithValue("requested_by", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("requested_dt", shipment.Requested_Date);
					cmd.Parameters.AddWithValue("purchase_order", shipment.Purchase_Order);
					cmd.Parameters.AddWithValue("market_id", shipment.MarketID);
					cmd.Parameters.AddWithValue("tech_id", shipment.TechID);
					cmd.Parameters.AddWithValue("dest_company", shipment.Destination.Company);
					cmd.Parameters.AddWithValue("dest_attn", shipment.Destination.Attention);
					cmd.Parameters.AddWithValue("dest_address", shipment.Destination.Address);
					cmd.Parameters.AddWithValue("dest_city", shipment.Destination.City);
					cmd.Parameters.AddWithValue("dest_state", shipment.Destination.State);
					cmd.Parameters.AddWithValue("dest_zip", shipment.Destination.Zip);
					cmd.Parameters.AddWithValue("dest_country", shipment.Destination.Country);
					cmd.Parameters.AddWithValue("dest_telephone", shipment.Destination.Telephone);
					cmd.Parameters.AddWithValue("dest_address_type", shipment.Destination.AddressType == AddressTypeEnum.Business ? "Business" : "Residential");
					cmd.Parameters.AddWithValue("flag_computer", shipment.HasComputer);
					cmd.Parameters.AddWithValue("flag_ready", shipment.IsReady);
					cmd.Parameters.AddWithValue("ready_date", shipment.ReadyDate);
					cmd.Parameters.AddWithValue("ship_method", shipment.ShipMethod);
					cmd.Parameters.AddWithValue("notes", shipment.Notes);
                    cmd.Parameters.AddWithValue("eparts_email_list", shipment.EmailList);
                    cmd.Parameters.AddWithValue("is_eparts", shipment.IsEparts);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				SetInventory(shipment.ID, ledger, conn);
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Shipment, shipment.ID, shipment.Destination.Company);
		}

		/// <summary>
		/// Changes a shipment's ready status without changing any other properties.
		/// </summary>
		public void MarkAsReady()
		{
			var now = ClassDatabase.GetCurrentTime();
			IsReady = true;
			ReadyDate = now;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET flag_ready = TRUE,
							ready_date = @now
						WHERE id = @shipmentID;";
					cmd.Parameters.AddWithValue("now", now);
					cmd.Parameters.AddWithValue("shipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Shipment, ID, "Ready");
		}

		public void CancelReady()
		{
			IsReady = false;
			ReadyDate = null;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET flag_ready = FALSE,
							ready_date = NULL
						WHERE id = @shipmentID;";
					cmd.Parameters.AddWithValue("shipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Shipment, ID, "Cancel Ready");
		}

		/// <summary>
		/// Marks shipment as picked by current user at current time.
		/// </summary>
		public void Pick()
		{
			var now = ClassDatabase.GetCurrentTime();
			Picked_By = GS.Settings.LoggedOnUser.FirstL;
			Picked_Date = now;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET picking_by = @userID,
							picking_dt = @now
						WHERE id = @shipmentID;";
					cmd.Parameters.AddWithValue("userID", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("now", now);
					cmd.Parameters.AddWithValue("shipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Shipment, ID, "Picked");
		}

		/// <summary>
		/// Cancels shipment pick; clears pick user and time.
		/// </summary>
		public void CancelPick()
		{
			Picked_By = null;
			Picked_Date = null;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET picking_by = NULL,
							picking_dt = NULL
						WHERE id = @shipmentID;";
					cmd.Parameters.AddWithValue("shipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Shipment, ID, "Cancel Picked");
		}

		/// <summary>
		/// Marks shipment as shipped by current user at current time.
		/// </summary>
		public void Ship(int? packageQty, float? weight, float? shipmentCost, float? insuranceAmount, string trackingNumber)
		{
			var now = ClassDatabase.GetCurrentTime();
			Packages = packageQty;
			Weight = weight;
			Fulfillment_Cost = shipmentCost;
			Insurance_Amount = insuranceAmount;
			Tracking = trackingNumber;
			Fulfilled_By = GS.Settings.LoggedOnUser.FirstL;
			Fulfilled_Date = now;

            if(IsEparts && EmailList != string.Empty)
            {
                ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.EpartsOrder, ClassEmailGenerator.GenerateEmail_EpartOrderShipped(this));
            }


			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET
							ship_packages = @packageQty,
							ship_weight = @weight,
							fulfilled_cost = @shipmentCost,
							ship_insurance = @insuranceAmount,
							tracking = @trackingNumber,
							fulfilled_by = @userID,
							fulfilled_dt = @now
						WHERE id = @shipmentID;";
					cmd.Parameters.AddWithValue("packageQty", packageQty);
					cmd.Parameters.AddWithValue("weight", weight);
					cmd.Parameters.AddWithValue("shipmentCost", shipmentCost);
					cmd.Parameters.AddWithValue("insuranceAmount", insuranceAmount);
					cmd.Parameters.AddWithValue("trackingNumber", trackingNumber);
					cmd.Parameters.AddWithValue("userID", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("now", now);
					cmd.Parameters.AddWithValue("shipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Close, ClassEventLog.ObjectTypeEnum.Shipment, ID, Destination.Company);
		}

		/// <summary>
		/// Cancels shipment ship; clears ship user and time.
		/// </summary>
		public void CancelShip()
		{
			Fulfilled_By = null;
			Fulfilled_Date = null;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET fulfilled_by = NULL,
							fulfilled_dt = NULL
						WHERE id = @shipmentID;";
					cmd.Parameters.AddWithValue("shipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Reopen, ClassEventLog.ObjectTypeEnum.Shipment, ID, Destination.Company);
		}

		/// <summary>
		/// Sets the inventory for the specified shipment. Uses an existing connection that must be open.
		/// </summary>
		public static void SetInventory(int shipmentID, IEnumerable<ClassShipment_Item> inventory, MySqlConnection conn)
		{
			// Remove existing inventory items
			using (var cmd = conn.CreateCommand())
			{
				cmd.CommandText = @"DELETE FROM shipment_inventory
						WHERE shipment_id = @ShipmentID;";
				cmd.Parameters.AddWithValue("ShipmentID", shipmentID);
				cmd.ExecuteNonQuery();
			}

			// Write new inventory items
			foreach (var item in inventory)
			{
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO shipment_inventory
							(shipment_id, assembly_type_id, assembly_id, rma_id, ticket_id, asset_id, job_number, serial_number, qty)
							VALUES
							(@ShipmentID, @AssemblyTypeID, @AssemblyID, @RMA_ID, @TicketID, @AssetID, @JobNumber, @SerialNumber, @Qty);";
					cmd.Parameters.AddWithValue("ShipmentID", shipmentID);
					cmd.Parameters.AddWithValue("AssemblyTypeID", item.AssemblyType.ID);
					cmd.Parameters.AddWithValue("AssemblyID", item.Assembly != null ? item.Assembly.ID : (int?)null);
					cmd.Parameters.AddWithValue("RMA_ID", item.RMA_ID);
					cmd.Parameters.AddWithValue("TicketID", item.Ticket_ID);
					cmd.Parameters.AddWithValue("AssetID", item.Asset_ID);
					cmd.Parameters.AddWithValue("JobNumber", item.Job_Number);
					cmd.Parameters.AddWithValue("SerialNumber", item.Serial_Number);
					cmd.Parameters.AddWithValue("Qty", item.Quantity);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Marks shipment as deleted.
		/// </summary>
		public void Delete(string reason)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET deleted = TRUE,
							deleted_reason = @reason,
							deleted_date = NOW()
						WHERE id = @shipment_id;";
					cmd.Parameters.AddWithValue("shipment_id", ID);
					cmd.Parameters.AddWithValue("reason", reason);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Shipment, ID, Destination.Company);
		}

		/// <summary>
		/// Restores the specified shipment (removes mark as deleted).
		/// </summary>
		public void Restore()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET deleted = FALSE,
							deleted_reason = NULL,
							deleted_date = NULL
						WHERE id = @shipment_id;";
					cmd.Parameters.AddWithValue("shipment_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Restore, ClassEventLog.ObjectTypeEnum.Shipment, ID, Destination.Company);
		}

		/// <summary>
		/// Put shipment on hold.
		/// </summary>
		public void Hold()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET flag_onhold = TRUE
						WHERE id = @ShipmentID;";
					cmd.Parameters.AddWithValue("ShipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Held, ClassEventLog.ObjectTypeEnum.Shipment, ID, Destination.Company);
		}

		/// <summary>
		/// Release shipment from Hold.
		/// </summary>
		public void Release()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE shipments
						SET flag_onhold = FALSE
						WHERE id = @ShipmentID;";
					cmd.Parameters.AddWithValue("ShipmentID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Released, ClassEventLog.ObjectTypeEnum.Shipment, ID, Destination.Company);
		}

		/// <summary>
		/// Gets a list of previously used addresses from the shipments table for shipments that weren't associated with a tech or market.
		/// </summary>
		public static IEnumerable<ClassShippingAddressInfo> GetUnassociatedDestinations()
		{
			var dests = new List<ClassShippingAddressInfo>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT dest_company, dest_attn, dest_address,
							dest_city, dest_state, dest_zip,
							dest_country, dest_telephone, dest_address_type
						FROM shipments
						WHERE dest_company IS NOT NULL
							AND dest_company != ''
							AND market_id IS NULL
							AND tech_id IS NULL
						ORDER BY dest_company ASC;";
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.HasRows && reader.Read())
						{
							var altDest = new ClassShippingAddressInfo
							              {
								              Company = reader.GetDBString("dest_company"),
								              Attention = reader.GetDBString("dest_attn"),
								              Address = reader.GetDBString("dest_address"),
								              City = reader.GetDBString("dest_city"),
								              State = reader.GetDBString("dest_state"),
								              Zip = reader.GetDBString("dest_zip"),
								              Country = reader.GetDBString("dest_country"),
								              Telephone = reader.GetDBString("dest_telephone"),
								              AddressType = reader.GetDBString("dest_address_type") == "Residential" ? AddressTypeEnum.Residential : AddressTypeEnum.Business
							              };
							if (dests.All(d => !d.Equals(altDest)))
								dests.Add(altDest);
						}
					}
				}
				conn.Close();
			}
			return dests;
		}

		public override string ToString()
		{
			return string.Format("{0} {1:yyyy-MM-dd}", ID, Requested_Date);
		}
		#endregion
	}
}