using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.Admin;
using SDB.Forms.Asset;
using SDB.Forms.CameraCheck;
using SDB.Forms.Customer;
using SDB.Forms.Reporting;
using SDB.Forms.RMA;
using SDB.Forms.Shipment;
using SDB.Forms.Tech;
using SDB.Forms.Ticket;
using SDB.UserControls.Camera_Check;
using SDB.UserControls.Ticket;
using SDB.MagicInfo.Forms;
using SDB.UserControls.Wiki;
using SDB.Forms.Eparts;
using System.Deployment;

using SDB.Interfaces;


namespace SDB.Forms.General
{
	public sealed partial class FormMain : Form
	{
		#region Globals
		private readonly FormRMA_List _rmaListForm = new FormRMA_List();
		private readonly FormRMA_Editor _rmaEditorForm = new FormRMA_Editor();

        //private readonly FormRMA _formRMA = new FormRMA();

		private readonly FormShipment_List _shipmentListForm = new FormShipment_List();
        private readonly FormShipment_Editor _shipmentEditorForm = new FormShipment_Editor();
		private readonly Reporting.FormReporting _reportingForm = new Reporting.FormReporting();
		private readonly FormNotifications _notificationsForm = new FormNotifications();
		private readonly FormCameraCheck_Review _cameraCheckReviewForm = new FormCameraCheck_Review();
       // private readonly FormMagicInfo _magicinfoForm = new FormMagicInfo();
        private FormEparts _epartsForm;
        private FormCameraCheck _cameraCheck;

        private int _ccDueQty, _ccReviewQty, _notificationQty;
		private DateTime _ccDueLastCleared, _ccReviewLastCleared, _notificationLastCleared;
		private readonly Color _buttonActiveColor = Color.Yellow;
		private readonly Color _buttonResetColor = SystemColors.Control;
		/// <summary>
		/// Used to iterate the collection of child forms for open/close and saving attributes.
		/// </summary>
		private readonly Form[] _childForms;

		private bool _forceClose;

		private const int _GOTO_MAX_RECENT_ITEMS = 10;
		private const int _MAX_FAILED_LOGIN_ATTEMPTS = 3;

		private readonly List<ToolStripMenuItem> _recentTickets = new List<ToolStripMenuItem>();
		private readonly List<ToolStripMenuItem> _recentAssets = new List<ToolStripMenuItem>();
		private readonly List<ToolStripMenuItem> _recentTechs = new List<ToolStripMenuItem>();
		private bool _trackerNeedsRefresh;

        private readonly AuthenticationService _authService;
        private readonly ISettingsService _settingsService;
		#endregion globals

		#region Main Form
        
        // Default constructor for Designer/Legacy support
        public FormMain() : this(new SettingsService())
        {
        }

        // Injection constructor
		public FormMain(ISettingsService settingsService)
		{
            _settingsService = settingsService;
            _authService = new AuthenticationService(_settingsService); // Composition Root for now
			InitializeComponent();
			// Text += " " + Version();
			Text += " " + Application.ProductVersion;
            
            _childForms = new[] { (Form)_rmaListForm, _rmaEditorForm, _shipmentListForm, _shipmentEditorForm, _reportingForm, _notificationsForm, _cameraCheckReviewForm };

            LoadSettings();
			ClassLogFile.AppendToLog($"Application started, version {Application.ProductVersion}.");

			WindowState = GS.Settings.WindowState;
			if (GS.Settings.WindowState == FormWindowState.Normal)
			{
				Location = GS.Settings.WindowLocation;
				Size = GS.Settings.WindowSize;

                // Ensure window is visible on screen
                var formRectangle = new Rectangle(Location, Size);
                var isVisible = false;
                foreach (var screen in Screen.AllScreens)
                {
                    if (screen.WorkingArea.IntersectsWith(formRectangle))
                    {
                        isVisible = true;
                        break;
                    }
                }

                if (!isVisible)
                {
                    Size = new Size(1087, 781);
                    var primaryScreen = Screen.PrimaryScreen;
                    Location = new Point(
                        primaryScreen.WorkingArea.X + (primaryScreen.WorkingArea.Width - Size.Width) / 2,
                        primaryScreen.WorkingArea.Y + (primaryScreen.WorkingArea.Height - Size.Height) / 2
                    );
                }
			}

			//using (var frm = new FormUpdateCheck())
			//	frm.ShowDialog();

			#region Event Subscribe
			ClassEmailQueue.QueueBusy += ClassEmailQueue_QueueBusy;
			ClassEmailQueue.ItemSent += ClassEmailQueue_ItemSent;
			ClassEmailQueue.AllSent += ClassEmailQueue_AllSent;
			ClassEmailQueue.ErrorSending += ClassEmailQueue_ErrorSending;

			_shipmentListForm.ViewTracking += ShipmentListForm_ViewTracking;
			_shipmentListForm.ViewShipment += ShipmentListForm_ViewShipment;
			_shipmentListForm.CreateShipment += ShipmentListForm_CreateShipment;

			_shipmentEditorForm.ViewAsset += ShipmentEditorForm_ViewAsset;
			_shipmentEditorForm.ViewRMA += ShipmentEditorForm_ViewRMA;
			_shipmentEditorForm.ViewTicket += ShipmentEditorForm_ViewTicket;
			_shipmentEditorForm.ViewTracking += ShipmentEditorForm_ViewTracking;
			_shipmentEditorForm.RefreshShipmentList += ShipmentEditorForm_RefreshShipmentList;

			_reportingForm.ViewRMA += ReportsForm_ViewRMA;
			_reportingForm.ViewTicket += ReportsForm_ViewTicket;

            //TODO
			_rmaListForm.ViewRMA += RMA_ViewRMA;
			_rmaListForm.CreateRMA += RMA_Create;

			_rmaEditorForm.ViewAsset += RMA_ViewAsset;
			_rmaEditorForm.ViewTicket += RMA_ViewTicket;
			_rmaEditorForm.ViewShipment += RMA_ViewShipment;
			_rmaEditorForm.ViewTech += RMA_ViewTech;
			_rmaEditorForm.ViewTracking += RMA_ViewTracking;
			_rmaEditorForm.CreateShipment += RMA_CreateShipment;

            //_epartsForm.ViewShipment += ucTechEditor1_ViewShipment;
            

            _notificationsForm.ViewObject += Notifications_ViewObject;
			_notificationsForm.RefreshNotificationsOnMain += Notifications_Refresh;

			_cameraCheckReviewForm.OpenNewTicket += CreateTicketForCameraCheck;
			_cameraCheckReviewForm.FormClosing += CameraCheckReviewForm_FormClosing;
            #endregion
        }

		//public string Version()
		//{
		//	Version myVersion;

		//	if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
		//	{
		//		myVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
		//		return myVersion.ToString();
		//	}
		//	else return "";

		//}

