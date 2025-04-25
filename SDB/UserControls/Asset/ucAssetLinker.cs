using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.UserControls.Asset
{
	/// <summary>
	/// Given a list of <see cref="ClassAsset"/>s, this control will produce clickable links which raise <see cref="AssetClicked"/> events.
	/// </summary>
	public partial class AssetLinker : UserControl
	{
		public delegate void AssetEvent(int assetID);

		public event AssetEvent AssetClicked;

		private List<ClassAsset> _clickableAssets;

		public AssetLinker()
		{
			InitializeComponent();
			_clickableAssets = new List<ClassAsset>();
		}

		/// <summary>
		/// Clears the control.
		/// </summary>
		public void Clear()
		{
			_clickableAssets.Clear();
			foreach (var l in flpLinkPanel.Controls.Cast<Control>().Where(c => c is LinkLabel))
				l.Click -= l_Click;
			flpLinkPanel.Controls.Clear();
		}

		/// <summary>
		/// Creates clickable links for the specified assets.
		/// </summary>
		public void SetAssetLinks(List<ClassAsset> assets)
		{
			Clear();
			_clickableAssets = assets;
			foreach (var asset in _clickableAssets)
			{
				LinkLabel l = new LinkLabel {Text = asset.AssetName, Tag = asset.ID, AutoSize = true};
				l.Click += l_Click;
				flpLinkPanel.Controls.Add(l);
			}
		}

		void l_Click(object sender, EventArgs e)
		{
			if (AssetClicked == null)
				return;

			var l = (LinkLabel)sender;
			int assetID = (int)l.Tag;
			AssetClicked(assetID);
		}
	}
}