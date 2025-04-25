using System;
using System.Collections.Generic;
using System.Linq;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Tech;
using SDB.Classes.User;

// ReSharper disable UnusedMember.Global

namespace SDB.Classes.Ticket
{
	public static class TicketUtil
	{
		/// <summary>
		/// Populates <see cref="TicketExtraProperties.SymptomList"/> and <see cref="TicketExtraProperties.SolutionList"/> for specified ticket.
		/// </summary>
		public static void PopulateSymptomsAndSolutions(this ClassTicket ticket)
		{
			if (ticket == null)
				return;

			PopulateSymptomsAndSolutions(new List<ClassTicket>
										 {
											 ticket
										 });
		}

		/// <summary>
		/// Populates <see cref="TicketExtraProperties.SymptomList"/> and <see cref="TicketExtraProperties.SolutionList"/> for specified ticket list.
		/// </summary>
		/// <remarks>
		/// Gets all symptoms and solutions once then distributes them to all tickets by reading rows in the ticket_symptoms and ticket_solutions tables.
		/// </remarks>
		public static void PopulateSymptomsAndSolutions(this List<ClassTicket> tickets)
		{
			if (tickets == null || tickets.Count < 1)
				return;

			var allSymptoms = ClassTicket_Symptom.GetAll().ToList();
			var allSolutions = ClassTicket_Solution.GetAll().ToList();

			if (tickets.Count <= 1000)
			{
				var ticketIdsCsv = string.Join(",", tickets.Select(t => t.ID).Distinct());

				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = $"SELECT ticket_id, symptom_id FROM ticket_symptoms WHERE ticket_id IN ({ticketIdsCsv});";
						using (var reader = cmd.ExecuteReader())
							while (reader.HasRows && reader.Read())
								tickets.Single(t => t.ID == reader.GetDBInt("ticket_id")).ExtraProperties.SymptomList.Add(allSymptoms.Single(sym => sym.ID == reader.GetDBInt("symptom_id")));

						cmd.CommandText = $"SELECT ticket_id, solution_id FROM ticket_solutions WHERE ticket_id IN ({ticketIdsCsv});";
						using (var reader = cmd.ExecuteReader())
							while (reader.HasRows && reader.Read())
								tickets.Single(t => t.ID == reader.GetDBInt("ticket_id")).ExtraProperties.SolutionList.Add(allSolutions.Single(sym => sym.ID == reader.GetDBInt("solution_id")));
					}
					conn.Close();
				}
			}
			else
			{
				var minTicketId = tickets.Select(t => t.ID).Min();
				var maxTicketId = tickets.Select(t => t.ID).Max();
				var ticketSymptomLink = new Dictionary<int, List<int>>();
				var ticketSolutionLink = new Dictionary<int, List<int>>();

				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText = $"SELECT ticket_id, symptom_id FROM ticket_symptoms WHERE ticket_id >= {minTicketId} AND ticket_id <= {maxTicketId};";
						using (var reader = cmd.ExecuteReader())
							while (reader.HasRows && reader.Read())
							{
								var ticketId = reader.GetDBInt("ticket_id");
								var symptomId = reader.GetDBInt("symptom_id");
								if (ticketSymptomLink.TryGetValue(ticketId, out var ticketEntry))
									ticketEntry.Add(symptomId);
								else
									ticketSymptomLink.Add(ticketId, new List<int>
																	{
																		symptomId
																	});
							}

						cmd.CommandText = $"SELECT ticket_id, solution_id FROM ticket_solutions WHERE ticket_id >= {minTicketId} AND ticket_id <= {maxTicketId};";
						using (var reader = cmd.ExecuteReader())
							while (reader.HasRows && reader.Read())
							{
								var ticketId = reader.GetDBInt("ticket_id");
								var solutionid = reader.GetDBInt("solution_id");
								if (ticketSolutionLink.TryGetValue(ticketId, out var ticketEntry))
									ticketEntry.Add(solutionid);
								else
									ticketSolutionLink.Add(ticketId, new List<int>
																	 {
																		 solutionid
																	 });
							}
					}
					conn.Close();
				}

				foreach (var ticket in tickets)
				{
					try
					{
						if (ticketSymptomLink.ContainsKey(ticket.ID))
							ticket.ExtraProperties.SymptomList.AddRange(allSymptoms.Where(sym => ticketSymptomLink[ticket.ID].Contains(sym.ID)));
						if (ticketSolutionLink.ContainsKey(ticket.ID))
							ticket.ExtraProperties.SolutionList.AddRange(allSolutions.Where(sol => ticketSolutionLink[ticket.ID].Contains(sol.ID)));
					}
					catch (Exception exc)
					{
						throw new Exception($"Error populating symptoms and solutions on ticket {ticket.ID}", exc);
					}
				}
			}
		}

		public static void PopulateLastJournals(this ClassTicket ticket)
		{
			if (ticket == null)
				return;

			PopulateLastJournals(new List<ClassTicket>
								 {
									 ticket
								 });
		}

		public static void PopulateLastJournals(this List<ClassTicket> tickets)
		{
			if (tickets == null)
				return;

			ClassJournalItem.PopulateLastEntriesForTicketList(tickets);
		}

		/// <summary>
		/// Populates <see cref="TicketExtraProperties.AssetName"/>, <see cref="TicketExtraProperties.AssetPanelName"/>,
		/// <see cref="TicketExtraProperties.AssetLocation"/>, <see cref="TicketExtraProperties.AssignedTechName"/>, and
		/// <see cref="TicketExtraProperties.CustomerAssetTag"/> for specified ticket.
		/// </summary>
		public static void PopulateExtraStrings(this ClassTicket ticket)
		{
			if (ticket == null)
				return;

			PopulateExtraStrings(new List<ClassTicket>
								 {
									 ticket
								 });
		}

		/// <summary>
		/// Populates <see cref="TicketExtraProperties.AssetName"/>, <see cref="TicketExtraProperties.AssetPanelName"/>,
		/// <see cref="TicketExtraProperties.AssetLocation"/>, <see cref="TicketExtraProperties.AssignedTechName"/>, and
		/// <see cref="TicketExtraProperties.CustomerAssetTag"/> for specified ticket list.
		/// </summary>
		public static void PopulateExtraStrings(this List<ClassTicket> tickets)
		{
			if (tickets == null || tickets.Count < 1)
				return;

			var allTechNames = ClassTech.GetNames(tickets.Select(t => t.TechID).DistinctValues().ToList());
			var allAssetPieces = ClassAsset.GetPieces(tickets.Select(t => t.AssetID).ToList());
			var ticketToCustomerAssetTagLookup = ClassCustomerAssetTag.GetCustomerAssetTagForTicketIds(tickets.Select(t => t.ID));
			var allUserNames = ClassUser.GetIdToNameDictionary();

			foreach (var ticket in tickets)
			{
				try
				{
					ticket.ExtraProperties.AssetName = allAssetPieces[ticket.AssetID].Asset;
					ticket.ExtraProperties.AssetPanelName = allAssetPieces[ticket.AssetID].Panel;
					ticket.ExtraProperties.AssetLocation = allAssetPieces[ticket.AssetID].Location;
					ticket.ExtraProperties.CustomerName = allAssetPieces[ticket.AssetID].CustomerName;
					ticket.ExtraProperties.OpenUser = allUserNames[ticket.Open_UserID];
					if (ticket.Close_UserID.HasValue && allUserNames.ContainsKey(ticket.Close_UserID.Value))
						ticket.ExtraProperties.CloseUser = allUserNames[ticket.Close_UserID.Value];
					if (!ticket.TechID.HasValue)
						ticket.ExtraProperties.AssignedTechName = string.Empty;
					else
					{
						if (allTechNames.TryGetValue(ticket.TechID.Value, out var techName))
							ticket.ExtraProperties.AssignedTechName = techName;
						else
							ticket.ExtraProperties.AssignedTechName = "Unknown/Missing";
					}

					ticket.ExtraProperties.CustomerAssetTag = ticketToCustomerAssetTagLookup[ticket.ID];
				}
				catch (Exception exc)
				{
					throw new Exception($"Error populating extra strings on ticket {ticket.ID}", exc);
				}
			}
		}

		public static void PopulateAssetWarrantyIndicator(this List<ClassTicket> tickets)
		{
			if (tickets == null || tickets.Count < 1)
				return;

			var ticketIdsCsv = string.Join(",", tickets.Select(t => t.ID).Distinct());
			var now = ClassDatabase.GetCurrentTime();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						$@"SELECT t.id, a.labor_w_end_dt, a.labor_c_end_dt, a.labor_c_monitoring
						FROM tickets t
						JOIN assets a ON t.asset_id = a.id
						WHERE t.id IN ({ticketIdsCsv});";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var ticket = tickets.Single(t => t.ID == reader.GetDBInt("id"));
							ticket.ExtraProperties.IsAssetLaborCovered = !reader.GetDBBool("labor_c_monitoring") && (reader.GetDBDateTime_Null("labor_w_end_dt") > now || reader.GetDBDateTime_Null("labor_c_end_dt") > now);
						}
				}
				conn.Close();
			}
		}
	}
}