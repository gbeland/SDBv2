using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.UserControls.Camera_Check;

namespace SDB.Forms.CameraCheck
{
	public partial class FormCameraCheck : Form
	{
		public delegate void AssetEvent(ClassAsset asset);

		public event AssetEvent LaunchDashboard;

		private readonly List<CameraCheckAsset> _cameraCheckAssets = new List<CameraCheckAsset>();
		private readonly List<ClassTicket_Symptom> _visibleSymptoms = new List<ClassTicket_Symptom>();

		private readonly bool _ignoreStateChange;
		private CameraCheckType _checkMode = CameraCheckType.Normal;
		private readonly int _cameraCheckExpireMinutes;
		private readonly int _cameraCheckPaddingMinutes;
		private readonly bool _ticketModeEnabled;
		private int _normalQty, _ticketedQty, _blackoutQty;
		private bool _imageAutoCycle;
		private bool _isRetrieving;

		/// <summary>
		/// How many assets are displayed at once is a batch.
		/// </summary>
		private int _batchQty = 15;

		/// <summary>
		/// Limit batch quantity to this number to avoid lengthy load times or higher numbers of images than users can process before expiration time.
		/// </summary>
		private const int _BATCH_MAX_QTY = 40;

		/// <summary>
		/// The time between checks for the lock to be open
		/// </summary>
		private const int _WAIT_FOR_LOCK_MS = 1000;

		/// <summary>
		/// The max time before ignoring the lock
		/// I am making it 10 seconds becuase becuase the mean time to actually procces from what I have seen after my changes 
		/// has been less then 10 seconds
		/// </summary>
		private const int _WAIT_FOR_LOCK_TOTAL_MS = 10000;

		private enum CameraCheckType
		{
			/// <summary>
			/// Asset does not have a ticket open, nor is in blackout schedule.
			/// </summary>
			Normal,

			/// <summary>
			/// Asset has a ticket open; may or may not be in blackout schedule.
			/// </summary>
			Ticketed,

			/// <summary>
			/// Asset does not have a ticket open, but is in blackout schedule.
			/// </summary>
			Blackout
		}

		public FormCameraCheck(bool enableTicketMode = false)
		{
			InitializeComponent();

			_cameraCheckExpireMinutes = ClassConfig.GetCameraCheckExpireMinutes();
			_cameraCheckPaddingMinutes = ClassConfig.GetCameraCheckPaddingMinutes();
			_ticketModeEnabled = enableTicketMode;

			_ignoreStateChange = true;
			chkAutoSubmitContinue.Checked = GS.Settings.CameraCheck_AutoSubmitContinue;
			chkHideButtons.Checked = GS.Settings.CameraCheck_HideButtons;
			radModeTicketed.Visible = _ticketModeEnabled;

			_ignoreStateChange = false;
		}

		private void FormCameraCheck_Load(object sender, EventArgs e)
		{
			UpdateCheckQtys();
			if (_ticketModeEnabled)
			{
				if (_normalQty == 0 && _ticketedQty == 0)
					radModeBlackout.Checked = true;
				else if (_normalQty == 0)
					radModeTicketed.Checked = true;
			}
			else
			{
				if (_normalQty == 0)
					radModeBlackout.Checked = true;
			}

			timerQtyCheck.Start();
		}

		private void FormCameraCheck_Shown(object sender, EventArgs e)
		{
			// Create a temporary cameracheck control to use its default height and width
			using (var cameraCheckControl = new CameraCheckControl(null, null))
			{
				var maxColumns = tableLayoutPanel1.Width / cameraCheckControl.Width;
				var maxRows = tableLayoutPanel1.Height / cameraCheckControl.Height;

				tableLayoutPanel1.ColumnCount = maxColumns;
				tableLayoutPanel1.RowCount = maxRows;
				_batchQty = maxColumns * maxRows;
				_cameraCheckAssets.Capacity = _batchQty;

				if (_batchQty > _BATCH_MAX_QTY)
					_batchQty = _BATCH_MAX_QTY;
			}
		}

		private void FormCameraCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
			{
				e.Cancel = true;
				return;
			}

