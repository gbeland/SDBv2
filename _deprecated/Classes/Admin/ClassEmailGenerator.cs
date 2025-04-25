using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Tech;
using SDB.Classes.Ticket;
using SDB.Classes.User;
// ReSharper disable RedundantVerbatimStringPrefix

namespace SDB.Classes.Admin
{
	/// <summary>
	/// Generates email messages (and attachments) for various outbound email functions throughout the SDB.
	/// </summary>
	public static class ClassEmailGenerator
	{
		private static readonly string _OSA_COVER_FILE = Path.Combine(Application.StartupPath, @"Required Files", @"OSA_Cover.pdf");
		private static readonly string _OSA_CHECKLIST_FILE = Path.Combine(Application.StartupPath, @"Required Files", @"OSA_Checklist.pdf");
		private static readonly string _OSA_TEMPLATE_FILE = Path.Combine(Application.StartupPath, @"Required Files", @"template.rtf");
        private static readonly string _PMC_TEMPLATE_FILE = Path.Combine(Application.StartupPath, @"Required Files", @"pmc_template.rtf");

        /// <summary>
        /// Provides a three-line string with the service company name and address.
        /// </summary>
        private static string ServiceFooter
		{
			get
			{
				var sb = new StringBuilder();

				sb.AppendLine(ClassConfig.GetServiceCompany());
				sb.AppendLine(ClassConfig.GetServiceAddress());
				sb.AppendLine(ClassConfig.GetServicePhone());

				return sb.ToString();
			}
		}

		/// <summary>
		/// Provides an HTML three-line string with the service company name and address.
		/// </summary>
		private static string ServiceFooterHtml
		{
			get
			{
				var sb = new StringBuilder();

				sb.AppendLine("<strong>" + ClassConfig.GetServiceCompany() + "</strong><br />");
				var address = Regex.Replace(ClassConfig.GetServiceAddress(), @"\r\n?|\n", "<br />");
				sb.AppendLine(address + "<br />");
				var phone = Regex.Replace(ClassConfig.GetServicePhone(), @"\r\n?|\n", "<br />");
				sb.AppendLine(phone + "<br />");

				return sb.ToString();
			}
		}

		/// <summary>
		/// Provides a three-line string with the main company name and address.
		/// </summary>
		private static string MainFooter
		{
			get
			{
				var sb = new StringBuilder();

				sb.AppendLine(ClassConfig.GetMainCompany());
				sb.AppendLine(ClassConfig.GetMainAddress());
				sb.AppendLine(ClassConfig.GetMainPhone());

				return sb.ToString();
			}
		}

		/// <summary>
		/// Provides an HTML three-line string with the main company name and address.
		/// </summary>
		private static string MainFooterHtml
		{
			get
			{
				var sb = new StringBuilder();
        
				sb.AppendLine("<strong>" + ClassConfig.GetMainCompany() + "</strong><br />");
				var address = Regex.Replace(ClassConfig.GetMainAddress(), @"\r\n?|\n", "<br />");
				sb.AppendLine(address + "<br />");
				var phone = Regex.Replace(ClassConfig.GetMainPhone(), @"\r\n?|\n", "<br />");
				sb.AppendLine(phone + "<br />");

				return sb.ToString();
			}
		}
		
		/// <summary>
		/// Generates an email for a ticket open (or re-open) event.
		/// </summary>
		private static MailMessage GenerateEmail_Ticket_OpenOrReOpen(ClassTicket ticket, out string status, bool isReopen = false, DateTime? reOpenDt = null)
		{
			var asset = ClassAsset.GetByID(ticket.AssetID);
			var market = ClassMarket.GetByID(asset.MarketID);

			#region Validation
			if (string.IsNullOrEmpty(market.GetCombinedEmailList()))
			{
				status = "No valid email addresses.";
				return null;
			}
			#endregion

			var customer = ClassCustomer.GetByID(market.CustomerID);
			var openUser = ClassUser.GetByID(ticket.Open_UserID);

			var sb = new StringBuilder();
			sb.AppendFormat("{0},", customer.Name).AppendLine().AppendLine();
			sb.AppendFormat("Ticket number {0} has been {1}opened by Prismview.", ticket.ID, isReopen ? "re-" : string.Empty).AppendLine();
			if (!string.IsNullOrEmpty(ticket.CustomerIssueNumber))
				sb.AppendFormat("Customer Issue #: {0}", ticket.CustomerIssueNumber).AppendLine();
			sb.AppendLine();
			sb.AppendFormat("Asset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("Panel: {0}", string.IsNullOrEmpty(asset.Panel) ? "[No Panel Designation]" : asset.Panel).AppendLine();
			sb.AppendFormat("Location: {0}  Facing {1}", asset.Location, asset.FacingDirection).AppendLine();
			sb.AppendFormat("Address: {0}, {1}, {2} {3}", asset.Address.NullIfEmpty() ?? "[No Address]", asset.City, asset.State, asset.Country).AppendLine();
			sb.AppendLine();
			sb.AppendFormat("Issue: {0}", ticket.ExtraProperties.Symptoms()).AppendLine();
			sb.AppendLine();
			var timeZoneName = TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now) ? TimeZone.CurrentTimeZone.DaylightName : TimeZone.CurrentTimeZone.StandardName;
			sb.AppendFormat("Opened: {0:yyyy-MM-dd HH:mm} ({1})", ticket.OpenDateTime, timeZoneName).AppendLine();
			if (isReopen)
				sb.AppendFormat("Re-opened: {0:yyyy-MM-dd HH:mm} ({1})", reOpenDt, timeZoneName).AppendLine();
			sb.AppendLine();
			sb.AppendFormat("Reported by: {0} via {1}", ticket.ReportedBy, ticket.ReportedType).AppendLine();
			sb.AppendFormat("Opened by: {0}", openUser.FirstL).AppendLine();
			sb.AppendLine();

			sb.AppendLine(ServiceFooter);

			var serviceEmail = ClassConfig.GetServiceEmail();
			var openMessage = new MailMessage { From = serviceEmail };
			openMessage.ReplyToList.Add(serviceEmail);
			openMessage.To.Add(market.GetCombinedEmailList().Trim(','));
			var assetOrPanel = string.IsNullOrEmpty(asset.Panel) ? "asset " + asset.AssetName : "panel " + asset.Panel;
			openMessage.Subject = $"Prismview has {(isReopen ? "re-" : string.Empty)}opened ticket {ticket.ID} for {assetOrPanel}";
			openMessage.Body = sb.ToString();

			status = string.Empty;
			return openMessage;
		}

		/// <summary>
		/// Generates an email for a ticket re-open event.
		/// </summary>
		public static MailMessage GenerateEmail_Ticket_ReOpen(ClassTicket ticket, DateTime reOpenDt, out string status)
		{
			return GenerateEmail_Ticket_OpenOrReOpen(ticket, out status, true, reOpenDt);
		}

		/// <summary>
		/// Generates an email for a ticket open event.
		/// </summary>
		public static MailMessage GenerateEmail_Ticket_Open(ClassTicket ticket, out string status)
		{
			return GenerateEmail_Ticket_OpenOrReOpen(ticket, out status);
		}

