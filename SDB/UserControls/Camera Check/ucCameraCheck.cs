using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.Ticket;
using SDB.Forms.Asset;

// ReSharper disable LoopCanBePartlyConvertedToQuery

namespace SDB.UserControls.Camera_Check
{
	public partial class CameraCheckControl : UserControl
	{
		public delegate void EvaluateEvent();
		public delegate void AssetEvent(ClassAsset asset);

		public event EvaluateEvent Evaluated;
		public event AssetEvent LaunchDashboard;

		public ClassCameraCheck.CheckStatus CheckStatus = ClassCameraCheck.CheckStatus.Unassigned;
		public int? SymptomID { get; set; }

		public CameraCheckAsset CheckedAsset => _ccAsset;

		private readonly CameraCheckAsset _ccAsset;
		private int _imageIndex;
		private readonly Point _DEFAULT_CM_LOCATION = new Point(0, 20);
		private readonly IEnumerable<ClassTicket_Symptom> _visibleSymptoms = new List<ClassTicket_Symptom>();
		private bool _isFailLocked;

		public CameraCheckControl(CameraCheckAsset ccAsset, IEnumerable<ClassTicket_Symptom> visibleSymptoms, bool hideButtons = false, bool cycleImages = false)
		{
			InitializeComponent();
			
			if (ccAsset == null)
				return;

			_ccAsset = ccAsset;
			_visibleSymptoms = visibleSymptoms;
			PopulateSymptomContextMenu();
			lblAssetInfo.Text = _ccAsset.Asset.AssetName;
			pnlControl.Visible = !hideButtons;
            CycleImages(cycleImages);

            pbCameraImage.MouseWheel += CameraCheckControl_MouseWheel;

			if(pnlControl.Visible)
				btnServiceReminder.BackColor = string.IsNullOrEmpty(_ccAsset.Asset.ServiceReminder) ? Color.Silver : Color.Yellow;
			else
				lblAssetInfo.ForeColor = string.IsNullOrEmpty(_ccAsset.Asset.ServiceReminder) ? Color.White : Color.Yellow;

			//if (_ccAsset.Asset.CameraCheckInfo.RequestStatus == ClassAsset.ClassCameraCheckInfo.RequestType.RequestActive)
			//{
			//	lblRequested.Text = "Requested by " + _ccAsset.Asset.CameraCheckInfo.CameraCheckRequestUserID;
			//	lblRequested.Visible = true;
			//}
			if (_ccAsset.Asset.OpenTicketData != null)
			{
				lblTicketInfo.Text = string.Join(Environment.NewLine, _ccAsset.Asset.OpenTicketData.Select(ot => string.Format("{0}: {1}", ot.TicketID, ot.Symptoms)));
				lblTicketInfo.Visible = true;
			}
			if (!_ccAsset.ImageList.Any())
			{
				// Automatically set to fail, display message about no images available.
				pbCameraImage.Image = ClassCameraCheck.GenerateNoImagesBitmap();
				SetFail(true, null);
				_isFailLocked = true;
				return;
			}
			_imageIndex = _ccAsset.ImageList.Count - 1;
			ViewImageForCurrentIndex();
		}

        private void CameraCheckControl_MouseWheel(object sender, MouseEventArgs e)
        {
            
            if (e.Delta > 0)
                DecrementImageIndexAndShow();
            else if(e.Delta < 0)
                IncrementImageIndexAndShow();
        }

        private void ViewImageForCurrentIndex()
		{
			pbCameraImage.Image = new Bitmap(_ccAsset.ImageList[_imageIndex].ImageFileInfo.FullName);
			SizeControlToFitImage(pbCameraImage.Image);
			UpdateImageInfoLabel();
		}

		private void UpdateImageInfoLabel()
		{
			var date = string.Format("{0:yyyy-MM-dd HH:mm:ss}", _ccAsset.ImageList[_imageIndex].ImageDate);
			var position = string.Format("Image {0}/{1}", _imageIndex + 1, _ccAsset.ImageList.Count);
			lblImageInfo.Text = string.Format("{0}{1}{2}", date, Environment.NewLine, position);
		}

		/// <summary>
		/// Sizes the control so that the camera image is 1:1
		/// </summary>
		private void SizeControlToFitImage(Image image)
		{
			Width = image.Width + GetAdditionalWidthAfterImage();
			Height = image.Height + GetAdditionalHeightAfterImage();
		}

		private int GetAdditionalWidthAfterImage()
		{
			return pnlStatusBorder.Padding.Left + pnlStatusBorder.Padding.Right;
		}

		private int GetAdditionalHeightAfterImage()
		{
			return pnlStatusBorder.Padding.Top + pnlStatusBorder.Padding.Bottom + pnlInfo.Height + pnlControl.Height;
		}

		private void pbCameraImage_MouseClick(object sender, MouseEventArgs e)
		{
            pbCameraImage.Focus();
            switch (e.Button)
			{
				case MouseButtons.Left:
					if (ModifierKeys == Keys.Shift)
						CycleImages(true);
					else if (ModifierKeys == Keys.Control && LaunchDashboard != null)
						LaunchDashboard(_ccAsset.Asset);
					else
						SetPass();
					break;

				case MouseButtons.Right:
					SetFail(false, pbCameraImage.PointToClient(Cursor.Position));
					break;

				case MouseButtons.Middle:
					ShowServiceReminder();
					break;
			}
		}

		private void btnFail_Click(object sender, EventArgs e)
		{
			SetFail(false, _DEFAULT_CM_LOCATION);
		}

