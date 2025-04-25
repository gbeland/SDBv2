using SDB.Classes.General;
using SDB.Forms.Customer;
using SDB.Forms.Tech;
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
    public partial class FormEpartsNewOrder : Form
    {
        public Classes.Eparts.Eparts LoadedEparts;

        public FormEpartsNewOrder()
        {
            InitializeComponent();
            LoadedEparts = new Classes.Eparts.Eparts();
        }

        public FormEpartsNewOrder(Classes.Eparts.Eparts eparts)
        {
            InitializeComponent();
            LoadedEparts = eparts;
            Populate();
        }

        public void Populate()
        {
                txtDest_Company.Text = LoadedEparts.S_Company;
                txtDest_Address.Text = LoadedEparts.S_Address;
                txtDest_Attn.Text = LoadedEparts.S_Attn;
                txtDest_City.Text = LoadedEparts.S_City;
                txtDest_State.Text = LoadedEparts.S_State;
                txtDest_Country.Text = LoadedEparts.S_Country;
                txtDest_Zip.Text = LoadedEparts.S_Zip;
                tbxPO.Text = LoadedEparts.PO;
                tbxEmailList.Text = LoadedEparts.Email;
        }

        private void btnImportMarket_Click(object sender, EventArgs e)
        {
            using(FormMarket_Select _form = new FormMarket_Select())
            {
                _form.ShowDialog();

                var market = _form.SelectedMarket;

                LoadedEparts.Market_ID = market;

                txtDest_Company.Text = LoadedEparts.S_Company = LoadedEparts.Market.NameWithCustomerName;
                txtDest_Address.Text = LoadedEparts.S_Address = LoadedEparts.Market.Address;
                txtDest_Attn.Text = LoadedEparts.S_Attn;
                txtDest_City.Text = LoadedEparts.S_City = LoadedEparts.Market.City;
                txtDest_State.Text = LoadedEparts.S_State = LoadedEparts.Market.State;
                txtDest_Country.Text = LoadedEparts.S_Country = LoadedEparts.Market.Country;
                txtDest_Zip.Text = LoadedEparts.S_Zip = LoadedEparts.Market.Zip;

                tbxEmailList.Text = LoadedEparts.Email = LoadedEparts.Market.Email_Addresses;
                tbxPhone.Text = LoadedEparts.Phone = LoadedEparts.Market.Telephone;
            }



        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(tbxNote.Text == String.Empty)
            {
                MessageBox.Show("Must include a Eparts Note");
                return;
            }
            if (tbxEmailList.Text == String.Empty)
            {
                MessageBox.Show("Must include an email address");
                return;
            }

            LoadedEparts.S_Company = txtDest_Company.Text;
            LoadedEparts.S_Address = txtDest_Address.Text;
            LoadedEparts.S_Attn = txtDest_Attn.Text;
            LoadedEparts.S_City = txtDest_City.Text;
            LoadedEparts.S_State = txtDest_State.Text;
            LoadedEparts.S_Country = txtDest_Country.Text;
            LoadedEparts.S_Zip = txtDest_Zip.Text;

            LoadedEparts.Email = tbxEmailList.Text;
            LoadedEparts.Phone = tbxPhone.Text;
            LoadedEparts.PO = tbxPO.Text;

            //save eparts order info
            if (LoadedEparts.ID == null)
            {
                Classes.Eparts.Eparts.AddNew(ref LoadedEparts);
                Classes.Eparts.Eparts.AddJournalEntry(new Classes.Eparts.Eparts.EpartsEntry
                {
                    Entry = "Eparts Order Created",
                    Date = DateTime.Now,
                    User_ID = GS.Settings.LoggedOnUser.ID,
                    System_Msg = true,
                    Eparts_ID = (int)LoadedEparts.ID
                });
                Classes.Eparts.Eparts.AddJournalEntry(new Classes.Eparts.Eparts.EpartsEntry
                {
                    Entry = tbxNote.Text,
                    Date = DateTime.Now,
                    User_ID = GS.Settings.LoggedOnUser.ID,
                    System_Msg = false,
                    Eparts_ID = (int)LoadedEparts.ID
                });
                Classes.Eparts.Eparts.UpdateStatus(LoadedEparts, "New");
            }
            else
            {
                Classes.Eparts.Eparts.Update(LoadedEparts);

            }
            Close();
        }

        //close
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddAssem_Click(object sender, EventArgs e)
        {
            if (LoadedEparts == null)
                return;

            using(FormEpartItem _form = new FormEpartItem())
            {
                _form.ShowDialog();
                for (int i = 0; i < _form.Quantity; i++)
                    Classes.Eparts.Eparts.AddToInventory(LoadedEparts, _form.Assembly);
            }

        }

        private void btnImportTech_Click(object sender, EventArgs e)
        {
            using (FormList_Techs _form = new FormList_Techs())
            {
                _form.ShowDialog();

                var tech = _form.SelectedTech;

                if (tech == null)
                    return;
                
                txtDest_Company.Text = tech.TechName;
                txtDest_Address.Text = tech.Shipping_Address;
                txtDest_Attn.Text = "";
                txtDest_City.Text = tech.Shipping_City;
                txtDest_State.Text = tech.Shipping_State;
                txtDest_Country.Text = tech.Shipping_Country;
                txtDest_Zip.Text = tech.Shipping_Zip;

                tbxEmailList.Text = tech.Email;
                tbxPhone.Text = tech.Telephone;
            }


        }
    }
}
