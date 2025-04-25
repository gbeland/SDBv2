using System;
using System.Windows.Forms;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_AssetTags_New : Form
	{
		public string AssetTag = string.Empty;
		public string Description = string.Empty;

		public FormAdmin_AssetTags_New()
		{
			InitializeComponent();
		}
		public FormAdmin_AssetTags_New(string tag, string description)
		{
			InitializeComponent();

			AssetTag = tag;
			Description = description;

			txtAssetTag.Text = tag;
			txtDescription.Text = description;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void txtAssetTag_TextChanged(object sender, EventArgs e)
		{
			AssetTag = txtAssetTag.Text;
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{
			Description = txtDescription.Text;
		}
	}
}