			if (_isRetrieving)
			{
				ClassCameraCheck.ReleaseLock();
			}

			timerQtyCheck.Stop();
		}

		private void chkAutoSubmitContinue_CheckedChanged(object sender, EventArgs e)
		{
			if (!_ignoreStateChange)
				GS.Settings.CameraCheck_AutoSubmitContinue = chkAutoSubmitContinue.Checked;
		}

		private void chkHideButtons_CheckedChanged(object sender, EventArgs e)
		{
			if (!_ignoreStateChange)
				GS.Settings.CameraCheck_HideButtons = chkHideButtons.Checked;
		}

		private void btnRetrieve_Click(object sender, EventArgs e)
		{
			Retrieve();
		}

		#region Backgroundworker Functions

		/// <summary>
		/// Begins the process of retrieving camera checks
		/// It will return if it is already retrieving
		/// Resets _cameraCheckAssets
		/// </summary>
		private void Retrieve()
		{
			//Return if it is currently retrieving 
			if (_isRetrieving || IsCurrentModeEmpty())
				return;

			_isRetrieving = true;
			btnClose.Enabled = false;

			//resetting from last clear
			_cameraCheckAssets.Clear();
			_visibleSymptoms.Clear();
			_visibleSymptoms.AddRange(ClassTicket_Symptom.GetAll().Where(s => s.IsVisible));

			//Create Camera Check Assets in Step 1
			CreateCameraCheckAssets();
		}

		/// <summary>
		/// This section is the multithreading of camera checks. 
		/// The _worker thread gets called in 3 steps
		/// each step proccessing a different batch of info and then making changes onced finished
		/// multithreading is being used to try to increase performance but at the bare minimum to allow 
		/// camera checks to be done while using the main form while things load 
		/// 
		/// All changes made in DoWork functions should never change data not created in the thread only read it 
		/// and return it as a Result
		/// 
		/// 
		/// </summary>

		// ############################## STEP 1 ##############################
		//                              Populate Asset List

