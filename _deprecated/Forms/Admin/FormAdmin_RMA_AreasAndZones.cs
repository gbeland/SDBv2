using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Forms.RMA;
using Seagull.BarTender.Print;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Rma_Zones : Form
	{

		private List<ClassRMA_Area> _areas = new List<ClassRMA_Area>();
		private ClassRMA_Area _selectedArea;

		private List<ClassRMA_Zone> _zones = new List<ClassRMA_Zone>();
		private ClassRMA_Zone _selectedZone;

		public FormAdmin_Rma_Zones()
		{
			InitializeComponent();

			olcDefault.AspectToStringConverter = delegate(object x)
			{
				var isDefault = (bool)x;
				return isDefault ? "True" : string.Empty;
			};
		}

		private void FormAdmin_Rma_Zones_Load(object sender, EventArgs e)
		{
			Populate_Areas();
		}

		private void Populate_Areas()
		{
			_areas = ClassRMA_Area.GetAll().ToList();

			olvRmaAreas.SetObjects(_areas);
			olvRmaZones.SetObjects(null);
		}

		private void Populate_Zones()
		{
			_zones = olvRmaAreas.SelectedObject == null ? null : ClassRMA_Zone.GetByArea(_selectedArea.ID);
			olvRmaZones.SetObjects(_zones);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void olvRMAAreas_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedArea = (ClassRMA_Area)olvRmaAreas.SelectedObject;
			_selectedZone = null;
			Populate_Zones();
		}

		private void olvRmaZones_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (olvRmaZones.SelectedItems.Count == 1)
				_selectedZone = (ClassRMA_Zone)olvRmaZones.SelectedObject;
			else
				_selectedZone = null;
		}

		private void olvRmaZones_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var zone = (ClassRMA_Zone)e.Model;
			if (!zone.IsDefault)
				return;
			e.Item.BackColor = Color.PaleGreen;
		}

		private void btnRMAZone_Add_Click(object sender, EventArgs e)
		{
			if (_selectedArea == null)
				return;

			using (var fae = new FormAdmin_RMA_Zone_AddEdit(false))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;

				try
				{
					ClassRMA_Zone.AddNew(fae.Zone, _selectedArea.ID);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not add Zone. Ensure the Zone Name is unique within its Area.{0}{0}{1}", Environment.NewLine, exc.Message), "Zone Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			Populate_Zones();
		}

		private void olvRmaZones_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			RmaZone_Edit();
		}

		private void btnRmaZone_Edit_Click(object sender, EventArgs e)
		{
			RmaZone_Edit();
		}

		private void btnRmaZone_SetDefault_Click(object sender, EventArgs e)
		{
			if (_selectedZone == null)
				return;

			ClassRMA_Zone.SetDefault(_selectedZone.ID);
			Populate_Zones();

		}

		private void RmaZone_Edit()
		{
			if (_selectedZone == null)
				return;

			var selectedIndex = olvRmaZones.IndexOf(olvRmaZones.SelectedObject);

			using (var fae = new FormAdmin_RMA_Zone_AddEdit(true, _selectedZone.ZoneName))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;

				try
				{
					_selectedZone.ZoneName = fae.Zone;
					ClassRMA_Zone.Update(_selectedZone);

				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not update Zone. Ensure the Zone Name is unique within its Area.{0}{0}{1}", Environment.NewLine, exc.Message), "Zone Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			Populate_Zones();

			// Select and show last-edited item if possible
			try
			{
				olvRmaZones.Select();
				olvRmaZones.TopItemIndex = selectedIndex;
				olvRmaZones.SelectedIndex = selectedIndex;
			}
			catch
			{
			}
		}

		private void btnRMAZone_Remove_Click(object sender, EventArgs e)
		{
			if (_selectedZone == null)
				return;

			int usedQty = ClassRMA_Zone.GetUsedQty(_selectedZone.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another zone?", _selectedZone.ZoneName, usedQty, Environment.NewLine),
					"Zone In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var fzs = new FormRMA_AreaZone_Select())
				{
					if (fzs.ShowDialog() != DialogResult.OK)
						return;

					if (fzs.SelectedZone == null)
						return;

					if (fzs.SelectedZone.ID == _selectedZone.ID)
					{
						MessageBox.Show("Cannot merge Zone with itself.", "Merge Zone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (MessageBox.Show(string.Format("Zone '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedZone.ZoneName, fzs.SelectedZone.ZoneName),
						"Confirm Zone Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;

					try
					{
						ClassRMA_Zone.Merge(_selectedZone.ID, fzs.SelectedZone.ID);
						ClassRMA_Zone.Delete(_selectedZone.ID);
						MessageBox.Show("Zone merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Zone merge failed: " + exc.Message, "Merge Zone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Zone '{0}'?", _selectedZone.ZoneName),
					"Confirm Remove Zone", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				
				ClassRMA_Zone.Delete(_selectedZone.ID);
				//MessageBox.Show("Zone remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			_selectedZone = null;
			Populate_Zones();
		}

		private void btnRmaZone_PrintLabel_Click(object sender, EventArgs e)
		{
			var selectedZones = olvRmaZones.SelectedObjects.Cast<ClassRMA_Zone>().ToList();
			PrintZoneLabels(selectedZones);
		}

		private void PrintZoneLabels(List<ClassRMA_Zone> zones)
		{
			if (zones == null || !zones.Any())
				return;

			const int LABEL_PRINT_TIMEOUT = 10000; // ms
			var rmaZoneLabelWithPath = Path.Combine(Application.StartupPath, @"Required Files", ClassRMA_Zone.RMA_ZONE_LABEL_DOCUMENT);

			#region Validation
			if (string.IsNullOrEmpty(GS.Settings.RMA_ZoneLabel_PrinterName))
			{
				MessageBox.Show("No printer selected for RMA Zone Labels.", "Printer Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			if (!File.Exists(rmaZoneLabelWithPath))
			{
				var message = string.Format("Error: Could not find the RMA Zone Label Document \"{0}\". Label printing is not possible.", rmaZoneLabelWithPath);
				MessageBox.Show(message, "Missing Label Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			Engine barTenderEngine = new Engine(true);
			LabelFormatDocument barTenderDocument;

			try
			{
				barTenderDocument = barTenderEngine.Documents.Open(rmaZoneLabelWithPath);
			}
			catch (COMException comException)
			{
				var message = string.Format("Error opening RMA Zone Label Document \"{0}\":{1}{1}{2}", rmaZoneLabelWithPath, Environment.NewLine, comException.Message);
				MessageBox.Show(message, "Error Opening Label Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
				barTenderEngine.Stop();
				return;
			}

			barTenderDocument.PrintSetup.IdenticalCopiesOfLabel = 2; // Printed label is designed to be half of a physical 4x6 label, print two above-and-below on the same label
			barTenderDocument.PrintSetup.NumberOfSerializedLabels = 1;
			barTenderDocument.PrintSetup.PrinterName = GS.Settings.RMA_ZoneLabel_PrinterName;

			var sbSummary = new StringBuilder();
			var sbDetail = new StringBuilder();

			foreach (var zone in zones)
			{
				barTenderDocument.SubStrings["area_name"].Value = ClassRMA_Area.GetByID(zone.Area_ID).AreaName;
				barTenderDocument.SubStrings["zone_name"].Value = zone.ZoneName;
				barTenderDocument.SubStrings["zone_id"].Value = string.Format("Z{0:00000}", zone.ID);

				Messages printMessages;
				Result printResult = barTenderDocument.Print(zone.ZoneName, LABEL_PRINT_TIMEOUT, out printMessages);
				var messageString = printMessages.Aggregate("\n\nMessages:", (current, m) => current + ("\n\n" + m.Text));
				sbSummary.AppendFormat("{0}: {1}", zone.ZoneName, printResult == Result.Success ? "Success" : "Failed").AppendLine();
				sbDetail.AppendFormat("{0}{1}{1}", messageString, Environment.NewLine);
			}

			barTenderEngine.Stop();

			var summaryMessage = string.Format("{0}{1}{1}Show details?", sbSummary, Environment.NewLine);
			if (MessageBox.Show(summaryMessage, "Label Print Results", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
				return;

			MessageBox.Show(sbDetail.ToString());
		}
		
		private void btnRMAArea_Add_Click(object sender, EventArgs e)
		{
			using (var fae = new FormAdmin_RMA_Area_AddEdit(false))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;

				try
				{
					ClassRMA_Area.AddNew(fae.Area);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not add Area. Ensure the Area Name is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Area Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			Populate_Areas();
		}

		private void btnRMAArea_Remove_Click(object sender, EventArgs e)
		{
			if (_selectedArea == null)
				return;

			int usedQty = ClassRMA_Area.GetUsedQty(_selectedArea.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Area?", _selectedArea.AreaName, usedQty, Environment.NewLine),
					"Area In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var fzs = new FormRMA_AreaZone_Select(FormRMA_AreaZone_Select.AreaZoneSelect.AreaOnly))
				{
					if (fzs.ShowDialog() != DialogResult.OK)
						return;

					if (fzs.SelectedArea == null)
						return;

					if (fzs.SelectedArea.ID == _selectedArea.ID)
					{
						MessageBox.Show("Cannot merge Area with itself.", "Merge Area Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (MessageBox.Show(string.Format("Area '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedArea.AreaName, fzs.SelectedArea.AreaName),
						"Confirm Area Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;

					try
					{
						ClassRMA_Area.Merge(_selectedArea.ID, fzs.SelectedArea.ID);
						ClassRMA_Area.Delete(_selectedArea.ID);
						MessageBox.Show("Area merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Area merge failed: " + exc.Message, "Merge Area Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Area '{0}'?", _selectedArea.AreaName),
					"Confirm Remove Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				ClassRMA_Area.Delete(_selectedArea.ID);
				//MessageBox.Show("Area remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			_selectedArea = null;
			Populate_Areas();
		}

		private void olvRmaAreas_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			RmaArea_Edit();

		}
		private void btnRMAArea_Edit_Click(object sender, EventArgs e)
		{
			RmaArea_Edit();
		}

		private void RmaArea_Edit()
		{
			if (_selectedArea == null)
				return;

			var selectedIndex = olvRmaAreas.IndexOf(olvRmaAreas.SelectedObject);

			using (var fae = new FormAdmin_RMA_Area_AddEdit(true, _selectedArea.AreaName))
			{
				if (fae.ShowDialog(this) != DialogResult.OK)
					return;

				try
				{
					_selectedArea.AreaName = fae.Area;
					ClassRMA_Area.Update(_selectedArea);
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Could not update Area. Ensure the Area Name is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Area Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			Populate_Areas();

			// Select and show last-edited item if possible
			try
			{
				olvRmaAreas.Select();
				olvRmaAreas.TopItemIndex = selectedIndex;
				olvRmaAreas.SelectedIndex = selectedIndex;
			}
			catch
			{
			}
		}
	}
}