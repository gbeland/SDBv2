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
    /// This class is for the serverinfo user control. It will only set or get textfields of the server provided to it.
    /// It should not communicate with the SQL Database and all server changes should be self contained.  
    /// </summary>
    public partial class ServerComponent : UserControl
    {

        //Local Copy of server
        private MagicInfoServer _server;

        /// <summary>
        /// Creates a empty usercontrol
        /// </summary>
        public ServerComponent()
        {
            InitializeComponent();
            _server = new MagicInfoServer();
        }

        /// <summary>
        /// Creates a server user control and populates it with the server info
        /// </summary>
        /// <param name="server"></param>
        public ServerComponent(MagicInfoServer server)
        {
            InitializeComponent();
            Populate(server);
        }

        /// <summary>
        /// Takes an server and sets the text fields based on the passed server. 
        /// It also stores local copy of the server
        /// </summary>
        public void Populate(MagicInfoServer server)
        {
            if (server == null)
                return;
            _server = server;
            tbxServerName.Text = _server.Name;
            tbxAlias.Text = _server.Alias;
            tbxServerTag.Text = _server.Tag;
            tbxServerIP.Text = _server.IP;
            tbxServerPort.Text = _server.Port;
            tbxLicense.Text = _server.License;
            tbxVersion.Text = _server.Version;
            tbxType.Text = _server.Type;
            tbxMIPassword.Text = _server.ServerPassword;
            tbxMIUsername.Text = _server.ServerUsername;
            tbxTVID.Text = _server.TeamviewerID;
            tbxTVPassword.Text = _server.TeamviewerPassword;
            cbxIsURL.Checked = server.IsUrl;
            tbxAlertEmails.Text = server.AlertEmails;
            cbxEmailCustomer.Checked = server.SendEmail;
        }

        /// <summary>
        /// Creates a new server based on the fields return it.
        /// </summary>
        public MagicInfoServer GetServer()
        {
            _server.Name = tbxServerName.Text;
            _server.Alias = tbxAlias.Text;
            _server.Tag = tbxServerTag.Text;
            _server.IP = tbxServerIP.Text;
            _server.Port = tbxServerPort.Text;
            _server.License = tbxLicense.Text;
            _server.Version = tbxVersion.Text;
            _server.Type = tbxType.Text;
            _server.ServerUsername = tbxMIUsername.Text;
            _server.ServerPassword = tbxMIPassword.Text;
            _server.TeamviewerID = tbxTVID.Text;
            _server.TeamviewerPassword = tbxTVPassword.Text;
            _server.IsUrl = cbxIsURL.Checked;
            _server.AlertEmails = tbxAlertEmails.Text;
            _server.SendEmail = cbxEmailCustomer.Checked;
            return _server;
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
            
            if (tbxServerName.Text == "")
            {
                isComplete = false;
                tbxServerName.BackColor = failColor;
            }
                
            return isComplete;
        }

        /// <summary>
        /// Sets the stored server to new instance and clears all text fields
        /// </summary>
        public void Clear()
        {
            _server = new MagicInfoServer();
            IEnumerable<TextBox> allTbx = grpServerInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
        }

        /// <summary>
        /// Sets all text fields readonly property
        /// </summary>
        /// <param name="isReadOnly"></param>
        public void ReadOnly(bool isReadOnly)
        {
            IEnumerable<TextBox> allTbx = grpServerInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.ReadOnly = isReadOnly;
            cbxIsURL.Enabled = !isReadOnly;
            cbxEmailCustomer.Enabled = !isReadOnly;
        }

        /// <summary>
        /// gets the server id of the currently stored server
        /// </summary>
        /// <returns></returns>
        public int? GetServerID()
        {
            if (_server.ID == null)
                return null;
            else
                return _server.ID;
        }

    }
}