		/// <summary>
		/// Updates lblLoading.Text and creates first background worker
		/// </summary>
		private void CreateCameraCheckAssets()
		{
			//Update Loading Text
			lblLoading.Text = "Locking Camera Check...";
			lblLoading.Visible = true;

			//Create a worker to obtain a lock
			var workerLocker = new BackgroundWorker();
			workerLocker.WorkerReportsProgress = true;
			workerLocker.WorkerSupportsCancellation = false;

			//Change Text to tell user who is currently pulling an camera check. 
			//workerLocker.ProgressChanged += (sender, e) => { lblLoading.Text = ClassUser.GetByID(ClassCameraCheck.GetLockedBy()).FirstL + " Is Pulling Camera Checks.\n Please Wait..."; };
			//Obtain the lock in the SQL so no users overlap
			//workerLocker.DoWork += (sender, e) =>
			//						{
			//							var counter = 0;
			//							while (!ClassCameraCheck.ObtainLock())
			//							{
			//								(sender as BackgroundWorker)?.ReportProgress(1);
			//								counter += _WAIT_FOR_LOCK_MS;
			//								System.Threading.Thread.Sleep(_WAIT_FOR_LOCK_MS);
			//								if (counter > _WAIT_FOR_LOCK_TOTAL_MS)
			//									ClassCameraCheck.ForceClearLock();
			//							}
			//						};
            //Runs after user obtains lock
            //workerLocker.RunWorkerCompleted += (sender, e) =>
            //                                    {
            //                                        lblLoading.Text = "Populating Assets...";

            //                                        //creating and running the worker to filter the eligible assets
            //                                        //once it is finished it will call worker_PopulateCameraCheckAssetsCompleted
            //                                        var worker = new BackgroundWorker();
            //                                        worker.WorkerReportsProgress = false;
            //                                        worker.WorkerSupportsCancellation = true;
            //                                    };


            //Change Text to tell user who is currently pulling an camera check. 
            workerLocker.ProgressChanged += (object sender, ProgressChangedEventArgs e) => 
                {
                    lblLoading.Text = ClassUser.GetByID(ClassCameraCheck.GetLockedBy()).FirstL + " Is Pulling Camera Checks.\n Please Wait...";
                };
            //Obtain the lock in the SQL so no users overlap
            workerLocker.DoWork += (object sender, DoWorkEventArgs e) => 
                {
                    var counter = 0;
                    while (!ClassCameraCheck.ObtainLock())
                    {
                        (sender as BackgroundWorker).ReportProgress(1);
                        counter += _WAIT_FOR_LOCK_MS;
                        System.Threading.Thread.Sleep(_WAIT_FOR_LOCK_MS);
                        if (counter > _WAIT_FOR_LOCK_TOTAL_MS)
                            ClassCameraCheck.ForceClearLock();
                    }
                };
            //Runs after user obtains lock
            workerLocker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) => 
                {
                    // Executed on GUI thread.
                    if (e.Error != null)
                    {
                        // Background thread errored - report it in a messagebox.
                        ClassLogFile.AppendToLog(e.Error.ToString());
                        MessageBox.Show(e.Error.ToString(), "Error", MessageBoxButtons.OK);
                        ShowLoading(false);
                        _isRetrieving = false;
                        btnClose.Enabled = true;
                        return;
                    }
                    if (e.Cancelled == true)
                    {
                        btnClose.Enabled = true;
                        ShowLoading(false);
                        _isRetrieving = false;

                        return;
                    }

                    lblLoading.Text = "Populating Assets...";
                    
                    //creating and running the worker to filter the eligible assets
                    //once it is finished it will call worker_PopulateCameraCheckAssetsCompleted
                    BackgroundWorker _worker = new BackgroundWorker();
                    _worker.WorkerReportsProgress = false;
                    _worker.WorkerSupportsCancellation = true;

					_worker.DoWork += worker_PopulateCameraCheckAssets;
					_worker.RunWorkerCompleted += worker_PopulateCameraCheckAssetsCompleted;
					_worker.RunWorkerAsync();
				};
			workerLocker.RunWorkerAsync();
		}

		/// <summary>
		/// Background worker to grab eligible assets 
		/// </summary>
		private void worker_PopulateCameraCheckAssets(object sender, DoWorkEventArgs e)
		{
			e.Result = FilterListByCheckType();
		}

		/// <summary>
		/// Filters the list of assets to those matching the <see cref="CameraCheckType"/>.
		/// </summary>
		private IEnumerable<int> FilterListByCheckType()
		{
			//get the list of eligable assets
			var eligibleAssetIds = ClassAsset.GetIdsForCameraCheck(_cameraCheckPaddingMinutes);

			// Create list to return
			IEnumerable<int> assetList;

			//Adding assets to AssetList depending on mode
			if (_ticketModeEnabled)
			{
				switch (_checkMode)
				{
					case CameraCheckType.Blackout:
						assetList = eligibleAssetIds.Where(assetID => (ClassAsset.GetOpenTicketQty(assetID) == 0) && (ClassBlackoutSchedule.IsBlackedOut(assetID)));
						return assetList;


					case CameraCheckType.Ticketed:
						assetList = eligibleAssetIds.Where(assetID => ClassAsset.GetOpenTicketQty(assetID) > 0);
						return assetList;

					default:
						// Normal mode
						assetList = eligibleAssetIds.Where(assetID => !ClassBlackoutSchedule.IsBlackedOut(assetID));
						return assetList;
				}
			}
			else
			{
				switch (_checkMode)
				{
					case CameraCheckType.Blackout:
						assetList = eligibleAssetIds.Where(assetID => ClassBlackoutSchedule.IsBlackedOut(assetID));
						return assetList;

					default:
						// Normal and ticketed
						assetList = eligibleAssetIds.Where(assetID => !ClassBlackoutSchedule.IsBlackedOut(assetID));
						return assetList;
				}
			}

		}

		private void worker_PopulateCameraCheckAssetsCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// Executed on GUI thread.
			if (e.Error != null)
			{
				// Background thread errored - report it in a messagebox.
				ClassLogFile.AppendToLog(e.Error.ToString());
				MessageBox.Show(e.Error.ToString(), "Error", MessageBoxButtons.OK);
				ShowLoading(false);
				_isRetrieving = false;
				btnClose.Enabled = true;
				return;
			}

			if (e.Cancelled)
			{
				btnClose.Enabled = true;
				ShowLoading(false);
				_isRetrieving = false;

				return;
			}

			lblMessage.Visible = false;
			PutButtonsInCheckMode(true);


			var workerPopulate = new BackgroundWorker();
			workerPopulate.WorkerReportsProgress = true;
			workerPopulate.WorkerSupportsCancellation = false;
			workerPopulate.ProgressChanged += worker_ReportProgress;

			workerPopulate.DoWork += (s, args) => { PopulateCameraCheckAssets((IEnumerable<int>)e.Result); };
			workerPopulate.RunWorkerCompleted += (s, args) =>
												  {
													  if (!_cameraCheckAssets.Any())
													  {
														  lblMessage.Visible = true;
														  ShowLoading(false);
														  _isRetrieving = false;
														  btnClose.Enabled = true;
														  return;
													  }


													  lblLoading.Text = "Loading Images...";
													  prgLoading.Maximum = _cameraCheckAssets.Count;
													  prgLoading.Value = 0;
													  ShowLoading();

													  var worker = new BackgroundWorker();
													  worker.WorkerReportsProgress = true;
													  worker.WorkerSupportsCancellation = true;
													  worker.ProgressChanged += worker_ReportProgress;
													  worker.DoWork += worker_PopulateImageLists;
													  worker.RunWorkerCompleted += worker_PopulateImageListsCompleted;

													  worker.RunWorkerAsync();
												  };

			workerPopulate.RunWorkerAsync();
		}

		/// <summary>
		/// Gets a batch of assets with the oldest submitted camera checks and marks them as requested, adding them to <see cref="_cameraCheckAssets"/>.
		/// </summary>
		private void PopulateCameraCheckAssets(IEnumerable<int> eligibleAssets)
		{
			// get the current time 
			var requestTime = ClassDatabase.GetCurrentTime();

			// Modify the list to include only assets without active requests or that have expired requests
			// then sort by last submit
			// the take _batchQty

			var batch = eligibleAssets.Where(a => (ClassAsset.GetByID(a).CameraCheckInfo.CameraCheckLastRequest.HasValue ?
												 ClassAsset.GetByID(a).CameraCheckInfo.CameraCheckLastRequest.Value.AddMinutes(_cameraCheckExpireMinutes) < requestTime : true))
				.Take(_batchQty).ToList();

			ClassAsset.RequestCameraCheckBatch(batch);
			ClassCameraCheck.ReleaseLock();

			//Add the assets to the Cameracheck asset list to be populated with images later
			foreach (var assetID in batch)
			{
				_cameraCheckAssets.Add(new CameraCheckAsset(assetID, requestTime));
			}

			//Populate the Ticket info 
			if (_ticketModeEnabled && _checkMode == CameraCheckType.Ticketed)
				PopulateOpenTicketInformation();
		}

		/// <summary>
		/// Adding ticket Info to assets in _cameraCheckAssets
		/// </summary>
		private void PopulateOpenTicketInformation()
		{
			foreach (var ccAsset in _cameraCheckAssets)
				ccAsset.Asset.PopulateOpenTicketData();
		}

		// ############################## STEP 2 ##############################
		//                              Get Images for the assets

		private void worker_PopulateImageLists(object sender, DoWorkEventArgs e)
		{
			PopulateImageLists(sender as BackgroundWorker);
		}

		private void PopulateImageLists(BackgroundWorker worker)
		{
			//List<CameraCheckImageReference> ImageList = new List<CameraCheckImageReference>();
			foreach (var cameraCheckAsset in _cameraCheckAssets)
			{
				cameraCheckAsset.ImageList = ClassCameraCheck.GetLastImages(cameraCheckAsset).ToList();
				worker.ReportProgress(1);
			}
		}

		private void worker_PopulateImageListsCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// Executed on GUI thread.
			if (e.Error != null)
			{
				// Background thread errored - report it in a messagebox.
				ClassLogFile.AppendToLog(e.Error.ToString());
				MessageBox.Show(e.Error.ToString(), "Error", MessageBoxButtons.OK);
				ShowLoading(false);
				_isRetrieving = false;
				btnClose.Enabled = true;
				return;
			}

			if (e.Cancelled)
			{
				btnClose.Enabled = true;
				ShowLoading(false);
				_isRetrieving = false;

				return;
			}

			var worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.WorkerSupportsCancellation = true;
			worker.ProgressChanged += worker_ReportProgress;
			worker.DoWork += worker_GetBatch;
			worker.RunWorkerCompleted += worker_GetBatchCompleted;
			worker.RunWorkerAsync();
		}

		// ############################## STEP 3 ##############################
		//                              Get CameraCheckControl Batch and add to layout

		private void worker_GetBatchCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// Executed on GUI thread.
			if (e.Error != null)
			{
				// Background thread errored - report it in a messagebox.
				ClassLogFile.AppendToLog(e.Error.ToString());
				MessageBox.Show(e.Error.ToString(), "Error", MessageBoxButtons.OK);
				ShowLoading(false);
				_isRetrieving = false;
				btnClose.Enabled = true;
				return;
			}

			if (e.Cancelled)
			{
				btnClose.Enabled = true;
				ShowLoading(false);
				_isRetrieving = false;
				return;
			}

			ShowLoading(false);
			AddBatchToLayout((List<CameraCheckControl>)e.Result);
			btnClose.Enabled = true;
			_isRetrieving = false;
		}

		private void worker_GetBatch(object sender, DoWorkEventArgs e)
		{
			e.Result = CreateBatch(sender as BackgroundWorker);
		}

		private List<CameraCheckControl> CreateBatch(BackgroundWorker worker)
		{
			//tableLayoutPanel1.Controls.Clear(true);
			var batch = new List<CameraCheckControl>();

			foreach (var checkControl in _cameraCheckAssets.Select(ccAsset => new CameraCheckControl(ccAsset, _visibleSymptoms, GS.Settings.CameraCheck_HideButtons)))
			{
				batch.Add(checkControl);
				worker.ReportProgress(1);
			}

			return batch;
		}

		private void AddBatchToLayout(List<CameraCheckControl> batch)
		{
			tableLayoutPanel1.Controls.Clear(true);
			foreach (var c in batch)
			{
				c.Evaluated += checkControl_Evaluated;
				c.LaunchDashboard += checkControl_LaunchDashboard;
				tableLayoutPanel1.Controls.Add(c);
				c.CycleImages(_imageAutoCycle);
			}
		}

		// ############################## Reporting Progress ##############################

		private void worker_ReportProgress(object sender, ProgressChangedEventArgs e)
		{
			if (!_isRetrieving)
				(sender as BackgroundWorker)?.CancelAsync();
			prgLoading.PerformStep();
		}

		#endregion

		private void ShowLoading(bool show = true)
		{
			lblLoading.Visible = show;
			prgLoading.Visible = show;
		}

		private void PutButtonsInCheckMode(bool inCheckMode)
		{
			btnRetrieve.Enabled = !inCheckMode;
			flpMode.Enabled = !inCheckMode;
			btnSubmit.Enabled = inCheckMode;
			btnSubmitRetrieveNext.Enabled = inCheckMode;

			if (inCheckMode)
				btnSubmitRetrieveNext.Select();
		}

		private void checkControl_Evaluated()
		{
			if (!GS.Settings.CameraCheck_AutoSubmitContinue)
				return;

			if (tableLayoutPanel1.Controls.OfType<CameraCheckControl>().Any(c => c.CheckStatus == ClassCameraCheck.CheckStatus.Unassigned))
				return;

			if (Submit())
				Retrieve();
		}

		private void checkControl_LaunchDashboard(ClassAsset asset)
		{
			LaunchDashboard?.Invoke(asset);
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			Submit();
		}

		private void btnSubmitRetrieveNext_Click(object sender, EventArgs e)
		{
			if (Submit())
				Retrieve();
		}

		/// <summary>
		/// Submits camera checks. Returns true if no errors, false otherwise.
		/// </summary>
		private bool Submit()
		{
			var ccControls = tableLayoutPanel1.Controls.OfType<CameraCheckControl>().ToList();

			#region Validation
			if (!ccControls.Any())
			{
				MessageBox.Show("No camera checks to submit.", "No Camera Checks", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			// Ensure everything has a result
			if (ccControls.Any(c => c.CheckStatus == ClassCameraCheck.CheckStatus.Unassigned))
			{
				MessageBox.Show("All camera checks must have a pass/fail status.", "Unassigned Camera Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			#endregion

			// Iterate camera check controls and submit results
			var assetsWithSubmitErrors = new List<string>();
			foreach (var cc in ccControls)
			{
				var asset = cc.CheckedAsset;
				var lastImage = cc.CheckedAsset.ImageList.LastOrDefault();
				var lastImageName = lastImage?.ImageFileInfo.Name;
				var lastImageDateTime = lastImage?.ImageDate;

				var submitSuccess = ClassCameraCheck.Submit(asset.Asset.ID, cc.CheckStatus, cc.SymptomID, lastImageName, lastImageDateTime);
				if (submitSuccess)
					ClassAsset.SubmitCameraCheck(asset.Asset.ID);
				else
					assetsWithSubmitErrors.Add(cc.CheckedAsset.Asset.AssetName);
			}

			if (assetsWithSubmitErrors.Any())
			{
				const string PREFACE = "Could not submit camera checks for the following assets:";
				const string APPEND = "Another user may have already submitted the same requests.";
				var message = $"{PREFACE}{Environment.NewLine}{Environment.NewLine}{string.Join(", ", assetsWithSubmitErrors)}{Environment.NewLine}{Environment.NewLine}{APPEND}";
				MessageBox.Show(message, "Submission Errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			_cameraCheckAssets.Clear();
			tableLayoutPanel1.Controls.Clear(true);
			lblStatus.Text = string.Empty;
			PutButtonsInCheckMode(false);
			UpdateCheckQtys();
			return true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{

			if (_cameraCheckAssets.Any())
			{
				if (MessageBox.Show("You have unsubmitted camera checks, are you sure you want to close?", "Unsubmitted Camera Checks", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void radModeNormal_CheckedChanged(object sender, EventArgs e)
		{
			if (radModeNormal.Checked)
				_checkMode = CameraCheckType.Normal;
		}

		private void radModeTicketed_CheckedChanged(object sender, EventArgs e)
		{
			if (radModeTicketed.Checked)
				_checkMode = CameraCheckType.Ticketed;
		}

		private void radModeBlackout_CheckedChanged(object sender, EventArgs e)
		{
			if (radModeBlackout.Checked)
				_checkMode = CameraCheckType.Blackout;
		}

		private void ckbAutoCycle_Click(object sender, EventArgs e)
		{
			_imageAutoCycle = chkAutoCycle.Checked;
			if (!tableLayoutPanel1.Controls.OfType<CameraCheckControl>().Any())
				return;
			foreach (var a in tableLayoutPanel1.Controls.OfType<CameraCheckControl>())
				a.CycleImages(_imageAutoCycle);
		}

		private void timerQtyCheck_Tick(object sender, EventArgs e)
		{
			UpdateCheckQtys();
		}

		private void UpdateCheckQtys()
		{
			var qtys = ClassCameraCheck.GetDueQtys();

			if (_ticketModeEnabled)
			{
				_normalQty = qtys.Normal + qtys.Ticketed;
			}
			else
			{
				_normalQty = qtys.Normal;
				_ticketedQty = qtys.Ticketed;
			}

			_blackoutQty = qtys.Blackout;

			radModeNormal.Text = $"Normal ({_normalQty})";
			radModeTicketed.Text = $"Ticketed ({_ticketedQty})";
			radModeBlackout.Text = $"Blackout ({_blackoutQty})";
		}

		private bool IsCurrentModeEmpty()
		{

			UpdateCheckQtys();
			switch (_checkMode)
			{
				case CameraCheckType.Normal:
					if (_normalQty == 0)
						return true;
					break;
				case CameraCheckType.Blackout:
					if (_blackoutQty == 0)
						return true;
					break;
				case CameraCheckType.Ticketed:
					if (_ticketedQty == 0)
						return true;
					break;
			}

			return false;
		}
	}
}