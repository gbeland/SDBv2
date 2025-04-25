using System;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Forms.Reporting
{
	public partial class FormReporting_Ticket : Form
	{
		public delegate void ViewTicketEvent(int ticketID);
		public event ViewTicketEvent ViewTicket;

		public string ReportTitle
		{
			set => lblReportTitle.Text = value;
		}

		public ICollection TicketReportList
		{
			set
			{
				olvTR.SetObjects(value);
				txtQty.Text = value.Count.ToString(CultureInfo.InvariantCulture);
			}
		}

		public FormReporting_Ticket()
		{
			InitializeComponent();

			olvColTicket_Duration.AspectToStringConverter = delegate(object x)
				{
					var ts = (TimeSpan)x;
					return ClassUtility.FormatTimeSpan_Dhm(ts);
				};

			olvColTicket_TechArrivedDuration.AspectToStringConverter = delegate(object x)
				{
					if (x == null)
						return string.Empty;
					var ts = (TimeSpan)x;
					return ClassUtility.FormatTimeSpan_Dhm(ts);
				};
		}

		private void olvTRs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvTR.SelectedItem == null || ViewTicket == null)
				return;

			ViewTicket(((ClassTicket_Reporting)olvTR.SelectedObject).Ticket.ID);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvExport(olvTR, ClassUtility.MakeSafeFileName(Text + ".csv"), "Export Ticket Report");
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvPrint(olvTR);
		}

		private void OlvTr_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var tr = (ClassTicket_Reporting)e.Model;
			e.Item.ForeColor = tr.Ticket.StatusColor_FG;
			e.Item.BackColor = tr.Ticket.StatusColor_BG;
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

		private void FormReporting_Ticket_FormClosing(object sender, FormClosingEventArgs e)
		{
			lblReportTitle.Text = string.Empty;
			Hide();
			e.Cancel = true;
		}

		private void FormReporting_Ticket_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}
	}
}