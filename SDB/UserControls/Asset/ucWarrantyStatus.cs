using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;

namespace SDB.UserControls.Asset
{
	public partial class WarrantyStatus : UserControl
	{
		private const string _VALID = "Valid";
		private const string _EXPIRED = "Expired";
		private const string _UNDEFINED = "Undefined";
		private const string _FUTURE = "Future";
		
		private readonly Color _colValid = Color.LightGreen;
		private readonly Color _colExpired = Color.Red;
		private readonly Color _colMonitoring = Color.FromArgb(128, 128, 255);
		private readonly Color _colUndefined = SystemColors.Control;
		private readonly Color _colFuture = Color.LightSeaGreen;

		private ClassAsset _asset;
		private DateTime _now;

		public WarrantyStatus()
		{
			InitializeComponent();
		}

		public void ShowStatus(ClassAsset asset)
		{
			_now = ClassDatabase.GetCurrentTime();
			_asset = asset;

			PopulateLaborWarrantyStatus();
			PopulateLaborContractStatus();
			PopulatePartsWarrantyStatus();
			PopulatePartsContractStatus();
            PopulateCreative();
            PopulateCradlePoint();
		}

		private void PopulateLaborWarrantyStatus()
		{
			if (_asset.WarrantyInfo.LaborWarrantyExpire == DateTime.MinValue || !_asset.WarrantyInfo.LaborWarrantyExpire.HasValue)
			{
				lblLaborWarranty.Text = _UNDEFINED;
				lblLaborWarranty.BackColor = _colUndefined;
				toolTip.SetToolTip(lblLaborWarranty, "Not established.");
			}
			else if (_now.Date <= _asset.WarrantyInfo.LaborWarrantyExpire.Value.Date)
			{
				lblLaborWarranty.Text = _VALID;
				lblLaborWarranty.BackColor = _colValid;
				toolTip.SetToolTip(lblLaborWarranty, string.Format("{0}{1}Valid until {2:yyyy-MM-dd}", _asset.WarrantyInfo.LaborWarrantyNumber, Environment.NewLine, _asset.WarrantyInfo.LaborWarrantyExpire));
			}
			else
			{
				lblLaborWarranty.Text = _EXPIRED;
				lblLaborWarranty.BackColor = _colExpired;
				toolTip.SetToolTip(lblLaborWarranty, string.Format("{0}{1}Expired on {2:yyyy-MM-dd}", _asset.WarrantyInfo.LaborWarrantyNumber, Environment.NewLine, _asset.WarrantyInfo.LaborWarrantyExpire));
			}
		}

