using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.User;

namespace SDB.Forms.General
{
	/// <summary>
	/// This form shows and manages user notifications as well as subscriptions.
	/// </summary>
	public partial class FormNotifications : Form
	{
		private DateTime _mostRecentNotification;
		private List<ClassNotification> _notifications = new List<ClassNotification>();
		private List<ClassSubscription> _subscriptions = new List<ClassSubscription>();

		#region Delegates and Events
		public delegate void ObjectLinkClickedEvent(int objectID, ClassSubscription.ObjectTypeEnum objectType);
		public event ObjectLinkClickedEvent ViewObject;

		public delegate void RefreshEvent();
		public event RefreshEvent RefreshNotificationsOnMain;
		#endregion

		public FormNotifications()
		{
			InitializeComponent();

			olcNotifications_MarkRead.AspectToStringConverter = value => string.Empty;
			olcNotifications_MarkRead.ImageGetter = imageIndex => "markread";

			olcNotifications_Unsubscribe.AspectToStringConverter = value => string.Empty;
			olcNotifications_Unsubscribe.ImageGetter = x => ((ClassNotification)x).SubscriptionID.HasValue ? "unsubscribe" : "none";

			olcSubscriptions_Unsubscribe.AspectToStringConverter = value => string.Empty;
			olcSubscriptions_Unsubscribe.ImageGetter = imageIndex => "unsubscribe";
		}

		private void FormNotifications_Load(object sender, EventArgs e)
		{
			WindowState = GS.Settings.WindowState_Notifications;
			Location = GS.Settings.Location_Notifications;
		}

		private void FormNotifications_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;

			tabControl.SelectedTab = tabNotifications;

			RefreshNotificationsList();
			RefreshSubscriptionsList();
			StartTimers(true);
		}

		private void FormNotifications_VisibleChanged(object sender, EventArgs e)
		{
			if (Visible)
			{
				tabControl.SelectedTab = tabNotifications;
				RefreshNotificationsList();
				RefreshSubscriptionsList();
				StartTimers(true);
			}
			else
				StartTimers(false);
		}

		private void FormNotifications_FormClosing(object sender, FormClosingEventArgs e)
		{
			_mostRecentNotification = DateTime.MinValue;

			StartTimers(false);
			GS.Settings.WindowState_Notifications = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_Notifications = Location;
			Hide();
			e.Cancel = true;
		}

		private void timerRefreshNotifications_Tick(object sender, EventArgs e)
		{
			if (!ClassNotification.AnyNotificationsSince(_mostRecentNotification, GS.Settings.LoggedOnUser.ID))
				return;
		
			RefreshNotificationsList();
		}

		private void timerRefreshSubscriptions_Tick(object sender, EventArgs e)
		{
			RefreshSubscriptionsList();
		}

		private void RefreshNotificationsList()
		{
			_notifications = ClassNotification.GetForUser(GS.Settings.LoggedOnUser.ID).ToList();
			olvNotifications.SetObjects(_notifications);
			lblNotificationQty.Text = $"{_notifications.Count} Notification{_notifications.Count.SIfPlural()}";
		}

		private void RefreshSubscriptionsList()
		{
			_subscriptions = ClassSubscription.GetByUser(GS.Settings.LoggedOnUser.ID).ToList();
			olvSubscriptions.SetObjects(_subscriptions);
			lblSubscriptions.Text = $"{_subscriptions.Count} Subscription{_subscriptions.Count.SIfPlural()}";
		}

		private void StartTimers(bool start)
		{
			if (start)
			{
				timerRefreshNotifications.Start();
				timerRefreshSubscriptions.Start();
			}
			else
			{
				timerRefreshNotifications.Stop();
				timerRefreshSubscriptions.Stop();
			}
		}

		private void btnSubscriptions_Refresh_Click(object sender, EventArgs e)
		{
			RefreshSubscriptionsList();
		}

		private void btnNotifications_Refresh_Click(object sender, EventArgs e)
		{
			RefreshNotificationsList();
		}

