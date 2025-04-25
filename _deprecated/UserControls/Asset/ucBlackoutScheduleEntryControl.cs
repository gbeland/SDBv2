using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.Asset;

namespace SDB.UserControls.Asset
{
	public partial class ucBlackoutScheduleEntryControl : UserControl
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		private readonly ClassBlackoutScheduleEntry _entry;
		private bool _ignoreStateChange;
		#endregion

		#region Public Properties
		public ClassBlackoutScheduleEntry ScheduleEntry => _entry;
		#endregion

		#region Constructor
		public ucBlackoutScheduleEntryControl(int assetID)
		{
			InitializeComponent();

			_ignoreStateChange = true;
			cmbDays.DisplayMember = "Key";
			cmbDays.ValueMember = "Value";
			cmbDays.DataSource = new BindingSource(ClassBlackoutScheduleEntry.DAY_SHORTCUT, null);

			_entry = new ClassBlackoutScheduleEntry(assetID);
			_ignoreStateChange = false;

			Populate();
		}

		public ucBlackoutScheduleEntryControl(ClassBlackoutScheduleEntry entry)
		{
			InitializeComponent();

			_ignoreStateChange = true;
			cmbDays.DisplayMember = "Key";
			cmbDays.ValueMember = "Value";
			cmbDays.DataSource = new BindingSource(ClassBlackoutScheduleEntry.DAY_SHORTCUT, null);

			_entry = entry;
			_ignoreStateChange = false;

			Populate();
		}

		#endregion

		#region Private Methods
		private void Populate()
		{
			_ignoreStateChange = true;

			dtpStart.Value = _entry.StartTime;
			dtpStop.Value = _entry.StopTime;
			cmbDays.SelectedValue = _entry.DayMask;

			_ignoreStateChange = false;
		}

		private void dtpStart_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			_entry.StartTime = dtpStart.Value;
		}

		private void dtpStop_ValueChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			_entry.StopTime = dtpStop.Value;
		}

		private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			_entry.DayMask = (int)cmbDays.SelectedValue;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			_entry.DeleteFlag = !_entry.DeleteFlag;
			if (_entry.DeleteFlag)
			{
				BackColor = Color.Gray;
				dtpStart.Enabled = false;
				dtpStop.Enabled = false;
				cmbDays.Enabled = false;
			}
			else
			{
				BackColor = SystemColors.Control;
				dtpStart.Enabled = true;
				dtpStop.Enabled = true;
				cmbDays.Enabled = true;
			}
		}
		#endregion

		#region Public Methods
		#endregion

		#region Protected Methods
		#endregion
	}
}