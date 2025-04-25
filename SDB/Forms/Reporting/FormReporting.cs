using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Forms.Asset;

namespace SDB.Forms.Reporting
{
	public partial class FormReporting : Form
	{
		public delegate void RMAClickedEvent(int rmaID);
		public event RMAClickedEvent ViewRMA;

		public delegate void TicketClickedEvent(int ticketID);
		public event TicketClickedEvent ViewTicket;

		#region Child Forms
		private readonly FormReporting_Graph _graphReport = new FormReporting_Graph();
		private readonly FormReporting_RMA _rmaReport = new FormReporting_RMA();
		private readonly FormReporting_Symptoms _symptomReport = new FormReporting_Symptoms();
		private readonly FormReporting_Ticket _ticketReport = new FormReporting_Ticket();
		#endregion

		#region Vars
		private List<ClassAsset> _assets = new List<ClassAsset>();
		private List<ClassCustomer> _customers = new List<ClassCustomer>();
		private List<ClassTech> _techs = new List<ClassTech>();

		private List<ClassTicket_Symptom> _ticketSymptoms = new List<ClassTicket_Symptom>();
		private List<ClassTicket_Solution> _ticketSolutions = new List<ClassTicket_Solution>();

		private List<ClassAssemblyType> _assemblyTypes = new List<ClassAssemblyType>();
		private List<ClassRMA_FailureType> _rmaFailureTypes = new List<ClassRMA_FailureType>();
		private List<ClassRMA_RepairType> _rmaRepairTypes = new List<ClassRMA_RepairType>();
		private List<ClassRMA_RootCause> _rmaRootCauses = new List<ClassRMA_RootCause>();

		private bool _ignoreStateChange;
		private DateTime? _storedDateFrom;
		private DateTime? _storedDateTo;

		private ClassReporting.ClassReportElement _selectedReport;
		#endregion

		#region Form
		public FormReporting()
		{
			InitializeComponent();

			_ticketReport.ViewTicket += TicketReport_ViewTicket;
			_rmaReport.ViewRma += RmaReport_ViewRma;
		}

		private void FormReporting_Load(object sender, EventArgs e)
		{
			_ignoreStateChange = true;

			var dtNow = DateTime.Now;
			SetDateRange(btnShortcut_Week, new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 0, 0, 0).AddDays(-7), new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 23, 59, 59));

			RefreshData();

			lstCustomers.DisplayMember = "DisplayMember";
			lstCustomers.ValueMember = "ID";
			lstCustomers.DataSource = _customers;
			lstCustomers.SelectedItems.Clear();

			lstAssets.DisplayMember = "DisplayMember";
			lstAssets.ValueMember = "ID";
			lstAssets.DataSource = _assets;
			lstAssets.SelectedItems.Clear();

			lstTechs.DisplayMember = "DisplayMember";
			lstTechs.ValueMember = "ID";
			lstTechs.DataSource = _techs;
			lstTechs.SelectedItems.Clear();

			lstTicketSymptoms.DisplayMember = "DisplayMember";
			lstTicketSymptoms.ValueMember = "ID";
			lstTicketSymptoms.DataSource = _ticketSymptoms;
			lstTicketSymptoms.SelectedItems.Clear();

			lstTicketSolutions.DisplayMember = "DisplayMember";
			lstTicketSolutions.ValueMember = "ID";
			lstTicketSolutions.DataSource = _ticketSolutions;
			lstTicketSolutions.SelectedItems.Clear();

			lstRMAOptions_AssemblyTypes.DisplayMember = "DisplayMember";
			lstRMAOptions_AssemblyTypes.ValueMember = "ID";
			lstRMAOptions_AssemblyTypes.DataSource = _assemblyTypes;
			lstRMAOptions_AssemblyTypes.SelectedItems.Clear();

			lstRMAOptions_FailureTypes.DisplayMember = "DisplayMember";
			lstRMAOptions_FailureTypes.ValueMember = "ID";
			lstRMAOptions_FailureTypes.DataSource = _rmaFailureTypes;
			lstRMAOptions_FailureTypes.SelectedItems.Clear();

			lstRMAOptions_RepairTypes.DisplayMember = "DisplayMember";
			lstRMAOptions_RepairTypes.ValueMember = "ID";
			lstRMAOptions_RepairTypes.DataSource = _rmaRepairTypes;
			lstRMAOptions_RepairTypes.SelectedItems.Clear();

