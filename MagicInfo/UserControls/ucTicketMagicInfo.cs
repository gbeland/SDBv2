using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using System.Speech.Synthesis;
using SDB.MagicInfo.Classes;
using SDB.MagicInfo.Forms;
using System.Diagnostics;

namespace SDB.MagicInfo.UserControls
{
    public partial class ucTicketMagicInfo : UserControl
    {
        private MagicInfoTicket _ticket;


        public ucTicketMagicInfo()
        {
            InitializeComponent();

            // Make components readonly
            ticketInfoComponent1.ReadOnly();
            confidentialComponent1.ReadOnly();

        }

        public void RefreshTicket()
        {
            if (_ticket == null)
                return;
            Populate((int)_ticket.ID);
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if (_ticket == null)
                return;

            using (FormJournalEntry _form = new FormJournalEntry(_ticket))
            {
                _form.ShowDialog();
            }
            Populate((int)_ticket.ID);
        }


        private void BtnCloseTicket_Click(object sender, EventArgs e)
        {
            if (_ticket == null)
                return;
            if (_ticket.CurrentStatus_fky == MagicInfoStatus.GetByName("Closed").ID)
            {
                ReopenTicket();
                return;
            }


            if (cblSolutions.SelectedItem == null)
            {
                MessageBox.Show("Please Select Solution");
                return;
            }
            CloseTicket();
        }

        public void ReopenTicket()
        {
            if (_ticket == null)
                return;
            _ticket.CloseDate = null;
            _ticket.CurrentStatus_fky = MagicInfoStatus.GetByName("Opened").ID;
            MagicInfoTicket.Update(_ticket);
            MagicInfoJournalEntry entry = new MagicInfoJournalEntry
            {
                Entry = "Ticket Reopened.",
                ExpireDate = DateTime.Now.AddMinutes(5),
                StartDate = DateTime.Now,
                User_fky = GS.Settings.LoggedOnUser.ID,
                Status_fky = (int)MagicInfoStatus.GetByName("Opened").ID,
                Ticket_fky = (int)_ticket.ID,
            };
            MagicInfoJournalEntry.AddNew(entry);
            Populate((int)_ticket.ID);
        }

        public void Populate(int ticket_id)
        {
            _ticket = MagicInfoTicket.GetByID(ticket_id);
            if (_ticket == null)
                return;
            if (_ticket.CurrentStatus_fky == MagicInfoStatus.GetByName("Closed").ID)
            {
                btnAddEntry.Enabled = false;
                btnCloseTicket.Text = "Reopen";
            }
            else
            {
                btnCloseTicket.Text = "Close Ticket";
                btnAddEntry.Enabled = true;
            }


            cblSolutions.Items.Clear();
            foreach (MagicInfoSolution s in MagicInfoSolution.GetAllEnabled())
            {
                int index =cblSolutions.Items.Add(s);
            }
            cblSolutions.DisplayMember = "Solution";

            ticketInfoComponent1.Populate(_ticket);
            confidentialComponent1.Populate(_ticket);

            List<MagicInfoJournalEntry> journal = MagicInfoJournalEntry.GetAllByTicketID((int)_ticket.ID);
            ticketJournalComponent1.Populate(journal);
            ticketInfoComponent1.Populate(_ticket);

            Refresh();
        }

        public void CloseTicket()
        {
            if (_ticket == null)
                return;
            

            MagicInfoSolution solution = (cblSolutions.SelectedItem as MagicInfoSolution);
            MagicInfoJournalEntry entry = new MagicInfoJournalEntry
            {
                Entry = "Closed as " + solution.Solution,
                ExpireDate = DateTime.Now,
                StartDate = DateTime.Now,
                User_fky = GS.Settings.LoggedOnUser.ID,
                Status_fky = (int)MagicInfoStatus.GetByName("Closed").ID,
                Ticket_fky = (int)_ticket.ID,
            };
            MagicInfoJournalEntry.AddNew(entry);
            _ticket.Solution_fky = solution.ID;
            _ticket.CurrentStatus_fky = entry.Status_fky;
            _ticket.CloseDate = DateTime.Now;
            MagicInfoTicket.Update(_ticket);
            Populate((int)_ticket.ID);
        }

        public void Load_Ticket(int? ticket_id)
        {
            if (ticket_id == null)
                return;
            Populate((int)ticket_id);
        }

        private void cblSolutions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < cblSolutions.Items.Count; ++ix)
                if (ix != e.Index) cblSolutions.SetItemChecked(ix, false);
        }

        private void actionsComponent1_OpenServerEvent()
        {
            if (_ticket == null)
                return;
            MagicInfoServer s = MagicInfoServer.GetByID((int)_ticket.Server_fky);
            Process.Start($"http://{s.IP}:{s.Port}/MagicInfo");
        }
    }
}
