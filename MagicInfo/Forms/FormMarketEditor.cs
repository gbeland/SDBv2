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
    public partial class FormMarketEditor : Form
    {
        public FormMarketEditor(int selectedServer, int selectedCustomerID)
        {
            InitializeComponent();
            ucMarketEditor1.Init(selectedServer, selectedCustomerID);
        }
        public FormMarketEditor(int selectedServer, int selectedCustomerID, MagicInfoMarket market = null)
        {
            InitializeComponent();
            ucMarketEditor1.Init(selectedServer, selectedCustomerID, market);
        }

    }
}
