using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Misc;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.General;
using SDB.Forms.Tech;

namespace SDB.Forms.Ticket
{
	public partial class FormTicket_Create : Form
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		private readonly ClassAsset _asset;
		private readonly ClassCustomer _customer;
		private readonly ClassMarket _market;
		private readonly List<ClassTicket_Symptom> _symptomList;

		private readonly List<ClassTech> _assignableTechs = new List<ClassTech>();

		private readonly ClassWebDownload _webcamDownloadClient = new ClassWebDownload(5000);

		private readonly Color _greenBgColor = Color.FromArgb(192, 255, 192);
		private readonly Color _cancelBgColor = Color.FromArgb(255, 224, 192);
		private bool _ignoreStateChange;
		#endregion

		#region Public Properties
		/// <summary>
		/// Populates <see cref="TicketExtraProperties.SymptomList"/> to be used when adding it to the database.
		/// </summary>
		public readonly ClassTicket NewTicket;
		public Image NewTicketImage;

		/// <summary>
		/// If not null, the ID of the supervisor who provided the override to open ticket.
		/// </summary>
		public ClassUser SupervisorForOsaOverride;
		#endregion

		#region Constructor
		public FormTicket_Create(ClassAsset asset)
		{
			InitializeComponent();
			NewTicket = new ClassTicket();

			_asset = asset;
			_customer = ClassCustomer.GetByAsset(_asset);
			_market = ClassMarket.GetByID(_asset.MarketID);

			_assignableTechs.AddRange(ClassTech.GetByAsset(_asset.ID));

			cmbReportType.Items.AddRange(new object[] { "Alert", "CamCheck", "E-Mail", "On-Site", "Phone" });
			cmbReportType.SelectedIndex = -1;

			_symptomList = ClassTicket_Symptom.GetAll().ToList();
			olvSymptoms.SetObjects(_symptomList);
			olvSymptoms.PrimarySortColumn = olvColSymptom;
			olvSymptoms.PrimarySortOrder = SortOrder.Ascending;

			_webcamDownloadClient.DownloadDataCompleted += WebCamDownloadDataComplete;
		}
		#endregion

		#region Private Methods
		private void FormTicket_Create_Load(object sender, EventArgs e)
		{
			Populate();
		}

