using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_TimeAnalysis : Form
	{
		private readonly ClassRMA _rma;
		public FormRMA_TimeAnalysis(ClassRMA rma)
		{
			InitializeComponent();
			_rma = rma;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormRMA_TimeAnalysis_Load(object sender, EventArgs e)
		{
			Populate();
			timerRefresh.Start();
		}

		private void Populate()
		{
			DateTime dtNow = DateTime.Now;
			txtCreated.Text = _rma.Creation_Date.ToString("yyyy-MM-dd");
			if (_rma.FirstAssemblyReceived.HasValue)
			{
				txtReceived.Text = _rma.FirstAssemblyReceived.Value.ToString("yyyy-MM-dd");
				txtTimeToReceive.Text = ClassUtility.FormatTimeSpan_Dhm(_rma.FirstAssemblyReceived.Value - _rma.Creation_Date);
				if (_rma.Completed_Date.HasValue)
				{
					txtCompleted.Text = _rma.Completed_Date.Value.ToString("yyyy-MM-dd");
					txtTimeToRepair.Text = ClassUtility.FormatTimeSpan_Dhm(_rma.Completed_Date.Value - _rma.FirstAssemblyReceived.Value);
					txtTotalTime.Text = ClassUtility.FormatTimeSpan_Dhm(_rma.Completed_Date.Value - _rma.Creation_Date);
				}
				else
				{
					txtCompleted.BackColor = Color.Pink;
					txtTimeToRepair.BackColor = Color.Pink;
					txtTotalTime.BackColor = Color.Pink;
					txtTimeToRepair.Text = ClassUtility.FormatTimeSpan_Dhm(dtNow - _rma.FirstAssemblyReceived.Value);
					txtTotalTime.Text = ClassUtility.FormatTimeSpan_Dhm(dtNow - _rma.Creation_Date);
				}
			}
			else
			{
				txtCompleted.BackColor = Color.Pink;
				txtReceived.BackColor = Color.Pink;
				txtTimeToReceive.BackColor = Color.Pink;
				txtTimeToRepair.BackColor = Color.Pink;
				txtTotalTime.BackColor = Color.Pink;
				txtTimeToReceive.Text = txtTimeToRepair.Text = txtTotalTime.Text = ClassUtility.FormatTimeSpan_Dhm(dtNow - _rma.Creation_Date);
				
			}
			if (_rma.Finalized_Date.HasValue)
				txtFinalized.Text = _rma.Finalized_Date.Value.ToString("yyyy-MM-dd");
			else
				txtFinalized.BackColor = Color.Pink;
		}

		private void timerRefresh_Tick(object sender, EventArgs e)
		{
			Populate();
		}
	}
}
