using System;
using System.Windows.Forms;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_RMA_FailureRepair_AddEdit : Form
	{
		public string Description;
		private readonly bool _isEditing;

		public FormAdmin_RMA_FailureRepair_AddEdit(bool isEditing, string failureRepairText = null)
		{
			InitializeComponent();
			_isEditing = isEditing;

			if (!_isEditing || failureRepairText == null)
				return;
			Description = failureRepairText;
			Populate();
		}

		private void Populate()
		{
			txtFailureRepairDescription.Text = Description;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Description = txtFailureRepairDescription.Text.Trim();
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}