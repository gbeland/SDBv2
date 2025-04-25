using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.Tech;
using SDB.Interfaces;

namespace SDB.Classes.RMA
{
	/// <summary>
	/// This is the RMA class as of version 1.6 +
	/// </summary>
	public partial class ClassRMA : ISupportsJournal
	{
		#region RMA Status Objects
		private static readonly RmaStatusObject _RMA_STATUS_UNRECEIVED = new RmaStatusObject
		                                                               {
			                                                               Foreground = Color.DimGray,
			                                                               Background = SystemColors.Window,
			                                                               Status = "Unreceived",
			                                                               Description = "No assemblies have been received."
		                                                               };

		private static readonly RmaStatusObject _RMA_STATUS_UNSHIPPED_APR = new RmaStatusObject
		                                                                    {
			                                                                    Foreground = Color.DarkSlateBlue,
			                                                                    Background = SystemColors.Window,
			                                                                    Status = "Unshipped APR",
			                                                                    Description = "No shipments yet for APR RMA."
		                                                                    };

		private static readonly RmaStatusObject _RMA_STATUS_RECEIVED = new RmaStatusObject
		                                                             {
			                                                             Foreground = Color.Black,
			                                                             Background = SystemColors.Window,
			                                                             Status = "Received",
			                                                             Description = "At least one assembly has been recieved."
		                                                             };

		private static readonly RmaStatusObject _RMA_STATUS_IN_PROGRESS = new RmaStatusObject
		                                                                {
			                                                                Foreground = Color.FromArgb(192, 64, 0),
			                                                                Background = Color.LightGoldenrodYellow,
			                                                                Status = "In Progress",
			                                                                Description = "At least one assembly has started repairs."
		                                                                };

		private static readonly RmaStatusObject _RMA_STATUS_PENDING = new RmaStatusObject
		                                                            {
			                                                            Foreground = Color.DarkSlateGray,
			                                                            Background = Color.LightGray,
			                                                            Status = "Pending",
			                                                            Description = "The RMA is on hold."
		                                                            };

		private static readonly RmaStatusObject _RMA_STATUS_COMPLETED = new RmaStatusObject
		                                                              {
			                                                              Foreground = Color.DarkBlue,
			                                                              Background = Color.LightBlue,
			                                                              Status = "Completed",
			                                                              Description = "All assemblies have been repaired."
		                                                              };

		/// <summary>
		/// Same as unshipped.
		/// </summary>
		private static readonly RmaStatusObject _RMA_STATUS_FINALIZED = new RmaStatusObject
		                                                              {
			                                                              Foreground = Color.FromArgb(16, 164, 16),
			                                                              Background = SystemColors.Window,
			                                                              Status = "Finalized",
			                                                              Description = "All assemblies repaired and root cause assigned."
		                                                              };

		private static readonly RmaStatusObject _RMA_STATUS_CLOSED = new RmaStatusObject
		                                                           {
			                                                           Foreground = Color.DarkGreen,
			                                                           Background = Color.FromArgb(224, 255, 224),
			                                                           Status = "Closed",
			                                                           Description = "All assemblies repaired, finalized, and shipped."
		                                                           };

		private static readonly RmaStatusObject _RMA_STATUS_EXPIRED = new RmaStatusObject
		                                                              {
			                                                              Foreground = Color.LightGray,
			                                                              Background = Color.FromArgb(64, 64, 64),
			                                                              Status = "Expired",
			                                                              Description = "No assemblies were received before time limit."
		                                                              };

		private static readonly RmaStatusObject _RMA_STATUS_DELETED = new RmaStatusObject
		                                                            {
			                                                            Foreground = Color.DarkMagenta,
			                                                            Background = Color.LightPink,
			                                                            Status = "Deleted",
			                                                            Description = "The RMA has been marked deleted."
		                                                            };
		#endregion

		public static readonly TimeSpan MAX_JOURNAL_EXPIRATION = TimeSpan.FromDays(14);
		public const int UNRECEIVED_RMA_WARN_OVER_DAYS = 30;
		public const int UNRECEIVED_RMA_EXPIRE_AFTER_DAYS = 90;

		public int ID { get; set; }
		public int TicketID { get; set; }
		public int AssetID { get; set; }
		public int TechID { get; set; }
		public DateTime Creation_Date { get; set; }
		public int? Creation_UserID { get; set; }
		public string JobNumber { get; set; }
		public string PONumber { get; set; }
		public int? LegacyRMANumber { get; set; }
		public string Notes { get; set; }
		public bool IsAPR { get; set; }
		public bool IsHot { get; set; }
        
		/// <summary>
		/// Accounting done
		/// </summary>
		public bool IsAccountingDone { get; set; }
		public bool IsPending { get; set; }
		public bool HasComputer { get; set; }
		public bool HasNonSystemInfo { get; set; }
		public bool HasShipments { get; set; }
		public string Pending_Type { get; set; }
		public string Pending_Reason { get; set; }
		public DateTime? Completed_Date { get; set; }
		public DateTime? Finalized_Date { get; set; }
		public bool IsExpired { get; set; }
		public bool IsDeleted { get; set; }

		// Optional fields that aren't normally part of this class
		public string AssetName { get; set; }
		public string TechName { get; set; }
		public string Creation_UserName { get; set; }
		public int AssemblyQty { get; set; }
		public DateTime? FirstAssemblyReceived { get; set; }
		public int Assemblies_ReceivedOrDiscarded_Qty { get; set; }
		public int Assemblies_RepairStarted_Qty { get; set; }
		public int Assemblies_RepairEnded_Qty { get; set; }
		/// <summary>
		/// Used in lists to show brief assembly list
		/// </summary>
		public string AssemblyTooltip { get; set; }

		/// <summary>
		/// The name of the user who most recently did repair work on any assembly.
		/// </summary>
		public string MostRecentRepair_UserName { get; set; }

		/// <summary>
		/// True if at least one assembly has been recieved.
		/// </summary>
		public bool IsReceived => FirstAssemblyReceived.HasValue;

		/// <summary>
		/// True if all assemblies have been received or discarded.
		/// </summary>
		public bool IsFullyReceivedOrDiscarded => Assemblies_ReceivedOrDiscarded_Qty == AssemblyQty;

		/// <summary>
		/// True if all assemblies have been repaired.
		/// </summary>
		public bool IsCompleted => Completed_Date.HasValue;

		/// <summary>
		/// True if all assemblies have been repaired and root cause assigned.
		/// </summary>
		public bool IsFinalized => Finalized_Date.HasValue;

		public ClassJournal.JournalTableInfo JournalTableInfo =>
			new ClassJournal.JournalTableInfo
			{
				TableName = "rma_journal",
				LinkerName = "rma_id"
			};

		public struct RmaStatusObject
		{
			public Color Foreground { get; set; }
			public Color Background { get; set; }
			public string Status { get; set; }
			public string Description { get; set; }
		}

