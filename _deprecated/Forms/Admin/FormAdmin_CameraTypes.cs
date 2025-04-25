using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_CameraTypes : Form
	{
		private List<ClassCameraType> _cameraTypes = new List<ClassCameraType>();
		private ClassCameraType _selectedCameraType;

		public FormAdmin_CameraTypes()
		{
			InitializeComponent();
		}

		private void FormCameraTypes_Load(object sender, EventArgs e)
		{
			Populate_CameraTypes();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Populate_CameraTypes()
		{
			_cameraTypes = ClassCameraType.GetCameraTypes().ToList();
			olvCameraTypes.SetObjects(_cameraTypes);
		}

		private void olvCameraTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedCameraType = (ClassCameraType)olvCameraTypes.SelectedObject;
		}

		private void btnCameraType_Add_Click(object sender, EventArgs e)
		{
			using (FormAdmin_CameraType_AddEdit frmCamTypeAddEdit = new FormAdmin_CameraType_AddEdit(false))
			{
				if (frmCamTypeAddEdit.ShowDialog() != DialogResult.OK)
					return;

				Populate_CameraTypes();
			}
		}

		private void btnCameraType_Edit_Click(object sender, EventArgs e)
		{
			CameraType_Edit();
		}

		private void olvCameraTypes_DoubleClick(object sender, EventArgs e)
		{
			CameraType_Edit();
		}

		private void CameraType_Edit()
		{
			if (_selectedCameraType == null)
				return;

			using (FormAdmin_CameraType_AddEdit frmCamTypeAddEdit = new FormAdmin_CameraType_AddEdit(true, _selectedCameraType.ID))
			{
				if (frmCamTypeAddEdit.ShowDialog() != DialogResult.OK)
					return;

				Populate_CameraTypes();
			}
		}

		private void btnCameraType_Remove_Click(object sender, EventArgs e)
		{
			if (_selectedCameraType == null)
				return;

			if (MessageBox.Show("Are you sure you want to delete the selected camera type?", "Confirm Camera Type Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			// Check if the camera type is used for any asset
			int cameraTypeUsedQty = ClassCameraType.GetUsedQty(_selectedCameraType.ID);
			if (cameraTypeUsedQty > 0)
			{
				MessageBox.Show(string.Format("This camera type is used {0} time{1} in the database. It cannot be deleted.", cameraTypeUsedQty, cameraTypeUsedQty == 1 ? string.Empty : "s"), "Camera Type In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			ClassCameraType.Delete(_selectedCameraType.ID);
			Populate_CameraTypes();
		}
	}
}