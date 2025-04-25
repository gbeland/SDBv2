using System;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Misc;
using SDB.Classes.User;
using SDB.Forms.General;

namespace SDB.Forms.Asset
{
	public partial class FormAsset_Warranty : Form
	{
		private readonly ClassAsset _asset;
		private readonly ClassAsset.ClassWarrantyInfo _assetWarrantyBeforeEdit;
		private ClassUser _supervisor;
		private bool _isEditAllowed;
		private bool _ignoreStateChange;

		public FormAsset_Warranty(ClassAsset asset)
		{
			InitializeComponent();
			_asset = asset;
			_assetWarrantyBeforeEdit = _asset.WarrantyInfo;
		}

		private void frmWarranty_Load(object sender, EventArgs e)
		{
			Populate();
			btnCancel.Select();

			// if logged-in user is administrator, unlock automatically
			_isEditAllowed = GS.Settings.LoggedOnUser.IsAdmin;
		}

		private void Populate()
		{
			_ignoreStateChange = true;
			txtAsset.Text = _asset.AssetName;
			lblPanel.Visible = !string.IsNullOrEmpty(_asset.Panel);
			txtPanel.Text = _asset.Panel;
			txtReleaseNumber.Text = _asset.ReleaseNumber;

			// LABOR WARRANTY
			txtLaborWarrantyNumber.Text = _asset.WarrantyInfo.LaborWarrantyNumber;
			//ndtpLaborWarrantyStarts.Value = _asset.WarrantyInfo.InstallDate;
			ndtpLaborWarrantyStarts.Value = _asset.WarrantyInfo.ShippedDate; //Requested By Tood 05/22/2020 (InstallDate to ShippedDate)
			ndtpLaborWarrantyExpires.Value = _asset.WarrantyInfo.LaborWarrantyExpire;
			lblLaborWarrantyDuration.Text = GetDuration(ndtpLaborWarrantyStarts.Value, ndtpLaborWarrantyExpires.Value);


			// LABOR CONTRACT
			txtLaborContractNumber.Text = _asset.WarrantyInfo.LaborContractNumber;
			ndtpLaborContractStarts.Value = _asset.WarrantyInfo.LaborContractStart;
			ndtpLaborContractExpires.Value = _asset.WarrantyInfo.LaborContractExpire;
			lblLaborContractDuration.Text = GetDuration(ndtpLaborContractStarts.Value, ndtpLaborContractExpires.Value);
			chkLaborContractIsMonitoring.Checked = _asset.WarrantyInfo.MonitoringContractOnly;

            cbxBillToMarket.Checked = _asset.WarrantyInfo.BillToMarket;

            // PARTS WARRANTY
            txtPartsWarrantyNumber.Text = _asset.WarrantyInfo.PartsWarrantyNumber;
			ndtpPartsWarrantyStarts.Value = _asset.WarrantyInfo.ShippedDate;
			ndtpPartsWarrantyExpires.Value = _asset.WarrantyInfo.PartsWarrantyExpire;
			lblPartsWarrantyDuration.Text = GetDuration(ndtpPartsWarrantyStarts.Value, ndtpPartsWarrantyExpires.Value);

			// PARTS CONTRACT
			txtPartsContractNumber.Text = _asset.WarrantyInfo.PartsContractNumber;
			ndtpPartsContractStarts.Value = _asset.WarrantyInfo.PartsContractStart;
			ndtpPartsContractExpires.Value = _asset.WarrantyInfo.PartsContractExpire;
			lblPartsContractDuration.Text = GetDuration(ndtpPartsContractStarts.Value, ndtpPartsContractExpires.Value);
			_ignoreStateChange = false;


            //Creative
            tbxCreativeNumber.Text = _asset.WarrantyInfo.CreativeContract;
            dtpCreativeStart.Value = _asset.WarrantyInfo.CreativeStart;
            dtpCreativeExpires.Value = _asset.WarrantyInfo.CreativeExpire;
            lblCreativeDuration.Text = GetDuration(dtpCreativeStart.Value, dtpCreativeExpires.Value);
            _ignoreStateChange = false;

            //Cradlepoint
            tbxCradlepointNumber.Text = _asset.WarrantyInfo.CradlepointContract;
            dtpCradlepointStart.Value = _asset.WarrantyInfo.CradlepointStart;
            dtpCradlepointExpire.Value = _asset.WarrantyInfo.CradlepointExpire;
            lblCradlepointDuration.Text = GetDuration(dtpCradlepointStart.Value, dtpCradlepointExpire.Value);
            _ignoreStateChange = false;


        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!Validate_WarrantyInfo(out var errors))
			{
				MessageBox.Show(errors, "Asset Warranty/Contract Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!_isEditAllowed)
			{
				using (var overrideForm = new FormSupervisor_Override())
				{
					overrideForm.SetMainText("Only supervisors should change this information. Contact your supervisor to proceed.");
					overrideForm.SetPermitButtonText("Permit");
					overrideForm.ShowDialog(this);

					if (overrideForm.Result != FormSupervisor_Override.VerificationResultEnum.Permit)
						return;
					_supervisor = overrideForm.Supervisor;
				}
			}

			if (_supervisor != null)
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.SupervisorNotice, ClassEmailGenerator.GenerateEmail_Supervisor_WarrantyEdit(_assetWarrantyBeforeEdit, _asset, _supervisor));

            // Change warranty info for asset
            _asset.WarrantyInfo = new ClassAsset.ClassWarrantyInfo
            {
                // Labor Warranty
                LaborWarrantyNumber = txtLaborWarrantyNumber.Text.Trim(),
                InstallDate = ndtpLaborWarrantyStarts.Value,
                LaborWarrantyExpire = ndtpLaborWarrantyExpires.Value,

                // Parts Warranty
                PartsWarrantyNumber = txtPartsWarrantyNumber.Text.Trim(),
                ShippedDate = ndtpPartsWarrantyStarts.Value,
                PartsWarrantyExpire = ndtpPartsWarrantyExpires.Value,

                // Labor Contract
                LaborContractNumber = txtLaborContractNumber.Text.Trim(),
                LaborContractStart = ndtpLaborContractStarts.Value,
                LaborContractExpire = ndtpLaborContractExpires.Value,
                MonitoringContractOnly = chkLaborContractIsMonitoring.Checked,

                // Parts Contract
                PartsContractNumber = txtPartsContractNumber.Text.Trim(),
                PartsContractStart = ndtpPartsContractStarts.Value,
                PartsContractExpire = ndtpPartsContractExpires.Value,

                //creative
                CreativeContract = tbxCreativeNumber.Text.Trim(),
                CreativeStart = dtpCreativeStart.Value,
                CreativeExpire = dtpCreativeExpires.Value,

                //cradlepoint
                CradlepointContract = tbxCradlepointNumber.Text.Trim(),
                CradlepointStart = dtpCreativeStart.Value,
                CradlepointExpire = dtpCradlepointExpire.Value,

                BillToMarket = cbxBillToMarket.Checked
				};

			// Update the warranty info in the db
			ClassAsset.UpdateWarranty(_asset);
			ClassJournal.AddJournalEntry(_asset, "Modified asset warranty.", null, true);
			ClassNotification.SendNotificationsForObject("Modified asset warranty.", ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Asset, _asset.ID, _asset.AssetName);
			DialogResult = DialogResult.OK;
			Close();
		}

