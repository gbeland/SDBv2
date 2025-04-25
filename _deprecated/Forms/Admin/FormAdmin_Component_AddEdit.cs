using System;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Forms.General;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Component_AddEdit : Form
	{
		private ClassComponent _component = new ClassComponent();
		private readonly bool _isEditing;

		public FormAdmin_Component_AddEdit(bool IsEditing, int? ComponentID = null)
		{
			InitializeComponent();
			_isEditing = IsEditing;

			if (_isEditing && ComponentID.HasValue)
			{
				_component = ClassComponent.GetByID(ComponentID.Value);
				PopulateAssembly();
			}

			txtComponentNumber.Select();
		}

		private void PopulateAssembly()
		{
			txtComponentNumber.Text = _component.ComponentNumber;
			txtComponentDescription.Text = _component.Description;
			txtComponentLocation.Text = _component.Location;
			numComponentCost.Value = ((decimal?)_component.Cost).GetValueOrDefault(0);
			numComponentInventoryQty.Value = _component.InventoryQty.GetValueOrDefault(0);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			NumericUpDown n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtComponentNumber.Text) || string.IsNullOrEmpty(txtComponentDescription.Text))
			{
				MessageBox.Show("Component part number and description cannot be blank.", "Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion
			UpdateAssemblyObjectFromFields();
			try
			{
				if (_isEditing)
					ClassComponent.Update(_component);
				else
					ClassComponent.AddNew(ref _component);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add component. Ensure the component description and number are unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateAssemblyObjectFromFields()
		{
			_component.ComponentNumber = txtComponentNumber.Text.Trim();
			_component.Description = txtComponentDescription.Text.Trim();
			_component.Location = txtComponentLocation.Text.Trim();
			_component.Cost = (double?)numComponentCost.Value;
			_component.InventoryQty = (int?)numComponentInventoryQty.Value;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			using (FormWorkbenchImport fwi = new FormWorkbenchImport())
			{
				if (fwi.ShowDialog(this) != DialogResult.OK)
					return;

				txtComponentNumber.Text = fwi.SelectedWorkbenchItem.CatalogNumber;
				txtComponentDescription.Text = fwi.SelectedWorkbenchItem.Description;
			}
		}
	}
}
