using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.Asset;
using SDB.Classes.General;
using System.Reflection;

namespace SDB.Forms.Asset
{
	public partial class FormList_Assets : Form
	{
		public ClassAsset SelectedAsset;

		private List<ClassAsset> _assetList;
		private readonly string _searchTerm;

		private const int _MAX_RESULTS_PER_PAGE = 1000;
		private int _page;
		private int _maxPage;
		private int _assetCount;
		private bool _ignoreStateChange;

		/// <summary>
		/// Holds the time that the list was generated for determining expired warranty/contract formatting.
		/// </summary>
		private DateTime _dtListGenerated;

		public string ReportTitle
		{
			set => lblReportTitle.Text = value;
		}

		public FormList_Assets(List<ClassAsset> customAssetList = null, string searchTerm = null)
		{
			InitializeComponent();

			lblKey_ExpiringSoon.BackColor = ClassAsset.COL_ASSET_EXPIRES_SOON_WC_BG;
			lblKey_Expired.BackColor = ClassAsset.COL_ASSET_EXPIRED_WC_BG;
			toolTip1.SetToolTip(lblKey_ExpiringSoon, $"Expiring within {ClassAsset.EXPIRING_SOON_DAYS} day{ClassAsset.EXPIRING_SOON_DAYS.SIfPlural()}.");
			olvAssets.EmptyListMsg = "Loading...";

			lblReportTitle.Text = string.Empty;

			_assetList = customAssetList;
			_searchTerm = searchTerm;
		}

		private void FormList_Assets_Shown(object sender, EventArgs e)
		{
			if (_assetList != null)
			{
				olvAssets.SetObjects(_assetList);
				txtAssetQty.Text = _assetList.Count.ToString(CultureInfo.InvariantCulture);

				if (string.IsNullOrEmpty(_searchTerm))
					return;

				var filter = TextMatchFilter.Contains(olvAssets, _searchTerm);
				olvAssets.ModelFilter = filter;
				olvAssets.DefaultRenderer = new HighlightTextRenderer(filter);
			}
			else
			{
				PopulateAssetList();
			}
		}

		private async void PopulateAssetList()
		{
			Cursor = Cursors.WaitCursor;
			await LoadAssetsAsync();
			olvAssets.SetObjects(_assetList);
			olvAssets.EmptyListMsg = "No assets found.";
			HandlePagination();
			Cursor = Cursors.Default;
		}

		private Task LoadAssetsAsync()
		{
			return Task.Factory.StartNew(() =>
			                             {
				                             _dtListGenerated = ClassDatabase.GetCurrentTime();
				                             _assetList = ClassAsset.GetAll(_page, _MAX_RESULTS_PER_PAGE, out _assetCount);
				                             _assetList.PopulateExtraProperties();
			                             });
		}

		private void HandlePagination()
		{
			_maxPage = (int)Math.Ceiling(_assetCount / (decimal)_MAX_RESULTS_PER_PAGE) - 1;
			txtAssetQty.Text = _assetCount.ToString(CultureInfo.InvariantCulture);

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
			SelectedAsset = olvAssets.SelectedObject as ClassAsset;
			DialogResult = SelectedAsset == null ? DialogResult.Cancel : DialogResult.OK;
			Close();
		}

		private void olvAssets_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvAssets.SelectedItem == null)
				return;

