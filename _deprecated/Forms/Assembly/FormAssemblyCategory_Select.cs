using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;

namespace SDB.Forms.Assembly
{
	/// <summary>
	/// This form is only used to select a replacement Assembly Type when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormAssemblyCategory_Select : Form
	{
		public ClassAssemblyCategory AssemblyCategory;

		public FormAssemblyCategory_Select()
		{
			InitializeComponent();
			
			var assemblyCategories = ClassAssemblyCategory.GetAll().ToList();
			cmbAssemblyCategories.DisplayMember = "DisplayMember";
			cmbAssemblyCategories.ValueMember = "ID";
			cmbAssemblyCategories.DataSource = assemblyCategories;
		}

		/// <summary>
		/// To override the default info label (for example, when not allowing a quantity to be specified).
		/// </summary>
		public void SetInfoLabel(string labelText)
		{
			lblInfo.Text = labelText;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			AssemblyCategory = (ClassAssemblyCategory)cmbAssemblyCategories.SelectedItem;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}