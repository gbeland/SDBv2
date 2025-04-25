using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.General;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_Modify : Form
	{
		private readonly int _rmaid;
		private ClassRMA _rma = new ClassRMA();
		private List<ClassTech> _techs = new List<ClassTech>();
		private List<ClassRMA.ClassRMAAssembly> _rmaAssemblies = new List<ClassRMA.ClassRMAAssembly>();
		private ClassTech _assignedTech;
		private ClassTicket _ticket;
		private ClassAsset _asset;
		private bool _ignoreStateChange;

		public bool ChangedToApr;

		public FormRMA_Modify(int rmaid)
		{
			InitializeComponent();
			
			_rmaid = rmaid;

			//chkHot.Enabled = GS.Settings.LoggedOnUser.IsAdmin;
			//chkPending.Enabled = GS.Settings.LoggedOnUser.IsAdmin;
			//pnlPending.Enabled = GS.Settings.LoggedOnUser.IsAdmin;

			olcDiscarded.AspectGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded;
			olcDiscarded.AspectToStringConverter = x => string.Empty;
			olcDiscarded.ImageGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded ? "trash" : "none";
		}

		private void FormRMA_Modify_Shown(object sender, EventArgs e)
		{
			LoadRMA(_rmaid);
		}

		private void LoadRMA(int rmaid)
		{
			_ignoreStateChange = true;
			_rma = ClassRMA.GetRMA(rmaid);
			_rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(_rma.ID).ToList();
			_assignedTech = ClassTech.GetByID(_rma.TechID);
			_ticket = ClassTicket.GetByID(_rma.TicketID);
			_asset = ClassAsset.GetByID(_rma.AssetID);
			_techs = ClassTech.GetAll().Where(t => t.TechStatus != ClassDefinitions.TECH_STATUS_TYPES[4]).ToList();

            cmbTechs.DisplayMember = "DisplayMember";
            cmbTechs.ValueMember = "ID";
            cmbTechs.DataSource = _techs;

            int te = cmbTechs.FindString(_assignedTech.TechName);
            cmbTechs.SelectedIndex = te;

            txtRMANumber.Text = _rma.ID.ToString(CultureInfo.InvariantCulture);
			txtTicketID.Text = _ticket.ID.ToString(CultureInfo.InvariantCulture);
			txtAsset.Text = _asset.AssetName;
			var isUsingPO = !string.IsNullOrEmpty(_rma.PONumber);
			txtJob_PO.Text = isUsingPO ? _rma.PONumber : _rma.JobNumber;
			radPONumber.Checked = isUsingPO;
			
			txtLegacyRMA.Text = _rma.LegacyRMANumber.ToString();
			txtNotes.Text = _rma.Notes;
			chkAPR.Checked = _rma.IsAPR;
			chkHot.Checked = _rma.IsHot;
			chkPending.Checked = _rma.IsPending;
			if (_rma.Pending_Reason == "Engineering")
				radPending_Engineering.Checked = true;
			else
				radPending_Production.Checked = true;
			txtPendingReason.Text = _rma.Pending_Reason;
			btnDelete.Text = _rma.IsDeleted ? "Undelete RMA" : "Delete RMA";
			PopulateRMAAssemblies();
			_ignoreStateChange = false;
		}

		private void txtTicketID_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTicketID.Text))
			{
				txtTicketID.Text = _ticket.ID.ToString(CultureInfo.InvariantCulture);
				return;
			}

			if (!int.TryParse(txtTicketID.Text.Trim(), out var ticketID))
			{
				MessageBox.Show("Invalid ticket number.", "Invalid Ticket Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (_ticket.ID != ticketID)
				PopulateTicketChange(ticketID);
		}

		private void PopulateTicketChange(int ticketID)
		{
			var newTicket = ClassTicket.GetByID(ticketID);
			if (newTicket == null || newTicket.ID < 0)
			{
				MessageBox.Show("Ticket does not exist.", "Invalid Ticket Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_ticket = newTicket;
			_asset = ClassAsset.GetByID(_ticket.AssetID);
			txtAsset.Text = _asset.AssetName;
			txtJob_PO.Text = _asset.ActivePartsNumber;
			cmbTechs.SelectedIndex = cmbTechs.FindStringExact(ClassTech.GetByID(_ticket.TechID).TechName);
		}

		private void PopulateRMAAssemblies()
		{
			olvAssemblies.SetObjects(_rmaAssemblies);
			txtAssemblies_Qty.Text = _rmaAssemblies.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void btnAssembly_Add_Click(object sender, EventArgs e)
		{
			using (var assemblyAddForm = new FormRMA_AssemblyAdd(_asset))
			{
				if (assemblyAddForm.ShowDialog(this) != DialogResult.OK)
					return;
				if (assemblyAddForm.Qty > 8 && MessageBox.Show($"Are you sure you want to add {assemblyAddForm.Qty} assemblies of type '{assemblyAddForm.RMAAssembly.AssemblyTypeDescription}'?", "Confirm Multiple Assemblies", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
				for (var i = 0; i < assemblyAddForm.Qty; i++)
					ClassRMA.AddAssembly(_rma.ID, assemblyAddForm.RMAAssembly);
				var entry = $"Added {assemblyAddForm.Qty} {(assemblyAddForm.Qty == 1 ? "assembly" : "assemblies")}: {assemblyAddForm.RMAAssembly.Description}";
				ClassJournal.AddJournalEntry(_rma, entry, null, true);
			}
			_rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(_rma.ID).ToList();

			// Remove the RMA Completed and Finalized dates and Accounting Flag: with new assemblies present this will no longer be true.
			ClassRMA.SetCompleted(_rma.ID, false);
			ClassRMA.SetFinalized(_rma.ID, false);
			ClassRMA.SetAccountingDone(_rma.ID, false);

			PopulateRMAAssemblies();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			#region Validation
			if (_ticket == null || _ticket.ID < 0)
			{
				MessageBox.Show("Ticket is not valid.", "Invalid Ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (_asset == null)
			{
				MessageBox.Show("Asset is not valid.", "Invalid Asset", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (_assignedTech == null)
			{
				MessageBox.Show("Tech is not valid.", "Invalid Tech", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (_rmaAssemblies.Count < 1)
			{
				MessageBox.Show("There must be at least one assembly type.", "Missing Assembly Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (chkPending.Checked && string.IsNullOrEmpty(txtPendingReason.Text))
			{
				MessageBox.Show("RMA pending reason must be supplied.", "Missing Pending Reason", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			var wasPending = _rma.IsPending;
			var wasAPR = _rma.IsAPR;
			UpdateRMAObjectFromFields();
			var isPending = _rma.IsPending;
			var isAPR = _rma.IsAPR;
			var pendingChanged = wasPending != isPending;
			var aprChanged = wasAPR != isAPR;



			if (pendingChanged)
			{
				ClassJournal.AddJournalEntry(_rma, isPending ? "RMA changed to pending." : "RMA pending canceled.", null, true);
				var ticketJournalEntry = $"RMA {_rma.ID} {(isPending ? "changed to pending" : "pending canceled")}";
				ClassJournal.AddJournalEntry(_ticket, ticketJournalEntry, null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
			}
			if (aprChanged)
			{
				if (isAPR)
					ChangedToApr = true;
				ClassJournal.AddJournalEntry(_rma, isAPR ? "RMA changed to APR." : "RMA changed from APR to normal.", null, true);
				var ticketJournalEntry = $"RMA {_rma.ID} {(isAPR ? "changed to APR" : "changed from APR to normal")}";
				ClassJournal.AddJournalEntry(_ticket, ticketJournalEntry, null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
			}

			ClassRMA.Update(_rma);
			ClassJournal.AddJournalEntry(_rma, "Modified RMA.", null, true);
			ClassNotification.SendNotificationsForObject("Modified RMA.", ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			if (chkSendEmail.Checked)
			{
				var message = string.Format("The option to send assigned tech an email is checked.{0}{0}Do you want to send {1} an email when modifying this RMA?", Environment.NewLine, _assignedTech.TechName);
				var dialogResult = MessageBox.Show(message, "Send Email Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dialogResult != DialogResult.Yes)
					return;
				
				try
				{
					var rmaMessage = ClassEmailGenerator.GenerateEmail_RMA(_rma);
					ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.RMA, rmaMessage, _ticket.ID);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					ClassJournal.AddJournalEntry(_rma, $"Error sending RMA email to tech/market: {exc.Message}", null, true);
					MessageBox.Show("Cannot send RMA email to tech/market: " + exc.Message, "RMA Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// If not all assemblies are completed, but RMA was completed, mark as incomplete
			if (_rmaAssemblies.Any(a => !a.Repair_DateTime_End.HasValue && _rma.IsCompleted))
			{
				MessageBox.Show("This RMA was completed, but now one or more assemblies are incomplete. The RMA will be marked as incomplete.", "RMA Not Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClassRMA.SetCompleted(_rma.ID, false);
				ClassRMA.SetFinalized(_rma.ID, false);
				ClassJournal.AddJournalEntry(_rma, "RMA changed to incomplete.", null, true);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} changed to incomplete.", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
				ClassNotification.SendNotificationsForObject("RMA no longer completed.", ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			}

			// If assemblies are all completed, but RMA was incomplete, mark as completed
			if (_rmaAssemblies.All(a => a.Repair_DateTime_End.HasValue && !_rma.IsCompleted))
			{
				MessageBox.Show("All assemblies for this RMA are repaired. The RMA will be marked as completed.", "RMA Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClassRMA.SetCompleted(_rma.ID);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} completed", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
				ClassNotification.SendNotificationsForObject("RMA completed.", ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			}

			// If remaining assemblies are all finalized, then mark the RMA as finalized
			if (_rmaAssemblies.All(a=>a.Finalize_Date.HasValue) && !_rma.IsFinalized)
			{
				MessageBox.Show("All assemblies for this RMA are finalized. The RMA will be marked as finalized.", "RMA Finalized", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClassRMA.SetFinalized(_rma.ID);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} finalized", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
				ClassNotification.SendNotificationsForObject("RMA finalized.", ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
			}

			MessageBox.Show($"RMA {_rma.ID} has been modified.", "RMA Modified Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void UpdateRMAObjectFromFields()
		{
			_rma.TicketID = _ticket.ID;
			_rma.AssetID = _asset.ID;
			_rma.TechID = _assignedTech.ID;
			_rma.JobNumber = radJobNumber.Checked ? txtJob_PO.Text.Trim() : string.Empty;
			_rma.PONumber = radPONumber.Checked ? txtJob_PO.Text.Trim() : string.Empty;
			if (int.TryParse(txtLegacyRMA.Text.Trim(), out var legacyRmaID))
				_rma.LegacyRMANumber = legacyRmaID;
			else
				_rma.LegacyRMANumber = null;
			_rma.Notes = txtNotes.Text.Trim();
			_rma.IsAPR = chkAPR.Checked;
			_rma.IsHot = chkHot.Checked;
            if (chkHot.Checked)
                _rma.Hot_Date = DateTime.Now;
            _rma.IsPending = chkPending.Checked;
			_rma.Pending_Type = radPending_Production.Checked ? "Production" : "Engineering";
			_rma.Pending_Reason = txtPendingReason.Text.Trim();
			_rma.HasComputer = _rmaAssemblies.Any(ra => ra.AssemblyTypeIsComputer);
		}

		private void cmbTechs_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange) return;
			_assignedTech = (ClassTech)cmbTechs.SelectedItem;
			if (_assignedTech.ID != _rma.TechID)
				chkSendEmail.Checked = true;
		}
		
		private void radRMADetails_PONumber_CheckedChanged(object sender, EventArgs e)
		{
			txtJob_PO.SelectAll();
			txtJob_PO.Select();
		}

		private void chkPending_CheckedChanged(object sender, EventArgs e)
		{
			pnlPending.Visible = chkPending.Checked;
		}

		private void btnAssembly_Remove_Click(object sender, EventArgs e)
		{
			if (olvAssemblies.SelectedItem == null)
				return;
			var selectedRMAAssembly = (ClassRMA.ClassRMAAssembly)olvAssemblies.SelectedObject;
			if (selectedRMAAssembly.Finalize_Date.HasValue || selectedRMAAssembly.Repair_DateTime_End.HasValue)
			{
				MessageBox.Show("This assembly cannot be removed because repair has been completed.", "Cannot Remove Assembly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (selectedRMAAssembly.Receive_Date.HasValue)
			{
				const string MESSAGE = "Are you sure you want to remove this assembly? Doing so will remove all work completed so far and components used. This cannot be undone.";
				if (MessageBox.Show(MESSAGE, "Confirm Remove Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
			}
			ClassJournal.AddJournalEntry(_rma, $"Removed assembly: {selectedRMAAssembly.Description}", null, true);
			ClassRMA.RemoveAssembly(selectedRMAAssembly);
			_rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(_rmaid).ToList();
			PopulateRMAAssemblies();
		}

		private void olvAssemblies_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var currentAssembly = (ClassRMA.ClassRMAAssembly)e.Model;
			e.Item.ForeColor = currentAssembly.StatusColor;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (_rma == null || _rma.ID < 0)
				return;

			if (_rma.IsDeleted)
				RMA_Restore();
			else
				RMA_Delete();
		}

		private void RMA_Delete()
		{
			// Future: Permission Check: RMA DELETE/RESTORE

			var confirmMessage = $"Are you sure you want to delete RMA {_rma.ID}?";
			if (MessageBox.Show(confirmMessage, "RMA Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			using (var formUserInput = new FormUserInput("Delete Reason", "Please enter a reason for deleting this RMA:"))
			{
				if (formUserInput.ShowDialog() != DialogResult.OK)
					return;

				var entry = $"Deleted RMA: {formUserInput.UserText.Trim()}";
				_rma.Delete(entry);
				ClassJournal.AddJournalEntry(_rma, entry, null, true);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} deleted", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
				ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
				Close();
			}
		}

		private void RMA_Restore()
		{
			// Future: Permission Check: RMA DELETE/RESTORE

			using (var formUserInput = new FormUserInput("Restore Reason", "Please enter a reason for restoring this RMA:"))
			{
				if (formUserInput.ShowDialog() != DialogResult.OK)
					return;

				var entry = $"Restored RMA: {formUserInput.UserText.Trim()}";
				_rma.Restore();
				ClassJournal.AddJournalEntry(_rma, entry, null, true);
				ClassJournal.AddJournalEntry(_ticket, $"RMA {_rma.ID} restored", null, true);
				if (_ticket.IsHeld)
					_ticket.Release();
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
				if (GS.Settings.AutoSubscribe_Create || GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);
				MessageBox.Show($"RMA {_rma.ID} has been restored.", "RMA Restored Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

    }
}