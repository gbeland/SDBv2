using System;
using System.Windows.Forms;

namespace SDB.Forms.Asset
{
	public partial class FormAsset_Document_New : Form
	{
		public string DocumentName;
		public string DocumentLink;

		public FormAsset_Document_New()
		{
			InitializeComponent();
		}

		public FormAsset_Document_New(string name, string link)
		{
			InitializeComponent();

			tbxName.Text = DocumentName = name;
			tbxDocumentLink.Text = DocumentLink = link;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (tbxDocumentLink.Text == string.Empty)
			{
				MessageBox.Show("Please Enter a Document Link or Click Cancel", "No Link!", MessageBoxButtons.OK);
				return;
			}
			else if (tbxName.Text == string.Empty)
			{
				MessageBox.Show("Please Enter a Document Name or Click Cancel", "No Name!", MessageBoxButtons.OK);
				return;
			}
			var s = tbxDocumentLink.Text;
			tbxDocumentLink.Text = s.Replace(" ", "%");
			if (s.Substring((s.Length - 3), 3).Contains("exe"))
			{
				MessageBox.Show("The File type .exe is not allowed.", "Bad File Type", MessageBoxButtons.OK);
				return;
			}
			if (!s.Contains("file://") && !s.Contains("https://") && !s.Contains("http://") && !s.Contains("www"))
			{
				MessageBox.Show("Your File Link must either start with file:// or https:// or http:// or www \n", "Bad Format", MessageBoxButtons.OK);
				return;
			}

			DialogResult = DialogResult.OK;
			DocumentLink = tbxDocumentLink.Text;
			DocumentName = tbxName.Text;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}