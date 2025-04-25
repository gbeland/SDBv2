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
    public partial class FormServerEditor : Form
    {
        public FormServerEditor(int customer_id, MagicInfoServer server)
        {
            InitializeComponent();
            ucServerEditor1.Init(customer_id, server);
        }
        public FormServerEditor(int customer_id)
        {
            InitializeComponent();
            ucServerEditor1.Init(customer_id, null);
        }
    }
}
