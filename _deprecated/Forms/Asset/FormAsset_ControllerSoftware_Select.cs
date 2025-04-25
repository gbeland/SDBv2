using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Asset
{
	/// <summary>
	/// This form is only used to select a replacement Asset Controller Software when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormAsset_ControllerSoftware_Select : Form
	{
		public ControllerSoftware ControllerSoftware;

		public FormAsset_ControllerSoftware_Select()
		{
			InitializeComponent();

			var controllerSoftware = ControllerSoftware.GetAll().ToList();
			cmbControllerSoftware.DisplayMember = "DisplayMember";
			cmbControllerSoftware.ValueMember = "ID";
			cmbControllerSoftware.DataSource = controllerSoftware;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			ControllerSoftware = (ControllerSoftware)cmbControllerSoftware.SelectedItem;
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