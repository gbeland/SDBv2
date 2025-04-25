using SDB.MagicInfo.Classes;
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

namespace SDB.MagicInfo.Forms
{
    /* This is form for generating Reports for Samsung side of SDB
     * Currently only ticket reporting is functional, other reports will be added as the need for them arises. [TA] 
     */
    public partial class FormReporting : Form
    {

        // Struct used to place all relavate data for report into a single structure to all for easy iteration through list of all data points
        public struct TicketReport
        {
            public MagicInfoServer server;
            public MagicInfoAsset asset;
            public MagicInfoTicket ticket;
            public List<MagicInfoJournalEntry> journal;
        }

        public FormReporting()
        {
            InitializeComponent();
            cblServerSelect.DisplayMember = "Name";
            cblAssetSelect.DisplayMember = "Name";
        }

        //Populates the tabs based on the open tab.
        public void Populate()
        {
            var tab = tabsReportData.SelectedTab.Text;

            switch (tab)
            {
                case "Ticket Data":
                    Populate_SeverList();
                    break;
                default:
                    break;
            }




        }

        //Populates the server list in the Ticket Tab
        private void Populate_SeverList()
        {
            foreach (MagicInfoServer s in MagicInfoServer.GetAll())
            {
                var i = cblServerSelect.Items.Add(s);
            }
        }

        //Trigger event to intially populate form
        private void ServerList_VisibleChanged(object sender, EventArgs e)
        {
            Populate();
        }

