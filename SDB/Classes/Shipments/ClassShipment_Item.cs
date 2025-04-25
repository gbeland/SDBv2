using SDB.Classes.Assembly;

namespace SDB.Classes.Shipments
{
	public class ClassShipment_Item
	{
		public int ID { get; set; }
		public int ShipmentID { get; set; }
		
		/// <summary>
		/// Optional: RMA ID this part is associated with
		/// </summary>
		public int? RMA_ID { get; set; }

		/// <summary>
		/// Optional: Ticket ID this part is associated with
		/// </summary>
		public int? Ticket_ID { get; set; }

		/// <summary>
		/// Optional: Asset ID this part is associated with
		/// </summary>
		public int? Asset_ID { get; set; }

		/// <summary>
		/// Optional for certain views (must join assets table to populate)
		/// </summary>
		public string Asset_Name { get; set; }

		/// <summary>
		/// For asset job number join to assets table. Otherwise populate from independent_jobnumber field.
		/// </summary>
		public string Job_Number { get; set; }

		public string Serial_Number { get; set; }

		public const int SERIAL_NUMBER_MAX_LENGTH = 32;

		public ClassAssemblyType AssemblyType { get; set; }
		public ClassAssembly Assembly { get; set; }

		public int Quantity { set; get; }

		public ClassShipment_Item()
		{
			ID = -1;
			ShipmentID = -1;
			RMA_ID = null;
			Ticket_ID = null;
			Asset_ID = -1;
			Asset_Name = string.Empty;
			Job_Number = string.Empty;
			Serial_Number = string.Empty;

			AssemblyType = null;
			Assembly = null;
			Quantity = 0;
		}

		[UsedImplicitly]
		public string Description => Assembly == null ? AssemblyType.Description : string.Format("{0}: {1} ({2})", AssemblyType.Description, Assembly.AssemblyNumber, Assembly.Description);

		[UsedImplicitly]
		public string PartNumber => Assembly == null ? string.Empty : Assembly.AssemblyNumber;

		public override string ToString()
		{
			return string.Format("{0}x {1}", Quantity, Assembly == null ? AssemblyType.Description : Assembly.Description);
		}
	}
}