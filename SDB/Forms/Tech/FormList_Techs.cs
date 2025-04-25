using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.General;
using SDB.Classes.Tech;

namespace SDB.Forms.Tech
{
	public partial class FormList_Techs : Form
	{
		private List<ClassTech> _allTechs;
		private readonly List<ClassTech> _techList;
		private readonly string _searchTerm;
		private readonly bool _assignMode;

		public ClassTech SelectedTech;

		/// <summary>
		/// A list of techs or subcontractors. Shows all techs in database unless a list is provided.
		/// </summary>
		/// <param name="customTechList">Provided list of techs, such as a search result or assigned tech list for an asset.</param>
		/// <param name="searchTerm">Term to highlight in results, used in conjunction with a supplied custom list from a search result.</param>
		/// <param name="assignMode">Indicates if the CustomTechList is a list of assigned techs, and allows selection of that list or the full list. Also prevents main list from showing "Do Not Use" techs.</param>
		public FormList_Techs(List<ClassTech> customTechList = null, string searchTerm = null, bool assignMode = false)
		{
			InitializeComponent();
			if (customTechList != null)
				_techList = customTechList;
			_searchTerm = searchTerm;
			_assignMode = assignMode;

            olvTechs.PrimarySortColumn = olvColTechName;
            olvTechs.PrimarySortOrder = SortOrder.Ascending;

            PopulateTechList();
			olvTechs.EmptyListMsg = "No techs found.";

            

			if (assignMode)
				pnlSubControlLeft.Visible = true;
		}

		private void PopulateTechList()
		{
			if (_assignMode)
				_allTechs = ClassTech.GetAll().Where(t => t.TechStatus != ClassDefinitions.TECH_STATUS_TYPES[3]).ToList();
			else if (_techList == null)
				_allTechs = ClassTech.GetAll().ToList();

			if (_techList != null)
			{
				olvTechs.SetObjects(_techList);
				txtTechQty.Text = _techList.Count.ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				olvTechs.SetObjects(_allTechs);
				txtTechQty.Text = _allTechs.Count.ToString(CultureInfo.InvariantCulture);
			}

			if (string.IsNullOrEmpty(_searchTerm))
				return;
			var filter = TextMatchFilter.Contains(olvTechs, _searchTerm);
			olvTechs.ModelFilter = filter;
			olvTechs.DefaultRenderer = new HighlightTextRenderer(filter);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SelectedTech = olvTechs.SelectedObject as ClassTech;
			DialogResult = SelectedTech == null ? DialogResult.Cancel : DialogResult.OK;
			Close();
		}

		private void olvTechs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (olvTechs.SelectedItem == null)
				return;

			SelectedTech = (ClassTech)olvTechs.SelectedObject;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void olvTechs_FormatCell(object sender, FormatCellEventArgs e)
		{
			if (e.ColumnIndex != olvColStatus.Index)
				return;

			var t = (ClassTech)e.Model;
			e.SubItem.ForeColor = t.TechStatus.Color;
		}

		private void radAssigned_CheckedChanged(object sender, EventArgs e)
		{
			if (!radAssigned.Checked)
				return;

			olvTechs.SetObjects(_techList);
			txtTechQty.Text = _techList.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void radAll_CheckedChanged(object sender, EventArgs e)
		{
			if (!radAll.Checked)
				return;

			olvTechs.SetObjects(_allTechs);
			txtTechQty.Text = _allTechs.Count.ToString(CultureInfo.InvariantCulture);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvExport(olvTechs, ClassUtility.MakeSafeFileName(Text + ".csv"), "Export Tech List");
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvPrint(olvTechs);
		}
	}
}