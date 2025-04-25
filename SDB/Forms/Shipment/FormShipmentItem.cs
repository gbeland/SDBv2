using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Ticket;

namespace SDB.Forms.Shipment
{
	public partial class FormEpartItem : Form
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		private List<ClassAsset> _assets;
		
		private List<ClassAssemblyCategory> _assemblyCategories;
		private List<ClassAssemblyType> _assemblyTypes;
		private List<ClassAssembly> _assemblies;

		private ClassAssemblyCategory _selectedAssemblyCategory;
		private ClassAssemblyType _selectedAssemblyType;
		private ClassAssembly _selectedAssembly;

		private int? _assetID;
		private int? _ticketID;
		private int? _rmaID;
		private bool _ignoreStateChange;
		#endregion

		#region Public Properties
		public int Quantity;
		public ClassAssemblyType AssemblyType;
		public ClassAssembly Assembly;
		public ClassAsset Asset;
		public int? TicketID;
		public int? RmaID;
		public string JobNumber;
		public string SerialNumbers;
		#endregion

		#region Constructor
		public FormEpartItem()
		{
			InitializeComponent();

			_rmaID = null;
			_ticketID = null;
			_assetID = null;
		}

		public FormEpartItem(ClassShipment_Item shipmentItem)
		{
			InitializeComponent();
			
			_rmaID = shipmentItem.RMA_ID;
			_ticketID = shipmentItem.Ticket_ID;
			_assetID = shipmentItem.Asset_ID;
			JobNumber = shipmentItem.Job_Number;
			Quantity = shipmentItem.Quantity;
			AssemblyType = shipmentItem.AssemblyType;
			Assembly = shipmentItem.Assembly;
			SerialNumbers = shipmentItem.Serial_Number;
		}
		#endregion

		#region Private Methods
		private void FormShipmentItem_Shown(object sender, EventArgs e)
		{
			_assets = ClassAsset.GetAll(null, int.MaxValue, out var _).Where(a => !a.IsRetired).ToList();
			_assemblyCategories = ClassAssemblyCategory.GetAll().ToList();
			
			_ignoreStateChange = true;

			SetupComboboxes();

			if (_rmaID.HasValue)
				txtRMA.Text = _rmaID.ToString();
			if (_ticketID.HasValue)
				txtTicket.Text = _ticketID.ToString();
			if (_assetID.HasValue)
				cmbAsset.SelectedValue = _assetID.Value;
			
			// If editing, show the previous Job Number as custom only if it does not match the asset's current active parts number
			var selectedAsset = (ClassAsset)cmbAsset.SelectedItem;
			if (selectedAsset != null)
			{
				var activePartsNumber = selectedAsset.ActivePartsNumber;
				if (JobNumber != activePartsNumber)
					chkCustomJobNumber.Checked = true;
			}

			txtJobNumber.Text = JobNumber;

			if (Quantity < numQty.Minimum)
				Quantity = (int)numQty.Minimum;

			if (Quantity > numQty.Maximum)
				Quantity = (int)numQty.Maximum;

			numQty.Value = Quantity;

			if (Assembly != null)
			{
				_selectedAssemblyCategory = _assemblyCategories.Single(c => AssemblyType.CategoryID == c.ID);
				cmbCategory.SelectedValue = _selectedAssemblyCategory.ID;
				
				PopulateTypes();

				_selectedAssemblyType = AssemblyType;
				cmbType.SelectedValue = AssemblyType.ID;

				PopulateAssemblies();
				
				_selectedAssembly = Assembly;
				cmbAssembly.SelectedValue = Assembly.ID;
			}

			if (!string.IsNullOrEmpty(SerialNumbers))
				txtSerialNumber.Text = SerialNumbers;

			// If Job Number is populated but Asset is not, independent part should be selected
			if (!string.IsNullOrEmpty(JobNumber) && !_assetID.HasValue)
				chkCustomJobNumber.Checked = true;

			_ignoreStateChange = false;

			txtRMA.Select();
		}

