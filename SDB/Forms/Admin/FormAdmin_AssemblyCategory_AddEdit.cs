using System;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.General;

namespace SDB.Forms.Admin
{
	public sealed partial class FormAdmin_AssemblyCategory_AddEdit : Form
	{
		private ClassAssemblyCategory _assemblyCategory = new ClassAssemblyCategory();
		private readonly bool _isEditing;

		public FormAdmin_AssemblyCategory_AddEdit(bool isEditing, int? assemblyCategoryID = null)
		{
			InitializeComponent();
			_isEditing = isEditing;
			Text = $"{(_isEditing ? "Edit" : "Add")} Assembly Category";

			if (!_isEditing || !assemblyCategoryID.HasValue)
				return;

			_assemblyCategory = ClassAssemblyCategory.GetByID(assemblyCategoryID.Value);
			PopulateAssemblyType();
		}

		private void PopulateAssemblyType()
		{
			txtAssemblyTypeDescription.Text = _assemblyCategory.Description;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtAssemblyTypeDescription.Text))
			{
				MessageBox.Show("Assembly Category description cannot be blank.", "Assembly Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			Cursor = Cursors.WaitCursor;
			UpdateAssemblyCategoryObjectFromFields();
			try
			{
				if (_isEditing)
				{
					ClassAssemblyCategory.Update(_assemblyCategory);
				}
				else
					ClassAssemblyCategory.AddNew(ref _assemblyCategory);
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add assembly category. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Assembly Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor = Cursors.Default;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void UpdateAssemblyCategoryObjectFromFields()
		{
			_assemblyCategory.Description = txtAssemblyTypeDescription.Text.Trim();
		}
	}
}