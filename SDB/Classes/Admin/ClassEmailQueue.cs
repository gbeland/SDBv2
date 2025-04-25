using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Timers;
using SDB.Classes.General;

namespace SDB.Classes.Admin
{
	/// <summary>
	/// Handles queuing and sending of email messages.
	/// </summary>
	public static class ClassEmailQueue
	{
		#region Delegates and Events
		public delegate void QueueBusyEvent();

		/// <summary>
		/// Used to update main form when the email queue is busy.
		/// </summary>
		public static event QueueBusyEvent QueueBusy;

		public delegate void ItemSentEvent(ClassQueueObject queueObject);

		/// <summary>
		/// Used to update ticket journal when an email is successfully sent.
		/// </summary>
		public static event ItemSentEvent ItemSent;

		public delegate void AllSentEvent();

		/// <summary>
		/// Used to update main form when all email has been sent.
		/// </summary>
		public static event AllSentEvent AllSent;

		public delegate void ErrorEvent(ClassQueueObject queueObject);

		/// <summary>
		/// Used to update ticket journal when an email fails to send.
		/// </summary>
		public static event ErrorEvent ErrorSending;
		#endregion

		public enum EmailTypeEnum
		{
			OSA,
            PMC,
			Open,
			OpenNow,
			Closed,
			TechOnSite,
			RentalReminder,
			RMA,
			SupervisorNotice,
			ProblemReport,
			ReOpenTicket,
			PasswordReset,
			NewUser,
            EpartsOrder,
            CradlepointReset,
            CradlepointResetNotification
        };

		public static readonly Dictionary<EmailTypeEnum, string> EMAIL_TYPE_TO_STRING_LOOKUP = new Dictionary<EmailTypeEnum, string>
                                                                                               {
                                                                                                   {EmailTypeEnum.OSA, "OSA"},
                                                                                                   {EmailTypeEnum.PMC, "PMC"},
                                                                                                   {EmailTypeEnum.Open, "Open"},
                                                                                                   {EmailTypeEnum.OpenNow, "Open Now"},
                                                                                                   {EmailTypeEnum.Closed, "Closed"},
                                                                                                   {EmailTypeEnum.TechOnSite, "Tech on-site"},
                                                                                                   {EmailTypeEnum.RentalReminder, "Rental reminder"},
                                                                                                   {EmailTypeEnum.RMA, "RMA"},
                                                                                                   {EmailTypeEnum.SupervisorNotice, "Supervisor Notice"},
                                                                                                   {EmailTypeEnum.ProblemReport, "Problem report"},
                                                                                                   {EmailTypeEnum.ReOpenTicket, "Re-open Ticket"},
                                                                                                   {EmailTypeEnum.PasswordReset, "Password Reset"},
                                                                                                   {EmailTypeEnum.NewUser, "New User"},
                                                                                                   {EmailTypeEnum.EpartsOrder, "Eparts Order"},
                                                                                                   {EmailTypeEnum.CradlepointReset, "Cradlepoint Reset"},
                                                                                                   {EmailTypeEnum.CradlepointResetNotification, "Cradlepoint Reset Notification"},
                                                                                               };

		private static readonly Queue<ClassQueueObject> _messageQueue = new Queue<ClassQueueObject>();

		private static readonly Timer _emailTimer = new Timer
		                                            {
			                                            Interval = 60000,
			                                            Enabled = false
		                                            };

		private static readonly BackgroundWorker _bgwEmailWorker = new BackgroundWorker
		                                                           {
			                                                           WorkerSupportsCancellation = true,
			                                                           WorkerReportsProgress = true
		                                                           };

		private const int _MAX_TRIES = 3;

		public class ClassQueueObject
		{
			public EmailTypeEnum EmailType;
			public MailMessage Message;
			public int? AssociatedTicket;
			public int? AssociatedRma;
			public readonly List<LogObject> EventLog;
			public int Tries;
			public int MaxTries;

			public class LogObject
			{
				public DateTime DateStamp;
				public string Event;

				public override string ToString()
				{
					return string.Format("{0:yyyy-MM-dd HH:mm:ss}: {1}", DateStamp, Event);
				}
			}

			public ClassQueueObject()
			{
				Message = null;
				EventLog = new List<LogObject>();
				Tries = 0;
			}
		}

		static ClassEmailQueue()
		{
			_emailTimer.Elapsed += EmailTimer_Elapsed;
			_emailTimer.Enabled = true;
			_bgwEmailWorker.DoWork += bgwEmailWorker_DoWork;
			_bgwEmailWorker.ProgressChanged += bgwEmailWorker_ProgressChanged;
			_bgwEmailWorker.RunWorkerCompleted += bgwEmailWorker_RunWorkerCompleted;
		}

		/// <summary>
		/// The number of items in the queue.
		/// </summary>
		public static int QueueSize => _messageQueue.Count;

		public static bool IsQueueBusy => _bgwEmailWorker.IsBusy || _messageQueue.Count > 0;

