using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;

namespace SDB.Classes
{
	/// <summary>
	/// This ticket class should be used when working with multiple tickets in a list.
	/// Multi tickets are for lists where speed is a concern.
	/// </summary>
	public class ClassTicket_Multi
	{
		//public enum TicketTypeEnum { Open, Pending, Monitoring, Closed, Deleted };

		public int ID { get; set; }
		public int AssetID { get; set; }
		/// <summary>
		/// Optional for certain views (must join assets table to populate)
		/// </summary>
		public string AssetName { get; set; }
		/// <summary>
		/// Optional for certain views (must join assets table to populate)
		/// </summary>
		public string AssetPanel { get; set; }
		/// <summary>
		/// Optional for certain views (must join assets table to populate)
		/// </summary>
		public string AssetLocation { get; set; }
		public string IssueNum { get; set; }
		public string OrderNum { get; set; }
		public DateTime OpenDT { get; set; }
		public DateTime? CloseDT { get; set; }
		//public DateTime? PendingDT { get; set; }
		/// <summary>
		/// How the ticket was reported (email, phone, etc.)
		/// </summary>
		public string ReportedType { get; set; }
		public string ReportedBy { get; set; }
		/// <summary>
		/// notes (OSA Notes)
		/// </summary>
		public string Notes { get; set; }
		public string Symptom_Other { get; set; }
		public int? TechID { get; set; }
		/// <summary>
		/// Optional for certain views (must join techs table to populate)
		/// </summary>
		public string TechName { get; set; }
		public int Open_UserID { get; set; }
		public int? Close_UserID { get; set; }
		public string Invoice_Notes { get; set; }
		public string Solution_Notes { get; set; }
		public DateTime? FirstTechArrivedDT { get; set; }
		public bool EmailSent_OSA { get; set; }
		public bool EmailSent_OPEN { get; set; }
		//public int? RentalID { get; set; }
		//public string RentalPickUpNumber { get; set; }
		public bool IsHeld { get; set; }
		public bool IsDeleted { get; set; }
		public string DeleteReason { get; set; }

		public string Symptoms { get; set; }

		public string Solutions { get; set; }

		public TimeSpan Duration
		{
			get { return CloseDT.HasValue ? CloseDT.Value - OpenDT : DateTime.Now - OpenDT; }
		}

		public TimeSpan TechArrivedDuration
		{
			get { return FirstTechArrivedDT.HasValue ? FirstTechArrivedDT.Value - OpenDT : TimeSpan.Zero; }
		}

		public bool IsClosed
		{
			get { return CloseDT.HasValue; }
		}

		//public bool IsPending
		//{
		//    get { return PendingDT.HasValue && !CloseDT.HasValue; }
		//}

		public Color StatusColor_Foreground
		{
			get
			{
				if (IsDeleted)
					return ClassTicket.COL_TICKET_DELETED_FG;

				if (IsClosed)
					return ClassTicket.COL_TICKET_CLOSED_FG;

				if (IsHeld)
					return ClassTicket.COL_TICKET_HELD_FG;

				return TechID.HasValue ? ClassTicket.COL_TICKET_OPEN_OSA_FG : ClassTicket.COL_TICKET_OPEN_FG;
			}
		}

		public Color StatusColor_Background
		{
			get
			{
				if (IsDeleted)
					return ClassTicket.COL_TICKET_DELETED_BG;

				if (IsClosed)
					return ClassTicket.COL_TICKET_CLOSED_BG;

				if (IsHeld)
					return ClassTicket.COL_TICKET_HELD_BG;

				return TechID.HasValue ? ClassTicket.COL_TICKET_OPEN_OSA_BG : ClassTicket.COL_TICKET_OPEN_BG;
			}
		}

		public override string ToString()
		{
			return ID.ToString();
		}

		public ClassTicket_Multi()
		{
			ID = -1;
			AssetID = -1;
		}

