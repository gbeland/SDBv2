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
    public partial class ucServerEditor : UserControl
    {
        enum Mode
        {
            NEW,
            EDIT
        }
        private Mode _mode = Mode.NEW;
        private int _customer_id;


        public ucServerEditor()
        {
            InitializeComponent();
            serverComponent1.ReadOnly(false);
        }

        public void Init(int customer_id, MagicInfoServer server)
        {
            _customer_id = customer_id;

            if (server == null)
                return;

            _mode = Mode.EDIT;
            Populate(server);
        }

        public void Populate(MagicInfoServer server)
        {
            serverComponent1.Populate(server);
            addressComponent1.Populate(server.Address_ID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private bool isComplete()
        {
            if (addressComponent1.isComplete() & serverComponent1.isComplete())
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
            MagicInfoServer s = serverComponent1.GetServer();
            s.Address_ID = addressComponent1.GetAddressID();
            s.Customer_ID = _customer_id;
            if (_mode == Mode.NEW)
            {
                MagicInfoServer.AddNew(s);
            }
            else
            {
                MagicInfoServer.Update(ref s);
            }

            ParentForm.Close();
        }
    }
}
