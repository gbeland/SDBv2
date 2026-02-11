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
    public partial class FormEparts : Form
    {
        Classes.Eparts.Eparts SelectedOrder;

        public delegate void IDEvent(int jumpID);
        public event IDEvent ViewShipment;


        public List<Classes.Eparts.Eparts> LoadedEparts;
        public int loadedPage = 0;
        public readonly int PageCount = 1000;

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
            cmbFilter.SelectedItem = "All";

            ClearLoadedEpartsList();
            LoadBatch();
        }

        public void PopulateTracker(string filter = "")
        {
            var list = LoadedEparts;
                if (filter == "Closed")
                    olvEparts.Objects = SDB.Classes.Eparts.Eparts.GetAllClosed();
                else if (filter != "" && filter != "All")
                    olvEparts.Objects = list.Where(x => x.Status == filter);
                else
                    olvEparts.Objects = list.Where(x => x.Status != "Closed");

                olvEparts.PrimarySortColumn = olcStatus;
            
        }

        public void ClearLoadedEpartsList()
        {
            LoadedEparts = new List<Classes.Eparts.Eparts>();
            loadedPage = 0;
        }

        public void LoadBatch(string search = null)
        {
            if(search == null)
            {
                LoadedEparts.AddRange(SDB.Classes.Eparts.Eparts.GetAllOpenPaged(PageCount, loadedPage));
                LoadedEparts = LoadedEparts.Distinct().ToList();
            }
            else
            {
                LoadedEparts.AddRange(SDB.Classes.Eparts.Eparts.GetAllSearchPaged(PageCount, loadedPage, search));
                LoadedEparts = LoadedEparts.Distinct().ToList();
            }
            PopulateTracker();
            loadedPage++;
        }


        private void FormEparts_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                LoadedEparts = new List<Classes.Eparts.Eparts>();
                Populate();
            }
                
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
            ClearLoadedEpartsList();
            LoadBatch(tbxSearch.Text);
        }

        private void olvEparts_Scroll(object sender, ScrollEventArgs e)
        {
            //6 is a magic number that came from debugging. it is the initial value that is max for the scroll
            if (e.NewValue >= (6 + ((loadedPage-1) * PageCount)))
            {
                if (tbxSearch.Text == "")
                    LoadBatch();
                else
                    LoadBatch(tbxSearch.Text);
            }

        }

        private void FormEparts_Load(object sender, EventArgs e)
        {

        }
    }
}
