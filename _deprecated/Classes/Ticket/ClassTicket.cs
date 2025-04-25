using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Tech;
using SDB.Classes.User;
using SDB.Forms.Ticket;
using SDB.Interfaces;
// ReSharper disable RedundantVerbatimStringPrefix

namespace SDB.Classes.Ticket
{
	/// <summary>
	/// This ticket class should only be used when working with an individual ticket (not a list).
	/// </summary>
	public class ClassTicket : ISupportsJournal, IExportableToCsv
	{
		internal static readonly Color COL_TICKET_OPEN_OSA_FG = Color.FromArgb(192, 0, 0);
		internal static readonly Color COL_TICKET_OPEN_OSA_BG = SystemColors.Window;
		internal static readonly Color COL_TICKET_OPEN_FG = Color.FromArgb(128, 128, 255);
		internal static readonly Color COL_TICKET_OPEN_BG = Color.FromArgb(230, 230, 255);
		internal static readonly Color COL_TICKET_HELD_FG = Color.DarkSlateGray;
		internal static readonly Color COL_TICKET_HELD_BG = Color.LightGray;
		internal static readonly Color COL_TICKET_CLOSED_FG = Color.Green;
		internal static readonly Color COL_TICKET_CLOSED_BG = SystemColors.Window;
		internal static readonly Color COL_TICKET_DELETED_FG = Color.DarkMagenta;
		internal static readonly Color COL_TICKET_DELETED_BG = Color.LightPink;

		internal static readonly TimeSpan MAX_JOURNAL_EXPIRATION = TimeSpan.FromDays(14);
		internal static readonly TimeSpan MAX_HOLD_EXPIRATION = TimeSpan.FromDays(14);

		internal static readonly int MAX_SELECTED_SYMPTOMS = 2;
		internal static readonly int MAX_SELECTED_SOLUTIONS = 4;

		internal static readonly TimeSpan JOURNAL_EXPIRATION_TECH_ON_SITE = TimeSpan.FromMinutes(60);
		internal static readonly TimeSpan JOURNAL_EXPIRATION_TECH_OFF_SITE = TimeSpan.Zero;

		internal static readonly TimeSpan MAX_TIME_BEFORE_UNSUPERVISED_REOPEN = TimeSpan.FromDays(7);

		private string _solutionNotes;
		private string _otherSymptomNotes;

		private static readonly string[] _ticketDBFields =
		{
			"issue", "asset_id", "ordernum",
			"reported_by", "reported_type",
			"open_user", "open_dt",
			"close_user", "close_dt",
			"solution_notes", "notes",
			"tech_id", "techarrived_dt",
			"tech_on_site", "rental_active",
			"billable", "invoicing_notes",
			"symptom_other",
			"override_close_email",
			"emailsent_osa", "emailsent_open",
			"held", "deleted", "deleted_reason", "issue_priority"
        };

		public struct TicketHoldData
		{
			public int TicketID { get; set; }
			public DateTime HoldExpirationDate { get; set; }
		}

		[Flags]
		public enum TicketType : short
		{
			Open = 1,
			Held = 2,
			Closed = 4,
			Deleted = 8
		}

		public int ID { get; set; }
		public int AssetID { get; set; }

		public string CustomerIssueNumber { get; set; }

		public string OrderNum { get; set; }
		public DateTime OpenDateTime { get; set; }
		public DateTime? CloseDateTime { get; set; }

		/// <summary>
		/// How the ticket was reported (email, phone, etc.)
		/// </summary>
		public string ReportedType { get; set; }

		public string ReportedBy { get; set; }

		public string OSANotes { get; set; }

        /// <summary>
        /// This is only used when sending osa to mark its priority. Not stored in DB
        /// </summary>
        public int IssuePriority { get; set; }

        public string Symptom_Other
		{
			get => _otherSymptomNotes;
			set
			{
				ExtraProperties.SetOtherSymptomNotes(value);
				_otherSymptomNotes = value;
			}
		}

		public string Solution_Notes
		{
			get => _solutionNotes;
			set
			{
				ExtraProperties.SetSolutionNotes(value);
				_solutionNotes = value;
			}
		}

		/// <summary>
		/// Null indicates no tech assigned.
		/// </summary>
		public int? TechID { get; set; }

		public int Open_UserID { get; set; }
		public int? Close_UserID { get; set; }

		public string Invoice_Notes { get; set; }

		/// <summary>
		/// Indicates whether ticket is billable to customer.
		/// </summary>
		public bool IsBillable { get; set; }
		/// <summary>
		/// Timestamp of first tech arriving on site.
		/// </summary>
		public DateTime? FirstTechArrivalDateTime { get; set; }
		/// <summary>
		/// Elapsed time from ticket open to first tech arriving.
		/// </summary>
		public TimeSpan TechArrivedDuration => FirstTechArrivalDateTime.HasValue ? FirstTechArrivalDateTime.Value - OpenDateTime : TimeSpan.Zero;
		/// <summary>
		/// Indicates if a tech is on site.
		/// </summary>
		public bool IsTechOnSite { get; set; }
		/// <summary>
		/// Indicates if a rental is active.
		/// </summary>
		public bool IsRentalActive { get; set; }

		/// <summary>
		/// Set true once an OSA email (to tech) has been sent for the ticket.
		/// </summary>
		public bool EmailSent_OSA { get; set; }

		/// <summary>
		/// Set true once an OPEN email (to market) has been sent for the ticket.
		/// </summary>
		public bool EmailSent_Open { get; set; }

		public bool IsHeld { get; set; }
		public bool IsDeleted { get; set; }
		public string DeleteReason { get; set; }
		public bool? OverrideCloseEmail { get; set; }

		/// <summary>
		/// Used when creating new tickets
		/// </summary>
		public bool OpenOption_SendEmail_Open;

