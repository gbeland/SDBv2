using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.User;

namespace SDB.Forms.RMA
{
	/// <summary>
	/// This form is used for converting all existing RMA inventory (prior to this version) to the new bin system.
	/// After all RMAs have been converted, this form is depreacted.
	/// </summary>
	public partial class FormRMA_Migrate : Form
	{
		private ClassRMA _rma = new ClassRMA();
		private ClassRMA_Bin _rmaBin;
		private List<ClassRMA.ClassRMAAssembly> _rmaAssemblies = new List<ClassRMA.ClassRMAAssembly>();
		private List<ClassRMA_Zone> _zones = new List<ClassRMA_Zone>();
		private bool _ignoreStateChange;
		
		public FormRMA_Migrate()
		{
			InitializeComponent();

			olvColZone.AspectToStringConverter = x =>
				                                     {
					                                     var zoneID = (int?)x;
					                                     if (zoneID.HasValue)
					                                     {
						                                     var zone = _zones.Single(z => z.ID == zoneID.Value);
						                                     return zone == null ? string.Empty : zone.ZoneName;
					                                     }
					                                     return string.Empty;
				                                     };
		}

		private void txtRmaNumber_Enter(object sender, EventArgs e)
		{
			txtRmaNumber.SelectAll();
			AcceptButton = btnFind;
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtRmaNumber.Text, out var rmaNum))
			{
				MessageBox.Show("Invalid RMA Number.", "Invalid RMA Number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				if (_rma != null)
					txtRmaNumber.Text = _rma.ID.ToString(CultureInfo.InvariantCulture);
				else
					txtRmaNumber.Clear();
				txtRmaNumber.SelectAll();
				return;
			}
			RMA_Load(rmaNum);
		}

