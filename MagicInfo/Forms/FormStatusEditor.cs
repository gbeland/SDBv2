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
    public partial class FormStatusEditor : Form
    {
        public FormStatusEditor()
        {
            InitializeComponent();
            ucStatusEditor1.Populate();
        }
    }
}
