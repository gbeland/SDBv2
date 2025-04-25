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
using SDB.Classes.General;
using SDB.MagicInfo.Forms;

namespace SDB.MagicInfo.UserControls
{
    public partial class ucMagicInfoTracker : UserControl
    {
        public delegate void LoadTicket(int? ticket_id);
        public event LoadTicket TicketLoadEvent;
        public delegate void LoadServer(int? server_id);
        public event LoadServer ServerLoadEvent;

        List<MagicInfoTicket> _ticketList;
        List<MagicInfoStatus> _statusList;
        private readonly string AllOpenStatus = "All Open";

        public ucMagicInfoTracker()
        {
            InitializeComponent();

            _ticketList = new List<MagicInfoTicket>();
            _statusList = new List<MagicInfoStatus>();
            cmbTrackerFilter.DisplayMember = "Status";
            olcExpiration.AspectToStringConverter = x =>
            {
                if (x == null)
                    return string.Empty;

                var expireTime = (DateTime)x;
                var ts = expireTime - DateTime.Now;
                return ts.Ticks > 0 ? $"in {ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration())}" : $"{ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration())} ago";
            };
            olvTickets.PrimarySortColumn = olcExpiration;
            olvTickets.PrimarySortOrder = SortOrder.Ascending;
            olvTickets.SecondarySortColumn = olcStatus;
            olvTickets.SecondarySortOrder = SortOrder.Ascending;
        }

        public void RefreshTracker()
        {
            RefreshTimer.Enabled = true;
            UpdateStatusList();
            UpdateTicketList();
            CheckForExpired();
            Populate_StatusFilter();
            Populate_TrackerTickets();
        }

        private void Populate_StatusFilter()
        {
            cmbTrackerFilter.Items.Clear();
            if (_statusList.Count == 0)
            {
                cmbTrackerFilter.Items.Add("ERROR: Failed to load Status list [ucMAgicinfoTracker.cs | Populate_StatusFilter()]");
                return;
            }
            cmbTrackerFilter.Items.Add(AllOpenStatus);
            cmbTrackerFilter.Items.AddRange(_statusList.ToArray());
            cmbTrackerFilter.SelectedIndex = 0;
        }

        private void Populate_TrackerTickets()
        {
            if (_statusList.Count == 0)
                return;
            if (cmbTrackerFilter.SelectedIndex <= 0)
            {
                olvTickets.Objects = _ticketList;
                txtTicketQty.Text = _ticketList.Count().ToString();
            }
            else
            {
                MagicInfoStatus s = cmbTrackerFilter.SelectedItem as MagicInfoStatus;
                olvTickets.Objects = _ticketList.Where(t => t.CurrentStatus_fky == s.ID);
                txtTicketQty.Text = _ticketList.Where(t => t.CurrentStatus_fky == s.ID).Count().ToString();
            }
            
        }

        private void UpdateTicketList()
        {
            _ticketList = MagicInfoTicket.GetAllOpen();
        }

        private void UpdateStatusList()
        {
            _statusList = MagicInfoStatus.GetAll_IncludingSystemOnly();
        }

        private void olvTickets_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if(e.ColumnIndex == olcExpiration.Index)
            {
                MagicInfoTicket t = (e.Model as MagicInfoTicket);
                if (t.isExpired)
                    e.SubItem.BackColor = Color.Salmon;
                else
                    e.SubItem.BackColor = Color.PaleGreen;
            }
            if(e.ColumnIndex == olcStatus.Index)
            {
                MagicInfoTicket t = (e.Model as MagicInfoTicket);
                e.SubItem.BackColor = t.TicketStatus.StatusColor;
            }
        }

        private void cmbTrackerFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_statusList.Count == 0)
                return;
            Populate_TrackerTickets();

        }

        private void ShowJournalEntry(int ticket_id)
        {

            using (FormJournalEntry _form = new FormJournalEntry(MagicInfoTicket.GetByID(ticket_id)))
            {
                _form.ShowDialog();
            }
            RefreshTracker();
        }

        private void olvTickets_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            MagicInfoTicket t = e.Model as MagicInfoTicket;
            if (t == null)
                return;

            if (e.ColumnIndex == olcTicketID.Index)
                TicketLoadEvent?.Invoke(t.ID);
            else if (e.ColumnIndex == olcServer.Index || e.ColumnIndex == olcAsset.Index)
                ServerLoadEvent?.Invoke(t.Server_fky);
            else
                ShowJournalEntry((int)t.ID);
            e.Handled = true;

        }

        private void CheckForExpired()
        {
            foreach (MagicInfoTicket t in _ticketList)
            {
                if (t.isExpired && t.CurrentStatus_fky != MagicInfoStatus.GetByName("Expired").ID) 
                {
                    MagicInfoTicket.UpdateStatus(t, MagicInfoStatus.GetByName("Expired"));
                }
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshTracker();
        }
    }
}
