using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Shipments;
using SDB.Classes.Tech;

namespace SDB.Forms.Shipment
{
	public partial class FormShipment_List : Form
	{
		#region Delegates and Events
		public delegate void ItemIDEvent(int itemID);
		public delegate void TrackingEvent(string trackingURL);
		public delegate void CreateShipmentEvent();

		public event TrackingEvent ViewTracking;
		public event ItemIDEvent ViewShipment;
		public event CreateShipmentEvent CreateShipment;
		#endregion

		#region Private Vars
		private enum SearchModeEnum
		{
			Shipment,
			JobNumber,
			RMANumber,
			Asset,
			Customer,
			Tech,
			Other,
			AssemblyType,
			Date
		};

		private SearchModeEnum _searchMode;

		private enum ListModeEnum
		{
			Requested,
			OnHold,
			Ready,
			Picked,
			Shipped,
			Deleted,
			SearchResults
		};

		private ListModeEnum _listMode;

		private List<ClassCustomer> _customers = new List<ClassCustomer>();
		private List<ClassAsset> _assets = new List<ClassAsset>();
		private List<ClassTech> _techs = new List<ClassTech>();

		private List<ClassShipment> _shipmentListSearchResults = new List<ClassShipment>();

		private List<ClassAssemblyType> _assemblyTypes = new List<ClassAssemblyType>();

		private const int _MAX_RESULTS_PER_PAGE = 1000;
		private int _page;
		private int _maxPage;
		private int _shipmentCount;
		private bool _ignoreStateChange;
		#endregion

		public FormShipment_List()
		{
			InitializeComponent();

			olvColHasComputer.AspectGetter = value => ((ClassShipment)value).HasComputer;
			olvColHasComputer.AspectToStringConverter = value => string.Empty;
			olvColHasComputer.ImageGetter = value => ((ClassShipment)value).HasComputer ? "computer" : "none";

			olvColReadJournal.AspectGetter = value => ((ClassShipment)value).HasNonSystemInfo;
			olvColReadJournal.AspectToStringConverter = value => string.Empty;
			olvColReadJournal.ImageGetter = value => ((ClassShipment)value).HasNonSystemInfo ? "flag" : "none";

			olvShippingResultsList.PrimarySortColumn = olvColRequestDate;
			olvShippingResultsList.PrimarySortOrder = SortOrder.Ascending;

			// Bind customer selectors
			cmbSearch_Customer.ValueMember = "ID";
			cmbSearch_Customer.DisplayMember = "DisplayMember";

			// Bind asset selectors
			cmbSearch_Asset.ValueMember = "ID";
			cmbSearch_Asset.DisplayMember = "DisplayMember";

			// Bind tech selectors
			cmbSearch_Tech.ValueMember = "ID";
			cmbSearch_Tech.DisplayMember = "TechName";

			// Bind assembly type selectors
			cmbSearch_AssemblyType.ValueMember = "ID";
			cmbSearch_AssemblyType.DisplayMember = "DisplayMember";
		}

		private void FormShipment_List_Load(object sender, EventArgs e)
		{
			WindowState = GS.Settings.WindowState_Shipment_List;
			Location = GS.Settings.Location_Shipment_List;
		}

		private void FormShipment_List_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}

