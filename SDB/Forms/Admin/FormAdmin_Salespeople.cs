using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Customer;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Salespeople : Form
	{
		private List<ClassSalesperson> _salespeople = new List<ClassSalesperson>();
		private ClassSalesperson _selectedSalesperson;

		public FormAdmin_Salespeople()
		{
			InitializeComponent();
		}

		private void FormSalespeople_Load(object sender, EventArgs e)
		{
			Populate_Salespeople();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Populate_Salespeople()
		{
			_salespeople = ClassSalesperson.GetSalespeople().ToList();
			olvSalespeople.SetObjects(_salespeople);
		}

		private void olvSalespeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedSalesperson = (ClassSalesperson)olvSalespeople.SelectedObject;
		}

		private void btnSalesperson_Add_Click(object sender, EventArgs e)
		{
			using (FormAdmin_Salespeople_AddEdit frmSalespeopleAddEdit = new FormAdmin_Salespeople_AddEdit(false))
			{
				if (frmSalespeopleAddEdit.ShowDialog() != DialogResult.OK)
					return;
				Populate_Salespeople();
			}
		}

		private void btnSalesperson_Edit_Click(object sender, EventArgs e)
		{
			Salesperson_Edit();
		}

		private void olvSalespeople_DoubleClick(object sender, EventArgs e)
		{
			Salesperson_Edit();
		}

		private void Salesperson_Edit()
		{
			if (_selectedSalesperson == null)
				return;
			using (FormAdmin_Salespeople_AddEdit frmSalespersonAddEdit = new FormAdmin_Salespeople_AddEdit(true, _selectedSalesperson.ID))
			{
				if (frmSalespersonAddEdit.ShowDialog() != DialogResult.OK)
					return;
				Populate_Salespeople();
			}
		}

		private void btnSalesperson_Remove_Click(object sender, EventArgs e)
		{
			if (_selectedSalesperson == null) return;
			if (MessageBox.Show("Are you sure you want to delete the selected salesperson?", "Confirm Salesperson Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			// Check if the camera type is used for any asset
			int salespersonUsedQty = ClassSalesperson.GetUsedQty(_selectedSalesperson.ID);
			if (salespersonUsedQty > 0)
			{
				MessageBox.Show(string.Format("This salesperson is used {0} time{1} in the database. It cannot be deleted.", salespersonUsedQty, salespersonUsedQty == 1 ? string.Empty : "s"), "Salesperson In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			ClassSalesperson.Delete(_selectedSalesperson);
			Populate_Salespeople();
		}
	}
}
