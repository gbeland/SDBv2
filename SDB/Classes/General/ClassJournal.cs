using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Ticket;
using SDB.Interfaces;

namespace SDB.Classes.General
{
	public partial class ClassJournal
	{
		public enum ExpirationType
		{
			Required,
			NotRequired
		}

		private static readonly TimeSpan _journalExpirationSystemDefault = TimeSpan.FromMinutes(10);

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
		public ClassJournalItem LastEntry => Entries.Count > 0 ? Entries.Last() : new ClassJournalItem();

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
		public int Count => Entries.Count;

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
				dgvr.Cells[1].Value = $"{entry.JournalDateTime:yyyy-MM-dd HH:mm}";
				dgvr.Cells[2].Value = entry.JournalText;
				dgvr.Cells[2].Style.ForeColor = entry.IsSystemMessage ? ClassJournalItem.COL_JOURNAL_SYSTEM_BLUE_FG : entry.IsExpired ? Color.DarkRed : Color.Black;
				if (entry.ExpireDateTime.HasValue)
				{
					var expiryTimeSpan = entry.ExpireDateTime.Value - entry.JournalDateTime;
					if (expiryTimeSpan.Duration().Ticks > 0)
					{
						expiryTimeSpan = expiryTimeSpan.Round();
						var expiresValue = $"{entry.ExpireDateTime:yyyy-MM-dd HH:mm} ({ClassUtility.FormatRoundedTimeSpan_Dhm(expiryTimeSpan)})";
						dgvr.Cells[3].Value = expiresValue;
					}
				}
				dgv.Rows.Add(dgvr);
			}
			dgv.ResumeLayout();
		}

		/// <summary>
		/// Adds a journal entry for the specified object (Ticket, Asset, Shipment or RMA) using the logged-on user ID, using the current server timestamp.
		/// </summary>
		/// <param name="journalParent">The ticket, asset, shipment or RMA to add the journal entry to.</param>
		/// <param name="journalText">The text of the journal entry.</param>
		/// <param name="expire">When the entry expires. Null for no expiration.</param>
		/// <param name="isSystemMessage">True if the entry should be treated as a system-created.</param>
		public static void AddJournalEntry(ISupportsJournal journalParent, string journalText, DateTime? expire, bool isSystemMessage)
		{
			#region Validation
			if (GS.Settings.LoggedOnUser.ID < 1)
				throw new Exception("Cannot add Journal Entry. User ID is invalid.");
			#endregion

			// If system entry, use default expiration
			if (isSystemMessage && !expire.HasValue)
				expire = ClassDatabase.GetCurrentTime().Add(_journalExpirationSystemDefault);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"INSERT INTO {journalParent.JournalTableInfo.TableName}
						({journalParent.JournalTableInfo.LinkerName}, user_id, user_text, dt, expire_dt, system_msg)
						VALUES
						(@ParentID, @UserID, @JournalText, NOW(), @ExpireDT, @SystemMsg);";
					cmd.Parameters.AddWithValue("ParentID", journalParent.ID);
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
		public static void AddJournalEntry(ISupportsJournal journalParent, ClassJournalItem journalItem)
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
	}
}