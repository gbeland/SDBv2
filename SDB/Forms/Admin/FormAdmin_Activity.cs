using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.User;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_Activity : Form
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		private class ClassRMARepairObject
		{
			public int RMA_ID { get; set; }
			public int Ticket_ID { get; set; }
			public string AssemblyType { get; set; }
			public DateTime Repair_Start { get; set; }
			public string UserName { get; set; }
		}
		#endregion

		#region Private Fields
		private List<ClassUser> _users = new List<ClassUser>();
		private List<ClassRMARepairObject> _rmaRepairs = new List<ClassRMARepairObject>();
		private bool _isPaused;
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		public FormAdmin_Activity()
		{
			InitializeComponent();

			olvLoggedIn.PrimarySortColumn = olvColLoggedIn_LoggedIn;
			olvLoggedIn.SecondarySortColumn = olvColLoggedIn_LastName;

			olvLoggedIn.PrimarySortOrder = SortOrder.Descending;
			olvLoggedIn.SecondarySortOrder = SortOrder.Ascending;

			olvColLoggedIn_Duration.AspectToStringConverter = delegate(object x)
			{
				var ts = (TimeSpan)x;
				return ClassUtility.FormatTimeSpan_Dhm(ts);
			};
		}
		#endregion

		#region Private Methods
		private void FormAdminActivity_Load(object sender, EventArgs e)
		{
			Populate();
			timerRefresh.Start();
		}

		private void FormAdmin_Activity_FormClosing(object sender, FormClosingEventArgs e)
		{
			timerRefresh.Stop();
		}

		private void timerRefresh_Tick(object sender, EventArgs e)
		{
			Populate();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			timerRefresh.Stop();
			Populate();
			timerRefresh.Start();
		}

		private void Populate()
		{
			if (_isPaused)
				return;
		
			Cursor = Cursors.WaitCursor;
			if (tabControl1.SelectedTab == tabUsers)
			{
				_users = ClassUser.GetAll(ClassUser.UserAccountStatus.Enabled).Where(u => u.IsLoggedIn).ToList();
				olvLoggedIn.SetObjects(_users);
				txtLoggedIn_Qty.Text = _users.Count.ToString(CultureInfo.InvariantCulture);
			}
			else if (tabControl1.SelectedTab == tabRMAActivity)
			{
				_rmaRepairs = Get_RMA_Repair_Activity().ToList();
				olvRMARepairs.SetObjects(_rmaRepairs);
				txtRMARepairs_Qty.Text = _rmaRepairs.Count.ToString(CultureInfo.InvariantCulture);
			}
			else if (tabControl1.SelectedTab == tabEventLog)
			{
				UpdateEventLog();
			}
			Cursor = Cursors.Default;
		}

		private void UpdateEventLog()
		{
			try
			{
				var sb = new StringBuilder();
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.Parameters.Clear();
						cmd.CommandText =
							@"SELECT
								e.timestamp,
								CONCAT(u.firstname, LEFT(u.lastname,1)) `user`,
								e.event_type,
								e.object_type,
								e.object_id,
								e.info
							FROM eventlog e
								USE INDEX (`TIMESTAMP_IX`)
								JOIN users u ON e.user_id = u.userid
							ORDER BY e.`timestamp` DESC
							LIMIT 100;";
						using (var reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								var eventTimeStamp = reader.GetDBDateTime("timestamp");
								var eventUser = reader.GetDBString("user");
								var eventType = reader.GetDBString("event_type");
								var eventObjectType = reader.GetDBString("object_type");
								var eventObjectID = reader.GetDBString("object_id");
								var eventInfo = reader.GetDBString("info");
								sb.AppendFormat("{0:yyyy-MM-dd HH:mm:ss}: {1} {2} {3} ({4}) {5}", eventTimeStamp, eventUser, eventType, eventObjectType, eventObjectID, eventInfo).AppendLine();
							}
						}
					}
					conn.Close();
				}
				rtbEventLog.Text = sb.ToString();
			}
			catch (Exception)
			{
			}
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			_isPaused = !_isPaused;

			btnPause.Text = _isPaused ? "Resume" : "Pause";
		}

		private IEnumerable<ClassRMARepairObject> Get_RMA_Repair_Activity()
		{
			var rmas = new List<ClassRMARepairObject>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"# RMA repairs in progress
						SELECT r.id rma_id, r.ticket_id, at.description assembly_type, rar.repair_start,
							CONCAT(u.firstname, LEFT(u.lastname, 1)) `user`
						FROM rma_assembly_repairlog rar
							JOIN rma_assemblies ra ON ra.id = rar.rma_assembly_id
							JOIN rma r ON r.id = ra.rma_id
							JOIN assembly_types `at` ON at.id = ra.assembly_type
							JOIN users u ON u.userid = rar.user_id
						WHERE rar.repair_end IS NULL;";
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var rro = new ClassRMARepairObject
							{
								RMA_ID = reader.GetDBInt("rma_id"),
								Ticket_ID = reader.GetDBInt("ticket_id"),
								AssemblyType = reader.GetDBString("assembly_type"),
								Repair_Start = reader.GetDBDateTime("repair_start"),
								UserName = reader.GetDBString("user")
							};
							rmas.Add(rro);
						}
					}
				}
				conn.Close();
			}
			return rmas;
		}

		private void olvLoggedIn_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
		{
			var user = (ClassUser)e.Model;
			e.Item.ForeColor = user.IsLoggedIn ? Color.Black : Color.Gray;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion
	}
}