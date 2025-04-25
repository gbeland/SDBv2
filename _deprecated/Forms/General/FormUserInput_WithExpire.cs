using System;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Forms.General
{
	/// <summary>
	/// Provides a way for user to enter text (for example, a reason for holding a ticket) which requires an expiration datetime for the action.
	/// i.e. The expiration of a ticket hold is not optional.
	/// </summary>
	public sealed partial class FormUserInput_WithExpire : Form
	{
		public string UserText;
		public DateTime ExpirationDate;

		private readonly DateTime _entryDateTime;
		private readonly DateTime _maxExpirationDate;

		/// <summary>
		/// A user text entry which requires an expiration date be specified.
		/// </summary>
		/// <param name="title">The title of the form, prompting for the correct information.</param>
		/// <param name="itemName">Name of the action being performed, such as "Ticket Hold" or "Ticket Delete"; appears in labels like "Ticket Hold expires in:"</param>
		/// <param name="buttonName">Name of the button to commit the action. For example: "Hold Ticket" or "Delete Shipment"</param>
		/// <param name="defaultExpireTime">Default time for item expiration.</param>
		/// <param name="maxExpireTime">Maximum time allowed for item expiration.</param>
		public FormUserInput_WithExpire(string title, string itemName, string buttonName, TimeSpan defaultExpireTime, TimeSpan maxExpireTime)
		{
			InitializeComponent();
			
			_entryDateTime = ClassDatabase.GetCurrentTime();
			var defaultExpirationDate = _entryDateTime.AddTicks(defaultExpireTime.Ticks);
			_maxExpirationDate = _entryDateTime.AddTicks(maxExpireTime.Ticks);
			ucSpellCheckSmall1.FontSize = GS.Settings.JournalFont.FontValue.Size * 1.5F; // WPF control renders fonts smaller, so multiply by 1.5
			ucSpellCheckSmall1.FontFamily = new System.Windows.Media.FontFamily(GS.Settings.JournalFont.FontValue.Name);
			ucSpellCheckSmall1.KeyDown += ucSpellCheckSmall1_KeyDown;

			Text = title;

			btnCommit.Text = buttonName;

			radExpires_HoursMinutes.Text = $"{itemName} expires in:";
			radExpires_Date.Text = $"{itemName} expires at:";

			dtpExpires_Date.MinDate = _entryDateTime.AddMinutes(1);
			dtpExpires_Date.MaxDate = _maxExpirationDate;
			dtpExpires_Date.Value = defaultExpirationDate;

			var maxHours = (int)Math.Floor(maxExpireTime.TotalHours);
			numExpires_Hours.Maximum = maxHours;
			
			var defaultHours = (int)Math.Floor(defaultExpireTime.TotalHours);
			numExpires_Hours.Value = defaultHours;
			numExpires_Minutes.Value = defaultExpireTime.Minutes;
		}

		private void ucSpellCheckSmall1_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (ModifierKeys != Keys.Control)
				return;

			if (e.Key == System.Windows.Input.Key.Enter)
				CreateJournalEntry();
		}

		private void btnCommit_Click(object sender, EventArgs e)
		{
			CreateJournalEntry();
		}

		/// <summary>
		/// Validates and populates public fields for use in calling method.
		/// </summary>
		private void CreateJournalEntry()
		{
			ucSpellCheckSmall1.txtData.SelectAll();
			var userText = ucSpellCheckSmall1.txtData.Selection.Text.Trim();
			var expiresIn = _entryDateTime.AddHours((int)numExpires_Hours.Value).AddMinutes((int)numExpires_Minutes.Value);
			var expiresAt = dtpExpires_Date.Value;
			var expirationDate = radExpires_Date.Checked ? expiresAt : expiresIn;

			if (!ValidateEntry(userText, expirationDate))
				return;
			
			ExpirationDate = expirationDate;
			UserText = userText;

			DialogResult = DialogResult.OK;
			Close();
		}

		private bool ValidateEntry(string userText, DateTime expirationDate)
		{
			if (string.IsNullOrEmpty(userText))
			{
				MessageBox.Show("No text has been entered for journal entry.", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (userText.Length > ClassJournalItem.MAX_JOURNAL_LENGTH)
			{
				MessageBox.Show($"The entry is too long. A maximum of {ClassJournalItem.MAX_JOURNAL_LENGTH} characters is allowed.", "Journal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (expirationDate <= _entryDateTime)
			{
				MessageBox.Show("The expiration date must be in the future.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (expirationDate > _maxExpirationDate)
			{
				MessageBox.Show("The expiration date is too far in the future.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (userText.StartsWith("*"))
			{
				MessageBox.Show("Entry cannot begin with an asterisk (*).", "Journal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void radExpires_HoursMinutes_CheckedChanged(object sender, EventArgs e)
		{
			var enabled = radExpires_HoursMinutes.Checked;
			numExpires_Hours.Enabled = enabled;
			lblExpires_Hours.Enabled = enabled;
			numExpires_Minutes.Enabled = enabled;
			lblExpires_Minutes.Enabled = enabled;
		}

		private void radExpires_Date_CheckedChanged(object sender, EventArgs e)
		{
			dtpExpires_Date.Enabled = radExpires_Date.Checked;
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

		/// <summary>
		/// Pre-populates the text box with <paramref name="text"/>.
		/// </summary>
		public void Prefill(string text)
		{
			ucSpellCheckSmall1.txtData.AppendText(text);
			ucSpellCheckSmall1.txtData.CaretPosition = ucSpellCheckSmall1.txtData.Document.ContentEnd;
		}
	}
}