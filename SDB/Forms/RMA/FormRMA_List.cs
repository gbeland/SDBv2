using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Tech;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_List : Form
	{
		#region Private Vars
		private enum SearchModeEnum { RMA, Ticket, Asset, Customer, Tech, Date, AssemblyType };
		private SearchModeEnum _searchMode;
		private List<ClassRMA> _rmaListSearchResults = new List<ClassRMA>();

		private List<ClassCustomer> _customers = new List<ClassCustomer>();
		private List<ClassAsset> _assets = new List<ClassAsset>();
		private List<ClassTech> _techs = new List<ClassTech>();
		private List<ClassAssemblyType> _assemblyTypes = new List<ClassAssemblyType>();

		private const int _MAX_RESULTS_PER_PAGE = 1000;
		private int _page;
		private int _maxPage;
		private int _rmaCount;
		private bool _ignoreStateChange;
		#endregion

		#region Delegates and Events
		public delegate void RMAEvent(int rmaID, FormRMA_Editor.ViewEnum viewType = FormRMA_Editor.ViewEnum.Assemblies);
		public delegate void RMACreateEvent();
		public event RMAEvent ViewRMA;
		public event RMACreateEvent CreateRMA;
		#endregion

		#region FORM
		public FormRMA_List()
		{
			InitializeComponent();

			olvColRMAList_Hot.AspectGetter = x => ((ClassRMA)x).IsHot;
			olvColRMAList_Hot.AspectToStringConverter = x => string.Empty;
			olvColRMAList_Hot.ImageGetter = x => ((ClassRMA)x).IsHot ? "fire" : "none";

			olvColRMAList_APR.AspectGetter = x => ((ClassRMA)x).IsHot;
			olvColRMAList_APR.AspectToStringConverter = x => string.Empty;
			olvColRMAList_APR.ImageGetter = x => ((ClassRMA)x).IsAPR ? "star" : "none";

			olvColRMAList_HasComputer.AspectGetter = x => ((ClassRMA)x).HasComputer;
			olvColRMAList_HasComputer.AspectToStringConverter = x => string.Empty;
			olvColRMAList_HasComputer.ImageGetter = x => ((ClassRMA)x).HasComputer ? "computer" : "none";

			olvColRMAList_HasNonSystemJournalEntries.AspectGetter = x => ((ClassRMA)x).HasNonSystemInfo;
			olvColRMAList_HasNonSystemJournalEntries.AspectToStringConverter = x => string.Empty;
			olvColRMAList_HasNonSystemJournalEntries.ImageGetter = x => ((ClassRMA)x).HasNonSystemInfo ? "flag" : "none";

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

			olvRMAList.CellToolTip.InitialDelay = 1000;

			foreach (var status in ClassRMA.GetAllStatuses())
			{
				flpRmaKey.Controls.Add(new Label
				                       {
					                       AutoSize = true,
					                       TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
										   BorderStyle = BorderStyle.FixedSingle,
					                       Text = status.Status,
					                       BackColor = status.Background,
					                       ForeColor = status.Foreground
				                       });
			}
		}

		private void FormRMAList_Load(object sender, EventArgs e)
		{
			WindowState = GS.Settings.WindowState_RMAList;
			Location = GS.Settings.Location_RMAList;
		}

		private void FormRMA_List_Activated(object sender, EventArgs e)
		{
		}

		private void FormRMAList_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		
		private void FormRMAList_FormClosing(object sender, FormClosingEventArgs e)
		{
			GS.Settings.WindowState_RMAList = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_RMAList = Location;
			Hide();
			e.Cancel = true;
		}

		/// <summary>
		/// Load the specified RMA in the RMA Editor form, using selected view type (tab).
		/// </summary>
		private void RMA_Load(int rmaID, FormRMA_Editor.ViewEnum viewType = FormRMA_Editor.ViewEnum.Assemblies)
		{
			ViewRMA?.Invoke(rmaID, viewType);
		}

		private void tabControlRMA_SelectedIndexChanged(object sender, EventArgs e)
		{
			pnlPagination.Visible = tabControlRMA.SelectedTab == tabRMA_List;

			if (tabControlRMA.SelectedTab != tabRMA_Search)
				return;

			Search_SetShow();
		}

		private void btnCreateNewRMA_Click(object sender, EventArgs e)
		{
			CreateRMA?.Invoke();
			RefreshCurrentList();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			RefreshCurrentList();
		}

		private void FormRMA_List_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
				RefreshCurrentList();
		}

		private void btnMove_Click(object sender, EventArgs e)
		{
			using (var moveStuffForm = new FormRMA_MoveStuff())
				moveStuffForm.ShowDialog(this);
		}
		#endregion

		#region SEARCH
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			switch (_searchMode)
			{
				case SearchModeEnum.RMA:
					if (int.TryParse(txtSearch_RMANumber.Text, out var rmaNumber))
						SearchByRMA(rmaNumber, chkIncludeDeleted.Checked);
					else
						MessageBox.Show("Invalid RMA Number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					break;

				case SearchModeEnum.Ticket:
					if (int.TryParse(txtSearch_Ticket.Text, out var ticketNumber))
						SearchByTicket(ticketNumber, chkIncludeDeleted.Checked);
					else
						MessageBox.Show("Invalid Ticket Number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					break;

				case SearchModeEnum.Asset:
					SearchByAsset((ClassAsset)cmbSearch_Asset.SelectedItem, chkIncludeDeleted.Checked);
					break;

				case SearchModeEnum.Customer:
					if (chkSearch_AllMarkets.Checked)
						SearchByCustomer((ClassCustomer)cmbSearch_Customer.SelectedItem, chkIncludeDeleted.Checked);
					else
						SearchByMarket((ClassCustomer)cmbSearch_Customer.SelectedItem, (int)cmbSearch_Market.SelectedValue, chkIncludeDeleted.Checked);
					break;

				case SearchModeEnum.Tech:
					SearchByTech((ClassTech)cmbSearch_Tech.SelectedItem, chkIncludeDeleted.Checked);
					break;

				case SearchModeEnum.Date:
					if (dtpSearch_From.Value < dtpSearch_To.Value)
						SearchByDateRange(dtpSearch_From.Value, dtpSearch_To.Value, chkIncludeDeleted.Checked);
					else
						MessageBox.Show("Invalid date range.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					break;

				case SearchModeEnum.AssemblyType:
					SearchByAssemblyType((ClassAssemblyType)cmbSearch_AssemblyType.SelectedItem, chkIncludeDeleted.Checked);
					break;
			}
			Cursor = Cursors.Default;
		}

		private void radSearch_CheckedChanged(object sender, EventArgs e)
		{
			Search_SetShow();
		}

		private void cmbSearch_Customer_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbSearch_Market.ValueMember = "ID";
			cmbSearch_Market.DisplayMember = "DisplayMember";
			cmbSearch_Market.DataSource = ((ClassCustomer)cmbSearch_Customer.SelectedItem).Markets;
		}

		/// <summary>
		/// Sets the search mode and invokes Search_ShowFields which shows/hides relevant form controls.
		/// </summary>
		private void Search_SetShow()
		{
			if (radSearch_RMANumber.Checked)
				_searchMode = SearchModeEnum.RMA;
			
			if (radSearch_Ticket.Checked)
				_searchMode = SearchModeEnum.Ticket;
			
			if (radSearch_Asset.Checked)
				_searchMode = SearchModeEnum.Asset;
			
			if (radSearch_Customer.Checked)
				_searchMode = SearchModeEnum.Customer;
			
			if (radSearch_Tech.Checked)
				_searchMode = SearchModeEnum.Tech;
			
			if (radSearch_DateRange.Checked)
				_searchMode = SearchModeEnum.Date;

			if (radSearch_AssemblyType.Checked)
				_searchMode = SearchModeEnum.AssemblyType;

			Search_ShowFields();

			switch (_searchMode)
			{
				case SearchModeEnum.RMA:
					txtSearch_RMANumber.SelectAll();
					txtSearch_RMANumber.Select();
					break;

				case SearchModeEnum.Ticket:
					txtSearch_Ticket.SelectAll();
					txtSearch_Ticket.Select();
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

				case SearchModeEnum.Date:
					dtpSearch_From.Select();
					break;

				case SearchModeEnum.AssemblyType:
					RefreshAssemblyTypeDataBinding();
					cmbSearch_AssemblyType.Select();
					break;
			}
		}

		/// <summary>
		/// Shows the search button and the input fields for selected search mode.
		/// </summary>
		private void Search_ShowFields()
		{
			btnSearch.Visible = true;
			txtSearch_RMANumber.Visible = _searchMode == SearchModeEnum.RMA;
			txtSearch_Ticket.Visible = _searchMode == SearchModeEnum.Ticket;
			cmbSearch_Asset.Visible = _searchMode == SearchModeEnum.Asset;
			cmbSearch_Customer.Visible = _searchMode == SearchModeEnum.Customer;
			chkSearch_AllMarkets.Visible = _searchMode == SearchModeEnum.Customer;
			cmbSearch_Market.Visible = _searchMode == SearchModeEnum.Customer;
			cmbSearch_Tech.Visible = _searchMode == SearchModeEnum.Tech;
			pnlSearch_DateRange.Visible = _searchMode == SearchModeEnum.Date;
			cmbSearch_AssemblyType.Visible = _searchMode == SearchModeEnum.AssemblyType;
		}

		/// <summary>
		/// Searches RMAs by RMA number.
		/// </summary>
		private void SearchByRMA(int rmaNumber, bool includeDeleted = false)
		{
			var rmas = ClassRMA.GetByNumberIncludingLegacy(rmaNumber, includeDeleted).ToList();
			switch (rmas.Count)
			{
				case 0:
					MessageBox.Show($"Sorry, RMA number {rmaNumber} was not found.", "RMA Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				case 1:
					RMA_Load(rmas[0].ID);
					break;
				default: // 2+
					PopulateSearchResults(rmas);
					break;
			}
		}

		/// <summary>
		/// Searches RMAs by ticket number.
		/// </summary>
		private void SearchByTicket(int ticketNumber, bool includeDeleted = false)
		{
			var ticketRmas = ClassRMA.GetByTicket(ticketNumber, true, includeDeleted).ToList();
			if (ticketRmas.Count < 1)
			{
				MessageBox.Show($"Sorry, no RMAs found for ticket number {ticketNumber}.", "No RMAs Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(ticketRmas);
		}

		/// <summary>
		/// Searches RMAs by asset ID.
		/// </summary>
		private void SearchByAsset(ClassAsset asset, bool includeDeleted = false)
		{
			var ticketRmas = ClassRMA.GetByAsset(asset.ID, true, includeDeleted).ToList();
			if (ticketRmas.Count < 1)
			{
				MessageBox.Show($"Sorry, no RMAs for Asset '{asset.AssetName}' were found.", "No RMAs Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(ticketRmas);
		}

		/// <summary>
		/// Searches RMAs by Tech ID.
		/// </summary>
		private void SearchByTech(ClassTech tech, bool includeDeleted = false)
		{
			var techRmas = ClassRMA.GetByTech(tech.ID, true, includeDeleted).ToList();
			if (techRmas.Count < 1)
			{
				MessageBox.Show($"Sorry, no RMAs for {tech.TechName} were found.", "No RMAs Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(techRmas);
		}

		/// <summary>
		/// Searches RMAs by customer (all markets).
		/// </summary>
		private void SearchByCustomer(ClassCustomer customer, bool includeDeleted = false)
		{
			var customerRmas = ClassRMA.GetByCustomer(customer.ID, true, includeDeleted).ToList();
			if (customerRmas.Count < 1)
			{
				MessageBox.Show($"Sorry, no RMAs for {customer.Name} were found.", "No RMAs Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(customerRmas);
		}

		/// <summary>
		/// Searches RMAs by customer market (market ID).
		/// </summary>
		private void SearchByMarket(ClassCustomer customer, int marketID, bool includeDeleted = false)
		{
			var customerRmas = ClassRMA.GetByMarket(marketID, true, includeDeleted).ToList();
			if (customerRmas.Count < 1)
			{
				MessageBox.Show($"Sorry, no RMAs for {customer.Name}: {customer.Market(marketID).Name} were found.", "No RMAs Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(customerRmas);
		}

		private void chkSearch_AllMarkets_CheckedChanged(object sender, EventArgs e)
		{
			cmbSearch_Market.Visible = !chkSearch_AllMarkets.Checked;
		}

		/// <summary>
		/// Searches RMAs by request date within a range.
		/// </summary>
		/// <param name="startDate">The start of the date range. (Time is automatically set to 0:00:00.)</param>
		/// <param name="endDate">The end of the date range. (Time is automatically set to 23:59:59.)</param>
		/// <param name="includeDeleted">Include deleted RMAs in results.</param>
		private void SearchByDateRange(DateTime startDate, DateTime endDate, bool includeDeleted = false)
		{
			var customerRmas = ClassRMA.GetByDateRange(startDate, endDate, true, includeDeleted).ToList();
			if (customerRmas.Count < 1)
			{
				MessageBox.Show($"Sorry, no RMAs requested from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd} (inclusive) were found.", "No RMAs Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(customerRmas);
		}

		/// <summary>
		/// Searches RMAs by assembly types they contain.
		/// </summary>
		private void SearchByAssemblyType(ClassAssemblyType assemblyType, bool includeDeleted)
		{
			var assyTypeRmas = ClassRMA.GetByAssemblyType(assemblyType.ID, true, includeDeleted).ToList();
			if (assyTypeRmas.Count < 1)
			{
				MessageBox.Show($"Sorry, no RMAs containing {assemblyType.Description} were found.", "No RMAs Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			PopulateSearchResults(assyTypeRmas);
		}

		/// <summary>
		/// Populates the list with RMA results from searching and selects the list tab.
		/// </summary>
		private void PopulateSearchResults(List<ClassRMA> rmas)
		{
			_rmaListSearchResults = rmas;
			RMA_List_SearchResults();
		}

		private void Search_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnSearch;
			var n = sender as TextBox;
			n?.SelectAll();
		}

		private void Search_Leave(object sender, EventArgs e)
		{
			AcceptButton = null;
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
			cmbSearch_AssemblyType.DataSource = new BindingSource {DataSource = _assemblyTypes};

			Cursor = Cursors.Default;
		}
		#endregion

		#region LIST
		private void RefreshCurrentList()
		{
			if (radRMAList_Unreceived.Checked)
				RMA_List_Unreceived();
			else if (radRMAList_Received.Checked)
				RMA_List_Received();
			else if (radRMAList_InProgress.Checked)
				RMA_List_InProgress();
			else if (radRMAList_Pending.Checked)
				RMA_List_Pending();
			else if (radRMAList_Review.Checked)
				RMA_List_Review();
			else if (radRMAList_Unshipped.Checked)
				RMA_List_Unshipped();
			else if (radRMAList_Closed.Checked)
				RMA_List_Closed();
			else if (radRMAList_Expired.Checked)
				RMA_List_Expired();
			else if (radRMAList_Deleted.Checked)
				RMA_List_Deleted();
		}
        private void RefreshCurrentList(int max)
        {
            if (radRMAList_Unreceived.Checked)
                RMA_List_Unreceived(max);
            else if (radRMAList_Received.Checked)
                RMA_List_Received(max);
            else if (radRMAList_InProgress.Checked)
                RMA_List_InProgress(max);
            else if (radRMAList_Pending.Checked)
                RMA_List_Pending(max);
            else if (radRMAList_Review.Checked)
                RMA_List_Review(max);
            else if (radRMAList_Unshipped.Checked)
                RMA_List_Unshipped(max);
            else if (radRMAList_Closed.Checked)
                RMA_List_Closed(max);
            else if (radRMAList_Expired.Checked)
                RMA_List_Expired(max);
            else if (radRMAList_Deleted.Checked)
                RMA_List_Deleted(max);
        }

        private void radRMAList_Unreceived_Click(object sender, EventArgs e)
		{
			RMA_List_Unreceived();
		}

		private void radRMAList_UnshippedAPR_Click(object sender, EventArgs e)
		{
			RMA_List_APR();
		}

		private void radRMAList_Received_Click(object sender, EventArgs e)
		{
			RMA_List_Received();
		}

		private void radRMAList_InProgress_Click(object sender, EventArgs e)
		{
			RMA_List_InProgress();
		}

		private void radRMAList_Pending_Click(object sender, EventArgs e)
		{
			RMA_List_Pending();
		}

		private void radRMAList_Review_Click(object sender, EventArgs e)
		{
			RMA_List_Review();
		}

		private void radRMAList_Unshipped_Click(object sender, EventArgs e)
		{
			RMA_List_Unshipped();
		}

		private void radRMAList_Closed_Click(object sender, EventArgs e)
		{
			RMA_List_Closed();
		}

		private void radRMAList_Expired_Click(object sender, EventArgs e)
		{
			RMA_List_Expired();
		}

		private void radRMAList_Deleted_Click(object sender, EventArgs e)
		{
			RMA_List_Deleted();
		}

		/// <summary>
		/// View RMAs from Search Query. Switches to the list tab, selects the search results option and populates the list.
		/// </summary>
		private void RMA_List_SearchResults()
		{
			Cursor = Cursors.WaitCursor;
			// Sort by RMA number
			olvRMAList.PrimarySortColumn = olvColRMAList_Number;
			olvRMAList.PrimarySortOrder = SortOrder.Ascending;
			olvRMAList.SecondarySortColumn = null;
			olvRMAList.SecondarySortOrder = SortOrder.Ascending;

			tabControlRMA.SelectedTab = tabRMA_List;

			ResetPageIfNotAlreadyChecked(null);
			UncheckAll();

			olvRMAList.SetObjects(_rmaListSearchResults);
			olvRMAList.EmptyListMsg = "No RMAs matching specified criteria";
			olvColRMAList_PendingReason.IsVisible = false;
			pnlPagination.Visible = false;
			cmbPage.DataSource = null;
			txtRMAList_Qty.Text = _rmaListSearchResults.Count.ToString(CultureInfo.InvariantCulture);
			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View all incomplete RMAs with APR selected and no shipments. (Acts as the parts order queue.)
		/// </summary>
		private void RMA_List_APR(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;
			// Sort by Hot, then creation date
			olvRMAList.PrimarySortColumn = olvColRMAList_Hot;
			olvRMAList.PrimarySortOrder = SortOrder.Descending;
			olvRMAList.SecondarySortColumn = olvColRMAList_Created;
			olvRMAList.SecondarySortOrder = SortOrder.Ascending;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_UnshippedAPR);
			UncheckAll();
			radRMAList_UnshippedAPR.Checked = true;

			var rmaListOpenAPR = ClassRMA.GetUnshippedAPR(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(rmaListOpenAPR);
			olvRMAList.EmptyListMsg = "No unshipped APR RMAs.";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View Incomplete Unreceived RMAs. Switches to the list tab, selects the unreceived option, and populates the list.
		/// Also runs a command to automatically mark unreceived RMAs as expired if they have been unreceived for 90+ days.
		/// </summary>
		private void RMA_List_Unreceived(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			// Find expired RMAs
			ClassRMA.MarkUnreceivedAsExpired(ClassRMA.UNRECEIVED_RMA_EXPIRE_AFTER_DAYS);

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_Unreceived);
			UncheckAll();
			radRMAList_Unreceived.Checked = true;

			var unreceivedRmas = ClassRMA.GetUnreceived(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(unreceivedRmas);
			olvRMAList.EmptyListMsg = "No unreceived RMAs";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View Incomplete Received RMAs where repair has not started on at least one assembly.
		/// Switches to the list tab, selectes the received option, and populates the list.
		/// </summary>
		public void RMA_List_Received(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_Received);
			UncheckAll();
			radRMAList_Received.Checked = true;

			var receivedRmas = ClassRMA.GetReceived(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(receivedRmas);
			olvRMAList.EmptyListMsg = "No received RMAs";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View RMAs for which repair has started on at least one assembly.
		/// Switches to the list tab, selectes the In Progress option, and populates the list.
		/// </summary>
		private void RMA_List_InProgress(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_InProgress);
			UncheckAll();
			radRMAList_InProgress.Checked = true;

			var inProgressRmAs = ClassRMA.GetInProgress(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(inProgressRmAs);
			olvRMAList.EmptyListMsg = "No RMAs in progress";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View Pending RMAs. Switches to the list tab, selects the Pending option, and populates the list.
		/// </summary>
		private void RMA_List_Pending(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_Pending);
			UncheckAll();
			radRMAList_Pending.Checked = true;

			var pendingRmas = ClassRMA.GetPending(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(pendingRmas);
			olvRMAList.EmptyListMsg = "No pending RMAs";
			olvColRMAList_PendingReason.IsVisible = true;

			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View Completed (for review) RMAs. Switches to the list tab, selectes the Review option, and populates the list.
		/// </summary>
		private void RMA_List_Review(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_Review);
			UncheckAll();
			radRMAList_Review.Checked = true;

			var completedRmas = ClassRMA.GetCompleted(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(completedRmas);
			olvRMAList.EmptyListMsg = "No RMAs to review";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View Closed (Finalized) RMAs that have no shipments attached.
		/// </summary>
		private void RMA_List_Unshipped(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_Unshipped);
			UncheckAll();
			radRMAList_Unshipped.Checked = true;

			var unshippedRmas = ClassRMA.GetUnshipped(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(unshippedRmas);
			olvRMAList.EmptyListMsg = "No unshipped RMAs";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		/// <summary>
		/// View Closed (Finalized) RMAs that have shipments attached. Switches to the list tab, selectes the Closed option, and populates the list.
		/// </summary>
		private void RMA_List_Closed(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_Closed);
			UncheckAll();
			radRMAList_Closed.Checked = true;

			var closedRmas = ClassRMA.GetClosed(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(closedRmas);
			olvRMAList.EmptyListMsg = "No closed RMAs";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		private void RMA_List_Expired(int max = _MAX_RESULTS_PER_PAGE)
		{
			Cursor = Cursors.WaitCursor;

			tabControlRMA.SelectedTab = tabRMA_List;
			ResetPageIfNotAlreadyChecked(radRMAList_Expired);
			UncheckAll();
			radRMAList_Expired.Checked = true;

			var expiredRmas = ClassRMA.GetExpired(_page, max, out _rmaCount).ToList();
			HandlePagination();
			olvRMAList.SetObjects(expiredRmas);
			olvRMAList.EmptyListMsg = "No expired RMAs";
			olvColRMAList_PendingReason.IsVisible = false;

			Cursor = Cursors.Default;
		}

		private void RMA_List_Deleted(int max = _MAX_RESULTS_PER_PAGE)
		{
			try
			{
				Cursor = Cursors.WaitCursor;

				tabControlRMA.SelectedTab = tabRMA_List;
				ResetPageIfNotAlreadyChecked(radRMAList_Deleted);
				UncheckAll();
				radRMAList_Deleted.Checked = true;

				var deletedRmas = ClassRMA.GetDeleted(_page, max, out _rmaCount).ToList();
				HandlePagination();
				olvRMAList.SetObjects(deletedRmas);
				olvRMAList.EmptyListMsg = "No deleted RMAs";
				olvColRMAList_PendingReason.IsVisible = false;
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void HandlePagination()
		{
			_maxPage = (int)Math.Ceiling(_rmaCount / (decimal)_MAX_RESULTS_PER_PAGE) - 1;
			txtRMAList_Qty.Text = _rmaCount.ToString(CultureInfo.InvariantCulture);

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

		private void UncheckAll()
		{
			foreach (var radioButton in pnlViewControl.Controls.OfType<RadioButton>())
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

		private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			_page = (int)cmbPage.SelectedItem - 1;
			RefreshCurrentList();
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			_page = 0;
			RefreshCurrentList();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			_page--;
			if (_page < 0)
				_page = 0;
			RefreshCurrentList();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			_page++;
			if (_page > _maxPage)
				_page = _maxPage;
			RefreshCurrentList();
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			_page = _maxPage;
			RefreshCurrentList();
		}

		private void olvRMAList_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var rma = (ClassRMA)e.Model;
			
			e.Item.ForeColor = rma.Status.Foreground;
			e.Item.BackColor = rma.Status.Background;
		}

		private void olvRMAList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var editorViewType = FormRMA_Editor.ViewEnum.Assemblies;

			if (radRMAList_Unreceived.Checked)
				editorViewType = FormRMA_Editor.ViewEnum.Receive;
			else if (radRMAList_Received.Checked)
				editorViewType = FormRMA_Editor.ViewEnum.Repair;
			else if (radRMAList_InProgress.Checked)
				editorViewType = FormRMA_Editor.ViewEnum.Repair;
			else if (radRMAList_Pending.Checked)
				editorViewType = FormRMA_Editor.ViewEnum.Summary;
			else if (radRMAList_Review.Checked)
				editorViewType = FormRMA_Editor.ViewEnum.Summary;
			else if (radRMAList_Closed.Checked)
				editorViewType = FormRMA_Editor.ViewEnum.Summary;

			if (olvRMAList.SelectedItem != null)
				RMA_Load(((ClassRMA)olvRMAList.SelectedObject).ID, editorViewType);
		}

		private void olvRMAList_CellToolTipShowing(object sender, BrightIdeasSoftware.ToolTipShowingEventArgs e)
		{
			e.AutoPopDelay = 30000;
			var rma = (ClassRMA)e.Model;
			if (string.IsNullOrEmpty(rma.AssemblyTooltip))
			{
				Console.WriteLine($"RMA {rma.ID} tooltip generated...");

				var rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(rma.ID).ToList();
				var assemblyGroups = rmaAssemblies.OrderBy(a => a.AssemblyTypeDescription).GroupBy(a => a.AssemblyTypeDescription);

				rma.AssemblyTooltip = $"RMA {rma.ID} Assemblies: {Environment.NewLine}{Environment.NewLine}";
				rma.AssemblyTooltip += string.Join(Environment.NewLine, assemblyGroups.Select(g => $"{g.Count()}x: {g.Key}"));
			}

			e.Text = rma.AssemblyTooltip;
		}
        #endregion

        private void btnExport_Click(object sender, EventArgs e)
        {
            RefreshCurrentList(100000);
            var export = new OLVExporter(olvRMAList);
            string csv = export.ExportTo(OLVExporter.ExportFormat.CSV);
            SaveFileDialog saveFile = new SaveFileDialog();

            string date = DateTime.Today.ToShortDateString();

            date = date.Replace("/", "-");
            saveFile.FileName = "RMAList_" + date + ".csv";
            saveFile.Filter = "csv files (*.csv)|*.csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(csv);
                    }
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Error: Please make sure the file does not exist already", "Error");
                }
                
            }

            RefreshCurrentList();
        }
    }
}