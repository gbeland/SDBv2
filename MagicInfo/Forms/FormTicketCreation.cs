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
    public partial class FormTicketCreation : Form
    {
        public FormTicketCreation(int server_id, int? asset_id = null)
        {
            InitializeComponent();
            ucTicketCreation1.Init(server_id, asset_id);
        }

        public int? GetTicketID()
        {
            if (ucTicketCreation1._ticket == null)
                return null;
            return ucTicketCreation1._ticket.ID;
        }
    }
}
