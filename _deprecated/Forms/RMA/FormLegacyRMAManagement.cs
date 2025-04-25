using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Tech;
using SDB.UserControls.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormLegacyRMAManagement : Form
	{
		#region Delegates and Events
		public delegate void TicketIDEvent(int TicketID);
		public delegate void ShipmentEvent(ClassLegacyRMA RMA);

		public event TicketIDEvent TicketDoubleClicked;
		public event ShipmentEvent CreateShipment;
		#endregion

		#region Globals
		private readonly ucLegacyRMAPartLineEditor[] _rmaPartLineEditorsCreate;
		private readonly ucLegacyRMAPartLineEditor[] _rmaPartLineEditorsEdit;
		private readonly ucLegacyRMAJobLogLine[] _rmaJobLogLines;
		private readonly ucLegacyRMAPartDetail[] _rmaDetailLines;

		private List<ClassTech> _techs;
		private List<ClassAsset> _assets;

		private Stream _streamToPrint;
		private int _currentRMAApprovalStatus;
		private bool _rmaJobLogCompletedPanelEntered;
		private bool _rmaJobLogNewlyCompleted;
		private DateTime? _rmaJobLogClosedDate;

		private int _currentlyLoadedRmaID = -1;

		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern bool BitBlt
		(
			IntPtr hdcDest, // handle to destination DC
			int nXDest, // x-coord of destination upper-left corner
			int nYDest, // y-coord of destination upper-left corner
			int nWidth, // width of destination rectangle
			int nHeight, // height of destination rectangle
			IntPtr hdcSrc, // handle to source DC
			int nXSrc, // x-coordinate of source upper-left corner
			int nYSrc, // y-coordinate of source upper-left corner
			int dwRop // raster operation code
		);
		#endregion

		#region Form
		public FormLegacyRMAManagement()
		{
			InitializeComponent();

			// Establish arrays for groups of controls
			_rmaPartLineEditorsCreate = new[] { ucRMAPartLineEditor_Create1, ucRMAPartLineEditor_Create2, ucRMAPartLineEditor_Create3, ucRMAPartLineEditor_Create4, ucRMAPartLineEditor_Create5 };
			_rmaPartLineEditorsEdit = new[] { ucRMAPartLineEditor_Edit1, ucRMAPartLineEditor_Edit2, ucRMAPartLineEditor_Edit3, ucRMAPartLineEditor_Edit4, ucRMAPartLineEditor_Edit5 };
			_rmaJobLogLines = new[] { ucRMAJobLogLine1, ucRMAJobLogLine2, ucRMAJobLogLine3, ucRMAJobLogLine4, ucRMAJobLogLine5 };
			_rmaDetailLines = new[] { ucRMADetail_Part1, ucRMADetail_Part2, ucRMADetail_Part3, ucRMADetail_Part4, ucRMADetail_Part5 };

			for (int i = 0; i < 5; i++)
			{
				_rmaPartLineEditorsCreate[i].SetDesignation(i + 1);
				_rmaPartLineEditorsEdit[i].SetDesignation(i + 1);
				_rmaJobLogLines[i].SetDesignation(i + 1);
			}
		}

		private void FormRMAManagement_Load(object sender, EventArgs e)
		{
			WindowState = GS.Settings.WindowState_RMAManager;
			Location = GS.Settings.Location_RMAManager;

			_techs = ClassTech.GetAll().ToList();

			cmbRMAEdit_AssignedTech.DisplayMember = "DisplayMember";
			cmbRMAEdit_AssignedTech.ValueMember = "ID";
			cmbRMAEdit_AssignedTech.DataSource = new BindingSource(_techs, null);

			cmbRMACreate_TechSelection.DisplayMember = "DisplayMember";
			cmbRMACreate_TechSelection.ValueMember = "ID";
			cmbRMACreate_TechSelection.DataSource = new BindingSource(_techs, null);

			cmbRMATechs.DisplayMember = "DisplayMember";
			cmbRMATechs.ValueMember = "ID";
			cmbRMATechs.DataSource = new BindingSource(_techs, null);

			_assets = ClassAsset.GetAll(null, int.MaxValue, out var _).ToList();

			cmbRMACreate_DisplayName.DisplayMember = "DisplayMember";
			cmbRMACreate_DisplayName.ValueMember = "ID";
			cmbRMACreate_DisplayName.DataSource = new BindingSource(_assets, null);
		}

		private void FormRMAManagement_Shown(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				WindowState = FormWindowState.Normal;
		}

		private void FormRMAManagement_FormClosing(object sender, FormClosingEventArgs e)
		{
			GS.Settings.WindowState_RMAManager = WindowState;
			if (WindowState == FormWindowState.Normal)
				GS.Settings.Location_RMAManager = Location;
			Hide();
			e.Cancel = true;
		}
		#endregion

		#region Public Methods
		public void RMA_StartSearch()
		{
			tabRMA.SelectedTab = tabRMAEdit;
			txtRMAEdit_RMANumber.Select();
		}

		/// <summary>
		/// Loads the specified RMA and displays it in the edit tab.
		/// </summary>
		public void RMA_Load(int rmaID)
		{
			RMAEdit(rmaID);
		}
		#endregion

		#region Create
		private void cmbRMACreateTechSelection_SelectedIndexChanged(object sender, EventArgs e)
		{
			AcceptButton = btnRMACreate_SelectTech;
		}

		private void btnRMACreate_SelectTech_Click(object sender, EventArgs e)
		{
			cmbRMACreate_TechSelection.Enabled = false;
			btnRMACreate_SelectTech.Enabled = false;
			grpRMACreate.Visible = true;
			dtpRMACreate_DateIssued.Value = DateTime.Now;
			cmbRMACreate_DisplayName.Select();
		}

		private void btnRMACreate_Create_Click(object sender, EventArgs e)
		{
			//RMACreate();
			MessageBox.Show("Legacy RMAs are now deprecated. No new Legacy RMA's can be created.", "Cannot Create Legacy RMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dtpRMACreate_DateIssued_Enter(object sender, EventArgs e)
		{
			dtpRMACreate_DateIssued.Value = DateTime.Now;
		}

		private void btnRMACreate_Reset_Click(object sender, EventArgs e)
		{
			RMACreate_Clear();
		}

		private void RMACreate_Clear()
		{
			grpRMACreate.Visible = false;
			cmbRMACreate_TechSelection.Enabled = true;
			btnRMACreate_SelectTech.Enabled = true;
			txtRMACreate_JobNumber.Text = string.Empty;
			cmbRMACreate_TechSelection.SelectedIndex = -1;
			cmbRMACreate_DisplayName.SelectedIndex = -1;
			chkRMACreate_APR.Checked = chkRMACreate_RiskKit.Checked = false;
			foreach (ucLegacyRMAPartLineEditor pl in _rmaPartLineEditorsCreate)
			{
				pl.SetPart(new ClassLegacyRMA.PartLine());
				pl.Priority = "No Priority";
			}
			txtRMACreate_PO.Text = string.Empty;
			txtRMACreate_TicketNumber.Text = string.Empty;
			txtRMACreate_AuthBy.Text = string.Empty;
			dtpRMACreate_DateIssued.Value = DateTime.Now;
			txtRMACreate_Tracking.Text = string.Empty;
			txtRMACreate_YescoNotes.Text = string.Empty;
			txtRMACreate_CustomerRequests.Text = string.Empty;
		}

		private void chkRMACreate_APR_CheckedChanged(object sender, EventArgs e)
		{
			bool b = chkRMACreate_APR.Checked;
			if (b) chkRMACreate_RiskKit.Checked = false;
			chkRMACreate_APR.Font = new Font(chkRMACreate_RiskKit.Font, b ? FontStyle.Bold : FontStyle.Regular);
			chkRMACreate_APR.ForeColor = b ? Color.Red : SystemColors.ControlText;
		}

		private void chkRMACreate_RiskKit_CheckedChanged(object sender, EventArgs e)
		{
			bool b = chkRMACreate_RiskKit.Checked;
			if (b) chkRMACreate_APR.Checked = false;
			chkRMACreate_RiskKit.Font = new Font(chkRMACreate_RiskKit.Font, b ? FontStyle.Bold : FontStyle.Regular);
			chkRMACreate_RiskKit.ForeColor = b ? Color.Red : SystemColors.ControlText;
		}

		private void cmbRMACreate_DisplayName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbRMACreate_DisplayName.SelectedIndex < 0) return;
			var selectedAsset = (ClassAsset)cmbRMACreate_DisplayName.SelectedItem;
			txtRMACreate_JobNumber.Text = selectedAsset.ActivePartsNumber;
		}
		#endregion

		#region Edit
		private void txtRMAEdit_TextChanged(object sender, EventArgs e)
		{
			AcceptButton = btnRMAEdit_Find;
		}

		private void btnRMAEdit_Find_Click(object sender, EventArgs e)
		{
			int rmaID;
			if (int.TryParse(txtRMAEdit_RMANumber.Text, out rmaID))
				RMAEdit(rmaID);
			else
				MessageBox.Show("Invalid RMA number.");
		}

		private void RMAEdit(int rmaID)
		{
			tabRMA.SelectedTab = tabRMAEdit;

			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"SELECT r.*
						FROM rma_legacy r
						WHERE r.rmanum = @RMANum;";
					cmd.Parameters.Add(new MySqlParameter("RMANum", rmaID));
					MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						reader.Read();
						_currentlyLoadedRmaID = reader.GetDBInt("rmanum");
						txtRMAEdit_RMANumber.Text = _currentlyLoadedRmaID.ToString();
						txtRMAEdit_RMANumber.Tag = _currentlyLoadedRmaID; // store RMA number in case user alters it without clicking "Find"
						chkRMAEdit_APR.Tag = reader.GetDBInt("apr_flag"); // store APR_Flag for UpdateRMA() use
						//cmbRMAEdit_AssignedTech.SelectedValue = ClassDatabase.GetDBString("tech_id", Reader);
						cmbRMAEdit_AssignedTech.SelectedValue = reader.GetDBInt("tech_id");
						_currentRMAApprovalStatus = reader.GetDBInt("noreturn_approval");
						btnRMAEdit_ApprovalRequired.Tag = reader.GetDBString("noreturn_reason");
						switch (_currentRMAApprovalStatus)
						{
							case 1:
								btnRMAEdit_ApprovalRequired.Text = "NR Approval Required";
								btnRMAEdit_ApprovalRequired.BackColor = Color.Red;
								btnRMAEdit_ApprovalRequired.ForeColor = Color.White;
								btnRMAEdit_ApprovalRequired.Enabled = true;
								btnRMAEdit_ApprovalRequired.Visible = true;
								break;
							case 2:
								btnRMAEdit_ApprovalRequired.Text = "NR Approved";
								btnRMAEdit_ApprovalRequired.BackColor = Color.LightGreen;
								btnRMAEdit_ApprovalRequired.ForeColor = Color.Black;
								btnRMAEdit_ApprovalRequired.Enabled = true;
								btnRMAEdit_ApprovalRequired.Visible = true;
								break;
							case 3:
								btnRMAEdit_ApprovalRequired.Text = string.Format("NR Denied ({0})", reader.GetDBString("noreturn_approvedby"));
								btnRMAEdit_ApprovalRequired.BackColor = Color.Red;
								btnRMAEdit_ApprovalRequired.ForeColor = Color.White;
								btnRMAEdit_ApprovalRequired.Enabled = true;
								btnRMAEdit_ApprovalRequired.Visible = true;
								break;
							default: // 0
								btnRMAEdit_ApprovalRequired.Enabled = false;
								btnRMAEdit_ApprovalRequired.Visible = false;
								break;
						}
						txtRMAEdit_JobNumber.Text = reader.GetDBString("jobnumber1");
						txtRMAEdit_DisplayName.Text = reader.GetDBString("displayname1");
						txtRMAEdit_DisplayName.Tag = reader.GetDBInt("asset_id");
						string apr = reader.GetDBString("apr");
						switch (apr)
						{
							case "APR":
								chkRMAEdit_APR.Checked = true;
								break;
							case "RK":
								chkRMAEdit_RiskKit.Checked = true;
								break;
							default:
								chkRMAEdit_APR.Checked = chkRMAEdit_RiskKit.Checked = false;
								break;
						}

						for (int i = 0; i < 5; i++)
						{
							int designation = i + 1;
							_rmaPartLineEditorsEdit[i].SetDesignation(designation);
							_rmaPartLineEditorsEdit[i].SetPart(ClassLegacyRMA.LegacyRMA_GetPartLineFromReader(designation, reader));
							_rmaPartLineEditorsEdit[i].ShowDistinct(_rmaPartLineEditorsEdit[i].Qty > 0 &&
															_rmaPartLineEditorsEdit[i].JobNumber != txtRMAEdit_JobNumber.Text &&
															_rmaPartLineEditorsEdit[i].JobNumber != string.Empty);
						}
						txtRMAEdit_PO.Text = reader.GetDBString("ponum");
						txtRMAEdit_TicketNumber.Text = reader.GetDBString("ticket_id");
						txtRMAEdit_CustomerWorkOrder.Text = reader.GetDBString("cust_wo");
						txtRMAEdit_AuthBy.Text = reader.GetDBString("poauth");
						dtpRMAEdit_DateIssued.Value = reader.GetDBDateTime("issued_dt");
						txtRMAEdit_Tracking.Text = reader.GetDBString("trackingnum");

						txtRMAEdit_YescoNotes.Text = reader.GetDBString("rmanote");
						txtRMAEdit_CustomerRequests.Text = reader.GetDBString("specialreq");

						// If RMA is closed, lock editing
						bool isClosed = reader.GetDBBool("closed_flag");
						RMAEdit_Lock(isClosed);
						lblRMAEdit_Completed.Visible = isClosed;
					}
					else
					{
						MessageBox.Show("RMA # " + txtRMAEdit_RMANumber.Text + " was not found.",
										"RMA Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
						RMAEdit_Clear();
						txtRMAEdit_RMANumber.SelectAll();
					}
					conn.Close();
				}
			}
		}

		private void txtRMAEdit_TicketNumber_DoubleClick(object sender, EventArgs e)
		{
			int ticketID;
			if (!int.TryParse(txtRMAEdit_TicketNumber.Text, out ticketID))
				return;
			if (TicketDoubleClicked != null)
				TicketDoubleClicked(ticketID);
		}

		/// <summary>
		/// Locks the Edit RMA screen to prevent editing.
		/// </summary>
		private void RMAEdit_Lock(bool Lock)
		{
			Lock = !Lock;
			cmbRMAEdit_AssignedTech.Enabled = Lock;
			btnRMAEdit_ApprovalRequired.Enabled = Lock;
			pnlRMAEdit_Sidebar.Enabled = Lock;
			grpRMAEdit.Enabled = Lock;
			btnRMAEdit_Update.Enabled = Lock;
		}

		private void btnRMAEdit_ApprovalRequired_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtRMAEdit_RMANumber.Tag as string))
				return;
			string rma = txtRMAEdit_RMANumber.Text = txtRMAEdit_RMANumber.Tag as string;
			FormLegacyRMANoReturnApproval frmApprove = new FormLegacyRMANoReturnApproval();
			frmApprove.SetRMA(rma);
			frmApprove.SetReason(btnRMAEdit_ApprovalRequired.Tag as string);
			DialogResult dr = frmApprove.ShowDialog();
			if (dr == DialogResult.Cancel)
				return;

			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE rma_legacy
						SET noreturn_approval = @ApprovalCode, noreturn_approvedby = @User
						WHERE rmanum = @RMA;";
					cmd.Parameters.AddWithValue("ApprovalCode", dr == DialogResult.Yes ? 2 : 3);
					cmd.Parameters.AddWithValue("User", GS.Settings.LoggedOnUser.FirstL);
					cmd.Parameters.AddWithValue("RMA", rma);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
			RMAEdit(_currentlyLoadedRmaID);
		}

		private void btnRMAEdit_Update_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == (Keys.Control | Keys.Alt))
				RMAEdit_Update();
			else
				MessageBox.Show("Legacy RMA's can no longer be modified. Contact a supervisor.", "Legacy RMA Locked", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void RMAEdit_Update()
		{
			#region validation
			if (string.IsNullOrEmpty(txtRMAEdit_TicketNumber.Text))
			{
				MessageBox.Show(string.Format("The ticket number is missing.{0}{0}RMAs now require a ticket. If this RMA is not associated with a ticket, you will have to create a ticket for it first.", Environment.NewLine), "Error Creating RMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(txtRMAEdit_JobNumber.Text) || string.IsNullOrEmpty(txtRMAEdit_DisplayName.Text))
			{
				MessageBox.Show("Job number and display name must be provided.", "Error Updating RMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (ucRMAPartLineEditor_Edit1.Qty + ucRMAPartLineEditor_Edit2.Qty + ucRMAPartLineEditor_Edit3.Qty + ucRMAPartLineEditor_Edit4.Qty + ucRMAPartLineEditor_Edit5.Qty < 1)
			{
				MessageBox.Show("At least one part must be present, check quantities.", "Error Updating RMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			for (int i = 0; i < 5; i++)
			{
				if (_rmaPartLineEditorsEdit[i].Valid()) continue;
				MessageBox.Show("A description and problem must be provided for part line number " + (i + 1) + ".", "Error Updating RMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (btnRMAEdit_ApprovalRequired.Visible && _currentRMAApprovalStatus == 1)
			{
				MessageBox.Show("One or more parts are marked \"No Return\" - please approve.", "Error Updating RMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion validation
			
			int updateRMANumber = (int)txtRMAEdit_RMANumber.Tag; // use tag (not text), to prevent user modification prior to Find button press

			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.Clear();
					cmd.CommandText = @"UPDATE rma_legacy SET
						jobnumber1=?job_number, ticket_id = ?ticket_id, cust_wo = ?customer_wo,
						quantity1=?quantity_1, manufacturer1=?manufacturer_1, partdescription1=?part_description_1, repairneeded1=?problem_1, priority1=?priority_1,
						quantity2=?quantity_2, manufacturer2=?manufacturer_2, partdescription2=?part_description_2, repairneeded2=?problem_2, priority2=?priority_2,
						quantity3=?quantity_3, manufacturer3=?manufacturer_3, partdescription3=?part_description_3, repairneeded3=?problem_3, priority3=?priority_3,
						quantity4=?quantity_4, manufacturer4=?manufacturer_4, partdescription4=?part_description_4, repairneeded4=?problem_4, priority4=?priority_4,
						quantity5=?quantity_5, manufacturer5=?manufacturer_5, partdescription5=?part_description_5, repairneeded5=?problem_5, priority5=?priority_5,
						tech_id=?tech_id, ponum=?po_num, poauth=?po_auth, issued_dt=?date_rma_sent, trackingnum=?tracking_number, specialreq=?special_requests,
						rmanote=?rma_note, apr=?apr, apr_flag=?apr_flag
						WHERE rmanum=?rma_number;";
					cmd.Parameters.Add(new MySqlParameter("?job_number", txtRMAEdit_JobNumber.Text));
					int rmaTicketID;
					if (!int.TryParse(txtRMAEdit_TicketNumber.Text, out rmaTicketID)) rmaTicketID = -1;
					cmd.Parameters.Add(new MySqlParameter("?ticket_id", rmaTicketID < 0 ? null : rmaTicketID.ToString()));
					cmd.Parameters.AddWithValue("?customer_wo", txtRMAEdit_CustomerWorkOrder.Text);
					for (int i = 0; i < 5; i++)
					{
						string px = (i + 1).ToString("0");
						ClassLegacyRMA.PartLine Part = _rmaPartLineEditorsEdit[i].GetPart();
						cmd.Parameters.Add(new MySqlParameter("?quantity_" + px, Part.Qty));
						cmd.Parameters.Add(new MySqlParameter("?manufacturer_" + px, Part.Mfg));
						cmd.Parameters.Add(new MySqlParameter("?part_description_" + px, Part.Description));
						cmd.Parameters.Add(new MySqlParameter("?problem_" + px, Part.Problem));
						string Priority = "5";
						foreach (var entry in ClassDefinitions.PRIORITY_TYPES.Where(entry => entry.Value == Part.Priority))
						{
							Priority = entry.Key.ToString();
							break;
						}
						cmd.Parameters.Add(new MySqlParameter("?priority_" + px, Priority));
					}

					cmd.Parameters.AddWithValue("?tech_id", cmbRMAEdit_AssignedTech.SelectedValue);
					cmd.Parameters.AddWithValue("?po_num", txtRMAEdit_PO.Text);
					cmd.Parameters.AddWithValue("?po_auth", txtRMAEdit_AuthBy.Text);
					cmd.Parameters.AddWithValue("?date_rma_sent", dtpRMAEdit_DateIssued.Value);
					cmd.Parameters.AddWithValue("?tracking_number", txtRMAEdit_Tracking.Text);
					cmd.Parameters.AddWithValue("?rma_note", txtRMAEdit_YescoNotes.Text);
					cmd.Parameters.AddWithValue("?special_requests", txtRMAEdit_CustomerRequests.Text);
					// APR Handling
					bool isAPR = (chkRMAEdit_APR.Checked || chkRMAEdit_RiskKit.Checked);
					int previousAPRFlag = (int)chkRMAEdit_APR.Tag;
					int newAPRFlag;
					if (!isAPR)
						newAPRFlag = 0;
					else
						newAPRFlag = (previousAPRFlag == 2 ? 2 : 1);
					cmd.Parameters.AddWithValue("apr", chkRMAEdit_RiskKit.Checked ? "RK" : chkRMAEdit_APR.Checked ? "APR" : "");
					cmd.Parameters.AddWithValue("apr_flag", newAPRFlag);
					cmd.Parameters.AddWithValue("rma_number", updateRMANumber);
					try
					{
						cmd.ExecuteNonQuery();
						MessageBox.Show("RMA [" + txtRMAEdit_RMANumber.Text + "] successfully updated!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						RMAEdit(_currentlyLoadedRmaID); // refresh
					}
					catch
					{
						MessageBox.Show("Could not update RMA", "Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					conn.Close();
				}
			}
			txtRMAEdit_RMANumber.Focus();
		}

		private void RMAEdit_Clear()
		{
			_currentlyLoadedRmaID = -1;
			txtRMAEdit_JobNumber.Text = string.Empty;
			txtRMAEdit_DisplayName.Text = string.Empty;
			chkRMAEdit_APR.Checked = chkRMAEdit_RiskKit.Checked = false;
			ucRMAPartLineEditor_Edit1.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAPartLineEditor_Edit2.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAPartLineEditor_Edit3.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAPartLineEditor_Edit4.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAPartLineEditor_Edit5.SetPart(new ClassLegacyRMA.PartLine());
			txtRMAEdit_PO.Text = string.Empty;
			txtRMAEdit_TicketNumber.Text = string.Empty;
			txtRMAEdit_AuthBy.Text = string.Empty;
			dtpRMAEdit_DateIssued.Value = DateTime.Now;
			txtRMAEdit_Tracking.Text = string.Empty;
			txtRMAEdit_CustomerRequests.Text = string.Empty;

			// Clear Job Log and Detail also
			RMAJobLog_Clear();
			RMADetail_Clear();
		}

		private void chkRMAEdit_APR_CheckedChanged(object sender, EventArgs e)
		{
			bool b = chkRMAEdit_APR.Checked;
			if (b) chkRMAEdit_RiskKit.Checked = false;
			chkRMAEdit_APR.Font = new Font(chkRMAEdit_APR.Font, b ? FontStyle.Bold : FontStyle.Regular);
			chkRMAEdit_APR.ForeColor = b ? Color.Red : SystemColors.ControlText;
		}

		private void chkRMAEdit_RiskKit_CheckedChanged(object sender, EventArgs e)
		{
			bool b = chkRMAEdit_RiskKit.Checked;
			if (b) chkRMAEdit_APR.Checked = false;
			chkRMAEdit_RiskKit.Font = new Font(chkRMAEdit_RiskKit.Font, b ? FontStyle.Bold : FontStyle.Regular);
			chkRMAEdit_RiskKit.ForeColor = b ? Color.Red : SystemColors.ControlText;
		}
		#endregion

		#region JobLog
		private void RMAJobLog_Clear()
		{
			lblRMAJobLogShow_RMANumber.Text = string.Empty;
			txtRMAJobLog_JobNumber.Text = string.Empty;
			txtRMAJobLog_TicketNumber.Text = string.Empty;
			txtRMAJobLog_DisplayName.Text = string.Empty;
			lblRMAJobLogShow_PurchaseOrder.Text = string.Empty;
			ucRMAJobLogLine1.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAJobLogLine2.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAJobLogLine3.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAJobLogLine4.SetPart(new ClassLegacyRMA.PartLine());
			ucRMAJobLogLine5.SetPart(new ClassLegacyRMA.PartLine());
			txtRMAJobLog_YescoNotes.Text = string.Empty;
		}

		private void RMA_JobLog_Populate(int RMA_ID)
		{
			tabRMA.SelectedTab = tabRMAJobLog;
			_rmaJobLogNewlyCompleted = false;
			_rmaJobLogCompletedPanelEntered = false;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					#region autocomplete populate
					AutoCompleteStringCollection acTechs = new AutoCompleteStringCollection();
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"SELECT UCASE(CONCAT(LEFT(firstname,1), lastname)) AS techabb
						FROM users";
					MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
							acTechs.Add(reader.GetDBString("techabb"));
						foreach (ucLegacyRMAJobLogLine jl in _rmaJobLogLines)
							jl.SetTechList(acTechs);
					}
					reader.Close();
					#endregion

					cmd.Parameters.Clear();
					cmd.CommandText =
						@"SELECT rma_legacy.*, techs.* FROM rma_legacy
						LEFT JOIN techs
						ON rma.tech_id = techs.id
						WHERE rma.rmanum = @RMANum;";
					cmd.Parameters.AddWithValue("RMANum", RMA_ID);
					reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						reader.Read();
						lblRMAJobLogShow_RMANumber.Text = reader.GetDBInt("rmanum").ToString();
						lblRMAJobLogShow_RMANumber.Tag = reader.GetDBInt("rmanum");
						radRMAJobLog_CompletedYes.Checked = reader.GetDBBool("closed_flag");
						radRMAJobLog_CompletedNo.Checked = !radRMAJobLog_CompletedYes.Checked;
						_rmaJobLogClosedDate = reader.GetDBDateTime_Null("closed_dt");
						radRMAJobLog_CompletedYes.Tag = reader.GetDBInt("apr_flag"); // store APR flag for JobLogRMA_EnterInfo()
						txtRMAJobLog_JobNumber.Text = reader.GetDBString("jobnumber1");
						txtRMAJobLog_TicketNumber.Text = reader.GetDBString("ticket_id");
						txtRMAJobLog_DisplayName.Text = reader.GetDBString("displayname1");
						lblRMAJobLogShow_PurchaseOrder.Text = reader.GetDBString("ponum");
						txtRMAJobLog_WorkOrders.Text = reader.GetDBString("work_order").Trim();
						txtRMAJobLog_YescoNotes.Text = reader.GetDBString("rmanote");
						txtRMAJobLog_CustomerRequests.Text = reader.GetDBString("specialreq");
						txtRMAJobLog_CustomerWorkOrder.Text = reader.GetDBString("cust_wo");
						int approval = reader.GetDBInt("noreturn_approval");
						switch (approval)
						{
							case 1: // needs approval
								lblRMAJobLog_NoReturnApproval.Text = "NR Requires Approval";
								lblRMAJobLog_NoReturnApproval.ForeColor = Color.Red;
								lblRMAJobLog_NoReturnApproval.Visible = true;
								btnRMAJobLog_EnterBottom.Enabled = btnRMAJobLog_EnterTop.Enabled = false;
								break;
							case 2: // approved
								lblRMAJobLog_NoReturnApproval.Text = "NR Approved by " + reader.GetDBString("noreturn_approvedby", "Unknown");
								lblRMAJobLog_NoReturnApproval.ForeColor = Color.DarkGreen;
								lblRMAJobLog_NoReturnApproval.Visible = true;
								btnRMAJobLog_EnterBottom.Enabled = btnRMAJobLog_EnterTop.Enabled = true;
								break;
							case 3: // denied
								lblRMAJobLog_NoReturnApproval.Text = "NR Denied by " + reader.GetDBString("noreturn_approvedby", "Unknown");
								lblRMAJobLog_NoReturnApproval.ForeColor = Color.Red;
								lblRMAJobLog_NoReturnApproval.Visible = true;
								// should the RMA Job Log be editable if a "No Return" part was denied?
								// Allowing edits for now...
								btnRMAJobLog_EnterBottom.Enabled = btnRMAJobLog_EnterTop.Enabled = true;
								break;
							default: // 0 - no approval required
								lblRMAJobLog_NoReturnApproval.Visible = false;
								btnRMAJobLog_EnterBottom.Enabled = btnRMAJobLog_EnterTop.Enabled = true;
								break;
						}
						string APR = reader.GetDBString("apr");
						for (int i = 0; i < 5; i++)
						{
							_rmaJobLogLines[i].SetPart(ClassLegacyRMA.LegacyRMA_GetPartLineFromReader(i + 1, reader));
							_rmaJobLogLines[i].SetAPR_RK(APR == "RK" ? ucLegacyRMAJobLogLine.APRType.RK : (APR == "APR" ? ucLegacyRMAJobLogLine.APRType.ARP : ucLegacyRMAJobLogLine.APRType.None));
						}

						// If RMA is closed, lock editing
						RMA_JobLog_Lock(reader.GetDBBool("closed_flag"));

						// If RMA has had a shipping form created, colorize the Create Shipment button
						btnRMAJobLog_CreateShipper.BackColor = reader.GetDBBool("shipform") ? Color.LightBlue : Color.Transparent;
					}
					else
					{
						MessageBox.Show(string.Format("Could not retrieve information for RMA {0}", lblRMADetail_Show_RMANum.Text));
						RMAJobLog_Clear();
					}
					conn.Close();
				}
			}
		}

		private void txtRMAJobLog_TicketNumber_DoubleClick(object sender, EventArgs e)
		{
			int ticketID;
			if (int.TryParse(txtRMAJobLog_TicketNumber.Text, out ticketID))
				if (TicketDoubleClicked != null)
					TicketDoubleClicked(ticketID);
		}

		/// <summary>
		/// Locks the Job Log RMA screen to prevent editing.
		/// </summary>
		private void RMA_JobLog_Lock(bool Lock)
		{
			lblRMAJobLog_JobNumber.Enabled = !Lock;
			txtRMAJobLog_JobNumber.ReadOnly = Lock;
			lblRMAJobLog_DisplayName.Enabled = !Lock;
			txtRMAJobLog_DisplayName.ReadOnly = Lock;
			foreach (Control c in pnlRMAJobLog_Header.Controls)
			{
				if (c is TextBox) (c as TextBox).ReadOnly = Lock;
				if (c is CheckBox) (c as CheckBox).AutoCheck = !Lock;
				if (c is Label) (c as Label).Enabled = !Lock;
			}
			ucRMAJobLogLine1.Lock(Lock);
			ucRMAJobLogLine2.Lock(Lock);
			ucRMAJobLogLine3.Lock(Lock);
			ucRMAJobLogLine4.Lock(Lock);
			ucRMAJobLogLine5.Lock(Lock);
			lblRMAJobLog_YescoNotes.Enabled = !Lock;
			txtRMAJobLog_YescoNotes.ReadOnly = Lock;
			lblRMAJobLog_CustomerRequests.Enabled = !Lock;
			txtRMAJobLog_CustomerRequests.ReadOnly = Lock;
			lblRMAJobLog_NoReturnApproval.Enabled = !Lock;
		}

		private void pnlRMAJobLog_Completed_Enter(object sender, EventArgs e)
		{
			_rmaJobLogCompletedPanelEntered = true;
		}

		private void radRMAJobLog_CompletedYes_CheckedChanged(object sender, EventArgs e)
		{
			_rmaJobLogNewlyCompleted = true;
			pnlRMAJobLog_Completed.BackColor = radRMAJobLog_CompletedYes.Checked ? Color.LawnGreen : SystemColors.Control;
		}

		private void btnRMAJobLog_EnterTop_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == (Keys.Control | Keys.Alt))
				RMAJobLog_Save();
			else
				MessageBox.Show("Legacy RMA's can no longer be modified. Contact a supervisor.", "Legacy RMA Locked", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnRMAJobLog_EnterBottom_Click(object sender, EventArgs e)
		{
			if (ModifierKeys == (Keys.Control | Keys.Alt))
				RMAJobLog_Save();
			else
				MessageBox.Show("Legacy RMA's can no longer be modified. Contact a supervisor.", "Legacy RMA Locked", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void RMAJobLog_Save()
		{
			#region validation
			// if the RMA is not selected for close, ask user if the RMA should be closed
			if (!radRMAJobLog_CompletedYes.Checked && !_rmaJobLogCompletedPanelEntered)
				if (MessageBox.Show("This RMA has not been closed. Do you want to close the RMA at this time?", "Close RMA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					radRMAJobLog_CompletedYes.Checked = true;
			if (radRMAJobLog_CompletedYes.Checked)
			{
				// if a part line has repairs text but no selected repair type, show a prompt
				bool needsRepairTypeSelected = false;
				for (int i = 0; i < 5; i++)
					if (!string.IsNullOrEmpty(_rmaJobLogLines[i].Repairs) && string.IsNullOrEmpty(_rmaJobLogLines[i].RepairType))
						needsRepairTypeSelected = true;
				if (needsRepairTypeSelected)
				{
					MessageBox.Show(
						"A repair type must be selected for one or more parts on this RMA. Please select the appropriate repair type(s).",
						"Missing Repair Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			#endregion validation
			// if the RMA is an APR:
			// - check all parts for a tracking number
			// - if all parts have a tracking number, the APR is complete
			// - if they do not, remind the user to enter them
			bool IsAPR = ((int)radRMAJobLog_CompletedYes.Tag) != 0;
			bool APRComplete = true;
			if (IsAPR)
				foreach (ucLegacyRMAJobLogLine jl in _rmaJobLogLines)
					if (jl.Qty > 0 && string.IsNullOrEmpty(jl.ReturnTracking))
						APRComplete = false;
			if (IsAPR && !APRComplete) MessageBox.Show("This RMA is an Advanced Parts Replacement or Risk Kit Fulfillment that does not yet have shipment tracking numbers.\n\n" +
				"Please enter tracking numbers for all parts to remove this RMA from the Parts Order list. " +
				"If a particular part does not have a tracking number or is not related to the APR, please enter \"N/A\" for the tracking number.\n\n" +
				"Completing the RMA will also remove it from the Parts Order list.", "RMA APR/RK Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"UPDATE rma_legacy SET
						rcv1_dt = @Date_Received_1, rcv2_dt = @Date_Received_2, rcv3_dt = @Date_Received_3, rcv4_dt = @Date_Received_4, rcv5_dt = @Date_Received_5,
						zone_1 = @Zone_1, zone_2 = @Zone_2, zone_3 = @Zone_3, zone_4 = @Zone_4, zone_5 = @Zone_5,
						repairdone_1 = @Repairs_1, repairdone_2 = @Repairs_2, repairdone_3 = @Repairs_3, repairdone_4 = @Repairs_4, repairdone_5 = @Repairs_5,
						mu_1 = @MU_1, mu_2 = @MU_2, mu_3 = @MU_3, mu_4 = @MU_4, mu_5 = @MU_5,
						repairtech_1 = @Tech_1, repairtech_2 = @Tech_2, repairtech_3 = @Tech_3, repairtech_4 = @Tech_4, repairtech_5 = @Tech_5,
						returnedby_1 = @Returned_By_1, returnedby_2 = @Returned_By_2, returnedby_3 = @Returned_By_3, returnedby_4 = @Returned_By_4, returnedby_5 = @Returned_By_5,
						ret1_dt = @Date_Returned_1, ret2_dt = @Date_Returned_2, ret3_dt = @Date_Returned_3, ret4_dt = @Date_Returned_4, ret5_dt = @Date_Returned_5,
						tracking_1 = @Return_Tracking_Number1, tracking_2 = @Return_Tracking_Number2, tracking_3 = @Return_Tracking_Number3, tracking_4 = @Return_Tracking_Number4, tracking_5 = @Return_Tracking_Number5,
						repairtype_1 = @RepairType1, repairtype_2 = @RepairType2, repairtype_3 = @RepairType3, repairtype_4 = @RepairType4, repairtype_5 = @RepairType5,
						closed_dt = @ClosedDate, closed_flag = @ClosedFlag, rmanote = @RMANote, specialreq = @SpecialRequests, work_order = @Work_Order, apr_flag = @APR_Flag
						WHERE rmanum = @RMANum;";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("RMANum", lblRMAJobLogShow_RMANumber.Text);
					cmd.Parameters.AddWithValue("Work_Order", txtRMAJobLog_WorkOrders.Text);
					cmd.Parameters.AddWithValue("RMANote", txtRMAJobLog_YescoNotes.Text);
					cmd.Parameters.AddWithValue("SpecialRequests", txtRMAJobLog_CustomerRequests.Text);
					for (int i = 0; i < 5; i++)
					{
						string ix = (i + 1).ToString("0");
						cmd.Parameters.AddWithValue("Date_Received_" + ix, _rmaJobLogLines[i].Received);
						cmd.Parameters.AddWithValue("Zone_" + ix, _rmaJobLogLines[i].Zone);
						cmd.Parameters.AddWithValue("Repairs_" + ix, _rmaJobLogLines[i].Repairs);
						cmd.Parameters.AddWithValue("MU_" + ix, _rmaJobLogLines[i].MU);
						cmd.Parameters.AddWithValue("Tech_" + ix, _rmaJobLogLines[i].RepairTech);
						cmd.Parameters.AddWithValue("Returned_By_" + ix, _rmaJobLogLines[i].ReturnedBy);
						cmd.Parameters.AddWithValue("Date_Returned_" + ix, _rmaJobLogLines[i].Returned);
						cmd.Parameters.AddWithValue("Return_Tracking_Number" + ix, _rmaJobLogLines[i].ReturnTracking);
						cmd.Parameters.AddWithValue("RepairType" + ix, _rmaJobLogLines[i].RepairType);
					}
					if (radRMAJobLog_CompletedYes.Checked)
					{
						cmd.Parameters.AddWithValue("ClosedFlag", true);
						cmd.Parameters.AddWithValue("ClosedDate", _rmaJobLogNewlyCompleted ? DateTime.Now : _rmaJobLogClosedDate);
					}
					else
					{
						cmd.Parameters.AddWithValue("ClosedFlag", false);
						cmd.Parameters.AddWithValue("ClosedDate", null);
					}


					cmd.Parameters.AddWithValue("APR_Flag", IsAPR && APRComplete ? 2 : IsAPR ? 1 : 0);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					try
					{
						cmd.ExecuteNonQuery();
						MessageBox.Show("Job Log updated succesfully for RMA# " + lblRMAJobLogShow_RMANumber.Text, "Update Success",
										MessageBoxButtons.OK,
										MessageBoxIcon.Information);
						RMA_JobLog_Populate(_currentlyLoadedRmaID); // refresh
					}
					catch
					{
						MessageBox.Show("Update failed for RMA# " + lblRMAJobLogShow_RMANumber.Text, "Update Failure", MessageBoxButtons.OK,
										MessageBoxIcon.Information);
					}
					conn.Close();
				}
			}
		}

		/// <summary>
		/// Pre-populates the shipping form with details from the RMA currently being edited.
		/// </summary>
		private void btnRMAJobLog_CreateShipper_Click(object sender, EventArgs e)
		{
			if (CreateShipment != null)
				CreateShipment(ClassLegacyRMA.GetByID((int)lblRMAJobLogShow_RMANumber.Tag));

			//FormShipping fs = new FormShipping();
			//fs.PopulateFromRMA(lblRMAJobLogShow_RMANumber.Text);
			//fs.Show();
			//Point p = new Point(Location.X + (Width - fs.Width) / 2, Location.Y + (Height - fs.Height) / 2);
			//fs.Location = p;
		}
		#endregion

		#region Detail
		private void RMA_Detail_Populate(int RMA_ID)
		{
			tabRMA.SelectedTab = tabRMADetail;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"SELECT *
						FROM rma_legacy
							LEFT JOIN techs ON rma.tech_id = techs.id
						WHERE rmanum = @RMANum;"; // YARP uses tech 1 // 1.1.2.3
					cmd.Parameters.AddWithValue("RMANum", RMA_ID);
					MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						reader.Read();
						lblRMADetail_Show_RMANum.Text = reader.GetDBInt("rmanum").ToString();
						lblRMADetail_Show_RMANum.Tag = reader.GetDBInt("rmanum");
						DateTime dateIssued = reader.GetDBDateTime("issued_dt");
						lblRMADetail_Show_DateIssued.Tag = dateIssued;
						lblRMADetail_Show_DateIssued.Text = dateIssued.ToString("yyyy-MM-dd");
						lblRMADetail_Show_IssuedBy.Text = reader.GetDBString("poauth");
						lblRMADetail_Show_PurchaseOrder.Text = reader.GetDBString("ponum");
						lblRMADetail_Show_TicketNumber.Text = reader.GetDBString("ticket_id");
						lblRMADetail_Show_CustomerWorkOrder.Text = reader.GetDBString("cust_wo");
						lblRMADetail_Show_AddressName.Text = reader.GetDBString("tech", "* Tech not found *");
						lblRMADetail_Show_AddressRoad.Text = reader.GetDBString("address");
						lblRMADetail_Show_AddressStateCity.Text = string.Format("{0}, {1} {2}", reader.GetDBString("city"), reader.GetDBString("state"), reader.GetDBString("zip"));
						lblRMADetail_Show_AddressTelNum.Text = reader.GetDBString("telno");
						lblRMADetail_Show_ShippingName.Text = lblRMADetail_Show_AddressName.Text;
						lblRMADetail_Show_ShippingRoad.Text = reader.GetDBString("shippingaddress");
						lblRMADetail_Show_ShippingStateCity.Text = string.Format("{0}, {1} {2}", reader.GetDBString("shippingcity"), reader.GetDBString("shippingstate"), reader.GetDBString("shippingzip"));
						lblRMADetail_Show_ShippingTelNum.Text = reader.GetDBString("telno");
						lblRMADetail_Show_APR.Text = reader.GetDBString("apr");
						if (lblRMADetail_Show_APR.Text == string.Empty) lblRMADetail_Show_APR.Text = "N/A";
						lblRMADetail_Show_APR.ForeColor = (lblRMADetail_Show_APR.Text == "APR" || lblRMADetail_Show_APR.Text == "RK" ? Color.Red : SystemColors.ControlText);
						for (int i = 0; i < 5; i++)
						{
							int designation = i + 1;
							_rmaDetailLines[i].SetDesignation(designation);
							_rmaDetailLines[i].SetPart(ClassLegacyRMA.LegacyRMA_GetPartLineFromReader(designation, reader));
						}
						txtRMADetail_YescoNotes.Text = reader.GetDBString("rmanote");
						txtRMADetail_CustomerRequests.Text = reader.GetDBString("specialreq");
					}
					else
					{
						MessageBox.Show(string.Format("Could not retrieve information for RMA {0}", lblRMADetail_Show_RMANum.Text));
					}
					conn.Close();
				}
			}
		}

		private void RMADetail_Clear()
		{
			foreach (Label l in tabRMADetail.Controls.Cast<Control>().Where(c => c is Label && c.Name.Contains("_Show_")))
				l.Text = string.Empty;
			foreach (ucLegacyRMAPartDetail rd in _rmaDetailLines)
			{
				rd.SetPart(new ClassLegacyRMA.PartLine());
			}
		}

		private void btnRMADetail_CreatePDF_Click(object sender, EventArgs e)
		{
			// create object and populate it with data
			ClassLegacyRMA rdo = new ClassLegacyRMA();
			rdo.ID = int.Parse(lblRMADetail_Show_RMANum.Text);
			rdo.IssuedDate = (DateTime)lblRMADetail_Show_DateIssued.Tag;
			rdo.IssuedBy = lblRMADetail_Show_IssuedBy.Text;
			rdo.CustomerWorkOrder = lblRMADetail_Show_CustomerWorkOrder.Text;
			rdo.PONum = lblRMADetail_Show_PurchaseOrder.Text;
			int rmaTicket;
			if (int.TryParse(lblRMADetail_Show_TicketNumber.Text, out rmaTicket))
				rdo.Ticket_ID = rmaTicket;
			rdo.CustName = lblRMADetail_Show_AddressName.Text;
			rdo.CustAddress = lblRMADetail_Show_AddressRoad.Text;
			rdo.CustCSZ = lblRMADetail_Show_AddressStateCity.Text;
			rdo.CustTel = lblRMADetail_Show_AddressTelNum.Text;
			rdo.CustShipName = lblRMADetail_Show_ShippingName.Text;
			rdo.CustShipAddress = lblRMADetail_Show_ShippingRoad.Text;
			rdo.CustShipCSZ = lblRMADetail_Show_ShippingStateCity.Text;
			rdo.CustShipTel = lblRMADetail_Show_ShippingTelNum.Text;
			rdo.APR = lblRMADetail_Show_APR.Text;

			rdo.PartData.Add(ucRMADetail_Part1.GetPart());
			rdo.PartData.Add(ucRMADetail_Part2.GetPart());
			rdo.PartData.Add(ucRMADetail_Part3.GetPart());
			rdo.PartData.Add(ucRMADetail_Part4.GetPart());
			rdo.PartData.Add(ucRMADetail_Part5.GetPart());
			rdo.YescoNotes = txtRMADetail_YescoNotes.Text;
			rdo.CustomerRequests = txtRMADetail_CustomerRequests.Text;

			// create PDF and write to it
			const string PDF_FILE_NAME = "RMA Detail.pdf";
			ClassLegacyRMA_PDFPrint.Create(rdo, PDF_FILE_NAME);

			// open in system (figure out how to automate printing at some point)
			// see http://vidmar.net/weblog/archive/2008/04/14/printing-pdf-documents-in-c.aspx for a possible method
			Process.Start(PDF_FILE_NAME);
		}
		#endregion

		#region Unreceived
		private void lstRMAUnreceived_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstvRMAUnreceived.SelectedIndices.Count != 1) return;
			try
			{
				lblRMAUnreceived_Selected.Text = "Selected RMA - # " + lstvRMAUnreceived.SelectedItems[0].SubItems[0].Text + "     Branch: " + lstvRMAUnreceived.SelectedItems[0].SubItems[2].Text;
			}
			catch { }
		}

		private void lstRMAUnreceived_DoubleClick(object sender, EventArgs e)
		{
			int rma_id;
			if (int.TryParse(lstvRMAUnreceived.SelectedItems[0].SubItems[0].Text, out rma_id))
				RMAEdit(rma_id);
			//txtRMAEdit_RMANumber.Text = lstvRMAUnreceived.SelectedItems[0].SubItems[0].Text;
			//tabRMA.SelectedTab = tabRMAEdit;
			//RMAEdit();
		}

		private void RMAUnreceived_GetRMAs()
		{
			lstvRMAUnreceived.Items.Clear();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"SELECT r.rmanum, r.issued_dt, techs.tech
									FROM rma_legacy r
										LEFT JOIN techs ON r.tech_id = techs.id
									WHERE
									((r.quantity1 > 0 && r.rcv1_dt IS NULL) OR
									(r.quantity2 > 0 && r.rcv2_dt IS NULL) OR
									(r.quantity3 > 0 && r.rcv3_dt IS NULL) OR
									(r.quantity4 > 0 && r.rcv4_dt IS NULL) OR
									(r.quantity5 > 0 && r.rcv5_dt IS NULL)) AND
									r.closed_flag = 0;";
					MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						lstvRMAUnreceived.BeginUpdate();
						while (reader.Read())
						{
							string strRMA = reader.GetDBString("rmanum");
							DateTime dateIssued = reader.GetDBDateTime("issued_dt");
							string strTech = (reader["tech"] == DBNull.Value ? "" : reader.GetDBString("tech"));
							TimeSpan tspTimeTaken = DateTime.Now - dateIssued;
							string[] myItems = { strRMA, dateIssued.ToString("yyyy-MM-dd"), strTech };
							ListViewItem lvItem = new ListViewItem(myItems, 0);
							if (tspTimeTaken.Days > 15)
							{
								lvItem.BackColor = Color.LightSlateGray;
								lvItem.ForeColor = Color.Yellow;
							}
							if (tspTimeTaken.Days > 30)
							{
								lvItem.BackColor = Color.White;
								lvItem.ForeColor = Color.Red;
							}
							lstvRMAUnreceived.Items.Add(lvItem);
						}
						lstvRMAUnreceived.EndUpdate();
					}
					conn.Close();
				}
			}
		}

		private void btnRMAUnreceivedEdit_Click(object sender, EventArgs e)
		{
			int rmaID;
			if (int.TryParse(lstvRMAUnreceived.SelectedItems[0].SubItems[0].Text, out rmaID))
				RMAEdit(rmaID);
			//try
			//{
			//    txtRMAEdit_RMANumber.Text = lstvRMAUnreceived.SelectedItems[0].SubItems[0].Text;
			//}
			//catch
			//{
			//    MessageBox.Show("No RMA selected for viewing", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//    return;
			//}
			//RMAEdit();
			//tabRMA.SelectedTab = tabRMAEdit;
		}

		private void btnRMAUnreceivedDetail_Click(object sender, EventArgs e)
		{
			int rmaID;
			if (!int.TryParse(lstvRMAUnreceived.SelectedItems[0].SubItems[0].Text, out rmaID))
				return;
			_currentlyLoadedRmaID = rmaID;
			RMA_Detail_Populate(rmaID);
		}

		private void btnRMAUnreceivedJobLog_Click(object sender, EventArgs e)
		{
			int rmaID;
			if (!int.TryParse(lstvRMAUnreceived.SelectedItems[0].SubItems[0].Text, out rmaID))
				return;
			_currentlyLoadedRmaID = rmaID;
			RMA_JobLog_Populate(rmaID);
		}

		private void btnRMA_ExportUnreceived_Click(object sender, EventArgs e)
		{
			ClassUtility.Export_CSV(lstvRMAUnreceived, "Unreceived RMA List.csv");
		}
		#endregion

		#region Unfinished
		private void RMAUnfinished_GetRMAs()
		{
			lstvRMAUnfinished.Items.Clear();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT r.rmanum, r.issued_dt, techs.tech, r.rcv1_dt
						FROM rma_legacy r
							LEFT JOIN techs ON r.tech_id = techs.id
						WHERE
						(
							(r.quantity1 > 0 && r.rcv1_dt IS NOT NULL) OR
							(r.quantity2 > 0 && r.rcv2_dt IS NOT NULL) OR
							(r.quantity3 > 0 && r.rcv3_dt IS NOT NULL) OR
							(r.quantity4 > 0 && r.rcv4_dt IS NOT NULL) OR
							(r.quantity5 > 0 && r.rcv5_dt IS NOT NULL)
						)
						AND
							r.closed_flag = 0";
					MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						lstvRMAUnfinished.BeginUpdate();
						while (reader.Read())
						{
							TimeSpan tspTimeTaken = TimeSpan.Zero;
							string strRMA = reader.GetDBString("rmanum");
							DateTime DateIssued = reader.GetDBDateTime("issued_dt");
							DateTime? DateReceived1 = reader.GetDBDateTime_Null("rcv1_dt");
							if (DateReceived1.HasValue)
								tspTimeTaken = DateTime.Now - DateReceived1.Value;
							string[] myItems = { strRMA, DateIssued.ToString("yyyy-MM-dd"), (reader["tech"] != DBNull.Value ? reader.GetDBString("tech") : "") };
							ListViewItem lvItem = new ListViewItem(myItems, 0);
							if (tspTimeTaken.Days > 15)
							{
								lvItem.BackColor = Color.LightSlateGray;
								lvItem.ForeColor = Color.Yellow;
							}
							if (tspTimeTaken.Days > 30)
							{
								lvItem.BackColor = Color.White;
								lvItem.ForeColor = Color.Red;
							}
							lstvRMAUnfinished.Items.Add(lvItem);
						}
						lstvRMAUnfinished.EndUpdate();
					}
					conn.Close();
				}
			}
		}

		private void lstRMAUnfinished_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstvRMAUnfinished.SelectedIndices.Count != 1)
				return;
			try
			{
				lblRMAUnfinished_Selected.Text = "Selected RMA - # " + lstvRMAUnfinished.SelectedItems[0].SubItems[0].Text + "     Branch: " + lstvRMAUnfinished.SelectedItems[0].SubItems[2].Text;
			}
			catch { }
		}

		private void lstRMAUnfinished_DoubleClick(object sender, EventArgs e)
		{
			int rma_id;
			if (int.TryParse(lstvRMAUnfinished.SelectedItems[0].SubItems[0].Text, out rma_id))
				RMAEdit(rma_id);
		}

		private void btnRMAUnfinishedDetail_Click(object sender, EventArgs e)
		{
			int rma_id;
			if (!int.TryParse(lstvRMAUnfinished.SelectedItems[0].SubItems[0].Text, out rma_id))
				return;
			_currentlyLoadedRmaID = rma_id;
			RMA_Detail_Populate(rma_id);
		}

		private void btnRMAUnfinishedEdit_Click(object sender, EventArgs e)
		{
			int rma_id;
			if (int.TryParse(lstvRMAUnfinished.SelectedItems[0].SubItems[0].Text, out rma_id))
				RMAEdit(rma_id);
		}

		private void btnRMAUnfinishedJobLog_Click(object sender, EventArgs e)
		{
			int rma_id;
			if (!int.TryParse(lstvRMAUnfinished.SelectedItems[0].SubItems[0].Text, out rma_id))
				return;
			_currentlyLoadedRmaID = rma_id;
			RMA_JobLog_Populate(rma_id);
		}

		private void btnRMA_ExportUnfinished_Click(object sender, EventArgs e)
		{
			ClassUtility.Export_CSV(lstvRMAUnfinished, "Unfinished RMA List.csv");
		}
		#endregion

		#region MasterList
		private void RMAMasterList_GetRMAs()
		{
			lstRMAMaster.Items.Clear();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT r.rmanum, r.issued_dt, techs.tech, r.closed_flag, r.rcv1_dt
						FROM rma_legacy r
							LEFT JOIN techs ON r.tech_id = techs.id
						ORDER BY r.rmanum ASC;";
					lblRMAMasterList_Header.Text = "Loading, please Wait...";
					lblRMAMasterList_Header.Update();
					MySqlDataReader reader = cmd.ExecuteReader();
					lstRMAMaster.BeginUpdate();
					while (reader.Read())
					{
						TimeSpan tspTimeTaken = TimeSpan.Zero;
						string strRMA = reader.GetDBString("rmanum");
						DateTime dateIssued = reader.GetDBDateTime("issued_dt");
						DateTime? dateReceived1 = reader.GetDBDateTime_Null("rcv1_dt");
						if (dateReceived1.HasValue)
							tspTimeTaken = DateTime.Now - dateReceived1.Value;
						string strTech = (reader["tech"] == DBNull.Value ? "" : reader.GetDBString("tech"));
						string strClosed = (reader.GetDBBool("closed_flag") ? "CLOSED" : "OPEN");
						string[] myItems = { strRMA, dateIssued.ToString("yyyy-MM-dd"), strTech, strClosed };
						ListViewItem lvItem = new ListViewItem(myItems, 0);
						if (tspTimeTaken.Days > 15 && strClosed != "CLOSED")
						{
							lvItem.BackColor = Color.LightSlateGray;
							lvItem.ForeColor = Color.Yellow;
						}
						if (tspTimeTaken.Days > 30 && strClosed != "CLOSED")
						{
							lvItem.BackColor = Color.White;
							lvItem.ForeColor = Color.Red;
						}
						if (strClosed == "CLOSED")
						{
							lvItem.BackColor = Color.White;
							lvItem.ForeColor = Color.Gray;
						}
						lstRMAMaster.Items.Add(lvItem);
					}
					reader.Dispose();
					lstRMAMaster.EndUpdate();
					lblRMAMasterList_Header.Text = "Master List";
					conn.Close();
				}
			}
		}

		private void lstRMAMaster_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstRMAMaster.SelectedIndices.Count != 1)
				return;
			try
			{
				lblRMAMaster_Selected.Text = "Selected RMA - # " + lstRMAMaster.SelectedItems[0].SubItems[0].Text + "     Branch: " + lstRMAMaster.SelectedItems[0].SubItems[2].Text;
			}
			catch { }
		}

		private void lstRMAMaster_DoubleClick(object sender, EventArgs e)
		{
			int rmaID;
			if (int.TryParse(lstRMAMaster.SelectedItems[0].SubItems[0].Text, out rmaID))
				RMAEdit(rmaID);
		}

		private void btnRMAMaster_Job_Click(object sender, EventArgs e)
		{
			if (lstRMAMaster.SelectedItems.Count == 0)
				return;

			int rmaID;
			if (!int.TryParse(lstRMAMaster.SelectedItems[0].SubItems[0].Text, out rmaID))
				return;
			_currentlyLoadedRmaID = rmaID;
			RMA_JobLog_Populate(rmaID);
		}

		private void btnRMAMaster_Detail_Click(object sender, EventArgs e)
		{
			if (lstRMAMaster.SelectedItems.Count == 0)
				return;
			
			int rmaID;
			if (!int.TryParse(lstRMAMaster.SelectedItems[0].SubItems[0].Text, out rmaID))
				return;
			_currentlyLoadedRmaID = rmaID;
			RMA_Detail_Populate(rmaID);
		}

		private void btnRMAMaster_Edit_Click(object sender, EventArgs e)
		{
			if (lstRMAMaster.SelectedItems.Count == 0)
				return;

			int rmaID;
			if (int.TryParse(lstRMAMaster.SelectedItems[0].SubItems[0].Text, out rmaID))
				RMAEdit(rmaID);
		}

		private void btnRMA_ExportMaster_Click(object sender, EventArgs e)
		{
			ClassUtility.Export_CSV(lstRMAMaster, "Master RMA List.csv");
		}
		#endregion

		#region ByTech
		private void btnRMA_ExportByTech_Click(object sender, EventArgs e)
		{
			ClassUtility.Export_CSV(lstvRMATechs, "RMA List by Tech.csv");
		}

		private void cmbRMAbyTechTechs_SelectedIndexChanged(object sender, EventArgs e)
		{
			RMATechs_PopulateList((int)cmbRMATechs.SelectedValue);
		}

		private void RMATechs_PopulateList(int techID)
		{
			lstvRMATechs.BeginUpdate();
			lstvRMATechs.Items.Clear();

			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT r.rmanum, r.issued_dt, r.closed_flag
						FROM rma_legacy r
						WHERE tech_id = ?TechID;";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("TechID", techID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.HasRows)
							while (reader.Read())
							{
								string rmaNumber = reader.GetDBString("rmanum");
								DateTime dateIssued = reader.GetDBDateTime("issued_dt");
								bool rmaClosed = reader.GetDBBool("closed_flag");
								string closedState = rmaClosed ? "Closed" : "Open";
								ListViewItem lvi = new ListViewItem(new[] { rmaNumber, dateIssued.ToString("yyyy-MM-dd"), closedState });
								lvi.ForeColor = rmaClosed ? Color.Gray : Color.Black;
								lstvRMATechs.Items.Add(lvi);
							}
					}
					conn.Close();
				}
			}
			lstvRMATechs.EndUpdate();
		}

		private void lstvRMATechs_DoubleClick(object sender, EventArgs e)
		{
			int rmaID;
			if (int.TryParse(lstvRMATechs.SelectedItems[0].SubItems[0].Text, out rmaID))
				RMAEdit(rmaID);
		}
		#endregion

		#region Printing
		private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
		{
			Image image = Image.FromStream(_streamToPrint);
			int x = e.MarginBounds.X;
			int y = e.MarginBounds.Y;
			int width = image.Width;
			int height = image.Height;
			if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
			{
				width = e.MarginBounds.Width;
				height = image.Height * e.MarginBounds.Width / image.Width;
			}
			else
			{
				height = e.MarginBounds.Height;
				width = image.Width * e.MarginBounds.Height / image.Height;
			}
			Rectangle destRect = new Rectangle(x, y, width, height);
			e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
		}

		private void StartPrint(Stream memorystream)
		{
			printDocument.PrintPage += printDoc_PrintPage;
			_streamToPrint = memorystream;
			PrintDialog pd = new PrintDialog();
			Margins mg = new Margins(50, 50, 50, 50);
			pd.Document = printDocument;
			pd.Document.DefaultPageSettings.Landscape = true;
			pd.Document.DefaultPageSettings.Margins = mg;

			DialogResult result = pd.ShowDialog();
			if (result == DialogResult.OK)
				pd.Document.Print();
		}
		#endregion

		#region Utility
		private void btnRMA_PrintScreen_Click(object sender, EventArgs e)
		{
			// This print method used screen capture, basically
			// hide buttons before image capture
			btnRMADetail_PrintScreen.Hide();
			btnRMAJobLog_PrintScreen.Hide();
			btnRMAEdit_PrintScreen.Hide();
			btnRMADetail_CreatePDF.Hide();

			Graphics g1 = CreateGraphics();
			Image myImage = new Bitmap(tabRMA.Width, (tabRMA.Height - 20), g1); // set size of image
			Graphics g2 = Graphics.FromImage(myImage);
			IntPtr dc1 = g1.GetHdc();
			IntPtr dc2 = g2.GetHdc();

			// show buttons
			btnRMADetail_PrintScreen.Show();
			btnRMAJobLog_PrintScreen.Show();
			btnRMAEdit_PrintScreen.Show();
			btnRMADetail_CreatePDF.Show();

			BitBlt(dc2, 0, 0, tabRMA.Width, (tabRMA.Height - 20), dc1, tabRMA.Location.X, (tabRMA.Location.Y + 20), 13369376); // transfer image
			g1.ReleaseHdc(dc1);
			g2.ReleaseHdc(dc2);
			MemoryStream ms = new MemoryStream();
			myImage.Save(ms, ImageFormat.Jpeg);
			StartPrint(ms);
			ms.Close();
		}

		private void lstRMAViewer_Click(object sender, ColumnClickEventArgs e)
		{
			ListView lv = (ListView)sender;
			lv.Tag = lv.Tag ?? "";
			lv.Sorting = (lv.Tag.ToString() == e.Column.ToString() ? (lv.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending) : SortOrder.Ascending);
			lv.Tag = e.Column.ToString();
			lv.Sort();
			// Set the ListViewItemSorter property to a new ListViewItemComparer object.
			lv.ListViewItemSorter = new ListViewItemComparer(e.Column, lv.Sorting);
		}

		private class ListViewItemComparer : IComparer
		{
			readonly private int _col;
			readonly private SortOrder _order;
			public ListViewItemComparer(int column, SortOrder order)
			{
				_col = column;
				_order = order;
			}
			public int Compare(object x, object y)
			{
				int returnVal = string.CompareOrdinal(((ListViewItem)x).SubItems[_col].Text, ((ListViewItem)y).SubItems[_col].Text);
				// Determine whether the sort order is descending.
				if (_order == SortOrder.Descending)
					// Invert the value returned by String.Compare.
					returnVal *= -1;
				return returnVal;
			}
		}
		#endregion

		private void tabRMA_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabRMA.SelectedTab == tabRMACreate)
			{
				RefreshAssetLists();
				RefreshTechLists();
			}
			else if (tabRMA.SelectedTab == tabRMAEdit)
			{
				RefreshAssetLists();
				RefreshTechLists();
				if (_currentlyLoadedRmaID < 1) return;
				RMAEdit(_currentlyLoadedRmaID);
			}
			else if (tabRMA.SelectedTab == tabRMAJobLog)
			{
				if (_currentlyLoadedRmaID < 1) return;
				RMA_JobLog_Populate(_currentlyLoadedRmaID);
			}
			else if (tabRMA.SelectedTab == tabRMADetail)
			{
				if (_currentlyLoadedRmaID < 1) return;
				RMA_Detail_Populate(_currentlyLoadedRmaID);
			}
			else if (tabRMA.SelectedTab == tabRMAUnreceived)
			{
				RMAUnreceived_GetRMAs();
			}
			else if (tabRMA.SelectedTab == tabRMAUnfinished)
			{
				RMAUnfinished_GetRMAs();
			}
			else if (tabRMA.SelectedTab == tabRMAMasterList)
			{
				RMAMasterList_GetRMAs();
			}
			else if (tabRMA.SelectedTab == tabRMATechs)
			{
				RefreshTechLists();
			}
		}

		private void RefreshTechLists()
		{
			int? selectedTechID = null;
			if (cmbRMATechs.SelectedItem != null)
				selectedTechID = (int)cmbRMATechs.SelectedValue;

			_techs = ClassTech.GetAll().ToList();

			cmbRMAEdit_AssignedTech.DataSource = new BindingSource(_techs, null);
			cmbRMACreate_TechSelection.DataSource = new BindingSource(_techs, null);
			cmbRMATechs.DataSource = new BindingSource(_techs, null);

			if (selectedTechID.HasValue)
				cmbRMATechs.SelectedValue = selectedTechID.Value;
		}

		private void RefreshAssetLists()
		{
			_assets = ClassAsset.GetAll(null, int.MaxValue, out var _).ToList();

			cmbRMACreate_DisplayName.DataSource = new BindingSource(_assets, null);
		}
	}
}