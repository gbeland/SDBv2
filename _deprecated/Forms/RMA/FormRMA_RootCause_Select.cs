using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_RootCause_Select : Form
	{
		public ClassRMA_RootCause RootCause = new ClassRMA_RootCause();

		public FormRMA_RootCause_Select()
		{
			InitializeComponent();

			cmbRootCause.DisplayMember = "DisplayMember";
			cmbRootCause.ValueMember = "ID";
			cmbRootCause.DataSource = ClassRMA_RootCause.GetAll().ToList();
			cmbRootCause.SelectedIndex = -1;
		}

		public void SetSelectedRootCause(int? finalizeRootCause)
		{
			if (!finalizeRootCause.HasValue)
				return;

			try
			{
				cmbRootCause.SelectedValue = finalizeRootCause;
			}
			catch (InvalidOperationException)
			{
				cmbRootCause.SelectedIndex = -1;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			var selectedRootCause = (ClassRMA_RootCause)cmbRootCause.SelectedItem;
			if (selectedRootCause == null)
			{
				MessageBox.Show("You must select a root cause.", "Invalid Root Cause");
				return;
			}
			RootCause = selectedRootCause;
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