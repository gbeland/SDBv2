using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Ticket;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Solution_Select : Form
	{
		public ClassTicket_Solution Solution = new ClassTicket_Solution();

		public FormAdmin_Solution_Select()
		{
			InitializeComponent();

			cmbSolution.DisplayMember = "DisplayMember";
			cmbSolution.ValueMember = "ID";
			cmbSolution.DataSource = ClassTicket_Solution.GetAll().ToList();
			cmbSolution.SelectedIndex = -1;
		}

		public void SetSelectedSolution(int? solutionId)
		{
			if (!solutionId.HasValue)
				return;

			try
			{
				cmbSolution.SelectedValue = solutionId;
			}
			catch (InvalidOperationException)
			{
				cmbSolution.SelectedIndex = -1;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			var selectedSolution = (ClassTicket_Solution)cmbSolution.SelectedItem;
			if (selectedSolution == null)
			{
				MessageBox.Show("You must select a solution.", "Invalid Solution");
				return;
			}
			Solution = selectedSolution;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}