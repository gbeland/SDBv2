using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;
using SDB.MagicInfo.Classes;

namespace SDB.MagicInfo.Forms
{

    public partial class FormLFDEditor : Form
    {

        private MagicInfoServer _server;


        public FormLFDEditor()
        {
            InitializeComponent();

            //Add Event for when back button is clicked in LFDEditor
            ucAddLFDManually1.Back_Clicked += new SDB.MagicInfo.UserControls.ucLFDEditor.BackClickedEvent(this.Back);
        }

        public void Init(MagicInfoServer server, MagicInfoAsset asset = null)
        {
            SetServer(server);
            if (asset == null)
            {
                ucAddLFDManually1.Init(_server);
                HideControls();
            }
            else
            {
                ucAddLFDManually1.Init(server, asset);
                ShowLFDEditor();
            }
        }

        private void SetServer(MagicInfoServer server)
        {
            _server = server;
        }

        private void FormAddLFDToServer_Shown(object sender, EventArgs e)
        {
            if (_server == null)
                Close();
            
        }

        private void btnManualSingle_Click(object sender, EventArgs e)
        {
            ShowLFDEditor();
        }

        private void ShowLFDEditor()
        {
            ucAddLFDManually1.BringToFront();
            ucAddLFDManually1.Visible = true;
        }

        private void HideControls()
        {
            ucAddLFDManually1.Visible = false;
        }

        private void Back()
        {
            HideControls();
        }
    }
}
