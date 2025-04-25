using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_AreaZone_Select : Form
	{
		public ClassRMA_Area SelectedArea;
		public ClassRMA_Zone SelectedZone;

		private readonly IEnumerable<ClassRMA_Area> _areas = ClassRMA_Area.GetAll();
		private readonly IEnumerable<ClassRMA_Zone> _zones = ClassRMA_Zone.GetAll();

		public enum AreaZoneSelect
		{
			AreaOnly,
			AreaAndZone,
			ZoneOnly
		}

		/// <summary>
		/// RMA Area and Zone selection form.
		/// </summary>
		/// <param name="selectionMode">Determines whether area and/or zone are shown for selecting.</param>
		/// <param name="showZonesInArea">If only zone is to be selected, the area must be specified to determine which zones to show.</param>
		public FormRMA_AreaZone_Select(AreaZoneSelect selectionMode = AreaZoneSelect.AreaAndZone, ClassRMA_Area showZonesInArea = null)
		{
			InitializeComponent();

			cmbArea.DisplayMember = "DisplayMember";
			cmbArea.ValueMember = "ID";

			cmbZone.DisplayMember = "DisplayMember";
			cmbZone.ValueMember = "ID";

			switch (selectionMode)
			{
				case AreaZoneSelect.AreaOnly:
					cmbArea.DataSource = _areas.ToList();
					pnlZone.Visible = false;
					break;

				case AreaZoneSelect.ZoneOnly:
					if (showZonesInArea == null)
						throw new ArgumentNullException(nameof(showZonesInArea));
					cmbZone.DataSource = _zones.Where(z => z.Area_ID == showZonesInArea.ID);
					pnlArea.Visible = false;
					break;

				default:
					cmbArea.DataSource = _areas.ToList();
					pnlArea.Visible = pnlZone.Visible = true;
					break;
			}
		}

		private void FormRMA_AreaZone_Select_Load(object sender, EventArgs e)
		{
		}

		private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectedArea = (ClassRMA_Area)cmbArea.SelectedItem;

			cmbZone.DataSource = _zones.Where(z => z.Area_ID == SelectedArea.ID).ToList();
		}

		private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectedZone = (ClassRMA_Zone)cmbZone.SelectedItem;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}