			lstRMAOptions_RootCauses.DisplayMember = "DisplayMember";
			lstRMAOptions_RootCauses.ValueMember = "ID";
			lstRMAOptions_RootCauses.DataSource = _rmaRootCauses;
			lstRMAOptions_RootCauses.SelectedItems.Clear();

			#region Populate Selection Lists
			lstSymptomReports.Items.AddRange(ClassReporting.ALL_REPORTS.Where(r => r.ReportGroup == ClassReporting.ReportGroupEnum.Symptom).Cast<object>().ToArray());
			lstTicketReports.Items.AddRange(ClassReporting.ALL_REPORTS.Where(r => r.ReportGroup == ClassReporting.ReportGroupEnum.Ticket).Cast<object>().ToArray());
			lstRMAReports.Items.AddRange(ClassReporting.ALL_REPORTS.Where(r => r.ReportGroup == ClassReporting.ReportGroupEnum.RMA).Cast<object>().ToArray());
			lstAccountingReports.Items.AddRange(ClassReporting.ALL_REPORTS.Where(r => r.ReportGroup == ClassReporting.ReportGroupEnum.Accounting).Cast<object>().ToArray());
			#endregion
			_ignoreStateChange = false;

			WindowState = GS.Settings.WindowState_Reports;
			Location = GS.Settings.Location_Reports;
		}

		private void FormReporting_VisibleChanged(object sender, EventArgs e)
		{
			// Refresh data when form is shown again
			if (!((Form)sender).Visible) return;
			RefreshData();
		}

		private void FormReporting_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}

		private void FormReporting_FormClosing(object sender, FormClosingEventArgs e)
		{
			GS.Settings.WindowState_Reports = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_Reports = Location;
			Hide();
			e.Cancel = true;
		}

		private void RefreshData()
		{
			_customers = ClassCustomer.GetCustomers().ToList();
			_assets = ClassAsset.GetAll(null, int.MaxValue, out var _).ToList();
			_techs = ClassTech.GetAll().ToList();
			_ticketSymptoms = ClassTicket_Symptom.GetAll().ToList();
			_ticketSolutions = ClassTicket_Solution.GetAll().ToList();
			_assemblyTypes = ClassAssemblyType.GetAll().ToList();
			_rmaFailureTypes = ClassRMA_FailureType.GetAll().ToList();
			_rmaRepairTypes = ClassRMA_RepairType.GetAll().ToList();
			_rmaRootCauses = ClassRMA_RootCause.GetAll().ToList();
		}

		#endregion

		#region DateShortcuts
		private void btnShortcut_Today_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, new DateTime(now.Year, now.Month, now.Day, 0, 0, 0), new DateTime(now.Year, now.Month, now.Day, 23, 59, 59));
		}

		private void btnShortcut_Week_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddDays(-7), new DateTime(now.Year, now.Month, now.Day, 23, 59, 59));
		}

		private void btnShortcut_Month_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddMonths(-1), new DateTime(now.Year, now.Month, now.Day, 23, 59, 59));
		}

		private void btnShortcut_Quarter_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			DateTime start;
			DateTime end;
			if (now.Month <= 3)
			{
				start = new DateTime(now.Year, 1, 1, 0, 0, 0);
				end = new DateTime(now.Year, 3, 31, 23, 59, 59);
			}
			else if (now.Month <= 6)
			{
				start = new DateTime(now.Year, 4, 1, 0, 0, 0);
				end = new DateTime(now.Year, 6, 30, 23, 59, 59);
			}
			else if (now.Month <= 9)
			{
				start = new DateTime(now.Year, 7, 1, 0, 0, 0);
				end = new DateTime(now.Year, 9, 30, 23, 59, 59);
			}
			else
			{
				start = new DateTime(now.Year, 10, 1, 0, 0, 0);
				end = new DateTime(now.Year, 12, 31, 23, 59, 59);
			}
			SetDateRange(sender as Button, start, end);
		}

		private void btnShortcut_Year_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddYears(-1), new DateTime(now.Year, now.Month, now.Day, 23, 59, 59));
		}

		private void btnShortcut_Within30Days_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, now.Subtract(TimeSpan.FromDays(30)), null);
		}

		private void btnShortcut_Within60Days_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, now.Subtract(TimeSpan.FromDays(60)), null);
		}

		private void btnShortcut_Within90Days_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, now.Subtract(TimeSpan.FromDays(90)), null);
		}
		
		private void btnShortcut_30PlusDays_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, null, new DateTime(now.Year, now.Month, now.Day, 23, 59, 59).AddDays(-30));
		}

		private void btnShortcut_60PlusDays_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, null, new DateTime(now.Year, now.Month, now.Day, 23, 59, 59).AddDays(-60));
		}

		private void btnShortcut_90PlusDays_Click(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			SetDateRange(sender as Button, null, new DateTime(now.Year, now.Month, now.Day, 23, 59, 59).AddDays(-90));
		}

		private void SetDateRange(Control sender, DateTime? startDate, DateTime? endDate)
		{
			_ignoreStateChange = true;
			ResetDateShortcutColors();
			sender.BackColor = Color.LightGreen;
			chkAnyDate.Checked = !startDate.HasValue && !endDate.HasValue;
			ndtpDateFrom.Value = startDate;
			ndtpDateTo.Value = endDate;
			_ignoreStateChange = false;
		}
		#endregion

		#region Generate
		private void GenerateReport()
		{
			// Validation
			if (_selectedReport == null)
				return;

			var reportRequest = CreateReportRequestObject();

			switch (reportRequest.ReportElement.ReportType)
			{
				case ClassReporting.ReportTypeEnum.SymptomGraph:
					if (_graphReport.SymptomGraph(reportRequest))
					{
						_graphReport.Show();
						_graphReport.BringToFront();
					}
					else
						ShowNoDataMessage();
					break;

				case ClassReporting.ReportTypeEnum.SymptomTable:
					var symptomSets = ClassReporting.Report_Symptoms(reportRequest).ToList();
					if (symptomSets.Count > 0)
					{
						_symptomReport.SymptomSet = symptomSets;
						_symptomReport.ReportTitle = reportRequest.ReportTitle_SingleLine;
						_symptomReport.Show();
						_symptomReport.BringToFront();
					}
					else
						ShowNoDataMessage();
					break;

				case ClassReporting.ReportTypeEnum.SymptomTrend:
					if (_graphReport.SymptomTrendGraph(reportRequest))
					{
						_graphReport.Show();
						_graphReport.BringToFront();
					}
					else
						ShowNoDataMessage();
					break;

				case ClassReporting.ReportTypeEnum.SymptomTrendLine:
					if (_graphReport.SymptomTrendGraph2(reportRequest))
					{
						_graphReport.Show();
						_graphReport.BringToFront();
					}
					else
						ShowNoDataMessage();
					break;

				case ClassReporting.ReportTypeEnum.Tickets:
					try
					{
						var reportTickets = ClassTicket_Reporting.GetTicketsForReporting(reportRequest).ToList();

						// Filter RptTickets options not handled by SQL
						if (reportRequest.TicketReportOptions.IsOpenDurationFiltered)
							reportTickets.RemoveAll(t => t.Ticket.Duration.TotalHours < reportRequest.TicketReportOptions.OpenDuration_Hours);

						if (reportTickets.Count > 0)
						{
							_ticketReport.TicketReportList = reportTickets;
							_ticketReport.ReportTitle = reportRequest.ReportTitle_SingleLine;
							_ticketReport.Show();
							_ticketReport.BringToFront();
						}
						else
							ShowNoDataMessage();
					}
					catch (Exception exc)
					{
						ClassLogFile.AppendToLog(exc);
						MessageBox.Show(string.Format("The report failed to generate:{0}{0}{1}", Environment.NewLine, exc.Message), "Report Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case ClassReporting.ReportTypeEnum.RMAs:
					try
					{
						var rmaReportings = ClassRMA_Reporting.GetRmasForReporting(reportRequest).ToList();

						if (rmaReportings.Count > 0)
						{
							_rmaReport.RmaReportList = rmaReportings;
							_rmaReport.ReportTitle = reportRequest.ReportTitle_SingleLine;
							_rmaReport.Show();
							_rmaReport.BringToFront();
						}
						else
							ShowNoDataMessage();
					}
					catch (Exception exc)
					{
						ClassLogFile.AppendToLog(exc);
						MessageBox.Show(string.Format("The report failed to generate:{0}{0}{1}", Environment.NewLine, exc.Message), "Report Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case ClassReporting.ReportTypeEnum.OutOfDateWC:
					var outOfDateWcAssets = ClassAsset.GetAll(null, int.MaxValue, out var _).ToList();
					outOfDateWcAssets = outOfDateWcAssets.Where(a =>
																a.WarrantyInfo.LaborContractExpire >= reportRequest.OpenFrom && a.WarrantyInfo.LaborContractExpire <= reportRequest.OpenTo ||
																a.WarrantyInfo.PartsContractExpire >= reportRequest.OpenFrom && a.WarrantyInfo.PartsContractExpire <= reportRequest.OpenTo ||
																a.WarrantyInfo.LaborWarrantyExpire >= reportRequest.OpenFrom && a.WarrantyInfo.LaborWarrantyExpire <= reportRequest.OpenTo && !a.WarrantyInfo.LaborContractExpire.HasValue ||
																a.WarrantyInfo.PartsWarrantyExpire >= reportRequest.OpenFrom && a.WarrantyInfo.PartsWarrantyExpire <= reportRequest.OpenTo && !a.WarrantyInfo.PartsContractExpire.HasValue).ToList();
					if (reportRequest.Customers.Count > 0)
						outOfDateWcAssets = outOfDateWcAssets.Where(a => reportRequest.Customers.Any(c => c.Markets.Any(m => m.ID == a.MarketID))).ToList();

					outOfDateWcAssets.PopulateExtraProperties();
					if (outOfDateWcAssets.Count > 0)
					{
						using (var frmAssetList = new FormList_Assets(outOfDateWcAssets))
						{
							frmAssetList.ReportTitle = reportRequest.ReportTitle_SingleLine;
							frmAssetList.ShowDialog();
						}
					}
					else
						ShowNoDataMessage();
					break;

				case ClassReporting.ReportTypeEnum.MissingLaborWC:
				case ClassReporting.ReportTypeEnum.MissingPartsWC:
					var missingWcAssets = ClassAsset.GetAll(null, int.MaxValue, out var _).ToList();
					missingWcAssets = missingWcAssets.Where(a => a.WarrantyInfo.InstallDate >= reportRequest.OpenFrom && a.WarrantyInfo.InstallDate <= reportRequest.OpenTo).ToList();
					switch (reportRequest.ReportElement.ReportType)
					{
						case ClassReporting.ReportTypeEnum.MissingLaborWC:
							missingWcAssets = missingWcAssets.Where(a => !a.WarrantyInfo.LaborWarrantyExpire.HasValue && !a.WarrantyInfo.LaborContractExpire.HasValue).ToList();
							break;
						case ClassReporting.ReportTypeEnum.MissingPartsWC:
							missingWcAssets = missingWcAssets.Where(a => !a.WarrantyInfo.PartsWarrantyExpire.HasValue && !a.WarrantyInfo.PartsContractExpire.HasValue).ToList();
							break;
					}
					if (reportRequest.Customers.Count > 0)
						missingWcAssets = missingWcAssets.Where(a => reportRequest.Customers.Any(c => c.Markets.Any(m => m.ID == a.MarketID))).ToList();

					missingWcAssets.PopulateExtraProperties();
					if (missingWcAssets.Count > 0)
					{
						using (var frmAssetList = new FormList_Assets(missingWcAssets))
						{
							frmAssetList.ReportTitle = reportRequest.ReportTitle_SingleLine;
							frmAssetList.ShowDialog();
						}
					}
					else
						ShowNoDataMessage();
					break;
			}
		}

		private ClassReporting.ClassReportRequestObject CreateReportRequestObject()
		{
			var rptRequestObject = new ClassReporting.ClassReportRequestObject
			{
				ReportElement = _selectedReport,
				OpenFrom = ndtpDateFrom.Value,
				OpenTo = ndtpDateTo.Value,
				Customers = chkAllCustomers.Checked ? new List<ClassCustomer>() : new List<ClassCustomer>(lstCustomers.SelectedItems.Cast<ClassCustomer>()),
				Assets = chkAllAssets.Checked ? new List<ClassAsset>() : new List<ClassAsset>(lstAssets.SelectedItems.Cast<ClassAsset>()),
				Techs = chkAllTechs.Checked ? new List<ClassTech>() : new List<ClassTech>(lstTechs.SelectedItems.Cast<ClassTech>()),
				TicketReportOptions = new ClassReporting.ClassReportRequestObject.ClassTicketReportOptions
				{
					IsOpenDurationFiltered = chkTicketOptions_DurationHours.Checked,
					IsSymptomsFiltered = !chkTicketOptions_AllSymptoms.Checked,
					IsSolutionsFiltered = !chkTicketOptions_AllSolutions.Checked,
					OpenDuration_Hours = (int)numTicketOptions_DurationHours.Value,
					IncludeOpen = chkTicketOptions_Open.Checked,
					IncludeHeld = chkTicketOptions_Held.Checked,
					IncludeClosed = chkTicketOptions_Closed.Checked
				},
				RMAReportOptions = new ClassReporting.ClassReportRequestObject.ClassRMAReportOptions
				{
					IncludeUnreceived = chkRMAOptions_Unreceived.Checked,
					IncludeReceived = chkRMAOptions_Received.Checked,
					IncludeInProgress = chkRMAOptions_InProgress.Checked,
					IncludePending = chkRMAOptions_Pending.Checked,
					IncludeCompleted = chkRMAOptions_Completed.Checked,
					IncludeFinalized = chkRMAOptions_Finalized.Checked,
					IsAssemblyTypeFiltered = !chkRMAOptions_AssemblyTypes.Checked,
					IsFailureTypeFiltered = !chkRMAOptions_FailureTypes.Checked,
					IsRepairTypeFiltered = !chkRMAOptions_RepairTypes.Checked,
					IsRootCauseFiltered = !chkRMAOptions_RootCauses.Checked
				}
			};

			// Some validation on filters
			rptRequestObject.TicketReportOptions.IsSymptomsFiltered = rptRequestObject.TicketReportOptions.IsSymptomsFiltered && lstTicketSymptoms.SelectedItems.Count > 0;
			rptRequestObject.TicketReportOptions.IsSolutionsFiltered = rptRequestObject.TicketReportOptions.IsSolutionsFiltered && lstTicketSolutions.SelectedItems.Count > 0;
			rptRequestObject.RMAReportOptions.IsAssemblyTypeFiltered = rptRequestObject.RMAReportOptions.IsAssemblyTypeFiltered && lstRMAOptions_AssemblyTypes.SelectedItems.Count > 0;
			rptRequestObject.RMAReportOptions.IsFailureTypeFiltered = rptRequestObject.RMAReportOptions.IsFailureTypeFiltered && lstRMAOptions_FailureTypes.SelectedItems.Count > 0;
			rptRequestObject.RMAReportOptions.IsRepairTypeFiltered = rptRequestObject.RMAReportOptions.IsRepairTypeFiltered && lstRMAOptions_RepairTypes.SelectedItems.Count > 0;
			rptRequestObject.RMAReportOptions.IsRootCauseFiltered = rptRequestObject.RMAReportOptions.IsRootCauseFiltered && lstRMAOptions_RootCauses.SelectedItems.Count > 0;

			if (rptRequestObject.TicketReportOptions.IsSymptomsFiltered)
				rptRequestObject.TicketReportOptions.Filters.Symptoms = lstTicketSymptoms.SelectedItems.Cast<ClassTicket_Symptom>().ToList();
			if (rptRequestObject.TicketReportOptions.IsSolutionsFiltered)
				rptRequestObject.TicketReportOptions.Filters.Solutions = lstTicketSolutions.SelectedItems.Cast<ClassTicket_Solution>().ToList();

			if (rptRequestObject.RMAReportOptions.IsAssemblyTypeFiltered)
				rptRequestObject.RMAReportOptions.Filters.AssemblyTypes = lstRMAOptions_AssemblyTypes.SelectedItems.Cast<ClassAssemblyType>().ToList();
			if (rptRequestObject.RMAReportOptions.IsFailureTypeFiltered)
				rptRequestObject.RMAReportOptions.Filters.FailureTypes = lstRMAOptions_FailureTypes.SelectedItems.Cast<ClassRMA_FailureType>().ToList();
			if (rptRequestObject.RMAReportOptions.IsRepairTypeFiltered)
				rptRequestObject.RMAReportOptions.Filters.RepairTypes = lstRMAOptions_RepairTypes.SelectedItems.Cast<ClassRMA_RepairType>().ToList();
			if (rptRequestObject.RMAReportOptions.IsRootCauseFiltered)
				rptRequestObject.RMAReportOptions.Filters.RootCauses = lstRMAOptions_RootCauses.SelectedItems.Cast<ClassRMA_RootCause>().ToList();

			return rptRequestObject;
		}

		private void ShowNoDataMessage()
		{
			MessageBox.Show("No data available for specified parameters.", "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion

		#region Actions
		private void btnGenerate_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			GenerateReport();
			Cursor = Cursors.Default;
		}

		private void lstSymptomReports_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstSymptomReports.SelectedItem == null)
				return;
			_selectedReport = (ClassReporting.ClassReportElement)lstSymptomReports.SelectedItem;
			SetTextAndFilters(_selectedReport);
			lstTicketReports.ClearSelected();
			lstRMAReports.ClearSelected();
			lstAccountingReports.ClearSelected();
		}

		private void lstTicketReports_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstTicketReports.SelectedItem == null)
				return;
			_selectedReport = (ClassReporting.ClassReportElement)lstTicketReports.SelectedItem;
			SetTextAndFilters(_selectedReport);
			lstSymptomReports.ClearSelected();
			lstRMAReports.ClearSelected();
			lstAccountingReports.ClearSelected();
		}

		private void lstRMAReports_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstRMAReports.SelectedItem == null)
				return;
			_selectedReport = (ClassReporting.ClassReportElement)lstRMAReports.SelectedItem;
			SetTextAndFilters(_selectedReport);
			lstSymptomReports.ClearSelected();
			lstTicketReports.ClearSelected();
			lstAccountingReports.ClearSelected();
		}

		private void lstAccountingReports_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstAccountingReports.SelectedItem == null)
				return;
			_selectedReport = (ClassReporting.ClassReportElement)lstAccountingReports.SelectedItem;
			SetTextAndFilters(_selectedReport);
			lstSymptomReports.ClearSelected();
			lstTicketReports.ClearSelected();
			lstRMAReports.ClearSelected();
		}

		private void SetTextAndFilters(ClassReporting.ClassReportElement reportObject)
		{
			txtDescription.Text = reportObject.Description;

			pnlOptions_Dates.Enabled = reportObject.UsesDateRangeFilter;
			pnlOptions_Customer.Enabled = reportObject.UsesCustomerFilter;
			pnlOptions_Asset.Enabled = reportObject.UsesAssetFilter;
			pnlOptions_Tech.Enabled = reportObject.UsesTechFilter;
			pnlOptions_Ticket.Enabled = reportObject.UsesTicketOptions;
			pnlOptions_RMA.Enabled = reportObject.UsesRMAOptions;
		}

		private void chkAllCustomers_CheckedChanged(object sender, EventArgs e)
		{
			lstCustomers.Enabled = !chkAllCustomers.Checked;
			if (!chkAllCustomers.Checked)
				return;
			lstCustomers.SelectedItems.Clear();
			lstAssets.DataSource = _assets;
		}

		private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedCustomers = lstCustomers.SelectedItems.Cast<ClassCustomer>().ToList();
			lstAssets.DataSource = selectedCustomers.Count < 1 ? _assets : _assets.Where(a => selectedCustomers.Any(c => c.Markets.Any(m => m.ID == a.MarketID))).ToList();
		}

		private void chkAllAssets_CheckedChanged(object sender, EventArgs e)
		{
			lstAssets.Enabled = !chkAllAssets.Checked;
			if (!chkAllAssets.Checked)
				return;
			lstAssets.SelectedItems.Clear();
		}

		private void chkAllTechs_CheckedChanged(object sender, EventArgs e)
		{
			lstTechs.Enabled = !chkAllTechs.Checked;
			if (!chkAllTechs.Checked)
				return;
			lstTechs.SelectedItems.Clear();
		}

		private void ndtpDateFrom_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			ResetDateShortcutColors();
		}

		private void ndtpDateTo_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			ResetDateShortcutColors();
		}

		private void ResetDateShortcutColors()
		{
			foreach (var b in pnlDates.Controls.OfType<Button>())
				b.BackColor = SystemColors.Control;
		}

		private void chkTicketOptions_DurationHours_CheckedChanged(object sender, EventArgs e)
		{
			numTicketOptions_DurationHours.Enabled = lblTicketOptions_DurationHours.Enabled = chkTicketOptions_DurationHours.Checked;
		}

		private void chkTicketOptions_AllSymptoms_CheckedChanged(object sender, EventArgs e)
		{
			lstTicketSymptoms.Enabled = !chkTicketOptions_AllSymptoms.Checked;
		}

		private void chkTicketOptions_AllSolutions_CheckedChanged(object sender, EventArgs e)
		{
			lstTicketSolutions.Enabled = !chkTicketOptions_AllSolutions.Checked;
		}

		private void chkAnyDate_CheckedChanged(object sender, EventArgs e)
		{
			pnlDates.Enabled = !chkAnyDate.Checked;
			if (chkAnyDate.Checked)
			{
				_storedDateFrom = ndtpDateFrom.Value;
				_storedDateTo = ndtpDateTo.Value;
				ndtpDateFrom.Value = null;
				ndtpDateTo.Value = null;
			}
			else
			{
				ndtpDateFrom.Value = _storedDateFrom;
				ndtpDateTo.Value = _storedDateTo;
			}
		}

		private void chkTicketType_CheckedChanged(object sender, EventArgs e)
		{
			var ticketTypeCBs = new[] { chkTicketOptions_Open, chkTicketOptions_Held, chkTicketOptions_Closed };
			if (ticketTypeCBs.Any(cb => cb.Checked))
				return;

			MessageBox.Show("At least one ticket type must be checked.", "Invalid Ticket Report Option", MessageBoxButtons.OK, MessageBoxIcon.Information);
			chkTicketOptions_Open.Checked = true;
		}

		private void chkRMAOptions_AssemblyTypes_CheckedChanged(object sender, EventArgs e)
		{
			lstRMAOptions_AssemblyTypes.Enabled = !chkRMAOptions_AssemblyTypes.Checked;
		}

		private void chkRMAOptions_FailureTypes_CheckedChanged(object sender, EventArgs e)
		{
			lstRMAOptions_FailureTypes.Enabled = !chkRMAOptions_FailureTypes.Checked;
		}

		private void chkRMAOptions_AllRepairTypes_CheckedChanged(object sender, EventArgs e)
		{
			lstRMAOptions_RepairTypes.Enabled = !chkRMAOptions_RepairTypes.Checked;
		}

		private void chkRMAOptions_RootCauses_CheckedChanged(object sender, EventArgs e)
		{
			lstRMAOptions_RootCauses.Enabled = !chkRMAOptions_RootCauses.Checked;
		}

		private void chkRMAType_CheckedChanged(object sender, EventArgs e)
		{
			var rmaTypeCBs = new[] { chkRMAOptions_Unreceived, chkRMAOptions_Received, chkRMAOptions_InProgress, chkRMAOptions_Completed, chkRMAOptions_Pending, chkRMAOptions_Completed, chkRMAOptions_Finalized };
			if (rmaTypeCBs.Any(cb => cb.Checked))
				return;

			MessageBox.Show("At least one RMA type must be checked.", "Invalid RMA Report Option", MessageBoxButtons.OK, MessageBoxIcon.Information);
			chkRMAOptions_Unreceived.Checked = true;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			var dtNow = DateTime.Now;
			SetDateRange(btnShortcut_Week, new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 0, 0, 0).AddDays(-7), new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 23, 59, 59));

			chkAllCustomers.Checked = true;
			chkAllAssets.Checked = true;
			chkAllTechs.Checked = true;

			chkTicketOptions_DurationHours.Checked = false;
			chkTicketOptions_Open.Checked = true;
			chkTicketOptions_Held.Checked = true;
			chkTicketOptions_Closed.Checked = true;
			chkTicketOptions_AllSolutions.Checked = true;
			chkTicketOptions_AllSymptoms.Checked = true;

			chkRMAOptions_Unreceived.Checked = true;
			chkRMAOptions_Received.Checked = true;
			chkRMAOptions_InProgress.Checked = true;
			chkRMAOptions_Pending.Checked = true;
			chkRMAOptions_Completed.Checked = true;
			chkRMAOptions_Finalized.Checked = true;

			chkRMAOptions_AssemblyTypes.Checked = true;
			chkRMAOptions_FailureTypes.Checked = true;
			chkRMAOptions_RepairTypes.Checked = true;
			chkRMAOptions_RootCauses.Checked = true;
		}

		private void lstReportList_DoubleClick(object sender, EventArgs e)
		{
			GenerateReport();
		}
		#endregion

		#region Event Callbacks
		private void TicketReport_ViewTicket(int ticketID)
		{
			ViewTicket?.Invoke(ticketID);
		}

		private void RmaReport_ViewRma(int rmaID)
		{
			ViewRMA?.Invoke(rmaID);
		}
		#endregion
	}
}