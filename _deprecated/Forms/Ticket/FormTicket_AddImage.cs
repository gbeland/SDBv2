using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Ticket
{
	public partial class FormTicket_AddImage : Form
	{
		private readonly ClassAsset _asset;
		public Image NewImage;
		public string ImageDescription;

		public FormTicket_AddImage(ClassAsset asset)
		{
			InitializeComponent();
			_asset = asset;
		}

		private void btnCamera_Click(object sender, EventArgs e)
		{
			btnCamera.Enabled = false;
			btnFile.Enabled = false;
			btnOK.Enabled = false;
			btnOK.Text = "Fetching Image";
			lblProcessing.Visible = true;
			bgwGetImage.RunWorkerAsync();
		}

		private void bgwGetImage_DoWork(object sender, DoWorkEventArgs e)
		{
			Uri camUri;
			var camType = ClassCameraType.GetByID(_asset.Net.Webcam_Type);
			if (!Uri.TryCreate(_asset.URL_CameraImage(camType), UriKind.Absolute, out camUri))
			{
				MessageBox.Show(string.Format("Invalid camera URL.{0}{0}{1}", Environment.NewLine, _asset.URL_CameraImage(camType)), "Image Download Aborted", MessageBoxButtons.OK);
				return;
			}
			try
			{
				using (var client = new WebClient())
				{
					using (Stream s = client.OpenRead(camUri))
					{
						if (s != null)
							NewImage = new Bitmap(s);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Error obtaining camera image.{0}{0}{1}", Environment.NewLine, ex.Message), "Image Download Error", MessageBoxButtons.OK);
			}
		}

		private void bgwGetImage_Complete(object sender, RunWorkerCompletedEventArgs e)
		{
			if (NewImage != null)
				pbImage.Image = NewImage;

			btnOK.Text = "Create Ticket";
			btnOK.Enabled = true;
			lblProcessing.Visible = false;
			btnCamera.Enabled = true;
			btnFile.Enabled = true;
		}

		private void btnFile_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				ofd.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
				ofd.ShowDialog();
				if (!File.Exists(ofd.FileName))
					return;
				NewImage = Image.FromFile(ofd.FileName);
				pbImage.Image = NewImage;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			bgwGetImage.CancelAsync();
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			ImageDescription = txtDescription.Text.Trim();
			Close();
		}
	}
}