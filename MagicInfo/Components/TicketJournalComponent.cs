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
    public partial class TicketJournalComponent : UserControl
    {
        List<MagicInfoJournalEntry> _journal;


        public TicketJournalComponent()
        {
            InitializeComponent();

        }

        public void Populate(List<MagicInfoJournalEntry> journal)
        {
            if (journal == null)
                return;
            _journal = journal;

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            int height = 30;
            foreach(MagicInfoJournalEntry e in journal)
            {
                
                int r = dataGridView1.Rows.Add(e.EntryUser.FirstL, $"{e.StartDate:yyyy-MM-dd HH:mm:ss}", e.Entry, e.EntryStatus.Status, $"{e.ExpireDate:yyyy-MM-dd HH:mm:ss}");
                dataGridView1.Rows[r].DefaultCellStyle.BackColor = e.EntryStatus.StatusColor;
                dataGridView1.Rows[r].DefaultCellStyle.SelectionBackColor = e.EntryStatus.StatusColor;
                height += dataGridView1.Rows[r].Height;
            }
            if(height > dataGridView1.Height)
                dataGridView1.Height = height;
            dataGridView1.Sort(colDate, ListSortDirection.Descending);
            dataGridView1.Refresh();
        }
    }
}
