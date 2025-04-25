using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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
	public partial class FormRMA_Create : Form
	{
		public int NewRmaID;

		private ClassRMA _rma = new ClassRMA();
		private readonly List<ClassRMA.ClassRMAAssembly> _rmaAssemblies = new List<ClassRMA.ClassRMAAssembly>();
		private ClassTech _assignedTech;
		private ClassTicket _ticket;
		private ClassAsset _asset;
		private int? _createFromTicketID;

		public FormRMA_Create(int? ticketID = null)
		{
			InitializeComponent();
	
			olcDiscarded.AspectGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded;
			olcDiscarded.AspectToStringConverter = x => string.Empty;
			olcDiscarded.ImageGetter = x => ((ClassRMA.ClassRMAAssembly)x).Discarded ? "trash" : "none";

			var techs = ClassTech.GetAll().Where(t => t.TechStatus != ClassDefinitions.TECH_STATUS_TYPES[4]).ToList();
            


            cmbTechs.DisplayMember = "DisplayMember";
			cmbTechs.ValueMember = "ID";
			cmbTechs.DataSource = techs;
			cmbTechs.SelectedIndex = -1;

			//if (GS.Settings.LoggedOnUser.IsAdmin)
		    chkHot.Visible = true;

			_createFromTicketID = ticketID;
		}

		private void FormRMA_Create_Shown(object sender, EventArgs e)
		{
			if (_createFromTicketID.HasValue)
				CreateRMA_FromTicket(_createFromTicketID.Value);
		}

		/// <summary>
		/// Auto-populates Create RMA form based on supplied ticket number.
		/// </summary>
		private void CreateRMA_FromTicket(int ticketID)
		{
			txtRMADetails_TicketID.Text = ticketID.ToString(CultureInfo.InvariantCulture);
			PopulateCreate(ticketID);
		}

		private void txtRMADetails_TicketID_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtRMADetails_TicketID.Text))
				return;
			if (!int.TryParse(txtRMADetails_TicketID.Text.Trim(), out var ticketID))
			{
				MessageBox.Show("Invalid ticket number.", "Invalid Ticket Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (_ticket == null || _ticket.ID != ticketID)
				PopulateCreate(ticketID);
		}

		private void PopulateCreate(int ticketID)
		{
			_ticket = ClassTicket.GetByID(ticketID);
			if (_ticket == null || _ticket.ID < 0)
			{
				MessageBox.Show("Ticket does not exist.", "Invalid Ticket Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_asset = ClassAsset.GetByID(_ticket.AssetID);
			txtRMADetails_Asset.Text = _asset.AssetName;
			txtRMADetails_Job_PO.Text = _asset.ActivePartsNumber;
			radRMADetails_PONumber.Checked = string.IsNullOrEmpty(_asset.ActivePartsNumber);

			if(_ticket.TechID.HasValue)
				cmbTechs.SelectedIndex = cmbTechs.FindStringExact(ClassTech.GetByID(_ticket.TechID).TechName);

			if (!IsTicketTechPrimary(_ticket, out var recommendedTech))
			{
				string message;
				if (recommendedTech == null)
				{
					message = "This asset does not have a primary tech. The RMA should be assigned to the tech that will receive or install replacements.";
					MessageBox.Show(message, "Non-Primary Tech Used", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					message = string.Format("Ticket is not assigned to the primary tech, {1}.{0}{0}Do you want to assign this RMA to the primary tech?", Environment.NewLine, recommendedTech.TechName);
					if (MessageBox.Show(message, "Non-Primary Tech Used", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
						cmbTechs.SelectedIndex = cmbTechs.FindStringExact(recommendedTech.TechName);
				}
			}

            btnAssembly_Add.Select();
		}

		/// <summary>
		/// Checks if the ticket utilizes the primary-assigned tech for the asset.
		/// Provides the recommended tech.
		/// </summary>
		private bool IsTicketTechPrimary(ClassTicket ticket, out ClassTech recommendedTech)
		{
			var assignedTechs = ClassTech.GetByAsset(ticket.AssetID).ToList();
			if (!assignedTechs.Any())
			{
				recommendedTech = null;
				return false;
			}
			var priorityTech = assignedTechs.OrderBy(t => t.Priority).First();
			if (priorityTech == null)
			{
				recommendedTech = null;
				return false;
			}
			recommendedTech = priorityTech;
			return (priorityTech.ID == ticket.TechID);
		}

		private void PopulateRMAAssemblies()
		{
			olvAssemblyAdd.SetObjects(_rmaAssemblies);
			txtAssemblyAdd_Qty.Text = _rmaAssemblies.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void btnAssembly_Add_Click(object sender, EventArgs e)
		{
			using (var addAssemblyForm = new FormRMA_AssemblyAdd(_asset))
			{
				if (addAssemblyForm.ShowDialog(this) != DialogResult.OK)
					return;
				if (addAssemblyForm.Qty > 8 && MessageBox.Show($"Are you sure you want to add {addAssemblyForm.Qty} assemblies of type '{addAssemblyForm.RMAAssembly.AssemblyTypeDescription}'?", "Confirm Multiple Assemblies", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
				for (var i = 0; i < addAssemblyForm.Qty; i++)
					_rmaAssemblies.Add(addAssemblyForm.RMAAssembly);
			}
			PopulateRMAAssemblies();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			ClassUser overridingSupervisor = null;

			if (!ValidateNewRma(out var errors))
			{
				MessageBox.Show(errors, "RMA Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (IsPartsCoverageExpiredForJobNumberUsed())
			{
				if (!GetSupervisorApproval(ref overridingSupervisor))
					return;
			}

			UpdateRMAObjectFromFields();
			ClassRMA.AddNew(ref _rma);
			ClassJournal.AddJournalEntry(_rma, "Created RMA", null, true);

			// Add journal entries to referenced tickets and assets
			var rmaCreatedEntry = $"RMA {_rma.ID} created";
			ClassJournal.AddJournalEntry(_ticket, rmaCreatedEntry, null, true);
			ClassJournal.AddJournalEntry(_asset, rmaCreatedEntry, null, true);

			// Send notifications
			ClassNotification.SendNotificationsForObject(rmaCreatedEntry, ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			if (GS.Settings.AutoSubscribe_Create)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.RMA, _rma.ID);

			foreach (var assy in _rmaAssemblies)
				ClassRMA.AddAssembly(_rma.ID, assy);

			if (chkEmail_SendToTech.Checked)
				try
				{
					var rmaMailMessage = ClassEmailGenerator.GenerateEmail_RMA(_rma);
					ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.RMA, rmaMailMessage, _ticket.ID);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					ClassJournal.AddJournalEntry(_rma, $"Error sending RMA email to tech/market: {exc.Message}", null, true);
					MessageBox.Show("Cannot send RMA email to tech/market: " + exc.Message, "RMA Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			MessageBox.Show(string.Format("New RMA created for {0}:{1}{1}RMA Number: {2}", _assignedTech.TechName, Environment.NewLine, _rma.ID), "RMA Created Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
			DialogResult = DialogResult.OK;
			NewRmaID = _rma.ID;
			if (overridingSupervisor != null)
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.SupervisorNotice, ClassEmailGenerator.GenerateEmail_Supervisor_RMACreate(_rma, _asset, overridingSupervisor), _ticket.ID);
			Close();
		}

		private bool IsPartsCoverageExpiredForJobNumberUsed()
		{
			return (!_asset.IsPartsCovered && radRMADetails_JobNumber.Checked);
		}

		private bool GetSupervisorApproval(ref ClassUser overridingSupervisor)
		{
			using (var overrideForm = new FormSupervisor_Override())
			{
				overrideForm.SetMainText("The asset has an expired or undefined parts warranty/contract. Obtain a Customer Purchase Order or contact your supervisor to allow creation of an RMA.");
				overrideForm.ShowDialog();
				if (overrideForm.Result != FormSupervisor_Override.VerificationResultEnum.Permit)
					return false;
				overridingSupervisor = overrideForm.Supervisor;
				return true;
			}
		}

		private bool ValidateNewRma(out string errors)
		{
			var sb = new StringBuilder();
			if (_ticket == null || _ticket.ID < 0)
				sb.AppendLine("Ticket is not valid.");

			if (_asset == null)
				sb.AppendLine("Asset is not valid.");

			if (_asset != null && _asset.IsRetired)
				sb.AppendLine("Asset is retired.");

			if (_assignedTech == null)
				sb.AppendLine("Tech is not valid.");

			if (_assignedTech != null && string.IsNullOrEmpty(_assignedTech.Email))
				sb.AppendLine("Tech email is blank.");

			if (_rmaAssemblies.Count < 1)
				sb.AppendLine("There must be at least one assembly type.");

			if (string.IsNullOrWhiteSpace(txtRMADetails_Job_PO.Text.Trim()))
				sb.AppendLine("A job number or purchase order number must be provided.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private void UpdateRMAObjectFromFields()
		{
			_rma.TechName = _assignedTech.TechName;
			_rma.AssetName = _asset.AssetName;

			_rma.TicketID = _ticket.ID;
			_rma.AssetID = _asset.ID;
			_rma.TechID = _assignedTech.ID;
			_rma.JobNumber = radRMADetails_JobNumber.Checked ? txtRMADetails_Job_PO.Text.Trim() : string.Empty;
			_rma.PONumber = radRMADetails_PONumber.Checked ? txtRMADetails_Job_PO.Text.Trim() : string.Empty;
			_rma.LegacyRMANumber = null;
			_rma.Notes = txtNotes.Text.Trim();
			_rma.IsAPR = chkAPR.Checked;
			_rma.IsHot = chkHot.Checked;

            if (chkHot.Checked)
                _rma.Hot_Date = DateTime.Now;

			_rma.HasComputer = _rmaAssemblies.Any(ra => ra.AssemblyTypeIsComputer);
		}

		private void cmbTechs_SelectedIndexChanged(object sender, EventArgs e)
		{
			_assignedTech = (ClassTech)cmbTechs.SelectedItem;
		}

		private void radRMADetails_PONumber_CheckedChanged(object sender, EventArgs e)
		{
			txtRMADetails_Job_PO.SelectAll();
			txtRMADetails_Job_PO.Select();
		}

		private void btnAssembly_Remove_Click(object sender, EventArgs e)
		{
			if (olvAssemblyAdd.SelectedItem == null)
				return;
			var selectedRMAAssembly = (ClassRMA.ClassRMAAssembly)olvAssemblyAdd.SelectedObject;
			_rmaAssemblies.Remove(selectedRMAAssembly);
			PopulateRMAAssemblies();
		}
	}
}