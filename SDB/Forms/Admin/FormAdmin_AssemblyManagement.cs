using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Assembly;
using SDB.Forms.Assembly;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_AssemblyManagement : Form
	{
		private List<ClassAssemblyCategory> _categories = new List<ClassAssemblyCategory>();
		private ClassAssemblyCategory _selectedCategory;
		private List<ClassAssemblyType> _types = new List<ClassAssemblyType>();
		private ClassAssemblyType _selectedType;
		private List<ClassAssembly> _assemblies = new List<ClassAssembly>();
		private ClassAssembly _selectedAssembly;

		public FormAdmin_AssemblyManagement()
		{
			InitializeComponent();

			olvTypes.PrimarySortColumn = olcType_Description;
			olvTypes.PrimarySortOrder = SortOrder.Ascending;

			olvAssemblies.FormatRow += olvAssemblies_FormatRow;
			olvAssemblies.PrimarySortColumn = olvColAssembly_Description;
			olvAssemblies.PrimarySortOrder = SortOrder.Ascending;
				
			olcType_IsComputer.AspectGetter = x => ((ClassAssemblyType)x).NeedsPrep;
			olcType_IsComputer.AspectToStringConverter = x => string.Empty;
			olcType_IsComputer.ImageGetter = x => ((ClassAssemblyType)x).NeedsPrep ? "computer" : "none";

			olcType_AllowDiscard.AspectGetter = x => ((ClassAssemblyType)x).AllowDiscard;
			olcType_AllowDiscard.AspectToStringConverter = x => string.Empty;
			olcType_AllowDiscard.ImageGetter = x => ((ClassAssemblyType)x).AllowDiscard ? "trash" : "none";
	}

		private void FormPartsManagement_Load(object sender, EventArgs e)
		{
			Populate_Categories();
		}

		#region CATEGORIES
		private void Populate_Categories()
		{
			_categories = ClassAssemblyCategory.GetAll().ToList();

			olvCategories.SetObjects(_categories);
			txtCategory_Qty.Text = _categories.Count.ToString(CultureInfo.InvariantCulture);

			Populate_Types();
		}

		private void olvCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedCategory = (ClassAssemblyCategory)olvCategories.SelectedObject;
			_selectedType = null;
			_selectedAssembly = null;
			Populate_Types();
		}

		private void btnCategory_Add_Click(object sender, EventArgs e)
		{
			using (var categoryEditor = new FormAdmin_AssemblyCategory_AddEdit(false))
			{
				if (categoryEditor.ShowDialog() != DialogResult.OK)
					return;
				Populate_Categories();
			}
		}

		private void btnCategory_Edit_Click(object sender, EventArgs e)
		{
			Category_Edit();
		}

		private void btnCategory_Delete_Click(object sender, EventArgs e)
		{
			if (_selectedCategory == null)
				return;

			var usedQty = ClassAssemblyCategory.GetUsedQty(_selectedCategory.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Assembly Category?", _selectedCategory.Description, usedQty, Environment.NewLine),
		"Assembly Category In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (var categorySelector = new FormAssemblyCategory_Select())
				{
					categorySelector.SetInfoLabel("Select an assembly category:");
					if (categorySelector.ShowDialog() != DialogResult.OK)
						return;
					if (categorySelector.AssemblyCategory.ID == _selectedCategory.ID)
					{
						MessageBox.Show("Cannot merge Assembly Category with itself.", "Merge Assembly Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Assembly Category '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedCategory.Description, categorySelector.AssemblyCategory.Description),
						"Confirm Assembly Category Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassAssemblyCategory.Merge(_selectedCategory.ID, categorySelector.AssemblyCategory.ID);
						ClassAssemblyCategory.Delete(_selectedCategory);
						MessageBox.Show("Assembly Category merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Assembly Category merge failed: " + exc.Message, "Merge Assembly Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Assembly Category '{0}'?", _selectedCategory.Description),
		"Confirm Remove Assembly Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassAssemblyCategory.Delete(_selectedCategory);
			}
			Populate_Categories();
		}

		private void olvCategories_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Category_Edit();
		}

		private void Category_Edit()
		{
			if (_selectedCategory == null)
				return;

			var selectedIndex = olvCategories.IndexOf(olvCategories.SelectedObject);

			using (var categoryEditor = new FormAdmin_AssemblyCategory_AddEdit(true, _selectedCategory.ID))
			{
				if (categoryEditor.ShowDialog() != DialogResult.OK)
					return;

				Populate_Categories();
			}

			// Select and show last-edited item if possible
			try
			{
				olvCategories.Select();
				olvCategories.TopItemIndex = selectedIndex;
				olvCategories.SelectedIndex = selectedIndex;
			}
			catch
			{
			}
		}
		#endregion

		#region TYPES
		private void Populate_Types()
		{
			_types = _selectedCategory == null ? null : ClassAssemblyType.GetByCategory(_selectedCategory).ToList();
			
			olvTypes.EmptyListMsg = _selectedCategory == null ? "No category selected." : "No types in this category.";
			txtTypes_OfCategory.Text = _selectedCategory == null ? "(None Selected)" : _selectedCategory.Description;

			olvTypes.SetObjects(_types);
			txtType_Qty.Text = _types?.Count.ToString(CultureInfo.InvariantCulture) ?? "0";

			Populate_Assemblies();
		}

		private void olvTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedType = (ClassAssemblyType)olvTypes.SelectedObject;
			_selectedAssembly = null;
			Populate_Assemblies();
		}

		private void btnTypes_Add_Click(object sender, EventArgs e)
		{
			using (var fata = new FormAdmin_AssemblyType_AddEdit(_selectedCategory, false))
			{
				if (fata.ShowDialog() != DialogResult.OK)
					return;
				Populate_Types();
			}
		}

		private void btnTypes_Edit_Click(object sender, EventArgs e)
		{
			Type_Edit();
		}

		private void btnTypes_Delete_Click(object sender, EventArgs e)
		{
			if (_selectedType == null)
				return;

			var usedQty = ClassAssemblyType.GetUsedQty(_selectedType.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Assembly Type?", _selectedType.Description, usedQty, Environment.NewLine),
					"Assembly Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (var fats = new FormAssemblyType_Select())
				{
					fats.ShowQuantity(false);
					fats.SetInfoLabel("Select an assembly type:");
					if (fats.ShowDialog() != DialogResult.OK)
						return;
					if (fats.AssemblyType.ID == _selectedType.ID)
					{
						MessageBox.Show("Cannot merge Assembly Type with itself.", "Merge Assembly Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Assembly Type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedType.Description, fats.AssemblyType.Description),
						"Confirm Assembly Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassAssemblyType.Merge(_selectedType.ID, fats.AssemblyType.ID);
						ClassAssemblyType.Delete(_selectedType);
						MessageBox.Show("Assembly Type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Assembly Type merge failed: " + exc.Message, "Merge Assembly Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Assembly Type '{0}'?", _selectedType.Description),
					"Confirm Remove Assembly Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassAssemblyType.Delete(_selectedType);
				//MessageBox.Show("Assembly Type remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			Populate_Types();
		}

		private void olvTypes_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Type_Edit();
		}

		private void Type_Edit()
		{
			if (_selectedType == null)
				return;

			var selectedIndex = olvTypes.IndexOf(olvTypes.SelectedObject);

			using (var fata = new FormAdmin_AssemblyType_AddEdit(_selectedCategory, true, _selectedType.ID))
			{
				if (fata.ShowDialog() != DialogResult.OK)
					return;
				Populate_Types();
			}

			// Select and show last-edited item if possible
			try
			{
				olvTypes.Select();
				olvTypes.TopItemIndex = selectedIndex;
				olvTypes.SelectedIndex = selectedIndex;
			}
			catch
			{
			}
		}
		#endregion

		#region ASSEMBLIES
		private void olvAssemblies_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var assembly = (ClassAssembly)e.Model;
			if (assembly.Disabled)
				e.Item.ForeColor = Color.LightGray;
		}

		private void Populate_Assemblies()
		{
			_assemblies = _selectedType == null ? null : ClassAssembly.GetByType(_selectedType).ToList();
			
			olvAssemblies.EmptyListMsg = _selectedType == null ? "No type selected." : "No assemblies of this type.";
			txtAssemblies_OfType.Text = _selectedType == null ? "(None Selected)" : _selectedType.Description;

			olvAssemblies.SetObjects(_assemblies);
			txtAssembly_Qty.Text = _assemblies?.Count.ToString(CultureInfo.InvariantCulture) ?? "0";
		}

		private void olvAssemblies_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshSelectedAssembly();
		}

		private void RefreshSelectedAssembly()
		{
			_selectedAssembly = (ClassAssembly)olvAssemblies.SelectedObject;
			if (_selectedAssembly == null)
				return;
			btnAssembly_EnableDisable.Text = _selectedAssembly.Disabled ? "Enable Assembly" : "Disable Assembly";
		}

		private void btnAssembly_Add_Click(object sender, EventArgs e)
		{
			using (var faa = new FormAdmin_Assembly_AddEdit(false))
			{
				if (faa.ShowDialog() != DialogResult.OK)
					return;
				Populate_Assemblies();
			}
		}

		private void btnAssembly_Edit_Click(object sender, EventArgs e)
		{
			Assembly_Edit();
		}

		private void olvAssemblies_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Assembly_Edit();
		}

		private void Assembly_Edit()
		{
			if (_selectedAssembly == null)
				return;

			var selectedIndex = olvAssemblies.IndexOf(olvAssemblies.SelectedObject);

			using (var faa = new FormAdmin_Assembly_AddEdit(true, _selectedAssembly.ID))
			{
				if (faa.ShowDialog() != DialogResult.OK)
					return;
				Populate_Assemblies();
			}

			// Select and show last-edited item if possible
			try
			{
				olvAssemblies.Select();
				olvAssemblies.TopItemIndex = selectedIndex;
				olvAssemblies.SelectedIndex = selectedIndex;
			}
			catch
			{
			}
		}

		private void btnAssembly_Delete_Click(object sender, EventArgs e)
		{
			if (_selectedAssembly == null)
				return;

			var usedQty = ClassAssembly.GetUsedQty(_selectedAssembly.ID);
			if (usedQty > 0)
			{
				var message = string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another assembly?", _selectedAssembly.Description, usedQty, Environment.NewLine);
				if (MessageBox.Show(message, "Assembly In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var fas = new FormAdmin_Assembly_Select(true))
				{
					if (fas.ShowDialog() != DialogResult.OK)
						return;
					if (fas.Assembly.ID == _selectedAssembly.ID)
					{
						MessageBox.Show("Cannot merge assembly with itself.", "Merge Assembly Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					var confirmation = string.Format("Assembly '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedAssembly.Description, fas.Assembly.Description);
					if (MessageBox.Show(confirmation, "Confirm Assembly Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassAssembly.Merge(_selectedAssembly, fas.Assembly);
						ClassAssembly.Delete(_selectedAssembly);
						MessageBox.Show("Assembly merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Assembly merge failed: " + exc.Message, "Merge Assembly Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove assembly '{0}'?", _selectedAssembly.Description),
					"Confirm Remove Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassAssembly.Delete(_selectedAssembly);
			}
			_selectedAssembly = null;
			Populate_Assemblies();
		}

		private void btnAssembly_EnableDisable_Click(object sender, EventArgs e)
		{
			if (_selectedAssembly == null)
				return;

			var disabledReminder = false;
			var tempAssy = new ClassAssembly();
			if (!_selectedAssembly.Disabled)
			{
				if (MessageBox.Show("Are you sure you want to disable the selected assembly?", "Confirm Assembly Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				ClassAssembly.Disable(_selectedAssembly, true);
				disabledReminder = true;
				tempAssy = _selectedAssembly;
			}
			else
				ClassAssembly.Disable(_selectedAssembly, false);

			Populate_Assemblies();
			RefreshSelectedAssembly();

			if (disabledReminder && MessageBox.Show("Do you want to specify a replacement assembly?", "Replacement Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				_selectedAssembly = tempAssy;
				Assembly_Edit();
			}
		}
		#endregion

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}