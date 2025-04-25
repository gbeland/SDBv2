using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.Admin;
using SDB.Forms.Customer;

namespace SDB.UserControls.Customer
{
	/// <summary>
	/// This class is for the Market/Customer tab UI. 
	/// </summary>
	public partial class CustomerEditor : UserControl
	{
		#region Private fields and constants
		private ClassCustomer _customer;
		private ClassMarket _market;
		private List<ClassMarket> _marketsList = new List<ClassMarket>();
		private enum EditorMode { Viewing, EditingMarket, AddingMarket, EditingCustomer, AddingCustomer };
		private EditorMode _currentEditorMode = EditorMode.Viewing;
		private ClassCustomer _previousClassCustomer;
		private ClassMarket _previousClassMarket;

		private const int _NOTES_TAB_INDEX = 0;
		private const int _ASSETS_TAB_INDEX = 1;
		private const int _TICKET_TAB_INDEX = 2;
		#endregion

		#region Delegates and Events
		public delegate void MarketEvent(ClassMarket market);
		public delegate void AssetEvent(int assetID);
		public delegate void TicketEvent(int ticketID);
		public delegate void UpdateEvent();

		/// <summary>
		/// Occurs when the usercontrol has successfully loaded a tech. The main program can use the event to populate headers or tab page text.
		/// </summary>
		public event MarketEvent MarketLoaded;
		public event UpdateEvent MarketUpdated;
		public event AssetEvent ViewAsset;
		public event TicketEvent ViewTicket;
		#endregion

		#region Public read-only static fields

		#endregion

		#region Constructors and the Finalizer
		public CustomerEditor()
		{
			InitializeComponent();
			InitializeListViews();
			pnlControl_Top.BackColor = GS.Settings.ControlBarColor;

			olvColTickets_Symptoms.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Symptoms(true);
			olvColTickets_Solutions.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Solutions();

		}

		#endregion 

		#region Actions

		/// <summary>
		/// Opens the automated email list box for adding and removing emails
		/// </summary>
		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_market == null)
				return;