		/// <summary>
		/// The TicketMulti class requires a group_concat of solutions and symptoms when populating the datareader.
		/// For example: SELECT t.id, GROUP_CONCAT(DISTINCT s.symptom SEPARATOR ', ') symptoms, GROUP_CONCAT(DISTINCT l.solution SEPARATOR ', ')
		/// FROM tickets t, ticket_symptoms ts, symptoms s, ticket_solutions tl, solutions l
		/// WHERE t.id = ts.ticket_id
		/// AND t.id = tl.ticket_id
		/// AND ts.symptom_id = s.id
		/// AND tl.solution_id = l.id
		/// GROUP BY t.id;
		/// </summary>
		static private ClassTicket_Multi GetTicketMultiFromReader(MySqlDataReader reader)
		{
			var ticketID = reader.GetDBInt_Null("id");
			if (!ticketID.HasValue)
				return null;

			var ticket = new ClassTicket_Multi
			             {
				             ID = ticketID.Value,
				             AssetID = reader.GetDBInt("asset_id"),
				             IssueNum = reader.GetDBString("issue"),
				             OrderNum = reader.GetDBString("ordernum"),
				             ReportedType = reader.GetDBString("reported_type"),
				             OpenDT = reader.GetDBDateTime("open_dt"),
				             CloseDT = reader.GetDBDateTime_Null("close_dt"),
				             IsHeld = reader.GetDBBool("held"),
				             Solution_Notes = reader.GetDBString("solution_notes"),
				             ReportedBy = reader.GetDBString("reported_by"),
				             Notes = reader.GetDBString("notes"),
				             Symptom_Other = reader.GetDBString("symptom_other"),
				             TechID = reader.GetDBInt_Null("tech_id"),
				             Open_UserID = reader.GetDBInt("open_user"),
				             Close_UserID = reader.GetDBInt_Null("close_user"),
				             Invoice_Notes = reader.GetDBString("invoicing_notes"),
				             FirstTechArrivedDT = reader.GetDBDateTime_Null("techarrived_dt"),
				             EmailSent_OSA = reader.GetDBBool("emailsent_osa"),
				             EmailSent_OPEN = reader.GetDBBool("emailsent_open"),
				             IsDeleted = reader.GetDBBool("deleted"),
				             DeleteReason = reader.GetDBString("deleted_reason")
			             };

			return ticket;
		}

