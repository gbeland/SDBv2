using System.Windows.Forms;
using SDB.Classes;

namespace SDB.UserControls
{
	public partial class RMAKey : UserControl
	{
		public RMAKey()
		{
			InitializeComponent();
			lblKey_NotReceived.BackColor = ClassRMA.RMA_UNRECEIVED;
			lblKey_Received.BackColor = ClassRMA.RMA_RECEIVED;
			lblKey_InProgress.BackColor = ClassRMA.RMA_IN_PROGRESS;
			lblKey_Completed.BackColor = ClassRMA.RMA_REPAIR_COMPLETED;
			lblKey_Finalized.BackColor = ClassRMA.RMA_FINALIZED;

			toolTip1.SetToolTip(lblKey_NotReceived, "");
		}
	}
}