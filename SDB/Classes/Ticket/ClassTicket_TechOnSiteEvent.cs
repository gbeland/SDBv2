using System;
using System.Collections.Generic;
using System.Linq;

namespace SDB.Classes.Ticket
{
	/// <summary>
	/// A tech arrival or departure for a ticket.
	/// </summary>
	public class ClassTicket_TechOnSiteEvent
	{
		public int TechID;
		public string TechName;
		public DateTime EventDateTime;

		private const string _ARRIVAL = "Arrived";
		private const string _DEPARTURE = "Departed";

		/// <summary>
		/// True if arrived, false if departed.
		/// </summary>
		public bool TechArrived;

		public string ArriveDepart => TechArrived ? _ARRIVAL : _DEPARTURE;

		public override string ToString()
		{
			return string.Format("{0} {1} {2:yyyy-MM-dd HH:mm:ss}", TechName, ArriveDepart, EventDateTime);
		}

		public static TimeSpan CalculateTotalTechOnSiteTime(List<ClassTicket_TechOnSiteEvent> events)
		{
			if (events == null || events.Count < 1)
				return TimeSpan.Zero;

			// If there are no tech arrival events but there's one or more events, the list is bogus: report zero.
			if (events.All(e => e.ArriveDepart != _ARRIVAL))
				return TimeSpan.Zero;

			// If there are no tech departure events, tech must still be on site, report based on last arrival time
			if (events.All(e => e.ArriveDepart != _DEPARTURE))
				return DateTime.Now - events.Where(e => e.ArriveDepart == _ARRIVAL).OrderBy(e => e.EventDateTime).Select(e => e.EventDateTime).Last();

			// Iterate through list, summing the total time tech spent on site
			TimeSpan totalTime = new TimeSpan();
			DateTime tempArrivalTime = new DateTime();
			foreach (var techEvent in events.OrderBy(e=>e.EventDateTime))
			{
				switch (techEvent.ArriveDepart)
				{
					case _ARRIVAL:
						tempArrivalTime = techEvent.EventDateTime;
						continue;

					case _DEPARTURE:
						totalTime += (techEvent.EventDateTime - tempArrivalTime);
						continue;
				}
			}

			// If the last event was an arrival, add the time from that arrival until now
			if (events.OrderBy(e => e.EventDateTime).Last().ArriveDepart == _ARRIVAL)
				totalTime += (DateTime.Now - tempArrivalTime);

			return totalTime;
		}
	}
}