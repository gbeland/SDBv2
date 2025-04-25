using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.UserControls.Ticket
{
	public partial class ucJournalViewer : UserControl
	{
		public ucJournalViewer()
		{
			InitializeComponent();
		}

		public void SetJournal(ClassJournal journal)
		{
			journal.PopulateDataGridView(dgvJournal);
			dgvJournal.DefaultCellStyle.Font = GS.Settings.JournalFont;
		}
	}
}