using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Misc;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.Asset;
using SDB.Forms.Customer;
using SDB.Forms.Ticket;

namespace SDB.UserControls.Asset
{
	// TODO Compile ObjectListView with source, and do this? http://sourceforge.net/p/objectlistview/discussion/812922/thread/8bfe910f/
	public partial class AssetEditor : UserControl
	{
		#region Delegates and Events
		public delegate void TechClickedEvent(ClassTech tech);

		public delegate void AssetEvent(ClassAsset asset);

		public delegate void TicketClickedEvent(int ticketID);

		public delegate void TicketCreatedEvent(ClassTicket ticket);

		public delegate void RMAClickedEvent(int rmaID);

		public delegate void ShipmentEvent(int shipmentID, int assetID);

		public delegate void TrackingEvent(string trackingURL);

		public delegate void UpdateEvent();

		public delegate void AssetIDEvent(int assetID);

		public event TechClickedEvent TechDoubleClicked;
		public event TicketClickedEvent TicketDoubleClicked;
		public event TicketCreatedEvent TicketCreated;

		/// <summary>
		/// Occurs when the usercontrol has successfully loaded an asset. The main program can use the event to populate headers or tab page text.
		/// </summary>
		public event AssetEvent AssetLoaded;

		/// <summary>
		/// Occurs when dashboard button is clicked.
		/// </summary>
		public event AssetEvent LaunchDashboard;

		public event AssetEvent LaunchVNC;
		public event AssetEvent LaunchTeamviewer;

		/// <summary>
		/// Occurs when market navigation button is clicked.
		/// </summary>
		public event AssetEvent ViewMarket;

		public event AssetEvent OpenURL_Camera;
		public event AssetEvent OpenURL_IBoot;
		public event AssetEvent OpenURL_MiniGoose;
		public event AssetEvent OpenURL_LatLongMap;
		public event AssetEvent OpenURL_Server;
		public event AssetEvent OpenURL_WebVNC;
		public event AssetEvent CreateShipment;
		public event AssetIDEvent AssetClicked;
		public event RMAClickedEvent ViewLegacyRMA;
		public event RMAClickedEvent ViewRMA;
		public event ShipmentEvent ViewShipment;
		public event UpdateEvent AssetUpdated;
		public event TrackingEvent ViewTracking;
		#endregion

		#region Enums and Structs
		private enum AssetEditorModes
		{
			Viewing,
			Editing,
			Adding
		};

		// Order values first in the nullable int column
		private class TechPriorityComparer : IComparer
		{
			private readonly SortOrder _order;

			public TechPriorityComparer(SortOrder order)
			{
				_order = order;
			}

			public int Compare(object a, object b)
			{
				if (a == null && b == null)
					return 0;

				if (!(a is ListViewItem))
					return _order == SortOrder.Ascending ? -1 : 1;

				if (!(b is ListViewItem))
					return _order == SortOrder.Ascending ? 1 : -1;

				var item1 = (ListViewItem)a;
				var item2 = (ListViewItem)b;

				if (!(item1.ListView is ObjectListView))
					throw new ArgumentException("Underlying ListView is not of type " + typeof(ObjectListView));

				var view = (ObjectListView)item1.ListView;

				var obj1 = view.GetModelObject(item1.Index);
				var obj2 = view.GetModelObject(item2.Index);

				if (!(obj1 is ClassTech) || !(obj2 is ClassTech))
					throw new ArgumentException("ObjectListView data objects are not of type " + typeof(ClassTech));

				var tech1 = obj1 as ClassTech;
				var tech2 = obj2 as ClassTech;

				if (tech1.Priority.HasValue && !tech2.Priority.HasValue)
					return _order == SortOrder.Ascending ? -1 : 1;

				if (!tech1.Priority.HasValue && tech2.Priority.HasValue)
					return _order == SortOrder.Ascending ? 1 : -1;

				if (!tech1.Priority.HasValue && !tech2.Priority.HasValue)
					return _order == SortOrder.Ascending ? string.Compare(tech1.TechName, tech2.TechName, StringComparison.Ordinal) : string.Compare(tech2.TechName, tech1.TechName, StringComparison.Ordinal);

				if (tech1.Priority.GetValueOrDefault(1) == tech2.Priority.GetValueOrDefault(1))
					return 0;

				switch (_order)
				{
					default:
						return tech1.Priority.GetValueOrDefault(1) < tech2.Priority.GetValueOrDefault(1) ? -1 : 1;
					case SortOrder.Descending:
						return tech2.Priority.GetValueOrDefault(1) < tech1.Priority.GetValueOrDefault(1) ? -1 : 1;
				}
			}
		}
		#endregion

		#region Private Fields
		private AssetEditorModes _currentAssetEditorMode = AssetEditorModes.Viewing;
		// Currently loaded asset
		private ClassAsset _asset;

		// Items that are specific to the loaded asset
		private ClassJournal _journal = new ClassJournal();
		private List<ClassTicket> _ticketHistory = new List<ClassTicket>();

		/// <summary>
		/// The subset of techs assigned to the current asset.
		/// </summary>
		private List<ClassTech> _assignedTechs = new List<ClassTech>();

		private List<ClassLegacyRMA> _legacyRmas = new List<ClassLegacyRMA>();
		private List<ClassRMA> _rmas = new List<ClassRMA>();
		private List<ClassShipment> _shipments = new List<ClassShipment>();

		private List<ClassDocuments> _documents = new List<ClassDocuments>();

		// Items that aren't asset-specific
		/// <summary>
		/// Used to store current asset in case adding a new asset is canceled (load previous).
		/// </summary>
		private ClassAsset _assetLoadedBeforeAddNew;

		/// <summary>
		/// Used to select assigned techs.
		/// </summary>
		private List<ClassTech> _assignableTechs = new List<ClassTech>();

		private List<ClassCameraType> _cameraTypes = new List<ClassCameraType>();
		private List<ClassLiftType> _liftTypes = new List<ClassLiftType>();
		private List<ClassCabinetType> _cabinetTypes = new List<ClassCabinetType>();
		private List<ClassOutputMethod> _outputMethods = new List<ClassOutputMethod>();
		private List<ControllerHardware> _controllerHardware = new List<ControllerHardware>();
		private List<ControllerSoftware> _controllerSoftware = new List<ControllerSoftware>();
		private List<ControllerConnection> _controllerConnections = new List<ControllerConnection>();
        private List<ClassClientConnection> _clientConnections = new List<ClassClientConnection>();
        private bool _ignoreStateChange;
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		public AssetEditor()
		{
			InitializeComponent();
			InitializeOlvs();

			pnlControl_Top.BackColor = GS.Settings.ControlBarColor;
		}
		#endregion

		#region Private Methods
		private void InitializeOlvs()
		{
			olvAssignedTechs.PrimarySortColumn = olvColTechPriority;
			olvAssignedTechs.PrimarySortOrder = SortOrder.Ascending;

			olvTicketHistory.PrimarySortColumn = olcTicketHistory_TicketID;
			olvTicketHistory.PrimarySortOrder = SortOrder.Descending;

			olcTicketHistory_Symptoms.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Symptoms(true);
			olcTicketHistory_Solutions.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Solutions();

			olvLegacyRMA.PrimarySortColumn = olvColumn1; //rename olvLegacy cols eventually
			olvLegacyRMA.PrimarySortOrder = SortOrder.Descending;

			olvDocuments.PrimarySortColumn = olvDocumentsColumn; //rename olvLegacy cols eventually
			olvDocuments.PrimarySortOrder = SortOrder.Descending;
		}

