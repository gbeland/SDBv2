using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_RepairType_Select : Form
	{
		public ClassRMA_RepairType RepairType = new ClassRMA_RepairType();

		public FormRMA_RepairType_Select()
		{
			InitializeComponent();

			cmbRepairType.DisplayMember = "DisplayMember";
			cmbRepairType.ValueMember = "ID";
			cmbRepairType.DataSource = ClassRMA_RepairType.GetAll().ToList();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			RepairType = (ClassRMA_RepairType)cmbRepairType.SelectedItem;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}