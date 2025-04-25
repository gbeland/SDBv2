using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.Forms.Admin
{
	public sealed partial class FormAdmin_AssemblyType_AddEdit : Form
	{
		private ClassAssemblyType _assemblyType = new ClassAssemblyType();
		private readonly bool _isEditing;

		public FormAdmin_AssemblyType_AddEdit(ClassAssemblyCategory category, bool isEditing, int? assemblyTypeID = null)
		{
			InitializeComponent();
			_isEditing = isEditing;

			var categories = ClassAssemblyCategory.GetAll().ToList();
			cmbCategory.DisplayMember = "DisplayMember";
			cmbCategory.ValueMember = "ID";
			cmbCategory.DataSource = categories;
			cmbCategory.SelectedValue = category.ID;

			Text = (_isEditing ? "Edit" : "Add") + " Assembly Type";

			if (!_isEditing || !assemblyTypeID.HasValue)
				return;

			_assemblyType = ClassAssemblyType.GetByID(assemblyTypeID.Value);
			PopulateAssemblyType();
		}

		private void FormAdmin_AssemblyType_AddEdit_Load(object sender, EventArgs e)
		{
			txtAssemblyTypeDescription.Select();
		}

		private void PopulateAssemblyType()
		{
			txtAssemblyTypeDescription.Text = _assemblyType.Description;
			chkIsComputer.Checked = _assemblyType.IsComputer;
			chkAllowDiscard.Checked = _assemblyType.AllowDiscard;
			txtSerialNumberFormat.Text = _assemblyType.SerialNumberFormat;
			txtCustomsDescription.Text = _assemblyType.CustomsDescription;
			mtxtTariffCode.Text = _assemblyType.TariffCode;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void MaskedTextBox_Enter(object sender, EventArgs e)
		{
			var t = (MaskedTextBox)sender;
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
				MessageBox.Show("Assembly Type description cannot be blank.", "Assembly Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			var rmasModified = 0;
			Cursor = Cursors.WaitCursor;
			UpdateAssemblyTypeObjectFromFields();
			try
			{
				if (_isEditing)
				{
					ClassAssemblyType.Update(_assemblyType);
					rmasModified = ClassRMA.ValidateComputerAssemblyTypes();
				}
				else
					ClassAssemblyType.AddNew(ref _assemblyType);
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add assembly type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Assembly Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor = Cursors.Default;
			}

			if (rmasModified != 0)
				MessageBox.Show(string.Format("{0} RMA{1} modified for Computer Flag change.", rmasModified, rmasModified == 1 ? " was" : "s were"), "RMA Modification Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			DialogResult = DialogResult.OK;
			Close();
		}

		private void UpdateAssemblyTypeObjectFromFields()
		{
			_assemblyType.CategoryID = (int)cmbCategory.SelectedValue;
			_assemblyType.Description = txtAssemblyTypeDescription.Text.Trim();
			_assemblyType.IsComputer = chkIsComputer.Checked;
			_assemblyType.AllowDiscard = chkAllowDiscard.Checked;
			_assemblyType.SerialNumberFormat = txtSerialNumberFormat.Text;
			_assemblyType.CustomsDescription = txtCustomsDescription.Text.Trim();
			_assemblyType.TariffCode = mtxtTariffCode.Text;
		}

		private void lnkRegexLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://msdn.microsoft.com/en-us/library/az24scfc%28v=vs.110%29.aspx");
		}
	}
}