		/// <summary>
		/// Begins the creation of a new asset.
		/// </summary>
		private void Asset_StartAdd()
		{
			if (_currentAssetEditorMode == AssetEditorModes.Editing || _currentAssetEditorMode == AssetEditorModes.Adding)
			{
				if (MessageBox.Show("Do you want to start adding a new asset, discarding edits to the current asset?", "Confirm Cancel Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;

				_currentAssetEditorMode = AssetEditorModes.Viewing;
			}

			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			_currentAssetEditorMode = AssetEditorModes.Adding;

			// Remember current asset in case addition of new asset is canceled
			if (_asset != null)
				_assetLoadedBeforeAddNew = _asset;

			ClearControls();
			_asset = new ClassAsset();
			Populate();

			mnuAddNew.Visible = false;
			mnuDelete.Visible = false;
			btnCancel.Visible = true;
			btnEditSave.Text = "Save New";
			btnPrevious.Enabled = false;
			btnNext.Enabled = false;

			// New assets should be set to disabled, ClearControls() sets these options to disabled
			//_ignoreStateChange = true;
			//radMonitoring_DataMode_Disabled.Checked = true;
			//radMonitoring_WebcamMode_Auto.Checked = true;
			//_ignoreStateChange = false;

			LockControls(false);

			txtAsset_AssetName.Select();
		}

		private void Asset_StartRetire()
		{
			if (_asset == null || _asset.ID < 1)
			{
				MessageBox.Show("No asset being viewed.", "Asset Retire Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (_asset.IsRetired)
			{
				_asset.Retire(false);
				MessageBox.Show("Asset no longer retired.", "Asset Un-Retired", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				// Check for any open tickets, RMAs or shipments. Asset can only be retired if no items are open.
				var openTickets = ClassTicket.GetByAsset(_asset.ID, ClassTicket.TicketType.Open).ToList();
				var openRmas = ClassRMA.GetByAsset(_asset.ID).Where(r => !r.IsDeleted && !r.IsFinalized).ToList();
				var openShipments = ClassShipment.GetListByAsset(_asset.ID).Where(s => !s.IsDeleted && !s.Fulfilled_Date.HasValue).ToList();

				var openTicketQty = openTickets.Count;
				var openRmaQty = openRmas.Count;
				var openShipmentQty = openShipments.Count;

				var openItemQty = openTicketQty + openRmaQty + openShipmentQty;
				if (openItemQty > 0)
				{
					var ticketLine = string.Format("{0} ticket{1}", openTicketQty, openTicketQty.SIfPlural());
					var rmaLine = string.Format("{0} RMA{1}", openRmaQty, openRmaQty.SIfPlural());
					var shipmentLine = string.Format("{0} shipment{1}", openShipmentQty, openShipmentQty.SIfPlural());
					var message = string.Format("Cannot retire this asset. It has:{0}{0}{1}{0}{2}{0}{3}{0}{0}All associated items must be closed before the asset can be retired.", Environment.NewLine, ticketLine, rmaLine, shipmentLine);
					MessageBox.Show(message, "Asset Retire Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				_asset.Retire();
				MessageBox.Show("Asset retired successfully.", "Asset Retired", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClassNotification.SendNotificationsForObject("Asset Retired", ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
				ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID);
			}
			Asset_Load(_asset.ID);
		}

		private void Asset_StartDelete()
		{
			if (_asset == null || _asset.ID < 1)
			{
				MessageBox.Show("No asset being viewed.", "Asset Delete Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var usedQty = ClassAsset.GetUsedQty(_asset.ID);
			if (usedQty > 0)
			{
				var sb = new StringBuilder();
				sb.AppendFormat("Cannot delete '{0}' because it is used {1} time(s) in the database.", _asset.AssetName, usedQty).AppendLine().AppendLine();
				sb.Append("Do you want to merge it with another Asset?").AppendLine().AppendLine();
				sb.Append("Merging this asset will move all tickets, rma's, and shipment items for it to another asset you select. ");
				sb.Append("Asset information (notes, network info, etc.) for the this asset will NOT be migrated, so be sure to transfer any needed information before merging.");
				if (MessageBox.Show(sb.ToString(), "Asset In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var frmAssets = new FormList_Assets())
				{
					if (frmAssets.ShowDialog() != DialogResult.OK)
						return;

					if (frmAssets.SelectedAsset.ID == _asset.ID)
					{
						MessageBox.Show("Cannot merge Asset with itself.", "Merge Asset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (MessageBox.Show($"Asset '{_asset.AssetName}' will be replaced with '{frmAssets.SelectedAsset.AssetName}' throughout the database. Do you want to proceed?",
										"Confirm Asset Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;

					try
					{
						ClassAsset.Merge(_asset.ID, frmAssets.SelectedAsset.ID);
						_asset.Delete();
						MessageBox.Show("Asset merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Asset merge failed: " + exc.Message, "Merge Asset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

					Asset_Load(frmAssets.SelectedAsset.ID);
				}
			}
			else
			{
				if (MessageBox.Show($"Are you sure you want to delete asset '{_asset.AssetName}'?",
									"Confirm Asset Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				_asset.Delete();
				MessageBox.Show("Asset deleted successfully.", "Asset Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClassNotification.SendNotificationsForObject("Asset Deleted", ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
				ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID);
				ClearControls();
			}
		}

		private void Asset_EditWarranty()
		{
			using (var warrantyForm = new FormAsset_Warranty(_asset))
			{
				warrantyForm.ShowDialog();
				if (warrantyForm.DialogResult != DialogResult.OK)
					return;
				AssetUpdated?.Invoke();
				Asset_Load(_asset.ID);
			}
		}

		private void ClearControls_Network()
		{
			// Ungrouped
			txtNetwork_ISP.Text = string.Empty;
			txtNetwork_Router.Text = string.Empty;
			txtNetwork_WAN.Text = string.Empty;
			chkNetwork_UseLAN.Checked = false;

			chkNetwork_CameraInstalled.Checked = false;
			chkNetwork_IBootInstalled.Checked = false;
			chkNetwork_MiniGooseInstalled.Checked = false;

			// Server
			foreach (var textBox in pnlNetwork_Server.Controls.OfType<TextBox>())
				textBox.Clear();

			// Remote Access
			foreach (var textBox in pnlNetwork_Remote.Controls.OfType<TextBox>())
				textBox.Clear();
			numNetwork_RemoteVncPort.Value = ClassAsset.VNC_DEFAULT_PORT;
			numNetwork_RemoteVncWebPort.Value = ClassAsset.VNC_DEFAULT_WEB_PORT;
            cbxUseRealVNC.Checked = false;

			// Prismview System
			foreach (var textBox in pnlNetwork_System.Controls.OfType<TextBox>())
				textBox.Clear();
			numNetwork_SystemPort.Value = ClassAsset.SYSTEM_DEFAULT_PORT;
			chkNetwork_SystemSsl.Checked = true;

			// Prismview Player
			foreach (var textBox in pnlNetwork_Player.Controls.OfType<TextBox>())
				textBox.Clear();
			numNetwork_PlayerPort.Value = ClassAsset.PLAYER_DEFAULT_PORT;
			chkNetwork_PlayerSsl.Checked = true;

			// Camera
			foreach (var textBox in pnlNetwork_Camera.Controls.OfType<TextBox>())
				textBox.Clear();
			numNetwork_CameraPort.Value = ClassAsset.CAMERA_DEFAULT_PORT;
			numNetwork_CameraChannel.Value = 1;
			cmbNetwork_WebcamType.SelectedIndex = -1;

			// IBoot
			foreach (var textBox in pnlNetwork_IBoot.Controls.OfType<TextBox>())
				textBox.Clear();
			numNetwork_IBootPort.Value = ClassAsset.IBOOT_DEFAULT_PORT;

			// MiniGoose
			foreach (var textBox in pnlNetwork_MiniGoose.Controls.OfType<TextBox>())
				textBox.Clear();
			numNetwork_MiniGoosePort.Value = ClassAsset.GOOSE_DEFAULT_PORT;

			// Shortcut buttons
			btnVNC.Enabled = false;
			btnTeamViewer.Enabled = false;
		}

		private void LockControls(bool isLocked = true)
		{
			EnableLinkerFields(isLocked);
			chkManagedByMedia.Enabled = !isLocked;
            cbxIsPMC.Enabled = !isLocked;

			// OWNERSHIP
			foreach (var textBox in pnlOwnershipInformation.Controls.OfType<TextBox>())
			{
				// Customer and Market textboxes are always readonly
				if (textBox == txtAsset_Customer || textBox == txtAsset_Market)
					continue;
				textBox.ReadOnly = isLocked;
			}
			foreach (var nullableDateTimePicker in pnlOwnershipInformation.Controls.OfType<NullableDateTimePicker>())
				nullableDateTimePicker.Enabled = !isLocked;
			btnAsset_SelectMarket.Visible = !isLocked;
			btnAsset_SelectMarket.Enabled = !isLocked;

			// PHYSICAL
			foreach (var textBox in pnlPhysical.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;
			foreach (var comboBox in pnlPhysical.Controls.OfType<ComboBox>())
				comboBox.Enabled = !isLocked;
			foreach (var numericUpDown in pnlPhysical.Controls.OfType<ClassFixedNumericUpDown>())
				numericUpDown.ReadOnly = isLocked;
			chkIndoor.Enabled = !isLocked;

			// GEOGRAPHIC
			foreach (var textBox in pnlGeographic.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;
			foreach (var comboBox in pnlGeographic.Controls.OfType<ComboBox>())
				comboBox.Enabled = !isLocked;

			// NOTES
			txtGeneralNotes.ReadOnly = isLocked;
			txtAccessNotes.ReadOnly = isLocked;

			// IBOM
			ucAsset_IBOM1.LockControls(isLocked);

			// NETWORK
			LockControls_Network(isLocked);

			// MONITORING
			pnlMonitoringControl.Enabled = !isLocked;
			btnMonitoring_BlackoutSchedule.Enabled = !isLocked;
			numMonitoring_HoldTime.ReadOnly = isLocked;

			// ASSIGNED TECHS
			btnAssignedTechs_Assign.Enabled = !isLocked;
			btnAssignedTechs_MoveUp.Enabled = !isLocked;

			// NAVIGATION BUTTONS visible only when locked
			btnAsset_ViewLatLongMap.Visible = isLocked;

			// GEOCODE BUTTON visible only when unlocked
			btnAsset_GeoCode.Visible = !isLocked;
		}

		private void LockControls_Network(bool isLocked)
		{
			// Ungrouped
			txtNetwork_ISP.ReadOnly = isLocked;
			txtNetwork_Router.ReadOnly = isLocked;
			txtNetwork_WAN.ReadOnly = isLocked;
			chkNetwork_UseLAN.Enabled = !isLocked;

			chkNetwork_CameraInstalled.Enabled = !isLocked;
			chkNetwork_IBootInstalled.Enabled = !isLocked;
			chkNetwork_MiniGooseInstalled.Enabled = !isLocked;
            cbxUseRealVNC.Enabled = !isLocked;

			// Server
			foreach (var textBox in pnlNetwork_Server.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;

			// Remote Access
			foreach (var textBox in pnlNetwork_Remote.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;
			foreach (var numericUpDown in pnlNetwork_Remote.Controls.OfType<ClassFixedNumericUpDown>())
				numericUpDown.ReadOnly = isLocked;

			// Prismview System
			foreach (var textBox in pnlNetwork_System.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;
			numNetwork_SystemPort.ReadOnly = isLocked;
			chkNetwork_SystemSsl.Enabled = !isLocked;

			// Prismview Player
			foreach (var textBox in pnlNetwork_Player.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;
			numNetwork_PlayerPort.ReadOnly = isLocked;
			chkNetwork_PlayerSsl.Enabled = !isLocked;

			// Camera
			foreach (var textBox in pnlNetwork_Camera.Controls.OfType<TextBox>().Where(c => c != txtNetwork_WebcamTypeAssemblyDesc))
				textBox.ReadOnly = isLocked;
			foreach (var numericUpDown in pnlNetwork_Camera.Controls.OfType<ClassFixedNumericUpDown>())
				numericUpDown.ReadOnly = isLocked;
			cmbNetwork_WebcamType.Enabled = !isLocked;

			// IBoot
			foreach (var textBox in pnlNetwork_IBoot.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;
			numNetwork_IBootPort.ReadOnly = isLocked;

			// MiniGoose
			foreach (var textBox in pnlNetwork_MiniGoose.Controls.OfType<TextBox>())
				textBox.ReadOnly = isLocked;
			numNetwork_MiniGoosePort.ReadOnly = isLocked;
		}

		private void EnableLinkerFields(bool enable)
		{
			var linkerFields = new Control[]
								   {
									   txtAsset_Market,
									   numNetwork_SystemPort,
									   numNetwork_RemoteVncPort,
									   numNetwork_RemoteVncWebPort,
									   txtNetwork_CameraLan,
									   txtNetwork_IBootLan,
									   txtNetwork_MiniGooseLan,
									   txtNetwork_TeamviewerID
								   };
			foreach (var control in linkerFields)
			{
				control.Font = enable ? new Font(control.Font, control.Font.Style | FontStyle.Underline) : new Font(control.Font, control.Font.Style ^ FontStyle.Underline);
				control.Cursor = enable ? Cursors.Hand : control is TextBox ? Cursors.IBeam : Cursors.Default;
			}
		}

		#region Populate
		private void Populate()
		{
			_ignoreStateChange = true;
			SetJournalFont();
			SuspendLayout();

			ResetButtonText();
			LockControls();
			AssignTechsEnable(false);
			mnuDelete.Visible = GS.Settings.LoggedOnUser.IsAdmin;
			mnuRetire.Visible = GS.Settings.LoggedOnUser.IsAdmin;
			mnuRetire.Text = _asset.IsRetired ? "Un-Retire Asset" : "Retire Asset";

			if (_asset == null)
				return;

			chkSubscribe.Checked = ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Asset, _asset.ID);

			Populate_Ownership();
			Populate_Physical();
			Populate_Geography();

			// Populate any tab which gets updated at "Save" otherwise wrong information gets written
			Populate_Notes();
			Populate_IBom();
			Populate_Network();
			Populate_Monitoring();

			Populate_ActiveTab();

			ResumeLayout();

			AssetLoaded?.Invoke(_asset);
			_ignoreStateChange = false;
		}

		private void SetJournalFont()
		{
			dgvJournal.DefaultCellStyle.Font = GS.Settings.JournalFont;
		}

		/// <summary>
		/// Populate the currently selected tab, if the tab involves fetching only associated data.
		/// (For example, the Network tab is an extension of Asset information, and is populated whenever the asset loads.)
		/// </summary>
		private void Populate_ActiveTab()
		{
			switch (tabControl.SelectedTab.Name)
			{
				//case "tabNotes":
				//    Populate_Notes();
				//    break;

				case "tabJournal":
					Populate_Journal();
					break;

				//case "tabIBom":
				//    Populate_IBom();
				//    break;

				//case "tabNetwork":
				//    Populate_Network();
				//    break;

				//case "tabMonitoring":
				//    Populate_Monitoring();
				//    break;

				case "tabAssignedTechs":
					Populate_AssignedTechs();
					break;

				case "tabTicketHistory":
					Populate_TicketHistory();
					break;

				case "tabRMA":
					Populate_Rmas();
					break;

				case "tabShipments":
					Populate_Shipments();
					break;

				case "tabSpareParts":
					Populate_SpareParts();
					break;

				case "tabSystemBackups":
					Populate_SystemBackups();
					break;
				case "tabDocuments":
					Populate_Documents();
					break;
			}
		}

		private void Populate_Journal()
		{
			_journal = ClassJournal.GetByObject(_asset);
			_journal.PopulateDataGridView(dgvJournal);
		}

		private void Populate_Ownership()
		{
			if (_asset == null)
				return;

			txtAsset_AssetName.Text = _asset.AssetName;
			txtAsset_AssetName.BackColor = _asset.IsRetired ? Color.Red : SystemColors.Control;
			txtAsset_Customer.Text = _asset.ExtraProperties.CustomerName;
			txtAsset_Market.Text = _asset.ExtraProperties.MarketName;
			txtAsset_Panel.Text = _asset.Panel;
			txtAsset_SerialNumber.Text = _asset.SerialNumber;
			Populate_Status();
			txtAsset_Release.Text = _asset.ReleaseNumber;
			ndtpAsset_InstallDateTime.Value = _asset.WarrantyInfo.InstallDate;
			ndtpAsset_ShippedDateTime.Value = _asset.WarrantyInfo.ShippedDate;
			ucWarrantyStatus1.ShowStatus(_asset);
			chkManagedByMedia.Checked = _asset.ManagedByCreative;
            cbxIsPMC.Checked = _asset.IsPMC;
			// Populate the SSR and Asset Tag textboxes
			txtAsset_CustomerTag.Text = ClassCustomer.GetByAsset(_asset).GetCustomerAssetTag();
			var assignedSsr = ClassCustomer.GetByAsset(_asset).AssignedSSR;
			txtAsset_AssignedSsr.Text = assignedSsr == null ? "Not Assigned" : ClassUser.GetByID((int)assignedSsr).FirstLast;
		}

		/// <summary>
		/// Populates the status label to show open tickets, or retired status.
		/// </summary>
		private void Populate_Status()
		{
			if (_asset.IsRetired)
			{
				lblStatus.BackColor = Color.Pink;
				lblStatus.ForeColor = Color.Red;
				lblStatus.Text = "RETIRED";
			}
			else
			{
				// Since _ticketHistory is only populated on-demand, use a quick SQL query to check for open tickets
				var openTicketQty = ClassAsset.GetOpenTicketQty(_asset.ID);
				var hasTickets = openTicketQty > 0;
				lblStatus.Text = $"{openTicketQty} OPEN TICKET{openTicketQty.SIfPlural().ToUpper()}";
				lblStatus.BackColor = hasTickets ? Color.Yellow : Color.Transparent;
				lblStatus.ForeColor = hasTickets ? Color.Black : Color.Silver;
			}
		}

		private void Populate_Physical()
		{
            cmbChipType.Items.Clear();
            cmbInterfaceType.Items.Clear();

            //Interface type and chip type are temp hardcoded until I have time to add UI to add remove them [TA] 
            string[] inerfacelist = { "Y4D", "Y4DVIX8", "Y5DVIX8", "Y6DVIX8", "Y7DVIX16E", "Y7DVIX16S", "Legacy" };
            cmbInterfaceType.Items.AddRange(inerfacelist);
            string[] chiplist = {"ST", "TI", "Gen 6", "Gen 7", "Gen 8" };
            cmbChipType.Items.AddRange(chiplist);

            if (cmbInterfaceType.FindStringExact(_asset.InterfaceType) == -1)
                cmbInterfaceType.Items.Add(_asset.InterfaceType);
            cmbInterfaceType.SelectedIndex = cmbInterfaceType.FindStringExact(_asset.InterfaceType);

            if (cmbChipType.FindStringExact(_asset.Chip_Type) == -1)
                cmbChipType.Items.Add(_asset.Chip_Type);
            cmbChipType.SelectedIndex = cmbChipType.FindStringExact(_asset.Chip_Type);


            numAsset_InterfaceQty.Value = _asset.InterfaceQty;
                        
            cmbAsset_ControllerHardware.SelectedValue = _asset.ControllerHardwareId ?? -1;
			cmbAsset_ControllerSoftware.SelectedValue = _asset.ControllerSoftwareId ?? -1;
			cmbAsset_ControllerConnection.SelectedValue = _asset.ControllerConnectionId ?? -1;
            cmbAsset_ClientConnection.SelectedValue = _asset.ClientConnectionId ?? -1;

            numAsset_MatrixX.Value = _asset.MatrixWidth;
			numAsset_MatrixY.Value = _asset.MatrixHeight;
			numAsset_Pitch.Value = _asset.Pitch;
			cmbAsset_OutputMethod.SelectedValue = _asset.OutputMethodId ?? -1;
			cmbAsset_CabinetType.SelectedValue = _asset.CabinetTypeId ?? -1;
			numAsset_FaceQty.Value = _asset.FaceQty;
			numAsset_HAGL.Value = _asset.HeightAboveGroundLevel;
			chkIndoor.Checked = _asset.IsIndoor;
			cmbAsset_LiftType.SelectedValue = _asset.LiftTypeId ?? -1;
			numAsset_LiftHeight.Value = _asset.Lift_Height;
		}

        private void Populate_ComboBoxLists()
        {
            cmbAsset_CabinetType.DisplayMember = "DisplayMember";
            cmbAsset_CabinetType.ValueMember = "ID";
            cmbAsset_CabinetType.DataSource = _cabinetTypes;

            cmbAsset_LiftType.DisplayMember = "DisplayMember";
            cmbAsset_LiftType.ValueMember = "ID";
            cmbAsset_LiftType.DataSource = _liftTypes;

            cmbAsset_OutputMethod.DisplayMember = "DisplayMember";
            cmbAsset_OutputMethod.ValueMember = "ID";
            cmbAsset_OutputMethod.DataSource = _outputMethods;

            cmbAsset_ControllerHardware.DisplayMember = "DisplayMember";
            cmbAsset_ControllerHardware.ValueMember = "ID";
            cmbAsset_ControllerHardware.DataSource = _controllerHardware;

            cmbAsset_ControllerSoftware.DisplayMember = "DisplayMember";
            cmbAsset_ControllerSoftware.ValueMember = "ID";
            cmbAsset_ControllerSoftware.DataSource = _controllerSoftware;

            cmbAsset_ControllerConnection.DisplayMember = "DisplayMember";
            cmbAsset_ControllerConnection.ValueMember = "ID";
            cmbAsset_ControllerConnection.DataSource = _controllerConnections;

            cmbAsset_ClientConnection.DisplayMember = "DisplayMember";
            cmbAsset_ClientConnection.ValueMember = "ID";
            cmbAsset_ClientConnection.DataSource = _clientConnections;

        }

        private void Populate_Geography()
		{
			txtLocation.Text = _asset.Location;
			txtAddress.Text = _asset.Address;
			cmbAsset_FacingDirection.Text = _asset.FacingDirection;
			txtCity.Text = _asset.City;
			txtState.Text = _asset.State;
			txtZip.Text = _asset.Zip;
			txtCountry.Text = _asset.Country;
			txtLatitude.Text = _asset.Latitude.ToString();
			txtLongitude.Text = _asset.Longitude.ToString();
			btnAsset_ViewLatLongMap.Enabled = _asset.Latitude.HasValue && _asset.Longitude.HasValue;

			// Get other assets that share location
			var sharedLocationAssets = ClassAsset.GetBySameLocation(_asset).ToList();
			assetLinker1.SetAssetLinks(sharedLocationAssets);
		}

		private void Populate_Notes()
		{
			if (_asset == null)
				return;

			txtGeneralNotes.Text = _asset.Notes;
			txtAccessNotes.Text = _asset.AccessNotes;
		}

		private void Populate_IBom()
		{
			if (_asset == null)
				return;

			ucAsset_IBOM1.IBOM = _asset.Ibom;
		}

		private void Populate_Network()
		{
			if (_asset == null)
				return;

			// Ungrouped
			txtNetwork_ISP.Text = _asset.Net.InternetServiceProvider;
			txtNetwork_Router.Text = _asset.Net.RouterInfo;
			txtNetwork_WAN.Text = _asset.Net.WanAddress;
			chkNetwork_UseLAN.Checked = _asset.Net.UseLanAddresses;
			chkNetwork_CameraInstalled.Checked = _asset.Net.Webcam_Installed;
			chkNetwork_IBootInstalled.Checked = _asset.Net.IBoot_Installed;
			chkNetwork_MiniGooseInstalled.Checked = _asset.Net.Goose_Installed;

            

			// Server
			txtNetwork_ServerLan.Text = _asset.Net.LanAddress;
			txtNetwork_ServerGateway.Text = _asset.Net.Gateway;
			txtNetwork_ServerMask.Text = _asset.Net.SubnetMask;

			// Remote Access
			txtNetwork_TeamviewerID.Text = _asset.Net.Teamviewer_ID;
			txtNetwork_TeamviewerPassword.Text = _asset.Net.Teamviewer_Password;
			numNetwork_RemoteVncPort.Value = _asset.Net.VNC_Port.GetValueOrDefault(ClassAsset.VNC_DEFAULT_PORT);
			numNetwork_RemoteVncWebPort.Value = _asset.Net.VNC_WebPort.GetValueOrDefault(ClassAsset.VNC_DEFAULT_WEB_PORT);
			txtNetwork_RemoteVncPassword.Text = _asset.Net.VNC_Password;

            cbxUseRealVNC.Checked = _asset.Net.Use_Real_VNC;

			// Prismview System
			numNetwork_SystemPort.Value = _asset.Net.System_Port.GetValueOrDefault(ClassAsset.SYSTEM_DEFAULT_PORT);
			chkNetwork_SystemSsl.Checked = _asset.Net.System_UseSsl.GetValueOrDefault(true);
			txtNetwork_SystemPassword.Text = _asset.Net.System_Password;

			// Prismview Player
			numNetwork_PlayerPort.Value = _asset.Net.Player_Port.GetValueOrDefault(ClassAsset.PLAYER_DEFAULT_PORT);
			chkNetwork_PlayerSsl.Checked = _asset.Net.Player_UseSsl.GetValueOrDefault(true);
			txtNetwork_PlayerPassword.Text = _asset.Net.Player_Password;

			// Camera
			txtNetwork_CameraLan.Text = _asset.Net.Webcam_Address;
			numNetwork_CameraPort.Value = _asset.Net.Webcam_Port.GetValueOrDefault(ClassAsset.CAMERA_DEFAULT_PORT);
			numNetwork_CameraChannel.Value = _asset.Net.Webcam_Channel.GetValueOrDefault(1);
			txtNetwork_CameraUser.Text = _asset.Net.Webcam_User;
			txtNetwork_CameraPassword.Text = _asset.Net.Webcam_Password;
			cmbNetwork_WebcamType.SelectedValue = -1;
			txtNetwork_WebcamTypeAssemblyDesc.Clear();
			if (_asset.Net.Webcam_Type.HasValue && _cameraTypes.Any(c => c.ID == _asset.Net.Webcam_Type.GetValueOrDefault(0)))
			{
				cmbNetwork_WebcamType.SelectedValue = _asset.Net.Webcam_Type;
				var cameraAssemblyID = _cameraTypes.Single(c => c.ID == _asset.Net.Webcam_Type.GetValueOrDefault(0)).AssemblyID;
				if (cameraAssemblyID.HasValue)
				{
					var cameraAssembly = ClassAssembly.GetByID(cameraAssemblyID.Value);
					txtNetwork_WebcamTypeAssemblyDesc.Text = $"[{cameraAssembly.AssemblyNumber}] {cameraAssembly.Description}";
				}
			}

			// IBoot
			txtNetwork_IBootLan.Text = _asset.Net.IBoot_Address;
			numNetwork_IBootPort.Value = _asset.Net.IBoot_Port.GetValueOrDefault(ClassAsset.IBOOT_DEFAULT_PORT);
			txtNetwork_IBootPassword.Text = _asset.Net.IBoot_Password;

			// MiniGoose
			txtNetwork_MiniGooseLan.Text = _asset.Net.Goose_Address;
			numNetwork_MiniGoosePort.Value = _asset.Net.Goose_Port.GetValueOrDefault(ClassAsset.GOOSE_DEFAULT_PORT);
			txtNetwork_MiniGoosePassword.Text = _asset.Net.Goose_Password;

			// Shortcut Buttons
			btnVNC.Enabled = _asset.Net.HasServerAddress && !string.IsNullOrEmpty(_asset.Net.VNC_Password);
			btnTeamViewer.Enabled = !string.IsNullOrEmpty(_asset.Net.Teamviewer_ID);
		}

		private void Populate_Monitoring()
		{
			if (_asset == null)
				return;

			switch (_asset.Monitoring.DataMode)
			{
				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Disabled:
					radMonitoring_DataMode_Disabled.Checked = true;
					break;

				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Forced:
					radMonitoring_DataMode_Forced.Checked = true;
					break;
                case ClassAsset.ClassMonitoringOptions.MonitoringMode.Auto:
                    radMonitoring_DataMode_Auto.Checked = true;
                    break;

                default: // auto
                    radMonitoring_DataMode_Disabled.Checked = false;
                    break;
			}
			switch (_asset.Monitoring.WebcamMode)
			{
				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Disabled:
					radMonitoring_WebcamMode_Disabled.Checked = true;
					break;

				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Forced:
					radMonitoring_WebcamMode_Forced.Checked = true;
					break;

				default: // auto
					radMonitoring_WebcamMode_Auto.Checked = true;
					break;
			}

			numMonitoring_Interval.Value = _asset.Monitoring.Interval;
			numMonitoring_HoldTime.Value = _asset.Monitoring.HoldTime;
			numMonitoring_CameraCheckInterval.Value = _asset.CameraCheckInterval;
			Populate_Monitoring_Status();

			txtMonitoring_BlackoutSchedule.Text = new ClassBlackoutSchedule(_asset.ID).ScheduleAsText();
		}

		private void Populate_Monitoring_Status()
		{
			lblMonitoring_ShowDataStatus.BackColor = Color.Transparent;
			lblMonitoring_ShowWebcamStatus.BackColor = Color.Transparent;

			// DATA STATUS
			switch (_asset.Monitoring.DataMode)
			{
				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Disabled:
					lblMonitoring_ShowDataStatus.Text = "Disabled";
					break;
				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Forced:
					lblMonitoring_ShowDataStatus.Text = _asset.Net.HasServerAddress ? "OK (Forced)" : "Error";
					lblMonitoring_ShowDataStatus.BackColor = _asset.Net.HasServerAddress ? Color.LightGreen : Color.Orange;
					break;
				default: // auto
					lblMonitoring_ShowDataStatus.Text = _asset.Net.HasServerAddress ? _asset.IsMonitoringCovered ? "OK (Auto)" : "Expired" : "Error";
					lblMonitoring_ShowDataStatus.BackColor = _asset.Net.HasServerAddress ? _asset.IsMonitoringCovered ? Color.LightGreen : Color.Pink : Color.Orange;
					break;
			}

			// WEBCAM STATUS
			switch (_asset.Monitoring.WebcamMode)
			{
				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Disabled:
					lblMonitoring_ShowWebcamStatus.Text = "Disabled";
					break;
				case ClassAsset.ClassMonitoringOptions.MonitoringMode.Forced:
					lblMonitoring_ShowWebcamStatus.Text = _asset.Net.HasWebcamAndAddress ? "OK (Forced)" : "Error";
					lblMonitoring_ShowWebcamStatus.BackColor = _asset.Net.HasWebcamAndAddress ? Color.LightGreen : Color.Orange;
					break;
				default: // auto
					lblMonitoring_ShowWebcamStatus.Text = _asset.Net.HasWebcamAndAddress ? _asset.IsMonitoringCovered ? "OK (Auto)" : "Expired" : "Error";
					lblMonitoring_ShowWebcamStatus.BackColor = _asset.Net.HasWebcamAndAddress ? _asset.IsMonitoringCovered ? Color.LightGreen : Color.Pink : Color.Orange;
					break;
			}
			//txtMonitoring_LastAttempt.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm:ss}", "Never", _asset.Monitoring.LastAttempt);
			//txtMonitoring_LastData.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm:ss}", "Never", _asset.Monitoring.LastData);
			//txtMonitoring_LastImage.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm:ss}", "Never", _asset.Monitoring.LastImage);
		}

		private void Populate_AssignedTechs()
		{
			if (_asset == null)
				return;

			_assignedTechs = ClassTech.GetByAsset(_asset.ID).ToList();
			olvAssignedTechs.SetObjects(_assignedTechs);
		}

		private void Populate_TicketHistory()
		{
			if (_asset == null)
				return;

			_ticketHistory = ClassTicket.GetByAsset(_asset.ID, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held | ClassTicket.TicketType.Closed).ToList();
			_ticketHistory.PopulateSymptomsAndSolutions();
			btnCreateTicket.BackColor = _ticketHistory.Any(t => !t.IsClosed) ? Color.Yellow : Color.FromArgb(192, 255, 192);
			btnSetServiceReminder.BackColor = !string.IsNullOrWhiteSpace(_asset.ServiceReminder) ? Color.Yellow : SystemColors.Control;
			olvTicketHistory.SetObjects(_ticketHistory);
			txtTicketHistory_TicketQty.Text = _ticketHistory.Count.ToString(CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Populates the RMA tab with either the Legacy or normal RMA olv
		/// </summary>
		private void Populate_RMA_List()
		{
			if (radLegacyRMA.Checked)
				Populate_LegacyRmas();
			else
				Populate_Rmas();
		}

		/// <summary>
		/// populates the Legacy RMA olv in the RMA tab
		/// </summary>
		private void Populate_LegacyRmas()
		{
			if (_asset == null)
				return;

			_legacyRmas = ClassLegacyRMA.GetByAsset(_asset.ID).ToList();
			olvLegacyRMA.SetObjects(_legacyRmas);
			tbxLegacyRMACount.Text = _legacyRmas.Count.ToString(CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Populates the RMA olv in the RMA tab
		/// </summary>
		private void Populate_Rmas()
		{
			if (_asset == null)
				return;

			_rmas = ClassRMA.GetByAsset(_asset.ID).ToList();
			ucRMAList1.SetObjects(_rmas);
		}

		private void Populate_Documents()
		{
			if (_asset == null)
				return;
			_documents = ClassDocuments.GetAllAssetDocuments(_asset.ID).ToList();
			olvDocuments.SetObjects(_documents);
		}


		private void Populate_Shipments()
		{
			if (_asset == null)
				return;

			_shipments = ClassShipment.GetListByAsset(_asset.ID).ToList();
			ucShipmentList1.SetObjects(_shipments);
		}

		private void Populate_SpareParts()
		{
			if (_asset == null)
				return;

			ucAssetSpareParts1.SetAsset(_asset);
		}

		private void Populate_SystemBackups()
		{
			if (_asset == null)
				return;

			ucAssetSystemBackup1.SetAsset(_asset);
		}
		#endregion Populate

		private void ResetButtonText()
		{
			btnEditSave.Text = "Edit Asset";

			btnCancel.Visible = false;

			mnuAddNew.Visible = true;

			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			var prevAssetID = -1;
			if (_asset == null)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = @"SELECT id
						FROM assets
						ORDER BY asset DESC LIMIT 1";
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								prevAssetID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}
			else
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = @"SELECT id
						FROM assets
						WHERE asset < (SELECT asset FROM assets WHERE id = @CurrentAssetID)
						ORDER BY asset DESC LIMIT 1";
						cmd.Parameters.AddWithValue("CurrentAssetID", _asset.ID);
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								prevAssetID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}

			if (prevAssetID != -1)
				Asset_Load(prevAssetID);
			else
				MessageBox.Show("There is not a previous asset to display.", "End of List", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			var nextAssetID = -1;
			if (_asset == null)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = @"SELECT id
						FROM assets
						ORDER BY asset ASC LIMIT 1";
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								nextAssetID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}
			else
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = @"SELECT id
						FROM assets
						WHERE asset > (SELECT asset FROM assets WHERE id = @CurrentAssetID)
						ORDER BY asset ASC LIMIT 1";
						cmd.Parameters.AddWithValue("CurrentAssetID", _asset.ID);
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								nextAssetID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}

			if (nextAssetID != -1)
				Asset_Load(nextAssetID);
			else
				MessageBox.Show("There is not a following asset to display.", "End of List", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void ucWarrantyStatus1_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode == AssetEditorModes.Adding)
			{
				MessageBox.Show("The new asset must be saved before warranty information can be edited.", "Save Asset First", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (_asset == null || _asset.ID < 0)
				return;

			Asset_EditWarranty();
		}

		private void btnAsset_SelectMarket_Click(object sender, EventArgs e)
		{
			using (var marketSelectForm = new FormMarket_Select())
			{
				marketSelectForm.ShowDialog(this);
				if (marketSelectForm.DialogResult != DialogResult.OK) return;
				if (marketSelectForm.SelectedMarket <= 0)
					return;
				_asset.MarketID = marketSelectForm.SelectedMarket;
				if (_asset.ID < 1)
				{
					var market = ClassMarket.GetByID(_asset.MarketID);
					txtAsset_Customer.Text = market.CustomerName;
					txtAsset_Market.Text = market.Name;
				}
				else
				{
					ClassAsset.Update(_asset);
					Asset_Load(_asset.ID);
				}
			}
		}

		private void txtAsset_Market_Click(object sender, EventArgs e)
		{
			if (ViewMarket == null || _currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			ViewMarket(_asset);
		}

		private void btnAsset_GeoCode_Click(object sender, EventArgs e)
		{
			ClassGeoCode.Address geoInfo;
			var address = txtAddress.Text.NullIfEmpty() ?? txtLocation.Text;
			var assetLocation = string.Format("{0}, {1}, {2} {3}", address, txtCity.Text, txtState.Text, txtCountry.Text);
			try
			{
				geoInfo = ClassGeoCode.GetAddressV3(assetLocation);
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Geocoding was not successful:{0}{0}{1}", Environment.NewLine, exc.Message), "Geocoding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (geoInfo.StatusCode != "OK")
			{
				MessageBox.Show(string.Format("Geocoding was not successful.{0}{0}{1}", Environment.NewLine, geoInfo.StatusCode), "Geocoding Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			using (var geoCodeConfirmForm = new FormGeoCodeConfirm())
			{
				geoCodeConfirmForm.AssetLocation = assetLocation;
				geoCodeConfirmForm.Latitude = geoInfo.Lat;
				geoCodeConfirmForm.Longitude = geoInfo.Long;
				if (geoCodeConfirmForm.ShowDialog() != DialogResult.Yes)
					return;
			}
			txtLatitude.Text = geoInfo.Lat;
			txtLongitude.Text = geoInfo.Long;
			btnAsset_ViewLatLongMap.Enabled = true;
		}

		private void btnAsset_ViewLatLongMap_Click(object sender, EventArgs e)
		{
			OpenURL_LatLongMap?.Invoke(_asset);
		}

		#region Network
		private void numNetwork_ServerPort_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			OpenURL_Server?.Invoke(_asset);
		}

		private void numNetwork_ServerVNCPort_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			LaunchVNC?.Invoke(_asset);
		}

		private void numNetwork_ServerVNCWebPort_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			OpenURL_WebVNC?.Invoke(_asset);
		}

		private void txtNetwork_CameraLan_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			OpenURL_Camera?.Invoke(_asset);
		}

		private void txtNetwork_IBootLan_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			OpenURL_IBoot?.Invoke(_asset);
		}

		private void txtNetwork_MiniGooseLan_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			OpenURL_MiniGoose?.Invoke(_asset);
		}

		private void chkNetwork_CameraInstalled_CheckedChanged(object sender, EventArgs e)
		{
			pnlNetwork_Camera.Enabled = chkNetwork_CameraInstalled.Checked;
			if (!chkNetwork_CameraInstalled.Checked)
			{
				radMonitoring_WebcamMode_Disabled.Checked = true;
				radMonitoring_WebcamMode_Forced.Enabled = false;
				radMonitoring_WebcamMode_Auto.Enabled = false;
			}
			else
			{
				radMonitoring_WebcamMode_Forced.Enabled = true;
				radMonitoring_WebcamMode_Auto.Enabled = true;
			}
		}

		private void chkNetwork_IBootInstalled_CheckedChanged(object sender, EventArgs e)
		{
			pnlNetwork_IBoot.Enabled = chkNetwork_IBootInstalled.Checked;
		}

		private void chkNetwork_MiniGooseInstalled_CheckedChanged(object sender, EventArgs e)
		{
			pnlNetwork_MiniGoose.Enabled = chkNetwork_MiniGooseInstalled.Checked;
		}

		private void txtNetwork_TeamviewerID_Click(object sender, EventArgs e)
		{
			if (_currentAssetEditorMode != AssetEditorModes.Viewing)
				return;

			if (LaunchTeamviewer != null && !string.IsNullOrEmpty(_asset.Net.Teamviewer_ID))
				LaunchTeamviewer(_asset);
		}
		#endregion Network

		#region Monitoring
		private void radMonitoring_DataMode_Auto_Click(object sender, EventArgs e)
		{
			if (_asset.Net.HasServerAddress)
				return;

			var message = string.Format("This asset does not have a server {0} address, data monitoring will not be possible.", _asset.Net.UseLanAddresses ? "LAN" : "WAN");
			MessageBox.Show(message, "Data Monitoring Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void radMonitoring_DataMode_Forced_Click(object sender, EventArgs e)
		{
			if (_asset.Net.HasServerAddress)
				return;

			var message = string.Format("This asset does not have a server {0} address, data monitoring will not be possible.", _asset.Net.UseLanAddresses ? "LAN" : "WAN");
			MessageBox.Show(message, "Data Monitoring Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void radMonitoring_WebcamMode_Auto_Click(object sender, EventArgs e)
		{
			if (_asset.Net.HasWebcamAndAddress)
				return;

			var message = string.Format("This asset does not have a webcam {0} address, webcam monitoring will not be possible.", _asset.Net.UseLanAddresses ? "LAN" : "WAN");
			MessageBox.Show(message, "Webcam Monitoring Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void radMonitoring_WebcamMode_Forced_Click(object sender, EventArgs e)
		{
			if (_asset.Net.HasWebcamAndAddress)
				return;

			var message = string.Format("This asset does not have a webcam {0} address, webcam monitoring will not be possible.", _asset.Net.UseLanAddresses ? "LAN" : "WAN");
			MessageBox.Show(message, "Webcam Monitoring Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void radMonitoring_Mode_CheckedChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			// Provide some feedback when the monitoring modes are changed
			// Changes aren't permanent unless user saves edits.
			UpdateAssetMonitoringOptionsFromFields();
			Populate_Monitoring_Status();
		}

		private void btnMonitoring_BlackoutSchedule_Click(object sender, EventArgs e)
		{
			if (_asset == null || _asset.ID < 1)
			{
				MessageBox.Show("Save asset before modifying blackout schedule.");
				return;
			}

			using (var blackoutScheduleForm = new FormAsset_BlackoutSchedule(_asset.ID))
			{
				if (blackoutScheduleForm.ShowDialog() != DialogResult.OK)
					return;

				Populate_Monitoring();
			}
		}
		#endregion Monitoring

		private void rBtnLegacyRMA_Click(object sender, EventArgs e)
		{
			radLegacyRMA.Checked = true;
			radRMA.Checked = false;

			olvLegacyRMA.Visible = true;
			lblLegacyRMACount.Visible = true;
			tbxLegacyRMACount.Visible = true;

			Populate_RMA_List();
		}

		/// <summary>
		///  Populates 
		/// </summary>
		private void rBtnRMA_Click(object sender, EventArgs e)
		{
			radLegacyRMA.Checked = false;
			radRMA.Checked = true;

			olvLegacyRMA.Visible = false;
			lblLegacyRMACount.Visible = false;
			tbxLegacyRMACount.Visible = false;

			Populate_RMA_List();
		}

		private void btnEditSave_Click(object sender, EventArgs e)
		{
			switch (_currentAssetEditorMode)
			{
				case AssetEditorModes.Viewing:
					// Enter edit mode
					if (_asset == null || _asset.ID < 0)
						return;

					if (_asset.IsRetired)
					{
						MessageBox.Show("This asset has been retired.", "Retired Asset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}

					_currentAssetEditorMode = AssetEditorModes.Editing;
					_assetLoadedBeforeAddNew = _asset;
					LockControls(false);
					btnEditSave.Text = "Save";
					btnCancel.Visible = true;
					txtAsset_AssetName.Select();
					break;

				case AssetEditorModes.Editing:
					// Update existing
					if (!ValidateAsset())
						return;

					UpdateAssetObjectFromFields();
					try
					{
						ClassAsset.Update(_asset);

						if (_asset.Ibom != null)
							ClassAsset.UpdateIbom(_asset);

						if (_asset.Monitoring != null)
							ClassAsset.UpdateMonitoringOptions(_asset);
					}
					catch (Exception exc)
					{
						ClassLogFile.AppendToLog(exc);
						MessageBox.Show(string.Format("Cannot modify asset. It may have a duplicate name.{0}{0}{1}", Environment.NewLine, exc.Message), "Asset Modify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					ClassJournal.AddJournalEntry(_asset, "Modified asset.", null, true);
					ClassNotification.SendNotificationsForObject("Modified asset.", ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
					if (GS.Settings.AutoSubscribe_Modify)
						ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
					AssetUpdated?.Invoke();
					//MessageBox.Show("Asset updated successfully.", "Asset Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ResetButtonText();
					Asset_Load(_asset.ID);
					//LockControls();
					//CurrentAssetEditorMode = AssetEditorMode.Viewing;
					break;

				case AssetEditorModes.Adding:
					// Add new
					if (!ValidateAsset())
						return;

					UpdateAssetObjectFromFields();
					try
					{
						ClassAsset.AddNew(ref _asset);
						ClassJournal.AddJournalEntry(_asset, "Created asset.", null, true);
						ClassNotification.SendNotificationsForObject("Created asset.", ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
						if (GS.Settings.AutoSubscribe_Create)
							ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
					}
					catch (Exception exc)
					{
						ClassLogFile.AppendToLog(exc);
						MessageBox.Show(string.Format("Cannot add asset. Most likely it is a duplicate name.{0}{0}{1}", Environment.NewLine, exc.Message), "Asset Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					AssetUpdated?.Invoke();
					MessageBox.Show("Asset added successfully.", "Asset Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ResetButtonText();
					Asset_Load(_asset.ID);
					//LockControls();
					//_currentAssetEditorMode = AssetEditorModes.Viewing;
					break;
			}
		}

		private void UpdateAssetObjectFromFields()
		{
			// OWNERSHIP
			_asset.AssetName = txtAsset_AssetName.Text.Trim();
			_asset.Panel = txtAsset_Panel.Text.Trim();
			_asset.WarrantyInfo.InstallDate = ndtpAsset_InstallDateTime.Value;
			_asset.WarrantyInfo.ShippedDate = ndtpAsset_ShippedDateTime.Value;
			_asset.ReleaseNumber = txtAsset_Release.Text.Trim();
			_asset.ManagedByCreative = chkManagedByMedia.Checked;
            _asset.IsPMC = cbxIsPMC.Checked;
			// PHYSICAL
			_asset.Location = txtLocation.Text.Trim();
			_asset.Address = txtAddress.Text.Trim();
			_asset.City = txtCity.Text.Trim();
			_asset.State = txtState.Text.ToUpper().Trim();
			_asset.Zip = txtZip.Text.Trim();
			_asset.Country = txtCountry.Text.Trim();

			if (decimal.TryParse(txtLatitude.Text.Trim(), out var lat))
				_asset.Latitude = lat;
			else
				_asset.Latitude = null;

			if (decimal.TryParse(txtLongitude.Text.Trim(), out var lng))
				_asset.Longitude = lng;
			else
				_asset.Longitude = null;

			_asset.HeightAboveGroundLevel = (int)numAsset_HAGL.Value;
			_asset.IsIndoor = chkIndoor.Checked;
			_asset.FacingDirection = cmbAsset_FacingDirection.Text;
			_asset.InterfaceType = cmbInterfaceType.Text.Trim();
			_asset.InterfaceQty = (int)numAsset_InterfaceQty.Value;
			_asset.MatrixWidth = (int)numAsset_MatrixX.Value;
			_asset.MatrixHeight = (int)numAsset_MatrixY.Value;
			_asset.Pitch = (int)numAsset_Pitch.Value;
			_asset.OutputMethodId = (int?)cmbAsset_OutputMethod.SelectedValue;
			_asset.Chip_Type = cmbChipType.Text.Trim();
			_asset.ControllerHardwareId = (int?)cmbAsset_ControllerHardware.SelectedValue;
			_asset.ControllerSoftwareId = (int?)cmbAsset_ControllerSoftware.SelectedValue;
			_asset.ControllerConnectionId = (int?)cmbAsset_ControllerConnection.SelectedValue;
            _asset.ClientConnectionId = (int?)cmbAsset_ClientConnection.SelectedValue;
            _asset.CabinetTypeId = (int?)cmbAsset_CabinetType.SelectedValue;
			_asset.FaceQty = (int)numAsset_FaceQty.Value;
			_asset.Lift_Height = (int)numAsset_LiftHeight.Value;
			_asset.LiftTypeId = (int?)cmbAsset_LiftType.SelectedValue;
			_asset.SerialNumber = txtAsset_SerialNumber.Text.Trim();

			// NOTES
			_asset.Notes = txtGeneralNotes.Text.Trim();
			_asset.AccessNotes = txtAccessNotes.Text.Trim();

			// IBOM
			_asset.Ibom = ucAsset_IBOM1.IBOM;

			// NETWORK
			UpdateAssetNetworkOptionsFromFields();

			// MONITORING
			UpdateAssetMonitoringOptionsFromFields();
		}

		private void UpdateAssetNetworkOptionsFromFields()
		{
			// Ungrouped
			_asset.Net.InternetServiceProvider = txtNetwork_ISP.Text.Trim();
			_asset.Net.RouterInfo = txtNetwork_Router.Text.Trim();
			_asset.Net.WanAddress = txtNetwork_WAN.Text.Trim();
			_asset.Net.UseLanAddresses = chkNetwork_UseLAN.Checked;
			_asset.Net.Webcam_Installed = chkNetwork_CameraInstalled.Checked;
			_asset.Net.IBoot_Installed = chkNetwork_IBootInstalled.Checked;
			_asset.Net.Goose_Installed = chkNetwork_MiniGooseInstalled.Checked;

			// Server
			_asset.Net.LanAddress = txtNetwork_ServerLan.Text.Trim();
			_asset.Net.Gateway = txtNetwork_ServerGateway.Text.Trim();
			_asset.Net.SubnetMask = txtNetwork_ServerMask.Text.Trim();

			// Remote Access
			_asset.Net.Teamviewer_ID = txtNetwork_TeamviewerID.Text.Trim();
			_asset.Net.Teamviewer_Password = txtNetwork_TeamviewerPassword.Text.Trim();
			_asset.Net.VNC_Port = (int)numNetwork_RemoteVncPort.Value;
			_asset.Net.VNC_WebPort = (int)numNetwork_RemoteVncWebPort.Value;
			_asset.Net.VNC_Password = txtNetwork_RemoteVncPassword.Text.Trim();
            _asset.Net.Use_Real_VNC = cbxUseRealVNC.Checked;

			// Prismview System
			_asset.Net.System_Port = (int)numNetwork_SystemPort.Value;
			_asset.Net.System_UseSsl = chkNetwork_SystemSsl.Checked;
			_asset.Net.System_Password = txtNetwork_SystemPassword.Text.Trim();

			// Prismview Player
			_asset.Net.Player_Port = (int)numNetwork_PlayerPort.Value;
			_asset.Net.Player_UseSsl = chkNetwork_PlayerSsl.Checked;
			_asset.Net.Player_Password = txtNetwork_PlayerPassword.Text.Trim();

			// Camera
			_asset.Net.Webcam_Address = txtNetwork_CameraLan.Text.Trim();
			_asset.Net.Webcam_Port = (int)numNetwork_CameraPort.Value;
			_asset.Net.Webcam_Channel = (int)numNetwork_CameraChannel.Value;
			_asset.Net.Webcam_User = txtNetwork_CameraUser.Text.Trim();
			_asset.Net.Webcam_Password = txtNetwork_CameraPassword.Text.Trim();
			_asset.Net.Webcam_Type = cmbNetwork_WebcamType.SelectedIndex >= 0 ? (int?)cmbNetwork_WebcamType.SelectedValue : null;

			// IBoot
			_asset.Net.IBoot_Address = txtNetwork_IBootLan.Text.Trim();
			_asset.Net.IBoot_Port = (int)numNetwork_IBootPort.Value;
			_asset.Net.IBoot_Password = txtNetwork_IBootPassword.Text.Trim();

			// MiniGoose
			_asset.Net.Goose_Address = txtNetwork_MiniGooseLan.Text.Trim();
			_asset.Net.Goose_Port = (int)numNetwork_MiniGoosePort.Value;
			_asset.Net.Goose_Password = txtNetwork_MiniGoosePassword.Text.Trim();
		}

		private void UpdateAssetMonitoringOptionsFromFields()
		{
			_asset.Monitoring.DataMode =
				radMonitoring_DataMode_Disabled.Checked ? ClassAsset.ClassMonitoringOptions.MonitoringMode.Disabled :
					radMonitoring_DataMode_Forced.Checked ? ClassAsset.ClassMonitoringOptions.MonitoringMode.Forced :
						ClassAsset.ClassMonitoringOptions.MonitoringMode.Auto;
			_asset.Monitoring.WebcamMode =
				radMonitoring_WebcamMode_Disabled.Checked ? ClassAsset.ClassMonitoringOptions.MonitoringMode.Disabled :
					radMonitoring_WebcamMode_Forced.Checked ? ClassAsset.ClassMonitoringOptions.MonitoringMode.Forced :
						ClassAsset.ClassMonitoringOptions.MonitoringMode.Auto;

			_asset.Monitoring.Interval = (int)numMonitoring_Interval.Value;
			_asset.Monitoring.HoldTime = (int)numMonitoring_HoldTime.Value;
			_asset.CameraCheckInterval = (int)numMonitoring_CameraCheckInterval.Value;
		}

		private bool ValidateAsset()
		{
			// TODO: More validation stuff here
			// Specifically: pitch, matrix, monitoring options
			if (string.IsNullOrEmpty(txtAsset_AssetName.Text.Trim()))
			{
				MessageBox.Show("Asset name cannot be blank.", "Asset Add/Modify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (_asset.MarketID < 1)
			{
				MessageBox.Show("Customer and market cannot be blank.", "Asset Add/Modify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (numMonitoring_CameraCheckInterval.Value > 0 && numMonitoring_CameraCheckInterval.Value <= numMonitoring_Interval.Value)
			{
				MessageBox.Show("Camera check interval must be greater than the monitoring interval.", "Asset Add/Modify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			var ccPaddingMinutes = ClassConfig.GetCameraCheckPaddingMinutes();
			if (numMonitoring_CameraCheckInterval.Value > 0 && numMonitoring_CameraCheckInterval.Value < ccPaddingMinutes)
			{
				var message = $"Camera check interval cannot be less than the system-configured padding amount, which is {ccPaddingMinutes} minutes.";
				MessageBox.Show(message, "Asset Add/Modify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearControls();
			LockControls();

			if (_currentAssetEditorMode == AssetEditorModes.Adding && _assetLoadedBeforeAddNew != null)
				Asset_Load(_assetLoadedBeforeAddNew.ID);
			else if (_asset != null && _asset.ID != -1)
				Asset_Load(_asset.ID);
            else
            {
                _currentAssetEditorMode = AssetEditorModes.Viewing;
            }
		}

		private void mnuAddNew_Click(object sender, EventArgs e)
		{
			Asset_StartAdd();
		}

		private void mnuRetire_Click(object sender, EventArgs e)
		{
			Asset_StartRetire();
		}

		private void mnuDelete_Click(object sender, EventArgs e)
		{
			Asset_StartDelete();
		}

		#region Actions
		private void btnSetServiceReminder_Click(object sender, EventArgs e)
		{
			if (_asset == null || _asset.ID < 0)
				return;

			if (_asset.IsRetired)
			{
				MessageBox.Show("This asset has been retired.", "Retired Asset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			using (var serviceReminderForm = new FormAsset_ServiceReminder(_asset))
			{
				serviceReminderForm.ShowDialog();
				if (serviceReminderForm.DialogResult != DialogResult.OK)
					return;
				Asset_Load(_asset.ID);
			}
		}

		private void btnCreateTicket_Click(object sender, EventArgs e)
		{
			if (!ClassTicket.TicketPrerequisiteCheck(_asset))
				return;

			var newTicket = ClassTicket.Create(_asset);
			if (newTicket != null)
				TicketCreated?.Invoke(newTicket);
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			if (_asset == null || _asset.ID < 0)
				return;

			LaunchDashboard?.Invoke(_asset);
		}

		private void btnVNC_Click(object sender, EventArgs e)
		{
			LaunchVNC?.Invoke(_asset);
		}

		private void btnTeamViewer_Click(object sender, EventArgs e)
		{
			LaunchTeamviewer?.Invoke(_asset);
		}

		private void assetLinker1_AssetClicked(int assetID)
		{
			AssetClicked?.Invoke(assetID);
		}

		/// <summary>
		/// Opens the open ticket if there is one. If there is more than one it changes the tab to ticket history.
		/// </summary>
		private void lblAsset_OpenTickets_Click(object sender, EventArgs e)
		{
			var ticketList = ClassTicket.GetByAsset(_asset.ID, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held).ToList();
			var count = ticketList.Count;

			switch (count)
			{
				case 1: // only one open ticket
					TicketDoubleClicked?.Invoke(ticketList[0].ID);
					break;

				default: //everything else 
					tabControl.SelectedTab = tabTicketHistory;
					break;
			}
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			Populate_ActiveTab();
		}

		private void btnAddDocument_Click(object sender, EventArgs e)
		{
            if (_asset == null)
                return;
			using (var newDocForm = new FormAsset_Document_New())
			{
				newDocForm.ShowDialog(this);
				if (newDocForm.DialogResult != DialogResult.OK)
					return;

				var doc = new ClassDocuments
				          {
					          AssetId = _asset.ID,
					          Name = newDocForm.DocumentName,
					          Document_Link = newDocForm.DocumentLink,
					          DateModified = DateTime.Now,
					          UserId = GS.Settings.LoggedOnUser.ID
				          };
				ClassDocuments.AddNew(ref doc);
				RefreshView();
			}
		}

		private void btnChangeDocument_Click(object sender, EventArgs e)
		{
			var selectedDoc = (ClassDocuments)olvDocuments.SelectedObject;
			if (selectedDoc == null)
				return;

			using (var newDocForm = new FormAsset_Document_New(selectedDoc.Name, selectedDoc.Document_Link))
			{
				newDocForm.ShowDialog(this);
				if (newDocForm.DialogResult != DialogResult.OK)
					return;

				selectedDoc.Name = newDocForm.DocumentName;
				selectedDoc.Document_Link = newDocForm.DocumentLink;
				selectedDoc.DateModified = DateTime.Now;
				selectedDoc.UserId = GS.Settings.LoggedOnUser.ID;
				ClassDocuments.Update(selectedDoc);
				RefreshView();
			}
		}

		private void btnRemoveDocument_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to remove link?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
				return;

			//We may want to add a confirm box eventually 
			var selectedDoc = (ClassDocuments)olvDocuments.SelectedObject;
			if (selectedDoc == null)
				return;
			ClassDocuments.Delete(selectedDoc);
			RefreshView();
		}

		private void olvDocuments_DoubleClick(object sender, EventArgs e)
		{
			var selectedDoc = (ClassDocuments)olvDocuments.SelectedObject;
			if (selectedDoc == null)
				return;
			var doc = selectedDoc.Document_Link;
			try
			{
				System.Diagnostics.Process.Start(doc);
			}
			catch (System.ComponentModel.Win32Exception)
			{
				try
				{
					System.Diagnostics.Process.Start(@doc);
				}
				catch (System.ComponentModel.Win32Exception)
				{
					MessageBox.Show("Unable To Open Document. Please check the document format.", "Error", MessageBoxButtons.OK);
				}
			}
		}
		#endregion

		#region Journal
		private void btnJournal_Add_Click(object sender, EventArgs e)
		{
			if (_asset == null || _asset.ID < 0)
				return;

			using (var frmJournal = new FormJournal(_asset, ClassAsset.MAX_JOURNAL_EXPIRATION, ClassJournal.ExpirationType.NotRequired))
			{
				if (frmJournal.ShowDialog(this) == DialogResult.Cancel)
					return;

				ClassJournal.AddJournalEntry(_asset, frmJournal.JournalEntry);
				ClassNotification.SendNotificationsForObject(frmJournal.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
			}

			Asset_Load(_asset.ID);
		}
		#endregion

		#region Ticket History
		private void olvTicketHistory_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvTicketHistory.SelectedItem == null || TicketDoubleClicked == null)
				return;

			var clickedTicket = (ClassTicket)olvTicketHistory.SelectedObject;
			TicketDoubleClicked(clickedTicket.ID);
		}

		private void olvTicketHistory_FormatRow(object sender, FormatRowEventArgs e)
		{
			var ticket = (ClassTicket)e.Model;
			e.Item.BackColor = ticket.StatusColor_Background;
			e.Item.ForeColor = ticket.StatusColor_Foreground;
		}
		#endregion

		#region Assigned Techs
		private void Asset_AssignTechs()
		{
			AssignTechsEnable();

			// Clear assigned tech list
			olvAssignedTechs.SetObjects(null);

			// Populate with all techs
			_assignableTechs = ClassTech.GetAll().Where(t => t.TechStatus != ClassDefinitions.TECH_STATUS_TYPES[4]).ToList();

			foreach (var assignableTech in _assignableTechs)
			{
				var tech = assignableTech;
				assignableTech.Assigned = _assignedTechs.Any(t => t.ID == tech.ID);
				if (_assignedTechs.Any(t => t.ID == tech.ID))
					assignableTech.Priority = _assignedTechs.Single(t => t.ID == tech.ID).Priority;
			}
			olvAssignedTechs.CheckedAspectName = "Assigned";
			olvAssignedTechs.SetObjects(_assignableTechs);

			olvAssignedTechs.Select();
		}

		private void Asset_SaveAssignedTechs()
		{
			// Validation
			if (olvAssignedTechs.CheckedItems.Count > ClassAsset.MAX_ASSIGNED_TECHS)
			{
				MessageBox.Show($"You can only select a maximum of {ClassAsset.MAX_ASSIGNED_TECHS} assigned techs.", "Assigned Techs Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			AssignTechsEnable(false);

			// Rewrite the assigned techs table values
			ClassAsset.AssignTechs(_asset, _assignableTechs.Where(t => t.Assigned).ToList());

			// Repopulate assigned tech list
			_assignedTechs = ClassTech.GetByAsset(_asset.ID).ToList();

			// Show only assigned techs
			olvAssignedTechs.SetObjects(_assignedTechs);
		}

		private void Asset_CancelAssignTechs()
		{
			AssignTechsEnable(false);

			// Show only assigned techs
			olvAssignedTechs.SetObjects(_assignedTechs);
		}

		private void AssignTechsEnable(bool enable = true)
		{
			olvAssignedTechs.CheckBoxes = enable;
			btnAssignedTechs_MoveUp.Enabled = !enable;
			btnAssignedTechs_Cancel.Visible = enable;
			btnAssignedTechs_Save.Visible = enable;
			btnAssignedTechs_Assign.Visible = !enable;
		}

		private void olvAssignedTechs_FormatCell(object sender, FormatCellEventArgs e)
		{
			if (e.ColumnIndex != olvColTechStatus.Index) return;
			var t = (ClassTech)e.Model;
			e.SubItem.ForeColor = t.TechStatus.Color;
		}

		private void olvAssignedTechs_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAssignedTechs_MoveUp.Visible = olvAssignedTechs.SelectedItems.Count == 1 && _currentAssetEditorMode == AssetEditorModes.Editing;
		}

		private void olvAssignedTechs_ItemsChanged(object sender, ItemsChangedEventArgs e)
		{
			btnAssignedTechs_MoveUp.Visible = false;
		}

		private void olvAssignedTechs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvAssignedTechs.SelectedItem != null)
				TechDoubleClicked?.Invoke((ClassTech)olvAssignedTechs.SelectedObject);
		}

		private void btnAssignedTechs_Assign_Click(object sender, EventArgs e)
		{
			if (_asset == null || _asset.ID < 0)
				return;

			Asset_AssignTechs();
		}

		private void btnAssignedTechs_MoveUp_Click(object sender, EventArgs e)
		{
			if (olvAssignedTechs.SelectedItem == null || _asset == null || _asset.ID < 0)
				return;

			var selectedTech = (ClassTech)olvAssignedTechs.SelectedObject;
			ClassAsset.IncreaseTechPriority(_asset.ID, selectedTech.ID);
			Populate_AssignedTechs();
		}

		private void btnAssignedTechs_Cancel_Click(object sender, EventArgs e)
		{
			Asset_CancelAssignTechs();
		}

		private void btnAssignedTechs_Save_Click(object sender, EventArgs e)
		{
			Asset_SaveAssignedTechs();
		}
		#endregion

		#region RMAs
		private void olvLegacyRmas_DoubleClick(object sender, EventArgs e)
		{
			ViewLegacyRMA?.Invoke(((ClassLegacyRMA)olvLegacyRMA.SelectedObject).ID);
		}

		private void ucRMAList1_ViewRMA(int rmaID)
		{
			ViewRMA?.Invoke(rmaID);
		}
		#endregion

		#region Shipments
		private void ucShipmentList_ViewShipment(int shipmentID)
		{
			ViewShipment?.Invoke(shipmentID, _asset.ID);
		}

		private void ucShipmentList_CreateShipment()
		{
			if (_asset.IsRetired)
			{
				MessageBox.Show("This asset has been retired.", "Retired Asset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			CreateShipment?.Invoke(_asset);
		}

		private void ucShipmentList_ViewTracking(string trackingUrl)
		{
			ViewTracking?.Invoke(trackingUrl);
		}
		#endregion

		private void TextBox_NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
		{
			/*
			 * ASCII
			 * - = 45
			 * . = 46
			 * / = 47
			 * 0 = 48
			 * 1 = 49
			 * 2 = 50
			 * 3 = 51
			 * 4 = 52
			 * 5 = 53
			 * 6 = 54
			 * 7 = 55
			 * 8 = 56
			 * 9 = 57
			 * 
			 * */
			// Allow numbers, dot and minus only
			if ((e.KeyChar < 48 || e.KeyChar > 57)
				&& e.KeyChar != 45
				&& e.KeyChar != 46
				&& e.KeyChar != 8)
				e.Handled = true; // Remove the character
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Asset_StartSearch();
		}

		private void Asset_StartSearch()
		{
			if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
				return;
			// Clear search field if something was found
			if (Asset_Search(txtSearch.Text))
				txtSearch.Clear();
		}

		private bool Asset_Search(string searchTerm)
		{
			var foundAssets = ClassAsset.Search(searchTerm).ToList();
			switch (foundAssets.Count)
			{
				case 0:
					MessageBox.Show(string.Format("No assets were found with the search term {0}.", searchTerm), "Asset Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				case 1:
					Asset_Load(foundAssets[0].ID);
					return true;
				default:
					foundAssets.PopulateExtraProperties();
					using (var fal = new FormList_Assets(foundAssets, searchTerm))
					{
						fal.ShowDialog(this);
						if (fal.SelectedAsset != null)
							Asset_Load(fal.SelectedAsset.ID);
					}
					return true;
			}
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			e.SuppressKeyPress = true;
			Asset_StartSearch();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void chkSubscribe_Click(object sender, EventArgs e)
		{
			if (_asset == null || _asset.ID < 0)
				return;

			if (_ignoreStateChange)
				return;

			if (ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Asset, _asset.ID))
			{
				ClassSubscription.Unsubscribe(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID);
				chkSubscribe.Checked = false;
			}
			else
			{
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
				chkSubscribe.Checked = true;
			}
		}

		private void olvAssignedTechs_BeforeSorting(object sender, BeforeSortingEventArgs e)
		{
			if (e.ColumnToSort == olvColTechPriority)
			{
				olvAssignedTechs.CustomSorter = delegate(OLVColumn col, SortOrder order) { olvAssignedTechs.ListViewItemSorter = new TechPriorityComparer(order); };
			}
			else
				olvAssignedTechs.CustomSorter = null;
		}
		#endregion Private Methods

		#region Public Methods
		public void Asset_Load(int assetID)
		{
			Cursor = Cursors.WaitCursor;
			_asset = ClassAsset.GetByID(assetID);
			_asset.PopulateExtraProperties();
			_asset.Ibom = ClassAsset.GetIbom(_asset.ID);
			_asset.Monitoring = ClassAsset.GetMonitoringOptions(_asset.ID);

			_cameraTypes = ClassCameraType.GetCameraTypes().ToList();
			_cabinetTypes = ClassCabinetType.GetCabinetTypes().ToList();
			_liftTypes = ClassLiftType.GetAll().ToList();
			_outputMethods = ClassOutputMethod.GetAll().OrderBy(om => om.Description).ToList();
			_controllerHardware = ControllerHardware.GetAll().OrderBy(ch => ch.Description).ToList();
			_controllerSoftware = ControllerSoftware.GetAll().OrderBy(cs => cs.Description).ToList();
			_controllerConnections = ControllerConnection.GetAll().OrderBy(cc => cc.Description).ToList();
            _clientConnections = ClassClientConnection.GetAll().OrderBy(cc => cc.Description).ToList();

            // Clear ticket history to avoid prior asset ticket history contamination
            _ticketHistory = null;

			cmbNetwork_WebcamType.DisplayMember = "DisplayMember";
			cmbNetwork_WebcamType.ValueMember = "ID";
			cmbNetwork_WebcamType.DataSource = new BindingSource { DataSource = _cameraTypes };

            Populate_ComboBoxLists();
			Populate();
			_currentAssetEditorMode = AssetEditorModes.Viewing;
			Cursor = Cursors.Default;
		}

		/// <summary>
		/// Reloads the current asset, if applicable.
		/// </summary>
		public void RefreshView()
		{
			if (_asset != null && _asset.ID > 0)
				Asset_Load(_asset.ID);
		}

		public void FocusSearch()
		{
			txtSearch.Select();
		}

		/// <summary>
		/// Clears all controls on the asset editor, resets button text and makes local objects null.
		/// Should only be called to present a blank form, not when populating an asset.
		/// </summary>
		public void ClearControls()
		{
			_ignoreStateChange = true;

			//_asset = new ClassAsset();

			ResetButtonText();

			// SEARCH
			txtSearch.Clear();

			// OWNERSHIP
			foreach (var textBox in pnlOwnershipInformation.Controls.OfType<TextBox>())
				textBox.Clear();
			ndtpAsset_InstallDateTime.Value = null;
			ndtpAsset_ShippedDateTime.Value = null;
			ucWarrantyStatus1.Clear();

			// STATUS
			lblStatus.Text = "STATUS";
			lblStatus.BackColor = Color.Transparent;
			lblStatus.ForeColor = Color.Silver;

			// PHYSICAL
			foreach (var textBox in pnlPhysical.Controls.OfType<TextBox>())
				textBox.Clear();
			numAsset_HAGL.Value = 0;
			chkIndoor.Checked = false;
			numAsset_InterfaceQty.Value = 0;
			numAsset_Pitch.Value = 0;

			// GEOGRAPHIC
			foreach (var textBox in pnlGeographic.Controls.OfType<TextBox>())
				textBox.Clear();
			assetLinker1.Clear();

			// ACTIONS
			btnSetServiceReminder.BackColor = SystemColors.Control;
			btnCreateTicket.BackColor = SystemColors.Control;

			// NOTES
			txtGeneralNotes.Clear();
			txtAccessNotes.Clear();

			// JOURNAL
			_journal = null;
			dgvJournal.Rows.Clear();

			// IBOM
			ucAsset_IBOM1.Clear();

			// NETWORK
			ClearControls_Network();

			// MONITORING
			radMonitoring_DataMode_Disabled.Checked = true;
			radMonitoring_WebcamMode_Disabled.Checked = true;
			lblMonitoring_ShowDataStatus.Text = string.Empty;
			lblMonitoring_ShowDataStatus.BackColor = SystemColors.Control;
			lblMonitoring_ShowWebcamStatus.Text = string.Empty;
			lblMonitoring_ShowWebcamStatus.BackColor = SystemColors.Control;
			numMonitoring_Interval.Value = 10;
			numMonitoring_HoldTime.Value = 0;
			foreach (var textBox in tabMonitoring.Controls.OfType<TextBox>())
			{
				textBox.BackColor = SystemColors.Control;
				textBox.Clear();
			}
			txtMonitoring_BlackoutSchedule.Clear();

			// ASSIGNED TECHS
			_assignedTechs = null;
			olvAssignedTechs.SetObjects(null);

			// TICKET HISTORY
			_ticketHistory = null;
			olvTicketHistory.SetObjects(null);

			// LEGACY RMA
			_legacyRmas = null;
			olvLegacyRMA.SetObjects(null);
			tbxLegacyRMACount.Clear();

			// RMA
			_rmas = null;
			ucRMAList1.Clear();

			// SHIPMENTS
			_shipments = null;
			ucShipmentList1.Clear();

			// SPARE PARTS
			ucAssetSpareParts1.Clear();

			// SYSTEM BACKUPS
			ucAssetSystemBackup1.Clear();

			AssetLoaded?.Invoke(null);

			_ignoreStateChange = false;
		}

		#endregion
	}
}