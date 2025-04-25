using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;

namespace SDB.UserControls.Asset
{
	public partial class MiniWarrantyStatus : UserControl
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		private readonly Color _colValid = Color.LightGreen;
		private readonly Color _colExpired = Color.Red;
		private readonly Color _colMonitoring = Color.FromArgb(128, 128, 255);
		private readonly Color _colUndefined = SystemColors.Control;
		private readonly Color _colFuture = Color.LightSeaGreen;

		private ClassAsset _asset;
		private DateTime _now;
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		public MiniWarrantyStatus()
		{
			InitializeComponent();
		}
		#endregion

		#region Private Methods
		private void PopulateLaborWarrantyStatus()
		{
			if (_asset.WarrantyInfo.LaborWarrantyExpire == DateTime.MinValue || !_asset.WarrantyInfo.LaborWarrantyExpire.HasValue)
			{
				lblLaborWarranty.BackColor = _colUndefined;
				toolTip.SetToolTip(lblLaborWarranty, "Not established.");
			}
			else if (_now.Date <= _asset.WarrantyInfo.LaborWarrantyExpire.Value.Date)
			{
				lblLaborWarranty.BackColor = _colValid;
				toolTip.SetToolTip(lblLaborWarranty, string.Format("Valid until {0:yyyy-MM-dd}", _asset.WarrantyInfo.LaborWarrantyExpire));
			}
			else
			{
				lblLaborWarranty.BackColor = _colExpired;
				toolTip.SetToolTip(lblLaborWarranty, string.Format("Expired on {0:yyyy-MM-dd}", _asset.WarrantyInfo.LaborWarrantyExpire));
			}
		}

		private void PopulateLaborContractStatus()
		{
			if (_asset.WarrantyInfo.LaborContractExpire == DateTime.MinValue || !_asset.WarrantyInfo.LaborContractExpire.HasValue)
			{
				lblLaborContract.BackColor = _colUndefined;
				toolTip.SetToolTip(lblLaborContract, "Not established.");
			}
			else if (_asset.WarrantyInfo.LaborContractStart.GetValueOrDefault(DateTime.MinValue).Date <= _now.Date && _now.Date <= _asset.WarrantyInfo.LaborContractExpire.Value.Date)
			{
				if (_asset.WarrantyInfo.MonitoringContractOnly)
				{
					lblLaborContract.BackColor = _colMonitoring;
					toolTip.SetToolTip(lblLaborContract, string.Format("Monitoring-only until {0:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractExpire));
				}
				else
				{
					lblLaborContract.BackColor = _colValid;
					toolTip.SetToolTip(lblLaborContract, string.Format("Valid until {0:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractExpire));
				}
			}
			else if (_now.Date <= _asset.WarrantyInfo.LaborContractStart.GetValueOrDefault(DateTime.MinValue).Date)
			{
				lblLaborContract.BackColor = _colFuture;
				toolTip.SetToolTip(lblLabor, string.Format("Starts on {0:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractStart));
			}
			else
			{
				lblLaborContract.BackColor = _colExpired;
				toolTip.SetToolTip(lblLaborContract, string.Format("Expired on {0:yyyy-MM-dd}", _asset.WarrantyInfo.LaborContractExpire));
			}
		}

		private void PopulatePartsWarrantyStatus()
		{
			if (_asset.WarrantyInfo.PartsWarrantyExpire == DateTime.MinValue || !_asset.WarrantyInfo.PartsWarrantyExpire.HasValue)
			{
				lblPartsWarranty.BackColor = _colUndefined;
				toolTip.SetToolTip(lblPartsWarranty, "Not established.");
			}
			else if (_now.Date <= _asset.WarrantyInfo.PartsWarrantyExpire.Value.Date)
			{
				lblPartsWarranty.BackColor = _colValid;
				toolTip.SetToolTip(lblPartsWarranty, string.Format("Valid until {0:yyyy-MM-dd}", _asset.WarrantyInfo.PartsWarrantyExpire));
			}
			else
			{
				lblPartsWarranty.BackColor = _colExpired;
				toolTip.SetToolTip(lblPartsWarranty, string.Format("Expired on {0:yyyy-MM-dd}", _asset.WarrantyInfo.PartsWarrantyExpire));
			}
		}

		private void PopulatePartsContractStatus()
		{
			if (_asset.WarrantyInfo.PartsContractExpire == DateTime.MinValue || !_asset.WarrantyInfo.PartsContractExpire.HasValue)
			{
				lblPartsContract.BackColor = _colUndefined;
				toolTip.SetToolTip(lblPartsContract, "Not established.");
			}
			else if (_asset.WarrantyInfo.PartsContractStart.GetValueOrDefault(DateTime.MinValue).Date <= _now.Date && _now.Date <= _asset.WarrantyInfo.PartsContractExpire.Value.Date)
			{
				lblPartsContract.BackColor = _colValid;
				toolTip.SetToolTip(lblPartsContract, string.Format("Valid until {0:yyyy-MM-dd}", _asset.WarrantyInfo.PartsContractExpire));
			}
			else if (_now.Date <= _asset.WarrantyInfo.PartsContractStart.GetValueOrDefault(DateTime.MinValue).Date)
			{
				lblPartsContract.BackColor = _colFuture;
				toolTip.SetToolTip(lblPartsContract, string.Format("Starts on {0:yyyy-MM-dd}", _asset.WarrantyInfo.PartsContractStart));
			}
			else
			{
				lblPartsContract.BackColor = _colExpired;
				toolTip.SetToolTip(lblPartsContract, string.Format("Expired on {0:yyyy-MM-dd}", _asset.WarrantyInfo.PartsContractExpire));
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

        private void lbl_Click(object sender, EventArgs e)
		{
			OnClick(e);
		}
		#endregion

		#region Public Methods
		public void ShowStatus(ClassAsset asset)
		{
			_now = ClassDatabase.GetCurrentTime();
			_asset = asset;

			PopulateLaborWarrantyStatus();
			PopulateLaborContractStatus();
			PopulatePartsWarrantyStatus();
			PopulatePartsContractStatus();
            PopulateCradlePoint();
            PopulateCreative();
		}

		public void Clear()
		{
			lblLaborWarranty.BackColor = Color.Transparent;
			lblLaborContract.BackColor = Color.Transparent;
			lblPartsWarranty.BackColor = Color.Transparent;
			lblPartsContract.BackColor = Color.Transparent;
            lblContract.BackColor = Color.Transparent;
            lblCradlepoint.BackColor = Color.Transparent;
		}
		#endregion
	}
}