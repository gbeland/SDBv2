using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.General;

namespace SDB.Forms.General
{
	public partial class FormWorkbenchImport : Form
	{
		public ClassWorkbenchItem SelectedWorkbenchItem;
		private List<ClassWorkbenchItem> _workbenchItems = new List<ClassWorkbenchItem>();
		public FormWorkbenchImport()
		{
			InitializeComponent();

			olvWorkbenchItems.PrimarySortColumn = olvColCategory;
			olvWorkbenchItems.PrimarySortOrder = SortOrder.Ascending;
			olvWorkbenchItems.SecondarySortColumn = olvColDescription;
			olvWorkbenchItems.SecondarySortOrder = SortOrder.Ascending;
			
			olvColPartComp.AspectToStringConverter = delegate(object x)
			{
				var pc = (string)x;
				return pc.Substring(0, 1);
			};
		}

		private void FormWorkbenchImport_Load(object sender, EventArgs e)
		{
			_workbenchItems = ClassWorkbenchItem.GetWorkbenchItems().ToList();
			Populate();
			txtFilter.Select();
		}

		private void Populate()
		{
			olvWorkbenchItems.SetObjects(_workbenchItems);
			txtQty.Text = _workbenchItems.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (olvWorkbenchItems.SelectedItem == null)
				return;
			SelectedWorkbenchItem = (ClassWorkbenchItem)olvWorkbenchItems.SelectedObject;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void olvWorkbenchItems_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvWorkbenchItems.SelectedItem == null) return;
			SelectedWorkbenchItem = (ClassWorkbenchItem)olvWorkbenchItems.SelectedObject;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtFilter.Text))
			{
				olvWorkbenchItems.ModelFilter = null;
				olvWorkbenchItems.DefaultRenderer = null;
			}
			else
			{
				var filter = TextMatchFilter.Contains(olvWorkbenchItems, txtFilter.Text);
				olvWorkbenchItems.ModelFilter = filter;
				olvWorkbenchItems.DefaultRenderer = new HighlightTextRenderer(filter);
			}
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			timerDelay.Stop();
			timerDelay.Start();
		}

		private void timerDelay_Tick(object sender, EventArgs e)
		{
			timerDelay.Stop();
			if (string.IsNullOrEmpty(txtFilter.Text))
			{
				olvWorkbenchItems.ModelFilter = null;
				olvWorkbenchItems.DefaultRenderer = null;
			}
			else
			{
				var filter = TextMatchFilter.Contains(olvWorkbenchItems, txtFilter.Text);
				olvWorkbenchItems.ModelFilter = filter;
				olvWorkbenchItems.DefaultRenderer = new HighlightTextRenderer(filter);
			}
		}
	}
}