		/// <summary>
		/// Ticket open duration (from open to close, or open to current time if not closed). Disregards hold time.
		/// </summary>
		public TimeSpan Duration => CloseDateTime.HasValue ? CloseDateTime.Value - OpenDateTime : DateTime.Now - OpenDateTime;

		/// <summary>
		/// Indicates if ticket is closed. (If it has a <see cref="CloseDateTime"/> value.)
		/// </summary>
		public bool IsClosed => CloseDateTime.HasValue;

		public Color StatusColor_Foreground
		{
			get
			{
				if (IsDeleted)
					return COL_TICKET_DELETED_FG;

				if (IsClosed)
					return COL_TICKET_CLOSED_FG;

				if (IsHeld)
					return COL_TICKET_HELD_FG;

				return TechID.HasValue ? COL_TICKET_OPEN_OSA_FG : COL_TICKET_OPEN_FG;
			}
		}

		public Color StatusColor_Background
		{
			get
			{
				if (IsDeleted)
					return COL_TICKET_DELETED_BG;

				if (IsClosed)
					return COL_TICKET_CLOSED_BG;

				if (IsHeld)
					return COL_TICKET_HELD_BG;

				return TechID.HasValue ? COL_TICKET_OPEN_OSA_BG : COL_TICKET_OPEN_BG;
			}
		}

		public ClassJournal.JournalTableInfo JournalTableInfo =>
			new ClassJournal.JournalTableInfo
			{
				TableName = "ticket_journal",
				LinkerName = "ticket_id"
			};

		public override string ToString()
		{
			return ID.ToString(CultureInfo.InvariantCulture);
		}

		public TicketExtraProperties ExtraProperties { get; }

		public ClassTicket()
		{
			ID = -1;
			AssetID = -1;
			IsBillable = false;
			ExtraProperties = new TicketExtraProperties(Solution_Notes, Symptom_Other);
		}

