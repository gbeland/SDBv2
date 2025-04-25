using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.General;

namespace SDB.Forms.Customer
{
	public partial class FormEmails_AutomatedEmailList : Form
	{
		public string EmailsList;
		public FormEmails_AutomatedEmailList(string emails)
		{
			InitializeComponent();
			tbxEmailList.Text = emails;
			EmailsList = emails;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			tbxEmailList.Text = tbxEmailList.Text.Replace(" ", string.Empty).Trim();
			if (!string.IsNullOrWhiteSpace(tbxEmailList.Text))
			{
				var addresses = tbxEmailList.Text.Split(',');
				if (addresses.Any(a => !ClassUtility.ValidateEmailAddress(a)))
				{
					MessageBox.Show("Error: Invalid Emails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			EmailsList = tbxEmailList.Text;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}