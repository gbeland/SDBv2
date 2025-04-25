using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Misc;
using SDB.Classes.RMA;

namespace SDB.UserControls.RMA
{
	public partial class ucLegacyRMAJobLogLine : UserControl
	{
		private ClassLegacyRMA.PartLine _part;
		public enum APRType { ARP, RK, None };

		public void SetPart(ClassLegacyRMA.PartLine Part)
		{
			_part = Part;
			txtQty.Text = _part.Qty.ToString();
			txtPart.Text = _part.Description;
			toolTip.SetToolTip(txtPart, _part.Problem);
			ndtpReceived.Value = _part.ReceiveDate;
			cmbZone.Text = _part.Zone;
			txtMU.Text = _part.MU;
			txtRepairs.Text = _part.Repairs;
			txtRepairedByTech.Text = _part.RepairTech;
			cmbRepairType.Text = _part.RepairType;

			txtReturnedBy.Text = _part.ReturnedBy;
			ndtpReturned.Value = _part.ReturnDate;
			txtTracking.Text = _part.TrackingNumber;

			BackColor = (_part.Qty > 0 ? SystemColors.Control : Color.DarkGray);
			pnlJobLogLine.Enabled = (_part.Qty > 0);
		}

		public void SetAPR_RK(APRType APR_Type)
		{
			switch (APR_Type)
			{
				case APRType.RK:
					lblAPR_RiskKit.Text = "RK";
					lblAPR_RiskKit.Visible = true;
					break;
				case APRType.ARP:
					lblAPR_RiskKit.Text = "APR";
					lblAPR_RiskKit.Visible = true;
					break;
				default: // None
					lblAPR_RiskKit.Visible = false;
					break;
			}
		}

		public ClassLegacyRMA.PartLine GetPart()
		{
			return _part;
		}

		public void SetDesignation(int Designation)
		{
			lblDesignation.Text = Designation.ToString("0");
		}

		public void SetTechList(AutoCompleteStringCollection TechList)
		{
			txtRepairedByTech.AutoCompleteCustomSource = TechList;
			txtReturnedBy.AutoCompleteCustomSource = TechList;
		}

		/// <summary>
		/// Prevents editing if locked.
		/// </summary>
		public void Lock(bool Lock)
		{
			foreach (Label c in Controls.OfType<Label>())
				c.Enabled = !Lock;
			txtQty.ReadOnly = Lock;
			txtPart.ReadOnly = Lock;
			ndtpReceived.Enabled = !Lock;
			cmbZone.Enabled = !Lock;
			txtMU.ReadOnly = Lock;
			txtRepairs.ReadOnly = Lock;
			txtRepairedByTech.ReadOnly = Lock;
			cmbRepairType.Enabled = !Lock;
			txtReturnedBy.ReadOnly = Lock;
			ndtpReturned.Enabled = !Lock;
			txtTracking.ReadOnly = Lock;
		}

		#region individual properties
		public int Qty => _part.Qty;

		public string Repairs => _part.Repairs;

		public DateTime? Received => _part.ReceiveDate;

		public string Zone => _part.Zone;

		public string MU => _part.MU;

		public string RepairTech => _part.RepairTech;

		public string ReturnedBy => _part.ReturnedBy;

		public DateTime? Returned => _part.ReturnDate;

		public string RepairType => _part.RepairType;

		public string ReturnTracking => _part.TrackingNumber;
		#endregion

		public ucLegacyRMAJobLogLine()
		{
			InitializeComponent();
			_part = new ClassLegacyRMA.PartLine();
			cmbRepairType.DataSource = new ClassLegacyRMA_RepairTypes().RepairActions;
			ndtpReceived.CustomFormat = ndtpReturned.CustomFormat ="yyyy-MM-dd";
		}

		#region events
		private void ndtpReceived_ValueChanged(object sender, EventArgs e)
		{
			_part.ReceiveDate = ndtpReceived.Value;
		}

		private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
		{
			_part.Zone = cmbZone.Text;
		}

		private void txtMU_TextChanged(object sender, EventArgs e)
		{
			_part.MU = txtMU.Text;
		}

		private void txtRepairs_TextChanged(object sender, EventArgs e)
		{
			_part.Repairs = txtRepairs.Text;
		}

		private void txtTech_TextChanged(object sender, EventArgs e)
		{
			_part.RepairTech = txtRepairedByTech.Text;
		}

		private void cmbRepairType_SelectedIndexChanged(object sender, EventArgs e)
		{
			_part.RepairType = cmbRepairType.Text;
		}

		private void txtReturnedBy_TextChanged(object sender, EventArgs e)
		{
			_part.ReturnedBy = txtReturnedBy.Text;
		}

		private void ndtpReturned_ValueChanged(object sender, EventArgs e)
		{
			_part.ReturnDate = ndtpReturned.Value;
		}

		private void txtTracking_TextChanged(object sender, EventArgs e)
		{
			_part.TrackingNumber = txtTracking.Text;
		}

		private void ndtpReceived_Enter(object sender, EventArgs e)
		{
			NDTP_Today_If_Null((NullableDateTimePicker)sender);
		}

		private void ndtpReturned_Enter(object sender, EventArgs e)
		{
			NDTP_Today_If_Null((NullableDateTimePicker)sender);
		}

		private void ndtpReceived_MouseDown(object sender, MouseEventArgs e)
		{
			NDTP_Today_If_Null((NullableDateTimePicker)sender);
		}

		private void ndtpReturned_MouseDown(object sender, MouseEventArgs e)
		{
			NDTP_Today_If_Null((NullableDateTimePicker)sender);
		}

		private static void NDTP_Today_If_Null(NullableDateTimePicker ndtp)
		{
			if (!ndtp.Value.HasValue) ndtp.Value = DateTime.Now.Date;
		}
		#endregion events
	}
}