		public RmaStatusObject Status
		{
			get
			{
				if (IsDeleted)
					return _RMA_STATUS_DELETED;

				if (IsPending)
					return _RMA_STATUS_PENDING;

				if (IsAPR && !HasShipments)
					return _RMA_STATUS_UNSHIPPED_APR;

				if (IsExpired)
					return _RMA_STATUS_EXPIRED;

				if (IsFinalized && HasShipments)
					return _RMA_STATUS_CLOSED;

				if (IsFinalized && !HasShipments)
					return _RMA_STATUS_FINALIZED;

				if (IsCompleted)
					return _RMA_STATUS_COMPLETED;

				if (Assemblies_RepairStarted_Qty > 0)
					return _RMA_STATUS_IN_PROGRESS;

				if (Assemblies_ReceivedOrDiscarded_Qty > 0)
					return _RMA_STATUS_RECEIVED;

				return _RMA_STATUS_UNRECEIVED;
			}
		}

		#region Base Query
		private const string _RMA_BASE_QUERY =
			@"SELECT
				r.id, r.ticket_id, r.asset_id, a.asset asset_name, r.tech_id, h.tech tech_name, r.creation_date,
				r.creation_user, CONCAT(u.firstname, LEFT(u.lastname,1)) creation_username,
				r.job_number, r.po_number, r.legacy_rma, r.notes, r.flag_apr, r.flag_hot, r.flag_accounting,
				r.flag_pending, r.flag_computer, r.pending_type, r.pending_reason,
				r.completed_date, r.finalized_date, r.expired, r.deleted,
					(CASE WHEN EXISTS (
						SELECT 1 FROM rma_journal j
						WHERE j.system_msg IS FALSE
						AND j.rma_id = r.id)
					THEN TRUE ELSE FALSE END) AS flag_nonsystemjournal,
					(CASE WHEN EXISTS (
						SELECT 1 FROM shipment_inventory si
						WHERE si.rma_id = r.id)
					THEN TRUE ELSE FALSE END) AS flag_hasshipments,
				COUNT(ra.id) assembly_qty,
				SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
				IF(SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) > 0, 1, 0) any_received_or_discarded,
				SUM(IF(ra.repair_start_date IS NOT NULL, 1, 0)) repair_start_qty,
				SUM(IF(ra.repair_end_date IS NOT NULL, 1, 0)) repair_end_qty,
				MIN(ra.receive_date) first_received,
				CONCAT(repair_users.firstname, LEFT(repair_users.lastname, 1)) last_repaired_by
			FROM rma r
				JOIN assets a
					USE INDEX (PRIMARY)
					ON r.asset_id = a.id
				JOIN techs h ON r.tech_id = h.id
				LEFT JOIN rma_assemblies ra ON ra.rma_id = r.id
				LEFT JOIN users u ON r.creation_user = u.userid
				LEFT JOIN
					(SELECT MAX(rl.repair_start) last_repair_start, rl.id, ra.rma_id
					FROM rma_assemblies ra
						JOIN rma_assembly_repairlog rl ON rl.rma_assembly_id = ra.id
					GROUP BY ra.rma_id
					) last_repair ON last_repair.rma_id = r.id
				LEFT JOIN rma_assembly_repairlog rl2 ON rl2.id = last_repair.id
				LEFT JOIN users repair_users ON rl2.user_id = repair_users.userid
			";
		#endregion

