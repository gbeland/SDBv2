using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Ticket;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_SymptomsSolutions : Form
	{
		private List<ClassTicket_Symptom> _symptoms;
		private List<ClassTicket_Solution> _solutions;

		public FormAdmin_SymptomsSolutions()
		{
			InitializeComponent();
		}

		private void FormSymptomsSolutions_Load(object sender, EventArgs e)
		{
			PopulateSymptomsSolutions();
		}

		private void PopulateSymptomsSolutions()
		{
			_symptoms = ClassTicket_Symptom.GetAll().ToList();
			_solutions = ClassTicket_Solution.GetAll().ToList();

			olvSymptoms.SetObjects(_symptoms);
			olvSolutions.SetObjects(_solutions);
		}

		private void btnSymptoms_Add_Click(object sender, EventArgs e)
		{
			using (var symptomEditForm = new FormAdmin_Symptom_AddEdit())
			{
				if(symptomEditForm.ShowDialog(this)!= DialogResult.OK)
					return;

				var newSymptom = symptomEditForm.Symptom;
				ClassTicket_Symptom.AddNew(ref newSymptom);
				PopulateSymptomsSolutions();
			}
		}

		private void btnSymptoms_Edit_Click(object sender, EventArgs e)
		{
			Symptom_Edit();
		}

		private void Symptom_Edit()
		{
			var selectedSymptom = (ClassTicket_Symptom)olvSymptoms.SelectedObject;
			if (selectedSymptom == null)
				return;

			using (var symptomEditForm = new FormAdmin_Symptom_AddEdit(selectedSymptom))
			{
				if (symptomEditForm.ShowDialog(this) != DialogResult.OK)
					return;

				ClassTicket_Symptom.Update(selectedSymptom);
				PopulateSymptomsSolutions();
			}
		}

		private void btnSolutions_Add_Click(object sender, EventArgs e)
		{
			using (var solutionEditForm = new FormAdmin_Solution_AddEdit())
			{
				if(solutionEditForm.ShowDialog(this) != DialogResult.OK)
					return;

				var newSolution = solutionEditForm.Solution;
				ClassTicket_Solution.AddNew(ref newSolution);
				PopulateSymptomsSolutions();
			}
		}

		private void btnSolutions_Edit_Click(object sender, EventArgs e)
		{
			Solution_Edit();
		}

		private void Solution_Edit()
		{
			var selectedSolution = (ClassTicket_Solution)olvSolutions.SelectedObject;
			if (selectedSolution == null)
				return;

			using (var solutionEditForm = new FormAdmin_Solution_AddEdit(selectedSolution))
			{
				if (solutionEditForm.ShowDialog(this) != DialogResult.OK)
					return;

				ClassTicket_Solution.Update(selectedSolution);
				PopulateSymptomsSolutions();
			}
		}

		private void btnSymptoms_Remove_Click(object sender, EventArgs e)
		{
			if (olvSymptoms.SelectedItem == null)
				return;

			var selectedSymptom = (ClassTicket_Symptom)olvSymptoms.SelectedObject;
			var usedQty = ClassTicket_Symptom.GetUsedQty(selectedSymptom.ID);
			if (usedQty > 0)
			{
				var message = string.Format("Cannot remove \"{0}\" because it is used {1} time{2} in the database.{3}{3}Do you want to merge it with another symptom?", selectedSymptom.Symptom, usedQty, usedQty == 1 ? string.Empty : "s", Environment.NewLine);
				if (MessageBox.Show(message, "Symptom In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var symptomSelectForm = new FormAdmin_Symptom_Select())
				{
					if (symptomSelectForm.ShowDialog() != DialogResult.OK)
						return;

					if (symptomSelectForm.Symptom.ID == selectedSymptom.ID)
					{
						MessageBox.Show("Cannot merge symptom with itself.", "Merge Symptom Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					var confirmation = string.Format("Symptom '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", selectedSymptom.Symptom, symptomSelectForm.Symptom.Symptom);
					if (MessageBox.Show(confirmation, "Confirm Symptom Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						selectedSymptom.Merge(symptomSelectForm.Symptom.ID);
						selectedSymptom.Delete();
						MessageBox.Show("Symptom merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Symptom merge failed: " + exc.Message, "Symptom Merge Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				var question = string.Format("Are you sure you want to remove \"{0}\"?", selectedSymptom.Symptom);
				if (MessageBox.Show(question, "Confirm Remove Symptom", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
				selectedSymptom.Delete();
			}
			PopulateSymptomsSolutions();
		}

		private void btnSolutions_Remove_Click(object sender, EventArgs e)
		{
			if (olvSolutions.SelectedItem == null)
				return;

			var selectedSolution = (ClassTicket_Solution)olvSolutions.SelectedObject;
			var usedQty = ClassTicket_Solution.GetUsedQty(selectedSolution.ID);
			if (usedQty > 0)
			{
				var message = string.Format("Cannot remove \"{0}\" because it is used {1} time{2} in the database.{3}{3}Do you want to merge it with another solution?", selectedSolution.Solution, usedQty, usedQty == 1 ? string.Empty : "s", Environment.NewLine);
				if (MessageBox.Show(message, "Solution In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var solutionSelectForm = new FormAdmin_Solution_Select())
				{
					if (solutionSelectForm.ShowDialog() != DialogResult.OK)
						return;

					if (solutionSelectForm.Solution.ID == selectedSolution.ID)
					{
						MessageBox.Show("Cannot merge solution with itself.", "Merge Solution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					var confirmation = string.Format("Solution '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", selectedSolution.Solution, solutionSelectForm.Solution);
					if (MessageBox.Show(confirmation, "Confirm Solution Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						selectedSolution.Merge(solutionSelectForm.Solution.ID);
						selectedSolution.Delete();
						MessageBox.Show("Solution merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Solution merge failed: " + exc.Message, "Solution Merge Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				var question = string.Format("Are you sure you want to remove \"{0}\"?", selectedSolution.Solution);
				if (MessageBox.Show(question, "Confirm Remove Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
				selectedSolution.Delete();
				PopulateSymptomsSolutions();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormAdmin_SymptomsSolutions_ResizeEnd(object sender, EventArgs e)
		{
			var margin = pnlSymptoms.Left;
			var panelWidth = (Width / 2) - (margin * 3);
			pnlSymptoms.Width = panelWidth;

			pnlSolutions.Location = new Point((Width / 2) + (margin / 2), pnlSolutions.Top);
			pnlSolutions.Width = panelWidth;
		}

		private void olvSymptoms_DoubleClick(object sender, EventArgs e)
		{
			Symptom_Edit();
		}

		private void olvSolutions_DoubleClick(object sender, EventArgs e)
		{
			Solution_Edit();
		}
	}
}