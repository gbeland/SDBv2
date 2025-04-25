using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Customer;

namespace SDB.Forms.Customer
{
	public partial class FormMarket_Select : Form
	{
		public int SelectedMarket = -1;
		private int? _initialMarketID;

		public FormMarket_Select(int? preselectedMarketID = null)
		{
			InitializeComponent();

			_initialMarketID = preselectedMarketID;
		}

		private void FormMarketList_Load(object sender, EventArgs e)
		{
			tvMarketList.BeginUpdate();
			PopulateMarketTree();
			tvMarketList.EndUpdate();

			if (!_initialMarketID.HasValue)
				return;

			var initialMarketNode = FindTreeNode(_initialMarketID.Value);
			if (initialMarketNode == null)
				return;

			initialMarketNode.EnsureVisible();
			tvMarketList.SelectedNode = initialMarketNode;
		}

		/// <summary>
		/// Finds the treenode with tag matching specified int value.
		/// </summary>
		private TreeNode FindTreeNode(int tagIntValue)
		{
			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (TreeNode tn0 in tvMarketList.Nodes)
				foreach (TreeNode tn1 in tn0.Nodes)
					if (tn1.Tag is int i && i == tagIntValue)
						return tn1;
			return null;
			// ReSharper restore LoopCanBeConvertedToQuery
		}

		private void PopulateMarketTree()
		{
			var allCustomers = ClassCustomer.GetCustomers().ToList();
			foreach (var customer in allCustomers)
			{
				var customerNode = new TreeNode(customer.DisplayMember)
				{
					NodeFont = new Font(tvMarketList.Font, FontStyle.Bold),
					ForeColor = customer.IsFrozen ? Color.Red : SystemColors.ControlText,
					Tag = customer.ID
				};
				tvMarketList.Nodes.Add(customerNode);

				foreach (var market in customer.Markets)
				{
					var marketNode = new TreeNode(market.DisplayMember)
					{
						ForeColor = customer.IsFrozen ? Color.Red : SystemColors.ControlText,
						Tag = market.ID
					};
					customerNode.Nodes.Add(marketNode);
				}
			}
		}

		private void tvMarketList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			SelectAndClose();
		}

		private void btnMarketList_OK_Click(object sender, EventArgs e)
		{
			SelectAndClose();
		}

		private void SelectAndClose()
		{
			if (tvMarketList.SelectedNode == null || tvMarketList.SelectedNode.Nodes.Count != 0)
				return;
			SelectedMarket = (int)tvMarketList.SelectedNode.Tag;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnMarketList_Cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}