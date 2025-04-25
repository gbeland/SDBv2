using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.Forms.Asset;
using SDB.Forms.General;

namespace SDB.UserControls.Asset
{
	public partial class ucAssetSystemBackup : UserControl
	{
		private ClassAsset _asset;
		private List<ClassSystemBackup> _backups;

		public ucAssetSystemBackup()
		{
			InitializeComponent();

			olvSystemBackups.PrimarySortColumn = olcDate;
			olvSystemBackups.PrimarySortOrder = SortOrder.Ascending;
		}

		public void SetAsset(ClassAsset asset)
		{
			_asset = asset;
			Populate();
		}

		private void Populate()
		{
			_backups = ClassSystemBackup.GetByAsset(_asset.ID).ToList();
			olvSystemBackups.SetObjects(_backups);
		}

		public void Clear()
		{
			_asset = null;
			olvSystemBackups.SetObjects(null);
		}

		private void btnCreateBackup_Click(object sender, EventArgs e)
		{
			if (_asset.IsRetired)
			{
				MessageBox.Show("This asset has been retired.", "Retired Asset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			
			using (var frmInput = new FormUserInput("Describe Backup", "Enter a description for this backup:"))
			{
				if (frmInput.ShowDialog(this) != DialogResult.OK)
					return;

				Cursor = Cursors.WaitCursor;
				try
				{
					var backup = ClassSystemBackup.CreateFromSystem(_asset, frmInput.UserText);
					ClassSystemBackup.AddNew(ref backup);
					ClassJournal.AddJournalEntry(_asset, "Created system backup.", null, true);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					var errorMessage = string.Format("Error creating backup: {0}{0}{1}", Environment.NewLine, exc.Message);
					if (exc.Data[0] != null)
						errorMessage += string.Format("{0}{0}Check network information. Cannot connect to:{0}\"{1}\"", Environment.NewLine, exc.Data[0]);
					MessageBox.Show(errorMessage, "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				finally
				{
					Cursor = Cursors.Default;
				}
			}
			Populate();
		}

		private void btnDeleteBackup_Click(object sender, EventArgs e)
		{
			var selectedBackup = (ClassSystemBackup)olvSystemBackups.SelectedObject;
			if (selectedBackup == null)
				return;

			var confirmMessage = string.Format("Are you sure you want to delete System Backup for {0} on {1:yyyy-MM-dd HH:mm:ss}?", _asset.AssetName, selectedBackup.BackupDate);
			if (MessageBox.Show(confirmMessage, "Confirm Remove System Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			selectedBackup.Delete();
			ClassJournal.AddJournalEntry(_asset, "Deleted system backup.", null, true);
			Populate();

		}

		private void btnSaveAs_Click(object sender, EventArgs e)
		{
			var selectedBackup = (ClassSystemBackup)olvSystemBackups.SelectedObject;
			if (selectedBackup == null)
				return;

			using (var sfd = new SaveFileDialog())
			{
				sfd.FileName = string.Format("{0} PVS {1} Backup {2:yyyyMMdd_HHmmss}", ClassUtility.MakeSafeFileName(_asset.AssetName), selectedBackup.SystemVersion, selectedBackup.BackupDate);
				sfd.Filter = "ZIP Files (*.zip)|*.zip";
				sfd.DefaultExt = ".zip";
				sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
				if (sfd.ShowDialog(this) != DialogResult.OK)
					return;
				try
				{
					File.WriteAllBytes(sfd.FileName, selectedBackup.BackupData);
				}
				catch (Exception exc)
				{
					MessageBox.Show("Error saving file: " + exc.Message);
				}
			}
		}

		private void btnRestoreBackup_Click(object sender, EventArgs e)
		{
			if (_asset.IsRetired)
			{
				MessageBox.Show("This asset has been retired.", "Retired Asset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			
			var selectedBackup = (ClassSystemBackup)olvSystemBackups.SelectedObject;
			if (selectedBackup == null)
				return;

			var confirmThisAsset = string.Format("Do you want to restore the backup dated {1:yyyy-MM-dd HH:mm:ss} to {2}?{0}{0}", Environment.NewLine, selectedBackup.BackupDate, _asset.AssetName);
			confirmThisAsset += string.Format("Select \"No\" to select a different asset to restore to.{0}{0}This will issue a restart command to Prismview System.", Environment.NewLine);
			var thisAssetTitle = string.Format("Restore Backup to {0}", _asset.AssetName);
			var result = MessageBox.Show(confirmThisAsset, thisAssetTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

			switch (result)
			{
				case DialogResult.Yes:
					RestoreBackup(selectedBackup, _asset.ID);
					break;

				case DialogResult.No:
					ClassAsset selectedAsset;
					var confirmed = false;
					do
					{
						selectedAsset = SelectAsset();
						if (selectedAsset == null)
							return;
						var confirmAsset = string.Format("Do you want to restore the backup dated {0:yyyy-MM-dd HH:mm:ss} to {1}? This will issue a restart command to Prismview System.", selectedBackup.BackupDate, selectedAsset.AssetName);
						var assetTitle = string.Format("Restore Backup to {0}", selectedAsset.AssetName);
						var altResult = MessageBox.Show(confirmAsset, assetTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
						switch (altResult)
						{
							case DialogResult.Yes:
								confirmed = true;
								break;

							case DialogResult.No:
								break;

							case DialogResult.Cancel:
								return;
						}
					} while (!confirmed);

					RestoreBackup(selectedBackup, selectedAsset.ID);
					ClassJournal.AddJournalEntry(_asset, "Restored system backup.", null, true);
					break;

				case DialogResult.Cancel:
					return;
			}
		}

		private void RestoreBackup(ClassSystemBackup backup, int? assetID = null)
		{
			var result = string.Empty;
			try
			{
				result = assetID.HasValue ? backup.Restore(assetID.Value) : backup.Restore();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				var errorMessage = string.Format("Error restoring backup: Result: {1}{0}{0}Exception: {2}", Environment.NewLine, result, exc.Message);
				MessageBox.Show(errorMessage, "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Restore, ClassEventLog.ObjectTypeEnum.SystemBackup, backup.ID, string.Format(""));
			var resultMessage = string.Format("Restore finished with result: {0}", result);
			MessageBox.Show(resultMessage, "Restore Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private ClassAsset SelectAsset()
		{
			using (var frmAssetList = new FormList_Assets())
			{
				return frmAssetList.ShowDialog(this) != DialogResult.OK ? null : frmAssetList.SelectedAsset;
			}
		}
	}
}