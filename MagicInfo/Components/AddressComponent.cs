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

namespace SDB.MagicInfo.Components
{
    /// <summary>
    /// This User control is a self contained control for displaying address info. 
    /// It should not talk with SQL database or call manipulate outside components
    /// </summary>
    public partial class AddressComponent : UserControl
    {
        //Local Copy of Address
        MagicInfoAddress _address;

        /// <summary>
        /// Creates an empty address user control 
        /// </summary>
        public AddressComponent()
        {
            InitializeComponent();
            _address = new MagicInfoAddress();
        }

        /// <summary>
        /// Populates the text fields with the address and stores a local copy
        /// </summary>
        /// <param name="address"></param>
        public void Populate(int? address_id)
        {
            if (address_id == null)
                return;
            MagicInfoAddress address = MagicInfoAddress.GetByID(address_id);
            if (address == null)
                return;
            
            _address = address;
            tbxStreet.Text = address.Street;
            tbxCity.Text = address.City;
            tbxState.Text = address.State;
            tbxCountry.Text = address.Country;
            tbxZip.Text = address.Zip;
        }

        /// <summary>
        /// Show or Hide the AddNew and Find Buttons
        /// </summary>
        /// <param name="show"></param>
        public void ShowButtons(bool show)
        {
            btnFindAddress.Visible = show;
            btnAddNewAddress.Visible = show;
        }

        /// <summary>
        /// Determines if the textboxes all have values and colors them green if they do and red if they don't 
        /// Returns true if all textboxes have values 
        /// </summary>
        /// <returns></returns>
        public bool isComplete()
        {
            Color failColor = Color.Salmon;
            Color goodColor = Color.PaleGreen;
            bool isComplete = true;

            //Get all textboxes from asset
            IEnumerable<TextBox> allTbx = grpAddress.Controls.Cast<Control>().OfType<TextBox>();

            foreach (TextBox tbx in allTbx)
            {
                if (tbx.Text == string.Empty)
                {
                    tbx.BackColor = failColor;
                    isComplete = false;
                }
                else
                    tbx.BackColor = goodColor;
            }
            return isComplete;
        }

        /// <summary>
        /// returns the address based on the values n the text fields
        /// </summary>
        /// <returns></returns>
        public MagicInfoAddress GetAddress()
        {
            _address.Street = tbxStreet.Text;
            _address.City = tbxCity.Text;
            _address.State = tbxState.Text;
            _address.Zip = tbxZip.Text;
            _address.Country = tbxCountry.Text;
            return _address;
        }

        /// <summary>
        /// Gets the id of the stored address or returns null if it is a new address
        /// </summary>
        /// <returns></returns>
        public int? GetAddressID()
        {
            return _address.ID;
        }
        
        /// <summary>
        /// Unlocks the textfields to be edited and sets the stored address id to null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewAddress_Click(object sender, EventArgs e)
        {
            if(_address.ID == null)
                Populate(null);
            _address.ID = null;
            ReadOnly(false);
        }

        /// <summary>
        /// Locks or unlocks the text fields by making them readonly
        /// True means that all fields will be readonly
        /// </summary>
        /// <param name="lockAddress"></param>
        public void ReadOnly(bool lockAddress)
        {
            tbxStreet.ReadOnly = lockAddress;
            tbxCity.ReadOnly = lockAddress;
            tbxState.ReadOnly = lockAddress;
            tbxCountry.ReadOnly = lockAddress;
            tbxZip.ReadOnly = lockAddress;
        }

        /// <summary>
        /// Clears al text fields and clears the stored address
        /// </summary>
        public void Clear()
        {
            _address = new MagicInfoAddress();
            IEnumerable<TextBox> allTbx = grpAddress.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
        }

        public void SetAddressName(string name)
        {
            grpAddress.Text = name + " Address";
        }
    }
}
