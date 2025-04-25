using System.Globalization;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace SDB.Classes.Asset
{
	public static class ClassGeoCode
	{
		private const string _GOOGLE_MAP_API_BASE_URL = @"https://maps.googleapis.com/maps/api/geocode/";

		public struct Address
		{
			public string Lat;
			public string Long;
			public string StatusCode;
		}

		[UsedImplicitly]
		private class GoogleGeoCodeResponse
		{
			public Results[] results { get; set; }
			/// <summary>
			/// Can be OK, ZERO_RESULTS, OVER_QUERY_LIMIT, REQUEST_DENIED, INVALID_REQUEST, or UNKNOWN_ERROR
			/// </summary>
			public string status { get; set; }
		}

		[UsedImplicitly]
		private class Results
		{
			public Geometry geometry { get; set; }
		}

		[UsedImplicitly]
		private class Geometry
		{
			public Location location { get; set; }
		}

		[UsedImplicitly]
		private class Location
		{
			public decimal lat { get; set; }
			public decimal lng { get; set; }
		}

		/// <summary>
		/// Call the Google Map API (V3) to geocode an address.
		/// </summary>
		/// <returns>An <see cref="Address"/> containing the latitude and longitude.</returns>
		public static Address GetAddressV3(string address)
		{
            // Google Maps API v3
            string key = "AIzaSyBo1nCegs1KW48tIwbNzs_6PrqStz5_6K0";

            var args = string.Format(@"json?address={0}&key={1}", HttpUtility.UrlEncode(address), key);

			var requestUrl = string.Format("{0}{1}", _GOOGLE_MAP_API_BASE_URL, args);
			using (var webClient = new WebClient())
			{
				var result = webClient.DownloadString(requestUrl);
				var jss = new JavaScriptSerializer();
				var geoCoded = jss.Deserialize<GoogleGeoCodeResponse>(result);

				var newAddress = new Address();
				newAddress.StatusCode = geoCoded.status;
				newAddress.Lat = geoCoded.results[0].geometry.location.lat.ToString(CultureInfo.InvariantCulture);
				newAddress.Long = geoCoded.results[0].geometry.location.lng.ToString(CultureInfo.InvariantCulture);
				return newAddress;
			}
		}
	}
}