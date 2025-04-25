using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Asset
{
	/// <summary>
	/// This form is only used to select a replacement Lift Type when deleting an existing one (for merge functionality).
	/// </summary>
	public partial class FormLiftType_Select : Form
	{
		public ClassLiftType LiftType;

		private readonly List<ClassLiftType> _liftTypes;

		public FormLiftType_Select()
		{
			InitializeComponent();

			_liftTypes = ClassLiftType.GetAll().ToList();
			cmbLiftTypes.DisplayMember = "DisplayMember";
			cmbLiftTypes.ValueMember = "ID";
			cmbLiftTypes.DataSource = _liftTypes;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			LiftType = (ClassLiftType)cmbLiftTypes.SelectedItem;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}