			SelectedAsset = (ClassAsset)olvAssets.SelectedObject;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void olvAssets_FormatCell(object sender, FormatCellEventArgs e)
		{
			var lineAsset = (ClassAsset)e.Model;

			// RETIRED
			if (lineAsset.IsRetired)
			{
				e.SubItem.ForeColor = ClassAsset.COL_ASSET_RETIRED_FG;
				return;
			}

			// LABOR WARRANTY
			if (e.Column == olcLWExpire)
			{
				if (!lineAsset.WarrantyInfo.LaborWarrantyExpire.HasValue)
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_NOTAPPLICABLE_WC_FG;
				else if (lineAsset.WarrantyInfo.LaborWarrantyExpire.Value.Date < _dtListGenerated.Date)
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRED_WC_BG;
				else if (lineAsset.WarrantyInfo.LaborWarrantyExpire.Value < _dtListGenerated.Date.AddDays(ClassAsset.EXPIRING_SOON_DAYS))
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRES_SOON_WC_BG;
				else
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_VALID_FG;
			}

			// LABOR CONTRACT
			if (e.Column == olcLCExpire)
			{
				if (!lineAsset.WarrantyInfo.LaborContractExpire.HasValue)
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_NOTAPPLICABLE_WC_FG;
				else if (lineAsset.WarrantyInfo.LaborContractExpire.Value.Date < _dtListGenerated.Date)
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRED_WC_BG;
				else if (lineAsset.WarrantyInfo.LaborContractExpire.Value.Date < _dtListGenerated.Date.AddDays(ClassAsset.EXPIRING_SOON_DAYS))
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRES_SOON_WC_BG;
				else
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_VALID_FG;
			}

			// PARTS WARRANTY
			if (e.Column == olcPWExpire)
			{
				if (!lineAsset.WarrantyInfo.PartsWarrantyExpire.HasValue)
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_NOTAPPLICABLE_WC_FG;
				else if (lineAsset.WarrantyInfo.PartsWarrantyExpire.Value.Date < _dtListGenerated.Date)
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRED_WC_BG;
				else if (lineAsset.WarrantyInfo.PartsWarrantyExpire.Value.Date < _dtListGenerated.Date.AddDays(ClassAsset.EXPIRING_SOON_DAYS))
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRES_SOON_WC_BG;
				else
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_VALID_FG;
			}

			// PARTS CONTRACT
			if (e.Column == olcPCExpire)
			{
				if (!lineAsset.WarrantyInfo.PartsContractExpire.HasValue)
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_NOTAPPLICABLE_WC_FG;
				else if (lineAsset.WarrantyInfo.PartsContractExpire.Value.Date < _dtListGenerated.Date)
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRED_WC_BG;
				else if (lineAsset.WarrantyInfo.PartsContractExpire.Value.Date < _dtListGenerated.Date.AddDays(ClassAsset.EXPIRING_SOON_DAYS))
					e.SubItem.BackColor = ClassAsset.COL_ASSET_EXPIRES_SOON_WC_BG;
				else
					e.SubItem.ForeColor = ClassAsset.COL_ASSET_VALID_FG;
			}
		}

		private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;
			_page = (int)cmbPage.SelectedItem - 1;
			PopulateAssetList();
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			_page = 0;
			PopulateAssetList();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			_page--;
			if (_page < 0)
				_page = 0;
			PopulateAssetList();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			_page++;
			if (_page > _maxPage)
				_page = _maxPage;
			PopulateAssetList();
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			_page = _maxPage;
			PopulateAssetList();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			using (var sfd = new SaveFileDialog())
			{
				sfd.FileName = ClassUtility.MakeSafeFileName($"Asset List {DateTime.Now:yyyyMMdd_HHmmss}.csv");
				sfd.Filter = "Comma Separated Values (*.csv)|*.csv";
				sfd.DefaultExt = ".csv";
				sfd.Title = "Export Asset List";
				sfd.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
				if (sfd.ShowDialog() != DialogResult.OK)
					return;

				try
				{
					Cursor = Cursors.WaitCursor;
                    List<ClassAsset> allAssets = new List<ClassAsset>();
                    
                    allAssets.AddRange(olvAssets.FilteredObjects.Cast<ClassAsset>());
                    

                    //foreach(var a in olvAssets.FilteredObjects)
                    //{
                    //    ClassAsset ass = a as ClassAsset;
                    //    ass.PopulateExtraProperties();
                    //    allAssets.Add(ass);
                    //}

                    allAssets.PopulateExtraProperties();

					ClassUtility.ObjectListExport(allAssets, sfd.FileName);
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

		private void FormList_Assets_FormClosing(object sender, FormClosingEventArgs e)
		{
			lblReportTitle.Text = string.Empty;
		}


        
    }
}