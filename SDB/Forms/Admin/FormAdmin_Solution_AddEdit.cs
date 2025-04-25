using System;
using System.Windows.Forms;
using SDB.Classes.Ticket;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Solution_AddEdit : Form
	{
		public ClassTicket_Solution Solution { get; set; }

		public FormAdmin_Solution_AddEdit()
		{
			InitializeComponent();
			Solution = new ClassTicket_Solution();
		}

		public FormAdmin_Solution_AddEdit(ClassTicket_Solution solution) : this()
		{
			Solution = solution;
			txtSolutionName.Text = Solution.Solution;
			chkSolutionRequiresParts.Checked = Solution.RequiresParts;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Solution.Solution = txtSolutionName.Text.Trim();
			Solution.RequiresParts = chkSolutionRequiresParts.Checked;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}