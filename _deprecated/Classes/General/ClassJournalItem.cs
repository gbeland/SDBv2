using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using SDB.Classes.Asset;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Ticket;

namespace SDB.Classes.General
{
	/// <summary>
	/// Journal items are individual entries for tickets, shipments, RMA's, etc.
	/// </summary>
	public class ClassJournalItem
	{
		// ReSharper disable InconsistentNaming
		internal static readonly Color COL_JOURNAL_OUTOFDATE_RED_BG = Color.FromArgb(255, 128, 128);
		internal static readonly Color COL_JOURNAL_OUTOFDATE_SOFT_BG = Color.FromArgb(255, 192, 192);
		internal static readonly Color COL_JOURNAL_OUTOFDATE_ORANGE_BG = Color.FromArgb(255, 150, 100);
		internal static readonly Color COL_JOURNAL_OUTOFDATE_YELLOW_BG = Color.FromArgb(255, 255, 159);
		internal static readonly Color COL_JOURNAL_SYSTEM_BLUE_FG = Color.MediumBlue;
		// ReSharper restore InconsistentNaming

		public int ID { get; set; }
		public int Parent_ID { get; set; }
		public int User_ID { get; set; }
		/// <summary>
		/// Optional user name for certain views, must join with users table when populating.
		/// </summary>
		public string User_Name { get; set; }
		public string JournalText { get; set; }
		public DateTime JournalDateTime { get; set; }
		public DateTime? ExpireDateTime { get; set; }
		public bool IsSystemMessage { get; set; }

		/// <summary>
		/// True if the journal entry has an expiration date that has elapsed.
		/// (Never true if expiration date was not specified.)
		/// </summary>
		public bool IsExpired => ExpireDateTime.HasValue && DateTime.Now > ExpireDateTime;

		/// <summary>
		/// Used for sorting tickets by journal expirations. Entries without expirations have a "soft" expiration of 24 hours.
		/// This property provides that expiration in the absence of a hard expiration.
		/// </summary>
		[UsedImplicitly]
		public DateTime SoftExpireDateTime => ExpireDateTime.HasValue ? ExpireDateTime.Value : JournalDateTime.AddHours(24);

		[XmlIgnore]
		public const int MAX_JOURNAL_LENGTH = 65535;

		public override string ToString()
		{
			return string.Format("[{0}] Parent {1}, User {2}, Text {3}, Date {4:yyyyMMddHHmmss}, System: {5}", ID, Parent_ID, User_ID, JournalText.Truncate(16), JournalDateTime, IsSystemMessage ? "True" : "False");
		}

		public ClassJournalItem()
		{
			JournalText = "[Blank]";
			ExpireDateTime = DateTime.Now;
		}

