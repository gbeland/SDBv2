using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_SerialNumberSearch : Form
	{
		public FormRMA_SerialNumberSearch()
		{
			InitializeComponent();
		}

		public FormRMA_SerialNumberSearch(string serialNumber) : this()
		{
			txtSerialNumberInput.Text = serialNumber;
			Search(serialNumber);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			txtDetail.Clear();

			var snInput = txtSerialNumberInput.Text.Trim();
			Search(snInput);
		}

		private void Search(string serialNumber)
		{
			var matchingAssemblies = ClassRMA.ClassRMAAssembly.GetBySerialNumber(serialNumber);

			if (!matchingAssemblies.Any())
				txtDetail.Text = string.Format("No assemblies with SN '{0}' found.", serialNumber);
			else
				ShowSerialNumberDetail(matchingAssemblies);

			txtSerialNumberInput.Clear();
			txtSerialNumberInput.Select();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ShowSerialNumberDetail(List<ClassRMA.ClassRMAAssembly> assemblies)
		{
			Cursor = Cursors.WaitCursor;

			var sb = new StringBuilder();
			sb.AppendFormat("Detail for Serial Number '{0}':", assemblies.First().SerialNumber).AppendLine();
			foreach (var assembly in assemblies.OrderBy(a => a.ID))
			{
				var rma = ClassRMA.GetByID(assembly.RMA_ID);

                if (rma == null)
                    continue;

				ClassRMA.ClassRMAAssembly.GetRMAAssemblyRepairStrings(new List<ClassRMA.ClassRMAAssembly> {assembly});
				assembly.RepairLog = ClassRMA.ClassRMAAssembly.RMAAssembly_GetRepairLog(assembly.ID).ToList();

				sb.AppendFormat("RMA: {0}", rma.ID).AppendLine();
				sb.AppendFormat("Ticket: {0}", rma.TicketID).AppendLine();
				sb.AppendFormat("\tCreated: {0:yyyy-MM-dd HH:mm:ss} by {1}", rma.Creation_Date, rma.Creation_UserName).AppendLine();
				sb.AppendFormat("\tAssembly Received: {0:yyyy-MM-dd HH:mm:ss} by {1}", assembly.Receive_Date, assembly.Receive_UserName).AppendLine();
				sb.AppendFormat("\tTime from creation to receive: {0}", ClassUtility.FormatTimeSpan_Dhm(assembly.Receive_Date - rma.Creation_Date)).AppendLine();
				sb.AppendFormat("\tFailure Type: {0}", assembly.FailureTypeDescription).AppendLine();
				sb.AppendFormat("\tRepairs: {0}", assembly.RepairTypes_AllDescriptions).AppendLine();
				sb.AppendFormat("\tRepairs done by: {0} requring {1} total.", string.Join(", ", assembly.RepairLog.Select(rl => rl.UserName)), ClassUtility.FormatRoundedTimeSpan_Dhm(assembly.Repair_TotalTechTime)).AppendLine();
				sb.AppendFormat("\tTime from receive to repair complete: {0}", ClassUtility.FormatTimeSpan_Dhm(assembly.Repair_TotalTime)).AppendLine();
				sb.AppendFormat("\tRoot Cause: {0}", assembly.Finalize_RootCauseDescription).AppendLine();
				sb.AppendLine();
			}
			txtDetail.Text = sb.ToString();

			Cursor = Cursors.Default;
		}
	}
}