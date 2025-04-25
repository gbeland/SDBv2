using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using SDB.MagicInfo.Classes;

namespace SDB.MagicInfo.UserControls
{
    public partial class ucLFDEditor : UserControl
    {
        public delegate void BackClickedEvent();
        public event BackClickedEvent Back_Clicked;

        private MagicInfoServer _server;
        private MagicInfoAsset _asset;

        public enum Mode
        {
            NEW,
            EDIT,
        }

        private Mode _mode;

        public ucLFDEditor()
        {
            InitializeComponent();
        }

        public void Init(MagicInfoServer server, MagicInfoAsset asset = null)
        {
            SetServer(server);
            
            if(asset != null)
            {
                LockForEditMode();
                _asset = asset;
                _mode = Mode.EDIT;
                Populate();
            }
            else
            {
                _asset = new MagicInfoAsset();
                _mode = Mode.NEW;
                Populate();
            }
                
        }

        /// <summary>
        /// Only use if editing or viewing an existing asset and the asset has been set
        /// </summary>
        private void Populate()
        {
            assetComponent1.Populate(_asset, MagicInfoCustomer.GetByID((int)_server.Customer_ID));
            addressComponent1.Populate(_asset.Address_ID);
        }

        private void SetServer(MagicInfoServer server)
        {
            _server = server;
        }

        private bool CheckForCompletion()
        {
            if (!assetComponent1.isComplete() || !addressComponent1.isComplete())
                return false;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isComplete = CheckForCompletion();
            if (isComplete)
            {
                //Add Address if not existing
                if (addressComponent1.GetAddressID() == null)
                {
                    MagicInfoAddress address = addressComponent1.GetAddress();
                    MagicInfoAddress.AddNew(ref address);
                }

                //update asset info
                _asset = assetComponent1.GetAsset();
                _asset.Customer_ID = (int)_server.Customer_ID;
                //_asset.Market_ID = (int)_server.Market_ID;
                _asset.Server_ID = (int)_server.ID;
                _asset.Address_ID = addressComponent1.GetAddressID();

                //ADD NEW LFD
                if (_mode == Mode.NEW) 
                {
                    MagicInfoAsset.AddNew(ref _asset);
                }
                //Edit Existing LFD
                else
                {
                    MagicInfoAsset.Update(ref _asset);
                }
                
                ParentForm.Close();
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }
        }

        

        private void LockForEditMode()
        {
            //assetComponent1.tbxSerial.ReadOnly = true;
            //assetComponent1.tbxSerial.BackColor = Color.LightGray;
            btnBack.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            assetComponent1.Clear();
            addressComponent1.Clear();
            Back_Clicked?.Invoke();
        }

        
    }
}
