using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Forms.Ticket
{
	public partial class FormTicket_TechLog : Form
	{
		private List<ClassTicket_TechOnSiteEvent> _tosEvents = new List<ClassTicket_TechOnSiteEvent>();
		private readonly int _ticketID;

		public FormTicket_TechLog(int ticketID)
		{
			_ticketID = ticketID;
			InitializeComponent();
		}

		private void FormPMAChecklist_Load(object sender, EventArgs e)
		{
			Populate();
		}

		private void Populate()
		{
			_tosEvents = ClassTicket.GetTechLog(_ticketID);
			olvTOSEvents.SetObjects(_tosEvents);
			txtTotalTime.Text = ClassUtility.FormatTimeSpan_Dhm(ClassTicket_TechOnSiteEvent.CalculateTotalTechOnSiteTime(_tosEvents));
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}