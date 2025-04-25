using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.Customer;
using SDB.Forms.General;
using SDB.Forms.Tech;
using SDB.Forms.Ticket;
 
namespace SDB.Forms.Shipment
{
	public partial class FormShipment_Editor : Form
	{
		#region Delegates and Events
		public delegate void ItemIDEvent(int itemID);
		public delegate void TrackingEvent(string trackingURL);
		public delegate void RefreshListEvent();
		public event ItemIDEvent ViewRMA;
		public event ItemIDEvent ViewTicket;
		public event ItemIDEvent ViewAsset;
		public event TrackingEvent ViewTracking;
		public event RefreshListEvent RefreshShipmentList;
		#endregion

		#region Enums and Structs
		private enum EditorMode { Viewing, Editing };
		#endregion

		#region Private Fields
		private EditorMode _currentEditorMode = EditorMode.Viewing;

		private ClassShipment _shipment = new ClassShipment();
		private ClassJournal _journal = new ClassJournal();
		private List<ClassShipment_Item> _ledger = new List<ClassShipment_Item>();
       // private String


        private List<ClassShipment_Method> _shipmentMethods = new List<ClassShipment_Method>();

		private int? _affinityRmaID;
		private int? _affinityTicketID;
		private int? _affinityAssetID;
		private bool _ignoreStateChange;
		private bool _allowAdminEdit;
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		public FormShipment_Editor()
		{
			InitializeComponent();

			// Bind shipping method selectors
			cmbShippingMethod.ValueMember = "ID";
			cmbShippingMethod.DisplayMember = "Description";

			olvLedger.CellToolTip.HasBorder = true;
			olvLedger.CellToolTip.AutoPopDelay = 10000;
			olvLedger.CellToolTip.Font = new Font("Consolas", 10);
		}
		#endregion

		#region Private Methods
		private void FormShipment_Editor_Load(object sender, EventArgs e)
		{
			_shipmentMethods = ClassShipment_Method.GetAll().ToList();

			WindowState = GS.Settings.WindowState_Shipment_Editor;
			Location = GS.Settings.Location_Shipment_Editor;
		}

		private void FormShipment_Editor_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}

		private void FormShipment_Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Confirm if editing
			if (_currentEditorMode == EditorMode.Editing)
			{
				if (MessageBox.Show("Are you sure you want to discard edits to the current shipment?", "Confirm Cancel Shipment Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				{
					e.Cancel = true;
					return;
				}
			}

			_currentEditorMode = EditorMode.Viewing;
			ClearControls();

			// Clear affinities
			_affinityAssetID = _affinityRmaID = _affinityTicketID = null;

			GS.Settings.WindowState_Shipment_Editor = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_Shipment_Editor = Location;
			Hide();
			e.Cancel = true;
		}

