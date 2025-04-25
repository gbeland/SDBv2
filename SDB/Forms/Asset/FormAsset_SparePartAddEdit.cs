using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;

namespace SDB.Forms.Asset
{
	public partial class FormAsset_SparePartAddEdit : Form
	{
		private readonly List<ClassAssemblyType> _assemblyTypes;
		private List<ClassAssembly> _assemblies;
		private readonly bool _showDisabled;

		private bool _ignoreStateChange;

		private ClassSparePart _sparePart;
		
		public ClassSparePart SparePart
		{
			get => _sparePart;
			set
			{
				_sparePart = value;
				cmbAssemblyType.SelectedValue = _sparePart.Assembly.AssemblyTypeID;
				cmbAssembly.SelectedValue = _sparePart.Assembly.ID;
				numQuantity.Value = _sparePart.Quantity;
				numExpected.Value = _sparePart.Expected;
			}
		}

		public FormAsset_SparePartAddEdit(bool showDisabled = false)
		{
			InitializeComponent();
			_showDisabled = showDisabled;
			_assemblyTypes = ClassAssemblyType.GetAll().ToList();

			_ignoreStateChange = true;
			cmbAssemblyType.DisplayMember = "DisplayMember";
			cmbAssemblyType.ValueMember = "ID";
			cmbAssemblyType.DataSource = _assemblyTypes;
			cmbAssemblyType.SelectedIndex = -1;

			cmbAssembly.DisplayMember = "DisplayMember";
			cmbAssembly.ValueMember = "ID";
			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;
			_ignoreStateChange = false;
		}

		private void cmbAssemblyType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			var selectedAssemblyType = (ClassAssemblyType)cmbAssemblyType.SelectedItem;
			if (selectedAssemblyType == null)
			{
				_assemblies.Clear();
				return;
			}

			_ignoreStateChange = true;
			_assemblies = ClassAssembly.GetAssemblies(selectedAssemblyType.ID).Where(a => _showDisabled || !a.Disabled).OrderBy(a => a.AssemblyNumber).ToList();
			cmbAssembly.DataSource = null;
			cmbAssembly.DisplayMember = "DisplayMember";
			cmbAssembly.ValueMember = "ID";
			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;
			_ignoreStateChange = false;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (cmbAssembly.SelectedItem == null)
				return;

			SparePart = new ClassSparePart
				            {
					            Assembly = (ClassAssembly)cmbAssembly.SelectedItem,
								Quantity = (int)numQuantity.Value,
					            Expected = (int)numExpected.Value
				            };

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void cmbAssembly_DrawItem(object sender, DrawItemEventArgs e)
		{
			var comboBox = (ComboBox)sender;
			e.DrawBackground();
			if (e.Index < 0)
				return;
			var text = comboBox.GetItemText(comboBox.Items[e.Index]);
			var brush = _assemblies[e.Index].Disabled ? Brushes.Gray : Brushes.Black;
			e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}
	}
}