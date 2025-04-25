using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.UserControls.RMA
{
	public partial class RmaList : UserControl
	{
		public delegate void CreateEvent();
		public delegate void RMAEvent(int rmaID);
		public event RMAEvent ViewRMA;
		public event CreateEvent CreateRMA;
		private List<ClassRMA> _collection;
		private bool _isCreateButtonShown;
		private bool _isFilterShown;
		private RmaFilter _filter = RmaFilter.All;

		private enum RmaFilter
		{
			All,
			Unreceived,
			Received,
			Completed,
			Finalized
		};

		public bool ShowCreateButton
		{
			get => _isCreateButtonShown;
			set
			{
				_isCreateButtonShown = value;
				btnCreate.Visible = _isCreateButtonShown;
			}
		}

		public bool ShowFilter
		{
			get => _isFilterShown;
			set
			{
				_isFilterShown = value;
				cmbFilter.Visible = _isFilterShown;
			}
		}

		public RmaList()
		{
			InitializeComponent();

			cmbFilter.DataSource = Enum.GetValues(typeof(RmaFilter));

			olvRmas.PrimarySortColumn = olvColRMA_ID;
			olvRmas.PrimarySortOrder = SortOrder.Descending;

			olvRmas.CellToolTip.InitialDelay = 1000;
		}

		public void SetObjects(List<ClassRMA> collection)
		{
			_collection = collection;
			Populate();
		}

		private void Populate()
		{
			if (_collection == null)
				return;

			var filteredList = new List<ClassRMA>();
			switch (_filter)
			{
				case RmaFilter.All:
					filteredList = _collection;
					break;

				case RmaFilter.Unreceived:
					filteredList = _collection.Where(r => !r.IsFullyReceivedOrDiscarded).ToList();
					break;

				case RmaFilter.Received:
					filteredList = _collection.Where(r => r.IsFullyReceivedOrDiscarded).ToList();
					break;

				case RmaFilter.Completed:
					filteredList = _collection.Where(r => r.IsCompleted).ToList();
					break;

				case RmaFilter.Finalized:
					filteredList = _collection.Where(r => r.IsFinalized).ToList();
					break;
			}
			olvRmas.SetObjects(filteredList);
			txtRMAQty.Text = filteredList.Count.ToString(CultureInfo.InvariantCulture);
		}

		public void Clear()
		{
			olvRmas.SetObjects(null);
			txtRMAQty.Clear();
		}

		private void olvRmas_DoubleClick(object sender, EventArgs e)
		{
			if (ViewRMA == null)
				return;

			var selectedRMA = (ClassRMA)olvRmas.SelectedObject;
			if (selectedRMA != null)
				ViewRMA(selectedRMA.ID);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			CreateRMA?.Invoke();
		}

		private void olvRmas_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var rma = (ClassRMA)e.Model;
			e.Item.ForeColor = rma.Status.Foreground;
			e.Item.BackColor = rma.Status.Background;
		}

		/// <summary>
		/// Locks or unlocks controls for editing
		/// </summary>
		public void LockControls(bool isLocked)
		{
			foreach (var button in pnlRMA_Control.Controls.OfType<Button>())
				button.Enabled = !isLocked;
		}

		private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			_filter = (RmaFilter)cmbFilter.SelectedItem;
			Populate();
		}

		private void olvRmas_CellToolTipShowing(object sender, BrightIdeasSoftware.ToolTipShowingEventArgs e)
		{
			var rmaItems = (ClassRMA)(e.Model);
			var rmaAssembly = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(rmaItems.ID).ToList();
			var tip = string.Format("RMA Parts List: {0}{0}", Environment.NewLine);

			foreach (var i in rmaAssembly)
				tip += i.AssemblyTypeDescription + Environment.NewLine;

			e.Text = tip;
		}
	}
}