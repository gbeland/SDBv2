using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_BinSelect : Form
	{
		private List<ClassRMA_Bin> _bins;

		public string SelectedBin { get; private set; }

		public FormRMA_BinSelect()
		{
			InitializeComponent();
		}

		private void FormRMA_BinSelect_Load(object sender, EventArgs e)
		{
			txtBinIDInput.Select();
		}

		private void radScan_Click(object sender, EventArgs e)
		{
			if (radScan.Checked)
				return;

			EnableListMode(false);
		}

		private void radList_Click(object sender, EventArgs e)
		{
			if (radList.Checked)
				return;

			EnableListMode();
		}

		private void EnableListMode(bool enabled = true)
		{
			radScan.Checked = !enabled;
			txtBinIDInput.Enabled = !enabled;

			radList.Checked = enabled;
			cmbBinList.Enabled = enabled;
			if (enabled)
			{
				PopulateList();
			}
			else
			{
				txtBinIDInput.Select();
				txtBinIDInput.SelectAll();
			}
		}

		private void PopulateList()
		{
			Cursor = Cursors.WaitCursor;
			_bins = ClassRMA_Bin.GetAll();
			cmbBinList.ValueMember = "ID";
			cmbBinList.DisplayMember = "ListDisplayMember";
			cmbBinList.DataSource = _bins;
			Cursor = Cursors.Default;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			SelectedBin = string.Empty;
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string binName;
			if (radList.Checked)
			{
				var bin = (ClassRMA_Bin)cmbBinList.SelectedItem;
				binName = bin.BinName;
			}
			else
			{
				binName = txtBinIDInput.Text;

				// Format as a Bin Name in case only a number was entered
				if (int.TryParse(binName, out var x))
					binName = $"B{x:D5}";

				if (!ClassRMA_Bin.ValidateBinName(binName))
				{
					var message = $"Sorry, Invalid Bin ID \"{binName}\"";
					MessageBox.Show(message, "Invalid Bin ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBinIDInput.SelectAll();
					return;
				}
			}

			SelectedBin = binName;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}