namespace SDB.Classes.RMA
{
	public class ClassLegacyRMA_RepairTypes
	{
		/// <summary>
		/// String collection that describes various conditions that exist which require repair or replacement.
		/// </summary>
		public readonly string[] Conditions =
		{
			"",
			"Broken traces",
			"Broken Traces: Due to corrosion",
			"Burnt PCB",
			"Coating in EPROM socket",
			"Corrosion: Extensive corrosion",
			"Corrosion: Inside headers",
			"Corrosion: On LED Drivers",
			"Corrosion: On pigtails",
			"Corrosion: On R pots",
			"Corrosion: Under caps",
			"Corrosion: Under headers causing broken traces",
			"Corrosion: Under headers causing shorted pins",
			"No problems found",
			"Old style rectifier",
			"Possible power surge",
			"R Pots: Adjusted",
			"R Pots: Bad solder",
			"R Pots: Broken",
			"Cold Solder Joint",
			"Insufficient Solder",
			"Lack of Solder",
			"Pins crimped into traces",
			"Incorrect Component Orientation",
			"Bad Solder"
		};

		/// <summary>
		/// String collection that describes repair or replacement actions performed (in response to a condition).
		/// </summary>
		public readonly string[] RepairActions =
		{
			"",
			"Added Component(s)",
			"Adjusted Pots/Switches/Trimcaps",
			"Bridged/Shorted Trace",
			"Broken/Open Trace",
			"Cleaned",
			"Cold Solder Joint",
			"Computer: Hardware - Cooling",
			"Computer: Hardware - CPU",
			"Computer: Hardware - Hard Drive",
			"Computer: Hardware - Motherboard",
			"Computer: Hardware - Other",
			"Computer: Hardware - Power Supply",
			"Computer: Hardware - RAM/Memory",
			"Computer: Software - Configuration",
			"Computer: Software - OS",
			"Computer: Software - Other",
			"Computer: Software - Reinstall",
			"Discarded",
			"Forwarded to Supplier",
			"Multiple Problems Repaired (See Notes)",
			"No Repair Needed (Tested OK)",
			"Redirected to Other Yesco Branch",
			"Replaced Component(s)",
			"Replaced with New",
			"Replaced with Refurb",
			"Returned to Inventory",
			"Other"
		};
	}
}
