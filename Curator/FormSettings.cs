using System;
using System.Windows.Forms;

namespace Curator
{
	public partial class FormSettings : Form
	{
		public FormSettings()
		{
			InitializeComponent();
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
			Populate();
		}

		private void Populate()
		{
			Populate_MySQLServer();
			Populate_EmailServer();
			Populate_Admin();
			Populate_Operation();
			Populate_Messages();
		}

		private void Populate_MySQLServer()
		{
			txtMySQLServer_Server.Text = FormCurator.Settings.SQLServer;
			txtMySQLServer_User.Text = FormCurator.Settings.SQLUser;
			txtMySQLServer_Password.Text = FormCurator.Settings.SQLPassword;
			numMySQLServer_Timeout.Value = FormCurator.Settings.SQLTimeout;
			txtMySQLServer_DatabaseName.Text = FormCurator.Settings.SQLDatabase;
		}

		private void Populate_EmailServer()
		{
			txtEmail_Server.Text = FormCurator.Settings.EmailServer;
			txtEmail_ServerPort.Text = FormCurator.Settings.EmailServerPort;
			chkEmail_UseSSL.Checked = FormCurator.Settings.EmailServerUseSSL;
			txtEmail_User.Text = FormCurator.Settings.EmailAccount;
			txtEmail_Password.Text = FormCurator.Settings.EmailPassword;
			txtEmail_ReplyTo.Text = FormCurator.Settings.EmailReplyTo;
		}

		private void Populate_Admin()
		{
			txtAdminEmail.Text = FormCurator.Settings.EmailAddressesForSummary;
		}

		private void Populate_Operation()
		{
			numCheckIntervalMinutes.Value = FormCurator.Settings.UnreceivedRmaNotification_CheckIntervalMinutes;
		}

		private void Populate_Messages()
		{
			chkFirstNotification_Enable.Checked = FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_Enabled;
			numFirstNotification_Days.Value = FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_DaysRequired;
			numFirstNotification_DaysNotToExceed.Value = FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_DaysNotToExceed;
			txtFirstHeader.Text = FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_Header;
			txtFirstFooter.Text = FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_Footer;

			chkSecondNotification_Enable.Checked = FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_Enabled;
			numSecondNotification_Days.Value = FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_DaysRequired;
			numSecondNotification_DaysNotToExceed.Value = FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_DaysNotToExceed;
			txtSecondHeader.Text = FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_Header;
			txtSecondFooter.Text = FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_Footer;

			numDaysBeforeSendingAdditionalNotice.Value = FormCurator.Settings.UnreceivedRmaNotification_DaysBeforeSendingAnotherNotice;
		}

		private void UpdateSettings()
		{
			UpdateSettings_MySQLServer();
			UpdateSettings_EmailServer();
			UpdateSettings_Admin();
			UpdateSettings_Operation();
			UpdateSettings_Messages();
		}

		private void UpdateSettings_MySQLServer()
		{
			FormCurator.Settings.SQLServer = txtMySQLServer_Server.Text.Trim();
			FormCurator.Settings.SQLUser = txtMySQLServer_User.Text.Trim();
			FormCurator.Settings.SQLPassword = txtMySQLServer_Password.Text.Trim();
			FormCurator.Settings.SQLTimeout = (int)numMySQLServer_Timeout.Value;
			FormCurator.Settings.SQLDatabase = txtMySQLServer_DatabaseName.Text.Trim();
		}

		private void UpdateSettings_EmailServer()
		{
			FormCurator.Settings.EmailServer = txtEmail_Server.Text.Trim();
			FormCurator.Settings.EmailServerPort = txtEmail_ServerPort.Text.Trim();
			FormCurator.Settings.EmailServerUseSSL = chkEmail_UseSSL.Checked;
			FormCurator.Settings.EmailAccount = txtEmail_User.Text.Trim();
			FormCurator.Settings.EmailPassword = txtEmail_Password.Text.Trim();
			FormCurator.Settings.EmailReplyTo = txtEmail_ReplyTo.Text.Trim();
		}

		private void UpdateSettings_Admin()
		{
			FormCurator.Settings.EmailAddressesForSummary = txtAdminEmail.Text.Trim();
		}

		private void UpdateSettings_Operation()
		{
			FormCurator.Settings.UnreceivedRmaNotification_CheckIntervalMinutes = (int)numCheckIntervalMinutes.Value;
		}

		private void UpdateSettings_Messages()
		{
			FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_Enabled = chkFirstNotification_Enable.Checked;
			FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_DaysRequired = (int)numFirstNotification_Days.Value;
			FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_DaysNotToExceed = (int)numFirstNotification_DaysNotToExceed.Value;
			FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_Header = txtFirstHeader.Text.Trim();
			FormCurator.Settings.UnreceivedRmaNotification_FirstNotification_Footer = txtFirstFooter.Text.Trim();

			FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_Enabled = chkSecondNotification_Enable.Checked;
			FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_DaysRequired = (int)numSecondNotification_Days.Value;
			FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_DaysNotToExceed = (int)numSecondNotification_DaysNotToExceed.Value;
			FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_Header = txtSecondHeader.Text.Trim();
			FormCurator.Settings.UnreceivedRmaNotification_SecondNotification_Footer = txtSecondFooter.Text.Trim();

			FormCurator.Settings.UnreceivedRmaNotification_DaysBeforeSendingAnotherNotice = (int)numDaysBeforeSendingAdditionalNotice.Value;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			UpdateSettings();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void chkFirstNotification_Enable_CheckedChanged(object sender, EventArgs e)
		{
			pnlFirstNotification.Enabled = chkFirstNotification_Enable.Checked;
		}

		private void chkSecondNotification_Enable_CheckedChanged(object sender, EventArgs e)
		{
			pnlSecondNotification.Enabled = chkSecondNotification_Enable.Checked;
		}

		private void NumericUpDown_Enter(object sender, EventArgs e)
		{
			NumericUpDown n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}
	}
}