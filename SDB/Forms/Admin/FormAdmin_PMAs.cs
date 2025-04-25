using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_PMAs : Form
	{
		private List<ClassPreventiveMaintenanceAction> _pmas = new List<ClassPreventiveMaintenanceAction>();
		private ClassPreventiveMaintenanceAction _selectedPMA;

		public FormAdmin_PMAs()
		{
			InitializeComponent();
		}

		private void FormPMAs_Load(object sender, EventArgs e)
		{
			Populate_PMAs();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Populate_PMAs()
		{
			_pmas = ClassPreventiveMaintenanceAction.GetPreventiveMaintenanceActions().ToList();
			olvPMAs.SetObjects(_pmas);
		}

		private void olvPMAs_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedPMA = (ClassPreventiveMaintenanceAction)olvPMAs.SelectedObject;
			if (_selectedPMA == null)
				return;
		}

		private void btnPMA_Add_Click(object sender, EventArgs e)
		{
			using (FormAdmin_PMAs_AddEdit frmPMAAddEdit = new FormAdmin_PMAs_AddEdit(false))
			{
				if (frmPMAAddEdit.ShowDialog() != DialogResult.OK)
					return;
				Populate_PMAs();
			}
		}

		private void btnPMA_Edit_Click(object sender, EventArgs e)
		{
			PMA_Edit();
		}

		private void olvPMAs_DoubleClick(object sender, EventArgs e)
		{
			PMA_Edit();
		}

		private void PMA_Edit()
		{
			if (_selectedPMA == null)
				return;
			using (FormAdmin_PMAs_AddEdit frmPMAAddEdit = new FormAdmin_PMAs_AddEdit(true, _selectedPMA.ID))
			{
				if (frmPMAAddEdit.ShowDialog() != DialogResult.OK)
					return;
				Populate_PMAs();
			}
		}

		private void btnPMA_Remove_Click(object sender, EventArgs e)
		{
			if (_selectedPMA == null) return;
			if (MessageBox.Show("Are you sure you want to delete the selected preventive maintenance action?", "Confirm PMA Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			// Check if the PMA is used for anything
			int PMAUsedQty = ClassPreventiveMaintenanceAction.GetUsedQty(_selectedPMA.ID);
			if (PMAUsedQty > 0)
			{
				MessageBox.Show(string.Format("This preventive maintenance action is used {0} time{1} in the database. It cannot be deleted.", PMAUsedQty, PMAUsedQty == 1 ? string.Empty : "s"), "PMA In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			ClassPreventiveMaintenanceAction.Delete(_selectedPMA);
			Populate_PMAs();
		}
	}
}
