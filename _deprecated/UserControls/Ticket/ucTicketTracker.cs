using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using MySql.Data.MySqlClient;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.Classes.User;

namespace SDB.UserControls.Ticket
{
	public partial class TicketTracker : UserControl
	{
		#region Delegates and Events
		public delegate void TicketDelegate(ClassTicket ticket);
		public delegate void TicketRentalDelegate(ClassTicket ticket);
		public delegate void AssetDelegate(int assetID);
		public delegate void TechDelegate(int techID);

		public event TicketDelegate Ticket_Click;
		public event TicketRentalDelegate TicketRental_Click;
		public event TicketDelegate Journal_Click;
		public event AssetDelegate Asset_Click;
		public event TechDelegate Tech_Click;
		#endregion

		#region Enums and Structs
		public enum ViewModes
		{
			Open,
			OnHold,
			RecentlyClosed,
			None
		};
		#endregion

		#region Private Fields
		private ViewModes _currentViewMode = ViewModes.Open;
		private bool _changingViewMode;

		private List<ClassTicket> _tickets = new List<ClassTicket>();
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		public TicketTracker()
		{
			InitializeComponent();

			pnlControl.BackColor = GS.Settings.ControlBarColor;
			radOpen.ForeColor = ClassTicket.COL_TICKET_OPEN_OSA_FG;
			radOpen.BackColor = ClassTicket.COL_TICKET_OPEN_OSA_BG;
			radOnHold.ForeColor = ClassTicket.COL_TICKET_HELD_FG;
			radOnHold.BackColor = ClassTicket.COL_TICKET_HELD_BG;
			radClosed.ForeColor = ClassTicket.COL_TICKET_CLOSED_FG;
			radClosed.BackColor = ClassTicket.COL_TICKET_CLOSED_BG;

			#region Sorters and Formatters for ObjectListView
			olvTickets.PrimarySortColumn = olcExpiration;
			olvTickets.PrimarySortOrder = SortOrder.Ascending;

			olvTickets.SecondarySortColumn = olcExpiration;
			olvTickets.SecondarySortOrder = SortOrder.Ascending;

			olcUpdated.AspectToStringConverter = x =>
			{
				if (x == null)
					return string.Empty;

				var updateTime = (DateTime)x;
				var ts = updateTime - DateTime.Now;
				return ts.Ticks > 0 ? $"in {ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration())}" : $"{ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration())} ago";
			};

			olcExpiration.AspectToStringConverter = x =>
			{
				if (x == null)
					return string.Empty;

				var expireTime = (DateTime)x;
				var ts = expireTime - DateTime.Now;
				return ts.Ticks > 0 ? $"in {ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration())}" : $"{ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration())} ago";
			};

			olcOpenDuration.AspectToStringConverter = x =>
			{
				if (x == null)
					return string.Empty;

				var ts = (TimeSpan)x;
				return ClassUtility.FormatRoundedTimeSpan_Dhm(ts.Round().Duration());
			};

			olcSymptoms.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Symptoms();

			olcTechOnSite.AspectGetter = x => ((ClassTicket)x).IsTechOnSite;
			olcTechOnSite.AspectToStringConverter = x => string.Empty;
			olcTechOnSite.ImageGetter = x => ((ClassTicket)x).IsTechOnSite ? "tech" : "none";

			olcRentalActive.AspectGetter = x => ((ClassTicket)x).IsRentalActive;
			olcRentalActive.AspectToStringConverter = x => string.Empty;
			olcRentalActive.ImageGetter = x => ((ClassTicket)x).IsRentalActive ? "rental" : "none";
			#endregion
		}
		#endregion

		#region Private Methods
		private void radOpen_Click(object sender, EventArgs e)
		{
			var previousViewMode = _currentViewMode;
			_currentViewMode = ViewModes.Open;
			if (previousViewMode != _currentViewMode)
				_changingViewMode = true;
			Populate();
		}

		private void radOnHold_Click(object sender, EventArgs e)
		{
			var previousViewMode = _currentViewMode;
			_currentViewMode = ViewModes.OnHold;
			if (previousViewMode != _currentViewMode)
				_changingViewMode = true;
			Populate();
		}

		private void radClosed_Click(object sender, EventArgs e)
		{
			var previousViewMode = _currentViewMode;
			_currentViewMode = ViewModes.RecentlyClosed;
			if (previousViewMode != _currentViewMode)
				_changingViewMode = true;
			Populate();
		}