		private void FormMain_Load(object sender, EventArgs e)
		{
            var thisVersion = new Version(Application.ProductVersion);
			var requiredVersion = ClassConfig.GetMinimumClientVersion();
			if (thisVersion < requiredVersion)
			{
				ClassLogFile.AppendToLog($"Incompatible version. Required: {requiredVersion}");
				var message = $"This client does not meet the minimum version requirements. Please update to version {requiredVersion} or later.";
				MessageBox.Show(message, "Incompatible Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			// Adding Launch dashboard to cam check
			_notificationLastCleared = _ccDueLastCleared = _ccReviewLastCleared = DateTime.Now;

			// Have the form capture keyboard events first.
			KeyPreview = true;

			pnlLogin.Visible = true;
			pnlLogin.BringToFront();
			txtLogin_UserID.Focus();
			AcceptButton = btnLogin;
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_forceClose && UserHasOpenRepairSessions())
			{
				e.Cancel = true;
				return;
			}

			try
			{
				var osaTempFolder = new DirectoryInfo(Path.GetTempPath());
				foreach (var file in osaTempFolder.GetFiles("*_OSA.doc"))
					file.Delete();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				Console.WriteLine("Deleting OSA temp files: " + exc.Message);
			}

			if (!_forceClose && ClassEmailQueue.IsQueueBusy && e.CloseReason == CloseReason.UserClosing)
				if (MessageBox.Show("There are email messages in the outbound queue. Are you sure you want to exit?", "Email Queue Busy", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				{
					e.Cancel = true;
					return;
				}

			if (ClassEmailQueue.IsQueueBusy)
				ClassEmailQueue.CancelAll();

			// Close child forms to save positions
			foreach (var form in _childForms)
				form.Close();


			GS.Settings.TrackerSettings = ticketTracker.GetTrackerSettings();

			if (GS.Settings.LoggedOnUser != null && GS.Settings.LoggedOnUser.ID != -1)
				LogOff();

			if (WindowState == FormWindowState.Normal)
			{
				GS.Settings.WindowLocation = Location;
				GS.Settings.WindowSize = Size;
			}

			GS.Settings.WindowState = WindowState;
			GS.Settings.SaveSettings();
			ClassLogFile.AppendToLog("Application exited.");
		}

		/// <summary>
		/// Checks for RMA repair sessions in progress by the logged-on user.
		/// If none, returns false;
		/// If any, asks user if they want to cancel logoff (keep sessions open). If user cancels, returns true.
		/// Otherwise, closes all open sessions and returns false.
		/// </summary>
		/// <returns></returns>
		private bool UserHasOpenRepairSessions()
		{
			if (GS.Settings.LoggedOnUser == null)
				return false;

			List<ClassRMA.ClassRMAAssembly.ClassRMAAssembly_InProgressItem> assemblyRepairs;
			try
			{
				assemblyRepairs = ClassRMA.ClassRMAAssembly.RMAAssembly_Repair_GetInProgressItems(GS.Settings.LoggedOnUser.ID).ToList();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				return false;
			}

			if (assemblyRepairs.Count == 0)
				return false;

			var message = string.Format("You have an RMA repair session in progress. Are you sure you want to exit?{0}{0}RMA(s):{0}{1}{0}{0}Repair session will be ended if you exit.", Environment.NewLine, string.Join(", ", assemblyRepairs.Select(r => r.RMA_ID)));
			if (MessageBox.Show(message, "RMA Repair Sessions In Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return true;

			ClassRMA.ClassRMAAssembly.EndAllRepairSessions(GS.Settings.LoggedOnUser.ID);
			return false;
		}

		private void LoadSettings()
		{
			MigrateOldSettingsAndLog();
			if (File.Exists(Path.Combine(GS.Settings.SettingsPath, ClassSettings.SETTINGS_FILE)))
				GS.LoadSettings();
			else
			{
				MessageBox.Show("No settings file was found, the settings panel will now be shown.", "Missing Settings", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				using (var settingsForm = new FormSettings())
				{
					settingsForm.ShowDialog(this);
					if (settingsForm.DialogResult == DialogResult.OK)
						LoadSettings();
				}
			}
			if (GS.Settings.TrackerSettings != null)
				ticketTracker.ApplyTrackerSettings(GS.Settings.TrackerSettings);

			if (!GS.Settings.CameraCheck_Enable)
				btnCameraCheck_Due.Visible = btnCameraCheck_Fails.Visible = false;
			else if (GS.Settings.LoggedOnUser != null && GS.Settings.LoggedOnUser.IsLoggedIn)
				btnCameraCheck_Due.Visible = btnCameraCheck_Fails.Visible = true;
		}

		/// <summary>
		/// Checks for previous "Yesco" settings file and moves it to new settings path (one time).
		/// If so, the log file is also moved if possible.
		/// </summary>
		private void MigrateOldSettingsAndLog()
		{
			var newSettingsFile = Path.Combine(GS.Settings.SettingsPath, ClassSettings.SETTINGS_FILE);
			if (File.Exists(newSettingsFile))
				return;

			var oldSettingsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Yesco", "SDB", ClassSettings.SETTINGS_FILE);
			if (!File.Exists(oldSettingsFile))
				return;

			try
			{
				Directory.CreateDirectory(GS.Settings.SettingsPath);
				File.Move(oldSettingsFile, newSettingsFile);
			}
			catch (Exception exc)
			{
				MessageBox.Show("Old settings file found, but could not be migrated: " + exc.Message);
			}

			var oldLogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Yesco", "SDB", ClassSettings.LOG_FILE);
			var newLogFIle = Path.Combine(GS.Settings.SettingsPath, ClassSettings.LOG_FILE);
			if (File.Exists(newLogFIle) || !File.Exists(oldLogFile))
				return;

			try
			{
				Directory.CreateDirectory(GS.Settings.SettingsPath);
				File.Move(oldLogFile, newLogFIle);
			}
			catch
			{
			}
		}

		private void GeneralNotes_Refresh()
		{
			var sw = new Stopwatch();
			sw.Start();
			ucGeneralNotes1.RefreshNotes();
			sw.Stop();
			Console.WriteLine("Refreshed General Notes in {0}ms", sw.ElapsedMilliseconds);
		}
		#endregion

		#region Login / Connection
		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (_authService.IsLockedOut)
			{
				ClassLogFile.AppendToLog("Multiple login failures, exiting.");
				_forceClose = true;
				Close();
                return;
			}

			if (!int.TryParse(txtLogin_UserID.Text.Trim(), out var userID))
			{
				MessageBox.Show("Login failed. Check your login and password and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            var password = txtLogin_Password.Text;
            var user = _authService.AttemptLogin(userID, password, out var message);

            if (user == null)
            {
                MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin_Password.SelectAll();
                return;
            }

            SetupUIForLogOn();

            if (message == "Temporary password used.")
            {
                ClassLogFile.AppendToLog("Temporary password used.");
                using (var frmUserDetails = new FormAdmin_User_Details(password))
                    frmUserDetails.ShowDialog(this);
            }
		}

		private void txtLogin_Password_TextChanged(object sender, EventArgs e)
		{
			AcceptButton = btnLogin;
		}

		private void txtLogin_UserID_TextChanged(object sender, EventArgs e)
		{
			AcceptButton = btnLogin;
			lnkLogin_ForgotPassword.Visible = !string.IsNullOrEmpty(txtLogin_UserID.Text);
		}

		private void lnkLogin_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!int.TryParse(txtLogin_UserID.Text.Trim(), out var userID))
				return;

			var candidateUser = ClassUser.GetByID(userID);
			if (string.IsNullOrEmpty(candidateUser?.Email))
			{
				var noEmailMessage = $"No email address is associated with user {userID}. Password must be reset by a supervisor/administrator.";
				MessageBox.Show(noEmailMessage);
				return;
			}

			var confirmMessage = $"An email will be sent to the address for user {candidateUser.ID}. Do you want to proceed?";
			var response = MessageBox.Show(confirmMessage, "Confirm Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (response != DialogResult.Yes)
				return;

			var temporaryPassword = ClassPasswordUtility.Generate(10, true, true, true, true, true);
			candidateUser.SetTemporaryPassword(temporaryPassword);
			var pwResetEmail = ClassEmailGenerator.GenerateEmail_PasswordReset(candidateUser, temporaryPassword);
			ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.PasswordReset, pwResetEmail);
			ClassEventLog.AddEntry(userID, ClassEventLog.EventTypeEnum.RequestPwReset, ClassEventLog.ObjectTypeEnum.User, userID, string.Empty);
		}



		/// <summary>
		/// Logs off the currently logged-in user and clears controls.
		/// </summary>
		private void LogOff()
		{
			// Clear recent items
			lock (_recentAssets)
			{
				_recentAssets.Clear();
			}
			if (mnuGoto_RecentAssets.HasDropDownItems)
				mnuGoto_RecentAssets.DropDownItems.Clear();
			lock (_recentTechs)
			{
				_recentTechs.Clear();
			}
			if (mnuGoto_RecentTechs.HasDropDownItems)
				mnuGoto_RecentTechs.DropDownItems.Clear();
			lock (_recentTickets)
			{
				_recentTickets.Clear();
			}
			if (mnuGoto_RecentTickets.HasDropDownItems)
				mnuGoto_RecentTickets.DropDownItems.Clear();

			// Close all child forms
			foreach (var form in _childForms)
				form.Hide();

			// Close any dialogs
			var openForms = Application.OpenForms.Cast<Form>().ToArray();
			for (var i = openForms.Length - 1; i > -1; i--)
			{
				if (openForms[i] == this)
					continue;

				// If the form is modal, dispose it
				if (openForms[i].Modal)
					openForms[i].Dispose();
			}

			// Flush and clear email queue
			ClassEmailQueue.Flush();
			var emailTimeout = new Stopwatch();
			emailTimeout.Start();
			while (ClassEmailQueue.IsQueueBusy && emailTimeout.ElapsedMilliseconds < 30000)
			{
				Thread.Sleep(500);
			}
			emailTimeout.Stop();
			ClassEmailQueue.CancelAll();

			// Clear controls and log out user
			ClearControls();
            _authService.Logout();

			GS.Settings.LoggedOnUser = null;

			// Stop timers
			tmrClock.Enabled = false;
			tmrRefresh_GeneralNotes.Enabled = false;
			tmrRefresh_Notifications.Enabled = false;
			tmrRefresh_CameraChecks.Enabled = false;
			tmrRefresh_Tracker.Enabled = false;
			tmrIdleCheck.Enabled = false;

			// Revert UI back to "Log On" mode
			pnlMain.Visible = false;
			pnlMain_RightBar.Enabled = false;
			pnlLogin.Visible = true;
			btnNotifications.Visible = false;
			btnCameraCheck_Due.Visible = false;
			btnCameraCheck_Fails.Visible = false;

			EnableMenuItems(false);

			lblStatus_User.Visible = false;
			lblStatus_User.Text = string.Empty;

			lblStatus_Connection.Text = "Logged Off";
			lblStatus_Connection.ForeColor = SystemColors.ControlText;
			lblStatus_Connection.BackColor = SystemColors.Control;

			txtLogin_UserID.Focus();
		}

		/// <summary>
		/// Sets the SDB UI up for a user logging on or off.
		/// Hides the login form, and initializes the application according to the logged-in user's preferences.
		/// </summary>
		private void SetupUIForLogOn()
		{
			AcceptButton = null;

			txtLogin_UserID.Clear();
			txtLogin_Password.Clear();

			dtpSearch_DateFrom.Value = DateTime.Now.AddDays(-7);
			dtpSearch_DateTo.Value = DateTime.Now;

			tmrClock.Enabled = true;
			tmrRefresh_GeneralNotes.Enabled = true;
			tmrRefresh_Notifications.Enabled = true;
			tmrRefresh_Tracker.Enabled = true;
			tmrRefresh_CameraChecks.Enabled = true;
			tmrIdleCheck.Enabled = true;

			pnlMain.Visible = true;
			pnlMain_RightBar.Enabled = true;
			pnlLogin.Visible = false;
			btnNotifications.Visible = true;
			btnCameraCheck_Due.Visible = GS.Settings.CameraCheck_Enable;
			btnCameraCheck_Fails.Visible = GS.Settings.CameraCheck_Enable;


            //don't uncomment 
            //   ;)
            //TstWiki w = new TstWiki();
            //this.Controls.Add(w);
            //w.Hide();
            
            EnableMenuItems(true);

			lblStatus_User.Visible = true;
			lblStatus_User.Text = GS.Settings.LoggedOnUser.ID.ToString(CultureInfo.InvariantCulture);

			lblStatus_Connection.Text = $"Logged In: {GS.Settings.LoggedOnUser.FirstL}";
			lblStatus_Connection.ForeColor = Color.Green;
			lblStatus_Connection.BackColor = Color.LightGreen;

			switch (GS.Settings.StartupMode)
			{
				case ClassSettings.StartupModeEnum.RMA:
					WindowState = FormWindowState.Minimized;
					RMA_ShowListForm();
					break;

				case ClassSettings.StartupModeEnum.Reports:
					WindowState = FormWindowState.Minimized;
					Reports_ShowForm();
					break;

				case ClassSettings.StartupModeEnum.Shipments:
					WindowState = FormWindowState.Minimized;
					ShipmentList_ShowForm();
					break;

                //Need to figure out if this entire switch can be moved to after login otherwise user data non existant. 
                //Waiting for Jared to get back to me
                //case ClassSettings.StartupModeEnum.MagicInfo:
                //    WindowState = FormWindowState.Minimized;
                //    MagicInfo_ShowForm();
                //    break;

                default:
					tabMain.SelectedTab = tabTracker;
					ticketTracker.SetViewMode(TicketTracker.ViewModes.Open);
					break;
			}
			TicketTracker_Refresh();
			GeneralNotes_Refresh();
			Notifications_RefreshQtys();
			CameraCheck_RefreshQtys();
		}

		/// <summary>
		/// Enables or disables menu items; use with log on / log off
		/// </summary>
		private void EnableMenuItems(bool enable)
		{
			mnuReports.Visible = enable;
			mnuView.Visible = enable;
			mnuRma.Visible = enable;
			mnuShipments.Visible = enable;
			mnuGoto.Visible = enable;
			mnuAdmin_UserDetails.Enabled = enable;
			mnuAdmin_LogOff.Enabled = enable;
			mnuHelp_Troubleshooting_ReportProblem.Enabled = enable;
            menuEparts.Visible = enable;

			var isAdmin = GS.Settings.LoggedOnUser != null && GS.Settings.LoggedOnUser.IsAdmin;
			var isMod = GS.Settings.LoggedOnUser != null && GS.Settings.LoggedOnUser.IsMod;

			mnuAdmin_Configure.Enabled = isAdmin || isMod;
			mnuAdmin_Config_Markets.Enabled = isAdmin || isMod;
			mnuAdmin_Config_Assemblies.Enabled = isAdmin || isMod;
			mnuAdmin_Config_RMAComponents.Enabled = isAdmin || isMod;
			mnuAdmin_Config_Salespeople.Enabled = isAdmin || isMod;

			mnuAdmin_Config_AdminEmails.Enabled = isAdmin;
			mnuAdmin_Config_RMAFailureRepair.Enabled = isAdmin;
			mnuAdmin_Config_RentalCompanies.Enabled = isAdmin;
			mnuAdmin_Config_ShipmentMethods.Enabled = isAdmin;
			mnuAdmin_Config_SymptomsSolutions.Enabled = isAdmin;
			mnuAdmin_Config_TOSChecklist.Enabled = isAdmin;
			mnuAdmin_ActivityPanel.Enabled = isAdmin;
            mnuAdmin_AssetTag_Config.Enabled = isAdmin;

        }
		#endregion

		#region Menu
		#region Administration
		private void mnuAdmin_Settings_Click(object sender, EventArgs e)
		{
			var loggedInUser = GS.Settings.LoggedOnUser;
			using (var frmSettings = new FormSettings())
			{
				frmSettings.ShowDialog(this);
				if (frmSettings.DialogResult != DialogResult.OK)
					return;

				LoadSettings();
				GS.Settings.LoggedOnUser = loggedInUser;
			}
		}

		private void mnuAdmin_UserDetails_Click(object sender, EventArgs e)
		{
			using (var frmUserDetails = new FormAdmin_User_Details())
				frmUserDetails.ShowDialog(this);
		}

		private void mnuAdmin_ActivityPanel_Click(object sender, EventArgs e)
		{
			var faa = new FormAdmin_Activity();
			faa.Show();
		}

		private void mnuAdmin_LogOff_Click(object sender, EventArgs e)
		{
			if (!UserHasOpenRepairSessions())
				LogOff();
		}

		private void mnuAdmin_Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mnuAdmin_Config_AdminEmails_Click(object sender, EventArgs e)
		{
			using (var frmAdminEmails = new FormAdmin_Emails())
				frmAdminEmails.ShowDialog(this);
		}

		private void mnuAdmin_Config_AssetOptions_Click(object sender, EventArgs e)
		{
			using (var frmAssetOptions = new FormAdmin_AssetOptions())
				frmAssetOptions.ShowDialog(this);
		}

		private void mnuAdmin_Config_CameraTypes_Click(object sender, EventArgs e)
		{
			using (var frmCameraTypes = new FormAdmin_CameraTypes())
				frmCameraTypes.ShowDialog(this);
		}

		private void mnuAdmin_Config_Markets_Click(object sender, EventArgs e)
		{
			using (var frmMarketConfig = new FormAdmin_MarketConfig())
				frmMarketConfig.ShowDialog(this);
		}

		private void mnuAdmin_Config_Assemblies_Click(object sender, EventArgs e)
		{
			using (var frmAssemblyMgmt = new FormAdmin_AssemblyManagement())
				frmAssemblyMgmt.ShowDialog(this);
		}

		private void mnuAdmin_Config_RentalCompanies_Click(object sender, EventArgs e)
		{
			using (var frmRentalCompanies = new FormAdmin_RentalCompanies())
				frmRentalCompanies.ShowDialog(this);
		}

		private void mnuAdmin_Config_Salespeople_Click(object sender, EventArgs e)
		{
			using (var frmSalespeople = new FormAdmin_Salespeople())
				frmSalespeople.ShowDialog(this);
		}

		private void mnuAdmin_Config_ShipmentMethods_Click(object sender, EventArgs e)
		{
			using (var frmShipmentMethods = new FormAdmin_ShipmentMethods())
				frmShipmentMethods.ShowDialog(this);
		}

		private void mnuAdmin_Config_SymptomsSolutions_Click(object sender, EventArgs e)
		{
			using (var frmSymptomsSolutions = new FormAdmin_SymptomsSolutions())
				frmSymptomsSolutions.ShowDialog(this);
		}

		private void mnuAdmin_Config_TechOnSiteChecklist_Click(object sender, EventArgs e)
		{
			using (var frmChecklist = new FormAdmin_PMAs())
				frmChecklist.ShowDialog(this);
		}

		private void mnuAdmin_Config_RMAFailureRepair_Click(object sender, EventArgs e)
		{
			using (var frfrm = new FormAdmin_RMA_FailureRepair_Management())
				frfrm.ShowDialog(this);
		}

		private void mnuAdmin_Config_RMAComponents_Click(object sender, EventArgs e)
		{
			using (var frc = new FormAdmin_ComponentManagement())
				frc.ShowDialog(this);
		}

		private void mnuAdmin_Config_RMAZones_Click(object sender, EventArgs e)
		{
			using (var frmZones = new FormAdmin_Rma_Zones())
				frmZones.ShowDialog(this);
		}

		private void mnuAdmin_Config_Users_Click(object sender, EventArgs e)
		{
			if (GS.Settings.LoggedOnUser.UserType == ClassUser.USERTYPE_STANDARD)
				return;

			using (var frmUsers = new FormAdmin_Users())
				frmUsers.ShowDialog(this);
		}

		private void mnuAdmin_Config_CustomerAssetTags_Click(object sender, EventArgs e)
		{
			using (var frmCustomerTags = new FormAdmin_AssetTags())
				frmCustomerTags.ShowDialog(this);
		}
		#endregion

		#region Reports
		private void mnuReports_Click(object sender, EventArgs e)
		{
			Reports_ShowForm();
		}
		#endregion

		#region View
		private void mnuView_CameraCheck_Click(object sender, EventArgs e)
		{
			CameraCheck_ShowForm();
		}

		private void mnuView_CameraCheckReview_Click(object sender, EventArgs e)
		{
			CameraCheckReview_ShowForm();
		}

		private void mnuView_CameraCheckAudit_Click(object sender, EventArgs e)
		{
			CameraCheckAudit_ShowForm();
		}

		private void mnuView_List_Ticket_Click(object sender, EventArgs e)
		{
			using (var frmTicketList = new FormList_Tickets())
			{
				frmTicketList.ShowDialog(this);
				if (frmTicketList.DialogResult != DialogResult.OK || !frmTicketList.SelectedTicketID.HasValue)
					return;
				Ticket_Load(frmTicketList.SelectedTicketID.Value);
			}
		}

		private void mnuView_List_Tech_Click(object sender, EventArgs e)
		{
			using (var frmTechList = new FormList_Techs())
			{
				if (frmTechList.ShowDialog(this) != DialogResult.OK) return;
				Tech_Load(frmTechList.SelectedTech.ID);
			}
		}

		private void mnuView_List_Rental_Click(object sender, EventArgs e)
		{
			using (var frmRentalList = new FormList_RentalCompanies())
				frmRentalList.ShowDialog(this);
		}

		private void mnuView_List_Market_Click(object sender, EventArgs e)
		{
			using (var frmMarketList = new FormList_Markets())
			{
				if (frmMarketList.ShowDialog(this) != DialogResult.OK)
					return;
				Market_Load(frmMarketList.SelectedMarket.ID);
			}
		}

		private void mnuView_List_Asset_Click(object sender, EventArgs e)
		{
			using (var frmAssetList = new FormList_Assets())
			{
				if (frmAssetList.ShowDialog(this) != DialogResult.OK)
					return;
				Asset_Load(frmAssetList.SelectedAsset.ID);
			}
		}

		private void mnuView_Refresh_Click(object sender, EventArgs e)
		{
			// Disable refresh menu temporarily
			mnuView_Refresh.Enabled = false;
			Cursor = Cursors.WaitCursor;

			// Stop refresh timers
			tmrRefresh_GeneralNotes.Stop();
			tmrRefresh_Notifications.Stop();
			tmrRefresh_Tracker.Stop();

			// Refresh all the things
			if (tabMain.SelectedTab == tabTracker)
				TicketTracker_Refresh();
			else
				_trackerNeedsRefresh = true;

			GeneralNotes_Refresh();
			Notifications_RefreshQtys();

			ucAssetEditor1.RefreshView();
			ucTicketEditor1.RefreshView();
			ucTechEditor1.RefreshView();

			// Restart refresh timers
			tmrRefresh_GeneralNotes.Start();
			tmrRefresh_Notifications.Start();
			tmrRefresh_Tracker.Start();

			// Re-enable refresh menu
			mnuView_Refresh.Enabled = true;
			Cursor = Cursors.Default;
		}
		#endregion

		#region RMA
		private void mnuRma_List_Click(object sender, EventArgs e)
		{
			RMA_List();
		}

		private void mnuRma_Migration_Click(object sender, EventArgs e)
		{
			using (var migrationForm = new FormRMA_Migrate())
			{
				migrationForm.ShowDialog();
			}
		}

		private void mnuRma_Inventory_Click(object sender, EventArgs e)
		{
			RMA_Inventory();
		}
		#endregion

		#region Shipments
		private void mnuShipments_Click(object sender, EventArgs e)
		{
			Shipments_List();
		}
		#endregion

		#region Goto
		private void Goto_RecentTickets_Addto(ClassTicket ticket)
		{
			if (ticket == null)
				return;

			// If the ticket is already in the list, move it to the top
			lock (_recentTickets)
			{
				var duplicateTicket = _recentTickets.FirstOrDefault(rt => ((int)rt.Tag) == ticket.ID);
				if (duplicateTicket != null)
					_recentTickets.RemoveAt(_recentTickets.IndexOf(duplicateTicket));

				var recentTicket = new ToolStripMenuItem();
				recentTicket.Tag = ticket.ID;
				recentTicket.Text = $"{ticket.ID} ({ticket.ExtraProperties.AssetName.Replace("&", "&&;")})";
				recentTicket.Click += recentTicket_Click;
				_recentTickets.Add(recentTicket);
				while (_recentTickets.Count > _GOTO_MAX_RECENT_ITEMS)
					_recentTickets.RemoveAt(0);
			}
			Goto_RecentTickets_PopulateMenu();
		}

		private void recentTicket_Click(object sender, EventArgs e)
		{
			var recentTicket = (ToolStripMenuItem)sender;
			if (recentTicket == null)
				return;
			Ticket_Load(Convert.ToInt32(recentTicket.Tag));
		}

		private void Goto_RecentAssets_AddTo(ClassAsset asset)
		{
			if (asset == null)
				return;

			// If the asset is already in the list, move it to the top
			lock (_recentAssets)
			{
				var duplicateAsset = _recentAssets.FirstOrDefault(ra => ((int)ra.Tag) == asset.ID);
				if (duplicateAsset != null)
					_recentAssets.RemoveAt(_recentAssets.IndexOf(duplicateAsset));

				var recentAsset = new ToolStripMenuItem();
				recentAsset.Tag = asset.ID;
				recentAsset.Text = asset.AssetName.Replace("&", "&&");
				recentAsset.Click += recentAsset_Click;
				_recentAssets.Add(recentAsset);
				while (_recentAssets.Count > _GOTO_MAX_RECENT_ITEMS)
					_recentAssets.RemoveAt(0);
			}
			Goto_RecentAssets_PopulateMenu();
		}

		private void recentAsset_Click(object sender, EventArgs e)
		{
			var recentAsset = (ToolStripMenuItem)sender;
			if (recentAsset == null)
				return;
			Asset_Load(Convert.ToInt32(recentAsset.Tag));
		}

		private void Goto_RecentTechs_AddTo(ClassTech tech)
		{
			if (tech == null)
				return;

			// If the tech is already in the list, move it to the top
			lock (_recentTechs)
			{
				var duplicateTech = _recentTechs.FirstOrDefault(rt => ((int)rt.Tag) == tech.ID);
				if (duplicateTech != null)
					_recentTechs.RemoveAt(_recentTechs.IndexOf(duplicateTech));

				var recentTech = new ToolStripMenuItem();
				recentTech.Tag = tech.ID;
				recentTech.Text = tech.TechName.Replace("&", "&&");
				recentTech.Click += recentTech_Click;
				_recentTechs.Add(recentTech);
				while (_recentTechs.Count > _GOTO_MAX_RECENT_ITEMS)
					_recentTechs.RemoveAt(0);
			}
			Goto_RecentTechs_PopulateMenu();
		}

		private void recentTech_Click(object sender, EventArgs e)
		{
			var recentTech = (ToolStripMenuItem)sender;
			if (recentTech == null)
				return;
			Tech_Load(Convert.ToInt32(recentTech.Tag));
		}

		private void Goto_RecentTickets_PopulateMenu()
		{
			if (mnuGoto_RecentTickets.HasDropDownItems)
				mnuGoto_RecentTickets.DropDownItems.Clear();

			lock (_recentTickets)
			{
				for (var i = _recentTickets.Count - 1; i >= 0; i--)
					mnuGoto_RecentTickets.DropDownItems.Add(_recentTickets[i]);
			}
		}

		private void Goto_RecentAssets_PopulateMenu()
		{
			if (mnuGoto_RecentAssets.HasDropDownItems)
				mnuGoto_RecentAssets.DropDownItems.Clear();

			lock (_recentAssets)
			{
				for (var i = _recentAssets.Count - 1; i >= 0; i--)
					mnuGoto_RecentAssets.DropDownItems.Add(_recentAssets[i]);
			}
		}

		private void Goto_RecentTechs_PopulateMenu()
		{
			if (mnuGoto_RecentTechs.HasDropDownItems)
				mnuGoto_RecentTechs.DropDownItems.Clear();

			lock (_recentTechs)
			{
				for (var i = _recentTechs.Count - 1; i >= 0; i--)
					mnuGoto_RecentTechs.DropDownItems.Add(_recentTechs[i]);
			}
		}
		#endregion

		#region Help
		private void mnuHelp_ChangeLog_Click(object sender, EventArgs e)
		{
			using (var frmChangeLog = new FormHelp_ChangeLog())
				frmChangeLog.ShowDialog(this);
		}

		private void mnuHelp_Troubleshooting_ViewLogFile_Click(object sender, EventArgs e)
		{
			var logFilePath = Path.Combine(GS.Settings.SettingsPath, ClassSettings.LOG_FILE);

			if (File.Exists(logFilePath))
			{
				try
				{
					Process.Start(logFilePath);
				}
				catch (Exception exc)
				{
					MessageBox.Show("Could not open log file: " + exc.Message, "Log File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void mnuHelp_Troubleshooting_ReportProblem_Click(object sender, EventArgs e)
		{
			using (var frmInput = new FormUserInput("Problem Report", "Please describe the bug/problem. If a ticket, RMA, or shipment is involved please include its number."))
			{
				if (frmInput.ShowDialog() != DialogResult.OK)
					return;

				// Create email with attached settings and log file
				ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.ProblemReport, ClassEmailGenerator.GenerateEmail_ProblemReport(frmInput.UserText.Trim()));
			}
		}

		private void mnuHelp_CheckUpdates_Click(object sender, EventArgs e)
		{
			using (var frmUpdateCheck = new FormUpdateCheck())
				frmUpdateCheck.ShowDialog();
		}

		private void mnuHelp_About_Click(object sender, EventArgs e)
		{
			using (var frmAbout = new FormHelp_About())
				frmAbout.ShowDialog(this);
		}
		#endregion
		#endregion Menu

		#region Timers
		private void tmrClock_Tick(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			lblRightBar_CurrentDate.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
		}

		private void tmrRefresh_GeneralNotes_Tick(object sender, EventArgs e)
		{
			GeneralNotes_Refresh();
		}

		private void tmrRefresh_Notifications_Tick(object sender, EventArgs e)
		{
			Notifications_RefreshQtys();
		}

		private void tmrRefresh_Tracker_Tick(object sender, EventArgs e)
		{
			if (GS.Settings.LoggedOnUser == null)
				return;

			if (tabMain.SelectedTab == tabTracker && this == ActiveForm)
				TicketTracker_Refresh();
			else
				_trackerNeedsRefresh = true;
		}

		private void tmrIdleCheck_Tick(object sender, EventArgs e)
		{
			if (GS.Settings.LoggedOnUser == null || !GS.Settings.LoggedOnUser.IsLoggedIn)
				return;

			var secondsSinceLastInput = DateTime.Now.AddSeconds(-GetLastInputTime());
			if (IsApplicationInFocus())
				GS.Settings.LoggedOnUser.LastInteraction = secondsSinceLastInput;

			var maxIdleSeconds = ClassConfig.GetUserIdleTimeout();
			if (!IsUserIdle(maxIdleSeconds))
				return;

			ClassLogFile.AppendToLog($"Logged out user {GS.Settings.LoggedOnUser.FirstL} due to inactivity ({maxIdleSeconds}s)");
			ClassRMA.ClassRMAAssembly.EndAllRepairSessions(GS.Settings.LoggedOnUser.ID);
			LogOff();
		}

        
        private void tmrFlasher_Notifications_Tick(object sender, EventArgs e)
		{
			if (_notificationQty > 0)
			{
				tmrFlasher_Notifications.Interval = GetIntervalBasedOnTimeSpan(DateTime.Now - _notificationLastCleared, new[] { 600, 1800, 3600 }, new[] { 3000, 1500, 500 });
				ToggleButtonColor(btnNotifications);
			}
			else
			{
				tmrFlasher_Notifications.Interval = 3000;
				ResetButtonColor(btnNotifications);
				_notificationLastCleared = DateTime.Now;
			}
		}

		private void tmrFlasher_CameraCheckDue_Tick(object sender, EventArgs e)
		{
			if (_ccDueQty > 0)
			{
				tmrFlasher_CameraCheckDue.Interval = GetIntervalBasedOnTimeSpan(DateTime.Now - _ccDueLastCleared, new[] { 300, 600, 900 }, new[] { 3000, 1500, 500 });
				ToggleButtonColor(btnCameraCheck_Due);
			}
			else
			{
				tmrFlasher_CameraCheckDue.Interval = 3000;
				ResetButtonColor(btnCameraCheck_Due);
				_ccDueLastCleared = DateTime.Now;
			}
		}

		private void tmrFlasher_CameraCheckReview_Tick(object sender, EventArgs e)
		{
			if (_ccReviewQty > 0)
			{
				tmrFlasher_CameraCheckReview.Interval = GetIntervalBasedOnTimeSpan(DateTime.Now - _ccReviewLastCleared, new[] { 600, 1200, 1800 }, new[] { 3000, 1500, 500 });
				ToggleButtonColor(btnCameraCheck_Fails);
			}
			else
			{
				tmrFlasher_CameraCheckReview.Interval = 3000;
				ResetButtonColor(btnCameraCheck_Fails);
				_ccReviewLastCleared = DateTime.Now;
			}
		}

		private void tmrRefresh_CameraChecks_Tick(object sender, EventArgs e)
		{
			CameraCheck_RefreshQtys();
		}

		private void tmrCheckLogout_Tick(object sender, EventArgs e)
		{
			if (GS.Settings.LoggedOnUser == null)
				return;

			try
			{
				if (!GS.Settings.LoggedOnUser.GetForceLogout())
					return;
			}
			catch
			{
				return;
			}

			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.LogOff, ClassEventLog.ObjectTypeEnum.User, GS.Settings.LoggedOnUser.ID, "Administrator forced logout");
			ClassRMA.ClassRMAAssembly.EndAllRepairSessions(GS.Settings.LoggedOnUser.ID);
			_forceClose = true;
			Close();
		}
        
		/// <summary>
		/// Provides a millisecond interval which can be used to change the timer used to flash buttons.
		/// Given a timespan, the absolute value in seconds is determined and used as selection criteria.
		/// As long as the timespan does not exceed the value provided in <paramref name="secondThresholds"/>,
		/// the corresponding value from <paramref name="millisecondIntervals"/> is returned.
		/// The purpose is to flash a button faster as something ages or becomes urgent. (Camera checks for example.)
		/// For example, given the following:
		/// second thresholds:    10,   60, 120
		/// ms intervals:       3000, 1500, 500
		/// The following table shows input/output results:
		/// Input  Output
		/// -----  ------
		///     0    3000
		///     9    3000
		///    75    1500
		///   200     500
		/// </summary>
		private int GetIntervalBasedOnTimeSpan(TimeSpan span, IList<int> secondThresholds, IList<int> millisecondIntervals)
		{
			if (secondThresholds.Count != millisecondIntervals.Count)
				throw new ArgumentException("Arrays must be same length.");

			var elapsedSeconds = span.Duration().TotalSeconds;
			for (var i = 0; i < secondThresholds.Count; i++)
			{
				if (elapsedSeconds < secondThresholds[i])
					return millisecondIntervals[i];
			}
			return millisecondIntervals.Last();
		}
		#endregion

		#region Create Ticket
		private void btnCreateTicket_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCreateTicket_Asset.Text))
				return;

			var assetResults = ClassAsset.Search(txtCreateTicket_Asset.Text).ToList();
			assetResults.PopulateExtraProperties();
			switch (assetResults.Count)
			{
				case 0:
					MessageBox.Show("The specified asset was not found.", "Asset Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;

				case 1:
					CreateTicketForAsset(assetResults[0].ID);
					txtCreateTicket_Asset.Clear();
					break;

				default: // more than 1
					using (var assetsListForm = new FormList_Assets(assetResults, txtCreateTicket_Asset.Text.Trim()))
					{
						if (assetsListForm.ShowDialog() != DialogResult.OK)
							return;
						CreateTicketForAsset(assetsListForm.SelectedAsset.ID);
						txtCreateTicket_Asset.Clear();
					}
					return;
			}
		}

		private void CreateTicketForAsset(int assetID)
		{
			var asset = ClassAsset.GetByID(assetID);
			asset.PopulateExtraProperties();
			if (!ClassTicket.TicketPrerequisiteCheck(asset))
				return;

			var newTicket = ClassTicket.Create(asset);
			if (newTicket == null)
				return;

			// View ticket in Ticket Editor, but mark ticket tracker as needing a refresh
			_trackerNeedsRefresh = true;

			Ticket_Load(newTicket.ID);
			ucTicketEditor1.PromptForJournalEntry();
		}

		private ClassTicket CreateTicketForCameraCheck(ClassCameraCheck check, CameraCheckReview sender)
		{
			var asset = ClassAsset.GetByID(check.Asset_ID);
			if (!ClassTicket.TicketPrerequisiteCheck(asset))
				return null;

			var newTicket = ClassTicket.CreateForCameraCheck(check, asset);
			if (newTicket == null)
				return null;

			if (check.Cover(newTicket.ID, true))// ClassCameraCheck.Cover(sender.ID, newTicket.ID, true))
			{
				_trackerNeedsRefresh = true;
				Ticket_Load(newTicket.ID);
				ucTicketEditor1.PromptForJournalEntry();
				return newTicket;
			}

			// A ticket has already been assigned to the camera check, get details about covering ticket
			var cc = ClassCameraCheck.GetByID(check.ID);
			if (cc == null)
				return newTicket;
			var message = string.Format("Ticket {0} has already been assigned to this camera check.", cc.Ticket_ID);
			MessageBox.Show(message, "Camera Check Already Covered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return newTicket;
		}

		private void txtCreateTicket_Asset_GotFocus(object sender, EventArgs e)
		{
			AcceptButton = btnCreateTicket;
		}

		private void txtCreateTicket_Asset_LostFocus(object sender, EventArgs e)
		{
			AcceptButton = null;
		}
		#endregion

		#region Search
		private void txtSearch_Enter(object sender, EventArgs e)
		{
			var thisTextBox = (TextBox)sender;
			foreach (var tb in pnlRightBar_Search.Controls.OfType<TextBox>().Where(c => c != thisTextBox))
				tb.Clear();
			AcceptButton = btnSearch;
		}

		private void txtSearch_Leave(object sender, EventArgs e)
		{
			AcceptButton = null;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtSearch_Asset.Text))
			{
				if (Asset_Search(txtSearch_Asset.Text.Trim()))
					foreach (var tb in pnlRightBar_Search.Controls.OfType<TextBox>())
						tb.Clear();
			}
			else if (!string.IsNullOrEmpty(txtSearch_Ticket.Text))
			{
				if (Ticket_Search(txtSearch_Ticket.Text.Trim()))
					foreach (var tb in pnlRightBar_Search.Controls.OfType<TextBox>())
						tb.Clear();
			}
			else if (!string.IsNullOrEmpty(txtSearch_Tech.Text))
			{
				if (Tech_Search(txtSearch_Tech.Text.Trim()))
					foreach (var tb in pnlRightBar_Search.Controls.OfType<TextBox>())
						tb.Clear();
			}
		}

		private void btnSearchAll_Click(object sender, EventArgs e)
		{
			SearchAll(txtSearch_SearchAll.Text);
		}

		private void SearchAll(string searchTerm)
		{
			if (string.IsNullOrWhiteSpace(searchTerm))
				return;
			using (var fs = new FormSearch(searchTerm))
			{
				fs.ShowDialog();
				txtSearch_SearchAll.Text = string.Empty;
				if (string.IsNullOrEmpty(fs.ResultType)) return;
				switch (fs.ResultType)
				{
					case "Ticket":
						Ticket_Load(fs.ResultID);
						break;
					case "Asset":
						Asset_Load(fs.ResultID);
						break;
					case "Tech":
						Tech_Load(fs.ResultID);
						break;
				}
			}
		}

		private void txtSearchAll_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnSearch_SearchAll;
		}

		private void txtSearchAll_Leave(object sender, EventArgs e)
		{
			AcceptButton = null;
		}

		private void btnSearchDateRange_Click(object sender, EventArgs e)
		{
			var dateFrom = dtpSearch_DateFrom.Value.Date;
			var dateTo = dtpSearch_DateTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

			if (dateFrom > dateTo)
			{
				MessageBox.Show("Invalid date range.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var foundTickets = ClassTicket.GetByOpenDate(dateFrom, dateTo).ToList();
			if (foundTickets.Count < 1)
			{
				MessageBox.Show($"No tickets were found opened between {dateFrom:yyyy-MM-dd} and {dateTo:yyyy-MM-dd}.", "No Tickets Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			foundTickets.PopulateExtraStrings();
			using (var ftl = new FormList_Tickets(foundTickets))
			{
				ftl.ShowDialog(this);
				if (ftl.DialogResult != DialogResult.OK || !ftl.SelectedTicketID.HasValue) return;
				Ticket_Load(ftl.SelectedTicketID.Value);
			}
		}
		#endregion

		#region Tracker
		private void TicketTracker_Refresh()
		{
			_trackerNeedsRefresh = false;
			var sw = new Stopwatch();
			sw.Start();
			ticketTracker.RefreshTicketList();
			sw.Stop();
			Console.WriteLine("Refreshed Ticket Tracker in {0}ms", sw.ElapsedMilliseconds);
		}

		private void ticketTracker_Ticket_Click(ClassTicket ticket)
		{
			Ticket_Load(ticket.ID);
		}

		private void ticketTracker_Tech_Click(int techID)
		{
			Tech_Load(techID);
		}

		private void ticketTracker_Asset_Click(int assetID)
		{
			Asset_Load(assetID);
		}

		private void ticketTracker_Journal_Click(ClassTicket ticket)
		{
			try
			{
				using (var journalForm = new FormJournal(ticket, ClassTicket.MAX_JOURNAL_EXPIRATION, ClassJournal.ExpirationType.Required))
				{
					if (journalForm.ShowDialog() != DialogResult.OK)
						return;

					if (journalForm.ReleaseHold)
						ticket.Release();

					

                    if (journalForm.cbxHoldTicket.Checked)
                    {
                        ticket.Hold((DateTime)journalForm.JournalEntry.ExpireDateTime);
                        journalForm.JournalEntry.JournalText = journalForm.JournalEntry.JournalText.Insert(0, "Ticket Held: ");
                    }
                   

                    ClassJournal.AddJournalEntry(ticket, journalForm.JournalEntry);

                    // Send notifications for ticket journal addition
                    ClassNotification.SendNotificationsForObject(journalForm.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.Ticket, ticket.ID);
					if (GS.Settings.AutoSubscribe_Modify)
						ClassSubscription.Subscribe(ClassSubscription.ObjectTypeEnum.Ticket, ticket.ID);

					// Send notifications for ticket journal addition expiration
					if (journalForm.JournalEntry.ExpireDateTime.HasValue)
						ClassNotification.SendNotificationsForObject("EXPIRED: " + journalForm.JournalEntry.JournalText, ClassSubscription.ObjectTypeEnum.Ticket, ticket.ID, null, journalForm.JournalEntry.ExpireDateTime.Value);
				}
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog("Error clicking Journal from ticket tracker.", exc);
				MessageBox.Show("An unexpected error occurred: " + exc.Message, "Journal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			TicketTracker_Refresh();
		}

		private void ticketTracker_TicketRental_Click(ClassTicket ticket)
		{
			Ticket_Load(ticket.ID);
			ucTicketEditor1.ShowRentalTab();
		}
		#endregion

		#region Ticket Editor
		private void ucTicketEditor1_TicketLoaded(ClassTicket ticket)
		{
			tabTicket.Text = ticket == null ? "Ticket" : $"Ticket [{ticket.ID}]";
			Goto_RecentTickets_Addto(ticket);
		}

		private void ucTicketEditor1_TicketUpdated()
		{
			_trackerNeedsRefresh = true;
		}

		private void ucTicketEditor1_ViewOSA(ClassTicket ticket, ClassAsset asset, ClassTech tech)
		{
            if (asset.IsPMC)
            {
                MessageBox.Show("This is a PMC Asset, Can Not Generate OSA.", "PMC Asset");
            }
            else
                if (ClassEmailGenerator.GenerateDocument_OSA(ticket, asset, tech))
                    OpenFile(Path.Combine(Path.GetTempPath(), $"{ticket.ID}_OSA.doc"));
       
		}

		private void ucTicketEditor1_ViewAsset(ClassAsset asset)
		{
			Asset_Load(asset.ID);
		}

		private void ucTicketEditor1_ViewMarket(ClassMarket market)
		{
			Market_Load(market.ID);
		}

		private void ucTicketEditor1_ViewTech(ClassTech tech)
		{
			Tech_Load(tech.ID);
		}

		private void ucTicketEditor1_ViewRMA(int rmaID)
		{
			RMA_Load(rmaID);
		}

		private void ucTicketEditor1_ViewShipment(int shipmentID, int ticketID)
		{
			Shipment_Load_ForTicket(shipmentID, ticketID);
		}

		private void ucTicketEditor1_ViewTracking(string trackingURL)
		{
			OpenURL(trackingURL);
		}

		private void ucTicketEditor1_CreateRMA(ClassTicket ticket)
		{
			RMA_Create(ticket);
		}

		private void ucTicketEditor1_CreateShipment(ClassTicket ticket, ClassAsset asset, ClassTech tech)
		{
			_shipmentEditorForm.CreateShipmentForTicket(ticket.ID, asset.ID, tech);
			ShipmentEditor_ShowForm();
		}

		private void ucTicketEditor1_LaunchVNC(ClassAsset asset)
		{
			VNC_Connect(asset);
		}

		private void ucTicketEditor1_LaunchDashboard(ClassAsset asset)
		{
			LaunchDashboard(asset);
		}

		private void ucTicketEditor1_LaunchTeamviewer(ClassAsset asset)
		{
			Teamviewer_Connect(asset);
		}

		/// <summary>
		/// Finds tickets where the SearchTerm is in the ticket or customer issue number.
		/// </summary>
		/// <returns>True if one or more records match, false if none found.</returns>
		private bool Ticket_Search(string searchTerm)
		{
			var foundTickets = ClassTicket.Search(searchTerm, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held | ClassTicket.TicketType.Closed).ToList();
			switch (foundTickets.Count)
			{
				case 0:
					// None found, check if deleted
					var deletedTickets = ClassTicket.Search(searchTerm, ClassTicket.TicketType.Deleted).ToList();
					if (deletedTickets.Count < 1)
						MessageBox.Show($"No tickets were found with the search term {searchTerm}.", "Ticket Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					else
						MessageBox.Show($"The only tickets matching '{searchTerm}' have been deleted.", "Ticket Deleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;

				case 1:
					Ticket_Load(foundTickets[0].ID);
					return true;

				default:
					using (var ftl = new FormList_Tickets(foundTickets, searchTerm))
					{
						ftl.ShowDialog(this);
						if (ftl.DialogResult != DialogResult.OK || !ftl.SelectedTicketID.HasValue)
							return false;
						Ticket_Load(ftl.SelectedTicketID.Value);
					}
					return true;
			}
		}

		/// <summary>
		/// Switches to the ticket tab and displays the specified ticket.
		/// </summary>
		private void Ticket_Load(int ticketID)
		{
			if (ticketID < 0)
				return;

			ucTicketEditor1.Ticket_Load(ticketID);
			tabMain.SelectedTab = tabTicket;
			BringToFront();
		}
		#endregion

		#region Asset Editor
		/// <summary>
		/// Finds assets where the SearchTerm is in the asset name, panel, or location.
		/// </summary>
		/// <returns>True if one or more records match, false if none found.</returns>
		private bool Asset_Search(string searchTerm)
		{
			if (string.IsNullOrEmpty(searchTerm)) return false;
			var foundAssets = ClassAsset.Search(searchTerm).ToList();
			switch (foundAssets.Count)
			{
				case 0:
					MessageBox.Show($"No assets were found with the search term {searchTerm}.", "Asset Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				case 1:
					ucAssetEditor1.Asset_Load(foundAssets[0].ID);
					tabMain.SelectedTab = tabAsset;
					return true;
				default:
					foundAssets.PopulateExtraProperties();
					using (var fal = new FormList_Assets(foundAssets, searchTerm))
					{
						fal.ShowDialog(this);
						if (fal.SelectedAsset != null)
							Asset_Load(fal.SelectedAsset.ID);
					}
					return true;
			}
		}

		/// <summary>
		/// Switches to the asset tab and displays the specified asset.
		/// </summary>
		/// <param name="assetID">Asset ID to load.</param>
		private void Asset_Load(int assetID)
		{
			if (assetID < 0)
				return;

			ucAssetEditor1.Asset_Load(assetID);
			tabMain.SelectedTab = tabAsset;
			BringToFront();
		}

		private void ucAssetEditor1_AssetLoaded(ClassAsset asset)
		{
			tabAsset.Text = asset == null ? "Asset" : string.Format("Asset{0}", !string.IsNullOrEmpty(asset.AssetName) ? string.Format(" [{0}]", asset.AssetName) : string.Empty);
			Goto_RecentAssets_AddTo(asset);
		}

		private void ucAssetEditor1_AssetUpdated()
		{
			_trackerNeedsRefresh = true;
		}

		private void ucAssetEditor1_AssetClicked(int assetID)
		{
			Asset_Load(assetID);
		}

		private void ucAssetEditor1_TechDoubleClicked(ClassTech tech)
		{
			ucTechEditor1.Tech_Load(tech.ID);
			tabMain.SelectedTab = tabTech;
		}

		private void ucAssetEditor1_TicketDoubleClicked(int ticketID)
		{
			Ticket_Load(ticketID);
		}

		private void ucAssetEditor1_TicketCreated(ClassTicket newTicket)
		{
			if (newTicket == null)
				return;

			_trackerNeedsRefresh = true;
			Ticket_Load(newTicket.ID);
			ucTicketEditor1.PromptForJournalEntry();
		}

		private void ucAssetEditor1_LaunchDashboard(ClassAsset asset)
		{
			LaunchDashboard(asset);
		}

		private void ucAssetEditor1_MarketDoubleClicked(ClassAsset asset)
		{
			if (asset == null) return;
			Market_Load(asset.MarketID);
		}

		private void ucAssetEditor1_OpenURL_Camera(ClassAsset asset)
		{
			var assetCameraType = ClassCameraType.GetByID(asset.Net.Webcam_Type);
			if (assetCameraType == null)
			{
				MessageBox.Show("Camera type not defined for this asset.", "Camera Type Undefined", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			OpenURL(asset.URL_CameraImage(assetCameraType));
		}

		private void ucAssetEditor1_OpenURL_IBoot(ClassAsset asset)
		{
			OpenURL(asset.URL_IBoot);
		}

		private void ucAssetEditor1_OpenURL_LatLongMap(ClassAsset asset)
		{
			if (!string.IsNullOrEmpty(asset.URL_GoogleMap))
				OpenURL(asset.URL_GoogleMap);
		}

		private void ucAssetEditor1_OpenURL_MiniGoose(ClassAsset asset)
		{
			OpenURL(asset.URL_MiniGoose);
		}

		private void ucAssetEditor1_OpenURL_Server(ClassAsset asset)
		{
			OpenURL(asset.URL_SystemIndex);
		}

		private void ucAssetEditor1_OpenURL_WebVNC(ClassAsset asset)
		{
			OpenURL(asset.URL_WebVNC);
		}

		private void ucAssetEditor1_LaunchVNC(ClassAsset asset)
		{
			VNC_Connect(asset);
		}

		private void ucAssetEditor1_LaunchTeamviewer(ClassAsset asset)
		{
			Teamviewer_Connect(asset);
		}

		private void ucAssetEditor1_CreateShipment(ClassAsset asset)
		{
			_shipmentEditorForm.CreateShipmentForAsset(asset.ID);
			ShipmentEditor_ShowForm();
		}

		private void ucAssetEditor1_ViewRMA(int rmaID)
		{
			RMA_Load(rmaID);
		}

		private void ucAssetEditor1_ViewShipment(int shipmentID, int assetID)
		{
			Shipment_Load_ForAsset(shipmentID, assetID);
		}

		private void ucAssetEditor1_ViewTracking(string trackingURL)
		{
			OpenURL(trackingURL);
		}
		#endregion

		#region Tech Editor
		/// <summary>
		/// Switches to the tech tab and displays the specified tech.
		/// </summary>
		/// <param name="techID">Tech ID to load.</param>
		private void Tech_Load(int techID)
		{
			if (techID < 0)
				return;

			ucTechEditor1.Tech_Load(techID);
			tabMain.SelectedTab = tabTech;
			BringToFront();
		}

		private void ucTechEditor1_AssetDoubleClicked(int assetID)
		{
			Asset_Load(assetID);
		}

		private void ucTechEditor1_TicketDoubleClicked(int ticketID)
		{
			Ticket_Load(ticketID);
		}

		private void ucTechEditor1_TechLoaded(ClassTech tech)
		{
			tabTech.Text = tech == null ? "Tech" : $"Tech{(string.IsNullOrEmpty(tech.TechName) ? string.Empty : $" [{tech.TechName}]")}";
			Goto_RecentTechs_AddTo(tech);
		}

		private void ucTechEditor1_TechUpdated()
		{
			_trackerNeedsRefresh = true;
		}

		private void ucTechEditor1_CreateShipment(ClassTech tech)
		{
			if (tech == null)
				return;

			_shipmentEditorForm.CreateShipmentForTech(tech.ID);
			ShipmentEditor_ShowForm();
		}

		private void ucTechEditor1_ViewRMA(int rmaID)
		{
			RMA_Load(rmaID);
		}

		private void ucTechEditor1_ViewShipment(int shipmentID)
		{
			Shipment_Load(shipmentID);
		}

		private void ucTechEditor1_ViewTracking(string trackingURL)
		{
			OpenURL(trackingURL);
		}

		/// <summary>
		/// Finds techs where the SearchTerm is in the Tech Name, Address, or one of the contact names.
		/// </summary>
		/// <returns>True if one or more records match, false if none found.</returns>
		private bool Tech_Search(string searchTerm)
		{
			var foundTechs = ClassTech.Search(searchTerm).ToList();
			switch (foundTechs.Count)
			{
				case 0:
					MessageBox.Show($"No techs were found with the search term {searchTerm}.", "Tech Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				case 1:
					ucTechEditor1.Tech_Load(foundTechs[0].ID);
					tabMain.SelectedTab = tabTech;
					return true;
				default:
					using (var ftl = new FormList_Techs(foundTechs, searchTerm))
					{
						ftl.ShowDialog(this);
						if (ftl.SelectedTech != null)
						{
							ucTechEditor1.Tech_Load(ftl.SelectedTech.ID);
							tabMain.SelectedTab = tabTech;
						}
					}
					return true;
			}
		}
		#endregion

		#region Market
		private void Market_Load(int marketID)
		{
			if (marketID < 0)
				return;

			customerEditor1.Market_Load(marketID);
			tabMain.SelectedTab = tabMarket;
			BringToFront();
		}

		private void MarketLoaded(ClassMarket market)
		{
			tabMarket.Text = ClassUtility.StringFormatNull("Market [{0}: {1}]", "Market", market?.CustomerPrefix, market?.Name);
		}

		private void customerEditor1_MarketUpdated()
		{
			_trackerNeedsRefresh = true;
		}
		#endregion

		#region Email Processing
		private void ClassEmailQueue_QueueBusy()
		{
			if (InvokeRequired)
			{
				BeginInvoke(new MethodInvoker(ClassEmailQueue_QueueBusy));
				return;
			}
			// Change status to indicate current queue condition
			lblStatus_Email.Text = $"Email: Sending ({ClassEmailQueue.QueueSize + 1})";
			lblStatus_Email.IsLink = false;
		}

		private void ClassEmailQueue_ErrorSending(ClassEmailQueue.ClassQueueObject queueObject)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new MethodInvoker(() => ClassEmailQueue_ErrorSending(queueObject)));
				return;
			}
			if (queueObject.AssociatedTicket == null)
				return;

			// Skip if email is Supervisory
			if (queueObject.EmailType == ClassEmailQueue.EmailTypeEnum.SupervisorNotice)
				return;

			// Change status to indicate current queue condition
			lblStatus_Email.Text = "Email: Error";
			lblStatus_Email.IsLink = true;

			// Update related ticket
			var ticket = ClassTicket.GetByID(queueObject.AssociatedTicket.Value);
			var journalText = $"Error sending {queueObject.EmailType} email: {queueObject.EventLog.Last()} (Attempt {queueObject.Tries}/{queueObject.MaxTries})";
			ClassJournal.AddJournalEntry(ticket, journalText, null, true);
			ClassNotification.SendNotificationsForObject(journalText, ClassSubscription.ObjectTypeEnum.Ticket, queueObject.AssociatedTicket.Value);
		}

		private void ClassEmailQueue_AllSent()
		{
			if (InvokeRequired)
			{
				BeginInvoke(new MethodInvoker(ClassEmailQueue_AllSent));
				return;
			}
			lblStatus_Email.Text = "Email: Idle";
			lblStatus_Email.IsLink = false;
		}

		private void ClassEmailQueue_ItemSent(ClassEmailQueue.ClassQueueObject queueObject)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new MethodInvoker(() => ClassEmailQueue_ItemSent(queueObject)));
				return;
			}

			if (queueObject.AssociatedTicket == null)
				return;

			if (queueObject.EmailType == ClassEmailQueue.EmailTypeEnum.SupervisorNotice)
				return;

			// Update related ticket
			var ticket = ClassTicket.GetByID(queueObject.AssociatedTicket.Value);
			var entry = $"{ClassEmailQueue.EMAIL_TYPE_TO_STRING_LOOKUP[queueObject.EmailType]} email successfully sent ({queueObject.Message.To})";
			ClassJournal.AddJournalEntry(ticket, entry, null, true);
			// TODO: possibly add support for RMA Journals for RMA emails to techs
			ClassNotification.SendNotificationsForObject(entry, ClassSubscription.ObjectTypeEnum.Ticket, queueObject.AssociatedTicket.Value);

			switch (queueObject.EmailType)
			{
				case ClassEmailQueue.EmailTypeEnum.OSA:
					ClassTicket.SetEmail_OSA(queueObject.AssociatedTicket.Value, true);
					break;
                case ClassEmailQueue.EmailTypeEnum.PMC:
                    ClassTicket.SetEmail_OSA(queueObject.AssociatedTicket.Value, true);
                    break;

                case ClassEmailQueue.EmailTypeEnum.Open:
				case ClassEmailQueue.EmailTypeEnum.OpenNow:
				case ClassEmailQueue.EmailTypeEnum.ReOpenTicket:
					ClassTicket.SetEmail_Open(queueObject.AssociatedTicket.Value, true);
					break;
			}
			queueObject.Message.Dispose();
		}

		private void lblStatus_Email_Click(object sender, EventArgs e)
		{
			if (!lblStatus_Email.IsLink)
				return;

			MessageBox.Show(ClassEmailQueue.GetStatus());
		}
		#endregion

		#region Shipment List
		private void ShipmentList_ShowForm()
		{
			_shipmentListForm.Show();
			if (_shipmentListForm.WindowState == FormWindowState.Minimized)
				_shipmentListForm.WindowState = FormWindowState.Normal;
			_shipmentListForm.BringToFront();
		}

		/// <summary>
		/// Opens the shipment form showing the currently open shipment list.
		/// </summary>
		private void Shipments_List()
		{
			_shipmentListForm.Shipments_List_Ready();
			ShipmentList_ShowForm();
		}

		private void ShipmentListForm_ViewTracking(string trackingURL)
		{
			OpenURL(trackingURL);
		}

		private void ShipmentListForm_ViewShipment(int shipmentID)
		{
			Shipment_Load(shipmentID);
		}

		private void ShipmentListForm_CreateShipment()
		{
			_shipmentEditorForm.Show();
			_shipmentEditorForm.CreateShipment();
		}
        #endregion

        #region MagicInfo
        //public void MagicInfo_ShowForm()
        //{
        //    _magicinfoForm.BringToFront();
        //    _magicinfoForm.WindowState = FormWindowState.Normal;
        //    _magicinfoForm.Show(); 
       
        //}
        #endregion

        #region Shipment Editor
        private void ShipmentEditor_ShowForm()
		{
			_shipmentEditorForm.Show();
			if (_shipmentEditorForm.WindowState == FormWindowState.Minimized)
				_shipmentEditorForm.WindowState = FormWindowState.Normal;
			_shipmentEditorForm.BringToFront();
		}

		/// <summary>
		/// Opens the shipment form with the specified Shipment loaded. The shipment will have an affinity
		/// for the specified ticket. (New items added auto-populate that ticket number).
		/// </summary>
		private void Shipment_Load_ForTicket(int shipmentID, int ticketID)
		{
			_shipmentEditorForm.Shipment_Load_ForTicket(shipmentID, ticketID);
			ShipmentEditor_ShowForm();
		}

		/// <summary>
		/// Opens the shipment form with the specified Shipment loaded. The shipment will have an affinity
		/// for the specified asset. (New items added auto-populate that asset).
		/// </summary>
		private void Shipment_Load_ForAsset(int shipmentID, int assetID)
		{
			_shipmentEditorForm.Shipment_Load_ForAsset(shipmentID, assetID);
			ShipmentEditor_ShowForm();
		}

		/// <summary>
		/// Opens the shipment form with the specified Shipment loaded, or blank if unspecified.
		/// </summary>
		private void Shipment_Load(int shipmentID)
		{
			_shipmentEditorForm.Shipment_Load(shipmentID);
			ShipmentEditor_ShowForm();
		}

		private void ShipmentEditorForm_ViewAsset(int itemID)
		{
			Asset_Load(itemID);
		}

		private void ShipmentEditorForm_ViewRMA(int itemID)
		{
			RMA_Load(itemID);
		}

		private void ShipmentEditorForm_ViewTicket(int itemID)
		{
			Ticket_Load(itemID);
		}

		private void ShipmentEditorForm_ViewTracking(string trackingURL)
		{
			OpenURL(trackingURL);
		}

		private void ShipmentEditorForm_RefreshShipmentList()
		{
			_shipmentListForm.RefreshSelectedShipmentList();
		}

		/// <summary>
		/// Shows the Shipments form and begins creation of a new shipment for the specified RMA.
		/// </summary>
		private void Shipment_Create(int rmaID)
		{
			ShipmentEditor_ShowForm();
			_shipmentEditorForm.CreateShipmentForRMA(rmaID);
		}
		#endregion

		#region RMA
		private void RMA_Load(int rmaID, FormRMA_Editor.ViewEnum viewType = FormRMA_Editor.ViewEnum.Assemblies)
		{
			_rmaEditorForm.RMA_Load(rmaID);
			_rmaEditorForm.SetView(viewType);
			_rmaEditorForm.Show();
			_rmaEditorForm.BringToFront();
		}

   
		private void RMA_ShowListForm()
		{
            //RMA_Show();
			_rmaListForm.Show();
            _rmaListForm.WindowState = FormWindowState.Normal;
            _rmaListForm.BringToFront();
		}

        private void RMA_Show(int? rma_id = null)
        {
            //_formRMA.Show();
            //_formRMA.WindowState = FormWindowState.Normal;
            //_formRMA.BringToFront();
        }

		private void RMA_List()
		{
            //_formRMA.Populate();
            _rmaListForm.RMA_List_Received();
            RMA_ShowListForm();
		}

		private void RMA_Inventory()
		{
			using (var rmaInventoryForm = new FormRMA_Inventory())
			{
				rmaInventoryForm.ViewRMA += RMA_ViewRMA;
				rmaInventoryForm.ShowDialog(this);
			}
		}

		/// <summary>
		/// Begins creation of an RMA based on the specified ticket. (Autopopulates ticket, assembly types, asset and tech.)
		/// </summary>
		private void RMA_Create(ClassTicket ticket)
		{
			ClassRMA newRMA;
			using (var frc = new FormRMA_Create(ticket.ID))
			{
				frc.ShowDialog(this);
				if (frc.DialogResult != DialogResult.OK)
					return;

				newRMA = ClassRMA.GetRMA(frc.NewRmaID);
			}
			Ticket_Load(ticket.ID);
			if (!newRMA.IsAPR)
				return;

			MessageBox.Show("This RMA is for Advanced Parts Replacement, and requires that a shipment be created.", "APR RMA Shipment Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Shipment_Create(newRMA.ID);
		}

		/// <summary>
		/// Begins the creation of an RMA (no auto-population).
		/// </summary>
		private void RMA_Create()
		{
			ClassRMA newRMA;
			using (var frc = new FormRMA_Create())
			{
				frc.ShowDialog(this);
				if (frc.DialogResult != DialogResult.OK)
					return;

				newRMA = ClassRMA.GetRMA(frc.NewRmaID);
			}
			if (!newRMA.IsAPR)
				return;

			MessageBox.Show("This RMA is for Advanced Parts Replacement, and requires that a shipment be created.", "APR RMA Shipment Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Shipment_Create(newRMA.ID);
		}

		private void RMA_ViewRMA(int rmaID, FormRMA_Editor.ViewEnum viewType = FormRMA_Editor.ViewEnum.Assemblies)
		{
			RMA_Load(rmaID, viewType);
		}

		private void RMA_ViewAsset(int assetID)
		{
			Asset_Load(assetID);
		}

		private void RMA_ViewTicket(int ticketID)
		{
			Ticket_Load(ticketID);
		}

		private void RMA_ViewShipment(int shipmentID)
		{
			Shipment_Load(shipmentID);
		}

		private void RMA_ViewTech(int techID)
		{
			Tech_Load(techID);
		}

		private void RMA_ViewTracking(string trackingURL)
		{
			OpenURL(trackingURL);
		}

		private void RMA_CreateShipment(int rmaID)
		{
			try
			{
				_shipmentEditorForm.CreateShipmentForRMA(rmaID);
				ShipmentEditor_ShowForm();
			}
			catch (Exception exc)
			{
				MessageBox.Show("An error occurred creating a shipment from the RMA: " + exc.Message, "Error Creating Shipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Reports
		private void Reports_ShowForm()
		{
            _reportingForm.Show();
		}

		private void ReportsForm_ViewRMA(int rmaID)
		{
			RMA_Load(rmaID);
		}

		private void ReportsForm_ViewTicket(int ticketID)
		{
			Ticket_Load(ticketID);
		}
		#endregion

		#region Notifications
		private void Notifications_RefreshQtys()
		{
			var sw = new Stopwatch();
			sw.Start();
			try
			{
				_notificationQty = ClassNotification.GetNotificationCount_Current();
			}
			catch (MySqlException exc)
			{
				ClassLogFile.AppendToLog("Error refreshing notifications:", exc);
			}

			btnNotifications.Text = $"Notifications ({_notificationQty})";

			sw.Stop();
			Console.WriteLine("Refreshed Notifications in {0}ms", sw.ElapsedMilliseconds);
		}

		private void Notifications_Refresh()
		{
			Notifications_RefreshQtys();
		}

		private void btnNotifications_Click(object sender, EventArgs e)
		{
			Notifications_ShowForm();
		}

		private void mnuView_Notifications_Click(object sender, EventArgs e)
		{
			Notifications_ShowForm();
		}

		private void Notifications_ShowForm()
		{
			_notificationsForm.Show();
			_notificationsForm.WindowState = FormWindowState.Normal;
			_notificationsForm.BringToFront();
		}

		private void Notifications_ViewObject(int objectID, ClassSubscription.ObjectTypeEnum objecttype)
		{
			switch (objecttype)
			{
				case ClassSubscription.ObjectTypeEnum.Asset:
					Asset_Load(objectID);
					break;

				case ClassSubscription.ObjectTypeEnum.Customer:
					//TODO: Implement Customer Load from Notification Click
					//Customer_Load(objectID);
					break;

				case ClassSubscription.ObjectTypeEnum.Market:
					Market_Load(objectID);
					break;

				case ClassSubscription.ObjectTypeEnum.RMA:
					RMA_Load(objectID);
					break;

				case ClassSubscription.ObjectTypeEnum.Shipment:
					Shipment_Load(objectID);
					break;

				case ClassSubscription.ObjectTypeEnum.Ticket:
					Ticket_Load(objectID);
					break;
			}
		}
		#endregion

		#region Camera Checks
		private void CameraCheck_RefreshQtys()
		{
			if (!GS.Settings.CameraCheck_Enable)
				return;

			var sw = new Stopwatch();
			sw.Start();
			try
			{
				var dueQtys = ClassCameraCheck.GetDueQtys();
				_ccDueQty = dueQtys.Total;

				_ccReviewQty = ClassCameraCheck.GetFailQty();
			}
			catch (MySqlException exc)
			{
				ClassLogFile.AppendToLog("Error refreshing camera check quantities:", exc);
			}

			btnCameraCheck_Due.Text = $"CC Due ({_ccDueQty})";
			btnCameraCheck_Fails.Text = $"CC Fails ({_ccReviewQty})";

			sw.Stop();
			Console.WriteLine("Refreshed CameraCheckQtys in {0}ms", sw.ElapsedMilliseconds);
		}

		private void CameraCheck_ShowForm()
		{
			if (!ClassCameraCheck.ValidateCameraCheckFolder())
			{
				var message = string.Format("Cannot access camera check image folder:{0}{0}{1}{0}{0}Verify that folder location is accessible and correct in application settings.", Environment.NewLine, GS.Settings.CameraImagePath);
				MessageBox.Show(message, "Camera Check Folder Inaccessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            if(_cameraCheck == null || _cameraCheck.IsDisposed)
            {
                _cameraCheck = new FormCameraCheck(ClassConfig.GetCameraCheckTicketModeEnabled());
                
                _cameraCheck.ShowInTaskbar = true;
                _cameraCheck.LaunchDashboard += LaunchDashboard;
                _cameraCheck.FormClosing += CameraCheckForm_FormClosing;
                _cameraCheck.Show();
            }
            
            _cameraCheck.BringToFront();
		}

		private void CameraCheckReview_ShowForm()
		{
			if (!ClassCameraCheck.ValidateCameraCheckFolder())
			{
				var message = string.Format("Cannot access camera check image folder:{0}{0}{1}{0}{0}Verify that folder location is accessible and correct in application settings.", Environment.NewLine, GS.Settings.CameraImagePath);
				MessageBox.Show(message, "Camera Check Folder Inaccessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_cameraCheckReviewForm.Show();
			_cameraCheckReviewForm.WindowState = FormWindowState.Normal;
			_cameraCheckReviewForm.BringToFront();
		}

		private void CameraCheckAudit_ShowForm()
		{
			using (var cameraCheckAudit = new FormCameraCheck_Audit())
			{
				cameraCheckAudit.ShowDialog();
			}
		}

		private void btnCameraCheck_Due_Click(object sender, EventArgs e)
		{
			CameraCheck_ShowForm();
		}

		private void btnCameraCheck_Fails_Click(object sender, EventArgs e)
		{
			CameraCheckReview_ShowForm();
		}

		private void CameraCheckReviewForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CameraCheck_RefreshQtys();
		}

        private void CameraCheckForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BringToFront();
            CameraCheck_RefreshQtys();
        }

        #endregion

        #region Button Flashing
        private void ToggleButtonColor(Button btn)
		{
			btn.BackColor = btn.BackColor == _buttonActiveColor ? _buttonResetColor : _buttonActiveColor;
		}

		private void ResetButtonColor(Button btn)
		{
			btn.BackColor = _buttonResetColor;
		}
		#endregion

		#region Utility
		private static void OpenFile(string filePath)
		{
			if (File.Exists(filePath))
				Process.Start(filePath);
			else
				MessageBox.Show(string.Format("File does not exist: {0}", filePath), "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Opens Dashboard in the system default web browser and displays the specified asset. (Never uses WebViewer tab.)
		/// </summary>
		private static void LaunchDashboard(ClassAsset asset)
		{
			if (asset == null)
				return;
			Process.Start($"{GS.Settings.DashboardWebURL}{asset.ID}");

            //using(FormWebPage wp = new FormWebPage())
            //{
            //    string url = asset.URL_CameraAdmin; //asset.URL_WebCamLiveFeed;
            //    wp.webBrowser1.Url = new Uri(url);
            //    wp.ShowDialog();
            //}
		}

		/// <summary>
		/// Opens the specified URL in WebViewer or External Browser depending on user settings.
		/// </summary>
		/// <param name="url">URL to navigate to.</param>
		private void OpenURL(string url)
		{
			Process.Start(url);
		}

		/// <summary>
		/// Launches settings-specified VNC client and connects to the specified asset
		/// using Server IP (WAN if UseLan is false) and VNC port.
		/// If VNC port is unspecified, 5900 is attempted.
		/// If VNC password is specified it will be automatically entered using SendKeys.
		/// </summary>
		private void VNC_Connect(ClassAsset asset)
		{
			if (!File.Exists(GS.Settings.VNCPath) && !File.Exists(GS.Settings.RealVNCPath))
			{
				MessageBox.Show("Tight VNC Client or Real VNC Client  was not found, this feature will not be available.", "VNC Client Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			var vncAddress = $"{(asset.Net.UseLanAddresses ? asset.Net.LanAddress : asset.Net.WanAddress)}:{asset.Net.VNC_Port.GetValueOrDefault(5900)}";

            if(asset.Net.Use_Real_VNC)
                Process.Start(GS.Settings.RealVNCPath, vncAddress);
            else
                Process.Start(GS.Settings.VNCPath, vncAddress);

            if (string.IsNullOrWhiteSpace(asset.Net.VNC_Password))
                return;

            var specialKeys = new[] { '+', '^', '%', '~' };
            var keySequence = string.Empty;
            foreach (var c in asset.Net.VNC_Password)
            {
                if (specialKeys.Contains(c))
                    keySequence += string.Format("{{{0}}}", c);
                else keySequence += c;
            }

            // Try to input password in authentication dialog
            var bgVNCConnector = new BackgroundWorker();
            bgVNCConnector.DoWork += bgVNCConnector_DoWork;

            bgVNCConnector.RunWorkerAsync(keySequence);
        }

        /// <summary>
        /// Launches settings-specified Teamviewer client and connects to the specified asset
        /// using Teamviewer ID and password.
        /// </summary>
        private void Teamviewer_Connect(ClassAsset asset)
		{
			if (!File.Exists(GS.Settings.TeamviewerPath))
			{
				MessageBox.Show("Teamviewer executable was not found, this feature will not be available.", "Teamviewer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			var teamviewerProcess = new Process();
			teamviewerProcess.StartInfo.FileName = GS.Settings.TeamviewerPath;
			teamviewerProcess.StartInfo.Arguments = $"-i {asset.Net.Teamviewer_ID} --Password {asset.Net.Teamviewer_Password}";
			teamviewerProcess.Start();
		}

		private void bgVNCConnector_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				var keySequence = (string)e.Argument;
				var connected = false;
				var connectionTimeElapsed = new Stopwatch();
				connectionTimeElapsed.Start();
				while (!connected && connectionTimeElapsed.Elapsed <= TimeSpan.FromSeconds(GS.Settings.VNCTimeout))
				{
					Thread.Sleep(200);
					var runningProcesses = Process.GetProcesses();
					if (runningProcesses.All(p => string.Compare(p.MainWindowTitle, GS.Settings.VNCPasswordWindowTitle, StringComparison.OrdinalIgnoreCase) != 0))
						continue;

					Invoke(new BgwSendKeysDelegate(BgwSendKeys), keySequence);
					connected = true;
				}
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				Debug.WriteLine(exc);
			}
			finally
			{
				Debug.WriteLine("VNC Connector BGW Ended");
			}
		}

		private delegate void BgwSendKeysDelegate(string keySequence);
		private void BgwSendKeys(string keySequence)
		{
			SendKeys.Send(keySequence);
			SendKeys.Send("{ENTER}");
		}

		private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabMain.SelectedTab == tabTracker && _trackerNeedsRefresh)
			{
				tmrRefresh_Tracker.Stop();
				TicketTracker_Refresh();
				tmrRefresh_Tracker.Start();
			}
			else if (tabMain.SelectedTab == tabTicket)
				ucTicketEditor1.FocusSearch();
			else if (tabMain.SelectedTab == tabAsset)
				ucAssetEditor1.FocusSearch();
			else if (tabMain.SelectedTab == tabTech)
				ucTechEditor1.FocusSearch();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		/// <summary>
		/// Clears main form controls (login, search fields, editors, etc.)
		/// </summary>
		private void ClearControls()
		{
			// Clear login fields
			txtLogin_UserID.Clear();
			txtLogin_Password.Clear();

			// Clear create ticket field
			txtCreateTicket_Asset.Clear();

			// Clear Search fields
			txtSearch_Ticket.Clear();
			txtSearch_Asset.Clear();
			txtSearch_Tech.Clear();
			txtSearch_SearchAll.Clear();

			// Clear editors UI
			ticketTracker.ClearControls();
			ucTicketEditor1.ClearControls();
			ucAssetEditor1.ClearControls();
			ucTechEditor1.ClearControls();
			customerEditor1.ClearAllControls();
		}

		private bool IsApplicationInFocus()
		{
			var hasFocus = false;
			if (ContainsFocus)
				hasFocus = true;
			else if (Application.OpenForms.Cast<Form>().Any(f => f != null && f.ContainsFocus))
				hasFocus = true;
			return hasFocus;
		}

        //private void magicInfoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MagicInfo_ShowForm();
        //}

        private void epartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEpartsForm();
        }

        private void ShowEpartsForm()
        {
            _epartsForm = null;
            _epartsForm = new FormEparts();
            _epartsForm.Show();
        }

        private void ucTechEditor1_OpenURL_LatLongMap(ClassTech tech)
        {
            if (!string.IsNullOrEmpty(tech.URL_GoogleMap))
                OpenURL(tech.URL_GoogleMap);
        }



        /// <summary>
        /// Checks if the user's last interaction time was more than <paramref name="threshold"/> seconds ago.
        /// If no user is logged in, returns false.
        /// </summary>
        private bool IsUserIdle(int threshold)
		{
			if (GS.Settings.LoggedOnUser == null || !GS.Settings.LoggedOnUser.IsLoggedIn)
				return false;

			return (DateTime.Now - GS.Settings.LoggedOnUser.LastInteraction).TotalSeconds > threshold;
		}
		#endregion

		#region Idle Timeout
		// ReSharper disable InconsistentNaming
		// ReSharper disable MemberCanBePrivate.Local
		[StructLayout(LayoutKind.Sequential)]
		struct LASTINPUTINFO
		{
			public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));

			[MarshalAs(UnmanagedType.U4)]
			public uint cbSize;
			[MarshalAs(UnmanagedType.U4)]
			public uint dwTime;
		}
		// ReSharper restore MemberCanBePrivate.Local
		// ReSharper restore InconsistentNaming
		[DllImport("user32.dll")]
		private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

		/// <summary>
		/// Returns time in seconds since last user input (session-wide, not for a specific application).
		/// </summary>
		private static int GetLastInputTime()
		{
			uint idleTime = 0;
			var lastInputInfo = new LASTINPUTINFO();
			lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);
			lastInputInfo.dwTime = 0;

			var envTicks = (uint)Environment.TickCount;

			if (GetLastInputInfo(ref lastInputInfo))
			{
				var lastInputTick = lastInputInfo.dwTime;
				idleTime = envTicks - lastInputTick;
			}

			return (int)((idleTime > 0) ? (idleTime / 1000) : 0);
		}
		#endregion
	}
}