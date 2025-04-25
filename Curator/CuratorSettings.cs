using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Curator
{
	public class CuratorSettings
	{
		[XmlIgnore] public static readonly string SETTINGS_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"SEA", @"NOC Service Database");

		private string _emailReplyTo;

		[XmlIgnore]
		public const string SETTINGS_FILE = @"curator_settings.xml";

		public FormWindowState WindowState { get; set; }
		public Point WindowLocation { get; set; }

		public string SQLServer { get; set; }
		public string SQLUser { get; set; }
		public string SQLPassword { get; set; }
		public string SQLDatabase { get; set; }
		public int SQLTimeout { get; set; }

		public string EmailServer { get; set; }
		public string EmailServerPort { get; set; }
		public bool EmailServerUseSSL { get; set; }
		public string EmailAccount { get; set; }
		/// <summary>
		/// Human-readable name for email user account (e.g. 'Service Center' or 'John Smith')
		/// </summary>
		public string EmailName { get; set; }
		public string EmailPassword { get; set; }

		public string EmailReplyTo
		{
			get
			{
				return string.IsNullOrEmpty(_emailReplyTo) ? EmailAccount : _emailReplyTo;
			}
			set { _emailReplyTo = value; }
		}

		/// <summary>
		/// Comma-separated list of email addresses to send summary information to.
		/// </summary>
		public string EmailAddressesForSummary { get; set; }

		/// <summary>
		/// How often Unreceived RMAs are evaluated (regardless of whether notifications are enabled).
		/// </summary>
		public int UnreceivedRmaNotification_CheckIntervalMinutes { get; set; }
		/// <summary>
		/// When the last check was performed.
		/// </summary>
		public DateTime UnreceivedRmaNotification_LastCheck { get; set; }

		/// <summary>
		/// Determines whether first notification is enabled.
		/// </summary>
		public bool UnreceivedRmaNotification_FirstNotification_Enabled { get; set; }
		/// <summary>
		/// How many days old an unreceived RMA must be to send first notification.
		/// </summary>
		public int UnreceivedRmaNotification_FirstNotification_DaysRequired { get; set; }
		/// <summary>
		/// An unreceived RMA must be _fewer_ than this many days old to send first notification.
		/// </summary>
		public int UnreceivedRmaNotification_FirstNotification_DaysNotToExceed { get; set; }
		/// <summary>
		/// The first notification text to send to technicians. Precedes the list of RMAs and their assemblies.
		/// </summary>
		public string UnreceivedRmaNotification_FirstNotification_Header { get; set; }
		/// <summary>
		/// The first notification text to send to technicians. Follows the list of RMAs and their assemblies.
		/// </summary>
		public string UnreceivedRmaNotification_FirstNotification_Footer { get; set; }

		/// <summary>
		/// Determines whether second notification is enabled.
		/// </summary>
		public bool UnreceivedRmaNotification_SecondNotification_Enabled { get; set; }
		/// <summary>
		/// How many days old an unreceived RMA must be to send second notification.
		/// </summary>
		public int UnreceivedRmaNotification_SecondNotification_DaysRequired { get; set; }
		/// <summary>
		/// An unreceived RMA must be _fewer_ than this many days old to send second notification.
		/// </summary>
		public int UnreceivedRmaNotification_SecondNotification_DaysNotToExceed { get; set; }
		/// <summary>
		/// The second notification text to send to technicians. Precedes the list of RMAs and their assemblies.
		/// </summary>
		public string UnreceivedRmaNotification_SecondNotification_Header { get; set; }
		/// <summary>
		/// The second notification text to send to technicians. Follows the list of RMAs and their assemblies.
		/// </summary>
		public string UnreceivedRmaNotification_SecondNotification_Footer { get; set; }

		/// <summary>
		/// If an RMA has generated a prior notification, prevent additional notifications being sent for this many days.
		/// </summary>
		public int UnreceivedRmaNotification_DaysBeforeSendingAnotherNotice { get; set; }

		public CuratorSettings()
		{
			WindowState = FormWindowState.Normal;
			WindowLocation = new Point(0, 0);
			SQLServer = @"";
			SQLUser = @"";
			SQLPassword = string.Empty;
			SQLDatabase = @"";
			SQLTimeout = 45;

			EmailServer = @"";
			EmailServerPort = @"";
			EmailServerUseSSL = true;
			EmailAccount = @"";
			EmailName = @"";
			EmailPassword = @"";
			//EmailPassword = @"y9H5$2nITl%MOH56wA";

			EmailAddressesForSummary = string.Empty;
			UnreceivedRmaNotification_CheckIntervalMinutes = 1440;
			UnreceivedRmaNotification_LastCheck = DateTime.MinValue;

			UnreceivedRmaNotification_FirstNotification_Enabled = true;
			UnreceivedRmaNotification_FirstNotification_DaysRequired = 30;
			UnreceivedRmaNotification_FirstNotification_DaysNotToExceed = 60;
			UnreceivedRmaNotification_FirstNotification_Header = "Our records indicate the following RMA(s) have not yet been received. Please take a moment to check your inventory and ship these items as soon as possible.";
			UnreceivedRmaNotification_FirstNotification_Footer = "Please include the RMA number clearly on the package and ship to:\n\tElectronic Service Group\n\tSEA\n\t1651 N 1000 W\n\tLOGAN UT 84321";

			UnreceivedRmaNotification_SecondNotification_Enabled = true;
			UnreceivedRmaNotification_SecondNotification_DaysRequired = 60;
			UnreceivedRmaNotification_SecondNotification_DaysNotToExceed = 90;
			UnreceivedRmaNotification_SecondNotification_Header = "Our records indicate the following RMA(s) have not yet been received after more than 60 days. Please contact us if you believe this to be in error. It is important that we receive these items as soon as possible.";
			UnreceivedRmaNotification_SecondNotification_Footer = "Please include the RMA number clearly on the package and ship to:\n\tElectronic Service Group\n\tSEA\n\t1651 N 1000 W\n\tLOGAN UT 84321";

			UnreceivedRmaNotification_DaysBeforeSendingAnotherNotice = 30;
		}

		public void SaveSettings()
		{
			if (!Directory.Exists(SETTINGS_PATH))
				Directory.CreateDirectory(SETTINGS_PATH);

			var writerSettings = new XmlWriterSettings { NewLineHandling = NewLineHandling.Entitize };

			var serializer = new XmlSerializer(typeof(CuratorSettings));
			using (var writer = XmlWriter.Create(Path.Combine(SETTINGS_PATH, SETTINGS_FILE), writerSettings))
			{
				serializer.Serialize(writer, this);
				writer.Flush();
				writer.Close();
			}
		}

		public CuratorSettings LoadSettings()
		{
			var temp = new CuratorSettings();
			if (File.Exists(Path.Combine(SETTINGS_PATH, SETTINGS_FILE)))
			{
				using (var sr = new StreamReader(Path.Combine(SETTINGS_PATH, SETTINGS_FILE)))
				{
					try
					{
						var x = new XmlSerializer(typeof(CuratorSettings));
						temp = (CuratorSettings)x.Deserialize(sr);
					}
					catch
					{
						MessageBox.Show("The settings file could not be read.");
					}
				}
			}
			return temp;
		}
	}
}