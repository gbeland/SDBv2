using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	public class ClassTicket_Hold
	{
		public int ID { get; set; }
		public int TicketID { get; set; }
		/// <summary>
		/// When hold started
		/// </summary>
		public DateTime HoldStart { get; set; }
		/// <summary>
		/// When hold ended (may be before expiration; may be after expiration due to latency)
		/// </summary>
		public DateTime? HoldEnd { get; set; }
		/// <summary>
		/// When hold expires
		/// </summary>
		public DateTime HoldExpires { get; set; }

		public static List<ClassTicket_Hold> GetLogByTicket(int ticketID)
		{
			List<ClassTicket_Hold> ticketHolds = new List<ClassTicket_Hold>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, ticket_id, hold_start, hold_end, expires
						FROM ticket_holdlog
						WHERE ticket_id = @ticketID
						ORDER BY id ASC;";
					cmd.Parameters.AddWithValue("ticketID", ticketID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							ClassTicket_Hold ticketHold = new ClassTicket_Hold
							{
								ID = reader.GetDBInt("id"),
								TicketID = reader.GetDBInt("ticket_id"),
								HoldStart = reader.GetDBDateTime("hold_start"),
								HoldEnd = reader.GetDBDateTime_Null("hold_end"),
								HoldExpires = reader.GetDBDateTime("expires")
							};
							ticketHolds.Add(ticketHold);
						}
					}
				}
				conn.Close();
			}
			return ticketHolds;
		}
	}
}