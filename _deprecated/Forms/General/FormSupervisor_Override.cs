using System;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.User;

namespace SDB.Forms.General
{
	public partial class FormSupervisor_Override : Form
	{
		private int _failedAttempts;
		private const int _MAX_FAILED_ATTEMPTS_BEFORE_CANCEL = 3;

		public enum VerificationResultEnum { Permit, Cancel };
		public VerificationResultEnum Result;
		public ClassUser Supervisor;

		public FormSupervisor_Override()
		{
			InitializeComponent();
		}

		public void SetMainText(string text)
		{
			lblMainText.Text = text;
		}

		public void SetPermitButtonText(string text)
		{
			btnPermit.Text = text;
		}

		private void btnPermit_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtID.Text, out var pinUserID))
				return;
			Supervisor = ClassUser.GetByID(pinUserID);
			if (Supervisor.UserType == ClassUser.USERTYPE_STANDARD)
			{
				MessageBox.Show("Invalid user.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (Supervisor.VerifyPin(txtPIN.Text))
			{
				Result = VerificationResultEnum.Permit;
				Close();
			}
			else
			{
				_failedAttempts++;
				if (_failedAttempts > _MAX_FAILED_ATTEMPTS_BEFORE_CANCEL)
				{
					MessageBox.Show("Invalid ID or PIN. Contact your supervisor.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Denied, ClassEventLog.ObjectTypeEnum.User, null, "Denied permission for supervisor override.");
					Supervisor = null;
					Result = VerificationResultEnum.Cancel;
					Close();
				}
				else
				{
					MessageBox.Show("Invalid ID or PIN.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtPIN.SelectAll();
					txtPIN.Select();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Result = VerificationResultEnum.Cancel;
            Close();
        }
	}
}