using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.Admin;
using SDB.Forms.Ticket;
using Orientation = System.Windows.Forms.Orientation;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_Editor : Form
	{
		#region Private Vars
		private ClassRMA _rma = new ClassRMA();
		private ClassRMA_Bin _rmaBin;
		private ClassJournal _journal = new ClassJournal();
		private List<ClassRMA.ClassRMAAssembly> _rmaAssemblies = new List<ClassRMA.ClassRMAAssembly>();
		private ClassRMA.ClassRMAAssembly _repairAssembly;

		private ClassTicket _ticket = new ClassTicket();
		private ClassAsset _asset = new ClassAsset();
		private List<ClassShipment> _shipments = new List<ClassShipment>();
		private List<ClassRMA_Component> _components = new List<ClassRMA_Component>();
		private List<ControllerHardware> _controllerHardware = new List<ControllerHardware>();

		// ReSharper disable InconsistentNaming
		private readonly Color COL_INPROGRESS_BG = Color.Orange;
		private readonly Color COL_COMPLETED_BG = Color.SkyBlue;
		private readonly Color COL_FINALIZED_BG = Color.LightGreen;
		// ReSharper restore InconsistentNaming

		private bool _ignoreStateChange;

		// Sidebar properties
		//private bool _sidebarShown;
		//private const int _SIDEBAR_COLLAPSED_WIDTH = 20;
		//private const int _SIDEBAR_EXPANDED_WIDTH = 300;
		//private const int _SIDEBAR_MOVEBY = 20;
		//private TabPage _sidebarPreviousClickedTab;
		#endregion

		#region Public Vars
		public enum ViewEnum { Journal, Assemblies, Receive, Repair, Accounting, Summary };
		#endregion

		#region Delegates and Events
		public delegate void IDEvent(int jumpID);
		public delegate void TrackingEvent(string trackingURL);
		public event IDEvent ViewTech;
		public event IDEvent ViewTicket;
		public event IDEvent ViewAsset;
		public event IDEvent ViewShipment;
		public event IDEvent CreateShipment;
		public event IDEvent ViewLegacyRMA;
		public event TrackingEvent ViewTracking;
		#endregion

		#region Form
		public FormRMA_Editor()
		{
			InitializeComponent();

			lblKey_NotReceived.BackColor = ClassRMA.ClassRMAAssembly.RMA_ASSEMBLY_UNRECEIVED;
			lblKey_Received.BackColor = ClassRMA.ClassRMAAssembly.RMA_ASSEMBLY_RECEIVED;
			lblKey_InProgress.BackColor = ClassRMA.ClassRMAAssembly.RMA_ASSEMBLY_REPAIR_STARTED;
			lblKey_Completed.BackColor = ClassRMA.ClassRMAAssembly.RMA_ASSEMBLY_REPAIR_COMPLETED;
			lblKey_Finalized.BackColor = ClassRMA.ClassRMAAssembly.RMA_ASSEMBLY_FINALIZED;

			olvColSummary_Assemblies_TotalTime.AspectToStringConverter = delegate(object x)
			                                                             {
				                                                             var ts = (TimeSpan)x;
				                                                             return ClassUtility.FormatTimeSpan_Dhm(ts);
			                                                             };

			olvColAssyAdd_Discarded.AspectGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded;
			olvColAssyAdd_Discarded.AspectToStringConverter = x => string.Empty;
			olvColAssyAdd_Discarded.ImageGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded ? "trash" : "none";

			olvColDiscarded.AspectGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded;
			olvColDiscarded.AspectToStringConverter = x => string.Empty;
			olvColDiscarded.ImageGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded ? "trash" : "none";

			olvColSummary_Discarded.AspectGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded;
			olvColSummary_Discarded.AspectToStringConverter = x => string.Empty;
			olvColSummary_Discarded.ImageGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded ? "trash" : "none";
		}

		private void FormRMAEditor_Load(object sender, EventArgs e)
		{
			WindowState = GS.Settings.WindowState_RMAEditor;
			Location = GS.Settings.Location_RMAEditor;
		}

		private void FormRMA_Editor_Activated(object sender, EventArgs e)
		{
			var isAdmin = GS.Settings.LoggedOnUser.IsAdmin;
			var isMod = GS.Settings.LoggedOnUser.IsMod;

			btnModify.Visible = isAdmin || isMod;
			chkAccounting_Charged.Visible = isAdmin;
			btnAssemblyManagement.Visible = isAdmin || isMod;
		}

		private void FormRMA_Editor_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
            cmbRepairAction.DataSource = ClassRepair_Actions.GetAllActions();
        }

		private void FormRMAEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			GS.Settings.WindowState_RMAEditor = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_RMAEditor = Location;
			Hide();
			e.Cancel = true;
		}

		/// <summary>
		/// Selects the appropriate tab for the specified ViewType.
		/// </summary>
		public void SetView(ViewEnum viewType)
		{
			switch (viewType)
			{
				case ViewEnum.Assemblies:
					tabControl_RMA.SelectedTab = tabAssemblyTypes;
					break;

				case ViewEnum.Receive:
					tabControl_RMA.SelectedTab = tabReceive;
					break;

				case ViewEnum.Repair:
					tabControl_RMA.SelectedTab = tabRepair;
					break;

				case ViewEnum.Accounting:
					tabControl_RMA.SelectedTab = tabAccounting;
					break;

				case ViewEnum.Summary:
					tabControl_RMA.SelectedTab = tabSummary;
					break;
			}
		}

		private void pbNotesFlag_Click(object sender, EventArgs e)
		{
			SetView(ViewEnum.Journal);
		}

		private void FormRMA_Editor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Escape)
				return;

			Close();
		}
		#endregion

		#region RMA General
		public void RMA_Load(int rmaID)
		{
			_rma = ClassRMA.GetRMA(rmaID);
			_journal = ClassJournal.GetByObject(_rma);

			if (_rma == null)
			{
				MessageBox.Show("Specified RMA does not exist.", "RMA Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(rmaID).ToList();
			foreach (var assy in _rmaAssemblies)
			{
				// Get bin details for each assembly
				var bin = ClassRMA_Bin.GetBinForAssembly(assy.ID);
				if (bin == null)
					continue;
				assy.AssignedBinID = bin.BinName;
			}
			ClassRMA.ClassRMAAssembly.GetRMAAssemblyRepairStrings(_rmaAssemblies);
			_ticket = ClassTicket.GetByID(_rma.TicketID);
			_asset = ClassAsset.GetByID(_rma.AssetID);
			_shipments = ClassShipment.GetListByRMA(_rma.ID);
			_components = ClassRMA_Component.GetComponentsByRma(rmaID).ToList();
			_rmaBin = null;
			_controllerHardware = ControllerHardware.GetAll().ToList();
			Populate();
		}

		private void Populate()
		{
			_ignoreStateChange = true;

			chkSubscribe.Checked = ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			Populate_TopDetails();
			Populate_Journal();
			Populate_TicketDetails();
			Populate_AssetDetails();
			Populate_AddAssemblies();
			Populate_Receive();
			Populate_Repair();
			Populate_Shipments();
			Populate_Accounting();
			Populate_Summary();
			_ignoreStateChange = false;

			// Show warning if showing a deleted RMA
			if (_rma.IsDeleted)
				MessageBox.Show("This RMA has been deleted.", "Deleted RMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Populate_TopDetails()
		{
			btnModify.Enabled = true;
			btnExport.Enabled = true;

			txtRMADetails_RMANumber.Text = _rma.ID.ToString(CultureInfo.InvariantCulture);
			txtRMADetails_Asset.Text = _rma.AssetName;

			chkRMADetails_APR.Checked = _rma.IsAPR;
			chkRMA_Hot.Checked = _rma.IsHot;
            if (_rma.Hot_Date != null)
                tbxHotDate.Text = ((DateTime)_rma.Hot_Date).ToShortDateString() + " " + ((DateTime)_rma.Hot_Date).ToShortTimeString();
            else tbxHotDate.Text = "";

			if (!string.IsNullOrEmpty(_rma.PONumber))
			{
				radRMADetails_PONumber.Checked = true;
				radRMADetails_JobNumber.Checked = false;
				txtRMADetails_Job_PO.Text = _rma.PONumber;
			}
			else
			{
				radRMADetails_PONumber.Checked = false;
				radRMADetails_JobNumber.Checked = true;
				txtRMADetails_Job_PO.Text = _rma.JobNumber;
			}
			txtRMADetails_AssignedTo.Text = _rma.TechName;
			txtRMADetails_LegacyRMA.Text = _rma.LegacyRMANumber.ToString();

			txtRMADetails_CreatedBy.Text = _rma.Creation_UserName;
			txtRMADetails_CreationDate.Text = _rma.Creation_Date.ToString("yyyy-MM-dd");
			txtRMADetails_Completed.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", "In Progress", _rma.Completed_Date);
			txtRMADetails_Finalized.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", string.Empty, _rma.Finalized_Date);

			// Status
			txtRmaStatus.Text = _rma.Status.Status;
			txtRmaStatus.ForeColor = _rma.Status.Foreground;
			txtRmaStatus.BackColor = _rma.Status.Background;

			// Color Highlights
			txtRMADetails_Completed.BackColor = _rma.IsCompleted && !_rma.IsFinalized ? COL_COMPLETED_BG : SystemColors.Control;
			txtRMADetails_Finalized.BackColor = _rma.IsFinalized ? COL_FINALIZED_BG : SystemColors.Control;

			if (_rma.Completed_Date != null)
				txtRMADetails_Duration.Text = ClassUtility.FormatTimeSpan_Dhm(_rma.Completed_Date.Value - _rma.Creation_Date);
			else
				txtRMADetails_Duration.Clear();

			txtRMADetails_Notes.Text = _rma.Notes;
			pbNotesFlag.Visible = _rma.HasNonSystemInfo;

			if (_rma.IsDeleted)
				tabControl_RMA.SelectedTab = tabAssemblyTypes;
			// Lock controls if deleted
			tabControl_RMA.Enabled = !_rma.IsDeleted;
		}

		private void chkRMA_Hot_CheckedChanged(object sender, EventArgs e)
		{
			if (chkRMA_Hot.Checked)
			{
				chkRMA_Hot.BackColor = Color.Red;
				chkRMA_Hot.ForeColor = Color.White;
			}
			else
			{
				chkRMA_Hot.BackColor = SystemColors.Control;
				chkRMA_Hot.ForeColor = Color.Gray;
			}
		}

		private void chkRMADetails_APR_CheckedChanged(object sender, EventArgs e)
		{
			if (chkRMADetails_APR.Checked)
			{
				chkRMADetails_APR.BackColor = Color.Black;
				chkRMADetails_APR.ForeColor = Color.White;
			}
			else
			{
				chkRMADetails_APR.BackColor = SystemColors.Control;
				chkRMADetails_APR.ForeColor = Color.Gray;
			}
		}

		private void Populate_TicketDetails()
		{
			txtTicket_Number.Text = _rma.TicketID.ToString(CultureInfo.InvariantCulture);
			txtTicket_Symptoms.Text = _ticket.ExtraProperties.Symptoms();
			txtTicket_OSANotes.Text = _ticket.OSANotes;
		}

		private void Populate_AssetDetails()
		{
			if (_asset.CabinetTypeId != null)
			{
				var cabinetType = ClassCabinetType.GetByID(_asset.CabinetTypeId);
				if (cabinetType != null)
					txtAsset_SignType.Text = cabinetType.Description;
			}
			txtAsset_Matrix.Text = $"{_asset.MatrixWidth}x{_asset.MatrixHeight}";
			txtAsset_Pitch.Text = _asset.Pitch.ToString(CultureInfo.InvariantCulture);
			txtAsset_ControllerHw.Text = _controllerHardware.SingleOrDefault(hw => hw.ID == _asset.ControllerHardwareId)?.Description;
			txtAsset_InstallDate.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", string.Empty, _asset.WarrantyInfo.InstallDate);
		}

		private void tabControl_RMA_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_rma != null)
				RMA_Load(_rma.ID);
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			if (!GS.Settings.LoggedOnUser.IsAdmin && !GS.Settings.LoggedOnUser.IsMod)
			{
				MessageBox.Show("Only moderators and administrators may modify RMAs.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			using (var frm = new FormRMA_Modify(_rma.ID))
			{
				if (frm.ShowDialog(this) == DialogResult.OK)
					RMA_Load(_rma.ID);

				if (frm.ChangedToApr)
				{
					MessageBox.Show("This RMA is for Advanced Parts Replacement, and requires that a shipment be created.", "APR RMA Shipment Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CreateShipment?.Invoke(_rma.ID);
				}

			}
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			ExportRMA(_rma.ID);
		}

		private void btnRMATime_Click(object sender, EventArgs e)
		{
			using (var frt = new FormRMA_TimeAnalysis(_rma))
				frt.ShowDialog(this);
		}

		private void chkSubscribe_Click(object sender, EventArgs e)
		{
			if (_rma == null || _rma.ID < 0)
				return;

			if (_ignoreStateChange)
				return;

			if (ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID))
			{
				ClassSubscription.Unsubscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
				chkSubscribe.Checked = false;
			}
			else
			{
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
				chkSubscribe.Checked = true;
			}
		}
		#endregion

		#region Jumps
		private void txtRMADetails_TicketID_Click(object sender, EventArgs e)
		{
			if (ViewTicket != null && _rma != null)
				ViewTicket(_rma.TicketID);
		}

		private void txtRMADetails_Asset_Click(object sender, EventArgs e)
		{
			if (ViewAsset != null && _rma != null)
				ViewAsset(_rma.AssetID);
		}

		private void txtRMADetails_AssignedTo_Click(object sender, EventArgs e)
		{
			if (ViewTech != null && _rma != null)
				ViewTech(_rma.TechID);
		}

		private void txtRMADetails_LegacyRMA_Click(object sender, EventArgs e)
		{
			if (ViewLegacyRMA == null || _rma?.LegacyRMANumber == null)
				return;

			ViewLegacyRMA(_rma.LegacyRMANumber.Value);
		}
		#endregion

		#region Search
		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			e.SuppressKeyPress = true;
			RMA_StartSearch();
		}

		private void txtSearch_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnSearch;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			RMA_StartSearch();
		}

		private void RMA_StartSearch()
		{
			if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
				return;
			// Clear search field if something was found
			if (RMA_Search(txtSearch.Text.Trim()))
				txtSearch.Clear();
		}

		private bool RMA_Search(string searchTerm)
		{
			if (!int.TryParse(searchTerm, out var rmaID))
			{
				MessageBox.Show("Invalid Number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			var rmas = ClassRMA.GetByNumberIncludingLegacy(rmaID).ToList();
			switch (rmas.Count)
			{
				case 0:
					MessageBox.Show($"No RMAs found with number {rmaID}.", "RMA Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;

				case 1:
					RMA_Load(rmas[0].ID);
					return true;

				default: //2+
					MessageBox.Show($"Multiple RMAs found with number {rmaID}. (There may be a duplicate between current and legacy RMAs. Use the search feature on the RMA List.)", "Multiple Matches Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
			}
		}
		#endregion

		#region Journal
		private void Populate_Journal()
		{
			_journal.PopulateDataGridView(dgvJournal);
			dgvJournal.DefaultCellStyle.Font = GS.Settings.JournalFont;
		}

		private void btnJournal_Add_Click(object sender, EventArgs e)
		{
			if (_rma == null || _rma.ID < 0)
				return;

			using (var frmJournal = new FormJournal(_rma, ClassRMA.MAX_JOURNAL_EXPIRATION, ClassJournal.ExpirationType.NotRequired))
			{
				if (frmJournal.ShowDialog(this) == DialogResult.Cancel)
					return;

				ClassJournal.AddJournalEntry(_rma, frmJournal.JournalEntry);

				// Send notifications for RMA journal addition
				ClassNotification.SendNotificationsForObject(frmJournal.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

				// Send notifications for RMA journal addition expiration
				if (frmJournal.JournalEntry.ExpireDateTime.HasValue)
					ClassNotification.SendNotificationsForObject("EXPIRED: " + frmJournal.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID, null, frmJournal.JournalEntry.ExpireDateTime.Value);
			}

			RMA_Load(_rma.ID);
		}
		#endregion

		#region Assemblies
		private void Populate_AddAssemblies()
		{
			olvAssemblyAdd.SetObjects(_rmaAssemblies);
			txtAssemblyAdd_Qty.Text = _rmaAssemblies.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void olvAssemblyAdd_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var currentAssembly = (ClassRMA.ClassRMAAssembly)e.Model;
			e.Item.ForeColor = currentAssembly.StatusColor;
		}

		private void olvAssemblyAdd_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (olvAssemblyAdd.SelectedItem == null)
				lblAssemblyAdd_SelectedAssemblyID.Text = string.Empty;
			else
			{
				var assy = (ClassRMA.ClassRMAAssembly)olvAssemblyAdd.SelectedObject;
				lblAssemblyAdd_SelectedAssemblyID.Text = $"ID: {assy.ID}";
			}
		}
		#endregion

		#region Receive
		private void Populate_Receive()
		{
			olvReceive_Assemblies.DeselectAll();
			olvReceive_Assemblies.SetObjects(_rmaAssemblies);

			txtReceive_ReceivedQty.Text = _rma.Assemblies_ReceivedOrDiscarded_Qty.ToString(CultureInfo.InvariantCulture);
			txtReceive_TotalAssyQty.Text = _rma.AssemblyQty.ToString(CultureInfo.InvariantCulture);

			EnableReceiveControls(false);

			Populate_Receive_SelectedBin();
		}

		private void Populate_Receive_SelectedBin()
		{
			if (_rmaBin == null)
				_rmaBin = ClassRMA_Bin.GetLastBin(_rma.ID);

			if (_rmaBin != null)
			{
				var assyQty = _rmaBin.GetAssemblyQty();
				lblReceive_BinAssyQty.Text = $"({assyQty} item{assyQty.SIfPlural()})";
				txtReceive_CurrentBinID.ForeColor = assyQty == 0 ? Color.Green : SystemColors.WindowText;
				txtReceive_CurrentBinID.BackColor = SystemColors.Control;
			}

			txtReceive_CurrentBinID.Text = _rmaBin == null ? "NONE" : _rmaBin.BinName;
		}

		private void btnReceive_Receive_Click(object sender, EventArgs e)
		{
			#region Validation
			if (olvReceive_Assemblies.SelectedItems.Count != 1)
				return;

			var rmaAssy = (ClassRMA.ClassRMAAssembly)olvReceive_Assemblies.SelectedObject;

			if (rmaAssy.Discarded)
			{
				var confirmReceiveDiscardedMessage = string.Format("This assembly is marked as discarded. If you receive it, it will no longer be marked as discarded.{0}{0}Are you sure you want to receive this assembly?", Environment.NewLine);
				if (MessageBox.Show(confirmReceiveDiscardedMessage, "Confirm: Receive Discarded Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
			}

			// If a bin was scanned, select it (for convenience)
			if (ClassRMA_Bin.ValidateBinName(txtReceive_AssemblySerialNumber.Text))
			{
				SelectBin(txtReceive_AssemblySerialNumber.Text);
				var selectedAssembly = olvReceive_Assemblies.SelectedObject;
				olvReceive_Assemblies.SelectedObject = selectedAssembly;
				txtReceive_AssemblySerialNumber.Clear();
				txtReceive_AssemblySerialNumber.Select();
				return;
			}

			// Same assembly selected, but different serial number; confirm
			if (!string.IsNullOrEmpty(rmaAssy.SerialNumber) && rmaAssy.SerialNumber != txtReceive_AssemblySerialNumber.Text)
			{
				var message = string.Format("Serial number is different. Are you sure you want to change the serial number of:{0}{0}{1}?", Environment.NewLine, rmaAssy.Description);
				if (MessageBox.Show(message, "Confirm Serial Number Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;
			}

			if (!ClassRMA.ClassRMAAssembly.ValidateSerialNumber(txtReceive_AssemblySerialNumber.Text, rmaAssy.AssemblyTypeSerialNumberFormat))
			{
				var message = $"Serial number is not valid. Required format is: \"{rmaAssy.AssemblyTypeSerialNumberFormat}\"";
				MessageBox.Show(message, "Invalid Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			if (_rmaBin == null)
			{
				MessageBox.Show("A bin must be selected.", "Bin Required", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtReceive_AssemblySerialNumber.SelectAll();
				return;
			}
			#endregion

			try
			{
				ClassRMA.ReceiveAssembly(_rma.ID, rmaAssy, txtReceive_AssemblySerialNumber.Text.Trim(), _rmaBin);
			}
			catch (ArgumentException)
			{
				txtReceive_AssemblySerialNumber.Clear();
				MessageBox.Show("Cannot receive assembly with same serial number as another assembly in the same RMA.", "Duplicate Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			var journalText = string.IsNullOrEmpty(rmaAssy.SerialNumber) ? $"Received {rmaAssy.AssemblyNumber}, ID: {rmaAssy.ID}" : $"Received {rmaAssy.AssemblyNumber}, SN: {rmaAssy.SerialNumber}";
			ClassJournal.AddJournalEntry(_rma, journalText, null, true);
			ClassNotification.SendNotificationsForObject(journalText, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			// Ticket journal updates
			if (!_rma.IsReceived && _rma.AssemblyQty > 1)
			{
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} first assembly received", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
			}

			// Reload RMA, but preserve selected bin
			var previousBin = _rmaBin;
			
			RMA_Load(_rma.ID);

			if (previousBin != null)
				SelectBin(previousBin.BinName);
			
			// After reloading RMA... more ticket journal updates
			if (_rma.IsFullyReceivedOrDiscarded)
			{
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} received", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
			}

			SelectNextReceivableAssembly(rmaAssy.ID);
		}

		private void btnReceive_DiscardSelected_Click(object sender, EventArgs e)
		{
			#region Validation
			if (olvReceive_Assemblies.SelectedItems.Count != 1)
				return;

			var assy = (ClassRMA.ClassRMAAssembly)olvReceive_Assemblies.SelectedObject;

			if (assy.Discarded)
				return;

			if (assy.IsRepairComplete || assy.IsRepairStarted)
			{
				MessageBox.Show("This assembly has started or completed repair and cannot be discarded.", "Assembly Cannot be Discarded", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (assy.Receive_Date.HasValue)
			{
				var discardConfirmMessage = string.Format("This assembly has already been received. If you are discarding this assembly, you should do so in the repair section by selecting an appropriate repair type.{0}{0}Are you sure you want to discard this assembly and remove record of its receipt?", Environment.NewLine);
				if (MessageBox.Show(discardConfirmMessage, "Confirm: Discard Received Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
			}
			#endregion

			ClassRMA.DiscardAssembly(_rma.ID, assy);
			var journalText = $"Discarded {assy.AssemblyNumber}";
			ClassJournal.AddJournalEntry(_rma, journalText, null, true);
			ClassNotification.SendNotificationsForObject(journalText, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			RMA_Load(_rma.ID);

			// Ticket journal updates
			if (_rma.IsFullyReceivedOrDiscarded)
			{
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} received", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
			}

			SelectNextReceivableAssembly(assy.ID);
		}

		/// <summary>
		/// To make RECEIVING assemblies quicker, select the next UNRECEIVED assembly, if one exists
		/// If not, select the RMA Number field.
		/// </summary>
		/// <param name="excludeThisAssemblyID">The ID of the assembly that was just received to avoid selecting it.</param>
		private void SelectNextReceivableAssembly(int? excludeThisAssemblyID)
		{
			var nextReceived = excludeThisAssemblyID.HasValue ?
				olvReceive_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().FirstOrDefault(a => !a.Receive_Date.HasValue && a.ID != excludeThisAssemblyID) :
				olvReceive_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().FirstOrDefault(a => !a.Receive_Date.HasValue);

			if (nextReceived != null)
			{
				olvReceive_Assemblies.SelectObject(nextReceived);
			}
			else
			{
				// Select RMA field as there are no more assemblies to migrate
				txtSearch.Select();
				txtSearch.SelectAll();
			}
		}

		private void olvReceive_Assemblies_SelectedIndexChanged(object sender, EventArgs e)
		{
			HandleAssemblySelectionOnReceiveTab();
		}

		private void olvReceive_Assemblies_Click(object sender, EventArgs e)
		{
			HandleAssemblySelectionOnReceiveTab();
		}

		private void HandleAssemblySelectionOnReceiveTab()
		{
			if (_ignoreStateChange)
				return;

			EnableReceiveControls(false);

			var selectedAssembly = (ClassRMA.ClassRMAAssembly)olvReceive_Assemblies.SelectedObject;
			if (selectedAssembly == null)
			{
				lblReceive_SelectedAssemblyID.Text = string.Empty;
				txtReceive_AssemblySerialNumber.Clear();
				return;
			}

			lblReceive_SelectedAssemblyID.Text = $"ID: {selectedAssembly.ID}";
			txtReceive_AssemblySerialNumber.Text = selectedAssembly.SerialNumber;

			var received = selectedAssembly.Receive_Date.HasValue;

			// Enable receive and prev/next bin buttons if selected assembly is not already received
			EnableReceiveControls(!received);

			// If assembly is assigned to a bin, select it, otherwise show currently selected bin
			var assyBin = ClassRMA_Bin.GetBinForAssembly(selectedAssembly.ID);
			if (assyBin != null)
				SelectBin(assyBin.BinName);

			// If currently selected bin is null, select last bin for RMA
			if (_rmaBin == null)
				_rmaBin = ClassRMA_Bin.GetLastBin(_rma.ID);

			txtReceive_CurrentBinID.Text = _rmaBin == null ? "NONE" : _rmaBin.BinName;

			// If unreceived, place cursor in serial number field for barcode scanning
			if (selectedAssembly.Receive_Date.HasValue)
				return;

			SelectAndFocusReceiveSerialNumber();
		}

		private void EnableReceiveControls(bool enable)
		{
			txtReceive_AssemblySerialNumber.ReadOnly = !enable;

			btnReceive_ReceiveSelected.Enabled = enable;
		}

		private void SelectAndFocusReceiveSerialNumber()
		{
			txtReceive_AssemblySerialNumber.SelectAll();
			txtReceive_AssemblySerialNumber.Select();
		}

		private void olvReceive_Assemblies_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var currentAssembly = (ClassRMA.ClassRMAAssembly)e.Model;
			e.Item.ForeColor = currentAssembly.StatusColor;
		}

		private void mnuReceive_Undo_Click(object sender, EventArgs e)
		{
			var selectedAssembly = (ClassRMA.ClassRMAAssembly)olvReceive_Assemblies.SelectedObject;

			#region Validation
			if (selectedAssembly == null)
				return;

			if (selectedAssembly.IsRepairStarted || selectedAssembly.IsRepairComplete)
			{
				MessageBox.Show("Cannot Undo Receive of an assembly that has repair in progress or completed.", "Cannot Undo Receive", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			#endregion

			ClassRMA.UnreceiveAssembly(_rma.ID, selectedAssembly.ID);
			RMA_Load(_rma.ID);

			// Reselect last item
			olvReceive_Assemblies.SelectedObject = selectedAssembly;
		}

		private void txtReceive_AssemblySerialNumber_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnReceive_ReceiveSelected;
		}

		private void btnReceive_SelectBin_Click(object sender, EventArgs e)
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
			Populate_Receive_SelectedBin();
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
			Populate_Receive();
		}

		private void btnReceive_DeleteBin_Click(object sender, EventArgs e)
		{
			var previouslySelectedAssembly = (ClassRMA.ClassRMAAssembly)olvReceive_Assemblies.SelectedObject;

			if (_rmaBin.GetAssemblies().Any())
			{
				var message = $"Cannot delete bin {_rmaBin.BinName} which contains assemblies.";
				MessageBox.Show(message, "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			_rmaBin.DeleteBin();
			_rmaBin = null;
			Populate_Receive();

			// Reselect last item
			if (previouslySelectedAssembly != null)
				olvReceive_Assemblies.SelectedObject = previouslySelectedAssembly;
		}

		private void btnReceive_PrintBinLabels_All_Click(object sender, EventArgs e)
		{
			ClassRMA_Bin.PrintBinLabels(ClassRMA_Bin.GetByRMA(_rma.ID));
		}

		private void btnReceive_PrintBinLabels_Current_Click(object sender, EventArgs e)
		{
			if (_rmaBin == null)
				return;

			ClassRMA_Bin.PrintBinLabels(new[] { _rmaBin });
		}
		#endregion

		#region Repair
		private void Populate_Repair()
		{
			Clear_Repair_Assembly();
            
			olvRepair_Assemblies.SetObjects(_rmaAssemblies.Where(a => a.Receive_Date.HasValue || a.Discarded));
			txtRepair_Assemblies_ReceivedQty.Text = _rmaAssemblies.Count(a => a.Receive_Date.HasValue).ToString(CultureInfo.InvariantCulture);
			txtRepair_Assemblies_TotalQty.Text = _rmaAssemblies.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void olvRepair_Assemblies_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			_ignoreStateChange = true;
			Clear_Repair_Assembly();

			if (olvRepair_Assemblies.SelectedItems.Count == 0)
			{
				//Lock_Repair_Assembly(true);
				_ignoreStateChange = false;
				return;
			}
			_repairAssembly = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			_repairAssembly.RepairLog = ClassRMA.ClassRMAAssembly.RMAAssembly_GetRepairLog(_repairAssembly.ID).ToList();
			Populate_Repair_Assembly(_rmaAssemblies.Single(a => a.ID == _repairAssembly.ID));
			_ignoreStateChange = false;
		}

		private void Clear_Repair_Assembly()
		{
			lblRepair_SelectedAssemblyID.Text = string.Empty;

			foreach (var t in pnlRepair_FailureSection.Controls.OfType<TextBox>())
				t.Clear();
			lblRepair_Discarded.Visible = false;

			foreach (var t in pnlRepair_RepairTime.Controls.OfType<TextBox>())
				t.Clear();

			txtRepair_DateStarted.BackColor = SystemColors.Control;
			txtRepair_DateCompleted.BackColor = SystemColors.Control;
			txtRepair_DateFinalized.BackColor = SystemColors.Control;

			olvRepair_RepairLog.SetObjects(null);
            
			cmbRepair_Assembly.DataSource = null;
           // cmbRepairAction.DataSource = null;

			cmbRepair_Assembly.SelectedIndex = -1;
			chkRepair_UnlockAssemblyFromType.Checked = false;
			olvRepair_RepairTypes.SetObjects(null);
			olvRepair_Components.SetObjects(null);
			txtRepair_MU.Clear();
			txtRepair_Components_Qty.Clear();
			txtRepair_Notes.Clear();
			btnRepair_Finish.Text = "Finish Repair";

			btnRepair_StartStop.Enabled = btnRepair_Finish.Enabled = false;
			pnlRepair_RepairDetail.Enabled = false;
		}

		private void Lock_Repair_Assembly(bool Lock)
		{
			cmbRepair_Assembly.Enabled = !Lock;
			chkRepair_UnlockAssemblyFromType.Enabled = !Lock;
			btnAssemblyManagement.Enabled = !Lock;
			txtRepair_OriginalJobNumber.ReadOnly = Lock;
			txtRepair_LEDBoard_Calibration.ReadOnly = Lock;
			txtRepair_SerialNumber.ReadOnly = Lock;
			btnRepair_RepairType_Add.Enabled = !Lock;
			btnRepair_RepairType_Remove.Enabled = !Lock;
			btnRepair_Component_Add.Enabled = !Lock;
			btnRepair_Component_Remove.Enabled = !Lock;
			txtRepair_MU.ReadOnly = Lock;
			txtRepair_Notes.ReadOnly = Lock;
            cmbRepairAction.Enabled = !Lock;
		}

		private void olvRepair_Assemblies_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var currentAssembly = (ClassRMA.ClassRMAAssembly)e.Model;
			e.Item.ForeColor = currentAssembly.StatusColor;
		}

		private void Populate_Repair_Assembly(ClassRMA.ClassRMAAssembly repairAssembly)
		{
			if (repairAssembly == null)
				return;

			lblRepair_SelectedAssemblyID.Text = $"ID: {repairAssembly.ID}";

			// FAILURE SECTION
			txtRepair_FailureType.Text = repairAssembly.FailureTypeDescription;
			txtRepair_FailureNotes.Text = repairAssembly.Failure_Notes;
			txtRepair_GridLocation.Text = repairAssembly.Failure_GridLocation;
			txtRepair_ReceiveDate.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd} by {1}", string.Empty, repairAssembly.Receive_Date, repairAssembly.Receive_UserName);
			lblRepair_Discarded.Visible = repairAssembly.Discarded;
			txtRepair_InventoryLocation.Text = GetInventoryLocation(repairAssembly);

			// REPAIR LOG SECTION
			olvRepair_RepairLog.SetObjects(repairAssembly.RepairLog.OrderByDescending(rl => rl.ID).ToList());
            

            if (repairAssembly.IsRepairStarted)
			{
				txtRepair_DateStarted.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm}", string.Empty, repairAssembly.Repair_DateTime_Start);
				txtRepair_TechTime.Text = ClassUtility.FormatTimeSpan_Dhm(_repairAssembly.Repair_TotalTechTime);
			}
			if (repairAssembly.IsRepairStarted && repairAssembly.IsRepairComplete)
			{
				txtRepair_DateCompleted.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm}", string.Empty, repairAssembly.Repair_DateTime_End);
				txtRepair_RepairTime.Text = ClassUtility.FormatTimeSpan_Dhm(repairAssembly.Repair_TotalTime);
			}
			if (repairAssembly.IsFinalized)
			{
				txtRepair_DateFinalized.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm}", string.Empty, repairAssembly.Finalize_Date);
				txtRepair_FinalizedBy.Text = repairAssembly.Finalize_UserName;
			}

			txtRepair_DateStarted.BackColor = repairAssembly.IsRepairStarted && !repairAssembly.IsRepairComplete ? COL_INPROGRESS_BG : SystemColors.Control;
			txtRepair_DateCompleted.BackColor = repairAssembly.IsRepairComplete && !repairAssembly.IsFinalized ? COL_COMPLETED_BG : SystemColors.Control;
			txtRepair_DateFinalized.BackColor = repairAssembly.IsFinalized ? COL_FINALIZED_BG : SystemColors.Control;

			btnRepair_StartStop.Text = repairAssembly.IsRepairInProgress ? "Stop Repair" : repairAssembly.RepairLog.Count > 0 ? "Resume Repair" : "Start Repair";
			btnRepair_StartStop.Enabled = !repairAssembly.Repair_DateTime_End.HasValue;

			// REPAIR DETAILS SECTION
			pnlRepair_RepairDetail.Enabled = repairAssembly.IsRepairStarted;

			var assemblies = ClassAssembly.GetAssemblies(repairAssembly.AssemblyType_ID).OrderBy(a => a.AssemblyNumber).ToList();
			cmbRepair_Assembly.DisplayMember = "DisplayMember";
			cmbRepair_Assembly.ValueMember = "ID";
			cmbRepair_Assembly.DataSource = assemblies;
			toolTip.SetToolTip(cmbRepair_Assembly, assemblies.Count > 0 ? "Select a specific assembly." : "No specific assemblies are configured for this assembly type. Contact an administrator.");

			if (repairAssembly.Assembly_ID.HasValue)
				cmbRepair_Assembly.SelectedValue = repairAssembly.Assembly_ID.Value;
			else
				cmbRepair_Assembly.SelectedIndex = -1;

			txtRepair_OriginalJobNumber.Text = repairAssembly.Repair_OriginalJob;
			txtRepair_LEDBoard_Calibration.Text = repairAssembly.Repair_Calibration;
			txtRepair_SerialNumber.Text = repairAssembly.SerialNumber;
			txtRepair_MU.Text = repairAssembly.Repair_MU;
			txtRepair_Notes.Text = repairAssembly.Repair_Notes;

			Populate_Repair_Assembly_RepairTypes(repairAssembly.ID);
			Populate_Repair_Assembly_Components(repairAssembly.ID);

			btnRepair_Finish.Enabled = repairAssembly.IsRepairStarted && !repairAssembly.IsRepairComplete;
			btnRepair_Save.Enabled = repairAssembly.IsRepairStarted && !repairAssembly.IsRepairComplete;
			btnRepair_Unfinish.Visible = repairAssembly.IsRepairComplete && GS.Settings.LoggedOnUser.IsAdmin;

			Lock_Repair_Assembly(repairAssembly.IsRepairComplete);
		}

		/// <summary>
		/// Gets the inventory location for specified assembly as a string like "xxx (yyy, zzz)" where xxx is the bin, yyy is the zone, and zzz is the area.
		/// If the assembly is not assigned to a bin, returns an empty string.
		/// If the bin is not assigned to a zone, returns the bin number.
		/// </summary>
		private string GetInventoryLocation(ClassRMA.ClassRMAAssembly assy)
		{
			var bin = ClassRMA_Bin.GetBinForAssembly(assy.ID);
			if (bin == null)
			{
				var oldZone = ClassRMA_Zone.GetByID(assy.Receive_Zone);
				if (oldZone == null)
					return string.Empty;
				var oldArea = ClassRMA_Area.GetByID(oldZone.Area_ID);
				return $"({oldZone.ZoneName}, {oldArea.AreaName})";
			}

			var zone = ClassRMA_Zone.GetByID(bin.Zone_ID);
			if (zone == null)
				return bin.BinName;
			var area = ClassRMA_Area.GetByID(zone.Area_ID);

			return $"{bin.BinName} ({zone.ZoneName}, {area.AreaName})";
		}

		private void chkRepair_UnlockAssemblyFromType_CheckedChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			var assemblies = chkRepair_UnlockAssemblyFromType.Checked ? ClassAssembly.GetByType().OrderBy(a => a.AssemblyNumber).ToList() : ClassAssembly.GetAssemblies(_repairAssembly.AssemblyType_ID).OrderBy(a => a.AssemblyNumber).ToList();
			cmbRepair_Assembly.DataSource = assemblies;
			toolTip.SetToolTip(cmbRepair_Assembly, assemblies.Count > 0 ? "Select a specific assembly." : "No specific assemblies are configured for this assembly type. Contact an administrator.");
		}

		private void mnuRepairFailureTypeChange_Click(object sender, EventArgs e)
		{
			if (_repairAssembly == null)
				return;

			var selectedRepairAssemblyID = _repairAssembly.ID;

			using (var failureTypeSelect = new FormRMA_FailureType_Select())
			{
				if (failureTypeSelect.ShowDialog() != DialogResult.OK)
					return;

				_repairAssembly.SetFailureType(failureTypeSelect.FailureType);
			}

			RMA_Load(_rma.ID);
			olvRepair_Assemblies.SelectedObject = olvRepair_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().Single(r => r.ID == selectedRepairAssemblyID);
		}

		private void Populate_Repair_Assembly_RepairTypes(int repairAssemblyID)
		{
			var assemblyRepairs = ClassRMA.ClassRMAAssembly.GetRMAAssemblyRepairTypes(repairAssemblyID).ToList();
			olvRepair_RepairTypes.SetObjects(assemblyRepairs);
		}

		private void Populate_Repair_Assembly_Components(int repairAssemblyID)
		{
			var assemblyRMAComponents = ClassRMA_Component.GetComponentsByAssembly(repairAssemblyID).ToList();
			olvRepair_Components.SetObjects(assemblyRMAComponents);
			txtRepair_Components_Qty.Text = assemblyRMAComponents.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void btnRepair_SerialNumberSearch_Click(object sender, EventArgs e)
		{
			using (var serialNumberSearchForm = new FormRMA_SerialNumberSearch(txtRepair_SerialNumber.Text.Trim()))
				serialNumberSearchForm.ShowDialog(this);
		}

		private void btnRepair_InventoryMove_Click(object sender, EventArgs e)
		{
			using (var moveStuffForm = new FormRMA_MoveStuff())
				moveStuffForm.ShowDialog(this);
		}

		private void btnRepair_StartStop_Click(object sender, EventArgs e)
		{
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			if (assemblyToRepair == null)
				return;

			if (assemblyToRepair.IsRepairInProgress)
			{
				if (assemblyToRepair.LastOrCurrentRepairTechID != GS.Settings.LoggedOnUser.ID && !GS.Settings.LoggedOnUser.IsAdmin)
				{
					MessageBox.Show("Only the active repair tech or an administrator may stop repair work on this assembly.", "Stop Repair Session Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				ClassRMA.ClassRMAAssembly.RMAAssembly_RepairSession_Stop(assemblyToRepair.ID);
			}
			else
			{
				#region Validation
				// Check if any HOT RMAs are received
				if (!_rma.IsHot && ClassRMA.CountReceivedInactiveHot() > 0)
				{
					if (MessageBox.Show(string.Format("This RMA should not be worked on yet.{0}{0}There are RMAs marked as Hot which have been received.{0}{0}Are you sure you want to continue?", Environment.NewLine), "RMA Not Priority", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
						return;
				}

				#region deprecated-keep
				//// Check if RMA is oldest received
				//int? oldestReceivedRMA = ClassRMA.GetOldestReceivedInactiveID();
				//bool isOldestReceived = _rma.ID == oldestReceivedRMA;
				//if (!isOldestReceived && !_rma.IsHot && !_rmaAssemblies.Any(a => a.Repair_DateTime_Start.HasValue))
				//{
				//    string message = oldestReceivedRMA.HasValue ? "See RMA # " + oldestReceivedRMA.Value : "Check with supervisor.";
				//    MessageBox.Show(string.Format("This RMA cannot be worked on yet.{0}{0}There is at least one other RMA which has received parts earlier.{0}{0}{1}", Environment.NewLine, message),
				//        "RMA Locked", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//    return;
				//}
				#endregion

				// Check if any other RMA Assembly repair has been started by this tech
				var inProgressItems = ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_GetInProgressItems(GS.Settings.LoggedOnUser.ID).ToList();
				if (inProgressItems.Count > 0)
				{
					var sb = new StringBuilder();
					foreach (var item in inProgressItems)
						sb.AppendFormat("RMA {0}, {1}: Started {2:yyyy-MM-dd}{3}", item.RMA_ID, item.Assembly_Type_Description, item.Repair_Started, Environment.NewLine);
					MessageBox.Show(string.Format("You cannot start work on this assembly because you have one or more other assemblies in progress:{0}{0}{1}", Environment.NewLine, sb), "Other Repair in Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
                #endregion

                int? id = (int)ClassRepair_Actions.GetIDByString((string)cmbRepairAction.SelectedValue);
                if (id == null)
                {
                    MessageBox.Show("Error: 1184", "ERROR");
                    return;
                }
                    

                ClassRMA.ClassRMAAssembly.RMAAssembly_RepairSession_Start(assemblyToRepair.ID, (int)id);
			}

			RMA_Load(_rma.ID);
			olvRepair_Assemblies.SelectedObject = olvRepair_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().Single(r => r.ID == assemblyToRepair.ID);
			cmbRepair_Assembly.Select();
		}

		private void btnRepair_RepairType_Add_Click(object sender, EventArgs e)
		{
			#region Validation
			if (olvRepair_Assemblies.SelectedItems.Count < 1)
				return;
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			#endregion

			var frts = new FormRMA_RepairType_Select();
			if (frts.ShowDialog(this) != DialogResult.OK)
				return;
			try
			{
				ClassRMA.ClassRMAAssembly.RMAAssembly_RepairType_Add(assemblyToRepair.ID, frts.RepairType);
			}
			catch
			{
				MessageBox.Show("Cannot add duplicate repair type.", "Duplicate Repair Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Populate_Repair_Assembly_RepairTypes(assemblyToRepair.ID);
		}

		private void btnRepair_RepairType_Remove_Click(object sender, EventArgs e)
		{
			if (olvRepair_Assemblies.SelectedItems.Count < 1 || olvRepair_RepairTypes.SelectedItem == null)
				return;
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			var rmaRepairType = (ClassRMA_RepairType)olvRepair_RepairTypes.SelectedObject;
			ClassRMA.ClassRMAAssembly.RMAAssembly_RepairType_Remove(assemblyToRepair.ID, rmaRepairType.ID);
			Populate_Repair_Assembly_RepairTypes(assemblyToRepair.ID);
		}

		private void btnRepair_Component_Add_Click(object sender, EventArgs e)
		{
			#region Validation
			if (olvRepair_Assemblies.SelectedItems.Count < 1)
				return;
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			#endregion

			using (var componentSelectForm = new FormRMA_Component_Select())
			{
				if (componentSelectForm.ShowDialog(this) != DialogResult.OK)
					return;

				foreach (var component in componentSelectForm.RMAComponents)
					ClassRMA.ClassRMAAssembly.RMAAssembly_RMAComponent_Add(assemblyToRepair.ID, component);
			}
			Populate_Repair_Assembly_Components(assemblyToRepair.ID);
		}

		private void btnRepair_Component_Remove_Click(object sender, EventArgs e)
		{
			if (olvRepair_Assemblies.SelectedItems.Count < 1 || olvRepair_Components.SelectedItem == null)
				return;

			var previouslySelectedIndex = olvRepair_Components.SelectedIndex;
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			var rmaComponentToRemove = (ClassRMA_Component)olvRepair_Components.SelectedObject;
			ClassRMA.ClassRMAAssembly.RMAAssembly_RMAComponent_Remove(rmaComponentToRemove.ID);
			Populate_Repair_Assembly_Components(assemblyToRepair.ID);
			try
			{
				if (previouslySelectedIndex > olvRepair_Components.GetItemCount() - 1)
					previouslySelectedIndex--;
				if (previouslySelectedIndex < 0)
					previouslySelectedIndex = 0;

				olvRepair_Components.EnsureVisible(previouslySelectedIndex);
				olvRepair_Components.SelectedIndex = previouslySelectedIndex;
				olvRepair_Components.Select();
			}
			catch
			{
			}
		}

		private void btnRepair_Unfinish_Click(object sender, EventArgs e)
		{
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;

			if (assemblyToRepair?.Repair_DateTime_End == null)
				return;

			if (!GS.Settings.LoggedOnUser.IsAdmin)
			{
				MessageBox.Show("Only administrators can unfinish repairs to assemblies.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (MessageBox.Show("Are you sure you want to cancel repairs to this assembly? This will change the repair finish time, increasing the time taken to repair.", "Confirm Cancel RMA Assembly Repair",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Cancel(assemblyToRepair.ID);
			ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Finalize_Cancel(assemblyToRepair.ID);
			var entry = $"Canceled repairs on {assemblyToRepair.Description} [{assemblyToRepair.SerialNumber}]";
			ClassJournal.AddJournalEntry(_rma, entry, null, true);

			if (_rma.IsFinalized)
			{
				ClassRMA.SetFinalized(_rma.ID, false);
				ClassJournal.AddJournalEntry(_rma, "RMA finalize canceled.", null, true);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} finalize canceled.", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
			}
			if (_rma.IsCompleted)
			{
				ClassRMA.SetCompleted(_rma.ID, false);
				ClassJournal.AddJournalEntry(_rma, "RMA changed to incomplete.", null, true);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} changed to incomplete.", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
			}

			RMA_Load(_rma.ID);
			olvRepair_Assemblies.SelectedObject = olvRepair_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().Single(r => r.ID == assemblyToRepair.ID);
		}

		private void btnRepair_Save_Click(object sender, EventArgs e)
		{
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			if (assemblyToRepair == null)
				return;

			if (assemblyToRepair.IsRepairInProgress && (assemblyToRepair.LastOrCurrentRepairTechID != GS.Settings.LoggedOnUser.ID && !GS.Settings.LoggedOnUser.IsAdmin))
			{
				MessageBox.Show("Only the active repair tech or an administrator may save repair info for this assembly.", "Save Repair Info Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			UpdateRepairAssemblyObjectFromFields(assemblyToRepair);
			ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Update(assemblyToRepair);
			RMA_Load(_rma.ID);
			olvRepair_Assemblies.SelectedObject = olvRepair_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().Single(r => r.ID == assemblyToRepair.ID);
		}

		private void btnRepair_Finish_Click(object sender, EventArgs e)
		{
			#region Validation
			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;
			if (assemblyToRepair == null)
				return;

			if (assemblyToRepair.IsRepairInProgress && (assemblyToRepair.LastOrCurrentRepairTechID != GS.Settings.LoggedOnUser.ID && !GS.Settings.LoggedOnUser.IsAdmin))
			{
				MessageBox.Show("Only the active repair tech or an administrator may stop repair work on this assembly.", "Finish Repair Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (cmbRepair_Assembly.SelectedValue == null)
			{
				if (MessageBox.Show(string.Format("This assembly type does not have a specific assembly selected. An assembly must be selected (from the dropdown menu on the repair tab) in order to finish repair. This repair will NOT be marked as finished.{0}{0}Do you want to save changes?", Environment.NewLine),
					"Specific Assembly Not Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
				UpdateRepairAssemblyObjectFromFields(assemblyToRepair);
				ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Update(assemblyToRepair);
				return;
			}

			if (olvRepair_RepairTypes.Items.Count < 1)
			{
				MessageBox.Show("At least one repair type must be specified.", "Repair Type Not Specified", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			#endregion

			UpdateRepairAssemblyObjectFromFields(assemblyToRepair);
			ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Update(assemblyToRepair);
			ClassRMA.ClassRMAAssembly.RMAAssembly_RepairSession_Stop(assemblyToRepair.ID);
			ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Finish(assemblyToRepair);
			var entry = $"Finished repairs on {assemblyToRepair.Description} [{assemblyToRepair.SerialNumber}]";
			ClassJournal.AddJournalEntry(_rma, entry, null, true);
			ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			// Mark RMA completed if all assemblies have been repaired.
			if (ClassRMA.AreAllAssembliesRepaired(_rma.ID))
			{
				MessageBox.Show("All assemblies for this RMA are now repaired. The RMA will be marked as completed.", "RMA Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClassRMA.SetCompleted(_rma.ID);
				const string COMPLETED_TEXT = "Completed RMA repairs.";
				ClassJournal.AddJournalEntry(_rma, COMPLETED_TEXT, null, true);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} completed", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
				ClassNotification.SendNotificationsForObject(COMPLETED_TEXT, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			}

			RMA_Load(_rma.ID);

			if (_rma.IsCompleted)
			{
				// Select search box
				txtSearch.SelectAll();
				txtSearch.Select();
			}
			else
			{
				// Select first assembly in list that is not repaired yet
				var firstUnrepairedAssemblyInList = olvRepair_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().FirstOrDefault(ra => !ra.IsRepairComplete);
				if (firstUnrepairedAssemblyInList != null)
				{
					olvRepair_Assemblies.SelectedObject = olvRepair_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().Single(ra => ra.ID == firstUnrepairedAssemblyInList.ID);
					return;
				}
				// Otherwise select the assembly that was just finished
				olvRepair_Assemblies.SelectedObject = olvRepair_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().Single(ra => ra.ID == assemblyToRepair.ID);
			}
		}

		private void UpdateRepairAssemblyObjectFromFields(ClassRMA.ClassRMAAssembly repairedAssembly)
		{
			repairedAssembly.Assembly_ID = (int?)cmbRepair_Assembly.SelectedValue;
			repairedAssembly.Repair_OriginalJob = txtRepair_OriginalJobNumber.Text.Trim();
			repairedAssembly.Repair_Calibration = txtRepair_LEDBoard_Calibration.Text.Trim();
			repairedAssembly.SerialNumber = txtRepair_SerialNumber.Text.Trim();
			repairedAssembly.Repair_MU = txtRepair_MU.Text.Trim();
			repairedAssembly.Repair_Notes = txtRepair_Notes.Text.Trim();
		}

		private void btnAssemblyManagement_Click(object sender, EventArgs e)
		{
			if (olvRepair_Assemblies.SelectedItems.Count < 1)
				return;

			var assemblyToRepair = (ClassRMA.ClassRMAAssembly)olvRepair_Assemblies.SelectedObject;

			using (var frm = new FormAdmin_AssemblyManagement())
				frm.ShowDialog(this);

			cmbRepair_Assembly.DisplayMember = "DisplayMember";
			cmbRepair_Assembly.ValueMember = "ID";
			cmbRepair_Assembly.DataSource = ClassAssembly.GetAssemblies(assemblyToRepair.AssemblyType_ID).OrderBy(a => a.AssemblyNumber).ToList();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}
		#endregion

		#region Shipments
		private void Populate_Shipments()
		{
			ucShipmentList1.SetObjects(_shipments);
		}

		private void ucShipmentList1_CreateShipment()
		{
			if (CreateShipment == null)
				return;

			#region Validation
			// If the RMA is not APR and no assemblies have been repaired yet, disallow with dialog
			if (!_rma.IsAPR && _rma.Assemblies_RepairStarted_Qty < 1)
			{
				MessageBox.Show("RMA must be APR or at least one assembly received and repaired in order to create a shipment.", "Shipment Requirements Not Met", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			#endregion

			CreateShipment(_rma.ID);
		}

		private void ucShipmentList1_ViewShipment(int shipmentID)
		{
			ViewShipment?.Invoke(shipmentID);
		}

		private void ucShipmentList1_ViewTracking(string trackingURL)
		{
			ViewTracking?.Invoke(trackingURL);
		}
		#endregion

		#region Accounting
		private void Populate_Accounting()
		{
			olvAccounting_Components.SetObjects(_components);
			txtAccounting_Components_Qty.Text = _components.Count.ToString(CultureInfo.InvariantCulture);
			txtAccounting_TotalCost.Text = $"${_components.Sum(c => c.Component.Cost):#,##0.000}";
		}

		private void chkAccounting_Charged_CheckedChanged(object sender, EventArgs e)
		{
			ClassRMA.SetAccountingDone(_rma.ID, chkAccounting_Charged.Checked);
			RMA_Load(_rma.ID);
		}
		#endregion

		#region Summary
		private void Populate_Summary()
		{
			txtSummary_AssemblyRepairNotes.Clear();
			olvSummary_Assemblies.SetObjects(_rmaAssemblies);
			txtSummary_Assemblies_Qty.Text = _rmaAssemblies.Count.ToString(CultureInfo.InvariantCulture);
			olvSummary_Components.SetObjects(null);
		}

		private void olvSummary_Assemblies_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (olvSummary_Assemblies.SelectedItems.Count)
			{
				case 0:
					txtSummary_AssemblyRepairNotes.Clear();
					olvSummary_Components.SetObjects(null);
					olvSummary_Components.EmptyListMsg = "[NONE SELECTED]";
					txtSummary_Components_Qty.Clear();
					btnSummary_Assembly_Finalize.Enabled = false;
					return;

				case 1:
					var selectedAssembly = (ClassRMA.ClassRMAAssembly)olvSummary_Assemblies.SelectedObject;
					txtSummary_AssemblyRepairNotes.Text = selectedAssembly.Repair_Notes;
					var selectedAssemblyComponents = _components.Where(c => c.RMAAssemblyID == selectedAssembly.ID).ToList();
					olvSummary_Components.SetObjects(selectedAssemblyComponents);
					olvSummary_Components.EmptyListMsg = "No components for selected assembly.";
					txtSummary_Components_Qty.Text = selectedAssemblyComponents.Count.ToString(CultureInfo.InvariantCulture);
					btnSummary_Assembly_Finalize.Enabled = true;
					break;

				default:
					// Multiple selected
					txtSummary_AssemblyRepairNotes.Text = "[MULTIPLE SELECTED]";
					olvSummary_Components.SetObjects(null);
					olvSummary_Components.EmptyListMsg = "[MULTIPLE SELECTED]";
					txtSummary_Components_Qty.Clear();
					btnSummary_Assembly_Finalize.Enabled = true;
					break;
			}
		}

		private void olvSummary_Assemblies_DoubleClick(object sender, EventArgs e)
		{
			var selectedSummaryAssembly = (ClassRMA.ClassRMAAssembly)olvSummary_Assemblies.SelectedObject;
			if (selectedSummaryAssembly == null)
				return;

			// TODO Future: Permissions check

			FinalizeAssembly(selectedSummaryAssembly);
		}

		private void btnSummary_Assembly_Finalize_Click(object sender, EventArgs e)
		{
			var selectedAssyQty = olvSummary_Assemblies.SelectedItems.Count;

			if (selectedAssyQty < 1)
				return;

			switch (selectedAssyQty)
			{
				case 1:
					var selectedAssembly = (ClassRMA.ClassRMAAssembly)olvSummary_Assemblies.SelectedObject;
					if (selectedAssembly == null)
						return;

					if (selectedAssembly.Finalize_Date.HasValue)
					{
						if (!GS.Settings.LoggedOnUser.IsAdmin)
						{
							MessageBox.Show("Only administrators can change root cause assessment.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}

						if (MessageBox.Show("The selected assembly has already been finalized. Do you want to change the root cause?", "Assembly Already Finalized", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
							return;
					}

					FinalizeAssembly(selectedAssembly);
					break;

				default:
					var selectedAssemblies = olvSummary_Assemblies.SelectedObjects.Cast<ClassRMA.ClassRMAAssembly>().ToList();
					if (selectedAssemblies.Count < 1)
						return;

					if (selectedAssemblies.Any(a => a.Finalize_Date.HasValue))
					{
						if (!GS.Settings.LoggedOnUser.IsAdmin)
						{
							MessageBox.Show("Only administrators can change root cause assessment.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}

						if (MessageBox.Show("At least one selected assembly has already been finalized. Do you want to change the root cause?", "Assembly Already Finalized", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
							return;
					}

					FinalizeAssemblies(selectedAssemblies);
					break;
			}
		}

		private void olvSummary_Assemblies_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var currentAssembly = (ClassRMA.ClassRMAAssembly)e.Model;
			e.Item.ForeColor = currentAssembly.StatusColor;
		}

		private void FinalizeAssembly(ClassRMA.ClassRMAAssembly rmaAssembly)
		{
			if (rmaAssembly == null)
				return;

			if (!rmaAssembly.Repair_DateTime_End.HasValue)
			{
				MessageBox.Show("This assembly cannot be finalized until repairs are completed.", "Cannot Finalize", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (var rootCauseSelectionForm = new FormRMA_RootCause_Select())
			{
				if (rmaAssembly.Finalize_RootCause.HasValue)
					rootCauseSelectionForm.SetSelectedRootCause(rmaAssembly.Finalize_RootCause);

				if (rootCauseSelectionForm.ShowDialog(this) != DialogResult.OK)
					return;

				rmaAssembly.Finalize_RootCause = rootCauseSelectionForm.RootCause.ID;
			}
			ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Finalize(rmaAssembly);

			FinalizeRmaIfAllAssembliesFinalized();

			RMA_Load(_rma.ID);
			olvSummary_Assemblies.SelectedObject = olvSummary_Assemblies.Objects.Cast<ClassRMA.ClassRMAAssembly>().Single(r => r.ID == rmaAssembly.ID);
		}

		private void FinalizeAssemblies(List<ClassRMA.ClassRMAAssembly> rmaAssemblies)
		{
			if (rmaAssemblies == null || rmaAssemblies.Count < 0)
				return;

			if (rmaAssemblies.Any(ra => !ra.Repair_DateTime_End.HasValue))
			{
				MessageBox.Show("At least one assembly cannot be finalized until repairs are completed.", "Cannot Finalize", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (var rootCauseSelectionForm = new FormRMA_RootCause_Select())
			{
				if (rmaAssemblies.GroupBy(ra => ra.Finalize_RootCause).Count() == 1)
				{
					var rootCauseOfAllSelected = rmaAssemblies.First().Finalize_RootCause;
					if (rootCauseOfAllSelected.HasValue)
						rootCauseSelectionForm.SetSelectedRootCause(rootCauseOfAllSelected.Value);
				}

				if (rootCauseSelectionForm.ShowDialog(this) != DialogResult.OK)
					return;

				rmaAssemblies.ToList().ForEach(ra => ra.Finalize_RootCause = rootCauseSelectionForm.RootCause.ID);
			}

			rmaAssemblies.ForEach(ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_Finalize);

			FinalizeRmaIfAllAssembliesFinalized();

			RMA_Load(_rma.ID);
			olvSummary_Assemblies.SelectedObjects = rmaAssemblies;
		}

		/// <summary>
		/// Mark RMA finalized if all assemblies have been finalized.
		/// </summary>
		private void FinalizeRmaIfAllAssembliesFinalized()
		{
			if (!ClassRMA.AreAllAssembliesFinalized(_rma.ID))
				return;

			MessageBox.Show("All assemblies for this RMA are now finalized. The RMA will be marked as finalized.", "RMA Finalized", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClassRMA.SetFinalized(_rma.ID);
			ClassJournal.AddJournalEntry(_rma, "RMA finalized.", null, true);
			ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} finalized", null, true);
			if (_ticket.IsHeld)
				_ticket.Release();
			ClassNotification.SendNotificationsForObject("RMA finalized.", ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
		}

		private void spltSummary_Paint(object sender, PaintEventArgs e)
		{
			// Make the separator bar more visible
			// http://stackoverflow.com/a/4405758/161052

			var control = (SplitContainer)sender;

			// paint the three dots
			var points = new Point[3];
			var w = control.Width;
			var h = control.Height;
			var d = control.SplitterDistance;
			var sW = control.SplitterWidth;

			// calculate the position of the points
			if (control.Orientation == Orientation.Horizontal)
			{
				points[0] = new Point((w / 2), d + (sW / 2));
				points[1] = new Point(points[0].X - 10, points[0].Y);
				points[2] = new Point(points[0].X + 10, points[0].Y);
			}
			else
			{
				points[0] = new Point(d + (sW / 2), (h / 2));
				points[1] = new Point(points[0].X, points[0].Y - 10);
				points[2] = new Point(points[0].X, points[0].Y + 10);
			}

			foreach (var p in points)
			{
				p.Offset(-2, -2);
				e.Graphics.FillEllipse(SystemBrushes.ControlDark,
					new Rectangle(p, new Size(3, 3)));

				p.Offset(1, 1);
				e.Graphics.FillEllipse(SystemBrushes.ControlLight,
					new Rectangle(p, new Size(3, 3)));
			}
		}
		#endregion

		#region Export
		private void ExportRMA(int rmaID)
		{
			var eRMA = ClassRMA.GetRMA(rmaID);
			if (eRMA == null) return;
			var eAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(rmaID).ToList();
			//var eComponents = ClassRMA_Component.GetComponentsByRma(rmaID).ToList();

			using (var sfd = new SaveFileDialog())
			{
				sfd.FileName = $"RMA_{eRMA.ID}";
				sfd.Filter = "HTML Files (*.htm)|*.htm";
				sfd.DefaultExt = ".htm";
				sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
				if (sfd.ShowDialog(this) != DialogResult.OK)
					return;

				var sb = new StringBuilder();
				sb.AppendFormat(
					@"<html>
<head>
	<title>RMA {0} Details</title>
	<style type=""text/css"">
		body
		{{
			font-family: Arial, Helvetica, sans-serif;
		}}
		.b
		{{
			margin: 0 0 0 2em;
			font-weight: bold;
		}}
		.assy
		{{
			margin: 0 0 0 4em;
			font-weight: bold;
		}}
		.assy_rep
		{{
			margin: 0 0 0 6em;
		}}
	</style>
</head>
<body>", eRMA.ID).AppendLine();
				sb.AppendFormat("<h3>RMA: {0}</h3>", eRMA.ID).AppendLine();
				sb.AppendLine("<h4>Details</h4>");
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Ticket #", eRMA.TicketID).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Asset", eRMA.AssetName).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", string.IsNullOrEmpty(eRMA.PONumber) ? "Job #" : "PO", string.IsNullOrEmpty(eRMA.PONumber) ? eRMA.JobNumber : eRMA.PONumber).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Assigned To", eRMA.TechName).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Legacy RMA", eRMA.LegacyRMANumber).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Created by", eRMA.Creation_UserName).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1:yyyy-MM-dd}<br />", "Created", eRMA.Creation_Date).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Completed", ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", string.Empty, eRMA.Completed_Date)).AppendLine();
				if (eRMA.Completed_Date.HasValue)
					sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Duration", ClassUtility.FormatTimeSpan_Dhm(eRMA.Completed_Date.Value - eRMA.Creation_Date)).AppendLine();
				sb.AppendFormat("<span class=\"b\">{0}: </span>{1}<br />", "Finalized", ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", string.Empty, eRMA.Finalized_Date)).AppendLine();
				sb.AppendLine("<hr>");
				sb.AppendLine("<h4>Assemblies</h4>");
				foreach (var ra in eAssemblies)
				{
					sb.AppendFormat("<span class=\"b\">{0}</span><br />", ra.AssemblyTypeDescription).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Assembly #", ra.AssemblyNumber).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Description", ra.AssemblyDescription).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Failure Type", ra.FailureTypeDescription).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Failure Notes", ra.Failure_Notes).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Grid", ra.Failure_GridLocation).AppendLine();
					sb.AppendLine("<br />");
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1:yyyy-MM-dd}<br />", "Received", ra.Receive_Date).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Received by", ra.Receive_UserName).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Zone", ra.Receive_Zone).AppendLine();
					sb.AppendLine("<br />");
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1:yyyy-MM-dd}<br />", "Repair Start", ra.Repair_DateTime_Start).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1:yyyy-MM-dd}<br />", "Repair Completed", ra.Repair_DateTime_End).AppendLine();
					if (ra.Repair_DateTime_Start.HasValue && ra.Repair_DateTime_End.HasValue)
						sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Repair Duration", ClassUtility.FormatTimeSpan_Dhm(ra.Repair_DateTime_End.Value - ra.Repair_DateTime_Start.Value)).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Original Job #", ra.Repair_OriginalJob).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Original Part #", ra.Repair_OriginalPart).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "LED Calibration #", ra.Repair_Calibration).AppendLine();
					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Serial Number", ra.SerialNumber).AppendLine();

					sb.AppendLine("<span class=\"assy\" style=\"font-weight: bold;\">Repairs Made:</span><br />");
					foreach (var rt in ClassRMA.ClassRMAAssembly.GetRMAAssemblyRepairTypes(ra.ID))
						sb.AppendFormat("<span class=\"assy_rep\">{0}</span><br />", rt.Description).AppendLine();

					// Components omitted by request; export files are provided to customers and should not include components. (R. Ellis 2012-01-17)

					//sb.AppendLine("<span class=\"assy\" style=\"font-weight: bold;\">Components Used:</span><br />");
					//ClassYSO.ClassRMA.ClassRMAAssembly ra1 = ra;
					//foreach (ClassYSO.ClassRMA.ClassRMAComponent rc in E_Components.Where(c => c.RMAAssemblyID == ra1.ID))
					//    sb.AppendFormat("<span class=\"assy_rep\">{0} {1} ({2})</span><br />", rc.Component.ComponentNumber, rc.Component.Description, rc.SilkscreenID).AppendLine();

					sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Notes", ra.Repair_Notes).AppendLine();
					sb.AppendLine("<br />");
					if (ra.Finalize_Date.HasValue)
					{
						sb.AppendFormat("<span class=\"assy\">{0}: </span>{1:yyyy-MM-dd}<br />", "Finalized", ra.Finalize_Date.Value).AppendLine();
						sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Finalized by", ra.Finalize_UserName).AppendLine();
						sb.AppendFormat("<span class=\"assy\">{0}: </span>{1}<br />", "Root Cause", ra.Finalize_RootCauseDescription).AppendLine();
					}
					sb.AppendLine("<br />");
				}
				sb.AppendLine("</body></html>");
				#region Output/Launch
				try
				{
					File.WriteAllText(sfd.FileName, sb.ToString());
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Cannot export RMA {0}:{1}{1}{2}", eRMA.ID, Environment.NewLine, exc.Message), "File Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				try
				{
					Process.Start(sfd.FileName);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Cannot open export from RMA {0}:{1}{1}{2}", eRMA.ID, Environment.NewLine, exc.Message), "File Open Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
				#endregion
		}
		#endregion
	}
}