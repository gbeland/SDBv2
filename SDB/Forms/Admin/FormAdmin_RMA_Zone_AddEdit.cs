using System;
using System.Windows.Forms;

namespace SDB.Forms.Admin
{
	public sealed partial class FormAdmin_RMA_Zone_AddEdit : Form
	{
		public string Zone;
		private readonly bool _isEditing;

		public FormAdmin_RMA_Zone_AddEdit(bool isEditing, string zoneText = null)
		{
			InitializeComponent();
			_isEditing = isEditing;
			Text = (_isEditing ? "Edit" : "Add") + " RMA Zone";

			if (!_isEditing || zoneText == null)
				return;

			Zone = zoneText;
			Populate();
		}

		private void Populate()
		{
			txtZone.Text = Zone;
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
			Zone = txtZone.Text.Trim();
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}