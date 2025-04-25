using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.User;

namespace SDB.Forms.Admin
{
    public partial class FormAdmin_Users : Form
    {
        private bool _ignoreStateChange;

        public FormAdmin_Users()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            PopulateUsers();
        }

        private void PopulateUsers()
        {
            _ignoreStateChange = true;

            cmbModifyUser_SelectUser.DisplayMember = "DisplayMember";
            cmbModifyUser_SelectUser.ValueMember = "ID";
            cmbModifyUser_SelectUser.DataSource = ClassUser.GetAll(ClassUser.UserAccountStatus.All);
            cmbModifyUser_SelectUser.SelectedIndex = -1;

            _ignoreStateChange = false;
        }

        private void btnUser_Modify_Click(object sender, EventArgs e)
        {
            var selectedUser = (ClassUser)cmbModifyUser_SelectUser.SelectedItem;

            if (selectedUser == null)
                return;

            if (!string.IsNullOrWhiteSpace(txtModifyUser_Password.Text.Trim()))
            {
                string errors;
                if (!Validate_ModifyUser_Password(out errors))
                {
                    MessageBox.Show(errors, "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClassUser.SetPassword(selectedUser.ID, txtModifyUser_Password.Text.Trim());
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, "Changed password");
                MessageBox.Show(string.Format("Password successfully changed for \"{0} {1}\".", selectedUser.First, selectedUser.Last), "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!string.IsNullOrWhiteSpace(txtModifyUser_Pin.Text.Trim()))
            {
                string errors;
                if (!Validate_ModifyUser_Pin(out errors))
                {
                    MessageBox.Show(errors, "Pin Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClassUser.SetPin(selectedUser.ID, txtModifyUser_Pin.Text.Trim());
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, "Changed PIN");
                MessageBox.Show(string.Format("PIN successfully changed for \"{0} {1}\".", selectedUser.First, selectedUser.Last), "PIN Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string newUserType;
            if (radModifyUser_UserType_Administrator.Checked)
                newUserType = ClassUser.USERTYPE_ADMIN;
            else if (radModifyUser_UserType_Moderator.Checked)
                newUserType = ClassUser.USERTYPE_MODERATOR;
            else if (radModifyUser_UserType_SSR.Checked)
                newUserType = ClassUser.USERTYPE_SSR;
            else
                newUserType = ClassUser.USERTYPE_STANDARD;

            if (selectedUser.UserType != newUserType)
            {
                ClassUser.SetType(selectedUser.ID, newUserType);
                var changeString = string.Format("from {0} to {1}", selectedUser.UserType, newUserType);
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, changeString);
                MessageBox.Show(string.Format("\"{0} {1}\" successfully changed {2}.", selectedUser.First, selectedUser.Last, changeString), "User Type Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (selectedUser.LoginDisabled != radModifyUser_DisableLogin.Checked)
            {
                ClassUser.SetLoginDisabled(selectedUser.ID, radModifyUser_DisableLogin.Checked);
                var changeString = string.Format("from {0} to {1}", selectedUser.LoginDisabled ? "Disabled" : "Enabled", radModifyUser_DisableLogin.Checked ? "Disabled" : "Enabled");
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, changeString);
                MessageBox.Show(string.Format("\"{0} {1}\" successfully changed {2}.", selectedUser.First, selectedUser.Last, changeString), "User Account Status Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (radModifyUser_DisableLogin.Checked)
                {
                    ClassSubscription.UnsubscribeAll(selectedUser.ID);
                    ClassNotification.DeleteAllByUser(selectedUser.ID);
                }
            }
            ClearControls_ModifyUser();
            PopulateUsers();
        }

        private void btnUser_New_Click(object sender, EventArgs e)
        {
            int newUserID;
            string errors;
            if (!Validate_NewUser(out errors, out newUserID))
            {
                MessageBox.Show(errors, "Create User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new ClassUser
            {
                ID = newUserID,
                First = txtCreateUser_FirstName.Text.Trim(),
                Last = txtCreateUser_LastName.Text.Trim(),
                Email = txtCreateUser_Email.Text.Trim()
            };
            var initialPassword = txtCreateUser_Password.Text;

            if (radCreateUser_UserType_Administrator.Checked)
                newUser.UserType = ClassUser.USERTYPE_ADMIN;
            else if (radCreateUser_UserType_Moderator.Checked)
                newUser.UserType = ClassUser.USERTYPE_MODERATOR;
            else if (radCreateUser_UserType_SSR.Checked)
                newUser.UserType = ClassUser.USERTYPE_SSR;
            else
                newUser.UserType = ClassUser.USERTYPE_STANDARD;
            try
            {
                ClassUser.AddNew(newUser, initialPassword);
            }
            catch (MySqlException mexc)
            {
                MessageBox.Show(string.Format("User could not be added. Is the login unique?{0}{0}{1}", Environment.NewLine, mexc.Message), "Create User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.NewUser, ClassEmailGenerator.GenerateEmail_NewUser(newUser, initialPassword));
            }
            catch (Exception exc)
            {
                ClassLogFile.AppendToLog("Unable to send new user email.", exc);
            }

            ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.User, newUser.ID, string.Format("{0} {1}", newUser.First, newUser.Last));
            MessageBox.Show(string.Format("\"{0} {1}\" successfully added using login \"{2}\".", newUser.First, newUser.Last, newUser.ID), "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearControls_NewUser();
            PopulateUsers();
        }

        private bool Validate_ModifyUser_Password(out string errors)
        {
            var sb = new StringBuilder();

            if (txtModifyUser_Password.Text.Trim().Length < 6)
                sb.AppendLine("New password must be at least 6 characters.");

            if (txtModifyUser_Password.Text.Trim() != txtModifyUser_Password_Confirm.Text.Trim())
                sb.AppendLine("Passwords do not match.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private bool Validate_ModifyUser_Pin(out string errors)
        {
            var sb = new StringBuilder();

            if (txtModifyUser_Pin.Text.Trim().Length < 4)
                sb.AppendLine("New PIN must be at least 4 characters.");

            if (txtModifyUser_Pin.Text.Trim() != txtModifyUser_Pin_Confirm.Text.Trim())
                sb.AppendLine("PINs do not match.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private bool Validate_NewUser(out string errors, out int newUserID)
        {
            var sb = new StringBuilder();

            if (!int.TryParse(txtCreateUser_Login.Text.Trim(), out newUserID))
                sb.AppendLine("New user logins must be numeric only.");

            if (string.IsNullOrWhiteSpace(txtCreateUser_FirstName.Text.Trim()))
                sb.AppendLine("First name cannot be blank.");

            if (string.IsNullOrWhiteSpace(txtCreateUser_LastName.Text.Trim()))
                sb.AppendLine("Last name cannot be blank.");

            if (!ClassUtility.ValidateEmailAddress(txtCreateUser_Email.Text.Trim()))
                sb.AppendLine("Email address required.");

            if (string.IsNullOrWhiteSpace(txtCreateUser_Password.Text.Trim()))
                sb.AppendLine("Password cannot be blank.");

            if (txtCreateUser_Password.Text.Trim().Length < 6)
                sb.AppendLine("Password must be at least 6 characters.");

            if (txtCreateUser_Password.Text.Trim() != txtCreateUser_Password_Confirm.Text.Trim())
                sb.AppendLine("Passwords do not match.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ignoreStateChange)
                return;

            var selectedUser = (ClassUser)cmbModifyUser_SelectUser.SelectedItem;
            switch (selectedUser.UserType)
            {
                case ClassUser.USERTYPE_ADMIN:
                    radModifyUser_UserType_Administrator.Checked = true;
                    break;
                case ClassUser.USERTYPE_MODERATOR:
                    radModifyUser_UserType_Moderator.Checked = true;
                    break;
                case ClassUser.USERTYPE_SSR:
                    radModifyUser_UserType_SSR.Checked = true;
                    break;
                default:
                    radModifyUser_UserType_Standard.Checked = true;
                    break;
            }
            radModifyUser_DisableLogin.Checked = selectedUser.LoginDisabled;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var t = (TextBox)sender;
            t.SelectAll();
        }

        private void ClearControls_ModifyUser()
        {
            foreach (var textBox in pnlUser_Modify.Controls.OfType<TextBox>())
                textBox.Clear();
            radModifyUser_UserType_Standard.Checked = true;
            radModifyUser_DisableLogin.Checked = false;
        }

        private void ClearControls_NewUser()
        {
            foreach (var textBox in pnlUser_Create.Controls.OfType<TextBox>())
                textBox.Clear();
            radCreateUser_UserType_Standard.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlUser_Modify_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnModifyUser;
        }

        private void pnlUser_Create_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnCreateUser;
        }
    }
}