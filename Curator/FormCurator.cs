using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes;
using SDB.Classes.General;

namespace Curator
{
	public sealed partial class FormCurator : Form
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		private enum WhichNotification
		{
			First,
			Second
		};
		#endregion

		#region Private Fields
		internal static CuratorSettings Settings = new CuratorSettings();
		private bool _endSessionPending;
		private const int _WM_QUERYENDSESSION = 0x11;
		private readonly StringBuilder _summaryEmail = new StringBuilder();
		private readonly Queue<ClassUnreceivedRmaEmail> _emailQueue = new Queue<ClassUnreceivedRmaEmail>();
		#endregion

		#region Constructor
		public FormCurator()
		{
			InitializeComponent();
			LoadSettings();
			Text = string.Format("{0} {1}", Application.ProductName, Application.ProductVersion);
		}
		#endregion

		#region Private Methods
		private void FormCurator_Load(object sender, EventArgs e)
		{
			WindowState = Settings.WindowState;
			if (Settings.WindowState == FormWindowState.Minimized)
			{
				ShowInTaskbar = false;
				tsmiHide.Visible = false;
			}
			else
			{
				Location = Settings.WindowLocation;
				tsmiShow.Visible = false;
			}
			Application.Idle += Application_Idle;
		}

		private void Application_Idle(object sender, EventArgs e)
		{
			Application.Idle -= Application_Idle;
			StartTimers();
		}

