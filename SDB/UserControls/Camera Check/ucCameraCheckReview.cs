using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.General;
using System.Diagnostics;

namespace SDB.UserControls.Camera_Check
{
	public partial class CameraCheckReview : UserControl
	{
		#region Delegates and Events
		public delegate void CameraCheckEvent(CameraCheckReview sender);

		public delegate void CameraCheckTicketEvent(ClassCameraCheck cameraCheck, CameraCheckReview sender);


		/// <summary>
		/// Occurs when the camera check review has been covered by/assigned a ticket.
		/// </summary>
		public event CameraCheckEvent CameraCheckCovered;

		public event CameraCheckEvent CameraCheckReverted;
		/// <summary>
		/// Occurs when the camera check review requests to open a new ticket to cover it.
		/// </summary>
		public event CameraCheckTicketEvent OpenNewTicket;
		#endregion

		#region Enums and Structs
		/// <summary>
		/// Combines an asset name with a list of <see cref="CameraCheckTicketData"/>
		/// </summary>
		private class CameraCheckReviewData
		{
			public string Asset { get; set; }
			public List<CameraCheckTicketData> Tickets { get; set; }

			public class CameraCheckTicketData
			{
				public int TicketID { get; set; }
				public string Symptoms { get; set; }
				public string OtherSymptom { get; set; }
				public TimeSpan Duration { get; set; }

				[UsedImplicitly]
				public string CombinedSymptoms => Symptoms + (string.IsNullOrEmpty(OtherSymptom) ? string.Empty : string.Format(" ({0})", OtherSymptom));

				[UsedImplicitly]
				public string DurationAsRoundedString()
				{
					return ClassUtility.FormatRoundedTimeSpan_Dhm(Duration.Round());
				}

				public override string ToString()
				{
					return string.Format("{0} {1} {2}", TicketID, CombinedSymptoms, ClassUtility.FormatRoundedTimeSpan_Dhm(Duration.Round()));
				}

				public CameraCheckTicketData()
				{
					Duration = TimeSpan.Zero;
				}
			}

			public CameraCheckReviewData(string asset)
			{
				Asset = asset;
				Tickets = new List<CameraCheckTicketData>();
			}
		}
		#endregion

		#region Private Fields
		private readonly ClassCameraCheck _cc;
		private readonly CameraCheckReviewData _ccReviewData;
		#endregion

		#region Public Properties
		public int ID { get; private set; }
		#endregion

		#region Constructor
		public CameraCheckReview(ClassCameraCheck cameraCheck)
		{
			InitializeComponent();
			if (cameraCheck == null)
				return;

			_cc = cameraCheck;
			_ccReviewData = GetReviewData(_cc);
			ID = _cc.ID;

			Populate();
			if (GS.Settings.LoggedOnUser.UserType == ClassUser.USERTYPE_STANDARD)
				btnRevert.FlatStyle = FlatStyle.Flat;
		}
		#endregion

		#region Private Methods
		private CameraCheckReviewData GetReviewData(ClassCameraCheck cc)
		{
			var data = new CameraCheckReviewData(ClassAsset.GetName(cc.Asset_ID));
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT
							t.id ticket_id,
							GROUP_CONCAT(DISTINCT(sym.symptom) SEPARATOR ', ') symptoms,
							t.symptom_other other_symptom,
							TIMESTAMPDIFF(SECOND, t.open_dt, NOW()) duration_seconds
						FROM tickets t
							LEFT JOIN ticket_symptoms tsym
								JOIN symptoms sym ON tsym.symptom_id = sym.id
								ON tsym.ticket_id = t.id
						WHERE t.deleted IS FALSE
							AND t.close_dt IS NULL
							AND t.asset_id = @assetId
						GROUP BY t.id;";
					cmd.Parameters.AddWithValue("assetId", cc.Asset_ID);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var ticket = new CameraCheckReviewData.CameraCheckTicketData
							{
								TicketID = reader.GetDBInt("ticket_id"),
								Symptoms = reader.GetDBString("symptoms"),
								OtherSymptom = reader.GetDBString("other_symptom"),
								Duration = TimeSpan.FromSeconds(reader.GetDBInt("duration_seconds"))
							};
							data.Tickets.Add(ticket);
						}
					}
				}
				conn.Close();
			}
			return data;
		}

		private void Populate()
		{
			lblAsset.Text = _ccReviewData.Asset;
			lblSubmitInfo.Text = string.Format("Submitted {0:yyyy-MM-dd HH:mm:ss}{1}by {2}", _cc.Submitted, Environment.NewLine, ClassUser.GetFirstL(_cc.User_ID));
			txtSymptom.Visible = _cc.Symptom_ID.HasValue;
			txtSymptom.Text = _cc.Symptom_ID.HasValue ? ClassTicket_Symptom.GetByID(_cc.Symptom_ID.Value).Symptom : string.Empty;
			olvTickets.SetObjects(_ccReviewData.Tickets);
			lblTicketQty.Text = string.Format("Open Tickets: {0}", _ccReviewData.Tickets.Count());
			pbCheckedImage.Image = ClassCameraCheck.GetImageForCameraCheck(_cc);
		}

		private void btnAssignTicket_Click(object sender, EventArgs e)
		{
			var selectedTicket = (CameraCheckReviewData.CameraCheckTicketData)olvTickets.SelectedObject;
			if (selectedTicket == null)
				return;

			AssignTicketToCameraCheck(selectedTicket.TicketID);
		}

		private void olvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var selectedTicket = (CameraCheckReviewData.CameraCheckTicketData)olvTickets.SelectedObject;
			if (selectedTicket == null)
				return;

			AssignTicketToCameraCheck(selectedTicket.TicketID);
		}

		private void btnRevert_Click(object sender, EventArgs e)
		{
			RevertFailedCameraCheck();
		}

		private void btnOpenNewTicket_Click(object sender, EventArgs e)
		{
			if (OpenNewTicket != null)
				OpenNewTicket(_cc, this);
		}

		private void olvTickets_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedTicket = olvTickets.SelectedObject;
			btnAssignTicket.Enabled = selectedTicket != null;
		}

		private void RevertFailedCameraCheck()
		{
			if (GS.Settings.LoggedOnUser.UserType == ClassUser.USERTYPE_STANDARD)
			{
				using (var overrideForm = new FormSupervisor_Override())
				{
					overrideForm.SetMainText("Supervisor required to revert failed camera to pass.");
					overrideForm.SetPermitButtonText("Allow");
					overrideForm.ShowDialog(this);

					if (overrideForm.Result != FormSupervisor_Override.VerificationResultEnum.Permit)
						return;
				}
			}
			_cc.Revert();
			Enabled = false;
			if (CameraCheckReverted != null)
				CameraCheckReverted(this);
		}

		private void AssignTicketToCameraCheck(int ticketID)
		{
			_cc.Cover(ticketID, false);
			Enabled = false;
			if (CameraCheckCovered != null)
				CameraCheckCovered(this);
		}
        #endregion

        #region Public Methods
        #endregion

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ClassAsset _asset = ClassAsset.GetByID(_cc.Asset_ID);
            Process.Start($"{GS.Settings.DashboardWebURL}{_asset.AssetName}");
        }
    }
}