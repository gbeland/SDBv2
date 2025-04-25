using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Ticket;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Symptom_Select : Form
	{
		public ClassTicket_Symptom Symptom = new ClassTicket_Symptom();

		public FormAdmin_Symptom_Select()
		{
			InitializeComponent();

			cmbSymptom.DisplayMember = "DisplayMember";
			cmbSymptom.ValueMember = "ID";
			cmbSymptom.DataSource = ClassTicket_Symptom.GetAll().ToList();
			cmbSymptom.SelectedIndex = -1;
		}

		public void SetSelectedSymptom(int? symptomId)
		{
			if (!symptomId.HasValue)
				return;

			try
			{
				cmbSymptom.SelectedValue = symptomId;
			}
			catch (InvalidOperationException)
			{
				cmbSymptom.SelectedIndex = -1;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			var selectedSymptom = (ClassTicket_Symptom)cmbSymptom.SelectedItem;
			if (selectedSymptom == null)
			{
				MessageBox.Show("You must select a symptom.", "Invalid Symptom");
				return;
			}
			Symptom = selectedSymptom;
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