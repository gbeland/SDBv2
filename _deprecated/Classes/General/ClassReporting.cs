using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.RMA;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using ZedGraph;

namespace SDB.Classes.General
{
	public static class ClassReporting
	{
		#region Private Vars
		private const int _MAX_BAR_GROUPS = 16;
		// ReSharper disable InconsistentNaming
		private static readonly List<Color> SYMPTOM_COLOR_LIST = new List<Color>
		{
			Color.Red,
			Color.DarkOrange,
			Color.Gold,
			Color.LimeGreen,
			Color.Blue,
			Color.BlueViolet,
			Color.Violet,

			Color.DarkRed,
			Color.Chocolate,
			Color.Goldenrod,
			Color.Green,
			Color.DarkBlue,
			Color.Indigo,
			Color.Purple,

			Color.Cyan,
			Color.Magenta,
			Color.Yellow,
			Color.Black,

			Color.DimGray,
			Color.Gray,
			Color.DarkGray,
			Color.LightGray
		};
		// ReSharper restore InconsistentNaming
		#endregion

		#region Private Classes
		private class ClassSymptomTrendGroup
		{
			public DateTime InitialGroupDate { get; set; }
			public List<ClassTicket_Symptom> Symptoms { get; private set; }
			public DateTime DateRangeStart { get; set; }
			public DateTime DateRangeEnd { get; set; }

			public ClassSymptomTrendGroup()
			{
				InitialGroupDate = DateTime.MinValue;
				DateRangeStart = DateTime.MinValue;
				DateRangeEnd = DateTime.MinValue;
				Symptoms = new List<ClassTicket_Symptom>();
			}
		}
		#endregion

		#region Public Classes Etc
		/// <summary>
		/// List of reports by type. (Each type is generated a unique way.)
		/// </summary>
		public enum ReportTypeEnum
		{
			SymptomGraph, SymptomTable, SymptomTrend, SymptomTrendLine,
			Tickets, RMAs,
			MissingLaborWC, MissingPartsWC, OutOfDateWC
		};

		/// <summary>
		/// Logical grouping of reports by object type or subject.
		/// </summary>
		public enum ReportGroupEnum
		{
			Symptom, Ticket, RMA, Accounting
		};

		/// <summary>
		/// Object that represents a unique report element.
		/// </summary>
		public class ClassReportElement
		{
			/// <summary>
			/// The name of the report shown to users.
			/// </summary>
			public string ReportName;
			/// <summary>
			/// Determines how the report is generated and shown.
			/// </summary>
			public ReportTypeEnum ReportType;
			/// <summary>
			/// Determines which selection group the report appears in.
			/// </summary>
			public ReportGroupEnum ReportGroup;

			public bool UsesDateRangeFilter;
			public bool UsesCustomerFilter;
			public bool UsesAssetFilter;
			public bool UsesTechFilter;
			public bool UsesTicketOptions;
			public bool UsesRMAOptions;

			/// <summary>
			/// A text description of the report and its purpose.
			/// </summary>
			public string Description;

			public override string ToString()
			{
				return ReportName;
			}
		}

		/// <summary>
		/// Object that represents a request for a report with all its arguments.
		/// </summary>
		public class ClassReportRequestObject
		{
			public ClassReportElement ReportElement;
			public List<ClassCustomer> Customers;
			public List<ClassAsset> Assets;
			public List<ClassTech> Techs;
			public DateTime? OpenFrom;
			public DateTime? OpenTo;
			public ClassTicketReportOptions TicketReportOptions;
			public ClassRMAReportOptions RMAReportOptions;

