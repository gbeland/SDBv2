using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.User;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_MarketConfig : Form
	{
		#region Vars
		private List<ClassCustomer> _customers = new List<ClassCustomer>();
		private List<ClassSalesperson> _salespeople = new List<ClassSalesperson>();

		private ClassCustomer _selectedCustomer;
		private ClassMarket _selectedMarket;
		private bool _isCreatingNewCustomer;
		private bool _isCreatingNewMarket;

		/// <summary>
		/// Stores current market email list so it can be more easily compressed and expanded to/from CSV.
		/// </summary>
		private List<string> _currentMarketEmailList = new List<string>();
		private bool _ignoreStateChange;
		private int? _afterLoadShowMarketID;
		#endregion

		#region Form
		public FormAdmin_MarketConfig(int? marketToShow = null)
		{
			InitializeComponent();

			btnCustomer_Delete.Visible = GS.Settings.LoggedOnUser.IsAdmin;
			btnMarket_Delete.Visible = GS.Settings.LoggedOnUser.IsAdmin;
			chkCustomerFreeze.Visible = GS.Settings.LoggedOnUser.IsAdmin;

			_afterLoadShowMarketID = marketToShow;

			cmbCustomer_Select.DisplayMember = "DisplayMember";
			cmbCustomer_Select.ValueMember = "ID";

			cmbMarket_SalesRep.DisplayMember = "DisplayMember";
			cmbMarket_SalesRep.ValueMember = "ID";
		}

		private void FormMarketConfig_Load(object sender, EventArgs e)
		{
			Application.Idle += Application_Idle;
			_salespeople = ClassSalesperson.GetSalespeople().ToList();
			cmbMarket_SalesRep.DataSource = _salespeople;
		}

		void Application_Idle(object sender, EventArgs e)
		{
			Application.Idle -= Application_Idle;
			Customer_List_Populate();

			if (!_afterLoadShowMarketID.HasValue)
				return;

			_selectedMarket = _customers.SelectMany(c => c.Markets).SingleOrDefault(m => m.ID == _afterLoadShowMarketID);

			if (_selectedMarket == null)
				return;

			cmbCustomer_Select.SelectedValue = _selectedMarket.CustomerID;
			olvMarkets.SelectedObject = _selectedMarket;
				
			_afterLoadShowMarketID = null;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		#region Company
		private void cmbCustomer_Select_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			if (cmbCustomer_Select.SelectedIndex < 0)
			{
				btnCustomer_Save.Enabled = false;
				return;
			}
			_isCreatingNewCustomer = false;
			_selectedCustomer = (ClassCustomer)cmbCustomer_Select.SelectedItem;
			Customer_Populate(_selectedCustomer);
			pnlMarkets.Enabled = true;

			Market_Clear();
			Market_List_Populate(_selectedCustomer);

			btnMarket_New.Enabled = true;
			btnMarket_Delete.Enabled = false;
			btnCustomer_Delete.Enabled = true;
			btnCustomer_Save.Enabled = true;
		}

		private void Customer_TextEnter(object sender, EventArgs e)
		{
			AcceptButton = btnCustomer_Save;
			((TextBox)sender).SelectAll();
		}

		private void Customer_TextLeave(object sender, EventArgs e)
		{
			AcceptButton = btnClose;
		}

		private void Customer_List_Populate()
		{
			_ignoreStateChange = true;
			_customers = ClassCustomer.GetCustomers().ToList();
			cmbCustomer_Select.DataSource = _customers;
			cmbCustomer_Select.SelectedIndex = -1;
			_ignoreStateChange = false;
		}

		private void Customer_Populate(ClassCustomer customer)
		{
			if (customer == null)
			{
				foreach (var t in pnlCustomer.Controls.OfType<TextBox>())
					t.Clear();
				return;
			}
			chkSubscribe_Customer.Checked = ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Customer, customer.ID);
			txtCustomer_ID.Text = customer.Prefix;
			txtCustomer_ID.Tag = customer.ID;
			txtCustomer_Name.Text = customer.Name;
			chkCustomerFreeze.Checked = customer.IsFrozen;
		}

		private void btnCustomer_New_Click(object sender, EventArgs e)
		{
			if (_customers.Any(c => c.Prefix.ToUpper() == "***"))
			{
				MessageBox.Show("There is already a new customer, rename or remove it before adding another.", "Duplicate New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			_isCreatingNewCustomer = true;
			var newCustomer = new ClassCustomer { Name = "New Company", Prefix = "***" };
			ClassCustomer.AddNew(ref newCustomer);

			Customer_List_Populate();
			cmbCustomer_Select.SelectedValue = newCustomer.ID;
			txtCustomer_ID.Select();
		}

		private void btnCustomer_Delete_Click(object sender, EventArgs e)
		{
			if (cmbCustomer_Select.SelectedIndex < 0)
				return;

			if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Customer Delete",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			var customerToDelete = (ClassCustomer)cmbCustomer_Select.SelectedItem;

			if (customerToDelete.Markets.Any())
			{
				MessageBox.Show("Customer has markets assigned to it. Cannot delete.", "Cannot Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			ClassCustomer.Delete(customerToDelete);

			ClassNotification.SendNotificationsForObject("Deleted customer.", ClassSubscription.ObjectTypeEnum.Customer, customerToDelete.ID, customerToDelete.Name);
			ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Customer, customerToDelete.ID);
			Customer_List_Populate();
			_selectedCustomer = (ClassCustomer)cmbCustomer_Select.SelectedItem;
			Customer_Populate(_selectedCustomer);
		}

		private void btnCustomer_Save_Click(object sender, EventArgs e)
		{
			var modifiedCustomer = new ClassCustomer
				                                 {
													 ID = (int)txtCustomer_ID.Tag,
													 Name = txtCustomer_Name.Text.Trim(),
													 Prefix = txtCustomer_ID.Text.Trim(),
													 IsFrozen = chkCustomerFreeze.Checked
				                                 };
			
			ClassCustomer.Update(modifiedCustomer);

			if (_isCreatingNewCustomer && GS.Settings.AutoSubscribe_Create)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Customer, modifiedCustomer.ID, modifiedCustomer.Name);
			else if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Customer, modifiedCustomer.ID, modifiedCustomer.Name);
			
			if (!_isCreatingNewCustomer)
				ClassNotification.SendNotificationsForObject("MODIFIED customer.", ClassSubscription.ObjectTypeEnum.Customer, _selectedCustomer.ID, _selectedCustomer.Name);
			_isCreatingNewCustomer = false;

			Customer_List_Populate();
			cmbCustomer_Select.SelectedValue = modifiedCustomer.ID;
		}

		private void chkSubscribe_Customer_Click(object sender, EventArgs e)
		{
			if (_selectedCustomer == null || _selectedCustomer.ID < 0)
				return;

			if (_ignoreStateChange)
				return;

			if (ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Customer, _selectedCustomer.ID))
			{
				ClassSubscription.Unsubscribe(ClassSubscription.ObjectTypeEnum.Customer, _selectedCustomer.ID);
				chkSubscribe_Customer.Checked = false;
			}
			else
			{
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Customer, _selectedCustomer.ID, _selectedCustomer.Name);
				chkSubscribe_Customer.Checked = true;
			}
		}
		#endregion

		#region Market
		private void Market_Clear()
		{
			Email_Clear();

			lstEmail.Items.Clear();
			_currentMarketEmailList.Clear();
			foreach (var tb in pnlMarket_Bottom.Controls.OfType<TextBox>())
				tb.Text = string.Empty;
			foreach (var cb in pnlMarket_Email.Controls.OfType<CheckBox>())
				cb.Checked = false;
			pnlMarket_Bottom.Enabled = false;
			pnlMarket_Email.Enabled = false;
			
			cmbMarket_SalesRep.SelectedIndex = -1;
		}

		/// <summary>
		/// Populates the markets list for a given company.
		/// </summary>
		private void Market_List_Populate(ClassCustomer customer)
		{
			olvMarkets.SetObjects(customer.Markets);
		}

		private void olvMarkets_SelectedIndexChanged(object sender, EventArgs e)
		{
			_isCreatingNewMarket = false;
			if (olvMarkets.SelectedItems.Count < 1)
			{
				Market_Clear();
				return;
			}
			_selectedMarket = (ClassMarket)olvMarkets.SelectedObject;
			Market_Populate(_selectedMarket);

			btnEmail_New.Enabled = true;
			btnMarket_Delete.Enabled = true;
		}

		private void Market_TextEnter(object sender, EventArgs e)
		{
			AcceptButton = btnMarket_Save;
			((TextBox)sender).SelectAll();
		}

		private void Market_TextLeave(object sender, EventArgs e)
		{
			AcceptButton = btnClose;
		}

		/// <summary>
		/// Populates market information. Also indirectly populates email information for the market.
		/// </summary>
		private void Market_Populate(ClassMarket market)
		{
			chkSubscribe_Market.Checked = ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Market, market.ID);
			pnlMarket_Bottom.Enabled = true;
			pnlMarket_Email.Enabled = true;
			txtMarket_ID.Text = market.Prefix;
			txtMarket_ID.Tag = market.ID;
			txtMarket_Name.Text = market.Name;
			txtMarket_Address.Text = market.Address;
			txtMarket_City.Text = market.City;
			txtMarket_State.Text = market.State;
			txtMarket_Zip.Text = market.Zip;
			txtMarket_Country.Text = market.Country;
			txtMarket_Telephone.Text = market.Telephone;
			txtMarket_Notes.Text = market.Notes;
			txtMarket_Contact1_Name.Text = market.Contact1_Name;
			txtMarket_Contact2_Name.Text = market.Contact2_Name;
			txtMarket_Contact3_Name.Text = market.Contact3_Name;
			txtMarket_Contact1_Position.Text = market.Contact1_Position;
			txtMarket_Contact2_Position.Text = market.Contact2_Position;
			txtMarket_Contact3_Position.Text = market.Contact3_Position;
			txtMarket_Contact1_Number.Text = market.Contact1_Number;
			txtMarket_Contact2_Number.Text = market.Contact2_Number;
			txtMarket_Contact3_Number.Text = market.Contact3_Number;
			chkMarket_EmailOpen.Checked = market.SendEmail_Open;
			chkMarket_EmailClosed.Checked = market.SendEmail_Close;
			chkMarket_EmailTechOnSite.Checked = market.SendEmail_TechOnSite;
			chkMarket_EmailRmaCreated.Checked = market.SendEmail_RmaCreated;
			Email_List_Populate(market);
			cmbMarket_SalesRep.SelectedValue = market.SalespersonID;
		}

		private void btnMarket_New_Click(object sender, EventArgs e)
		{
			if (_selectedCustomer.Markets.Any(m => m.Prefix.ToUpper() == "***"))
			{
				MessageBox.Show("There is already a new market for this customer. Rename or remove it before adding another.", "Duplicate New Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			_isCreatingNewMarket = true;
			var newMarket = new ClassMarket
			                {
				                CustomerName = _selectedCustomer.Name,
				                CustomerID = _selectedCustomer.ID,
				                Prefix = "***",
				                Name = "New Market"
			                };
			ClassMarket.AddNew(ref newMarket);

			Customer_List_Populate();
			cmbCustomer_Select.SelectedValue = _selectedCustomer.ID;
			Market_List_Populate(_selectedCustomer);
			olvMarkets.SelectedObject = newMarket;
			txtMarket_ID.Select();
		}

		private void btnMarket_Delete_Click(object sender, EventArgs e)
		{
			if (olvMarkets.SelectedItems.Count < 1)
				return;

			var selectedMarket = (ClassMarket)olvMarkets.SelectedObject;

			if (MessageBox.Show("Are you sure you want to delete this market?", "Confirm Market Delete",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			// check if assets assigned to market
			var usedQty = ClassMarket.GetUsedQty(selectedMarket.ID);
			if(usedQty != 0)
			{
				var message = string.Format("Market is used {0} time{1} throughout the database. Cannot delete.", usedQty, usedQty.SIfPlural());
				MessageBox.Show(message, "Cannot Delete Market", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			ClassMarket.Delete(selectedMarket);
			ClassNotification.SendNotificationsForObject("Deleted market.", ClassSubscription.ObjectTypeEnum.Market, selectedMarket.ID, selectedMarket.Name);
			ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Market, selectedMarket.ID);
			Customer_List_Populate();
			cmbCustomer_Select.SelectedValue = _selectedCustomer.ID;
			Market_List_Populate(_selectedCustomer);
		}

		private void btnMarket_Save_Click(object sender, EventArgs e)
		{
			var modifiedMarket = new ClassMarket
			                     {
				                     ID = (int)txtMarket_ID.Tag,
				                     Prefix = txtMarket_ID.Text.Trim(),
				                     Name = txtMarket_Name.Text.Trim(),
				                     Address = txtMarket_Address.Text.Trim(),
				                     City = txtMarket_City.Text.Trim(),
				                     State = txtMarket_State.Text.Trim(),
				                     Zip = txtMarket_Zip.Text.Trim(),
				                     Country = txtMarket_Country.Text.Trim(),
				                     Telephone = txtMarket_Telephone.Text.Trim(),
				                     Contact1_Name = txtMarket_Contact1_Name.Text.Trim(),
				                     Contact2_Name = txtMarket_Contact2_Name.Text.Trim(),
				                     Contact3_Name = txtMarket_Contact3_Name.Text.Trim(),
				                     Contact1_Position = txtMarket_Contact1_Position.Text.Trim(),
				                     Contact2_Position = txtMarket_Contact2_Position.Text.Trim(),
				                     Contact3_Position = txtMarket_Contact3_Position.Text.Trim(),
				                     Contact1_Number = txtMarket_Contact1_Number.Text.Trim(),
				                     Contact2_Number = txtMarket_Contact2_Number.Text.Trim(),
				                     Contact3_Number = txtMarket_Contact3_Number.Text.Trim(),
				                     Email_Addresses = string.Join(",", _currentMarketEmailList.ToArray()),
				                     SendEmail_Open = chkMarket_EmailOpen.Checked,
				                     SendEmail_Close = chkMarket_EmailClosed.Checked,
				                     SendEmail_TechOnSite = chkMarket_EmailTechOnSite.Checked,
									 SendEmail_RmaCreated = chkMarket_EmailRmaCreated.Checked,
				                     Notes = txtMarket_Notes.Text.Trim(),
				                     SalespersonID = (int?)cmbMarket_SalesRep.SelectedValue,
				                     CustomerID = _selectedCustomer.ID,
				                     CustomerName = _selectedCustomer.Name
			                     };

			if (_selectedCustomer.Markets.Any(m => m.Prefix.ToUpper() == txtMarket_ID.Text.Trim() && m.ID != modifiedMarket.ID))
			{
				MessageBox.Show(string.Format("There is already a market for {0}.", txtMarket_ID.Text.Trim()), "Duplicate Market Prefix", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			
			ClassMarket.Update(modifiedMarket);
			
			if (_isCreatingNewMarket && GS.Settings.AutoSubscribe_Create)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Market, modifiedMarket.ID, modifiedMarket.NameWithCustomerName);
			else if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Market, modifiedMarket.ID, modifiedMarket.NameWithCustomerName);
			
			if (!_isCreatingNewCustomer)
				ClassNotification.SendNotificationsForObject("MODIFIED market.", ClassSubscription.ObjectTypeEnum.Market, modifiedMarket.ID, modifiedMarket.NameWithCustomerName);
			_isCreatingNewMarket = false;

			Customer_List_Populate();
			cmbCustomer_Select.SelectedValue = _selectedCustomer.ID;

			Market_List_Populate(_selectedCustomer);
			olvMarkets.SelectedObject = _selectedMarket;
			txtMarket_ID.Select();
		}

		private void chkSubscribe_Market_Click(object sender, EventArgs e)
		{
			if (_selectedMarket == null || _selectedMarket.ID < 0)
				return;

			if (_ignoreStateChange)
				return;

			if (ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Market, _selectedMarket.ID))
			{
				ClassSubscription.Unsubscribe(ClassSubscription.ObjectTypeEnum.Market, _selectedMarket.ID);
				chkSubscribe_Market.Checked = false;
			}
			else
			{
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Market, _selectedMarket.ID, string.Format("{0}: {1}", _selectedCustomer.Name, _selectedMarket.Name).Truncate(64));
				chkSubscribe_Market.Checked = true;
			}
		}
		#endregion

		#region EMail
		private void Email_Clear()
		{
			foreach (var tb in grpEmailAddresses.Controls.OfType<TextBox>())
				tb.Text = string.Empty;
			btnEmail_Update.Enabled = false;
		}

		private void Email_List_Populate(ClassMarket market)
		{
			lstEmail.Items.Clear();
			Email_Clear();
			_currentMarketEmailList = market.Email_Addresses.Split(',').Where(s => !string.IsNullOrEmpty(s)).ToList();
			foreach (var s in _currentMarketEmailList.Where(s => !string.IsNullOrEmpty(s)))
				lstEmail.Items.Add(new ListViewItem(s));
		}

		private void lstEmail_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstEmail.SelectedItems.Count < 1)
			{
				Email_Clear();
				return;
			}
			Email_Populate(lstEmail.SelectedItems[0].SubItems[0].Text);

			btnEmail_Delete.Enabled = true;
		}

		private void Email_Populate(string emailAddress)
		{
			btnEmail_Update.Enabled = true;
			txtEmail.Text = emailAddress;
		}

		private void txtEmail_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnEmail_Update;
			((TextBox)sender).SelectAll();
		}

		private void txtEmail_Leave(object sender, EventArgs e)
		{
			AcceptButton = btnClose;
		}

		private void btnEmail_Update_Click(object sender, EventArgs e)
		{
			var emailIndex = lstEmail.SelectedIndices[0];
			_currentMarketEmailList[emailIndex] = txtEmail.Text;
			lstEmail.SelectedItems[0].SubItems[0].Text = txtEmail.Text;

			if (_currentMarketEmailList.Sum(o => o.Length) <= 1024)
				return;
			MessageBox.Show("The list of emails for this market exceeds the allocated storage capacity. Please remove one or more addresses.", "Email List Exceeds Capacity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			lstEmail.Items.RemoveAt(lstEmail.Items.Count - 1);
			_currentMarketEmailList.RemoveAt(_currentMarketEmailList.Count - 1);
		}

		private void btnEmail_New_Click(object sender, EventArgs e)
		{
			_currentMarketEmailList.Add(string.Empty);
			lstEmail.Items.Add(string.Empty);
			lstEmail.SelectedIndices.Clear();
			lstEmail.SelectedIndices.Add(lstEmail.Items.Count - 1);
			lstEmail.EnsureVisible(lstEmail.Items.Count - 1);
			txtEmail.Text = "Enter New Email";
			txtEmail.Select();
		}

		private void btnEmail_Delete_Click(object sender, EventArgs e)
		{
			var emailIndex = lstEmail.SelectedIndices[0];
			_currentMarketEmailList.RemoveAt(emailIndex);
			lstEmail.Items.RemoveAt(emailIndex);
		}
		#endregion
	}
}