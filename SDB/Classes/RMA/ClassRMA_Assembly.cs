using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Assembly;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public partial class ClassRMA
	{
		public class ClassRMAAssembly
		{
			// ReSharper disable InconsistentNaming
			internal static readonly Color RMA_ASSEMBLY_UNRECEIVED = Color.Gray;
			internal static readonly Color RMA_ASSEMBLY_RECEIVED = Color.Black;
			internal static readonly Color RMA_ASSEMBLY_REPAIR_STARTED = Color.FromArgb(192, 64, 0);
			internal static readonly Color RMA_ASSEMBLY_REPAIR_COMPLETED = Color.DarkBlue;
			internal static readonly Color RMA_ASSEMBLY_FINALIZED = Color.DarkGreen;
			// ReSharper restore InconsistentNaming

			public int ID { get; set; }
			public int RMA_ID { get; set; }
			public int? Bin_ID { get; set; }
			public int AssemblyType_ID { get; set; }
			/// <summary>
			/// Nullable because early in implementation RMAs did not require specific assemblies.
			/// </summary>
			public int? Assembly_ID { get; set; }
			public string SerialNumber { get; set; }

			public int Failure_Type { get; set; }
			public string Failure_Notes { get; set; }
			public string Failure_GridLocation { get; set; }
			/// <summary>
			/// Indicates that this assembly was discarded by customer and will not be returned.
			/// </summary>
			public bool Discarded { get; set; }
			public DateTime? Receive_Date { get; set; }
			public int? Receive_UserID { get; set; }
			public int? Receive_Zone { get; set; }
			public DateTime? Repair_DateTime_Start { get; set; }
			public DateTime? Repair_DateTime_End { get; set; }
			// ReSharper disable UnusedMember.Global
			/// <summary>
			/// Used in ObjectListViews
			/// </summary>
			public string Repair_TimeSpan => ClassUtility.FormatTimeSpan_Dhm(Repair_DateTime_End - Repair_DateTime_Start);
			// ReSharper restore UnusedMember.Global
			public int? Repair_UserID { get; set; }

            public int Repair_ActionID { get; set; }
           

			public string Repair_Notes { get; set; }
			public string Repair_OriginalJob { get; set; }
			public string Repair_OriginalPart { get; set; }
			public string Repair_Calibration { get; set; }
			public string Repair_MU { get; set; }
			public int? Finalize_RootCause { get; set; }
			public DateTime? Finalize_Date { get; set; }
			public int? Finalize_UserID { get; set; }

			// Optional fields that aren't normally part of this class
			public string AssemblyTypeDescription { get; set; }
			public bool AssemblyTypeIsComputer { get; set; }
			public string AssemblyDescription { get; set; }
			public string AssemblyTypeSerialNumberFormat { get; set; }

			/// <summary>
			/// Returns the assembly description if populated or the Assembly Type description if not.
			/// </summary>
			[UsedImplicitly]
			public string Description => !Assembly_ID.HasValue ? AssemblyTypeDescription : string.Format("{0}: {1} ({2})", AssemblyTypeDescription, AssemblyNumber, AssemblyDescription);

			public string AssemblyNumber { get; set; }
			public string FailureTypeDescription { get; set; }
			public string Receive_UserName { get; set; }
			public string Repair_UserName { get; set; }
			public string Finalize_UserName { get; set; }
			/// <summary>
			/// Used in RMA summary and reports to show all repairs applied to this assembly.
			/// </summary>
			public string RepairTypes_AllDescriptions { get; set; }
			public string Finalize_RootCauseDescription { get; set; }
			/// <summary>
			/// Used in ObjectListView to show bin names
			/// </summary>
			public string AssignedBinID { get; set; }

			public bool IsRepairStarted => Repair_DateTime_Start.HasValue;

			public bool IsRepairInProgress
			{
				get { return RepairLog.Count > 0 && !RepairLog.Aggregate((seed, f) => f.ID > seed.ID ? f : seed).RepairEnd.HasValue; }
			}

			/// <summary>
			/// Used to find out who is working on (or last worked on) the assembly.
			/// </summary>
			public int? LastOrCurrentRepairTechID
			{
				get
				{
					if (RepairLog == null || RepairLog.Count < 1)
						return null;
					return RepairLog.Aggregate((seed, f) => f.ID > seed.ID ? f : seed).UserID;
				}
			}

			public bool IsRepairComplete => Repair_DateTime_End.HasValue;

			public bool IsFinalized => Finalize_Date.HasValue;

			public List<ClassRepairLogEntry> RepairLog { get; set; }

			public TimeSpan Repair_TotalTechTime
			{
				get
				{
					var now = DateTime.Now;
					var totalTechTime = TimeSpan.Zero;
					foreach (var entry in RepairLog)
					{
						if (entry.RepairEnd.HasValue)
							totalTechTime = totalTechTime + (entry.RepairEnd.Value - entry.RepairStart);
						else
							totalTechTime = totalTechTime + (now - entry.RepairStart);
					}
					return totalTechTime;
				}
			}

			public TimeSpan Repair_TotalTime
			{
				get
				{
					var now = DateTime.Now;
					if (Repair_DateTime_Start.HasValue && Repair_DateTime_End.HasValue)
						return Repair_DateTime_End.Value - Repair_DateTime_Start.Value;
					return Repair_DateTime_Start.HasValue ? now - Repair_DateTime_Start.Value : TimeSpan.Zero;
				}
			}

			public Color StatusColor
			{
				get
				{
					if (Finalize_Date.HasValue)
						return RMA_ASSEMBLY_FINALIZED;
					if (Repair_DateTime_End.HasValue)
						return RMA_ASSEMBLY_REPAIR_COMPLETED;
					if (Repair_DateTime_Start.HasValue)
						return RMA_ASSEMBLY_REPAIR_STARTED;
					if (Receive_Date.HasValue)
						return RMA_ASSEMBLY_RECEIVED;
					return RMA_ASSEMBLY_UNRECEIVED;
				}
			}

			public override string ToString()
			{
				return string.Format("{0} [{1}]", AssemblyType_ID, ID);
			}

			public class ClassRepairLogEntry
			{
				public int ID { get; set; }
				public int UserID { get; set; }
				/// <summary>
				/// (UserName requires a table join to populate, not part of the repair log table.)
				/// </summary>
				public string UserName { get; set; }
				public DateTime RepairStart { get; set; }
				public DateTime? RepairEnd { get; set; }
                public int? Repair_ActionID { get; set; }
                
                public string Action()
                {
                    return ClassRepair_Actions.GetActionByID((int)Repair_ActionID);
                }

                public string TimeTaken => RepairEnd.HasValue ? ClassUtility.FormatTimeSpan_Dhm(RepairEnd - RepairStart) : "In Progress";

				public string DisplayMember => $"{RepairStart:yyyy-MM-dd}: {TimeTaken} ({UserName})";

				public override string ToString()
				{
					return DisplayMember;
				}
			}

			public ClassRMAAssembly()
			{
				RepairLog = new List<ClassRepairLogEntry>();
			}

			#region Assy Base Query
			private const string _RMA_ASSEMBLY_BASE_QUERY =
				@"SELECT
					ra.id, ra.rma_id, ra.bin_id, ra.assembly_type,
					`at`.description assembly_type_description, `at`.is_computer assembly_type_is_computer, `at`.serial_number_format assembly_type_serial_number_format,
					ra.assembly_id, ra.serial_number, a.description assembly_description, a.assembly_number assembly_number,
					ra.failure_type, rft.description failure_type_description,
					ra.failure_notes, ra.failure_grid,
					ra.discarded,
					ra.receive_date, ra.receive_user, CONCAT(u_rcv.firstname, LEFT(u_rcv.lastname,1)) receive_username, ra.receive_zone,
					ra.repair_start_date, ra.repair_end_date, ra.repair_user, CONCAT(u_rep.firstname, LEFT(u_rep.lastname, 1)) repair_username,
					ra.repair_notes, ra.repair_original_job, ra.repair_led_calibration, ra.repair_mu,
					ra.finalize_root_cause, rrc.description finalize_root_cause_description,
					ra.finalize_date, ra.finalize_user, CONCAT(u_fin.firstname, LEFT(u_fin.lastname,1)) finalize_username
				FROM assembly_types `at`
					JOIN rma_assemblies ra ON ra.assembly_type = at.id
					JOIN rma_failure_types rft ON rft.id = ra.failure_type
					LEFT JOIN assemblies a ON ra.assembly_id = a.id
					LEFT JOIN users u_rcv ON ra.receive_user = u_rcv.userid
					LEFT JOIN users u_rep ON ra.repair_user = u_rep.userid
					LEFT JOIN users u_fin ON ra.finalize_user = u_fin.userid
					LEFT JOIN rma_root_causes rrc ON ra.finalize_root_cause = rrc.id
				WHERE TRUE
				";
			#endregion

			/// <summary>
			/// Marks specified RMA Assembly as having repair session started at the current time by the logged-in user.
			/// </summary>
			public static void RMAAssembly_RepairSession_Start(int rmaAssemblyID, int action)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						// Read current repairlog for this assembly
						var repairLog = RMAAssembly_GetRepairLog(rmaAssemblyID).ToList();

						// If the last entry in the log has no repair end date, then indicate error
						if (repairLog.Count > 0 && !repairLog.Aggregate((seed, f) => f.ID > seed.ID ? f : seed).RepairEnd.HasValue)
						{
							MessageBox.Show("Repair is in progress and cannot be started on this assembly.", "Cannot Start Repair Session", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						cmd.Parameters.AddWithValue("RepairUserID", GS.Settings.LoggedOnUser.ID);
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);
                        

                        // If this is the first repair, update the parent RMA (repair_start_date)
                        if (repairLog.Count == 0)
						{
							cmd.CommandText =
								@"UPDATE rma_assemblies
								SET repair_start_date = NOW(),
								repair_user = @RepairUserID                           
								WHERE id = @RMAAssemblyID;";
							cmd.ExecuteNonQuery();
						}

                        cmd.Parameters.AddWithValue("repair_action_fky", action);
                        // Add a repairlog entry
                        cmd.CommandText =
                            @"INSERT INTO rma_assembly_repairlog
							(rma_assembly_id, user_id, repair_start, repair_action_fky)
							VALUES
							(@RMAAssemblyID, @RepairUserID, NOW(), @repair_action_fky);";
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			public static void RMAAssembly_RepairSession_Stop(int rmaAssemblyID)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						// Read current repairlog for this assembly
						var repairLog = RMAAssembly_GetRepairLog(rmaAssemblyID).ToList();

						// If there is no log, do nothing
						if (repairLog.Count == 0)
							return;

						// If the last entry in the log already has a repair end date, do nothing
						var lastLogID = repairLog.Max(rl => rl.ID);
						if (repairLog.Single(rl => rl.ID == lastLogID).RepairEnd.HasValue)
							return;

						cmd.Parameters.AddWithValue("RepairLogID", lastLogID);

						// Complete a repairlog entry
						cmd.CommandText =
							@"UPDATE rma_assembly_repairlog
							SET repair_end = NOW()
							WHERE id = @RepairLogID;";
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Updates specified RMA Assembly: assembly ID, original job number, calibration #, mu #, and repair notes from the RepairedAssembly object.
			/// Also changes the Assembly Type ID if the specific assembly is of a different type.
			/// </summary>
			public static void RMAAssembly_Repair_Update(ClassRMAAssembly repairedAssembly)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"SELECT repair_end_date
							FROM rma_assemblies
							WHERE id = @RMAAssemblyID;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", repairedAssembly.ID);
						using (var reader = cmd.ExecuteReader())
							if (reader.HasRows)
							{
								reader.Read();
								if (reader.GetDBDateTime_Null("repair_end_date").HasValue)
								{
									MessageBox.Show("Repair has already finished on this assembly.", "Cannot Update Repair", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									return;
								}
							}

						cmd.Parameters.Clear();
						cmd.CommandText =
							@"UPDATE rma_assemblies
							SET serial_number = @SerialNumber,
								repair_notes = @RepairNotes,
								repair_original_job = @RepairJobNumber,
								repair_led_calibration = @RepairCalibration,
								repair_mu = @RepairMU,
								assembly_id = @AssemblyID,
								assembly_type = @AssemblyType
							WHERE id = @RMAAssemblyID;";
						cmd.Parameters.AddWithValue("RepairNotes", repairedAssembly.Repair_Notes);
						cmd.Parameters.AddWithValue("RepairJobNumber", repairedAssembly.Repair_OriginalJob);
						cmd.Parameters.AddWithValue("RepairCalibration", repairedAssembly.Repair_Calibration);
						cmd.Parameters.AddWithValue("SerialNumber", repairedAssembly.SerialNumber);
						cmd.Parameters.AddWithValue("RepairMU", repairedAssembly.Repair_MU);
						cmd.Parameters.AddWithValue("AssemblyID", repairedAssembly.Assembly_ID);
						cmd.Parameters.AddWithValue("AssemblyType", repairedAssembly.Assembly_ID.HasValue ? ClassAssembly.GetByID(repairedAssembly.Assembly_ID.Value).AssemblyTypeID : repairedAssembly.AssemblyType_ID);
						cmd.Parameters.AddWithValue("RMAAssemblyID", repairedAssembly.ID);
						ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Marks specified RMA Assembly as having repair finished at the current time.
			/// </summary>
			public static void RMAAssembly_Repair_Finish(ClassRMAAssembly repairedAssembly)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"SELECT repair_end_date
							FROM rma_assemblies
							WHERE id = @RMAAssemblyID;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", repairedAssembly.ID);
						using (var reader = cmd.ExecuteReader())
							if (reader.HasRows)
							{
								reader.Read();
								if (reader.GetDBDateTime_Null("repair_end_date").HasValue)
								{
									MessageBox.Show("Repair has already finished on this assembly.", "Cannot Finish Repair", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									return;
								}
							}

						// Read current repairlog for this assembly
						var repairLog = RMAAssembly_GetRepairLog(repairedAssembly.ID).ToList();

						// Update repairlog if a repair is in progress
						if (repairLog.Count > 0)
						{
							var lastLogID = repairLog.Max(rl => rl.ID);
							if (!repairLog.Single(rl => rl.ID == lastLogID).RepairEnd.HasValue)
							{
								cmd.Parameters.Clear();
								cmd.CommandText =
									@"UPDATE rma_assembly_repairlog
									SET repair_end = NOW()
									WHERE id = @RepairLogLastID;";
								cmd.Parameters.AddWithValue("RepairLogLastID", lastLogID);
							}
						}

						cmd.Parameters.Clear();
						cmd.CommandText =
							@"UPDATE rma_assemblies
							SET repair_end_date = NOW()
							WHERE id = @RMAAssemblyID;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", repairedAssembly.ID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Marks specified RMA Assembly as being finalized with its root cause at the current time.
			/// </summary>
			public static void RMAAssembly_Repair_Finalize(ClassRMAAssembly repairedAssembly)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.Parameters.Clear();
						cmd.CommandText =
							@"UPDATE rma_assemblies
							SET finalize_date = NOW(),
								finalize_root_cause = @FinalizeRootCause,
								finalize_user = @FinalizeUser
							WHERE id = @RMAAssemblyID;";
						cmd.Parameters.AddWithValue("FinalizeRootCause", repairedAssembly.Finalize_RootCause);
						cmd.Parameters.AddWithValue("FinalizeUser", GS.Settings.LoggedOnUser.ID);
						cmd.Parameters.AddWithValue("RMAAssemblyID", repairedAssembly.ID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Clears finalization details from specified RMA Assembly.
			/// </summary>
			public static void RMAAssembly_Repair_Finalize_Cancel(int rmaAssemblyID)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"UPDATE rma_assemblies
							SET finalize_date = NULL,
								finalize_root_cause = NULL,
								finalize_user = NULL
							WHERE id = @RMAAssemblyID;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Cancels finished repair on specified RMA Assembly. (Allows additional editing.)
			/// </summary>
			public static void RMAAssembly_Repair_Cancel(int rmaAssemblyID)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"UPDATE rma_assemblies
							SET repair_end_date = @RepairEndDate
							WHERE id = @AssemblyID;";
						cmd.Parameters.AddWithValue("RepairEndDate", null);
						cmd.Parameters.AddWithValue("AssemblyID", rmaAssemblyID);
						ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			public class ClassRMAAssembly_InProgressItem
			{
				public int RMA_ID;
				public string Assembly_Type_Description;
				public DateTime Repair_Started;
			}

			/// <summary>
			/// Gets a list of ClassRMAAssembly_InProgressItems for RMAs where assemblies have started repair but are not stopped/finished by the specified user.
			/// </summary>
			public static IEnumerable<ClassRMAAssembly_InProgressItem> RMAAssembly_Repair_GetInProgressItems(int userID)
			{
				var inProgressItems = new List<ClassRMAAssembly_InProgressItem>();
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"SELECT r.id, at.description, rarl.repair_start
							FROM rma r
								JOIN rma_assemblies ra ON ra.rma_id = r.id
								JOIN rma_assembly_repairlog rarl ON rarl.rma_assembly_id = ra.id
								JOIN assembly_types `at` ON ra.assembly_type = at.id
							WHERE rarl.user_id = @UserID
								AND rarl.repair_end IS NULL;";
						cmd.Parameters.AddWithValue("@UserID", userID);
						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
								while (reader.Read())
									inProgressItems.Add(new ClassRMAAssembly_InProgressItem
									                    {
										                    RMA_ID = reader.GetDBInt("id"),
										                    Assembly_Type_Description = reader.GetDBString("description"),
										                    Repair_Started = reader.GetDBDateTime("repair_start")
									                    });
						}
					}
					conn.Close();
				}
				return inProgressItems;
			}

			/// <summary>
			/// Ends any repair sessions started by specified user at the current time.
			/// </summary>
			public static void EndAllRepairSessions(int userID)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = @"UPDATE rma_assembly_repairlog rarl
											SET rarl.repair_end = NOW()
											WHERE rarl.repair_end IS NULL
												AND rarl.user_id = @userID";
						cmd.Parameters.AddWithValue("userID", userID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Gets the repair log for the specified RMA Assembly.
			/// </summary>
			public static IEnumerable<ClassRepairLogEntry> RMAAssembly_GetRepairLog(int rmaAssemblyID)
			{
				var repairLog = new List<ClassRepairLogEntry>();
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"SELECT rarl.*, CONCAT(u.firstname, LEFT(u.lastname, 1)) user_name
							FROM rma_assembly_repairlog rarl
								JOIN users u ON rarl.user_id = u.userid
							WHERE rarl.rma_assembly_id = @RMAAssemblyID
							ORDER BY rarl.id DESC;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);

						using (var reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								var repairLogEntry = GetRMAAssemblyRepairLogEntryFromReader(reader);
								repairLogEntry.UserName = reader.GetDBString("user_name");
								repairLog.Add(repairLogEntry);
							}
						}
					}
					conn.Close();
				}
				return repairLog;
			}

			/// <summary>
			/// Adds a repair type to the specified RMA Assembly.
			/// </summary>
			public static void RMAAssembly_RepairType_Add(int rmaAssemblyID, ClassRMA_RepairType repairType)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"INSERT INTO rma_assembly_repairs
								(rma_assembly_id, rma_repair_type)
							VALUES
								(@RMAAssemblyID, @RMARepairType);";
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);
						cmd.Parameters.AddWithValue("RMARepairType", repairType.ID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Removes specified repair type from specified RMA Assembly.
			/// </summary>
			public static void RMAAssembly_RepairType_Remove(int rmaAssemblyID, int repairTypeID)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"DELETE FROM rma_assembly_repairs
							WHERE rma_assembly_id = @RMAAssemblyID
								AND rma_repair_type = @RepairTypeID;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);
						cmd.Parameters.AddWithValue("RepairTypeID", repairTypeID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Adds a component to the specified RMA Assembly being repaired.
			/// </summary>
			public static void RMAAssembly_RMAComponent_Add(int rmaAssemblyID, ClassRMA_Component rmaComponent)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"INSERT INTO rma_assembly_components
								(rma_assembly_id, component_id, silkscreen_id)
							VALUES
								(@RMAAssemblyID, @ComponentID, @SilkscreenID);";
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);
						cmd.Parameters.AddWithValue("ComponentID", rmaComponent.Component.ID);
						cmd.Parameters.AddWithValue("SilkscreenID", rmaComponent.SilkscreenID);
						ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Removes specified component from specified RMA Assembly.
			/// </summary>
			public static void RMAAssembly_RMAComponent_Remove(int rmaComponentID)
			{
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"DELETE FROM rma_assembly_components
							WHERE id = @RMAComponentID;";
						cmd.Parameters.AddWithValue("RMAComponentID", rmaComponentID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}

			public static ClassRMAAssembly GetByID(int rmaAssemblyID)
			{
				var rmaAssembly = new ClassRMAAssembly();
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = _RMA_ASSEMBLY_BASE_QUERY +
						                  @"AND ra.id = @RMAAssemblyID;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);
						using (var reader = cmd.ExecuteReader())
							if (reader.HasRows)
							{
								reader.Read();
								rmaAssembly = GetRMAAssemblyFromReader(reader);
							}
					}
					conn.Close();
				}
				return rmaAssembly;
			}

			/// <summary>
			/// Returns all RMA Assemblies having specified serial number.
			/// This can be used to validate that only one instance of the serial number exists among open RMAs, or to track the history of a given serial number through RMA history.
			/// </summary>
			public static List<ClassRMAAssembly> GetBySerialNumber(string assemblySerialNumber)
			{
				var assemblySerialNumberInstances = new List<ClassRMAAssembly>();
				if (string.IsNullOrEmpty(assemblySerialNumber))
					return assemblySerialNumberInstances;

				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = _RMA_ASSEMBLY_BASE_QUERY +
						                  @"AND ra.serial_number = @assemblySerialNumber;";
						cmd.Parameters.AddWithValue("assemblySerialNumber", assemblySerialNumber);
						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
								assemblySerialNumberInstances.Add(GetRMAAssemblyFromReader(reader));
					}
					conn.Close();
				}
				return assemblySerialNumberInstances;
			}

			/// <summary>
			/// Gets the collection of RMA Assemblies for specified RMA.
			/// </summary>
			/// <param name="rmaID">The RMA for which to get assemblies.</param>
			/// <param name="limit">Optional: Limit number of results to this amount.</param>
			public static IEnumerable<ClassRMAAssembly> GetRMAAssemblies(int rmaID, int? limit = null)
			{
				var rmaAssemblies = new List<ClassRMAAssembly>();
				var limitCondition = limit.HasValue ? $"LIMIT {limit}" : string.Empty;
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = _RMA_ASSEMBLY_BASE_QUERY +
						                  $@"AND ra.rma_id = @rmaID
							ORDER BY ra.id ASC
							{limitCondition};";
						cmd.Parameters.AddWithValue("rmaID", rmaID);
						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
								rmaAssemblies.Add(GetRMAAssemblyFromReader(reader));
					}
					conn.Close();
				}
				return rmaAssemblies;
			}

			/// <summary>
			/// Looks up the repairs performed on the RMA Assemblies and populates their RepairTypes_AllDescriptions property. (For RMA Summary or Reports)
			/// </summary>
			public static void GetRMAAssemblyRepairStrings(List<ClassRMAAssembly> rmaAssemblyList)
			{
				if (rmaAssemblyList.Count < 1)
					return;

				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = string.Format(
							@"SELECT rap.rma_assembly_id, GROUP_CONCAT(rrt.description SEPARATOR ', ') repairs
							FROM rma_assembly_repairs rap
								JOIN rma_repair_types rrt ON rap.rma_repair_type = rrt.id
							WHERE rap.rma_assembly_id IN ({0})
							GROUP BY rap.rma_assembly_id;",
							string.Join(",", rmaAssemblyList.Select(ra => ra.ID).ToArray()));
						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
								rmaAssemblyList.Single(ra => ra.ID == reader.GetDBInt("rma_assembly_id")).RepairTypes_AllDescriptions = reader.GetDBString("repairs");
					}
					conn.Close();
				}
			}

			/// <summary>
			/// Gets the repair types for the specified RMA Assembly.
			/// </summary>
			public static IEnumerable<ClassRMA_RepairType> GetRMAAssemblyRepairTypes(int rmaAssemblyID)
			{
				var rmaAssemblyRepairTypes = new List<ClassRMA_RepairType>();
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"SELECT rrt.id, rrt.description
							FROM rma_repair_types rrt, rma_assembly_repairs rar
							WHERE rar.rma_repair_type = rrt.id
							AND rar.rma_assembly_id = @RMAAssemblyID
							ORDER BY rrt.description ASC;";
						cmd.Parameters.AddWithValue("RMAAssemblyID", rmaAssemblyID);
						using (var reader = cmd.ExecuteReader())
							while (reader.Read())
							{
								var repairType = new ClassRMA_RepairType();
								repairType.ID = reader.GetDBInt("id");
								repairType.Description = reader.GetDBString("description");
								rmaAssemblyRepairTypes.Add(repairType);
							}
					}
					conn.Close();
				}
				return rmaAssemblyRepairTypes;
			}

			private static ClassRMAAssembly GetRMAAssemblyFromReader(MySqlDataReader reader)
			{
				var rmaAssy = new ClassRMAAssembly();
				var id = reader.GetDBInt_Null("id");

				if (!id.HasValue)
					return null;

				rmaAssy.ID = id.Value;
				rmaAssy.RMA_ID = reader.GetDBInt("rma_id");
				rmaAssy.Bin_ID = reader.GetDBInt_Null("bin_id");
				rmaAssy.AssemblyType_ID = reader.GetDBInt("assembly_type");
				rmaAssy.Assembly_ID = reader.GetDBInt_Null("assembly_id");
				rmaAssy.Failure_Type = reader.GetDBInt("failure_type");
				rmaAssy.Failure_Notes = reader.GetDBString("failure_notes");
				rmaAssy.Failure_GridLocation = reader.GetDBString("failure_grid");
				rmaAssy.Discarded = reader.GetDBBool("discarded");
				rmaAssy.Receive_Date = reader.GetDBDateTime_Null("receive_date");
				rmaAssy.Receive_UserID = reader.GetDBInt_Null("receive_user");
				rmaAssy.Receive_Zone = reader.GetDBInt_Null("receive_zone");
				rmaAssy.Repair_DateTime_Start = reader.GetDBDateTime_Null("repair_start_date");
				rmaAssy.Repair_UserID = reader.GetDBInt_Null("repair_user");
				rmaAssy.Repair_DateTime_End = reader.GetDBDateTime_Null("repair_end_date");
				rmaAssy.Repair_Notes = reader.GetDBString("repair_notes");
				rmaAssy.Repair_OriginalJob = reader.GetDBString("repair_original_job");
				rmaAssy.Repair_Calibration = reader.GetDBString("repair_led_calibration");
				rmaAssy.SerialNumber = reader.GetDBString("serial_number");
				rmaAssy.Repair_MU = reader.GetDBString("repair_mu");
				rmaAssy.Finalize_RootCause = reader.GetDBInt_Null("finalize_root_cause");
				rmaAssy.Finalize_Date = reader.GetDBDateTime_Null("finalize_date");
				rmaAssy.Finalize_UserID = reader.GetDBInt_Null("finalize_user");

				// Optional fields
				rmaAssy.AssemblyTypeDescription = reader.GetDBString("assembly_type_description");
				rmaAssy.AssemblyTypeIsComputer = reader.GetDBBool("assembly_type_is_computer");
				rmaAssy.AssemblyTypeSerialNumberFormat = reader.GetDBString("assembly_type_serial_number_format");
				rmaAssy.AssemblyDescription = reader.GetDBString("assembly_description");
				rmaAssy.AssemblyNumber = reader.GetDBString("assembly_number");
				rmaAssy.FailureTypeDescription = reader.GetDBString("failure_type_description");
				rmaAssy.Receive_UserName = reader.GetDBString("receive_username");
				rmaAssy.Repair_UserName = reader.GetDBString("repair_username");
				rmaAssy.Finalize_UserName = reader.GetDBString("finalize_username");
				rmaAssy.Finalize_RootCauseDescription = reader.GetDBString("finalize_root_cause_description");

				return rmaAssy;
			}

			private static ClassRepairLogEntry GetRMAAssemblyRepairLogEntryFromReader(MySqlDataReader reader)
			{
				return new ClassRepairLogEntry
				       {
					       ID = reader.GetDBInt("id"),
					       RepairStart = reader.GetDBDateTime("repair_start"),
					       RepairEnd = reader.GetDBDateTime_Null("repair_end"),
					       UserID = reader.GetDBInt("user_id"),
                           Repair_ActionID = reader.GetDBInt("repair_action_fky")
                };
			}

			/// <summary>
			/// Checks if supplied serial number is valid.
			/// </summary>
			/// <param name="serialNumber">Serial number to validate.</param>
			/// <param name="serialNumberFormat">Regular expression to validate against.</param>
			public static bool ValidateSerialNumber(string serialNumber, string serialNumberFormat)
			{
				if (string.IsNullOrEmpty(serialNumberFormat))
					return true;

				var regex = new Regex(@"^" + serialNumberFormat + @"$", RegexOptions.IgnoreCase);
				var match = regex.Match(serialNumber);
				return match.Success;
			}

			/// <summary>
			/// Changes the failure type for this assembly
			/// </summary>
			public void SetFailureType(ClassRMA_FailureType failureType)
			{
				Failure_Type = failureType.ID;
				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"UPDATE rma_assemblies
								SET failure_type = @failureTypeID
							WHERE id = @rmaAssemblyID;";
						cmd.Parameters.AddWithValue("failureTypeID", Failure_Type);
						cmd.Parameters.AddWithValue("rmaAssemblyID", ID);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}
		}
	}
}