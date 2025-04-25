using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;

namespace SDB.Forms.Assembly
{
	/// <summary>
	/// This form is only used to select a replacement Assembly Type when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormAssemblyType_Select : Form
	{
		public ClassAssemblyType AssemblyType;

		public FormAssemblyType_Select()
		{
			InitializeComponent();
			
			var assemblyTypes = ClassAssemblyType.GetAll().ToList();
			cmbAssemblyTypes.DisplayMember = "DisplayMember";
			cmbAssemblyTypes.ValueMember = "ID";
			cmbAssemblyTypes.DataSource = assemblyTypes;
		}

		/// <summary>
		/// To override the default info label (for example, when not allowing a quantity to be specified).
		/// </summary>
		public void SetInfoLabel(string labelText)
		{
			lblInfo.Text = labelText;
		}

		/// <summary>
		/// Show or hide the NumericUpDown depending on whether a quantity value should be specified.
		/// </summary>
		public void ShowQuantity(bool show)
		{
			numQty.Visible = show;
		}

		private void FormAssemblyTypeSelector_Load(object sender, EventArgs e)
		{
			numQty.Select();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			AssemblyType = (ClassAssemblyType)cmbAssemblyTypes.SelectedItem;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}
	}
}