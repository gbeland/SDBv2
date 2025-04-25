using System;
using System.Windows.Forms;
using SDB.Classes.Ticket;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Symptom_AddEdit : Form
	{
		public ClassTicket_Symptom Symptom { get; set; }

		public FormAdmin_Symptom_AddEdit()
		{
			InitializeComponent();
			Symptom = new ClassTicket_Symptom();
		}

		public FormAdmin_Symptom_AddEdit(ClassTicket_Symptom symptom) : this()
		{
			Symptom = symptom;
			txtSymptomName.Text = Symptom.Symptom;
			chkSymptomIsVisible.Checked = Symptom.IsVisible;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Symptom.Symptom = txtSymptomName.Text.Trim();
			Symptom.IsVisible = chkSymptomIsVisible.Checked;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}