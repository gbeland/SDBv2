using SDB.Classes.Customer;
using SDB.Classes.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB.Forms.Customer
{
    public partial class FormCustomerAdvancedEmail : Form
    {
        private List<ClassTicket_Symptom> _symptomList;
        int market_id;

        public FormCustomerAdvancedEmail(int id)
        {
            InitializeComponent();
            market_id = id;
            _symptomList = ClassTicket_Symptom.GetAll().ToList();
            
            if(ClassMarket.AdvancedEmailOptions_Enabled(market_id))
            {
                _symptomList = ClassMarket.GetEmailSymptoms(market_id);
                checkBox1.Checked = true;
                olvSymptoms.Enabled = true;
            }
            else 
            foreach (ClassTicket_Symptom s in _symptomList)
            {
                s.Selected = true;
            }

            olvSymptoms.SetObjects(_symptomList);
            olvSymptoms.PrimarySortColumn = olvColSymptom;
            olvSymptoms.PrimarySortOrder = SortOrder.Ascending;
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            olvSymptoms.Enabled = checkBox1.Checked;
            _symptomList = ClassMarket.GetEmailSymptoms(market_id);
            olvSymptoms.SetObjects(_symptomList);
        }

        private void FormCustomerAdvancedEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(checkBox1.Checked)
            {
                ClassMarket.SetAdvancedEmailOptions(market_id, true);

                foreach(ClassTicket_Symptom s in olvSymptoms.Objects)
                {
                    ClassMarket.UpsertMarketAdvEmails(market_id, s.ID, s.Selected);
                }

            }
            else
            {
                ClassMarket.SetAdvancedEmailOptions(market_id, false);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ClassTicket_Symptom s in _symptomList)
            {
                s.Selected = true;
            }

            olvSymptoms.SetObjects(_symptomList);

        }
    }
}
