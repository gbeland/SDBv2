using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.Customer;
using SDB.Classes.General;

namespace SDB.Forms.Customer
{
	public partial class FormList_Markets : Form
	{
		private List<ClassMarket> _marketList;
		private readonly string _searchTerm;

		private const int _MAX_RESULTS_PER_PAGE = 1000;
		private int _page;
		private int _maxPage;
		private int _marketCount;
		private bool _ignoreStateChange;

		public ClassMarket SelectedMarket;

		/// <summary>
		/// A list of customer markets. Shows all markets (and the customer) in the database unless a list is provided.
		/// </summary>
		/// <param name="customMarketList">Provided list of markets, such as a search result.</param>
		/// <param name="searchTerm">Term to highlight in results, used in conjunction with a supplied custom list from a search result.</param>
		public FormList_Markets(List<ClassMarket> customMarketList = null, string searchTerm = null)
		{
			InitializeComponent();

			olvMarkets.PrimarySortColumn = olcCustomerName;
			olvMarkets.PrimarySortOrder = SortOrder.Ascending;
			olvMarkets.SecondarySortColumn = olcMarketName;
			olvMarkets.SecondarySortOrder = SortOrder.Ascending;
			olvMarkets.EmptyListMsg = "Loading...";

			_marketList = customMarketList;
			_searchTerm = searchTerm;
		}

		private void FormList_Markets_Shown(object sender, EventArgs e)
		{
			if (_marketList != null)
			{
				olvMarkets.SetObjects(_marketList);
				txtMarketQty.Text = _marketList.Count.ToString(CultureInfo.InvariantCulture);

				if (string.IsNullOrEmpty(_searchTerm))
					return;

				var filter = TextMatchFilter.Contains(olvMarkets, _searchTerm);
				olvMarkets.ModelFilter = filter;
				olvMarkets.DefaultRenderer = new HighlightTextRenderer(filter);
			}
			else
			{
				PopulateMarketList();
			}
		}

		private async void PopulateMarketList()
		{
			Cursor = Cursors.WaitCursor;
			await LoadMarketsAsync();
			olvMarkets.SetObjects(_marketList);
			olvMarkets.EmptyListMsg = "No markets found.";
			HandlePagination();
			Cursor = Cursors.Default;
		}

		private Task LoadMarketsAsync()
		{
			return Task.Factory.StartNew(() => { _marketList = ClassMarket.GetAll(_page, _MAX_RESULTS_PER_PAGE, out _marketCount); });
		}

		private void HandlePagination()
		{
			_maxPage = (int)Math.Ceiling(_marketCount / (decimal)_MAX_RESULTS_PER_PAGE) - 1;
			txtMarketQty.Text = _marketCount.ToString(CultureInfo.InvariantCulture);

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

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SelectedMarket = olvMarkets.SelectedObject as ClassMarket;
			DialogResult = SelectedMarket == null ? DialogResult.Cancel : DialogResult.OK;
			Close();
		}

		private void olvMarkets_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvMarkets.SelectedItem == null)
				return;

			SelectedMarket = (ClassMarket)olvMarkets.SelectedObject;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			using (var sfd = new SaveFileDialog())
			{
				sfd.FileName = ClassUtility.MakeSafeFileName($"Market List {DateTime.Now:yyyyMMdd_HHmmss}.csv");
				sfd.Filter = "Comma Separated Values (*.csv)|*.csv";
				sfd.DefaultExt = ".csv";
				sfd.Title = "Export Market List";
				sfd.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
				if (sfd.ShowDialog() != DialogResult.OK)
					return;

				try
				{
					Cursor = Cursors.WaitCursor;
					var allMarkets = ClassMarket.GetAll(null, int.MaxValue, out var _).ToList();

					ClassUtility.ObjectListExport(allMarkets, sfd.FileName);
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

		private void olvMarkets_FormatCell(object sender, FormatCellEventArgs e)
		{
			if (e.ColumnIndex != olcCustomerName.Index && e.ColumnIndex != olcMarketName.Index)
				return;

			var m = (ClassMarket)e.Model;
			e.SubItem.ForeColor = m.StatusColor;
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			_page = 0;
			PopulateMarketList();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			_page--;
			if (_page < 0)
				_page = 0;
			PopulateMarketList();
		}

		private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			_page = (int)cmbPage.SelectedItem - 1;
			PopulateMarketList();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			_page++;
			if (_page > _maxPage)
				_page = _maxPage;
			PopulateMarketList();
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			_page = _maxPage;
			PopulateMarketList();
		}
	}
}