		#region GENERIC
		/// <summary>
		/// Gets all Journal Items for specified object in ID sequence.
		/// </summary>
		public static IEnumerable<ClassJournalItem> GetAll(object journalParent)
		{
			List<ClassJournalItem> entries = new List<ClassJournalItem>();

			if (journalParent == null)
				return entries;

			if (!(journalParent is ClassTicket || journalParent is ClassAsset || journalParent is ClassShipment || journalParent is ClassRMA))
				throw new ArgumentException("Object does not support journals.", nameof(journalParent));

			string tableName, linkerName;
			int parentID;

			if (journalParent is ClassTicket)
			{
				tableName = "ticket_journal";
				linkerName = "ticket_id";
				parentID = ((ClassTicket)journalParent).ID;
			}
			else if (journalParent is ClassAsset)
			{
				tableName = "asset_journal";
				linkerName = "asset_id";
				parentID = ((ClassAsset)journalParent).ID;
			}
			else if (journalParent is ClassShipment)
			{
				tableName = "shipment_journal";
				linkerName = "shipment_id";
				parentID = ((ClassShipment)journalParent).ID;
			}
			else
			{
				tableName = "rma_journal";
				linkerName = "rma_id";
				parentID = ((ClassRMA)journalParent).ID;
			}
			
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						string.Format(@"SELECT j.*, j.{0} parent_id, CONCAT(u.firstname, LEFT(u.lastname, 1)) user_name
						FROM {1} j
							JOIN users u ON j.user_id = u.userid
						WHERE j.{0} = @parentID
						ORDER BY j.id ASC;", linkerName, tableName);
					cmd.Parameters.AddWithValue("parentID", parentID);

					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							ClassJournalItem j = GetFromReader(reader);
							j.User_Name = reader.GetDBString("user_name");
							entries.Add(j);
						}
					conn.Close();
				}
			}
			return entries;
		}

		/// <summary>
		/// Gets the last journal entry for specified object.
		/// </summary>
		public static ClassJournalItem GetLast(object journalParent)
		{
			if (!(journalParent is ClassTicket || journalParent is ClassAsset || journalParent is ClassShipment || journalParent is ClassRMA))
				throw new ArgumentException("Object does not support journals.", nameof(journalParent));

			string tableName, linkerName;
			int parentID;

			if (journalParent is ClassTicket ticket)
			{
				tableName = "ticket_journal";
				linkerName = "ticket_id";
				parentID = ticket.ID;
			}
			else if (journalParent is ClassAsset)
			{
				tableName = "asset_journal";
				linkerName = "asset_id";
				parentID = ((ClassAsset)journalParent).ID;
			}
			else if (journalParent is ClassShipment)
			{
				tableName = "shipment_journal";
				linkerName = "shipment_id";
				parentID = ((ClassShipment)journalParent).ID;
			}
			else
			{
				tableName = "rma_journal";
				linkerName = "rma_id";
				parentID = ((ClassRMA)journalParent).ID;
			}
			
			var journalItem = new ClassJournalItem();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"SELECT j.*, j.{0} parent_id, CONCAT(u.firstname, LEFT(u.lastname, 1)) user_name
						FROM {1} j
							JOIN users u ON j.user_id = u.userid
						WHERE j.{0} = @parentID
						ORDER BY j.id DESC
						LIMIT 0,1;", linkerName, tableName);
					cmd.Parameters.AddWithValue("parentID", parentID);

					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							journalItem = GetFromReader(reader);
							journalItem.User_Name = reader.GetDBString("user_name");
						}
				}
				conn.Close();
			}
			return journalItem;
		}

		/// <summary>
		/// Gets the last journal entry for every ticket in list (in one query).
		/// </summary>
		public static void PopulateLastEntriesForTicketList(List<ClassTicket> tickets)
		{
			if (!tickets.Any())
				return;

			var parentIds = tickets.Select(t => t.ID);
			var entries = new List<ClassJournalItem>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = $@"SELECT
							tj.id, tj.ticket_id parent_id, tj.dt, tj.user_id, tj.user_text, tj.expire_dt, tj.system_msg,
							CONCAT(u.firstname, LEFT(u.lastname, 1)) user_name
						FROM ticket_journal tj
						JOIN users u ON tj.user_id = u.userid
						LEFT JOIN ticket_journal tj2
							ON (tj.ticket_id = tj2.ticket_id AND tj.id < tj2.id)
						WHERE tj2.id IS NULL
						AND tj.ticket_id in ({string.Join(",", parentIds)});";

					using (var reader = cmd.ExecuteReader())
						while (reader.HasRows && reader.Read())
						{
							var entry = GetFromReader(reader);
							entry.User_Name = reader.GetDBString("user_name");
							entries.Add(entry);
						}
				}
				conn.Close();
			}
			foreach (var ticket in tickets)
				ticket.ExtraProperties.Journal.Entries.Add(entries.Single(e => e.Parent_ID == ticket.ID));
		}

		private static ClassJournalItem GetFromReader(MySqlDataReader reader)
		{
			var journalItem = new ClassJournalItem
			{
				ID = reader.GetDBInt("id"),
				Parent_ID = reader.GetDBInt("parent_id"),
				User_ID = reader.GetDBInt("user_id"),
				JournalText = reader.GetDBString("user_text").Trim(),
				JournalDateTime = reader.GetDBDateTime("dt"),
				ExpireDateTime = reader.GetDBDateTime_Null("expire_dt"),
				IsSystemMessage = reader.GetDBBool("system_msg")
			};
			return journalItem;
		}
		#endregion
		
		/// <summary>
		/// Populates and formats a textbox according to a standard format.
		/// </summary>
		public void PopulateTextBox(TextBox tb)
		{
			tb.Text = JournalText;
			tb.ForeColor = IsSystemMessage ? COL_JOURNAL_SYSTEM_BLUE_FG : IsExpired ? Color.DarkRed : Color.Black;
		}
	}
}