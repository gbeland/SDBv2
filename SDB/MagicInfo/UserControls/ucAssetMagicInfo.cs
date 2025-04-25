using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.MagicInfo.Classes;
using System.IO;
using SDB.Classes.General;
using System.Diagnostics;
using System.Collections;
using SDB.MagicInfo.Forms;
using BrightIdeasSoftware;
using SDB.MagicInfo.Components;

namespace SDB.MagicInfo.UserControls
{
    public partial class ucAssetMagicInfo : UserControl
    {
        public delegate void LoadTicket(int? ticket_id);
        public event LoadTicket TicketLoadEvent;

        enum NavLevels
        {
            Customer = 0,
            Server = 1,
            Market = 2,
            
        }
        NavLevels SelectedLevel;

        #region Data
        private List<MagicInfoMarket> _marketList;
        private List<MagicInfoCustomer> _customerList;
        private List<MagicInfoServer> _serverList;
        private List<MagicInfoAsset> _assetList;

        private MagicInfoServer _server;
        private MagicInfoAddress _address;
        private MagicInfoCustomer _customer;
        private MagicInfoMarket _market;



        #endregion

        #region Init

        /// <summary>
        /// Handles intitalizing conponent settings
        /// </summary>
        public ucAssetMagicInfo()
        {
            InitializeComponent();
            addressComponent1.ShowButtons(false);
            addressComponent1.SetAddressName("Server");
            customerComponent1.ReadOnly(true);
            serverComponent1.ReadOnly(true);

            actionsComponent1.HideDispatchButton();
            actionsComponent1.HideEscalateButton();
            tabCustomerComponent.ReadOnly(true);
            tabMarketComponent.ReadOnly(true);
            tabMarketAddressComponent.ShowButtons(false);
            tabCustomerAddressComponent.ShowButtons(false);
        }

        /// <summary>
        /// Populates the Navigation tree. This needs to be called after constructor to function
        /// </summary>
        public void Init()
        {
            Populate_AssetNav();
        }

        /// <summary>
        /// Populates all the variou controls with data based on _selected server 
        /// </summary>
        private void Populate()
        {
            if (_server == null)
                return;
            _address = MagicInfoAddress.GetByID((int)_server.Address_ID);
            _customer = MagicInfoCustomer.GetByID((int)_server.Customer_ID);

            Populate_ContactList();
            Populate_ServerInfo();
            Populate_ServerAddress();
            Populate_ServerLFDList();
            Populate_ServerCustomer();
            Populate_ServerMarket();
            Populate_TicketList();
            Populate_ServerNote();
            Populate_CustomerInfoTab();
        }

        private void Populate_ContactList()
        {
            floContactList.Controls.Clear();


            if (_server == null)
                return;


            List<MagicInfoContacts> contactList = MagicInfoContacts.GetAllByServer(_server).ToList();

            foreach(MagicInfoContacts c in contactList)
            {
                ContactComponent cc = new ContactComponent();
                cc.Init(c);
                cc.ContactSaveEvent += new ContactComponent.SaveContact(SaveContact);
                floContactList.Controls.Add(cc);
            }
        }

        private void Populate_TicketList()
        {
            olvTickets.ClearObjects();
            if (_server == null)
                return;
            olvTickets.Objects = MagicInfoTicket.GetByServerID((int)_server.ID);

        }
        private void Populate_AssetNav()
        {
            _customerList = MagicInfoCustomer.GetAll().ToList(); //get customer list
            _marketList = MagicInfoMarket.GetAll().ToList(); //get customer list
            _serverList = MagicInfoServer.GetAll().ToList(); // get customer list

            Random r = new Random();
            

            if (_customerList.Count == 0)
                AssetNav.Enabled = false;
            else
                AssetNav.Enabled = true;

            AssetNav.Nodes.Clear();

            foreach(MagicInfoCustomer c in _customerList)
            {
                TreeNode customerNode = new TreeNode(c.Name); //create root tree node
                //customerNode.BackColor = Color.FromArgb(r.Next());
                customerNode.Tag = c.ID;
                foreach(MagicInfoServer s in _serverList.ToList()) //iterate server list to add to parents and add children
                {
                    if(c.ID == s.Customer_ID) 
                    {
                        TreeNode serverNode = new TreeNode(s.Name);
                        //serverNode.BackColor = Color.FromArgb(r.Next());
                        serverNode.Tag = s.ID;
                        customerNode.Nodes.Add(serverNode); // add market under parent customer
                        foreach(MagicInfoMarket m in _marketList.ToList()) //interate server to add to marets
                        {
                            if(m.Server_ID == s.ID)
                            {
                                TreeNode marketNode = new TreeNode(m.Name);
                                //marketNode.BackColor = Color.FromArgb(r.Next());
                                marketNode.Tag = m.ID;
                                serverNode.Nodes.Add(marketNode); //add server to parent market
                                _marketList.Remove(m); // remove server from list to speed up future iterations
                            }
                            
                        }
                        _serverList.Remove(s); // remove from list to speed up future iterations
                    }

                }
                AssetNav.Nodes.Add(customerNode); 
            }
        }

