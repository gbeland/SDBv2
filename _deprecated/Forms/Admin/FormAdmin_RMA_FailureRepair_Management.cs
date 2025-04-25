using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Forms.RMA;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_RMA_FailureRepair_Management : Form
	{
		private List<ClassRMA_FailureType> _failureTypes = new List<ClassRMA_FailureType>();
		private List<ClassRMA_RepairType> _repairTypes = new List<ClassRMA_RepairType>();
		private List<ClassRMA_RootCause> _rootCauses = new List<ClassRMA_RootCause>();

		public FormAdmin_RMA_FailureRepair_Management()
		{
			InitializeComponent();
			PopulateRMAFailures();
		}

		private void PopulateRMAFailures()
		{
			_failureTypes = ClassRMA_FailureType.GetAll().ToList();
			_repairTypes = ClassRMA_RepairType.GetAll().ToList();
			_rootCauses = ClassRMA_RootCause.GetAll().ToList();

			olvFailureTypes.SetObjects(_failureTypes);
			olvRepairTypes.SetObjects(_repairTypes);
			olvRootCauses.SetObjects(_rootCauses);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		#region FailureTypes
		private void btnFailureType_Add_Click(object sender, EventArgs e)
		{
			using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(false))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;
				try
				{
					ClassRMA_FailureType.AddNew(fae.Description);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not add Failure Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Failure Type Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			PopulateRMAFailures();
		}

		private void btnFailureType_Edit_Click(object sender, EventArgs e)
		{
			if (olvFailureTypes.SelectedItem == null)
				return;

			ClassRMA_FailureType selectedFailureType = (ClassRMA_FailureType)olvFailureTypes.SelectedObject;
			using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(true, selectedFailureType.Description))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;
				try
				{
					selectedFailureType.Description = fae.Description;
					ClassRMA_FailureType.Update(selectedFailureType);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not update Failure Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Failure Type Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			PopulateRMAFailures();
		}

		private void btnFailureType_Remove_Click(object sender, EventArgs e)
		{
			if (olvFailureTypes.SelectedItem == null)
				return;

			ClassRMA_FailureType selectedFailureType = (ClassRMA_FailureType)olvFailureTypes.SelectedObject;
			int usedQty = ClassRMA_FailureType.GetUsedQty(selectedFailureType.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another failure type?", selectedFailureType.Description, usedQty, Environment.NewLine),
					"Failure Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (FormRMA_FailureType_Select ffts = new FormRMA_FailureType_Select())
				{
					if (ffts.ShowDialog() != DialogResult.OK)
						return;

					if (ffts.FailureType.ID == selectedFailureType.ID)
					{
						MessageBox.Show("Cannot merge Failure Type with itself.", "Merge Failure Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (MessageBox.Show(string.Format("Failure type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", selectedFailureType.Description, ffts.FailureType.Description),
						"Confirm Failure Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;

					try
					{
						ClassRMA_FailureType.Merge(selectedFailureType.ID, ffts.FailureType.ID);
						ClassRMA_FailureType.Delete(selectedFailureType.ID);
						MessageBox.Show("Failure type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Component merge failed: " + exc.Message, "Merge Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove failure type '{0}'?", selectedFailureType.Description),
					"Confirm Remove Failure Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				ClassRMA_FailureType.Delete(selectedFailureType.ID);
				MessageBox.Show("Failure type remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			PopulateRMAFailures();
		}
		#endregion

		#region Repair Types
		private void btnRepairTypes_Add_Click(object sender, EventArgs e)
		{
			using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(false))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;
				try
				{
					ClassRMA_RepairType.AddNew(fae.Description);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not add Repair Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Repair Type Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			PopulateRMAFailures();
		}

		private void btnRepairType_Edit_Click(object sender, EventArgs e)
		{
			if (olvRepairTypes.SelectedItem == null) return;
			ClassRMA_RepairType SelectedRepairType = (ClassRMA_RepairType)olvRepairTypes.SelectedObject;
			using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(true, SelectedRepairType.Description))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;
				try
				{
					SelectedRepairType.Description = fae.Description;
					ClassRMA_RepairType.Update(SelectedRepairType);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not update Repair Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Repair Type Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			PopulateRMAFailures();
		}

		private void btnRepairType_Remove_Click(object sender, EventArgs e)
		{
			if (olvRepairTypes.SelectedItem == null) return;
			ClassRMA_RepairType SelectedRepairType = (ClassRMA_RepairType)olvRepairTypes.SelectedObject;
			int UsedQty = ClassRMA_RepairType.GetUsedQty(SelectedRepairType.ID);
			if (UsedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another repair type?", SelectedRepairType.Description, UsedQty, Environment.NewLine),
					"Repair Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (FormRMA_RepairType_Select frts = new FormRMA_RepairType_Select())
				{
					if (frts.ShowDialog() != DialogResult.OK)
						return;
					if (frts.RepairType.ID == SelectedRepairType.ID)
					{
						MessageBox.Show("Cannot merge Repair Type with itself.", "Merge Repair Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Repair type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", SelectedRepairType.Description, frts.RepairType.Description),
						"Confirm Repair Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassRMA_RepairType.Merge(SelectedRepairType.ID, frts.RepairType.ID);
						ClassRMA_RepairType.Delete(SelectedRepairType.ID);
						MessageBox.Show("Repair Type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Repair Type merge failed: " + exc.Message, "Merge Repair Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove repair type '{0}'?", SelectedRepairType.Description),
					"Confirm Remove Repair Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassRMA_RepairType.Delete(SelectedRepairType.ID);
				MessageBox.Show("Repair type remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			PopulateRMAFailures();
		}
		#endregion

		#region Root Causes
		private void btnRootCause_Add_Click(object sender, EventArgs e)
		{
			using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(false))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;
				try
				{
					ClassRMA_RootCause.AddNew(fae.Description);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not update or add root cause. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Root Cause Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			PopulateRMAFailures();
		}

		private void btnRootCause_Edit_Click(object sender, EventArgs e)
		{
			if (olvRootCauses.SelectedItem == null) return;
			ClassRMA_RootCause selectedRootCause = (ClassRMA_RootCause)olvRootCauses.SelectedObject;
			using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(true, selectedRootCause.Description))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;
				try
				{
					selectedRootCause.Description = fae.Description;
					ClassRMA_RootCause.Update(selectedRootCause);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not update or add Root Cause. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Root Cause Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			PopulateRMAFailures();
		}

		private void btnRootCause_Remove_Click(object sender, EventArgs e)
		{
			if (olvRootCauses.SelectedItem == null) return;
			ClassRMA_RootCause SelectedRootCause = (ClassRMA_RootCause)olvRootCauses.SelectedObject;
			int UsedQty = ClassRMA_RootCause.GetUsedQty(SelectedRootCause.ID);
			if (UsedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Root Cause?", SelectedRootCause.Description, UsedQty, Environment.NewLine),
					"Root Cause In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (FormRMA_RootCause_Select frcs = new FormRMA_RootCause_Select())
				{
					if (frcs.ShowDialog() != DialogResult.OK)
						return;
					if (frcs.RootCause.ID == SelectedRootCause.ID)
					{
						MessageBox.Show("Cannot merge Root Cause with itself.", "Merge Root Cause Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Root Cause '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", SelectedRootCause.Description, frcs.RootCause.Description),
						"Confirm Root Cause Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassRMA_RootCause.Merge(SelectedRootCause.ID, frcs.RootCause.ID);
						ClassRMA_RootCause.Delete(SelectedRootCause.ID);
						MessageBox.Show("Root Cause merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Root Cause merge failed: " + exc.Message, "Merge Root Cause Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Root Cause '{0}'?", SelectedRootCause.Description),
					"Confirm Remove Root Cause", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassRMA_RootCause.Delete(SelectedRootCause.ID);
				MessageBox.Show("Root Cause remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			PopulateRMAFailures();
		}
		#endregion
	}
}