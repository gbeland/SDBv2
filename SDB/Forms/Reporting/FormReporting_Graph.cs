using System;
using System.Windows.Forms;
using SDB.Classes.General;

namespace SDB.Forms.Reporting
{
	public partial class FormReporting_Graph : Form
	{
		public string ReportTitle
		{
			set => lblReportTitle.Text = value;
		}

		public FormReporting_Graph()
		{
			InitializeComponent();
		}

		public bool SymptomGraph(ClassReporting.ClassReportRequestObject reportRequest)
		{
			if (!ClassReporting.Report_SymptomGraph(ref zgcGraph, reportRequest))
				return false;
			
			lblReportTitle.Text = reportRequest.ReportTitle_SingleLine;
			zgcGraph.SaveFileDialog.FileName = reportRequest.FileName;
			zgcGraph.SaveFileDialog.DefaultExt = ".png";
			zgcGraph.AxisChange();
			return true;
		}

		public bool SymptomTrendGraph(ClassReporting.ClassReportRequestObject reportRequest)
		{
			if (!ClassReporting.Report_SymptomTrendGraph(ref zgcGraph, reportRequest))
				return false;

			lblReportTitle.Text = reportRequest.ReportTitle_SingleLine;
			zgcGraph.SaveFileDialog.FileName = reportRequest.FileName;
			zgcGraph.SaveFileDialog.DefaultExt = ".png";
			zgcGraph.AxisChange();
			return true;
		}

		public bool SymptomTrendGraph2(ClassReporting.ClassReportRequestObject reportRequest)
		{
			if (!ClassReporting.Report_SymptomTrendGraph2(ref zgcGraph, reportRequest))
				return false;

			lblReportTitle.Text = reportRequest.ReportTitle_SingleLine;
			zgcGraph.SaveFileDialog.FileName = reportRequest.FileName;
			zgcGraph.SaveFileDialog.DefaultExt = ".png";
			zgcGraph.AxisChange();
			return true;
		}

		private void btnSaveFile_Click(object sender, EventArgs e)
		{
			zgcGraph.SaveAs(ClassUtility.MakeSafeFileName(Text + ".png"));
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			zgcGraph.DoPageSetup();
			zgcGraph.DoPrintPreview();
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

		private void FormReporting_Graph_FormClosing(object sender, FormClosingEventArgs e)
		{
			lblReportTitle.Text = string.Empty;
			Hide();
			e.Cancel = true;
		}

		private void FormReporting_Graph_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}
	}
}