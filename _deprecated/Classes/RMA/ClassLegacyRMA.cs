using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	/// <summary>
	///  This is the old style RMA class. (Replaces ClassRMADetailObject)
	/// </summary>
	public class ClassLegacyRMA
	{
		public int ID;
		public DateTime IssuedDate;
		public DateTime? ClosedDate;
		public string IssuedBy;
		public string PONum;
		public int Tech_ID;
		/// <summary>
		/// Optional field: requires joining techs table
		/// </summary>
		public string Tech_Name;
		public int? Asset_ID;
		public int? Ticket_ID;
		public string CustomerWorkOrder;
		public string CustName;
		public string CustAddress;
		public string CustCSZ;
		public string CustTel;
		public string CustShipName;
		public string CustShipAddress;
		public string CustShipCSZ;
		public string CustShipTel;
		public readonly List<PartLine> PartData;
		/// <summary>
		/// rmanote in the db
		/// </summary>
		public string YescoNotes;
		/// <summary>
		/// specialreq in the db
		/// </summary>
		public string CustomerRequests;
		public string APR;

		public ClassLegacyRMA()
		{
			PartData = new List<PartLine>();
		}

		/// <summary>
		/// This is an RMA-only part, not to be confused with ClassPart.
		/// </summary>
		public class PartLine
		{
			public int Qty;
			public string Description;
			public string Mfg = "Yesco";
			public string Problem;
			public string Priority;

			public string JobNum; // LEGACY
			public string DisplayName; // LEGACY

			// Repair Related
			public DateTime? ReceiveDate;
			public string Zone;
			public string MU;
			public DateTime? ReturnDate;
			public string ShippingType;
			public string RepairTech;
			public string ReturnedBy;
			public string Repairs;
			public string RepairType;
			public string TrackingNumber;
		}

		public static ClassLegacyRMA GetByID(int rmaID)
		{
			ClassLegacyRMA legacyRMA = new ClassLegacyRMA();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT r.*, t.tech tech_name
						FROM rma_legacy r
							JOIN techs t ON r.tech_id = t.id
						WHERE r.rmanum = @RMAID;";
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							legacyRMA = GetFromReader(reader);
						}
					conn.Close();
				}
			}
			return legacyRMA;
		}

		public static IEnumerable<ClassLegacyRMA> GetByTicket(int ticketID)
		{
			List<ClassLegacyRMA> ticketLegacyRmAs = new List<ClassLegacyRMA>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT r.*, t.tech tech_name
						FROM rma_legacy r
							JOIN techs t ON r.tech_id = t.id
						WHERE r.ticket_id = @TicketID
						AND r.deleted IS FALSE
						AND r.converted IS FALSE
						ORDER BY r.rmanum ASC;";
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							ticketLegacyRmAs.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return ticketLegacyRmAs;
		}

		public static IEnumerable<ClassLegacyRMA> GetByTech(int techID)
		{
			List<ClassLegacyRMA> ticketLegacyRmAs = new List<ClassLegacyRMA>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT r.*, t.tech tech_name
						FROM rma_legacy r
							JOIN techs t ON r.tech_id = t.id
						WHERE r.tech_id = @TechID
						AND r.deleted IS FALSE
						AND r.converted IS FALSE
						ORDER BY r.rmanum ASC;";
					cmd.Parameters.AddWithValue("TechID", techID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							ticketLegacyRmAs.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return ticketLegacyRmAs;
		}

		public static IEnumerable<ClassLegacyRMA> GetByAsset(int assetID)
		{
			List<ClassLegacyRMA> assetLegacyRmAs = new List<ClassLegacyRMA>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT r.*, t.tech tech_name
						FROM rma_legacy r
							JOIN techs t ON r.tech_id = t.id
						WHERE r.asset_id = @AssetID
						AND r.deleted IS FALSE
						AND r.converted IS FALSE
						ORDER BY r.rmanum ASC;";
					cmd.Parameters.AddWithValue("AssetID", assetID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							assetLegacyRmAs.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return assetLegacyRmAs;
		}

		public static PartLine LegacyRMA_GetPartLineFromReader(int partNumber, MySqlDataReader reader)
		{
			string px = partNumber.ToString("0");
			PartLine part =
				new PartLine
					{
						JobNum = reader.GetDBString("jobnumber" + px),
						MU = reader.GetDBString("mu_" + px),
						DisplayName = reader.GetDBString("displayname" + px),
						Qty = int.Parse(reader.GetDBString("quantity" + px, "0")),
						Mfg = reader.GetDBString("manufacturer" + px),
						Description = reader.GetDBString("partdescription" + px)
					};
			string rcv = string.Empty, ret = string.Empty;
			try
			{
				part.ReceiveDate = reader.GetDBDateTime_Null("rcv" + px + "_dt");
				part.Zone = reader.GetDBString("zone_" + px).Trim();
				part.ReturnDate = reader.GetDBDateTime_Null("ret" + px + "_dt");
			}
			catch (Exception ex)
			{
				if (ex is ArgumentNullException || ex is FormatException)
				{
					StringBuilder sb = new StringBuilder();
					sb.AppendLine("Error reading an old date for this RMA:").AppendLine();
					sb.AppendFormat("Part Description: \"{0}\"", part.Description).AppendLine();
					sb.AppendFormat("Received Date: \"{0}\"", rcv).AppendLine();
					sb.AppendFormat("Returned Date: \"{0}\"", ret);
					MessageBox.Show(sb.ToString(), "Date Read Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else throw;
			}
			part.RepairTech = reader.GetDBString("repairtech_" + px);
			string prio = reader.GetDBString("priority" + px);
			if (string.IsNullOrEmpty(prio)) prio = "5";
			part.Priority = ClassDefinitions.PRIORITY_TYPES[Convert.ToInt32(prio)];
			part.Problem = reader.GetDBString("repairneeded" + px);
			part.Repairs = reader.GetDBString("repairdone_" + px);
			part.RepairType = reader.GetDBString("repairtype_" + px);
			part.ReturnedBy = reader.GetDBString("returnedby_" + px);
			part.TrackingNumber = reader.GetDBString("tracking_" + px);
			return part;
		}

		private static ClassLegacyRMA GetFromReader(MySqlDataReader reader)
		{
			ClassLegacyRMA legacyRMA = new ClassLegacyRMA();
			legacyRMA.ID = reader.GetDBInt("rmanum");
			legacyRMA.IssuedDate = reader.GetDBDateTime("issued_dt");
			legacyRMA.IssuedBy = reader.GetDBString("poauth");
			legacyRMA.PONum = reader.GetDBString("ponum");
			legacyRMA.Tech_ID = reader.GetDBInt("tech_id");
			legacyRMA.Tech_Name = reader.GetDBString("tech_name");
			legacyRMA.Asset_ID = reader.GetDBInt_Null("asset_id");
			legacyRMA.Ticket_ID = reader.GetDBInt_Null("ticket_id");
			legacyRMA.ClosedDate = reader.GetDBDateTime_Null("closed_dt");
			legacyRMA.APR = reader.GetDBString("apr");
			legacyRMA.YescoNotes = reader.GetDBString("rmanote");
			legacyRMA.CustomerRequests = reader.GetDBString("specialreq");
			for (int i = 0; i < 5; i++)
				legacyRMA.PartData.Add(LegacyRMA_GetPartLineFromReader(i + 1, reader));
			return legacyRMA;
		}
	}
}