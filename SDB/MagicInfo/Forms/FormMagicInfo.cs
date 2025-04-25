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
    public partial class FormMagicInfo : Form
    {

        FormMagicInfoAlert FormAlert;
        public FormMagicInfo()
        {
            InitializeComponent();
            FormAlert = new FormMagicInfoAlert();
            FormAlert.TicketLoadEvent += new FormMagicInfoAlert.LoadTicket(Load_TicketEvent);
        }

        #region Methods

        #endregion

        #region Events

        /// <summary>
        /// Handles Form Closing Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMagicInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMagicInfo_Shown(object sender, EventArgs e)
        {
            ucAssetMagicInfo1.Init();
            ucMagicInfoTracker1.RefreshTracker();
        }



        #endregion

        private void Load_TicketEvent(int? ticket_id)
        {
            tabControl.SelectedTab = tabTickets;
            ticketLFD1.Load_Ticket(ticket_id);
        }

        private void FormMagicInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                RefreshAll();
        }

        private void Load_ServerEvent(int? server_id)
        {
            tabControl.SelectedTab = tabAsset;
            ucAssetMagicInfo1.LoadServer((int)server_id);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    ucMagicInfoTracker1.RefreshTracker();
                    break;
                case 1:
                    ticketLFD1.RefreshTicket();
                    break;
                case 2:
                    ucAssetMagicInfo1.RefreshServer();
                    break;
            }


        }

        private void RefreshAll()
        {
            ucMagicInfoTracker1.RefreshTracker();
            ucAssetMagicInfo1.RefreshServer();
            ticketLFD1.RefreshTicket();
        }

        private void statusListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormStatusEditor _form = new FormStatusEditor())
            {
                _form.ShowDialog();
            }
            RefreshAll();
        }


        private void solutionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormSolutionEditor _form = new FormSolutionEditor())
            {
                _form.ShowDialog();
            }
            RefreshAll();
        }


        private void issueListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormIssueEditor _form = new FormIssueEditor())
            {
                _form.ShowDialog();
            }
            RefreshAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void AlertCheckTimer_Tick(object sender, EventArgs e)
        {
          //  int a = FormAlert.UpdateAlerts();
            //if (a > 0)
            //{
            //   // btnAlerts.Text = "Alerts [" + a + "]";
            //    AlertFlasher.Enabled = true;
            //}
            //else
            //{
            //    AlertFlasher.Enabled = false;
              //  btnAlerts.BackColor = Color.Silver;
         //   }
        }

        private void FormMagicInfo_VisibleChanged(object sender, EventArgs e)
        {
          //  if (Visible)
           //     AlertCheckTimer.Enabled = true;
        }

        private void AlertFlasher_Tick(object sender, EventArgs e)
        {
          //  if (btnAlerts.BackColor == Color.Silver)
             //   btnAlerts.BackColor = Color.Salmon;
         //   else
         //       btnAlerts.BackColor = Color.Silver;
        }



        private void btnAlerts_Click(object sender, EventArgs e)
        {
        //    FormAlert.Show();
        //    btnAlerts.Text = "Alerts [" + FormAlert.GetCount() + "]";   
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var _form = new FormReporting() )
            {
                _form.ShowDialog();
            }
        }
    }
}
