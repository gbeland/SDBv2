using System;
using System.Windows.Forms;
using SDB.Classes.Customer;
using SDB.Classes.General;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Salespeople_AddEdit : Form
	{
		private ClassSalesperson _salesperson = new ClassSalesperson();
		private readonly bool _isEditing;

		public FormAdmin_Salespeople_AddEdit(bool IsEditing, int? SalespersonID = null)
		{
			InitializeComponent();
			_isEditing = IsEditing;

			if (_isEditing && SalespersonID.HasValue)
			{
				_salesperson = ClassSalesperson.GetByID(SalespersonID.Value);
				Populate();
			}

			txtFirst.Select();
		}

		private void Populate()
		{
			txtFirst.Text = _salesperson.FirstName;
			txtLast.Text = _salesperson.LastName;
			txtAddress.Text = _salesperson.Address;
			txtCity.Text = _salesperson.City;
			txtState.Text = _salesperson.State;
			txtZip.Text = _salesperson.Zip;
			txtCountry.Text = _salesperson.Country;
			txtEmail.Text = _salesperson.Email;
			txtOffice.Text = _salesperson.Phone_Office;
			txtMobile.Text = _salesperson.Phone_Mobile;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtFirst.Text) || string.IsNullOrEmpty(txtLast.Text))
			{
				MessageBox.Show("Salesperson name cannot be blank.", "Salesperson Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion
			UpdateSalespersonObjectFromFields();
			try
			{
				if (_isEditing)
					ClassSalesperson.Update(_salesperson);
				else
					ClassSalesperson.AddNew(ref _salesperson);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add salesperson.{0}{0}{1}", Environment.NewLine, exc.Message), "Salesperson Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateSalespersonObjectFromFields()
		{
			_salesperson.FirstName = txtFirst.Text.Trim();
			_salesperson.LastName = txtLast.Text.Trim();
			_salesperson.Address = txtAddress.Text.Trim();
			_salesperson.City = txtCity.Text.Trim();
			_salesperson.State = txtState.Text.Trim();
			_salesperson.Zip = txtZip.Text.Trim();
			_salesperson.Country = txtCountry.Text.Trim();
			_salesperson.Email = txtEmail.Text.Trim();
			_salesperson.Phone_Office = txtOffice.Text.Trim();
			_salesperson.Phone_Mobile = txtMobile.Text.Trim();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
