using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.Asset;
using SDB.Forms.General;
using SDB.Forms.Tech;
using SDB.Forms.Ticket;



// ReSharper disable RedundantVerbatimStringPrefix

namespace SDB.UserControls.Ticket
{
	public partial class TicketEditor : UserControl
	{
		#region Private Vars
		private ClassTicket _ticket;
		private ClassUser _openUser;
		private ClassUser _closeUser;
		private ClassTech _assignedTech;
		private ClassAsset _asset;
		private ClassCustomer _customer;
		private ClassMarket _market;
		private ClassJournal _journal;
		private List<ClassTicket_Image> _images;
		private List<ClassRMA> _rmas;
		private List<ClassRMA> _warningRmas;
		private List<ClassShipment> _shipments;
		private List<ClassTicket_Rental> _ticketRentals;
		private List<ClassTicket_Solution> _solutions;
		private List<ClassTicket_Hold> _ticketHoldLog;
		private bool _ignoreStateChange;

		private readonly Size _TICKET_IMAGE_SIZE = new Size(132, 108);
		#endregion

		#region Delegates and Events
		public delegate void TicketEvent(ClassTicket ticket);
		public delegate void MarketEvent(ClassMarket market);
		public delegate void AssetEvent(ClassAsset asset);
		public delegate void TechEvent(ClassTech tech);
		public delegate void TicketAssetTechEvent(ClassTicket ticket, ClassAsset asset, ClassTech tech);
		public delegate void ShipmentEvent(int shipmentID, int ticketID);
		public delegate void TrackingEvent(string trackingURL);
		public delegate void RMAEvent(int rmaID);
		public delegate void UpdateEvent();

		/// <summary>
		/// Occurs when the usercontrol has successfully loaded a ticket. The main program can use the event to populate headers or tab page text.
		/// </summary>
		public event TicketEvent TicketLoaded;
		public event TicketAssetTechEvent ViewOSA;
		public event TicketEvent CreateRMA;
		public event TicketAssetTechEvent CreateShipment;
		public event MarketEvent ViewMarket;
		public event TechEvent ViewTech;
		public event AssetEvent ViewAsset;
		public event AssetEvent LaunchDashboard;
		public event AssetEvent LaunchVNC;
		public event AssetEvent LaunchTeamviewer;

		public event RMAEvent ViewRMA;
		public event ShipmentEvent ViewShipment;
		public event TrackingEvent ViewTracking;
		public event UpdateEvent TicketUpdated;
		#endregion

		public TicketEditor()
		{
			InitializeComponent();
			InitializeListViews();

			pnlControl_Top.BackColor = GS.Settings.ControlBarColor;
		}

		private void InitializeListViews()
		{
			// Ensure selected solutions are always at the top of the list
			olvTicket_Solutions.CustomSorter = delegate (OLVColumn col, SortOrder order)
			{
				olvTicket_Solutions.ListViewItemSorter = new ColumnComparer(
					new OLVColumn("selected", "Selected"), SortOrder.Descending, col, order);
			};

			olvLegacyRMAs.PrimarySortColumn = olvColRMA_ID;
			olvLegacyRMAs.PrimarySortOrder = SortOrder.Descending;
		}

