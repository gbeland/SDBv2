using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using SDB.Classes.User;

namespace SDB.Classes.General
{
	[Serializable]
	public class ClassSettings
	{
		public enum StartupModeEnum
		{
			Tracker,
			RMA,
			Reports,
			Shipments,
            MagicInfo
		};

		[XmlIgnore]
		public readonly string SettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Prismview", @"SDB");

		[XmlIgnore]
		public const string SETTINGS_FILE = @"settings.xml";

		[XmlIgnore]
		public const string LOG_FILE = @"sdb.log";

		#region Properties
		/// <summary>
		/// Location of main program window.
		/// </summary>
		public Point WindowLocation = new Point(200, 200);

		/// <summary>
		/// Size of main program window.
		/// </summary>
		public Size WindowSize = new Size(1087, 781);

		/// <summary>
		/// Main program window state.
		/// </summary>
		public FormWindowState WindowState = FormWindowState.Normal;

		[XmlElement("ControlBarColor")]
		public string ControlBarColorHtml = "#778899";
		[XmlIgnore]
		public Color ControlBarColor
		{
			get => ColorTranslator.FromHtml(ControlBarColorHtml);
			set => ControlBarColorHtml = ColorTranslator.ToHtml(value);
		}

		/// <summary>
		/// Location of RMA Manager window.
		/// </summary>
		public Point Location_RMAManager = new Point(200, 200);

		/// <summary>
		/// RMA Manager window state.
		/// </summary>
		public FormWindowState WindowState_RMAManager = FormWindowState.Normal;

		/// <summary>
		/// Location of RMA List window.
		/// </summary>
		public Point Location_RMAList = new Point(200, 200);

		/// <summary>
		/// RMA List window state.
		/// </summary>
		public FormWindowState WindowState_RMAList = FormWindowState.Normal;

		/// <summary>
		/// Location of RMA Editor window.
		/// </summary>
		public Point Location_RMAEditor = new Point(200, 200);

		/// <summary>
		/// RMA Editor window state.
		/// </summary>
		public FormWindowState WindowState_RMAEditor = FormWindowState.Normal;

		/// <summary>
		/// Location of Shipment List window.
		/// </summary>
		public Point Location_Shipment_List = new Point(200, 200);

		/// <summary>
		/// Shipment List window state.
		/// </summary>
		public FormWindowState WindowState_Shipment_List = FormWindowState.Normal;

		/// <summary>
		/// Location of Shipment Editor window.
		/// </summary>
		public Point Location_Shipment_Editor = new Point(200, 200);

		/// <summary>
		/// Shipment Editor window state.
		/// </summary>
		public FormWindowState WindowState_Shipment_Editor;

		/// <summary>
		/// Location of Reports window.
		/// </summary>
		public Point Location_Reports = new Point(200, 200);

		/// <summary>
		/// Reports window state.
		/// </summary>
		public FormWindowState WindowState_Reports = FormWindowState.Normal;

		/// <summary>
		/// Location of Notifications window.
		/// </summary>
		public Point Location_Notifications = new Point(200, 200);

		/// <summary>
		/// Notifications window state.
		/// </summary>
		public FormWindowState WindowState_Notifications = FormWindowState.Normal;

		/// <summary>
		/// Location of Camera Check Review window.
		/// </summary>
		public Point Location_CameraCheckReview { get; set; }

		/// <summary>
		/// Camera Check Review window state.
		/// </summary>
		public FormWindowState WindowState_CameraCheckReview { get; set; }

        /// <summary>
        /// Name of datebase for Samsung Magicinfo Service 
        /// </summary>
        public string DBName_Samsung = @"magicinfo_lfd";

		/// <summary>
		/// Name of database for Prismview Electronics Service
		/// </summary>
		public string DBName_Service = @"electronics";

		/// <summary>
		/// Name of database for Prismview Monitor
		/// </summary>
		public string DBName_Monitoring = @"pvm";

		/// <summary>
		/// Database server address.
		/// </summary>
		public string DBServer = @"192.168.90.19";

		/// <summary>
		/// Database server user name.
		/// </summary>
		public string DBUser = @"sdb";

		/// <summary>
		/// Database server user password.
		/// </summary>
		public string DBPassword = @"";

		/// <summary>
		/// Database timeout in seconds.
		/// </summary>
		public int DBTimeout = 30;

		/// <summary>
		/// Email server address.
		/// </summary>
		public string EmailServer = @"smtp.gmail.com";

		/// <summary>
		/// Email server port.
		/// </summary>
		public string EmailServerPort = @"587";

