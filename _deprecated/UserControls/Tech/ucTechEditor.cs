using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.General;
using SDB.Forms.Tech;

namespace SDB.UserControls.Tech
{
	public partial class TechEditor : UserControl
	{
		private enum TechEditorMode { Viewing, Editing, Adding };
		private TechEditorMode _currentTechEditorMode = TechEditorMode.Viewing;
		private ClassTech _tech;
		private int _techStatusComboboxSavedState;
		private bool _ignoreStateChange;
		private List<ClassAsset> _assignedAssets = new List<ClassAsset>();
		private List<ClassLegacyRMA> _legacyRmas = new List<ClassLegacyRMA>();
		private List<ClassRMA> _rmas = new List<ClassRMA>();
		private List<ClassRMA> _warningRmas = new List<ClassRMA>();
		private List<ClassShipment> _shipments = new List<ClassShipment>();

		/// <summary>
		/// Used to store current tech in case adding a new tech is canceled (load previous).
		/// </summary>
		private ClassTech _techLoadedBeforeAddNew;

		#region Delegates and Events
		public delegate void TechEvent(ClassTech tech);
		public delegate void AssetEvent(int assetID);
		public delegate void TicketEvent(int ticketID);
		public delegate void RMAEvent(int rmaID);
		public delegate void ShipmentEvent(int shipmentID);
		public delegate void TrackingEvent(string trackingURL);
		public delegate void UpdateEvent();

		public event AssetEvent ViewAsset;
		public event TicketEvent ViewTicket;
		/// <summary>
		/// Occurs when the usercontrol has successfully loaded a tech. The main program can use the event to populate headers or tab page text.
		/// </summary>
		public event TechEvent TechLoaded;
		public event TechEvent CreateShipment;
		public event RMAEvent ViewLegacyRMA;
		public event RMAEvent ViewRMA;
		public event ShipmentEvent ViewShipment;
		public event TrackingEvent ViewTracking;
		public event UpdateEvent TechUpdated;
		#endregion

		public TechEditor()
		{
			InitializeComponent();
			InitializeListViews();

			pnlControl_Top.BackColor = GS.Settings.ControlBarColor;

			olvColTickets_Symptoms.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Symptoms(true);
			olvColTickets_Solutions.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Solutions();

			_ignoreStateChange = true;
			cmbStatus.DisplayMember = "Description";
			cmbStatus.ValueMember = "Value";
			cmbStatus.DataSource = ClassDefinitions.TECH_STATUS_TYPES;
			_ignoreStateChange = false;
		}

		private void InitializeListViews()
		{
			olvTickets.PrimarySortColumn = olvColTickets_ID;
			olvTickets.PrimarySortOrder = SortOrder.Descending;

			olvLegacyRMAs.PrimarySortColumn = olvColRMA_ID;
			olvLegacyRMAs.PrimarySortOrder = SortOrder.Descending;
		}

		public void Tech_Load(int techID)
		{
			Cursor = Cursors.WaitCursor;
			_tech = ClassTech.GetByID(techID);
			// Switch to show open tickets upon loading a tech (closed may take too long)
			radTickets_Open.Checked = true;
			Populate();
			CheckForOldUnreceivedRmas();
			_currentTechEditorMode = TechEditorMode.Viewing;
			Cursor = Cursors.Default;
		}

		/// <summary>
		/// Reloads the current tech, if applicable.
		/// </summary>
		public void RefreshView()
		{
			if (_tech != null && _tech.ID > 0)
				Tech_Load(_tech.ID);
		}

		public void FocusSearch()
		{
			txtSearch.Select();
		}

