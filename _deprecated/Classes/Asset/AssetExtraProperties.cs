namespace SDB.Classes.Asset
{
	/// <summary>
	/// Properties that are not part of the asset table and are populated on-demand as needed for lists.
	/// </summary>
	public class AssetExtraProperties
	{
		public string CabinetType { get; set; }
		public string ControllerHardware { get; set; }
		public string ControllerSoftware { get; set; }
		public string ControllerConnection { get; set; }
		public string CustomerName { get; set; }
		public string MarketName { get; set; }
		public string OutputMethod { get; set; }
	}
}