using SDB.MagicInfo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB.MagicInfo.Forms
{
    /// <summary>
    /// creates a window for customer editor uc and passing along its data
    /// </summary>
    public partial class FormCustomerEditor : Form
    {
        public FormCustomerEditor()
        {
            InitializeComponent();

        }
        public FormCustomerEditor(MagicInfoCustomer customer)
        {
            InitializeComponent();
            ucCustomerEditor1.Init(customer);
        }
        
    }
}
