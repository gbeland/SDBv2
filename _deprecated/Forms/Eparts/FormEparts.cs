using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB.Forms.Eparts
{
    public partial class FormEparts : Form
    {
        Classes.Eparts.Eparts SelectedOrder;

        public delegate void IDEvent(int jumpID);
        public event IDEvent ViewShipment;
        public event IDEvent ViewMarket;

        public FormEparts()
        {
            InitializeComponent();

            epartsInfoPanel.ViewShipment += ViewShipmentWindow;


        }

        private void ViewShipmentWindow(int shipmentID)
        {
            ViewShipment(shipmentID);
        }

        public void Populate()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("All");
            cmbFilter.Items.Add("Closed");
            cmbFilter.Items.AddRange(Classes.Eparts.Eparts.GetAllStatuses().ToArray());
            cmbFilter.SelectedItem = "New";

            PopulateTracker();
            
        }

        public void PopulateTracker(string filter = "", string search = "")
        {
            Stopwatch _timer = new Stopwatch();
            _timer.Start();

            var list = SDB.Classes.Eparts.Eparts.GetAllOpen();
            _timer.Stop();
            var xx = _timer.ElapsedMilliseconds;

            
            if (filter == "Closed")
                olvEparts.Objects = SDB.Classes.Eparts.Eparts.GetAllClosed();
            else if (filter != "" && filter != "All")
                olvEparts.Objects = list.Where(x => x.Status == filter);
            else
                olvEparts.Objects = list.Where(x => x.Status != "Closed");
            
            olvEparts.PrimarySortColumn = olcStatus;

            if (search != "")
            {
                //list.AddRange(SDB.Classes.Eparts.Eparts.GetAllClosed());
                olvEparts.Objects = list.Where(x => ((int)x.ID).ToString("D6").Contains(search));
            }


        }

        //public void PopulateTracker(string filter = "", string search = "")
        //{



        //}

        private void FormEparts_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                Populate();
        }

        private void FormEparts_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void olvEparts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOrder = (Classes.Eparts.Eparts)olvEparts.SelectedObject;
            if (SelectedOrder == null)
                return;
            epartsInfoPanel.LoadOrder(SelectedOrder);

        }

        

        private void btnNewOrder_Click(object sender, EventArgs e)
        {

            using(FormEpartsNewOrder _form = new FormEpartsNewOrder())
            {
                _form.ShowDialog();
            }
            Populate();

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTracker(cmbFilter.Text);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateTracker("", tbxSearch.Text);
        }
    }
}
