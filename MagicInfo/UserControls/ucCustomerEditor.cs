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
    /// <summary>
    /// User controll for editing and adding customer and its address
    /// </summary>
    public partial class ucCustomerEditor : UserControl
    {
        enum Mode
        {
            NEW,
            EDIT
        }
        private Mode _mode = Mode.NEW;

        public ucCustomerEditor()
        {
            InitializeComponent();
            customerComponent1.ReadOnly(false);
        }
    
        public void Init(MagicInfoCustomer customer)
        {
            _mode = Mode.EDIT;
            Populate(customer);
        }

        public void Populate(MagicInfoCustomer customer)
        {
            customerComponent1.Populate(customer);
            addressComponent1.Populate(customer.Address_ID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private bool isComplete()
        {
            if (addressComponent1.isComplete() & customerComponent1.isComplete())
                return true;
            else return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!isComplete())
            {
                SystemSounds.Asterisk.Play();
                return;
            }
            if (addressComponent1.GetAddressID() == null)
            {
                MagicInfoAddress address = addressComponent1.GetAddress();
                MagicInfoAddress.AddNew(ref address);
            }
            MagicInfoCustomer c = customerComponent1.GetCustomer();
            c.Address_ID = addressComponent1.GetAddressID();

            if (_mode == Mode.NEW)
            {
                MagicInfoCustomer.AddNew(c);
            }
            else
            {
                MagicInfoCustomer.Update(c);
            }

            ParentForm.Close();
        }
    }
}
