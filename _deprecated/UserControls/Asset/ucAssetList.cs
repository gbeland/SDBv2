using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.UserControls.Asset
{
	public partial class ucAssetList : UserControl
	{
		public delegate void AssetEvent(int assetID);

		public event AssetEvent ViewAsset;

		[Description("Text displayed in list when no items are present.")]
		public string EmptyListMessage
		{
			get => olvAssets.EmptyListMsg;
			set { olvAssets.EmptyListMsg = value; }
		}

		public ucAssetList()
		{
			InitializeComponent();

			olvAssets.PrimarySortColumn = olvColAsset;
			olvAssets.PrimarySortOrder = SortOrder.Ascending;
		}

		public void SetObjects<T>(List<T> collection)
		{
			olvAssets.SetObjects(collection);
			txtAssetQty.Text = collection.Count.ToString();
		}

		public void Clear()
		{
			olvAssets.SetObjects(null);
			txtAssetQty.Clear();
		}

		private void olvAssets_DoubleClick(object sender, EventArgs e)
		{
			if (ViewAsset!=null)
				ViewAsset(((ClassAsset)olvAssets.SelectedObject).ID);
		}

		private void olvAssets_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
		{
			var lineAsset = (ClassAsset)e.Model;
			
			// RETIRED
			if (lineAsset.IsRetired)
			{
				e.SubItem.ForeColor = ClassAsset.COL_ASSET_RETIRED_FG;
				return;
			}
		}
	}
}