			public string ReportTitle_SingleLine
			{
				get
				{
					var filters = new List<string>();

					if (Customers.Count == 1)
						filters.Add(Customers[0].Name);
					if (Customers.Count > 1)
						filters.Add("Multiple Customers");
					if (Assets.Count == 1)
						filters.Add(Assets[0].AssetName);
					if (Assets.Count > 1)
						filters.Add("Multiple Assets");
					if (Techs.Count == 1)
						filters.Add(Techs[0].TechName);
					if (Techs.Count > 1)
						filters.Add("Multiple Techs");

					var sb = new StringBuilder();
					sb.AppendFormat("{0}{1}{2} ", ReportElement.ReportName, filters.Count > 0 ? ": " : string.Empty, string.Join(", ", filters.ToArray()));
					sb.AppendFormat("{0:yyyy-MM-dd} to {1:yyyy-MM-dd}", OpenFrom, OpenTo);
					return sb.ToString();
				}
			}

			public string ReportTitle_MultiLine
			{
				get
				{
					var sb = new StringBuilder();
					sb.AppendLine(ReportElement.ReportName);
					if (Customers.Count == 1)
						sb.AppendLine(Customers[0].Name);
					if (Customers.Count > 1)
						sb.AppendLine("multiple Customers");
					if (Assets.Count == 1)
						sb.AppendLine(Assets[0].AssetName);
					if (Assets.Count > 1)
						sb.AppendLine("Multiple Assets");
					if (Techs.Count == 1)
						sb.AppendLine(Techs[0].TechName);
					if (Techs.Count > 1)
						sb.AppendLine("Multiple Techs");
					sb.AppendFormat("{0:yyyy-MM-dd} to {1:yyyy-MM-dd}", OpenFrom, OpenTo).AppendLine();
					return sb.ToString();
				}
			}

			public string FileName => $"{ReportElement.ReportName} ({OpenFrom:yyyy-MM-dd} to {OpenTo:yyyy-MM-dd})";

			public override string ToString()
			{
				return ReportElement.ReportName;
			}

			public class ClassTicketReportOptions
			{
				public bool IsOpenDurationFiltered;
				public int OpenDuration_Hours;
				public bool IncludeOpen;
				public bool IncludeHeld;
				public bool IncludeClosed;
				public bool IsSymptomsFiltered;
				public bool IsSolutionsFiltered;
				public readonly ClassFilters Filters = new ClassFilters();

				public class ClassFilters
				{
					public List<ClassTicket_Symptom> Symptoms;
					public List<ClassTicket_Solution> Solutions;
				}
			}

			public class ClassRMAReportOptions
			{
				public bool IncludeUnreceived;
				public bool IncludeReceived;
				public bool IncludeInProgress;
				public bool IncludePending;
				public bool IncludeCompleted;
				public bool IncludeFinalized;
				public bool IsAssemblyTypeFiltered;
				public bool IsFailureTypeFiltered;
				public bool IsRepairTypeFiltered;
				public bool IsRootCauseFiltered;

				public readonly ClassFilters Filters = new ClassFilters();

				public class ClassFilters
				{
					public List<ClassAssemblyType> AssemblyTypes;
					public List<ClassRMA_FailureType> FailureTypes;
					public List<ClassRMA_RepairType> RepairTypes;
					public List<ClassRMA_RootCause> RootCauses;
				}
			}
		}

