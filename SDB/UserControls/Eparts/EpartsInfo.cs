using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.Forms.Ticket;
using SDB.Forms.Eparts;
using SDB.Classes.User;
using SDB.Classes.General;
using System.Net.Mail;
using SDB.Classes.Admin;
using SDB.Classes.Shipments;
using SDB.Classes.Assembly;

namespace SDB.UserControls.Eparts
{
    public partial class EpartsInfo : UserControl
    {
        SDB.Classes.Eparts.Eparts LoadedEpartsOrder;
        public delegate void IDEvent(int jumpID);
        public event IDEvent ViewShipment;


        public EpartsInfo()
        {
            InitializeComponent();
        }
        
        public void LoadOrder(SDB.Classes.Eparts.Eparts eparts)
        {
            eparts = Classes.Eparts.Eparts.GetByID((int)eparts.ID);
            eparts.Populate();
            LoadedEpartsOrder = eparts;

            ButtonsController();

            tbxEpartsID.Text = eparts.FormattedID;
            tbxCreationDate.Text = eparts.Creation_DT.ToString();
            tbxClosed.Text = eparts.Completion_DT.ToString();
            tbxMarket.Text = eparts.Market!=null ? eparts.Market.Name : "";
            tbxShipment.Text = eparts.Shipment_ID.ToString();
            tbxShipment.ForeColor = Color.Blue;
            tbxEmailList.Text = eparts.Email;
            tbxPhone.Text = eparts.Phone;
            tbxPO.Text = eparts.PO;

            lblStatus.Text = eparts.Status;

            if(LoadedEpartsOrder.Shipment != null && LoadedEpartsOrder.Shipment.IsDeleted)
            {
                MessageBox.Show("It Appears that the attached Shipper has been Deleted. Please Remake the shipment", "Shipment: " + LoadedEpartsOrder.Shipment_ID);
                var entry = new Classes.Eparts.Eparts.EpartsEntry
                {
                    Entry = "Shipment: " + LoadedEpartsOrder.Shipment_ID + "Is Deleted, Detaching from Eparts Order",
                    Date = DateTime.Now,
                    User_ID = GS.Settings.LoggedOnUser.ID,
                    System_Msg = true,
                    Eparts_ID = (int)LoadedEpartsOrder.ID
                };

                SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);

                LoadedEpartsOrder.Shipment_ID = null;

                Classes.Eparts.Eparts.Update(LoadedEpartsOrder);
                LoadOrder(LoadedEpartsOrder);
            }

            
            PopulateJournal();
            PopulateAdress();
            PopulateAssembly();
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            if (LoadedEpartsOrder == null)
                return;

            using (FormEpartsJournal _form = new FormEpartsJournal(LoadedEpartsOrder))
            {
                _form.ShowDialog();
            }
        }

