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
    /// <summary>
    /// self contained User Control for Customer info
    /// This control should not interact with outside controls or update sql DB
    /// </summary>
    public partial class CustomerComponent : UserControl
    {
        //Stored copy of Customer
        private MagicInfoCustomer _customer;

        /// <summary>
        /// creates empy a customer user control.
        /// </summary>
        public CustomerComponent()
        {
            InitializeComponent();
            _customer = new MagicInfoCustomer();
        }

        /// <summary>
        /// Makes all text fields Readonly
        /// True is read only
        /// </summary>
        /// <param name="isReadOnly"></param>
        public void ReadOnly(bool isReadOnly)
        {
            tbxName.ReadOnly = isReadOnly;
            tbxTag.ReadOnly = isReadOnly;
        }

        /// <summary>
        /// Populates text fields based on customer and stores a copy of customer
        /// </summary>
        /// <param name="customer"></param>
        public void Populate(MagicInfoCustomer customer)
        {
            if (customer == null)
                return;
            _customer = customer;
            tbxName.Text = customer.Name;
            tbxTag.Text = customer.Tag;
        }

        /// <summary>
        /// Returns a customer based on the text fields
        /// </summary>
        /// <returns></returns>
        public MagicInfoCustomer GetCustomer()
        {
            _customer.Name = tbxName.Text;
            _customer.Tag = tbxTag.Text;
            return _customer;
        }

        /// <summary>
        /// Clears all textboxes and the stored customer
        /// </summary>
        public void Clear()
        {
            _customer = new MagicInfoCustomer();
            IEnumerable<TextBox> allTbx = grpCustomerInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
        }

        /// <summary>
        /// Iterates through all textboxes to see if they are blank. If they are it colors them red, if they are not it colors them green
        /// </summary>
        /// <TODO>Add ability to set color data and more advanced validating</TODO>
        /// <returns>returns true if all fields have text</returns>
        public bool isComplete()
        {
            Color failColor = Color.Salmon;
            Color goodColor = Color.PaleGreen;
            bool isComplete = true;

            
            IEnumerable<TextBox> allTbx = grpCustomerInfo.Controls.Cast<Control>().OfType<TextBox>();

            foreach (TextBox tbx in allTbx)
            {
                if (tbx.Text == string.Empty)
                {
                    tbx.BackColor = failColor;
                    isComplete = false;
                }
                else
                    tbx.BackColor = goodColor;
            }
            return isComplete;
        }
    }
}
