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

namespace SDB.MagicInfo.Components
{
    public partial class ConfidentialComponent : UserControl
    {
        MagicInfoCustomer _customer;
        MagicInfoMarket _market;
        MagicInfoServer _server;
        MagicInfoAsset _asset;
        MagicInfoTicket _ticket;

        public ConfidentialComponent()
        {
            InitializeComponent();
            addressComponent1.ShowButtons(false);
        }

        public void Populate(MagicInfoTicket ticket)
        {
            if (ticket == null)
                return;
            _ticket = ticket;
            _server = MagicInfoServer.GetByID((int)_ticket.Server_fky);
            if (_ticket.Asset_fky != null)
            {
                _asset = MagicInfoAsset.GetByID((int)_ticket.Asset_fky);
                addressComponent1.Populate(_asset.Address_ID);
                addressComponent1.SetAddressName("Asset");
            }
            else
            {
                addressComponent1.Populate(_server.Address_ID);
                addressComponent1.SetAddressName("Server");
            }

            //_market = MagicInfoMarket.GetByID((int)_server.Market_ID);
            _customer = MagicInfoCustomer.GetByID((int)_server.Customer_ID);

            tbxCustomer.Text = _customer.Name;
            //tbxMarket.Text = _market.Name;
            tbxServerName.Text = _server.Name;
            tbxServerAlias.Text = _server.Alias;
            tbxServerIP.Text = _server.IP;
            tbxServerPort.Text = _server.Port;

            if (_asset != null)
            {
                tbxAssetName.Text = _asset.Name;
                tbxAssetAlias.Text = _asset.Alias;
                tbxAssetIP.Text = _asset.IP;
            }

            tbxServerUserName.Text = _server.ServerUsername;
            tbxServerPassword.Text = _server.ServerPassword;

            tbxTVID.Text = _server.TeamviewerID;
            tbxTVPassword.Text = _server.TeamviewerPassword;


        }

        /// <summary>
        /// Locks or unlocks the text fields by making them readonly
        /// True means that all fields will be readonly
        /// </summary>
        public void ReadOnly(bool makeReadonly = true)
        {
            IEnumerable<TextBox> allTbx = grpCustomerInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.ReadOnly = makeReadonly;
            allTbx = grpServerInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.ReadOnly = makeReadonly;
            allTbx = grpAssetInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.ReadOnly = makeReadonly;
            allTbx = grpCred.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.ReadOnly = makeReadonly;
            addressComponent1.ReadOnly(makeReadonly);
        }

        /// <summary>
        /// Clears al text fields and clears the stored objects
        /// </summary>
        public void Clear()
        {
            _ticket = new MagicInfoTicket();
            _asset = new MagicInfoAsset();
            _market = new MagicInfoMarket();
            _customer = new MagicInfoCustomer();
            _server = new MagicInfoServer();

            IEnumerable<TextBox> allTbx = grpCustomerInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
            allTbx = grpServerInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
            allTbx = grpAssetInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
            allTbx = grpCred.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
            addressComponent1.Clear();
        }

    }
}
