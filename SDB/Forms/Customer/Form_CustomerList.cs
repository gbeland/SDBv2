using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Customer;

namespace SDB.Forms.Customer
{
	public partial class Form_CustomerList : Form
	{
		public ClassCustomer SelectedCustomer { get; set; }
		public Form_CustomerList()
		{
			InitializeComponent();
			var customerList = ClassCustomer.GetCustomers().ToList();
			lbxCustomers.DataSource = customerList;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (lbxCustomers.SelectedItem == null)
			{
				MessageBox.Show("No Customer Selected");
			}
			else
			{
				SelectedCustomer = (ClassCustomer)lbxCustomers.SelectedItem;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}