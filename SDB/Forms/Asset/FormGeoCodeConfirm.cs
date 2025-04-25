using System;
using System.Windows.Forms;

namespace SDB.Forms.Asset
{
	public partial class FormGeoCodeConfirm : Form
	{
		public string AssetLocation { private get; set; }
		public string Latitude { private get; set; }
		public string Longitude { private get; set; }

		public FormGeoCodeConfirm()
		{
			InitializeComponent();
		}

		private void FormGeoCodeConfirm_Shown(object sender, EventArgs e)
		{
			txtLocation.Text = AssetLocation;
			txtLatitude.Text = Latitude;
			txtLongitude.Text = Longitude;

			wbOverview.DocumentText = $"<img src='{GetMapLink(Latitude, Longitude, wbOverview.Width, wbOverview.Height, 4)}' />";
			wbZoomed.DocumentText = $"<img src='{GetMapLink(Latitude, Longitude, wbZoomed.Width, wbZoomed.Height, 12)}' />";
		}

		private string GetMapLink(string latitude, string longitude, int width, int height, int zoomValue)
		{
			return string.Format("http://maps.google.com/maps/api/staticmap?size={0}x{1}&amp;maptype=roadmap&amp;center={2},{3}&amp;zoom={4}&amp;markers=color:red%7Clabel:&bull;%7C{2},{3}&amp;sensor=false",
				width,
				height,
				latitude,
				longitude,
				zoomValue);
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.No;
			Close();
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Yes;
			Close();
		}
	}
}