        private void ButtonsController()
        {
            btnEmailCustomerInfo.Enabled = false;
            btnEnterCustomerInfo.Enabled = false;
            btnNewNote.Enabled = false;
            btnQoute.Enabled = false;
            btnCreateShipment.Enabled = false;
            btnClose.Enabled = false;

            if (LoadedEpartsOrder.ID != null)
                btnEmailCustomerInfo.Enabled = true;
            if (LoadedEpartsOrder.ID != null)
                btnEnterCustomerInfo.Enabled = true;
            if (LoadedEpartsOrder.Inventory != null)
                if (LoadedEpartsOrder.Inventory.Count > 0)
                    btnQoute.Enabled = true;
            if (LoadedEpartsOrder.Inventory != null)
                if (LoadedEpartsOrder.Inventory.Count > 0)
                    btnCreateShipment.Enabled = true;
            if (LoadedEpartsOrder.ID != null)
                btnClose.Enabled = true;
            if (LoadedEpartsOrder.ID != null)
                btnNewNote.Enabled = true;
            if (LoadedEpartsOrder.ID != null)
            {
                btnAddAssembly.Enabled = true;
                btnEditAssembly.Enabled = true;
                btnRemoveAssembly.Enabled = true;
            }


                if (!GS.Settings.LoggedOnUser.IsSSR)
            {
                btnAddAssembly.Enabled = false;
                btnEditAssembly.Enabled = false;
                btnRemoveAssembly.Enabled = false;

                btnCreateShipment.Enabled = false;
                btnQoute.Enabled = false;
                btnClose.Enabled = false;
            }

            if (LoadedEpartsOrder.Status == "Closed")
            {
                btnNewNote.Enabled = false;
                btnAddAssembly.Enabled = false;
                btnEditAssembly.Enabled = false;
                btnRemoveAssembly.Enabled = false;
                btnEmailCustomerInfo.Enabled = false;
                btnEnterCustomerInfo.Enabled = false;
                btnCreateShipment.Enabled = false;
                btnQoute.Enabled = false;
            }

            if(LoadedEpartsOrder.Shipment_ID != null)
            {
                btnAddAssembly.Enabled = false;
                btnEditAssembly.Enabled = false;
                btnRemoveAssembly.Enabled = false;
                btnCreateShipment.Text = "View Shipment";
               


            }
            else btnCreateShipment.Text = "Create Shipment";



            if (LoadedEpartsOrder.Completion_DT != null)
            {
                btnClose.Text = "Open";
            }
            else btnClose.Text = "Close";

        }

