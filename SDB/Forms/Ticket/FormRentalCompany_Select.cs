using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Ticket;

namespace SDB.Forms.Ticket
{
	/// <summary>
	/// This form is only used to select a replacement Rental Company when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormRentalCompany_Select : Form
	{
		public ClassRentalCompany RentalCompany;

		private readonly List<ClassRentalCompany> _rentalCompanies;

		public FormRentalCompany_Select()
		{
			InitializeComponent();

			_rentalCompanies = ClassRentalCompany.GetAll().ToList();
			cmbRentalCompanies.DisplayMember = "DisplayMember";
			cmbRentalCompanies.ValueMember = "ID";
			cmbRentalCompanies.DataSource = _rentalCompanies;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			RentalCompany = (ClassRentalCompany)cmbRentalCompanies.SelectedItem;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}