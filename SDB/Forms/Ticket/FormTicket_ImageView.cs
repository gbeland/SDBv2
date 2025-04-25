using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Forms.Ticket
{
	/// <summary>
	/// Uses DialogResult.Retry to indicate ticket reload required.
	/// </summary>
	public partial class FormTicket_ImageView : Form
	{
		private ClassTicket_Image _ticketImage;
		private readonly int _widthDiff;
		private readonly int _heightDiff;

		public ClassTicket_Image TicketImage
		{
			private get { return _ticketImage; }
			set
			{
				_ticketImage = value;
				pbTicketImage.Image = value.TicketImage;
				txtDate.Text = $"{value.ImageDate:yyyy-MM-dd HH:mm}";
				txtDescription.Text = value.Description;

				// Set form size to show image 1:1
				Size = new Size(pbTicketImage.Image.Width + _widthDiff, pbTicketImage.Image.Height + pnlControl.Height + _heightDiff);
			}
		}
		
		public FormTicket_ImageView()
		{
			InitializeComponent();
			_heightDiff = Height - pbTicketImage.Height;
			_widthDiff = Width - pbTicketImage.Width;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveImage();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete this ticket image?", "Confirm Image Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;
			// Use DialogResult.Retry to indicate that the ticket needs to be refreshed upon close.
			DialogResult = DialogResult.Retry;
			_ticketImage.Delete();
			Close();
		}

		private void SaveImage()
		{
			if (_ticketImage == null)
				return;

			try
			{
				using (var saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
					saveFileDialog.DefaultExt = "png";
					saveFileDialog.AddExtension = true;
					saveFileDialog.Filter = "PNG Images (*.png)|*.png|JPG Images (*.jpg)|*.jpg";
					saveFileDialog.FileName = string.Format("{0}_{1:yyyyMMdd}_{1:HHmmss}", TicketImage.TicketID, TicketImage.ImageDate);
					if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
						return;
					_ticketImage.TicketImage.Save(saveFileDialog.FileName);
					Close();
				}
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show("An error occurred saving image: " + exc.Message);
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}