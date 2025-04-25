using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Asset
{
	/// <summary>
	/// This form is only used to select a replacement Asset Cabinet Type when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormAsset_CabinetType_Select : Form
	{
		public ClassCabinetType CabinetType;

		private readonly List<ClassCabinetType> _cabinetTypes;

		public FormAsset_CabinetType_Select()
		{
			InitializeComponent();

			_cabinetTypes = ClassCabinetType.GetAll().ToList();
			cmbCabinetTypes.DisplayMember = "DisplayMember";
			cmbCabinetTypes.ValueMember = "ID";
			cmbCabinetTypes.DataSource = _cabinetTypes;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			CabinetType = (ClassCabinetType)cmbCabinetTypes.SelectedItem;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}