		/// <summary>
		/// Creates a new shipment with the optionally specified Tech or Market destination.
		/// If both are specified (they shouldn't be), the Tech takes priority.
		/// </summary>
		private void Shipment_Create(ClassTech tech = null, ClassMarket market = null)
		{
			if (_currentEditorMode == EditorMode.Editing &&
			    MessageBox.Show("Do you want to create a new shipment, discarding changes to the current shipment?", "Confirm Cancel Shipment Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			_shipment = new ClassShipment();
			_ledger = new List<ClassShipment_Item>();
			_journal = new ClassJournal();
			_shipment.Requested_By = GS.Settings.LoggedOnUser.FirstL;
			_shipment.Requested_Date = ClassDatabase.GetCurrentTime();
			// Do not use default shipping method because users will fail to select an appropriate shipping method unless forced to specify it.

			if (tech != null)
			{
				_shipment.TechID = tech.ID;
				SetShipmentDestinationToTech(tech);
				LockDestination(true);
			}
			else if (market != null)
			{
				_shipment.MarketID = market.ID;
				SetShipmentDestinationToMarket(market);
				LockDestination(true);
			}

			btnEditSave.Text = "Save";
			_currentEditorMode = EditorMode.Editing;
			Populate();
		}

		/// <summary>
		/// Load the specified shipment and show it on the details tab.
		/// </summary>
		public void Shipment_Load(int shipmentID)
		{
			if (_currentEditorMode == EditorMode.Editing &&
				MessageBox.Show("Do you want to load a shipment, discarding changes to the current shipment?", "Confirm Cancel Shipment Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			_currentEditorMode = EditorMode.Viewing;
			_allowAdminEdit = false;

			_shipment = ClassShipment.GetByID(shipmentID);
			if (_shipment == null)
				return;
			_ledger = ClassShipment.GetInventory(_shipment.ID).ToList();
			_journal = ClassJournal.GetByObject(_shipment);

			Populate();
		}

		/// <summary>
		/// Load the specified shipment and show it on the details tab. Sets ticket affinity to specified Ticket ID.
		/// </summary>
		public void Shipment_Load_ForTicket(int shipmentID, int ticketID)
		{
			_affinityTicketID = ticketID;
			Shipment_Load(shipmentID);
		}

		/// <summary>
		/// Load the specified shipment and show it on the details tab. Sets asset affinity to specified Asset ID.
		/// </summary>
		public void Shipment_Load_ForAsset(int shipmentID, int assetID)
		{
			_affinityAssetID = assetID;
			Shipment_Load(shipmentID);
		}

		/// <summary>
		/// Populates the detail tab with the currently loaded shipment and switches to the detail tab.
		/// </summary>
		private void Populate()
		{
			ClearControls();
			RefreshDataBindings();
			_ignoreStateChange = true;

			chkSubscribe.Checked = ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);

			SetColors();
			Populate_Control();
			Populate_Status();
			Populate_Journal();
			Populate_RequestSection();
			Populate_AddressSection();
			Populate_Ledger();
			Populate_Fulfillment();
			LockControls(_currentEditorMode != EditorMode.Editing);
			_ignoreStateChange = false;
		}

		/// <summary>
		/// Populates the status and button text at top of shipment detail.
		/// </summary>
		private void Populate_Status()
		{
			// Creating Shipment
			if (_shipment.ID < 1)
			{
				txtShipmentNumber.Text = "* New *";
				lblStatus.Text = "New Request";
				return;
			}

			txtShipmentNumber.Text = _shipment.ID.ToString(CultureInfo.InvariantCulture);

			if (_shipment.IsDeleted)
				lblStatus.Text = "Deleted";
			else if (_shipment.Fulfilled_Date.HasValue)
				lblStatus.Text = "Shipped"; //string.Format("Shipped on {0:yyyy-MM-dd} by {1}", _shipment.Fulfilled_Date, _shipment.Fulfilled_By);
			else if (_shipment.IsOnHold)
				lblStatus.Text = "On Hold";
			else if (_shipment.Picked_Date.HasValue)
				lblStatus.Text = "Ready to Ship";
			else if (_shipment.IsReady)
				lblStatus.Text = "Ready to Pick";
			else
				lblStatus.Text = "Not Ready";
		}

		private void ShowPrep(bool show)
		{
			pbxRequiresPrep.Visible = show;
			lblRequirePrep.Visible = show;
		}

		/// <summary>
		/// Handles the text, state and tooltip of buttons in general when loading a shipment.
		/// </summary>
		private void Populate_Control()
		{
			// create is always the same

			// delete/restore
			mnuDeleteRestore.Text = _shipment.IsDeleted ? "Restore" : "Delete";
			mnuDeleteRestore.BackColor = _shipment.IsDeleted ? Color.FromArgb(192, 255, 192) : Color.FromArgb(255, 192, 192);
			//mnuDeleteRestore.ForeColor = _shipment.IsDeleted ? Color.Green : Color.Red;
			mnuDeleteRestore.Enabled = _shipment.ID > 0;
			mnuDeleteRestore.ToolTipText = _shipment.IsDeleted ? "Restore this shipment." : "Delete this shipment.";

			// hold/release
			mnuHoldRelease.Text = _shipment.IsOnHold ? "Release" : "Hold";
			mnuHoldRelease.BackColor = _shipment.IsOnHold ? Color.FromArgb(192, 255, 255) : Color.FromArgb(255, 224, 192);
			//mnuHoldRelease.ForeColor = _shipment.IsOnHold ? Color.DeepSkyBlue : Color.Orange;
			mnuHoldRelease.Enabled = _shipment.ID > 0 && !_shipment.IsDeleted && !_shipment.Fulfilled_Date.HasValue;
			mnuHoldRelease.ToolTipText = _shipment.IsOnHold ? "Release this shipment." : "Put shipment on hold.";

			// edit/save
			btnEditSave.Enabled = GS.Settings.LoggedOnUser.IsAdmin || (!_shipment.IsDeleted && !_shipment.Fulfilled_Date.HasValue);
			btnEditSave.Text = (_currentEditorMode == EditorMode.Editing) ? "Save" : "Edit";
			toolTip.SetToolTip(btnEditSave, _currentEditorMode == EditorMode.Editing ? "Save edits." : "Edit this shipment.");

			// export
			mnuExport.Visible = _shipment.ID > 0;

			// print
			mnuPrint.Visible = _shipment.ID > 0;

			// cancel
			btnCancel.Visible = _currentEditorMode == EditorMode.Editing;
		}

		private void Populate_Journal()
		{
			_journal.PopulateDataGridView(dgvJournal);
			dgvJournal.DefaultCellStyle.Font = GS.Settings.JournalFont;
		}

		private void Populate_RequestSection()
		{
			txtRequestedBy.Text = _shipment.Requested_By;
			txtRequestedDate.Text = _shipment.Requested_Date.ToString("yyyy-MM-dd");
			txtPurchaseOrder.Text = _shipment.Purchase_Order;
			cmbShippingMethod.SelectedValue = _shipment.ShipMethod;
			txtNotes.Text = _shipment.Notes;
			pbNotesFlag.Visible = _shipment.HasNonSystemInfo;
            ePartsCbx.Checked = _shipment.IsEparts;
            tbxEmailList.Text = _shipment.EmailList;
		}

		private void Populate_AddressSection()
		{
			if (_shipment.Destination == null)
				return;

			txtDest_Company.Text = _shipment.Destination.Company;
			txtDest_Attn.Text = _shipment.Destination.Attention;
			txtDest_Address.Text = _shipment.Destination.Address;
			txtDest_City.Text = _shipment.Destination.City;
			txtDest_State.Text = _shipment.Destination.State;
			txtDest_Zip.Text = _shipment.Destination.Zip;
			txtDest_Country.Text = _shipment.Destination.Country;
			txtDest_Telephone.Text = _shipment.Destination.Telephone;
			if (_shipment.Destination.AddressType == ClassShipment.AddressTypeEnum.Business)
				radAddressTypeBusiness.Checked = true;
			else
				radAddressTypeResidence.Checked = true;

			btnSelectTech.BackColor = _shipment.TechID.HasValue ? Color.LightGreen : SystemColors.Control;
			btnSelectMarket.BackColor = _shipment.MarketID.HasValue ? Color.LightGreen : SystemColors.Control;
			LockDestination(_shipment.TechID.HasValue || _shipment.MarketID.HasValue);
		}

		private void Populate_Ledger()
		{
			olvLedger.SetObjects(_ledger);
			txtLedger_ItemQty.Text = $"{_ledger.Sum(l => l.Quantity)}";
			olvLedger.PrimarySortColumn = olvColLedger_ID;
			olvLedger.PrimarySortOrder = SortOrder.Ascending;

			if (_shipment.IsReady)
			{
				btnReady.Text = "Cancel Ready to Pick";
				toolTip.SetToolTip(btnReady, "Mark shipment as Not Ready to Pick.");
				txtReadyDate.Text = $"{_shipment.ReadyDate:yyyy-MM-dd HH:mm}";

				btnLedger_Add.Enabled = false;
				btnLedger_Remove.Enabled = false;
				btnLedger_Edit.Enabled = false;
			}
			else
			{
				btnReady.Text = "Mark as Ready to Pick";
				toolTip.SetToolTip(btnReady, "Mark shipment as Ready to Pick.");
				txtReadyDate.Clear();

				btnLedger_Add.Enabled = true;
				btnLedger_Remove.Enabled = true;
				btnLedger_Edit.Enabled = true;
			}

			// The Ledger control section is only enabled if the shipment 1) is not deleted AND 2) is not on hold.
			pnlLedger_Control.Enabled = !_shipment.IsDeleted && !_shipment.IsOnHold;

			// The "Mark as Ready" button is only enabled if the shipment 1) hasn't been picked AND 2) has an ID AND 3) is not deleted AND 4) is not on hold.
			btnReady.Enabled = !_shipment.Picked_Date.HasValue && _shipment.ID > 0 && !_shipment.IsDeleted && !_shipment.IsOnHold;
		}

		private void Populate_Fulfillment()
		{
			if (_shipment.IsDeleted || _shipment.IsOnHold)
			{
				grpFulfillment.Enabled = false;
				return;
			}

			grpFulfillment.Enabled = true;

			// Enable picking if not shipped, ledger has at least one item, and shipment is "ready"
			pnlPick.Enabled = _ledger.Count > 0 && _shipment.IsReady && !_shipment.Fulfilled_Date.HasValue;

			// Enable shipping if picked
			pnlShip.Enabled = _ledger.Count > 0 && _shipment.Picked_Date.HasValue;

			// Populate pick information
			if (_shipment.Picked_Date.HasValue)
			{
				btnPick.Text = "Cancel Pick";
				toolTip.SetToolTip(btnPick, "Cancel item picking for this shipment. This will unlock the shipment and allow modification of its ledger.");
				txtPickDate.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm}", string.Empty, _shipment.Picked_Date.Value);
				if (_shipment.Picked_By != null)
					txtPickedBy.Text = _shipment.Picked_By;
			}
			else
			{
				btnPick.Text = "Pick";
				toolTip.SetToolTip(btnPick, "Start assembling the shipment. This will lock the shipment from being edited unless canceled.");
				txtPickDate.Clear();
				txtPickedBy.Clear();
			}

			// Populate ship information
			if (_shipment.Fulfilled_Date.HasValue)
			{
				btnShip.Text = "Cancel Ship";
				toolTip.SetToolTip(btnShip, "Cancel the finalization of this shipment. This will reopen the shipment and allow modification of fulfillment details.");
				txtShipDate.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm}", string.Empty, _shipment.Fulfilled_Date.Value);
				if (_shipment.Fulfilled_By != null)
					txtShippedBy.Text = _shipment.Fulfilled_By;
			}
			else
			{
				btnShip.Text = "Ship";
				toolTip.SetToolTip(btnShip, "Finalize the shipment. This will close this shipment and mark it as completed.");
				txtShipDate.Clear();
				txtShippedBy.Clear();
			}

			numPackages.Value = _shipment.Packages.GetValueOrDefault(0);
			numWeight.Value = (decimal)_shipment.Weight.GetValueOrDefault(0);
			numTotalCost.Value = (decimal)_shipment.Fulfillment_Cost.GetValueOrDefault(0);
			numInsurance.Value = (decimal)_shipment.Insurance_Amount.GetValueOrDefault(0);
			txtTrackingNumber.Text = _shipment.Tracking;

			numPackages.ReadOnly = _shipment.Fulfilled_Date.HasValue;
			numWeight.ReadOnly = _shipment.Fulfilled_Date.HasValue;
			numTotalCost.ReadOnly = _shipment.Fulfilled_Date.HasValue;
			numInsurance.ReadOnly = _shipment.Fulfilled_Date.HasValue;
			txtTrackingNumber.ReadOnly = _shipment.Fulfilled_Date.HasValue;
			btnViewTracking.Enabled = _shipment.Fulfilled_Date.HasValue;

			bool prep = false;
			foreach(var x in _ledger)
			{
				if (x.AssemblyType.NeedsPrep)
					prep = true;
			}
			ShowPrep(prep);

		}

		private void ClearControls()
		{
			_allowAdminEdit = false;
			_ignoreStateChange = true;
			txtShipmentNumber.Clear();
			lblStatus.Text = string.Empty;
            ePartsCbx.Checked = false;
            tbxEmailList.Clear();

			// Button states and text
			mnuCreate.Enabled = true;

			mnuDeleteRestore.Enabled = false;
			mnuDeleteRestore.Text = "Delete";
			mnuDeleteRestore.ToolTipText = "Delete this shipment.";

			mnuHoldRelease.Enabled = false;
			mnuHoldRelease.Text = "Hold";
			mnuHoldRelease.ToolTipText = "Put this shipment on hold.";

			btnEditSave.Text = "Edit";
			toolTip.SetToolTip(btnEditSave, "Edit this shipment.");

			mnuExport.Visible = false;
			mnuPrint.Visible = false;
			btnCancel.Visible = false;

			dgvJournal.Rows.Clear();

			txtRequestedBy.Clear();
			txtRequestedDate.Clear();
			txtPurchaseOrder.Clear();
			foreach (var textBox in tabDestination.Controls.OfType<TextBox>())
				textBox.Clear();
			radAddressTypeBusiness.Checked = true;
			cmbShippingMethod.SelectedIndex = -1;
			txtNotes.Clear();

			txtLedger_ItemQty.Clear();
			olvLedger.SetObjects(null);
			btnReady.Text = "Mark as Ready";
			btnReady.Enabled = false;
			toolTip.SetToolTip(btnReady, "Mark shipment as Ready.");

			foreach (var textBox in pnlPick.Controls.OfType<TextBox>())
				textBox.Clear();
			foreach (var textBox in pnlShip.Controls.OfType<TextBox>())
				textBox.Clear();
			foreach (var numericUpDown in pnlShip.Controls.OfType<NumericUpDown>())
				numericUpDown.Value = 0;

			SetColors();
			LockControls(true);
			_ignoreStateChange = false;
		}

		/// <summary>
		/// Sets colors for editor based on shipment status.
		/// </summary>
		private void SetColors()
		{
			if (_shipment == null)
			{
				txtShipmentNumber.ForeColor = lblStatus.ForeColor = ClassShipment.SHIPMENT_READY;
				txtShipmentNumber.BackColor = pnlTopControl.BackColor = ClassShipment.SHIPMENT_READY_BG;
				return;
			}

			txtShipmentNumber.ForeColor = lblStatus.ForeColor = _shipment.StatusColor;
			txtShipmentNumber.BackColor = pnlTopControl.BackColor = _shipment.StatusColorBackground;
            BackColor = _shipment.StatusColorBackground;

        }

		/// <summary>
		/// Locks or unlocks shipment request section controls.
		/// </summary>
		private void LockControls(bool isLocked)
		{
			// Request Section
			foreach (var textBox in grpRequest.Controls.OfType<TextBox>().Where(c => (string)c.Tag != "ReadOnly"))
				textBox.ReadOnly = isLocked;

           // tabDestination.Enabled = !isLocked;
            tbxEmailList.ReadOnly = isLocked;
            ePartsCbx.Enabled = !isLocked;

            btnClear.Enabled = !isLocked;
            btnOtherAddressLookup.Enabled = !isLocked;
            btnSelectMarket.Enabled = !isLocked;
            btnSelectTech.Enabled = !isLocked;

			// Textboxes in grpDestination are only unlocked for editing if the shipment is not associated with a tech or market
			var enableDestinationEditing = !_shipment.TechID.HasValue && _shipment.MarketID.HasValue;

			foreach (var textBox in tabDestination.Controls.OfType<TextBox>().Where(t => t != txtDest_Attn))
			{
				if (!isLocked && enableDestinationEditing)
					textBox.ReadOnly = false;
				else textBox.ReadOnly = true;
			}

			txtDest_Attn.ReadOnly = isLocked;
			
			foreach (var radioButton in tabDestination.Controls.OfType<RadioButton>())
				radioButton.Enabled = !isLocked && enableDestinationEditing;
			
			foreach (var comboBox in grpRequest.Controls.OfType<ComboBox>())
				comboBox.Enabled = !isLocked;
		}

		private void btnLedger_Add_Click(object sender, EventArgs e)
		{
			#region Validation
			if (_shipment.IsReady && !_allowAdminEdit)
				return;
			#endregion

			using (var shipmentItemForm = new FormEpartItem())
			{
				#region Smart Auto-Populate
				var lastItem = _ledger.LastOrDefault();

				// Use the last item in the ledger to populate the form, otherwise use affinities, if set
				if (lastItem != null)
				{
					if (lastItem.RMA_ID.HasValue)
						shipmentItemForm.SetRMA(lastItem.RMA_ID.Value);
					if (lastItem.Asset_ID.HasValue)
						shipmentItemForm.SetAsset(lastItem.Asset_ID.Value);
					if (lastItem.Ticket_ID.HasValue)
						shipmentItemForm.SetTicket(lastItem.Ticket_ID.Value);
					if (!string.IsNullOrEmpty(lastItem.Job_Number))
						shipmentItemForm.SetJobNumber(lastItem.Job_Number);
				}
				else
				{
					if (_affinityRmaID.HasValue)
						shipmentItemForm.SetRMA(_affinityRmaID.Value);
					if (_affinityAssetID.HasValue)
					{
						shipmentItemForm.SetAsset(_affinityAssetID.Value);
						shipmentItemForm.SetJobNumber(ClassAsset.GetByID(_affinityAssetID.Value).ActivePartsNumber);
					}
					if (_affinityTicketID.HasValue)
						shipmentItemForm.SetTicket(_affinityTicketID.Value);
				}
				#endregion

				if (shipmentItemForm.ShowDialog() != DialogResult.OK)
					return;

				var item = new ClassShipment_Item
				{
					Quantity = shipmentItemForm.Quantity,
					AssemblyType = shipmentItemForm.AssemblyType,
					Assembly = shipmentItemForm.Assembly,
					Asset_ID = shipmentItemForm.Asset?.ID,
					Asset_Name = shipmentItemForm.Asset == null ? string.Empty : shipmentItemForm.Asset.AssetName,
					Job_Number = shipmentItemForm.JobNumber,
					Serial_Number = shipmentItemForm.SerialNumbers,
					Ticket_ID = shipmentItemForm.TicketID,
					RMA_ID = shipmentItemForm.RmaID
				};

                //Add Journal on item added
                ClassJournal.AddJournalEntry(_shipment, GS.Settings.LoggedOnUser.FirstL + " ADDED " + item.Assembly.AssemblyNumber + " [x" + item.Quantity + "]", null, true);


                if (item.Quantity == 1 || string.IsNullOrEmpty(item.Serial_Number))
					_ledger.Add(item);
				else
				{
					// Serial numbers should already be validated by FormShipmentItem
					var serials = item.Serial_Number.Trim().Replace(" ", string.Empty).Split(',');
					for (var i = 0; i < item.Quantity; i++)
					{
						_ledger.Add(new ClassShipment_Item
						            {
										 Quantity= 1,
										 AssemblyType = item.AssemblyType,
										 Assembly = item.Assembly,
										 Asset_ID = item.Asset_ID,
										 Asset_Name =item.Asset_Name,
										 Job_Number = item.Job_Number,
										 Serial_Number = serials[i],
										 Ticket_ID = item.Ticket_ID,
										 RMA_ID = item.RMA_ID
						            });
					}
				}

                // Automatically update shipment if it has an ID
                if (_shipment.ID > 0)
					UpdateOrCreateShipment();
				else
					Populate_Ledger();
			}
		}

		private void btnLedger_Edit_Click(object sender, EventArgs e)
		{
			ShipmentDetail_EditSelectedItem();
		}

		private void btnLedger_Remove_Click(object sender, EventArgs e)
		{
			if (olvLedger.SelectedItem == null || (_shipment.IsReady && !_allowAdminEdit))
				return;

			var selectedShipmentItem = (ClassShipment_Item)olvLedger.SelectedObject;
			_ledger.Remove(selectedShipmentItem);

            //Add Journal on item added
            ClassJournal.AddJournalEntry(_shipment, GS.Settings.LoggedOnUser.FirstL + " REMOVED " + selectedShipmentItem.Assembly.AssemblyNumber + " [x" + selectedShipmentItem.Quantity + "]", null, true);


            // Automatically update shipment if it has an ID
            if (_shipment.ID > 0)
				UpdateOrCreateShipment();
			else
				Populate_Ledger();
		}

		/// <summary>
		/// Cancels the editing of a new or existing shipment (doesn't cancel the shipment itself).
		/// </summary>
		private void Shipment_Cancel()
		{
			if (_shipment.ID < 1)
			{
				if (MessageBox.Show("Are you sure you want to cancel shipment creation?", "Confirm Cancel Shipment Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				_currentEditorMode = EditorMode.Viewing;
				ClearControls();
				Close();
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to discard edits to the current shipment?", "Confirm Cancel Shipment Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				_currentEditorMode = EditorMode.Viewing;
				Shipment_Load(_shipment.ID);
			}
		}

		private void Shipment_EditSave()
		{
			if (_currentEditorMode == EditorMode.Editing)
			{
				// save
				UpdateOrCreateShipment();
			}
			else
			{
				if (_shipment.ID < 1)
					return;
				// change modes and repopulate
				_currentEditorMode = EditorMode.Editing;
				Populate();
			}
		}

		/// <summary>
		/// Used by admins to modify the ledger without canceling ship or pick status.
		/// </summary>
		private void Shipment_UnlockLedger()
		{
			pnlLedger_Control.Enabled = true;
			foreach (var b in pnlLedger_Control.Controls.OfType<Button>())
				b.Enabled = true;
                
		}

		private void Shipment_Hold()
		{
			if (MessageBox.Show($"Are you sure you want to put shipment {_shipment.ID} on hold?",
				"Confirm Shipment Hold", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			using (var f = new FormUserInput("Hold Reason", "Please enter a hold reason for this shipment:"))
			{
				if (f.ShowDialog() != DialogResult.OK)
					return;

				_shipment.Hold();
				var entry = $"Held shipment: {f.UserText.Trim()}";
				ClassJournal.AddJournalEntry(_shipment, entry, null, true);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} placed on hold.", null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}
			Shipment_Load(_shipment.ID);

			RefreshShipmentList?.Invoke();
		}

		private void Shipment_Release()
		{
			_shipment.Release();
			ClassJournal.AddJournalEntry(_shipment, "Released shipment", null, true);
			foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
			{
				ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} released from hold.", null, true);
				if (ticket.IsHeld)
					ticket.Release();
			}
			ClassNotification.SendNotificationsForObject("Released shipment", ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			Shipment_Load(_shipment.ID);

			RefreshShipmentList?.Invoke();
		}

		private void Shipment_DeleteRestore()
		{
			if (_shipment.IsDeleted)
				Shipment_Restore();
			else
				Shipment_Delete();
		}

		private void Shipment_Delete()
		{
			var confirmMessage = $"Are you sure you want to delete shipment {_shipment.ID}?";
			if (MessageBox.Show(confirmMessage, "Shipment Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			using (var f = new FormUserInput("Delete Reason", "Enter a reason for deleting this shipment:"))
			{
				if (f.ShowDialog() != DialogResult.OK)
					return;
				
				var reason = f.UserText.Trim();
				_shipment.Delete(reason);
				var entry = $"Deleted shipment: {reason}";
				ClassJournal.AddJournalEntry(_shipment, entry, null, true);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} deleted", null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}
			Shipment_Load(_shipment.ID);
			RefreshShipmentList?.Invoke();
		}

		private void Shipment_Restore()
		{
			var confirmMessage = $"Are you sure you want to restore shipment {_shipment.ID}?";
			if (MessageBox.Show(confirmMessage, "Shipment Restore Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			using (var userInputForm = new FormUserInput("Restore Reason", "Please enter a reason for restoring this shipment:"))
			{
				if (userInputForm.ShowDialog() != DialogResult.OK)
					return;

				_shipment.Restore();
				var entry = $"Restored shipment: {userInputForm.UserText.Trim()}";
				ClassJournal.AddJournalEntry(_shipment, entry, null, true);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} restored.", null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Create || GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}
			Shipment_Load(_shipment.ID);
			RefreshShipmentList?.Invoke();
		}

		private void UpdateOrCreateShipment()
		{
			if (!ValidateShipment(out var errors))
			{
				MessageBox.Show(errors, "Shipment Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Clear affinities
			_affinityRmaID = null;
			_affinityTicketID = null;
			_affinityAssetID = null;

			// Update ShipmentDetail to match what is on the request portion of the form
			_shipment.Purchase_Order = txtPurchaseOrder.Text.Trim();
			_shipment.Destination = new ClassShipment.ClassShippingAddressInfo
			                        {
				                        Company = txtDest_Company.Text.Trim(),
				                        Attention = txtDest_Attn.Text.Trim(),
				                        Address = txtDest_Address.Text.Trim(),
				                        City = txtDest_City.Text.Trim(),
				                        State = txtDest_State.Text.Trim(),
				                        Zip = txtDest_Zip.Text.Trim(),
				                        Country = txtDest_Country.Text.Trim(),
				                        Telephone = txtDest_Telephone.Text.Trim(),
				                        AddressType = radAddressTypeBusiness.Checked ? ClassShipment.AddressTypeEnum.Business : ClassShipment.AddressTypeEnum.Residential
			                        };
			_shipment.HasComputer = _ledger.Any(i => i.AssemblyType.NeedsPrep);
			_shipment.ShipMethod = (int)cmbShippingMethod.SelectedValue;
			_shipment.Notes = txtNotes.Text.Trim();
            _shipment.IsEparts = ePartsCbx.Checked;
            _shipment.EmailList = tbxEmailList.Text;

			// Update in DB
			if (_shipment.ID < 1)
			{
				// Mark the shipment as ready if no items require prep, otherwise not ready
				//_shipment.IsReady = false;
				if (_shipment.IsReady)
					_shipment.ReadyDate = _shipment.Requested_Date;
				ClassShipment.AddNew(ref _shipment, _ledger);
                ClassJournal.AddJournalEntry(_shipment, "Created shipment", null, true);

                ClassNotification.SendNotificationsForObject("Created shipment", ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Create)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);

				// Add journal entries for the tickets, assets and RMAs that the shipment refers to
				var rmas = _ledger.Where(l => l.RMA_ID.HasValue).Select(l => l.RMA_ID.GetValueOrDefault(0)).Distinct().ToArray();
				var tickets = _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.GetValueOrDefault(0)).Distinct().ToArray();
				var assets = _ledger.Where(l => l.Asset_ID.HasValue).Select(l => l.Asset_ID.GetValueOrDefault(0)).Distinct().ToArray();

				foreach (var rma in rmas.Select(ClassRMA.GetRMA))
					ClassJournal.AddJournalEntry(rma, $"Shipment {_shipment.ID} created", null, true);

				foreach (var ticket in tickets.Select(ClassTicket.GetByID))
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} created", null, true);

				foreach (var asset in assets.Select(ClassAsset.GetByID))
					ClassJournal.AddJournalEntry(asset, $"Shipment {_shipment.ID} created", null, true);
			}
			else
			{
				ClassShipment.Update(_shipment, _ledger);
				ClassJournal.AddJournalEntry(_shipment, "Modified shipment.", null, true);
				ClassNotification.SendNotificationsForObject("Modified shipment.", ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}

			RefreshShipmentList?.Invoke();

			_currentEditorMode = EditorMode.Viewing;
			Shipment_Load(_shipment.ID);
		}

		/// <summary>
		/// Verifies that required destination fields, shipment method and ledger are present.
		/// </summary>
		private bool ValidateShipment(out string errors)
		{
			var sb = new StringBuilder();
			if (string.IsNullOrEmpty(txtDest_Company.Text.Trim()))
				sb.AppendLine("Company name cannot be blank.");
			if (string.IsNullOrEmpty(txtDest_Address.Text.Trim()))
				sb.AppendLine("Address cannot be blank.");
			if (string.IsNullOrEmpty(txtDest_City.Text.Trim()))
				sb.AppendLine("City cannot be blank.");
			// Some international addresses do not have or use a state/province abbreviation
			//if (string.IsNullOrEmpty(txtDest_State.Text.Trim()))
			//	sb.AppendLine("State cannot be blank.");
			if (string.IsNullOrEmpty(txtDest_Zip.Text.Trim()))
				sb.AppendLine("Zip/postal code cannot be blank.");
			if (cmbShippingMethod.SelectedIndex < 0)
				sb.AppendLine("Valid shipment method must be selected.");
			if (_ledger.Count < 1)
				sb.AppendLine("At least one item must be present in the ledger.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private void btnPick_Click(object sender, EventArgs e)
		{
			if (!_shipment.Picked_Date.HasValue)
			{
				_shipment.Pick();
				ClassJournal.AddJournalEntry(_shipment, "Shipment picked", null, true);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} picked", null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject("Shipment picked", ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to cancel picking? This will unlock the shipment for further editing.", "Confirm Cancel Shipment Pick", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				string cancelReason;
				using (var userInputForm = new FormUserInput("Reason for Canceling Picked Status", "Please enter the reason for canceling the picked status of this shipment:"))
				{
					if (userInputForm.ShowDialog() != DialogResult.OK)
						return;
					cancelReason = userInputForm.UserText;
				}
				_shipment.CancelPick();
				var cancelMessage = $"Shipment pick canceled: {cancelReason}";
				ClassJournal.AddJournalEntry(_shipment, cancelMessage, null, false);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} pick canceled", null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject("Shipment pick canceled", ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}

			Shipment_Load(_shipment.ID);

			RefreshShipmentList?.Invoke();
		}

		private void btnShip_Click(object sender, EventArgs e)
		{
			if (!_shipment.Fulfilled_Date.HasValue)
			{
				#region Validation
				if (numPackages.Value < 1)
				{
					MessageBox.Show("You can't ship something without at least one package.", "Zero Packages", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrEmpty(txtTrackingNumber.Text))
				{
					if (MessageBox.Show("Are you sure you want to ship without specifying a tracking number?", "No Tracking Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
				}

				if (numWeight.Value == 0 || numTotalCost.Value == 0)
				{
					if (MessageBox.Show("Are you sure you want to ship with missing information for Weight or Total Cost?", "Missing Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
				}
				#endregion

				_shipment.Ship((int)numPackages.Value, (float)numWeight.Value, (float)numTotalCost.Value, (float)numInsurance.Value, txtTrackingNumber.Text.Trim());
				ClassJournal.AddJournalEntry(_shipment, "Shipment shipped", null, true);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} shipped", null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject("Shipment shipped", ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to cancel shipping? This will unlock the shipment for further editing.", "Confirm Cancel Ship", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				string cancelReason;
				using (var userInputForm = new FormUserInput("Reason for Canceling Shipped Status", "Please enter the reason for canceling the shipped status of this shipment:"))
				{
					if (userInputForm.ShowDialog() != DialogResult.OK)
						return;
					cancelReason = userInputForm.UserText;
				}

				_shipment.CancelShip();
				var cancelMessage = $"Shipment ship canceled: {cancelReason}";
				ClassJournal.AddJournalEntry(_shipment, cancelMessage, null, false);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, $"Shipment {_shipment.ID} ship canceled", null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject("Shipment ship canceled", ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}

			Shipment_Load(_shipment.ID);

			RefreshShipmentList?.Invoke();
		}

		private void olvLedger_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
		{
			var selectedItem = (ClassShipment_Item)e.Model;
			if (e.Column == olvColLedger_RMA)
			{
				var rmaNum = selectedItem.RMA_ID;
				if (ViewRMA != null && rmaNum.HasValue)
					ViewRMA(rmaNum.Value);
			}
			else if (e.Column == olvColLedger_Ticket)
			{
				var ticketID = selectedItem.Ticket_ID;
				if (ViewTicket != null && ticketID.HasValue)
					ViewTicket(ticketID.Value);
			}
			else if (e.Column == olvColLedger_Asset)
			{
				var assetID = selectedItem.Asset_ID;
				if (ViewAsset != null && assetID.HasValue)
					ViewAsset(assetID.Value);
			}
			e.Handled = true;
		}

		private void btnViewTracking_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(_shipment.Tracking))
				ViewTracking?.Invoke(_shipment.URL_TrackingLink);
		}

		private void btnReady_Click(object sender, EventArgs e)
		{
			if (_shipment.IsReady)
			{
				var oldReadyDateTime = _shipment.ReadyDate;
				var readyCancelMessage = $"Shipment ready canceled (was {oldReadyDateTime:yyyy-MM-dd HH:mm})";
				var readyCancelMessageWithId = $"Shipment {_shipment.ID} ready canceled (was {oldReadyDateTime:yyyy-MM-dd HH:mm})";
				_shipment.CancelReady();
				ClassJournal.AddJournalEntry(_shipment, readyCancelMessage, null, true);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, readyCancelMessageWithId, null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject(readyCancelMessageWithId, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}
			else
			{
				_shipment.MarkAsReady();
				const string READY_MESSAGE = "Shipment ready";
				var readyMessageWithId = $"Shipment {_shipment.ID} ready";
				ClassJournal.AddJournalEntry(_shipment, READY_MESSAGE, null, true);
				foreach (var ticket in _ledger.Where(l => l.Ticket_ID.HasValue).Select(l => l.Ticket_ID.Value).Distinct().Select(ClassTicket.GetByID))
				{
					ClassJournal.AddJournalEntry(ticket, readyMessageWithId, null, true);
					if (ticket.IsHeld)
						ticket.Release();
				}
				ClassNotification.SendNotificationsForObject(readyMessageWithId, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
			}

			Shipment_Load(_shipment.ID);

			RefreshShipmentList?.Invoke();
		}

		private void btnJournal_Add_Click(object sender, EventArgs e)
		{
			if (_shipment == null || _shipment.ID < 0)
				return;

			using (var frmJournal = new FormJournal(_shipment, ClassShipment.MAX_JOURNAL_EXPIRATION, ClassJournal.ExpirationType.NotRequired))
			{
				if (frmJournal.ShowDialog(this) != DialogResult.OK)
					return;

				if (frmJournal.ReleaseHold)
					Shipment_Release();

				ClassJournal.AddJournalEntry(_shipment, frmJournal.JournalEntry);

				// Send notifications for shipment journal addition
				ClassNotification.SendNotificationsForObject(frmJournal.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);

				// Send notifications for shipment journal addition expiration
				if (frmJournal.JournalEntry.ExpireDateTime.HasValue)
					ClassNotification.SendNotificationsForObject("EXPIRED: " + frmJournal.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID, null, frmJournal.JournalEntry.ExpireDateTime.Value);
			}
			Shipment_Load(_shipment.ID);
		}

		/// <summary>
		/// Exports the specified shipment to an HTML file.
		/// </summary>
		private void ExportShipmentToFile(int shipmentID)
		{
			using (var saveDialog = new SaveFileDialog())
			{
				saveDialog.Title = "Save Shipment As...";
				saveDialog.DefaultExt = ".htm";
				saveDialog.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
				saveDialog.FileName = $"Shipment_{shipmentID}.htm";
				saveDialog.Filter = "HTML Files (*.htm)|*.htm";
				if (saveDialog.ShowDialog() != DialogResult.OK)
					return;

				var shipmentHtml = CreateHtmlForShipment(shipmentID);

				try
				{
					File.WriteAllText(saveDialog.FileName, shipmentHtml);
					Process.Start(saveDialog.FileName);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not save file, an error occurred: {0}{0}{1}", Environment.NewLine, exc.Message), "Error Exporting Shipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// Creates an HTML document with shipment details.
		/// </summary>
		private string CreateHtmlForShipment(int shipmentID)
		{
			var exportShipment = ClassShipment.GetByID(shipmentID);
			if (exportShipment == null)
				return string.Empty;
			var exportShipmentLedger = ClassShipment.GetInventory(shipmentID).ToList();
			var shipmentJournal = ClassJournal.GetByObject(exportShipment);

			var sb = new StringBuilder();
			sb.AppendFormat("<html><head><style>th {{ font-weight: bold; }} td {{ border: dotted 1px black; padding: 0 4px 0 4px; }} table {{ font-size: 10pt; }} hr {{ margin: 0px; }} h2,h3 {{ margin-bottom: 0px; }} @media print {{ .pbreak {{ page-break-after: auto }} }}</style><title>{0} Shipment {1}</title></head>", ClassConfig.GetMainCompany(), exportShipment.ID).AppendLine();
			sb.AppendLine("<body style='font-family: Arial, Helvetica, sans-serif;'>");

			sb.AppendFormat("<h2>Shipment {0}</h2>", exportShipment.ID).AppendLine();
			sb.AppendLine("<hr />");
			sb.AppendLine("<div style='margin-left: 2em;'>");
			sb.AppendFormat("<strong>Requested By:</strong> {0} on {1:yyyy-MM-dd}<br />", exportShipment.Requested_By, exportShipment.Requested_Date).AppendLine();
			sb.AppendFormat("<strong>Purchase Order:</strong> {0}<br />", exportShipment.Purchase_Order).AppendLine();
			sb.AppendFormat("<strong>Notes:</strong> {0}<br />", exportShipment.Notes).AppendLine();
			sb.AppendLine("</div>");

			sb.AppendLine("<h3>Destination</h3>");
			sb.AppendLine("<hr />");
			sb.AppendLine("<div style='margin-left: 2em;'>");
			sb.AppendFormat("<strong>Company:</strong> {0}<br />", exportShipment.Destination.Company).AppendLine();
			sb.AppendFormat("<strong>Attention:</strong> {0}<br />", exportShipment.Destination.Attention).AppendLine();
			sb.AppendFormat("<strong>Address:</strong> {0}<br />", exportShipment.Destination.Address.ReplaceNewLineWithBr()).AppendLine();
			sb.AppendFormat("<strong>City:</strong> {0}<br />", exportShipment.Destination.City).AppendLine();
			sb.AppendFormat("<strong>State:</strong> {0}<br />", exportShipment.Destination.State).AppendLine();
			sb.AppendFormat("<strong>Zip:</strong> {0}<br />", exportShipment.Destination.Zip).AppendLine();
			sb.AppendFormat("<strong>Country:</strong> {0}<br />", exportShipment.Destination.Country).AppendLine();
			sb.AppendFormat("<strong>Telephone:</strong> {0}<br />", exportShipment.Destination.Telephone).AppendLine();
			sb.AppendFormat("<strong>Address Type:</strong> {0}<br />", exportShipment.Destination.AddressType);
			sb.AppendFormat("<strong>Shipping Method:</strong> {0}<br />", exportShipment.ShipMethod_Name).AppendLine();
			sb.AppendLine("</div>");

			sb.AppendLine("<h3>Ledger</h3>");
			sb.AppendLine("<hr />");
			sb.AppendLine("<div style='margin-left: 2em;'>");
			sb.AppendLine("<table style='border: solid 1px black; border-collapse: collapse;'><tr><th>Qty</th><th>Description</th><th>RMA</th><th>Ticket</th><th>Asset</th><th>Job</th><th>S/N</th><th>Customs Desc.</th><th>Tariff Code</th></tr>");
			foreach (var item in exportShipmentLedger)
				sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td></tr>",
					item.Quantity,
					item.Description,
					item.RMA_ID,
					item.Ticket_ID,
					item.Asset_Name,
					item.Job_Number,
					item.Serial_Number,
					item.AssemblyType.CustomsDescription,
					item.AssemblyType.TariffCode);
			sb.AppendLine("</table>");
			sb.AppendLine("</div>");

			if (exportShipment.Picked_Date.HasValue)
			{
				sb.AppendLine("<h3>Fulfillment</h3>");
				sb.AppendLine("<hr />");
				sb.AppendLine("<div style='margin-left: 2em;'>");
				sb.AppendFormat("<strong>Ready At:</strong> {0:yyyy-MM-dd HH:mm}<br />", exportShipment.ReadyDate).AppendLine();
				sb.AppendFormat("<strong>Picked By:</strong> {0} on {1:yyyy-MM-dd}<br />", exportShipment.Picked_By, exportShipment.Picked_Date).AppendLine();
				if (exportShipment.Fulfilled_Date.HasValue)
				{
					sb.AppendFormat("<strong>Shipped By:</strong> {0} on {1:yyyy-MM-dd}<br />", exportShipment.Fulfilled_By, exportShipment.Fulfilled_Date).AppendLine();
					sb.AppendFormat("<strong>Packages:</strong> {0}, <strong>Weight:</strong> {1:0.0} lbs, <strong>Total Cost:</strong> ${2:0.00}, <strong>Insurance:</strong> ${3:0.00}<br />",
						exportShipment.Packages,
						exportShipment.Weight,
						exportShipment.Fulfillment_Cost,
						exportShipment.Insurance_Amount).AppendLine();
					sb.AppendFormat("<strong>Tracking:</strong> <a href=\"{0}\">{1}</a><br />", exportShipment.URL_TrackingLink, exportShipment.Tracking).AppendLine();
				}
				sb.AppendLine("</div>");
			}

			sb.AppendLine("<br class='pbreak' />");

			if (shipmentJournal.Count > 0)
			{
				sb.AppendLine("<h3>Journal</h3>");
				sb.AppendLine("<hr />");
				sb.AppendLine("<div style='margin-left: 2em;'>");
				sb.AppendLine("<table style='border: solid 1px black; border-collapse: collapse;'><tr><th>DateTime</th><th>User</th><th>Notes</th></tr>");
				foreach (var journalItem in shipmentJournal.Entries)
				{
					sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>",
						journalItem.JournalDateTime,
						journalItem.User_Name,
						journalItem.JournalText);
				}
				sb.AppendLine("</table>");
				sb.AppendLine("</div>");
			}
			sb.AppendLine("</body></html>");

			return sb.ToString();
		}

		/// <summary>
		/// Creates an HTML document for a shipment label.
		/// </summary>
		private string CreateHtmlForShipmentLabel(int shipmentID)
		{
			var shipment = ClassShipment.GetByID(shipmentID);
			if (shipment == null)
				return string.Empty;
			var ledger = ClassShipment.GetInventory(shipmentID).ToList();

			var sb = new StringBuilder();
			sb.AppendLine("<html>                                                                                         ");
			sb.AppendLine("	<head>                                                                                        ");
			sb.AppendFormat("		<title>{0} Shipment {1} Label</title>                                           ", ClassConfig.GetMainCompany(), shipment.ID).AppendLine();
			sb.AppendLine(@"		<style type=""text/css"">                                                             ");
			sb.AppendLine("			body                                                                                  ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				margin: 0.25in;                                                                   ");
			sb.AppendLine("				font-family: 'Consolas', 'Lucida Console', 'Helvetica', 'Arial', sans-serif;      ");
			sb.AppendLine("				font-size: 12pt;                                                                  ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			hr                                                                                    ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				margin: 0;                                                                        ");
			sb.AppendLine("				border: 0;                                                                        ");
			sb.AppendLine("				height: 2px;                                                                      ");
			sb.AppendLine("				background: black;                                                                ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#overall-border                                                                       ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				padding: 4px;                                                                     ");
			sb.AppendLine("				width: 5in;                                                                       ");
			sb.AppendLine("				height: 4.625in;                                                                  ");
			sb.AppendLine("				border: solid 4px black;                                                          ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#logo                                                                                 ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				float: left;                                                                      ");
			sb.AppendLine("				margin-right: 0.125in;                                                            ");
			sb.AppendLine("				width: 0.625in;                                                                   ");
			sb.AppendLine("				height: 0.625in;                                                                  ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#shipment-number                                                                      ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				margin: 0;                                                                        ");
			sb.AppendLine("				font-size: 64pt;                                                                  ");
			sb.AppendLine("				font-weight: bold;                                                                ");
			sb.AppendLine("				text-align: center;                                                               ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#return-address:first-line                                                            ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				font-weight: bold;                                                                ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#to                                                                                   ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				float: left;                                                                      ");
			sb.AppendLine("				width: 0.75in;                                                                    ");
			sb.AppendLine("				height: 1in;                                                                      ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#recipient-address:first-line                                                         ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				font-weight: bold;                                                                ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#rmas                                                                                 ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				float: left;                                                                      ");
			sb.AppendLine("				width: 0.75in;                                                                    ");
			sb.AppendLine("				height: 0.5in;                                                                    ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#rma-numbers                                                                          ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#jobs                                                                                 ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				float: left;                                                                      ");
			sb.AppendLine("				width: 0.75in;                                                                    ");
			sb.AppendLine("				height: 0.5in;                                                                    ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#job-numbers                                                                          ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("			#shipment-type                                                                        ");
			sb.AppendLine("			{                                                                                     ");
			sb.AppendLine("				height: 0.75in;                                                                   ");
			sb.AppendLine("				font-size: 48pt;                                                                  ");
			sb.AppendLine("				font-weight: bold;                                                                ");
			sb.AppendLine("				text-align: center;                                                               ");
			sb.AppendLine("			}                                                                                     ");
			sb.AppendLine("		</style>                                                                                  ");
			sb.AppendLine("	</head>                                                                                       ");
			sb.AppendLine("	<body>                                                                                        ");
			sb.AppendLine(@"		<div id=""overall-border"">                                                                 ");
			//var logoFile = new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Required Files", "prismview_icon_gs_256x256.png"));
			//sb.AppendFormat(@"			<img id=""logo"" src=""{0}"" />                                          ", logoFile).AppendLine();
			sb.AppendLine(@"			<div id=""return-address"">                                                             ");
			sb.AppendLine($"				{ClassConfig.GetServiceCompany()}<br />                                                      ");
			sb.AppendLine($"				{ClassConfig.GetServiceAddress()}<br />                                                               ");
			//sb.AppendLine($"				LOGAN UT 84321                                                                    ");
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine(@"			<hr style=""clear: both; margin-top: 0.125in;"" />                                      ");
			sb.AppendLine(@"			<div id=""shipment-number"">                                                            ");
			sb.AppendFormat("				{0}                                                                             ", shipment.ID).AppendLine();
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine("			<hr />                                                                                ");
			sb.AppendLine(@"			<div id=""to"">                                                                         ");
			sb.AppendLine("				TO:                                                                               ");
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine(@"			<div id=""recipient-address"">                                                          ");
			sb.AppendFormat("				{0}<br />                                                    ", shipment.Destination.Company).AppendLine();
			sb.AppendFormat("				{0}<br />                                                       ", shipment.Destination.Address.ReplaceNewLineWithBr()).AppendLine();
			sb.AppendFormat("				{0} {1} {2}<br />                                                            ", shipment.Destination.City, shipment.Destination.State, shipment.Destination.Zip).AppendLine();
			sb.AppendFormat("				{0}                                                                               ", shipment.Destination.Country).AppendLine();
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine(@"			<hr style=""clear: both;"" />                                                           ");

			var rmas = ledger.Where(l => l.RMA_ID.HasValue).Select(l => l.RMA_ID.GetValueOrDefault(0)).Distinct().ToArray();
			var rmaList = rmas.Any() ? string.Join(", ", rmas) : "NONE";
			sb.AppendLine(@"			<div id=""rmas"">                                                                       ");
			sb.AppendFormat("				RMA{0}:                                                                             ", rmas.Length.SIfPlural()).AppendLine();
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine(@"			<div id=""rma-numbers"">                                                                ");
			sb.AppendFormat("				{0}                                                                              ", rmaList).AppendLine();
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine(@"			<hr style=""clear: both;"" />                                                           ");
			sb.AppendLine(@"			<div id=""jobs"">                                                                       ");
			sb.AppendLine("				JOB#:                                                                             ");
			sb.AppendLine("			</div>                                                                                ");

			sb.AppendLine(@"			<div id=""job-numbers"">                                                                ");
			var jobs = ledger.Select(l => l.Job_Number).Distinct().ToArray();
			var jobList = jobs.Any() ? string.Join(", ", jobs) : "NONE";
			sb.AppendFormat("				{0}                                                                           ", jobList).AppendLine();
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine(@"			<hr style=""clear: both;"" />                                                           ");
			sb.AppendLine(@"			<div id=""shipment-type"">                                                              ");
			sb.AppendFormat("				{0}                                                                               ", shipment.ShipMethod_Abbreviation.ToUpper()).AppendLine();
			sb.AppendLine("			</div>                                                                                ");
			sb.AppendLine("		</div>                                                                                    ");
			sb.AppendLine("	</body>                                                                                       ");
			sb.AppendLine("</html>                                                                                        ");
			return sb.ToString();
		}

		private void Print(int shipmentID)
		{
			// Gray out form temporarily
			Enabled = false;
			using (var frmPrintOption = new FormShipmentPrintOption())
			{
				var result = frmPrintOption.ShowDialog(this);
				if (result != DialogResult.OK)
				{
					Enabled = true;
					return;
				}

				if (frmPrintOption.IsDetail)
					PrintShipmentDetail(shipmentID);
				else
					PrintShipmentLabel(shipmentID);
			}
			// Restore form color
			Enabled = true;
		}

		private void PrintShipmentDetail(int shipmentID)
		{
			// Get HTML version of shipment
			var shipmentHtml = CreateHtmlForShipment(shipmentID);

			// Use a web browser control to render HTML and print
			var wb = new WebBrowser
			         {
				         DocumentText = shipmentHtml
			         };
			wb.DocumentCompleted += wb_DocumentCompleted;
		}

		private void PrintShipmentLabel(int shipmentID)
		{
			// Get HTML version of label
			var shipmentLabelHtml = CreateHtmlForShipmentLabel(shipmentID);

			// Use a web broswer control to render HTML and print
			var wb = new WebBrowser
			         {
				         DocumentText = shipmentLabelHtml
			         };
			wb.DocumentCompleted += wb_DocumentCompleted;
		}

		private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			var wb = (WebBrowser)sender;
			wb.ShowPrintDialog();
			wb.Dispose();
		}

		private void olvLedger_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (!_shipment.IsReady)
				ShipmentDetail_EditSelectedItem();
		}

		private void olvLedger_CellToolTipShowing(object sender, BrightIdeasSoftware.ToolTipShowingEventArgs e)
		{
			if (e.Column != olvColLedger_Asset)
				return;

			var ledgerItem = (ClassShipment_Item)e.Model;
			if (!ledgerItem.Asset_ID.HasValue)
				return;

			var asset = ClassAsset.GetByID(ledgerItem.Asset_ID.Value);
			asset.PopulateExtraProperties();

			const int COLWIDTH = 16;
			var sb = new StringBuilder();
			sb.AppendFormat("{0} {1}", "Asset:".PadLeft(COLWIDTH), asset.AssetName).AppendLine();
			sb.AppendFormat("{0} {1}", "Panel:".PadLeft(COLWIDTH), asset.Panel).AppendLine();
			sb.AppendFormat("{0} {1}", "Location:".PadLeft(COLWIDTH), asset.Location + ClassUtility.StringFormatNull(" (Facing {0})", string.Empty, asset.FacingDirection)).AppendLine();
			sb.AppendFormat("{0} {1}", "City/State:".PadLeft(COLWIDTH), $"{asset.City}, {asset.State}, {asset.Country}").AppendLine();
			sb.AppendLine();
			sb.AppendFormat("{0} {1}", "Interfaces:".PadLeft(COLWIDTH), $"{asset.InterfaceQty}X {asset.InterfaceType}, chip: {asset.Chip_Type}").AppendLine();
			sb.AppendFormat("{0} {1}", "Matrix:".PadLeft(COLWIDTH), $"{asset.MatrixWidth}x{asset.MatrixHeight} {asset.Pitch}mm").AppendLine();
			sb.AppendFormat("{0} {1}", "Cabinet:".PadLeft(COLWIDTH), $"{asset.ExtraProperties.CabinetType} ({asset.FaceQty} face{asset.FaceQty.SIfPlural()}").AppendLine();
			sb.AppendFormat("{0} {1}", "Computer/Output:".PadLeft(COLWIDTH), $"{ControllerHardware.GetByID(asset.ControllerHardwareId)?.Description}, {asset.ExtraProperties.OutputMethod}").AppendLine();
			e.Text = sb.ToString();
		}

		private void ShipmentDetail_EditSelectedItem()
		{
			// If no item is selected, if the shipment has already been shipped, or if the shipment is marked "ready", do not allow item editing.
			if (olvLedger.SelectedItem == null || (_shipment.IsReady || _shipment.Fulfilled_Date.HasValue) && !_allowAdminEdit)
				return;

			using (var shipmentItemForm = new FormEpartItem((ClassShipment_Item)olvLedger.SelectedObject))
			{
				if (shipmentItemForm.ShowDialog() != DialogResult.OK)
					return;

				var newItem = new ClassShipment_Item
					              {
						              Quantity = shipmentItemForm.Quantity,
						              AssemblyType = shipmentItemForm.AssemblyType,
						              Assembly = shipmentItemForm.Assembly,
						              Asset_ID = shipmentItemForm.Asset?.ID,
						              Asset_Name = shipmentItemForm.Asset == null ? string.Empty : shipmentItemForm.Asset.AssetName,
						              Job_Number = shipmentItemForm.JobNumber,
						              Serial_Number = shipmentItemForm.SerialNumbers,
						              Ticket_ID = shipmentItemForm.TicketID,
						              RMA_ID = shipmentItemForm.RmaID,
						              ShipmentID = _shipment.ID
					              };

                //Add Journal Entry
                ClassJournal.AddJournalEntry(_shipment, GS.Settings.LoggedOnUser.FirstL + " CHANGED " + _ledger[olvLedger.SelectedIndex].Assembly.AssemblyNumber + " [x" + _ledger[olvLedger.SelectedIndex].Quantity + "] TO " + newItem.Assembly.AssemblyNumber + " [x" + newItem.Quantity + "]", null, true);

                if (newItem.Quantity == 1 || string.IsNullOrEmpty(newItem.Serial_Number))
				{
					// Replace ledger item that was originally selected
					_ledger[olvLedger.SelectedIndex] = newItem;
				}
				else
				{
					// Remove original item and add multiples in its place based on multiple items with serial numbers post-edit
					_ledger.RemoveAt(olvLedger.SelectedIndex);

					// Serial numbers should already be validated by FormShipmentItem
					var serials = newItem.Serial_Number.Split(',', ' ');
					for (var i = 0; i < newItem.Quantity; i++)
					{
						_ledger.Add(new ClassShipment_Item
						            {
							            Quantity = 1,
							            AssemblyType = newItem.AssemblyType,
							            Assembly = newItem.Assembly,
							            Asset_ID = newItem.Asset_ID,
							            Asset_Name = newItem.Asset_Name,
							            Job_Number = newItem.Job_Number,
							            Serial_Number = serials[i],
							            Ticket_ID = newItem.Ticket_ID,
							            RMA_ID = newItem.RMA_ID,
							            ShipmentID = _shipment.ID
						            });
					}
				}

				// Automatically update shipment if it has an ID
				if (_shipment.ID > 0)
					UpdateOrCreateShipment();
				else
					Populate_Ledger();
			}
		}

		private void RefreshDataBindings()
		{
			_ignoreStateChange = true;
			_shipmentMethods = ClassShipment_Method.GetAll().ToList();

			cmbShippingMethod.DataSource = new BindingSource { DataSource = _shipmentMethods };
			cmbShippingMethod.SelectedValue = _shipmentMethods.SingleOrDefault(s => s.Default);
			_ignoreStateChange = false;
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

		private void mnuCreate_Click(object sender, EventArgs e)
		{
			Shipment_Create();
		}

		private void mnuHoldRelease_Click(object sender, EventArgs e)
		{
			if (_shipment.IsOnHold)
				Shipment_Release();
			else
				Shipment_Hold();
		}

		private void mnuDeleteRestore_Click(object sender, EventArgs e)
		{
			Shipment_DeleteRestore();
		}

		private void mnuExport_Click(object sender, EventArgs e)
		{
			ExportShipmentToFile(_shipment.ID);
		}

		private void mnuPrint_Click(object sender, EventArgs e)
		{
			Print(_shipment.ID);
		}

		private void btnEditSave_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == Keys.Shift && GS.Settings.LoggedOnUser.IsAdmin)
			{
				_allowAdminEdit = true;
				Shipment_UnlockLedger();
			}
			else
				Shipment_EditSave();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Shipment_Cancel();
		}

		private void btnSelectTech_Click(object sender, EventArgs e)
		{
			using (var techList = new FormList_Techs())
			{
				if (techList.ShowDialog() != DialogResult.OK)
					return;

				SetShipmentDestinationToTech(techList.SelectedTech);
				Populate_AddressSection();

				_shipment.TechID = techList.SelectedTech.ID;
				btnSelectTech.BackColor = Color.LightGreen;

				_shipment.MarketID = null;
				btnSelectMarket.BackColor = SystemColors.Control;
				
				LockDestination(true);
			}
		}

		private void btnSelectMarket_Click(object sender, EventArgs e)
		{
			using (var marketList = new FormList_Markets())
			{
				if (marketList.ShowDialog() != DialogResult.OK)
					return;

				SetShipmentDestinationToMarket(marketList.SelectedMarket);
				Populate_AddressSection();
	
				_shipment.TechID = null;
				btnSelectTech.BackColor = SystemColors.Control;

				_shipment.MarketID = marketList.SelectedMarket.ID;
				btnSelectMarket.BackColor = Color.LightGreen;
				
				LockDestination(true);
			}
		}

		private void btnOtherAddressLookup_Click(object sender, EventArgs e)
		{
			using (var destList = new FormList_ShipmentDestinations())
			{
				if (destList.ShowDialog() != DialogResult.OK)
					return;

				var newDest = destList.SelectedDestination;
				txtDest_Company.Text = newDest.Company;
				txtDest_Attn.Text = newDest.Attention;
				txtDest_Address.Text = newDest.Address;
				txtDest_City.Text = newDest.City;
				txtDest_State.Text = newDest.State;
				txtDest_Zip.Text = newDest.Zip;
				txtDest_Country.Text = newDest.Country;
				txtDest_Telephone.Text = newDest.Telephone;
				_shipment.TechID = null;
				_shipment.MarketID = null;

				if (newDest.AddressType == ClassShipment.AddressTypeEnum.Residential)
					radAddressTypeResidence.Checked = true;
				else
					radAddressTypeBusiness.Checked = true;

				LockDestination(false);
				btnSelectMarket.BackColor = btnSelectTech.BackColor = SystemColors.Control;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			_shipment.TechID = null;
			btnSelectTech.BackColor = SystemColors.Control;
			_shipment.MarketID = null;
			btnSelectMarket.BackColor = SystemColors.Control;
			radAddressTypeBusiness.Checked = false;
			radAddressTypeResidence.Checked = false;
			foreach (var textBox in tabDestination.Controls.OfType<TextBox>())
				textBox.Clear();
			LockDestination(false);
		}

		/// <summary>
		/// Locks (or unlocks) destination text boxes to prevent editing after associating with tech or market.
		/// The attention field is always editable.
		/// </summary>
		private void LockDestination(bool isLocked)
		{
			foreach (var textBox in tabDestination.Controls.OfType<TextBox>().Where(textBox => textBox != txtDest_Attn))
				textBox.ReadOnly = isLocked;
			foreach (var radioButton in tabDestination.Controls.OfType<RadioButton>())
				radioButton.Enabled = !isLocked;
		}

		private void chkSubscribe_Click(object sender, EventArgs e)
		{
			if (_shipment == null || _shipment.ID <= 0)
				return;

			if (_ignoreStateChange)
				return;

			if (ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID))
			{
				ClassSubscription.Unsubscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				chkSubscribe.Checked = false;
			}
			else
			{
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Shipment, _shipment.ID);
				chkSubscribe.Checked = true;
			}
		}

		private void FormShipment_Editor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Escape)
				return;

			Close();
		}

		private void SetShipmentDestinationToTech(ClassTech tech)
		{
			_shipment.Destination.Company = tech.TechName;
			_shipment.Destination.Address = tech.Shipping_Address;
			_shipment.Destination.City = tech.Shipping_City;
			_shipment.Destination.State = tech.Shipping_State;
			_shipment.Destination.Zip = tech.Shipping_Zip;
			_shipment.Destination.Country = tech.Shipping_Country;
			_shipment.Destination.Telephone = tech.Telephone;
			radAddressTypeBusiness.Checked = true;
		}

		private void SetShipmentDestinationToMarket(ClassMarket market)
		{
			_shipment.Destination.Company = market.CustomerName;
			_shipment.Destination.Attention = $"{market.Name} Market";
			_shipment.Destination.Address = market.Address;
			_shipment.Destination.City = market.City;
			_shipment.Destination.State = market.State;
			_shipment.Destination.Zip = market.Zip;
			_shipment.Destination.Country = market.Country;
			_shipment.Destination.Telephone = market.Telephone;
			radAddressTypeBusiness.Checked = true;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Creates a new shipment, with the specified ticket and asset being default choices for item additions (but they can be changed).
		/// The specified tech will be the default destination, but can also be changed.
		/// </summary>
		public void CreateShipmentForTicket(int ticketID, int assetID, ClassTech tech)
		{
			_affinityTicketID = ticketID;
			_affinityAssetID = assetID;
			Shipment_Create(tech);
		}

		/// <summary>
		/// Creates a new shipment, with the specified asset being the default choice for item additions.
		/// </summary>
		public void CreateShipmentForAsset(int assetID)
		{
			_affinityAssetID = assetID;

			var assignedTechs = ClassTech.GetByAsset(assetID).ToList();
			if (!assignedTechs.Any())
				Shipment_Create();
			else
				Shipment_Create(assignedTechs.First());
		}

		public void CreateShipmentForTech(int techID)
		{
			Shipment_Create(ClassTech.GetByID(techID));
		}

		/// <summary>
		/// Creates a new shipment, using the RMA to specify default Asset, Ticket and Tech. Optionally imports shipment ledger from RMA Assembly List.
		/// </summary>
		public void CreateShipmentForRMA(int rmaID)
		{
			var rma = ClassRMA.GetRMA(rmaID);
			_affinityRmaID = rma.ID;
			_affinityAssetID = rma.AssetID;
			_affinityTicketID = rma.TicketID;
			Shipment_Create(ClassTech.GetByID(rma.TechID));
			if (MessageBox.Show("Do you want to import all RMA Assemblies into the Shipment Ledger?", "Import RMA Assemblies?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			var rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(rma.ID).ToList();

			if (rmaAssemblies.Any(ra => !ra.Assembly_ID.HasValue))
			{
				MessageBox.Show("One of the assemblies in the RMA to be imported only specifies an assembly type rather than a specific assembly. This may be due to a legacy RMA that predates version 1.8.2.0. Contact a supervisor.", "RMA Assembly Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var cancelImport = false;
			foreach (var rmaAssemblyGroup in rmaAssemblies.GroupBy(ra => ra.Assembly_ID))
			{
				// Check if assembly is disabled/replaced
				var assemblyType = ClassAssemblyType.GetByID(rmaAssemblyGroup.First().AssemblyType_ID);
				var assembly = ClassAssembly.GetByID(rmaAssemblyGroup.First().Assembly_ID.GetValueOrDefault());
				if (assembly.Disabled && assembly.ReplacedBy.HasValue)
				{
					// Disabled with Replacement
					var replacementAssembly = ClassAssembly.FindCurrentReplacement(assembly);
					var sb = new StringBuilder();
					sb.AppendLine("The RMA you are importing contains a disabled assembly.").AppendLine();
					sb.AppendFormat("Disabled: {0} ({1})", assembly.AssemblyNumber, assembly.Description).AppendLine();
					sb.AppendFormat("Replaced By: {0} ({1})", replacementAssembly.AssemblyNumber, replacementAssembly.Description).AppendLine();
					sb.AppendLine();
					sb.AppendLine("Do you want to import the replacement assembly? If you select 'No' the disabled assembly will be imported. If you select 'cancel' the import process will abort.");
					var result = MessageBox.Show(sb.ToString(), "Import Replacement Assembly?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
					switch (result)
					{
						case DialogResult.Yes:
							// Only the ID's need to be changed for the assembly type and assembly for ShipmentItem that follows.
							assemblyType = ClassAssemblyType.GetByID(replacementAssembly.AssemblyTypeID);
							assembly = replacementAssembly;
							break;

						case DialogResult.No:
							// No changes
							break;

						default:
							cancelImport = true;
							break;
					}
				}
				else if (assembly.Disabled)
				{
					// Disabled with No Replacement
					var sb = new StringBuilder();
					sb.AppendLine("The RMA you are importing contains a disabled assembly.").AppendLine();
					sb.AppendFormat("Disabled: {0} ({1})", assembly.AssemblyNumber, assembly.Description).AppendLine();
					sb.AppendLine();
					sb.AppendLine("Do you want to import the disabled assembly anyway?");
					var result = MessageBox.Show(sb.ToString(), "Import Disabled Assembly?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					switch (result)
					{
						case DialogResult.Yes:
							// No changes
							break;

						case DialogResult.No:
							continue;

						case DialogResult.Cancel:
							cancelImport = true;
							break;
					}
				}

				if (cancelImport)
					break;

				var shipmentItem = new ClassShipment_Item
				                   {
					                   Quantity = rmaAssemblies.Count(a => a.Assembly_ID == assembly.ID),
					                   AssemblyType = assemblyType,
					                   Assembly = assembly,
					                   Asset_ID = rma.AssetID,
					                   Asset_Name = rma.AssetName,
					                   Job_Number = rma.JobNumber,
					                   RMA_ID = rma.ID,
					                   Ticket_ID = rma.TicketID
				                   };
				_ledger.Add(shipmentItem);
			}
			Populate_Ledger();
		}

		/// <summary>
		/// Creates a new shipment without any specific asset, ticket, tech, or RMA preselected.
		/// </summary>
		public void CreateShipment()
		{
			Shipment_Create();
		}


        #endregion

        private void copyJobNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = (olvLedger.SelectedObject as ClassShipment_Item).Job_Number;

            Clipboard.SetText(s);

        }
    }
}