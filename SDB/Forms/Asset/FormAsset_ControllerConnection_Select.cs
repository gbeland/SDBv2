using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Asset
{
	/// <summary>
	/// This form is only used to select a replacement Asset Controller Connection when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormAsset_ControllerConnection_Select : Form
	{
		public ControllerConnection ControllerConnection;

		public FormAsset_ControllerConnection_Select()
		{
			InitializeComponent();

			var controllerConnections = ControllerConnection.GetAll().ToList();
			cmbConntrollerConnections.DisplayMember = "DisplayMember";
			cmbConntrollerConnections.ValueMember = "ID";
			cmbConntrollerConnections.DataSource = controllerConnections;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			ControllerConnection = (ControllerConnection)cmbConntrollerConnections.SelectedItem;
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