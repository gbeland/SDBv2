using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.Ticket;

namespace SDB.Forms.Ticket
{
	public partial class FormPMAChecklist : Form
	{
		private List<ClassPreventiveMaintenanceAction> _ticketPmas = new List<ClassPreventiveMaintenanceAction>();
		private readonly int _ticketID;

		public FormPMAChecklist(int ticketID)
		{
			_ticketID = ticketID;
			InitializeComponent();
		}

		private void FormPMAChecklist_Load(object sender, EventArgs e)
		{
			Populate_TicketPmas();
		}

		private void Populate_TicketPmas()
		{
			_ticketPmas = ClassPreventiveMaintenanceAction.GetPreventiveMaintenanceActions().ToList();
			var completedPmas = ClassTicket.GetCompletedPmas(_ticketID);
			foreach (var pma in _ticketPmas.Where(tpma => completedPmas.Contains(tpma.ID)))
				pma.Completed = true;
			olvPMAs.SetObjects(_ticketPmas);
		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			// update completed PMAs for this ticket
			ClassTicket.SetCompletedPmas(_ticketID, _ticketPmas.Where(tpma => tpma.Completed).Select(t => t.ID).ToList());
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}