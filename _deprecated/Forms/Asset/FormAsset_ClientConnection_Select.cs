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
    public partial class FormAsset_ClientConnection_Select : Form
    {
        public ClassClientConnection ClientConnection;
        public FormAsset_ClientConnection_Select()
        {
            InitializeComponent();

            var controllerConnections = ClassClientConnection.GetAll().ToList();
            cmbClientConnections.DisplayMember = "DisplayMember";
            cmbClientConnections.ValueMember = "ID";
            cmbClientConnections.DataSource = controllerConnections;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ClientConnection = (ClassClientConnection)cmbClientConnections.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
