using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.Tech;
using SDB.Classes.User;
using SDB.Interfaces;
using System.Reflection;

// ReSharper disable RedundantVerbatimStringPrefix
namespace SDB.Classes.Asset
{
	public class ClassAsset : ISupportsJournal, IExportableToCsv
	{
		#region Consts and Static 
		internal const int SYSTEM_DEFAULT_PORT = 38381;
		internal const int PLAYER_DEFAULT_PORT = 38382;
		internal const int CAMERA_DEFAULT_PORT = 38383;
		internal const int IBOOT_DEFAULT_PORT = 38384;
		internal const int GOOSE_DEFAULT_PORT = 38385;
		internal const int VNC_DEFAULT_PORT = 5900;
		internal const int VNC_DEFAULT_WEB_PORT = 5800;

		internal static readonly Color COL_ASSET_EXPIRED_WC_BG = Color.FromArgb(230, 184, 175);
		internal static readonly Color COL_ASSET_EXPIRES_SOON_WC_BG = Color.FromArgb(255, 229, 153);
		internal static readonly Color COL_ASSET_NOTAPPLICABLE_WC_FG = Color.LightGray;
		internal static readonly Color COL_ASSET_VALID_FG = Color.DarkGreen;
		internal static readonly Color COL_ASSET_RETIRED_FG = Color.DarkRed;
		internal static readonly Color COL_ASSET_NO_LABOR_COVERAGE_FG = Color.DimGray;

		/// <summary>
		/// How many days before a warranty or contract date expires should be considered "soon?"
		/// </summary>
		internal const int EXPIRING_SOON_DAYS = 30;

		internal static readonly TimeSpan MAX_JOURNAL_EXPIRATION = TimeSpan.FromDays(14);
		internal const int MAX_ASSIGNED_TECHS = 10;

		private static readonly string[] _assetDBFields =
		{
			"market_id", "asset", "panel", "location", "address", "city", "state", "zip", "country",
			"latitude", "longitude",
			"indoor", "hagl", "facing", "cabinet_type",
			"matrix_width", "matrix_height", "face_qty", "pitch",
			"controller_hw", "controller_sw", "controller_conn", "client_conn",
			"output_method", "chip_type", "interface_type", "interface_qty", "serial",
			"lift_type", "lift_height",
			"net_isp", "router",
			"wan_ip", "uselan", "subnet", "gateip", "lan_ip",
			"systemport", "systempassword", "systemssl",
			"vncport", "vncwebport", "vncpassword", "is_real_vnc",
            "tvid", "tvpw",
			"webcaminstalled", "webcamip", "webcamport", "webcamch", "webcamuser", "webcampassword", "webcam_type",
			"iboot_installed", "iboot_ip", "iboot_port", "iboot_password",
			"goose_installed", "goose_ip", "goose_port", "goose_password",
			"player_port", "player_password", "player_ssl",
			"service_reminder", "service_reminder_datetime", "service_reminder_user",
			"notes", "access_notes",
			"release_num",
			"labor_w", "labor_c",
			"parts_w", "parts_c",
			"shipped_dt", "install_dt",
			"parts_w_end_dt", "parts_c_start_dt", "parts_c_end_dt",
			"labor_w_end_dt", "labor_c_start_dt", "labor_c_end_dt", "labor_c_monitoring",
			"camera_check_interval",
			"retired", "managed_by_creative", "is_pmc", "bill_to_market"
        };

		/// <summary>
		/// Used for lists
		/// </summary>
		public struct AssetPieces
		{
			public string Asset { get; set; }
			public string Panel { get; set; }
			public string Location { get; set; }
			public string MarketName { get; set; }
			public string CustomerName { get; set; }
		}

		#endregion

		#region Variables
		public int ID { get; private set; }
		public int MarketID { get; set; }
		public string AssetName { get; set; }

		public bool ManagedByCreative { get; set; }
        public bool IsPMC { get; set; }

		// TODO: Move extra properties to new class
		///// <summary>
		///// Optional for certain views (must join markets table to populate)
		///// </summary>
		//public string MarketName { get; set; }

		// TODO: Move extra properties to new class
		///// <summary>
		///// Optional for certain views (must join markets and customers tables to populate)
		///// </summary>
		//public string CustomerName { get; set; }