		private void RMA_Load(int rmaNumber)
		{
			_rma = ClassRMA.GetRMA(rmaNumber);

			#region Validation
			if (_rma == null)
			{
				_rmaAssemblies = null;
				MessageBox.Show($"Specified RMA ({rmaNumber}) does not exist.", "RMA Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtRmaNumber.Clear();
				txtRmaNumber.SelectAll();
				return;
			}
			if (_rma.IsFinalized || _rma.IsDeleted)
			{
				_rmaAssemblies = null;
				MessageBox.Show($"Specified RMA ({_rma.ID}) is {(_rma.IsFinalized ? "finalized" : "deleted")} and not eligible for migration.", "RMA Ineligible", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtRmaNumber.Clear();
				txtRmaNumber.SelectAll();
				return;
			}
			#endregion

			_zones = ClassRMA_Zone.GetAll().ToList();
			_rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(rmaNumber).ToList();
			foreach (var assy in _rmaAssemblies)
			{
				// Get bin details
				var bin = ClassRMA_Bin.GetBinForAssembly(assy.ID);
				if (bin == null)
					continue;
				assy.AssignedBinID = bin.BinName;
			}

			_rmaBin = null;

			Populate();
			
			SelectNextMigrateableAssembly(null);
		}

		private void Populate()
		{
			if (_rma == null)
				return;

			_ignoreStateChange = true;
			olvAssemblies.DeselectAll();
			olvAssemblies.SetObjects(_rmaAssemblies);

			txtReceivedQty.Text = _rma.Assemblies_ReceivedOrDiscarded_Qty.ToString(CultureInfo.InvariantCulture);
			txtTotalAssyQty.Text = _rma.AssemblyQty.ToString(CultureInfo.InvariantCulture);

			EnableReceiveControls(false);

			if (_rmaBin == null)
				_rmaBin = ClassRMA_Bin.GetLastBin(_rma.ID);
			
			txtCurrentBinID.Text = _rmaBin == null ? "NONE" : _rmaBin.BinName;

			if (_rmaBin != null)
			{
				var assyQty = _rmaBin.GetAssemblyQty();
				lblBinAssyQty.Text = $"({assyQty} item{(assyQty != 1 ? "s" : string.Empty)})";
				txtCurrentBinID.ForeColor = assyQty == 0 ? Color.Green : SystemColors.WindowText;
				txtCurrentBinID.BackColor = SystemColors.Control;
			}

			_ignoreStateChange = false;
		}

		private void EnableReceiveControls(bool enable)
		{
			txtAssemblySerialNumber.ReadOnly = !enable;

			btnMigrate.Enabled = enable;
		}
		
		private void btnReceive_CreateBin_Click(object sender, EventArgs e)
		{
			if (_rmaBin != null && _rmaBin.GetAssemblies().Count == 0)
			{
				const string MESSAGE = "The currently selected bin does not have any assemblies assigned to it. Are you sure you want to create a new bin?";
				var result = MessageBox.Show(MESSAGE, "Create New Empty Bin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (result != DialogResult.Yes)
					return;
			}

			try
			{
				var bin = ClassRMA_Bin.AddNew();
				_rmaBin = bin;
			}
			catch (Exception exc)
			{
				var message = string.Format("Error creating bin:{0}{0}{1}", Environment.NewLine, exc.Message);
				MessageBox.Show(message, "Bin Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Populate();
		}

		private void btnReceive_SelectBox_Click(object sender, EventArgs e)
		{
			using (var binSelectForm = new FormRMA_BinSelect())
			{
				if (binSelectForm.ShowDialog(this) != DialogResult.OK)
					return;

				if (binSelectForm.SelectedBin == null)
					return;

				SelectBin(binSelectForm.SelectedBin);
			}
		}

		private void SelectBin(string binName)
		{
			var bin = ClassRMA_Bin.GetByName(binName);
			if (bin == null)
			{
				MessageBox.Show("Sorry, that bin does not exist.", "Invalid Bin", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			_rmaBin = bin;
			var selectedAssembly = olvAssemblies.SelectedObject;
			Populate();
			olvAssemblies.SelectedObject = selectedAssembly;
			txtAssemblySerialNumber.Select();
		}
		
		private void btnReceive_DeleteBin_Click(object sender, EventArgs e)
		{
			var previouslySelectedAssembly = (ClassRMA.ClassRMAAssembly)olvAssemblies.SelectedObject;

			if (_rmaBin.GetAssemblies().Any())
			{
				var message = $"Cannot delete bin {_rmaBin.BinName} which contains assemblies.";
				MessageBox.Show(message, "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			_rmaBin.DeleteBin();
			_rmaBin = null;
			Populate();

			// Reselect last item
			if (previouslySelectedAssembly != null)
				olvAssemblies.SelectedObject = previouslySelectedAssembly;
		}

		private void btnMigrate_Click(object sender, EventArgs e)
		{
			#region Validation
			if (olvAssemblies.SelectedItems.Count != 1)
				return;

			var assy = (ClassRMA.ClassRMAAssembly)olvAssemblies.SelectedObject;

			// If a bin was scanned, select it (for convenience)
			if (ClassRMA_Bin.ValidateBinName(txtAssemblySerialNumber.Text))
			{
				SelectBin(txtAssemblySerialNumber.Text);
				txtAssemblySerialNumber.Clear();
				txtAssemblySerialNumber.Select();
				return;
			}

			// Same assembly selected, but different serial number; confirm
			if (!string.IsNullOrEmpty(assy.SerialNumber) && assy.SerialNumber != txtAssemblySerialNumber.Text)
			{
				var message = string.Format("Serial number is different. Are you sure you want to change the serial number of:{0}{0}{1}?", Environment.NewLine, assy.Description);
				if (MessageBox.Show(message, "Confirm Serial Number Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;
			}

			if (!ClassRMA.ClassRMAAssembly.ValidateSerialNumber(txtAssemblySerialNumber.Text, assy.AssemblyTypeSerialNumberFormat))
			{
				var message = $"Serial number is not valid. Required format is: {assy.AssemblyTypeSerialNumberFormat}";
				MessageBox.Show(message, "Invalid Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			if (_rmaBin == null)
			{
				MessageBox.Show("A bin must be selected.", "Bin Required", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtAssemblySerialNumber.SelectAll();
				return;
			}
			#endregion

			try
			{
				ClassRMA.MigrateAssembly(_rma.ID, assy, txtAssemblySerialNumber.Text.Trim(), _rmaBin);
			}
			catch (ArgumentException)
			{
				txtAssemblySerialNumber.Clear();
				MessageBox.Show("Cannot receive assembly with same serial number as another assembly in the same RMA.", "Duplicate Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			var journalText = $"Migrated {assy.AssemblyNumber}, S/N {assy.SerialNumber}";
			ClassJournal.AddJournalEntry(_rma, journalText, null, true);
			ClassNotification.SendNotificationsForObject(journalText, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			RMA_Load(_rma.ID);
			
			SelectNextMigrateableAssembly(assy.ID);
		}

		/// <summary>
		/// To make MIGRATING assemblies quicker, select the next RECEIVED assembly, if one exists
		/// If not, select the RMA Number field.
		/// </summary>
		/// <param name="excludeThisAssemblyID">The ID of the assembly that was just migrated to avoid selecting it.</param>
		private void SelectNextMigrateableAssembly(int? excludeThisAssemblyID)
		{
			var nextReceived = excludeThisAssemblyID.HasValue ?
				olvAssemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().FirstOrDefault(a => a.Receive_Date.HasValue && a.ID != excludeThisAssemblyID && !a.Bin_ID.HasValue) :
				olvAssemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().FirstOrDefault(a => a.Receive_Date.HasValue && !a.Bin_ID.HasValue);

			if (nextReceived != null)
			{
				olvAssemblies.SelectObject(nextReceived);
			}
			else
			{
				// Select RMA field as there are no more assemblies to migrate
				txtRmaNumber.Select();
				txtRmaNumber.SelectAll();
			}
		}

		private void olvAssemblies_Click(object sender, EventArgs e)
		{
			HandleAssemblySelection();
		}

		private void HandleAssemblySelection()
		{
			if (_ignoreStateChange)
				return;

			EnableReceiveControls(false);

			var selectedAssembly = (ClassRMA.ClassRMAAssembly)olvAssemblies.SelectedObject;
			if (selectedAssembly == null)
			{
				lblSelectedAssemblyID.Text = string.Empty;
				txtAssemblySerialNumber.Clear();
				return;
			}

			lblSelectedAssemblyID.Text = $"ID: {selectedAssembly.ID}";
			txtAssemblySerialNumber.Text = selectedAssembly.SerialNumber;

			var received = selectedAssembly.Receive_Date.HasValue;
			
			if (!received)
				txtAssemblySerialNumber.Text = "MUST BE RECEIVED TO MIGRATE";

			// Enable receive and prev/next bin buttons only if selected assembly is received (for migration)
			EnableReceiveControls(received);

			// If assembly is assigned to a bin, show it, otherwise show currently selected bin
			var bin = ClassRMA_Bin.GetBinForAssembly(selectedAssembly.ID);
			if (bin != null)
				_rmaBin = bin;

			// If currently selected bin is null, select last bin for RMA
			if (_rmaBin == null)
				_rmaBin = ClassRMA_Bin.GetLastBin(_rma.ID);

			txtCurrentBinID.Text = _rmaBin == null ? "NONE" : _rmaBin.BinName;

			SelectAndFocusReceiveSerialNumber();
		}

		private void mnuUndoAssyMigrate_Click(object sender, EventArgs e)
		{
			var selectedAssembly = (ClassRMA.ClassRMAAssembly)olvAssemblies.SelectedObject;

			#region Validation
			if (selectedAssembly == null)
				return;

			if (!selectedAssembly.Bin_ID.HasValue)
			{
				MessageBox.Show("Cannot undo migration of an assembly that is not assigned to a bin.", "Cannot Undo Migration", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			#endregion

			ClassRMA_Bin.UnassignAssemblyFromAnyBin(selectedAssembly.ID);
			RMA_Load(_rma.ID);

			// Reselect last item
			olvAssemblies.SelectedObject = selectedAssembly;
		}

		private void SelectAndFocusReceiveSerialNumber()
		{
			txtAssemblySerialNumber.SelectAll();
			txtAssemblySerialNumber.Select();
		}

		private void olvAssemblies_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var currentAssembly = (ClassRMA.ClassRMAAssembly)e.Model;
			e.Item.ForeColor = currentAssembly.StatusColor;
		}

		private void olvAssemblies_SelectedIndexChanged(object sender, EventArgs e)
		{
			HandleAssemblySelection();
		}

		private void txtAssemblySerialNumber_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnMigrate;
		}

		private void btnPrintBinLabels_All_Click(object sender, EventArgs e)
		{
			ClassRMA_Bin.PrintBinLabels(ClassRMA_Bin.GetByRMA(_rma.ID));
		}

		private void btnPrintBinLabels_Current_Click(object sender, EventArgs e)
		{
			ClassRMA_Bin.PrintBinLabels(new[] { _rmaBin });
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}