		/// <summary>
		/// Gets the ticket with specified ticket ID or null if invalid.
		/// </summary>
		public static ClassTicket GetByID(int ticketId)
		{
			ClassTicket ticket;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.*
						FROM tickets t
						WHERE t.id = @ticketId;";
					cmd.Parameters.AddWithValue("ticketId", ticketId);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.HasRows && reader.Read())
						{
							ticket = GetFromReader(reader);
						}
						else
						{
							ticket = null;
							ClassLogFile.AppendToLog($"ClassTicket.GetById: No data for ID {ticketId}");
						}
					}
				}
				conn.Close();
			}
			return ticket;
		}

		/// <summary>
		/// Gets the ticket ID associated with specified RMA ID.
		/// </summary>
		public static int GetID_ByRMA(int rmaID)
		{
			var ticketID = -1;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT ticket_id
						FROM rma
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", rmaID);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							ticketID = reader.GetDBInt("ticket_id");
				}
				conn.Close();
			}
			return ticketID;
		}

		/// <summary>
		/// Returns the ticket for specified RMA number or null if invalid.
		/// </summary>
		public static ClassTicket GetByRMA(int rmaId)
		{
			return GetByID(GetID_ByRMA(rmaId));
		}

        public string GetLastNote()
        {
            return ExtraProperties.Journal.LastEntry.JournalText;
        }

		/// <summary>
		/// Returns tickets for specified asset.
		/// </summary>
		public static IEnumerable<ClassTicket> GetByAsset(int assetId, TicketType type)
		{
			var assetTickets = new List<ClassTicket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT t.*
						FROM tickets t
						WHERE {GetConditionalForTicketType(type)}
							AND t.asset_id = @assetId
						ORDER BY t.id ASC;";
					cmd.Parameters.AddWithValue("assetId", assetId);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							assetTickets.Add(GetFromReader(reader));
						}
				}
				conn.Close();
			}
			return assetTickets;
		}

		/// <summary>
		/// Returns all tickets for specified market ID.
		/// </summary>
		public static IEnumerable<ClassTicket> GetByMarket(int marketId, TicketType type)
		{
			var marketTickets = new List<ClassTicket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT t.*
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
						WHERE {GetConditionalForTicketType(type)}
							AND a.market_id = @marketId;";
					cmd.Parameters.AddWithValue("marketId", marketId);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							marketTickets.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return marketTickets;
		}

		/// <summary>
		/// Returns all tickets for specified tech ID.
		/// </summary>
		public static IEnumerable<ClassTicket> GetByTech(int techId, TicketType type)
		{
			var techTickets = new List<ClassTicket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT t.*
						FROM tickets t
						WHERE {GetConditionalForTicketType(type)}
							AND t.tech_id = @techId;";
					cmd.Parameters.AddWithValue("techId", techId);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							techTickets.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return techTickets;
		}

		/// <summary>
		/// Gets the collection of open, held, or open + held tickets.
		/// </summary>
		/// <param name="pageOffset">Which page of results to return. Null for no paging.</param>
		/// <param name="maxResults">Maximum number of results to return.</param>
		/// <param name="totalQty">Total number of tickets matching specified critera.</param>
		/// <param name="type">Which types of ticket to return. <see cref="TicketType"/></param>
		public static IEnumerable<ClassTicket> GetAll(int? pageOffset, int maxResults, out int totalQty, TicketType type)
		{
			totalQty = 0;
			var tickets = new List<ClassTicket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = $@"SELECT COUNT(t.id) qty
						FROM tickets t
						WHERE {GetConditionalForTicketType(type)}";
					totalQty = Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						$@"SELECT t.*
						FROM tickets t
						WHERE {GetConditionalForTicketType(type)}
						ORDER BY t.id DESC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							tickets.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return tickets;
		}

		/// <summary>
		/// Returns tickets where the ID, Customer Issue Number, Asset Name, Asset Panel, or Assigned Tech Name partially match <paramref name="searchTerm"/>.
		/// </summary>
		public static IEnumerable<ClassTicket> Search(string searchTerm, TicketType type)
		{
			var foundTickets = new List<ClassTicket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE {GetConditionalForTicketType(type)}
						AND (t.id LIKE @searchTerm
							OR t.issue LIKE @searchTerm
							OR a.asset LIKE @searchTerm
							OR a.panel LIKE @searchTerm
							OR h.tech LIKE @searchTerm);";
					cmd.Parameters.AddWithValue("searchTerm", searchTerm);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							foundTickets.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return foundTickets;
		}

		/// <summary>
		/// Returns all non-deleted tickets opened between <paramref name="startDate"/> and <paramref name="endDate"/>.
		/// </summary>
		public static IEnumerable<ClassTicket> GetByOpenDate(DateTime startDate, DateTime endDate)
		{
			var ticketsInRange = new List<ClassTicket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT
							t.*
						FROM tickets t
						WHERE t.deleted = FALSE
							AND t.open_dt >= @startDate
							AND t.open_dt <= @endDate;";
					cmd.Parameters.AddWithValue("startDate", startDate);
					cmd.Parameters.AddWithValue("endDate", endDate);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							ticketsInRange.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return ticketsInRange;
		}

		/// <summary>
		/// Returns all non-deleted closed tickets closed between <paramref name="startDate"/> and <paramref name="endDate"/>.
		/// </summary>
		public static IEnumerable<ClassTicket> GetByCloseDate(DateTime startDate, DateTime endDate)
		{
			var ticketsInRange = new List<ClassTicket>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT
							t.*
						FROM tickets t
						WHERE t.deleted = FALSE
							AND t.close_dt IS NOT NULL
							AND t.close_dt >= @startDate
							AND t.close_dt <= @endDate;";
					cmd.Parameters.AddWithValue("startDate", startDate);
					cmd.Parameters.AddWithValue("endDate", endDate);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							ticketsInRange.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return ticketsInRange;
		}

		private static ClassTicket GetFromReader(MySqlDataReader reader)
		{
			var ticketID = reader.GetDBInt_Null("id");
			if (!ticketID.HasValue)
				return null;

			var ticket = new ClassTicket
			{
				ID = ticketID.Value,
				AssetID = reader.GetDBInt("asset_id"),
				CustomerIssueNumber = reader.GetDBString("issue"),
				OrderNum = reader.GetDBString("ordernum"),
				ReportedType = reader.GetDBString("reported_type"),
				OpenDateTime = reader.GetDBDateTime("open_dt"),
				CloseDateTime = reader.GetDBDateTime_Null("close_dt"),
				Solution_Notes = reader.GetDBString("solution_notes"),
				ReportedBy = reader.GetDBString("reported_by"),
				OSANotes = reader.GetDBString("notes"),
				Symptom_Other = reader.GetDBString("symptom_other"),
				TechID = reader.GetDBInt_Null("tech_id"),
				IsTechOnSite = reader.GetDBBool("tech_on_site"),
				IsRentalActive = reader.GetDBBool("rental_active"),
				Open_UserID = reader.GetDBInt("open_user"),
				Close_UserID = reader.GetDBInt_Null("close_user"),
				IsBillable = reader.GetDBBool("billable"),
				Invoice_Notes = reader.GetDBString("invoicing_notes"),
				FirstTechArrivalDateTime = reader.GetDBDateTime_Null("techarrived_dt"),
				EmailSent_OSA = reader.GetDBBool("emailsent_osa"),
				EmailSent_Open = reader.GetDBBool("emailsent_open"),
				IsHeld = reader.GetDBBool("held"),
				IsDeleted = reader.GetDBBool("deleted"),
				DeleteReason = reader.GetDBString("deleted_reason"),
				OverrideCloseEmail = reader.GetDBBool_Null("override_close_email"),
                IssuePriority = reader.GetDBInt("issue_priority")
			};

			return ticket;
		}

		/// <summary>
		/// Provides the SQL condition for <see cref="TicketType"/>
		/// If <paramref name="type"/> includes <see cref="TicketType.Deleted"/>, then ONLY deleted tickets are returned.
		/// </summary>
		private static string GetConditionalForTicketType(TicketType type)
		{
			/* D_eleted
			 * C_losed
			 * H_eld
			 * O_pen */
			switch ((short)type)
			{
				case 15: // DCHO
					return string.Empty;

				case 14: // DCH
					return "t.deleted IS TRUE OR t.close_dt IS NOT NULL OR t.held IS TRUE";

				case 13: // DCO
					return "t.deleted IS TRUE OR t.held IS FALSE";

				case 12: // DC
					return "t.deleted IS TRUE OR t.close_dt IS NOT NULL ";

				case 11: // DHO
					return "t.deleted IS TRUE OR t.close_dt IS NULL";

				case 10: // DH
					return "t.deleted IS TRUE OR (t.close_dt IS NULL AND t.held IS TRUE)";

				case 9: // DO
					return "t.deleted IS TRUE OR (t.close_dt IS NULL AND t.held IS FALSE)";

				case 8: // D
					return "t.deleted IS TRUE";

				case 7: // CHO
					return "t.deleted IS FALSE";

				case 6: // CH
					return "t.deleted IS FALSE AND (t.close_dt IS NOT NULL OR t.held IS TRUE)";

				case 5: // CO
					return "t.deleted IS FALSE AND t.held IS FALSE";

				case 4: // C
					return "t.deleted IS FALSE AND t.close_dt IS NOT NULL";

				case 3: // HO
					return "t.deleted IS FALSE AND t.close_dt IS NULL";

				case 2: // H
					return "t.deleted IS FALSE AND t.close_dt IS NULL AND t.held IS TRUE";

				case 1: // O
					return "t.deleted IS FALSE AND t.close_dt IS NULL AND t.held IS FALSE";

				default: // NONE
					return "1 = 0";
			}
		}

		public string ExportHeadersAsCsvString()
		{
			return "\"" + string.Join("\",\"",
				       "Ticket ID", "Customer Issue Number", "Customer", "Asset Name",
				       "Order Number", "Reported By", "Reported Type",
				       "Opened By", "Open DateTime",
				       "Closed By", "Closed DateTime",
				       "Symptoms",
				       "Solutions",
				       "Assigned Tech",
				       "First Tech on Site DateTime",
				       "Time from Open to First Tech on Site",
				       "Billable"
			       ) + "\"";
		}

		/// <summary>
		/// Returns properties of asset as a CSV string for exporting.
		/// </summary>
		public string ExportPropertiesAsCsvString()
		{
			return "\"" + string.Join("\",\"",
				       ID, CustomerIssueNumber, ExtraProperties.CustomerName, ExtraProperties.AssetName,
				       OrderNum, ReportedBy, ReportedType,
					   ExtraProperties.OpenUser, OpenDateTime,
				       ExtraProperties.CloseUser, CloseDateTime,
				       ExtraProperties.Symptoms(),
					   ExtraProperties.Solutions(),
					   ExtraProperties.AssignedTechName,
					   FirstTechArrivalDateTime,
					   TechArrivedDuration,
					   IsBillable
					   ) + "\"";
		}

		#region Ticket Actions
			/// <summary>
			/// Writes an entry to the ticket_techlog indicating that a tech arrived on or departed from site.
			/// Also updates ticket "tech_on_site" field.
			/// If this is the first arrival of a tech for the specified ticket, the ticket property <see cref="FirstTechArrivalDateTime"/> is updated accordingly.
			/// </summary>
			/// <param name="techID">The currently-assigned Tech arriving or departing.</param>
			/// <param name="arrived">Whether the tech arrived (true) or departed (false).</param>
			public void TechArrivedOnSite(int techID, bool arrived)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("ticketId", ID);
					cmd.Parameters.AddWithValue("arrived", arrived);
					cmd.Parameters.AddWithValue("techID", techID);

					cmd.CommandText =
						@"INSERT INTO ticket_techlog
						(ticket_id, tech_id, tech_dt, arrived)
						VALUES
						(@ticketId, @techID, NOW(), @arrived);";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE tickets
						SET tech_on_site = @arrived
						WHERE id = @ticketId;";
					cmd.ExecuteNonQuery();

					// Update ticket FirstTechArrivalDateTime if this is first arrival
					if (!FirstTechArrivalDateTime.HasValue && arrived)
					{
						cmd.CommandText =
							@"UPDATE tickets
							SET techarrived_dt = NOW()
							WHERE id = @ticketId;";
						cmd.ExecuteNonQuery();
					}
				}
				conn.Close();
			}
			IsTechOnSite = arrived;
		}

		/// <summary>
		/// Gets the list of tech arrival and departures for the specified ticket.
		/// </summary>
		public static List<ClassTicket_TechOnSiteEvent> GetTechLog(int ticketID)
		{
			var techLog = new List<ClassTicket_TechOnSiteEvent>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT l.tech_dt, l.arrived, l.tech_id, t.tech tech_name
						FROM ticket_techlog l
							JOIN techs t ON (l.tech_id = t.id)
						WHERE l.ticket_id = @TicketID
						ORDER BY l.tech_dt ASC;";
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							techLog.Add(new ClassTicket_TechOnSiteEvent
							{
								TechID = reader.GetDBInt("tech_id"),
								TechName = reader.GetDBString("tech_name"),
								EventDateTime = reader.GetDBDateTime("tech_dt"),
								TechArrived = reader.GetDBBool("arrived")
							});
						}
					}
				}
				conn.Close();
			}
			return techLog;
		}

		/// <summary>
		/// Mark ticket as having OSA sent via email.
		/// </summary>
		public static void SetEmail_OSA(int ticketID, bool osaSent)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET emailsent_osa = @OSASent
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("OSASent", osaSent);
					cmd.Parameters.AddWithValue("ticket_id", ticketID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Mark ticket as having sent open notification via email.
		/// </summary>
		public static void SetEmail_Open(int ticketID, bool openSent)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET emailsent_open = @OPENSent
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("OPENSent", openSent);
					cmd.Parameters.AddWithValue("ticket_id", ticketID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Provides some validation and prerequisite checking before opening a ticket for specified asset, presenting user with warnings about open tickets and previous problems.
		/// Returns false if ticket creation process is canceled, true otherwise.
		/// Produces dialog boxes, so ensure that this is called on a GUI thread.
		/// </summary>
		public static bool TicketPrerequisiteCheck(ClassAsset asset)
		{
			// VALIDATION
			if (asset == null || asset.ID < 0)
				return false;

			// CHECK RETIRED ASSET
			if (asset.IsRetired)
			{
				MessageBox.Show("This asset has been retired.", "Retired Asset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			// CHECK FROZEN CUSTOMER
			var customer = ClassCustomer.GetByAsset(asset);
			if (customer.IsFrozen)
			{
				MessageBox.Show("This customer account has been frozen, no tickets may be created.", "Customer Account Frozen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (CheckAssetTicketLock(asset, out var lockedByUser))
			{
				var ticketInProgressMessage = $"A ticket for this asset is being created by {lockedByUser.FirstL}. Do you want to continue?";
				if (MessageBox.Show(ticketInProgressMessage, "Ticket In Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return false;
			}

			// CREATE TICKET LOCK
			ClassAsset.TicketLock(asset, GS.Settings.LoggedOnUser.ID);

			var ticketHistory = GetByAsset(asset.ID, TicketType.Open | TicketType.Held | TicketType.Closed).ToList();

			// CHECK OPEN TICKETS
			var openTickets = ticketHistory.Where(t => !t.IsClosed).ToList();
			openTickets.PopulateSymptomsAndSolutions();
			if (openTickets.Count > 0)
			{
				var sb = new StringBuilder();
				foreach (var ticket in openTickets)
				{
					sb.AppendFormat("Ticket {0} for {1} by {2} on {3:yyyy-MM-dd HH:mm:ss}{4}",
						ticket.ID, ticket.ExtraProperties.Symptoms(), ClassUser.GetFirstL(ticket.Open_UserID), ticket.OpenDateTime, Environment.NewLine);
				}
				var openTicketMessage = string.Format("This asset has currently open tickets:{0}{0}{1}{0}{0}Do you want to continue?", Environment.NewLine, sb);
				if (MessageBox.Show(openTicketMessage, "Open Tickets", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					ClassAsset.TicketLock(asset);
					return false;
				}
			}

			// ALERT USER IF RECENT TICKETS CONTAIN REPEAT PROBLEMS
			if (ticketHistory.Count <= 1)
				return true;

			var commonSymptoms = ticketHistory[ticketHistory.Count - 1].ExtraProperties.SymptomList.Where(s => ticketHistory[ticketHistory.Count - 2].ExtraProperties.SymptomList.Any(s2 => s2.ID == s.ID)).ToList();
			if (commonSymptoms.Count <= 0)
				return true;

			var commonSymptomList = string.Join(", ", commonSymptoms.Select(cs => cs.Symptom));
			var commonSymptomMessage = $"The last two tickets for this display had the following symptom(s): {Environment.NewLine}{commonSymptomList}";
			MessageBox.Show(commonSymptomMessage, "Repeat Symptoms Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return true;
		}

		/// <summary>
		/// Returns the new ticket if created, or null if canceled or invalid.
		/// Use <see cref="TicketPrerequisiteCheck"/> first to avoid unnecessary tickets.
		/// Shows the Ticket Creation form, so ensure that this is called on a GUI thread.
		/// </summary>
		/// <param name="asset">The asset which the ticket is for.</param>
		/// <param name="cameraCheck">Will automatically attach camera check image and select camera check for ticket reason if provided.</param>
		public static ClassTicket Create(ClassAsset asset, ClassCameraCheck cameraCheck = null)
		{
			ClassTicket newTicket;
			using (var ticketCreateForm = new FormTicket_Create(asset))
			{
				if (cameraCheck != null)
				{
					ticketCreateForm.SelectCameraCheck();
					ticketCreateForm.SetReportedBy(ClassUser.GetFirstL(cameraCheck.User_ID));
				}
				if (ticketCreateForm.ShowDialog() != DialogResult.OK)
				{
					ClassAsset.TicketLock(asset);
					return null;
				}

				newTicket = ticketCreateForm.NewTicket;
				AddNew(ref newTicket);
				ClassJournal.AddJournalEntry(newTicket, "Opened ticket", null, true);
				// Add journal entry to the asset also
				var entry = string.Format("Ticket {0} opened", newTicket.ID);
				ClassJournal.AddJournalEntry(asset, entry, null, true);
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, newTicket.ID);
				if (GS.Settings.AutoSubscribe_Create)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, newTicket.ID);

				if (ticketCreateForm.NewTicketImage != null)
				{
					try
					{
						newTicket.AddImage(ticketCreateForm.NewTicketImage, "OSA/Ticket Open");
					}
					catch (Exception exc)
					{
						ClassLogFile.AppendToLog(exc);
						MessageBox.Show("Could not add image to ticket: " + exc.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (ticketCreateForm.SupervisorForOsaOverride != null)
				{
					try
					{
						var supervisorMessage = ClassEmailGenerator.GenerateEmail_Supervisor_OsaCreate(newTicket, asset, ticketCreateForm.SupervisorForOsaOverride);
						ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.SupervisorNotice, supervisorMessage, newTicket.ID);
					}
					catch (Exception exc)
					{
						ClassJournal.AddJournalEntry(newTicket, $"Error sending Supervisor Override OSA Send: {exc.Message}", null, true);
					}
				}

				if (newTicket.OpenOption_SendEmail_Open)
				{
                    int market_id = ClassMarket.GetMarketIDByAsset(newTicket.AssetID);
                    if (ClassMarket.AdvancedEmailOptions_Enabled(market_id))
                    {
                        bool sendEmail = false;
                        foreach (ClassTicket_Symptom s in ClassTicket_Symptom.GetByTicket(newTicket.ID)) {
                            if (ClassMarket.EmailForSymptom(market_id, s.ID))
                                sendEmail = true;
                        }
                        if(sendEmail)
                        {
                            var openMessage = ClassEmailGenerator.GenerateEmail_Ticket_Open(newTicket, out var status);
                            if (openMessage == null)
                                ClassJournal.AddJournalEntry(newTicket, $"Error generating Open Ticket email: {status}", null, true);
                            else
                            {
                                try
                                {
                                    ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.Open, openMessage, newTicket.ID);
                                }
                                catch (Exception exc)
                                {
                                    ClassJournal.AddJournalEntry(newTicket, $"Error sending Open Ticket email: {exc.Message}", null, true);
                                }
                            }
                        }
                    }
                    else
                    {
                        var openMessage = ClassEmailGenerator.GenerateEmail_Ticket_Open(newTicket, out var status);
                        if (openMessage == null)
                            ClassJournal.AddJournalEntry(newTicket, $"Error generating Open Ticket email: {status}", null, true);
                        else
                        {
                            try
                            {
                                ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.Open, openMessage, newTicket.ID);
                            }
                            catch (Exception exc)
                            {
                                ClassJournal.AddJournalEntry(newTicket, $"Error sending Open Ticket email: {exc.Message}", null, true);
                            }
                        }
                    }
					
				}

				if (newTicket.TechID.HasValue)
				{
                    if(asset.IsPMC)
                    {
                        var osaMessage = ClassEmailGenerator.GenerateEmail_PMC(newTicket, asset, ClassTech.GetByID(newTicket.TechID), out var status);
                        if (osaMessage == null)
                            ClassJournal.AddJournalEntry(newTicket, $"Could not create PMC Form: {status}", null, true);
                        else
                        {
                            try
                            {
                                ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.PMC, osaMessage, newTicket.ID);
                            }
                            catch (Exception exc)
                            {
                                ClassJournal.AddJournalEntry(newTicket, $"Error sending PMC email: {exc.Message}", null, true);
                            }
                        }
                    }
                    else
                    {
                        var osaMessage = ClassEmailGenerator.GenerateEmail_OSA(newTicket, out var status);
                        if (osaMessage == null)
                            ClassJournal.AddJournalEntry(newTicket, $"Could not create OSA message: {status}", null, true);
                        else
                        {
                            try
                            {
                                ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.OSA, osaMessage, newTicket.ID);
                            }
                            catch (Exception exc)
                            {
                                ClassJournal.AddJournalEntry(newTicket, $"Error sending OSA email: {exc.Message}", null, true);
                            }
                        }
                    }
				}
			}

			// REMOVE TICKET LOCK
			ClassAsset.TicketLock(asset);

			return newTicket;
		}

		/// <summary>
		/// Returns the new ticket if created, or null if canceled or invalid.
		/// Use <see cref="TicketPrerequisiteCheck"/> first to avoid unnecessary tickets.
		/// Shows the Ticket Creation form, so ensure that this is called on a GUI thread.
		/// Automatically selects camera check on the Ticket form and attaches the camera check image to the ticket.
		/// </summary>
		public static ClassTicket CreateForCameraCheck(ClassCameraCheck check, ClassAsset asset)
		{
			var ticket = Create(asset, check);
			if (ticket == null)
				return null;

			try
			{
				var imageDescription = string.IsNullOrEmpty(check.ImageName) ? "Camera check (no images available) " : $"Camera check image \"{check.ImageName}\" ";
				imageDescription += $"submitted at {check.Submitted:yyyy-MM-dd HH:mm:ss} by {ClassUser.GetFirstL(check.User_ID)}.";
				ticket.AddImage(ClassCameraCheck.GetImageForCameraCheck(check), imageDescription);
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show("Could not add camera check image to ticket: " + exc.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return ticket;
		}

		/// <summary>
		/// Checks if specified asset has a ticket lock.
		/// </summary>
		private static bool CheckAssetTicketLock(ClassAsset asset, out ClassUser lockedByUser)
		{
			lockedByUser = ClassAsset.GetTicketLock(asset);
			return lockedByUser != null;
		}

		/// <summary>
		/// Inserts a new ticket into the database and populates its ID.
		/// To add a new ticket, the main app should use <see cref="TicketPrerequisiteCheck"/> then <see cref="Create"/>.
		/// </summary>
		private static void AddNew(ref ClassTicket ticket)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Insert new ticket
					cmd.CommandText =
						string.Format(@"INSERT INTO tickets
							({0})
						VALUES
							(@{1});", string.Join(", ", _ticketDBFields), string.Join(", @", _ticketDBFields));
					cmd.Parameters.AddWithValue("issue", ticket.CustomerIssueNumber);
					cmd.Parameters.AddWithValue("asset_id", ticket.AssetID);
					cmd.Parameters.AddWithValue("ordernum", ticket.OrderNum);
					cmd.Parameters.AddWithValue("reported_type", ticket.ReportedType);
					cmd.Parameters.AddWithValue("open_dt", ticket.OpenDateTime);
					cmd.Parameters.AddWithValue("close_dt", null);
					cmd.Parameters.AddWithValue("solution_notes", null);
					cmd.Parameters.AddWithValue("reported_by", ticket.ReportedBy);
					cmd.Parameters.AddWithValue("notes", ticket.OSANotes);
					cmd.Parameters.AddWithValue("tech_id", ticket.TechID);
					cmd.Parameters.AddWithValue("techarrived_dt", null);
                    cmd.Parameters.AddWithValue("tech_on_site", false);
                    cmd.Parameters.AddWithValue("rental_active", false);
                    cmd.Parameters.AddWithValue("open_user", ticket.Open_UserID);
					cmd.Parameters.AddWithValue("close_user", null);
					cmd.Parameters.AddWithValue("billable", ticket.IsBillable);
					cmd.Parameters.AddWithValue("invoicing_notes", ticket.Invoice_Notes);
					cmd.Parameters.AddWithValue("symptom_other", ticket.Symptom_Other.Truncate(80));
					cmd.Parameters.AddWithValue("emailsent_osa", ticket.EmailSent_OSA);
					cmd.Parameters.AddWithValue("emailsent_open", ticket.EmailSent_Open);
					cmd.Parameters.AddWithValue("held", false);
					cmd.Parameters.AddWithValue("deleted", false);
					cmd.Parameters.AddWithValue("deleted_reason", null);
					cmd.Parameters.AddWithValue("override_close_email", null);
					cmd.Parameters.AddWithValue("tickettype", string.Empty);
                    cmd.Parameters.AddWithValue("issue_priority", ticket.IssuePriority);

                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					ticket.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}

				// Insert symptoms
				using (var cmd = conn.CreateCommand())
				{
					var ticketID = ticket.ID;
					var symptomValues = ticket.ExtraProperties.SymptomList.Select(symptom => $"({ticketID},{symptom.ID})").ToList();
					cmd.CommandText = $@"INSERT INTO ticket_symptoms (ticket_id, symptom_id) VALUES {string.Join(",", symptomValues.ToArray())};";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Ticket, ticket.ID, ClassAsset.GetName(ticket.AssetID));
		}

		/// <summary>
		/// Closes the ticket at the current time.
		/// Updates the ticket solutions and solution notes
		/// </summary>
		public void Close()
		{
			var closeDateTime = ClassDatabase.GetCurrentTime();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET solution_notes = @solution_notes,
							close_dt = @close_dt,
							close_user = @close_user_id
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("solution_notes", Solution_Notes);
					cmd.Parameters.AddWithValue("close_dt", closeDateTime);
					cmd.Parameters.AddWithValue("close_user_id", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();

					// Clear solutions
					cmd.Parameters.Clear();
					cmd.CommandText = @"DELETE FROM ticket_solutions WHERE ticket_id = @ticket_id;";
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();

					// Insert solutions
					if (ExtraProperties.SolutionList.Count > 0)
					{
						var ticketID = ID;
						var solutionValues = ExtraProperties.SolutionList.Select(solution => $"({ticketID},{solution.ID})").ToList();
						cmd.CommandText = string.Format(@"INSERT INTO ticket_solutions (ticket_id, solution_id) VALUES {0};", string.Join(",", solutionValues.ToArray()));
						cmd.ExecuteNonQuery();
					}
				}
				conn.Close();

				Close_UserID = GS.Settings.LoggedOnUser.ID;
				CloseDateTime = closeDateTime;
			}

			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Close, ClassEventLog.ObjectTypeEnum.Ticket, ID, ClassAsset.GetName(AssetID));
		}

		/// <summary>
		/// Reopens the ticket by clearing its close date and user.
		/// Set the ticket type (Monitoring or not) before calling.
		/// </summary>
		public void Reopen()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET close_dt = NULL,
							close_user = NULL
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Reopen, ClassEventLog.ObjectTypeEnum.Ticket, ID, ClassAsset.GetName(AssetID));
		}

		/// <summary>
		/// Deletes all images for specified ticket.
		/// </summary>
		public static void DeleteAllImages(int ticketID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM ticket_images
						WHERE ticket_id = @ticketID;";
					cmd.Parameters.AddWithValue("ticketID", ticketID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Marks ticket as deleted.
		/// </summary>
		/// <param name="deleteReason">Delete reason is stored in the ticket properties.</param>
		public void Delete(string deleteReason)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets SET
							deleted = 1,
							deleted_reason = @deleted_reason,
							deleted_date = NOW()
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("deleted_reason", deleteReason);
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Ticket, ID, ClassAsset.GetName(AssetID));
		}

		/// <summary>
		/// Restores the ticket (removes mark as deleted).
		/// </summary>
		public void Restore()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET deleted = 0, deleted_reason = '', deleted_date = NULL
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Restore, ClassEventLog.ObjectTypeEnum.Ticket, ID, ClassAsset.GetName(AssetID));
		}

		/// <summary>
		/// Puts ticket on hold until <paramref name="holdExpiration"/>.
		/// </summary>
		/// <seealso cref="Release"/>
		public void Hold(DateTime holdExpiration)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Add entry to ticket_holdlog
					cmd.CommandText =
						@"INSERT INTO ticket_holdlog
							(ticket_id, hold_start, expires)
							VALUES
							(@ticketID, NOW(), @expires);";
					cmd.Parameters.AddWithValue("ticketID", ID);
					cmd.Parameters.AddWithValue("expires", holdExpiration);
					cmd.ExecuteNonQuery();

					// Update ticket held boolean
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE tickets
							SET held = TRUE
							WHERE id = @ticketID;";
					cmd.Parameters.AddWithValue("ticketID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			IsHeld = true;
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Held, ClassEventLog.ObjectTypeEnum.Ticket, ID, ClassAsset.GetName(AssetID));
		}

		/// <summary>
		/// Releases ticket from hold.
		/// </summary>
		/// <seealso cref="Hold"/>
		public void Release()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Get most recent hold entry for the ticket
					cmd.CommandText =
						@"SELECT MAX(id)
							FROM ticket_holdlog
							WHERE ticket_id = @ticketID;";
					cmd.Parameters.AddWithValue("ticketID", ID);
					var holdID = Convert.ToInt32(cmd.ExecuteScalar());

					// Add entry to ticket_holdlog
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE ticket_holdlog
							SET hold_end = NOW()
							WHERE id = @holdID;";
					cmd.Parameters.AddWithValue("holdID", holdID);
					cmd.ExecuteNonQuery();

					// Update ticket held boolean
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE tickets
							SET held = FALSE
							WHERE id = @ticketID;";
					cmd.Parameters.AddWithValue("ticketID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			IsHeld = false;
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Released, ClassEventLog.ObjectTypeEnum.Ticket, ID, ClassAsset.GetName(AssetID));
		}

		/// <summary>
		/// Add image to ticket. Images are stored directly in database.
		/// </summary>
		public void AddImage(Image ticketImage, string imageDescription)
		{
			ClassTicket_Image.AddImage(ID, ticketImage, imageDescription);
		}

		/// <summary>
		/// Returns a list of <see cref="TicketHoldData"/> for tickets on hold but have expired.
		/// </summary>
		public static IEnumerable<TicketHoldData> GetExpiredHolds()
		{
			var expiredHeldTickets = new List<TicketHoldData>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.id, hl.expires
						FROM tickets t
							LEFT JOIN ticket_holdlog hl ON hl.ticket_id = t.id
						WHERE t.held = TRUE
							AND t.deleted IS FALSE
							AND hl.hold_end IS NULL
							AND hl.expires <= NOW();";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							expiredHeldTickets.Add(new TicketHoldData { TicketID = reader.GetDBInt("id"), HoldExpirationDate = reader.GetDBDateTime("expires") });
				}
				conn.Close();
			}
			return expiredHeldTickets;
		}

		/// <summary>
		/// Gets total hold time for the specified ticket.
		/// </summary>
		public static TimeSpan GetTotalHoldTime(int ticketID)
		{
			int? totalSeconds = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT SUM(TIME_TO_SEC(TIMEDIFF(hold_end, hold_start))) AS hold_total
						FROM ticket_holdlog
						WHERE ticket_id = @ticket_id;";
					cmd.Parameters.AddWithValue("ticket_id", ticketID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							totalSeconds = reader.GetDBInt_Null("hold_total");
						}
				}
				conn.Close();
			}
			return TimeSpan.FromSeconds(totalSeconds.GetValueOrDefault(0));
		}

		/// <summary>
		/// Releases tickets where the hold expiration date has elapsed.
		/// </summary>
		public static void ReleaseExpiredHolds()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets t
							LEFT JOIN ticket_holdlog hl ON hl.ticket_id = t.id
						SET hl.hold_end = hl.expires,
						t.held = FALSE
						WHERE hl.hold_end IS NULL
						AND hl.expires <= NOW();";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Gets a list of PMA IDs that have been completed for the specified ticket.
		/// </summary>
		public static List<int> GetCompletedPmas(int ticketID)
		{
			var completedPmas = new List<int>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT pma_id
						FROM ticket_pmas
						WHERE ticket_id = @TicketID;";
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							completedPmas.Add(reader.GetDBInt("pma_id"));
					conn.Close();
				}
			}
			return completedPmas;
		}

		/// <summary>
		/// Writes the list of PMA IDs that have been completed for the specified ticket.
		/// </summary>
		public static void SetCompletedPmas(int ticketID, List<int> completedPmAs)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();

					// Clear existing list
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					cmd.CommandText =
						@"DELETE FROM ticket_pmas
						WHERE ticket_id = @TicketID;";
					cmd.ExecuteNonQuery();

					// Write new list
					if (completedPmAs.Count > 0)
					{
						cmd.CommandText =
							string.Format(@"INSERT INTO ticket_pmas
						(ticket_id, pma_id)
						VALUES
						{0};", string.Join(",", completedPmAs.Select(i => string.Format("({0},{1})", ticketID, i))));
						cmd.ExecuteNonQuery();
					}

					conn.Close();
				}
			}
		}

		/// <summary>
		/// Sets assigned tech_id for the specified ticket.
		/// </summary>
		public void AssignTech(ClassTech newTech)
		{
			var oldTechName = string.Empty;
			if (TechID.HasValue)
				oldTechName = ClassTech.GetName(TechID);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET tech_id = @tech_id
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("tech_id", newTech.ID);
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			TechID = newTech.ID;
			ExtraProperties.AssignedTechName = newTech.TechName;
			var techAssignMessage = string.IsNullOrEmpty(oldTechName) ? $"Assigned tech {newTech.TechName}" : $"Changed tech from {oldTechName} to {newTech.TechName}";
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Ticket, ID, techAssignMessage);
		}

		/// <summary>
		/// Associate ticket with different asset.
		/// </summary>
		public void ChangeAsset(ClassAsset newAsset)
		{
			var oldAssetName = ClassAsset.GetName(AssetID);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"UPDATE tickets t
						SET t.asset_id = @assetID
						WHERE t.id = @ticketID;";
					cmd.Parameters.AddWithValue("assetID", newAsset.ID);
					cmd.Parameters.AddWithValue("ticketID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			AssetID = newAsset.ID;
			ExtraProperties.AssetName = newAsset.AssetName;
			ExtraProperties.AssetPanelName = newAsset.Panel;
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Ticket, ID, $"Reassigned from {oldAssetName} to {newAsset.AssetName}");
		}

		/// <summary>
		/// Changes ticket OSA notes.
		/// </summary>
		public void UpdateOsaNotes(string newOsaNotes, int IssueP)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
                        @"UPDATE tickets
						SET notes = @newOsaNotes,
                            issue_priority = @issue_priority
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("newOsaNotes", newOsaNotes);
                    cmd.Parameters.AddWithValue("issue_priority", IssueP);
                    cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			OSANotes = newOsaNotes;
            IssuePriority = IssueP;
		}



        /// <summary>
        /// Overrides the market 'send email on close' setting.
        /// Null = Use market preference (default)
        /// 0 = Do not send email on close
        /// 1 = Send email on close
        /// </summary>
        public void SetOverrideCloseEmail(bool? overrideSetting = null)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET override_close_email = @overrideSetting
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.Parameters.AddWithValue("overrideSetting", overrideSetting);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			OverrideCloseEmail = overrideSetting;
		}

		/// <summary>
		/// Changes whether the ticket is Covered or Billable.
		/// </summary>
		public void SetBillable(bool isBillable)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET billable = @isBillable
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("isBillable", isBillable);
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Ticket, ID, "Invoice notes: " + (isBillable ? "Billable" : "Covered"));
		}

		/// <summary>
		/// Updates ticket <see cref="Invoice_Notes"/>.
		/// </summary>
		public void SetInvoiceNotes(string notes)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET invoicing_notes = @notes
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("notes", notes);
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			Invoice_Notes = notes;
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Ticket, ID, "Invoice notes.");
		}

		/// <summary>
		/// Change ticket <see cref="CustomerIssueNumber"/>.
		/// </summary>
		public void SetIssueNumber(string newIssueNumber)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets
						SET issue = @newIssueNumber
						WHERE id = @ticket_id;";
					cmd.Parameters.AddWithValue("newIssueNumber", newIssueNumber);
					cmd.Parameters.AddWithValue("ticket_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			var oldIssue = CustomerIssueNumber;
			CustomerIssueNumber = newIssueNumber;
			var entry = $"Issue number '{oldIssue}' to '{newIssueNumber}'";
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Ticket, ID, entry);
		}
		#endregion
	}
}