        private void Populate_CustomerInfoTab()
        {
            tabCustomerComponent.Populate(_customer);
            tabCustomerAddressComponent.Populate(_customer.Address_ID);
            if (_market != null)
            {
                tabMarketComponent.Populate(_market);
                tabMarketAddressComponent.Populate(_market.Address_ID);
            }
        }

        private void Populate_ServerInfo()
        {
            serverComponent1.Populate(_server);
        }

        private void Populate_ServerMarket()
        {
            marketComponent1.Populate(_market);
        }

        private void Populate_ServerAddress()
        {
            addressComponent1.Populate(_server.Address_ID);
        }

        private void Populate_ServerCustomer()
        {
            customerComponent1.Populate(_customer);
        }

        private void Populate_ServerLFDList()
        {
            _assetList = MagicInfoAsset.GetAllByServerID((int)_server.ID).ToList();
            if(SelectedLevel == NavLevels.Market)
            {
                _assetList = _assetList.Where(a => a.Market_ID == _market.ID).ToList();
            }

            olvLFDList.Objects= _assetList;
        }

        private void Populate_ServerNote()
        {
            rtbxNote.Text = _server.ServerNote;
        }

        private void PopulateNavContextMenu()
        {
            //hide all items
            foreach (ToolStripItem i in cmAssetList.Items)
                i.Visible = false;
            if (AssetNav.SelectedNode == null)
                return;

            if (AssetNav.SelectedNode.Level == (int)NavLevels.Customer)
            {
                tsiCustomer.Visible = true;

            }
            else if (AssetNav.SelectedNode.Level == (int)NavLevels.Market)
            {
                tsiMarket.Visible = true;
            }
            else if (AssetNav.SelectedNode.Level == (int)NavLevels.Server)
            {
                tsiServer.Visible = true;
            }
        }

        #endregion

        #region Refresh / Load

        public void RefreshServer()
        {
            if (_server == null)
                return;
            Populate_AssetNav();
            LoadServer((int)_server.ID);
        }

        /// <summary>
        /// Loads a server based on id
        /// </summary>
        /// <param name="server_id"></param>
        public void LoadServer(int server_id)
        {
            _server = MagicInfoServer.GetByID(server_id);
            Populate();
        }
        #endregion

        #region AssetNav 
        /// <summary>
        /// Determines if a server has been selected in the navigation tree and if so it populates the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerList_Clicked(Object sender, TreeViewEventArgs e)
        {
            SelectedLevel = (NavLevels)AssetNav.SelectedNode.Level;
            if (AssetNav.SelectedNode.Level == (int)NavLevels.Server)
            {
                _server = MagicInfoServer.GetByID((int)AssetNav.SelectedNode.Tag) ?? _server;
                Populate();
            }
            else if (AssetNav.SelectedNode.Level == (int)NavLevels.Market)
            {
                _market = MagicInfoMarket.GetByID((int)AssetNav.SelectedNode.Tag) ?? _market;
                _server = MagicInfoServer.GetByID((int)_market.Server_ID);
                Populate();

            }
        }

        /// <summary>
        /// Handles event when tree node is clicked in Nav Tree. 
        /// Sets selected node to the clicked node and expands or collapses the node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssetNav_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
         
            AssetNav.SelectedNode = e.Node;

            if (AssetNav.SelectedNode == null)
                return;


            SelectedLevel = (NavLevels)AssetNav.SelectedNode.Level;

            if (e.Button != MouseButtons.Right && SelectedLevel == NavLevels.Customer)
            {
                if (AssetNav.SelectedNode.IsExpanded)
                    AssetNav.SelectedNode.Collapse();
                else
                {
                    AssetNav.SelectedNode.Expand();
                    AssetNav.SelectedNode.ExpandAll();    
                }
                    
            }

            PopulateNavContextMenu();

            return;
        }
        
