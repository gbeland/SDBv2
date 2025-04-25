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

namespace SDB.MagicInfo.UserControls
{
    public partial class ucIssueEditor : UserControl
    {
        public ucIssueEditor()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            olvIssue.Objects = MagicInfoIssue.GetAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            olvIssue.AddObject(new MagicInfoIssue());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (MagicInfoIssue i in olvIssue.Objects)
            {
                if (i.ID == null)
                {
                    if (i.Issue != null)
                    {
                        MagicInfoIssue.AddNew(i);
                    }
                }
                else MagicInfoIssue.Update(i);
            }
            ParentForm.Close();
        }
    }
}
