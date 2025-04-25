using SDB.MagicInfo.Classes;
using SDB.MagicInfo.Components;
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
    public partial class FormMagicInfoAlert : Form
    {
        public delegate void LoadTicket(int? ticket_id);
        public event LoadTicket TicketLoadEvent;

        public FormMagicInfoAlert()
        {
            InitializeComponent(); 
        }
        
        public int UpdateAlerts()
        {
            MagicInfoAlertData data = MagicInfoAlertData.GetAlerts();
            int i = 0;
            floAlertList.Controls.Clear();

            foreach (MagicInfoAlertData.AlertData d in data.Data)
            {
                AlertComponent ac = new AlertComponent();

                ac.TicketLoadEvent += new AlertComponent.LoadTicket(LoadAlertTicket);
                ac.lblAlertName.Text = "Name: " + d.UID;
                string s = "";

                if (d.IgnoreAlert)
                    continue;

                s = "Error";
                if (!d.HasContent)
                    s = "| No Content |";
                if(!d.InputSourceIsValid)
                    s = "| Invalid Input Type |";
                if (!d.Connected)
                    s = "| No Connection |";


                ac.lblAlertType.Text = "Alert: " + s;
                ac.MAC = d.Name;
                floAlertList.Controls.Add(ac);

                i++;
            }
            return i;
        }

        public int GetCount()
        {
            return floAlertList.Controls.Count;
        }

        void LoadAlertTicket(int? ticket_id)
        {
            TicketLoadEvent?.Invoke(ticket_id);
            Hide();
        }

        private void FormMagicInfoAlert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                UpdateAlerts();
        }

        private void FormMagicInfoAlert_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void FormMagicInfoAlert_Load(object sender, EventArgs e)
        {
            UpdateAlerts();
        }
    }
}
