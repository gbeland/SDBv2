using System;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.Forms.Reporting
{
	public partial class FormReporting_RMA : Form
	{
		public delegate void ViewRmaEvent (int rmaID);
		public event ViewRmaEvent ViewRma;

		public string ReportTitle
		{
			set => lblReportTitle.Text = value;
		}

		public ICollection RmaReportList
		{
			set
			{
				olvRMAs.SetObjects(value);
				txtRMAQty.Text = value.Count.ToString(CultureInfo.InvariantCulture);
			}
		}

		public FormReporting_RMA()
		{
			InitializeComponent();
		}

		private void olvRMAs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvRMAs.SelectedItem == null || ViewRma == null)
				return;

			ViewRma(((ClassRMA_Reporting)olvRMAs.SelectedObject).ID);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvExport(olvRMAs, ClassUtility.MakeSafeFileName(Text + ".csv"), "Export RMA Report");
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvPrint(olvRMAs);
		}

		private void olvRMAs_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var rma = (ClassRMA_Reporting)e.Model;
			e.Item.ForeColor = rma.Status.Foreground;
			e.Item.BackColor = rma.Status.Background;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void FormReporting_RMA_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void FormReporting_RMA_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}
	}
}