using SDB.Classes.General;
using SDB.Classes.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB.Forms.Eparts
{
    public partial class FormEpartsJournal : Form
    {
        SDB.Classes.Eparts.Eparts Eparts;

        public FormEpartsJournal(SDB.Classes.Eparts.Eparts _eparts)
        {
            InitializeComponent();

            cmbStatus.Items.AddRange(Classes.Eparts.Eparts.GetAllStatuses().ToArray());
            cmbStatus.Items.Remove("ReOpened");
            Eparts = _eparts;

            Populate();
        }

        private void Populate()
        {
            Eparts.Populate();
            if (Eparts == null || Eparts.Journal == null)
                return;

            dgvJournal.SuspendLayout();

            var journal = Eparts.Journal;
            journal = journal.OrderByDescending(x => x.Date.ToString()).ToList();
            dgvJournal.Rows.Clear();
            foreach(var j in journal)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvJournal);
                row.Cells[0].Value = ClassUser.GetFirstL(j.User_ID);
                row.Cells[1].Value = $"{j.Date:yyyy-MM-dd HH:mm:ss}";
                row.Cells[2].Value = j.Entry;

                row.DefaultCellStyle.ForeColor = j.System_Msg ? ClassJournalItem.COL_JOURNAL_SYSTEM_BLUE_FG : Color.Black;
                

                dgvJournal.Rows.Add(row);
            }
            dgvJournal.Sort(colDate, ListSortDirection.Descending);
            dgvJournal.ResumeLayout();

        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if (Eparts == null)
                return;
            if (cmbStatus.SelectedIndex == -1)
                return;

            ucSpellCheckSmall1.txtData.SelectAll();
            var userText = ucSpellCheckSmall1.txtData.Selection.Text.Trim();

            if (userText == "")
                return;

            Classes.Eparts.Eparts.UpdateStatus(Eparts, cmbStatus.Text);

            var entry = new Classes.Eparts.Eparts.EpartsEntry
            {
                Entry = userText,
                Date = DateTime.Now,
                User_ID = GS.Settings.LoggedOnUser.ID,
                System_Msg = false,
                Eparts_ID = (int)Eparts.ID
            };
            SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);

            Populate();

            ucSpellCheckSmall1.txtData.Selection.Text = "";
            Refresh();
        }
    }
}
