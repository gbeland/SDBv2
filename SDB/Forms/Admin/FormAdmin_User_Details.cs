using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.User;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_User_Details : Form
	{
		private ClassUser _user;
		private readonly string _prefillPasswordChange;

		#region Constructors
		public FormAdmin_User_Details()
		{
			InitializeComponent();
		}

		public FormAdmin_User_Details(string prefillPasswordChange) : this()
		{
			_prefillPasswordChange = prefillPasswordChange;
		}
		#endregion

		private void FormUser_Details_Load(object sender, EventArgs e)
		{
			User_Load();

			if (_user == null)
				throw new NullReferenceException("User details failed to load.");
		}

		private void User_Load()
		{
			_user = ClassUser.GetByID(GS.Settings.LoggedOnUser.ID);
			Populate_UserDetails();
		}

		private void Populate_UserDetails()
		{
			txtUser_Login.Text = _user.ID.ToString(CultureInfo.InvariantCulture);
			txtUser_FirstName.Text = _user.First;
			txtUser_LastName.Text = _user.Last;
			txtUser_Email.Text = _user.Email;
			if (!string.IsNullOrEmpty(_prefillPasswordChange))
			{
				txtPassword_Current.Text = _prefillPasswordChange;
				txtPassword_New.Select();
			}
		}

		private void btnUser_Update_Click(object sender, EventArgs e)
		{
			string errors;
			if (!Validate_UserDetails(out errors))
			{
				MessageBox.Show(errors, "User Detail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_user.First = txtUser_FirstName.Text.Trim();
			_user.Last = txtUser_LastName.Text.Trim();
			_user.Email = txtUser_Email.Text.Trim();
			ClassUser.Update(_user);
			MessageBox.Show("User successfully updated.", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
			User_Load();
		}

		private void btnPassword_Change_Click(object sender, EventArgs e)
		{
			string errors;
			if (!Validate_Password(out errors))
			{
				MessageBox.Show(errors, "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ClassUser.SetPassword(_user.ID, txtPassword_New.Text);
			_user.ClearTemporaryPassword();
			MessageBox.Show("Password successfully changed.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearControls_Password();
		}

		private void btnPin_Change_Click(object sender, EventArgs e)
		{
			string errors;
			if (!Validate_Pin(out errors))
			{
				MessageBox.Show(errors, "Pin Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ClassUser.SetPin(_user.ID, txtPin_New.Text);
			MessageBox.Show("PIN successfully changed.", "PIN Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearControls_Pin();
		}

		private bool Validate_UserDetails(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrWhiteSpace(txtUser_FirstName.Text.Trim()))
				sb.AppendLine("First name cannot be blank.");

			if (string.IsNullOrWhiteSpace(txtUser_LastName.Text.Trim()))
				sb.AppendLine("Last name cannot be blank.");

			if (!ClassUtility.ValidateEmailAddress(txtUser_Email.Text.Trim()))
				sb.AppendLine("Email address is not valid.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private bool Validate_Password(out string errors)
		{
			var sb = new StringBuilder();
			
			if (string.IsNullOrEmpty(txtPassword_Current.Text))
				sb.AppendLine("Current or temporary password must be provided to change password. Contact an administrator if you have forgotten your password.");

			if (!ClassUser.VerifyPassword(_user.ID, txtPassword_Current.Text))
			{
				if (!ClassUser.VerifyTemporaryPassword(_user.ID, txtPassword_Current.Text, TimeSpan.FromHours(ClassUser.TEMPORARY_PASSWORD_VALID_FOR_HOURS)))
					sb.AppendLine("Current or temporary password incorrect. Contact an administrator if you have forgotten your password.");
			}

			if (txtPassword_New.Text != txtPassword_Confirm.Text)
				sb.AppendLine("Passwords do not match.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private bool Validate_Pin(out string errors)
		{
			var newPin = txtPin_New.Text;
			var confirmPin = txtPin_Confirm.Text;
			
			var sb = new StringBuilder();

			if (newPin.Length < ClassUser.PIN_MINIMUM_LENGTH)
				sb.AppendLine(string.Format("PIN must be at least {0} characters.", ClassUser.PIN_MINIMUM_LENGTH));

			if (ClassUtility.IsConsecutive(newPin) || ClassUtility.IsAllSameCharacter(newPin))
				sb.AppendLine("PIN must not consist of consecutive digits or all same digit.");

			if (newPin != confirmPin)
				sb.AppendLine("PINs do not match.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private void ClearControls_Password()
		{
			foreach (var textBox in pnlPassword.Controls.OfType<TextBox>())
				textBox.Clear();
		}

		private void ClearControls_Pin()
		{
			foreach (var textBox in pnlPin.Controls.OfType<TextBox>())
				textBox.Clear();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pnlUserDetails_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnUser_Update;
		}

		private void pnlPassword_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnPassword_Change;
		}

		private void pnlPin_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnPin_Change;
		}
	}
}