		public static void AddNew(ref ClassRMA newRMA)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rma
							(ticket_id, asset_id, tech_id,
							creation_date, creation_user,
							job_number, po_number, legacy_rma, notes,
							flag_apr, flag_hot, flag_computer)
						VALUES
							(@TicketID, @AssetID, @TechID,
							NOW(), @CreationUserID,
							@JobNumber, @PONumber, @LegacyRMA, @Notes,
							@IsAPR, @IsHot, @HasComputer);";
					cmd.Parameters.AddWithValue("TicketID", newRMA.TicketID);
					cmd.Parameters.AddWithValue("AssetID", newRMA.AssetID);
					cmd.Parameters.AddWithValue("TechID", newRMA.TechID);
					cmd.Parameters.AddWithValue("CreationUserID", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("JobNumber", newRMA.JobNumber);
					cmd.Parameters.AddWithValue("PONumber", newRMA.PONumber);
					cmd.Parameters.AddWithValue("LegacyRMA", newRMA.LegacyRMANumber);
					cmd.Parameters.AddWithValue("Notes", newRMA.Notes);
					cmd.Parameters.AddWithValue("IsAPR", newRMA.IsAPR);
					cmd.Parameters.AddWithValue("IsHot", newRMA.IsHot);
					cmd.Parameters.AddWithValue("HasComputer", newRMA.HasComputer);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					newRMA.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.RMA, newRMA.ID, string.Format("for {0} to {1}", newRMA.AssetName, newRMA.TechName));
		}

		public static void Update(ClassRMA rma)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma
						SET ticket_id = @TicketID,
						asset_id = @AssetID,
						tech_id = @TechID,
						job_number = @JobNumber,
						po_number = @PONumber,
						legacy_rma = @LegacyRMA,
						notes = @Notes,
						flag_apr = @APR,
						flag_hot = @Hot,
						flag_pending = @Pending,
						flag_computer = @HasComputer,
						pending_reason = @PendingReason
						WHERE id = @RMAID;";
					cmd.Parameters.AddWithValue("RMAID", rma.ID);
					cmd.Parameters.AddWithValue("TicketID", rma.TicketID);
					cmd.Parameters.AddWithValue("AssetID", rma.AssetID);
					cmd.Parameters.AddWithValue("TechID", rma.TechID);
					cmd.Parameters.AddWithValue("JobNumber", rma.JobNumber);
					cmd.Parameters.AddWithValue("PONumber", rma.PONumber);
					cmd.Parameters.AddWithValue("LegacyRMA", rma.LegacyRMANumber);
					cmd.Parameters.AddWithValue("Notes", rma.Notes);
					cmd.Parameters.AddWithValue("APR", rma.IsAPR);
					cmd.Parameters.AddWithValue("Hot", rma.IsHot);
					cmd.Parameters.AddWithValue("HasComputer", rma.HasComputer);
					cmd.Parameters.AddWithValue("Pending", rma.IsPending);
					cmd.Parameters.AddWithValue("PendingType", rma.Pending_Type);
					cmd.Parameters.AddWithValue("PendingReason", rma.Pending_Reason);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.RMA, rma.ID, string.Format("for {0} to {1}", rma.AssetName, rma.TechName));
		}

		/// <summary>
		/// Marks RMA as deleted.
		/// </summary>
		public void Delete(string deletedReason)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Delete any unfinished repair sessions for RMA first
					cmd.CommandText =
						@"DELETE rarl
							FROM rma_assembly_repairlog rarl
								JOIN rma_assemblies ra on rarl.rma_assembly_id = ra.id
								JOIN rma r ON ra.rma_id = r.id
							WHERE rarl.repair_end IS NULL
							AND r.id = @rmaID;";
					cmd.Parameters.AddWithValue("rmaID", ID);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE rma
							SET deleted = TRUE,
							deleted_reason = @deletedReason,
							deleted_date = NOW()
						WHERE id = @rmaID;";
					cmd.Parameters.AddWithValue("rmaID", ID);
					cmd.Parameters.AddWithValue("deletedReason", deletedReason.Truncate(128));
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.RMA, ID, string.Format("for {0} to {1}", AssetName, TechName));
		}

		/// <summary>
		/// Restores RMA from being marked as deleted.
		/// </summary>
		public void Restore()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma
							SET deleted = FALSE,
							deleted_reason = '',
							deleted_date = NULL
						WHERE id = @rma_id;";
					cmd.Parameters.AddWithValue("rma_id", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Restore, ClassEventLog.ObjectTypeEnum.RMA, ID, string.Format("for {0} to {1}", AssetName, TechName));
		}

		/// <summary>
		/// Assigns the RMA to new specified tech.
		/// </summary>
		public void ChangeTech(ClassTech newTech)
		{
			var oldTechName = ClassTech.GetName(TechID);
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma SET	
						tech_id = @techID
						WHERE id = @rmaID;";
					cmd.Parameters.AddWithValue("rmaID", ID);
					cmd.Parameters.AddWithValue("techID", newTech.ID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			TechName = newTech.TechName;
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.RMA, ID, string.Format("Assignment changed from {0} to {1}", oldTechName, newTech.TechName));
		}

		/// <summary>
		/// Gets the specified RMA.
		/// </summary>
		public static ClassRMA GetRMA(int rmaID)
		{
			var rma = new ClassRMA();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + @"WHERE r.id = @RMAID ORDER BY r.id ASC;";
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							rma = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return rma;
		}

		/// <summary>
		/// Searches for RMAs based on both RMA number and Legacy RMA Number
		/// </summary>
		public static IEnumerable<ClassRMA> GetByNumberIncludingLegacy(int rmaID, bool includeDeleted = false)
		{
			var rmas = new List<ClassRMA>();
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE (r.id = @rmaID OR r.legacy_rma = @rmaID)
							{deletedCondition}
						GROUP BY r.id ASC;";
					cmd.Parameters.AddWithValue("rmaID", rmaID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								rmas.Add(rma);
						}
				}
				conn.Close();
			}
			return rmas;
		}

		/// <summary>
		/// Gets non-legacy RMA based on ID.
		/// </summary>
		public static ClassRMA GetByID(int rmaID, bool includeDeleted = false)
		{
			ClassRMA rma = null;
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE r.id = @rmaID
						{deletedCondition}
						GROUP BY r.id ASC;";
					cmd.Parameters.AddWithValue("rmaID", rmaID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							rma = GetFromReader(reader);
				}
				conn.Close();
			}
			return rma;
		}

		/// <summary>
		/// Gets RMAs associated with specified asset.
		/// Expired and deleted RMAs are only included if specified.
		/// </summary>
		public static IEnumerable<ClassRMA> GetByAsset(int assetID, bool includeExpired = false, bool includeDeleted = false)
		{
			var assetRmas = new List<ClassRMA>();
			var expiredCondition = includeExpired ? string.Empty : "AND r.expired IS FALSE";
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE r.asset_id = @assetID
							{expiredCondition}
							{deletedCondition}
						GROUP BY r.id ASC;";
					cmd.Parameters.AddWithValue("assetID", assetID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								assetRmas.Add(rma);
						}
				}
				conn.Close();
			}
			return assetRmas;
		}

		/// <summary>
		/// Gets RMAs associated with specified tech.
		/// Expired and deleted RMAs are only included if specified.
		/// </summary>
		public static IEnumerable<ClassRMA> GetByTech(int techID, bool includeExpired = false, bool includeDeleted = false)
		{
			var techRmas = new List<ClassRMA>();
			var expiredCondition = includeExpired ? string.Empty : "AND r.expired IS FALSE";
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE r.tech_id = @techID
							{expiredCondition}
							{deletedCondition}
						GROUP BY r.id ASC;";
					cmd.Parameters.AddWithValue("techID", techID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								techRmas.Add(rma);
						}
				}
				conn.Close();
			}
			return techRmas;
		}

		/// <summary>
		/// Gets RMAs associated with specified ticket.
		/// Expired and deleted RMAs are only included if specified.
		/// </summary>
		public static IEnumerable<ClassRMA> GetByTicket(int ticketID, bool includeExpired = false, bool includeDeleted = false)
		{
			var ticketRmas = new List<ClassRMA>();
			var expiredCondition = includeExpired ? string.Empty : "AND r.expired IS FALSE";
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE r.ticket_id = @ticketID
							{expiredCondition}
							{deletedCondition}
						GROUP BY r.id ASC;";
					cmd.Parameters.AddWithValue("ticketID", ticketID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								ticketRmas.Add(rma);
						}
				}
				conn.Close();
			}
			return ticketRmas;
		}

		/// <summary>
		/// Gets RMAs assigned to assets belonging to specified customer (all markets).
		/// Expired and deleted RMAs are only included if specified.
		/// </summary>
		public static IEnumerable<ClassRMA> GetByCustomer(int customerID, bool includeExpired = false, bool includeDeleted = false)
		{
			var customerRmas = new List<ClassRMA>();
			var expiredCondition = includeExpired ? string.Empty : "AND r.expired IS FALSE";
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Get list of RMA ID's first
					var customerRmaIds = new List<int>();
					cmd.CommandText =
						$@"SELECT r.id
						FROM rma r
							JOIN assets a ON r.asset_id = a.id
							JOIN markets m ON a.market_id = m.id
						WHERE m.customer_id = @CustomerID
							{expiredCondition}
							{deletedCondition};";
					cmd.Parameters.AddWithValue("CustomerID", customerID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							customerRmaIds.Add(reader.GetDBInt("id"));

					if (customerRmaIds.Count == 0)
						return customerRmas;

					// Get RMAs for above IDs
					cmd.Parameters.Clear();
					cmd.CommandText = _RMA_BASE_QUERY + string.Format(
						@"WHERE r.id IN ({0})
						GROUP BY r.id ASC;", string.Join(",", customerRmaIds.ToArray()));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								customerRmas.Add(rma);
						}

				}
				conn.Close();
			}
			return customerRmas;
		}

		/// <summary>
		/// Gets RMAs assigned to assets belonging to specified market.
		/// Expired and deleted RMAs are only included if specified.
		/// </summary>
		public static IEnumerable<ClassRMA> GetByMarket(int marketID, bool includeExpired = false, bool includeDeleted = false)
		{
			var marketRmas = new List<ClassRMA>();
			var expiredCondition = includeExpired ? string.Empty : "AND r.expired IS FALSE";
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Get list of RMA ID's first
					var marketRmaIds = new List<int>();
					cmd.CommandText =
						$@"SELECT r.id
						FROM rma r
							JOIN assets a ON r.asset_id = a.id
							JOIN markets m ON a.market_id = m.id
						WHERE m.id = @marketID
							{expiredCondition}
							{deletedCondition};";
					cmd.Parameters.AddWithValue("marketID", marketID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							marketRmaIds.Add(reader.GetDBInt("id"));

					if (marketRmaIds.Count == 0)
						return marketRmas;

					// Get RMAs for above IDs
					cmd.Parameters.Clear();
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.id IN ({string.Join(",", marketRmaIds.ToArray())})
						GROUP BY r.id ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								marketRmas.Add(rma);
						}
				}
				conn.Close();
			}
			return marketRmas;
		}

		/// <summary>
		/// Gets RMAs created in the specified date range.
		/// Expired and deleted RMAs are only included if specified.
		/// </summary>
		public static IEnumerable<ClassRMA> GetByDateRange(DateTime rangeStart, DateTime rangeEnd, bool includeExpired = false, bool includeDeleted = false)
		{
			var inRangeList = new List<ClassRMA>();
			var expiredCondition = includeExpired ? string.Empty : "AND r.expired IS FALSE";
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE (r.creation_date >= @DateFrom AND r.creation_date <= @DateTo)
							{expiredCondition}
							{deletedCondition}
						GROUP BY r.id ASC;";
					cmd.Parameters.AddWithValue("DateFrom", rangeStart);
					cmd.Parameters.AddWithValue("DateTo", rangeEnd);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null) inRangeList.Add(rma);
						}
				}
				conn.Close();
			}
			return inRangeList;
		}

		/// <summary>
		/// Gets RMAs that contain the specified assembly type.
		/// Expired and deleted RMAs are only included if specified.
		/// </summary>
		public static IEnumerable<ClassRMA> GetByAssemblyType(int assemblyTypeID, bool includeExpired = false, bool includeDeleted = false)
		{
			var assyRmas = new List<ClassRMA>();
			var expiredCondition = includeExpired ? string.Empty : "AND r.expired IS FALSE";
			var deletedCondition = includeDeleted ? string.Empty : "AND r.deleted IS FALSE";
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE ra.assembly_type = @assemblyTypeID
							{expiredCondition}
							{deletedCondition}
						GROUP BY r.id ASC;";
					cmd.Parameters.AddWithValue("assemblyTypeID", assemblyTypeID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								assyRmas.Add(rma);
						}
				}
				conn.Close();
			}
			return assyRmas;
		}

		/// <summary>
		/// Gets all incomplete RMAs for which no assemblies have been recieved.
		/// Does not include deleted, expired, or pending.
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetUnreceived(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountUnreceived();

			var unreceivedRmas = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
					    $@"WHERE r.completed_date IS NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
						GROUP BY r.id ASC
							HAVING received_or_discarded_qty = 0
							OR
							(
								received_or_discarded_qty < assembly_qty
								AND
								repair_end_qty = received_or_discarded_qty
							)
						ORDER BY r.flag_hot DESC, any_received_or_discarded DESC, first_received ASC, r.creation_date ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								unreceivedRmas.Add(rma);
						}
				}
				conn.Close();
			}
			return unreceivedRmas;
		}

		/// <summary>
		/// Get count of incomplete RMAs for which no assemblies have been received.
		/// Does not include deleted, expired, or pending.
		/// </summary>
		private static int CountUnreceived()
		{
			int unreceivedRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(*)
						FROM (
							SELECT
								COUNT(ra.id) assembly_qty,
								SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
								SUM(IF(ra.repair_start_date IS NOT NULL, 1, 0)) repair_start_qty,
								SUM(IF(ra.repair_end_date IS NOT NULL, 1, 0)) repair_end_qty
							FROM rma r
							LEFT JOIN rma_assemblies ra ON ra.rma_id = r.id
							WHERE r.completed_date IS NULL
								AND r.expired IS FALSE
								AND r.deleted IS FALSE
								AND r.flag_pending IS FALSE
							GROUP BY r.id ASC
								HAVING received_or_discarded_qty = 0
								OR (received_or_discarded_qty < assembly_qty AND (repair_end_qty = received_or_discarded_qty))
							) AS `x`;";
					unreceivedRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return unreceivedRmaQty;
		}

		/// <summary>
		/// Gets all incomplete RMAs which are 1) APR, and 2) Have no shipments
		/// Does not include expired or deleted.
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetUnshippedAPR(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountUnshippedAPR();

			var unshippedAPRList = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.completed_date IS NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
							AND r.flag_apr IS TRUE
						GROUP BY r.id ASC
						HAVING flag_hasshipments IS FALSE
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rma = GetFromReader(reader);
							if (rma != null)
								unshippedAPRList.Add(rma);
						}
				}
				conn.Close();
			}
			return unshippedAPRList;
		}

		/// <summary>
		/// Get count of incompleted RMAs which are 1) APR, and 2) Have no shipments.
		/// Does not include expired or deleted.
		/// </summary>
		private static int CountUnshippedAPR()
		{
			int unshippedAprRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT SUM(
							(CASE WHEN NOT EXISTS (
								SELECT 1 FROM shipment_inventory si
								WHERE si.rma_id = r.id)
							THEN TRUE ELSE FALSE END)) AS unshipped_rma_qty
						FROM rma r
						WHERE r.completed_date IS NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
							AND r.flag_apr IS TRUE;";
					unshippedAprRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return unshippedAprRmaQty;
		}

		/// <summary>
		/// Gets all incomplete RMAs for which we have received at least one assembly. Omits RMAs on which repairs have begun.
		/// Does not include expired or deleted.
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetReceived(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountReceived();

			var receivedRmAs = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.completed_date IS NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
						GROUP BY r.id ASC
						HAVING received_or_discarded_qty > 0
							AND repair_start_qty = repair_end_qty
						ORDER BY r.flag_hot DESC, first_received ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								receivedRmAs.Add(r);
						}
				}
				conn.Close();
			}
			return receivedRmAs;
		}

		/// <summary>
		/// Counts RMAs for which we have received at least one assembly. Omits RMAs on which repairs have begun.
		/// Does not include expired or deleted.
		/// </summary>
		private static int CountReceived()
		{
			int receivedRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(*)
						FROM (
							SELECT
								COUNT(ra.id) assembly_qty,
								SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
								SUM(IF(ra.repair_start_date IS NOT NULL, 1, 0)) repair_start_qty,
								SUM(IF(ra.repair_end_date IS NOT NULL, 1, 0)) repair_end_qty
							FROM rma r
							LEFT JOIN rma_assemblies ra ON ra.rma_id = r.id
							WHERE r.completed_date IS NULL
								AND r.expired IS FALSE
								AND r.deleted IS FALSE
								AND r.flag_pending IS FALSE
							GROUP BY r.id ASC
								HAVING received_or_discarded_qty > 0
								AND repair_start_qty = repair_end_qty
							) AS `x`;";
					receivedRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return receivedRmaQty;
		}

		/// <summary>
		/// Gets all incomplete RMAs where repair has started on at least one assembly.
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetInProgress(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountInProgress();

			var inProgressRmAs = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.completed_date IS NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
						GROUP BY r.id ASC
						HAVING received_or_discarded_qty > 0
							AND repair_start_qty > repair_end_qty
						ORDER BY r.flag_hot DESC, first_received ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								inProgressRmAs.Add(r);
						}
				}
				conn.Close();
			}
			return inProgressRmAs;
		}

		/// <summary>
		/// Counts incomplete RMAs where repair has started on at least one assembly.
		/// Does not include expired or deleted.
		/// </summary>
		private static int CountInProgress()
		{
			int inProgressRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(*)
						FROM (
							SELECT
								COUNT(ra.id) assembly_qty,
								SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
								SUM(IF(ra.repair_start_date IS NOT NULL, 1, 0)) repair_start_qty,
								SUM(IF(ra.repair_end_date IS NOT NULL, 1, 0)) repair_end_qty
							FROM rma r
							LEFT JOIN rma_assemblies ra ON ra.rma_id = r.id
							WHERE r.completed_date IS NULL
								AND r.expired IS FALSE
								AND r.deleted IS FALSE
								AND r.flag_pending IS FALSE
							GROUP BY r.id ASC
								HAVING received_or_discarded_qty > 0
								AND repair_start_qty > repair_end_qty
							) AS `x`;";
					inProgressRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return inProgressRmaQty;
		}

		/// <summary>
		/// Gets all incomplete RMAs which are pending.
		/// Excludes deleted and expired.
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetPending(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountPending();

			var pendingRmAs = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.completed_date IS NULL
							AND r.deleted IS FALSE
							AND r.flag_pending IS TRUE
						GROUP BY r.id ASC
						ORDER BY r.flag_hot DESC, r.id ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								pendingRmAs.Add(r);
						}
				}
				conn.Close();
			}
			return pendingRmAs;
		}

		/// <summary>
		/// Counts pending RMAs.
		/// Does not include expired or deleted.
		/// </summary>
		private static int CountPending()
		{
			int pendingRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(*)
							FROM rma r
							WHERE r.completed_date IS NULL
								AND r.expired IS FALSE
								AND r.deleted IS FALSE
								AND r.flag_pending IS TRUE;";
					pendingRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return pendingRmaQty;
		}

		/// <summary>
		/// Get RMAs that are completed but not finalized. (All repairs completed, but supervisor has not finalized.)
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetCompleted(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountCompleted();

			var completedRmAs = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.completed_date IS NOT NULL
							AND r.finalized_date IS NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
						GROUP BY r.id ASC
						ORDER BY r.flag_hot DESC, r.completed_date ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								completedRmAs.Add(r);
						}
				}
				conn.Close();
			}
			return completedRmAs;
		}

		/// <summary>
		/// Counts completed RMAs.
		/// Does not include expired or deleted.
		/// </summary>
		private static int CountCompleted()
		{
			int completedRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(*)
							FROM rma r
							WHERE r.completed_date IS NOT NULL
								AND r.finalized_date IS NULL
								AND r.expired IS FALSE
								AND r.deleted IS FALSE
								AND r.flag_pending IS FALSE;";
					completedRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return completedRmaQty;
		}

		/// <summary>
		/// Gets RMAs that are completed (fully repaired), finalized, but have no shipments attached.
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetUnshipped(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountUnshipped();

			var unshippedRmas = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
						$@"WHERE r.completed_date IS NOT NULL
							AND r.finalized_date IS NOT NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
						GROUP BY r.id
						HAVING flag_hasshipments IS FALSE
						ORDER BY r.flag_hot DESC, r.id ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								unshippedRmas.Add(r);
						}
				}

				conn.Close();
			}

			return unshippedRmas;
		}

		/// <summary>
		/// Counts RMAs that are completed (fully repaired) and finalized (closed), but have no shipments attached.
		/// Does not include expired or deleted.
		/// </summary>
		private static int CountUnshipped()
		{
			int unshippedRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT SUM(
							(CASE WHEN NOT EXISTS (
								SELECT 1 FROM shipment_inventory si
								WHERE si.rma_id = r.id)
							THEN TRUE ELSE FALSE END)) AS unshipped_rma_qty
						FROM rma r
						WHERE r.completed_date IS NOT NULL
							AND r.finalized_date IS NOT NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE;";
					unshippedRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return unshippedRmaQty;
		}

		/// <summary>
		/// Get RMAs that are completed (fully repaired) and finalized (closed).
		/// Does not include expired or deleted.
		/// </summary>
		/// <param name="pageOffset">Which page of results to fetch; null/zero for first page.</param>
		/// <param name="maxResults">Maximum number of results to fetch.</param>
		/// <param name="totalQty">Total number of RMAs matching this criteria.</param>
		public static IEnumerable<ClassRMA> GetClosed(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountClosed();

			var finalizedRmas = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY +
					    $@"WHERE r.completed_date IS NOT NULL
							AND r.finalized_date IS NOT NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
						GROUP BY r.id
						HAVING flag_hasshipments IS TRUE
						ORDER BY r.id ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								finalizedRmas.Add(r);
						}
				}
				conn.Close();
			}
			return finalizedRmas;
		}

		/// <summary>
		/// Counts RMAs that are completed (fully repaired), finalized (closed), and have shipments attached.
		/// Does not include expired or deleted.
		/// </summary>
		private static int CountClosed()
		{
			int finalizedRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT SUM(
							(CASE WHEN EXISTS (
								SELECT 1 FROM shipment_inventory si
								WHERE si.rma_id = r.id)
							THEN TRUE ELSE FALSE END)) AS shipped_rma_qty
						FROM rma r
						WHERE r.completed_date IS NOT NULL
							AND r.finalized_date IS NOT NULL
							AND r.expired IS FALSE
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE;";
					finalizedRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return finalizedRmaQty;
		}

		public static IEnumerable<ClassRMA> GetExpired(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountExpired();

			var expiredRmas = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.expired IS TRUE
							AND r.deleted IS FALSE
						GROUP BY r.id
						ORDER BY r.id ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								expiredRmas.Add(r);
						}
				}
				conn.Close();
			}
			return expiredRmas;
		}

		/// <summary>
		/// Counts expired RMAs.
		/// Does not include deleted.
		/// </summary>
		private static int CountExpired()
		{
			int expiredRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(*)
							FROM rma r
							WHERE r.expired IS TRUE
							AND r.deleted IS FALSE;";
					expiredRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return expiredRmaQty;
		}

		/// <summary>
		/// Gets all deleted RMAs.
		/// </summary>
		public static IEnumerable<ClassRMA> GetDeleted(int? pageOffset, int maxResults, out int totalQty)
		{
			totalQty = CountDeleted();

			var deletedRmas = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.deleted IS TRUE
						GROUP BY r.id
						ORDER BY r.id ASC
						LIMIT {(pageOffset.HasValue ? $"{pageOffset.Value * maxResults}," : string.Empty)}{maxResults};";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								deletedRmas.Add(r);
						}
				}
				conn.Close();
			}
			return deletedRmas;
		}

		/// <summary>
		/// Counts deleted RMAs.
		/// </summary>
		private static int CountDeleted()
		{
			int deletedRmaQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT COUNT(*)
							FROM rma r
							WHERE r.deleted IS TRUE;";
					deletedRmaQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return deletedRmaQty;
		}

		private static ClassRMA GetFromReader(MySqlDataReader reader)
		{
			var rma = new ClassRMA();
			var id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;
			rma.ID = id.Value;
			rma.TicketID = reader.GetDBInt("ticket_id");
			rma.AssetID = reader.GetDBInt("asset_id");
			rma.TechID = reader.GetDBInt("tech_id");
			rma.Creation_Date = reader.GetDBDateTime("creation_date");
			rma.Creation_UserID = reader.GetDBInt_Null("creation_user");
			rma.JobNumber = reader.GetDBString("job_number");
			rma.PONumber = reader.GetDBString("po_number");
			rma.LegacyRMANumber = reader.GetDBInt_Null("legacy_rma");
			rma.Notes = reader.GetDBString("notes");
			rma.IsAPR = reader.GetDBBool("flag_apr");
			rma.IsHot = reader.GetDBBool("flag_hot");
			rma.IsAccountingDone = reader.GetDBBool("flag_accounting");
			rma.IsPending = reader.GetDBBool("flag_pending");
			rma.HasComputer = reader.GetDBBool("flag_computer");
			rma.HasNonSystemInfo = !string.IsNullOrEmpty(rma.Notes) || reader.GetDBBool("flag_nonsystemjournal");
			rma.HasShipments = reader.GetDBBool("flag_hasshipments");
			rma.Pending_Type = reader.GetDBString("pending_type");
			rma.Pending_Reason = reader.GetDBString("pending_reason");
			rma.Completed_Date = reader.GetDBDateTime_Null("completed_date");
			rma.Finalized_Date = reader.GetDBDateTime_Null("finalized_date");
			rma.IsExpired = reader.GetDBBool("expired");
			rma.IsDeleted = reader.GetDBBool("deleted");

			// Optional fields
			rma.AssetName = reader.GetDBString("asset_name");
			rma.Creation_UserName = reader.GetDBString("creation_username");
			rma.TechName = reader.GetDBString("tech_name");
			rma.AssemblyQty = reader.GetDBInt("assembly_qty");
			rma.Assemblies_ReceivedOrDiscarded_Qty = reader.GetDBInt("received_or_discarded_qty");
			rma.Assemblies_RepairStarted_Qty = reader.GetDBInt("repair_start_qty");
			rma.Assemblies_RepairEnded_Qty = reader.GetDBInt("repair_end_qty");
			rma.FirstAssemblyReceived = reader.GetDBDateTime_Null("first_received");
			rma.MostRecentRepair_UserName = reader.GetDBString("last_repaired_by");

			return rma;
		}

		/// <summary>
		/// Adds <paramref name="assembly"/> to the specified RMA <paramref name="rmaID"/>.
		/// Replaces "AddAssemblyType" because now RMA's require assemblies rather than assembly types.
		/// </summary>
		public static void AddAssembly(int rmaID, ClassRMAAssembly assembly)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rma_assemblies
						(rma_id, assembly_type, assembly_id, failure_type, failure_notes, failure_grid, discarded)
						VALUES
						(@RMAID, @AssemblyTypeID, @AssemblyID, @FailureType, @FailureNotes, @FailureGrid, @Discarded);";
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					cmd.Parameters.AddWithValue("AssemblyTypeID", assembly.AssemblyType_ID);
					cmd.Parameters.AddWithValue("AssemblyID", assembly.Assembly_ID);
					cmd.Parameters.AddWithValue("FailureType", assembly.Failure_Type);
					cmd.Parameters.AddWithValue("FailureNotes", assembly.Failure_Notes);
					cmd.Parameters.AddWithValue("FailureGrid", assembly.Failure_GridLocation);
					cmd.Parameters.AddWithValue("Discarded", assembly.Discarded);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Removes <paramref name="rmaAssembly"/>, all its repairs, and components used, from the database.
		/// </summary>
		public static void RemoveAssembly(ClassRMAAssembly rmaAssembly)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssembly.ID);

					cmd.CommandText =
						@"DELETE FROM rma_assemblies
						WHERE id = @RMAAssemblyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"DELETE FROM rma_assembly_components
						WHERE rma_assembly_id = @RMAAssemblyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"DELETE FROM rma_assembly_repairs
						WHERE rma_assembly_id = @RMAAssemblyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"DELETE FROM rma_assembly_repairlog
						WHERE rma_assembly_id = @RMAAssemblyID;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Marks the specified RMA assembly as received with the current date.
		/// Serial number is required.
		/// Assigns the received assembly to the specified Bin.
		/// Also marks the parent RMA as non-expired (in case it was expired).
		/// Duplicate serial numbers on the same RMA are not allowed.
		/// If assembly was marked as discarded, receiving it will change this status.
		/// </summary>
		public static void ReceiveAssembly(int rmaID, ClassRMAAssembly rmaAssembly, string serialNumber, ClassRMA_Bin bin)
		{
			if (bin == null)
				throw new ArgumentNullException(nameof(bin));

			if (!string.IsNullOrEmpty(serialNumber) || !string.IsNullOrEmpty(rmaAssembly.AssemblyTypeSerialNumberFormat))
			{
				var otherSerials = GetAssemblySerialNumbers(rmaID, rmaAssembly.ID);

				// TODO should duplicate RMA Assembly Serial Numbers be allowed if they are different Assembly Types?
				if (otherSerials.Any(s => s == serialNumber))
					throw new ArgumentException("Duplicate serial number in same RMA.");
			}

			rmaAssembly.SerialNumber = serialNumber;
			bin.AssignAssemblyToBin(rmaAssembly);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_assemblies ra
							JOIN rma r ON ra.rma_id = r.id
						SET
							r.expired = FALSE,
							ra.discarded = FALSE,
							ra.receive_date = NOW(),
							ra.serial_number = @SerialNumber,
							ra.receive_user = @ReceiveUser
						WHERE ra.id = @AssemblyID;";
					cmd.Parameters.AddWithValue("SerialNumber", serialNumber);
					cmd.Parameters.AddWithValue("ReceiveUser", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("AssemblyID", rmaAssembly.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			var eventString = $"Received assembly ID {rmaAssembly.ID} (S/N {serialNumber}) to Bin {bin.BinName}";
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.RMA, rmaID, eventString);
		}

		/// <summary>
		/// Marks the specified RMA assembly as discarded.
		/// Unreceives it if it was previously received.
		/// </summary>
		public static void DiscardAssembly(int rmaID, ClassRMAAssembly rmaAssembly)
		{
			if (rmaAssembly.Discarded)
				return;

			if (rmaAssembly.Receive_Date.HasValue)
				UnreceiveAssembly(rmaID, rmaAssembly.ID);

			rmaAssembly.Discarded = true;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_assemblies ra
							JOIN rma r ON ra.rma_id = r.id
						SET
							r.expired = FALSE,
							ra.discarded = TRUE
						WHERE ra.id = @AssemblyID;";
					cmd.Parameters.AddWithValue("AssemblyID", rmaAssembly.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Moves the specified RMA assembly into the specified bin, but leaves its receive date alone.
		/// Serial number is required.
		/// Also marks the parent RMA as non-expired (in case it was expired).
		/// Duplicate serial numbers on the same RMA are not allowed.
		/// </summary>
		public static void MigrateAssembly(int rmaID, ClassRMAAssembly rmaAssembly, string serialNumber, ClassRMA_Bin bin)
		{
			if (bin == null)
				throw new ArgumentNullException(nameof(bin));

			var otherSerials = GetAssemblySerialNumbers(rmaID, rmaAssembly.ID);
			if (otherSerials.Any(s => s == serialNumber))
				throw new ArgumentException("Duplicate serial number in same RMA.");

			rmaAssembly.SerialNumber = serialNumber;
			bin.AssignAssemblyToBin(rmaAssembly);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_assemblies ra
							JOIN rma r ON ra.rma_id = r.id
						SET
							r.expired = FALSE,
							ra.serial_number = @SerialNumber
						WHERE ra.id = @AssemblyID;";
					cmd.Parameters.AddWithValue("SerialNumber", serialNumber);
					cmd.Parameters.AddWithValue("AssemblyID", rmaAssembly.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			var eventString = $"Migrated assembly ID {rmaAssembly.ID} (S/N {serialNumber}) to Bin {bin.BinName}";
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.RMA, rmaID, eventString);
		}

		/// <summary>
		/// Disassociates RMA assembly from its bin and clears its Receive Date, Receive User, and Serial Number.
		/// </summary>
		public static void UnreceiveAssembly(int rmaID, int rmaAssemblyID)
		{
			var assemblyBin = ClassRMA_Bin.GetBinForAssembly(rmaAssemblyID);
			ClassRMA_Bin.UnassignAssemblyFromAnyBin(rmaAssemblyID);
			var serialNumber = string.Empty;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT serial_number
						FROM rma_assemblies
						WHERE id = @rmaAssemblyID;";
					cmd.Parameters.AddWithValue("rmaAssemblyID", rmaAssemblyID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							serialNumber = reader.GetDBString("serial_number");

					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE rma_assemblies ra
						SET
							ra.receive_date = NULL,
							ra.serial_number = NULL,
							ra.receive_user = NULL
						WHERE ra.id = @rmaAssemblyID;";
					cmd.Parameters.AddWithValue("rmaAssemblyID", rmaAssemblyID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			var eventString = $"Un-received assembly ID {rmaAssemblyID} (S/N {serialNumber}) from Bin {assemblyBin.BinName}";
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.RMA, rmaID, eventString);
		}

		/// <summary>
		/// Gets a list of all serial numbers for assemblies attached to this RMA, optionally excluding the specified assembly.
		/// </summary>
		/// <param name="rmaID">The RMA for which to retrieve all serial numbers.</param>
		/// <param name="excludeAssemblyID">Do not include serial number of this assembly, if specified.</param>
		public static IEnumerable<string> GetAssemblySerialNumbers(int rmaID, int? excludeAssemblyID = null)
		{
			var serialNumbers = new List<string>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT ra.serial_number
						FROM rma_assemblies ra
						WHERE ra.rma_id = @rmaID
						AND ra.id != @excludeAssemblyID;";
					cmd.Parameters.AddWithValue("rmaID", rmaID);
					cmd.Parameters.AddWithValue("excludeAssemblyID", excludeAssemblyID.GetValueOrDefault(0));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							serialNumbers.Add(reader.GetDBString_Null("serial_number"));
				}
				conn.Close();
			}
			return serialNumbers;
		}

		/// <summary>
		/// Returns the ID of the oldest received RMA. If one or more assemblies have been received, it counts as received.
		/// Omits RMAs where at least one assembly has started repair.
		/// If none found, returns null.
		/// </summary>
		public static int? GetOldestReceivedInactiveID()
		{
			int? rmaID = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT ra.rma_id, MIN(ra.receive_date) first_received,
						COUNT(ra.id) assembly_qty,
						SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
						SUM(IF(ra.repair_start_date IS NOT NULL,1,0)) repair_start_qty
						FROM rma r, rma_assemblies ra
						WHERE ra.rma_id = r.id
						AND r.completed_date IS NULL
						AND r.deleted IS FALSE
						AND r.flag_pending IS FALSE
						GROUP BY r.id ASC
						HAVING received_or_discarded_qty > 0 AND repair_start_qty = 0
						ORDER BY first_received ASC
						LIMIT 1;";
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							rmaID = reader.GetDBInt("rma_id");
						}
				}
				conn.Close();
			}
			return rmaID;
		}

		/// <summary>
		/// Counts the number of RMAs marked as HOT for which at least one assembly has been received but no repairs have been started.
		/// </summary>
		public static int CountReceivedInactiveHot()
		{
			int hotReceivedRMAQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT
							COUNT(DISTINCT(ra.rma_id)) hot_rma_qty,
							SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty,
							SUM(IF(ra.repair_start_date IS NOT NULL,1,0)) repair_start_qty
						FROM rma r, rma_assemblies ra
						WHERE ra.rma_id = r.id
							AND r.completed_date IS NULL
							AND r.deleted IS FALSE
							AND r.flag_pending IS FALSE
							AND r.flag_hot IS TRUE
						GROUP BY r.id ASC
							HAVING received_or_discarded_qty > 0 AND repair_start_qty = 0
						LIMIT 1;";
					hotReceivedRMAQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return hotReceivedRMAQty;
		}

		/// <summary>
		/// Checks if all assemblies for the specified RMA are repaired (completed).
		/// </summary>
		public static bool AreAllAssembliesRepaired(int rmaID)
		{
			bool allAssembliesRepaired;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(rma_id) unrepaired_assemblies
						FROM rma_assemblies
						WHERE repair_end_date IS NULL
						AND rma_id = @RMAID;";
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					allAssembliesRepaired = Convert.ToInt32(cmd.ExecuteScalar()) == 0;
				}
				conn.Close();
			}
			return allAssembliesRepaired;
		}

		/// <summary>
		/// Checks if all assemblies for the specified RMA are finalized (root cause assigned by supervisor).
		/// </summary>
		public static bool AreAllAssembliesFinalized(int rmaID)
		{
			bool allAssembliesFinalized;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(rma_id) unfinalized_assemblies
						FROM rma_assemblies
						WHERE finalize_date IS NULL
						AND rma_id = @RMAID;";
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					allAssembliesFinalized = Convert.ToInt32(cmd.ExecuteScalar()) == 0;
				}
				conn.Close();
			}
			return allAssembliesFinalized;
		}

		/// <summary>
		/// Marks the specified RMA as completed at the current time. (Completed means all assemblies have been repaired.)
		/// If <paramref name="isCompleted"/> is false, the RMA finalized date will be cleared.
		/// </summary>
		public static void SetCompleted(int rmaID, bool isCompleted = true)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						string.Format(@"UPDATE rma
						SET completed_date = {0},
						flag_pending = FALSE
						WHERE id = @RMAID;", isCompleted ? "NOW()" : "NULL");
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Updated, ClassEventLog.ObjectTypeEnum.RMA, rmaID, isCompleted ? "Completed" : "Undo Completed");
		}

		/// <summary>
		/// Marks the specified RMA as finalized at the current time. (Finalized means supervisor has finished root cause determination.)
		/// If the "Finalized" argument is false, the RMA finalized date will be cleared.
		/// </summary>
		public static void SetFinalized(int rmaID, bool isFinalized = true)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = $@"UPDATE rma
						SET finalized_date = {(isFinalized ? "NOW()" : "NULL")}
						WHERE id = @RMAID;";
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Updated, ClassEventLog.ObjectTypeEnum.RMA, rmaID, isFinalized ? "Finalized" : "Undo Finalized");
		}

		/// <summary>
		/// Marks the specified RMA accounting option true/false. This indicates whether accounting has processed the RMA components.
		/// </summary>
		public static void SetAccountingDone(int rmaID, bool isAccountingDone = true)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma
						SET flag_accounting = @Accounting
						WHERE id = @RMAID;";
					cmd.Parameters.AddWithValue("Accounting", isAccountingDone);
					cmd.Parameters.AddWithValue("RMAID", rmaID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Updated, ClassEventLog.ObjectTypeEnum.RMA, rmaID, isAccountingDone ? "Accounting Done" : "Accounting Incomplete");
		}

		/// <summary>
		/// After modifying any assembly type, this should be called to mark RMA's "flag_computer" as true/false according to the
		/// assembly types that each RMA has assigned to it.
		/// </summary>
		/// <returns>The number of RMA records modified.</returns>
		public static int ValidateComputerAssemblyTypes()
		{
			var recordsModified = 0;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Update RMAs that have assemblies which are computers, but the RMA does not indicate that it does
					cmd.CommandText =
						@"UPDATE rma r,
						(
							SELECT r.id, r.flag_computer, SUM(aty.is_computer) comp_qty
							FROM rma r
								LEFT JOIN rma_assemblies ra
									JOIN assembly_types aty
										ON aty.id = ra.assembly_type
									ON ra.rma_id = r.id
							WHERE r.flag_computer = 0
							GROUP BY r.id
							HAVING comp_qty > 0
						) AS rt
						SET r.flag_computer = 1
						WHERE r.id = rt.id;";
					recordsModified += cmd.ExecuteNonQuery();

					// Update RMAs that do not have assemblies which are computers, but the RMA indicates that it does					
					cmd.CommandText =
						@"UPDATE rma r,
						(
							SELECT r.id, r.flag_computer, SUM(aty.is_computer) comp_qty
							FROM rma r
								LEFT JOIN rma_assemblies ra
									JOIN assembly_types aty
										ON aty.id = ra.assembly_type
									ON ra.rma_id = r.id
							WHERE r.flag_computer = 1
							GROUP BY r.id
							HAVING comp_qty = 0
						) AS rt
						SET r.flag_computer = 0
						WHERE r.id = rt.id;";
					recordsModified += cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			return recordsModified;
		}

		/// <summary>
		/// Marks unreceived RMAs as expired when created more than n <paramref name="days"/> ago.
		/// </summary>
		public static void MarkUnreceivedAsExpired(int days)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"UPDATE rma r JOIN
						(
							SELECT r.id, r.creation_date,
								SUM(IF(ra.receive_date IS NOT NULL OR ra.discarded, 1, 0)) received_or_discarded_qty
							FROM rma r
							LEFT JOIN rma_assemblies ra ON ra.rma_id = r.id
							WHERE r.creation_date < DATE_SUB(NOW(), INTERVAL {days} DAY)
							GROUP BY r.id
							HAVING received_or_discarded_qty = 0
						) `x` ON x.id = r.id
						SET expired = TRUE;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Gets a list of RMAs assigned to specified tech and older than specified number of days, which contain unreceived assemblies.
		/// </summary>
		public static IEnumerable<ClassRMA> GetUnreceivedByTech(ClassTech tech, int daysOlderThan, bool includeExpired = false)
		{
			if (tech == null)
				return null;

			var unreceivedRmasByTech = new List<ClassRMA>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = _RMA_BASE_QUERY + $@"WHERE r.deleted IS FALSE
							{(includeExpired ? string.Empty : @"AND r.expired IS FALSE")}
							AND r.completed_date IS NULL
							AND DATEDIFF(CURDATE(), r.creation_date) > @daysOlderThan
							AND h.id = @techID
						GROUP BY r.id ASC
						HAVING received_or_discarded_qty < assembly_qty;";
					cmd.Parameters.AddWithValue("daysOlderThan", daysOlderThan);
					cmd.Parameters.AddWithValue("techID", tech.ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var r = GetFromReader(reader);
							if (r != null)
								unreceivedRmasByTech.Add(r);
						}
				}
				conn.Close();
			}
			return unreceivedRmasByTech;
		}

		/// <summary>
		/// Provides the collection of <see cref="RmaStatusObject"/>
		/// </summary>
		public static IEnumerable<RmaStatusObject> GetAllStatuses()
		{
			return new[]
			       {
				       _RMA_STATUS_UNRECEIVED,
				       _RMA_STATUS_UNSHIPPED_APR,
				       _RMA_STATUS_RECEIVED,
				       _RMA_STATUS_IN_PROGRESS,
				       _RMA_STATUS_PENDING,
				       _RMA_STATUS_COMPLETED,
				       _RMA_STATUS_FINALIZED,
				       _RMA_STATUS_CLOSED,
				       _RMA_STATUS_EXPIRED,
				       _RMA_STATUS_DELETED
				   };
		}
	}
}