using System;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_PMAs_AddEdit : Form
	{
		private ClassPreventiveMaintenanceAction _pma = new ClassPreventiveMaintenanceAction();
		private readonly bool _isEditing;

		public FormAdmin_PMAs_AddEdit(bool IsEditing, int? PMAID = null)
		{
			InitializeComponent();
			_isEditing = IsEditing;

			if (_isEditing && PMAID.HasValue)
			{
				_pma = ClassPreventiveMaintenanceAction.GetByID(PMAID.Value);
				Populate();
			}

			txtDescription.Select();
		}

		private void Populate()
		{
			txtDescription.Text = _pma.Description;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtDescription.Text))
			{
				MessageBox.Show("Preventive maintenance action description cannot be blank.", "PMA Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion
			UpdatePMAObjectFromFields();
			try
			{
				if (_isEditing)
					ClassPreventiveMaintenanceAction.Update(_pma);
				else
					ClassPreventiveMaintenanceAction.AddNew(ref _pma);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add preventive maintenance action.{0}{0}{1}", Environment.NewLine, exc.Message), "PMA Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdatePMAObjectFromFields()
		{
			_pma.Description = txtDescription.Text.Trim();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
