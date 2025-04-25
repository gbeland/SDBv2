using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_FailureType_Select : Form
	{
		public ClassRMA_FailureType FailureType = new ClassRMA_FailureType();

		public FormRMA_FailureType_Select()
		{
			InitializeComponent();

			cmbFailureType.DisplayMember = "DisplayMember";
			cmbFailureType.ValueMember = "ID";
			cmbFailureType.DataSource = ClassRMA_FailureType.GetAll().ToList();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			FailureType = (ClassRMA_FailureType)cmbFailureType.SelectedItem;
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
