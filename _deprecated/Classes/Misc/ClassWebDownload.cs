using System;
using System.Net;

namespace SDB.Classes.Misc
{
	/// <summary>
	/// A WebClient with a configurable timeout
	/// </summary>
	public class ClassWebDownload : WebClient
	{
		/// <summary>
		/// Time in milliseconds.
		/// </summary>
		public int Timeout { get; set; }

		public ClassWebDownload() : this(60000)
		{
		}

		public ClassWebDownload(int timeout)
		{
			Timeout = timeout;
		}

		protected override WebRequest GetWebRequest(Uri address)
		{
			var request = base.GetWebRequest(address);
			if (request != null)
			{
				request.Timeout = Timeout;
			}
			return request;
		}
	}
}