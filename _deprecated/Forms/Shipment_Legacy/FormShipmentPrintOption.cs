using System;
using System.Windows.Forms;

namespace SDB.Forms.Shipment
{
	public partial class FormShipmentPrintOption : Form
	{
		public bool IsDetail;

		public FormShipmentPrintOption()
		{
			InitializeComponent();
		}

		private void btnDetail_Click(object sender, EventArgs e)
		{
			IsDetail = true;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnLabel_Click(object sender, EventArgs e)
		{
			IsDetail = false;
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