        //Select all function for Sever List
        private void cbxSelectAll_CheckStateChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cblServerSelect.Items.Count; i++)
            {
                cblServerSelect.SetItemChecked(i, cbxSelectAll.Checked);
            }
        }

        //Logic to handle when a server is slected to then populate the asset list.
        private void cblServerSelect_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Shared vars
            MagicInfoServer server = cblServerSelect.Items[e.Index] as MagicInfoServer;


            ////Market Info
            //cblMarketSelect.Items.Clear();

            //if(e.NewValue == CheckState.Checked)
            //{
            //    var market = MagicInfoMarket.GetAllByServerID((int)server.ID);

            //    foreach(var m in market)
            //    {
            //        cblMarketSelect.Items.Add(m);
            //    }
            //}

            //foreach(var s in (cblServerSelect.CheckedItems.Cast<MagicInfoServer>()))
            //{
            //    var market = MagicInfoMarket.GetAllByServerID((int)s.ID);
            //    foreach (var m in market)
            //    {
            //        if (s.Name == (cblServerSelect.Items[e.Index] as MagicInfoServer).Name)
            //            break;
            //        cblMarketSelect.Items.Add(m);
            //    }
            //}

            //asset Info
            List<MagicInfoAsset> selectedItems = new List<MagicInfoAsset>();

            foreach (var a in cblAssetSelect.CheckedItems)
            {
                selectedItems.Add(a as MagicInfoAsset);
            }

            cblAssetSelect.Items.Clear();


            if (e.NewValue == CheckState.Checked)
            {
                var assets = MagicInfoAsset.GetAllByServerID((int)server.ID);

                foreach (var a in assets)
                {
                    cblAssetSelect.Items.Add(a);
                }
            }

            foreach (var s in (cblServerSelect.CheckedItems.Cast<MagicInfoServer>()))
            {
                var assets = MagicInfoAsset.GetAllByServerID((int)s.ID);
                foreach (var a in assets)
                {
                    if (s.Name == (cblServerSelect.Items[e.Index] as MagicInfoServer).Name)
                        break;
                    cblAssetSelect.Items.Add(a);
                }
            }

            if (checkBox1.Checked)
            {
                for (int i = 0; i < cblAssetSelect.Items.Count; i++)
                {
                    cblAssetSelect.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < cblAssetSelect.Items.Count; i++)
                {
                    foreach (var s in selectedItems)
                    {
                        if ((cblAssetSelect.Items[i] as MagicInfoAsset).ID == s.ID)
                            cblAssetSelect.SetItemChecked(i, true);
                    }


                }
            }

        }

        // Select All Function for Asset List
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cblAssetSelect.Items.Count; i++)
            {
                cblAssetSelect.SetItemChecked(i, checkBox1.Checked);
            }
        }
        // Select all function for all time for date range
        private void cbxAlltime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAlltime.Checked)
            {
                dtpToDate.Enabled = false;
                dtpFromDate.Enabled = false;
            }
            else
            {
                dtpToDate.Enabled = true;
                dtpFromDate.Enabled = true;
            }
        }

        // Takes all the datapoints and turns them into a CSV file. 
        //This function should be changed to account for different tabs when those tabs eventually get implmemented.
        private void btnExport_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value;
            var toDate = dtpToDate.Value;

            //Make sure date range is valid
            if (fromDate > toDate && !cbxAlltime.Checked)
            {
                MessageBox.Show( "Error With Date Range. Make sure From Date is before To Date.", "Error");
                return;
            }

            List<MagicInfoAsset> AssetList = cblAssetSelect.CheckedItems.OfType<MagicInfoAsset>().ToList();
            List<MagicInfoServer> ServerList = cblServerSelect.CheckedItems.OfType<MagicInfoServer>().ToList();
            List<TicketReport> reportList = new List<TicketReport>();
            List<MagicInfoTicket> ticketList = new List<MagicInfoTicket>();

            //Compiling a list of tickets attached to assets
            foreach(var a in AssetList)
            {
                ticketList.AddRange(MagicInfoTicket.GetByAssetID((int)a.ID));
            }
            //compiling a list of tickets attached to server
            foreach (var s in ServerList)
            {
                ticketList.AddRange(MagicInfoTicket.GetByServerID((int)s.ID));
            }

            //removing duplicates
            ticketList = ticketList.Distinct(new ItemEqualityComparer()).ToList();

            //filter out tickets outside date range if all time is not selected
            if(!cbxAlltime.Checked)
            {
                ticketList.RemoveAll(t => t.OpenDate < fromDate || t.OpenDate > toDate);
            }


            // compiling all data into a list of the struct which will hold all data
            foreach(var t in ticketList)
            {
                TicketReport r = new TicketReport
                {
                    ticket = t,
                    server = MagicInfoServer.GetByID((int)t.Server_fky),
                    journal = MagicInfoJournalEntry.GetAllByTicketID((int)t.ID)
                };
                reportList.Add(r);
            }

            try
            {
                using (SaveFileDialog fd = new SaveFileDialog())
                {
                    fd.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(fd.FileName);
                        foreach (var r in reportList)
                        {
                            string line = string.Format("{0},{1},{2},{3},{4}", r.server.Name, r.server.IP, r.ticket.ID, r.ticket.IssueText, (r.ticket.CloseDate == null ? "Open" : "Closed"));
                            writer.WriteLine(line);
                            foreach (var j in r.journal)
                            {
                                line = string.Format(",{0},{1},{2},{3}", j.EntryUser, j.EntryStatus.Status, j.StartDate, '"' + j.Entry.Replace(",", " ").Replace("'", " ").Replace('"', ' ').Replace("\n", " ") + '"');
                                writer.WriteLine(line);
                            }
                            writer.WriteLine(", ");
                        }
                        writer.Close();
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show("Error Saving File: \n" + ex.Message, "Error"); }

        }
    }
}

//Simple Class used to compare 2 MagicInfo Tickets and determine if they are the same. 
//This is used for the '.Distict()' Function used to generate the Ticket list for the report and remove duplicates
class ItemEqualityComparer : IEqualityComparer<MagicInfoTicket>
{
    public bool Equals(MagicInfoTicket x, MagicInfoTicket y)
    {
        // Two items are equal if their keys are equal.
        return x.ID == y.ID;
    }

    public int GetHashCode(MagicInfoTicket obj)
    {
        return obj.GetHashCode();
    }
}