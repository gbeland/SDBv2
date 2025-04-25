using System;
using System.Windows.Forms;

namespace SDB.Forms.RMA
{
	public partial class FormLegacyRMANoReturnApproval : Form
	{
		public FormLegacyRMANoReturnApproval()
		{
			InitializeComponent();
		}

		public void SetRMA(string RMA)
		{
			lblShow_RMA.Text = "RMA: #" + RMA;
		}

		public void SetReason(string Reason)
		{
			txtNoReturnReason.Text = Reason;
		}

		private void btnDeny_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.No;
			Close();
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Yes;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
