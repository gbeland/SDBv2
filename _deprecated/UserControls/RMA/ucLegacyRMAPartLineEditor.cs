using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.UserControls.RMA
{
	public partial class ucLegacyRMAPartLineEditor : UserControl
	{
		private ClassLegacyRMA.PartLine _part;

		public void SetPart(ClassLegacyRMA.PartLine Part)
		{
			_part = Part;
			numQty.Value = _part.Qty;
			BackColor = (_part.Qty > 0 ? SystemColors.Control : Color.DarkGray);
			txtMfg.Text = _part.Mfg;
			cmbPart.SelectedIndexChanged -= cmbPart_SelectedIndexChanged;
			cmbPart.Text = _part.Description;
			cmbPart.SelectedIndexChanged += cmbPart_SelectedIndexChanged;
			cmbPriority.Text = _part.Priority;
			txtRepair.Text = _part.Problem;
			txtJobNumber.Text = _part.JobNum;
			txtDisplayName.Text = _part.DisplayName;
		}

		public ClassLegacyRMA.PartLine GetPart()
		{
			return _part;
		}

		public void SetDesignation(int Designation)
		{
			lblDesignation.Text = Designation.ToString("0");
		}


		#region individual properties
		public string Priority
		{
			get => _part.Priority;
			set { cmbPriority.Text = value; }
		}

		public string Problem
		{
			get => _part.Problem;
			set { txtRepair.Text = value; }
		}

		/// <summary>
		/// Sets focus to the first field in the usercontrol which is the part quantity.
		/// </summary>
		public void StartFocus()
		{
			numQty.Focus();
		}

		public int Qty
		{
			get => _part.Qty;
			set { numQty.Value = value; }
		}

		public string JobNumber => _part.JobNum;

		public string DisplayName => _part.DisplayName;

		public string Manufacturer => _part.Mfg;

		public string Description => _part.Description;
		#endregion individual properties

		public ucLegacyRMAPartLineEditor()
		{
			InitializeComponent();
			_part = new ClassLegacyRMA.PartLine();
		}

		/// <summary>
		/// Returns true if the part quantity > 0 and a selected part description and problem.
		/// </summary>
		/// <returns></returns>
		public bool Valid()
		{
			if (_part.Qty < 1) return true;
			return _part.Description != string.Empty && _part.Problem != string.Empty;
		}

		/// <summary>
		/// Toggles whether the job number and display name are shown (used for when the part has distinct
		/// job number and display name).
		/// </summary>
		public void ShowDistinct(bool Show)
		{
			lblJobNumber.Visible = txtJobNumber.Visible = lblDisplayName.Visible = txtDisplayName.Visible = Show;
		}

		#region events
		private void numQty_Enter(object sender, EventArgs e)
		{
			NumericUpDown n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void numQty_ValueChanged(object sender, EventArgs e)
		{
			_part.Qty = (int)numQty.Value;
			BackColor = (numQty.Value > 0 ? SystemColors.Control : Color.DarkGray);
			bool en = numQty.Value > 0;
			txtMfg.Enabled = en;
			cmbPart.Enabled = en;
			txtJobNumber.Enabled = en;
			txtDisplayName.Enabled = en;
			cmbPriority.Enabled = en;
			txtRepair.Enabled = en;
		}

		private void txtMfg_TextChanged(object sender, EventArgs e)
		{
			_part.Mfg = txtMfg.Text;
		}

		private void cmbPart_SelectedIndexChanged(object sender, EventArgs e)
		{
			_part.Description = cmbPart.Text;
			cmbPriority.SelectedIndex = 0;
		}

		private void txtRepair_TextChanged(object sender, EventArgs e)
		{
			_part.Problem = txtRepair.Text;
		}

		private void txtJobNumber_TextChanged(object sender, EventArgs e)
		{
			_part.JobNum = txtJobNumber.Text;
		}

		private void txtDisplayName_TextChanged(object sender, EventArgs e)
		{
			_part.DisplayName = txtDisplayName.Text;
		}

		private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
		{
			_part.Priority = cmbPriority.Text;
		}
		#endregion events
	}
}
