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
    public partial class ucSolutionEditor : UserControl
    {
        public ucSolutionEditor()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            olvSolution.Objects = MagicInfoSolution.GetAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            olvSolution.AddObject(new MagicInfoSolution());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (MagicInfoSolution s in olvSolution.Objects)
            {
                if (s.ID == null)
                {
                    if (s.Solution != null)
                    {
                        MagicInfoSolution.AddNew(s);
                    }
                }
                else MagicInfoSolution.Update(s);
            }


            ParentForm.Close();
        }
    }
}