		/// <summary>
		/// Email server Secure Socket Layer protocol enabled.
		/// </summary>
		public bool EmailUseSSL = true;

		/// <summary>
		/// Email account to use for outgoing email.
		/// </summary>
		public string EmailUser = @"noreply@prismview.com";

		/// <summary>
		/// Email account password to use for outgoing email.
		/// </summary>
		public string EmailPassword = @"y9H5$2nITl%MOH56wA";

		/// <summary>
		/// Update server address.
		/// </summary>
		public string UpdateServer = @"192.168.90.88";

		/// <summary>
		/// Path to stored camera images (from PVM).
		/// </summary>
		public string CameraImagePath = @"I:\Images";

		/// <summary>
		/// URL for the Prismview Service Dashboard web application.
		/// </summary>
		public string DashboardWebURL = "http://192.168.90.87/dashboard/single.php?a=";

		/// <summary>
		/// Which window the Service Database client application should show upon login.
		/// </summary>
		public StartupModeEnum StartupMode = StartupModeEnum.Tracker;

		/// <summary>
		/// Location of TightVNC Viewer executable.
		/// </summary>
		public string VNCPath = @"C:\Program Files (x86)\TightVNC\vncviewer.exe";

        public string RealVNCPath = @"C:\Program Files\RealVNC\VNC Viewer\vncviewer.exe";


        /// <summary>
        /// The name of the password entry window in which to enter the VNC password.
        /// </summary>
        public string VNCPasswordWindowTitle = @"Standard VNC Authentication";

		/// <summary>
		/// How long to wait (in seconds) to attempt auto-population of VNC connection password.
		/// </summary>
		public int VNCTimeout = 5;

		/// <summary>
		/// Location of Teamviewer executable.
		/// </summary>
		public string TeamviewerPath = @"C:\Program Files (x86)\Teamviewer\Version9\TeamViewer.exe";

		/// <summary>
		/// Font to use for Ticket Journals.
		/// </summary>
		public SerializableFont JournalFont = new Font(@"MS Sans Serif", 8F);

		/// <summary>
		/// Google map zoom levels: "State" = 6, "City" = 13, "Street" = 17
		/// Actual accepted zoom levels are 0-21.
		/// </summary>
		public int DefaultMapZoomLevel = 13;

		/// <summary>
		/// Whether to automatically subscribe to objects (asset, ticket, shipment, etc.) when creating them.
		/// </summary>
		public bool AutoSubscribe_Create;

		/// <summary>
		/// Whether to automatically subscribe to object (asset, ticket, shipment, etc.) when modifying them.
		/// </summary>
		public bool AutoSubscribe_Modify;

		/// <summary>
		/// Stores the state of the Ticket Tracker columns (visibility, sequence, sort, widths, etc.)
		/// </summary>
		public byte[] TrackerSettings;

		/// <summary>
		/// Stores the name of the printer to use for RMA Bin Labels.
		/// </summary>
		public string RMA_BinLabel_PrinterName;

		/// <summary>
		/// Stores the name of the printer to use for RMA Zone Labels.
		/// </summary>
		public string RMA_ZoneLabel_PrinterName;

		[XmlIgnore]
		public ClassUser LoggedOnUser = new ClassUser();

		/// <summary>
		/// Enables camera check for the client.
		/// </summary>
		public bool CameraCheck_Enable;
		public bool CameraCheck_HideButtons;
		public bool CameraCheck_AutoSubmitContinue;
		#endregion

		public void SaveSettings()
		{
			if (!Directory.Exists(SettingsPath))
				Directory.CreateDirectory(SettingsPath);

			using (var sw = new StreamWriter(Path.Combine(SettingsPath, SETTINGS_FILE)))
			{
				var x = new XmlSerializer(typeof (ClassSettings));
				x.Serialize(sw, this);
				sw.Flush();
				sw.Close();
			}
		}

		public ClassSettings LoadSettings()
		{
			var loggedOnUser = LoggedOnUser;
			var temp = new ClassSettings();
			if (!File.Exists(Path.Combine(SettingsPath, SETTINGS_FILE)))
				return temp;

			using (var sr = new StreamReader(Path.Combine(SettingsPath, SETTINGS_FILE)))
			{
				try
				{
					var x = new XmlSerializer(typeof (ClassSettings));
					temp = (ClassSettings)x.Deserialize(sr);
				}
				catch
				{
					MessageBox.Show("The settings file could not be read.");
				}
			}
			if (loggedOnUser != null)
				temp.LoggedOnUser = loggedOnUser;
			return temp;
		}
	}
}