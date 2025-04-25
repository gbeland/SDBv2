using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.RMA;
using SDB.Forms.RMA;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_ComponentManagement : Form
	{
		private List<ClassComponent> _components = new List<ClassComponent>();
		private ClassComponent _selectedComponent;

		public FormAdmin_ComponentManagement()
		{
			InitializeComponent();

			olvComponents.FormatRow += olvComponents_FormatRow;
		}

		private void FormComponentManagement_Load(object sender, EventArgs e)
		{
			Populate_Components();
		}

		private void olvComponents_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var component = (ClassComponent)e.Model;
			if (component.Disabled)
				e.Item.ForeColor = Color.LightGray;
		}

		private void Populate_Components()
		{
			_components = ClassComponent.GetAll().OrderBy(c => c.Description).ToList();
			olvComponents.SetObjects(_components);
			txtQty.Text = _components.Count.ToString();
		}

		private void olvComponents_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedComponent = (ClassComponent)olvComponents.SelectedObject;
			if (_selectedComponent == null)
				return;
			btnEnableDisable.Text = _selectedComponent.Disabled ? "Enable Component" : "Disable Component";
		}

		private void btnComponent_Add_Click(object sender, EventArgs e)
		{
			using (var fca = new FormAdmin_Component_AddEdit(false))
			{
				if (fca.ShowDialog() != DialogResult.OK)
					return;
				Populate_Components();
			}
		}

		private void btnComponent_Edit_Click(object sender, EventArgs e)
		{
			Component_Edit();
		}

		private void olvComponents_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Component_Edit();
		}

		private void Component_Edit()
		{
			if (_selectedComponent == null)
				return;
			using (var fca = new FormAdmin_Component_AddEdit(true, _selectedComponent.ID))
			{
				if (fca.ShowDialog() != DialogResult.OK)
					return;
				Populate_Components();
			}
		}

		private void btnComponent_Delete_Click(object sender, EventArgs e)
		{
			if (_selectedComponent == null)
				return;
			var usedQty = ClassComponent.GetUsedQty(_selectedComponent.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Component?", _selectedComponent.Description, usedQty, Environment.NewLine),
					"Component In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (var componentSelectForm = new FormRMA_Component_Select())
				{
					componentSelectForm.ShowControlsForRMA(false);
					componentSelectForm.SetInfoLabel("Select a component:");
					if (componentSelectForm.ShowDialog() != DialogResult.OK)
						return;
					if (componentSelectForm.RMAComponents[0].Component.ID == _selectedComponent.ID)
					{
						MessageBox.Show("Cannot merge Component with itself.", "Merge Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Component '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedComponent.Description, componentSelectForm.RMAComponents[0].Component.Description),
						"Confirm Component Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassComponent.Merge(_selectedComponent.ID, componentSelectForm.RMAComponents[0].Component.ID);
						ClassComponent.Delete(_selectedComponent);
						MessageBox.Show("Component merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Component merge failed: " + exc.Message, "Merge Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Component '{0}'?", _selectedComponent.Description),
					"Confirm Remove Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassComponent.Delete(_selectedComponent);
				MessageBox.Show("Component remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			Populate_Components();

			#region Deprecated
			//if (_selectedComponent == null)
			//    return;
			//if (MessageBox.Show("Are you sure you want to delete the selected component?", "Confirm Component Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
			//    return;

			//// Check if the component is used for any RMA
			//int ComponentUsedQty = ClassYSO.Component_UsedQty(_selectedComponent.ID);
			//if (ComponentUsedQty > 0)
			//{
			//    MessageBox.Show(string.Format("This component is used {0} time{1} in the database. It cannot be deleted.", ComponentUsedQty, ComponentUsedQty == 1 ? string.Empty : "s"), "Component In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//    return;
			//}
			//ClassYSO.Component_Delete(_selectedComponent);
			//Populate_Components();
			#endregion
		}

		private void btnComponent_EnableDisable_Click(object sender, EventArgs e)
		{
			if (_selectedComponent == null) return;
			if (!_selectedComponent.Disabled)
			{
				if (MessageBox.Show("Are you sure you want to disable the selected component?", "Confirm Component Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassComponent.Disable(_selectedComponent.ID, true);
			}
			else
				ClassComponent.Disable(_selectedComponent.ID, false);

			Populate_Components();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