		private void olvTickets_FormatCell(object sender, FormatCellEventArgs e)
		{
			var ticket = (ClassTicket)e.Model;
			if (e.ColumnIndex == olcTicketID.Index)
			{
				e.SubItem.ForeColor = ticket.StatusColor_Foreground;
				e.SubItem.Font = new Font(e.SubItem.Font, FontStyle.Bold);
			}
			else if (e.ColumnIndex == olcAsset.Index)
			{
				e.SubItem.ForeColor = ticket.ExtraProperties.IsAssetLaborCovered ? Color.Black : ClassAsset.COL_ASSET_NO_LABOR_COVERAGE_FG;
			}
			else if (e.ColumnIndex == olcLastUpdate.Index)
			{
				e.SubItem.ForeColor = ticket.ExtraProperties.Journal.LastUserEntry.IsSystemMessage ? ClassJournalItem.COL_JOURNAL_SYSTEM_BLUE_FG : Color.Black;
			}
			else if (e.ColumnIndex == olcExpiration.Index)
			{
				if (!ticket.ExtraProperties.Journal.LastUserEntry.ExpireDateTime.HasValue)
					e.SubItem.ForeColor = Color.Gray;

				if (ticket.IsClosed || ticket.IsDeleted)
					return;

				if (ticket.ExtraProperties.Journal.LastUserEntry.IsExpired)
					e.SubItem.BackColor = ClassJournalItem.COL_JOURNAL_OUTOFDATE_RED_BG;
				else if (!ticket.ExtraProperties.Journal.LastUserEntry.ExpireDateTime.HasValue)
				{
					if (ticket.ExtraProperties.Journal.LastUserEntry.JournalDateTime < DateTime.Now.AddHours(-24))
						e.SubItem.BackColor = ClassJournalItem.COL_JOURNAL_OUTOFDATE_SOFT_BG;
				}
			}
		}

		private void Populate()
		{
			Cursor = Cursors.WaitCursor;
			olvTickets.Font = GS.Settings.JournalFont;
			var topItemIndex = olvTickets.TopItemIndex;
			olvTickets.ClearObjects();
			olvTickets.Update();

			foreach (var radioButton in pnlShowMode.Controls.OfType<RadioButton>())
				radioButton.Checked = false;

			try
			{
				CheckExpiredHolds();
			}
			catch (MySqlException exc)
			{
				ClassLogFile.AppendToLog($"MySqlException {exc.StackTrace.Trim()}");
				ClassLogFile.AppendToLog($"\t{exc.Message}");
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
			}

			try
			{
				switch (_currentViewMode)
				{
					case ViewModes.None:
						_tickets = null;
						break;

					case ViewModes.Open:
						radOpen.Checked = true;
						_tickets = ClassTicket.GetAll(null, int.MaxValue, out var _, ClassTicket.TicketType.Open).ToList();
						break;

					case ViewModes.OnHold:
						radOnHold.Checked = true;
						_tickets = ClassTicket.GetAll(null, int.MaxValue, out var _, ClassTicket.TicketType.Held).ToList();
						break;

					case ViewModes.RecentlyClosed:
						radClosed.Checked = true;
						var now = ClassDatabase.GetCurrentTime();
						var oneWeekAgo = now.AddDays(-7);
						_tickets = ClassTicket.GetByCloseDate(oneWeekAgo, now).ToList();
						break;
				}
				_tickets.PopulateSymptomsAndSolutions();
				_tickets.PopulateExtraStrings();
				_tickets.PopulateLastJournals();
				_tickets.PopulateAssetWarrantyIndicator();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
			}

			olvTickets.SetObjects(_tickets);
			if (_changingViewMode)
			{
				olvTickets.TopItemIndex = 0;
			}
			else
			{
				// Try to scroll back to same position
				try
				{
					olvTickets.TopItemIndex = topItemIndex;
				}
				catch
				{
				}
			}
			_changingViewMode = false;
			txtTicketQty.Text = _tickets?.Count.ToString(CultureInfo.InvariantCulture) ?? "0";
			Cursor = Cursors.Default;
		}