        /// <summary>
        /// handles edit customer event from context menu in nav tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SelectedLevel != NavLevels.Customer || AssetNav.SelectedNode == null)
                return;
            MagicInfoCustomer c = MagicInfoCustomer.GetByID((int)AssetNav.SelectedNode.Tag);
            ShowCustomerEditor(c);
        }

        /// <summary>
        /// handles edit market event for context menu in nav tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (SelectedLevel != NavLevels.Market || AssetNav.SelectedNode == null)
                return;
            MagicInfoMarket m = MagicInfoMarket.GetByID((int)AssetNav.SelectedNode.Tag);
            ShowMarketEditor((int)_server.ID, (int)m.Customer_ID, m);
        }

        /// <summary>
        /// handles edit server event for context menu in nav tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (_server == null)
                return;
            else
            {
                ShowServerEditor((int)_server.Customer_ID, _server);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SelectedLevel == NavLevels.Market && AssetNav.SelectedNode != null)
            {
                MagicInfoMarket m = MagicInfoMarket.GetByID((int)AssetNav.SelectedNode.Tag);
                ShowServerEditor((int)m.Customer_ID);
            }
        }

        private void addServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowServerEditor((int)AssetNav.SelectedNode.Tag);
        }

        #endregion

        #region SubForms

        /// <summary>
        /// Creates the LFd Editor form and inits based on if an lfd is selected in lfd table
        /// </summary>
        private void ShowLFDEditor()
        {
            using (FormLFDEditor _form = new FormLFDEditor())
            {
                if (_server == null)
                    return;
                if (olvLFDList.SelectedObject == null)
                    _form.Init(_server);
                else
                    _form.Init(_server, (olvLFDList.SelectedObject as MagicInfoAsset));

                if(!_form.IsDisposed)
                    _form.ShowDialog();
            }
            Populate();
        }

        /// <summary>
        /// Creates the customer editor form and populates it if a customer is selected
        /// </summary>
        /// <param name="customer"></param>
        private void ShowCustomerEditor(MagicInfoCustomer customer = null)
        {
            if (customer == null)
            {
                using (FormCustomerEditor _form = new FormCustomerEditor())
                {
                    _form.ShowDialog();
                }
            }
            else
            {
                using (FormCustomerEditor _form = new FormCustomerEditor(customer))
                {
                    _form.ShowDialog();
                }
            }
            Populate_AssetNav();
            Populate();
        }

        /// <summary>
        /// Creates the market editor form and populates it if a market is selected
        /// </summary>
        /// <param name="selectedCustomerID"></param>
        /// <param name="market"></param>
        private void ShowMarketEditor(int selectedServerID, int selectedCustomerID, MagicInfoMarket market = null)
        {
            if (market == null)
            {
                using (FormMarketEditor _form = new FormMarketEditor(selectedServerID, selectedCustomerID))
                {
                    _form.ShowDialog();
                }
            }
            else
            {
                using (FormMarketEditor _form = new FormMarketEditor(selectedServerID, selectedCustomerID, market))
                {
                    _form.ShowDialog();
                }
            }
            Populate_AssetNav();
            Populate();
        }

        /// <summary>
        /// Creates the server editor form and populates it if server is selected
        /// </summary>
        /// <param name="selected_market"></param>
        /// <param name="selected_customer"></param>
        /// <param name="server"></param>
        private void ShowServerEditor(int selected_customer, MagicInfoServer server = null)
        {
            if (server == null)
            {
                using (FormServerEditor _form = new FormServerEditor(selected_customer))
                {
                    _form.ShowDialog();
                }
            }
            else
            {
                using (FormServerEditor _form = new FormServerEditor(selected_customer, server))
                {
                    _form.ShowDialog();
                }
            }
            Populate_AssetNav();
            Populate();
        }

        /// <summary>
        /// create the ticket creation form and calls the load ticket event 
        /// </summary>
        /// <param name="server_id"></param>
        /// <param name="asset_id"></param>
        public void ShowTicketCreate(int server_id, int? asset_id = null)
        {
            using (FormTicketCreation _form = new FormTicketCreation(server_id, asset_id))
            {
                var result = _form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int? id = _form.GetTicketID();
                    TicketLoadEvent?.Invoke(id);
                }
            }
        }

        #endregion

        #region Action Bar

        /// <summary>
        /// Handles add customer event from tool strip in top action bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCustomerEditor();
        }

        /// <summary>
        /// handles edit customer event for tools strip on top action bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedLevel != NavLevels.Customer || AssetNav.SelectedNode == null)
                return;
            MagicInfoCustomer c = MagicInfoCustomer.GetByID((int)AssetNav.SelectedNode.Tag);
            ShowCustomerEditor(c);
        }

        /// <summary>
        /// handles add market event for tool strip in top action bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiAddMarket_Click(object sender, EventArgs e)
        {
            if (SelectedLevel != NavLevels.Server || AssetNav.SelectedNode == null)
                return;

            MagicInfoServer s = MagicInfoServer.GetByID((int)AssetNav.SelectedNode.Tag);

            ShowMarketEditor((int)s.ID, (int)s.Customer_ID);
        }

        /// <summary>
        /// handles edit market event for tool strip in top action bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiEditMarket_Click(object sender, EventArgs e)
        {
            if (SelectedLevel == NavLevels.Market && AssetNav.SelectedNode != null)
            {
                MagicInfoMarket m = MagicInfoMarket.GetByID((int)AssetNav.SelectedNode.Tag);
                ShowMarketEditor((int)m.Server_ID, (int)m.Customer_ID, m);
            }
        }

        /// <summary>
        /// handles edit server event for tool strip in top action bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiEditServer_Click(object sender, EventArgs e)
        {
            if (_server == null)
                return;
            else
            {
                ShowServerEditor((int)_server.Customer_ID, _server);
            }
        }

        
        #endregion

        #region Server Tabs Controls

        /// <summary>
        /// Handles Add LFd button click by calling function to open LFD editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLFD_Click(object sender, EventArgs e)
        {
            ShowLFDEditor();
        }
        /// <summary>
        /// Handles event for context menu edit option click.  
        /// Opens LFD Editor if lfd is selected in table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cmEditLFD_Click(object sender, EventArgs e)
        {
            if (olvLFDList.SelectedIndex != -1)
                ShowLFDEditor();
        }

        /// <summary>
        /// handles edit lfd event for LFd Edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowLFDEditor();
        }

        /// <summary>
        /// Hides Edit ld button if no lfd is selected in lfd table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void olvLFDList_SelectionChanged(object sender, EventArgs e)
        {
            if (olvLFDList.SelectedIndex != -1)
                btnEdit.Visible = true;
            else
                btnEdit.Visible = false;
        }

        /// <summary>
        /// handles the create ticket event for the create ticket button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            if (_server == null)
                return;
            ShowTicketCreate((int)_server.ID);
        }

        /// <summary>
        /// handles the create ticket event for the context menu in the lfd table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (olvLFDList.SelectedObject == null)
                return;
            ShowTicketCreate((int)_server.ID, (int)(olvLFDList.SelectedObject as MagicInfoAsset).ID);
        }

        /// <summary>
        /// handles the formatting of the ticket table based on ticket status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void olvTickets_FormatRow(object sender, FormatRowEventArgs e)
        {
            if (_server == null)
                return;

            MagicInfoTicket t = (e.Model as MagicInfoTicket);
            e.Item.BackColor = t.TicketStatus.StatusColor;
        }

        /// <summary>
        /// call load ticket event based on the ticket double clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void olvTickets_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (_server == null || olvTickets.SelectedItem == null)
                return;
            MagicInfoTicket t = (olvTickets.SelectedObject as MagicInfoTicket);
            TicketLoadEvent?.Invoke(t.ID);
        }

        /// <summary>
        /// Handles the edit note event for the edit ote button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditNote_Click(object sender, EventArgs e)
        {
            if (_server == null)
                return;
            if (rtbxNote.ReadOnly == true)
            {
                rtbxNote.ReadOnly = false;
                btnEditNote.Text = "Save";
                rtbxNote.BackColor = Color.White;
                rtbxNote.Focus();
                return;
            }
            else
            {
                rtbxNote.ReadOnly = true;
                btnEditNote.Text = "Edit Note";
                rtbxNote.BackColor = Color.Silver;
                MagicInfoServer.UpdateNote((int)_server.ID, rtbxNote.Text);
            }
        }


        #endregion

        #region Actions
        private void actionsComponent1_OpenServerEvent()
        {
            if (_server.IsUrl)
                Process.Start($"https://{_server.IP}/MagicInfo");
            else
                Process.Start($"http://{_server.IP}:{_server.Port}/MagicInfo");
        }





        #endregion

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            if (_server == null)
                return;
            btnNewContact.Enabled = false;
            ContactComponent cc = new ContactComponent();
            cc.Init();
            cc.ContactSaveEvent += new ContactComponent.SaveContact(SaveContact);
            floContactList.Controls.Add(cc);
            floContactList.Controls.SetChildIndex(cc, 0);
            
        }

        private void SaveContact(MagicInfoContacts cc)
        {
            if (_server == null || cc == null)
            {
                btnNewContact.Enabled = true;
                return;
            }
                

            cc.Server_Fky = (int)_server.ID;
            if (cc.ID == null)
                MagicInfoContacts.AddNew(cc);
            else
                MagicInfoContacts.Update(cc);
            btnNewContact.Enabled = true;
        }

        private void addMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagicInfoServer s = MagicInfoServer.GetByID((int)AssetNav.SelectedNode.Tag);
            ShowMarketEditor((int)s.ID, (int)s.Customer_ID);
        }

        private void addLFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLFDEditor();
        }

 
    }
}
