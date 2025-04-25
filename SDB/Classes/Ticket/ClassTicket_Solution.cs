using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	/// <summary>
	/// Ticket solution categories.
	/// </summary>
	public class ClassTicket_Solution
	{
		public int ID { get; private set; }
		public string Solution { get; set; }
		public bool RequiresParts { get; set; }

		/// <summary>
		/// Used only in the context of closing a ticket (not a standard solution property).
		/// </summary>
		public bool Selected { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Solution;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Solution, ID);
		}

		/// <summary>
		/// Gets all possible solutions.
		/// </summary>
		public static IEnumerable<ClassTicket_Solution> GetAll()
		{
			var solutions = new List<ClassTicket_Solution>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT s.*
						FROM solutions s
						ORDER BY s.solution ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							solutions.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return solutions;
		}

		public static IEnumerable<ClassTicket_Solution> GetByTicket(int ticketID)
		{
			var solutions = new List<ClassTicket_Solution>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT s.*
						FROM solutions s, ticket_solutions ts
						WHERE s.id = ts.solution_id
						AND ts.ticket_id = @TicketID
						ORDER BY s.id ASC;";
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							solutions.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return solutions;
		}

		public static void AddNew(ref ClassTicket_Solution newSolution)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO solutions (solution, requires_parts)
						VALUES (@Solution, @Requires_Parts);";
					cmd.Parameters.AddWithValue("Solution", newSolution.Solution);
					cmd.Parameters.AddWithValue("Requires_Parts", newSolution.RequiresParts);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					newSolution.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ClassTicket_Solution solution)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE solutions SET
						solution = @solution,
						requires_parts = @requires_parts
						WHERE id = @solution_id";

					cmd.Parameters.AddWithValue("solution", solution.Solution);
					cmd.Parameters.AddWithValue("requires_parts", solution.RequiresParts);
					cmd.Parameters.AddWithValue("solution_id", solution.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Returns how many times specified solution is utilized by tickets.
		/// </summary>
		public static int GetUsedQty(int solutionID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM ticket_solutions
						WHERE solution_id = @SolutionID;";
					cmd.Parameters.AddWithValue("SolutionID", solutionID);
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		public void Delete()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM solutions
						WHERE id = @SolutionID;";
					cmd.Parameters.AddWithValue("SolutionID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.TicketSolution, ID, Solution);
		}

		/// <summary>
		/// Replaces all occurrences of this solution with <paramref name="replacementSolutionId"/> throughout the database.
		/// </summary>
		public void Merge(int replacementSolutionId)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE ticket_solutions
						SET solution_id = @replacementSolutionId
						WHERE solution_id = @deprecatedSolutionId;";
					cmd.Parameters.AddWithValue("deprecatedSolutionId", ID);
					cmd.Parameters.AddWithValue("replacementSolutionId", replacementSolutionId);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static ClassTicket_Solution GetFromReader(MySqlDataReader reader)
		{
			return new ClassTicket_Solution
			       {
				       ID = reader.GetDBInt("id"),
				       Solution = reader.GetDBString("solution"),
				       RequiresParts = reader.GetDBBool("requires_parts")
			       };
		}
	}
}