		private void btnPass_Click(object sender, EventArgs e)
		{
			SetPass();
		}

		/// <summary>
		/// Sets camera check status to passed.
		/// </summary>
		/// <param name="isAuto">Indicates this is an automatic action and should not trigger the <see cref="EvaluateEvent"/> event.</param>
		private void SetPass(bool isAuto = false)
		{
			if (_isFailLocked)
				return;

			CheckStatus = ClassCameraCheck.CheckStatus.Passed;
			SymptomID = null;
			SetResultBorderColor();
			CycleImages(false);

			HideAndClearFailReason();

			if (!isAuto)
				timerEvalDelay.Start();
		}

		/// <summary>
		/// Sets camera check status to failed.
		/// </summary>
		/// <param name="isAuto">Indicates this is an automatic action and should not trigger the <see cref="EvaluateEvent"/> event.</param>
		/// <param name="contextMenuLocation">Position to show symptom context menu. Null if not applicable.</param>
		private void SetFail(bool isAuto, Point? contextMenuLocation)
		{
			CheckStatus = ClassCameraCheck.CheckStatus.Failed;
			SetResultBorderColor();
			CycleImages(false);

			if (!isAuto)
				ShowAndSelectFailReason(contextMenuLocation);
		}
		
		private void HideAndClearFailReason()
		{
			cmSymptoms.Hide();
			SymptomID = null;
			lblSymptom.Text = string.Empty;
			lblSymptom.Hide();
		}

		private void ShowAndSelectFailReason(Point? contextMenuLocation)
		{
			cmSymptoms.Show(this, contextMenuLocation ?? _DEFAULT_CM_LOCATION);
			cmSymptoms.Select();
		}

		private void SetResultBorderColor()
		{
			switch (CheckStatus)
			{
				case ClassCameraCheck.CheckStatus.Passed:
					pnlStatusBorder.BackColor = ClassCameraCheck.COLOR_PASS;
					break;

				case ClassCameraCheck.CheckStatus.Failed:
					pnlStatusBorder.BackColor = ClassCameraCheck.COLOR_FAIL;
					break;

				default:
					pnlStatusBorder.BackColor = ClassCameraCheck.COLOR_UNDETERMINED;
					break;
			}
		}

		private void ShowServiceReminder()
		{
			using (var serviceReminderForm = new FormAsset_ServiceReminder(_ccAsset.Asset))
				serviceReminderForm.ShowDialog();
		}

		private void btnPreviousImage_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == Keys.Shift)
			{
				_imageIndex = 0;
				ViewImageForCurrentIndex();
			}
			else
				DecrementImageIndexAndShow();
		}

		private void btnNextImage_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == Keys.Shift)
			{
				_imageIndex = _ccAsset.ImageList.Count - 1;
				ViewImageForCurrentIndex();
			}
			else
				IncrementImageIndexAndShow();
		}

		private void btnCycleImages_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == Keys.Control)
			{
				LaunchDashboard(_ccAsset.Asset);
			}
			else
			{
				CycleImages(!timerImageCycle.Enabled);
			}
		}

		public void CycleImages(bool enable)
		{
			timerImageCycle.Enabled = enable;

            if (enable)
                timerImageCycle.Start();
            else
                timerImageCycle.Stop();

            btnCycleImages.BackColor = enable ? Color.Lime : Color.Silver;
		}

		private void btnServiceReminder_Click(object sender, EventArgs e)
		{
			ShowServiceReminder();
		}

		private void timerImageCycle_Tick(object sender, EventArgs e)
		{
			IncrementImageIndexAndShow();
		}

		private void IncrementImageIndexAndShow()
		{
			if (!_ccAsset.ImageList.Any())
				return;

			_imageIndex++;
			if (_imageIndex > _ccAsset.ImageList.Count - 1)
				_imageIndex = 0;

			ViewImageForCurrentIndex();
		}

		private void DecrementImageIndexAndShow()
		{
			if (!_ccAsset.ImageList.Any())
				return;

			_imageIndex--;
			if (_imageIndex < 0)
				_imageIndex = _ccAsset.ImageList.Count - 1;

			ViewImageForCurrentIndex();
		}

		private void timerEvalDelay_Tick(object sender, EventArgs e)
		{
			timerEvalDelay.Stop();
			Evaluated?.Invoke();
		}

		private void PopulateSymptomContextMenu()
		{
			foreach (var symptom in _visibleSymptoms)
			{
				var menuItem = new ToolStripMenuItem(symptom.Symptom, null, AssignSymptom)
				               {
					               Tag = symptom.ID
				               };
				cmSymptoms.Items.Add(menuItem);
			}
			cmSymptoms.Items.Add(new ToolStripSeparator());
			cmSymptoms.Items.Add(new ToolStripMenuItem("Clear (None)", null, AssignSymptom)
			                     {
				                     Tag = null
			                     });
		}

		private void AssignSymptom(object sender, EventArgs e)
		{
			var menuItem = (ToolStripMenuItem)sender;
			if (menuItem == null || menuItem.Tag == null)
			{
				lblSymptom.Text = string.Empty;
				lblSymptom.Hide();
				SymptomID = null;
			}
			else
			{
				lblSymptom.Text = menuItem.Text;
				lblSymptom.Show();
				SymptomID = (int)menuItem.Tag;
			}
		}

        private void pnlStatusBorder_MouseHover(object sender, EventArgs e)
        {
            if(Form.ActiveForm != null && Form.ActiveForm.GetType() == ParentForm.GetType())
                pbCameraImage.Focus();
        }
    }
}