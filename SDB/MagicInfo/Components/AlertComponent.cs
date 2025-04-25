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
using SDB.MagicInfo.Forms;

namespace SDB.MagicInfo.Components
{
    
    public partial class AlertComponent : UserControl
    {
        public delegate void LoadTicket(int? ticket_id);
        public event LoadTicket TicketLoadEvent;

        public string MAC;
        public AlertComponent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOpenTicket_Click(object sender, EventArgs e)
        {
            MagicInfoAsset asset = MagicInfoAsset.GetAssetByMAC(MAC);
            if (asset == null)
                return;

            using (FormTicketCreation _form = new FormTicketCreation((int)asset.Server_ID, asset.ID))
            {
                var result = _form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int? id = _form.GetTicketID();
                    TicketLoadEvent?.Invoke(id);
                }
            }
        }
    }
}
