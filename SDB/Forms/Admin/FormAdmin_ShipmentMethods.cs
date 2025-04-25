using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Shipments;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_ShipmentMethods : Form
	{
		private List<ClassShipment_Method> _shipmentMethods = new List<ClassShipment_Method>();
		private ClassShipment_Method _selectedShipmentMethod;

		public FormAdmin_ShipmentMethods()
		{
			InitializeComponent();

			olvShipmentMethods.FormatRow += olvShipmentMethods_FormatRow;
			olvShipmentMethods.PrimarySortColumn = olcDisplayIndex;
			olvShipmentMethods.PrimarySortOrder = SortOrder.Ascending;

			olcDefault.AspectToStringConverter = delegate(object x)
			{
				var isDefault = (bool)x;
				return isDefault ? "True" : string.Empty;
			};
		}

		private void FormShipmentMethods_Load(object sender, EventArgs e)
		{
			Populate_ShipmentMethods();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Populate_ShipmentMethods()
		{
			_shipmentMethods = ClassShipment_Method.GetAll().ToList();
			olvShipmentMethods.SetObjects(_shipmentMethods);
		}

		private void olvShipmentMethods_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedShipmentMethod = (ClassShipment_Method)olvShipmentMethods.SelectedObject;
		}

		private void olvShipmentMethods_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var sm = (ClassShipment_Method)e.Model;
			if (!sm.Default)
				return;
			e.Item.BackColor = Color.PaleGreen;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (FormAdmin_ShipmentMethod_AddEdit frmShipmentMethodAddEdit = new FormAdmin_ShipmentMethod_AddEdit(false))
			{
				if (frmShipmentMethodAddEdit.ShowDialog(this) != DialogResult.OK)
					return;

				Populate_ShipmentMethods();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			ShipmentMethod_Edit();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (_selectedShipmentMethod == null)
				return;

			int usedQty = ClassShipment_Method.GetUsedQty(_selectedShipmentMethod.ID);
			if (usedQty == 0)
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove \"{0}\"?", _selectedShipmentMethod.Description), "Confirm Remove Shipment Method", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;
				ClassShipment_Method.Delete(_selectedShipmentMethod.ID);
				Populate_ShipmentMethods();
				return;
			}
			MessageBox.Show(string.Format("\"{0}\" is used {1} time{2} in the database. You cannot remove it.", _selectedShipmentMethod.Description, usedQty, usedQty == 1 ? string.Empty : "s"), "Cannot Remove Shipment Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void olvShipmentMethods_DoubleClick(object sender, EventArgs e)
		{
			ShipmentMethod_Edit();
		}

		private void ShipmentMethod_Edit()
		{
			if (_selectedShipmentMethod == null)
				return;

			using (FormAdmin_ShipmentMethod_AddEdit frmAdminEmailAddEdit = new FormAdmin_ShipmentMethod_AddEdit(true, _selectedShipmentMethod.ID))
			{
				if (frmAdminEmailAddEdit.ShowDialog() != DialogResult.OK)
					return;

				Populate_ShipmentMethods();
			}
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			if (_selectedShipmentMethod == null)
				return;

			ClassShipment_Method.SetDefault(_selectedShipmentMethod.ID);
			Populate_ShipmentMethods();
		}

		private void btnMoveUp_Click(object sender, EventArgs e)
		{
			if (_selectedShipmentMethod == null)
				return;

			ClassShipment_Method.MoveUp(_selectedShipmentMethod.ID);
			Populate_ShipmentMethods();
		}
	}
}