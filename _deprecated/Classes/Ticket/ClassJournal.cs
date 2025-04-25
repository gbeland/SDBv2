using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDB.Classes
{
	public class ClassJournal
	{
		public enum ExpirationType
		{
			Required,
			NotRequired
		}

		private static readonly TimeSpan _journalExpirationSystemDefault = TimeSpan.FromMinutes(10);

		private struct JournalTableInfo
		{
			public string TableName;
			public string LinkerName;
			public int ParentID;
		}

		public List<ClassJournalItem> Entries { get; private set; }

		public ClassJournal()
		{
			Entries = new List<ClassJournalItem>();
		}

		public void Add(ClassJournalItem entry)
		{
			Entries.Add(entry);
			Entries = Entries.OrderBy(e => e.ID).ToList();
		}

		/// <summary>
		/// Provides the last entry, whether system or user. If no entries exist, a blank one is provided.
		/// </summary>
		public ClassJournalItem LastEntry
		{
			get { return Entries.Count > 0 ? Entries.Last() : new ClassJournalItem(); }
		}

		/// <summary>
		/// Provides the last user entry, if available. If all entries are system entries, the last system entry is provided.
		/// If no entries exist, a blank one is provided.
		/// </summary>
		public ClassJournalItem LastUserEntry
		{
			get
			{
				if (Entries.Count < 1)
					return new ClassJournalItem();

				return Entries.Any(e => !e.IsSystemMessage) ? Entries.Last(e => !e.IsSystemMessage) : Entries.Last();
			}
		}

		/// <summary>
		/// Provides the last system entry, if available. If all entries are user entries, the last user entry is provided.
		/// If no entries exist, a blank one is provided.
		/// </summary>
		public ClassJournalItem LastSystemEntry
		{
			get
			{
				if (Entries.Count < 1)
					return new ClassJournalItem();

				return Entries.Any(e => e.IsSystemMessage) ? Entries.Last(e => e.IsSystemMessage) : Entries.Last();
			}
		}

		/// <summary>
		/// Returns the number of journal entries.
		/// </summary>
		public int Count
		{
			get { return Entries.Count; }
		}

		/// <summary>
		/// Retrieves the journal for the specified parent (ticket, asset, shipment, etc.)
		/// </summary>
		public static ClassJournal GetByObject(object journalParent)
		{
			var journal = new ClassJournal();
			journal.Entries = ClassJournalItem.GetAll(journalParent).ToList();
			return journal;
		}

		public static ClassJournal GetLastEntryByObject(object journalParent)
		{
			var journalWithOnlyLastEntry = new ClassJournal();
			journalWithOnlyLastEntry.Entries.Add(ClassJournalItem.GetLast(journalParent));
			return journalWithOnlyLastEntry;
		}

		/// <summary>
		/// Populates the specified DataGridView with Journal Entries according to a standard format.
		/// </summary>
		public void PopulateDataGridView(DataGridView dgv)
		{
			dgv.SuspendLayout();
			dgv.Rows.Clear();
			// Add entries in reverse order (newest at top)
			for (var i = Entries.Count - 1; i >= 0; i--)
			{
				var entry = Entries[i];
				var dgvr = new DataGridViewRow();
				dgvr.CreateCells(dgv);
				dgvr.Cells[0].Value = entry.User_Name;
				dgvr.Cells[1].Value = string.Format("{0:yyyy-MM-dd HH:mm}", entry.JournalDateTime);
				dgvr.Cells[2].Value = entry.JournalText;
				dgvr.Cells[2].Style.ForeColor = entry.IsSystemMessage ? ClassJournalItem.COL_JOURNAL_SYSTEM_BLUE_FG : entry.IsExpired ? Color.DarkRed : Color.Black;
				if (entry.ExpireDateTime.HasValue)
				{
					var expiryTimeSpan = entry.ExpireDateTime.Value - entry.JournalDateTime;
					if (expiryTimeSpan.Duration().Ticks > 0)
					{
						expiryTimeSpan = expiryTimeSpan.Round();
						var expiresValue = string.Format("{0:yyyy-MM-dd HH:mm} ({1})", entry.ExpireDateTime, ClassUtility.FormatRoundedTimeSpan_Dhm(expiryTimeSpan));
						dgvr.Cells[3].Value = expiresValue;
					}
				}
				dgv.Rows.Add(dgvr);
			}
			dgv.ResumeLayout();
		}

		private static JournalTableInfo GetJournalParentFieldNames(object journalParent)
		{
			#region Validation
			if (!(journalParent is ClassTicket || journalParent is ClassAsset || journalParent is ClassShipment || journalParent is ClassRMA))
				throw new ArgumentException("Object does not support journals.", "journalParent");
			#endregion

			var ticket = journalParent as ClassTicket;
			if (ticket != null)
				return new JournalTableInfo
						   {
							   TableName = "ticket_journal",
							   LinkerName = "ticket_id",
							   ParentID = ticket.ID
						   };

			var asset = journalParent as ClassAsset;
			if (asset != null)
				return new JournalTableInfo
						   {
							   TableName = "asset_journal",
							   LinkerName = "asset_id",
							   ParentID = asset.ID
						   };

			var shipment = journalParent as ClassShipment;
			if (shipment != null)
				return new JournalTableInfo
						   {
							   TableName = "shipment_journal",
							   LinkerName = "shipment_id",
							   ParentID = shipment.ID
						   };

			var rma = journalParent as ClassRMA;
			return new JournalTableInfo
				{
					TableName = "rma_journal",
					LinkerName = "rma_id",
					ParentID = rma.ID
				};
		}

		/// <summary>
		/// Adds a journal entry for the specified object (Ticket, Asset, Shipment or RMA) using the logged-on user ID, using the current server timestamp.
		/// </summary>
		/// <param name="journalParent">The ticket, asset, shipment or RMA to add the journal entry to.</param>
		/// <param name="journalText">The text of the journal entry.</param>
		/// <param name="expire">When the entry expires. Null for no expiration.</param>
		/// <param name="isSystemMessage">True if the entry should be treated as a system-created.</param>
		public static void AddJournalEntry(object journalParent, string journalText, DateTime? expire, bool isSystemMessage)
		{
			#region Validation
			if (!(journalParent is ClassTicket || journalParent is ClassAsset || journalParent is ClassShipment || journalParent is ClassRMA))
				throw new ArgumentException("Object does not support journals.", "journalParent");

			if (GS.Settings.LoggedOnUser.ID < 1)
				throw new Exception("Cannot add Journal Entry. User ID is invalid.");
			#endregion

			// If system entry, use default expiration
			if (isSystemMessage && !expire.HasValue)
				expire = ClassDatabase.GetCurrentTime().Add(_journalExpirationSystemDefault);

			var journalTableInfo = GetJournalParentFieldNames(journalParent);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"INSERT INTO {0}
						({1}, user_id, user_text, dt, expire_dt, system_msg)
						VALUES
						(@ParentID, @UserID, @JournalText, NOW(), @ExpireDT, @SystemMsg);", journalTableInfo.TableName, journalTableInfo.LinkerName);
					cmd.Parameters.AddWithValue("ParentID", journalTableInfo.ParentID);
					cmd.Parameters.AddWithValue("UserID", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("JournalText", journalText);
					cmd.Parameters.AddWithValue("ExpireDT", expire);
					cmd.Parameters.AddWithValue("SystemMsg", isSystemMessage);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Adds a journal entry for the specified object (Ticket, Asset, Shipment or RMA) using the logged-on user ID, using the current server timestamp.
		/// </summary>
		/// <param name="journalParent">The ticket, asset, shipment or RMA to add the journal entry to.</param>
		/// <param name="journalItem">The <see cref="ClassJournalItem"/> journal data.</param>
		public static void AddJournalEntry(object journalParent, ClassJournalItem journalItem)
		{
			AddJournalEntry(journalParent, journalItem.JournalText, journalItem.ExpireDateTime, journalItem.IsSystemMessage);
		}

		/// <summary>
		/// Adds a journal entry to specified ticket for expired hold.
		/// </summary>
		public static void AddTicketJournalEntryForExpiredHold(int ticketID, string journalText)
		{
			// Create a ticket object with only ID populated (because the method AddJournalEntry only uses the object type and ID)
			var ticket = new ClassTicket {ID = ticketID};
			AddJournalEntry(ticket, journalText, null, true);
		}

		public static int GetJournalParentID(object journalParent)
		{
			if (!(journalParent is ClassTicket || journalParent is ClassAsset || journalParent is ClassShipment || journalParent is ClassRMA))
				throw new ArgumentException("Object does not support journals.", "journalParent");

			int parentID;
			if (journalParent is ClassTicket)
				parentID = ((ClassTicket)journalParent).ID;
			else if (journalParent is ClassAsset)
				parentID = ((ClassAsset)journalParent).ID;
			else if (journalParent is ClassShipment)
				parentID = ((ClassShipment)journalParent).ID;
			else
				parentID = ((ClassRMA)journalParent).ID;
			return parentID;
		}
	}
}