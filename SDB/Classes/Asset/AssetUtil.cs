using System;
using System.Collections.Generic;
using System.Linq;
using SDB.Classes.Customer;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public static class AssetUtil
	{
		public static void PopulateExtraProperties(this ClassAsset asset)
		{
			if (asset == null)
				return;

			PopulateExtraProperties(new List<ClassAsset>
			                        {
				                        asset
			                        });
		}

		public static void PopulateExtraProperties(this List<ClassAsset> assets)
		{
			if (assets == null || assets.Count < 1)
				return;

			var allCabinetTypes = ClassCabinetType.GetAll().ToList();
			var allControllerHardware = ControllerHardware.GetAll().ToList();
			var allControllerSoftware = ControllerSoftware.GetAll().ToList();
			var allControllerConnections = ControllerConnection.GetAll().ToList();
			var allOutputMethods = ClassOutputMethod.GetAll().ToList();
			var allMarketAndCustomerNames = ClassCustomer.GetNamesByMarket(assets.Select(a => a.MarketID).ToList());

			foreach (var asset in assets)
			{
                try
                {
                    asset.ExtraProperties.MarketName = allMarketAndCustomerNames[asset.MarketID][0];
				    asset.ExtraProperties.CustomerName = allMarketAndCustomerNames[asset.MarketID][1];
				    if (asset.CabinetTypeId.HasValue)
					    asset.ExtraProperties.CabinetType = allCabinetTypes.Single(c => c.ID == asset.CabinetTypeId.Value).Description;
				    if (asset.OutputMethodId.HasValue)
					    asset.ExtraProperties.OutputMethod = allOutputMethods.Single(o => o.ID == asset.OutputMethodId.Value).Description;
				    if (asset.ControllerHardwareId.HasValue)
					    asset.ExtraProperties.ControllerHardware = allControllerHardware.Single(hw => hw.ID == asset.ControllerHardwareId.Value).Description;
				    if (asset.ControllerSoftwareId.HasValue)
					    asset.ExtraProperties.ControllerSoftware= allControllerSoftware.Single(sw => sw.ID == asset.ControllerSoftwareId.Value).Description;
				    if (asset.ControllerConnectionId.HasValue)
					    asset.ExtraProperties.ControllerConnection = allControllerConnections.Single(conn => conn.ID == asset.ControllerConnectionId.Value).Description;
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog($"Error populating extra properties on asset {asset.ID}", exc);
                }
            }
		}
	}
}