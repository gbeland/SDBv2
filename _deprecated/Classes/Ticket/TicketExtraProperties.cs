using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	/// <summary>
	/// Properties that are not part of the ticket table and are populated on-demand as needed for lists, etc. Replaces "ClassTicket_Multi" which largely duplicated <see cref="ClassTicket"/>.
	/// </summary>
	public class TicketExtraProperties
	{
		private string _solutionNotes;
		private string _otherSymptomNotes;

		#region Properties related to Asset
		public string CustomerName { get; set; }
		public string AssetName { get; set; }
		public string AssetPanelName { get; set; }
		public string AssetLocation { get; set; }
		public bool IsAssetLaborCovered { get; set; }
		#endregion

		#region Properties related to Tech
		public string AssignedTechName { get; set; }
		#endregion

		#region Properties related to Customer
		public string CustomerAssetTag { [UsedImplicitly] get; set; }
		#endregion

		#region Properties related to Symptoms/Solutions
		public List<ClassTicket_Symptom> SymptomList { get; set; }
		public List<ClassTicket_Solution> SolutionList { get; set; }
		#endregion

		#region Properties related to Users
		public string OpenUser { get; set; }
		public string CloseUser { get; set; }
		#endregion

		#region Properties related to Journal
		public ClassJournal Journal { get; }
		#endregion

		#region Properties used internally (not stored in database)
		/// <summary>
		/// Used when creating new tickets
		/// </summary>
		public Image OSA_Image;
		#endregion

		public TicketExtraProperties(string solutionNotes, string otherSymptomNotes)
		{
			_otherSymptomNotes = otherSymptomNotes;
			_solutionNotes = solutionNotes;

			SymptomList = new List<ClassTicket_Symptom>();
			SolutionList = new List<ClassTicket_Solution>();
			Journal = new ClassJournal();
		}

		internal void SetSolutionNotes(string solutionNotes)
		{
			_solutionNotes = solutionNotes;
		}

		internal void SetOtherSymptomNotes(string otherSymptomNotes)
		{
			_otherSymptomNotes = otherSymptomNotes;
		}

		/// <summary>
		/// Returns a comma-separated string of all Symptom descriptions.
		/// Symptom notes are included if <paramref name="includeOtherNotes"/> is true and "Other" is among the symptoms.
		/// </summary>
		public string Symptoms (bool includeOtherNotes = false)
		{
			var combinedSymptoms = string.Join(", ", SymptomList.Select(s => s.Symptom));
			if (includeOtherNotes && SymptomList.Any(s => s.Symptom == "Other"))
				combinedSymptoms += $": {_otherSymptomNotes}";
			return combinedSymptoms;
		}

		/// <summary>
		/// Returns a comma-separated string of all Solution descriptions.
		/// Solution notes are included if <paramref name="includeNotes"/> is true and "Other" is among the solutions.
		/// </summary>
		public string Solutions (bool includeNotes = false)
		{
			var combinedSolutions = string.Join(", ", SolutionList.Select(s => s.Solution));
			if (includeNotes && SolutionList.Any(s => s.Solution == "Other"))
				combinedSolutions += $": {_solutionNotes}";
			return combinedSolutions;
		}
	}
}