		/// <summary>
		/// Begins the creation of a new tech.
		/// </summary>
		private void Tech_StartAdd()
		{
			if (_currentTechEditorMode == TechEditorMode.Editing)
			{
				if (MessageBox.Show("Do you want to start adding a new tech, discarding edits to the current tech?", "Confirm Cancel Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;

				_currentTechEditorMode = TechEditorMode.Viewing;
			}

			if (_currentTechEditorMode != TechEditorMode.Viewing)
				return;

			_currentTechEditorMode = TechEditorMode.Adding;

			// Remember current tech in case add of new tech is canceled
			if (_tech != null)
				_techLoadedBeforeAddNew = _tech;

			ClearControls();
			_tech = new ClassTech();
			Populate();

			mnuAddNew.Visible = false;
			mnuDelete.Visible = false;
			btnCancel.Visible = true;
			btnEditSave.Text = "Save New";
			btnPrevious.Enabled = false;
			btnNext.Enabled = false;

			LockControls(false);

			txtCompanyName.Select();
		}

		private void Tech_StartDelete()
		{
			if (_tech == null || _tech.ID < 0)
			{
				MessageBox.Show("No technician being viewed.", "Tech Delete Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Check if tech is used anywhere first
			var techUsedQty = ClassTech.GetUsedQty(_tech);
			if (techUsedQty > 0)
			{
				MessageBox.Show($"This tech is used {techUsedQty} time{(techUsedQty == 1 ? string.Empty : "s")} in the database. It cannot be deleted.", "Tech In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (MessageBox.Show($"Are you sure you want to delete tech {_tech.TechName}?", "Confirm Tech Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			ClassTech.Delete(_tech);

			ClearControls();
			MessageBox.Show("Tech deleted successfully.", "Tech Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

			#region deprecated: keep for showing deletion results
			//            DialogResult dlgResut = MessageBox.Show(string.Format("Are you sure you want to delete tech {0}?", _tech.TechName), "Tech Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			//            if (dlgResut == DialogResult.No)
			//                return;

			//            // Check if tech is assigned to any tickets first
			//            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			//            {
			//                conn.Open();
			//                using (MySqlCommand cmd = conn.CreateCommand())
			//                {
			//                    cmd.CommandText =
			//                        @"SELECT id
			//						FROM tickets
			//						WHERE tech_id = @TechID";
			//                    cmd.Parameters.AddWithValue("TechID", _tech.ID);
			//                    using (MySqlDataReader Reader = cmd.ExecuteReader())
			//                    {
			//                        List<int> AssignedTickets = new List<int>();
			//                        while (Reader.Read())
			//                            AssignedTickets.Add(Reader.GetDBInt("id"));
			//                        if (AssignedTickets.Count > 0)
			//                        {
			//                            StringBuilder AssignedTicketsFormatted = new StringBuilder();
			//                            for (int i = 0; i < AssignedTickets.Count; i++)
			//                            {
			//                                AssignedTicketsFormatted.Append(AssignedTickets[i].ToString());
			//                                if (i < AssignedTickets.Count - 1) AssignedTicketsFormatted.Append(", ");
			//                                if (i % 20 == 0 && i > 0) AssignedTicketsFormatted.AppendLine();
			//                            }
			//                            DialogResult dlgResultUsed = MessageBox.Show(string.Format("Are you really, really sure? This tech is used in at least one ticket. Deleting the tech will result in an unassigned tech for the following ticket numbers:{0}{0}{1}", Environment.NewLine, AssignedTicketsFormatted),
			//                                                                         "Tech in Use: Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			//                            if (dlgResultUsed == DialogResult.No)
			//                                return;
			//                        }
			//                    }
			//                }

			//                // Delete the tech (all confirmations accepted)
			//                using (MySqlCommand cmd = conn.CreateCommand())
			//                {
			//                    cmd.CommandText = @"DELETE FROM techs WHERE id = @TechID;";
			//                    cmd.Parameters.AddWithValue("TechID", _tech.ID);
			//                    cmd.ExecuteNonQuery();
			//                }
			//                ClearControls();
			//                MessageBox.Show("Tech deleted successfully.", "Tech Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//                conn.Close();
			//            }
			#endregion
		}

		private void Tech_StartSearch()
		{
			if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
				return;
			// Clear search field if something was found
			if (Tech_Search(txtSearch.Text))
				txtSearch.Clear();
		}

		private bool Tech_Search(string searchTerm)
		{
			var foundTechs = ClassTech.Search(searchTerm).ToList();
			switch (foundTechs.Count)
			{
				case 0:
					MessageBox.Show(string.Format("No techs were found with the search term {0}.", searchTerm), "Tech Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				case 1:
					Tech_Load(foundTechs[0].ID);
					return true;
				default:
					using (var techListForm = new FormList_Techs(foundTechs, searchTerm))
					{
						techListForm.ShowDialog(this);
						if (techListForm.SelectedTech != null)
							Tech_Load(techListForm.SelectedTech.ID);
					}
					return true;
			}
		}

		private void Populate()
		{
			_ignoreStateChange = true;
			SuspendLayout();

			ResetButtonText();
			LockControls();
			mnuDelete.Visible = GS.Settings.LoggedOnUser.IsAdmin;

			if (_tech == null)
				return;
			
			Populate_TechInfo();
			Populate_Contacts();

			txtNotes.Text = _tech.Notes;

			Populate_TechInfo();
			Populate_Contacts();
			Populate_ActiveTab();

			ResumeLayout();

			TechLoaded?.Invoke(_tech);
			_ignoreStateChange = false;
		}

		private void Populate_TechInfo()
		{
			txtCompanyName.Text = _tech.TechName;
			txtAddress.Text = _tech.Address;
			txtCity.Text = _tech.City;
			txtState.Text = _tech.State;
			txtZip.Text = _tech.Zip;
			txtCountry.Text = _tech.Country;
			txtTelephone.Text = _tech.Telephone;
			txtFax.Text = _tech.Fax;
			txtEmail.Text = _tech.Email;

			if (_tech.Shipping_UseMailingAddress)
			{
				chkShipToMailingAddress.Checked = true;
				txtShip_Address.Text = _tech.Address;
				txtShip_City.Text = _tech.City;
				txtShip_State.Text = _tech.State;
				txtShip_Zip.Text = _tech.Zip;
				txtShip_Country.Text = _tech.Country;
			}
			else
			{
				chkShipToMailingAddress.Checked = false;
				txtShip_Address.Text = _tech.Shipping_Address;
				txtShip_City.Text = _tech.Shipping_City;
				txtShip_State.Text = _tech.Shipping_State;
				txtShip_Zip.Text = _tech.Shipping_Zip;
				txtShip_Country.Text = _tech.Shipping_Country;
			}

			cmbStatus.SelectedItem = _tech.TechStatus;

			numRates_Standard.Value = (decimal)_tech.Rate_Normal;
			numRates_AfterHours.Value = (decimal)_tech.Rate_AfterHours;
			numRates_Emergency.Value = (decimal)_tech.Rate_Emergency;
		}

		private void Populate_Contacts()
		{
			txtContact1_Name.Text = _tech.Contact1_Name;
			txtContact2_Name.Text = _tech.Contact2_Name;
			txtContact3_Name.Text = _tech.Contact3_Name;

			txtContact1_Telephone.Text = _tech.Contact1_Telephone;
			txtContact2_Telephone.Text = _tech.Contact2_Telephone;
			txtContact3_Telephone.Text = _tech.Contact3_Telephone;
		}

		private void tabAdditionalInfo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Populate_ActiveTab();
		}

		private void Populate_ActiveTab()
		{
			Cursor = Cursors.WaitCursor;

			switch (tabAdditionalInfo.SelectedTab.Name)
			{
				case "tabNotes":
					// Should already be populated at load due to the fact this info is updated/saved
					break;

				case "tabAssets":
					Populate_Assets();
					break;

				case "tabTickets":
					Populate_Tickets();
					break;

				case "tabLegacyRMA":
					Populate_LegacyRMA();
					break;

				case "tabRMA":
					Populate_RMA();
					break;

				case "tabShipments":
					Populate_Shipments();
					break;
			}

			Cursor = Cursors.Default;
		}

		private void Populate_Assets()
		{
			if (_tech == null)
				return;
			
			_assignedAssets = ClassAsset.GetByTech(_tech.ID).ToList();
			_assignedAssets.PopulateExtraProperties();
			ucAssetList1.SetObjects(_assignedAssets);
		}

		private void Populate_Tickets()
		{
			if (_tech == null)
				return;

			Cursor = Cursors.WaitCursor;
			olvTickets.EmptyListMsg = "Please wait...";
			olvTickets.SetObjects(null);

			if (radTickets_Open.Checked)
			{
				olvTickets.EmptyListMsg = "No open tickets.";
				var techsTickets = ClassTicket.GetByTech(_tech.ID, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held).ToList();
				techsTickets.PopulateSymptomsAndSolutions();
				techsTickets.PopulateExtraStrings();
				olvTickets.SetObjects(techsTickets);
				txtTicketQty.Text = techsTickets.Count.ToString(CultureInfo.InvariantCulture);
			}
			else if (radTickets_Closed.Checked)
			{
				olvTickets.EmptyListMsg = "No closed tickets.";
				var techsTickets = ClassTicket.GetByTech(_tech.ID, ClassTicket.TicketType.Closed).ToList();
				techsTickets.PopulateSymptomsAndSolutions();
				techsTickets.PopulateExtraStrings();
				olvTickets.SetObjects(techsTickets);
				txtTicketQty.Text = techsTickets.Count.ToString(CultureInfo.InvariantCulture);
			}
			Cursor = Cursors.Default;
		}

		private void Populate_LegacyRMA()
		{
			if (_tech == null)
				return;

			_legacyRmas = ClassLegacyRMA.GetByTech(_tech.ID).ToList();
			olvLegacyRMAs.SetObjects(_legacyRmas);
			txtLegacyRMAQty.Text = _legacyRmas.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void Populate_RMA()
		{
			if (_tech == null)
				return;

			_rmas = ClassRMA.GetByTech(_tech.ID).ToList();
			ucRMAList1.SetObjects(_rmas);
			foreach (var textbox in pnlRmaDetail.Controls.OfType<TextBox>())
				textbox.Clear();

			if (!_rmas.Any())
				return;

			var totalAssemblies = _rmas.Sum(r => r.AssemblyQty);
			
			if (totalAssemblies < 1)
				return;

			var receivedAssemblies = _rmas.Sum(r => r.Assemblies_ReceivedOrDiscarded_Qty);
			var percentageReceivedAssemblies = receivedAssemblies / (float)totalAssemblies;
			var daysToReceiveFirstAssembly = _rmas.Select(r => (r.FirstAssemblyReceived.GetValueOrDefault(DateTime.Now) - r.Creation_Date).TotalDays).ToList();

			txtRmaAssembliesReceived.Text = receivedAssemblies.ToString(CultureInfo.InvariantCulture);
			txtRmaAssembliesTotal.Text = totalAssemblies.ToString(CultureInfo.InvariantCulture);
			txtRmaAssembliesPercentage.Text = string.Format("({0:0.0}%)", percentageReceivedAssemblies * 100);

			if (!daysToReceiveFirstAssembly.Any())
			{
				txtRmaAssembliesAverageDaysToFirstReceive.Text = "N/A";
			}
			else
			{
				var averageDaysToReceiveFirstAssembly = daysToReceiveFirstAssembly.Average();
				txtRmaAssembliesAverageDaysToFirstReceive.Text = string.Format("{0:0.0}d", averageDaysToReceiveFirstAssembly);
			}
		}

		private void Populate_Shipments()
		{
			if (_tech == null)
				return;

			_shipments = ClassShipment.GetListByTech(_tech.ID);
			ucShipmentList1.SetObjects(_shipments);
		}

		private void CheckForOldUnreceivedRmas()
		{
			_warningRmas = ClassRMA.GetUnreceivedByTech(_tech, ClassRMA.UNRECEIVED_RMA_WARN_OVER_DAYS).ToList();
			if (!_warningRmas.Any())
			{
				btnRmaWarning.Visible = false;
				timerRmaWarningFlasher.Stop();
				return;
			}

			btnRmaWarning.Visible = true;
			timerRmaWarningFlasher.Start();
		}

		private void ResetButtonText()
		{
			btnEditSave.Text = "Edit Tech";

			btnCancel.Visible = false;

			mnuAddNew.Visible = true;

			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
		}

		internal void ClearControls()
		{
			_ignoreStateChange = true;

			ResetButtonText();

			// SEARCH
			txtSearch.Clear();

			// TECH INFO
			txtCompanyName.Text = string.Empty;
			txtAddress.Text = string.Empty;
			txtCity.Text = string.Empty;
			txtState.Text = string.Empty;
			txtZip.Text = string.Empty;
			txtCountry.Text = string.Empty;
			chkShipToMailingAddress.Checked = true;
			txtShip_Address.Text = string.Empty;
			txtShip_City.Text = string.Empty;
			txtShip_State.Text = string.Empty;
			txtShip_Zip.Text = string.Empty;
			txtShip_Country.Text = string.Empty;
			txtTelephone.Text = string.Empty;
			txtFax.Text = string.Empty;
			txtEmail.Text = string.Empty;
			cmbStatus.SelectedIndex = 0;
			numRates_Standard.Value = 0;
			numRates_AfterHours.Value = 0;
			numRates_Emergency.Value = 0;

			// CONTACTS
			txtContact1_Name.Text = string.Empty;
			txtContact2_Name.Text = string.Empty;
			txtContact3_Name.Text = string.Empty;
			txtContact1_Telephone.Text = string.Empty;
			txtContact2_Telephone.Text = string.Empty;
			txtContact3_Telephone.Text = string.Empty;

			// NOTES
			txtNotes.Text = string.Empty;

			// ASSETS
			ucAssetList1.Clear();

			// TICKETS
			olvTickets.SetObjects(null);
			txtTicketQty.Clear();

			// LEGACY RMA
			olvLegacyRMAs.SetObjects(null);
			txtLegacyRMAQty.Clear();

			// SHIPMENTS
			ucShipmentList1.Clear();

			TechLoaded?.Invoke(null);

			_ignoreStateChange = false;
		}

		private void LockControls(bool isLocked = true)
		{
			// TECH INFO
			txtCompanyName.ReadOnly = isLocked;
			txtAddress.ReadOnly = isLocked;
			txtCity.ReadOnly = isLocked;
			txtState.ReadOnly = isLocked;
			txtZip.ReadOnly = isLocked;
			txtCountry.ReadOnly = isLocked;
			chkShipToMailingAddress.Enabled = !isLocked;
			txtShip_Address.ReadOnly = isLocked;
			txtShip_City.ReadOnly = isLocked;
			txtShip_State.ReadOnly = isLocked;
			txtShip_Zip.ReadOnly = isLocked;
			txtShip_Country.ReadOnly = isLocked;
			txtTelephone.ReadOnly = isLocked;
			txtFax.ReadOnly = isLocked;
			txtEmail.ReadOnly = isLocked;
			cmbStatus.Enabled = !isLocked;
			numRates_Standard.Enabled = !isLocked;
			numRates_AfterHours.Enabled = !isLocked;
			numRates_Emergency.Enabled = !isLocked;

			// CONTACTS
			txtContact1_Name.ReadOnly = isLocked;
			txtContact2_Name.ReadOnly = isLocked;
			txtContact3_Name.ReadOnly = isLocked;
			txtContact1_Telephone.ReadOnly = isLocked;
			txtContact2_Telephone.ReadOnly = isLocked;
			txtContact3_Telephone.ReadOnly = isLocked;

			// NOTES
			txtNotes.ReadOnly = isLocked;
		}

		private void chkShipToMailingAddress_CheckedChanged(object sender, EventArgs e)
		{
			grpShipping.Enabled = !chkShipToMailingAddress.Checked;
			if (!chkShipToMailingAddress.Checked || _ignoreStateChange)
				return;

			txtShip_Address.Text = txtAddress.Text;
			txtShip_City.Text = txtCity.Text;
			txtShip_State.Text = txtState.Text;
			txtShip_Zip.Text = txtZip.Text;
			txtShip_Country.Text = txtCountry.Text;
		}

		private void btnEditSave_Click(object sender, EventArgs e)
		{
			switch (_currentTechEditorMode)
			{
				case TechEditorMode.Viewing:
					// Enter edit mode
					if (_tech == null || _tech.ID < 0)
						return;

					_currentTechEditorMode = TechEditorMode.Editing;
					LockControls(false);
					btnEditSave.Text = "Save";
					btnCancel.Visible = true;
					txtCompanyName.Select();
					break;

				case TechEditorMode.Editing:
					// Update existing
					if (!ValidateTech(out var modifyErrors))
					{
						MessageBox.Show(modifyErrors, "Error: Cannot Modify Tech", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if(IsTechNowDnu())
						ProcessRmasForDnuTech();

					UpdateTechObjectFromFields();
					try
					{
						ClassTech.Update(_tech);
					}
					catch (Exception exc)
					{
						ClassLogFile.AppendToLog(exc);
						MessageBox.Show(string.Format("Cannot modify tech. It may have a duplicate name.{0}{0}{1}", Environment.NewLine, exc.Message), "Error: Cannot Modify Tech", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					TechUpdated?.Invoke();
					ResetButtonText();
					Tech_Load(_tech.ID);
					break;

				case TechEditorMode.Adding:
					// Add new
					if (!ValidateTech(out var errors))
					{
						MessageBox.Show(errors, "Error: Cannot Add Tech", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					_tech = new ClassTech();
					UpdateTechObjectFromFields();
					try
					{
						ClassTech.AddNew(ref _tech);
					}
					catch (Exception exc)
					{
						ClassLogFile.AppendToLog(exc);
						MessageBox.Show(string.Format("Cannot add tech. It may have a duplicate name.{0}{0}{1}", Environment.NewLine, exc.Message), "Error: Cannot Add Tech", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					TechUpdated?.Invoke();
					MessageBox.Show("Tech added successfully.", "Tech Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ResetButtonText();
					Tech_Load(_tech.ID);
					break;
			}
		}

		/// <summary>
		/// Checks if tech is being changed to "Do Not Use"
		/// </summary>
		private bool IsTechNowDnu()
		{
			var previousStatus = _tech.TechStatus;
			var newStatus = (ClassTech_Status)cmbStatus.SelectedItem;
			return (previousStatus != newStatus && newStatus == ClassDefinitions.TECH_STATUS_TYPES[4]);
		}

		/// <summary>
		/// Checks for and processes RMAs that are open for the tech, 
		/// </summary>
		private void ProcessRmasForDnuTech()
		{
			var openRmas = ClassRMA.GetByTech(_tech.ID).Where(r => !r.Completed_Date.HasValue).ToList();
			if (!openRmas.Any())
				return;

			var message = string.Format("{0} has {1} open RMA{2}. Do you want to reassign all open RMAs to a different tech?", _tech.TechName, openRmas.Count, openRmas.Count.SIfPlural());
			var doReassign = MessageBox.Show(message, "Reassign Open RMAs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (doReassign != DialogResult.Yes)
				return;

			ClassTech newTech;
			using (var techSelectionForm = new FormList_Techs(ClassTech.GetAll().Where(t => t.TechStatus != ClassDefinitions.TECH_STATUS_TYPES[4]).ToList()))
			{
				var techPicked = techSelectionForm.ShowDialog();
				if (techPicked != DialogResult.OK)
					return;

				newTech = techSelectionForm.SelectedTech;
			}

			var confirmMessage = string.Format("This will reassign {0} RMA{1} to {2}. Proceed?", openRmas.Count, openRmas.Count.SIfPlural(), newTech.TechName);
			var confirm = MessageBox.Show(confirmMessage, "Confirm RMA Reassignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (confirm != DialogResult.Yes)
				return;
			
			Cursor = Cursors.WaitCursor;
			foreach (var rma in openRmas)
			{
				var oldTechName = rma.TechName;
				rma.ChangeTech(newTech);
				var rmaJournalEntry = string.Format("RMA assignment changed from {0} to {1}.", oldTechName, newTech.TechName);
				ClassJournal.AddJournalEntry(rma, rmaJournalEntry, null, true);
			}
			Cursor = Cursors.Default;

			var summary = string.Format("The following RMAs have been reassigned to {0}:{1}{1}{2}", newTech.TechName, Environment.NewLine, string.Join(", ", openRmas.Select(r => r.ID.ToString())));
			MessageBox.Show(summary, "RMA Reassignment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void UpdateTechObjectFromFields()
		{
            ClassLogFile.AppendToLog(GS.Settings.LoggedOnUser.FirstLast + "Changed Tech Data for " + _tech.ID);
            // TECH INFO
            _tech.TechName = txtCompanyName.Text.Trim();
            
			_tech.Address = txtAddress.Text.Trim();
			_tech.City = txtCity.Text.Trim();
			_tech.State = txtState.Text.Trim();
			_tech.Zip = txtZip.Text.Trim();
			_tech.Country = txtCountry.Text.Trim();
			_tech.Shipping_UseMailingAddress = chkShipToMailingAddress.Checked;
			if (!_tech.Shipping_UseMailingAddress)
			{
				_tech.Shipping_Address = txtShip_Address.Text.Trim();
				_tech.Shipping_City = txtShip_City.Text.Trim();
				_tech.Shipping_State = txtShip_State.Text.Trim();
				_tech.Shipping_Zip = txtShip_Zip.Text.Trim();
				_tech.Shipping_Country = txtShip_Country.Text.Trim();
			}
			_tech.TechStatus = (ClassTech_Status)cmbStatus.SelectedItem;
			_tech.Telephone = txtTelephone.Text.Trim();
			_tech.Fax = txtFax.Text.Trim();
			_tech.Email = txtEmail.Text.Trim().ToLower(CultureInfo.InvariantCulture).Replace(" ", string.Empty).Replace(",", ", ");

			// CONTACTS
			_tech.Contact1_Name = txtContact1_Name.Text.Trim();
			_tech.Contact2_Name = txtContact2_Name.Text.Trim();
			_tech.Contact3_Name = txtContact3_Name.Text.Trim();
			_tech.Contact1_Telephone = txtContact1_Telephone.Text.Trim();
			_tech.Contact2_Telephone = txtContact2_Telephone.Text.Trim();
			_tech.Contact3_Telephone = txtContact3_Telephone.Text.Trim();
			_tech.Rate_Normal = (float)numRates_Standard.Value;
			_tech.Rate_AfterHours = (float)numRates_AfterHours.Value;
			_tech.Rate_Emergency = (float)numRates_Emergency.Value;
			_tech.Notes = txtNotes.Text.Trim();
		}

		private bool ValidateTech(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
				sb.AppendLine("Tech company name cannot be blank.");
			
			if (cmbStatus.SelectedIndex < 0)
				sb.AppendLine("Tech status must be set.");

			var techEmails = txtEmail.Text.Replace(" ", string.Empty).Trim();
			if (string.IsNullOrWhiteSpace(techEmails))
				sb.AppendLine("Tech email cannot be blank.");
			else
			{
				var addresses = techEmails.Split(',');
				if (addresses.Any(a => !ClassUtility.ValidateEmailAddress(a)))
					sb.AppendLine("At least one tech email address is invalid.");
			}

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private void mnuAddNew_Click(object sender, EventArgs e)
		{
			Tech_StartAdd();
		}

		private void mnuDelete_Click(object sender, EventArgs e)
		{
			Tech_StartDelete();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearControls();
			LockControls();

			if (_currentTechEditorMode == TechEditorMode.Adding && _techLoadedBeforeAddNew != null)
				Tech_Load(_techLoadedBeforeAddNew.ID);
			else if (_tech != null)
				Tech_Load(_tech.ID);
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			var prevTechID = -1;
			if (_tech == null)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					using (var cmd = conn.CreateCommand())
					{
						conn.Open();
						cmd.CommandText = @"SELECT id
						FROM techs
						ORDER BY tech DESC LIMIT 1";
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								prevTechID = reader.GetDBInt("id");
							}
						}
						conn.Close();
					}
				}
			}
			else
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					using (var cmd = conn.CreateCommand())
					{
						conn.Open();
						cmd.CommandText = @"SELECT id
						FROM techs
						WHERE tech < (SELECT tech FROM techs WHERE id = @CurrentTechID)
						ORDER BY tech DESC LIMIT 1";
						cmd.Parameters.AddWithValue("CurrentTechID", _tech.ID);
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								prevTechID = reader.GetDBInt("id");
							}
						}
						conn.Close();
					}
				}
			}

			if (prevTechID != -1)
				Tech_Load(prevTechID);
			else
				MessageBox.Show("There is not a previous tech to display.", "End of List", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			var nextTechID = -1;
			if (_tech == null)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					using (var cmd = conn.CreateCommand())
					{
						conn.Open();
						cmd.CommandText = @"SELECT id
						FROM techs
						ORDER BY tech ASC LIMIT 1";
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								nextTechID = reader.GetDBInt("id");
							}
						}
						conn.Close();
					}
				}
			}
			else
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					using (var cmd = conn.CreateCommand())
					{
						conn.Open();
						cmd.CommandText = @"SELECT id
						FROM techs
						WHERE tech > (SELECT tech FROM techs WHERE id = @CurrentTechID)
						ORDER BY tech ASC LIMIT 1";
						cmd.Parameters.AddWithValue("CurrentTechID", _tech.ID);
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								nextTechID = reader.GetDBInt("id");
							}
						}
						conn.Close();
					}
				}
			}

			if (nextTechID != -1)
				Tech_Load(nextTechID);
			else
				MessageBox.Show("There is not a following tech to display.", "End of List", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			// Allow change if user is admin, moderator, or if tech is unassigned
			if (!GS.Settings.LoggedOnUser.IsAdmin && GS.Settings.LoggedOnUser.UserType != ClassUser.USERTYPE_MODERATOR && _tech.TechStatus.Value != -1)
				return;

			if (cmbStatus.SelectedIndex >= 0)
				_techStatusComboboxSavedState = cmbStatus.SelectedIndex;
			else
			{
				var overrideForm = new FormSupervisor_Override();
				overrideForm.SetMainText("Tech Status changes requires supervisor permissions.");
				overrideForm.SetPermitButtonText("Permit");
				overrideForm.ShowDialog();
				switch (overrideForm.Result)
				{
					case FormSupervisor_Override.VerificationResultEnum.Permit:
						if (cmbStatus.SelectedIndex >= 0)
							_techStatusComboboxSavedState = cmbStatus.SelectedIndex;
						break;

					default: // cancel
						_ignoreStateChange = true;
						cmbStatus.SelectedIndex = _techStatusComboboxSavedState;
						_ignoreStateChange = false;
						break;
				}
			}
		}

		private void cmbStatus_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			var c = (ComboBox)sender;
			if (c.DataSource == null || e.Index < 0)
				return;

			var techStatus = (ClassTech_Status)((ComboBox)sender).Items[e.Index];
			e.Graphics.DrawString(techStatus.Description, ((Control)sender).Font, new SolidBrush(techStatus.Color), e.Bounds.X, e.Bounds.Y);
		}

		private void ucAssetList1_ViewAsset(int assetID)
		{
			ViewAsset?.Invoke(assetID);
		}

		private void radTickets_Open_CheckedChanged(object sender, EventArgs e)
		{
			if (_tech == null || _tech.ID < 0)
				return;

			Populate_Tickets();
		}

		private void olvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvTickets.SelectedItem == null || ViewTicket == null)
				return;

			var selectedTicket = (ClassTicket)olvTickets.SelectedObject;
			ViewTicket(selectedTicket.ID);
		}

		private void olvLegacyRmas_DoubleClick(object sender, EventArgs e)
		{
			if (olvLegacyRMAs.SelectedItem == null || ViewLegacyRMA == null)
				return;

			var selectedRMA = (ClassLegacyRMA)olvLegacyRMAs.SelectedObject;
			ViewLegacyRMA(selectedRMA.ID);
		}

		private void ucRMAList1_ViewRMA(int rmaID)
		{
			ViewRMA?.Invoke(rmaID);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Tech_StartSearch();
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			e.SuppressKeyPress = true;
			Tech_StartSearch();
		}

		private void txtAddress_TextChanged(object sender, EventArgs e)
		{
			if (chkShipToMailingAddress.Checked)
				txtShip_Address.Text = txtAddress.Text;
		}

		private void txtCity_TextChanged(object sender, EventArgs e)
		{
			if (chkShipToMailingAddress.Checked)
				txtShip_City.Text = txtCity.Text;
		}

		private void txtState_TextChanged(object sender, EventArgs e)
		{
			if (chkShipToMailingAddress.Checked)
				txtShip_State.Text = txtState.Text;
		}

		private void txtZip_TextChanged(object sender, EventArgs e)
		{
			if (chkShipToMailingAddress.Checked)
				txtShip_Zip.Text = txtZip.Text;
		}

		private void txtCountry_TextChanged(object sender, EventArgs e)
		{
			if (chkShipToMailingAddress.Checked)
				txtShip_Country.Text = txtCountry.Text;
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		#region Shipments
		private void ucShipmentList_ViewShipment(int shipmentID)
		{
			ViewShipment?.Invoke(shipmentID);
		}

		private void ucShipmentList_CreateShipment()
		{
			CreateShipment?.Invoke(_tech);
		}

		private void ucShipmentList_ViewTracking(string trackingUrl)
		{
			ViewTracking?.Invoke(trackingUrl);
		}
		#endregion

		private void timerRmaWarningFlasher_Tick(object sender, EventArgs e)
		{
			btnRmaWarning.BackColor = (btnRmaWarning.BackColor == Color.Red) ? Color.DarkRed : Color.Red;
		}

		private void btnRmaWarning_Click(object sender, EventArgs e)
		{
			if (!_warningRmas.Any())
				return;

			var rmaDetail = string.Format("The following RMAs contain assemblies that have not been received in over {1} days:{0}{0}", Environment.NewLine, ClassRMA.UNRECEIVED_RMA_WARN_OVER_DAYS);
			rmaDetail += string.Join(Environment.NewLine, _warningRmas.Select(r => string.Format("{0} - issued on {1:yyyy-MM-dd} for {2}.  ({3}/{4} received)", r.ID, r.Creation_Date, r.AssetName, r.Assemblies_ReceivedOrDiscarded_Qty, r.AssemblyQty)));

			var title = string.Format("Unreceived RMAs Over {0} Days", ClassRMA.UNRECEIVED_RMA_WARN_OVER_DAYS);
			MessageBox.Show(rmaDetail, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}