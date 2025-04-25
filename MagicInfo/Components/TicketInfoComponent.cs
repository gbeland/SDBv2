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

namespace SDB.MagicInfo.Components
{
    public partial class TicketInfoComponent : UserControl
    {

        //Local Copy of ticket
        private MagicInfoTicket _ticket;


        public TicketInfoComponent()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Takes an ticket and sets the text fields based on the passed ticket. 
        /// It also stores local copy of the ticket
        /// </summary>
        public void Populate(MagicInfoTicket ticket)
        {
            if (ticket == null)
                return;
            _ticket = ticket;

            tbxTicketID.Text = string.Format("{0:D7}", _ticket.ID);
            tbxReportedAs.Text = _ticket.IssueText;
            tbxReportedBy.Text = _ticket.ReportedByUserName;
            tbxOpenDate.Text = _ticket.OpenDate.Value.ToLongDateString();
            if (_ticket.CloseDate != null)
            {
                TimeSpan ts = new TimeSpan(_ticket.CloseDate.Value.Ticks - _ticket.OpenDate.Value.Ticks);
                tbxCloseDate.Text = _ticket.CloseDate.Value.ToLongDateString();
                tbxDuration.Text = ts.Days.ToString() + " Days, " + ts.Hours.ToString() + " Hours";
            }
            else
            {
                TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - _ticket.OpenDate.Value.Ticks);
                tbxCloseDate.Text = "";
                tbxDuration.Text = ts.Days.ToString() + " Days, " + ts.Hours.ToString() + " Hours";
            }

            MagicInfoStatus s = _ticket.TicketStatus;
            grpTicketStatus.BackColor = s.StatusColor;
            lblStatus.Text = s.Status;
            Refresh();
        }

        /// <summary>
        /// Creates a new ticket based on the fields return it.
        /// </summary>
        public MagicInfoTicket GetTicket()
        {
            return _ticket;
        }

        /// <summary>
        /// Sets the stored ticket to new instance and clears all text fields
        /// </summary>
        public void Clear()
        {
            _ticket = new MagicInfoTicket();
            IEnumerable<TextBox> allTbx = grpTicketInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
            grpTicketStatus.BackColor = Color.Transparent;
            lblStatus.Text = "";
        }

        /// <summary>
        /// Sets all text fields readonly property
        /// </summary>
        /// <param name="isReadOnly"></param>
        public void ReadOnly(bool isReadOnly = true)
        {
            IEnumerable<TextBox> allTbx = grpTicketInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.ReadOnly = isReadOnly;
        }

        /// <summary>
        /// gets the ticket id of the currently stored ticket
        /// </summary>
        /// <returns></returns>
        public int? GetTicketID()
        {
            if (_ticket.ID == null)
                return null;
            else
                return _ticket.ID;
        }
    }
}