		private struct WarrantyContractValidationGroup
		{
			internal string GroupName { get; set; }
			internal DateTime? Start { get; set; }
			internal DateTime? Expire { get; set; }
			internal string Number { get; set; }
		}

		private string GetDuration(DateTime? d1, DateTime? d2)
		{
			if (!d1.HasValue || !d2.HasValue)
				return string.Empty;
			
			var ts = d2.Value - d1.Value;
			if (ts.Days <= 365)
				return ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round());

			ts = ts.Round();
			var years = (int)(ts.TotalDays / 365);
			var days = (int)(ts.TotalDays % 365);
			return string.Format("{0}y {1}d", years, days);
		}

		private bool Validate_WarrantyInfo(out string errors)
		{
			var sb = new StringBuilder();
			var wcGroups = new[]
			               {
				               new WarrantyContractValidationGroup
				               {
					               GroupName = "Labor Warranty",
					               Start = ndtpLaborWarrantyStarts.Value,
					               Expire = ndtpLaborWarrantyExpires.Value,
					               Number = txtLaborWarrantyNumber.Text
				               },
				               new WarrantyContractValidationGroup
				               {
					               GroupName = "Labor Contract",
					               Start = ndtpLaborContractStarts.Value,
					               Expire = ndtpLaborContractExpires.Value,
					               Number = txtLaborContractNumber.Text
				               },
				               new WarrantyContractValidationGroup
				               {
					               GroupName = "Parts Warranty",
					               Start = ndtpPartsWarrantyStarts.Value,
					               Expire = ndtpPartsWarrantyExpires.Value,
					               Number = txtPartsWarrantyNumber.Text
				               },
				               new WarrantyContractValidationGroup
				               {
					               GroupName = "Parts Contract",
					               Start = ndtpPartsContractStarts.Value,
					               Expire = ndtpPartsContractExpires.Value,
					               Number = txtPartsContractNumber.Text
				               }
			               };
			foreach (var group in wcGroups)
			{
				if (!ValidateWarrantyOrContract(group, out var error))
					sb.AppendLine(error);
			}

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		/// <summary>
		/// Verifies that expire is after start and that a name is provided.
		/// </summary>
		private bool ValidateWarrantyOrContract(WarrantyContractValidationGroup group, out string error)
		{
			if (!group.Start.HasValue && !group.Expire.HasValue)
			{
				error = string.Empty;
				return true;
			}

			if (!group.Start.HasValue || !group.Expire.HasValue)
			{
				error = $"{group.GroupName}: Start and expire date must both be provided.";
				return false;
			}

			var startValue = group.Start.Value;
			var expireValue = group.Expire.Value;

			if (expireValue <= startValue)
			{
				error = $"{group.GroupName}: Expire date must be after the start.";
				return false;
			}

			if (string.IsNullOrEmpty(group.Number))
			{
				error = $"{group.GroupName}: The warranty or contract number must be provided.";
				return false;
			}
			
			error = string.Empty;
			return true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void ndtp_Enter(object sender, EventArgs e)
		{
			var ndtp = (NullableDateTimePicker)sender;
			if (ndtp.Value == null)
				ndtp.Value = DateTime.Now;
		}

		private void textBox_Enter(object sender, EventArgs e)
		{
			var textBox = (TextBox)sender;
			textBox.SelectAll();
		}

		private void ndtpLaborWarrantyStarts_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblLaborWarrantyDuration.Text = GetDuration(ndtpLaborWarrantyStarts.Value, ndtpLaborWarrantyExpires.Value);
		}

		private void ndtpLaborWarrantyExpires_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblLaborWarrantyDuration.Text = GetDuration(ndtpLaborWarrantyStarts.Value, ndtpLaborWarrantyExpires.Value);
		}

		private void ndtpLaborContractStarts_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblLaborContractDuration.Text = GetDuration(ndtpLaborContractStarts.Value, ndtpLaborContractExpires.Value);
		}

		private void ndtpLaborContractExpires_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblLaborContractDuration.Text = GetDuration(ndtpLaborContractStarts.Value, ndtpLaborContractExpires.Value);
		}

		private void ndtpPartsWarrantyStarts_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblPartsWarrantyDuration.Text = GetDuration(ndtpPartsWarrantyStarts.Value, ndtpPartsWarrantyExpires.Value);
		}

		private void ndtpPartsWarrantyExpires_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblPartsWarrantyDuration.Text = GetDuration(ndtpPartsWarrantyStarts.Value, ndtpPartsWarrantyExpires.Value);
		}

		private void ndtpPartsContractStarts_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblPartsContractDuration.Text = GetDuration(ndtpPartsContractStarts.Value, ndtpPartsContractExpires.Value);
		}

		private void ndtpPartsContractExpires_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			lblPartsContractDuration.Text = GetDuration(ndtpPartsContractStarts.Value, ndtpPartsContractExpires.Value);
		}
	}
}