using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Curator
{
	internal class ClassUnreceivedRmaEmail
	{
		private readonly MailMessage _message;
		private readonly SmtpClient _client;
		private readonly string _techName;
		private readonly IEnumerable<int> _associatedRmas;

		public ClassUnreceivedRmaEmail(MailMessage message, SmtpClient client, string techName, List<int> associatedRmas)
		{
			#region Validation
			if (!associatedRmas.Any() || associatedRmas == null)
				throw new ArgumentException("RMA numbers must be supplied.");

			if (String.IsNullOrEmpty(message.Subject))
				message.Subject = "NOC Service ESupport Message";
			#endregion

			_message = message;
			_client = client;
			_techName = techName;
			_associatedRmas = associatedRmas;
		}

		public string To
		{
			get { return _message.To.ToString(); }
		}

		public IEnumerable<int> AssociatedRmas
		{
			get { return _associatedRmas; }
		}

		public string TechName
		{
			get { return _techName; }
		}

		public void Send()
		{
			_client.Send(_message);
		}
	}
}