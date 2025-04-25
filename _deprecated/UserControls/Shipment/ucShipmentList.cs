using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Shipments;
using SDB.Classes.User;

namespace SDB.UserControls.Shipment
{
	public partial class ucShipmentList : UserControl
	{
		public delegate void CreateEvent();
		public delegate void ShipmentEvent(int shipmentID);
		public delegate void TrackingEvent(string trackingURL);
		public event CreateEvent CreateShipment;
		public event ShipmentEvent ViewShipment;
		public event TrackingEvent ViewTracking;
		private bool _isCreateButtonShown;

		public bool ShowCreateButton
		{
			get => _isCreateButtonShown;
			set
			{
				_isCreateButtonShown = value;
				btnCreate.Visible = _isCreateButtonShown;
			}
		}

		public ucShipmentList()
		{
			InitializeComponent();

			olvShipments.PrimarySortColumn = olcShipmentId;
			olvShipments.PrimarySortOrder = SortOrder.Descending;
		}

		public void SetObjects<T>(List<T> collection)
		{
			PopulateUserNames(collection);
			olvShipments.SetObjects(collection);
			txtShipmentsQty.Text = collection.Count.ToString();
		}

		public void Clear()
		{
			olvShipments.SetObjects(null);
			txtShipmentsQty.Clear();
		}

		private void olvShipments_DoubleClick(object sender, EventArgs e)
		{
			if (ViewShipment != null)
				ViewShipment(((ClassShipment)olvShipments.SelectedObject).ID);
		}

		private void olvShipments_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
		{
			var selectedShipment = (ClassShipment)e.Model;
			if (e.Column == olcTracking)
			{
				if (ViewTracking != null && !string.IsNullOrEmpty(selectedShipment.Tracking))
					ViewTracking(selectedShipment.URL_TrackingLink);
			}
			e.Handled = true;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (CreateShipment != null)
				CreateShipment();
		}

		private void olvShipments_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			// There's a problem with the ObjectListView in that if Hyperlinks are used, only the first column
			// gets this row formatting.
			var shipment = (ClassShipment)e.Model;
			e.Item.ForeColor = shipment.StatusColor;
		}

		/// <summary>
		/// Locks or unlocks controls for editing.
		/// </summary>
		public void LockControls(bool isLocked)
		{
			foreach (var button in pnlShipments_Control.Controls.OfType<Button>())
				button.Enabled = !isLocked;
		}

		/// <summary>
		/// Populates usernames in each shipment.
		/// </summary>
		private void PopulateUserNames<T>(IEnumerable<T> shipments)
		{
			var userDictionary = ClassUser.GetIdToNameDictionary();
			foreach (var s in shipments.Cast<ClassShipment>())
			{
				s.Requested_By = userDictionary[s.Requested_UserId];
				s.Picked_By = s.Picked_UserId.HasValue ? userDictionary[s.Picked_UserId.Value] : string.Empty;
				s.Fulfilled_By = s.Fulfilled_UserId.HasValue ? userDictionary[s.Fulfilled_UserId.Value] : string.Empty;
			}
		}
	}
}