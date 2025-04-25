using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.RMA;
using SDB.Classes.User;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_BinScan : Form
	{
		private ClassRMA_Bin _bin;

		public FormRMA_BinScan()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			txtDetail.Clear();

			var binName = txtBinIDInput.Text.Trim();

			// Format as a Bin Name in case only a number was entered
			if (int.TryParse(binName, out var x))
				binName = $"B{x:D5}";

			if (!ClassRMA_Bin.ValidateBinName(binName))
			{
				var message = $"Sorry, Invalid Bin ID \"{binName}\"";
				MessageBox.Show(message, "Invalid Bin ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtBinIDInput.SelectAll();
				return;
			}

			_bin = FindBin(binName);
			if (_bin != null)
				ShowBinDetails(_bin);
			else
				txtDetail.Text = $"\"{binName}\" BIN ID NOT FOUND";

			txtBinIDInput.Clear();
			txtBinIDInput.Select();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private ClassRMA_Bin FindBin(string binID)
		{
			return ClassRMA_Bin.GetByName(binID);
		}

		private void ShowBinDetails(ClassRMA_Bin bin)
		{
			var sb = new StringBuilder();
			var assemblies = bin.GetAssemblies();
			var involvedRmaIDs = assemblies.Select(a => a.RMA_ID).Distinct();
			var zone = bin.Zone_ID.HasValue ? ClassRMA_Zone.GetByID(bin.Zone_ID.Value) : null;
			var zoneName = zone != null ? zone.ZoneName : "[None]";
			var area = zone != null ? ClassRMA_Area.GetByID(zone.Area_ID) : null;
			var areaName = area != null ? area.AreaName : "[None]";

			sb.AppendFormat("Bin {0}", bin.BinName).AppendLine();
			sb.AppendFormat("Location: AREA: {0} ZONE: {1}", areaName, zoneName).AppendLine();
			sb.AppendFormat("Assemblies: {0}", assemblies.Count).AppendLine();
			sb.AppendLine();

			foreach (var rmaID in involvedRmaIDs)
			{
				var thisRmaID = rmaID;
				sb.AppendFormat("RMA {0}:", thisRmaID).AppendLine();

				foreach (var a in assemblies.Where(a => a.RMA_ID == thisRmaID))
				{
					var binName = a.Bin_ID.HasValue ? ClassRMA_Bin.FormatBinName(a.Bin_ID.GetValueOrDefault(0)) : "None";
					sb.AppendFormat("\t{0} ({1}) S/N: {2}, Received: {3:yyyy-MM-dd} by {4}; Bin {5}", a.AssemblyNumber, a.AssemblyDescription, a.SerialNumber, a.Receive_Date, a.Receive_UserName, binName).AppendLine();
				}

				sb.AppendLine();
			}

			sb.AppendLine();

			var users = ClassUser.GetAll(ClassUser.UserAccountStatus.All).ToList();
			var history = bin.GetHistory();
			sb.AppendLine("Bin History:");
			foreach (var binEvent in history)
			{
				var eventUser = users.SingleOrDefault(u => u.ID == binEvent.UserID);
				var eventUsername = eventUser != null ? eventUser.FirstL : "Unknown";

				switch (binEvent.EventType)
				{
					case ClassRMA_BinHistory.BinEventType.Moved:
						sb.AppendFormat("\t{0:yyyy-MM-dd HH:mm:ss}: {1} to {2} by {3}", binEvent.HistoryDate, binEvent.EventType, binEvent.Location, eventUsername).AppendLine();
						break;

					case ClassRMA_BinHistory.BinEventType.AddAssembly:
					case ClassRMA_BinHistory.BinEventType.RemoveAssembly:
						sb.AppendFormat("\t{0:yyyy-MM-dd HH:mm:ss}: {1} [{2}] by {3}", binEvent.HistoryDate, binEvent.EventType, binEvent.AssemblySerialNumber, eventUsername).AppendLine();
						break;

					default:
						sb.AppendFormat("\t{0:yyyy-MM-dd HH:mm:ss}: {1} by {2}", binEvent.HistoryDate, binEvent.EventType, eventUsername).AppendLine();
						break;
				}
			}

			txtDetail.Text = sb.ToString();
		}
	}
}