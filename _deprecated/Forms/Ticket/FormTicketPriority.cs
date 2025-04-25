using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB.Forms.Ticket
{
    public partial class FormTicketPriority : Form
    {
        public FormTicketPriority()
        {
            InitializeComponent();
        }

        public int GetPriority()
        {
            if (radCritical.Checked)
                return 3;
            else if (radHigh.Checked)
                return 2;
            else return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radCritical.Checked && !radHigh.Checked && !radNormal.Checked)
                return;
            else DialogResult = DialogResult.OK;
            Close();
        }
    }
}