		/// <summary>
		/// Creates OSA document from template.rtf and saves it as OSA.doc.
		/// </summary>
		/// <param name="ticket">The ticket for this OSA.</param>
		/// <param name="asset">The asset for this OSA.</param>
		/// <param name="tech">The assigned tech.</param>
		/// <returns>True if document creation was successful.</returns>
		public static bool GenerateDocument_PMC(ClassTicket ticket, ClassAsset asset, ClassTech tech)
		{
            //PMC id is 1227
            if (tech == null || tech.ID == 1227)
                tech = null;
			try
			{
                ClassMarket m = ClassMarket.GetByID(asset.MarketID);


                var fileData = File.ReadAllText(_PMC_TEMPLATE_FILE);

				fileData = fileData.Replace("*panel_name*", asset.Panel);
				fileData = fileData.Replace("*ticket_id*", "Ticket #" + ticket.ID.ToString()); // TODO: Deal with tech addresses that have CRLFs; they don't appear properly in RTF
				fileData = fileData.Replace("*tech_name*", tech != null ? tech.TechName : string.Empty);
				fileData = fileData.Replace("*tech_contact*", tech != null ? tech.Contact1_Name : string.Empty);
				fileData = fileData.Replace("*tech_address*", tech != null ? tech.Address : string.Empty);
				fileData = fileData.Replace("*tech_city*", tech != null ? tech.City : string.Empty);
				fileData = fileData.Replace("*tech_state*", tech != null ? tech.State : string.Empty);
				fileData = fileData.Replace("*tech_zip*", tech != null ? tech.Zip : string.Empty);
				fileData = fileData.Replace("*tech_phone*", tech != null ? tech.Contact1_Telephone : string.Empty);
				fileData = fileData.Replace("*tech_emails*", tech != null ? tech.Email : string.Empty);
                fileData = fileData.Replace("*display_s_number*", asset.SerialNumber);
                fileData = fileData.Replace("*warranty_date*", asset.WarrantyInfo.LaborContractExpire.HasValue ? asset.WarrantyInfo.LaborContractExpire.Value.ToString("MMMM dd, yyyy") : "Error with Labor warrenty date");
                fileData = fileData.Replace("*market_name*", m.Name);
                fileData = fileData.Replace("*market_contact*", m.Contact1_Name);
                fileData = fileData.Replace("*display_address*", asset.Address);
                fileData = fileData.Replace("*display_city*", asset.City);
                fileData = fileData.Replace("*display_state*", asset.State);
                fileData = fileData.Replace("*display_zip*", asset.Zip);
                fileData = fileData.Replace("*market_phone*", m.Telephone);
                fileData = fileData.Replace("*market_email*", m.Email_Addresses);
                fileData = fileData.Replace("*problem*", ticket.OSANotes);


                var tempPath = Path.GetTempPath();
				var pmcFile = Path.Combine(tempPath, $"{ticket.ID}_PMC.doc");
				File.WriteAllText(pmcFile, fileData);

				return true;
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show("Cannot create OSA document: " + exc.Message, "OSA Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
        public static MailMessage GenerateEmail_PMC(ClassTicket ticket, ClassAsset ticketAsset, ClassTech ticketTech, out string status)
        {
            #region Validation
            if (!GenerateDocument_PMC(ticket, ticketAsset, ticketTech))
            {
                status = "Cannot generate PMC document. PMC template missing, or file I/O problem.";
                return null;
            }
            
            #endregion

            ticketAsset.PopulateExtraProperties();
            var sb = new StringBuilder();
            sb.Append("Please find attached the authorization for work to be completed on:<br /><br />").AppendLine();
            sb.AppendFormat("<strong>Asset:</strong> {0}<br />", ticketAsset.AssetName).AppendLine();
            sb.AppendFormat("<strong>Panel:</strong> {0}<br />", ticketAsset.Panel).AppendLine();
            sb.AppendFormat("<strong>Owner:</strong> {0}{1}<br />",
                ticketAsset.ExtraProperties.CustomerName,
                string.IsNullOrEmpty(ticketAsset.ExtraProperties.MarketName) ? string.Empty : $" ({ticketAsset.ExtraProperties.MarketName} market)").AppendLine();
            sb.AppendLine("<br />");
            sb.Append("<strong>Location:</strong><br />").AppendLine();
            sb.Append("<pre>" + ticketAsset.LocationMultiLine + "</pre><br />").AppendLine();

            sb.AppendLine("<br />");

            sb.Append(MainFooterHtml);

            var fromAddress = ClassConfig.GetServiceEmail();
            var pmcMessage = new MailMessage
            {
                From = fromAddress,
                IsBodyHtml = true
            };
            pmcMessage.ReplyToList.Add(fromAddress);
            try
            {
                pmcMessage.To.Add("todd@preferredmaintenance.net, ssrsupport@prismview.com, taspinwall@prismview.com");
            }
            catch
            {
                MessageBox.Show("Failed to send email due to broken email address. How did you manage that? They are literally hard coded... Are you trying to give me a brain aneurysm? Please stop..... please");
                throw;
            }

            pmcMessage.Subject = string.Format("Service Authorization: #{0}", ticket.ID);
            pmcMessage.Body = sb.ToString();
            
            try
            {
                var pmcFile = Path.Combine(Path.GetTempPath(), string.Format("{0}_PMC.doc", ticket.ID));
                pmcMessage.Attachments.Add(new Attachment(pmcFile));
            }
            catch (Exception exc)
            {
                ClassLogFile.AppendToLog(exc);
                MessageBox.Show(string.Format("PMC document could not be attached.{0}{0}{1}", Environment.NewLine, exc), "OSA EMail Attachment Error", MessageBoxButtons.OK);
            }
            

            status = string.Empty;
            return pmcMessage;
        }


        public static bool GenerateDocument_OSA(ClassTicket ticket, ClassAsset asset, ClassTech tech)
        {
            if (tech == null)
                return false;

            var userOpen = ClassUser.GetByID(ticket.Open_UserID);

            try
            {
                var fileData = File.ReadAllText(_OSA_TEMPLATE_FILE);
                string billTo = " Prismview \\line Accounts Payable \\line 1651 N 1000 W \\line Logan, UT 84321 \\line Fax 435-774-8804";

                if (asset.WarrantyInfo.BillToMarket)
                {
                    var market = ClassMarket.GetByID((ClassMarket.GetMarketIDByAsset(asset.ID)));
                    billTo = market.NameWithCustomerName;
                }

                switch (ticket.IssuePriority)
                {
                    case 3:
                        fileData = fileData.Replace("*issue_priority*", "CRITICAL");
                        break;
                    case 2:
                        fileData = fileData.Replace("*issue_priority*", "HIGH");
                        break;
                    case 1:
                        fileData = fileData.Replace("*issue_priority*", "NORMAL");
                        break;
                }

                if (asset.IsLaborCovered)
                    if (asset.WarrantyInfo.BillToMarket)
                        fileData = fileData.Replace("*labor*", "BILL TO MARKET");
                    else fileData = fileData.Replace("*labor*", "YES");
                else fileData = fileData.Replace("*labor*", "NO");

                if (asset.IsPartsCovered)
                    fileData = fileData.Replace("*parts*", "YES");
                else fileData = fileData.Replace("*parts*", "NO");

                fileData = fileData.Replace("*reminder*", asset.ServiceReminder);
                fileData = fileData.Replace("*bill_to*", billTo);
                fileData = fileData.Replace("*access_notes*", asset.AccessNotes);
                fileData = fileData.Replace("*hagl*", asset.HeightAboveGroundLevel.ToString());
                fileData = fileData.Replace("*tech*", tech.TechName);
                fileData = fileData.Replace("*address*", tech.Address); // TODO: Deal with tech addresses that have CRLFs; they don't appear properly in RTF
                fileData = fileData.Replace("*city*", $"{tech.City}, {tech.State} {tech.Zip}");
                fileData = fileData.Replace("*tel*", tech.Telephone);
                fileData = fileData.Replace("*fax*", tech.Fax);
                fileData = fileData.Replace("*date*", ticket.OpenDateTime.ToString("MM/dd/yyyy"));
                fileData = fileData.Replace("*issueby*", userOpen.FirstL);
                fileData = fileData.Replace("*po*", "QP" + ticket.ID);
                fileData = fileData.Replace("*cont*", asset.ActiveLaborNumber);
                fileData = fileData.Replace("*osa*", asset.AssetName);
                fileData = fileData.Replace("*jobname*", $"{asset.AssetName}{ClassUtility.StringFormatNull(" ({0})", string.Empty, asset.Panel)}");
                var facing = string.IsNullOrEmpty(asset.FacingDirection) ? string.Empty : $" ({asset.FacingDirection} face)";
                fileData = fileData.Replace("*location*", $"{asset.Location}{facing}; {asset.Address.NullIfEmpty() ?? "[NO ADDRESS]"} in {asset.City}, {asset.State}{(asset.Latitude.HasValue && asset.Longitude.HasValue ? string.Format(" (Lat: {0}, Long: {1})", asset.Latitude, asset.Longitude) : string.Empty)}");
                fileData = fileData.Replace("*complaint*", ticket.ExtraProperties.Symptoms());
                var accessNotes = string.IsNullOrEmpty(asset.AccessNotes) ? string.Empty : $" Access Notes: {asset.AccessNotes}";
                fileData = fileData.Replace("*comments*", $"{ticket.OSANotes}");
                fileData = fileData.Replace("*auth*", userOpen.FirstL);

                var tempPath = Path.GetTempPath();
                var osaFile = Path.Combine(tempPath, $"{ticket.ID}_OSA.doc");
                File.WriteAllText(osaFile, fileData);

                return true;
            }
            catch (Exception exc)
            {
                ClassLogFile.AppendToLog(exc);
                MessageBox.Show("Cannot create OSA document: " + exc.Message, "OSA Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Creates the email message for an OSA (including the OSA document) and attaches necessary files.
        /// </summary>
        /// <param name="ticket">The ticket for this OSA.</param>
        /// <param name="ticketAsset">The asset for this OSA.</param>
        /// <param name="ticketTech">The assigned tech.</param>
        /// <param name="status">If message cannot be generated, information about why.</param>
        /// <returns>The generated MailMessage or null if unsuccessful.</returns>
        public static MailMessage GenerateEmail_OSA(ClassTicket ticket, ClassAsset ticketAsset, ClassTech ticketTech, out string status)
		{
			#region Validation
			if (!GenerateDocument_OSA(ticket, ticketAsset, ticketTech))
			{
				status = "Cannot generate OSA document. Tech may be null, OSA template missing, or file I/O problem.";
				return null;
			}

			if (string.IsNullOrEmpty(ticketTech.Email))
			{
				status = $"Cannot create OSA email, {ticketTech.TechName} does not have a valid email address.";
				return null;
			}
			#endregion

			ticketAsset.PopulateExtraProperties();
			var sb = new StringBuilder();
			sb.Append("Please find attached the authorization for work to be completed on:<br /><br />").AppendLine();
			sb.AppendFormat("<strong>Asset:</strong> {0}<br />", ticketAsset.AssetName).AppendLine();
			sb.AppendFormat("<strong>Panel:</strong> {0}<br />", ticketAsset.Panel).AppendLine();
			sb.AppendFormat("<strong>Owner:</strong> {0}{1}<br />",
				ticketAsset.ExtraProperties.CustomerName,
				string.IsNullOrEmpty(ticketAsset.ExtraProperties.MarketName) ? string.Empty : $" ({ticketAsset.ExtraProperties.MarketName} market)").AppendLine();
			sb.AppendLine("<br />");
			sb.Append("<strong>Location:</strong><br />").AppendLine();
			sb.Append("<pre>" + ticketAsset.LocationMultiLine + "</pre><br />").AppendLine();
			
			sb.AppendLine("<br />");

			sb.Append(MainFooterHtml);

			var fromAddress = ClassConfig.GetServiceEmail();
			var osaMessage = new MailMessage
			                 {
				                 From = fromAddress,
				                 IsBodyHtml = true
			                 };
			osaMessage.ReplyToList.Add(fromAddress);
			try
			{
				osaMessage.To.Add(ticketTech.Email.Replace(";", ",").Trim(','));
			}
			catch
			{
				MessageBox.Show(string.Format("Error generating OSA email. Invalid email address(es):{0}{0}\"{1}\"", Environment.NewLine, ticketTech.Email));
				throw;
			}

			osaMessage.Subject = string.Format("Service Authorization: QP{0}", ticket.ID);
			osaMessage.Body = sb.ToString();

			try
			{
				osaMessage.Attachments.Add(new Attachment(_OSA_COVER_FILE));
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("OSA cover page could not be attached.{0}{0}{1}", Environment.NewLine, exc), "OSA Email Attachment Error", MessageBoxButtons.OK);
			}

			try
			{
				var osaFile = Path.Combine(Path.GetTempPath(), string.Format("{0}_OSA.doc", ticket.ID));
				osaMessage.Attachments.Add(new Attachment(osaFile));
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("OSA document could not be attached.{0}{0}{1}", Environment.NewLine, exc), "OSA EMail Attachment Error", MessageBoxButtons.OK);
			}

			try
			{
				osaMessage.Attachments.Add(new Attachment(_OSA_CHECKLIST_FILE));
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("OSA checklist could not be attached.{0}{0}{1}", Environment.NewLine, exc), "OSA Email Attachment Error", MessageBoxButtons.OK);
			}

			if (ticket.ExtraProperties.OSA_Image != null)
				try
				{
					osaMessage.Attachments.Add(new Attachment(new MemoryStream(ClassUtility.ImageToByteArray(ticket.ExtraProperties.OSA_Image)), string.Format("{0}_OSA_Image.jpg", ticket.ID)));
				}
				catch (Exception exc)
				{
					ClassLogFile.AppendToLog(exc);
					MessageBox.Show(string.Format("Ticket image could not be attached.{0}{0}{1}", Environment.NewLine, exc), "OSA Email Attachment Error", MessageBoxButtons.OK);
				}

			status = string.Empty;
			return osaMessage;
		}

		public static MailMessage GenerateEmail_OSA(ClassTicket ticket, out string status)
		{
			if (!ticket.TechID.HasValue)
			{
				status = "No tech specified.";
				return null;
			}

			var ticketAsset = ClassAsset.GetByID(ticket.AssetID);
			var ticketTech = ClassTech.GetByID(ticket.TechID.Value);
			return GenerateEmail_OSA(ticket, ticketAsset, ticketTech, out status);
		}

		/// <summary>
		/// Generates an email for a tech-on-site event.
		/// </summary>
		/// <param name="ticket">The ticket with tech arriving.</param>
		/// <param name="status">If message cannot be generated, information about why.</param>
		public static MailMessage GenerateEMail_TechOnSite(ClassTicket ticket, out string status)
		{
			var asset = ClassAsset.GetByID(ticket.AssetID);
			var market = ClassMarket.GetByID(asset.MarketID);

			#region Validation
			if (string.IsNullOrEmpty(market.GetCombinedEmailList()))
			{
				status = "No valid email addresses.";
				return null;
			}
			#endregion

			var sb = new StringBuilder();
			sb.AppendLine("Status Update:").AppendLine();
			sb.AppendLine();

			sb.AppendFormat("Prismview Ticket #: {0}", ticket.ID).AppendLine();
			if(!string.IsNullOrEmpty(ticket.CustomerIssueNumber))
				sb.AppendFormat("Customer Issue #: {0}", ticket.CustomerIssueNumber).AppendLine();
			sb.AppendFormat("Asset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("Panel: {0}", asset.Panel).AppendLine();
			sb.AppendFormat("Location: {0}", asset.Location).AppendLine();
			sb.AppendLine();

			sb.Append("The Prismview certified subcontractor has arrived on site to service the problem at this location. ");
			// TODO: Following depends on content of symptom, and should be refactored eventually
			if (ticket.ExtraProperties.SymptomList.Any(s => s.Symptom.ToLower() == "all out"))
			{
				sb.Append("This ticket was opened as an \"ALL OUT\", and the PC might need to be replaced during this visit. ");
				sb.Append("If you need content loaded, you will need to be at your PC. ");
			}
			sb.Append("If you have questions or concerns please contact us and reference the Prismview ticket number.");
			sb.AppendLine().AppendLine();
			var serviceEmail = ClassConfig.GetServiceEmail();
			sb.AppendLine("Email: " + serviceEmail.Address).AppendLine();

			sb.AppendLine(ServiceFooter);

			var techOnSiteMessage = new MailMessage { From = serviceEmail };
			techOnSiteMessage.ReplyToList.Add(serviceEmail);
			techOnSiteMessage.To.Add(market.GetCombinedEmailList().Trim(','));
			var assetOrPanel = string.IsNullOrEmpty(asset.Panel) ? "asset " + asset.AssetName : "panel " + asset.Panel;
			techOnSiteMessage.Subject = $"Prismview Ticket Status Update for {assetOrPanel}";
			techOnSiteMessage.Body = sb.ToString();

			status = string.Empty;
			return techOnSiteMessage;
		}

		/// <summary>
		/// Generates an email for a ticket close event.
		/// </summary>
		/// <param name="ticket">The ticket being closed.</param>
		/// <param name="status">If message cannot be generated, information about why.</param>
		public static MailMessage GenerateEmail_Close(ClassTicket ticket, out string status)
		{
			var asset = ClassAsset.GetByID(ticket.AssetID);
			var market = ClassMarket.GetByID(asset.MarketID);

			#region Validation
			if (string.IsNullOrEmpty(market.GetCombinedEmailList()))
			{
				status = "No valid email addresses.";
				return null;
			}
			#endregion

			var customer = ClassCustomer.GetByID(market.CustomerID);
			var closeUser = new ClassUser();
			if (ticket.Close_UserID.HasValue)
				closeUser = ClassUser.GetByID(ticket.Close_UserID.Value);

			var sb = new StringBuilder();
			sb.AppendFormat("{0},", customer.Name).AppendLine().AppendLine();

			sb.AppendFormat("Ticket number {0} has been closed by Prismview.", ticket.ID).AppendLine();
			sb.AppendLine();
			
			if (!string.IsNullOrEmpty(ticket.CustomerIssueNumber))
			{
				sb.AppendFormat("Customer Issue #: {0}", ticket.CustomerIssueNumber).AppendLine();
				sb.AppendLine();
			}

			sb.AppendFormat("Asset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("Panel: {0}", string.IsNullOrEmpty(asset.Panel) ? "N/A" : asset.Panel).AppendLine();
			sb.AppendFormat("Location: {0}, {1}", asset.Location, asset.City).AppendLine();
			sb.AppendLine();

			sb.AppendFormat("Symptom(s): {0}", ticket.ExtraProperties.Symptoms()).AppendLine();
			sb.AppendFormat("Resolution: {0}", ticket.ExtraProperties.Solutions(true)).AppendLine();
			sb.AppendFormat("Notes: {0}", ticket.Solution_Notes).AppendLine();
			sb.AppendLine();

			sb.AppendFormat("Opened: {0:yyyy-MM-dd HH:mm} (MST)", ticket.OpenDateTime).AppendLine();
			sb.AppendFormat("Reported by: {0} via {1}", ticket.ReportedBy, ticket.ReportedType).AppendLine();
			if (ticket.FirstTechArrivalDateTime.HasValue)
				sb.AppendFormat("Tech Arrived: {0:yyyy-MM-dd HH:mm} (MST)", ticket.FirstTechArrivalDateTime).AppendLine();
			sb.AppendFormat("Closed: {0:yyyy-MM-dd HH:mm} (MST)", ticket.CloseDateTime.GetValueOrDefault(DateTime.MinValue)).AppendLine();
			sb.AppendFormat("Closed by: {0}", closeUser.FirstL).AppendLine();
			sb.AppendLine();

			sb.AppendLine(ServiceFooter);
			
			var serviceEmail = ClassConfig.GetServiceEmail();
			var closeMessage = new MailMessage { From = serviceEmail };
			closeMessage.ReplyToList.Add(serviceEmail);
			closeMessage.To.Add(market.GetCombinedEmailList().Trim(','));
			var assetOrPanel = string.IsNullOrEmpty(asset.Panel) ? "asset " + asset.AssetName : "panel " + asset.Panel;
			closeMessage.Subject = $"Prismview has closed ticket {ticket.ID} for {assetOrPanel}.";
			closeMessage.Body = sb.ToString();

			status = string.Empty;
			return closeMessage;
		}

		/// <summary>
		/// An email that notifies tech/subcontractor of a newly-created RMA.
		/// Carbon-copies market if that market is configured to receive them.
		/// </summary>
		public static MailMessage GenerateEmail_RMA(ClassRMA rma)
		{
			var rmaTech = ClassTech.GetByID(rma.TechID);
			var rmaAsset = ClassAsset.GetByID(rma.AssetID);
			var rmaMarket = ClassMarket.GetByID(rmaAsset.MarketID);
			var rmaTicket = ClassTicket.GetByID(rma.TicketID);
			var rmaAssemblies = ClassRMA.ClassRMAAssembly.GetRMAAssemblies(rma.ID).ToList();

			var sb = new StringBuilder();
			sb.AppendFormat("{0},", rmaTech.TechName).AppendLine();
			sb.AppendLine();
			sb.AppendFormat("RMA {0} has been created under ticket {1}.", rma.ID, rmaTicket.ID).AppendLine();
			sb.AppendFormat("This is for display: {0} ({1}) located at {2}, {3}, {4}.", rmaAsset.AssetName, rmaAsset.Panel, rmaAsset.Location, rmaAsset.City, rmaAsset.State).AppendLine();
			sb.AppendLine();
			sb.AppendLine();

			var returnableAssemblies = rmaAssemblies.Where(a => !a.Discarded).ToList();
			var discardedAssemblies = rmaAssemblies.Where(a => a.Discarded).ToList();

			if (returnableAssemblies.Any())
			{
				sb.AppendFormat("The following parts need to be tagged and returned to the Prismview service department within 30 days:").AppendLine();
				sb.AppendLine();

				foreach (var returnableGroup in returnableAssemblies.GroupBy(a => a.AssemblyType_ID))
					sb.AppendFormat("{0} {1}", returnableGroup.Count(), returnableGroup.First().AssemblyTypeDescription).AppendLine();

				sb.AppendLine();
				sb.AppendLine();
			}

			if (discardedAssemblies.Any())
			{
				sb.AppendFormat("The following parts have been marked as discarded and DO NOT need to be returned:").AppendLine();
				sb.AppendLine();

				foreach (var discardedGroup in discardedAssemblies.GroupBy(a => a.AssemblyType_ID))
					sb.AppendFormat("{0} {1}", discardedGroup.Count(), discardedGroup.First().AssemblyTypeDescription).AppendLine();

				sb.AppendLine();
				sb.AppendLine();
			}

			sb.AppendLine();
			sb.AppendLine("SHIP TO:");
			sb.AppendLine();

			sb.Append("Attention: RMA Receiving").AppendLine();
			sb.AppendFormat("RMA #{0}", rma.ID).AppendLine();
			sb.AppendLine(ClassConfig.GetServiceAddress());
			sb.AppendLine();
			sb.AppendLine();

			sb.Append("Failure to do so will result in non-payment of your service invoice.").AppendLine().AppendLine();

			// Don't use normal footer here. Omit main company address to avoid RMAs being shipped to wrong address.
			sb.AppendLine(ClassConfig.GetServiceCompany());
			sb.AppendLine(ClassConfig.GetServicePhone());

			var serviceEmail = ClassConfig.GetServiceEmail();
			var rmaMessage = new MailMessage { From = serviceEmail };
			rmaMessage.ReplyToList.Add(serviceEmail);
			rmaMessage.To.Add(rmaTech.Email.Trim(','));
			if (rmaMarket.SendEmail_RmaCreated && rmaMarket.GetCombinedEmailList().Any())
				rmaMessage.CC.Add(rmaMarket.GetCombinedEmailList());
			rmaMessage.Subject = string.Format("Prismview Service: RMA {0} Issued", rma.ID);
			rmaMessage.Body = sb.ToString();

			return rmaMessage;
		}

		/// <summary>
		/// An email that notifies managers that supervisor override was used to allow an OSA send.
		/// </summary>
		/// <param name="ticket">The ticket associated with the OSA, for ticket ID and symptom information.</param>
		/// <param name="asset">The asset for the ticket, for ownership and warranty information.</param>
		/// <param name="supervisor">The supervisor providing the override.</param>
		public static MailMessage GenerateEmail_Supervisor_OsaCreate(ClassTicket ticket, ClassAsset asset, ClassUser supervisor)
		{
			var sb = new StringBuilder();

			sb.AppendFormat("An OSA has been created for ticket {0} and assigned to {1}.", ticket.ID, ticket.ExtraProperties.AssignedTechName).AppendLine();
			sb.AppendFormat("\tCustomer: {0}", asset.ExtraProperties.CustomerName).AppendLine();
			sb.AppendFormat("\tMarket: {0}", asset.ExtraProperties.MarketName).AppendLine();
			sb.AppendFormat("\tAsset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("\tPanel: {0}", asset.Panel).AppendLine();
			sb.Append("\tWarranty Information:").AppendLine();
			sb.AppendFormat("\t\tLabor W/C: {0}{1}", asset.ActiveLaborNumber, asset.WarrantyInfo.MonitoringContractOnly ? " (Monitoring Only)" : string.Empty).AppendLine();
			sb.AppendFormat("\t\tParts W/C: {0}", asset.ActivePartsNumber).AppendLine();
			sb.AppendFormat("\t\tLabor Warranty Expire: {0}", asset.WarrantyInfo.LaborWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tLabor Contract Expire: {0}", asset.WarrantyInfo.LaborContractExpire).AppendLine();
			sb.AppendFormat("\t\tParts Warranty Expire: {0}", asset.WarrantyInfo.PartsWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tParts Contract Expire: {0}", asset.WarrantyInfo.PartsContractExpire).AppendLine().AppendLine();

			sb.AppendFormat("\tSymptoms: {0}", ticket.ExtraProperties.Symptoms()).AppendLine().AppendLine();

			sb.AppendFormat("Ticket {0}", ticket.ID).AppendLine();
			sb.AppendFormat("Opened by: {0} ({1})", GS.Settings.LoggedOnUser.FirstL, GS.Settings.LoggedOnUser.ID).AppendLine();
			sb.AppendFormat("Approved by: {0} ({1})", supervisor.FirstL, supervisor.ID).AppendLine();
			sb.AppendFormat("OSA Sent: {0}", ticket.TechID.HasValue ? $"Yes, to {ticket.ExtraProperties.AssignedTechName}" : "No").AppendLine();
			sb.AppendFormat("Open Sent: {0}", ticket.OpenOption_SendEmail_Open ? $"Yes, to {asset.ExtraProperties.MarketName}" : "No").AppendLine();

			var serviceEmail = ClassConfig.GetServiceEmail();
			var svMessage = new MailMessage { From = serviceEmail };
			svMessage.ReplyToList.Add(serviceEmail);
			foreach (var address in ClassAdminEmail.GetAllAsMailAddresses())
				svMessage.To.Add(address);
			svMessage.Subject = $"Supervisor-Authorized OSA (#{ticket.ID}) Sent";
			svMessage.Body = sb.ToString();

			return svMessage;
		}

		/// <summary>
		/// An email that notifies managers that supervisor override was used to rent equipment for non-covered asset.
		/// </summary>
		/// <param name="ticket">The ticket associated with the OSA, for ticket ID and symptom information.</param>
		/// <param name="asset">The asset for the ticket, for ownership and warranty information.</param>
		/// <param name="rental">Rental information.</param>
		/// <param name="supervisor">The supervisor providing the override.</param>
		public static MailMessage GenerateEmail_Supervisor_NewRental(ClassTicket ticket, ClassAsset asset, ClassTicket_Rental rental, ClassUser supervisor)
		{
			var sb = new StringBuilder();

			sb.AppendFormat("Equipment has been rented for ticket {0} from {1}.", ticket.ID, rental.Rental_Company_Name).AppendLine();
			sb.AppendFormat("\tCustomer: {0}", asset.ExtraProperties.CustomerName).AppendLine();
			sb.AppendFormat("\tMarket: {0}", asset.ExtraProperties.MarketName).AppendLine();
			sb.AppendFormat("\tAsset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("\tPanel: {0}", asset.Panel).AppendLine();
			sb.Append("\tWarranty Information:").AppendLine();
			sb.AppendFormat("\t\tLabor W/C: {0}{1}", asset.ActiveLaborNumber, asset.WarrantyInfo.MonitoringContractOnly ? " (Monitoring Only)" : string.Empty).AppendLine();
			sb.AppendFormat("\t\tParts W/C: {0}", asset.ActivePartsNumber).AppendLine();
			sb.AppendFormat("\t\tLabor Warranty Expire: {0}", asset.WarrantyInfo.LaborWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tLabor Contract Expire: {0}", asset.WarrantyInfo.LaborContractExpire).AppendLine();
			sb.AppendFormat("\t\tParts Warranty Expire: {0}", asset.WarrantyInfo.PartsWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tParts Contract Expire: {0}", asset.WarrantyInfo.PartsContractExpire).AppendLine().AppendLine();

			sb.AppendFormat("\tSymptoms: {0}", ticket.ExtraProperties.Symptoms()).AppendLine().AppendLine();

			sb.AppendFormat("Ticket {0}", ticket.ID).AppendLine();
			sb.AppendFormat("Opened by: {0} ({1})", GS.Settings.LoggedOnUser.FirstL, GS.Settings.LoggedOnUser.ID).AppendLine();
			sb.AppendFormat("Approved by: {0} ({1})", supervisor.FirstL, supervisor.ID).AppendLine();
			sb.AppendFormat("OSA Sent: {0}", ticket.TechID.HasValue ? $"Yes, to {ticket.ExtraProperties.AssignedTechName}" : "No").AppendLine();
			sb.AppendFormat("Open Sent: {0}", ticket.OpenOption_SendEmail_Open ? $"Yes, to {asset.ExtraProperties.MarketName}" : "No").AppendLine();

			var serviceEmail = ClassConfig.GetServiceEmail();
			var svMessage = new MailMessage { From = serviceEmail };
			svMessage.ReplyToList.Add(serviceEmail);
			foreach (var address in ClassAdminEmail.GetAllAsMailAddresses())
				svMessage.To.Add(address);
			svMessage.Subject = $"Supervisor-Authorized Equipment Rental (#{ticket.ID})";
			svMessage.Body = sb.ToString();

			return svMessage;
		}

		/// <summary>
		/// An email that notifies managers that a supervisor override was used to reopen a ticket which has been closed longer than the configured grace period.
		/// </summary>
		/// <param name="ticket">The ticket reopened.</param>
		/// <param name="asset">The asset for the ticket, for ownership/warranty info.</param>
		/// <param name="supervisor">The supervisor providing the override.</param>
		public static MailMessage GenerateEmail_Supervisor_TicketReopenAfterExpire(ClassTicket ticket, ClassAsset asset, ClassUser supervisor)
		{
			var sb = new StringBuilder();

			sb.AppendFormat("Ticket {0} has been reopened after being closed longer than the allowed time.", ticket.ID).AppendLine();
			sb.AppendFormat("\tCustomer: {0}", asset.ExtraProperties.CustomerName).AppendLine();
			sb.AppendFormat("\tMarket: {0}", asset.ExtraProperties.MarketName).AppendLine();
			sb.AppendFormat("\tAsset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("\tPanel: {0}", asset.Panel).AppendLine();
			sb.Append("\tWarranty Information:").AppendLine();
			sb.AppendFormat("\t\tLabor W/C: {0}{1}", asset.ActiveLaborNumber, asset.WarrantyInfo.MonitoringContractOnly ? " (Monitoring Only)" : string.Empty).AppendLine();
			sb.AppendFormat("\t\tParts W/C: {0}", asset.ActivePartsNumber).AppendLine();
			sb.AppendFormat("\t\tLabor Warranty Expire: {0}", asset.WarrantyInfo.LaborWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tLabor Contract Expire: {0}", asset.WarrantyInfo.LaborContractExpire).AppendLine();
			sb.AppendFormat("\t\tParts Warranty Expire: {0}", asset.WarrantyInfo.PartsWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tParts Contract Expire: {0}", asset.WarrantyInfo.PartsContractExpire).AppendLine().AppendLine();

			sb.AppendFormat("\tSymptoms: {0}", ticket.ExtraProperties.Symptoms()).AppendLine().AppendLine();

			sb.AppendFormat("\tSolutions: {0}", ticket.ExtraProperties.Solutions(true)).AppendLine().AppendLine();

			sb.AppendFormat("Ticket {0}", ticket.ID).AppendLine();
			sb.AppendFormat("Re-opened by: {0} ({1})", GS.Settings.LoggedOnUser.FirstL, GS.Settings.LoggedOnUser.ID).AppendLine();
			sb.AppendFormat("Approved by: {0} ({1})", supervisor.FirstL, supervisor.ID).AppendLine();
			sb.AppendFormat("OSA Sent: {0}", ticket.TechID.HasValue ? $"Yes, to {ticket.ExtraProperties.AssignedTechName}" : "No").AppendLine();
			sb.AppendFormat("Open Sent: {0}", ticket.OpenOption_SendEmail_Open ? $"Yes, to {asset.ExtraProperties.MarketName}" : "No").AppendLine();

			var serviceEmail = ClassConfig.GetServiceEmail();
			var svMessage = new MailMessage { From = serviceEmail };
			svMessage.ReplyToList.Add(serviceEmail);
			foreach (var address in ClassAdminEmail.GetAllAsMailAddresses())
				svMessage.To.Add(address);
			svMessage.Subject = $"Supervisor-Authorized Ticket Re-open After Close Expire (#{ticket.ID}) Sent";
			svMessage.Body = sb.ToString();

			return svMessage;
		}

		/// <summary>
		/// An email that notifies managers that supervisor override was used to create an RMA without parts warranty/contract.
		/// </summary>
		/// <param name="rma">The RMA created.</param>
		/// <param name="asset">The asset associated with the RMA.</param>
		/// <param name="supervisor">The supervisor providing the override.</param>
		public static MailMessage GenerateEmail_Supervisor_RMACreate(ClassRMA rma, ClassAsset asset, ClassUser supervisor)
		{
			var sb = new StringBuilder();

			sb.Append("An RMA has been created for:").AppendLine();
			sb.AppendFormat("\tAsset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("\tPanel: {0}", asset.Panel).AppendLine();
			sb.AppendFormat("\tTech: {0}", rma.TechName).AppendLine();
			sb.Append("\tWarranty Information:").AppendLine();
			sb.AppendFormat("\t\tLabor W/C: {0}{1}", asset.ActiveLaborNumber, asset.WarrantyInfo.MonitoringContractOnly ? " (Monitoring Only)" : string.Empty).AppendLine();
			sb.AppendFormat("\t\tParts W/C: {0}", asset.ActivePartsNumber).AppendLine();
			sb.AppendFormat("\t\tLabor Warranty Expire: {0}", asset.WarrantyInfo.LaborWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tLabor Contract Expire: {0}", asset.WarrantyInfo.LaborContractExpire).AppendLine();
			sb.AppendFormat("\t\tParts Warranty Expire: {0}", asset.WarrantyInfo.PartsWarrantyExpire).AppendLine();
			sb.AppendFormat("\t\tParts Contract Expire: {0}", asset.WarrantyInfo.PartsContractExpire).AppendLine().AppendLine();

			sb.AppendFormat("RMA: {0}", rma.ID).AppendLine();
			sb.AppendFormat("Related Ticket: {0}", rma.TicketID).AppendLine();
			sb.AppendFormat("Created by: {0} ({1})", GS.Settings.LoggedOnUser.FirstL, GS.Settings.LoggedOnUser.ID).AppendLine();
			sb.AppendFormat("Approved by: {0} ({1})", supervisor.FirstL, supervisor.ID).AppendLine();

			var serviceEmail = ClassConfig.GetServiceEmail();
			var svMessage = new MailMessage { From = serviceEmail };
			svMessage.ReplyToList.Add(serviceEmail);
			foreach (var addy in ClassAdminEmail.GetAllAsMailAddresses())
				svMessage.To.Add(addy);
			svMessage.Subject = string.Format("Supervisor-Authorized RMA (#{0}) Created", rma.ID);
			svMessage.Body = sb.ToString();

			return svMessage;
		}

		/// <summary>
		/// An email that notifies managers that supervisor override was used to edit asset warranty information.
		/// </summary>
		/// <param name="oldWarrantyInfo">The warranty information before editing.</param>
		/// <param name="asset">The asset being edited, for ownership and warranty information. (After editing.)</param>
		/// <param name="supervisor">The supervisor providing the override.</param>
		public static MailMessage GenerateEmail_Supervisor_WarrantyEdit(ClassAsset.ClassWarrantyInfo oldWarrantyInfo, ClassAsset asset, ClassUser supervisor)
		{
			var sb = new StringBuilder();

			sb.Append("The following asset warranty was modified:").AppendLine();
			sb.AppendFormat("\tCustomer: {0}", asset.ExtraProperties.CustomerName).AppendLine();
			sb.AppendFormat("\tMarket: {0}", asset.ExtraProperties.MarketName).AppendLine();
			sb.AppendFormat("\tAsset: {0}", asset.AssetName).AppendLine();
			sb.AppendFormat("\tPanel: {0}", asset.Panel).AppendLine();
			sb.Append("\tWarranty Information:").AppendLine();

			if (oldWarrantyInfo.LaborWarrantyNumber != asset.WarrantyInfo.LaborWarrantyNumber)
				sb.AppendFormat("\t\tLabor Warranty Number: {0} changed to {1}", oldWarrantyInfo.LaborWarrantyNumber, asset.WarrantyInfo.LaborWarrantyNumber).AppendLine();
			else
				sb.AppendFormat("\t\tLabor Warranty Number: {0}", asset.WarrantyInfo.LaborWarrantyNumber).AppendLine();

			if (oldWarrantyInfo.LaborContractNumber != asset.WarrantyInfo.LaborContractNumber)
				sb.AppendFormat("\t\tLabor Contract Number: {0} changed to {1}", oldWarrantyInfo.LaborContractNumber, asset.WarrantyInfo.LaborContractNumber).AppendLine();
			else
				sb.AppendFormat("\t\tLabor Contract Number: {0}", asset.WarrantyInfo.LaborContractNumber).AppendLine();

			if (oldWarrantyInfo.MonitoringContractOnly != asset.WarrantyInfo.MonitoringContractOnly)
				sb.AppendFormat("\t\tLabor WC Type: {0} changed to {1}", oldWarrantyInfo.MonitoringContractOnly ? "Monitoring-Only" : "Standard", asset.WarrantyInfo.MonitoringContractOnly ? "Monitoring-Only" : "Standard").AppendLine();
			else
				sb.AppendFormat("\t\tLabor WC Type: {0}", asset.WarrantyInfo.MonitoringContractOnly ? "Monitoring-Only" : "Standard").AppendLine();

			if (oldWarrantyInfo.PartsWarrantyNumber != asset.WarrantyInfo.PartsWarrantyNumber)
				sb.AppendFormat("\t\tParts Warranty Number: {0} changed to {1}", oldWarrantyInfo.PartsWarrantyNumber, asset.WarrantyInfo.PartsWarrantyNumber).AppendLine();
			else
				sb.AppendFormat("\t\tParts Warranty Number: {0}", asset.WarrantyInfo.PartsWarrantyNumber).AppendLine();

			if (oldWarrantyInfo.PartsContractNumber != asset.WarrantyInfo.PartsContractNumber)
				sb.AppendFormat("\t\tParts Contract Number: {0} changed to {1}", oldWarrantyInfo.PartsContractNumber, asset.WarrantyInfo.PartsContractNumber).AppendLine();
			else
				sb.AppendFormat("\t\tParts Contract Number: {0}", asset.WarrantyInfo.PartsContractNumber).AppendLine();

			if (oldWarrantyInfo.LaborWarrantyExpire != asset.WarrantyInfo.LaborWarrantyExpire)
				sb.AppendFormat("\t\tLabor Warranty Expire: {0:yyyy-MM-dd} changed to {1:yyyy-MM-dd}", oldWarrantyInfo.LaborWarrantyExpire, asset.WarrantyInfo.LaborWarrantyExpire).AppendLine();
			else
				sb.AppendFormat("\t\tLabor Warranty Expire: {0:yyyy-MM-dd}", asset.WarrantyInfo.LaborWarrantyExpire).AppendLine();

			if (oldWarrantyInfo.LaborContractExpire != asset.WarrantyInfo.LaborContractExpire)
				sb.AppendFormat("\t\tLabor Contract Expire: {0:yyyy-MM-dd} changed to {1:yyyy-MM-dd}", oldWarrantyInfo.LaborContractExpire, asset.WarrantyInfo.LaborContractExpire).AppendLine();
			else
				sb.AppendFormat("\t\tLabor Contract Expire: {0:yyyy-MM-dd}", asset.WarrantyInfo.LaborContractExpire).AppendLine();

			if (oldWarrantyInfo.PartsWarrantyExpire != asset.WarrantyInfo.PartsWarrantyExpire)
				sb.AppendFormat("\t\tParts Warranty Expire: {0:yyyy-MM-dd} changed to {1:yyyy-MM-dd}", oldWarrantyInfo.PartsWarrantyExpire, asset.WarrantyInfo.PartsWarrantyExpire).AppendLine();
			else
				sb.AppendFormat("\t\tParts Warranty Expire: {0:yyyy-MM-dd}", asset.WarrantyInfo.PartsWarrantyExpire).AppendLine();

			if (oldWarrantyInfo.PartsContractExpire != asset.WarrantyInfo.PartsContractExpire)
				sb.AppendFormat("\t\tParts Contract Expire: {0:yyyy-MM-dd} changed to {1:yyyy-MM-dd}", oldWarrantyInfo.PartsContractExpire, asset.WarrantyInfo.PartsContractExpire).AppendLine().AppendLine();
			else
				sb.AppendFormat("\t\tParts Contract Expire: {0:yyyy-MM-dd}", asset.WarrantyInfo.PartsContractExpire).AppendLine().AppendLine();

			sb.AppendFormat("Approved by: {0} ({1})", supervisor.FirstL, supervisor.ID).AppendLine();

			var serviceEmail = ClassConfig.GetServiceEmail();
			var svMessage = new MailMessage { From = serviceEmail };
			svMessage.ReplyToList.Add(serviceEmail);
			foreach (var addy in ClassAdminEmail.GetAllAsMailAddresses())
				svMessage.To.Add(addy);
			svMessage.Subject = string.Format("Supervisor-Authorized Asset Warranty Modified ({0})", asset.AssetName);
			svMessage.Body = sb.ToString();

			return svMessage;
		}

		/// <summary>
		/// An email that is sent to development reporting a problem with the database. Includes settings and log file as attachments.
		/// </summary>
		/// <param name="message">User message.</param>
		public static MailMessage GenerateEmail_ProblemReport(string message)
		{
			var devEmail = ClassConfig.GetDevEmail();
			var problemReportMessage = new MailMessage();
			if (!string.IsNullOrEmpty(GS.Settings.LoggedOnUser.Email) && ClassUtility.IsValidEmail(GS.Settings.LoggedOnUser.Email))
			{
				var userAddress = new MailAddress(GS.Settings.LoggedOnUser.Email, GS.Settings.LoggedOnUser.FirstLast);
				problemReportMessage.From = userAddress;
				problemReportMessage.ReplyToList.Add(userAddress);
			}
			else
			{
				var fromAddress = new MailAddress(GS.Settings.EmailUser, GS.Settings.LoggedOnUser.FirstLast);
				problemReportMessage.From = fromAddress;
			}
			problemReportMessage.To.Add(devEmail);
			problemReportMessage.Subject = string.Format("SDB Problem Report {0}-{1}", GS.Settings.LoggedOnUser.ID, new Random().Next(1000, 9999));

			var sb = new StringBuilder();
			sb.AppendLine("SDB Problem Report");
			sb.AppendLine();
			sb.AppendFormat("From: [{0}] {1} {2} ({3})", GS.Settings.LoggedOnUser.ID, GS.Settings.LoggedOnUser.First, GS.Settings.LoggedOnUser.Last, GS.Settings.LoggedOnUser.Email).AppendLine();
			sb.AppendFormat("User type: {0}", GS.Settings.LoggedOnUser.UserType).AppendLine();
			sb.AppendFormat("Login duration: {0}", ClassUtility.FormatTimeSpan_Dhm(GS.Settings.LoggedOnUser.LoggedInDuration)).AppendLine();
			sb.AppendFormat("SDB version: {0}", Application.ProductVersion).AppendLine();
			sb.AppendFormat("OS: {0}", ClassUtility.GetOSName()).AppendLine();
			sb.AppendLine();
			sb.Append(message);
			sb.AppendLine().AppendLine();
			sb.AppendLine("--- END ---");
			problemReportMessage.Body = sb.ToString();

			// Copy files to a temporary file
			var logFile = Path.Combine(GS.Settings.SettingsPath, ClassSettings.LOG_FILE);
			var settingsFile = Path.Combine(GS.Settings.SettingsPath, ClassSettings.SETTINGS_FILE);

			var tempLogFile = Path.GetTempFileName();
			var tempSettingsFile = Path.GetTempFileName();

			File.Copy(logFile, tempLogFile, true);
			File.Copy(settingsFile, tempSettingsFile, true);

			problemReportMessage.Attachments.Add(new Attachment(new FileStream(tempLogFile, FileMode.Open), ClassSettings.LOG_FILE));
			problemReportMessage.Attachments.Add(new Attachment(new FileStream(tempSettingsFile, FileMode.Open), ClassSettings.SETTINGS_FILE));

			return problemReportMessage;
		}

		/// <summary>
		/// An email sent to users with a temporary password to allow them to log in and reset their password.
		/// </summary>
		public static MailMessage GenerateEmail_PasswordReset(ClassUser user, string temporaryPassword)
		{
			#region Validation
			if (string.IsNullOrEmpty(user.Email))
				return null;
			#endregion

			var sb = new StringBuilder();
			sb.AppendLine("Password Reset:");
			sb.AppendLine();
			sb.AppendFormat("A password reset has been requested for user ID: {0}", user.ID);
			sb.AppendLine();
			sb.AppendLine("If you did not request a password reset, please ignore this message.");
			sb.AppendLine();
			sb.AppendLine("To reset your password, please log in to the service database using this temporary password:");
			sb.AppendLine();
			sb.AppendLine(temporaryPassword);
			sb.AppendLine();
			sb.AppendLine("This password is valid only for a limited time. Once logged in, select Administration > User Details from the menu and change the password.");

			var serviceEmail = ClassConfig.GetServiceEmail();
			var passwordResetMessage = new MailMessage { From = serviceEmail };
			passwordResetMessage.ReplyToList.Add(serviceEmail);
			passwordResetMessage.To.Add(user.Email.Trim(','));
			passwordResetMessage.Subject = string.Format("SDB Password Reset for User {0}", user.ID);
			passwordResetMessage.Body = sb.ToString();

			return passwordResetMessage;
		}

		/// <summary>
		/// An email sent to new users with their initial password and instructions to change it.
		/// </summary>
		public static MailMessage GenerateEmail_NewUser(ClassUser user, string initialPassword)
		{
			if (string.IsNullOrEmpty(user.Email))
				return null;

			var sb = new StringBuilder();
			sb.AppendLine("The Prismview Service Database (SDB) is a database that manages digital displays, their maintenance and repair, parts replacement, shipping, and tracking.");
			sb.AppendLine();
			sb.AppendLine("A user account has been created for you. To login, you will need to have access to the SDB client. You can download a copy here:");
			sb.AppendLine();
			sb.AppendLine("http://192.168.90.88/");
			sb.AppendLine();
			sb.AppendLine("In order to install software, you may require administrator privileges. Contact the IT department for assistance or more information.");
			sb.AppendLine();
			sb.AppendLine("Important: You will need to enter a database password to grant the client access to the server for new installations. Please contact your supervisor or the IT department for this.");
			sb.AppendLine();
			sb.AppendLine("Your login credentials are:");
			sb.AppendLine();
			sb.AppendFormat("User ID: {0}", user.ID).AppendLine();
			sb.AppendFormat("Password: {0}", initialPassword).AppendLine();
			sb.AppendLine();
			sb.AppendLine("Upon first login, *** PLEASE CHANGE YOUR PASSWORD ***. To do this, navigate to the Administration > User Details menu.");
			sb.AppendLine();
			sb.AppendLine("If you experience problems, please contact the IT department or look in the Help menu.");

			var serviceEmail = ClassConfig.GetServiceEmail();
			var newUserMessage = new MailMessage { From = serviceEmail };
			newUserMessage.ReplyToList.Add(serviceEmail);
			newUserMessage.To.Add(user.Email.Trim(','));
			newUserMessage.Subject = string.Format("Welcome to the SDB, {0}", user.FirstLast);
			newUserMessage.Body = sb.ToString();

			return newUserMessage;
		}

		/// <summary>
		/// An email template for sending customers a billable confirmation (when fault may lie with power, communications, or customer equipment).
		/// </summary>
		public static MailMessage GenerateEmail_BillableConfirmation(ClassTicket ticket)
		{
			var asset = ClassAsset.GetByID(ticket.AssetID);
			asset.PopulateExtraProperties();
			var market = ClassMarket.GetByID(asset.MarketID);
			var subject = $"Billable confirmation for panel: {asset.Panel} ({asset.AssetName})";

			var sb = new StringBuilder();
			sb.AppendFormat("{0},", asset.ExtraProperties.CustomerName).AppendLine();
			sb.AppendLine();
			sb.Append("We are troubleshooting functionality at the following panel:").AppendLine();
			sb.AppendLine();
			sb.AppendFormat("{0} ({1})", asset.Panel, asset.AssetName).AppendLine();
			sb.AppendFormat("{0}", asset.LocationMultiLine);
			sb.AppendLine();
			sb.AppendFormat("Ticket number: {0}", ticket.ID).AppendLine();
			sb.AppendLine();
			sb.Append("We are not currently able to communicate with any of the equipment at this location. ");
			sb.Append("We can dispatch a technician, however if the root cause of the issue is determined to be main power or customer-provided communications equipment, the service call may be billable.").AppendLine();
			sb.AppendLine();
			sb.Append("Please Approve or Disallow a technician visit.").AppendLine();
			sb.AppendLine();
			sb.Append("Thank you,").AppendLine();
			sb.AppendFormat("{0}", GS.Settings.LoggedOnUser.FirstLast).AppendLine();

			var serviceEmail = ClassConfig.GetServiceEmail();
			var billableMessage = new MailMessage { From = serviceEmail };
			billableMessage.To.Add(market.Email_Addresses);
			billableMessage.CC.Add(serviceEmail);
			billableMessage.Subject = subject;
			billableMessage.Body = sb.ToString();
			return billableMessage;
		}

        /// <summary>
		/// An email template for sending customers a billable confirmation (when fault may lie with power, communications, or customer equipment).
		/// </summary>
		public static MailMessage GenerateEmail_EpartOrderShipped(ClassShipment shipment)
        {
            var address = shipment.Destination;
            var sb = new StringBuilder();
            var shipNum = shipment.ID.ToString();

            sb.Append("<h4> Shipment #" + shipNum + " Confirmation </h4>");
            sb.Append("<p>Good News! Your Prismview Eparts Order Is On Its Way.</p><br>");

            if(shipment.Tracking != string.Empty)
            sb.AppendFormat("<p><a href={0}>Tracking Number: {1} </a></p>", shipment.URL_TrackingLink, shipment.Tracking);

            sb.Append("<b>Shipped To:</b><br>");
            sb.Append(address.Address + ",<br>" + address.City + ", " + address.State + ", " + address.Zip + ", " + address.Country);
            sb.Append("<br><br><p><b>The Items Below Have Shipped:</b></p>");

            var itemlist = ClassShipment.GetInventory(shipment.ID).ToList();

            foreach(var item in itemlist)
            {
                sb.Append("<p style='margin-left: 20px'>- " + item.ToString() + "</p>");
            }
            sb.Append("<br><b>Questions? Please Call 800.741.6721 or email eparts@prismview.com<br>").AppendLine().AppendLine();
            sb.Append("This Email Was Generated Automatically.</b>");

            var from = ClassConfig.GetServiceEmail();
           // from = new MailAddress("taspinwall@prsimview.com");
            var email = new MailMessage { From = from, IsBodyHtml = true};

            //TODO Add Email List
            //email.To.Add("taspinwall@prismview.com");
            email.To.Add(shipment.EmailList + ", eparts@prismview.com");
            //email.CC.Add("eparts@prismview.com");
            email.Subject = "Your Prismview Eparts Order #" + shipNum + " Has Shipped" ;
            email.Body = sb.ToString();


            return email;
        }
    }
}