		#region Ticket Operations
		public void Ticket_Load(int ticketID)
		{
			Cursor = Cursors.WaitCursor;

			_ticket = ClassTicket.GetByID(ticketID);
			if (_ticket.ID < 0 || _ticket == null)
			{
				MessageBox.Show($"Ticket {ticketID} does not exist.", "Ticket Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Cursor = Cursors.Default;
				return;
			}

			_ticket.PopulateExtraStrings();
			_ticket.PopulateSymptomsAndSolutions();

			_openUser = ClassUser.GetByID(_ticket.Open_UserID);
			_assignedTech = ClassTech.GetByID(_ticket.TechID);
			_asset = ClassAsset.GetByID(_ticket.AssetID);
			_asset.PopulateExtraProperties();
			_customer = ClassCustomer.GetByAsset(_asset);
			_market = _customer.Markets.First(m => m.ID == _asset.MarketID);
			if (_ticket.CloseDateTime.HasValue && _ticket.Close_UserID.HasValue)
				_closeUser = ClassUser.GetByID(_ticket.Close_UserID.Value);
			else
				_closeUser = null;

			_solutions = ClassTicket_Solution.GetAll().OrderBy(s => s.Solution).ToList();
			_ticketHoldLog = ClassTicket_Hold.GetLogByTicket(ticketID);
			olvTicket_Solutions.SetObjects(_solutions);
			Populate();
			Populate_ActiveTab();
			Cursor = Cursors.Default;
		}

		/// <summary>
		/// Reloads the current ticket, if applicable.
		/// </summary>
		public void RefreshView()
		{
			if (_ticket != null && _ticket.ID > 0)
				Ticket_Load(_ticket.ID);
		}

		public void FocusSearch()
		{
			txtSearch.Select();
		}

		public void ShowRentalTab()
		{
			tabControl.SelectedTab = tabRentals;
		}

		private void Ticket_Delete()
		{
			if (_ticket == null || _ticket.ID < 0)
			{
				MessageBox.Show("No ticket being viewed.", "Ticket Delete Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Future: Permission Check: TICKET DELETE/RESTORE

			var confirmMessage = $"Are you sure you want to delete ticket {_ticket.ID}?";
			if (MessageBox.Show(confirmMessage, "Ticket Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			using (var userInputForm = new FormUserInput("Delete Reason", "Please enter a reason for deleting this ticket:"))
			{
				if (userInputForm.ShowDialog() != DialogResult.OK)
					return;

				var entry = $"Deleted ticket: {userInputForm.UserText.Trim()}";
				_ticket.Delete(entry);
				ClassJournal.AddJournalEntry(_ticket, entry, null, true);
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
				ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			}

			Ticket_Load(_ticket.ID);
			MessageBox.Show("Ticket deleted successfully.", "Ticket Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
			TicketUpdated?.Invoke();
		}

		private void Ticket_Restore()
		{
			if (_ticket == null || _ticket.ID < 0)
			{
				MessageBox.Show("No ticket being viewed.", "Ticket Restore Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Future: Permission Check: TICKET DELETE/RESTORE

			var confirmMessage = $"Are you sure you want to restore ticket {_ticket.ID}?";
			if (MessageBox.Show(confirmMessage, "Ticket Restore Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			using (var userInputForm = new FormUserInput("Restore Reason", "Please enter a reason for restoring this ticket:"))
			{
				if (userInputForm.ShowDialog() != DialogResult.OK)
					return;

				var entry = $"Restored ticket: {userInputForm.UserText.Trim()}";
				_ticket.Restore();
				ClassJournal.AddJournalEntry(_ticket, entry, null, true);
				ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
				if (GS.Settings.AutoSubscribe_Create || GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			}
			Ticket_Load(_ticket.ID);
			TicketUpdated?.Invoke();
		}

		private void btnClose_Reopen_Click(object sender, EventArgs e)
		{
			if (_ticket.IsClosed)
				Ticket_Reopen();
			else
				Ticket_Close();
		}

		private void Ticket_Reopen()
		{
			if (_ticket == null || _ticket.ID < 0 || !_ticket.IsClosed)
				return;

			// Future: Permission Check: TICKET OPEN/REOPEN

			// If ticket was closed more than x days ago, require supervisor override
			if (!Ticket_ReOpen_ValidateTimeAfterClose())
				return;

			// Prompt to send re-open email to market
			if (_market.SendEmail_Open)
			{
				var message = $"{_market.Name} is set to receive open ticket notifications. Do you want to send a notification that this ticket was re-opened?";
				var result = MessageBox.Show(message, "Send Market Re-open Email?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				switch (result)
				{
					case DialogResult.Cancel:
						return;

					case DialogResult.Yes:
						EmailSend_MarketReOpen();
						break;

					case DialogResult.No:
						ClassJournal.AddJournalEntry(_ticket, $"Declined to send Re-open Ticket email to {_market.Name}", null, true);
						break;
				}
			}

			_ticket.Reopen();

			// Add the journal entry for re-opening the ticket
			ClassJournal.AddJournalEntry(_ticket, "Re-opened ticket", null, true);
			ClassNotification.SendNotificationsForObject("Re-opened ticket", ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify || GS.Settings.AutoSubscribe_Create)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			// Possible options...
			/*
			 * 1. Asset has labor coverage, ticket already has a tech ID (OSA)
			 * 2. Asset has labor coverage, ticket does not have a tech ID
			 * 3. Asset does not have labor coverage, ticket has a tech ID (previous OSA made on supervisor override, or asset labor expired between original open and re-open)
			 * 4. Asset does not have labor coverage, ticket does not have a tech ID [no prompt to send osa]
			 * */

			// Prompt to send OSA email to tech where applicable
			if (_asset.IsLaborCovered && _assignedTech != null)
			{
				var message = $"{_asset.AssetName} has an active labor warranty or contract and an OSA has been generated for this ticket. Do you want to re-send {_assignedTech.TechName} a copy of the OSA?";
				if (MessageBox.Show(message, "Asset Labor WC Active / OSA Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					EmailSend_OSA();
			}
			else if (_asset.IsLaborCovered && !_ticket.TechID.HasValue)
			{
				var message = $"{_asset.AssetName} has an active labor warranty or contract but an OSA has not been generated for this ticket. Do you want to create and send an OSA?";
				if (MessageBox.Show(message, "Asset Labor WC Active / No OSA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					CreateOsa();
					EmailSend_OSA();
				}
			}
			else if (!_asset.IsLaborCovered && _ticket.TechID.HasValue)
			{
				var message = $"{_asset.AssetName} does not have an active labor warranty or contract (or expired after this ticket was originally opened). An OSA has already been generated for this ticket but you cannot re-send it without warranty or contract coverage. Please contact a supervisor.";
				MessageBox.Show(message, "Asset Labor WC Expired / OSA Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			// Refresh ticket view
			Ticket_Load(_ticket.ID);
			TicketUpdated?.Invoke();
		}

		private bool Ticket_ReOpen_ValidateTimeAfterClose()
		{
			var now = ClassDatabase.GetCurrentTime();

			if (!_ticket.CloseDateTime.HasValue || (now - _ticket.CloseDateTime.Value) <= ClassTicket.MAX_TIME_BEFORE_UNSUPERVISED_REOPEN)
				return true;

			using (var overrideForm = new FormSupervisor_Override())
			{
				overrideForm.SetMainText("This ticket has been closed for longer than the allowed re-open grace period. Re-open will require supervisor authorization.");
				overrideForm.ShowDialog();
				switch (overrideForm.Result)
				{
					case FormSupervisor_Override.VerificationResultEnum.Permit:
						var reopenMessage = ClassEmailGenerator.GenerateEmail_Supervisor_TicketReopenAfterExpire(_ticket, _asset, overrideForm.Supervisor);
						ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.SupervisorNotice, reopenMessage, _ticket.ID);
						return true;

					default:
						return false;
				}
			}
		}

		/// <summary>
		/// Closes the ticket, updating solutions and solution notes.
		/// Adds a camera image for ticket close, if applicable.
		/// </summary>
		private void Ticket_Close()
		{
			#region Validation
			if (_ticket == null || _ticket.ID < 0)
				return;

			// Future: Permission Check: TICKET CLOSE

			if (!Validate_Ticket_Close_TechOnSite())
				return;

			if (!Validate_Ticket_Close_RmaRequired())
				return;

			if (!Validate_Ticket_Close(out var errors))
			{
				MessageBox.Show(errors, "Ticket Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			// If ticket is on hold, cancel hold before close
			if (_ticket.IsHeld)
			{
				const string JOURNAL_ENTRY = "Canceled hold.";
				ClassJournal.AddJournalEntry(_ticket, JOURNAL_ENTRY, null, true);
				_ticket.Release();
			}

            if (_asset.ManagedByCreative)
                MessageBox.Show("This Asset Is Managed By The Creative Group. Please Contact Them After Closing Ticket!", "ALERT!");

            // If the asset has a service reminder, prompt to clear/modify it
            if (!string.IsNullOrEmpty(_asset.ServiceReminder))
			{
				var modifyMessage = string.Format("Service reminder:{0}{0}\"{1}\"{0}{0}Do you want to clear or modify it?", Environment.NewLine, _asset.ServiceReminder);
				var modifyResult = MessageBox.Show(modifyMessage, "Modify Asset Service Reminder?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (modifyResult == DialogResult.Yes)
				{
					using (var formServiceReminder = new FormAsset_ServiceReminder(_asset))
						formServiceReminder.ShowDialog(this);
				}
			}

			// Update ticket solution and solution notes
			_ticket.ExtraProperties.SolutionList = _solutions.Where(s => s.Selected).ToList();
            txtTicket_Solution_Notes.txtData.SelectAll();
            _ticket.Solution_Notes = txtTicket_Solution_Notes.txtData.Selection.Text.Trim();

            ClassJournal.AddJournalEntry(_ticket, "Close Note: " + _ticket.Solution_Notes, null, true);

			_ticket.Close();

			// Get image if webcam available
			if (_asset.Net.HasWebcamAndAddress)
				bgwWebCamGetter.RunWorkerAsync(new object[] { _asset, _ticket, "Ticket Close" });

			// If the option is set to send closed email, initiate closed email send
			if (chkTicket_SendCloseEmail.Checked)
			{
				var message = ClassEmailGenerator.GenerateEmail_Close(_ticket, out var status);
				if (message == null)
					ClassJournal.AddJournalEntry(_ticket, $"Error generating Close Ticket email: {status}", null, false);
				else
				{
					try
					{
						ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.Closed, message, _ticket.ID);
					}
					catch (Exception exc)
					{
						ClassJournal.AddJournalEntry(_ticket, $"Error sending Close Ticket email: {exc.Message}", null, true);
					}
				}
			}

            if(_asset.ManagedByCreative)
            {
                var message = ClassEmailGenerator.GenerateEmail_CloseCreative(_ticket, out var status);
                if (message == null)
                    ClassJournal.AddJournalEntry(_ticket, $"Error generating Creative Close Email: {status}", null, false);
                else
                {
                    try
                    {
                        ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.Closed, message, _ticket.ID);
                    }
                    catch (Exception exc)
                    {
                        ClassJournal.AddJournalEntry(_ticket, $"Error sending Creative Close Ticket email: {exc.Message}", null, true);
                    }
                }
            }

			// Add the journal entry for closing the ticket
			ClassJournal.AddJournalEntry(_ticket, "Closed ticket", null, true);
			ClassNotification.SendNotificationsForObject("Closed ticket", ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			ClassSubscription.UnsubscribeObject(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			// Refresh ticket view
			Ticket_Load(_ticket.ID);
			TicketUpdated?.Invoke();
		}

		#region Validation
		private bool Validate_Ticket_Close_TechOnSite()
		{
			// Attempting to close, but tech is still on-site
			if (_ticket.IsTechOnSite)
			{
				const string TOS_MESSAGE = "Ticket cannot be closed with Tech still on site. Do you want to mark tech off-site?";
				if (MessageBox.Show(TOS_MESSAGE, "Ticket Close Error: Tech On Site", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return false;

				Tech_MarkOffSite();
			}
			return true;
		}

		private bool Validate_Ticket_Close_RmaRequired()
		{
			// Refresh RMAs (as they are now only loaded on demand)
			_rmas = ClassRMA.GetByTicket(_ticket.ID).ToList();

			// Attempting to close with a "Replaced..." solution but no RMAs.
			if (_solutions.Where(s => s.Selected).Any(s => s.RequiresParts) && _rmas != null && _rmas.Count < 1)
			{
				const string RMA_MESSAGE = "One or more solutions indicates that parts were replaced, but no RMAs are attached to this ticket. Are you sure you want to continue?";
				if (MessageBox.Show(RMA_MESSAGE, "RMA May be Required", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return false;
			}
			return true;
		}

		private bool Validate_Ticket_Close(out string errors)
		{
			var sb = new StringBuilder();

			// Attempting to close but no solutions are marked
			if (!_solutions.Any(s => s.Selected))
				sb.AppendLine("At least one solution must be checked to close the ticket.");

			// Attempting to close but too many solutions are marked
			if (_solutions.FindAll(s => s.Selected).Count > ClassTicket.MAX_SELECTED_SOLUTIONS)
				sb.AppendLine($"No more than {ClassTicket.MAX_SELECTED_SOLUTIONS} solution{ClassTicket.MAX_SELECTED_SOLUTIONS.SIfPlural()} may be selected.");

            // Attempting to close but no solution notes
            txtTicket_Solution_Notes.txtData.SelectAll();
            if (string.IsNullOrEmpty(txtTicket_Solution_Notes.txtData.Selection.Text.Trim()) || txtTicket_Solution_Notes.txtData.Selection.Text.Trim().Length < 3)
				sb.AppendLine("You must enter solution notes to close the ticket.");

			// Attempting to close with an open rental
			if (_ticket.IsRentalActive)
				sb.AppendLine("Ticket cannot be closed with one or more active rentals.");

			// If closing, check that the ticket closure background worker is not busy
			if (!_ticket.CloseDateTime.HasValue && _asset.Net.HasWebcamAndAddress && bgwWebCamGetter.IsBusy)
				sb.AppendLine("Image for ticket closure is being obtained. Please wait a moment before closing another ticket.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}
		#endregion

		#region Export
		/// <summary>
		/// Exports the currently loaded ticket to an HTML file.
		/// </summary>
		private void Ticket_Export()
		{
			if (_ticket == null || _ticket.ID < 0)
			{
				MessageBox.Show("No ticket being viewed.", "Ticket Export Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var sb = new StringBuilder();
			Ticket_Export_Header(sb);

			Populate_Asset();
			Ticket_Export_AssetDetails(sb);

			Ticket_Export_TicketStatus(sb);
			Ticket_Export_TicketDetails(sb);

			Populate_RMA();
			Ticket_Export_RMADetails(sb);

			Populate_Rentals();
			Ticket_Export_RentalDetails(sb);

			Populate_Shipments();
			Ticket_Export_ShipmentDetails(sb);

			Populate_InvoiceNotes();
			Ticket_Export_InvoicingNotes(sb);

			Populate_Journal();
			Ticket_Export_TicketJournal(sb);

			// Select file export name/location
			using (var sfd = new SaveFileDialog())
			{
				sfd.DefaultExt = ".htm";
				sfd.Filter = "HTML Files (*.htm)|*.htm";
				sfd.AddExtension = true;
				sfd.FileName = $"Ticket {_ticket.ID} History.htm";
				sfd.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString();
				var dr = sfd.ShowDialog();
				if (dr == DialogResult.Cancel) return;

				// Export file and launch it
				using (var sw = new StreamWriter(sfd.FileName))
				{
					sw.Write(sb.ToString());
					sw.Close();
				}
				Process.Start(sfd.FileName);
			}
		}

		private void Ticket_Export_Header(StringBuilder sb)
		{
			sb.AppendLine(@"<style>
				body { font-family: Helvetica, Arial, sans-serif; }
				table { border-collapse: collapse; }
				th { border: solid 1px black; text-align: left; background-color: #CCC; vertical-align: top; }
				td { border: dotted 1px gray; padding: 0 4px 0 4px; vertical-align: top; }
				.btr { font-weight: bold; }
				</style>");
			sb.AppendLine("<h3>Prismview Service Ticket History</h3>");
			sb.AppendFormat("<h4><strong>Ticket Number: {0}</strong></h4>", _ticket.ID).AppendLine();
		}

		private void Ticket_Export_AssetDetails(StringBuilder sb)
		{
			sb.AppendFormat(
				@"<table>
				<tr><th colspan = 7>Asset Details:</th></tr>
				<tr class = btr><td>Location</td><td>Asset</td><td>Panel</td><td>Job Order</td><td>Issue #</td><td>Parts W/C #</td><td>Labor W/C #</td></tr>
				<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>
				</table><br />",
				_asset.Location, _asset.AssetName, _asset.Panel, _ticket.OrderNum, _ticket.CustomerIssueNumber, _asset.WarrantyInfo.PartsWarrantyNumber, _asset.WarrantyInfo.LaborWarrantyNumber).AppendLine();
			//...
			// TODO: store asset labor or parts number with ticket instead of relying on it to be "current"
		}

		private void Ticket_Export_TicketStatus(StringBuilder sb)
		{
			sb.AppendFormat(
				@"<table>
				<tr><th colspan = 7>Ticket Status:</th></tr>
				<tr class = btr><td>Received</td><td>Reported By</td><td>Reported Type</td><td>On Hold</td><td>&nbsp;</td><td>Closed</td><td>Open Duration</td>
				<tr><td>{0:yyyy-MM-dd HH:mm}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>
				</table><br />", _ticket.OpenDateTime,
				_ticket.ReportedBy,
				_ticket.ReportedType,
				_ticket.IsHeld ? "Yes" : "No",
				string.Empty,
				_ticket.CloseDateTime?.ToString("yyyy-MM-dd HH:mm") ?? "No",
				ClassUtility.FormatTimeSpan_Dhm(_ticket.CloseDateTime.GetValueOrDefault(DateTime.Now) - _ticket.OpenDateTime)).AppendLine();
		}

		private void Ticket_Export_TicketDetails(StringBuilder sb)
		{
			sb.AppendFormat(
				@"<table>
				<tr><th colspan = 5>Ticket Details:</th></tr>
				<tr class = btr><td>Symptoms</td><td>Assigned To</td><td>OSA Comments</td><td>Tech On-Site</td></tr>
				<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>
				<tr class = btr><td>Solutions</td><td colspan = 4>Solution Notes</td><tr>
				<tr><td>{4}</td><td colspan = 4>{5}</td></tr>
				</table><br />",
				_ticket.ExtraProperties.Symptoms(),
				_assignedTech != null ? _assignedTech.TechName : "No Tech Assigned",
				_ticket.OSANotes,
				_ticket.FirstTechArrivalDateTime?.ToString("yyyy-MM-dd HH:mm") ?? string.Empty,
				_ticket.ExtraProperties.SolutionList.Count > 0 ? _ticket.ExtraProperties.Solutions() : "No solutions yet.",
				_ticket.Solution_Notes).AppendLine();
		}

		private void Ticket_Export_RentalDetails(StringBuilder sb)
		{
			sb.AppendLine(
				@"<table>
				<tr><th colspan = 8>Rental Details:</th></tr>
				<tr class= btr><td>Rental Company</td><td>Lift Type</td><td>Lift Height</td><td>Started</td><td>Ended</td><td>Reservation #</td><td>Equipment #</td><td>Pickup #</td></tr>");
			foreach (var rentalEntry in ClassTicket_Rental.GetByTicket(_ticket.ID))
				sb.AppendFormat(
						@"<tr>
						<td>{0}</td><td>{1}</td><td>{2}</td><td>{3:yyyy-MM-dd HH:mm}</td><td>{4:yyyy-MM-dd HH:mm}</td><td>{5}</td><td{6}</td><td>{7}</td>
						</tr>",
					rentalEntry.Rental_Company_Name,
					rentalEntry.Lift_Type_Desc,
					rentalEntry.Lift_Height,
					rentalEntry.Reservation_Start,
					rentalEntry.Reservation_End,
					rentalEntry.Reservation_Number,
					rentalEntry.Equipment_Number,
					rentalEntry.PickUp_Number).AppendLine();
			sb.AppendLine(@"</table><br />");
		}

		private void Ticket_Export_RMADetails(StringBuilder sb)
		{
			sb.AppendLine(
				@"<table>
				<tr><th colspan = 3>Associated RMAs:</th></tr>
				<tr class = btr><td>RMA #</td><td>Created</td><td>By</td><td>Assigned to</td></tr>");
			foreach (var rma in _rmas)
			{
				sb.AppendFormat("<tr><td>{0}</td><td>{1:yyyy-MM-dd}</td><td>{2}</td><td>{3}</td></tr>",
								rma.ID, rma.Creation_Date,
								rma.Creation_UserName,
								rma.TechName).AppendLine();
			}
			sb.AppendLine("</table><br />");
		}

		private void Ticket_Export_ShipmentDetails(StringBuilder sb)
		{
			sb.AppendLine(
				@"<table>
				<tr><th colspan = 5>Shipments:</th></tr>");
			foreach (var shipment in _shipments)
			{
				sb.AppendFormat("<tr><td>{0}</td><td>{1:yyyy-MM-dd}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>",
								shipment.ID, shipment.Requested_Date,
								shipment.Destination.Company,
								shipment.Tracking,
								shipment.Fulfilled_Date?.ToString("yyyy-MM-dd") ?? string.Empty).AppendLine();
			}
			sb.AppendLine("</table><br />");
		}

		private void Ticket_Export_InvoicingNotes(StringBuilder sb)
		{
			sb.AppendFormat(
				@"<table>
				<tr><th colspan = 7>Invoicing Notes:</th></tr>
				<tr><td colspan = 7>{0}</td></tr>
				</table><br />",
				_ticket.Invoice_Notes).AppendLine();
		}

		private void Ticket_Export_TicketJournal(StringBuilder sb)
		{
			sb.AppendLine(
				@"<table>
				<tr><th colspan = 7>Ticket Journal:</th</tr>");
			foreach (var entry in ClassJournal.GetByObject(_ticket).Entries)
			{
				sb.AppendFormat("<tr><td style='font-size: 8pt; width: 100px;'>{0:yyyy-MM-dd HH:mm}</td><td>{1}</td><td colspan = 5>{2}</td>",
								entry.JournalDateTime, entry.User_Name, entry.JournalText).AppendLine();
			}
			sb.AppendLine("</table><br />");
		}
		#endregion Export

		private void Ticket_StartSearch()
		{
			if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
				return;

			// Clear search field if something was found
			if (Ticket_Search(txtSearch.Text))
				txtSearch.Clear();
		}

		private bool Ticket_Search(string searchTerm)
		{
			var foundTickets = ClassTicket.Search(searchTerm, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held | ClassTicket.TicketType.Closed).ToList();
			switch (foundTickets.Count)
			{
				case 0:
					MessageBox.Show($"No tickets were found with the search term {searchTerm}.", "Ticket Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;

				case 1:
					Ticket_Load(foundTickets[0].ID);
					return true;

				default:
					using (var ftl = new FormList_Tickets(foundTickets, searchTerm))
					{
						ftl.ShowDialog(this);
						if (ftl.SelectedTicketID.HasValue)
							Ticket_Load(ftl.SelectedTicketID.Value);
					}
					return true;
			}
		}
		#endregion

		#region Populate
		private void Populate()
		{
			_ignoreStateChange = true;
			SetJournalFont();
			SuspendLayout();

			if (_ticket == null)
				return;

			chkSubscribe.Checked = ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			Populate_Ticket();
			Populate_OSA();
			Populate_Asset();

			//Populate_Journal();
			//Populate_Images();
			//Populate_InvoiceNotes();
			//Populate_Rentals();
			//Populate_LegacyRMA();
			//Populate_RMA();
			//Populate_Shipments();
			Populate_ActiveTab();

			ResumeLayout();
			_ignoreStateChange = false;

			TicketLoaded?.Invoke(_ticket);
		}

		private void Populate_ActiveTab()
		{
			switch (tabControl.SelectedTab.Name)
			{
				case "tabJournal":
					Populate_Journal();
					break;

				case "tabInvoiceNotes":
					Populate_InvoiceNotes();
					break;

				case "tabImages":
					Populate_Images();
					break;

				case "tabRentals":
					Populate_Rentals();
					break;

				case "tabLegacyRMA":
					break;

				case "tabRMA":
					Populate_RMA();
					break;

				case "tabShipments":
					Populate_Shipments();
					break;
			}
		}

		private void Populate_Ticket()
		{
			txtTicket_Number.Text = _ticket.ID.ToString(CultureInfo.InvariantCulture);
			txtTicket_IssueNumber.Text = _ticket.CustomerIssueNumber;
			Populate_Ticket_Status();
            txtTicket_JobOrderNumber.Text = _ticket.OrderNum;
			txtTicket_ReportedType.Text = _ticket.ReportedType;
			txtTicket_ReportedBy.Text = _ticket.ReportedBy;
			txtTicket_OpenDate.Text = $"{_ticket.OpenDateTime:yyyy-MM-dd HH:mm:ss}";
			txtTicket_OpenedBy.Text = _openUser.FirstL;
			if (_ticket.CloseDateTime.HasValue)
			{
				txtTicket_CloseDate.Text = $"{_ticket.CloseDateTime:yyyy-MM-dd HH:mm:ss}";
				txtTicket_CloseDate.ForeColor = Color.Black;
				txtTicket_CloseDate.BackColor = SystemColors.Control;
			}
			else
			{
				txtTicket_CloseDate.Text = "(Not Closed)";
				txtTicket_CloseDate.ForeColor = Color.Gray;
				txtTicket_CloseDate.BackColor = SystemColors.Control;
			}
			txtTicket_ClosedBy.Text = _closeUser == null ? string.Empty : _closeUser.FirstL;
			txtTicket_Duration.Text = ClassUtility.FormatTimeSpan_Dhm(_ticket.CloseDateTime.HasValue ? _ticket.CloseDateTime.Value - _ticket.OpenDateTime : DateTime.Now - _ticket.OpenDateTime);
			Populate_Ticket_ActiveTime();
			txtTicket_Symptoms.Text = _ticket.ExtraProperties.Symptoms();
			Populate_Ticket_Solutions();
			Populate_Ticket_Buttons();
		}

		private void Populate_Ticket_ActiveTime()
		{
			var totalHoldTime = ClassTicket.GetTotalHoldTime(_ticket.ID);
			if (totalHoldTime.TotalSeconds > 0)
			{
				lblTicket_ActiveDuration.Visible = true;
				txtTicket_ActiveDuration.Text = ClassUtility.FormatTimeSpan_Dhm(_ticket.Duration - totalHoldTime);
				txtTicket_ActiveDuration.Visible = true;
			}
			else
			{
				lblTicket_ActiveDuration.Visible = false;
				txtTicket_ActiveDuration.Clear();
				txtTicket_ActiveDuration.Visible = false;
			}
		}

		private void Populate_Ticket_Solutions()
		{
			// Set send close ticket notification option according to market setting (but not if the ticket is monitoring)
			chkTicket_SendCloseEmail.Checked = _market.SendEmail_Close;

			// Override send close ticket notification
			if (_ticket.OverrideCloseEmail.HasValue)
			{
				chkTicket_SendCloseEmail.Checked = _ticket.OverrideCloseEmail.GetValueOrDefault(true);
				chkTicket_SendCloseEmail.BackColor = Color.FromArgb(255, 192, 192);
			}
			else
				chkTicket_SendCloseEmail.BackColor = SystemColors.Control;

			foreach (var sol in _solutions.Where(s => _ticket.ExtraProperties.SolutionList.Any(x => x.ID == s.ID)))
				sol.Selected = true;
			olvTicket_Solutions.PrimarySortColumn = olvColTicket_Solutions;
			olvTicket_Solutions.PrimarySortOrder = SortOrder.Ascending;
			olvTicket_Solutions.RebuildColumns();

            txtTicket_Solution_Notes.txtData.SelectAll();
            txtTicket_Solution_Notes.txtData.Selection.Text = _ticket.Solution_Notes;
		}

		/// <summary>
		/// Formats the status label in the Ticket group.
		/// </summary>
		private void Populate_Ticket_Status()
		{
			toolTip.SetToolTip(lblTicket_Status_Show, string.Empty);
			lblTicket_Status_Detail.Text = string.Empty;
			lblTicket_Status_Show.ForeColor = _ticket.StatusColor_Foreground;
			lblTicket_Status_Show.BackColor = _ticket.StatusColor_Background;
			if (_ticket.IsDeleted)
			{
				lblTicket_Status_Show.Text = "DELETED";
				toolTip.SetToolTip(lblTicket_Status_Show, _ticket.DeleteReason);
			}
			else if (_ticket.IsClosed)
			{
				lblTicket_Status_Show.Text = "CLOSED";
			}
			else if (_ticket.IsHeld)
			{
				lblTicket_Status_Show.Text = "HELD";
				var holdExpires = _ticketHoldLog.Last().HoldExpires;
				var timeUntilExpires = (holdExpires - DateTime.Now).Duration().Round();
				toolTip.SetToolTip(lblTicket_Status_Show, $"Expires {holdExpires:yyyy-MM-dd HH:mm}");
				lblTicket_Status_Detail.Text = $"Held until {holdExpires:yyyy-MM-dd HH:mm} ({ClassUtility.FormatRoundedTimeSpan_Dhm(timeUntilExpires)}).";
			}
			else
			{
				lblTicket_Status_Show.Text = "OPEN";
			}
		}

		/// <summary>
		/// Formats Hold/Monitoring/Update buttons.
		/// </summary>
		private void Populate_Ticket_Buttons()
		{
			mnuTicket_HoldRelease.Text = _ticket.IsHeld ? "Release" : "Hold";
			mnuTicket_HoldRelease.Enabled = !_ticket.IsClosed && !_ticket.IsDeleted;

			btnTicket_CloseReopen.Text = _ticket.IsClosed ? "Reopen Ticket" : "Close Ticket";
			btnTicket_CloseReopen.Enabled = !_ticket.IsDeleted;

            
            if(_asset.Net.Is_Cradlepoint)
            {
                mbtnRebootCradle.Enabled = true;
                mbtnRebootCradle.BackColor = Color.MediumPurple;
            }
            else
            {
                mbtnRebootCradle.Enabled = false;
                mbtnRebootCradle.BackColor = Color.WhiteSmoke;
            }

			mnuTicket_DeleteRestore.Text = _ticket.IsDeleted ? "Restore Ticket" : "Delete Ticket";
			mnuTicket_DeleteRestore.ForeColor = _ticket.IsDeleted ? Color.Green : Color.Red;
			mnuTicket_DeleteRestore.BackColor = _ticket.IsDeleted ? Color.FromArgb(192, 255, 192) : Color.FromArgb(255, 192, 192);
			mnuTicket_DeleteRestore.Visible = GS.Settings.LoggedOnUser.IsAdmin;

			mnuTicket_CreateOSA.Enabled = !_ticket.IsDeleted && !_ticket.IsClosed;

			mnuTicket_SendOSA.Enabled = !_ticket.IsDeleted && !_ticket.IsClosed && _ticket.TechID.HasValue;

			mnuTicket_SendOpen.Enabled = !_ticket.IsDeleted;

			mnuTicket_SendClose.Enabled = !_ticket.IsDeleted && _ticket.IsClosed;

			mnuTicket_Reassign.Visible = GS.Settings.LoggedOnUser.IsAdmin;
		}

		private void Populate_OSA()
		{
			pnlOSADetails.Enabled = _ticket.TechID.HasValue;

			pbTechOnSite.Visible = _ticket.IsTechOnSite;
			pbRental.Visible = _ticket.IsRentalActive;

			if (_assignedTech == null && !_asset.IsPMC)
			{
				Clear_OSA();
				return;
			}


            if (_asset.IsPMC)
            {
                //1227 is PMC
                ClassTech pmc = ClassTech.GetByID(1227);
                mnuTicket_SendOSA.Visible = false;
                txtOSA_AssignedTech.Text = pmc.TechName;
                txtOSA_AssignedTech_Location.Text = $"{pmc.City}, {pmc.State}";
                
            }
            else
            {
			    mnuTicket_CreateOSA.Text = "Change Assigned Tech";
			    mnuTicket_SendOSA.Visible = true;
			    txtOSA_AssignedTech.Text = _assignedTech.TechName;
			    txtOSA_AssignedTech_Location.Text = $"{_assignedTech.City}, {_assignedTech.State}";
			    
            }

            if (_ticket.IssuePriority != 0)
            {
                switch (_ticket.IssuePriority)
                {
                    case 1:
                        lblPriority_Actual.Text = "NORMAL";
                        break;
                    case 2:
                        lblPriority_Actual.Text = "HIGH";
                        break;
                    case 3:
                        lblPriority_Actual.Text = "CRITICAL";
                        break;
                    default:
                        lblPriority_Actual.Text = "NOT SET";
                        break;
                }
            }
            else
            {
                lblPriority_Actual.Text = "NOT SET";
            }

            txtOSA_Comments.Text = _ticket.OSANotes;
            txtOSA_Comments.Font = GS.Settings.JournalFont;
            lblOSA_OSAEMailSent.Text = _ticket.EmailSent_OSA ? "SENT" : "NOT SENT";
            lblOSA_OSAEMailSent.BackColor = _ticket.EmailSent_OSA ? Color.FromArgb(192, 255, 192) : SystemColors.Control;
            chkOSA_TechOnSite.Enabled = !_ticket.IsClosed;
            chkOSA_TechOnSite.Checked = _ticket.IsTechOnSite;
            btnOSA_View.Enabled = true;
            var unreceivedRmaThread = new Thread(CheckForOldUnreceivedRmas);
            unreceivedRmaThread.Start();
        }

		private void Clear_OSA()
		{
			foreach (var textBox in pnlOSADetails.Controls.OfType<TextBox>())
				textBox.Clear();
			mnuTicket_CreateOSA.Text = "Create OSA";
			mnuTicket_SendOSA.Visible = false;
			chkOSA_TechOnSite.Checked = false;
			btnOSA_View.Enabled = false;
			toolTip.SetToolTip(chkOSA_TechOnSite, string.Empty);
			lblOSA_OSAEMailSent.Text = "NOT SENT";
			chkOSA_TechOnSite.Enabled = false;
			Clear_UnreceivedRmaWarning();
		}

		private void Populate_Asset()
		{
			var assetMarket = _customer.Markets.FirstOrDefault(m => m.ID == _asset.MarketID);
			txtAsset_CustomerMarket.Text = assetMarket == null ? "NULL" : $"{assetMarket.CustomerName}: {assetMarket.Name}";
			txtAsset_Location.Text = _asset.LocationMultiLine;
			txtAsset_AssetName.Text = _asset.AssetName;
			txtAsset_Panel.Text = _asset.Panel;
			mnuTicket_SendClose.Enabled = _ticket.CloseDateTime.HasValue;
			miniWarrantyStatus1.ShowStatus(_asset);
			txtAsset_ServiceReminder.Text = _asset.ServiceReminder;
			txtAsset_ServiceReminder.BackColor = string.IsNullOrWhiteSpace(_asset.ServiceReminder) ? SystemColors.ControlDark : Color.Yellow;

			_ignoreStateChange = true;
			if (cmbAsset_TicketHistory.Tag is int i && i != _asset.ID)
			{
				cmbAsset_TicketHistory.Tag = null;
				cmbAsset_TicketHistory.DataSource = null;
			}

			if (cmbAsset_TicketHistory.DataSource != null)
				try
				{
					cmbAsset_TicketHistory.SelectedValue = _ticket.ID;
				}
				catch
				{
				}

			_ignoreStateChange = false;

			btnVNC.Enabled = _asset.Net.HasServerAddress && !string.IsNullOrEmpty(_asset.Net.VNC_Password);
			btnTeamViewer.Enabled = !string.IsNullOrEmpty(_asset.Net.Teamviewer_ID);
		}

		/// <summary>
		/// Populates the ticket history dropdown - currently only called when the dropdown is clicked and contains zero items.
		/// </summary>
		private void Populate_AssetTicketHistory()
		{
			if (_asset == null)
				return;
			cmbAsset_TicketHistory.Tag = _asset.ID;
			var assetTicketHistory = ClassTicket.GetByAsset(_asset.ID, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held | ClassTicket.TicketType.Closed).ToList();
			assetTicketHistory.PopulateSymptomsAndSolutions();

			_ignoreStateChange = true;
			cmbAsset_TicketHistory.DisplayMember = "Desc";
			cmbAsset_TicketHistory.ValueMember = "Value";
			cmbAsset_TicketHistory.DataSource = assetTicketHistory.OrderByDescending(t => t.OpenDateTime).Select(t => new
			{
				Desc = $"{t.ID:000000} {t.OpenDateTime:yyyy-MM-dd} {t.ExtraProperties.Symptoms()}",
				Value = t.ID
			}).ToList();

			cmbAsset_TicketHistory.SelectedValue = _ticket.ID;
			_ignoreStateChange = false;
		}

		private void Populate_Journal()
		{
			if (_ticket == null || _ticket.ID < 1)
				return;

			_journal = ClassJournal.GetByObject(_ticket);
			_journal.PopulateDataGridView(dgvJournal);

			if (_journal.Entries.Count < 1 || _ticket.IsClosed)
			{
				lblJournal_LastEntryExpiration.Text = string.Empty;
				lblJournal_LastEntryExpiration.BackColor = Color.Transparent;
			}
			else
			{

				var ts = _journal.LastUserEntry.SoftExpireDateTime - DateTime.Now;
				var expireTimeString = ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration());
				var isExpired = ts.Ticks < 0;
				lblJournal_LastEntryExpiration.Text = $"Last user entry {(isExpired ? $"expired {expireTimeString} ago" : $"expires in {expireTimeString}")}.";
				if (_journal.LastUserEntry.ExpireDateTime.HasValue)
				{
					lblJournal_LastEntryExpiration.BackColor = isExpired ? ClassJournalItem.COL_JOURNAL_OUTOFDATE_RED_BG : Color.Transparent;
					lblJournal_LastEntryExpiration.ForeColor = SystemColors.ControlText;
				}
				else
				{
					// Soft expire
					lblJournal_LastEntryExpiration.BackColor = isExpired ? ClassJournalItem.COL_JOURNAL_OUTOFDATE_SOFT_BG : Color.Transparent;
					lblJournal_LastEntryExpiration.ForeColor = Color.Gray;
				}
			}
		}

		private void Populate_Images()
		{
			ClearControls_Images();

			if (_ticket == null || _ticket.ID < 1)
				return;

			try
			{
				_images = ClassTicket_Image.GetByTicket(_ticket.ID).ToList();
			}
			catch
			{
				// Image table may be missing or offline
				return;
			}

			if (_images == null)
				return;

			flpTicket_Images.SuspendLayout();
			foreach (var image in _images)
			{
				var pb = new PictureBox
				{
					Size = _TICKET_IMAGE_SIZE,
					BackColor = Color.Black,
					Image = image.TicketImage,
					SizeMode = PictureBoxSizeMode.Zoom,
					BorderStyle = BorderStyle.FixedSingle,
					Tag = image
				};
				pb.Click += pbTicketImage_Click;
				var imageInfo = $"{image.Description} ({image.ImageDate:yyyy-MM-dd HH:mm:ss})";
				toolTip.SetToolTip(pb, imageInfo);
				flpTicket_Images.Controls.Add(pb);
			}
			flpTicket_Images.ResumeLayout();
		}

		private void Populate_InvoiceNotes()
		{
			if (_ticket == null)
				return;

			txtInvoiceNotes.Text = _ticket.Invoice_Notes;
			radInvoiceNotes_Billable.Checked = _ticket.IsBillable;
			txtInvoiceNotes_PartsWC.Text = _asset.ActivePartsNumber;
			txtInvoiceNotes_LaborWC.Text = _ticket.OrderNum; // _asset.ActiveLaborNumber;
															 // TODO: Do we need to create a field that stores the parts number that was in effect at the time the ticket was created?
															 // The "active" numbers are not helpful for historical ticket viewing.
		}

		private void Populate_Rentals()
		{
			if (_ticket == null)
			{
				ticketRentals1.Enabled = false;
				return;
			}

			ticketRentals1.Enabled = !_ticket.IsClosed;
			_ticketRentals = ClassTicket_Rental.GetByTicket(_ticket.ID).ToList();
			ticketRentals1.SetObjects(_ticketRentals);
		}

		private void Populate_RMA()
		{
			if (_ticket == null || _ticket.ID < 1)
				return;

			_rmas = ClassRMA.GetByTicket(_ticket.ID).ToList();
			ucRMAList1.SetObjects(_rmas);
		}

		private void Populate_Shipments()
		{
			if (_ticket == null || _ticket.ID < 1)
				return;

			_shipments = ClassShipment.GetListByTicket(_ticket.ID);
			ucShipmentList1.SetObjects(_shipments);
		}

		private void CheckForOldUnreceivedRmas()
		{
			var unreceivedRmas = ClassRMA.GetUnreceivedByTech(_assignedTech, ClassRMA.UNRECEIVED_RMA_WARN_OVER_DAYS);
			if (unreceivedRmas == null)
				return;
			_warningRmas = unreceivedRmas.ToList();
			Populate_UnreceivedRmaWarning();
		}

		private void Populate_UnreceivedRmaWarning()
		{
			if (btnRmaWarning.InvokeRequired)
			{
				btnRmaWarning.Invoke((MethodInvoker)Populate_UnreceivedRmaWarning);
				return;
			}

			if (!_warningRmas.Any())
			{
				Clear_UnreceivedRmaWarning();
				return;
			}

			btnRmaWarning.Visible = true;
			timerRmaWarningFlasher.Start();
		}

		private void Clear_UnreceivedRmaWarning()
		{
			btnRmaWarning.Visible = false;
			btnRmaWarning.BackColor = SystemColors.Control;
			timerRmaWarningFlasher.Stop();
		}
		#endregion

		/// <summary>
		/// Sets the journal to the user-selected font in settings.
		/// </summary>
		private void SetJournalFont()
		{
			dgvJournal.DefaultCellStyle.Font = GS.Settings.JournalFont;
		}

		#region Clear
		internal void ClearControls()
		{
			_ticket = null;
			_openUser = null;
			_assignedTech = null;
			_asset = null;
			_customer = null;
			_market = null;
			_closeUser = null;
			_journal = null;
			_shipments = null;
			_solutions = null;
			_images = null;

			// CONTROL
			txtSearch.Clear();
			mnuTicket_DeleteRestore.Text = "Delete Ticket";
			mnuTicket_DeleteRestore.ForeColor = Color.FromArgb(192, 0, 0);
			pnlControl_Top.BackColor = Color.Silver;

			// TICKET
			foreach (var textBox in pnlTicketDetails.Controls.OfType<TextBox>())
				textBox.Clear();
			txtTicket_CloseDate.ForeColor = Color.Black;
			lblTicket_ActiveDuration.Visible = false;
			txtTicket_ActiveDuration.Visible = false;
			olvTicket_Solutions.SetObjects(null);
			lblTicket_Status_Show.Text = string.Empty;
			lblTicket_Status_Detail.Text = string.Empty;
			chkTicket_SendCloseEmail.Checked = true;
			mnuTicket_HoldRelease.Text = "Hold";
			btnTicket_CloseReopen.Text = "Close Ticket";
            txtTicket_Solution_Notes.txtData.SelectAll();
            txtTicket_Solution_Notes.txtData.Selection.Text = string.Empty;
            Clear_OSA();

			// ASSET
			foreach (var textBox in pnlAssetDetails.Controls.OfType<TextBox>())
				textBox.Clear();
			btnVNC.Enabled = false;
			btnTeamViewer.Enabled = false;
			cmbAsset_TicketHistory.Tag = null;
			cmbAsset_TicketHistory.DataSource = null;
			miniWarrantyStatus1.Clear();

			// JOURNAL
			dgvJournal.Rows.Clear();
			lblJournal_LastEntryExpiration.BackColor = Color.Transparent;
			lblJournal_LastEntryExpiration.ForeColor = SystemColors.ControlText;
			lblJournal_LastEntryExpiration.Text = "Last entry expire info.";

			// IMAGES
			ClearControls_Images();

			// NOTES
			txtInvoiceNotes.Clear();
			txtInvoiceNotes_LaborWC.Clear();
			txtInvoiceNotes_PartsWC.Clear();

			// RENTAL
			ticketRentals1.Enabled = false;
			ticketRentals1.Clear();

			// LEGACY RMAs
			olvLegacyRMAs.SetObjects(null);
			txtRMAQty.Clear();

			// RMAs
			ucRMAList1.Clear();

			// SHIPMENTS
			ucShipmentList1.Clear();

			TicketLoaded?.Invoke(null);
		}

		private void ClearControls_Images()
		{
			flpTicket_Images.SuspendLayout();
			var imgboxes = new List<Control>(flpTicket_Images.Controls.Cast<Control>());
			flpTicket_Images.Controls.Clear();
			foreach (var i in imgboxes)
			{
				i.Click -= pbTicketImage_Click;
				i.Dispose();
			}
			flpTicket_Images.ResumeLayout();
		}
		#endregion

		#region Button Actions
		private void btnExport_Click(object sender, EventArgs e)
		{
			Ticket_Export();
		}

		private void mnuTicket_DeleteRestore_Click(object sender, EventArgs e)
		{
			if (_ticket == null)
				return;

			if (!_ticket.IsDeleted)
				Ticket_Delete();
			else
				Ticket_Restore();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Ticket_StartSearch();
		}

		private void btnOSA_ChangeTech_Click(object sender, EventArgs e)
		{
			CreateOsa();
		}

		private void CreateOsa()
		{
			#region Validation
			if (_ticket == null || _ticket.ID < 0)
				return;

			if (_ticket.IsClosed || _ticket.IsDeleted)
			{
				MessageBox.Show("You cannot create an OSA for a Closed or Deleted ticket.", "OSA Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (_ticket.IsTechOnSite)
			{
				MessageBox.Show("You cannot create an OSA or assign a new tech if a tech is already on site.", "OSA Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			ClassUser supervisorForOverride = null;
			if (!_asset.IsLaborCovered)
			{
				using (var overrideForm = new FormSupervisor_Override())
				{
					overrideForm.SetMainText("Asset is not covered by labor warranty or contract. Contact your supervisor to allow creation of OSA.");
					overrideForm.SetPermitButtonText("Allow");
					overrideForm.ShowDialog();
					if (overrideForm.Result != FormSupervisor_Override.VerificationResultEnum.Permit)
						return;

					supervisorForOverride = overrideForm.Supervisor;
				}
			}
			#endregion

			var assignedTechs = ClassTech.GetByAsset(_asset.ID).ToList();
			using (var formTechList = new FormList_Techs(assignedTechs, null, true))
			{
				formTechList.ShowDialog(this);
				if (formTechList.DialogResult != DialogResult.OK)
					return;

				_assignedTech = formTechList.SelectedTech;
			}

			var newOsaNotes = _ticket.OSANotes;
			using (var formTextEntry = new FormUserInput("OSA Notes", "Enter OSA Notes. These are the instructions for the tech.", true, newOsaNotes))
			{
				formTextEntry.ShowDialog(this);
				if (formTextEntry.DialogResult != DialogResult.OK)
					return;
				newOsaNotes = formTextEntry.UserText;
			}
            
            using(var formTicketPriority = new FormTicketPriority())
            {
                formTicketPriority.ShowDialog();
                if (formTicketPriority.DialogResult == DialogResult.OK)
                    _ticket.IssuePriority = formTicketPriority.GetPriority();
                else return;
            }

			var entry = "Created OSA";
			if (!_ticket.TechID.HasValue)
				entry = $"Created OSA for: {_assignedTech.TechName}";
			else if (_ticket.TechID.Value != _assignedTech.ID)
				entry = string.Format(_ticket.OSANotes == newOsaNotes ? "Assigned new tech: {0}" : "Modified OSA and assigned new tech: {0}", _assignedTech.TechName);
			else if (_ticket.TechID.Value == _assignedTech.ID)
				entry = string.Format(_ticket.OSANotes == newOsaNotes ? "Re-sent OSA to: {0}" : "Modified OSA for: {0}", _assignedTech.TechName);

			_ticket.UpdateOsaNotes(newOsaNotes, _ticket.IssuePriority);
			_ticket.AssignTech(_assignedTech);
			ClassJournal.AddJournalEntry(_ticket, entry, null, true);
			ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			EmailSend_OSA();

			if (supervisorForOverride != null)
			{
				var overrideOsaCreationMessage = ClassEmailGenerator.GenerateEmail_Supervisor_OsaCreate(_ticket, _asset, supervisorForOverride);
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.SupervisorNotice, overrideOsaCreationMessage, _ticket.ID);
			}

			Ticket_Load(_ticket.ID);
			TicketUpdated?.Invoke();
		}

		private void mnuTicket_CreateOSA_Click(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.ID < 0)
				return;
            if (_asset.IsPMC && _asset.WarrantyInfo.ShippedDate.Value.AddDays(90) < DateTime.Today)
            {
                MessageBox.Show("This is a PMC Asset. Automated PMC forms is still in progress. Please Fill out Form Manually.", "PMC Asset!");

                //sendPMCOSAToolStripMenuItem_Click(sender, e);
            }
            else
            {
                if(!_asset.IsLaborCovered)
                {
                    using(FormSupervisor_Override so = new FormSupervisor_Override())
                    {
                        so.ShowDialog();
                        if(so.Result == FormSupervisor_Override.VerificationResultEnum.Permit)
                            CreateOsa();
                    }
                }
                else CreateOsa();
            }
		}

		private void mnuTicket_SendOSA_Click(object sender, EventArgs e)
		{
            if (_asset.IsPMC && _asset.WarrantyInfo.ShippedDate.Value.AddDays(90) < DateTime.Today)
                MessageBox.Show("PMC Asset!", "This is a PMC Asset. Automated PMC forms is still in progress. Please Fill out Form Manually.");
            //sendPMCOSAToolStripMenuItem_Click(sender, e);
            else
			    EmailSend_OSA();
		}

		private void btnOSA_Tech_Log_Click(object sender, EventArgs e)
		{
			ShowTechLog();
		}

		private void btnOSA_TechOnSiteChecklist_Click(object sender, EventArgs e)
		{
			ShowPreventiveMaintenanceActionChecklist();
		}

		private void btnOSA_View_Click(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			ViewOSA?.Invoke(_ticket, _asset, _assignedTech);
		}

		private void mnuTicket_HoldRelease_Click(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.ID < 1)
				return;

			if (_ticket.IsHeld)
				Ticket_Release();
			else
				Ticket_Hold();
		}

		private void Ticket_Hold()
		{
			// Cannot change monitoring, closed, or deleted tickets
			if (_ticket.IsClosed || _ticket.IsDeleted)
			{
				MessageBox.Show("You cannot put a Closed or Deleted ticket on hold.", "Hold Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Future: Permission Check: TICKET HOLD/RELEASE

			using (var formInputExpire = new FormUserInput_WithExpire("Ticket Hold Reason", "Ticket Hold", "Hold Ticket", TimeSpan.FromHours(8), ClassTicket.MAX_HOLD_EXPIRATION))
			{
				if (formInputExpire.ShowDialog(this) != DialogResult.OK)
					return;

				// Change ticket to held
				_ticket.Hold(formInputExpire.ExpirationDate);

				var holdDuration = formInputExpire.ExpirationDate - ClassDatabase.GetCurrentTime();

				// Add journal entry with user input
				var journalEntry = $"Ticket held for {ClassUtility.FormatRoundedTimeSpan_Dhm(holdDuration.Round())}: {formInputExpire.UserText}";
				ClassJournal.AddJournalEntry(_ticket, journalEntry, formInputExpire.ExpirationDate, false);

				// Send notifications
				ClassNotification.SendNotificationsForObject(journalEntry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			}

			Ticket_Load(_ticket.ID);

			TicketUpdated?.Invoke();
		}

		private void Ticket_Release()
		{
			// Release ticket from hold
			_ticket.Release();

			// Add journal entry
			const string JOURNAL_ENTRY = "Canceled hold.";
			ClassJournal.AddJournalEntry(_ticket, JOURNAL_ENTRY, null, true);

			// Send notifications
			ClassNotification.SendNotificationsForObject(JOURNAL_ENTRY, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			Ticket_Load(_ticket.ID);

			TicketUpdated?.Invoke();
		}

		private void btnJournal_Add_Click(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			Journal_AddEntry();
		}

		private void btnJournal_ScrollToFirst_Click(object sender, EventArgs e)
		{
			try
			{
				dgvJournal.FirstDisplayedScrollingRowIndex = dgvJournal.RowCount - 1;
			}
			catch
			{
			}
		}

		private void Journal_AddEntry(string prefillText = "")
		{
			// Future: Permission Check

			using (var frmJournal = new FormJournal(_ticket, ClassTicket.MAX_JOURNAL_EXPIRATION, ClassJournal.ExpirationType.Required))
			{
				frmJournal.Prefill(prefillText);

				if (frmJournal.ShowDialog(this) == DialogResult.Cancel)
					return;

				if (frmJournal.ReleaseHold)
					Ticket_Release();

                if (frmJournal.cbxHoldTicket.Checked)
                {
                    _ticket.Hold((DateTime)frmJournal.JournalEntry.ExpireDateTime);
                    frmJournal.JournalEntry.JournalText = frmJournal.JournalEntry.JournalText.Insert(0, "Ticket Held: ");
                }

                ClassJournal.AddJournalEntry(_ticket, frmJournal.JournalEntry);

                
				// Send notifications for ticket journal addition
				ClassNotification.SendNotificationsForObject(frmJournal.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
				if (GS.Settings.AutoSubscribe_Modify)
					ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

				// Send notifications for ticket journal addition expiration
				if (frmJournal.JournalEntry.ExpireDateTime.HasValue)
					ClassNotification.SendNotificationsForObject("EXPIRED: " + frmJournal.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID, null, frmJournal.JournalEntry.ExpireDateTime.Value);
			}

			Ticket_Load(_ticket.ID);
			TicketUpdated?.Invoke();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			var nextTicketID = -1;
			if (_ticket == null)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"SELECT id
							FROM tickets
							ORDER BY id ASC LIMIT 1";
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								nextTicketID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}
			else
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"SELECT id
							FROM tickets
							WHERE id > (SELECT id FROM tickets WHERE id = @CurrentTicketID)
							ORDER BY id ASC LIMIT 1";
						cmd.Parameters.AddWithValue("CurrentTicketID", _ticket.ID);
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								nextTicketID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}

			if (nextTicketID != -1)
				Ticket_Load(nextTicketID);
			else
				MessageBox.Show("There is not a following ticket to display.", "End of List", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			var prevTicketID = -1;
			if (_ticket == null)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = @"SELECT id
						FROM tickets
						ORDER BY id DESC LIMIT 1";
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								prevTicketID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}
			else
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = @"SELECT id
						FROM tickets
						WHERE id < (SELECT id FROM tickets WHERE id = @CurrentTicketID)
						ORDER BY id DESC LIMIT 1";
						cmd.Parameters.AddWithValue("CurrentTicketID", _ticket.ID);
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();
								prevTicketID = reader.GetDBInt("id");
							}
						}
					}
					conn.Close();
				}
			}

			if (prevTicketID != -1)
				Ticket_Load(prevTicketID);
			else
				MessageBox.Show("There is not a previous ticket to display.", "End of List", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void mnuTicket_SendOpen_Click(object sender, EventArgs e)
		{
			if (!_market.SendEmail_Open)
			{
				if (MessageBox.Show("This market is not configured to receive Open Ticket notifications. Are you sure you want to send the market an Open Ticket Notification?", "Confirm: Send Open Ticket Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
			}

			EmailSend_MarketOpen();
		}

		private void mnuTicket_SendClose_Click(object sender, EventArgs e)
		{
			if (!_ticket.IsClosed)
				return;

			if (!_market.SendEmail_Close)
			{
				if (MessageBox.Show("This market is not configured to recieve Closed Ticket notifications. Are you sure you want to send the market a Closed Ticket Notification?", "Confirm: Send Close Ticket Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
			}

			EmailSend_MarketClose();
		}

		private void btnImages_Add_Click(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			using (var addImageForm = new FormTicket_AddImage(_asset))
			{
				addImageForm.ShowDialog(this);
				if (addImageForm.DialogResult != DialogResult.OK)
					return;

				try
				{
					_ticket.AddImage(addImageForm.NewImage, addImageForm.ImageDescription);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Image could not be added. Images may be disabled or offline.{0}{0}{1}", Environment.NewLine, exc.Message), "Image Addition Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			Ticket_Load(_ticket.ID);
		}

		private void btnImages_AddWebCamImage_Click(object sender, EventArgs e)
		{
			if (!_asset.Net.Webcam_Installed)
			{
				MessageBox.Show("Webcam is not installed.", "Webcam Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			bgwWebCamGetter.RunWorkerAsync(new object[] { _asset, _ticket, ClassDatabase.GetCurrentTime().ToString("yyyy-MM-dd HH:mm:ss") });
		}

		private void ucRMAList1_ViewRMA(int rmaID)
		{
			ViewRMA?.Invoke(rmaID);
		}

		private void ucRMAList1_CreateRMA()
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			if (CreateRMA == null)
				return;

			if (!_asset.IsPartsCovered)
			{
				if (MessageBox.Show("This asset does not have an active parts warranty/contract. A customer purchase order will be required. Do you want to continue?", "Parts W/C Expired", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
			}

			CreateRMA(_ticket);
		}

		private void ucShipmentList1_CreateShipment()
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			if (CreateShipment == null)
				return;

			Populate_RMA();
			if (_rmas.Any())
			{
				var message = string.Format("Are you creating a shipment that is associated with one of these RMAs?{0}{0}{1}", Environment.NewLine, string.Join(", ", _rmas.Select(r => r.ID)));
				if (MessageBox.Show(message, "Shipment For RMA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					MessageBox.Show("Please create the shipment from the RMA instead, which will automatically include the RMA number on the shipment.", "Create Shipment From RMA");
					tabControl.SelectedTab = tabRMA;
					return;
				}
			}
			else
			{
				var noRmaMessage = "You should create an RMA if you are replacing a failed assembly. Are you creating a shipment to replace a failed assembly?";
				if (MessageBox.Show(noRmaMessage, "Replacing Failed Assembly?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					MessageBox.Show("Please create an RMA first.", "Create RMA First");
					tabControl.SelectedTab = tabRMA;
					return;
				}
			}

			CreateShipment?.Invoke(_ticket, _asset, _assignedTech);
		}

		private void ucShipmentList1_ViewShipment(int shipmentID)
		{
			ViewShipment?.Invoke(shipmentID, _ticket.ID);
		}

		private void ucShipmentList1_ViewTracking(string trackingURL)
		{
			ViewTracking?.Invoke(trackingURL);
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			if (LaunchDashboard == null || _asset == null || _asset.ID < 1)
				return;

			LaunchDashboard(_asset);
		}

		private void btnVNC_Click(object sender, EventArgs e)
		{
			if (LaunchVNC == null || _asset == null || _asset.ID < 0)
				return;

			LaunchVNC(_asset);
		}

		private void btnTeamViewer_Click(object sender, EventArgs e)
		{
			if (LaunchTeamviewer == null || _asset == null || _asset.ID < 0)
				return;

			LaunchTeamviewer(_asset);
		}

		private void ticketRentals1_CreateTicketRental()
		{
			#region Validation
			if (_ticket == null || _ticket.ID < 0)
				return;

			if (_ticket.IsClosed || _ticket.IsDeleted)
			{
				MessageBox.Show("You cannot rent equipment for a Closed or Deleted ticket.", "Rental Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			ClassUser supervisorForOverride = null;
			if (!_asset.IsLaborCovered)
			{
				using (var overrideForm = new FormSupervisor_Override())
				{
					overrideForm.SetMainText("Asset is not covered by labor warranty or contract. Contact your supervisor to allow equipment rental.");
					overrideForm.SetPermitButtonText("Allow");
					overrideForm.ShowDialog();
					if (overrideForm.Result != FormSupervisor_Override.VerificationResultEnum.Permit)
						return;

					supervisorForOverride = overrideForm.Supervisor;
				}
			}
			#endregion

			ClassTicket_Rental newRental;
			using (var rentalForm = new FormTicket_Rental(_ticket))
			{
				if (rentalForm.ShowDialog(this) != DialogResult.OK)
					return;

				// Create ticket rental
				newRental = rentalForm.TicketRental;
				ClassTicket_Rental.AddNew(ref newRental);
			}

			_ticket.IsRentalActive = ClassTicket_Rental.SetTicketRentalIndicator(_ticket.ID);

			var entry = $"Rented equipment from {newRental.Rental_Company_Name}";
			ClassJournal.AddJournalEntry(_ticket, entry, null, true);
			ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			if (supervisorForOverride != null)
			{
				var overrideNewRentalMessage = ClassEmailGenerator.GenerateEmail_Supervisor_NewRental(_ticket, _asset, newRental, supervisorForOverride);
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.SupervisorNotice, overrideNewRentalMessage, _ticket.ID);
			}
			
			Ticket_Load(_ticket.ID);
			TicketUpdated?.Invoke();
		}

		private void ticketRentals1_EndTicketRental(ClassTicket_Rental ticketRental)
		{
			if (_ticket == null || _ticket.ID < 0 || ticketRental == null || ticketRental.Reservation_End.HasValue)
				return;

			ClassTicket_Rental endedRental;
			using (var rentalForm = new FormTicket_Rental(_ticket, ticketRental))
			{
				if (rentalForm.ShowDialog(this) != DialogResult.OK)
					return;

				// Update ticket rental
				endedRental = rentalForm.TicketRental;
				ClassTicket_Rental.Update(endedRental);
			}

			_ticket.IsRentalActive = ClassTicket_Rental.SetTicketRentalIndicator(_ticket.ID);

			var entry = $"Ended equipment rental from {endedRental.Rental_Company_Name}";
			ClassJournal.AddJournalEntry(_ticket, entry, null, true);
			ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			Ticket_Load(_ticket.ID);
			TicketUpdated?.Invoke();
		}

		private void mnuTicket_Reassign_Click(object sender, EventArgs e)
		{
			// Check for any RMA or shipment already on ticket.
			Populate_RMA();
			Populate_Shipments();

			if (_rmas.Any() || _shipments.Any())
			{
				MessageBox.Show("This ticket has at least one RMA or shipment and therefore cannot be reassigned.", "Cannot Reassign", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var previousAsset = _asset;
			ClassAsset newAsset;

			// Change asset assignment to ticket.
			using (var assetSelectionForm = new FormList_Assets())
			{
				var result = assetSelectionForm.ShowDialog();
				if (result != DialogResult.OK)
					return;

				newAsset = assetSelectionForm.SelectedAsset;
				if (newAsset == previousAsset)
				{
					MessageBox.Show("The ticket is already assigned to the selected asset. No changes made.", "Invalid Reassign", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				Populate_Images();
				if (_images.Any())
				{
					var confirm = MessageBox.Show("Assigning a different asset to the ticket will clear all existing ticket images. Are you sure you want to continue?", "Confirm Reassign", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (confirm != DialogResult.Yes)
						return;
					ClassTicket.DeleteAllImages(_ticket.ID);
				}
				_ticket.ChangeAsset(assetSelectionForm.SelectedAsset);
			}

			// Add journal entries
			var ticketJournalEntry = $"Ticket assignment changed from {previousAsset.AssetName} to {newAsset.AssetName}.";
			ClassJournal.AddJournalEntry(_ticket, ticketJournalEntry, null, true);
			var oldAssetJournalEntry = $"Ticket {_ticket.ID} reassigned to {newAsset.AssetName}.";
			ClassJournal.AddJournalEntry(previousAsset, oldAssetJournalEntry, null, true);
			var newAssetJournalEntry = $"Ticket {_ticket.ID} reassigned from {previousAsset.AssetName}.";
			ClassJournal.AddJournalEntry(newAsset, newAssetJournalEntry, null, true);

			// Send notifications
			ClassNotification.SendNotificationsForObject(ticketJournalEntry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			// Offer to re-send OSA if one was already sent.
			if (_ticket.TechID.HasValue)
			{
				var osaResendMessage = $"Do you want to re-send the OSA to {_assignedTech.TechName} due to the asset change?";
				var resendOsaConfirm = MessageBox.Show(osaResendMessage, "Re-send OSA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (resendOsaConfirm == DialogResult.Yes)
				{
					EmailSend_OSA();
				}
			}
			Ticket_Load(_ticket.ID);
		}
		#endregion

		#region Other Actions
		private void chkOSA_TechOnSite_Click(object sender, EventArgs e)
		{
			if (_ignoreStateChange || _ticket == null || _ticket.ID < 0 || _assignedTech == null)
				return;

			// Future: Permission check for tech on/off site

			if (_ticket.IsTechOnSite)
				Tech_MarkOffSite();
			else
				Tech_MarkOnSite();
		}

		private void Tech_MarkOnSite()
		{
			if (_ticket == null || _ticket.ID < 0 || _assignedTech == null)
				return;

			string arrivingTechName;
			using (var frmUserInput = new FormUserInput("Tech Arrival", "Please enter the name of the arriving technician:"))
			{
				if (frmUserInput.ShowDialog(this) != DialogResult.OK)
					return;

				arrivingTechName = frmUserInput.UserText.Truncate(16);
			}

			var entry = $"{arrivingTechName} from {_assignedTech.TechName} arrived on site.";
			var now = ClassDatabase.GetCurrentTime();
			_ticket.TechArrivedOnSite(_assignedTech.ID, true);

			_ignoreStateChange = true;
			chkOSA_TechOnSite.Checked = true;
			_ignoreStateChange = false;

			ClassJournal.AddJournalEntry(_ticket, entry, now.Add(ClassTicket.JOURNAL_EXPIRATION_TECH_ON_SITE), true);

			ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			// Send the "tech on site" email
			if (_market.SendEmail_TechOnSite)
				EmailSend_TechOnSite();

			// Reload just the journal to avoid clearing ticket close notes
			_journal = ClassJournal.GetByObject(_ticket);
			Populate_Journal();

			// Show PMA checklist when tech arrives on site
			ShowPreventiveMaintenanceActionChecklist();
		}

		private void Tech_MarkOffSite()
		{
			if (_ticket == null || _ticket.ID < 0 || _assignedTech == null)
				return;

			var entry = $"Tech from {_assignedTech.TechName} departed.";
			var now = ClassDatabase.GetCurrentTime();
			_ticket.TechArrivedOnSite(_assignedTech.ID, false);

			_ignoreStateChange = true;
			chkOSA_TechOnSite.Checked = false;
			_ignoreStateChange = false;

			ClassJournal.AddJournalEntry(_ticket, entry, now.Add(ClassTicket.JOURNAL_EXPIRATION_TECH_OFF_SITE), true);

			ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
			if (GS.Settings.AutoSubscribe_Modify)
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);

			// Reload just the journal and OSA section to avoid clearing ticket close notes
			_journal = ClassJournal.GetByObject(_ticket);

			Populate_OSA();
			Populate_Journal();

			// Don't show PMA checklist when tech goes off site
		}

		private void chkTicket_SendCloseEmail_CheckedChanged(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.ID < 0 || _ignoreStateChange || _market == null)
				return;

			if (_ignoreStateChange)
				return;

			var isMarketPreference = _market.SendEmail_Close == chkTicket_SendCloseEmail.Checked;
			var overrideSetting = isMarketPreference ? (bool?)null : chkTicket_SendCloseEmail.Checked;
			_ticket.SetOverrideCloseEmail(overrideSetting);
			chkTicket_SendCloseEmail.BackColor = isMarketPreference ? SystemColors.Control : Color.FromArgb(255, 192, 192);

			if (!isMarketPreference)
			{
				MessageBox.Show($"The market for this asset {(_market.SendEmail_Close ? "is" : "is not")} set to receive close notifications. The current setting does not reflect this preference.",
					"Close Ticket Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void olvLegacyRmas_DoubleClick(object sender, EventArgs e)
		{
		}

		private void pbTicketImage_Click(object sender, EventArgs e)
		{
			if (!(sender is PictureBox pb))
				return;

			using (var formTicketImageView = new FormTicket_ImageView())
			{
				formTicketImageView.TicketImage = (ClassTicket_Image)pb.Tag;
				if (formTicketImageView.ShowDialog(this) == DialogResult.Retry)
					Ticket_Load(_ticket.ID);
			}
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			e.SuppressKeyPress = true;
			Ticket_StartSearch();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			Populate_ActiveTab();
		}

		private void chkSubscribe_Click(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			if (_ignoreStateChange)
				return;

			if (ClassSubscription.IsUserSubscribed(GS.Settings.LoggedOnUser.ID, ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID))
			{
				ClassSubscription.Unsubscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
				chkSubscribe.Checked = false;
			}
			else
			{
				ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, _ticket.ID);
				chkSubscribe.Checked = true;
			}
		}

		private void txtOSA_AssignedTech_Click(object sender, EventArgs e)
		{
			if (ViewTech == null || _assignedTech == null)
				return;

			ViewTech(_assignedTech);
		}

		private void txtAsset_AssetName_Click(object sender, EventArgs e)
		{
			if (ViewAsset == null || _asset == null)
				return;

			ViewAsset(_asset);
		}

		private void txtAsset_Market_Click(object sender, EventArgs e)
		{
			if (ViewMarket == null || _market == null)
				return;

			ViewMarket(_market);
		}

		private void lblTicket_IssueNumber_Click(object sender, EventArgs e)
		{
			if (_ticket == null || _ticket.IsClosed)
				return;

			var message = $"Enter issue number for ticket {_ticket.ID}. (6 character max.)";
			string newIssueNumber;
			using (var userInputForm = new FormUserInput("Enter Issue Number", message, false, _ticket.CustomerIssueNumber))
			{
				if (userInputForm.ShowDialog() != DialogResult.OK)
					return;

				newIssueNumber = userInputForm.UserText;
			}

			if (newIssueNumber.Length > 6)
			{
				MessageBox.Show("Issue number must be 6 characters or less.");
				return;
			}

			_ticket.SetIssueNumber(newIssueNumber);
			Populate();
		}
		#endregion

		#region Email Sends
		private void EmailSend_OSA()
		{
			if (_ticket == null || _ticket.ID < 0 || _assignedTech == null)
				return;

			Populate_Images();
			var osaImage = _images?.FirstOrDefault(i => i.Description == "OSA/Ticket Open");
			if (osaImage != null)
				_ticket.ExtraProperties.OSA_Image = osaImage.TicketImage;
            



			var osaMessage = ClassEmailGenerator.GenerateEmail_OSA(_ticket, out var status);
			if (osaMessage == null)
			{
				var errorMessage = $"Error generating OSA Email: {status}";
				MessageBox.Show(errorMessage, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.OSA, osaMessage, _ticket.ID);
			}
			catch (Exception exc)
			{
				ClassJournal.AddJournalEntry(_ticket, $"Error sending OSA email: {exc.Message}", null, true);
			}
		}

		private void EmailSend_MarketOpen()
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			var openMessage = ClassEmailGenerator.GenerateEmail_Ticket_Open(_ticket, out var status);
			if (openMessage == null)
			{
				var errorMessage = $"Error generating Open Ticket Email: {status}";
				MessageBox.Show(errorMessage, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.Open, openMessage, _ticket.ID);
			}
			catch (Exception exc)
			{
				ClassJournal.AddJournalEntry(_ticket, $"Error sending Open Ticket Email: {exc.Message}", null, true);
			}
		}

		private void EmailSend_MarketReOpen()
		{
			if (_ticket == null || _ticket.ID < 0)
				return;

			var now = ClassDatabase.GetCurrentTime();
			var reOpenMessage = ClassEmailGenerator.GenerateEmail_Ticket_ReOpen(_ticket, now, out var status);
			if (reOpenMessage == null)
			{
				var errorMessage = $"Error generating Re-Open Ticket Email: {status}";
				MessageBox.Show(errorMessage, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.ReOpenTicket, reOpenMessage, _ticket.ID);
			}
			catch (Exception exc)
			{
				ClassJournal.AddJournalEntry(_ticket, $"Error sending Re-Open Ticket email: {exc.Message}", null, true);
			}
		}

		private void EmailSend_MarketClose()
		{
			if (_ticket == null || _ticket.ID < 0 || !_ticket.CloseDateTime.HasValue)
				return;

			var closeMessage = ClassEmailGenerator.GenerateEmail_Close(_ticket, out var status);
			if (closeMessage == null)
			{
				var errorMessage = $"Error generating Close Ticket Email: {status}";
				MessageBox.Show(errorMessage, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.Closed, closeMessage, _ticket.ID);
			}
			catch (Exception exc)
			{
				ClassJournal.AddJournalEntry(_ticket, $"Error sending Close Ticket email: {exc.Message}", null, true);
			}
		}

		private void EmailSend_TechOnSite()
		{
			if (_ticket == null || _ticket.ID < 0 || !_ticket.TechID.HasValue)
				return;

			var techOnSiteMessage = ClassEmailGenerator.GenerateEMail_TechOnSite(_ticket, out var status);
			if (techOnSiteMessage == null)
			{
				var errorMessage = $"Error generating Tech On Site Email: {status}";
				MessageBox.Show(errorMessage, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.TechOnSite, techOnSiteMessage, _ticket.ID);
			}
			catch (Exception exc)
			{
				ClassJournal.AddJournalEntry(_ticket, $"Error sending Tech On Site Email: {exc.Message}", null, true);
			}
		}
		#endregion

		private void ShowPreventiveMaintenanceActionChecklist()
		{
			using (var frmChecklist = new FormPMAChecklist(_ticket.ID))
				frmChecklist.ShowDialog(this);
		}

		private void ShowTechLog()
		{
			using (var frmTechLog = new FormTicket_TechLog(_ticket.ID))
				frmTechLog.ShowDialog(this);
		}

		#region Background Workers
		/// <summary>
		/// e.Argument expected to be object array[3]: ClassAsset Asset, ClassTicketSingle Ticket, string Caption
		/// </summary>
		private void bgwWebCamGetter_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			var args = (object[])e.Argument;
			var camAsset = (ClassAsset)args[0];
			var camTicket = (ClassTicket)args[1];
			var camType = ClassCameraType.GetByID(camAsset.Net.Webcam_Type);
			var camCaption = (string)args[2];

			Image webImage = null;
			try
			{
				using (var client = new WebClient())
				{
					var imageData = client.DownloadData(camAsset.URL_CameraImage(camType));
					webImage = ClassUtility.ByteArrayToImage(imageData);
				}
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				Debug.WriteLine(exc.Message);
				e.Result = null;
			}
			e.Result = new object[] { camTicket, camCaption, webImage };
		}

		/// <summary>
		/// e.Result expected to be object array[3]: ClassTicketSingle Ticket, string Caption, Image CameraImage
		/// </summary>
		private void bgwWebCamGetter_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			var result = (object[])e.Result;
			if (result == null)
				return;

			var camTicket = (ClassTicket)result[0];
			var camCaption = (string)result[1];
			var camImage = (Image)result[2];

			if (camImage != null)
				try
				{
					camTicket.AddImage(camImage, camCaption);
				}
				catch
				{
					// Ticket image table may be missing or offline
				}
		}
		#endregion

		private void radInvoiceNotes_Covered_CheckedChanged(object sender, EventArgs e)
		{
			if (!radInvoiceNotes_Covered.Checked)
				return;

			_ticket.SetBillable(false);
		}

		private void radInvoiceNotes_Billable_CheckedChanged(object sender, EventArgs e)
		{
			if (!radInvoiceNotes_Billable.Checked)
				return;

			_ticket.SetBillable(true);
		}

		private void btnInvoiceNotes_Update_Click(object sender, EventArgs e)
		{
			_ticket.SetInvoiceNotes(txtInvoiceNotes.Text.Trim());
		}

		private void timerRmaWarningFlasher_Tick(object sender, EventArgs e)
		{
			btnRmaWarning.BackColor = (btnRmaWarning.BackColor == Color.Yellow) ? SystemColors.Control : Color.Yellow;
		}

		private void btnRmaWarning_Click(object sender, EventArgs e)
		{
			if (!_warningRmas.Any())
				return;

			var rmaDetail = string.Format("The following RMAs contain assemblies that have not been received from {1} in over {2} days:{0}{0}", Environment.NewLine, _assignedTech.TechName, ClassRMA.UNRECEIVED_RMA_WARN_OVER_DAYS);
			rmaDetail += string.Join(Environment.NewLine, _warningRmas.Select(r => $"{r.ID} - issued on {r.Creation_Date:yyyy-MM-dd} for {r.AssetName}.  ({r.Assemblies_ReceivedOrDiscarded_Qty}/{r.AssemblyQty} received)"));

			var title = $"Unreceived RMAs Over {ClassRMA.UNRECEIVED_RMA_WARN_OVER_DAYS} Days";
			MessageBox.Show(rmaDetail, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtAsset_ServiceReminder_Click(object sender, EventArgs e)
		{
			if (_asset == null || _asset.ID < 0)
				return;

			using (var serviceReminderForm = new FormAsset_ServiceReminder(_asset))
			{
				serviceReminderForm.ShowDialog();
				if (serviceReminderForm.DialogResult != DialogResult.OK)
					return;

				_asset = ClassAsset.GetByID(_ticket.AssetID);
				Populate_Asset();
			}
		}

		private void cmbAsset_TicketHistory_Click(object sender, EventArgs e)
		{
			if (!(cmbAsset_TicketHistory.Tag is int) || ((int)cmbAsset_TicketHistory.Tag != _asset.ID))
				Populate_AssetTicketHistory();
		}

		private void cmbAsset_TicketHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange || cmbAsset_TicketHistory.SelectedItem == null)
				return;

			var ticketID = (int)cmbAsset_TicketHistory.SelectedValue;
			Ticket_Load(ticketID);
		}

		/// <summary>
		/// If a ticket is currently loaded, will open ticket journal addition prompt.
		/// </summary>
		public void PromptForJournalEntry()
		{
			if (_ticket == null || _ticket.IsDeleted)
				return;

			Journal_AddEntry();
		}

		/// <summary>
		/// Opens a preset email for sending billable confirmation.
		/// </summary>
		private void tsmiTicket_BillableConfirmationEmail_Click(object sender, EventArgs e)
		{
			var msg = ClassEmailGenerator.GenerateEmail_BillableConfirmation(_ticket);

			var processArguments = $"mailto:{msg.To}?cc={msg.CC}&subject={Uri.EscapeDataString(msg.Subject)}&body={Uri.EscapeDataString(msg.Body)}";
			Process.Start(processArguments);
		}

        private void sendPMCOSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassTech t;
            using (FormList_Techs _form = new FormList_Techs(ClassTech.GetByAsset(_asset.ID).ToList()))
            {
                _form.ShowDialog();
                t = _form.SelectedTech;
            }
            var newOsaNotes = _ticket.OSANotes;
            using (var formTextEntry = new FormUserInput("PMC Notes", "Enter Reason for dispatching a tech.", true, newOsaNotes))
            {
                formTextEntry.ShowDialog(this);
                if (formTextEntry.DialogResult != DialogResult.OK)
                    return;
                newOsaNotes = formTextEntry.UserText;
            }
            _ticket.UpdateOsaNotes(newOsaNotes, -1);

            if(t != null)
                _ticket.AssignTech(t);
                //1227 is the id of PMC. This is a temp solution until I think of a better way 
            if (t == null || t.ID == 1227)
                t = null;
            string error = string.Empty;

            var entry = "Dispatched PMC";
            ClassJournal.AddJournalEntry(_ticket, entry, DateTime.Now.AddMinutes(10), true);

            var msg = ClassEmailGenerator.GenerateEmail_PMC(_ticket, _asset, t, out error);
            ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.PMC, msg, _ticket.ID);
        }

        private void mbtnRebootCradle_Click(object sender, EventArgs e)
        {
            var RefreshedAsset = ClassAsset.GetByID(_ticket.AssetID);

            if(!RefreshedAsset.Net.Is_Cradlepoint)
            {
                MessageBox.Show("Asset Not Marked as having a Cradlepoint. Please double check!", "Can't Send Reboot!");
                return;
            } 

            //Send 3 reboot commands
            var email = ClassEmailGenerator.GenerateEmail_RebootCradlepoint(_ticket);
            
            ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.CradlepointReset, email, _ticket.ID);
            email = ClassEmailGenerator.GenerateEmail_RebootCradlepoint(_ticket);
            ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.CradlepointReset, email, _ticket.ID);
            email = ClassEmailGenerator.GenerateEmail_RebootCradlepoint(_ticket);
            ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.CradlepointReset, email, _ticket.ID);

            //send notification that reboots have been sent
            var emailNotify = ClassEmailGenerator.GenerateEmail_NotifyRebootCradlepoint(_ticket);
            ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.CradlepointResetNotification, emailNotify, _ticket.ID);
        }
    }
}