using SDB.Classes.Asset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB.Forms.Asset
{
    public partial class FormPlayerSoftware_Select : Form
    {
        public ClassPlayerSoftware PlayerSoftware;

        public FormPlayerSoftware_Select()
        {
            InitializeComponent();

            var playerSoftware = ClassPlayerSoftware.GetAll().ToList();
            cmbplayerSoftware.DisplayMember = "DisplayMember";
            cmbplayerSoftware.ValueMember = "ID";
            cmbplayerSoftware.DataSource = playerSoftware;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
