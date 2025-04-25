using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Asset;
using SDB.Forms.Asset;

namespace SDB.UserControls.Asset
{
	public partial class ucAssetSpareParts : UserControl
	{
		private ClassAsset _asset;
		private List<ClassSparePart> _spares;

		public ucAssetSpareParts()
		{
			InitializeComponent();
		}

		public void SetAsset(ClassAsset asset)
		{
			_asset = asset;
			Populate();
		}

		private void Populate()
		{
			_spares = ClassSparePart.GetByAsset(_asset.ID).ToList();
			olvSpareParts.SetObjects(_spares);
		}

		public void Clear()
		{
			_asset = null;
			olvSpareParts.SetObjects(null);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (_asset.IsRetired)
			{
				MessageBox.Show("This asset has been retired.", "Retired Asset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			using (var spareForm = new FormAsset_SparePartAddEdit(true))
			{
				if (spareForm.ShowDialog() != DialogResult.OK)
					return;

				try
				{
					ClassSparePart.AddNew(_asset.ID, spareForm.SparePart);
				}
				catch (MySqlException mexc)
				{
					var errorMessage = string.Format("Cannot add spare part. Is it a duplicate?{0}{0}{1}", Environment.NewLine, mexc.Message);
					MessageBox.Show(errorMessage, "Error Adding Spare Part", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			Populate();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			ClassSparePart selectedSpare = (ClassSparePart)olvSpareParts.SelectedObject;
			if (selectedSpare == null)
				return;

			string confirmMessage = string.Format("Are you sure you want to remove Spare Part '{0}'?", selectedSpare.Assembly.Description);
			if (MessageBox.Show(confirmMessage, "Confirm Remove Spare Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			ClassSparePart.Remove(_asset.ID, selectedSpare);
			Populate();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			ClassSparePart selectedSpare = (ClassSparePart)olvSpareParts.SelectedObject;
			if (selectedSpare == null)
				return;

			SparePart_Edit(selectedSpare);
		}

		private void olvSpareParts_DoubleClick(object sender, EventArgs e)
		{
			ClassSparePart selectedSpare = (ClassSparePart)olvSpareParts.SelectedObject;
			if (selectedSpare == null)
				return;

			SparePart_Edit(selectedSpare);
		}

		private void SparePart_Edit(ClassSparePart sparePart)
		{
			using (FormAsset_SparePartAddEdit spareForm = new FormAsset_SparePartAddEdit(true))
			{
				int originalAssemblyID = sparePart.Assembly.ID;
				spareForm.SparePart = sparePart;
				if (spareForm.ShowDialog() != DialogResult.OK)
					return;

				try
				{
					ClassSparePart.Update(_asset.ID, originalAssemblyID, spareForm.SparePart);
				}
				catch (MySqlException mexc)
				{
					string errorMessage = string.Format("Cannot update spare part. Is it a duplicate?{0}{0}{1}", Environment.NewLine, mexc.Message);
					MessageBox.Show(errorMessage, "Error Editing Spare Part", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			Populate();
		}

		private void btnIncrement_Click(object sender, EventArgs e)
		{
			ClassSparePart selectedSpare = (ClassSparePart)olvSpareParts.SelectedObject;
			SparePart_AddQuantity(selectedSpare, 1);
		}

		private void btnDecrement_Click(object sender, EventArgs e)
		{
			ClassSparePart selectedSpare = (ClassSparePart)olvSpareParts.SelectedObject;
			SparePart_AddQuantity(selectedSpare, -1);
		}

		private void SparePart_AddQuantity(ClassSparePart sparePart, int incrementBy)
		{
			if (sparePart == null)
				return;

			sparePart.Quantity += incrementBy;

			try
			{
				ClassSparePart.Update(_asset.ID, sparePart.Assembly.ID, sparePart);
			}
			catch (MySqlException mexc)
			{
				string errorMessage = string.Format("Cannot update spare part. Is it a duplicate?{0}{0}{1}", Environment.NewLine, mexc.Message);
				MessageBox.Show(errorMessage, "Error Editing Spare Part", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Populate();
			olvSpareParts.SelectedObject = _spares.FirstOrDefault(s => s.Assembly.ID == sparePart.Assembly.ID);
			olvSpareParts.Select();
		}
	}
}