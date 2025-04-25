using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.MagicInfo.Classes;
using SDB.Classes.General;

namespace SDB.MagicInfo.UserControls
{
    public partial class ucTicketCreation : UserControl
    {
        MagicInfoServer _server;
        MagicInfoAsset _asset;
        MagicInfoMarket _market;
        MagicInfoCustomer _customer;
        public MagicInfoTicket _ticket;
        

        public ucTicketCreation()
        {
            InitializeComponent();
            addressComponent1.ShowButtons(false);
        }

        public void Init(int server_id, int? asset_id = null)
        {

            _server = MagicInfoServer.GetByID((int)server_id);

            if (_server == null)
                return;

            if(asset_id != null)
            {
                _asset = MagicInfoAsset.GetByID((int)asset_id);
                tbxMarketName.Text = MagicInfoCustomer.GetByID((int)_asset.Market_ID).Name;
                tbxAssetName.Text = _asset.Name;
                tbxAssetSerial.Text = _asset.Serial;
                addressComponent1.SetAddressName("Asset");
                addressComponent1.Populate(_asset.Address_ID);
            }
            else
            {
                tbxAssetName.Visible = false;
                tbxAssetSerial.Visible = false;
                addressComponent1.SetAddressName("Server");
                addressComponent1.Populate(_server.Address_ID);
            }
            tbxServerName.Text = _server.Name;
            tbxServerAlias.Text = _server.Alias;

            _customer = MagicInfoCustomer.GetByID((int)_server.Customer_ID);
            
            tbxCustomerName.Text = _customer.Name;

            List <MagicInfoIssue> issueList = MagicInfoIssue.GetAllEnabled();

            cmbIssues.DisplayMember = "Issue";
            foreach(MagicInfoIssue i in issueList)
            {
                cmbIssues.Items.Add(i);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.DialogResult = DialogResult.Cancel;
            ParentForm.Close();
        }

        private bool ValidateComplete()
        {
            Color failColor = Color.Salmon;
            Color goodColor = Color.PaleGreen;
            bool isComplete = true;

            ucSpellCheckLarge1.txtData.SelectAll();
            var userText = ucSpellCheckLarge1.txtData.Selection.Text.Trim();

            if (userText == string.Empty)
            {
                elementHost1.BackColor = failColor;
                isComplete = false;
            }
            else
            {
                elementHost1.BackColor = goodColor;
            }

            if(cmbIssues.SelectedIndex == -1)
            {
                isComplete = false;
                cmbIssues.BackColor = failColor;
            }
            else
            {
                cmbIssues.BackColor = goodColor;
            }

            if (!isComplete)
                grpEntry.BackColor = failColor;

            return isComplete;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateComplete())
                return;
            ucSpellCheckLarge1.txtData.SelectAll();
            var userText = ucSpellCheckLarge1.txtData.Selection.Text.Trim();
            MagicInfoIssue issue = (cmbIssues.SelectedItem as MagicInfoIssue);

            int? asset_id = null;
            if (_asset != null)
                asset_id = _asset.ID;

            _ticket = new MagicInfoTicket
            {
                OpenDate = DateTime.Now,
                Issue_fky = issue.ID,
                OpenUser_fky = GS.Settings.LoggedOnUser.ID,
                Asset_fky = asset_id,
                Server_fky = _server.ID,
                CurrentStatus_fky = MagicInfoStatus.GetByName("Opened").ID,
            };
            MagicInfoTicket.AddNew(ref _ticket);

            MagicInfoJournalEntry entry = new MagicInfoJournalEntry
            {
                Entry = userText,
                StartDate = DateTime.Now,
                ExpireDate = DateTime.Now.AddMinutes(10),
                User_fky = GS.Settings.LoggedOnUser.ID,
                Status_fky = (int)MagicInfoStatus.GetByName("Opened").ID,
                Ticket_fky = (int)_ticket.ID,
            };

            MagicInfoJournalEntry.AddNew(entry);

            ParentForm.DialogResult = DialogResult.OK;
            ParentForm.Close();
        }
    }
}