		public static readonly List<ClassReportElement> ALL_REPORTS = new List<ClassReportElement>
			{
				//new ClassReportElement
				//{
				//	ReportName = "Symptoms Graph",
				//	ReportType = ReportTypeEnum.SymptomGraph,
				//	UsesCustomerFilter = true,
				//	UsesAssetFilter = true,
				//	UsesDateRangeFilter = true,
				//	UsesTechFilter = true,
				//	ReportGroup = ReportGroupEnum.Symptom,
				//	Description = "Shows the number of symptoms cited in tickets opened within the specified date range."
				//},
				new ClassReportElement
				{
					ReportName = "Symptoms Table",
					ReportType = ReportTypeEnum.SymptomTable,
					UsesCustomerFilter = true,
					UsesAssetFilter = true,
					UsesDateRangeFilter = true,
					UsesTechFilter = true,
					ReportGroup = ReportGroupEnum.Symptom,
					Description = "Shows the number of symptoms cited in tickets opened within the specified date range."
				},
				new ClassReportElement 
				{
					ReportName = "Symptom Trend Graph, By Install Date",
					ReportType = ReportTypeEnum.SymptomTrend, 
					UsesCustomerFilter = true,
					UsesAssetFilter = true,
					UsesDateRangeFilter = true,
					UsesTechFilter = true,
					ReportGroup = ReportGroupEnum.Symptom,
					Description = "Shows how much each symptom contributes to tickets created in the specified date range, broken up into groups of assets by their installation date."
				},
				new ClassReportElement 
				{
					ReportName = "Symptom Trend Graph, By Ticket Date",
					ReportType = ReportTypeEnum.SymptomTrendLine, 
					UsesCustomerFilter = true,
					UsesAssetFilter = true,
					UsesDateRangeFilter = true,
					UsesTechFilter = true,
					UsesTicketOptions = true,
					ReportGroup = ReportGroupEnum.Symptom,
					Description = "Shows how much each symptom contributes to tickets created each day, for tickets created in the specified date range."
				},
				new ClassReportElement
				{
					ReportName = "Tickets",
					ReportType = ReportTypeEnum.Tickets,
					UsesCustomerFilter = true,
					UsesAssetFilter = true,
					UsesDateRangeFilter = true,
					UsesTechFilter = true,
					UsesTicketOptions = true,
					ReportGroup = ReportGroupEnum.Ticket,
					Description = "Shows ticket details for the specified criteria, where the ticket was created in the specified date range."
				},
				new ClassReportElement
				{
					ReportName = "RMAs",
					ReportType = ReportTypeEnum.RMAs,
					UsesCustomerFilter = true,
					UsesAssetFilter = true,
					UsesDateRangeFilter = true,
					UsesTechFilter = true,
					UsesTicketOptions = false,
					UsesRMAOptions = true,
					ReportGroup = ReportGroupEnum.RMA,
					Description = "Shows RMA details for the specified criteria, where the RMA was created in the specified date range."
				},
				new ClassReportElement
				{
					ReportName = "Missing Labor Warranty/Contracts",
					ReportType = ReportTypeEnum.MissingLaborWC,
					UsesCustomerFilter = true,
					UsesAssetFilter = false,
					UsesDateRangeFilter = true,
					UsesTechFilter = false,
					UsesTicketOptions = false,
					ReportGroup = ReportGroupEnum.Accounting,
					Description = "Shows assets which do not have a labor warranty/contract, where the asset was installed within the specified date range."
				},
				new ClassReportElement
				{
					ReportName = "Missing Parts Warranty/Contracts",
					ReportType = ReportTypeEnum.MissingPartsWC,
					UsesCustomerFilter = true,
					UsesAssetFilter = false,
					UsesDateRangeFilter = true,
					UsesTechFilter = false,
					UsesTicketOptions = false,
					ReportGroup = ReportGroupEnum.Accounting,
					Description = "Shows assets which do not have a parts warranty/contract, where the asset was installed within the specified date range."
				},
				new ClassReportElement 
				{
					ReportName = "Out of Date Contracts",
					ReportType = ReportTypeEnum.OutOfDateWC,
					UsesCustomerFilter = true,
					UsesAssetFilter = false,
					UsesDateRangeFilter = true,
					UsesTechFilter = false,
					UsesTicketOptions = false,
					ReportGroup = ReportGroupEnum.Accounting,
					Description = "Shows assets for which labor/parts warranty/contract expires within the specified time frame."
				}
			};

		public class ClassSymptomCount
		{
			public ClassTicket_Symptom Symptom { get; set; }
			public int Quantity { get; set; }

			public override string ToString()
			{
				return string.Format("{0} {1}", Quantity, Symptom.Symptom);
			}
		}
		#endregion

