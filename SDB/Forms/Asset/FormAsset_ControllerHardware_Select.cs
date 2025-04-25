using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Asset
{
	/// <summary>
	/// This form is only used to select a replacement Asset Controller Hardware when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormAsset_ControllerHardware_Select : Form
	{
		public ControllerHardware ControllerHardware;

		public FormAsset_ControllerHardware_Select()
		{
			InitializeComponent();

			var controllerHardware = ControllerHardware.GetAll().ToList();
			cmbControllerHardware.DisplayMember = "DisplayMember";
			cmbControllerHardware.ValueMember = "ID";
			cmbControllerHardware.DataSource = controllerHardware;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			ControllerHardware = (ControllerHardware)cmbControllerHardware.SelectedItem;
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