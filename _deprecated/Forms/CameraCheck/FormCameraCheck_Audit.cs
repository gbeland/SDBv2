using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.Classes.User;

namespace SDB.Forms.CameraCheck
{
	public partial class FormCameraCheck_Audit : Form
	{
		private List<ClassCustomer> _customers;
		private List<ClassMarket> _markets;
		private List<ClassUser> _users;
		private List<ClassTicket_Symptom> _symptoms;
		private DateTime _now;
		private const int _AUDIT_MAX_DAYS = 7;

		private Dictionary<int, AssetInfo> _assetLookup;

		private struct AssetInfo
		{
			public string Customer;
			public string Market;
			public string Asset;
			public string Panel;
		}

		public FormCameraCheck_Audit()
		{
			InitializeComponent();

			olcCameraCheckCustomer.AspectToStringConverter = x => _assetLookup[(int)x].Customer;
			olcCameraCheckMarket.AspectToStringConverter = x => _assetLookup[(int)x].Market;
			olcCameraCheckAsset.AspectToStringConverter = x => _assetLookup[(int)x].Asset;
			olcCameraCheckPanel.AspectToStringConverter = x => _assetLookup[(int)x].Panel;
			olcCameraCheckUser.AspectToStringConverter = x => _users.Single(u => u.ID == (int)x).FirstL;
			olcCameraCheckSymptom.AspectToStringConverter = SymptomLookup;
			olcCameraCheckStatus.AspectToStringConverter = x => ((ClassCameraCheck.CheckStatus)x).ToString();

			olvCameraCheckResults.PrimarySortColumn = olcCameraCheckAsset;
			olvCameraCheckResults.PrimarySortOrder = SortOrder.Ascending;
			olvCameraCheckResults.SecondarySortColumn = olcCameraCheckSubmitDateTime;
			olvCameraCheckResults.SecondarySortOrder = SortOrder.Ascending;
		}

		private string SymptomLookup(object x)
		{
			if (x == null)
				return string.Empty;

			var symptom = _symptoms.SingleOrDefault(s => s.ID == (int)x);
			return symptom == null ? string.Empty : symptom.Symptom;
		}

		private void FormCameraCheck_Audit_Load(object sender, EventArgs e)
		{
			_users = ClassUser.GetAll(ClassUser.UserAccountStatus.All).OrderBy(u => u.Last).ThenBy(u => u.First).ToList();
			_symptoms = ClassTicket_Symptom.GetAll().ToList();

			_now = ClassDatabase.GetCurrentTime();
			var startOfDay = _now.Date;
			var endOfDay = new DateTime(_now.Year, _now.Month, _now.Day, 23, 59, 59);

			numLastNDays.Maximum = _AUDIT_MAX_DAYS;

			dtpFrom.Value = _now.AddDays(-1);
			dtpFrom.MinDate = startOfDay.AddDays(-_AUDIT_MAX_DAYS);
			dtpFrom.MaxDate = endOfDay;

			dtpTo.Value = _now;
			dtpTo.MinDate = startOfDay.AddDays(-_AUDIT_MAX_DAYS);
			dtpTo.MaxDate = endOfDay;
		}

		private void radCustomer_CheckedChanged(object sender, EventArgs e)
		{
			if (!radCustomer.Checked)
				return;

			SetupForCustomers();
		}

		private void radUser_CheckedChanged(object sender, EventArgs e)
		{
			if (!radUser.Checked)
				return;

			SetupForUsers();
		}

		private void SetupForUsers()
		{
			_users = ClassUser.GetAll(ClassUser.UserAccountStatus.All).OrderBy(u => u.Last).ThenBy(u => u.First).ToList();

			olvPrimary.Columns.Clear();
			var olcUsersFirst = new OLVColumn("First", "First") {Width = 70};
			var olcUsersLast = new OLVColumn("Last", "Last") { Width = 110, FillsFreeSpace = true };
			olvPrimary.Columns.Add(olcUsersFirst);
			olvPrimary.Columns.Add(olcUsersLast);
			olvPrimary.PrimarySortColumn = olcUsersFirst;
			olvPrimary.SetObjects(_users.Where(u => !u.LoginDisabled));
			olvPrimary.Visible = true;

			olvSecondary.SetObjects(null);
			olvSecondary.Visible = false;
		}