		private void SetupComboboxes()
		{
			cmbAsset.DisplayMember = "DisplayMember";
			cmbAsset.ValueMember = "ID";
			cmbAsset.DataSource = _assets;
			cmbAsset.SelectedIndex = -1;

			cmbCategory.DisplayMember = "DisplayMember";
			cmbCategory.ValueMember = "ID";
			cmbCategory.DataSource = _assemblyCategories;
			cmbCategory.SelectedIndex = -1;

			cmbType.DisplayMember = "DisplayMember";
			cmbType.ValueMember = "ID";
			cmbType.DataSource = _assemblyTypes;
			cmbType.SelectedIndex = -1;

			cmbAssembly.DisplayMember = "DisplayMember";
			cmbAssembly.ValueMember = "ID";
			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string errors;

			if (!VerifySelectedAssembly())
				return;

			if (!Validate_ShipmentItem(out errors))
			{
				MessageBox.Show(errors, "Shipment Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Quantity = (int)numQty.Value;
			JobNumber = txtJobNumber.Text.Trim();
			DialogResult = DialogResult.OK;
			Close();
		}

		/// <summary>
		/// Returns true if selected assembly has been verified by user and is valid.
		/// </summary>
		private bool VerifySelectedAssembly()
		{
			Assembly = (ClassAssembly)cmbAssembly.SelectedItem;

			// Can't verify, let validation handle it
			if (Assembly == null || Assembly.ID < 1)
				return true;
			
			if (!Assembly.Disabled)
				return true;

			if (Assembly.ReplacedBy.HasValue)
			{
				var replacementAssembly = ClassAssembly.FindCurrentReplacement(Assembly);
				var msg = string.Format("This assembly is disabled and has been replaced by:{0}{0}{1} ({2}){0}{0}Do you want to use it instead?", Environment.NewLine, replacementAssembly.Description, replacementAssembly.AssemblyNumber);
				var result = MessageBox.Show(msg, "Disabled Assembly with Replacement", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				switch (result)
				{
					case DialogResult.Yes:
						cmbType.SelectedValue = replacementAssembly.AssemblyTypeID;
						cmbAssembly.SelectedValue = replacementAssembly.ID;
						return true;

					case DialogResult.Cancel:
						return false;
				}
			}

			return MessageBox.Show("This assembly is disabled, are you sure you want to select it?", "Disabled Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
		}

		/// <summary>
		/// Checks if all selections match and an asset is specified. Also sets form's public properties to selected data.
		/// Also sets public variables <see cref="TicketID"/> and <see cref="RmaID"/>.
		/// </summary>
		private bool Validate_ShipmentItem(out string errors)
		{
			var sb = new StringBuilder();

			// Clear any existing values
			TicketID = null;
			RmaID = null;

			if (numQty.Value < 1)
				sb.AppendLine("The part quantity must be greater than zero.");

			if (Assembly == null || Assembly.ID < 1)
				sb.AppendLine("Must specify a valid assembly.");

			if (string.IsNullOrEmpty(txtJobNumber.Text))
				sb.AppendLine("Must specify a job number.");

			Validate_ShipmentItem_ObjectNumbers(sb);

			Validate_ShipmentItem_PartsWarranty(sb);

			Validate_ShipmentItem_SerialNumbers(sb);

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		/// <summary>
		/// If ticket/RMA/asset are specified, they must all match
		/// </summary>
		private void Validate_ShipmentItem_ObjectNumbers(StringBuilder sb)
		{
			if (Asset == null || Asset.ID < 1)
			{
				// No asset specified, therefore ticket and RMA must also be blank
				if (!string.IsNullOrEmpty(txtRMA.Text) || !string.IsNullOrEmpty(txtTicket.Text))
					sb.AppendLine("An asset must be specified if ticket or RMA are specified.");
			}
			else
			{
				// Parse RMA and Ticket numbers from form
				if (!string.IsNullOrEmpty(txtRMA.Text))
				{
					int rmaParse;
					if (!int.TryParse(txtRMA.Text, out rmaParse))
						txtRMA.Clear();
					else
						RmaID = rmaParse;
				}

				if (!string.IsNullOrEmpty(txtTicket.Text))
				{
					int ticketParse;
					if (!int.TryParse(txtTicket.Text, out ticketParse))
						txtTicket.Clear();
					else
						TicketID = ticketParse;
				}

				if (TicketID.HasValue)
				{
					var ticket = ClassTicket.GetByID(TicketID.Value);
					if (ticket == null || ticket.AssetID != Asset.ID)
						sb.AppendLine("Ticket does not match selected asset.");
				}

				if (RmaID.HasValue)
				{
					var rma = ClassRMA.GetRMA(RmaID.Value);
					if (rma == null || rma.AssetID != Asset.ID)
						sb.AppendLine("RMA does not match selected asset.");

					if (rma == null || TicketID.HasValue && rma.TicketID != TicketID.Value)
						sb.AppendLine("RMA does not match ticket.");
				}
			}
		}

		/// <summary>
		/// Check asset parts warranty/contract; if expired or missing, a custom PO must be provided
		/// </summary>
		private void Validate_ShipmentItem_PartsWarranty(StringBuilder sb)
		{
			if (Asset == null || Asset.IsPartsCovered)
				return;

			if (!chkCustomJobNumber.Checked || (chkCustomJobNumber.Checked && string.IsNullOrEmpty(txtJobNumber.Text)))
				sb.AppendLine("Asset parts warranty/contract is missing or expired. A custom job number must be provided.");
		}

		/// <summary>
		/// Check serial numbers
		/// </summary>
		private void Validate_ShipmentItem_SerialNumbers(StringBuilder sb)
		{
			var serials = txtSerialNumber.Text.Replace(" ", string.Empty).Split(',');
			if (serials.Any(s => s.Length > ClassShipment_Item.SERIAL_NUMBER_MAX_LENGTH))
				sb.AppendFormat("The maximum length for a serial number is {0} characters.", ClassShipment_Item.SERIAL_NUMBER_MAX_LENGTH).AppendLine();

			if (serials.GroupBy(s => s).Any(g => g.Count() > 1))
				sb.AppendLine("Duplicate serial numbers are not allowed.");

			var serialQty = serials.Count(s => !string.IsNullOrEmpty(s));
			if (!string.IsNullOrEmpty(AssemblyType.SerialNumberFormat))
			{
				// Assembly type has a serial number format; require serial numbers for each assembly and in proper format
				if (serialQty != numQty.Value)
					sb.AppendFormat("Serial number quantity ({0}) does not match assembly quantity ({1}).", serialQty, numQty.Value).AppendLine();

				if (serials.Any(s => !AssemblyType.ValidateSerialNumber(s)))
					sb.AppendFormat("At least one serial number does not match the required format: \"{0}\"", AssemblyType.SerialNumberFormat).AppendLine();
			}
			else
			{
				// Assembly type does not have a serial number format; check that serial number qty is either 0 or matches assembly qty
				if (serialQty != 0 && serialQty != numQty.Value)
					sb.AppendFormat("Serial number quantity ({0}) does not match assembly quantity ({1}).", serialQty, numQty.Value).AppendLine();

				// Verify all serial numbers are the same length
				if (serials.Any(s => s.Length != serials[0].Length))
					sb.AppendFormat("Serial numbers are not all the same length. (This assembly type does not have a required format, but serial numbers for it should be similar.)");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void txtSerialNumber_TextChanged(object sender, EventArgs e)
		{
			SerialNumbers = txtSerialNumber.Text.Trim();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void NumUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void chkCustomJobNumber_CheckedChanged(object sender, EventArgs e)
		{
			var isCustom = chkCustomJobNumber.Checked;

			lblJobNumber.Enabled = txtJobNumber.Enabled = isCustom;

			if (_ignoreStateChange)
				return;
			
			if (!isCustom)
				txtJobNumber.Text = Asset.ActivePartsNumber;
			else
			{
				txtJobNumber.Clear();
				txtJobNumber.Select();
			}
		}

		private void txtRMA_TextChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			timerLookupRma.Stop();
			timerLookupRma.Start();
		}

		private void txtTicket_TextChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			timerLookupTicket.Stop();
			timerLookupTicket.Start();
		}

		private void timerLookupRma_Tick(object sender, EventArgs e)
		{
			timerLookupRma.Stop();

			int rma;
			if (!int.TryParse(txtRMA.Text, out rma))
				return;

			var ticket = ClassTicket.GetByRMA(rma);
			if (ticket == null)
				return;

			_ignoreStateChange = true;
			txtTicket.Text = ticket.ID.ToString(CultureInfo.InvariantCulture);
			_ignoreStateChange = false;

			cmbAsset.SelectedValue = ticket.AssetID;
		}

		private void timerLookupTicket_Tick(object sender, EventArgs e)
		{
			timerLookupTicket.Stop();

			int ticketId;
			if (!int.TryParse(txtTicket.Text, out ticketId))
				return;

			var ticket = ClassTicket.GetByID(ticketId);
			if (ticket == null)
				return;

			cmbAsset.SelectedValue = ticket.AssetID;

			var ticketRmas = ClassRMA.GetByTicket(ticket.ID).ToList();
			if (!ticketRmas.Any())
				return;

			if (ticketRmas.Count == 1)
			{
				var message = string.Format("This ticket has one RMA, {0}. Do you want to associate it?", ticketRmas[0].ID);
				if (MessageBox.Show(message, "Associate With RMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
					return;
				_ignoreStateChange = true;
				txtRMA.Text = ticketRmas[0].ID.ToString();
				_ignoreStateChange = false;
			}
			else
			{
				var message = string.Format("This ticket has multiple RMAs:{1}{1}{0}{1}{1}Please be sure to associate this item with one of the RMAs if applicable.", string.Join(", ", ticketRmas.OrderBy(r => r.ID).Select(r => r.ID.ToString())), Environment.NewLine);
				MessageBox.Show(this, message, "Multiple RMAs Associated", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			_selectedAssemblyCategory = (ClassAssemblyCategory)cmbCategory.SelectedItem;
			
			PopulateTypes();
		}

		private void PopulateTypes()
		{
			_assemblyTypes = _selectedAssemblyCategory == null ? null : ClassAssemblyType.GetByCategory(_selectedAssemblyCategory).ToList();

			cmbType.DataSource = _assemblyTypes;
			cmbType.SelectedIndex = -1;
		}

		private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			AssemblyType = _selectedAssemblyType = (ClassAssemblyType)cmbType.SelectedItem;
			
			PopulateAssemblies();
		}

		private void cmbAssembly_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			Assembly = (ClassAssembly)cmbAssembly.SelectedItem;
		}

		private void cmbAsset_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Asset must always be set when combobox changes
			Asset = (ClassAsset)cmbAsset.SelectedItem;

			if (_ignoreStateChange || chkCustomJobNumber.Checked || Asset == null)
				return;

			txtJobNumber.Text = Asset.ActivePartsNumber;
		}

		private void txtJobNumber_TextChanged(object sender, EventArgs e)
		{
			JobNumber = txtJobNumber.Text.Trim();
		}

		private void PopulateAssemblies()
		{
			_assemblies = _selectedAssemblyType == null ? null : ClassAssembly.GetByType(_selectedAssemblyType).OrderBy(a => a.AssemblyNumber).ToList();

			cmbAssembly.DataSource = _assemblies;
			cmbAssembly.SelectedIndex = -1;
		}

		private void cmbAssembly_DrawItem(object sender, DrawItemEventArgs e)
		{
			var comboBox = (ComboBox)sender;
			e.DrawBackground();
			if (e.Index < 0)
				return;
			var text = comboBox.GetItemText(comboBox.Items[e.Index]);
			var brush = _assemblies[e.Index].Disabled ? Brushes.Gray : Brushes.Black;
			e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
		}
		#endregion

		#region Public Methods
		public void SetAsset(int assetID)
		{
			_assetID = assetID;
		}

		public void SetJobNumber(string jobNum)
		{
			JobNumber = jobNum;
		}

		public void SetTicket(int ticketID)
		{
			_ticketID = ticketID;
		}

		public void SetRMA(int rmaID)
		{
			_rmaID = rmaID;
		}
		#endregion
	}
}