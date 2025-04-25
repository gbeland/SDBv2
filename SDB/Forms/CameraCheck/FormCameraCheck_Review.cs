using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.UserControls.Camera_Check;

namespace SDB.Forms.CameraCheck
{
	public partial class FormCameraCheck_Review : Form
	{
		#region Delegates and Events
		public delegate ClassTicket OpenTicketEvent(ClassCameraCheck check, CameraCheckReview sender);
		public event OpenTicketEvent OpenNewTicket;
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		private List<ClassCameraCheck> _failedCameraChecks = new List<ClassCameraCheck>();
		private bool _initialLoad;
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		public FormCameraCheck_Review()
		{
			InitializeComponent();
		}
		#endregion

		#region Private Methods
		private void FormCameraCheck_Review_Load(object sender, EventArgs e)
		{
			WindowState = GS.Settings.WindowState_CameraCheckReview;
			Location = GS.Settings.Location_CameraCheckReview;
		}

		private void FormCameraCheck_Review_VisibleChanged(object sender, EventArgs e)
		{
			if (!Visible)
				return;

			RefreshList();
			_initialLoad = true;
			DrawAllTheThings();
			_initialLoad = false;
		}

		private void FormCameraCheck_Review_FormClosing(object sender, FormClosingEventArgs e)
		{
			GS.Settings.WindowState_CameraCheckReview = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_CameraCheckReview = Location;
			Hide();
			e.Cancel = true;
		}
		
		/// <summary>
		/// Gets the list of failed camera checks from the database.
		/// </summary>
		private void RefreshList()
		{
			_failedCameraChecks = ClassCameraCheck.GetFails().OrderBy(c => c.Submitted).ToList();
		}

		/// <summary>
		/// Populates the form using <see cref="CameraCheckReview"/> based on <see cref="_failedCameraChecks"/>.
		/// </summary>
		private void DrawAllTheThings()
		{
			flowLayoutPanel1.Controls.Clear(true);
			foreach (var camReview in _failedCameraChecks.Select(fcc => new CameraCheckReview(fcc)))
			{
				camReview.CameraCheckCovered += CameraCheckCovered;
				camReview.CameraCheckReverted += CameraCheckReverted;
				camReview.OpenNewTicket += CameraCheckOpenTicket;
				flowLayoutPanel1.Controls.Add(camReview);
			}

			SelectFirstControl();
		}

		private void SelectFirstControl()
		{
			flowLayoutPanel1.Select();
			if (flowLayoutPanel1.Controls.Count > 0)
				flowLayoutPanel1.Controls[0].Select();
			else if (!_initialLoad)
				Close();
		}

		private void CameraCheckCovered(CameraCheckReview sender)
		{
			if (sender == null)
				return;

			var child = flowLayoutPanel1.Controls.OfType<CameraCheckReview>().SingleOrDefault(c => c.ID == sender.ID);
			if (child == null)
				return;

			flowLayoutPanel1.Controls.Remove(child);
			child.Dispose();
			SelectFirstControl();
		}

		private void CameraCheckReverted(CameraCheckReview sender)
		{
			if (sender == null)
				return;

			var child = flowLayoutPanel1.Controls.OfType<CameraCheckReview>().SingleOrDefault(c => c.ID == sender.ID);
			if (child == null)
				return;

			flowLayoutPanel1.Controls.Remove(child);
			child.Dispose();
			SelectFirstControl();
		}

		private void CameraCheckOpenTicket(ClassCameraCheck check, CameraCheckReview sender)
		{
			if (sender == null || OpenNewTicket == null)
				return;

			var newTicket = OpenNewTicket(check, sender);
			if (newTicket == null)
				return;

			var child = flowLayoutPanel1.Controls.OfType<CameraCheckReview>().SingleOrDefault(c => c.ID == sender.ID);
			if (child == null)
				return;
			flowLayoutPanel1.Controls.Remove(child);
			child.Dispose();
			SelectFirstControl();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		#region Public Methods
		#endregion
	}
}