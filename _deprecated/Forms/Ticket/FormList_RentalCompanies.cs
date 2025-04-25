using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Forms.Ticket
{
	public partial class FormList_RentalCompanies : Form
	{
		private List<ClassRentalCompany> _allRentalCompanies;
		private readonly List<ClassRentalCompany> _customRentalList;
		private readonly string _searchTerm;
		private readonly List<OLVColumn> _fixedWidthFontColumns;

		/// <summary>
		/// A list of rental companies.
		/// </summary>
		/// <param name="customRentalList">Provided list of rental companies, such as a search result.</param>
		/// <param name="searchTerm">Term to highlight in results, used in conjunciton with a supplied custom list from a search result.</param>
		public FormList_RentalCompanies(List<ClassRentalCompany> customRentalList = null, string searchTerm = null)
		{
			InitializeComponent();
			_customRentalList = customRentalList;
			_searchTerm = searchTerm;
			_fixedWidthFontColumns = new List<OLVColumn> {olcFormatReservation, olcFormatEquipment, olcFormatPickup};

			Populate();
			olvRentalCompanies.EmptyListMsg = "No Rental Companies";
		}

		private void Populate()
		{
			if (_customRentalList == null)
			{
				_allRentalCompanies = ClassRentalCompany.GetAll().ToList();
				olvRentalCompanies.SetObjects(_allRentalCompanies);
				txtRentalCompanyQty.Text = _allRentalCompanies.Count.ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				olvRentalCompanies.SetObjects(_customRentalList);
				txtRentalCompanyQty.Text = _customRentalList.Count.ToString(CultureInfo.InvariantCulture);
			}

			if (string.IsNullOrEmpty(_searchTerm))
				return;
			var filter = TextMatchFilter.Contains(olvRentalCompanies, _searchTerm);
			olvRentalCompanies.ModelFilter = filter;
			olvRentalCompanies.DefaultRenderer = new HighlightTextRenderer(filter);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvExport(olvRentalCompanies, ClassUtility.MakeSafeFileName(Text + ".csv"), "Export Rental Company List");
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			ClassUtility.OlvPrint(olvRentalCompanies);
		}

		private void olvRentalCompanies_FormatCell(object sender, FormatCellEventArgs e)
		{
			if (_fixedWidthFontColumns.Any(c => c == e.Column))
				e.SubItem.Font = new Font("Consolas", e.SubItem.Font.Size);
		}
	}
}