		/// <summary>
		/// Finds non-deleted tickets having <paramref name="searchTerm"/> in the ticket or customer issue number.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> TicketSearch(string searchTerm)
		{
			var foundTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND (t.id = @SearchTerm
							OR t.issue = @SearchTerm)
						ORDER BY t.id ASC;";
					cmd.Parameters.AddWithValue("SearchTerm", searchTerm);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							foundTickets.Add(t);
						}
					conn.Close();
				}
			}
			Tickets_PopulateSymptomsSolutions(foundTickets);
			return foundTickets;
		}

		/// <summary>
		/// Finds ticket having SearchTerm in the following fields:
		/// Ticket Number, Issue Number, Asset Name, Panel Number, Assigned Tech
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> TicketSearchAll(string searchTerm)
		{
			var foundTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND (t.id LIKE @SearchTerm
							OR t.issue LIKE @SearchTerm
							OR a.asset LIKE @SearchTerm
							OR a.panel LIKE @SearchTerm
							OR h.tech LIKE @SearchTerm)
						ORDER BY t.id ASC;";
					cmd.Parameters.AddWithValue("SearchTerm", string.Format("%{0}%", searchTerm));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							foundTickets.Add(t);
						}
					conn.Close();
				}
			}
			Tickets_PopulateSymptomsSolutions(foundTickets);
			return foundTickets;
		}

		/// <summary>
		/// Finds deleted tickets having SearchTerm in the ticket or customer issue number.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> TicketSearch_Deleted(string searchTerm)
		{
			var foundDeletedTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = TRUE
						AND (t.id = @SearchTerm
							OR t.issue = @SearchTerm)
						ORDER BY t.id ASC;";
					cmd.Parameters.AddWithValue("SearchTerm", searchTerm);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							foundDeletedTickets.Add(t);
						}
					conn.Close();
				}
			}
			Tickets_PopulateSymptomsSolutions(foundDeletedTickets);
			return foundDeletedTickets;
		}

		/// <summary>
		/// Gets all tickets opened between StartDate and EndDate.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_ByOpenDate(DateTime startDate, DateTime endDate)
		{
			var ticketsInRange = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT
							t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							JOIN techs h ON t.tech_id = h.id
						WHERE 
							t.deleted = FALSE
							AND t.open_dt >= @StartDate
							AND t.open_dt <= @EndDate
						ORDER BY t.open_dt ASC;";
					cmd.Parameters.AddWithValue("StartDate", startDate);
					cmd.Parameters.AddWithValue("EndDate", endDate);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							ticketsInRange.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(ticketsInRange);
			return ticketsInRange;
		}

		/// <summary>
		/// Gets all tickets opened between StartDate and EndDate.
		/// If Customer is specified, only tickets for that customer will be retrieved.
		/// If Asset is specified, only tickets for that assets will be retrieved.
		/// If Tech is specified, only tickets assigned to that tech will be retrieved.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_ForReport(ClassReporting.ClassReportRequestObject reportRequest)
		{
			var ticketsInRange = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a on t.asset_id = a.id
							JOIN markets m ON a.market_id = m.id
							JOIN customers c ON m.customer_id = c.id
							JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND t.open_dt >= @StartDate
						AND t.open_dt <= @EndDate
						{0}
						{1}
						{2}
						ORDER BY t.open_dt ASC;",
									  reportRequest.Customers.Count > 0 ? @"AND c.id IN (@CustomerID)" : string.Empty,
									  reportRequest.Assets.Count > 0 ? @"AND a.id IN (@AssetID)" : string.Empty,
									  reportRequest.Techs.Count > 0 ? @"AND h.id IN (@TechID)" : string.Empty);
					cmd.Parameters.AddWithValue("StartDate", reportRequest.DateFrom);
					cmd.Parameters.AddWithValue("EndDate", reportRequest.DateTo);
					if (reportRequest.Customers.Count > 0)
						cmd.Parameters.AddWithValue("CustomerID", String.Join(",", reportRequest.Customers.Select(c => c.ID).ToArray()));
					if (reportRequest.Assets.Count > 0)
						cmd.Parameters.AddWithValue("AssetID", String.Join(",", reportRequest.Assets.Select(a => a.ID).ToArray()));
					if (reportRequest.Techs.Count > 0)
						cmd.Parameters.AddWithValue("TechID", String.Join(",", reportRequest.Techs.Select(t => t.ID).ToArray()));
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							ticketsInRange.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(ticketsInRange);
			return ticketsInRange;
		}

		/// <summary>
		/// Gets all open tickets.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_Open()
		{
			var openTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND t.close_dt IS NULL
						ORDER BY t.id DESC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							openTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(openTickets);
			return openTickets;
		}

		/// <summary>
		/// Gets all open tickets for specified customer.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_Open(ClassCustomer customer)
		{
			var openTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							JOIN markets m ON a.market_id = m.id
							JOIN customers c ON m.customer_id = c.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE c.id = @CustomerID
						AND t.deleted = FALSE
						AND t.close_dt IS NULL
						ORDER BY t.id DESC;";
					cmd.Parameters.AddWithValue("CustomerID", customer.ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							openTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(openTickets);
			return openTickets;
		}

        /// <summary>
        /// Gets all open tickets for specified asset.
        /// </summary>
        static public IEnumerable<ClassTicket_Multi> GetTickets_Open(ClassAsset asset)
        {
            var openTickets = new List<ClassTicket_Multi>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							JOIN markets m ON a.market_id = m.id
							JOIN customers c ON m.customer_id = c.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE a.id = @AssetID
						AND t.deleted = FALSE
						AND t.close_dt IS NULL
						ORDER BY t.id DESC;";
                    cmd.Parameters.AddWithValue("AssetID", asset.ID);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            var t = GetTicketMultiFromReader(reader);
                            t.AssetName = reader.GetDBString("asset");
                            t.AssetPanel = reader.GetDBString("panel");
                            t.TechName = reader.GetDBString("tech_name");
                            openTickets.Add(t);
                        }
                }
                conn.Close();
            }
            Tickets_PopulateSymptomsSolutions(openTickets);
            return openTickets;
        }

        /// <summary>
        /// Gets all open tickets for specified tech.
        /// </summary>
        static public IEnumerable<ClassTicket_Multi> GetTickets_Open(ClassTech tech)
		{
			var techOpenTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, a.location, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE h.id = @TechID
						AND t.deleted = FALSE
						AND t.close_dt IS NULL
						ORDER BY t.id DESC;";
					cmd.Parameters.AddWithValue("TechID", tech.ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.AssetLocation = reader.GetDBString("location");
							t.TechName = reader.GetDBString("tech_name");
							techOpenTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(techOpenTickets);
			return techOpenTickets;
		}

		/// <summary>
		/// Gets all open tickets for specified market.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_Open(ClassMarket market)
		{
			var marketOpenTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, a.location, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							JOIN markets m ON a.market_id = m.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE m.id = @marketID
							AND t.deleted = FALSE
							AND t.close_dt IS NULL
						ORDER BY t.id DESC;";
					cmd.Parameters.AddWithValue("marketID", market.ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.AssetLocation = reader.GetDBString("location");
							t.TechName = reader.GetDBString("tech_name");
							marketOpenTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(marketOpenTickets);
			return marketOpenTickets;
		}

		/// <summary>
		/// Gets all closed tickets since specified date.
		/// (All closed if unspecified.)
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_Closed(DateTime? sinceDate = null)
		{
			var closedTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND t.close_dt IS NOT NULL
						{0}
						ORDER BY t.id ASC;", sinceDate.HasValue ? @"AND t.close_dt >= @SinceDate" : string.Empty);
					cmd.Parameters.AddWithValue("SinceDate", sinceDate);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							closedTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(closedTickets);
			return closedTickets;
		}

		/// <summary>
		/// Gets all closed tickets for specified tech since specified date.
		/// (All closed tickets for specified tech if date is unspecified.)
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_Closed(ClassTech tech, DateTime? sinceDate = null)
		{
			var techsClosedTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE h.id = @TechID
						AND t.deleted = FALSE
						AND t.close_dt IS NOT NULL
						{0}
						ORDER BY t.id ASC;", sinceDate.HasValue ? @"AND t.close_dt >= @SinceDate" : string.Empty);
					cmd.Parameters.AddWithValue("TechID", tech.ID);
					cmd.Parameters.AddWithValue("SinceDate", sinceDate);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							techsClosedTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(techsClosedTickets);
			return techsClosedTickets;
		}

        /// <summary>
        /// Gets a list of tickets from a market since a particular date
        /// </summary>
        /// <param name="market"></param>
        /// <param name="sinceDate"></param>
        /// <returns></returns>
        static public IEnumerable<ClassTicket_Multi> GetClosedTickets_ByMarket_SinceDate(ClassMarket market, DateTime? sinceDate = null)
        {
            var marketClosedTickets = new List<ClassTicket_Multi>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        string.Format(@"SELECT t.*, a.asset, a.panel, a.location, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							JOIN markets m ON a.market_id = m.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE m.id = @marketID
							AND t.deleted = FALSE
                            AND t.close_dt IS NOT NULL
                            {0}
						ORDER BY t.id DESC;", sinceDate.HasValue ? @"AND t.close_dt >= @SinceDate" : string.Empty);
                    cmd.Parameters.AddWithValue("marketID", market.ID);
                    cmd.Parameters.AddWithValue("SinceDate", sinceDate);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            var t = GetTicketMultiFromReader(reader);
                            t.AssetName = reader.GetDBString("asset");
                            t.AssetPanel = reader.GetDBString("panel");
                            t.TechName = reader.GetDBString("tech_name");
                            marketClosedTickets.Add(t);
                        }
                }
                conn.Close();
            }
            Tickets_PopulateSymptomsSolutions(marketClosedTickets);
            return marketClosedTickets;
        }

        /// <summary>
        /// Gets the closed tickets, offsetting by the PageOffset and returning at most MaxResults.
        /// PageOffset is multiplied by the MaxResults to get the "page". For example, if PageOffset is 2
        /// and MaxResults is 1000, then records from 2000 to 2999 are retrieved.
        /// </summary>
        static public IEnumerable<ClassTicket_Multi> GetTickets_Closed(int? pageOffset, int maxResults)
		{
			var closedTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND t.close_dt IS NOT NULL
						ORDER BY t.id DESC
						LIMIT {0}{1};", pageOffset.HasValue ? string.Format("{0},", pageOffset.Value * maxResults) : string.Empty, maxResults);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							closedTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(closedTickets);
			return closedTickets;
		}

		static public IEnumerable<ClassTicket_Multi> GetTickets_Deleted()
		{
			var deletedTickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = TRUE
						ORDER BY t.id DESC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							deletedTickets.Add(t);
						}
				}
				conn.Close();
			}
			Tickets_PopulateSymptomsSolutions(deletedTickets);
			return deletedTickets;
		}

		/// <summary>
		/// Gets all tickets assigned to specified tech.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_ByTech(int techID)
		{
			var tickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND t.tech_id = @TechID
						ORDER BY t.id ASC;";
					cmd.Parameters.AddWithValue("TechID", techID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							tickets.Add(t);
						}
					conn.Close();
				}
			}
			Tickets_PopulateSymptomsSolutions(tickets);
			return tickets;
		}

		/// <summary>
		/// Gets all tickets for specified asset.
		/// </summary>
		static public IEnumerable<ClassTicket_Multi> GetTickets_ByAsset(int assetID)
		{
			var tickets = new List<ClassTicket_Multi>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT t.*, a.asset, a.panel, h.tech tech_name
						FROM tickets t
							JOIN assets a ON t.asset_id = a.id
							LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						AND t.asset_id = @AssetID
						ORDER BY t.id ASC;";
					cmd.Parameters.AddWithValue("AssetID", assetID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var t = GetTicketMultiFromReader(reader);
							t.AssetName = reader.GetDBString("asset");
							t.AssetPanel = reader.GetDBString("panel");
							t.TechName = reader.GetDBString("tech_name");
							tickets.Add(t);
						}
					conn.Close();
				}
			}
			Tickets_PopulateSymptomsSolutions(tickets);
			return tickets;
		}

		static private void Tickets_PopulateSymptomsSolutions(IEnumerable<ClassTicket_Multi> multiTicketList)
		{
			List<ClassTicket_Symptom> allSymptoms = ClassTicket_Symptom.GetAll().ToList();
			List<ClassTicket_Solution> allSolutions = ClassTicket_Solution.GetAll().ToList();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				foreach (var t in multiTicketList)
				{
					using (var cmd = conn.CreateCommand())
					{
						var symIDs = new List<int>();
						var solIDs = new List<int>();
						cmd.CommandText = @"SELECT symptom_id FROM ticket_symptoms WHERE ticket_id = @TicketID;";
						cmd.Parameters.AddWithValue("TicketID", t.ID);
						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
								symIDs.Add(reader.GetDBInt("symptom_id"));
						cmd.CommandText = @"SELECT solution_id FROM ticket_solutions WHERE ticket_id = @TicketID;";
						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
								solIDs.Add(reader.GetDBInt("solution_id"));
						t.Symptoms = String.Join(", ", allSymptoms.Where(s => symIDs.Contains(s.ID)).Select(s => s.Symptom).ToList());
						t.Solutions = String.Join(", ", allSolutions.Where(s => solIDs.Contains(s.ID)).Select(s => s.Solution).ToList());
					}
				}
				conn.Close();
			}
		}
	}
}