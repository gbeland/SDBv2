using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SDB.Classes.General;

namespace SDB.Forms.Reporting
{
	public partial class FormReporting_Symptoms : Form
	{
		public string ReportTitle
		{
			set => lblReportTitle.Text = value;
		}

		public IEnumerable<ClassReporting.ClassSymptomCount> SymptomSet
		{
			set => olvSymptoms.SetObjects(value);
		}

		public FormReporting_Symptoms()
		{
			InitializeComponent();

			olvSymptoms.PrimarySortColumn = olvColCount;
			olvSymptoms.PrimarySortOrder = SortOrder.Descending;
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvExport(olvSymptoms, ClassUtility.MakeSafeFileName(Text + ".csv"), "Export Symptoms Report");
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvPrint(olvSymptoms);
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

		private void FormReporting_Symptoms_FormClosing(object sender, FormClosingEventArgs e)
		{
			lblReportTitle.Text = string.Empty;
			Hide();
			e.Cancel = true;
		}

		private void FormReporting_Symptoms_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}
	}
}