		private void FormCurator_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_endSessionPending || e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.WindowsShutDown)
			{
				StopTimers();
				Settings.WindowState = WindowState;
				if (WindowState == FormWindowState.Normal)
					Settings.WindowLocation = Location;
				Settings.SaveSettings();
			}
			else
			{
				e.Cancel = true;
				MinimizeToTray();
			}
			OnClosing(e);
		}

		private void LoadSettings()
		{
			MigrateOldSettings();
			Settings = Settings.LoadSettings();
			mnuInitiate_UnreceivedRma1.Enabled = Settings.UnreceivedRmaNotification_FirstNotification_Enabled;
			mnuInitiate_UnreceivedRma2.Enabled = Settings.UnreceivedRmaNotification_SecondNotification_Enabled;
		}

		/// <summary>
		/// Checks for previous "Yesco" settings file and moves it to new settings path (one time).
		/// If so, the log file is also moved if possible.
		/// </summary>
		private void MigrateOldSettings()
		{
			var newSettingsFile = Path.Combine(CuratorSettings.SETTINGS_PATH, CuratorSettings.SETTINGS_FILE);
			if (File.Exists(newSettingsFile))
				return;

			var oldSettingsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Yesco", @"SDB", CuratorSettings.SETTINGS_FILE);
			if (!File.Exists(oldSettingsFile))
				return;

			try
			{
				Directory.CreateDirectory(CuratorSettings.SETTINGS_PATH);
				File.Move(oldSettingsFile, newSettingsFile);
			}
			catch (Exception exc)
			{
				MessageBox.Show("Old settings file found, but could not be migrated: " + exc.Message);
			}

			var oldLogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Yesco", @"SDB", ClassLogFile.LOG_FILENAME);
			var newLogFIle = Path.Combine(ClassLogFile.LOG_PATH, ClassLogFile.LOG_FILENAME);
			if (File.Exists(newLogFIle) || !File.Exists(oldLogFile))
				return;

			try
			{
				Directory.CreateDirectory(ClassLogFile.LOG_PATH);
				File.Move(oldLogFile, newLogFIle);
			}
			catch
			{
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				RestoreFromTray();
			else
				MinimizeToTray();
		}

		private void tsmiShow_Click(object sender, EventArgs e)
		{
			RestoreFromTray();
		}

		private void tsmiHide_Click(object sender, EventArgs e)
		{
			MinimizeToTray();
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			_endSessionPending = true;
			Close();
		}

		private void RestoreFromTray()
		{
			if (WindowState == FormWindowState.Minimized)
			{
				Show();
				WindowState = FormWindowState.Normal;
				Location = Settings.WindowLocation;
				ShowInTaskbar = true;
				tsmiShow.Visible = false;
				tsmiHide.Visible = true;
			}
			BringToFront();
		}

		private void MinimizeToTray()
		{
			Hide();
			WindowState = FormWindowState.Minimized;
			tsmiShow.Visible = true;
			tsmiHide.Visible = false;
		}

		private void StartTimers()
		{
			timerUnreceivedRmaCheck.Start();
			btnStartStop.Text = "Stop";
		}

		private void StopTimers()
		{
			timerUnreceivedRmaCheck.Stop();
			btnStartStop.Text = "Start";
		}

		private void FormCurator_ResizeEnd(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				Settings.WindowLocation = Location;
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			_endSessionPending = true;
			Close();
		}

		private void mnuSettings_Click(object sender, EventArgs e)
		{
			ShowSettings();
		}

		private void ShowSettings()
		{
			using (var settingsForm = new FormSettings())
			{
				if (settingsForm.ShowDialog() != DialogResult.OK)
					return;

				Settings.SaveSettings();
				LoadSettings();
			}
		}

		private void timerGuiUpdate_Tick(object sender, EventArgs e)
		{
			var expectedNextCheck = Settings.UnreceivedRmaNotification_LastCheck.AddMinutes(Settings.UnreceivedRmaNotification_CheckIntervalMinutes);
			var timeUntilNextCheck = expectedNextCheck - DateTime.Now;
			var nextCheckText = timeUntilNextCheck > TimeSpan.Zero ? string.Format("Running, {0} to next check.", ClassUtility.FormatRoundedTimeSpan_Dhm(timeUntilNextCheck.Duration())) : "Next check overdue.";
			var isRunning = timerUnreceivedRmaCheck.Enabled;
			lblStatus.Text = isRunning ? nextCheckText : "Idle";
		}

		private void timerUnreceivedRmaCheck_Tick(object sender, EventArgs e)
		{
			var timeSinceLastCheck = DateTime.Now - Settings.UnreceivedRmaNotification_LastCheck;
			if (timeSinceLastCheck.TotalMinutes < Settings.UnreceivedRmaNotification_CheckIntervalMinutes)
				return;

			Settings.UnreceivedRmaNotification_LastCheck = DateTime.Now;
			RmaCheck1();
			RmaCheck2();
		}

		private void RmaCheck1()
		{
			if (!Settings.UnreceivedRmaNotification_FirstNotification_Enabled)
				return;

			try
			{
				_summaryEmail.Clear();
				PerformUnreceivedRmaCheck(
					Settings.UnreceivedRmaNotification_FirstNotification_DaysRequired,
					Settings.UnreceivedRmaNotification_FirstNotification_DaysNotToExceed,
					Settings.UnreceivedRmaNotification_DaysBeforeSendingAnotherNotice,
					WhichNotification.First);
				var summaryEmailSubject = string.Format("NOC Service Database Curator Summary for {0:yyyy-MM-dd}, {1}-day", DateTime.Now, Settings.UnreceivedRmaNotification_FirstNotification_DaysRequired);
				SendSummaryEmail(summaryEmailSubject);
			}
			catch (MySqlException exc)
			{
				string error = string.Format("\t\tError checking Unreceived RMAs for First Notification: {0}", exc.Message);
				ClassLogFile.AddEntry(error);
			}

			if (!bgwEmailSender.IsBusy)
				bgwEmailSender.RunWorkerAsync();
		}

		private void RmaCheck2()
		{
			if (!Settings.UnreceivedRmaNotification_SecondNotification_Enabled)
				return;

			try
			{
				_summaryEmail.Clear();
				PerformUnreceivedRmaCheck(
					Settings.UnreceivedRmaNotification_SecondNotification_DaysRequired,
					Settings.UnreceivedRmaNotification_SecondNotification_DaysNotToExceed,
					Settings.UnreceivedRmaNotification_DaysBeforeSendingAnotherNotice,
					WhichNotification.Second);
				var summaryEmailSubject = string.Format("NOC Service Database Curator Summary for {0:yyyy-MM-dd}, {1}-day", DateTime.Now, Settings.UnreceivedRmaNotification_SecondNotification_DaysRequired);
				SendSummaryEmail(summaryEmailSubject);
			}
			catch (MySqlException exc)
			{
				var error = string.Format("\t\tError checking Unreceived RMAs for Second Notification: {0}", exc.Message);
				ClassLogFile.AddEntry(error);
			}

			if (!bgwEmailSender.IsBusy)
				bgwEmailSender.RunWorkerAsync();
		}

		/// <summary>
		/// Handles the unreceived RMA check.
		/// </summary>
		/// <param name="daysOlderThan">RMA was created more than this number of days ago.</param>
		/// <param name="daysNotOlderThan">RMA was creatred less than this number of days ago.</param>
		/// <param name="excludeNotifiedWithinDays">Do not include RMAs which have notices issued within this number of days.</param>
		/// <param name="notification">Which email headers/footers to use.</param>
		private void PerformUnreceivedRmaCheck(int daysOlderThan, int daysNotOlderThan, int excludeNotifiedWithinDays, WhichNotification notification)
		{
			var msg = string.Format("Getting unreceived RMAs between {0} and {1} days, without notices for {2} days. ({3} notification).", daysOlderThan, daysNotOlderThan, excludeNotifiedWithinDays, notification);
			_summaryEmail.AppendLine(msg);
			ClassLogFile.AddEntry(msg);

			// Get list of unreceived RMAs
			
			var unreceivedRmas = ClassCuratorSQL.GetUnreceivedRmas(daysOlderThan, daysNotOlderThan, excludeNotifiedWithinDays, notification == WhichNotification.Second).ToList();


			var isPlural = unreceivedRmas.Count != 1;
			var techQty = unreceivedRmas.Select(r => r.TechID).Distinct().Count();
			var isTechPlural = techQty != 1;
			var batchInfo = string.Format("{0} unreceived RMA{1} for {2} tech{3} found.", unreceivedRmas.Count, isPlural ? "s" : string.Empty, techQty, isTechPlural ? "s" : string.Empty);
			_summaryEmail.AppendLine(batchInfo);
			ClassLogFile.AddEntry(batchInfo);

			// Iterate by tech ID and process
			foreach (var techID in unreceivedRmas.Select(r => r.TechID).Distinct())
			{
				var thisTech = ClassCuratorSQL.GetTechData(techID);
				var associatedRmas = unreceivedRmas.Where(r => r.TechID == thisTech.ID).ToList();
				var text = BuildUnreceivedText(daysOlderThan, notification, unreceivedRmas, thisTech);

				var rmaAssetList = string.Join(", ", associatedRmas.Select(r => string.Format("{0} ({1})", r.RmaID, r.AssetName)));
				var entry = string.Format("\tQueueing email for {0} ({1} RMA(s): {2})", thisTech.Name, associatedRmas.Count, rmaAssetList);
				_summaryEmail.AppendLine(entry);
				ClassLogFile.AddEntry(entry);

				MailMessage message;
				try
				{
					message = GenerateUnreceivedRmaMailMessage(thisTech, text);
				}
				catch
				{
					var error = string.Format("\t\tError: Cannot create email to {0} with address(es): \"{1}\"", thisTech.Name, thisTech.Email);
					_summaryEmail.AppendLine(error);
					ClassLogFile.AddEntry(error);
					continue;
				}
				var client = GenerateMailClient();
				var email = new ClassUnreceivedRmaEmail(message, client, thisTech.Name, associatedRmas.Select(a => a.RmaID).ToList());

				lock (_emailQueue)
				{
					_emailQueue.Enqueue(email);
				}
			}
		}

		private void SendSummaryEmail(string subject)
		{
			if (string.IsNullOrEmpty(Settings.EmailAddressesForSummary))
				return;

			var summaryMessage = new MailMessage();

			// FROM
			var fromAddress = new MailAddress(Settings.EmailAccount, Settings.EmailName);
			summaryMessage.From = fromAddress;

			// TO
			var addressCollection = new MailAddressCollection();
			var adminEmailList = Settings.EmailAddressesForSummary.Trim().TrimEnd(new[] { ',' });
			addressCollection.Add(adminEmailList);
			foreach (var address in addressCollection)
				summaryMessage.To.Add(address);

			// REPLY-TO
			summaryMessage.ReplyToList.Add(new MailAddress(Settings.EmailReplyTo, Settings.EmailName));

			// SUBJECT
			summaryMessage.Subject = subject;

			// BODY
			summaryMessage.IsBodyHtml = false;
			summaryMessage.Body = _summaryEmail.ToString();

			var client = GenerateMailClient();
			client.Send(summaryMessage);
		}

		private MailMessage GenerateUnreceivedRmaMailMessage(ClassCuratorSQL.TechData tech, string body)
		{
			var message = new MailMessage();

			// FROM
			var addressFrom = new MailAddress(Settings.EmailAccount, Settings.EmailName);
			message.From = addressFrom;

			// TO
			var addressCollection = new MailAddressCollection();
			var techEmailList = tech.Email.Trim().TrimEnd(new[] { ',' });
			addressCollection.Add(techEmailList);
			foreach (var address in addressCollection)
				message.To.Add(address);

			// REPLY-TO
			message.ReplyToList.Add(new MailAddress(Settings.EmailReplyTo, Settings.EmailName));

			// SUBJECT
			message.Subject = string.Format("Unreceived RMA Notification: {0}", tech.Name);

			// BODY
			message.IsBodyHtml = false;
			message.Body = body;

			return message;
		}

		private SmtpClient GenerateMailClient()
		{
			int emailPort;
			return new SmtpClient
					   {
						   Host = Settings.EmailServer,
						   Port = Int32.TryParse(Settings.EmailServerPort, out emailPort) ? emailPort : 25,
						   EnableSsl = Settings.EmailServerUseSSL,
						   Credentials = new NetworkCredential(Settings.EmailAccount, Settings.EmailPassword),
					   };
		}

		private static string BuildUnreceivedText(int daysOlderThan, WhichNotification notification, List<ClassCuratorSQL.UnreceivedRmaData> unreceivedRmas, ClassCuratorSQL.TechData tech)
		{
			var sb = new StringBuilder();
			switch (notification)
			{
				case WhichNotification.First:
					sb.Append(Settings.UnreceivedRmaNotification_FirstNotification_Header).AppendLine();
					break;

				case WhichNotification.Second:
					sb.Append(Settings.UnreceivedRmaNotification_SecondNotification_Header).AppendLine();
					break;
			}
			sb.AppendLine();

			var thisTechRmaQty = unreceivedRmas.Count(r => r.TechID == tech.ID);
			var isPlural = thisTechRmaQty != 1;
			sb.AppendFormat("There {0} {1} RMA{2} issued to {3} which {0} unreceived after {4} days:",
							isPlural ? "are" : "is",
							thisTechRmaQty,
							isPlural ? "s" : "",
							tech.Name,
							daysOlderThan);
			sb.AppendLine().AppendLine();

			// Get the list of assemblies for each RMA assigned to this tech
			foreach (var rma in unreceivedRmas.Where(r => r.TechID == tech.ID))
			{
				sb.AppendFormat("RMA # {0}:", rma.RmaID).AppendLine();
				sb.AppendFormat("\tIssued: {0:yyyy-MM-dd}", rma.RmaCreated).AppendLine();
				sb.AppendFormat("\tAsset: {0}", rma.AssetInfo).AppendLine();
				var items = ClassCuratorSQL.GetAssemblyList(rma.RmaID).ToList();
				sb.AppendLine("\tQty\tAssembly");
				sb.AppendLine("\t---\t--------");
				foreach (var item in items)
				{
					sb.AppendFormat("\t{0}\t{1}", item.Qty, item.Assembly).AppendLine();
				}
				sb.AppendLine();
			}

			sb.AppendLine();
			switch (notification)
			{
				case WhichNotification.First:
					sb.Append(Settings.UnreceivedRmaNotification_FirstNotification_Footer);
					break;

				case WhichNotification.Second:
					sb.Append(Settings.UnreceivedRmaNotification_SecondNotification_Footer);
					break;
			}

			return sb.ToString();
		}

		private void mnuInitiateUnreceivedRma1_Click(object sender, EventArgs e)
		{
			RmaCheck1();
		}

		private void mnuInitiateUnreceivedRma2_Click(object sender, EventArgs e)
		{
			RmaCheck2();
		}

		private void bgwEmailSender_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			// Check the queue. If no messages, wait for 3 seconds then exit if still no messages to send.
			if (!_emailQueue.Any())
				Thread.Sleep(3000);

			while (_emailQueue.Any())
			{
				ClassUnreceivedRmaEmail message;
				int queueQty;
				lock (_emailQueue)
				{
					message = _emailQueue.Dequeue();
					queueQty = _emailQueue.Count;
				}
				try
				{
					message.Send();
				}
				catch (Exception exc)
				{
					var error = string.Format("\t\tError: Cannot send email to {0} (\"{1}\"): {2}", message.TechName, message.To, exc.Message);
					_summaryEmail.AppendLine(error);
					ClassLogFile.AddEntry(error);
					continue;
				}

				ClassCuratorSQL.WriteRmaNotifications(message.AssociatedRmas);

				bgwEmailSender.ReportProgress(0, queueQty);

				// Wait before sending another email
				Thread.Sleep(100);
			}
		}

		private void bgwEmailSender_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			var queueQty = (int)e.UserState;
			lblEmailStatus.Text = string.Format("Email Queue: {0}", queueQty);
		}

		private void bgwEmailSender_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			btnCancel.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (bgwEmailSender.IsBusy)
				bgwEmailSender.CancelAsync();
		}

		private void btnStartStop_Click(object sender, EventArgs e)
		{
			if (timerUnreceivedRmaCheck.Enabled)
				StopTimers();
			else
				StartTimers();
		}

		private void lblLog_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(Path.Combine(ClassLogFile.LOG_PATH, ClassLogFile.LOG_FILENAME));
			}
			catch
			{
			}
		}
		#endregion

		#region Public Methods
		#endregion

		#region Protected Methods
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == _WM_QUERYENDSESSION)
				_endSessionPending = true;
			base.WndProc(ref m);
		}
		#endregion
	}
}