		private static IEnumerable<ClassSymptomCount> GetSymptomsInDateRange(ClassReportRequestObject reportRequest)
		{
			var symptomTypes = ClassTicket_Symptom.GetAll().ToList();
			var symptomCountSet = symptomTypes.Select(sy => new ClassSymptomCount { Symptom = sy, Quantity = 0 }).ToList();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						string.Format(@"SELECT ts.symptom_id
						FROM tickets t
						JOIN assets a ON t.asset_id = a.id
						JOIN markets m ON a.market_id = m.id
						JOIN customers c on m.customer_id = c.id
						LEFT JOIN ticket_symptoms ts ON t.id = ts.ticket_id
						LEFT JOIN techs h ON t.tech_id = h.id
						WHERE t.deleted = FALSE
						{0}
						{1}
						{2}
						{3}
						{4};",
							reportRequest.Customers.Count > 0 ? @"AND c.id IN (@CustomerID)" : string.Empty,
							reportRequest.Assets.Count > 0 ? @"AND t.asset_id IN (@AssetID)" : string.Empty,
							reportRequest.Techs.Count > 0 ? @"AND h.id IN (@TechID)" : string.Empty,
							reportRequest.OpenFrom.HasValue ? @"AND t.open_dt >= @DtFrom" : string.Empty,
							reportRequest.OpenTo.HasValue ? @"AND t.open_dt <= @DtTo" : string.Empty);
					if (reportRequest.OpenFrom.HasValue)
						cmd.Parameters.AddWithValue("DtFrom", reportRequest.OpenFrom);
					if (reportRequest.OpenTo.HasValue)
						cmd.Parameters.AddWithValue("DtTo", reportRequest.OpenTo);
					cmd.Parameters.AddWithValue("CustomerID", reportRequest.Customers.Count > 0 ? string.Join(",", reportRequest.Customers.Select(c => c.ID).ToArray()) : string.Empty);
					cmd.Parameters.AddWithValue("AssetID", reportRequest.Assets.Count > 0 ? string.Join(",", reportRequest.Assets.Select(a => a.ID).ToArray()) : string.Empty);
					cmd.Parameters.AddWithValue("TechID", reportRequest.Techs.Count > 0 ? string.Join(",", reportRequest.Techs.Select(t => t.ID).ToArray()) : string.Empty);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.HasRows)
							while (reader.Read())
								symptomCountSet.Single(s => s.Symptom.ID == reader.GetDBInt("symptom_id")).Quantity++;
					}
					conn.Close();
				}
			}
			return symptomCountSet;
		}

		/// <summary>
		/// Generate a graph of problems (ticket symptoms) within specified date range.
		/// </summary>
		public static bool Report_SymptomGraph(ref ZedGraphControl zgc, ClassReportRequestObject reportRequest)
		{
			var symptomCountSet = GetSymptomsInDateRange(reportRequest).ToList();
			if (symptomCountSet.Count < 1)
				return false;
			var labels = symptomCountSet.Select(s => s.Symptom.Symptom).ToArray();

			var graph = zgc;
			graph.IsShowPointValues = true;

			var pane = graph.GraphPane;
			pane.Title.Text = reportRequest.ReportTitle_MultiLine;
			//pane.Title.Text = string.Format("All Symptoms{0}from {1:yyyy-MM-dd} to {2:yyyy-MM-dd}", Environment.NewLine, ReportRequest.DateFrom, ReportRequest.DateTo);
			//if (ReportRequest.Customer != null)
			//    pane.Title.Text += Environment.NewLine + ReportRequest.Customer.Name;
			//if (ReportRequest.Asset != null)
			//    pane.Title.Text += Environment.NewLine + ReportRequest.Asset.AssetName;
			pane.IsFontsScaled = false;
			pane.BarSettings.Type = BarType.Overlay;

			// Y AXIS
			pane.YAxis.Title.Text = "Quantity";
			pane.YAxis.MajorGrid.IsVisible = true;

			// X AXIS
			pane.XAxis.Title.Text = "Symptoms";
			pane.XAxis.Scale.TextLabels = labels;
			pane.XAxis.Scale.MajorStepAuto = false;
			pane.XAxis.Type = AxisType.Text;
			pane.XAxis.MajorTic.IsBetweenLabels = true;
			pane.XAxis.Scale.FontSpec.Size = 12;
			pane.XAxis.Scale.FontSpec.Angle = 90;
			pane.XAxis.Scale.Align = AlignP.Inside;

			for (var i = 0; i < symptomCountSet.Count(); i++)
			{
				var sc = symptomCountSet[i];
				var barColor = SYMPTOM_COLOR_LIST[i % SYMPTOM_COLOR_LIST.Count];
				var vals = new double[i + 1];
				vals[i] = sc.Quantity;
				var symptomBar = pane.AddBar(string.Empty, null, vals, barColor);
				symptomBar.Bar.Fill.Type = FillType.Solid;
			}
			return true;
		}

		public static IEnumerable<ClassSymptomCount> Report_Symptoms(ClassReportRequestObject reportRequest)
		{
			return GetSymptomsInDateRange(reportRequest).ToList();
		}

		/// <summary>
		/// For a given date range, for a specified company (or all companies if none), show symptom counts grouped by asset install date.
		/// </summary>
		/// <returns>A stacked bar graph.</returns>
		public static bool Report_SymptomTrendGraph(ref ZedGraphControl zgc, ClassReportRequestObject reportRequest)
		{
			return false;

			//#region Data Prep
			//// Get ticket IDs for the specified date range, filter by customer if specified
			//List<int> ticketIDList = ClassTicket.GetIDs_ByDateRange(reportRequest).ToList();
			//if (ticketIDList.Count < 1)
			//	return false;

			//var symptomTypes = ClassTicket_Symptom.GetAll().ToList();
			//var symptomsPerInstallDate = new List<ClassSymptomTrendGroup>();
			//var symptomsPerInstallDateRange = new List<ClassSymptomTrendGroup>();

			//using (var conn = ClassDatabase.CreateMySqlConnection())
			//{
			//	using (var cmd = conn.CreateCommand())
			//	{
			//		conn.Open();
			//		// For each ticket ID, get the symptoms and asset installation date
			//		cmd.CommandText =
			//			string.Format(@"SELECT ts.symptom_id, a.install_dt
			//			FROM tickets t
			//				JOIN assets a ON t.asset_id = a.id
			//				LEFT JOIN ticket_symptoms ts ON ts.ticket_id = t.id
			//				LEFT JOIN techs h ON t.tech_id = h.id
			//			WHERE t.id IN ({0})
			//			ORDER BY a.install_dt ASC;", string.Join(",", ticketIDList));
			//		using (var reader = cmd.ExecuteReader())
			//		{
			//			if (reader.HasRows)
			//				while (reader.Read())
			//				{
			//					var thisInstallDate = reader.GetDBDateTime("install_dt", DateTime.Today);
			//					var cst = symptomsPerInstallDate.SingleOrDefault(spi => spi.InitialGroupDate == thisInstallDate);
			//					if (cst == null)
			//					{
			//						cst = new ClassSymptomTrendGroup { InitialGroupDate = thisInstallDate };
			//						symptomsPerInstallDate.Add(cst);
			//					}
			//					cst.Symptoms.Add(symptomTypes.Single(s => s.ID == reader.GetDBInt("symptom_id")));
			//				}
			//		}
			//		// Now we have a list of installation dates and associated symptoms list
			//		// Combine dates so that MAX_BAR_GROUPS exist
			//		var installDateFirst = symptomsPerInstallDate.Min(s => s.InitialGroupDate);
			//		var installDateLast = symptomsPerInstallDate.Max(s => s.InitialGroupDate);
			//		var installDateSpan = installDateLast - installDateFirst;
			//		var perGroupSpan = TimeSpan.FromDays(installDateSpan.TotalDays / _MAX_BAR_GROUPS);
			//		for (var i = 0; i < _MAX_BAR_GROUPS; i++)
			//		{
			//			symptomsPerInstallDateRange.Add(new ClassSymptomTrendGroup
			//			{
			//				DateRangeStart = installDateFirst.AddDays(perGroupSpan.TotalDays * i),
			//				DateRangeEnd = installDateFirst.AddDays(perGroupSpan.TotalDays * (i + 1))
			//			});
			//		}
			//		foreach (var cstRange in symptomsPerInstallDateRange)
			//		{
			//			var cstGroup = cstRange;
			//			foreach (var cst in symptomsPerInstallDate.Where(c => c.InitialGroupDate >= cstGroup.DateRangeStart && c.InitialGroupDate < cstGroup.DateRangeEnd))
			//				cstGroup.Symptoms.AddRange(cst.Symptoms);
			//		}
			//		conn.Close();
			//	}
			//}
			//#endregion
			//var labels = symptomsPerInstallDateRange.Select(s => string.Format("{0:yyyy-MM-dd} to{1}{2:yyyy-MM-dd}", s.DateRangeStart, Environment.NewLine, s.DateRangeEnd)).ToArray();

			//var graph = zgc;
			//graph.PointValueEvent += graph_PointValueEvent;
			//graph.IsShowPointValues = true;
			//var pane = graph.GraphPane;
			//pane.Title.Text = reportRequest.ReportTitle_MultiLine;

			//pane.BarSettings.Type = BarType.Stack;
			//pane.IsFontsScaled = false;

			//// Y AXIS
			//pane.YAxis.Title.Text = "Symptom Count";
			//pane.YAxis.MajorGrid.IsVisible = true;
			//pane.YAxis.Scale.MajorStepAuto = true;

			//// X AXIS
			//pane.XAxis.Title.Text = "Installation Dates";
			//pane.XAxis.Scale.TextLabels = labels;
			//pane.XAxis.Scale.MajorStepAuto = false;
			//pane.XAxis.Type = AxisType.Text;
			//pane.XAxis.MajorTic.IsBetweenLabels = true;
			//pane.XAxis.Scale.FontSpec.Size = 12;
			//pane.XAxis.Scale.FontSpec.Angle = 90;

			//for (var i = 0; i < symptomTypes.Count; i++)
			//{
			//	var sym = symptomTypes[i];
			//	var symCount = new List<double>();
			//	// ReSharper disable LoopCanBeConvertedToQuery
			//	foreach (var cst in symptomsPerInstallDateRange)
			//		symCount.Add(cst.Symptoms.Count(s => s.ID == sym.ID));
			//	// ReSharper restore LoopCanBeConvertedToQuery
			//	var barColor = SYMPTOM_COLOR_LIST[i % SYMPTOM_COLOR_LIST.Count];
			//	var myBar = pane.AddBar(sym.Symptom, null, symCount.ToArray(), barColor);
			//	myBar.Bar.Fill.Type = FillType.Solid;
			//}

			//return true;
		}

		/// <summary>
		/// Builds a line graph that shows symptoms present in tickets opened during the specified date range.
		/// </summary>
		public static bool Report_SymptomTrendGraph2(ref ZedGraphControl zgc, ClassReportRequestObject reportRequest)
		{
			#region Data Prep
			var symptomTypes = ClassTicket_Symptom.GetAll().ToList();
			var ticketGroups = new List<ClassSymptomTrendGroup>();
			var symptomGroups = new List<ClassSymptomTrendGroup>();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					// For each ticket ID, get the symptoms
					cmd.CommandText =
						string.Format(@"SELECT t.open_dt ticket_date, ts.symptom_id
						FROM tickets t
							LEFT JOIN ticket_symptoms ts ON ts.ticket_id = t.id
						WHERE TRUE
						{0}
						{1}
						{2};",
							 reportRequest.OpenFrom.HasValue ? @"AND t.open_dt >= @DateFrom" : string.Empty,
							 reportRequest.OpenTo.HasValue ? @"AND t.open_dt <= @DateTo" : string.Empty,
							 reportRequest.TicketReportOptions.IsSymptomsFiltered ?
								string.Format(@"AND ts.symptom_id IN ({0})", string.Join(",", reportRequest.TicketReportOptions.Filters.Symptoms.Select(s => s.ID).ToArray())) :
								string.Empty);
					if (reportRequest.OpenFrom.HasValue)
						cmd.Parameters.AddWithValue("DateFrom", reportRequest.OpenFrom);
					if (reportRequest.OpenTo.HasValue)
						cmd.Parameters.AddWithValue("DateTo", reportRequest.OpenTo);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var grp = new ClassSymptomTrendGroup();
							grp.InitialGroupDate = reader.GetDateTime("ticket_date");
							var thisSymptom = reader.GetDBInt("symptom_id");
							grp.Symptoms.Add(symptomTypes.Single(st => st.ID == thisSymptom));
							ticketGroups.Add(grp);
						}

					// Now we have a list of dates and symptoms
					// Combine dates so that one group per day exists
					var dateFirst = ticketGroups.Min(s => s.InitialGroupDate).Date;
					var dateLast = ticketGroups.Max(s => s.InitialGroupDate).Date;
					var totalDays = (int)Math.Ceiling((dateLast - dateFirst).TotalDays);
					// Construct groups on a per-day basis
					for (var i = 0; i < totalDays; i++)
					{
						var grp = new ClassSymptomTrendGroup();
						grp.InitialGroupDate = dateFirst.AddDays(i);
						grp.Symptoms.AddRange(ticketGroups.Where(tg => tg.InitialGroupDate.Date == grp.InitialGroupDate).SelectMany(tg => tg.Symptoms));
						symptomGroups.Add(grp);
					}
					conn.Close();
				}
			}
			#endregion

			var graph = zgc;
			graph.PointValueEvent += graph_PointValueEvent2;
			graph.IsShowPointValues = true;
			var pane = graph.GraphPane;
			pane.Title.Text = reportRequest.ReportTitle_MultiLine;
			pane.LineType = LineType.Normal;
			pane.IsFontsScaled = false;

			// Y AXIS
			pane.YAxis.Title.Text = "Symptoms";
			pane.YAxis.MajorGrid.IsVisible = true;
			pane.YAxis.Scale.MajorStepAuto = true;

			// X AXIS
			pane.XAxis.Title.Text = "Ticket Dates";
			pane.XAxis.Type = AxisType.Date;

			pane.XAxis.Scale.MajorStepAuto = false;
			pane.XAxis.Scale.MajorStep = 1;
			pane.XAxis.MajorTic.IsBetweenLabels = true;
			pane.XAxis.Scale.FontSpec.Size = 12;
			pane.XAxis.Scale.FontSpec.Angle = 90;
			pane.XAxis.Scale.MinGrace = 0;
			pane.XAxis.Scale.MaxGrace = 0;

			for (var i = 0; i < symptomTypes.Count; i++)
			{
				var sym = symptomTypes[i];
				var symCount = new List<double>();
				var ticketDates = new List<double>();
				foreach (var cst in symptomGroups)
				{
					symCount.Add(cst.Symptoms.Count(s => s.ID == sym.ID));
					ticketDates.Add(new XDate(cst.InitialGroupDate));
				}
				var barColor = SYMPTOM_COLOR_LIST[i % SYMPTOM_COLOR_LIST.Count];
				var myLine = pane.AddCurve(sym.Symptom, ticketDates.ToArray(), symCount.ToArray(), barColor, SymbolType.None);
				myLine.Line.Width = 2;
				myLine.Line.Fill = new Fill(new SolidBrush(Color.FromArgb(50, barColor)));
				myLine.Line.IsSmooth = true;
				myLine.Line.SmoothTension = 0.1F;
			}

			return true;
		}

		private static string graph_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
		{
			return string.Format("Symptom: {0}{2}Qty: {1}", curve.Label.Text, curve[iPt].Y, Environment.NewLine);
		}

		private static string graph_PointValueEvent2(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
		{
			return string.Format("Symptom: {1}{0}Qty: {2}{0}Date: {3}", Environment.NewLine, curve.Label.Text, curve[iPt].Y, ((XDate)curve[iPt].X).DateTime);
		}
	}
}
