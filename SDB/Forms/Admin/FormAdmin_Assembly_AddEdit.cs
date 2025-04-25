using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.General;
using SDB.Forms.General;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Assembly_AddEdit : Form
	{
		private readonly List<ClassAssemblyCategory> _categories;
		private readonly List<ClassAssemblyType> _types;
		private readonly List<ClassAssembly> _replacementAssemblies;
		private ClassAssembly _assembly = new ClassAssembly();
		private readonly bool _isEditing;

		public FormAdmin_Assembly_AddEdit(bool isEditing, int? assemblyID = null)
		{
			InitializeComponent();
			_isEditing = isEditing;
			_categories = ClassAssemblyCategory.GetAll().ToList();
			_types = ClassAssemblyType.GetAll().ToList();
			_replacementAssemblies = ClassAssembly.GetByType().ToList();

			PopulateReplacementAssemblies(assemblyID);
			PopulateAssemblyCategories();

			if (_isEditing && assemblyID.HasValue)
			{
				_assembly = ClassAssembly.GetByID(assemblyID.Value);
				PopulateAssembly();
			}

			txtAssemblyNumber.Select();
		}

		private void cmbAssemblyCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			PopulateAssemblyTypes();
		}

		private void PopulateReplacementAssemblies(int? excludeAssemblyID)
		{
			if (excludeAssemblyID.HasValue)
				_replacementAssemblies.RemoveAll(a => a.ID == excludeAssemblyID.Value);

			cmbReplacementAssy.ValueMember = "ID";
			cmbReplacementAssy.DisplayMember = "DisplayMember";
			cmbReplacementAssy.DataSource = _replacementAssemblies;

			cmbReplacementAssy.SelectedIndex = -1;
		}

		private void PopulateAssemblyCategories()
		{
			cmbAssemblyCategory.DisplayMember = "DisplayMember";
			cmbAssemblyCategory.ValueMember = "ID";
			cmbAssemblyCategory.DataSource = _categories;

			PopulateAssemblyTypes();
		}
		
		// Figure out why assembly type isn't populating correctly
		private void PopulateAssemblyTypes()
		{
			var selectedCategory = (int)cmbAssemblyCategory.SelectedValue;

			cmbAssemblyType.DisplayMember = "DisplayMember";
			cmbAssemblyType.ValueMember = "ID";
			cmbAssemblyType.DataSource = _types.Where(t => t.CategoryID == selectedCategory).ToList();
		}

		private void PopulateAssembly()
		{
			try
			{
				var assyType = _types.Single(t => _assembly.AssemblyTypeID == t.ID);
				var assyCategory = _categories.Single(c => assyType.CategoryID == c.ID);
				cmbAssemblyCategory.SelectedValue = assyCategory.ID;
				cmbAssemblyType.SelectedValue = assyType.ID;
			}
			catch (Exception exc)
			{
				MessageBox.Show("Unexpected assembly category or type error: " + exc.Message);
			}

			txtAssemblyNumber.Text = _assembly.AssemblyNumber;
			txtAssemblyDescription.Text = _assembly.Description;
			txtAssemblyLocation.Text = _assembly.Location;
			numAssemblyCost.Value = ((decimal?)_assembly.Cost).GetValueOrDefault(0);
			numAssemblyInventoryQty.Value = _assembly.InventoryQty.GetValueOrDefault(0);
			chkDisabled.Checked = _assembly.Disabled;
            cbxThirdParty.Checked = _assembly.ThirdParty;
			lblReplacement.Enabled = cmbReplacementAssy.Enabled = _assembly.Disabled;

			if (_assembly.ReplacedBy.HasValue)
				cmbReplacementAssy.SelectedValue = _assembly.ReplacedBy.Value;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtAssemblyNumber.Text) || string.IsNullOrEmpty(txtAssemblyDescription.Text))
			{
				MessageBox.Show("Assembly part number and description cannot be blank.", "Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			UpdateAssemblyObjectFromFields();
			try
			{
				if (_isEditing)
					ClassAssembly.Update(_assembly);
				else
					ClassAssembly.AddNew(ref _assembly);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add assembly. Ensure the assembly description and number are unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Assembly Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateAssemblyObjectFromFields()
		{
			_assembly.AssemblyTypeID = (int)cmbAssemblyType.SelectedValue;
			_assembly.AssemblyNumber = txtAssemblyNumber.Text.Trim();
			_assembly.Description = txtAssemblyDescription.Text.Trim();
			_assembly.Location = txtAssemblyLocation.Text.Trim();
			_assembly.Cost = (double?)numAssemblyCost.Value;
			_assembly.InventoryQty = (int?)numAssemblyInventoryQty.Value;
			_assembly.Disabled = chkDisabled.Checked;
            _assembly.ThirdParty = cbxThirdParty.Checked;
			if (_assembly.Disabled && cmbReplacementAssy.SelectedIndex > 0)
				_assembly.ReplacedBy = (int)cmbReplacementAssy.SelectedValue;
			else
				_assembly.ReplacedBy = null;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			using (var fwi = new FormWorkbenchImport())
			{
				if (fwi.ShowDialog(this) != DialogResult.OK)
					return;

				txtAssemblyNumber.Text = fwi.SelectedWorkbenchItem.CatalogNumber;
				txtAssemblyDescription.Text = fwi.SelectedWorkbenchItem.Description;
			}
		}

		private void chkDisabled_CheckedChanged(object sender, EventArgs e)
		{
			lblReplacement.Enabled = cmbReplacementAssy.Enabled = chkDisabled.Checked;

			if (!chkDisabled.Checked)
				cmbReplacementAssy.SelectedIndex = -1;
		}

		private void cmbReplacementAssy_DrawItem(object sender, DrawItemEventArgs e)
		{
			var comboBox = (ComboBox)sender;
			e.DrawBackground();
			if (e.Index < 0)
				return;
			var text = comboBox.GetItemText(comboBox.Items[e.Index]);
			var brush = _replacementAssemblies[e.Index].Disabled ? Brushes.Gray : Brushes.Black;
			e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
		}
	}
}