		public string Panel { get; set; }
		public string Location { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public decimal? Latitude { get; set; }
		public decimal? Longitude { get; set; }
		public int HeightAboveGroundLevel { get; set; }

        

		/// <summary>
		/// Indicates asset is indoor type.
		/// </summary>
		public bool IsIndoor { get; set; }
		public string FacingDirection { get; set; }
		public string InterfaceType { get; set; }

		/// <summary>
		/// Output method (such as native dvi, native serial, etc.) (link to output methods table)
		/// </summary>
		public int? OutputMethodId { get; set; }

		public int InterfaceQty { get; set; }
		public int MatrixWidth { get; set; }
		public int MatrixHeight { get; set; }

		/// <summary>
		/// String representation of matrix width and height i.e. "704x200"
		/// </summary>
		public string MatrixSize => $"{MatrixWidth}x{MatrixHeight}";

		public int Pitch { get; set; }

		/// <summary>
		/// Number of faces on asset (operated by single controller)
		/// </summary>
		public int FaceQty { get; set; }

		public string Chip_Type { get; set; }

		/// <summary>
		/// Controller hardware selection (link to controller hardware table)
		/// </summary>
		public int? ControllerHardwareId { get; set; }
		/// <summary>
		/// Controller software selection (link to controller software table)
		/// </summary>
		public int? ControllerSoftwareId { get; set; }
		/// <summary>
		/// Controller connection type (link to controller connection table)
		/// </summary>
		public int? ControllerConnectionId { get; set; }

        public int? ClientConnectionId { get; set; }

		/// <summary>
		/// Cabinet type (link to cabinet_type table)
		/// </summary>
		public int? CabinetTypeId { get; set; }

		/// <summary>
		/// Recommended lift type for service (link to lift types table)
		/// </summary>
		public int? LiftTypeId { get; set; }

		/// <summary>
		///  Recommended lift height for service
		/// </summary>
		public int Lift_Height { get; set; }

		public string ReleaseNumber { get; set; }

		public string SerialNumber { get; set; }
		public List<int> AssignedTechIDs { get; set; }
		public string ServiceReminder { get; set; }
		public DateTime? ServiceReminder_DateTime { get; set; }
		public int? ServiceReminder_UserID { get; set; }

		/// <summary>
		/// General notes about the asset for service department internal use.
		/// </summary>
		public string Notes { get; set; }
		/// <summary>
		/// Physical- or security-related instructions for accessing the property and/or components of the asset.
		/// </summary>
		public string AccessNotes { get; set; }

		/// <summary>
		/// Indicates the asset is retired and should not be used to create new tickets, in monitoring, or other new activity.
		/// </summary>
		public bool IsRetired { get; set; }

		public ClassWarrantyInfo WarrantyInfo;
		public ClassNetworkInfo Net;
		public ClassMonitoringOptions Monitoring;
		public ClassIbom Ibom;
		public ClassCameraCheckInfo CameraCheckInfo;

		/// <summary>
		/// Camera check interval in minutes.
		/// </summary>
		public int CameraCheckInterval { get; set; }

		public List<OpenTicketMiniInfo> OpenTicketData { get; set; }

		/// <summary>
		/// Holds a ticket number and type.
		/// </summary>
		public struct OpenTicketMiniInfo
		{
			public int TicketID { get; set; }
			public string Symptoms { get; set; }
		}

		public AssetExtraProperties ExtraProperties { get; }

		#endregion

		#region Asset Subclasses
		public class ClassWarrantyInfo
		{
			public string LaborWarrantyNumber { get; set; }
			public string LaborContractNumber { get; set; }
			public string PartsWarrantyNumber { get; set; }
			public string PartsContractNumber { get; set; }

			/// <summary>
			/// Install date is also the Labor Warranty start date.
			/// </summary>
			public DateTime? InstallDate { get; set; }
			public DateTime? LaborWarrantyExpire { get; set; }
			public DateTime? LaborContractStart { get; set; }
			public DateTime? LaborContractExpire { get; set; }

			/// <summary>
			/// Shipped date is also the Parts Warranty start date.
			/// </summary>
			public DateTime? ShippedDate { get; set; }
			public DateTime? PartsWarrantyExpire { get; set; }
			public DateTime? PartsContractStart { get; set; }
			public DateTime? PartsContractExpire { get; set; }

			/// <summary>
			/// labor_c_monitoring (bool)
			/// </summary>
			public bool MonitoringContractOnly { get; set; }
            public bool BillToMarket { get; set; }

        }

		public class ClassNetworkInfo
		{
			public string InternetServiceProvider { get; set; }
			public string RouterInfo { get; set; }
			public string WanAddress { get; set; }
			public string Gateway { get; set; }
			public string SubnetMask { get; set; }
			public bool UseLanAddresses { get; set; }
			public string LanAddress { get; set; }

			public int? System_Port { get; set; }
			public string System_Password { get; set; }
			public bool? System_UseSsl { get; set; }

            public bool Use_Real_VNC { get; set; }
			public int? VNC_Port { get; set; }
			public int? VNC_WebPort { get; set; }
			public string VNC_Password { get; set; }

			public bool Webcam_Installed { get; set; }
			public int? Webcam_Type { get; set; }
			public string Webcam_Address { get; set; }
			public int? Webcam_Channel { get; set; }
			public string Webcam_User { get; set; }
			public int? Webcam_Port { get; set; }
			public string Webcam_Password { get; set; }

			public bool IBoot_Installed { get; set; }
			public string IBoot_Address { get; set; }
			public int? IBoot_Port { get; set; }
			public string IBoot_Password { get; set; }

			public bool Goose_Installed { get; set; }
			public string Goose_Address { get; set; }
			public int? Goose_Port { get; set; }
			public string Goose_Password { get; set; }

			public int? Player_Port { get; set; }
			public string Player_Password { get; set; }
			public bool? Player_UseSsl { get; set; }

			/// <summary>
			/// Is an address specified for the server, taking into account the "Use LAN" option?
			/// </summary>
			public bool HasServerAddress => UseLanAddresses ? !string.IsNullOrEmpty(LanAddress) : !string.IsNullOrEmpty(WanAddress);

			/// <summary>
			/// Is webcam installed and address specified, taking into account the "Use LAN" option?
			/// </summary>
			public bool HasWebcamAndAddress => Webcam_Installed && (UseLanAddresses ? !string.IsNullOrEmpty(Webcam_Address) : !string.IsNullOrEmpty(WanAddress));

			public string Teamviewer_ID { get; set; }
			public string Teamviewer_Password { get; set; }
		}

		public class ClassMonitoringOptions
		{
			private int _interval;

			/// <summary>
			/// 0=Disabled, 1=Auto, 2=Forced
			/// </summary>
			public enum MonitoringMode
			{
				Disabled,
				Auto,
				Forced
			};

			public MonitoringMode DataMode { get; set; }
			public MonitoringMode WebcamMode { get; set; }

			/// <summary>
			/// Data collection interval in minutes.
			/// </summary>
			public int Interval
			{
				get => _interval;
				set => _interval = value < 1 ? 1 : value;
			}

			/// <summary>
			/// The expected hold time for ads. 0 when not applicable.
			/// </summary>
			public int HoldTime { get; set; }

			public bool Trend_Debug { get; set; }

			public DateTime? LastAttempt { get; set; }
			public DateTime? LastData { get; set; }
			public DateTime? LastImage { get; set; }

			public ClassMonitoringOptions()
			{
				Interval = 10;
			}
		}

		public class ClassIbom
		{
			public int Asset_ID { get; set; }
			public string LED_JobNumber { get; set; }
			public string LED_Assembly { get; set; }
			public string LED_Calibration { get; set; }

			/// <summary>
			/// Power supply assembly number.
			/// </summary>
			public string PS_Assembly { get; set; }

			public decimal PS_RedVoltage { get; set; }
			public decimal PS_GreenVoltage { get; set; }
			public decimal PS_BlueVoltage { get; set; }
			public decimal PS_LogicVoltage { get; set; }

			public string Interface_EpromType { get; set; }
			public string Interface_EpromVersion { get; set; }
			public int? Interface_Assembly_ID { get; set; }
		}

		/// <summary>
		/// Properties in asset table used to track requests (lockouts) and submissions.
		/// Not to be confused with <seealso cref="ClassCameraCheck"/> which records check history.
		/// </summary>
		public class ClassCameraCheckInfo
		{
			/// <summary>
			/// Datetime of last camera check request, if pending; null if submitted or not requested.
			/// </summary>
			public DateTime? CameraCheckLastRequest { get; set; }
			/// <summary>
			/// User ID for last camera check request, if pending; null if submitted or not requested.
			/// </summary>
			public int? CameraCheckRequestUserID { get; set; }
			/// <summary>
			/// Datetime of last submitted camera check.
			/// </summary>
			public DateTime? CameraCheckLastSubmit { get; set; }

			public ClassCameraCheckInfo()
			{
				CameraCheckLastRequest = null;
				CameraCheckRequestUserID = null;
				CameraCheckLastSubmit = null;
			}
		}
		#endregion

		#region Functions
		public ClassAsset()
		{
			ID = -1;
			AssetName = string.Empty;
			Panel = string.Empty;
			Location = string.Empty;
			Address = string.Empty;
			City = string.Empty;
			State = string.Empty;
			Zip = string.Empty;
			Latitude = null;
			Longitude = null;
			HeightAboveGroundLevel = 0;
			IsIndoor = false;
			InterfaceType = string.Empty;
			InterfaceQty = 0;
			MatrixWidth = 0;
			MatrixHeight = 0;
			FaceQty = 1;
			Pitch = 0;
			OutputMethodId = null;
			Chip_Type = string.Empty;
			ControllerHardwareId = null;
			ControllerSoftwareId = null;
			ControllerConnectionId = null;
			CabinetTypeId = null;
			ReleaseNumber = string.Empty;
			SerialNumber = string.Empty;
			Lift_Height = 0;
			LiftTypeId = null;
			AssignedTechIDs = new List<int>();
			ServiceReminder = string.Empty;
			Notes = string.Empty;
			AccessNotes = string.Empty;
			IsRetired = false;
			CameraCheckInterval = 60;
			ManagedByCreative = false;
            IsPMC = false;

            WarrantyInfo = new ClassWarrantyInfo
            {
                ShippedDate = null,
                InstallDate = null,
                LaborWarrantyNumber = string.Empty,
                PartsWarrantyNumber = string.Empty,
                LaborWarrantyExpire = null,
                LaborContractStart = null,
                LaborContractExpire = null,
                PartsWarrantyExpire = null,
                PartsContractStart = null,
                PartsContractExpire = null,
                MonitoringContractOnly = false,
                BillToMarket = false,
            };

            Net = new ClassNetworkInfo
            {
                InternetServiceProvider = string.Empty,
                RouterInfo = string.Empty,
                WanAddress = string.Empty,
                Gateway = string.Empty,
                SubnetMask = "255.255.255.0",
                UseLanAddresses = false,
                LanAddress = string.Empty,
                System_Port = SYSTEM_DEFAULT_PORT,
                System_Password = string.Empty,
                System_UseSsl = null,

                Use_Real_VNC = false,
				VNC_Port = VNC_DEFAULT_PORT,
				VNC_WebPort = VNC_DEFAULT_WEB_PORT,
				Webcam_Address = string.Empty,
				Webcam_Channel = 1,
				Webcam_Port = null,
				IBoot_Installed = false,
				IBoot_Address = string.Empty,
				IBoot_Port = null,
				IBoot_Password = string.Empty,
				Goose_Installed = false,
				Goose_Address = string.Empty,
				Goose_Port = GOOSE_DEFAULT_PORT,
				Goose_Password = string.Empty,
				Player_Port = PLAYER_DEFAULT_PORT,
				Player_Password = string.Empty,
				Player_UseSsl = null,
				Teamviewer_Password = string.Empty
			};

			Monitoring = new ClassMonitoringOptions
			{
				DataMode = ClassMonitoringOptions.MonitoringMode.Disabled,
				WebcamMode = ClassMonitoringOptions.MonitoringMode.Disabled,
				HoldTime = 14400,
				Interval = 10
			};

			Ibom = new ClassIbom();

			CameraCheckInfo = new ClassCameraCheckInfo();
			ExtraProperties = new AssetExtraProperties();
		}

		public ClassJournal.JournalTableInfo JournalTableInfo =>
			new ClassJournal.JournalTableInfo
			{
				TableName = "asset_journal",
				LinkerName = "asset_id"
			};

		[UsedImplicitly]
		public string DisplayMember => $"{AssetName}{(string.IsNullOrEmpty(Panel) ? string.Empty : $" [{Panel}]")}";

		public override string ToString()
		{
			return $"{AssetName} [{ID}]";
		}

		/// <summary>
		/// Provides a multi-line string for the asset's full location like:
		/// 1. [Location] [Facing]
		/// 2. [Address]
		/// 3. [City], [State] [Country]
		/// Facing, Address, City and Country and preceding space/punctuation is omitted if they are not present.
		/// </summary>
		public string LocationMultiLine
		{
			get
			{
				var sb = new StringBuilder();
				var facing = string.IsNullOrEmpty(FacingDirection) ? string.Empty : string.Format(" ({0} face)", FacingDirection);
				sb.AppendFormat("{0}{1}", Location, facing).AppendLine();
				if (Address != Location && !string.IsNullOrEmpty(Address))
					sb.AppendLine(Address);
				sb.AppendFormat("{0}{1}{2}", City, string.IsNullOrEmpty(State) ? string.Empty : ", " + State, string.IsNullOrEmpty(Country) ? string.Empty : " " + Country).AppendLine();
				return sb.ToString();
			}
		}

		/// <summary>
		/// Whether the asset covered by a labor warranty or labor contract (that is NOT monitoring-only), and suitable for opening a ticket against.
		/// </summary>
		/// <remarks>Checks WARRANTY first, then CONTRACT. The MONITORING-ONLY option applies only to CONTRACT.</remarks>
		public bool IsLaborCovered
		{
			get
			{
				var now = ClassDatabase.GetCurrentTime();

				if (WarrantyInfo.LaborWarrantyExpire.HasValue && WarrantyInfo.LaborWarrantyExpire.Value.Date >= now.Date)
					return true;

				if (WarrantyInfo.LaborContractStart.HasValue && WarrantyInfo.LaborContractExpire.HasValue &&
					WarrantyInfo.LaborContractStart.Value.Date <= now.Date && now.Date <= WarrantyInfo.LaborContractExpire.Value.Date)
					return !WarrantyInfo.MonitoringContractOnly;

				return false;
			}
		}

		/// <summary>
		/// Returns the active Labor Warranty or Contract Number or empty string if both blank/expired.
		/// </summary>
		public string ActiveLaborNumber
		{
			get
			{
				var now = ClassDatabase.GetCurrentTime();
				string activeLabor;
				if (WarrantyInfo.LaborWarrantyExpire.HasValue && WarrantyInfo.LaborWarrantyExpire.Value.Date > now.Date)
					activeLabor = WarrantyInfo.LaborWarrantyNumber;
				else if (WarrantyInfo.LaborContractExpire.HasValue && WarrantyInfo.LaborContractExpire.Value.Date > now.Date)
					activeLabor = WarrantyInfo.LaborContractNumber;
				else
					activeLabor = string.Empty;
				return activeLabor;
			}
		}

		/// <summary>
		/// Whether the asset is covered by a labor warranty or labor contract. Can be monitoring-only.
		/// </summary>
		public bool IsMonitoringCovered
		{
			get
			{
				var now = ClassDatabase.GetCurrentTime();

				if (WarrantyInfo.LaborWarrantyExpire.HasValue && WarrantyInfo.LaborWarrantyExpire.Value.Date >= now.Date)
					return true;

				if (WarrantyInfo.LaborContractStart.HasValue && WarrantyInfo.LaborContractExpire.HasValue &&
					WarrantyInfo.LaborContractStart.Value.Date <= now.Date && now.Date <= WarrantyInfo.LaborContractExpire.Value.Date)
					return true;

				return false;
			}
		}

		/// <summary>
		/// Whether the asset is covered by a parts warranty or parts contract, and suitable for opening an RMA against.
		/// </summary>
		public bool IsPartsCovered
		{
			get
			{
				var now = ClassDatabase.GetCurrentTime();

				if (WarrantyInfo.PartsWarrantyExpire.HasValue && WarrantyInfo.PartsWarrantyExpire.Value.Date >= now.Date)
					return true;

				if (WarrantyInfo.PartsContractStart.HasValue && WarrantyInfo.PartsContractExpire.HasValue &&
					WarrantyInfo.PartsContractStart.Value.Date <= now.Date && now.Date <= WarrantyInfo.PartsContractExpire.Value.Date)
					return true;

				return false;
			}
		}

		/// <summary>
		/// Returns the active Parts Warranty or Contract Number or empty string if both blank/expired.
		/// </summary>
		public string ActivePartsNumber
		{
			get
			{
				var now = ClassDatabase.GetCurrentTime();
				string activeParts;
				if (WarrantyInfo.PartsWarrantyExpire.HasValue && WarrantyInfo.PartsWarrantyExpire.Value.Date > now.Date)
					activeParts = WarrantyInfo.PartsWarrantyNumber;
				else if (WarrantyInfo.PartsContractExpire.HasValue && WarrantyInfo.PartsContractExpire.Value.Date > now.Date)
					activeParts = WarrantyInfo.PartsContractNumber;
				else
					activeParts = string.Empty;
				return activeParts;
			}
		}

		#region URL Strings
		public string URL_GoogleMap => Latitude.HasValue && Longitude.HasValue
			? $"http://maps.google.com/?q={Latitude},{Longitude}&z={GS.Settings.DefaultMapZoomLevel}"
			: string.Empty;

		/// <summary>
		/// Gets the Still Image URL for the specified <paramref name="cameraType"/>. (URL includes basic auth)
		/// </summary>
		public string URL_CameraImage(ClassCameraType cameraType)
		{
			if (!Net.Webcam_Installed || cameraType == null)
				return string.Empty;

			var cred = string.IsNullOrEmpty(Net.Webcam_User) ? string.Empty : string.Format("{0}:{1}@", HttpUtility.UrlEncode(Net.Webcam_User), HttpUtility.UrlEncode(Net.Webcam_Password));
			var address = Net.UseLanAddresses ? Net.Webcam_Address : Net.WanAddress;
			var port = Net.Webcam_Port.GetValueOrDefault(CAMERA_DEFAULT_PORT);
			var channel = Net.Webcam_Channel == 999 ? "quad" : Net.Webcam_Channel == 0 ? "1" : Net.Webcam_Channel.GetValueOrDefault(1).ToString(CultureInfo.InvariantCulture);
			var path = cameraType.URL_Format_Still.Replace("[CHANNEL]", channel).TrimStart('/');
			var url = $"http://{cred}{address}:{port}/{path}";
			return url;
		}

		/// <summary>
		/// Provides the URL for the asset's camera administration or main page.
		/// </summary>
		public string URL_CameraAdmin
		{
			get
			{
				if (!Net.Webcam_Installed)
					return string.Empty;

				var auth = string.IsNullOrEmpty(Net.Webcam_User) ? string.Empty : $"{HttpUtility.UrlEncode(Net.Webcam_User)}:{HttpUtility.UrlEncode(Net.Webcam_Password)}@";
				var address = Net.UseLanAddresses ? Net.Webcam_Address : Net.WanAddress;
				var port = Net.Webcam_Port.GetValueOrDefault(CAMERA_DEFAULT_PORT);
				return $"http://{auth}{address}:{port}/";
			}
		}

        public string URL_WebCamLiveFeed
        {
            get
            {
			    var cameraType = ClassCameraType.GetByID(Net.Webcam_Type);
                if (!Net.Webcam_Installed || cameraType == null)
                    return string.Empty;

                var cred = string.IsNullOrEmpty(Net.Webcam_User) ? string.Empty : string.Format("{0}:{1}@", HttpUtility.UrlEncode(Net.Webcam_User), HttpUtility.UrlEncode(Net.Webcam_Password));
                var address = Net.UseLanAddresses ? Net.Webcam_Address : Net.WanAddress;
                var port = Net.Webcam_Port.GetValueOrDefault(CAMERA_DEFAULT_PORT);
                var channel = Net.Webcam_Channel == 999 ? "quad" : Net.Webcam_Channel == 0 ? "1" : Net.Webcam_Channel.GetValueOrDefault(1).ToString(CultureInfo.InvariantCulture);
                var path = cameraType.URL_Format_Video.Replace("[CHANNEL]", channel).TrimStart('/');
                var url = $"http://{cred}{address}:{port}/{path}";
                return url;
            }
        }

		public string URL_SystemIndex => $"{SystemAddress}/";

		public string URL_SystemXML => $"{SystemAddress}/xml";

		public string URL_SystemGetSettings => $"{SystemAddress}/getsettings";

		public string URL_SystemRestoreSettings => $"{SystemAddress}/restoresettings";

		public string URL_SystemRestart => $"{SystemAddress}/restart?type=pv";

		public string URL_IBoot
		{
			get
			{
				if (!Net.IBoot_Installed)
					return string.Empty;

				var iBootIP = Net.UseLanAddresses ? Net.IBoot_Address : Net.WanAddress;
				return $"http://{iBootIP}:{Net.IBoot_Port.GetValueOrDefault(IBOOT_DEFAULT_PORT)}/";
			}
		}

		public string URL_MiniGoose
		{
			get
			{
				if (!Net.Goose_Installed)
					return string.Empty;

				var gooseIP = Net.UseLanAddresses ? Net.Goose_Address : Net.WanAddress;
				return $"http://{gooseIP}:{Net.Goose_Port.GetValueOrDefault(GOOSE_DEFAULT_PORT)}/";
			}
		}

		public string URL_WebVNC
		{
			get
			{
				var webVncIP = Net.UseLanAddresses ? Net.LanAddress : Net.WanAddress;
				return $"http://{webVncIP}:{Net.VNC_WebPort.GetValueOrDefault(VNC_DEFAULT_WEB_PORT)}/";
			}
		}

		private string SystemAddress
		{
			get
			{
				var protocol = Net.System_UseSsl.GetValueOrDefault(true) ? "https" : "http";
				var address = Net.UseLanAddresses ? Net.LanAddress : Net.WanAddress;
				var port = Net.System_Port.GetValueOrDefault(SYSTEM_DEFAULT_PORT);
				return $"{protocol}://{address}:{port}";
			}
		}
		#endregion

		/// <summary>
		/// Gets all assets.
		/// </summary>
		/// <param name="pageOffset">Which page of results to return. Null for no paging.</param>
		/// <param name="maxResults">Maximum number of results to return.</param>
		/// <param name="totalQty">Total number of assets.</param>
		public static List<ClassAsset> GetAll(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = 0;
			var assets = new List<ClassAsset>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(a.id) qty
						FROM assets a;";
					totalQty = Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						$@"SELECT a.*,
							m.name market_name,
							c.name customer_name,
							cab.description cabinet_type_desc,
							om.description output_method_desc,
							achw.description controller_hw_desc,
							acsw.description controller_sw_desc,
							acc.description controller_conn_desc
						FROM assets a
							JOIN markets m ON a.market_id = m.id
							JOIN customers c ON m.customer_id = c.id
							LEFT JOIN cabinet_types cab ON a.cabinet_type = cab.id
							LEFT JOIN output_methods om ON a.output_method = om.id
							LEFT JOIN asset_controller_hw achw ON a.controller_hw = achw.id
							LEFT JOIN asset_controller_sw acsw ON a.controller_sw = acsw.id
							LEFT JOIN asset_controller_conn acc ON a.controller_conn = acc.id
						ORDER BY a.asset ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assets.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return assets;
		}

		/// <summary>
		/// Gets all asset names, panel names and locations as a dictionary indexed by primary key for lists.
		/// If <paramref name="assetIds"/> is supplied, only that subset of asset p is retrieved.
		/// </summary>
		public static Dictionary<int, AssetPieces> GetPieces(List<int> assetIds = null)
		{
			var assetPieces = new Dictionary<int, AssetPieces>();
			var conditional = assetIds != null && assetIds.Any() ? $@"WHERE a.id IN ({string.Join(",", assetIds.Distinct())});" : string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT a.id, a.asset, a.panel, a.location, m.name market_name, c.name customer_name
						FROM assets a
						JOIN markets m ON a.market_id = m.id
						JOIN customers c ON m.customer_id = c.id
						{conditional};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							assetPieces.Add(reader.GetDBInt("id"), new AssetPieces
							{
								Asset = reader.GetDBString("asset"),
								Panel = reader.GetDBString("panel"),
								Location = reader.GetDBString("location"),
								MarketName = reader.GetDBString("market_name"),
								CustomerName = reader.GetDBString("customer_name")
							});
						}
				}

