using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;

namespace SDB.Forms.Assembly
{
	public partial class FormAssemblyPicker : Form
	{
		private readonly List<ClassAssemblyType> _assemblyTypes;
		private List<ClassAssembly> _assemblies;
		private readonly bool _showDisabled;

		private bool _ignoreStateChange;

		public ClassAssembly SelectedAssembly { private set; get; }

		/// <summary>
		/// A form to allow users to select a specific assembly.
		/// </summary>
		/// <param name="showDisabled">Specifies whether to include assemblies that are disabled in the list.</param>
		/// <param name="preselectedAssemblyID">If specified, the form will be shown with this assembly already selected.</param>
		public FormAssemblyPicker(bool showDisabled = false, int? preselectedAssemblyID = null)
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

			if (preselectedAssemblyID.HasValue)
			{
				var preselectedAssembly = ClassAssembly.GetByID(preselectedAssemblyID.Value);
				cmbAssemblyType.SelectedValue = preselectedAssembly.AssemblyTypeID;
				cmbAssembly.SelectedValue = preselectedAssembly.ID;
			}
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

		private void cmbAssembly_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectedAssembly = (ClassAssembly)cmbAssembly.SelectedItem;
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			if (SelectedAssembly == null)
				return;

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
	}
}