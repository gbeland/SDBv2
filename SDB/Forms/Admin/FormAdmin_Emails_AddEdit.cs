using System;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Forms.Admin
{
	public sealed partial class FormAdmin_Email_AddEdit : Form
	{
		private ClassAdminEmail _adminEmail = new ClassAdminEmail();
		private readonly bool _isEditing;

		/// <summary>
		/// Construct a form to edit an existing or add a new admin email.
		/// </summary>
		/// <param name="isEditing">True if editing an existing admin email.</param>
		/// <param name="adminEmailID">Which admin email to edit, if any.</param>
		public FormAdmin_Email_AddEdit(bool isEditing, int? adminEmailID = null)
		{
			InitializeComponent();
			_isEditing = isEditing;

			Text = _isEditing ? "Edit Admin Email" : "Add Admin Email";

			if (_isEditing && adminEmailID.HasValue)
			{
				_adminEmail = ClassAdminEmail.GetByID(adminEmailID.Value);
				Populate();
			}

			txtAdminEmail_Name.Select();
		}

		private void Populate()
		{
			txtAdminEmail_Name.Text = _adminEmail.Name;
			txtAdminEmail_EmailAddress.Text = _adminEmail.Email;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtAdminEmail_Name.Text) || string.IsNullOrEmpty(txtAdminEmail_EmailAddress.Text))
			{
				MessageBox.Show("Admin Email name and address cannot be blank.", "Admin Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			UpdateAdminEmailObjectFromFields();
			try
			{
				if (_isEditing)
					ClassAdminEmail.Update(_adminEmail);
				else
					ClassAdminEmail.AddNew(ref _adminEmail);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add admin email. Ensure the email address is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Admin Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateAdminEmailObjectFromFields()
		{
			_adminEmail.Name = txtAdminEmail_Name.Text.Trim();
			_adminEmail.Email = txtAdminEmail_EmailAddress.Text.Trim();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}