				conn.Close();
			}

			return assetPieces;
		}

		public static ClassAsset GetByID(int assetID)
		{
			var asset = new ClassAsset();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT a.*
						FROM assets a
						WHERE a.id = @assetID;";
					cmd.Parameters.AddWithValue("assetID", assetID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							asset = GetFromReader(reader);
				}

				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT tech_id
						FROM asset_techs
						WHERE asset_id = @assetID;";
					cmd.Parameters.AddWithValue("assetID", assetID);

					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							asset.AssignedTechIDs.Add(reader.GetDBInt("tech_id"));
				}
				conn.Close();
			}
			return asset;
		}

		public static string GetName(int assetID)
		{
			var assetName = string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT asset FROM assets WHERE id = @assetID;";
					cmd.Parameters.AddWithValue("assetID", assetID);

					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							assetName = reader.GetDBString("asset");
				}
				conn.Close();
			}
			return assetName;
		}

		public static ClassIbom GetIbom(int assetID)
		{
			var assetIbom = new ClassIbom();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT *
						FROM assets_ibom
						WHERE asset_id = @assetID;";
					cmd.Parameters.AddWithValue("assetID", assetID);

					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							assetIbom = GetIbomFromReader(reader);
						}
					conn.Close();
				}
			}
			return assetIbom;
		}

		public static ClassMonitoringOptions GetMonitoringOptions(int assetID)
		{
			var monitoringOptions = new ClassMonitoringOptions();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						$@"SELECT get_data, get_image,
							trend_debug, interval_m, hold_time,
							dt_attempt, dt_data, dt_image
						FROM {GS.Settings.DBName_Monitoring}.displays
						WHERE asset_id = @assetID;";
					cmd.Parameters.AddWithValue("assetID", assetID);

					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							monitoringOptions = GetAssetMonitoringOptionsFromReader(reader);
						}
					conn.Close();
				}
			}
			return monitoringOptions;
		}

		/// <summary>
		/// Finds assets having SearchTerm in the asset name, panel, or location.
		/// </summary>
		public static IEnumerable<ClassAsset> Search(string searchTerm)
		{
			var foundAssets = new List<ClassAsset>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT a.*
						FROM assets a
						WHERE (a.asset LIKE @searchTerm
							OR a.panel LIKE @searchTerm
							OR a.location LIKE @searchTerm)
						ORDER BY a.asset ASC;";
					cmd.Parameters.AddWithValue("searchTerm", $"%{searchTerm}%");
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							foundAssets.Add(GetFromReader(reader));
				}

				if (foundAssets.Count > 0)
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							$@"SELECT *
							FROM asset_techs
							WHERE asset_id IN ({string.Join(",", foundAssets.Select(a => a.ID))});";

						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
								foundAssets.First(a => a.ID == reader.GetDBInt("asset_id")).AssignedTechIDs.Add(reader.GetDBInt("tech_id"));
					}
				conn.Close();
			}
			return foundAssets;
		}

		/// <summary>
		/// Finds assets having SearchTerm in one of the following fields:
		/// Asset Name, Panel, Location, City, State, Release Number, Labor WC, Parts WC
		/// </summary>
		public static IEnumerable<ClassAsset> SearchAll(string searchTerm)
		{
			var foundAssets = new List<ClassAsset>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
                        @"SELECT a.*
						FROM assets a
                        RIGHT JOIN markets m on m.id = a.market_id
                        RIGHT JOIN customers c on c.id = m.customer_id
						WHERE (a.asset LIKE @searchTerm
							OR a.panel LIKE @searchTerm
							OR a.location LIKE @searchTerm
							OR a.city LIKE @searchTerm
							OR a.state LIKE @searchTerm
							OR a.release_num LIKE @searchTerm
							OR a.labor_w LIKE @searchTerm
							OR a.labor_c LIKE @searchTerm
							OR a.parts_w LIKE @searchTerm
							OR a.parts_c LIKE @searchTerm
                            OR a.pitch LIKE @searchTerm
                            OR a.serial LIKE @searchTerm
                            OR c.name = @searchTerm
                            OR m.name LIKE @searchTerm
                            OR m.designation LIKE @searchTerm)
						ORDER BY a.asset ASC;";
					cmd.Parameters.AddWithValue("searchTerm", $"%{searchTerm}%");
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							foundAssets.Add(GetFromReader(reader));
				}

				if (foundAssets.Count > 0)
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							$@"SELECT *
							FROM asset_techs
							WHERE asset_id IN ({string.Join(",", foundAssets.Select(a => a.ID))});";

						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
								foundAssets.First(a => a.ID == reader.GetDBInt("asset_id")).AssignedTechIDs.Add(reader.GetDBInt("tech_id"));
					}

                conn.Close();
			}
			return foundAssets;
		}

		/// <summary>
		/// Gets the assets assigned to the specified Tech.
		/// </summary>
		public static IEnumerable<ClassAsset> GetByTech(int techID)
		{
			/*
			 * The double query is because MySQL is notoriously slow with SELECT IN (SELECT ...) subqueries.
			 * Some info:
			 * http://stackoverflow.com/questions/6135376/mysql-select-where-field-in-subquery-extremely-slow-why/6136153#6136153
			 */
			var techsAssets = new List<ClassAsset>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				var assetIDs = new List<int>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT asset_id
						FROM asset_techs
						WHERE tech_id = @techID;";
					cmd.Parameters.AddWithValue("techID", techID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assetIDs.Add(reader.GetDBInt("asset_id"));
				}
				if (assetIDs.Count < 1)
					return techsAssets;

				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT a.*
						FROM assets a
						WHERE a.id IN ({string.Join(",", assetIDs.Select(a => a.ToString(CultureInfo.InvariantCulture)).ToArray())});";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var sameTechAsset = GetFromReader(reader);
							if (sameTechAsset != null && sameTechAsset.ID != -1)
								techsAssets.Add(sameTechAsset);
						}
				}
				conn.Close();
			}
			return techsAssets;
		}

		/// <summary>
		/// Gets the assets assigned to the specified Market.
		/// </summary>
		/// <param name="marketID"></param>
		public static IEnumerable<ClassAsset> GetByMarket(int marketID)
		{
			var marketAssets = new List<ClassAsset>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT a.*
						FROM assets a
						WHERE a.market_id = @marketID;";
					cmd.Parameters.AddWithValue("marketID", marketID);

					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var sameMarketAsset = GetFromReader(reader);
							if (sameMarketAsset != null && sameMarketAsset.ID != -1)
								marketAssets.Add(sameMarketAsset);
						}
				}
				conn.Close();
			}
			return marketAssets;
		}

		/// <summary>
		/// Gets the assets that share the same location, city, state, and country as <paramref name="asset"/>.
		/// </summary>
		public static IEnumerable<ClassAsset> GetBySameLocation(ClassAsset asset)
		{
			if (string.IsNullOrEmpty(asset.Location))
				return new List<ClassAsset>();

			var sharedLocationAssets = new List<ClassAsset>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT a.*
						FROM assets a
						WHERE a.location = @Location
							AND a.city = @City
							AND a.state = @State
							AND a.country = @Country
							AND a.id != @ThisID
						ORDER BY a.asset ASC;";
					cmd.Parameters.AddWithValue("Location", asset.Location);
					cmd.Parameters.AddWithValue("City", asset.City);
					cmd.Parameters.AddWithValue("State", asset.State);
					cmd.Parameters.AddWithValue("Country", asset.Country);
					cmd.Parameters.AddWithValue("ThisID", asset.ID);

					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var sameLocationAsset = GetFromReader(reader);
							if (sameLocationAsset != null && sameLocationAsset.ID != -1)
								sharedLocationAssets.Add(sameLocationAsset);
						}
				}
				conn.Close();
			}
			return sharedLocationAssets;
		}

		/// <summary>
		/// Gets list of Asset Ids which have a camera installed, and are covered by labor (or monitoring-only) warranty or contract.
		/// </summary>
		/// <param name="isDueWithinMinutes">Consider an asset camera check due this many minutes prior to (the last submit time plus the camera check interval).</param>
		public static IEnumerable<int> GetIdsForCameraCheck(int isDueWithinMinutes = 0)
		{
			var camCheckAssetIds = new List<int>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT
							a.id
						FROM assets a
						WHERE a.retired IS FALSE
							AND (DATE(a.labor_w_end_dt) > CURDATE() OR DATE(a.labor_c_end_dt) > CURDATE())
							AND a.webcaminstalled IS TRUE
							AND a.camera_check_interval > 0
							AND (
									a.camera_check_lastsubmit IS NULL
									OR
									NOW() > DATE_ADD(a.camera_check_lastsubmit, INTERVAL (CAST(a.camera_check_interval AS SIGNED) - {isDueWithinMinutes}) MINUTE)
								)
						ORDER BY a.camera_check_lastsubmit ASC, a.asset ASC;";

					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							camCheckAssetIds.Add(reader.GetDBInt("id"));
				}
				conn.Close();
			}
			return camCheckAssetIds;
		}

		/// <summary>
		/// Updates camera check fields to indicate a camera check was requested by the current user at the current time.
		/// </summary>
		public static void RequestCameraCheck(int assetID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE assets SET
						camera_check_request_dt = NOW(),
						camera_check_request_user = @requestUser
						WHERE id = @assetID;";
					cmd.Parameters.AddWithValue("requestUser", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("assetID", assetID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void RequestCameraCheckBatch(List<int> batch)
		{
			foreach (var assetID in batch)
			{
				RequestCameraCheck(assetID);
			}
		}

		/// <summary>
		/// Updates camera check fields to indicate a camera check was submitted at the current time. Clears the request fields.
		/// </summary>
		public static void SubmitCameraCheck(int assetID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE assets SET
						camera_check_request_dt = NULL,
						camera_check_request_user = NULL,
						camera_check_lastsubmit = NOW()
						WHERE id = @assetID;";
					cmd.Parameters.AddWithValue("assetID", assetID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static int GetAssetIDByTicket(int ticketID)
		{
			var assetID = -1;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT asset_id
						FROM tickets
						WHERE id = @ticketID;";
					cmd.Parameters.AddWithValue("ticketID", ticketID);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							assetID = reader.GetDBInt("asset_id");
				}
				conn.Close();
			}
			return assetID;
		}

		/// <summary>
		/// Inserts a new asset into the database and populates its ID.
		/// </summary>
		public static void AddNew(ref ClassAsset asset)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Insert new asset
					cmd.CommandText =
						string.Format(@"INSERT INTO assets
							({0})
						VALUES
							(@{1});", string.Join(", ", _assetDBFields), string.Join(", @", _assetDBFields));
					cmd.Parameters.AddWithValue("market_id", asset.MarketID);
					cmd.Parameters.AddWithValue("asset", asset.AssetName);
					cmd.Parameters.AddWithValue("panel", asset.Panel);
					cmd.Parameters.AddWithValue("location", asset.Location);
					cmd.Parameters.AddWithValue("address", asset.Address);
					cmd.Parameters.AddWithValue("city", asset.City);
					cmd.Parameters.AddWithValue("state", asset.State);
					cmd.Parameters.AddWithValue("zip", asset.Zip);
					cmd.Parameters.AddWithValue("country", asset.Country);
					cmd.Parameters.AddWithValue("latitude", asset.Latitude);
					cmd.Parameters.AddWithValue("longitude", asset.Longitude);
					cmd.Parameters.AddWithValue("facing", asset.FacingDirection);
					cmd.Parameters.AddWithValue("release_num", asset.ReleaseNumber);
					cmd.Parameters.AddWithValue("net_isp", asset.Net.InternetServiceProvider);
					cmd.Parameters.AddWithValue("wan_ip", asset.Net.WanAddress);
					cmd.Parameters.AddWithValue("interface_type", asset.InterfaceType);
					cmd.Parameters.AddWithValue("interface_qty", asset.InterfaceQty);
					cmd.Parameters.AddWithValue("matrix_width", asset.MatrixWidth);
					cmd.Parameters.AddWithValue("matrix_height", asset.MatrixHeight);
					cmd.Parameters.AddWithValue("pitch", asset.Pitch);
					cmd.Parameters.AddWithValue("face_qty", asset.FaceQty);
					cmd.Parameters.AddWithValue("output_method", asset.OutputMethodId);
					cmd.Parameters.AddWithValue("chip_type", asset.Chip_Type);
					cmd.Parameters.AddWithValue("controller_hw", asset.ControllerHardwareId);
					cmd.Parameters.AddWithValue("controller_sw", asset.ControllerSoftwareId);
					cmd.Parameters.AddWithValue("controller_conn", asset.ControllerConnectionId);
                    cmd.Parameters.AddWithValue("client_conn", asset.ClientConnectionId);
                    cmd.Parameters.AddWithValue("cabinet_type", asset.CabinetTypeId);
					cmd.Parameters.AddWithValue("lift_type", asset.LiftTypeId);
					cmd.Parameters.AddWithValue("lift_height", asset.Lift_Height);
					cmd.Parameters.AddWithValue("uselan", asset.Net.UseLanAddresses);
					cmd.Parameters.AddWithValue("lan_ip", asset.Net.LanAddress);
					cmd.Parameters.AddWithValue("webcaminstalled", asset.Net.Webcam_Installed);
					cmd.Parameters.AddWithValue("webcam_type", asset.Net.Webcam_Type);
					cmd.Parameters.AddWithValue("webcamip", asset.Net.Webcam_Address);
					cmd.Parameters.AddWithValue("webcamport", asset.Net.Webcam_Port);
					cmd.Parameters.AddWithValue("webcamch", asset.Net.Webcam_Channel);
					cmd.Parameters.AddWithValue("webcamuser", asset.Net.Webcam_User);
					cmd.Parameters.AddWithValue("webcampassword", asset.Net.Webcam_Password);
					cmd.Parameters.AddWithValue("iboot_installed", asset.Net.IBoot_Installed);
					cmd.Parameters.AddWithValue("iboot_ip", asset.Net.IBoot_Address);
					cmd.Parameters.AddWithValue("iboot_port", asset.Net.IBoot_Port);
					cmd.Parameters.AddWithValue("iboot_password", asset.Net.IBoot_Password);
					cmd.Parameters.AddWithValue("goose_installed", asset.Net.Goose_Installed);
					cmd.Parameters.AddWithValue("goose_ip", asset.Net.Goose_Address);
					cmd.Parameters.AddWithValue("goose_port", asset.Net.Goose_Port);
					cmd.Parameters.AddWithValue("goose_password", asset.Net.Goose_Password);
					cmd.Parameters.AddWithValue("player_port", asset.Net.Player_Port);
					cmd.Parameters.AddWithValue("player_ssl", asset.Net.Player_UseSsl);
					cmd.Parameters.AddWithValue("player_password", asset.Net.Player_Password);
					cmd.Parameters.AddWithValue("subnet", asset.Net.SubnetMask);
					cmd.Parameters.AddWithValue("gateip", asset.Net.Gateway);
					cmd.Parameters.AddWithValue("router", asset.Net.RouterInfo);
					cmd.Parameters.AddWithValue("serial", asset.SerialNumber);
					cmd.Parameters.AddWithValue("hagl", asset.HeightAboveGroundLevel);
					cmd.Parameters.AddWithValue("indoor", asset.IsIndoor);
					cmd.Parameters.AddWithValue("notes", asset.Notes);
					cmd.Parameters.AddWithValue("access_notes", asset.AccessNotes);
					cmd.Parameters.AddWithValue("vncport", asset.Net.VNC_Port);
					cmd.Parameters.AddWithValue("vncwebport", asset.Net.VNC_WebPort);
					cmd.Parameters.AddWithValue("vncpassword", asset.Net.VNC_Password);
					cmd.Parameters.AddWithValue("tvid", asset.Net.Teamviewer_ID);
					cmd.Parameters.AddWithValue("tvpw", asset.Net.Teamviewer_Password);
					cmd.Parameters.AddWithValue("systemport", asset.Net.System_Port);
					cmd.Parameters.AddWithValue("systemssl", asset.Net.System_UseSsl);
					cmd.Parameters.AddWithValue("systempassword", asset.Net.System_Password);
					cmd.Parameters.AddWithValue("service_reminder", asset.ServiceReminder);
					cmd.Parameters.AddWithValue("service_reminder_user", asset.ServiceReminder_UserID);
					cmd.Parameters.AddWithValue("service_reminder_datetime", asset.ServiceReminder_DateTime);
					cmd.Parameters.AddWithValue("labor_w", asset.WarrantyInfo.LaborWarrantyNumber);
					cmd.Parameters.AddWithValue("parts_w", asset.WarrantyInfo.PartsWarrantyNumber);
					cmd.Parameters.AddWithValue("labor_c", asset.WarrantyInfo.LaborContractNumber);
					cmd.Parameters.AddWithValue("parts_c", asset.WarrantyInfo.PartsContractNumber);
					cmd.Parameters.AddWithValue("install_dt", asset.WarrantyInfo.InstallDate);
					cmd.Parameters.AddWithValue("shipped_dt", asset.WarrantyInfo.ShippedDate);
					cmd.Parameters.AddWithValue("parts_w_end_dt", asset.WarrantyInfo.PartsWarrantyExpire);
					cmd.Parameters.AddWithValue("parts_c_start_dt", asset.WarrantyInfo.PartsContractStart);
					cmd.Parameters.AddWithValue("parts_c_end_dt", asset.WarrantyInfo.PartsContractExpire);
					cmd.Parameters.AddWithValue("labor_w_end_dt", asset.WarrantyInfo.LaborWarrantyExpire);
					cmd.Parameters.AddWithValue("labor_c_start_dt", asset.WarrantyInfo.LaborContractStart);
					cmd.Parameters.AddWithValue("labor_c_end_dt", asset.WarrantyInfo.LaborContractExpire);
					cmd.Parameters.AddWithValue("labor_c_monitoring", asset.WarrantyInfo.MonitoringContractOnly);
					cmd.Parameters.AddWithValue("camera_check_interval", asset.CameraCheckInterval);
					cmd.Parameters.AddWithValue("retired", asset.IsRetired);
					cmd.Parameters.AddWithValue("managed_by_creative", asset.ManagedByCreative);
                    cmd.Parameters.AddWithValue("is_pmc", asset.IsPMC);
                    cmd.Parameters.AddWithValue("bill_to_market", asset.WarrantyInfo.BillToMarket);
                    cmd.Parameters.AddWithValue("is_real_vnc", asset.Net.Use_Real_VNC);
                    
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					asset.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}

				// Insert assigned techs
				if (asset.AssignedTechIDs.Count > 0)
					using (var cmd = conn.CreateCommand())
					{
						var assetID = asset.ID;
						var techIDValues = asset.AssignedTechIDs.Select(techID => string.Format("({0},{1})", assetID, techID)).ToList();
						cmd.CommandText = string.Format(@"INSERT INTO asset_techs (asset_id, tech_id) VALUES {0};", string.Join(",", techIDValues.ToArray()));
						cmd.ExecuteNonQuery();
					}

				// Insert IBOM record
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO assets_ibom
							(asset_id, led_jobnumber, led_assembly, led_calibration,
							ps_assembly, ps_red_voltage, ps_green_voltage, ps_blue_voltage, ps_logic_voltage,
							interface_eprom_type, interface_eprom_version)
						VALUES
							(@AssetID, @led_jobnumber, @led_assembly, @led_calibration,
							@ps_assembly, @ps_red_voltage, @ps_green_voltage, @ps_blue_voltage, @ps_logic_voltage,
							@interface_eprom_type, @interface_eprom_version);";
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					cmd.Parameters.AddWithValue("led_jobnumber", asset.Ibom.LED_JobNumber);
					cmd.Parameters.AddWithValue("led_assembly", asset.Ibom.LED_Assembly);
					cmd.Parameters.AddWithValue("led_calibration", asset.Ibom.LED_Calibration);
					cmd.Parameters.AddWithValue("ps_assembly", asset.Ibom.PS_Assembly);
					cmd.Parameters.AddWithValue("ps_red_voltage", asset.Ibom.PS_RedVoltage);
					cmd.Parameters.AddWithValue("ps_green_voltage", asset.Ibom.PS_GreenVoltage);
					cmd.Parameters.AddWithValue("ps_blue_voltage", asset.Ibom.PS_BlueVoltage);
					cmd.Parameters.AddWithValue("ps_logic_voltage", asset.Ibom.PS_LogicVoltage);
					cmd.Parameters.AddWithValue("interface_eprom_type", asset.Ibom.Interface_EpromType);
					cmd.Parameters.AddWithValue("interface_eprom_version", asset.Ibom.Interface_EpromVersion);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}

				// Insert monitoring record
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"INSERT INTO {0}.displays
							(asset_id, get_data, get_image, trend_debug, interval_m)
						VALUES
							({1}, @DataMode, @WebcamMode, 0, @Interval);", GS.Settings.DBName_Monitoring, asset.ID);
					cmd.Parameters.AddWithValue("DataMode", (int)asset.Monitoring.DataMode);
					cmd.Parameters.AddWithValue("WebcamMode", (int)asset.Monitoring.WebcamMode);
					cmd.Parameters.AddWithValue("Interval", asset.Monitoring.Interval);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}

				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Asset, asset.ID, asset.AssetName);
		}

		public static void Update(ClassAsset asset)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(@"UPDATE assets SET {0} WHERE id = @AssetID;", string.Join(",", _assetDBFields.Select(s => string.Format("{0} = @{0}", s)).ToArray()));

					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					cmd.Parameters.AddWithValue("market_id", asset.MarketID);
					cmd.Parameters.AddWithValue("asset", asset.AssetName);
					cmd.Parameters.AddWithValue("panel", asset.Panel);
					cmd.Parameters.AddWithValue("location", asset.Location);
					cmd.Parameters.AddWithValue("address", asset.Address);
					cmd.Parameters.AddWithValue("city", asset.City);
					cmd.Parameters.AddWithValue("state", asset.State);
					cmd.Parameters.AddWithValue("zip", asset.Zip);
					cmd.Parameters.AddWithValue("country", asset.Country);
					cmd.Parameters.AddWithValue("latitude", asset.Latitude);
					cmd.Parameters.AddWithValue("longitude", asset.Longitude);
					cmd.Parameters.AddWithValue("facing", asset.FacingDirection);
					cmd.Parameters.AddWithValue("release_num", asset.ReleaseNumber);
					cmd.Parameters.AddWithValue("net_isp", asset.Net.InternetServiceProvider);
					cmd.Parameters.AddWithValue("wan_ip", asset.Net.WanAddress);
					cmd.Parameters.AddWithValue("interface_type", asset.InterfaceType);
					cmd.Parameters.AddWithValue("interface_qty", asset.InterfaceQty);
					cmd.Parameters.AddWithValue("matrix_width", asset.MatrixWidth);
					cmd.Parameters.AddWithValue("matrix_height", asset.MatrixHeight);
					cmd.Parameters.AddWithValue("pitch", asset.Pitch);
					cmd.Parameters.AddWithValue("face_qty", asset.FaceQty);
					cmd.Parameters.AddWithValue("output_method", asset.OutputMethodId);
					cmd.Parameters.AddWithValue("chip_type", asset.Chip_Type);
					cmd.Parameters.AddWithValue("controller_hw", asset.ControllerHardwareId);
					cmd.Parameters.AddWithValue("controller_sw", asset.ControllerSoftwareId);
					cmd.Parameters.AddWithValue("controller_conn", asset.ControllerConnectionId);
                    cmd.Parameters.AddWithValue("client_conn", asset.ClientConnectionId);
                    cmd.Parameters.AddWithValue("cabinet_type", asset.CabinetTypeId);
					cmd.Parameters.AddWithValue("lift_type", asset.LiftTypeId);
					cmd.Parameters.AddWithValue("lift_height", asset.Lift_Height);
					cmd.Parameters.AddWithValue("uselan", asset.Net.UseLanAddresses);
					cmd.Parameters.AddWithValue("lan_ip", asset.Net.LanAddress);
					cmd.Parameters.AddWithValue("webcaminstalled", asset.Net.Webcam_Installed);
					cmd.Parameters.AddWithValue("webcam_type", asset.Net.Webcam_Type);
					cmd.Parameters.AddWithValue("webcamip", asset.Net.Webcam_Address);
					cmd.Parameters.AddWithValue("webcamport", asset.Net.Webcam_Port);
					cmd.Parameters.AddWithValue("webcamch", asset.Net.Webcam_Channel);
					cmd.Parameters.AddWithValue("webcamuser", asset.Net.Webcam_User);
					cmd.Parameters.AddWithValue("webcampassword", asset.Net.Webcam_Password);
					cmd.Parameters.AddWithValue("iboot_installed", asset.Net.IBoot_Installed);
					cmd.Parameters.AddWithValue("iboot_ip", asset.Net.IBoot_Address);
					cmd.Parameters.AddWithValue("iboot_port", asset.Net.IBoot_Port);
					cmd.Parameters.AddWithValue("iboot_password", asset.Net.IBoot_Password);
					cmd.Parameters.AddWithValue("goose_installed", asset.Net.Goose_Installed);
					cmd.Parameters.AddWithValue("goose_ip", asset.Net.Goose_Address);
					cmd.Parameters.AddWithValue("goose_port", asset.Net.Goose_Port);
					cmd.Parameters.AddWithValue("goose_password", asset.Net.Goose_Password);
					cmd.Parameters.AddWithValue("player_port", asset.Net.Player_Port);
					cmd.Parameters.AddWithValue("player_ssl", asset.Net.Player_UseSsl);
					cmd.Parameters.AddWithValue("player_password", asset.Net.Player_Password);
					cmd.Parameters.AddWithValue("subnet", asset.Net.SubnetMask);
					cmd.Parameters.AddWithValue("gateip", asset.Net.Gateway);
					cmd.Parameters.AddWithValue("router", asset.Net.RouterInfo);
					cmd.Parameters.AddWithValue("serial", asset.SerialNumber);
					cmd.Parameters.AddWithValue("hagl", asset.HeightAboveGroundLevel);
					cmd.Parameters.AddWithValue("indoor", asset.IsIndoor);
					cmd.Parameters.AddWithValue("notes", asset.Notes);
					cmd.Parameters.AddWithValue("access_notes", asset.AccessNotes);
					cmd.Parameters.AddWithValue("vncport", asset.Net.VNC_Port);
					cmd.Parameters.AddWithValue("vncwebport", asset.Net.VNC_WebPort);
					cmd.Parameters.AddWithValue("vncpassword", asset.Net.VNC_Password);
					cmd.Parameters.AddWithValue("tvid", asset.Net.Teamviewer_ID);
					cmd.Parameters.AddWithValue("tvpw", asset.Net.Teamviewer_Password);
					cmd.Parameters.AddWithValue("systemport", asset.Net.System_Port);
					cmd.Parameters.AddWithValue("systemssl", asset.Net.System_UseSsl);
					cmd.Parameters.AddWithValue("systempassword", asset.Net.System_Password);
					cmd.Parameters.AddWithValue("service_reminder", asset.ServiceReminder);
					cmd.Parameters.AddWithValue("service_reminder_user", asset.ServiceReminder_UserID);
					cmd.Parameters.AddWithValue("service_reminder_datetime", asset.ServiceReminder_DateTime);
					cmd.Parameters.AddWithValue("labor_w", asset.WarrantyInfo.LaborWarrantyNumber);
					cmd.Parameters.AddWithValue("parts_w", asset.WarrantyInfo.PartsWarrantyNumber);
					cmd.Parameters.AddWithValue("labor_c", asset.WarrantyInfo.LaborContractNumber);
					cmd.Parameters.AddWithValue("parts_c", asset.WarrantyInfo.PartsContractNumber);
					cmd.Parameters.AddWithValue("install_dt", asset.WarrantyInfo.InstallDate);
					cmd.Parameters.AddWithValue("shipped_dt", asset.WarrantyInfo.ShippedDate);
					cmd.Parameters.AddWithValue("parts_w_end_dt", asset.WarrantyInfo.PartsWarrantyExpire);
					cmd.Parameters.AddWithValue("parts_c_start_dt", asset.WarrantyInfo.PartsContractStart);
					cmd.Parameters.AddWithValue("parts_c_end_dt", asset.WarrantyInfo.PartsContractExpire);
					cmd.Parameters.AddWithValue("labor_w_end_dt", asset.WarrantyInfo.LaborWarrantyExpire);
					cmd.Parameters.AddWithValue("labor_c_start_dt", asset.WarrantyInfo.LaborContractStart);
					cmd.Parameters.AddWithValue("labor_c_end_dt", asset.WarrantyInfo.LaborContractExpire);
					cmd.Parameters.AddWithValue("labor_c_monitoring", asset.WarrantyInfo.MonitoringContractOnly);
					cmd.Parameters.AddWithValue("camera_check_interval", asset.CameraCheckInterval);
					cmd.Parameters.AddWithValue("retired", asset.IsRetired);
					cmd.Parameters.AddWithValue("managed_by_creative", asset.ManagedByCreative);
                    cmd.Parameters.AddWithValue("is_pmc", asset.IsPMC);
                    cmd.Parameters.AddWithValue("bill_to_market", asset.WarrantyInfo.BillToMarket);
                    cmd.Parameters.AddWithValue("is_real_vnc", asset.Net.Use_Real_VNC);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}

				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Asset, asset.ID, asset.AssetName);
		}

		/// <summary>
		/// Returns how many times specified asset is utilized by the database.
		/// (In Tickets, Shipments, Legacy RMA's, RMA's)
		/// </summary>
		public static int GetUsedQty(int assetID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("AssetID", assetID);

					// TICKETS
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM tickets
						WHERE asset_id = @AssetID
						AND deleted = FALSE;";
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());

					// SHIPMENTS
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM shipment_inventory
						WHERE asset_id = @AssetID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					// LEGACY RMA
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma_legacy
						WHERE asset_id = @AssetID
						AND deleted = FALSE;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					// RMA
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM rma
						WHERE asset_id = @AssetID
						AND deleted = FALSE;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					// Don't count subs and notifications as criteria for preventing deletion
					//                    // USER SUBSCRIPTIONS
					//                    cmd.CommandText =
					//                        @"SELECT COUNT(*) qty
					//						FROM user_subscriptions
					//						WHERE obj_id = @AssetID
					//						AND obj_type = 'Asset';";
					//                    usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					//                    // USER NOTIFICATIONS
					//                    cmd.CommandText =
					//                        @"SELECT COUNT(*) qty
					//						FROM user_notifications
					//						WHERE obj_id = @AssetID
					//						AND obj_type = 'Asset';";
					//                    usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Marks the asset as retired (unusable for new tickets, RMAs, and shipments).
		/// Calling method should verify there are no open items remaining for asset.
		/// </summary>
		public void Retire(bool retire = true)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = $@"UPDATE assets SET retired = {(retire ? 1 : 0)} WHERE id = @asset_id;";
					cmd.Parameters.AddWithValue("asset_id", ID);
					cmd.ExecuteNonQuery();

					if (retire)
					{
						// Remove assigned techs
						cmd.CommandText =
							@"DELETE ast
							FROM asset_techs ast
							JOIN assets a ON ast.asset_id = a.id
							WHERE a.id = @asset_id;";
						cmd.ExecuteNonQuery();
					}
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Permanently deletes specified asset from the database.
		/// Use <see cref="GetUsedQty"/> first to determine if the asset is used before deleting.
		/// </summary>
		public void Delete()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("AssetID", ID);

					cmd.CommandText = @"DELETE FROM assets WHERE id = @AssetID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM asset_techs WHERE asset_id = @AssetID;";
					cmd.ExecuteNonQuery();

					// Delete from IBOM
					cmd.CommandText = @"DELETE FROM assets_ibom WHERE asset_id = @AssetID;";
					cmd.ExecuteNonQuery();

					// Delete from spare parts
					cmd.CommandText = @"DELETE FROM asset_spare_parts WHERE asset_id = @AssetID;";
					cmd.ExecuteNonQuery();

					// Delete from asset journal
					cmd.CommandText = @"DELETE FROM asset_journal WHERE asset_id = @AssetID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM asset_blackout WHERE asset_id = @AssetID";
					cmd.ExecuteNonQuery();

					// Delete from PVM also - Janitor will pick up the removal of atts, subs, defs, and data
					cmd.CommandText = @"DELETE FROM pvm.displays WHERE asset_id = @AssetID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM asset_journal WHERE asset_id = @AssetID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM user_subscriptions WHERE obj_id = @AssetID AND obj_type = 'Asset';";
					cmd.ExecuteNonQuery();

					// Delete ticket for asset only if ticket was already marked as deleted
					cmd.CommandText = @"DELETE FROM tickets WHERE asset_id = @AssetID AND deleted IS TRUE;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Asset, ID, AssetName);
		}

		/// <summary>
		/// Replaces all occurrences of <param name="deprecatedAssetID"/> with <param name="replacementAssetID"/> throughout the database.
		/// Removes <paramref name="deprecatedAssetID"/> from the assets table.
		/// *** It is not necessary to delete the deprecated asset after calling this method.
		/// </summary>
		public static void Merge(int deprecatedAssetID, int replacementAssetID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Update RMAs
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE rma
						SET asset_id = @replacementAssetID
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.Parameters.AddWithValue("replacementAssetID", replacementAssetID);
					cmd.ExecuteNonQuery();

					// Update assigned techs
					// Delete deprecatedAssetID because table has a unique tech-asset index
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"DELETE FROM asset_techs
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.ExecuteNonQuery();

					// Update blackout schedule
					// Delete deprecatedAssetID
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"DELETE FROM asset_blackout
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.ExecuteNonQuery();

					// Asset table, delete deprecated asset
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"DELETE FROM assets
						WHERE id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.ExecuteNonQuery();

					// Assets ibom table, delete deprecated asset rows
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"DELETE FROM assets_ibom
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.ExecuteNonQuery();

					// Asset journal, change id
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE asset_journal
						SET asset_id = @replacementAssetID
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.Parameters.AddWithValue("replacementAssetID", replacementAssetID);
					cmd.ExecuteNonQuery();

					// Old rma table, change asset_id
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE rma_legacy
						SET asset_id = @replacementAssetID
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.Parameters.AddWithValue("replacementAssetID", replacementAssetID);
					cmd.ExecuteNonQuery();

					// Shipment inventory table, change asset_id
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE shipment_inventory
						SET asset_id = @replacementAssetID
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.Parameters.AddWithValue("replacementAssetID", replacementAssetID);
					cmd.ExecuteNonQuery();

					// Tickets table, change asset_id
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE tickets
						SET asset_id = @replacementAssetID
						WHERE asset_id = @deprecatedAssetID;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.Parameters.AddWithValue("replacementAssetID", replacementAssetID);
					cmd.ExecuteNonQuery();

					// User subscriptions
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE user_subscriptions
						SET obj_id = @replacementAssetID
						WHERE obj_id = @deprecatedAssetID
						AND obj_type = @obj_type;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.Parameters.AddWithValue("replacementAssetID", replacementAssetID);
					cmd.Parameters.AddWithValue("obj_type", ClassSubscription.ObjectTypeEnum.Asset.ToString());
					cmd.ExecuteNonQuery();

					// User notifications
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE user_notifications
						SET obj_id = @replacementAssetID
						WHERE obj_id = @deprecatedAssetID
						AND obj_type = @obj_type;";
					cmd.Parameters.AddWithValue("deprecatedAssetID", deprecatedAssetID);
					cmd.Parameters.AddWithValue("replacementAssetID", replacementAssetID);
					cmd.Parameters.AddWithValue("obj_type", ClassSubscription.ObjectTypeEnum.Asset.ToString());
					cmd.ExecuteNonQuery();

				}
				conn.Close();
			}
		}

		/// <summary>
		/// Updates the warranty info for the specified asset. (WC)
		/// </summary>
		public static void UpdateWarranty(ClassAsset asset)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
                        @"UPDATE assets SET
							labor_w = @labor_w,
							labor_c = @labor_c,
							parts_w = @parts_w,
							parts_c = @parts_c,
							install_dt = @install_dt,
							shipped_dt = @shipped_dt,
							parts_w_end_dt = @parts_w_end_dt,
							parts_c_start_dt = @parts_c_start_dt,
							parts_c_end_dt = @parts_c_end_dt,
							labor_w_end_dt = @labor_w_end_dt,
							labor_c_start_dt = @labor_c_start_dt,
							labor_c_end_dt = @labor_c_end_dt,
							labor_c_monitoring = @labor_c_monitoring,
                            bill_to_market = @bill_to_market
						WHERE id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					cmd.Parameters.AddWithValue("labor_w", asset.WarrantyInfo.LaborWarrantyNumber);
					cmd.Parameters.AddWithValue("labor_c", asset.WarrantyInfo.LaborContractNumber);
					cmd.Parameters.AddWithValue("parts_w", asset.WarrantyInfo.PartsWarrantyNumber);
					cmd.Parameters.AddWithValue("parts_c", asset.WarrantyInfo.PartsContractNumber);
					cmd.Parameters.AddWithValue("install_dt", asset.WarrantyInfo.InstallDate);
					cmd.Parameters.AddWithValue("shipped_dt", asset.WarrantyInfo.ShippedDate);
					cmd.Parameters.AddWithValue("parts_w_end_dt", asset.WarrantyInfo.PartsWarrantyExpire);
					cmd.Parameters.AddWithValue("parts_c_start_dt", asset.WarrantyInfo.PartsContractStart);
					cmd.Parameters.AddWithValue("parts_c_end_dt", asset.WarrantyInfo.PartsContractExpire);
					cmd.Parameters.AddWithValue("labor_w_end_dt", asset.WarrantyInfo.LaborWarrantyExpire);
					cmd.Parameters.AddWithValue("labor_c_start_dt", asset.WarrantyInfo.LaborContractStart);
					cmd.Parameters.AddWithValue("labor_c_end_dt", asset.WarrantyInfo.LaborContractExpire);
					cmd.Parameters.AddWithValue("labor_c_monitoring", asset.WarrantyInfo.MonitoringContractOnly);
                    cmd.Parameters.AddWithValue("bill_to_market", asset.WarrantyInfo.BillToMarket);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			var eventString = string.Format("{0} (warranty)", asset.AssetName);
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Asset, asset.ID, eventString);
		}

		/// <summary>
		/// Updates the IBOM info for the specified asset. (IBOM)
		/// </summary>
		public static void UpdateIbom(ClassAsset asset)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE assets_ibom SET
							led_jobnumber = @led_jobnumber,
							led_assembly = @led_assembly,
							led_calibration = @led_calibration,
							ps_assembly = @ps_assembly,
							ps_red_voltage = @ps_red_voltage,
							ps_green_voltage = @ps_green_voltage,
							ps_blue_voltage = @ps_blue_voltage,
							ps_logic_voltage = @ps_logic_voltage,
							interface_eprom_type = @interface_eprom_type,
							interface_eprom_version = @interface_eprom_version,
							interface_assembly_id = @interface_assembly_id
						WHERE asset_id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					cmd.Parameters.AddWithValue("led_jobnumber", asset.Ibom.LED_JobNumber);
					cmd.Parameters.AddWithValue("led_assembly", asset.Ibom.LED_Assembly);
					cmd.Parameters.AddWithValue("led_calibration", asset.Ibom.LED_Calibration);
					cmd.Parameters.AddWithValue("ps_assembly", asset.Ibom.PS_Assembly);
					cmd.Parameters.AddWithValue("ps_red_voltage", asset.Ibom.PS_RedVoltage);
					cmd.Parameters.AddWithValue("ps_green_voltage", asset.Ibom.PS_GreenVoltage);
					cmd.Parameters.AddWithValue("ps_blue_voltage", asset.Ibom.PS_BlueVoltage);
					cmd.Parameters.AddWithValue("ps_logic_voltage", asset.Ibom.PS_LogicVoltage);
					cmd.Parameters.AddWithValue("interface_eprom_type", asset.Ibom.Interface_EpromType);
					cmd.Parameters.AddWithValue("interface_eprom_version", asset.Ibom.Interface_EpromVersion);
					cmd.Parameters.AddWithValue("interface_assembly_id", asset.Ibom.Interface_Assembly_ID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Updates the Monitoring Options for the specified asset.
		/// </summary>
		public static void UpdateMonitoringOptions(ClassAsset asset)
		{
			/*
			 * trend_debug left out intentionally
			 */
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"UPDATE {0}.displays SET
							get_data = @GetData,
							get_image = @GetImage,
							interval_m = @Interval,
							hold_time = @HoldTime
						WHERE asset_id = @AssetID;", GS.Settings.DBName_Monitoring);
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					cmd.Parameters.AddWithValue("GetData", (int)asset.Monitoring.DataMode);
					cmd.Parameters.AddWithValue("GetImage", (int)asset.Monitoring.WebcamMode);
					cmd.Parameters.AddWithValue("Interval", asset.Monitoring.Interval);
					cmd.Parameters.AddWithValue("HoldTime", asset.Monitoring.HoldTime);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			// Redundant, is called every time the asset main details are modified, so no need to separately log monitoring info changes...
			// ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Asset, Asset.ID, string.Format("{0} (monitoring)", Asset.AssetName));
		}

		/// <summary>
		/// Creates a "lock" when a ticket is being created for an asset.
		/// Unlocks if <paramref name="userID"/> is null.
		/// </summary>
		/// <param name="asset">The asset to lock/unlock.</param>
		/// <param name="userID">Optional: Provide user id to lock or null to unlock.</param>
		public static void TicketLock(ClassAsset asset, int? userID = null)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE assets
						SET ticket_lock = @UserID
						WHERE id = @AssetID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Returns ClassUser if a ticket lock is in place, null if not.
		/// </summary>
		public static ClassUser GetTicketLock(ClassAsset asset)
		{
			ClassUser userLock = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT ticket_lock
						FROM assets
						WHERE id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							userLock = ClassUser.GetByID(reader.GetDBInt("ticket_lock"));
						}
				}
				conn.Close();
			}
			return userLock;
		}

		/// <summary>
		/// Assigns all specified techs (by tech ID) to the specified asset.
		/// </summary>
		public static void AssignTechs(ClassAsset asset, List<ClassTech> techs)
		{
			// Reassign priorities to avoid number gaps
			var priority = 1;
			foreach (var tech in techs.Where(t => t.Priority.HasValue).OrderBy(t => t.Priority.GetValueOrDefault(1)))
			{
				tech.Priority = priority;
				priority++;
			}

			// Assign priorities to all techs which have no priority.
			// Tech priority defaults to null, but the asset_techs table does not accept null priorities.
			// Process list alphabetically so that techs are shown in the same order as when presented, initially.
			var highestPriorityValue = techs.Any() ? techs.Max(t => t.Priority.GetValueOrDefault(0)) : 0;
			foreach (var tech in techs.OrderBy(t => t.TechName).Where(tech => !tech.Priority.HasValue))
			{
				tech.Priority = highestPriorityValue + 1;
				highestPriorityValue++;
			}

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();

				// Clear assigned techs
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM asset_techs WHERE asset_id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", asset.ID);
					cmd.ExecuteNonQuery();
				}

				// Insert assigned techs
				if (techs.Count > 0)
					using (var cmd = conn.CreateCommand())
					{
						var assetID = asset.ID;
						var values = techs.Select(t => $"({assetID},{t.ID},{t.Priority})").ToList();
						cmd.CommandText = $@"INSERT INTO asset_techs (asset_id, tech_id, priority) VALUES {string.Join(",", values.ToArray())};";
						cmd.ExecuteNonQuery();
					}

				conn.Close();
			}
		}

		/// <summary>
		/// Increases the specified Tech's priority. For example, if 3rd priority, the tech will be 2nd.
		/// </summary>
		public static void IncreaseTechPriority(int assetID, int techID)
		{
			// Get all assigned techs for the specified assset
			var assignedTechs = ClassTech.GetByAsset(assetID).ToList();

			// If the specified tech isn't assigned, do nothing
			if (assignedTechs.All(t => t.ID != techID))
				return;

			// If the specified tech is already highest priority, do nothing
			var promotedTech = assignedTechs.Single(t => t.ID == techID);
			if (promotedTech.Priority <= 1)
				return;

			// Order by priority and reassign all priority numbers from 1 to end
			assignedTechs = assignedTechs.OrderBy(t => t.Priority).ToList();
			for (var p = 0; p < assignedTechs.Count; p++)
				assignedTechs[p].Priority = p + 1;

			// Figure out intended new priority of specified tech
			var newPriority = promotedTech.Priority.GetValueOrDefault(1) - 1;

			// Demote techs with this priority
			foreach (var tech in assignedTechs.Where(t => t.Priority == newPriority))
				tech.Priority += 1;

			// Promote tech
			promotedTech.Priority -= 1;

			// Update database
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					foreach (var tech in assignedTechs)
					{
						cmd.Parameters.Clear();
						cmd.CommandText =
							@"UPDATE asset_techs
							SET priority = @Priority
							WHERE asset_id = @AssetID
							AND tech_id = @TechID;";
						cmd.Parameters.AddWithValue("Priority", tech.Priority);
						cmd.Parameters.AddWithValue("AssetID", assetID);
						cmd.Parameters.AddWithValue("TechID", tech.ID);
						cmd.ExecuteNonQuery();
					}
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Sets the notification text for this asset.
		/// </summary>
		public void SetServiceReminder(string reminder)
		{
			if (string.IsNullOrEmpty(reminder))
			{
				ClearServiceReminder();
				return;
			}

			ServiceReminder = reminder;
			ServiceReminder_DateTime = ClassDatabase.GetCurrentTime();
			ServiceReminder_UserID = GS.Settings.LoggedOnUser.ID;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE assets
						SET
							service_reminder = @Reminder,
							service_reminder_user = @UserID,
							service_reminder_datetime = @UpdateTime
						WHERE id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", ID);
					cmd.Parameters.AddWithValue("Reminder", ServiceReminder);
					cmd.Parameters.AddWithValue("UpdateTime", ServiceReminder_DateTime);
					cmd.Parameters.AddWithValue("UserID", ServiceReminder_UserID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			var entry = string.Format("Set service reminder: \"{0}\"", reminder.Truncate(50));
			ClassJournal.AddJournalEntry(this, entry, null, true);
		}

		/// <summary>
		/// Clears the notification text for this asset.
		/// </summary>
		public void ClearServiceReminder()
		{
			ServiceReminder = string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE assets
						SET service_reminder = NULL,
						service_reminder_user = NULL,
						service_reminder_datetime = NULL
						WHERE id = @AssetID;";
					cmd.Parameters.AddWithValue("AssetID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassJournal.AddJournalEntry(this, "Cleared service reminder.", null, true);
		}

		private static ClassAsset GetFromReader(MySqlDataReader reader)
		{
            var asset = new ClassAsset
            {
                ID = reader.GetDBInt("id"),
                MarketID = reader.GetDBInt("market_id"),
                AssetName = reader.GetDBString("asset"),
                Panel = reader.GetDBString("panel"),
                Location = reader.GetDBString("location"),
                Address = reader.GetDBString("address"),
                City = reader.GetDBString("city"),
                State = reader.GetDBString("state"),
                Zip = reader.GetDBString("zip"),
                Country = reader.GetDBString("country"),
                Latitude = reader.GetDBDecimal_Null("latitude"),
                Longitude = reader.GetDBDecimal_Null("longitude"),
                HeightAboveGroundLevel = reader.GetDBInt("hagl"),
                IsIndoor = reader.GetDBBool("indoor"),
                FacingDirection = reader.GetDBString("facing"),
                InterfaceType = reader.GetDBString("interface_type"),
                InterfaceQty = reader.GetDBInt("interface_qty"),
                MatrixWidth = reader.GetDBInt("matrix_width"),
                MatrixHeight = reader.GetDBInt("matrix_height"),
                OutputMethodId = reader.GetDBInt_Null("output_method"),
                FaceQty = reader.GetDBInt("face_qty"),
                Pitch = reader.GetDBInt("pitch"),
                Chip_Type = reader.GetDBString("chip_type"),
                ControllerHardwareId = reader.GetDBInt_Null("controller_hw"),
                ControllerSoftwareId = reader.GetDBInt_Null("controller_sw"),
                ControllerConnectionId = reader.GetDBInt_Null("controller_conn"),
                ClientConnectionId = reader.GetDBInt_Null("client_conn"),
                CabinetTypeId = reader.GetDBInt_Null("cabinet_type"),
                LiftTypeId = reader.GetDBInt_Null("lift_type"),
                Lift_Height = reader.GetDBInt("lift_height"),
                Notes = reader.GetDBString("notes"),
                AccessNotes = reader.GetDBString("access_notes"),
                ServiceReminder = reader.GetDBString("service_reminder"),
                ServiceReminder_UserID = reader.GetDBInt_Null("service_reminder_user"),
                ServiceReminder_DateTime = reader.GetDBDateTime_Null("service_reminder_datetime"),
                ReleaseNumber = reader.GetDBString("release_num"),
                SerialNumber = reader.GetDBString("serial"),
                CameraCheckInterval = reader.GetDBInt("camera_check_interval"),
                IsRetired = reader.GetDBBool("retired"),
                ManagedByCreative = reader.GetDBBool("managed_by_creative"),
                IsPMC = reader.GetDBBool("is_pmc"),

				Net = new ClassNetworkInfo
				{
					LanAddress = reader.GetDBString("lan_ip"),
					System_Port = reader.GetDBInt_Null("systemport"),
					System_UseSsl = reader.GetDBBool_Null("systemssl"),
					System_Password = reader.GetDBString("systempassword"),
					Webcam_Installed = reader.GetDBBool("webcaminstalled"),
					Webcam_Type = reader.GetDBInt_Null("webcam_type"),
					Webcam_Address = reader.GetDBString("webcamip"),
					Webcam_Port = reader.GetDBInt_Null("webcamport"),
					Webcam_Channel = reader.GetDBInt("webcamch"),
					Webcam_User = reader.GetDBString("webcamuser"),
					Webcam_Password = reader.GetDBString("webcampassword"),
					Gateway = reader.GetDBString("gateip"),
					SubnetMask = reader.GetDBString("subnet"),
					InternetServiceProvider = reader.GetDBString("net_isp"),
					RouterInfo = reader.GetDBString("router"),
					UseLanAddresses = reader.GetDBBool("uselan"),
                    Use_Real_VNC = reader.GetDBBool("is_real_vnc"),
					VNC_Port = reader.GetDBInt_Null("vncport"),
					VNC_WebPort = reader.GetDBInt_Null("vncwebport"),
					VNC_Password = reader.GetDBString("vncpassword"),
					WanAddress = reader.GetDBString("wan_ip"),
					IBoot_Installed = reader.GetDBBool("iboot_installed"),
					IBoot_Address = reader.GetDBString("iboot_ip"),
					IBoot_Port = reader.GetDBInt_Null("iboot_port"),
					IBoot_Password = reader.GetDBString("iboot_password"),
					Goose_Installed = reader.GetDBBool("goose_installed"),
					Goose_Address = reader.GetDBString("goose_ip"),
					Goose_Port = reader.GetDBInt_Null("goose_port"),
					Goose_Password = reader.GetDBString("goose_password"),
					Player_Port = reader.GetDBInt_Null("player_port"),
					Player_UseSsl = reader.GetDBBool_Null("player_ssl"),
					Player_Password = reader.GetDBString("player_password"),
					Teamviewer_ID = reader.GetDBString("tvid"),
					Teamviewer_Password = reader.GetDBString("tvpw")
				},

				WarrantyInfo = new ClassWarrantyInfo
				{
					LaborWarrantyNumber = reader.GetDBString("labor_w"),
					InstallDate = reader.GetDBDateTime_Null("install_dt"),
					LaborWarrantyExpire = reader.GetDBDateTime_Null("labor_w_end_dt"),

					LaborContractNumber = reader.GetDBString("labor_c"),
					LaborContractStart = reader.GetDBDateTime_Null("labor_c_start_dt"),
					LaborContractExpire = reader.GetDBDateTime_Null("labor_c_end_dt"),
					MonitoringContractOnly = reader.GetDBBool("labor_c_monitoring"),
                    BillToMarket = reader.GetDBBool("labor_c_monitoring"),

                    PartsWarrantyNumber = reader.GetDBString("parts_w"),
					ShippedDate = reader.GetDBDateTime_Null("shipped_dt"),
					PartsWarrantyExpire = reader.GetDBDateTime_Null("parts_w_end_dt"),

					PartsContractNumber = reader.GetDBString("parts_c"),
					PartsContractStart = reader.GetDBDateTime_Null("parts_c_start_dt"),
					PartsContractExpire = reader.GetDBDateTime_Null("parts_c_end_dt")
				},

				CameraCheckInfo = new ClassCameraCheckInfo
				{
					CameraCheckLastRequest = reader.GetDBDateTime_Null("camera_check_request_dt"),
					CameraCheckRequestUserID = reader.GetDBInt_Null("camera_check_request_user"),
					CameraCheckLastSubmit = reader.GetDBDateTime_Null("camera_check_lastsubmit")
				}
			};
			return asset;
		}

		private static ClassMonitoringOptions GetAssetMonitoringOptionsFromReader(MySqlDataReader reader)
		{
			var dataMode = reader.GetDBInt("get_data");
			var webcamMode = reader.GetDBInt("get_image");
			return new ClassMonitoringOptions
			{
				DataMode = (ClassMonitoringOptions.MonitoringMode)dataMode,
				WebcamMode = (ClassMonitoringOptions.MonitoringMode)webcamMode,
				Trend_Debug = reader.GetDBBool("trend_debug"),

				Interval = reader.GetDBInt("interval_m"),
				HoldTime = reader.GetDBInt("hold_time"),

				LastAttempt = reader.GetDBDateTime_Null("dt_attempt"),
				LastData = reader.GetDBDateTime_Null("dt_data"),
				LastImage = reader.GetDBDateTime_Null("dt_image")
			};
		}

		private static ClassIbom GetIbomFromReader(MySqlDataReader reader)
		{
			return new ClassIbom
			{
				Asset_ID = reader.GetDBInt("asset_id"),
				LED_JobNumber = reader.GetDBString("led_jobnumber"),
				LED_Assembly = reader.GetDBString("led_assembly"),
				LED_Calibration = reader.GetDBString("led_calibration"),
				PS_Assembly = reader.GetDBString("ps_assembly"),
				PS_RedVoltage = reader.GetDBDecimal("ps_red_voltage"),
				PS_GreenVoltage = reader.GetDBDecimal("ps_green_voltage"),
				PS_BlueVoltage = reader.GetDBDecimal("ps_blue_voltage"),
				PS_LogicVoltage = reader.GetDBDecimal("ps_logic_voltage"),
				Interface_EpromType = reader.GetDBString("interface_eprom_type"),
				Interface_EpromVersion = reader.GetDBString("interface_eprom_version"),
				Interface_Assembly_ID = reader.GetDBInt_Null("interface_assembly_id")
			};
		}

		public static int GetOpenTicketQty(int assetID)
		{
			int openTicketQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(t.id)
						FROM tickets t
						WHERE t.asset_id = @assetID
							AND t.deleted IS FALSE
							AND t.close_dt IS NULL;";
					cmd.Parameters.AddWithValue("assetID", assetID);
					openTicketQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return openTicketQty;
		}

		/// <summary>
		/// Populates <see cref="OpenTicketData"/> with a list of open ticket IDs, symptoms, and types for this asset.
		/// </summary>
		public void PopulateOpenTicketData()
		{
			OpenTicketData = new List<OpenTicketMiniInfo>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT t.id, t.held, t.tickettype, GROUP_CONCAT(DISTINCT(sym.symptom) SEPARATOR ', ') symptoms
						FROM tickets t
							LEFT JOIN ticket_symptoms tsym
								JOIN symptoms sym on tsym.symptom_id = sym.id
							ON tsym.ticket_id = t.id
						WHERE t.close_dt IS NULL
							AND t.deleted IS FALSE
							AND t.asset_id = @assetID
						GROUP BY t.id;";
					cmd.Parameters.AddWithValue("assetID", ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var ticketData = new OpenTicketMiniInfo
							{
								TicketID = reader.GetDBInt("id"),
								Symptoms = reader.GetDBString("symptoms")
							};
							OpenTicketData.Add(ticketData);
						}
				}
				conn.Close();
			}
		}

		public string ExportHeadersAsCsvString()
		{
			return "\"" + string.Join("\",\"", "Asset", "Panel", "Customer", "Market",
				       // TRACKING
				       "Release Number", "Serial Number",
				       // GEOGRAPHIC
				       "Location", "Address", "City", "State", "Zip", "Country", "Longitude", "Latitude",
				       // LABOR WARRANTY
				       "Labor Warranty Number", "Installation Date", "Labor Warranty Expiration",
				       // LABOR CONTRACT
				       "Labor Contract Number", "Labor Contract Start", "Labor Contract Expiration",
				       // CONTRACT OPTIONS
				       "Managed by Creative", "Monitoring Contract Only", "Is Retired",
				       // PARTS WARRANTY
				       "Parts Warranty Number", "Shipped Date", "Parts Warranty Expiration",
				       // PARTS CONTRACT
				       "Parts Contract Number", "Parts Contract Start", "Parts Contract Expiration",
				       // PHYSICAL
				       "Matrix", "Pitch (mm)", "Face Qty", "Facing", "Height Above Ground Level (ft)", "Indoor",
				       "Cabinet Type", "Interface Qty", "Interface Type", "Chip Type", "Controller Hardware",
				       "Controller Software", "Controller Connection", "Output Method",
				       // NETWORK
				       "WAN Address", "LAN Address", "Use LAN Address", "Gateway", "Subnet Mask",
				       // NETWORK: CONTROLLER SW
				       "Controller Software HTTP Port", "Controller Software Use SSL",
				       // NETWORK: CMS SW
				       "Player HTTP Port", "Player Use SSL",
				       // NETWORK: CAM
				       "Webcam Installed", "Webcam Address", "Webcam HTTP Port", "Webcam Channel",
				       // NETWORK: REMOTE POWER
				       "IBoot Installed", "IBoot Address", "IBoot HTTP Port",
				       // NETWORK: SENSOR
				       "Minigoose Installed", "Minigoose Address", "Minigoose HTTP Port",
				       // NETWORK: MONITORING
				       "Camera Check Interval (min)") + "\"";
		}

		/// <summary>
		/// Returns properties of asset as a CSV string for exporting.
		/// </summary>
		public string ExportPropertiesAsCsvString()
		{
			return "\"" + string.Join("\",\"", AssetName, Panel, ExtraProperties.CustomerName, ExtraProperties.MarketName,
					   // TRACKING
				       ReleaseNumber, SerialNumber,
					   // GEOGRAPHIC
					   Location, Address, City, State, Zip, Country, Longitude, Latitude,
					   // LABOR WARRANTY
					   WarrantyInfo.LaborWarrantyNumber, WarrantyInfo.InstallDate, WarrantyInfo.LaborWarrantyExpire,
					   // LABOR CONTRACT
					   WarrantyInfo.LaborContractNumber, WarrantyInfo.LaborContractStart, WarrantyInfo.LaborContractExpire,
					   // CONTRACT OPTIONS
					   ManagedByCreative, WarrantyInfo.MonitoringContractOnly, IsRetired,
					   // PARTS WARRANTY
					   WarrantyInfo.PartsWarrantyNumber, WarrantyInfo.ShippedDate, WarrantyInfo.PartsWarrantyExpire,
					   // PARTS CONTRACT
					   WarrantyInfo.PartsContractNumber, WarrantyInfo.PartsContractStart, WarrantyInfo.PartsContractExpire,
					   // PHYSICAL
				       MatrixSize, Pitch, FaceQty, FacingDirection, HeightAboveGroundLevel, IsIndoor,
					   ExtraProperties.CabinetType, InterfaceQty, InterfaceType, Chip_Type, ExtraProperties.ControllerHardware,
					   ExtraProperties.ControllerSoftware, ExtraProperties.ControllerConnection, ExtraProperties.OutputMethod,
					   // NETWORK
					   Net.WanAddress, Net.LanAddress, Net.UseLanAddresses, Net.Gateway, Net.SubnetMask,
					   // NETWORK: CONTROLLER SW
				       Net.System_Port, Net.System_UseSsl,
					   // NETWORK: CMS SW
					   Net.Player_Port, Net.Player_UseSsl,
					   // NETWORK: CAM
					   Net.Webcam_Installed, Net.Webcam_Address, Net.Webcam_Port, Net.Webcam_Channel,
					   // NETWORK: REMOTE POWER
					   Net.IBoot_Installed, Net.IBoot_Address, Net.IBoot_Port,
					   // NETWORK: SENSOR
					   Net.Goose_Installed, Net.Goose_Address, Net.Goose_Port,
					   // NETWORK: MONITORING
					   CameraCheckInterval) + "\"";
		}
		#endregion
	}
}