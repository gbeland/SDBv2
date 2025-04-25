using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Forms.Ticket
{
	public partial class FormList_Tickets : Form
	{
		public int? SelectedTicketID { get; private set; }

		private List<ClassTicket> _ticketList;
		private readonly string _searchTerm;

		private const int _MAX_RESULTS_PER_PAGE = 1000;
		private int _page;
		private int _maxPage;
		private int _ticketCount;
		private TicketListView _selectedView;
		private bool _ignoreStateChange;

		private enum TicketListView
		{
			OpenAndHeld,
			Closed,
			Deleted
		}

		public FormList_Tickets(List<ClassTicket> customTicketList = null, string searchTerm = null)
		{
			InitializeComponent();

			lblKey_OpenOsa.ForeColor = ClassTicket.COL_TICKET_OPEN_OSA_FG;
			lblKey_Open.ForeColor = ClassTicket.COL_TICKET_OPEN_FG;
			lblKey_Held.ForeColor = ClassTicket.COL_TICKET_HELD_FG;
			lblKey_Closed.ForeColor = ClassTicket.COL_TICKET_CLOSED_FG;
			lblKey_Deleted.ForeColor = ClassTicket.COL_TICKET_DELETED_FG;

			lblKey_OpenOsa.BackColor = ClassTicket.COL_TICKET_OPEN_OSA_BG;
			lblKey_Open.BackColor = ClassTicket.COL_TICKET_OPEN_BG;
			lblKey_Held.BackColor = ClassTicket.COL_TICKET_HELD_BG;
			lblKey_Closed.BackColor = ClassTicket.COL_TICKET_CLOSED_BG;
			lblKey_Deleted.BackColor = ClassTicket.COL_TICKET_DELETED_BG;

			olcDuration.AspectToStringConverter = x =>
			                                      {
													  if (x == null)
														  return string.Empty;
				                                      var ticketDuration = (TimeSpan)x;
				                                      return ClassUtility.FormatTimeSpan_Dhm(ticketDuration);
			                                      };

			olcTOSTime.AspectToStringConverter = x =>
			                                     {
													 if (x == null)
														 return string.Empty;
				                                     var techOnSiteTime = (TimeSpan)x;
				                                     return ClassUtility.FormatTimeSpan_Dhm(techOnSiteTime);
			                                     };

			olcSymptoms.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Symptoms(true);
			olcSolution.AspectGetter = x => ((ClassTicket)x).ExtraProperties.Solutions();
			olcIsHeld.AspectToStringConverter = x => (bool)x ? "Held" : string.Empty;
			olvTickets.EmptyListMsg = "Loading...";

			_ticketList = customTicketList;
			_searchTerm = searchTerm;
		}

		private void FormList_Tickets_Shown(object sender, EventArgs e)
		{
			if (_ticketList != null)
			{
				_ticketList.PopulateSymptomsAndSolutions();
				_ticketList.PopulateExtraStrings();

				olvTickets.SetObjects(_ticketList);
				txtTicketQty.Text = _ticketList.Count().ToString(CultureInfo.InvariantCulture);

				if (string.IsNullOrEmpty(_searchTerm))
					return;

				var filter = TextMatchFilter.Contains(olvTickets, _searchTerm);
				olvTickets.ModelFilter = filter;
				olvTickets.DefaultRenderer = new HighlightTextRenderer(filter);
			}
			else
			{
				pnlSubControlLeft.Visible = true;
				PopulateTicketList();
			}
		}

		private async void PopulateTicketList()
		{
			Cursor = Cursors.WaitCursor;
			await LoadTicketsAsync();
			olvTickets.SetObjects(_ticketList);
			olvTickets.EmptyListMsg = "No tickets found.";
			HandlePagination();
			Cursor = Cursors.Default;
		}

		private Task LoadTicketsAsync()
		{
			return Task.Factory.StartNew(() =>
			                             {
				                             switch (_selectedView)
				                             {
					                             case TicketListView.Closed:
						                             _ticketList = ClassTicket.GetAll(_page, _MAX_RESULTS_PER_PAGE, out _ticketCount, ClassTicket.TicketType.Closed).ToList();
						                             break;

					                             case TicketListView.Deleted:
						                             _ticketList = ClassTicket.GetAll(_page, _MAX_RESULTS_PER_PAGE, out _ticketCount, ClassTicket.TicketType.Deleted).ToList();
						                             break;

					                             case TicketListView.OpenAndHeld:
						                             _ticketList = ClassTicket.GetAll(_page, _MAX_RESULTS_PER_PAGE, out _ticketCount, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held).ToList();
						                             break;
				                             }

				                             _ticketList.PopulateSymptomsAndSolutions();
				                             _ticketList.PopulateExtraStrings();
			                             });
		}

		private void HandlePagination()
		{
			_maxPage = (int)Math.Ceiling(_ticketCount / (decimal)_MAX_RESULTS_PER_PAGE) - 1;
			txtTicketQty.Text = _ticketCount.ToString(CultureInfo.InvariantCulture);

			pnlPagination.Visible = _maxPage > 0;
			lblPageMax.Text = $"of {_maxPage + 1}";

			_ignoreStateChange = true;
			var pages = Enumerable.Range(1, _maxPage + 1).ToList();
			cmbPage.DataSource = pages;
			cmbPage.SelectedItem = _page + 1;
			_ignoreStateChange = false;

			btnFirst.Enabled = _page != 0;
			btnPrevious.Enabled = _page != 0;
			btnNext.Enabled = _page < _maxPage;
			btnLast.Enabled = _page < _maxPage;
		}

		private void radOpen_Click(object sender, EventArgs e)
		{
			_selectedView = TicketListView.OpenAndHeld;
			_page = 0;
			radOpen.Checked = true;
			PopulateTicketList();
		}

		private void radClosed_Click(object sender, EventArgs e)
		{
			_selectedView = TicketListView.Closed;
			_page = 0;
			radClosed.Checked = true;
			PopulateTicketList();
		}

		private void radDeleted_Click(object sender, EventArgs e)
		{
			_selectedView = TicketListView.Deleted;
			_page = 0;
			radDeleted.Checked = true;
			PopulateTicketList();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (olvTickets.SelectedObject is ClassTicket selectedTicket)
			{
				DialogResult = DialogResult.OK;
				SelectedTicketID = selectedTicket.ID;
			}
			else
				DialogResult = DialogResult.Cancel;
			Close();
		}

		private void olvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvTickets.SelectedItem == null)
				return;
			SelectedTicketID = ((ClassTicket)olvTickets.SelectedObject).ID;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			_page = (int)cmbPage.SelectedItem - 1;
			PopulateTicketList();
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			_page = 0;
			PopulateTicketList();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			_page--;
			if (_page < 0)
				_page = 0;
			PopulateTicketList();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			_page++;
			if (_page > _maxPage)
				_page = _maxPage;
			PopulateTicketList();
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			_page = _maxPage;
			PopulateTicketList();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
				ClassTicket.TicketType exportType;

				switch (_selectedView)
				{
					default:
						exportType = ClassTicket.TicketType.Open | ClassTicket.TicketType.Held;
						break;

					case TicketListView.Closed:
						exportType = ClassTicket.TicketType.Closed;
						break;

					case TicketListView.Deleted:
						exportType = ClassTicket.TicketType.Deleted;
						break;
				}

			using (var sfd = new SaveFileDialog())
			{
				sfd.FileName = ClassUtility.MakeSafeFileName($"{_selectedView} Ticket List {DateTime.Now:yyyyMMdd_HHmmss}.csv");
				sfd.Filter = "Comma Separated Values (*.csv)|*.csv";
				sfd.DefaultExt = ".csv";
				sfd.Title = "Export Ticket List";
				sfd.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
				if (sfd.ShowDialog() != DialogResult.OK)
					return;

				try
				{
					Cursor = Cursors.WaitCursor;
					var exportTickets = ClassTicket.GetAll(null, int.MaxValue, out var _, exportType).ToList();
					exportTickets.PopulateSymptomsAndSolutions();
					exportTickets.PopulateExtraStrings();

					ClassUtility.ObjectListExport(exportTickets, sfd.FileName);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc.ToString());
				}
				finally
				{
					Cursor = Cursors.Default;
				}
			}
		}

		private void olvTickets_FormatRow(object sender, FormatRowEventArgs e)
		{
			var ticket = (ClassTicket)e.Model;
			e.Item.ForeColor = ticket.StatusColor_Foreground;
			e.Item.BackColor = ticket.StatusColor_Background;
		}
	}
}