			FormEmails_AutomatedEmailList emailListForm = new FormEmails_AutomatedEmailList(_market.Automated_Email_List);
			emailListForm.ShowDialog();
			_market.Automated_Email_List = emailListForm.EmailsList;
			ClassMarket.Update(_market);
		}

		private void customerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tsmiEditCustomer.Enabled = _customer != null;
			tsmiAddCustomerTag.Enabled = GS.Settings.LoggedOnUser.IsAdmin;
		}

		/// <summary>
		/// Market Email double click event opens a new email with the markets emails 
		/// </summary>
		private void Market_Email_DoubleClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_market?.Email_Addresses))
				return;

			const string SUBJECT = @"Prismview Service Message";
			Process.Start($"mailto:{_market.Email_Addresses}?subject={SUBJECT}");
		}

		/// <summary>
		/// Changes editor mode to add customer mode
		/// </summary>
		private void tsmiAddCustomer_Click(object sender, EventArgs e)
		{
			ChangeEditorMode(EditorMode.AddingCustomer);
		}

		/// <summary>
		/// Changes editor mode to edit customer
		/// </summary>
		private void tsmiEditCustomer_Click(object sender, EventArgs e)
		{
			ChangeEditorMode(EditorMode.EditingCustomer);
		}

		/// <summary>
		/// Changes editor mode to add market
		/// </summary>
		private void tsmiAddMarket_Click(object sender, EventArgs e)
		{
			ChangeEditorMode(EditorMode.AddingMarket);
		}

		/// <summary>
		/// Change editor mode to edit market
		/// </summary>
		private void tsmiEditMarket_Click(object sender, EventArgs e)
		{
			ChangeEditorMode(EditorMode.EditingMarket);
		}

		/// <summary>
		/// Handles the double click of a ticket item in the ticket list
		/// </summary>
		private void olvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvTickets.SelectedItem == null || ViewTicket == null)
				return;

			var selectedTicket = (ClassTicket)olvTickets.SelectedObject;
			ViewTicket(selectedTicket.ID);
		}

		/// <summary>
		/// Saves the new data (customer/market) and changes editor mode back to viewer. 
		/// </summary>
		private void btnSave_Click(object sender, EventArgs e)
		{
			_market.CustomerID = _customer.ID;
			if (!ValidateData())
				return;

			UpdateClassesFromFields();
			switch (_currentEditorMode)
			{
				case EditorMode.AddingCustomer:
					ClassCustomer.AddNew(ref _customer);
					MessageBox.Show("New Customer Added!", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;

				case EditorMode.AddingMarket:
					ClassMarket.AddNew(ref _market);
					MessageBox.Show("New Market Added!", "Market Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;

				case EditorMode.EditingCustomer:
					ClassCustomer.Update(_customer);
					break;

				case EditorMode.EditingMarket:
					ClassMarket.Update(_market);
					break;
			}
			MarketUpdated?.Invoke();
			ChangeEditorMode(EditorMode.Viewing);
		}

		/// <summary>
		/// Reverts any changes to the data back to the original
		/// </summary>
		private void btnCancel_Click(object sender, EventArgs e)
		{
			ResetPreviousClassObjects();
			ChangeEditorMode(EditorMode.Viewing);
		}

		/// <summary>
		/// Changes whether open or recently closed tickets are shown in ticket list
		/// </summary>
		private void radOpenTickets_Click(object sender, EventArgs e)
		{
			radOpenTickets.Checked = true;
			radClosedTickets.Checked = false;
			PopulateTickets();
		}

		/// <summary>
		/// Changes whether open or recently closed tickets are shown in ticket list
		/// </summary>
		private void radClosedTickets_Click(object sender, EventArgs e)
		{
			radOpenTickets.Checked = false;
			radClosedTickets.Checked = true;
			PopulateTickets();
		}

		/// <summary>
		/// Handles populating a tab on selection change for lazy loading to improve performance
		/// </summary>
		private void tabAdditionalInfo_SelectedIndexChanged(object sender, EventArgs e)
		{
			PopulateTab();
		}

		/// <summary>
		/// Opens the market list form and handles populating market on selection from form
		/// </summary>
		private void btnMarketList_Click(object sender, EventArgs e)
		{
			using (var marketSelect = new FormMarket_Select(_market?.ID))
			{
				if (marketSelect.ShowDialog(this) == DialogResult.OK)
					Market_Load(marketSelect.SelectedMarket);
			}
		}

		/// <summary>
		/// Handles subscribing or unsubscribing a user from a market
		/// </summary>
		private void chkSubscribe_CheckedChanged(object sender, EventArgs e)
		{
			if (_market == null || _customer == null)
				return;

			if (ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Market, _market.ID))
			{
				ClassSubscription.Unsubscribe(ClassSubscription.ObjectTypeEnum.Market, _market.ID);
				chkSubscribe.Checked = false;
			}
			else
			{
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Market, _market.ID, string.Format("{0}: {1}", _customer.Name, _market.Name).Truncate(64));
				chkSubscribe.Checked = true;
			}
		}

		/// <summary>
		/// Handles the clicking of the add customer menu strip item click
		/// </summary>
		private void tsmiAddCustomerTag_Click(object sender, EventArgs e)
		{
			using (var frmCustomerTags = new FormAdmin_AssetTags())
				frmCustomerTags.ShowDialog(this);
			RefreshView();
		}

		private void tsmiChangeCustomer_Click(object sender, EventArgs e)
		{
			using (var customerList = new Form_CustomerList())
			{
				var result = customerList.ShowDialog();
				if (result == DialogResult.OK)
				{
					_market.CustomerID = customerList.SelectedCustomer.ID;
					ClassMarket.Update(_market);
					Market_Load(_market.ID);
				}
			}
		}

		/// <summary>
		/// Disables reassign customer and add automated email if market is null
		/// </summary>
		private void tsmiMarketOptions_Click(object sender, EventArgs e)
		{
			//This probably should eventually be moved to their own function
			tsmiChangeCustomer.Enabled = _market != null;
			tsmiAdd.Enabled = _market != null;
			tsmiEditMarket.Enabled = _market != null;
			tsmiChangeCustomer.Enabled = GS.Settings.LoggedOnUser.IsAdmin;

			tsmiAddMarket.Enabled = _customer != null;
		}
		#endregion

		#region Public Functions
		/// <summary>
		/// Loads a market by its market ID
		/// </summary>
		public void Market_Load(int marketId)
		{
			Cursor = Cursors.WaitCursor;
			_market = ClassMarket.GetByID(marketId);
			_customer = ClassCustomer.GetByID(_market.CustomerID);
			Populate();
			_currentEditorMode = EditorMode.Viewing;
			Cursor = Cursors.Default;
		}

		/// <summary>
		/// Refreshes the market page
		/// </summary>
		public void RefreshView()
		{
			if (_market != null && _market.ID > 0)
				Market_Load(_market.ID);
		}

		/// <summary>
		/// Populates the market page with customer and market data
		/// </summary>
		public void Populate()
		{
			SuspendLayout();
			ClearAllControls();
			LockControls();
			ShowButtons(false);
			PopulateCustomerInformation();
			PopulateMarketInformation();
			LockEditAddBtns(false);
			ResumeLayout();
			MarketLoaded?.Invoke(_market);
		}

		/// <summary>
		/// Clears all the data from the page
		/// </summary>
		public void ClearAllControls()
		{
			txtCustomerName.Clear();
			txtCustomerId.Clear();
			cmbCustomerSSR.Text = string.Empty;
			cmbCustomerTag.Text = string.Empty;
			cmbCustomerStanding.Text = string.Empty;
			txtMarketName_1.Clear();
			txtMarketPosition_1.Clear();
			txtMarketNumber_1.Clear();
			txtMarketName_2.Clear();
			txtMarketPosition_2.Clear();
			txtMarketNumber_2.Clear();
			txtMarketName_3.Clear();
			txtMarketPosition_3.Clear();
			txtMarketNumber_3.Clear();
			txtMarketName.Clear();
			txtMarketId.Clear();
			chkTicketIsOpen.Checked = false;
			chkTicketIsClosed.Checked = false;
			chkTechOnsite.Checked = false;
			chkRMACreated.Checked = false;
			txtMarketEmails.Clear();
			txtMarketStreet.Clear();
			txtMarketCity.Clear();
			txtMarketState.Clear();
			txtMarketZip.Clear();
			txtMarketCountry.Clear();
			txtMarketPhone.Clear();
			cmbCustomerSalesperson.Text = string.Empty;
			txtSalespersonEmail.Clear();
			txtSalespersonPhone.Clear();
			txtMarketNotes.Clear();
			ucAssetList1.Clear();
			olvTickets.SetObjects(null);
		}
		#endregion

		#region Private Functions
		/// <summary>
		/// Inits the ticket list
		/// </summary>
		private void InitializeListViews()
		{
			olvTickets.PrimarySortColumn = olvColTickets_ID;
			olvTickets.PrimarySortOrder = SortOrder.Descending;
		}

		/// <summary>
		/// Populate the tab based on the selected tab to improve performance. 
		/// </summary>
		private void PopulateTab()
		{
			if (_market == null)
				return;

			switch (tabAdditionalInfo.SelectedIndex)
			{
				case _NOTES_TAB_INDEX:
					PopulateNotes();
					break;

				case _TICKET_TAB_INDEX:
					PopulateTickets();
					break;

				case _ASSETS_TAB_INDEX:
					PopulateAssets();
					break;
			}
		}

		/// <summary>
		/// Populate the asset list
		/// </summary>
		private void PopulateAssets()
		{
			var marketAssets = ClassAsset.GetByMarket(_market.ID).ToList();
			marketAssets.PopulateExtraProperties();
			ucAssetList1.SetObjects(marketAssets);
		}

		/// <summary>
		/// Populate the ticket list
		/// </summary>
		private void PopulateTickets()
		{
			if (radOpenTickets.Checked)
			{
				var openTickets = ClassTicket.GetByMarket(_market.ID, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held).ToList();
				openTickets.PopulateSymptomsAndSolutions();
				openTickets.PopulateExtraStrings();

				olvTickets.SetObjects(openTickets);
				txtTicketQty.Text = openTickets.Count.ToString();
			}
			else
			{
				var now = DateTime.Now;
				var oneYearAgo = now.AddYears(-1);
				var closedTickets = ClassTicket.GetByMarket(_market.ID, ClassTicket.TicketType.Closed).ToList();
				closedTickets.RemoveAll(t => t.CloseDateTime < oneYearAgo);
				closedTickets.PopulateSymptomsAndSolutions();
				closedTickets.PopulateExtraStrings();

				olvTickets.SetObjects(closedTickets);
				txtTicketQty.Text = closedTickets.Count().ToString();
			}
		}

		/// <summary>
		/// Populate the the notes tab
		/// </summary>
		private void PopulateNotes()
		{
			txtMarketNotes.Text = _market.Notes;
		}

		/// <summary>
		/// PopulateCustomerInformation takes the customerEditor's customer object and populates all of the relavent gui fields 
		/// </summary>
		private void PopulateCustomerInformation()
		{
			if (_customer == null)
				return;

			txtCustomerName.Text = _customer.Name;
			txtCustomerId.Text = _customer.Prefix;

			if (_customer.IsFrozen)
			{
				cmbCustomerStanding.Text = "Frozen";
				pnlCustomerInfo.BackColor = ClassCustomer.FROZEN_STANDING_COLOR;
				pnlMarketInfo.BackColor = ClassCustomer.FROZEN_STANDING_COLOR;
				pnlTechContacts.BackColor = ClassCustomer.FROZEN_STANDING_COLOR;
				grpMarketAddress.BackColor = ClassCustomer.FROZEN_STANDING_COLOR;
				BackColor = ClassCustomer.FROZEN_STANDING_COLOR;
			}
			else
			{
				cmbCustomerStanding.Text = "Good";
				pnlCustomerInfo.BackColor = ClassCustomer.GOOD_STANDING_COLOR;
				grpMarketAddress.BackColor = ClassCustomer.GOOD_STANDING_COLOR;
				pnlMarketInfo.BackColor = ClassCustomer.GOOD_STANDING_COLOR;
				pnlTechContacts.BackColor = ClassCustomer.GOOD_STANDING_COLOR;
				BackColor = ClassCustomer.GOOD_STANDING_COLOR;
			}

			var ssrList = ClassUser.GetSSRs().ToList();
			cmbCustomerSSR.DataSource = ssrList;
			cmbCustomerSSR.DisplayMember = "FirstLast";
			cmbCustomerSSR.ValueMember = "ID";
			if (_customer.AssignedSSR.HasValue)
				cmbCustomerSSR.SelectedValue = _customer.AssignedSSR.Value;
			else
				cmbCustomerSSR.SelectedIndex = -1;

			var tagList = ClassCustomerAssetTag.GetAll().ToList();
			cmbCustomerTag.DataSource = tagList;
			cmbCustomerTag.DisplayMember = "DisplayMember";
			cmbCustomerTag.ValueMember = "Id";
			if (_customer.AssetTag.HasValue)
				cmbCustomerTag.SelectedValue = _customer.AssetTag;
			else
				cmbCustomerTag.SelectedIndex = -1;
		}

		/// <summary>
		/// PopulateMarketInformation takes the CustomerEditor's market object and populates all of the relavent GUI fields. 
		/// @Author Tyler Aspinwall
		/// </summary>
		private void PopulateMarketInformation()
		{
			if (_market == null)
				return;

			chkSubscribe.Checked = ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Market, _market.ID);
			cmbCustomerSalesperson.DataSource = ClassSalesperson.GetSalespeople().ToList();
			cmbCustomerSalesperson.DisplayMember = "FullName";

			if (_market.SalespersonID != null)
			{
				var sp = ClassSalesperson.GetByID((int)_market.SalespersonID);
				cmbCustomerSalesperson.Text = sp.FullName;
				txtSalespersonEmail.Text = sp.Email;
				txtSalespersonPhone.Text = sp.Phone_Mobile;
			}

			txtMarketName.Text = _market.Name;
			txtMarketId.Text = _market.Prefix;

			chkTicketIsOpen.Checked = _market.SendEmail_Open;
			chkTicketIsClosed.Checked = _market.SendEmail_Close;
			chkTechOnsite.Checked = _market.SendEmail_TechOnSite;
			chkRMACreated.Checked = _market.SendEmail_RmaCreated;

			txtMarketStreet.Text = _market.Address;
			txtMarketCity.Text = _market.City;
			txtMarketZip.Text = _market.Zip;
			txtMarketState.Text = _market.State;
			txtMarketCountry.Text = _market.Country;
			txtMarketPhone.Text = _market.Telephone;

			txtMarketEmails.Text = _market.Email_Addresses;

			txtMarketName_2.Text = _market.Contact2_Name;
			txtMarketPosition_2.Text = _market.Contact2_Position;
			txtMarketNumber_2.Text = _market.Contact2_Number;

			txtMarketName_3.Text = _market.Contact3_Name;
			txtMarketPosition_3.Text = _market.Contact3_Position;
			txtMarketNumber_3.Text = _market.Contact3_Number;

			txtMarketName_1.Text = _market.Contact1_Name;
			txtMarketPosition_1.Text = _market.Contact1_Position;
			txtMarketNumber_1.Text = _market.Contact1_Number;

			PopulateTab();
		}

		/// <summary>
		/// Clear the controls related to the customer
		/// </summary>
		private void ClearCustomerControls()
		{
			txtCustomerName.Clear();
			txtCustomerId.Clear();
			cmbCustomerSSR.Text = string.Empty;
			cmbCustomerTag.Text = string.Empty;
			cmbCustomerStanding.Text = string.Empty;
		}

		/// <summary>
		/// Clear the controls related to the market
		/// </summary>
		private void ClearMarketControls()
		{
			txtMarketName_1.Clear();
			txtMarketPosition_1.Clear();
			txtMarketNumber_1.Clear();
			txtMarketName_2.Clear();
			txtMarketPosition_2.Clear();
			txtMarketNumber_2.Clear();
			txtMarketName_3.Clear();
			txtMarketPosition_3.Clear();
			txtMarketNumber_3.Clear();
			txtMarketName.Clear();
			txtMarketId.Clear();
			chkTicketIsOpen.Checked = false;
			chkTicketIsClosed.Checked = false;
			chkTechOnsite.Checked = false;
			chkRMACreated.Checked = false;
			txtMarketEmails.Clear();
			txtMarketStreet.Clear();
			txtMarketCity.Clear();
			txtMarketState.Clear();
			txtMarketZip.Clear();
			txtMarketCountry.Clear();
			txtMarketPhone.Clear();
			cmbCustomerSalesperson.Text = string.Empty;
			txtSalespersonEmail.Clear();
			txtSalespersonPhone.Clear();
			txtMarketNotes.Clear();
			ucAssetList1.Clear();
			olvTickets.SetObjects(null);
		}

		/// <summary>
		/// Lock or unlock all of the controls for editing
		/// </summary>
		private void LockControls(bool isLock = true)
		{
			txtCustomerName.ReadOnly = isLock;
			txtCustomerId.ReadOnly = isLock;
			cmbCustomerSSR.Enabled = !isLock;
			cmbCustomerTag.Enabled = !isLock;
			cmbCustomerStanding.Enabled = !isLock;
			txtMarketName_1.ReadOnly = isLock;
			txtMarketPosition_1.ReadOnly = isLock;
			txtMarketNumber_1.ReadOnly = isLock;
			txtMarketName_2.ReadOnly = isLock;
			txtMarketPosition_2.ReadOnly = isLock;
			txtMarketNumber_2.ReadOnly = isLock;
			txtMarketName_3.ReadOnly = isLock;
			txtMarketPosition_3.ReadOnly = isLock;
			txtMarketNumber_3.ReadOnly = isLock;
			txtMarketName.ReadOnly = isLock;
			txtMarketId.ReadOnly = isLock;
			chkTicketIsOpen.Enabled = !isLock;
			chkTicketIsClosed.Enabled = !isLock;
			chkTechOnsite.Enabled = !isLock;
			chkRMACreated.Enabled = !isLock;
			txtMarketEmails.ReadOnly = isLock;
			txtMarketStreet.ReadOnly = isLock;
			txtMarketCity.ReadOnly = isLock;
			txtMarketState.ReadOnly = isLock;
			txtMarketZip.ReadOnly = isLock;
			txtMarketCountry.ReadOnly = isLock;
			txtMarketPhone.ReadOnly = isLock;
			cmbCustomerSalesperson.Enabled = !isLock;
			txtMarketNotes.ReadOnly = isLock;
            btnEmailAdv.Enabled = !isLock;
		}

		/// <summary>
		/// Hide or show the cancel and save buttons
		/// </summary>
		private void ShowButtons(bool show)
		{
			btnCancel.Visible = show;
			btnSave.Visible = show;
		}

		/// <summary>
		/// Lock the menu strip items
		/// </summary>
		private void LockEditAddBtns(bool isLocked = false)
		{
			tsmiCustomerOptions.Enabled = !isLocked;
			tsmiMarketOptions.Enabled = !isLocked;
			btnMarketList.Enabled = !isLocked;
		}

		/// <summary>
		/// Takes the market page fields and inputs in object in case of cancel
		/// </summary>
		private void SetPreviousClassObjects()
		{
			_previousClassCustomer = _customer;
			_previousClassMarket = _market;
		}

		/// <summary>
		/// Reverts to the previous objects in case of cancel during edit
		/// </summary>
		private void ResetPreviousClassObjects()
		{
			_customer = _previousClassCustomer;
			_market = _previousClassMarket;
		}

		/// <summary>
		/// Loads an asset from asset list
		/// </summary>
		private void ucAssetList1_ViewAsset(int assetID)
		{
			ViewAsset?.Invoke(assetID);
		}

		/// <summary>
		/// Validate customer and market and outputs error messages
		/// </summary>
		private bool ValidateData()
		{
			if (string.IsNullOrEmpty(txtCustomerName.Text))
			{
				MessageBox.Show("Error: Invalid Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			if (string.IsNullOrEmpty(txtCustomerId.Text))
			{
				MessageBox.Show("Error: Invalid Customer Prefix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			if (string.IsNullOrEmpty(txtMarketName.Text))
			{
				MessageBox.Show("Error: Invalid Market Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			if (string.IsNullOrEmpty(txtMarketId.Text))
			{
				MessageBox.Show("Error: Invalid Market ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			if (_market.CustomerID == -1) //if not linked to customer send error message and return
			{
				MessageBox.Show("Error: Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			txtMarketEmails.Text = txtMarketEmails.Text.Replace(" ", string.Empty).Trim();
			if (string.IsNullOrWhiteSpace(txtMarketEmails.Text))
				return true;

			var addresses = txtMarketEmails.Text.Split(',');
			if (addresses.Any(a => !ClassUtility.ValidateEmailAddress(a)))
			{
				MessageBox.Show("Error: Invalid Emails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		/// <summary>
		/// Update the the market and customer objects with new data
		/// </summary>
		private void UpdateClassesFromFields()
		{
			_customer.Name = txtCustomerName.Text;
			_customer.Prefix = txtCustomerId.Text;

			if (cmbCustomerTag.SelectedIndex >= 0)
				_customer.AssetTag = (int?)cmbCustomerTag.SelectedValue;
			else
				_customer.AssetTag = null;

			if (cmbCustomerSSR.SelectedIndex >= 0)
				_customer.AssignedSSR = (int?)cmbCustomerSSR.SelectedValue;
			else
				_customer.AssignedSSR = null;

			_customer.IsFrozen = cmbCustomerStanding.Text != "Good";

			_market.Contact1_Name = txtMarketName_1.Text;
			_market.Contact1_Position = txtMarketPosition_1.Text;
			_market.Contact1_Number = txtMarketNumber_1.Text;

			_market.Contact2_Name = txtMarketName_2.Text;
			_market.Contact2_Position = txtMarketPosition_2.Text;
			_market.Contact2_Number = txtMarketNumber_2.Text;

			_market.Contact3_Name = txtMarketName_3.Text;
			_market.Contact3_Position = txtMarketPosition_3.Text;
			_market.Contact3_Number = txtMarketNumber_3.Text;

			_market.Name = txtMarketName.Text;
			_market.Prefix = txtMarketId.Text;

			_market.SendEmail_Open = chkTicketIsOpen.Checked;
			_market.SendEmail_Close = chkTicketIsClosed.Checked;
			_market.SendEmail_TechOnSite = chkTechOnsite.Checked;
			_market.SendEmail_RmaCreated = chkRMACreated.Checked;

			_market.Email_Addresses = txtMarketEmails.Text.Trim().ToLower(CultureInfo.InvariantCulture).Replace(" ", string.Empty).Replace(",", ", ");
			_market.Address = txtMarketStreet.Text;
			_market.City = txtMarketCity.Text;
			_market.State = txtMarketState.Text;
			_market.Zip = txtMarketZip.Text;
			_market.Country = txtMarketCountry.Text;
			_market.Telephone = txtMarketPhone.Text;

			var sp = ClassSalesperson.GetSalespeople().FirstOrDefault(salesperson => salesperson.FullName == cmbCustomerSalesperson.Text);
			if (sp != null)
				_market.SalespersonID = sp.ID;

			_market.Notes = txtMarketNotes.Text;
		}

		/// <summary>
		/// Changes the editor mode of the page and locks irrelavent controls
		/// </summary>
		private void ChangeEditorMode(EditorMode mode)
		{
			_currentEditorMode = mode;
			switch (mode)
			{
				case EditorMode.AddingMarket:
					SetPreviousClassObjects();
					_market = new ClassMarket();
					LockControls(false);
					txtCustomerName.ReadOnly = true;
					txtCustomerId.ReadOnly = true;
					cmbCustomerSSR.Enabled = false;
					cmbCustomerTag.Enabled = false;
					cmbCustomerStanding.Enabled = false;
					txtSalespersonEmail.Clear();
					txtSalespersonPhone.Clear();
					LockEditAddBtns(true);
                    btnEmailAdv.Enabled = false;
                    ClearMarketControls();
					ShowButtons(true);
					break;

				case EditorMode.AddingCustomer:
					SetPreviousClassObjects();
					_customer = new ClassCustomer();
					_market = new ClassMarket();
					ClearAllControls();
					LockControls(false);
					LockEditAddBtns(true);
					ShowButtons(true);
					break;

				case EditorMode.EditingMarket:
					SetPreviousClassObjects();
					LockEditAddBtns(true);
					ShowButtons(true);
					LockControls(false);
					txtCustomerName.ReadOnly = true;
					txtCustomerId.ReadOnly = true;
					cmbCustomerSSR.Enabled = false;
					cmbCustomerTag.Enabled = false;
                    btnEmailAdv.Enabled = true;
                    cmbCustomerStanding.Enabled = false;
					txtSalespersonEmail.Clear();
					txtSalespersonPhone.Clear();
					break;

				case EditorMode.EditingCustomer:
					SetPreviousClassObjects();
					ShowButtons(true);
					LockEditAddBtns(true);
                    //unlocking customer fields only
                    btnEmailAdv.Enabled = true;
                    txtCustomerName.ReadOnly = false;
					txtCustomerId.ReadOnly = false;
					cmbCustomerSSR.Enabled = true;
					cmbCustomerTag.Enabled = true;
					cmbCustomerStanding.Enabled = true;
					break;

				case EditorMode.Viewing:
				default:
					LockControls();
					ShowButtons(false);
                    btnEmailAdv.Enabled = false;
                    LockEditAddBtns();
					Populate();
					break;
			}
		}
        #endregion

        private void btnEmailAdv_Click(object sender, EventArgs e)
        {
            using( FormCustomerAdvancedEmail _form = new FormCustomerAdvancedEmail(_market.ID))
            {
                _form.ShowDialog();
            }
        }
    }
}