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

namespace SDB.MagicInfo.UserControls
{
    
    public partial class ucJournalEntry : UserControl
    {
        MagicInfoTicket _ticket;
        List<MagicInfoJournalEntry> _journal;

        public ucJournalEntry()
        {
            InitializeComponent();
        }

        public void Init(MagicInfoTicket ticket)
        {
            _ticket = ticket;
            _journal = new List<MagicInfoJournalEntry>();
            _journal = MagicInfoJournalEntry.GetAllByTicketID((int)ticket.ID);
            ticketJournalComponent1.Populate(_journal);
            List<MagicInfoStatus> statusList = MagicInfoStatus.GetAll();

            cmbStatus.Items.AddRange(statusList.ToArray());
            MagicInfoStatus currentStatus = _ticket.TicketStatus;
            cmbStatus.Text = currentStatus.Status;
            grpStatus.BackColor = currentStatus.StatusColor;
            cmbStatus.Refresh();

            
        }

        public bool ValidateEntry()
        {
            bool isComplete = true;
            Color failColor = Color.Salmon;
            Color goodColor = Color.PaleGreen;

            ucSpellCheckLarge1.txtData.SelectAll();
            var userText = ucSpellCheckLarge1.txtData.Selection.Text.Trim();

            if (userText == string.Empty)
            {
                grpEntry.BackColor = failColor;
                isComplete = false;
            }
            else grpEntry.BackColor = goodColor;
            if (cmbStatus.SelectedIndex == -1)
            {
                isComplete = false;
                grpStatus.BackColor = failColor;
                grpStatus.Text = "Please Select A Status.";
            }
            else
            {
                grpStatus.Text = "Status";
            }
            return isComplete;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEntry())
                return;

            ucSpellCheckLarge1.txtData.SelectAll();
            var userText = ucSpellCheckLarge1.txtData.Selection.Text.Trim();
            MagicInfoStatus s = MagicInfoStatus.GetByName(cmbStatus.Text);
            var user_id = GS.Settings.LoggedOnUser.ID;

            DateTime expire = new DateTime();
            if (radExpires_HoursMinutes.Checked == true)
            {
                expire = DateTime.Now.AddHours((long)numExpires_Hours.Value).AddMinutes((long)numExpires_Minutes.Value);
            }
            else if(radExpires_Date.Checked == true)
            {
                expire = dtpExpires_Date.Value;
            }
            else if(radExpires_SameAsPrior.Checked == true)
            {
                expire = _journal.OrderByDescending(x => x.ExpireDate).First().ExpireDate.AddSeconds(1);
            }
            else
            {
                expire = DateTime.Now.AddMinutes(10);
            }
            MagicInfoJournalEntry entry = new MagicInfoJournalEntry
            {
                Entry = userText,
                ExpireDate = expire,
                StartDate = DateTime.Now,
                User_fky = user_id,
                Status_fky = (int)s.ID,
                Ticket_fky = (int)_ticket.ID,

            };
            MagicInfoJournalEntry.AddNew(entry);

            MagicInfoTicket.UpdateStatus(_ticket, s);
            ParentForm.Close();
        }

        private void radExpires_HoursMinutes_CheckedChanged(object sender, EventArgs e)
        {
            numExpires_Hours.Enabled = false;
            numExpires_Minutes.Enabled = false;
            dtpExpires_Date.Enabled = false;

            if (radExpires_HoursMinutes.Checked == true)
            {
                numExpires_Hours.Enabled = true;
                numExpires_Minutes.Enabled = true;
            }
            if(radExpires_Date.Checked == true)
            {
                dtpExpires_Date.Enabled = true;
            }
            if(radExpires_SameAsPrior.Checked == true)
            {
                var last = _journal.OrderByDescending(x => x.ExpireDate).First();
                txtExpires_SameAsPrior.Text = last.ExpireDate.ToString("g");
            }


        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            MagicInfoStatus selStatus = MagicInfoStatus.GetByName(cmbStatus.Text);
            grpStatus.BackColor = selStatus.StatusColor;
        }


    }
}
