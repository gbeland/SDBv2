using System;
using System.Windows.Forms;

namespace SDB.Forms.Admin
{
	public sealed partial class FormAdmin_RMA_Area_AddEdit : Form
	{
		public string Area;
		private readonly bool _isEditing;

		public FormAdmin_RMA_Area_AddEdit(bool isEditing, string areaText = null)
		{
			InitializeComponent();
			_isEditing = isEditing;
			Text = (_isEditing ? "Edit" : "Add") + " RMA Area";

			if (!_isEditing || areaText == null)
				return;

			Area = areaText;
			Populate();
		}

		private void Populate()
		{
			txtArea.Text = Area;
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
			Area = txtArea.Text.Trim();
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}