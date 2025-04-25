using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;

namespace SDB.Forms.General
{
	public partial class FormSearch : Form
	{
		public string ResultType;
		public int ResultID;

		private readonly List<ClassAsset> _assetList;
		private readonly List<ClassTicket> _ticketList;
		private readonly List<ClassTech> _techList;
		private readonly string _searchterm;
		private readonly Color _highlightColor = Color.Yellow;

		public FormSearch(string searchTerm)
		{
			InitializeComponent();
			_searchterm = searchTerm;

			if (string.IsNullOrEmpty(_searchterm))
				return;

			_assetList = ClassAsset.SearchAll(_searchterm).ToList();
			_assetList.PopulateExtraProperties();
            
			_ticketList = ClassTicket.Search(_searchterm, ClassTicket.TicketType.Open | ClassTicket.TicketType.Held | ClassTicket.TicketType.Closed).ToList();
            _ticketList.PopulateExtraStrings();
            _ticketList.PopulateSymptomsAndSolutions();

            _techList = ClassTech.Search(_searchterm).ToList();
		}

		private void FormSearch_Load(object sender, EventArgs e)
		{
			if (_ticketList.Count + _assetList.Count + _techList.Count < 1)
			{
				MessageBox.Show("Your search did not match any records.");
				Close();
			}
			PopulateAssets();
			PopulateTickets();
			PopulateTechs();
			SizeResults();
		}

		private void PopulateAssets()
		{
			if (_assetList.Count < 1)
				return;

			lblAssetCount.Text = $"{_assetList.Count}";
			foreach (var a in _assetList)
			{
				var row = new DataGridViewRow();
				row.CreateCells(dgvAssets);
				row.SetValues(new object[]
					              {
						              a.AssetName,
						              a.Panel,
						              a.Location,
						              a.FacingDirection,
						              a.City,
						              a.State,
						              a.ReleaseNumber,
                                      a.SerialNumber,
						              a.WarrantyInfo.LaborWarrantyNumber,
						              a.WarrantyInfo.LaborContractNumber,
						              a.WarrantyInfo.PartsWarrantyNumber,
						              a.WarrantyInfo.PartsContractNumber,
						              a.MatrixSize,
						              a.Pitch.ToString()
					              });
				row.Tag = a.ID;
				foreach (var cell in row.Cells.Cast<DataGridViewCell>().Where(cell => cell.Value.ToString().ToLowerInvariant().Contains(_searchterm.ToLowerInvariant())))
					cell.Style.BackColor = _highlightColor;
				dgvAssets.Rows.Add(row);
			}
		}

		private void PopulateTickets()
		{
			if (_ticketList.Count < 1)
				return;

			lblTicketCount.Text = $"{_ticketList.Count}";
            foreach (var t in _ticketList)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvTickets);
                row.SetValues(new object[]
                                  {
                                      t.ID.ToString(CultureInfo.InvariantCulture),
                                      t.CustomerIssueNumber,
                                      t.ExtraProperties.AssetName,
                                      t.ExtraProperties.AssetPanelName,
                                      t.OpenDateTime.ToString("yyyy-MM-dd"),
                                      t.CloseDateTime?.ToString("yyyy-MM-dd") ?? string.Empty,
                                      ClassUtility.FormatTimeSpan_Dhm(t.Duration),
                                      t.ExtraProperties.Symptoms(true),
                                      t.ExtraProperties.Solutions(true),
                                      t.ExtraProperties.AssignedTechName,
                                      $"{t.ReportedBy} ({t.ReportedType})"
                                  });
                row.Tag = t.ID;
                foreach (var cell in row.Cells.Cast<DataGridViewCell>().Where(cell => cell.Value.ToString().ToLowerInvariant().Contains(_searchterm.ToLowerInvariant())))
                    cell.Style.BackColor = _highlightColor;
                dgvTickets.Rows.Add(row);
            }
		}

		private void PopulateTechs()
		{
			if (_techList.Count < 1)
				return;

			lblTechsCount.Text = $"{_techList.Count}";
			foreach (var t in _techList)
			{
				var row = new DataGridViewRow();
				row.CreateCells(dgvTechs);
				row.SetValues(new object[]
					              {
						              t.TechName,
									  t.Address,
									  t.City,
									  t.State,
									  t.Zip,
									  t.Telephone,
									  t.Contact1_Name,
									  t.Contact2_Name,
									  t.Contact3_Name
					              });
				row.Tag = t.ID;
				foreach (var cell in row.Cells.Cast<DataGridViewCell>().Where(cell => cell.Value.ToString().ToLowerInvariant().Contains(_searchterm.ToLowerInvariant())))
					cell.Style.BackColor = _highlightColor;
				dgvTechs.Rows.Add(row);
			}
		}

		/// <summary>
		/// Sizes the datagridview results according to the number of results
		/// </summary>
		private void SizeResults()
		{
			// Size all according to baseline options (40 pixels for 0 results, 100 pixels otherwise)
			dgvAssets.Height = _assetList.Count > 0 ? 100 : 40;
			dgvTickets.Height = _ticketList.Count > 0 ? 100 : 40;
			dgvTechs.Height = _techList.Count > 0 ? 100 : 40;

			// Increase sizes proportionally to result count in the available space left
			float totalResults = _assetList.Count + _ticketList.Count + _techList.Count;
			var availableHeight = pnlMain.Height - (pnlMain.Controls.Cast<Control>().Sum(c => c.Height));
			dgvAssets.Height = (int)(dgvAssets.Height + (_assetList.Count / totalResults) * availableHeight);
			dgvTickets.Height = (int)(dgvTickets.Height + (_ticketList.Count / totalResults) * availableHeight);
			dgvTechs.Height = (int)(dgvTechs.Height + (_techList.Count / totalResults) * availableHeight);
		}

		private void dgvAssets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ResultType = "Asset";
			ResultID = (int)dgvAssets.Rows[dgvAssets.SelectedCells[0].RowIndex].Tag;
			Close();
		}

		private void dgvTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ResultType = "Ticket";
			ResultID = (int)dgvTickets.Rows[dgvTickets.SelectedCells[0].RowIndex].Tag;
			Close();
		}

		private void dgvTechs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ResultType = "Tech";
			ResultID = (int)dgvTechs.Rows[dgvTechs.SelectedCells[0].RowIndex].Tag;
			Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormSearch_ResizeEnd(object sender, EventArgs e)
		{
			SizeResults();
		}
	}
}