		private void SetupForCustomers()
		{
			_customers = ClassCustomer.GetCustomers().OrderBy(c => c.Name).ToList();
			_markets = ClassMarket.GetAll(null, int.MaxValue, out _).OrderBy(m => m.CustomerName).ThenBy(m => m.Name).ToList();

			olvPrimary.Columns.Clear();
			var olcCustomers = new OLVColumn("Customer", "Name") {Width = 200, FillsFreeSpace = true};
			olvPrimary.Columns.Add(olcCustomers);
			olvPrimary.PrimarySortColumn = olcCustomers;
			olvPrimary.SetObjects(_customers);
			olvPrimary.Visible = true;

			olvSecondary.SetObjects(null);
			olvSecondary.Visible = true;
		}

		private void olvPrimary_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			olvPrimary.SelectAll();
		}

		private void olvSecondary_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			olvSecondary.SelectAll();
		}

		private void olvPrimary_SelectionChanged(object sender, EventArgs e)
		{
			if(radCustomer.Checked && _markets!=null)
				olvSecondary.SetObjects(_markets.Where(m => olvPrimary.SelectedObjects.Cast<ClassCustomer>().Select(c => c.ID).Contains(m.CustomerID)));
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			btnGenerate.Enabled = false;
			Generate();
			btnGenerate.Enabled = true;
		}

		private void Generate()
		{
			#region Validation
			string errors;
			if (!ValidateDateRange(out errors))
			{
				MessageBox.Show(errors, "Date Range Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			Cursor = Cursors.WaitCursor;
			olvCameraCheckResults.SetObjects(null);
			PopulateAssetLookup();
			List<ClassCameraCheck> checks;
			if (radCustomer.Checked)
			{
				var marketIDs = olvSecondary.SelectedObjects.Cast<ClassMarket>().Select(m => m.ID).ToArray();
				checks = ClassCameraCheck.GetByMarket(marketIDs, dtpFrom.Value, dtpTo.Value, chkFailsOnly.Checked);
				
				olvCameraCheckResults.BuildGroups(olcCameraCheckAsset, SortOrder.Ascending);
				olvCameraCheckResults.AlwaysGroupByColumn = olcCameraCheckAsset;
				olvCameraCheckResults.Sort(olcCameraCheckAsset);
			}
			else
			{
				var userIDs = olvPrimary.SelectedObjects.Cast<ClassUser>().Select(u => u.ID).ToArray();
				checks = ClassCameraCheck.GetByUser(userIDs, dtpFrom.Value, dtpTo.Value, chkFailsOnly.Checked);

				olvCameraCheckResults.BuildGroups(olcCameraCheckUser, SortOrder.Ascending);
				olvCameraCheckResults.AlwaysGroupByColumn = olcCameraCheckUser;
				olvCameraCheckResults.Sort(olcCameraCheckUser);
			}
			olvCameraCheckResults.SetObjects(checks);
			Cursor = Cursors.Default;
		}

		/// <summary>
		/// Ensures that date range is no more than <see cref="_AUDIT_MAX_DAYS"/> days (to limit number of records).
		/// </summary>
		private bool ValidateDateRange(out string errors)
		{
			errors = string.Empty;
		
			var span = dtpFrom.Value - dtpTo.Value;
			if (span.Duration().TotalDays > _AUDIT_MAX_DAYS)
			{
				errors = string.Format("Date range must not exceed {0} days.", _AUDIT_MAX_DAYS);
				return false;
			}
			return true;
		}

		private void PopulateAssetLookup()
		{
			_assetLookup = new Dictionary<int, AssetInfo>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT a.id asset_id, c.name customer, m.name market, a.asset, a.panel
						FROM assets a
						JOIN markets m ON a.market_id = m.id
						JOIN customers c ON m.customer_id = c.id";
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							_assetLookup.Add(reader.GetDBInt("asset_id"), new AssetInfo
							                                        {
								                                        Customer = reader.GetDBString("customer"),
								                                        Market = reader.GetDBString("market"),
								                                        Asset = reader.GetDBString("asset"),
								                                        Panel = reader.GetDBString("panel")
							                                        });
						}
					}
				}
				conn.Close();
			}
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			ClassUtility.Export_CSV(olvCameraCheckResults, "Camera Check Audit.csv");
		}

		private void NumericUpDown_Enter(object sender, EventArgs e)
		{
			var numUpDown = (NumericUpDown)sender;
			numUpDown.Select(0, numUpDown.Text.Length);
		}

		private void numLastNDays_ValueChanged(object sender, EventArgs e)
		{
			dtpFrom.Value = _now.AddDays(-(int)numLastNDays.Value);
			dtpTo.Value = _now;
		}

		private void radDateRange_Range_CheckedChanged(object sender, EventArgs e)
		{
			pnlDateRange_Range.Enabled = radDateRange_Range.Checked;
			pnlDateRange_LastDays.Enabled = radDateRange_LastDays.Checked;
		}

		private void olvCameraCheckResults_SelectedIndexChanged(object sender, EventArgs e)
		{
			timerImageLoad.Stop();
			timerImageLoad.Start();
		}

		private void timerImageLoad_Tick(object sender, EventArgs e)
		{
			timerImageLoad.Stop();
			ClearDetails();
			PopulateDetails();
		}

		private void btnShowMenu_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ShowDetails(false);
		}

		/// <summary>
		/// Shows or hides the details pane (exchanging the menu in its place)
		/// </summary>
		private void ShowDetails(bool show)
		{
			if (show)
			{
				pnlSelections.Hide();
				pnlDetail.Show();
			}
			else
			{
				pnlDetail.Hide();
				pnlSelections.Show();
			}
		}

		private void ClearDetails()
		{
			if (pbCameraImage.Image != null)
				pbCameraImage.Image.Dispose();
			pbCameraImage.Image = null;
			lblDetail.Text = string.Empty;
		}

		private void PopulateDetails()
		{
			var cc = (ClassCameraCheck)olvCameraCheckResults.SelectedObject;
			if (cc == null)
			{
				ShowDetails(false);
				return;
			}

			var ccImage = ClassCameraCheck.GetImageForCameraCheck(cc);
			pnlDetail.Width = ccImage.Width + pnlDetail.Padding.Horizontal;
			pnlCameraImage.Height = ccImage.Height;

			switch (cc.Status)
			{
				case ClassCameraCheck.CheckStatus.Failed:
					pnlCameraImage.BackColor = ClassCameraCheck.COLOR_FAIL;
					break;
				case ClassCameraCheck.CheckStatus.Passed:
					pnlCameraImage.BackColor = ClassCameraCheck.COLOR_PASS;
					break;
				default:
					pnlCameraImage.BackColor = ClassCameraCheck.COLOR_UNDETERMINED;
					break;
			}

			pbCameraImage.Image = ccImage;

			var sb = new StringBuilder();
			sb.AppendFormat("Image Time: {0}", ClassUtility.StringFormatNull("{0:yyyy-MM-dd HH:mm:ss}", "NO IMAGES", cc.ImageDateTime)).AppendLine();
			sb.AppendFormat("Submitted:  {0:yyyy-MM-dd HH:mm:ss}", cc.Submitted).AppendLine();
			sb.AppendFormat("By:         {0}", _users.Single(u => u.ID == cc.User_ID).FirstL).AppendLine();
			sb.AppendLine();

			sb.AppendFormat("Status:     {0}", cc.Status).AppendLine();
			if (cc.Status == ClassCameraCheck.CheckStatus.Failed)
			{
				var symptom = _symptoms.SingleOrDefault(s => s.ID == cc.Symptom_ID);
				if (symptom != null)
					sb.AppendFormat("Symptom:    {0}", symptom.Symptom).AppendLine();
				sb.AppendLine();
				sb.AppendFormat("Ticket:     {0}", ClassUtility.StringFormatNull("{0}", "Not Reviewed Yet", cc.Ticket_ID)).AppendLine();
				if (cc.Ticket_ID.HasValue)
					sb.AppendFormat("Is New:     {0}", cc.NewTicket);
			}
			lblDetail.Text = sb.ToString();
			ShowDetails(true);
		}
	}
}