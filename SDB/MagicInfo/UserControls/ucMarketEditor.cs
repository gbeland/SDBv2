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
using System.Media;

namespace SDB.MagicInfo.UserControls
{
    public partial class ucMarketEditor : UserControl
    {
        enum Mode
        {
            NEW,
            EDIT
        }
        private Mode _mode = Mode.NEW;

        private int? _selectedCustomerID;
        private int _selectedServerID;

        public ucMarketEditor()
        {
            InitializeComponent();
            marketComponent1.ReadOnly(false);
        }

        public void Init(int selectedServer, int selectedCustomerID, MagicInfoMarket market = null)
        {
            _selectedCustomerID = selectedCustomerID;
            _selectedServerID = selectedServer;
            if (market != null)
            {
                _mode = Mode.EDIT;
                Populate(market);
            }
        }

        public void Populate(MagicInfoMarket market)
        {
            marketComponent1.Populate(market);
            addressComponent1.Populate((int)market.Address_ID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private bool isComplete()
        {
            if (addressComponent1.isComplete() & marketComponent1.isComplete())
                return true;
            else return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isComplete())
            {
                SystemSounds.Asterisk.Play();
                return;
            }
            if (addressComponent1.GetAddressID() == null)
            {
                MagicInfoAddress address = addressComponent1.GetAddress();
                MagicInfoAddress.AddNew(ref address);
            }

            MagicInfoMarket m = marketComponent1.GetMarket();
            m.Address_ID = addressComponent1.GetAddressID();
            m.Customer_ID = _selectedCustomerID;
            m.Server_ID = _selectedServerID;

            if (_mode == Mode.NEW)
            {
                MagicInfoMarket.AddNew(m);
            }
            else
            {
                MagicInfoMarket.Update(m);
            }

            ParentForm.Close();
        }
    }
}

