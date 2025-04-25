using System;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_Inventory : Form
	{
		public delegate void RMAEvent(int rmaID, FormRMA_Editor.ViewEnum viewType = FormRMA_Editor.ViewEnum.Assemblies);
		public event RMAEvent ViewRMA;

		public FormRMA_Inventory()
		{
			InitializeComponent();

			if (GS.Settings.LoggedOnUser.IsAdmin)
				btnInventory_DeleteEmptyBins.Visible = true;
		}

		private void btnInventory_BinScan_Click(object sender, EventArgs e)
		{
			using (var binScanForm = new FormRMA_BinScan())
				binScanForm.ShowDialog(this);
		}

		private void btnInventory_MoveItems_Click(object sender, EventArgs e)
		{
			using (var moveStuffForm = new FormRMA_MoveStuff())
				moveStuffForm.ShowDialog(this);
		}

		private void btnInventory_View_Click(object sender, EventArgs e)
		{
			using (var inventoryForm = new FormRMA_InventoryView())
				if (inventoryForm.ShowDialog(this) == DialogResult.OK)
					RMA_Load(inventoryForm.SelectedRMA);
		}

		private void btnInventory_DeleteEmptyBins_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will remove all empty bins from the database, proceed?", "Confirm Empty Bin Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			Cursor = Cursors.WaitCursor;
			var deletedQty = ClassRMA_Bin.DeleteAllEmpty();
			var message = $"{deletedQty} empty bins removed.";
			Cursor = Cursors.Default;
			MessageBox.Show(message, "Empty Bins Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnInventory_PrintBinLabels_Click(object sender, EventArgs e)
		{
			using (var binSelectForm = new FormRMA_BinSelect())
			{
				if (binSelectForm.ShowDialog() != DialogResult.OK)
					return;

				var selectedBin = ClassRMA_Bin.GetByName(binSelectForm.SelectedBin);

				ClassRMA_Bin.PrintBinLabels(new[] { selectedBin });
			}
		}

		private void btnInventory_SerialNumberSearch_Click(object sender, EventArgs e)
		{
			using (var snSearchForm = new FormRMA_SerialNumberSearch())
				snSearchForm.ShowDialog(this);
		}

		private void RMA_Load(int rmaID, FormRMA_Editor.ViewEnum viewType = FormRMA_Editor.ViewEnum.Assemblies)
		{
			ViewRMA?.Invoke(rmaID, viewType);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}