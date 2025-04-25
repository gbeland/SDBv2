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

namespace SDB.MagicInfo.Components
{
    /// <summary>
    /// This class is for the assetinfo user control. It will only set or get textfields of the asset provided to it.
    /// It should not communicate with the SQL Database and all asset changes should be self contained.  
    /// </summary>
    public partial class AssetComponent : UserControl
    {

        //Local Copy of asset
        private MagicInfoAsset _asset;

        /// <summary>
        /// Creates a empty usercontrol
        /// </summary>
        public AssetComponent()
        {
            InitializeComponent();
            _asset = new MagicInfoAsset();
            cmbMarketList.Items.Clear();
        }

        /// <summary>
        /// Creates a asset user control and populates it with the asset info
        /// </summary>
        /// <param name="asset"></param>
        public AssetComponent(MagicInfoAsset asset, MagicInfoCustomer customer)
        {
            InitializeComponent();
            Populate(asset, customer);
        }

        /// <summary>
        /// Takes an asset and sets the text fields based on the passed asset. 
        /// It also stores local copy of the asset
        /// </summary>
        /// <param name="asset">The asset to populate the text fields with</param>
        public void Populate(MagicInfoAsset asset, MagicInfoCustomer customer)
        {
            if (customer.ID == null)
                return;

            List<MagicInfoMarket> m = MagicInfoMarket.GetAllByCustomer((int)customer.ID).ToList();

            if(m.Count == 0)
            {
                MessageBox.Show("Please Add A Market First!", "Error");
                ParentForm.Close();
                return;
            }

            cmbMarketList.Items.AddRange(m.ToArray());
            cmbMarketList.DisplayMember = "Name";

            
            cmbMarketList.SelectedIndex = 0;

            if (asset == null || asset.ID == null)
                return;

            _asset = asset;
            cmbMarketList.SelectedIndex = cmbMarketList.FindString(MagicInfoMarket.GetByID((int)_asset.Market_ID).Name);
            
            cbxIgnoreAlerts.Checked = _asset.IgnoreAlerts;
            tbxName.Text = _asset.Name;
            tbxAlias.Text = _asset.Alias;
            tbxFirmware.Text = _asset.Firmware;
            tbxModel.Text = _asset.Model;
            tbxSerial.Text = _asset.Serial;
            tbxContractNumber.Text = _asset.ContractNumber;
            if (_asset.InstallDate >= dtpInstallDate.MinDate)
                dtpInstallDate.Value = _asset.InstallDate;
            else
                dtpInstallDate.Value = dtpInstallDate.MinDate;
            tbxMAC.Text = _asset.MAC_Address;
            tbxIP.Text = _asset.IP;
            
        }

        /// <summary>
        /// Creates a new Asset based on the fields return it.
        /// </summary>
        /// <returns>MagicInfo Asset</returns>
        public MagicInfoAsset GetAsset()
        {
            _asset.Name = tbxName.Text;
            _asset.Alias = tbxAlias.Text;
            _asset.Firmware = tbxFirmware.Text;
            _asset.Model = tbxModel.Text;
            _asset.Serial = tbxSerial.Text;
            _asset.ContractNumber = tbxContractNumber.Text;
            _asset.InstallDate = dtpInstallDate.Value;
            _asset.IP = tbxIP.Text;
            _asset.MAC_Address = tbxMAC.Text;
            _asset.IgnoreAlerts = cbxIgnoreAlerts.Checked;

            if(cmbMarketList.SelectedIndex != -1)
                _asset.Market_ID = ((MagicInfoMarket)cmbMarketList.SelectedItem).ID;

            return _asset;
        }

        /// <summary>
        /// Iterates through all textboxes to see if they are blank. If they are it colors them red, if they are not it colors them green
        /// </summary>
        /// <TODO>Add ability to set color data and more advanced validating</TODO>
        /// <returns>returns true if all fields have text</returns>
        public bool isComplete()
        {
            Color failColor = Color.Salmon;
            Color goodColor = Color.PaleGreen;
            bool isComplete = true;

            //Get all textboxes from asset
            IEnumerable<TextBox> allTbx = grpInfo.Controls.Cast<Control>().OfType<TextBox>();


            foreach (TextBox tbx in allTbx)
            {
                if (tbx.Text == string.Empty)
                {
                    tbx.BackColor = failColor;
                    isComplete = false;
                }
                else
                    tbx.BackColor = goodColor;
            }
            return isComplete;
        }

        /// <summary>
        /// Sets the stored asset to new instance and clears all text fields
        /// </summary>
        public void Clear()
        {
            _asset = new MagicInfoAsset();
            IEnumerable<TextBox> allTbx = grpInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
        }

        /// <summary>
        /// Sets all text fields readonly property
        /// </summary>
        /// <param name="isReadOnly"></param>
        public void ReadOnly(bool isReadOnly)
        {
            IEnumerable<TextBox> allTbx = grpInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.ReadOnly = isReadOnly;
            dtpInstallDate.Enabled = isReadOnly;
        }

        /// <summary>
        /// gets the asset id of the currently stored Asset
        /// </summary>
        /// <returns></returns>
        public int? GetAssetID()
        {
            if (_asset.ID == null)
                return null;
            else
                return _asset.ID;
        }

    }
}
