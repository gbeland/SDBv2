using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Asset
{
	/// <summary>
	/// This form is only used to select a replacement Asset Output Method when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormAsset_OutputMethod_Select : Form
	{
		public ClassOutputMethod OutputMethod;

		public FormAsset_OutputMethod_Select()
		{
			InitializeComponent();

			var outputMethods = ClassOutputMethod.GetAll().ToList();
			cmbOutputMethods.DisplayMember = "DisplayMember";
			cmbOutputMethods.ValueMember = "ID";
			cmbOutputMethods.DataSource = outputMethods;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			OutputMethod = (ClassOutputMethod)cmbOutputMethods.SelectedItem;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}