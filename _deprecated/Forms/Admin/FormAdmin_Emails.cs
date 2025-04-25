using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Admin;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Emails : Form
	{
		private List<ClassAdminEmail> _adminEmails = new List<ClassAdminEmail>();
		private ClassAdminEmail _selectedAdminEmail;

		public FormAdmin_Emails()
		{
			InitializeComponent();
		}

		private void FormAdminEmails_Load(object sender, EventArgs e)
		{
			Populate_AdminEmails();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Populate_AdminEmails()
		{
			_adminEmails = ClassAdminEmail.GetAll().ToList();
			olvAdminEmails.SetObjects(_adminEmails);
		}

		private void olvAdminEmails_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedAdminEmail = (ClassAdminEmail)olvAdminEmails.SelectedObject;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (var frmAdminEmailAddEdit = new FormAdmin_Email_AddEdit(false))
			{
				if (frmAdminEmailAddEdit.ShowDialog() != DialogResult.OK)
					return;

				Populate_AdminEmails();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			AdminEmail_Edit();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (_selectedAdminEmail == null)
				return;

			if (MessageBox.Show("Are you sure you want to delete the selected admin email?", "Confirm Admin Email Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			ClassAdminEmail.Delete(_selectedAdminEmail.ID);
			Populate_AdminEmails();
		}

		private void olvAdminEmails_DoubleClick(object sender, EventArgs e)
		{
			AdminEmail_Edit();
		}

		private void AdminEmail_Edit()
		{
			if (_selectedAdminEmail == null)
				return;

			using (var frmAdminEmailAddEdit = new FormAdmin_Email_AddEdit(true, _selectedAdminEmail.ID))
			{
				if (frmAdminEmailAddEdit.ShowDialog() != DialogResult.OK)
					return;

				Populate_AdminEmails();
			}
		}
	}
}