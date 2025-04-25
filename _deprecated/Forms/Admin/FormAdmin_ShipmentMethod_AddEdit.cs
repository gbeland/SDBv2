using System;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Shipments;

namespace SDB.Forms.Admin
{
	public sealed partial class FormAdmin_ShipmentMethod_AddEdit : Form
	{
		private ClassShipment_Method _shipmentMethod = new ClassShipment_Method();
		private readonly bool _isEditing;

		/// <summary>
		/// Construct a form to edit an existing or add a new shipment method.
		/// (Does not modify display indexes.)
		/// </summary>
		/// <param name="isEditing">True if editing an existing shipment method.</param>
		/// <param name="shipmentMethodID">Which shipment method to edit, if any.</param>
		public FormAdmin_ShipmentMethod_AddEdit(bool isEditing, int? shipmentMethodID = null)
		{
			InitializeComponent();
			_isEditing = isEditing;

			Text = _isEditing ? "Edit Shipment Method" : "Add Shipment Method";

			if (_isEditing && shipmentMethodID.HasValue)
			{
				_shipmentMethod = ClassShipment_Method.GetByID(shipmentMethodID.Value);
				Populate();
			}

			txtDescription.Select();
		}

		private void Populate()
		{
			txtAbbreviation.Text = _shipmentMethod.Abbreviation;
			txtDescription.Text = _shipmentMethod.Description;
			chkDefault.Checked = _shipmentMethod.Default;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtAbbreviation.Text) || string.IsNullOrEmpty(txtDescription.Text))
			{
				MessageBox.Show("Shipment Method abbreviation and description cannot be blank.", "Shipment Method Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			UpdateShipmentMethodObjectFromFields();
			try
			{
				if (_isEditing)
					ClassShipment_Method.Update(_shipmentMethod);
				else
					ClassShipment_Method.AddNew(ref _shipmentMethod);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add shipment method. Ensure that it is unique.{0}{0}{1}", Environment.NewLine, exc.Message));
			}
		}

		private void UpdateShipmentMethodObjectFromFields()
		{
			_shipmentMethod.Abbreviation = txtAbbreviation.Text.Trim();
			_shipmentMethod.Description = txtDescription.Text.Trim();
			_shipmentMethod.Default = chkDefault.Checked;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}