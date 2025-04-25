using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Ticket;

namespace SDB.Forms.Eparts
{
	public partial class FormEpartItem : Form
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		
		private List<ClassAssemblyCategory> _assemblyCategories;
		private List<ClassAssemblyType> _assemblyTypes;
		private List<ClassAssembly> _assemblies;

		private ClassAssemblyCategory _selectedAssemblyCategory;
		private ClassAssemblyType _selectedAssemblyType;
		private ClassAssembly _selectedAssembly;

		private bool _ignoreStateChange;
		#endregion

		#region Public Properties
		public int Quantity;
		public ClassAssemblyType AssemblyType;
		public ClassAssembly Assembly;
		#endregion

		#region Constructor
		public FormEpartItem()
		{
			InitializeComponent();

		}

		public FormEpartItem(ClassAssembly _item, int qty )
		{
			InitializeComponent();
			
			Quantity = qty;
			AssemblyType = ClassAssemblyType.GetByID(_item.AssemblyTypeID);
			Assembly = _item;
		}
		#endregion

		#region Private Methods
		private void FormShipmentItem_Shown(object sender, EventArgs e)
		{
			_assemblyCategories = ClassAssemblyCategory.GetAll().ToList();
			
			_ignoreStateChange = true;

			SetupComboboxes();
			

			if (Quantity < numQty.Minimum)
				Quantity = (int)numQty.Minimum;

			if (Quantity > numQty.Maximum)
				Quantity = (int)numQty.Maximum;

			numQty.Value = Quantity;

			if (Assembly != null)
			{
				_selectedAssemblyCategory = _assemblyCategories.Single(c => AssemblyType.CategoryID == c.ID);
				cmbCategory.SelectedValue = _selectedAssemblyCategory.ID;
				
				PopulateTypes();

				_selectedAssemblyType = AssemblyType;
				cmbType.SelectedValue = AssemblyType.ID;

				PopulateAssemblies();
				
				_selectedAssembly = Assembly;
				cmbAssembly.SelectedValue = Assembly.ID;
			}

			_ignoreStateChange = false;
		}

		private void SetupComboboxes()
		{

			cmbCategory.DisplayMember = "DisplayMember";
			cmbCategory.ValueMember = "ID";
			cmbCategory.DataSource = _assemblyCategories;
			cmbCategory.SelectedIndex = -1;

			cmbType.DisplayMember = "DisplayMember";
			cmbType.ValueMember = "ID";
			cmbType.DataSource = _assemblyTypes;
			cmbType.SelectedIndex = -1;

			cmbAssembly.DisplayMember = "DisplayMember";
			cmbAssembly.ValueMember = "ID";
			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string errors;

			if (!VerifySelectedAssembly())
				return;

			if (!Validate_ShipmentItem(out errors))
			{
				MessageBox.Show(errors, "Shipment Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Quantity = (int)numQty.Value;
			DialogResult = DialogResult.OK;
			Close();
		}

		/// <summary>
		/// Returns true if selected assembly has been verified by user and is valid.
		/// </summary>
		private bool VerifySelectedAssembly()
		{
			Assembly = (ClassAssembly)cmbAssembly.SelectedItem;

			// Can't verify, let validation handle it
			if (Assembly == null || Assembly.ID < 1)
				return true;
			
			if (!Assembly.Disabled)
				return true;

			if (Assembly.ReplacedBy.HasValue)
			{
				var replacementAssembly = ClassAssembly.FindCurrentReplacement(Assembly);
				var msg = string.Format("This assembly is disabled and has been replaced by:{0}{0}{1} ({2}){0}{0}Do you want to use it instead?", Environment.NewLine, replacementAssembly.Description, replacementAssembly.AssemblyNumber);
				var result = MessageBox.Show(msg, "Disabled Assembly with Replacement", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				switch (result)
				{
					case DialogResult.Yes:
						cmbType.SelectedValue = replacementAssembly.AssemblyTypeID;
						cmbAssembly.SelectedValue = replacementAssembly.ID;
						return true;

					case DialogResult.Cancel:
						return false;
				}
			}

			return MessageBox.Show("This assembly is disabled, are you sure you want to select it?", "Disabled Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
		}

		/// <summary>
		/// Checks if all selections match and an asset is specified. Also sets form's public properties to selected data.
		/// Also sets public variables <see cref="TicketID"/> and <see cref="RmaID"/>.
		/// </summary>
		private bool Validate_ShipmentItem(out string errors)
		{
			var sb = new StringBuilder();


			if (numQty.Value < 1)
				sb.AppendLine("The part quantity must be greater than zero.");

			if (Assembly == null || Assembly.ID < 1)
				sb.AppendLine("Must specify a valid assembly.");

			
			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
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

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
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

		private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			AssemblyType = _selectedAssemblyType = (ClassAssemblyType)cmbType.SelectedItem;
			
			PopulateAssemblies();
		}

		private void cmbAssembly_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			Assembly = (ClassAssembly)cmbAssembly.SelectedItem;
		}


		private void PopulateAssemblies()
		{
			_assemblies = _selectedAssemblyType == null ? null : ClassAssembly.GetByType(_selectedAssemblyType).OrderBy(a => a.AssemblyNumber).ToList();

			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;
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
		#endregion

	}
}