		private void PopulateLaborContractStatus()
		{
			if (_asset.WarrantyInfo.LaborContractExpire == DateTime.MinValue || !_asset.WarrantyInfo.LaborContractExpire.HasValue)
			{
				lblLaborContract.Text = _UNDEFINED;
				lblLaborContract.BackColor = _colUndefined;
				toolTip.SetToolTip(lblLaborContract, "Not established.");
			}
			else if (_asset.WarrantyInfo.LaborContractStart.GetValueOrDefault(DateTime.MinValue).Date <= _now.Date && _now.Date <= _asset.WarrantyInfo.LaborContractExpire.Value.Date)
			{
				lblLaborContract.Text = _VALID;
				if (_asset.WarrantyInfo.MonitoringContractOnly)
				{
					lblLaborContract.BackColor = _colMonitoring;
					toolTip.SetToolTip(lblLaborContract, string.Format("{0}{1}Monitoring-only until {2:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractNumber, Environment.NewLine, _asset.WarrantyInfo.LaborContractExpire));
				}
				else
				{
					lblLaborContract.BackColor = _colValid;
					toolTip.SetToolTip(lblLaborContract, string.Format("{0}{1}Valid until {2:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractNumber, Environment.NewLine, _asset.WarrantyInfo.LaborContractExpire));
				}
			}
			else if (_now.Date <= _asset.WarrantyInfo.LaborContractStart.GetValueOrDefault(DateTime.MinValue).Date)
			{
				lblLaborContract.Text = _FUTURE;
				lblLaborContract.BackColor = _colFuture;
				toolTip.SetToolTip(lblLabor, string.Format("{0}{1}Starts on {2:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractNumber, Environment.NewLine, _asset.WarrantyInfo.LaborContractStart));
			}
			else
			{
				lblLaborContract.Text = _EXPIRED;
				lblLaborContract.BackColor = _colExpired;
				toolTip.SetToolTip(lblLaborContract, string.Format("{0}{1}Expired on {2:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractNumber, Environment.NewLine, _asset.WarrantyInfo.LaborContractExpire));
			}
		}

		private void PopulatePartsWarrantyStatus()
		{
			if (_asset.WarrantyInfo.PartsWarrantyExpire == DateTime.MinValue || !_asset.WarrantyInfo.PartsWarrantyExpire.HasValue)
			{
				lblPartsWarranty.Text = _UNDEFINED;
				lblPartsWarranty.BackColor = _colUndefined;
				toolTip.SetToolTip(lblPartsWarranty, "Not established.");
			}
			else if (_now.Date <= _asset.WarrantyInfo.PartsWarrantyExpire.Value.Date)
			{
				lblPartsWarranty.Text = _VALID;
				lblPartsWarranty.BackColor = _colValid;
				toolTip.SetToolTip(lblPartsWarranty, string.Format("{0}{1}Valid until {2:yyyy-MM-dd}", _asset.WarrantyInfo.PartsWarrantyNumber, Environment.NewLine, _asset.WarrantyInfo.PartsWarrantyExpire));
			}
			else
			{
				lblPartsWarranty.Text = _EXPIRED;
				lblPartsWarranty.BackColor = _colExpired;
				toolTip.SetToolTip(lblPartsWarranty, string.Format("{0}{1}Expired on {2:yyyy-MM-dd}", _asset.WarrantyInfo.PartsWarrantyNumber, Environment.NewLine, _asset.WarrantyInfo.PartsWarrantyExpire));
			}
		}

		private void PopulatePartsContractStatus()
		{
			if (_asset.WarrantyInfo.PartsContractExpire == DateTime.MinValue || !_asset.WarrantyInfo.PartsContractExpire.HasValue)
			{
				lblPartsContract.Text = _UNDEFINED;
				lblPartsContract.BackColor = _colUndefined;
				toolTip.SetToolTip(lblPartsContract, "Not established.");
			}
			else if (_asset.WarrantyInfo.PartsContractStart.GetValueOrDefault(DateTime.MinValue).Date <= _now.Date && _now.Date <= _asset.WarrantyInfo.PartsContractExpire.Value.Date)
			{
				lblPartsContract.Text = _VALID;
				lblPartsContract.BackColor = _colValid;
				toolTip.SetToolTip(lblPartsContract, string.Format("{0}{1}Valid until {2:yyyy-MM-dd}", _asset.WarrantyInfo.PartsContractNumber, Environment.NewLine, _asset.WarrantyInfo.PartsContractExpire));
			}
			else if (_now.Date <= _asset.WarrantyInfo.PartsContractStart.GetValueOrDefault(DateTime.MinValue).Date)
			{
				lblPartsContract.Text = _FUTURE;
				lblPartsContract.BackColor = _colFuture;
				toolTip.SetToolTip(lblPartsContract, string.Format("{0}{1}Starts on {2:yyyy-MM-dd}", _asset.WarrantyInfo.PartsContractNumber, Environment.NewLine, _asset.WarrantyInfo.PartsContractStart));
			}
			else
			{
				lblPartsContract.Text = _EXPIRED;
				lblPartsContract.BackColor = _colExpired;
				toolTip.SetToolTip(lblPartsContract, string.Format("{0}{1}Expired on {2:yyyy-MM-dd}", _asset.WarrantyInfo.PartsContractNumber, Environment.NewLine, _asset.WarrantyInfo.PartsContractExpire));
			}
		}

        public void PopulateCreative()
        {
            if (_asset.WarrantyInfo.CreativeExpire == DateTime.MinValue || !_asset.WarrantyInfo.CreativeExpire.HasValue)
            {
                lblCreative_c.BackColor = _colUndefined;
                toolTip.SetToolTip(lblCreative_c, "Not established.");
            }
            else if (_asset.WarrantyInfo.CreativeStart.GetValueOrDefault(DateTime.MinValue).Date <= _now.Date && _now.Date <= _asset.WarrantyInfo.CreativeExpire.Value.Date)
            {
                lblCreative_c.BackColor = _colValid;
                toolTip.SetToolTip(lblCreative_c, string.Format("Valid until {0:yyyy-MM-dd}", _asset.WarrantyInfo.CreativeExpire));
            }
            else if (_now.Date <= _asset.WarrantyInfo.CreativeStart.GetValueOrDefault(DateTime.MinValue).Date)
            {
                lblPartsContract.BackColor = _colFuture;
                toolTip.SetToolTip(lblCreative_c, string.Format("Starts on {0:yyyy-MM-dd}", _asset.WarrantyInfo.CreativeStart));
            }
            else
            {
                lblCreative_c.BackColor = _colExpired;
                toolTip.SetToolTip(lblCreative_c, string.Format("Expired on {0:yyyy-MM-dd}", _asset.WarrantyInfo.CreativeExpire));
            }
        }


        public void PopulateCradlePoint()
        {
            if (_asset.WarrantyInfo.CradlepointExpire == DateTime.MinValue || !_asset.WarrantyInfo.CradlepointExpire.HasValue)
            {
                lblCradlepoint.BackColor = _colUndefined;
                toolTip.SetToolTip(lblCradlepoint, "Not established.");
            }
            else if (_asset.WarrantyInfo.CradlepointStart.GetValueOrDefault(DateTime.MinValue).Date <= _now.Date && _now.Date <= _asset.WarrantyInfo.CradlepointExpire.Value.Date)
            {
                lblCradlepoint.BackColor = _colValid;
                toolTip.SetToolTip(lblCradlepoint, string.Format("Valid until {0:yyyy-MM-dd}", _asset.WarrantyInfo.CradlepointExpire));
            }
            else if (_now.Date <= _asset.WarrantyInfo.CradlepointStart.GetValueOrDefault(DateTime.MinValue).Date)
            {
                lblPartsContract.BackColor = _colFuture;
                toolTip.SetToolTip(lblCradlepoint, string.Format("Starts on {0:yyyy-MM-dd}", _asset.WarrantyInfo.CradlepointStart));
            }
            else
            {
                lblCradlepoint.BackColor = _colExpired;
                toolTip.SetToolTip(lblCradlepoint, string.Format("Expired on {0:yyyy-MM-dd}", _asset.WarrantyInfo.CradlepointExpire));
            }
        }

        public void Clear()
		{
			lblLaborWarranty.Text = "Unknown";
			toolTip.SetToolTip(lblLaborWarranty, string.Empty);
			lblLaborContract.Text = "Unknown";
			toolTip.SetToolTip(lblLaborContract, string.Empty);

			lblPartsWarranty.Text = "Unknown";
			toolTip.SetToolTip(lblPartsWarranty, string.Empty);
			lblPartsContract.Text = "Unknown";
			toolTip.SetToolTip(lblPartsContract, string.Empty);
			
			lblLaborWarranty.BackColor = Color.Transparent;
			lblLaborContract.BackColor = Color.Transparent;
			lblPartsWarranty.BackColor = Color.Transparent;
			lblPartsContract.BackColor = Color.Transparent;

            lblContract.BackColor = Color.Transparent;
		}

		private void lbl_Click(object sender, EventArgs e)
		{
			OnClick(e);
		}
	}
}