		private static void CheckExpiredHolds()
		{
			// Find any expired on-hold tickets and add a journal entry indicating the hold expired
			var expiredHeldTickets = ClassTicket.GetExpiredHolds();
			foreach (var expiredHeldTicket in expiredHeldTickets)
			{
				const string HOLD_EXPIRED_ENTRY = "Hold Expired";
				ClassJournal.AddTicketJournalEntryForExpiredHold(expiredHeldTicket.TicketID, HOLD_EXPIRED_ENTRY);

				// Send notifications
				ClassNotification.SendNotificationsForObject(HOLD_EXPIRED_ENTRY, ClassSubscription.ObjectTypeEnum.Ticket, expiredHeldTicket.TicketID);
			}

			// Move any expired on-hold tickets back to open
			ClassTicket.ReleaseExpiredHolds();
		}

		private void olvTickets_CellClick(object sender, CellClickEventArgs e)
		{
			var selectedTicket = (ClassTicket)e.Model;
			if (e.Column == olcLastUpdate)
				Journal_Click?.Invoke(selectedTicket);
			else if (e.Column == olcTicketID)
				Ticket_Click?.Invoke(selectedTicket);
			else if (e.Column == olcRentalActive  && selectedTicket.IsRentalActive)
				TicketRental_Click?.Invoke(selectedTicket);
			else if (e.Column == olcAsset)
				Asset_Click?.Invoke(selectedTicket.AssetID);
			else if ((e.Column == olcTech || e.Column == olcTechOnSite) && selectedTicket.TechID.HasValue)
				Tech_Click?.Invoke(selectedTicket.TechID.Value);

			e.Handled = true;
		}

		private void olvTickets_BeforeCreatingGroups(object sender, CreateGroupsEventArgs e)
		{
			e.Parameters.PrimarySort = olcExpiration;
			e.Parameters.PrimarySortOrder = SortOrder.Ascending;
		}

		private void olvTickets_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
		{
			e.AutoPopDelay = 30000;
			var ticket = (ClassTicket)e.Model;
			if (e.Column == olcTechOnSite)
				e.Text = ticket.ExtraProperties.AssignedTechName;
			else if (e.Column == olcLastUpdate && ticket.ExtraProperties.Journal.LastEntry.JournalText.Length > 80)
				e.Text = ticket.ExtraProperties.Journal.LastEntry.JournalText.WrapAt(80);
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Refreshes the list for the currently selected ticket type.
		/// </summary>
		public void RefreshTicketList()
		{
			Populate();
		}

		public byte[] GetTrackerSettings()
		{
			return olvTickets.SaveState();
		}

		public void ApplyTrackerSettings(byte[] trackerSettings)
		{
			try
			{
				olvTickets.RestoreState(trackerSettings);
				olvTickets.Font = GS.Settings.JournalFont;
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog("Error restoring tracker settings:", exc);
			}
		}

		private void tsmiExportTracker_Click(object sender, EventArgs e)
		{
			var trackerState = olvTickets.SaveState();
			using (var sfd = new SaveFileDialog())
			{
				sfd.InitialDirectory = Application.StartupPath;
				sfd.DefaultExt = ".bin";
				sfd.FileName = "SDB Tracker State.bin";
				if (sfd.ShowDialog() != DialogResult.OK)
					return;
				try
				{
					File.WriteAllBytes(sfd.FileName, trackerState);
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Could not export tracker state: {exc.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void tsmiImportTracker_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				ofd.InitialDirectory = Application.StartupPath;
				ofd.Title = "Select Tracker State file";
				ofd.DefaultExt = ".bin";
				ofd.FileName = "SDB Tracker State.bin";
				if (ofd.ShowDialog() != DialogResult.OK)
					return;

				byte[] fileBytes;
				try
				{
					fileBytes = File.ReadAllBytes(ofd.FileName);

				}
				catch (Exception exc)
				{
					MessageBox.Show($"Could not import tracker state: {exc.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				try
				{
					olvTickets.RestoreState(fileBytes);
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Could not apply imported tracker state: {exc.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public void SetViewMode(ViewModes viewMode)
		{
			_currentViewMode = viewMode;
		}

		public void ClearControls()
		{
			_currentViewMode = ViewModes.None;
			foreach (var radioButton in pnlShowMode.Controls.OfType<RadioButton>())
				radioButton.Checked = false;
			olvTickets.SetObjects(null);
			txtTicketQty.Clear();
		}
		#endregion
	}
}