		private void FormShipment_List_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}

		private void RefreshCustomerDataBinding()
		{
			Cursor = Cursors.WaitCursor;
			_customers = ClassCustomer.GetCustomers().ToList();
			cmbSearch_Customer.DataSource = new BindingSource { DataSource = _customers };
			Cursor = Cursors.Default;
		}

		private void RefreshAssetDataBinding()
		{
			Cursor = Cursors.WaitCursor;
			_assets = ClassAsset.GetAll(null, int.MaxValue, out var _).ToList();
			cmbSearch_Asset.DataSource = new BindingSource { DataSource = _assets };
			Cursor = Cursors.Default;
		}

		private void RefreshTechDataBinding()
		{
			Cursor = Cursors.WaitCursor;
			_techs = ClassTech.GetAll().ToList();
			cmbSearch_Tech.DataSource = new BindingSource { DataSource = _techs };
			Cursor = Cursors.Default;
		}

		private void RefreshAssemblyTypeDataBinding()
		{
			Cursor = Cursors.WaitCursor;
			_assemblyTypes = ClassAssemblyType.GetAll().ToList();
			cmbSearch_AssemblyType.DataSource = new BindingSource { DataSource = _assemblyTypes };
			Cursor = Cursors.Default;
		}

		private void FormShipment_List_FormClosing(object sender, FormClosingEventArgs e)
		{
			GS.Settings.WindowState_Shipment_List = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_Shipment_List = Location;
			Hide();
			e.Cancel = true;
		}

		private void tabShipping_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabShipping.SelectedTab == tabSearch)
				Search_SetShow();

			pnlControl_Bottom.Visible = (tabShipping.SelectedTab == tabList);
		}

		#region SEARCH
		private void radSearch_CheckedChanged(object sender, EventArgs e)
		{
			Search_SetShow();
		}

		/// <summary>
		/// Sets the search mode and invokes Search_ShowFields which shows/hides relevant form controls.
		/// </summary>
		private void Search_SetShow()
		{
			if (radSearch_ShipmentNumber.Checked)
				_searchMode = SearchModeEnum.Shipment;
			if (radSearch_JobNumber.Checked)
				_searchMode = SearchModeEnum.JobNumber;
			if (radSearch_RMANumber.Checked)
				_searchMode = SearchModeEnum.RMANumber;
			if (radSearch_Asset.Checked)
				_searchMode = SearchModeEnum.Asset;
			if (radSearch_Customer.Checked)
				_searchMode = SearchModeEnum.Customer;
			if (radSearch_Tech.Checked)
				_searchMode = SearchModeEnum.Tech;
			if (radSearch_Other.Checked)
				_searchMode = SearchModeEnum.Other;
			if (radSearch_AssemblyType.Checked)
				_searchMode = SearchModeEnum.AssemblyType;
			if (radSearch_DateRange.Checked)
				_searchMode = SearchModeEnum.Date;

			Search_ShowFields();

			switch (_searchMode)
			{
				case SearchModeEnum.Shipment:
					txtSearch_Shipment.SelectAll();
					txtSearch_Shipment.Select();
					break;

				case SearchModeEnum.JobNumber:
					txtSearch_JobNumber.SelectAll();
					txtSearch_JobNumber.Select();
					break;

				case SearchModeEnum.RMANumber:
					txtSearch_RMANumber.SelectAll();
					txtSearch_RMANumber.Select();
					break;

				case SearchModeEnum.Asset:
					RefreshAssetDataBinding();
					cmbSearch_Asset.Select();
					break;

				case SearchModeEnum.Customer:
					RefreshCustomerDataBinding();
					cmbSearch_Customer.Select();
					break;

				case SearchModeEnum.Tech:
					RefreshTechDataBinding();
					cmbSearch_Tech.Select();
					break;

				case SearchModeEnum.Other:
					txtSearch_Other.SelectAll();
					txtSearch_Other.Select();
					break;

				case SearchModeEnum.AssemblyType:
					RefreshAssemblyTypeDataBinding();
					cmbSearch_AssemblyType.Select();
					break;

				case SearchModeEnum.Date:
					dtpSearch_From.Select();
					break;
			}

		}

		/// <summary>
		/// Shows the search button and the input fields for selected search mode.
		/// </summary>
		private void Search_ShowFields()
		{
			btnSearch.Visible = true;
			txtSearch_Shipment.Visible = _searchMode == SearchModeEnum.Shipment;
			txtSearch_JobNumber.Visible = _searchMode == SearchModeEnum.JobNumber;
			txtSearch_RMANumber.Visible = _searchMode == SearchModeEnum.RMANumber;
			cmbSearch_Asset.Visible = _searchMode == SearchModeEnum.Asset;
			cmbSearch_Customer.Visible = _searchMode == SearchModeEnum.Customer;
			chkSearch_AllMarkets.Visible = _searchMode == SearchModeEnum.Customer;
			cmbSearch_Market.Visible = _searchMode == SearchModeEnum.Customer;
			cmbSearch_Tech.Visible = _searchMode == SearchModeEnum.Tech;
			txtSearch_Other.Visible = _searchMode == SearchModeEnum.Other;
			cmbSearch_AssemblyType.Visible = _searchMode == SearchModeEnum.AssemblyType;
			pnlSearch_DateRange.Visible = _searchMode == SearchModeEnum.Date;
		}

		private void cmbSearch_Customer_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbSearch_Market.ValueMember = "ID";
			cmbSearch_Market.DisplayMember = "DisplayMember";
			cmbSearch_Market.DataSource = ((ClassCustomer)cmbSearch_Customer.SelectedItem).Markets;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.WaitCursor;
				switch (_searchMode)
				{
					case SearchModeEnum.Shipment:
						if (int.TryParse(txtSearch_Shipment.Text, out var shipmentNumber))
							SearchByShipment(shipmentNumber);
						else
							MessageBox.Show("Invalid Shipment Number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						break;

					case SearchModeEnum.JobNumber:
						SearchByJobNumber(txtSearch_JobNumber.Text);
						break;

					case SearchModeEnum.RMANumber:
						if (int.TryParse(txtSearch_RMANumber.Text, out var rmaNumber))
							SearchByRMA(rmaNumber);
						else
							MessageBox.Show("Invalid RMA Number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						break;

					case SearchModeEnum.Asset:
						SearchByAsset((ClassAsset)cmbSearch_Asset.SelectedItem);
						break;

					case SearchModeEnum.Customer:
						if (chkSearch_AllMarkets.Checked)
							SearchByCustomer((ClassCustomer)cmbSearch_Customer.SelectedItem);
						else
							SearchByMarket((ClassCustomer)cmbSearch_Customer.SelectedItem, (int)cmbSearch_Market.SelectedValue);
						break;

					case SearchModeEnum.Tech:
						SearchByTech((ClassTech)cmbSearch_Tech.SelectedItem);
						break;

					case SearchModeEnum.Other:
						SearchByOtherDestination(txtSearch_Other.Text.Trim());
						break;

					case SearchModeEnum.AssemblyType:
						SearchByAssemblyType((ClassAssemblyType)cmbSearch_AssemblyType.SelectedItem);
						break;

					case SearchModeEnum.Date:
						if (dtpSearch_From.Value <= dtpSearch_To.Value)
							SearchByDateRange(dtpSearch_From.Value, dtpSearch_To.Value, chkDateRange_Requested.Checked, chkDateRange_Shipped.Checked);
						else
							MessageBox.Show("Invalid date range.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						break;
				}
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Searches shipments by shipment number.
		/// </summary>
		private void SearchByShipment(int shipmentNumber)
		{
			var shipment = ClassShipment.GetByID(shipmentNumber);
			if (shipment == null)
			{
				MessageBox.Show($"Sorry, shipment number {shipmentNumber} was not found.", "Shipment Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSearch_Shipment.SelectAll();
				txtSearch_Shipment.Select();
				return;
			}

			//PopulateSearchResults(new List<ClassShipment> {shipment});

			ViewShipment?.Invoke(shipment.ID);
		}

		/// <summary>
		/// Searches shipments by job number (parts warranty/contract on the asset).
		/// </summary>
		private void SearchByJobNumber(string jobNumber)
		{
			var shipments = ClassShipment.GetListByJobNumber(jobNumber);
			if (shipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments found for job number (parts warranty/contract) {jobNumber}.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(shipments);
		}

		/// <summary>
		/// Searches shipments by RMA number.
		/// </summary>
		private void SearchByRMA(int rmaNumber)
		{
			var shipments = ClassShipment.GetListByLegacyRMA(rmaNumber);
			if (shipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments for RMA number {rmaNumber} were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(shipments);
		}

		/// <summary>
		/// Searches shipments by asset ID.
		/// </summary>
		private void SearchByAsset(ClassAsset asset)
		{
			var shipments = ClassShipment.GetListByAsset(asset.ID);
			if (shipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments for Asset '{asset.AssetName}' were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(shipments);
		}

		/// <summary>
		/// Searches shipments by Tech ID.
		/// </summary>
		private void SearchByTech(ClassTech tech)
		{
			var shipments = ClassShipment.GetListByTech(tech.ID);
			if (shipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments for {tech.TechName} were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(shipments);
		}

		/// <summary>
		/// Searches shipments by customer (all markets).
		/// </summary>
		private void SearchByCustomer(ClassCustomer customer)
		{
			var customerShipments = ClassShipment.GetListByCustomer(customer.ID);
			if (customerShipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments for {customer.Name} were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(customerShipments);
		}

		/// <summary>
		/// Searches shipments by customer market (market ID).
		/// </summary>
		private void SearchByMarket(ClassCustomer customer, int marketID)
		{
			var marketShipments = ClassShipment.GetListByMarket(marketID);
			if (marketShipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments for {customer.Name}: {customer.Market(marketID).Name} were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(marketShipments);
		}

		/// <summary>
		/// Searches shipments for other/alternate destination company, address, etc.
		/// </summary>
		private void SearchByOtherDestination(string otherText)
		{
			var otherShipments = ClassShipment.Search(otherText);
			if (otherShipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments for '{otherText}' were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(otherShipments);
		}

		/// <summary>
		/// Searches for shipments that contain the specified assembly type.
		/// </summary>
		/// <param name="assemblyType"></param>
		private void SearchByAssemblyType(ClassAssemblyType assemblyType)
		{
			var assyShipments = ClassShipment.GetListByAssemblyType(assemblyType.ID);
			if (assyShipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments containing {assemblyType.Description} were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(assyShipments);
		}

		/// <summary>
		/// Searches shipments by request date within a range.
		/// </summary>
		/// <param name="dtFrom">The start of the date range. (Time is automatically set to 0:00:00.)</param>
		/// <param name="dtTo">The end of the date range. (Time is automatically set to 23:59:59.)</param>
		/// <param name="useRequestDate">Search shipment request dates.</param>
		/// <param name="useShipDate">Search shipment shipped dates.</param>
		private void SearchByDateRange(DateTime dtFrom, DateTime dtTo, bool useRequestDate, bool useShipDate)
		{
			var shipments = ClassShipment.GetListByDateRange(dtFrom, dtTo, useRequestDate, useShipDate);
			if (shipments.Count < 1)
			{
				MessageBox.Show($"Sorry, no shipments requested from {dtFrom:yyyy-MM-dd} to {dtTo:yyyy-MM-dd} (inclusive) were found.", "No Shipments Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(shipments);
		}

		/// <summary>
		/// Populates the list with Shipments results from searching and selects the list tab.
		/// </summary>
		private void PopulateSearchResults(List<ClassShipment> shipments)
		{
			_shipmentListSearchResults = shipments;
			Shipments_List_SearchResults();
		}

		private void Search_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnSearch;
			if (!(sender is TextBox n))
				return;
			n.SelectAll();
		}

		private void Search_Leave(object sender, EventArgs e)
		{
			AcceptButton = null;
		}

		private void chkDateRange_Requested_CheckedChanged(object sender, EventArgs e)
		{
			if (!chkDateRange_Requested.Checked)
				chkDateRange_Shipped.Checked = true;
		}

		private void chkDateRange_Shipped_CheckedChanged(object sender, EventArgs e)
		{
			if (!chkDateRange_Shipped.Checked)
				chkDateRange_Requested.Checked = true;
		}

		private void chkSearch_AllMarkets_CheckedChanged(object sender, EventArgs e)
		{
			cmbSearch_Market.Visible = !chkSearch_AllMarkets.Checked;
		}
		#endregion

		#region LIST
		private void radList_Requested_Click(object sender, EventArgs e)
		{
			_listMode = ListModeEnum.Requested;
			ResetPageIfNotAlreadyChecked(radList_Requested);
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}

		private void radList_OnHold_Click(object sender, EventArgs e)
		{
			_listMode = ListModeEnum.OnHold;
			ResetPageIfNotAlreadyChecked(radList_OnHold);
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}

		private void radList_Ready_Click(object sender, EventArgs e)
		{
			_listMode = ListModeEnum.Ready;
			ResetPageIfNotAlreadyChecked(radList_Ready);
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}

		private void radList_Shipped_Click(object sender, EventArgs e)
		{
			_listMode = ListModeEnum.Shipped;
			ResetPageIfNotAlreadyChecked(radList_Shipped);
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}

		private void radList_Picked_Click(object sender, EventArgs e)
		{
			_listMode = ListModeEnum.Picked;
			ResetPageIfNotAlreadyChecked(radList_Picked);
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}
		
		private void radList_Deleted_Click(object sender, EventArgs e)
		{
			_listMode = ListModeEnum.Deleted;
			ResetPageIfNotAlreadyChecked(radList_Deleted);
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}

		private void btnList_Refresh_Click(object sender, EventArgs e)
		{
			Shipments_List_Populate();
		}

		private void MarkListRadioButton()
		{
			switch (_listMode)
			{
				case ListModeEnum.Requested:
					radList_Requested.Checked = true;
					break;

				case ListModeEnum.OnHold:
					radList_OnHold.Checked = true;
					break;

				case ListModeEnum.Ready:
					radList_Ready.Checked = true;
					break;

				case ListModeEnum.Picked:
					radList_Picked.Checked = true;
					break;

				case ListModeEnum.Shipped:
					radList_Shipped.Checked = true;
					break;

				case ListModeEnum.Deleted:
					radList_Deleted.Checked = true;
					break;

				default:
					foreach (var rb in pnlList_Control.Controls.OfType<RadioButton>())
						rb.Checked = false;
					break;
			}
		}

		private void SetShipmentCount()
		{
			switch (_listMode)
			{
				case ListModeEnum.Requested:
					_shipmentCount = ClassShipment.GetRequestedCount();
					break;

				case ListModeEnum.OnHold:
					_shipmentCount = ClassShipment.GetOnHoldCount();
					break;

				case ListModeEnum.Ready:
					_shipmentCount = ClassShipment.GetReadyCount();
					break;

				case ListModeEnum.Picked:
					_shipmentCount = ClassShipment.GetPickedCount();
					break;

				case ListModeEnum.Shipped:
					_shipmentCount = ClassShipment.GetShippedCount();
					break;

				case ListModeEnum.Deleted:
					_shipmentCount = ClassShipment.GetDeletedCount();
					break;

				case ListModeEnum.SearchResults:
					_shipmentCount = _shipmentListSearchResults.Count;
					break;
			}
		}

		private IEnumerable<ClassShipment> GetShipmentList()
		{
			var shipmentList = new List<ClassShipment>();
			switch (_listMode)
			{
				case ListModeEnum.Requested:
					shipmentList = ClassShipment.GetRequestedList(_page, _MAX_RESULTS_PER_PAGE);
					break;

				case ListModeEnum.OnHold:
					shipmentList = ClassShipment.GetOnHoldList(_page, _MAX_RESULTS_PER_PAGE);
					break;

				case ListModeEnum.Ready:
					shipmentList = ClassShipment.GetReadyList(_page, _MAX_RESULTS_PER_PAGE);
					break;

				case ListModeEnum.Picked:
					shipmentList = ClassShipment.GetPickedList(_page, _MAX_RESULTS_PER_PAGE);
					break;

				case ListModeEnum.Shipped:
					shipmentList = ClassShipment.GetShippedList(_page, _MAX_RESULTS_PER_PAGE);
					break;

				case ListModeEnum.Deleted:
					shipmentList = ClassShipment.GetDeletedList(_page, _MAX_RESULTS_PER_PAGE);
					break;

				case ListModeEnum.SearchResults:
					shipmentList = _shipmentListSearchResults;
					break;
			}
			return shipmentList;
		}

		private void Shipments_List_Populate()
		{
			try
			{
				Cursor = Cursors.WaitCursor;
				tabShipping.SelectedTab = tabList;
				SetShipmentCount();
				HandlePagination();
				SetColumnVisibilityBasedOnMode();
				olvShippingResultsList.SetObjects(GetShipmentList());
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void SetColumnVisibilityBasedOnMode()
		{
			foreach (var col in olvShippingResultsList.AllColumns)
				col.IsVisible = true;

			switch (_listMode)
			{
				case ListModeEnum.Requested:
					olvColReadyDate.IsVisible = false;
					olvColPicked.IsVisible = false;
					olvColShipped.IsVisible = false;
					olvColTracking.IsVisible = false;
					break;

				case ListModeEnum.Ready:
					olvColPicked.IsVisible = false;
					olvColShipped.IsVisible = false;
					olvColTracking.IsVisible = false;
					break;

				case ListModeEnum.Picked:
					olvColShipped.IsVisible = false;
					olvColTracking.IsVisible = false;
					break;
			}
			olvShippingResultsList.RebuildColumns();
		}

		/// <summary>
		/// Enables and disables page navigation based on the current values of <see cref="_page"/> and <see cref="_maxPage"/>.
		/// </summary>
		private void HandlePagination()
		{
			_maxPage = (int)Math.Ceiling(_shipmentCount / (decimal)_MAX_RESULTS_PER_PAGE) - 1;
			txtShipmentsQty.Text = _shipmentCount.ToString(CultureInfo.InvariantCulture);

			pnlPagination.Visible = _maxPage > 0;
			lblPageMax.Text = $"of {_maxPage + 1}";

			_ignoreStateChange = true;
			var pages = Enumerable.Range(1, _maxPage + 1).ToList();
			cmbPage.DataSource = pages;
			cmbPage.SelectedItem = _page + 1;
			_ignoreStateChange = false;

			btnFirst.Enabled = _page != 0;
			btnPrevious.Enabled = _page != 0;
			btnNext.Enabled = _page < _maxPage;
			btnLast.Enabled = _page < _maxPage;
		}

		/// <summary>
		/// Unchecks all shipment list radio buttons
		/// </summary>
		private void UncheckAll()
		{
			foreach (var radioButton in pnlList_Control.Controls.OfType<RadioButton>())
				radioButton.Checked = false;
		}

		/// <summary>
		/// Sets <see cref="_page"/> to 0 if the specified radio button is checked (or if it is null).
		/// </summary>
		private void ResetPageIfNotAlreadyChecked(RadioButton radioButton)
		{
			if (radioButton == null)
			{
				_page = 0;
				return;
			}

			if (!radioButton.Checked)
				_page = 0;
		}

		public void RefreshSelectedShipmentList()
		{
			if (tabShipping.SelectedTab != tabList)
				return;
			Shipments_List_Populate();
		}

		/// <summary>
		/// View Ready Shipments. Switches to the list tab, selects the Ready option and populates the list.
		/// Ready shipments are those with no items that require preparation, or with items that do, but the shipment has been marked ready.
		/// </summary>
		public void Shipments_List_Ready()
		{
			_listMode = ListModeEnum.Ready;
			_page = 0;
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}

		/// <summary>
		/// View Shipments from Search Query. Switches to the list tab, selects the search results option and populates the list.
		/// </summary>
		private void Shipments_List_SearchResults()
		{
			_listMode = ListModeEnum.SearchResults;
			_page = 0;
			UncheckAll();
			MarkListRadioButton();
			Shipments_List_Populate();
		}

		private void olvShippingResultsList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvShippingResultsList.SelectedItem != null)
				ViewShipment?.Invoke(((ClassShipment)olvShippingResultsList.SelectedObject).ID);
		}

		private void olvShippingResultsList_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var shipment = (ClassShipment)e.Model;
			e.Item.ForeColor = shipment.StatusColor;
			e.Item.BackColor = shipment.StatusColorBackground;
		}

		private void olvShippingResultsList_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
		{
			var selectedShipment = (ClassShipment)e.Model;
			if (e.Column == olvColTracking)
			{
				if (ViewTracking != null && !string.IsNullOrEmpty(selectedShipment.Tracking))
					ViewTracking(selectedShipment.URL_TrackingLink);
			}
			e.Handled = true;
		}

		private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			_page = (int)cmbPage.SelectedItem - 1;
			Shipments_List_Populate();
		}

		private void btnFirstPage_Click(object sender, EventArgs e)
		{
			_page = 0;
			Shipments_List_Populate();
		}

		private void btnPreviousPage_Click(object sender, EventArgs e)
		{
			_page--;
			if (_page < 0)
				_page = 0;
			Shipments_List_Populate();
		}

		private void btnNextPage_Click(object sender, EventArgs e)
		{
			_page++;
			if (_page > _maxPage)
				_page = _maxPage;
			Shipments_List_Populate();
		}

		private void btnLastPage_Click(object sender, EventArgs e)
		{
			_page = _maxPage;
			Shipments_List_Populate();
		}
		#endregion

		private void chkAutoRefresh_CheckedChanged(object sender, EventArgs e)
		{
			timerAutoRefresh.Enabled = chkAutoRefresh.Checked;
			btnList_Refresh.Enabled = !chkAutoRefresh.Checked;
		}

		private void timerAutoRefresh_Tick(object sender, EventArgs e)
		{
			Shipments_List_Populate();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			CreateShipment?.Invoke();
		}

        private void btnExport_Click(object sender, EventArgs e)
        {
            var export = new OLVExporter(olvShippingResultsList);
            string csv = export.ExportTo(OLVExporter.ExportFormat.CSV);
            SaveFileDialog saveFile = new SaveFileDialog();
            string date = DateTime.Today.ToShortDateString();
            date = date.Replace("/", "-");
            saveFile.FileName = "ShipperList_" + date + ".csv";
            saveFile.Filter = "csv files (*.csv)|*.csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.Write(csv);
                }
            }

        }
    }
}