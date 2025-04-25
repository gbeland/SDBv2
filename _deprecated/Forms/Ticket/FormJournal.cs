using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Ticket;
using SDB.Interfaces;

namespace SDB.Forms.Ticket
{
	public sealed partial class FormJournal : Form
	{
		/// <summary>
		/// Provides calling method access to the journal entry for <see cref="Classes.User.ClassNotification"/> purposes.
		/// </summary>
		public ClassJournalItem JournalEntry;

		public bool ReleaseHold;

		private readonly ClassJournal _journal;
		private DateTime? _priorUserEntryExpiration;
		private DateTime _now;
		private readonly TimeSpan _maxExpiration;
		private readonly ClassJournal.ExpirationType _expirationType;
		private readonly int _quickAddExpireMinutes;
        private ClassTicket _ticket;

		/// <summary>
		/// Constructs a <see cref="FormJournal"/> to allow addition of a new journal entry.
		/// </summary>
		/// <param name="journalParent">The parent object (Ticket, Asset, Shipment, RMA) which the journal is associated with.</param>
		/// <param name="maxExpiration">The maximum amount of time that the expiration can be set for.</param>
		/// <param name="expirationType">Specify if this journal entry requires that an expiration date/time be specified.</param>
		public FormJournal(ISupportsJournal journalParent, TimeSpan maxExpiration, ClassJournal.ExpirationType expirationType)
		{
			InitializeComponent();
			_now = ClassDatabase.GetCurrentTime();
			_quickAddExpireMinutes = ClassConfig.GetQuickAddJournalExpirationMinutes();
			btnQuickAddEntry.Text = $"&Quick Add (expires in {_quickAddExpireMinutes} minute{_quickAddExpireMinutes.SIfPlural()})";
			_journal = ClassJournal.GetByObject(journalParent);
			SetPriorUserEntryExpiration();
			_maxExpiration = maxExpiration;
			_expirationType = expirationType;
            ucSpellCheckSmall1.FontSize = GS.Settings.JournalFont.FontValue.Size * 1.5F; // WPF control renders fonts smaller, so multiply by 1.5
            ucSpellCheckSmall1.FontFamily = new System.Windows.Media.FontFamily(GS.Settings.JournalFont.FontValue.Name);
			dgvJournal.DefaultCellStyle.Font = GS.Settings.JournalFont;
            ucSpellCheckSmall1.KeyDown += ucSpellCheckSmall_KeyDown;

			switch (journalParent)
			{
				case ClassTicket ticket:
					Text = $"Ticket {journalParent.ID} Journal";

					chkReleaseHold.Visible = ticket.IsHeld;
					chkReleaseHold.Checked = ticket.IsHeld;
                    _ticket = ticket;
                    if (ticket.IsClosed || ticket.IsDeleted)
                        cbxHoldTicket.Visible = false;
                    else cbxHoldTicket.Visible = true;

                    break;

				case ClassAsset _:
					Text = $"Asset \"{ClassAsset.GetName(journalParent.ID)}\" Journal";
					chkReleaseHold.Visible = false;
                    cbxHoldTicket.Visible = false;
                    break;

				case ClassShipment shipment:
					Text = $"Shipment {journalParent.ID} Journal";
					chkReleaseHold.Visible = shipment.IsOnHold;
					chkReleaseHold.Checked = shipment.IsOnHold;
                    cbxHoldTicket.Visible = false;
                    break;

				case ClassRMA _:
					Text = $"RMA {journalParent.ID} Journal";
					chkReleaseHold.Visible = false;
                    cbxHoldTicket.Visible = false;
                    break;

				default:
					Text = "Journal";
					chkReleaseHold.Visible = false;
                    cbxHoldTicket.Visible = false;
                    break;
			}
			
			dtpExpires_Date.Value = _now;
			dtpExpires_Date.MinDate = _now;
			dtpExpires_Date.MaxDate = _now.Add(_maxExpiration);
			radExpires_SameAsPrior.Enabled = _priorUserEntryExpiration.HasValue;
			if (_priorUserEntryExpiration.HasValue)
				txtExpires_SameAsPrior.Text = $"{_priorUserEntryExpiration.Value:yyyy-MM-dd HH:mm}";

			numExpires_Hours.Value = 0;
			numExpires_Minutes.Value = 0;
			
			Populate();
		}

		private void SetPriorUserEntryExpiration()
		{
			if (_journal?.Entries == null || _journal.Entries.All(e => e.IsSystemMessage))
				return;

			var lastUserEntry = _journal.Entries.Where(e => !e.IsSystemMessage).OrderByDescending(e => e.JournalDateTime).First();
			if (lastUserEntry?.ExpireDateTime == null || lastUserEntry.ExpireDateTime <= _now)
				return;

			_priorUserEntryExpiration = lastUserEntry.ExpireDateTime.Value;
		}

