using SDB.Classes.Assembly;
using SDB.Classes.Shipments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text.pdf;
using iTextSharp.text;

namespace SDB.Forms.Eparts
{
    public partial class FormEpartsQoute : Form
    {
        Classes.Eparts.Eparts EpartsOrder;
        private static readonly string _OSA_COVER_FILE = Path.Combine(System.Windows.Forms.Application.StartupPath, @"Required Files", @"OSA_Cover.pdf");


        public FormEpartsQoute(Classes.Eparts.Eparts eparts)
        {
            InitializeComponent();
            EpartsOrder = eparts;

            List<ClassShipment_Item> shipList = new List<ClassShipment_Item>();
            
            var assemList = Classes.Eparts.Eparts.GetInventory(EpartsOrder);
            lblQty.Text = assemList.Count.ToString();
            double tp_cost = 0.0;
            double mh_cost = 0.0;

            List<int> exists = new List<int>();

            foreach (var a in assemList)
            {
                if (a.ThirdParty)
                    continue;
                mh_cost += (double)a.Cost;

                if (exists.Contains(a.ID))
                    continue;
                
                exists.Add(a.ID);
                

                var c = assemList.Where(x => x.ID == a.ID).Count();
                shipList.Add(new ClassShipment_Item
                {
                    Assembly = a,
                    AssemblyType = ClassAssemblyType.GetByID(a.AssemblyTypeID),
                    Quantity = c,
                    Asset_ID = null,
                    Job_Number = ""
                });
            }

            olvFG.Objects = shipList;
            shipList.Clear();

            foreach (var a in assemList)
            {
                if (!a.ThirdParty)
                    continue;
                tp_cost += (double)a.Cost;

                if (exists.Contains(a.ID))
                    continue;

                exists.Add(a.ID);
                var c = assemList.Where(x => x.ID == a.ID).Count();
                shipList.Add(new ClassShipment_Item
                {
                    Assembly = a,
                    AssemblyType = ClassAssemblyType.GetByID(a.AssemblyTypeID),
                    Quantity = c,
                    Asset_ID = null,
                    Job_Number = ""
                });
            }

            olvTPH.Objects = shipList;

            lblCost.Text = (mh_cost + tp_cost).ToString("0.##");

            lblGrandCost.Text = ((mh_cost * 2.0) + (tp_cost * 1.6)).ToString("0.##");

            lblExpires.Text = DateTime.Today.AddDays(30).ToShortDateString();

            cmbShippingMethod.Items.AddRange(Classes.Shipments.ClassShipment_Method.GetAll().ToArray());
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(cmbShippingMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Shipping Method", "No Shipping Method");
                return;
            }

            EpartsOrder.Shipping_Method = ((Classes.Shipments.ClassShipment_Method)cmbShippingMethod.SelectedItem).Description;
            Classes.Admin.ClassEmailGenerator.GenerateDocument_EpartsQoute(EpartsOrder);
            
        }

        private void btnSendToMarket_Click(object sender, EventArgs e)
        {
            Classes.Admin.ClassEmailGenerator.GenerateAccounting_EpartsQoute(EpartsOrder);
        }
    }
}
