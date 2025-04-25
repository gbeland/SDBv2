using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Customer;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_AssetTags : Form
	{
		private List<ClassCustomerAssetTag> _tags = new List<ClassCustomerAssetTag>();
		private FormAdmin_AssetTags_New _formNewAddTag;

		public FormAdmin_AssetTags()
		{
			InitializeComponent();

		}

		private void Populate_AssetTags()
		{
			_tags = ClassCustomerAssetTag.GetAll().ToList();
			olvTags.SetObjects(_tags);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormAdmin_AssetTags_Load(object sender, EventArgs e)
		{
			Populate_AssetTags();
		}

		private void btnCameraType_Add_Click(object sender, EventArgs e)
		{
			_formNewAddTag = new FormAdmin_AssetTags_New();
			var result = _formNewAddTag.ShowDialog();
			if (result == DialogResult.OK)
			{
				ClassCustomerAssetTag newTag = new ClassCustomerAssetTag();
				newTag.Tag = _formNewAddTag.AssetTag;
				newTag.Description = _formNewAddTag.Description;
				ClassCustomerAssetTag.AddNew(ref newTag);
				Populate_AssetTags();
			}
		}

		private void btnCameraType_Remove_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to remove this tag?", "Confirm", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				ClassCustomerAssetTag.Delete(((ClassCustomerAssetTag)(olvTags.SelectedObject)).Id);
				Populate_AssetTags();
			}
		}

		private void btnCameraType_Edit_Click(object sender, EventArgs e)
		{
			var obj = (ClassCustomerAssetTag)olvTags.SelectedObject;
			_formNewAddTag = new FormAdmin_AssetTags_New(obj.Tag, obj.Description);
			var result = _formNewAddTag.ShowDialog();
			if (result == DialogResult.OK)
			{
				obj.Tag = _formNewAddTag.AssetTag;
				obj.Description = _formNewAddTag.Description;
				ClassCustomerAssetTag.Update(obj);
				Populate_AssetTags();
			}
		}
    }
}