		private static void bgwEmailWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (_messageQueue.Count == 0 && AllSent != null)
				AllSent();
		}

		private static void bgwEmailWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			var currentObject = (ClassQueueObject)e.UserState;
			if (ItemSent != null)
				ItemSent(currentObject);
		}

		private static void bgwEmailWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			if (QueueBusy != null)
				QueueBusy();

			var failedItems = new List<ClassQueueObject>();
			while (_messageQueue.Count > 0 && !_bgwEmailWorker.CancellationPending)
			{
				var currentObject = _messageQueue.Dequeue();
				currentObject.Tries++;
				if (currentObject.Tries > _MAX_TRIES)
					continue;
				var messageToSend = currentObject.Message;
				using (var client = new SmtpClient())
				{
					client.Host = GS.Settings.EmailServer;
					int port;
					client.Port = int.TryParse(GS.Settings.EmailServerPort, out port) ? port : 25;
					client.EnableSsl = GS.Settings.EmailUseSSL;
					client.Credentials = new NetworkCredential(GS.Settings.EmailUser, GS.Settings.EmailPassword);
					try
					{
						client.Send(messageToSend);
						_bgwEmailWorker.ReportProgress(0, currentObject);
					}
					catch (Exception exc)
					{
						// Update the object's event log
						currentObject.EventLog.Add(new ClassQueueObject.LogObject
						                           {
							                           DateStamp = DateTime.Now,
							                           Event = string.Format("Error sending to '{0}': {1}{2}", currentObject.Message.To, exc.Message, (exc.InnerException != null ? " (" + exc.InnerException.Message + ")" : string.Empty))
						                           });
						// Add the object to the failed list for requeue
						failedItems.Add(currentObject);
						// Raise the error event
						if (ErrorSending != null)
							ErrorSending(currentObject);
					}
				}
			}
			// Re-queue the messages in the failed list
			foreach (var failure in failedItems)
				_messageQueue.Enqueue(failure);
		}

		/// <summary>
		/// Initiates sending of all messages in the queue.
		/// </summary>
		public static void Flush()
		{
			// Reset the timer
			_emailTimer.Stop();
			_emailTimer.Start();
			// If the queue is empty or the sender is busy, flush is unnecessary
			if (_messageQueue.Count < 1 || _bgwEmailWorker.IsBusy)
				return;

			_bgwEmailWorker.RunWorkerAsync();
		}

		private static void EmailTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Flush();
		}

		/// <summary>
		/// Adds a mail message to the queue.
		/// </summary>
		/// <param name="newEmailType">Type of email being queued, for later reporting use.</param>
		/// <param name="newMessage">MailMessage to send.</param>
		/// <param name="associatedTicket">Ticket ID (if any) to update journal with email send succeed/fail information.</param>
		/// <param name="associatedRma">RMA ID (if any) to update journal with email send succeed/fail information.</param>
		public static void Add(EmailTypeEnum newEmailType, MailMessage newMessage, int? associatedTicket = null, int? associatedRma = null)
		{
			if (newMessage == null)
				return;

			var queueObject = new ClassQueueObject
			                  {
				                  EmailType = newEmailType,
				                  Message = newMessage,
				                  AssociatedTicket = associatedTicket,
				                  AssociatedRma = associatedRma,
				                  MaxTries = _MAX_TRIES
			                  };
			queueObject.EventLog.Add(new ClassQueueObject.LogObject
			                         {
				                         DateStamp = DateTime.Now,
				                         Event = "Queued"
			                         });
			_messageQueue.Enqueue(queueObject);
			Flush();
		}

		/// <summary>
		/// Removes all messages in the queue.
		/// </summary>
		public static void CancelAll()
		{
			_messageQueue.Clear();
			_bgwEmailWorker.CancelAsync();
		}

		/// <summary>
		/// Reports on the status of message queue delivery.
		/// </summary>
		public static string GetStatus()
		{
			var sb = new StringBuilder();
			sb.AppendFormat("Queue Size: {0}", _messageQueue.Count).AppendLine().AppendLine();
			foreach (var queueItem in _messageQueue)
			{
				var objectList = new List<string>();
				if (queueItem.AssociatedTicket.HasValue)
					objectList.Add("Ticket " + queueItem.AssociatedTicket.Value);
				if (queueItem.AssociatedRma.HasValue)
					objectList.Add("RMA " + queueItem.AssociatedRma.Value);
				var associatedObjects = string.Join(", ", objectList);
				sb.AppendFormat("{0} Email to {1} for: {2}", queueItem.EmailType, queueItem.Message.To, associatedObjects).AppendLine();
				foreach (var logEntry in queueItem.EventLog)
					sb.AppendFormat("\t\u2022 {0:yyyy-MM-dd HH:mm:ss} {1}", logEntry.DateStamp, logEntry.Event).AppendLine();
				sb.AppendLine();
			}
			return sb.ToString();
		}
	}
}