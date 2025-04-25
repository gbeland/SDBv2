using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.UserControls
{
    public partial class ucRMADetails : UserControl
    {
        public ucRMADetails()
        {
            InitializeComponent();
        }

        public void Populate(ClassRMA rma)
        {
            tbxRMANum.Text = rma.ID.ToString();

            //TODO STATUS

            tbxCreatedBy.Text = rma.Creation_UserName;
            tbxCreatedDate.Text = rma.Creation_Date.ToShortDateString();

            tbxJobPO.Text = rma.PONumber == string.Empty ? rma.JobNumber : rma.PONumber;
            tbxAssignedTo.Text = rma.TechName; //TODO add link 
            cbxAPR.Checked = rma.IsAPR;
            cbxHot.Checked = rma.IsHot;
            tbxCreationNote.Text = rma.Notes;


        }

    }
}