		/// <summary>
		/// Pre-populates the text box with <paramref name="text"/>.
		/// </summary>
		public void Prefill(string text)
		{
			ucSpellCheckSmall1.txtData.AppendText(text);
            ucSpellCheckSmall1.txtData.CaretPosition = ucSpellCheckSmall1.txtData.Document.ContentEnd;
		}

		private void Populate()
		{
			_journal.PopulateDataGridView(dgvJournal);
		}

		private void ucSpellCheckSmall_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (ModifierKeys != Keys.Control)
				return;

			if (e.Key == System.Windows.Input.Key.Enter)
				AddJournalEntry();
		}

		private void btnAddEntry_Click(object sender, EventArgs e)
		{
			AddJournalEntry();
		}

		private void btnQuickAddEntry_Click(object sender, EventArgs e)
		{
			AddJournalEntry(_quickAddExpireMinutes);
		}

		private void AddJournalEntry(int? quickAddExpireMinutes = null)
		{
            ucSpellCheckSmall1.txtData.SelectAll();
			var userText = ucSpellCheckSmall1.txtData.Selection.Text.Trim();

			var expireDate = quickAddExpireMinutes.HasValue ? _now.AddMinutes(quickAddExpireMinutes.Value) : GetExpireDate();

			#region validation
			if (!ValidateEntry(userText, expireDate, out var errors))
			{
				MessageBox.Show(errors, "Journal Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			if (chkReleaseHold.Visible && chkReleaseHold.Checked)
				userText = $"Canceled hold: {userText}";

			JournalEntry = new ClassJournalItem
							   {
								   JournalDateTime = _now,
								   JournalText = userText,
								   ExpireDateTime = expireDate,
								   IsSystemMessage = false
							   };
			ReleaseHold = chkReleaseHold.Checked;

			DialogResult = DialogResult.OK;
			Close();
		}

        

        private DateTime? GetExpireDate()
		{
			var expireDate = (DateTime?)null;
			if (radExpires_Date.Checked)
				expireDate = dtpExpires_Date.Value;
			else if (radExpires_HoursMinutes.Checked)
				expireDate = _now.AddHours((int)numExpires_Hours.Value).AddMinutes((int)numExpires_Minutes.Value);
			else if (radExpires_SameAsPrior.Checked)
				expireDate = _priorUserEntryExpiration;
			return expireDate;
		}

		private bool ValidateEntry(string userText, DateTime? expirationDate, out string errors)
		{
			_now = ClassDatabase.GetCurrentTime();
			dtpExpires_Date.MinDate = _now;
			dtpExpires_Date.MaxDate = _now.Add(_maxExpiration);

			var sb = new StringBuilder();
			
			if (userText == null)
				userText = string.Empty;

			if (string.IsNullOrWhiteSpace(userText))
				sb.AppendLine("No text has been entered for journal entry.");

			if (userText.Length > ClassJournalItem.MAX_JOURNAL_LENGTH)
				sb.AppendFormat("The entry is too long. A maximum of {0} characters is allowed.", ClassJournalItem.MAX_JOURNAL_LENGTH).AppendLine();

			if (_expirationType == ClassJournal.ExpirationType.Required && !expirationDate.HasValue)
				sb.AppendLine("An expiration time/date must be specified.");

			if (radExpires_HoursMinutes.Checked || radExpires_Date.Checked)
			{
				if (expirationDate <= _now)
					sb.AppendLine("The expiration date must be in the future.");

				if (expirationDate > _now.AddTicks(_maxExpiration.Ticks))
					sb.AppendLine("The expiration date is too far in the future.");
			}

			if (userText.StartsWith("*"))
				sb.AppendLine("Entry cannot begin with an asterisk (*).");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private void radExpires_HoursMinutes_CheckedChanged(object sender, EventArgs e)
		{
			var isExpiresInTimeEnabled = radExpires_HoursMinutes.Checked;
			numExpires_Hours.Enabled = isExpiresInTimeEnabled;
			lblExpires_Hours.Enabled = isExpiresInTimeEnabled;
			numExpires_Minutes.Enabled = isExpiresInTimeEnabled;
			lblExpires_Minutes.Enabled = isExpiresInTimeEnabled;

			if (radExpires_HoursMinutes.Checked)
				numExpires_Hours.Select();
		}

		private void radExpires_Date_CheckedChanged(object sender, EventArgs e)
		{
			var isDateEnabled = radExpires_Date.Checked;
			dtpExpires_Date.Enabled = isDateEnabled;

			if(radExpires_Date.Checked)
				dtpExpires_Date.Select();
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}