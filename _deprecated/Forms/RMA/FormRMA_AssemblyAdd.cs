using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_AssemblyAdd : Form
	{
		public int Qty;
		public readonly ClassRMA.ClassRMAAssembly RMAAssembly = new ClassRMA.ClassRMAAssembly();

		private List<ClassAssemblyType> _assemblyTypes;
		private List<ClassAssembly> _assemblies;

		private ClassAssemblyCategory _selectedAssemblyCategory;
		private ClassAssemblyType _selectedAssemblyType;
		private ClassAssembly _selectedAssembly;

		private ClassRMA_FailureType _selectedFailureType;
		private bool _ignoreStateChanges;

		public FormRMA_AssemblyAdd(ClassAsset asset)
		{
			InitializeComponent();

			var assemblyCategories = ClassAssemblyCategory.GetAll().ToList();
			var failureTypes = ClassRMA_FailureType.GetAll().ToList();
			_assemblies = new List<ClassAssembly>();

			_ignoreStateChanges = true;

			cmbCategory.DisplayMember = "DisplayMember";
			cmbCategory.ValueMember = "ID";
			cmbCategory.DataSource = assemblyCategories;
			cmbCategory.SelectedIndex = -1;

			cmbType.DisplayMember = "DisplayMember";
			cmbType.ValueMember = "ID";
			cmbType.DataSource = _assemblyTypes;
			cmbType.SelectedIndex = -1;

			cmbAssembly.DisplayMember = "DisplayMember";
			cmbAssembly.ValueMember = "ID";
			cmbAssembly.DataSource = _assemblies;

			cmbFailureType.DisplayMember = "DisplayMember";
			cmbFailureType.ValueMember = "ID";
			cmbFailureType.DataSource = failureTypes;
			cmbFailureType.SelectedIndex = -1;

			txtAsset_Interface.Text = asset.InterfaceType;
			txtAsset_ModulePitch.Text = asset.Pitch.ToString();
            asset.Ibom = ClassAsset.GetIbom(asset.ID);
            tbxAssemNum.Text = asset.Ibom.LED_Assembly;

			_ignoreStateChanges = false;
		}

		/// <summary>
		/// Pre-set the assembly type without setting the assembly.
		/// </summary>
		public void SetAssemblyType(int assemblyTypeID)
		{
			_ignoreStateChanges = true;
			cmbType.SelectedValue = assemblyTypeID;
			_assemblies = ClassAssembly.GetByType((ClassAssemblyType)cmbType.SelectedItem).ToList();
			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;
			_ignoreStateChanges = false;
		}

		/// <summary>
		/// Pre-set the assembly. (Also sets assembly type.)
		/// </summary>
		public void SetAssembly(int assemblyID)
		{
			_ignoreStateChanges = true;
			var thisAssembly = ClassAssembly.GetByID(assemblyID);
			cmbType.SelectedValue = thisAssembly.AssemblyTypeID;
			_assemblies = ClassAssembly.GetByType((ClassAssemblyType)cmbType.SelectedItem).ToList();
			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedValue = thisAssembly.ID;
			_ignoreStateChanges = false;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (cmbType.SelectedItem == null || cmbAssembly.SelectedItem == null || cmbFailureType.SelectedItem == null || string.IsNullOrEmpty(txtFailureNotes.Text.Trim()))
			{
				MessageBox.Show("Assembly, Failure Type, and Failure Notes must all be provided.", "RMA Assembly Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (cmbFailureType.Text.Equals(txtFailureNotes.Text.Trim(), StringComparison.OrdinalIgnoreCase))
			{
				MessageBox.Show("Failure Notes should provide additional information rather than repeat the Failure Type.", "RMA Assembly Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var selectedAssembly = (ClassAssembly)cmbAssembly.SelectedItem;
			if (selectedAssembly.Disabled)
			{
				if (selectedAssembly.ReplacedBy.HasValue)
				{
					var replacementAssembly = ClassAssembly.FindCurrentReplacement(selectedAssembly);
					var message = string.Format("This assembly is disabled and has been replaced by:{0}{0}{1} ({2}){0}{0}Do you want to use it instead?", Environment.NewLine, replacementAssembly.Description, replacementAssembly.AssemblyNumber);
					var result = MessageBox.Show(message, "Disabled Assembly with Replacement", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
					switch (result)
					{
						case DialogResult.Yes:
							cmbType.SelectedValue = replacementAssembly.AssemblyTypeID;
							cmbAssembly.SelectedValue = replacementAssembly.ID;
							break;

						case DialogResult.Cancel:
							return;
					}
				}
				else if (MessageBox.Show("This assembly is disabled, are you sure you want to select it?", "Disabled Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
			}
			#endregion
			Qty = (int)numQty.Value;
			UpdateAssemblyObjectFromFields();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void UpdateAssemblyObjectFromFields()
		{
			RMAAssembly.AssemblyType_ID = _selectedAssemblyType.ID;
			RMAAssembly.AssemblyTypeDescription = _selectedAssemblyType.Description;
			RMAAssembly.AssemblyTypeIsComputer = _selectedAssemblyType.IsComputer;

			RMAAssembly.Assembly_ID = _selectedAssembly.ID;
			RMAAssembly.AssemblyNumber = _selectedAssembly.AssemblyNumber;
			RMAAssembly.AssemblyDescription = _selectedAssembly.Description;

			RMAAssembly.Failure_Type = _selectedFailureType.ID;
			RMAAssembly.FailureTypeDescription = _selectedFailureType.Description;

			RMAAssembly.Failure_Notes = txtFailureNotes.Text.Trim();
			RMAAssembly.Failure_GridLocation = txtLocation.Text.Trim();
			RMAAssembly.Discarded = chkDiscard.Checked;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void NumUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		/// <summary>
		/// Sets assembly type combobox to appropriate types for the selected assembly category.
		/// </summary>
		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChanges)
				return;

			_selectedAssemblyCategory = (ClassAssemblyCategory)cmbCategory.SelectedItem;

			PopulateTypes();
		}

		private void PopulateTypes()
		{
			_assemblyTypes = _selectedAssemblyCategory == null ? null : ClassAssemblyType.GetByCategory(_selectedAssemblyCategory).ToList();

			cmbType.DataSource = _assemblyTypes;
			cmbType.SelectedIndex = -1;
		}

		/// <summary>
		/// Sets assembly combobox to appropriate assemblies for the selected assembly type.
		/// </summary>
		private void cmbAssemblyType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChanges)
				return;

			_selectedAssemblyType = (ClassAssemblyType)cmbType.SelectedItem;

			PopulateAssemblies();
		}

		private void cmbAssembly_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedAssembly = (ClassAssembly)cmbAssembly.SelectedItem;
		}

		private void cmbFailureType_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedFailureType = (ClassRMA_FailureType)cmbFailureType.SelectedItem;
		}

		private void PopulateAssemblies()
		{
			_assemblies = _selectedAssemblyType == null ? null : ClassAssembly.GetByType(_selectedAssemblyType).OrderBy(a => a.AssemblyNumber).ToList();

			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;

			chkDiscard.Checked = false;
			chkDiscard.Enabled = _selectedAssemblyType != null && _selectedAssemblyType.AllowDiscard;
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