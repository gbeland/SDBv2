using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Shipments;

namespace SDB.Forms.Shipment
{
	/// <summary>
	/// Provides a list of previously-used shipment destinations not associated with a tech or market.
	/// </summary>
	public partial class FormList_ShipmentDestinations : Form
	{
		private List<ClassShipment.ClassShippingAddressInfo> _destinations;

		public ClassShipment.ClassShippingAddressInfo SelectedDestination;

		public FormList_ShipmentDestinations()
		{
			InitializeComponent();
			
			PopulateList();
			olvAltDests.EmptyListMsg = "No addresses found.";
		}

		private void PopulateList()
		{
			_destinations = ClassShipment.GetUnassociatedDestinations().ToList();
			olvAltDests.SetObjects(_destinations);
			txtQty.Text = _destinations.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SelectedDestination = olvAltDests.SelectedObject as ClassShipment.ClassShippingAddressInfo;
			DialogResult = SelectedDestination == null ? DialogResult.Cancel : DialogResult.OK;
			Close();
		}

		private void olvTechs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvAltDests.SelectedItem == null)
				return;
			SelectedDestination = (ClassShipment.ClassShippingAddressInfo)olvAltDests.SelectedObject;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}