using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.MagicInfo.Forms;

namespace SDB.MagicInfo.Components
{
    public partial class ActionsComponent : UserControl
    {
        public delegate void OpenServer();
        public event OpenServer OpenServerEvent;


        public ActionsComponent()
        {
            InitializeComponent();
        }

        public void HideMagicInfoButton(bool show = false)
        {
            btnConnect.Visible = show;
            tblButtonLayout.Refresh();
        }

        public void HideTeamViewerButton(bool show = false)
        {
            btnTeamviewer.Visible = show;
            tblButtonLayout.Refresh();
        }

        public void HideDispatchButton(bool show = false)
        {
            btnDispatch.Visible = show;
            tblButtonLayout.Refresh();
        }

        public void HideEscalateButton(bool show = false)
        {
            btnEscalate.Visible = show;
            tblButtonLayout.Refresh();
        }

        public void HideAllButtons(bool show = false)
        {
            HideDispatchButton(show);
            HideEscalateButton(show);
            HideMagicInfoButton(show);
            HideTeamViewerButton(show);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            OpenServerEvent?.Invoke();
        }
    }
}
