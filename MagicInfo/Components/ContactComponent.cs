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
    public partial class ContactComponent : UserControl
    {
        private MagicInfoContacts _contact;
        public delegate void SaveContact(MagicInfoContacts contact);
        public event SaveContact ContactSaveEvent;

        public ContactComponent()
        {
            InitializeComponent();
        }

        public void Init(MagicInfoContacts c = null)
        {

            
           if(c == null)
            {
                ReadOnly(false);
                ShowSaveBtn();
                ShowEditBtn(false);
                _contact = new MagicInfoContacts();
                lblContact.Text = "Unsaved Contact";
            }
           else
            {
                lblContact.Text = "Contact #" + c.ID.ToString();
                ReadOnly();
                ShowSaveBtn(false);
                ShowEditBtn();
                _contact = c;
                Populate();
            }
        }

        private void Populate()
        {
            if (_contact.ID == null)
                return;

            tbxFirstName.Text = _contact.FirstName;
            tbxLastName.Text = _contact.LastName;
            tbxPhone.Text = _contact.PhoneNumber;
            tbxEmail.Text = _contact.Email;
            cbxAuth.Checked = _contact.isAuthorizedContact;
        }

        public void ReadOnly(bool isReadOnly = true)
        {
            tbxFirstName.ReadOnly = isReadOnly;
            tbxLastName.ReadOnly = isReadOnly;
            tbxPhone.ReadOnly = isReadOnly;
            tbxEmail.ReadOnly = isReadOnly;
            cbxAuth.Enabled = !isReadOnly;
        }

        private void UpdateContact()
        {
            _contact.FirstName = tbxFirstName.Text;
            _contact.LastName = tbxLastName.Text;
            _contact.PhoneNumber = tbxPhone.Text;
            _contact.Email = tbxEmail.Text;
            _contact.isAuthorizedContact = cbxAuth.Checked;
        }

        public void Save()
        {
            UpdateContact();
            ReadOnly();
            ContactSaveEvent?.Invoke(_contact);
            ShowSaveBtn(false);
            ShowEditBtn(true);
        }

        private void ShowSaveBtn(bool show = true)
        {
            btnSave.Visible = show;
            btnCancel.Visible = show;
        }

        private void ShowEditBtn(bool show = true)
        {
            btnEdit.Visible = show;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ContactSaveEvent?.Invoke(null);
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnly(false);
            ShowEditBtn(false);
            ShowSaveBtn();

        }
    }


}