		private void FormTicket_Create_Shown(object sender, EventArgs e)
		{
			GetWebCamImageIfPossible();

			if (string.IsNullOrEmpty(_asset.ServiceReminder))
				return;

			var serviceReminderFooter = _asset.ServiceReminder_UserID.HasValue ? string.Format("(Set by {0} on {1:yyyy-MM-dd})", ClassUser.GetFirstL(_asset.ServiceReminder_UserID.Value), _asset.ServiceReminder_DateTime) : string.Empty;
			var message = string.Format("{0}{1}{1}{2}", _asset.ServiceReminder, Environment.NewLine, serviceReminderFooter);
			var title = $"Service Reminder for {_asset.AssetName}";
			MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Populate()
		{
			_ignoreStateChange = true;
			if (!_asset.Net.Webcam_Installed)
			{
				btnTicketImage_Webcam.Text = "Unavailable";
				btnTicketImage_Webcam.BackColor = Color.Gray;
				btnTicketImage_Webcam.Enabled = false;
			}

			txtAsset.Text = _asset.AssetName;
			txtCustomer.Text = _customer.Name;
			txtMarket.Text = _asset.ExtraProperties.MarketName;
			txtPanel.Text = _asset.Panel;
			var facing = string.IsNullOrEmpty(_asset.FacingDirection) ? string.Empty : string.Format(" ({0})", _asset.FacingDirection);
			var address = string.IsNullOrEmpty(_asset.Address) ? string.Empty : string.Format("{0}{1}", _asset.Address, Environment.NewLine);
			txtAssetLocation.Text = string.Format("{1}{2}{0}{3}{4}, {5} {6}", Environment.NewLine, _asset.Location, facing, address, _asset.City, _asset.State, _asset.Country);
			txtAssetServiceReminder.Text = _asset.ServiceReminder;
			txtAssetServiceReminder.BackColor = string.IsNullOrEmpty(_asset.ServiceReminder) ? SystemColors.ControlDark : Color.Yellow;
			txtAssetNotes.Text = _asset.Notes;

            cmbTechList.Items.AddRange(ClassTech.GetByAsset((int)_asset.ID).ToArray());
            if(cmbTechList.Items.Count > 0)
                cmbTechList.SelectedIndex = 0;
            cmbTechList.DisplayMember = "DisplayMemberWithPriority";

            if (_asset.IsPMC)
            {
                cbxSendOSA.Text = "Can Not Send OSA On PMC Asset From Ticket Creation";
                cbxSendOSA.Enabled = false;
            }
            
            dtpDateReceived.Value = ClassDatabase.GetCurrentTime();
			ucWarrantyStatus.ShowStatus(_asset);
			txtMarketNotes.Text = ClassMarket.GetByID(_asset.MarketID).Notes;
			chkEmail_SendOpen.Checked = _market.SendEmail_Open;
			_ignoreStateChange = false;
		}

		private void btnCreateTicket_Click(object sender, EventArgs e)
		{
			if (!Validate_TicketCreation(out var errors))
			{
				MessageBox.Show(errors, "Ticket Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

            if (_asset.ManagedByCreative)
                MessageBox.Show("This Asset Is Managed By The Creative Group. Please Notify Them!", "ALERT!");

			btnCreate.Enabled = false;

			NewTicket.OpenDateTime = dtpDateReceived.Value;
			NewTicket.Open_UserID = GS.Settings.LoggedOnUser.ID;
			NewTicket.AssetID = _asset.ID;
			NewTicket.ExtraProperties.AssetName = _asset.AssetName;
			NewTicket.CustomerIssueNumber = txtIssueNum.Text.Trim();
			NewTicket.OrderNum = _asset.ActiveLaborNumber;
			NewTicket.ReportedType = cmbReportType.Text;
			NewTicket.ReportedBy = txtReportedBy.Text.Trim();
			NewTicket.Symptom_Other = txtSymptoms_Other.Text.Trim();
			NewTicket.ExtraProperties.SymptomList = _symptomList.Where(s => s.Selected).ToList();

            if (radCritical.Checked)
                NewTicket.IssuePriority = 3;
            else if (radHigh.Checked)
                NewTicket.IssuePriority = 2;
            else NewTicket.IssuePriority = 1;
            

            if(cbxSendOSA.Checked)
            {
                if (_asset.IsLaborCovered)
                {
                    NewTicket.UpdateOsaNotes(rtbOsaNote.Text, NewTicket.IssuePriority);
                    NewTicket.TechID = (((ClassTech)cmbTechList.SelectedItem).ID);
                }
                else
                {
                    using (FormSupervisor_Override so = new FormSupervisor_Override())
                    {
                        so.ShowDialog();
                        if (so.Result == FormSupervisor_Override.VerificationResultEnum.Permit)
                        {
                            NewTicket.UpdateOsaNotes(rtbOsaNote.Text, NewTicket.IssuePriority);
                            NewTicket.TechID = (((ClassTech)cmbTechList.SelectedItem).ID);
                        }
                    }
                }
                
            }

            if (pbImage.Image != null)
				NewTicket.ExtraProperties.OSA_Image = pbImage.Image;

			NewTicket.OpenOption_SendEmail_Open = chkEmail_SendOpen.Checked;

			DialogResult = DialogResult.OK;
			Close();
		}

		private bool Validate_TicketCreation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(cmbReportType.Text))
				sb.AppendLine("Please select a report type.");

			if (string.IsNullOrEmpty(txtReportedBy.Text))
				sb.AppendLine("Please enter the name of the person/company that reported the issue.");

			if (olvSymptoms.CheckedItems.Count < 1)
				sb.AppendLine("Please select at least one symptom to identify the issue.");

			if (DetermineSymptomOther() && string.IsNullOrEmpty(txtSymptoms_Other.Text))
				sb.AppendLine("Please enter a description of the symptom. One of the selected symptoms is 'Other.'");
            if (cbxSendOSA.Checked && (rtbOsaNote.Text == string.Empty || cmbTechList.SelectedIndex == -1 || (!radCritical.Checked && !radHigh.Checked && !radNormal.Checked)))
            {
                sb.AppendLine("Please Fill Out OSA Details");
            }
            errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		/// <summary>
		/// Returns true if "Other" is selected as a symptom.
		/// </summary>
		private bool DetermineSymptomOther()
		{
			return (_symptomList.Any(s => s.Symptom == "Other" && s.Selected));
		}

		private void btnTicketImage_Webcam_Click(object sender, EventArgs e)
		{
			GetWebCamImageIfPossible();
		}

		private void GetWebCamImageIfPossible()
		{
			#region Validation
			if (!_asset.Net.Webcam_Installed)
				return;

			if (_webcamDownloadClient.IsBusy)
			{
				_webcamDownloadClient.CancelAsync();
				return;
			}
			#endregion

			lblCameraError.Visible = false;

			btnTicketImage_File.Enabled = false;
			btnCreate.Enabled = false;
			btnCreate.Text = "Fetching Image";
			lblCameraProcessing.Visible = true;

			var camType = ClassCameraType.GetByID(_asset.Net.Webcam_Type);
			var webcamUriString = _asset.URL_CameraImage(camType);
			Uri webcamUri;
			try
			{
				webcamUri = new Uri(webcamUriString);
			}
			catch (UriFormatException exc)
			{
				var errorMessage = string.Format("Webcam URL was not valid, check network and camera settings.{0}{0}URL: {1}{0}{0}Error: {2}", Environment.NewLine, webcamUriString, exc.Message);
				MessageBox.Show(errorMessage, "Webcam Address Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ResetControls_CamDownloadFinished();
				return;
			}
			_webcamDownloadClient.DownloadDataAsync(webcamUri);
			btnTicketImage_Webcam.BackColor = _cancelBgColor;
			btnTicketImage_Webcam.Text = "Cancel";
		}

		private void btnTicketImage_File_Click(object sender, EventArgs e)
		{
			lblCameraError.Visible = false;
			using (var ofd = new OpenFileDialog())
			{
				ofd.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
				ofd.ShowDialog();
				if (!File.Exists(ofd.FileName))
					return;
				var ticketImageFileInfo = new FileInfo(ofd.FileName);
				if (ticketImageFileInfo.Length > ClassTicket_Image.MAX_FILE_SIZE_BYTES)
				{
					MessageBox.Show(string.Format("Selected image is too large. File must be less than {0} bytes.", ClassTicket_Image.MAX_FILE_SIZE_BYTES), "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				NewTicketImage = Image.FromFile(ofd.FileName);
				pbImage.Image = NewTicketImage;
			}
		}

		private void btnTicketImage_Clear_Click(object sender, EventArgs e)
		{
			if (_webcamDownloadClient.IsBusy)
				_webcamDownloadClient.CancelAsync();

			lblCameraError.Visible = false;
			NewTicketImage = null;
			pbImage.Image = null;
		}

		private void WebCamDownloadDataComplete(object sender, DownloadDataCompletedEventArgs e)
		{
			ResetControls_CamDownloadFinished();

			if (e.Cancelled)
			{
				//ResetControls_CamDownloadFinished();
				return;
			}

			if (e.Error != null)
			{
				NewTicketImage = null;
				pbImage.Image = null;
				lblCameraError.Visible = true;
				ClassLogFile.AppendToLog($"Error obtaining camera image for ticket open: {e.Error.Message} {e.Error.InnerException?.Message ?? string.Empty}");
				return;
			}

			var imageData = e.Result;
			NewTicketImage = ClassUtility.ByteArrayToImage(imageData);
			if (NewTicketImage != null)
				pbImage.Image = NewTicketImage;
		}

		private void ResetControls_CamDownloadFinished()
		{
			btnTicketImage_Webcam.Text = "Webcam";
			btnTicketImage_Webcam.BackColor = _greenBgColor;
			btnTicketImage_File.Enabled = true;
			btnCreate.Text = "Create Ticket";
			btnCreate.Enabled = true;
			lblCameraProcessing.Visible = false;
		}

		private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((string)cmbReportType.SelectedItem == "Alert" && string.IsNullOrEmpty(txtReportedBy.Text))
				txtReportedBy.Text = "PVM";
			else if ((string)cmbReportType.SelectedItem != "Alert" && txtReportedBy.Text == "PVM")
				txtReportedBy.Clear();
			else if ((string)cmbReportType.SelectedItem == "CamCheck" && string.IsNullOrEmpty(txtReportedBy.Text))
				txtReportedBy.Text = GS.Settings.LoggedOnUser.FirstL;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Ticket_Cancel();
		}

		private void olvSymptoms_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (olvSymptoms.CheckedItems.Count > ClassTicket.MAX_SELECTED_SYMPTOMS)
			{
				MessageBox.Show($"A maximum of {ClassTicket.MAX_SELECTED_SYMPTOMS} symptom{ClassTicket.MAX_SELECTED_SYMPTOMS.SIfPlural()} may be selected.");
				olvSymptoms.UncheckAll();
			}
			pnlSymptoms_Other.Visible = DetermineSymptomOther();
		}

		private void chkEmail_SendOpen_CheckedChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			var isMarketPreference = _market.SendEmail_Open == chkEmail_SendOpen.Checked;

			chkEmail_SendOpen.BackColor = isMarketPreference ? SystemColors.Control : Color.FromArgb(255, 192, 192);

			if (!isMarketPreference)
			{
				MessageBox.Show(string.Format("The market for this asset {0} set to receive open notifications. The current setting does not reflect this preference.", _market.SendEmail_Open ? "is" : "is not"),
					"Open Ticket Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void Ticket_Cancel()
		{
			if (_webcamDownloadClient.IsBusy)
				_webcamDownloadClient.CancelAsync();
			DialogResult = DialogResult.Cancel;
			Close();
		}

        /*
		private void btnAssetCopyReminderToOsa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_asset.ServiceReminder))
				return;

			if (txtOSAComments.Text.EndsWith(_asset.ServiceReminder, StringComparison.OrdinalIgnoreCase))
				return;

			if (string.IsNullOrWhiteSpace(txtOSAComments.Text))
			{
				txtOSAComments.Text = _asset.ServiceReminder;
				return;
			}

			txtOSAComments.Text = txtOSAComments.Text + Environment.NewLine + _asset.ServiceReminder;
		}
        */


        /*
		private void HandleOsaStatusChange()
		{
			if (radOsa_None.Checked)
				EnableOsa(false);
			else
			{
				if (!_asset.IsLaborCovered)
				{
					using (var overrideForm = new FormSupervisor_Override())
					{
						overrideForm.Text = string.Format("OSA Verification for {0}", _asset.AssetName);
						overrideForm.ShowDialog();
						switch (overrideForm.Result)
						{
							case FormSupervisor_Override.VerificationResultEnum.Permit:
								SupervisorForOsaOverride = overrideForm.Supervisor;
								break;

							default:
								radOsa_None.Checked = true;
								return;
						}
					}
				}

				EnableOsa(true);
			}
		}
        */

            /*
		private void EnableOsa(bool enable)
		{
			pnlOsaEdit.Enabled = pnlOsaEdit.Visible = enable;
			btnAssetCopyReminderToOsa.Visible = enable;
			cmbTech.DataSource = _assignableTechs;
			if (cmbTech.Items.Count > 0)
				cmbTech.SelectedIndex = 0;
			if (enable)
				return;

			cmbTech.SelectedIndex = -1;
			txtOSAComments.Clear();
		}

    */
		#endregion

		#region Public Methods
		/// <summary>
		/// Selects camera check as ticket creation reason.
		/// </summary>
		public void SelectCameraCheck()
		{
			cmbReportType.SelectedItem = "CamCheck";
		}

		public void SetReportedBy(string s)
		{
			txtReportedBy.Text = s;
		}
        #endregion

        private void cbxSendOSA_CheckedChanged(object sender, EventArgs e)
        {
            rtbOsaNote.ReadOnly = !cbxSendOSA.Checked;
            cmbTechList.Enabled = cbxSendOSA.Checked;
        }

    }
}