        private void PopulateJournal()
        {
            dgvJournal.SuspendLayout();
           
            var journal = LoadedEpartsOrder.Journal;
            journal = journal.OrderByDescending(x => x.Date.ToString()).ToList();
            dgvJournal.Rows.Clear();
            foreach (var j in journal)
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
            
        private void PopulateAdress()
        {
            txtDest_Company.Text = LoadedEpartsOrder.S_Company;
            txtDest_Address.Text = LoadedEpartsOrder.S_Address;
            txtDest_Attn.Text = LoadedEpartsOrder.S_Attn;
            txtDest_City.Text = LoadedEpartsOrder.S_City;
            txtDest_State.Text = LoadedEpartsOrder.S_State;
            txtDest_Country.Text = LoadedEpartsOrder.S_Country;
            txtDest_Zip.Text = LoadedEpartsOrder.S_Zip;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (LoadedEpartsOrder.Completion_DT == null)
            {
                Classes.Eparts.Eparts.UpdateStatus(LoadedEpartsOrder, "Closed");

                Classes.Eparts.Eparts.Close(LoadedEpartsOrder);

                var entry = new Classes.Eparts.Eparts.EpartsEntry
                {
                    Entry = GS.Settings.LoggedOnUser.FirstL + " Closed The Order.",
                    Date = DateTime.Now,
                    User_ID = GS.Settings.LoggedOnUser.ID,
                    System_Msg = true,
                    Eparts_ID = (int)LoadedEpartsOrder.ID
                };

                SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);

                LoadOrder(LoadedEpartsOrder);
            }
            else
            {
                Classes.Eparts.Eparts.UpdateStatus(LoadedEpartsOrder, "ReOpened");

                Classes.Eparts.Eparts.ReOpen(LoadedEpartsOrder);

                var entry = new Classes.Eparts.Eparts.EpartsEntry
                {
                    Entry = GS.Settings.LoggedOnUser.FirstL + " Reopened The Order.",
                    Date = DateTime.Now,
                    User_ID = GS.Settings.LoggedOnUser.ID,
                    System_Msg = true,
                    Eparts_ID = (int)LoadedEpartsOrder.ID
                };

                SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);

                LoadOrder(LoadedEpartsOrder);
            }
        }

        private void btnEnterCustomerInfo_Click(object sender, EventArgs e)
        {
            using (FormEpartsNewOrder _form = new FormEpartsNewOrder(LoadedEpartsOrder))
            {
                _form.ShowDialog();
            }
            LoadOrder(LoadedEpartsOrder);
        }

       private void PopulateAssembly()
        {
            dataGridView1.SuspendLayout();

            int total = 0;

            var assem = Classes.Eparts.Eparts.GetInventory(LoadedEpartsOrder);
            List<int> exists = new List<int>();

            dataGridView1.Rows.Clear();
            foreach (var j in assem)
            {
                if (exists.Contains(j.ID))
                    continue;


                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                
                
                row.Cells[0].Value = j.DisplayMember;
                row.Cells[1].Value = assem.Where(x=> x.ID == j.ID).Count();
                row.Cells[2].Value = j.ID;
                exists.Add(j.ID);
                total += assem.Where(x => x.ID == j.ID).Count();
                dataGridView1.Rows.Add(row);
            }
            tbxQtyTotal.Text = total.ToString();
            dataGridView1.ResumeLayout();
        }

        private void btnAddAssembly_Click(object sender, EventArgs e)
        {
            using (FormEpartItem _form = new FormEpartItem())
            {
                var res = _form.ShowDialog();


                if (res == DialogResult.OK)
                {
                    for (int i = 0; i < _form.Quantity; i++)
                        Classes.Eparts.Eparts.AddToInventory(LoadedEpartsOrder, _form.Assembly);
                    var entry = new Classes.Eparts.Eparts.EpartsEntry
                    {
                        Entry = GS.Settings.LoggedOnUser.FirstL + " Added Assembly: " + _form.Assembly.AssemblyNumber,
                        Date = DateTime.Now,
                        User_ID = GS.Settings.LoggedOnUser.ID,
                        System_Msg = true,
                        Eparts_ID = (int)LoadedEpartsOrder.ID
                    };
                    SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);
                }
            }



            LoadOrder(LoadedEpartsOrder);
        }

        private void btnEditAssembly_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int id = (int)dataGridView1.SelectedCells[2].Value;
            int qty = (int)dataGridView1.SelectedCells[1].Value;

            var assem = ClassAssembly.GetByID(id);

                using (FormEpartItem _form = new FormEpartItem(assem, qty))
            {
                var res = _form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Classes.Eparts.Eparts.RemoveFromInventory(LoadedEpartsOrder, assem);
                    for (int i = 0; i < _form.Quantity; i++)
                        Classes.Eparts.Eparts.AddToInventory(LoadedEpartsOrder, _form.Assembly);
                }
                var entry = new Classes.Eparts.Eparts.EpartsEntry
                {
                    Entry = GS.Settings.LoggedOnUser.FirstL + "Change a Assembly: " + _form.Assembly.AssemblyNumber,
                    Date = DateTime.Now,
                    User_ID = GS.Settings.LoggedOnUser.ID,
                    System_Msg = true,
                    Eparts_ID = (int)LoadedEpartsOrder.ID
                };
                SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);
            }

            LoadOrder(LoadedEpartsOrder);

        }

        private void btnRemoveAssembly_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int id = (int)dataGridView1.SelectedCells[2].Value;
            int qty = (int)dataGridView1.SelectedCells[1].Value;
            var assem = Classes.Assembly.ClassAssembly.GetByID(id);
            Classes.Eparts.Eparts.RemoveFromInventory(LoadedEpartsOrder, assem);
            var entry = new Classes.Eparts.Eparts.EpartsEntry
            {
                Entry = GS.Settings.LoggedOnUser.FirstL + " Removed Assembly: " + assem.AssemblyNumber,
                Date = DateTime.Now,
                User_ID = GS.Settings.LoggedOnUser.ID,
                System_Msg = true,
                Eparts_ID = (int)LoadedEpartsOrder.ID
            };
            SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);

            LoadOrder(LoadedEpartsOrder);
        }

        private void btnEmailCustomerInfo_Click(object sender, EventArgs e)
        {
            MailMessage email = new MailMessage();
			try
			{
				email.To.Add(LoadedEpartsOrder.Email);
				email.To.Add(ClassConfig.GetServiceEmail());
            }
			catch (FormatException exf)
            {
                MessageBox.Show("Invalid Email Format", $"Error: {exf.Message}");
            }
                email.From = ClassConfig.GetServiceEmail();

            email.Subject = "Eparts Order: Information Required";
            email.Body = "We will need some information in order to furnish a quote.  \n" +
                "\nPlease take a picture of the label on the back of the LED board and fill in the following information:\n" +
                $"\nFirst time ordering parts from {ClassConfig.GetServiceCompany()}? (Yes / No):\n" +
                "\nCompany Name:\n" +
                "\nBilling Address:\n" +
                "\nShipping Address:\n" +
                "\nDisplay / Panel name or Location:\n" +
                "\nParts Needed:\n";

			ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.EpartsOrder, email);

            var entry = new Classes.Eparts.Eparts.EpartsEntry
            {
                Entry = GS.Settings.LoggedOnUser.FirstL + " Sent info request to" + LoadedEpartsOrder.Email,
                Date = DateTime.Now,
                User_ID = GS.Settings.LoggedOnUser.ID,
                System_Msg = true,
                Eparts_ID = (int)LoadedEpartsOrder.ID
            };
			Classes.Eparts.Eparts.AddJournalEntry(entry);

            LoadOrder(LoadedEpartsOrder);
        }

        private void btnCreateShipment_Click(object sender, EventArgs e)
        {
            if (LoadedEpartsOrder.Shipment_ID != null)
            {
                ViewShipment((int)LoadedEpartsOrder.Shipment_ID);
                return;
            }

            ClassShipment shipment = new ClassShipment();
            shipment.IsEparts = true;
            shipment.EmailList = LoadedEpartsOrder.Email;
            shipment.Destination = new ClassShipment.ClassShippingAddressInfo
            {
                Company = LoadedEpartsOrder.S_Company,
                Address = LoadedEpartsOrder.S_Address,
                City = LoadedEpartsOrder.S_City,
                State = LoadedEpartsOrder.S_State,
                Zip = LoadedEpartsOrder.S_Zip,
                Attention = LoadedEpartsOrder.S_Attn,
                Country = LoadedEpartsOrder.S_Country,
                Telephone = LoadedEpartsOrder.Phone
            };

            List<ClassShipment_Item> shipList = new List<ClassShipment_Item>();

            var assemList = Classes.Eparts.Eparts.GetInventory(LoadedEpartsOrder);

            List<int> exists = new List<int>();

            foreach(var a in assemList)
            {
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

            ClassShipment.AddNew(ref shipment, shipList);
            LoadedEpartsOrder.Shipment_ID = shipment.ID;
            Classes.Eparts.Eparts.Update(LoadedEpartsOrder);

            var entry = new Classes.Eparts.Eparts.EpartsEntry
            {
                Entry = GS.Settings.LoggedOnUser.FirstL + " Created Shipment: " + shipment.ID,
                Date = DateTime.Now,
                User_ID = GS.Settings.LoggedOnUser.ID,
                System_Msg = true,
                Eparts_ID = (int)LoadedEpartsOrder.ID
            };
            SDB.Classes.Eparts.Eparts.AddJournalEntry(entry);
            LoadOrder(LoadedEpartsOrder);

            ViewShipment((int)LoadedEpartsOrder.Shipment_ID);
        }

        private void tbxShipment_Click(object sender, EventArgs e)
        {
            if (LoadedEpartsOrder.Shipment_ID == null)
                return;

            ViewShipment((int)LoadedEpartsOrder.Shipment_ID);
        }

        private void btnQoute_Click(object sender, EventArgs e)
        {
            if (LoadedEpartsOrder.Inventory.Count == 0)
                return;


            using (FormEpartsQoute _form = new FormEpartsQoute(LoadedEpartsOrder))
            {
                var res = _form.ShowDialog();    
            }

            LoadOrder(LoadedEpartsOrder);
        }
    }
}