		private void btnMarkAllRead_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to mark all notifications as read?", "Confirm Clear Notifications", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			ClassNotification.DeleteCurrentByUser();

			RefreshNotificationsList();
			RefreshNotificationsOnMain?.Invoke();

			Close();
		}

		private void btnUnsubscribeAll_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to unsubscribe from all items?", "Confirm Unsubscribe All", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			ClassSubscription.UnsubscribeAll(GS.Settings.LoggedOnUser.ID);

			RefreshSubscriptionsList();
		}

		private void olvNotifications_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
		{
			var selectedNotification = (ClassNotification)e.Model;
			if (e.Column == olcNotifications_Link)
			{
				ViewObject?.Invoke(selectedNotification.ObjectID, selectedNotification.ObjectType);
			}
			e.Handled = true;
		}

		private void olvSubscriptions_HyperlinkClicked(object sender, BrightIdeasSoftware.HyperlinkClickedEventArgs e)
		{
			var selectedSubscription = (ClassSubscription)e.Model;
			if (e.Column == olcSubscriptions_ObjLink)
				ViewObject?.Invoke(selectedSubscription.ObjectID, selectedSubscription.ObjectType);
			e.Handled = true;
		}

		private void olvNotifications_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
		{
			if (e.Column == olcNotifications_MarkRead)
			{
				e.Cancel = true;

				var selectedNotification = (ClassNotification)e.RowObject;

				if (selectedNotification == null)
					return;

				Cursor = Cursors.WaitCursor;
				try
				{
					ClassNotification.Delete(selectedNotification);

					_notifications.Remove(selectedNotification);
					olvNotifications.SetObjects(_notifications);

					RefreshNotificationsList();

					RefreshNotificationsOnMain?.Invoke();
				}
				finally
				{
					Cursor = Cursors.Default;
				}
			}

			if (e.Column == olcNotifications_Unsubscribe)
			{
				e.Cancel = true;

				var selectedNotification = (ClassNotification)e.RowObject;

				if (selectedNotification?.SubscriptionID == null)
					return;

				Unsubscribe(selectedNotification.ObjectType, selectedNotification.ObjectID, selectedNotification.LinkText);
			}
		}

		private void olvSubscriptions_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
		{
			if (e.Column == olcSubscriptions_Unsubscribe)
			{
				e.Cancel = true;

				var selectedSubscription = (ClassSubscription)e.RowObject;
				if (selectedSubscription == null)
					return;

				Unsubscribe(selectedSubscription.ObjectType, selectedSubscription.ObjectID, selectedSubscription.LinkText);
			}
		}

		/// <summary>
		/// Confirms and handles the unsubscription process including an option to remove existing notifications.
		/// </summary>
		/// <param name="objectType">Object Type</param>
		/// <param name="objectID">Object ID</param>
		/// <param name="linkText">A human-readable string for the object.</param>
		private void Unsubscribe(ClassSubscription.ObjectTypeEnum objectType, int objectID, string linkText)
		{
			var confirmMessage = string.Format("Are you sure you want to unsubscribe from{0}{0}{1}?{0}{0}You will not receive further notifications unless you re-subscribe. (Unless you subscribe to a parent item.)", Environment.NewLine, linkText);
			if (MessageBox.Show(confirmMessage, "Confirm Unsubscribe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			Cursor = Cursors.WaitCursor;
			try
			{
				ClassSubscription.Unsubscribe(objectType, objectID);
			}
			finally
			{
				Cursor = Cursors.Default;
			}

			if (ClassNotification.GetNotificationCount_All(objectType, objectID) > 0)
			{
				if (MessageBox.Show("You have notifications for this item, do you want to clear all of them?", "Clear Notifications?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					Cursor = Cursors.WaitCursor;
					try
					{
						ClassNotification.DeleteByObjectForUser(objectType, objectID);
					}
					finally
					{
						Cursor = Cursors.Default;
					}
				}
			}

			RefreshNotificationsList();
			RefreshSubscriptionsList();
			RefreshNotificationsOnMain?.Invoke();
		}
	}
}