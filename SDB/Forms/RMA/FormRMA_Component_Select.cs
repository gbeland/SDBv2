using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.User;
using SDB.Forms.Admin;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_Component_Select : Form
	{
		public readonly List<ClassRMA_Component> RMAComponents = new List<ClassRMA_Component>();
		private List<ClassComponent> _components = new List<ClassComponent>();

		public FormRMA_Component_Select()
		{
			InitializeComponent();

			btnNew.Visible = GS.Settings.LoggedOnUser.UserType == ClassUser.USERTYPE_MODERATOR ||
				GS.Settings.LoggedOnUser.IsAdmin;

			cmbComponent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbComponent.AutoCompleteSource = AutoCompleteSource.ListItems;
			cmbComponent.DisplayMember = "DisplayMember";
			cmbComponent.ValueMember = "ID";

			Populate();
		}

		/// <summary>
		/// To override the default info label (for example, when not allowing a quantity to be specified).
		/// </summary>
		public void SetInfoLabel(string labelText)
		{
			lblComponent.Text = labelText;
		}

		/// <summary>
		/// Show or hide the controls for RMA data entry (quantity, silkscreen ID, and component manager button).
		/// </summary>
		public void ShowControlsForRMA(bool show)
		{
			lblQty.Visible = show;
			numQty.Visible = show;

			lblSilkscreenLetter.Visible = show;
			txtSilkscreenLetter.Visible = show;

			lblSilkscreenNumbers.Visible = show;
			txtSilkscreenNumbers.Visible = show;

			btnNew.Visible = show;
		}

		private void Populate()
		{
			_components = ClassComponent.GetAll().Where(c => !c.Disabled).OrderBy(c => c.Description).ToList();
			cmbComponent.DataSource = _components;
			cmbComponent.SelectedIndex = -1;
			cmbComponent.Select();
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (!(cmbComponent.SelectedItem is ClassComponent))
			{
				MessageBox.Show("Invalid component selected.", "Invalid Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var silkscreenLetter = txtSilkscreenLetter.Text.Trim();
			if(string.IsNullOrEmpty(silkscreenLetter) && !string.IsNullOrEmpty(txtSilkscreenNumbers.Text) ||
				!string.IsNullOrEmpty(silkscreenLetter) && string.IsNullOrEmpty(txtSilkscreenNumbers.Text))
			{
				MessageBox.Show("Silkscreen letter and number must both be blank or both be provided.", "Invalid Silkscreen Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Regex.IsMatch(silkscreenLetter, "^[A-Z]*$", RegexOptions.IgnoreCase))
			{
				MessageBox.Show("Silkscreen letter designator not in a valid format.", "Invalid Silkscreen Designator", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			List<int> silkscreenNumberValues = null;
			if (!string.IsNullOrEmpty(txtSilkscreenNumbers.Text) && !string.IsNullOrEmpty(silkscreenLetter))
			{
				try
				{
					silkscreenNumberValues = ClassUtility.ListFromHypenCommaString(txtSilkscreenNumbers.Text);
				}
				catch (Exception exc)
				{
					MessageBox.Show("Silkscreen numbers not in a valid format: " + exc.Message, "Invalid Silkscreen Number Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (numQty.Value != silkscreenNumberValues.Count)
				{
					MessageBox.Show("The number of silkscreen identifiers does not match the specified quantity for this component.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (silkscreenNumberValues.Any(n => n.ToString().Length > ClassRMA_Component.MAX_SILKSCREEN_ID_LENGTH - silkscreenLetter.Length))
				{
					var lengthMessage = $"Silkscreen ID maximum length is {ClassRMA_Component.MAX_SILKSCREEN_ID_LENGTH} character{ClassRMA_Component.MAX_SILKSCREEN_ID_LENGTH.SIfPlural()}.";
					MessageBox.Show(lengthMessage, "Invalid Silkscreen ID Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			#endregion

			var component = (ClassComponent)cmbComponent.SelectedItem;
			for (var i = 0; i < numQty.Value; i++)
			{
				if (silkscreenNumberValues != null)
				{
					RMAComponents.Add(new ClassRMA_Component
									  {
										  Component = component,
										  Quantity = 1,
										  SilkscreenID = $"{silkscreenLetter}{silkscreenNumberValues[i]}"
									  });
				}
				else
				{
					RMAComponents.Add(new ClassRMA_Component
									  {
										  Component = component,
										  Quantity = (int)numQty.Value,
										  SilkscreenID = string.Empty
									  });
				}
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			RMAComponents.Clear();
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
		{
			numQty.Select();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			using (var fcm = new FormAdmin_ComponentManagement())
				fcm.ShowDialog(this);
			Populate();
		}
	}
}