using System;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.User;

namespace SDB.Forms.Asset
{
	public partial class FormAsset_ServiceReminder : Form
	{
		readonly ClassAsset _asset;

		public FormAsset_ServiceReminder(ClassAsset asset)
		{
			InitializeComponent();
			_asset = asset;
		}

		private void frmAssetServiceReminder_Load(object sender, EventArgs e)
		{
			lblTitle.Text = $"Service Reminder for Asset: {_asset.AssetName}";
			txtServiceReminder.Text = _asset.ServiceReminder;

			var hasServiceReminder = _asset.ServiceReminder_UserID.HasValue && _asset.ServiceReminder_DateTime.HasValue;
			pnlLastUpdated.Visible = hasServiceReminder;
			txtLastUpdated_User.Text = hasServiceReminder ? ClassUser.GetFirstL(_asset.ServiceReminder_UserID.Value) : string.Empty;
			txtLastUpdated_Date.Text = hasServiceReminder ? $"{_asset.ServiceReminder_DateTime.Value:yyyy-MM-dd}" : string.Empty;
		}

		private void btnClearAndSave_Click(object sender, EventArgs e)
		{
			_asset.ClearServiceReminder();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SubmitText();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void txtServiceReminder_KeyDown(object sender, KeyEventArgs e)
		{
			if (ModifierKeys != Keys.Control)
				return;

			if (e.KeyCode == Keys.Enter)
				SubmitText();
		}

		private void SubmitText()
		{
			var text = txtServiceReminder.Text.Trim();
			// Save the service reminder in the database because the user may not save changes afterward
			_asset.SetServiceReminder(text);
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}