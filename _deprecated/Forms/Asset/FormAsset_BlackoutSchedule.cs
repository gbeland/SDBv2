using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.UserControls.Asset;

namespace SDB.Forms.Asset
{
	public partial class FormAsset_BlackoutSchedule : Form
	{
		private readonly int _assetID;
		private ClassBlackoutSchedule _blackoutSchedule;

		public FormAsset_BlackoutSchedule()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Creates a blackout schedule editor with the specified asset blackout schedule loaded.
		/// </summary>
		public FormAsset_BlackoutSchedule(int assetID)
		{
			InitializeComponent();

			_assetID = assetID;
			Populate();
		}

		/// <summary>
		/// Clears schedule entry controls, reloads the schedule for the asset, and repopulates controls.
		/// </summary>
		private void Populate()
		{
			for (var i = flpBlackoutScheduleEntries.Controls.Count - 1; i >= 0; --i)
				flpBlackoutScheduleEntries.Controls[i].Dispose();

			_blackoutSchedule = new ClassBlackoutSchedule(_assetID);

			foreach (var entry in _blackoutSchedule.Entries)
				flpBlackoutScheduleEntries.Controls.Add(new ucBlackoutScheduleEntryControl(entry));
		}

		private void btnAddEntry_Click(object sender, EventArgs e)
		{
			if (EntryCount() >= ClassBlackoutSchedule.MAX_ENTRIES)
			{
				var message = $"A maximum of {ClassBlackoutSchedule.MAX_ENTRIES} schedule entries are allowed.";
				MessageBox.Show(message, "Maximum Entries", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			flpBlackoutScheduleEntries.Controls.Add(new ucBlackoutScheduleEntryControl(_assetID));
		}

		private int EntryCount()
		{
			return flpBlackoutScheduleEntries.Controls.Count;
		}

		private void SaveSchedule()
		{
			// Delete any entries flagged for deletion
			foreach (var entry in flpBlackoutScheduleEntries.Controls.OfType<ucBlackoutScheduleEntryControl>().Where(c => c.ScheduleEntry.DeleteFlag))
				entry.ScheduleEntry.Delete();

			// Update any entries that already have IDs
			foreach (var entry in flpBlackoutScheduleEntries.Controls.OfType<ucBlackoutScheduleEntryControl>().Where(c => c.ScheduleEntry.ID >= 1))
				entry.ScheduleEntry.Update();

			// Insert new entries
			foreach (var entry in flpBlackoutScheduleEntries.Controls.OfType<ucBlackoutScheduleEntryControl>().Where(c => c.ScheduleEntry.ID == -1))
				entry.ScheduleEntry.AddNew();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!ValidateSchedule())
				return;

			SaveSchedule();
			DialogResult = DialogResult.OK;
			Close();
		}

		private bool ValidateSchedule()
		{
			if (flpBlackoutScheduleEntries.Controls.OfType<ucBlackoutScheduleEntryControl>().Any(c => c.ScheduleEntry.StopMinute != 0 && c.ScheduleEntry.StopMinute <= c.ScheduleEntry.StartMinute))
			{
				MessageBox.Show("Stop times must be after start times. A stop time of \"00:00\" is allowed to designate midnight the following day.", "Schedule Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (flpBlackoutScheduleEntries.Controls.OfType<ucBlackoutScheduleEntryControl>().Any(c => c.ScheduleEntry.StartMinute == 0 && c.ScheduleEntry.StopMinute == 0))
			{
				MessageBox.Show("Start and stop times cannot both be \"00:00\".", "Schedule Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}