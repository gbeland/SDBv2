using SDB.Classes.RMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB.Forms.RMA
{
    public partial class FormRMA : Form
    {
        ClassRMA _selectedRMA;
        List<ClassRMA> _listRMA;
        public FormRMA()
        {
            InitializeComponent();
            _listRMA = new List<ClassRMA>();
        }

        public void Populate()
        {
            //Populate RMA info tab
            if(_selectedRMA != null)
            {

            }

            //Populate RMA list Tab
            

        }

        private void PopulateRMAListTab()
        {
            //reset rma list
            _listRMA.Clear();


            //Populate list based on checked catagories

            
            _listRMA.AddRange(PopulateUnrecivedRMAList());


            //populate RMA list count
            int count = _listRMA.Count;
            txtRMAList_Qty.Text = count.ToString();
        }


        private IEnumerable<ClassRMA> PopulateUnrecivedRMAList()
        {
            int count = 0;
            IEnumerable<ClassRMA> list = ClassRMA.GetUnreceived(null, 10000, out count);
            return list;
        }

   
    }
}
