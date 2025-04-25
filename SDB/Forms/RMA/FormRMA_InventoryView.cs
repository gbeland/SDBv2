using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_InventoryView : Form
	{
		private readonly Font _areaFont = new Font("Consolas", 11F, FontStyle.Bold);
		private readonly Font _zoneFont = new Font("Consolas", 10F, FontStyle.Bold);
		private readonly Font _binFont = new Font("Consolas", 9F, FontStyle.Bold);
		private readonly Font _assyFont = new Font("Consolas", 8F, FontStyle.Regular);

		private readonly Color _emptyColor = Color.Gray;
		private readonly Color _activeColor = Color.Black;

		public int SelectedRMA { get; private set; }

		public FormRMA_InventoryView()
		{
			InitializeComponent();
		}

		private void FormRMA_Inventory_Load(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			var areas = ClassRMA_Area.GetAll();

			foreach (var area in areas)
			{
				var zones = ClassRMA_Zone.GetByArea(area.ID);
				var zoneQty = zones.Count;
				var areaNodeName = $"AREA: {area.AreaName} ({zoneQty} zone{zoneQty.SIfPlural()})";
				var areaNode = new TreeNode(areaNodeName)
					               {
						               NodeFont = _areaFont,
						               Text = areaNodeName,
									   ForeColor = zones.Count < 1 ? _emptyColor : _activeColor
					               };
				tvInventory.Nodes.Add(areaNode);

				foreach (var zone in zones)
				{
					var bins = ClassRMA_Bin.GetByZone(zone.ID);
					var binQty = bins.Count;
					var zoneNodeName = $"ZONE: {zone.ZoneName} ({binQty} bin{binQty.SIfPlural()})";
					var zoneNode = new TreeNode(zoneNodeName)
						               {
							               NodeFont = _zoneFont,
							               Text = zoneNodeName,
										   ForeColor = bins.Count < 1 ? _emptyColor : _activeColor
						               };
					areaNode.Nodes.Add(zoneNode);

					foreach (var bin in bins)
					{
						var assemblies = bin.GetAssemblies();
						var assyQty = assemblies.Count;
						var binNodeName = $"BIN: {bin.BinName} ({assyQty} assembl{(assyQty != 1 ? "ies" : "y")})";
						var binNode = new TreeNode(binNodeName)
							              {
								              NodeFont = _binFont,
								              Text = binNodeName,
											  ForeColor = assemblies.Count < 1 ? _emptyColor : _activeColor
							              };
						zoneNode.Nodes.Add(binNode);

						foreach (var assy in assemblies)
						{
							var assyNodeName = $"RMA {assy.RMA_ID}: {assy.AssemblyNumber} [SN: {assy.SerialNumber}]";
							var assyNode = new TreeNode(assyNodeName)
								               {
									               NodeFont = _assyFont,
									               Text = assyNodeName,
												   Tag = assy.RMA_ID
								               };
							binNode.Nodes.Add(assyNode);
						}
					}
				}
			}
			// Create an area for unassigned bins (non-zoned)
			const string NULL_AREA_NODE_NAME = "AREA: [UNASSIGNED]";
			var nullAreaNode = new TreeNode(NULL_AREA_NODE_NAME)
				                   {
					                   NodeFont = _areaFont,
					                   Text = NULL_AREA_NODE_NAME
				                   };
			tvInventory.Nodes.Add(nullAreaNode);

			// Get bins that aren't assigned to a zone
			var unzonedBins = ClassRMA_Bin.GetByZone(null);
			var unzonedBinQty = unzonedBins.Count;
			var unzonedNodeName = $"ZONE: [UNASSIGNED] ({unzonedBinQty} bin{unzonedBinQty.SIfPlural()})";
			var unzonedNode = new TreeNode(unzonedNodeName)
				                  {
					                  NodeFont = _zoneFont,
					                  Text = unzonedNodeName,
									  ForeColor = unzonedBins.Count < 1 ? _emptyColor : _activeColor
				                  };
			nullAreaNode.Nodes.Add(unzonedNode);

			foreach (var bin in unzonedBins)
			{
				var assemblies = bin.GetAssemblies();
				var assyQty = assemblies.Count;
				var binNodeName = $"BIN: {bin.BinName} ({assyQty} assembl{(assyQty != 1 ? "ies" : "y")})";
				var binNode = new TreeNode(binNodeName)
					              {
						              NodeFont = _binFont,
						              Text = binNodeName,
									  ForeColor = assemblies.Count < 1 ? _emptyColor : _activeColor
					              };
				unzonedNode.Nodes.Add(binNode);

				foreach (var assy in assemblies)
				{
					var assyNodeName = $"RMA {assy.RMA_ID}: {assy.AssemblyNumber} [SN: {assy.SerialNumber}]";
					var assyNode = new TreeNode(assyNodeName)
						               {
							               NodeFont = _assyFont,
							               Text = assyNodeName,
										   Tag = assy.RMA_ID
						               };
					binNode.Nodes.Add(assyNode);
				}
			}

			Cursor = Cursors.Default;
		}

		private void tvInventory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Tag == null)
				return;

			SelectedRMA = (int)e.Node.Tag;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}