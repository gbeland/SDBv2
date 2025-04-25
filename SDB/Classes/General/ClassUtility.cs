using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SDB.Interfaces;

namespace SDB.Classes.General
{
	/// <summary>
	/// A utility class with generally useful stuff!
	/// </summary>
	public static class ClassUtility
	{
		/// <summary>
		/// Like String.Format but if any parameter is null, <paramref name="nullOutput"/> string is returned.
		/// </summary>
		public static string StringFormatNull(string format, string nullOutput, params object[] args)
		{
			return args.Any(o => o == null) ? nullOutput : string.Format(format, args);
		}

		/// <summary>
		/// Returns a string like 7d 23h 59m but omits days and hours if zero.
		/// Rounds last minute up for partial seconds.
		/// </summary>
		public static string FormatTimeSpan_Dhm(TimeSpan? ts)
		{
			if (!ts.HasValue)
				return string.Empty;

			var days = (int)Math.Floor(ts.Value.TotalDays);
			var hours = (int)Math.Floor(ts.Value.TotalHours);
			return $"{(days > 0 ? ts.Value.Days + "d " : string.Empty)}{(hours > 0 ? ts.Value.Hours + "h " : string.Empty)}{(ts.Value.Minutes < 1 && ts.Value.Seconds > 0 ? 1 : ts.Value.Minutes)}m";
		}

		/// <summary>
		/// Returns a string like 7d or 23h but only one value (days, hours or minutes).
		/// Round the timespan before using.
		/// </summary>
		public static string FormatRoundedTimeSpan_Dhm(TimeSpan? ts)
		{
			if (!ts.HasValue)
				return string.Empty;

			if (ts.Value.Days > 0)
				return ts.Value.Days + "d";
			if (ts.Value.Hours > 0)
				return ts.Value.Hours + "h";
			return ts.Value.Minutes + "m";
		}

		/// <summary>
		/// Compare versions of form "1,2,3,4" or "1.2.3.4". Throws FormatException
		/// in case of invalid version.
		/// </summary>
		/// <param name="versionA">the first version</param>
		/// <param name="versionB">the second version</param>
		/// <returns>less than zero if strA is less than strB, equal to zero if
		/// strA equals strB, and greater than zero if strA is greater than strB</returns>
		public static int CompareVersions(string versionA, string versionB)
		{
			// http://stackoverflow.com/questions/30494/compare-version-identifiers
			#region validation
			if (string.IsNullOrEmpty(versionA) || string.IsNullOrEmpty(versionB))
				throw new FormatException("Cannot compare null or empty version.");
			versionA = Regex.Replace(versionA, @"[ A-Za-z]", string.Empty);
			versionB = Regex.Replace(versionB, @"[ A-Za-z]", string.Empty);
			#endregion
			var vA = new Version(versionA.Replace(",", "."));
			var vB = new Version(versionB.Replace(",", "."));

			return vA.CompareTo(vB);
		}

		/// <summary>
		/// Converts an image to a byte array.
		/// </summary>
		public static byte[] ImageToByteArray(Image imageToConvert)
		{
			if (imageToConvert == null)
				return null;
			try
			{
				using (var ms = new MemoryStream())
				{
					imageToConvert.Save(ms, ImageFormat.Png);
					return ms.ToArray();
				}
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				Debug.WriteLine(exc.Message);
				return null;
			}
		}

		/// <summary>
		///  Converts a byte array to an Image.
		/// </summary>
		public static Image ByteArrayToImage(byte[] byteArray)
		{
			if (byteArray == null)
				return null;

			try
			{
				var ms = new MemoryStream(byteArray);
				return Image.FromStream(ms);
				// BUG: Don't close or dispose stream, per GDI bug documented here:
				// http://stackoverflow.com/questions/4671449/how-can-i-write-an-extension-method-that-converts-a-system-drawing-bitmap-to-a-b/4672084#4672084
			}
			catch (Exception exc)
			{
				Debug.WriteLine(exc.Message);
				return null;
			}
		}

		public static Image ResizeImage(Image imageToResize, Size newSize)
		{
			var sourceWidth = imageToResize.Width;
			var sourceHeight = imageToResize.Height;

			var nPercentW = (newSize.Width / (float)sourceWidth);
			var nPercentH = (newSize.Height / (float)sourceHeight);

			var nPercent = nPercentH < nPercentW ? nPercentH : nPercentW;

			var destWidth = (int)(sourceWidth * nPercent);
			var destHeight = (int)(sourceHeight * nPercent);

			var resizedImage = new Bitmap(destWidth, destHeight);
			using (var g = Graphics.FromImage(resizedImage))
			{
				g.InterpolationMode = InterpolationMode.HighQualityBicubic;
				g.DrawImage(imageToResize, 0, 0, destWidth, destHeight);
			}

			return resizedImage;
		}

		public static void Export_CSV(ListView lstView, string defaultFilename)
		{
			// modified from http://www.daniweb.com/forums/thread192620.html
			var sb = new StringBuilder();
			var c = 0;
			foreach (ColumnHeader ch in lstView.Columns)
			{
				if (c > 0) sb.Append(",");
				sb.Append("\"" + ch.Text + "\"");
				c++;
			}
			sb.AppendLine();
			foreach (ListViewItem lvi in lstView.Items)
			{
				var n = 0;
				foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
				{
					if (n > 0)
						sb.Append(",");
					sb.Append("\"" + lvs.Text.Trim() + "\"");
					n++;
				}
				sb.AppendLine();
			}
			var sw = new StreamWriter(defaultFilename);
			sw.Write(sb.ToString());
			sw.Close();
			Process.Start(defaultFilename);
		}

		/// <summary>
		/// Makes a string safe to use as a filename.
		/// </summary>
		public static string MakeSafeFileName(string fileName)
		{
			fileName = fileName.Trim();
			if (fileName.Length > 128)
				fileName = fileName.Substring(0, 128);
			fileName = Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c, '_'));
			char[] replace = { '-', '.' };
			fileName = fileName.TrimStart(replace);
			fileName = fileName.TrimEnd(replace);
			return fileName;
		}

		public static void OlvExport(ObjectListView olv, string defaultFileName = "export.csv", string defaultTitle = "Export List")
		{
			using (var sfd = new SaveFileDialog())
			{
				sfd.FileName = defaultFileName;
				sfd.Filter = "Comma Separated Values (*.csv)|*.csv";
				sfd.DefaultExt = ".csv";
				sfd.Title = defaultTitle;
				sfd.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
				if (sfd.ShowDialog() != DialogResult.OK)
					return;
				ListViewToCSV(olv, sfd.FileName, false);
			}
		}

		/// <summary>
		/// Export the properties of a list of <see cref="IExportableToCsv"/> objects to a CSV file.
		/// </summary>
		public static void ObjectListExport(IEnumerable<IExportableToCsv> objectList, string fileName)
		{
				var sb = new StringBuilder();
				var needHeader = true;
				foreach (var item in objectList)
				{
					if (needHeader)
					{
						sb.AppendLine(item.ExportHeadersAsCsvString());
						needHeader = false;
					}

					sb.AppendLine(item.ExportPropertiesAsCsvString());
				}

				File.WriteAllText(fileName, sb.ToString());
		}

		/// <summary>
		/// Export ListView to a CSV located at FilePath
		/// </summary>
		/// <remarks>See: http://stackoverflow.com/a/1008994/161052</remarks>
		/// <param name="listView">The listview to export</param>
		/// <param name="filePath">The CSV file for output</param>
		/// <param name="includeHidden">Include hidden columns?</param>
		private static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
		{
			//make header string
			var sb = new StringBuilder();
			WriteCSVRow(sb, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

			//export data rows
			foreach (ListViewItem lvi in listView.Items)
			{
				var item = lvi;
				WriteCSVRow(sb, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => item.SubItems[i].Text);
			}

			File.WriteAllText(filePath, sb.ToString());
		}

		private static void WriteCSVRow(StringBuilder sb, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
		{
			var isFirstTime = true;
			for (var i = 0; i < itemsCount; i++)
			{
				if (!isColumnNeeded(i))
					continue;

				if (!isFirstTime)
					sb.Append(",");
				isFirstTime = false;

				sb.Append($"\"{columnValue(i)}\"");
			}
			sb.AppendLine();
		}

		public static void OlvPrint(ObjectListView olv)
		{
			using (var listviewPrinter = new ListViewPrinter())
			{
				listviewPrinter.ListView = olv;
				listviewPrinter.ListHeaderFormat.CanWrap = false;
				listviewPrinter.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
				listviewPrinter.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);
				listviewPrinter.PageSetup();
				listviewPrinter.PrintPreview();
			}
		}

		/// <summary>
		/// Truncates string to specified number of characters. If shorter, input value is returned.
		/// </summary>
		public static string Truncate(this string s, int length)
		{
			if (string.IsNullOrEmpty(s))
				return s;

			return s.Length > length ? s.Substring(0, length) : s;
		}

		/// <summary>
		/// Returns "s" if <paramref name="i"/> is 0 or >1; empty otherwise.
		/// </summary>
		public static string SIfPlural(this int i)
		{
			return i == 1 ? string.Empty : "s";
		}

		/// <summary>
		/// Returns null if <paramref name="s"/> is empty, otherwise its value.
		/// </summary>
		public static string NullIfEmpty(this string s)
		{
			return string.IsNullOrWhiteSpace(s) ? null : s;
		}

		/// <summary>
		/// Rounds a DateTime to the nearest unit specified by the TimeSpan supplied.
		/// </summary>
		/// <param name="date">DateTime to round.</param>
		/// <param name="span">Nearest unit to round by.</param>
		/// <example>Given 2012-01-01 16:43:17 and a TimeSpan of 5 minutes, returns 2012-01-01 16:45:00</example>
		/// <remarks>http://stackoverflow.com/questions/1393696/c-rounding-datetime-objects</remarks>
		public static DateTime Round(this DateTime date, TimeSpan span)
		{
			var ticks = (date.Ticks / span.Ticks) + (span.Ticks / 2) + 1;
			return new DateTime(ticks * span.Ticks);
		}

		public static DateTime Floor(this DateTime date, TimeSpan span)
		{
			var ticks = (date.Ticks / span.Ticks);
			return new DateTime(ticks * span.Ticks);
		}

		public static DateTime Ceil(this DateTime date, TimeSpan span)
		{
			var ticks = (date.Ticks + span.Ticks - 1) / span.Ticks;
			return new DateTime(ticks * span.Ticks);
		}

		/// <summary>
		/// Rounds a TimeSpan to the nearest minute if not over 60 minutes, nearest hour if not over 24 hours, etc.
		/// Values below 30 seconds are not rounded.
		/// </summary>
		public static TimeSpan Round(this TimeSpan span)
		{
			// Work from absolute value
			var isNegative = span.Ticks < 0;
			var absTimeSpan = span.Duration();

			// If less than 30 seconds, leave alone
			if (absTimeSpan.TotalSeconds < 30)
			{
				// no modification
			}
			else if (absTimeSpan.TotalMinutes < 60)
			{
				// If less than 1 hour, round to minutes
				absTimeSpan = new TimeSpan(0, 0, (int)absTimeSpan.TotalMinutes + (absTimeSpan.Seconds >= 30 ? 1 : 0), 0);
			}
			else if (absTimeSpan.TotalHours < 24)
			{
				// If less than 24 hours, round to hours
				absTimeSpan = new TimeSpan(0, (int)absTimeSpan.TotalHours + (absTimeSpan.Minutes >= 30 ? 1 : 0), 0, 0);
			}
			else
			{
				// If 24 hours or more, round to days
				absTimeSpan = new TimeSpan((int)absTimeSpan.TotalDays + (absTimeSpan.Hours >= 12 ? 1 : 0), 0, 0, 0);
			}

			return isNegative ? absTimeSpan.Negate() : absTimeSpan;
		}

		/// <summary>
		/// Adds <paramref name="item"/> to the queue, removing oldest items if the queue is larger than <paramref name="maxSize"/>.
		/// </summary>
		public static void EnqueueWithCapacity<T>(this Queue<T> q, T item, int maxSize)
		{
			if (q.Count >= maxSize)
				q.Dequeue();

			q.Enqueue(item);
		}

		public static string GetOSName()
		{
			var name = (from x in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>()
						select x.GetPropertyValue("Caption")).FirstOrDefault();
			return name != null ? $"{name.ToString().Trim()} {(Environment.Is64BitOperatingSystem ? "x64" : string.Empty)}" : Environment.OSVersion.ToString().Trim();
		}

		/// <summary>
		/// Determines email address validity based on whether it can be parsed by <see cref="System.Net.Mail.MailAddress"/>
		/// </summary>
		public static bool IsValidEmail(string address)
		{
			try
			{
				var mailAddress = new MailAddress(address);
				return mailAddress.Address == address;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Convert string to enumeration of specified type.
		/// </summary>
		public static T ToEnum<T>(this string value)
		{
			return (T)Enum.Parse(typeof(T), value, true);
		}

		public static void Clear(this Control.ControlCollection controls, bool dispose)
		{
			for (var ix = controls.Count - 1; ix >= 0; --ix)
			{
				if (dispose)
					controls[ix].Dispose();
				else
					controls.RemoveAt(ix);
			}
		}

		public static DateTime GetDateTimeFromCameraImageFileName(string filename)
		{
			var fileParts = filename.Split('_');

			if (fileParts.Length > 3)
				throw new FormatException("Invalid camera history file named " + filename);

			var yr = Convert.ToInt32(fileParts[1].Substring(0, 4));
			var mo = Convert.ToInt32(fileParts[1].Substring(4, 2));
			var dy = Convert.ToInt32(fileParts[1].Substring(6, 2));
			var hr = Convert.ToInt32(fileParts[2].Substring(0, 2));
			var mn = Convert.ToInt32(fileParts[2].Substring(2, 2));
			var sc = Convert.ToInt32(fileParts[2].Substring(4, 2));
			return new DateTime(yr, mo, dy, hr, mn, sc);
		}

		public static string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			var ip = host.AddressList.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
			return ip?.ToString() ?? string.Empty;
		}

		/// <summary>
		/// Validates an email address against a regular expression for proper email address format.
		/// </summary>
		public static bool ValidateEmailAddress(string address)
		{
			// http://stackoverflow.com/a/16168103/161052
			return Regex.IsMatch(address, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
		}

		/// <summary>
		/// Tests if supplied number <paramref name="value"/> consists of consecutive digits (eg: 1234 or 4321).
		/// </summary>
		public static bool IsConsecutive(string value)
		{
			if (!Regex.IsMatch(value, "^[0-9]+$", RegexOptions.IgnoreCase))
				return false;

			var num = value.Select(Convert.ToInt32).ToArray();
			return num.Zip(num.Skip(1), (a, b) => (a + 1) == b).All(x => x) || num.Zip(num.Skip(1), (a, b) => (a - 1) == b).All(x => x);
		}

		/// <summary>
		/// Tests if supplied number <paramref name="value"/> consists of all the same digit (eg: 0000 or 5555).
		/// </summary>
		public static bool IsAllSameCharacter(string value)
		{
			return value.Distinct().Count() == 1;
		}

		/// <summary>
		/// Parses a string like "100, 105, 110-115" (space optional) and returns a list of ints with each element like "100, 105, 110, 111, 112, 113, 114, 115"
		/// </summary>
		public static List<int> ListFromHypenCommaString(string humanList)
		{
			humanList = humanList.Replace(" ", string.Empty);
			var rangeRegex = new Regex(@"^(\d+|\d+-\d+)(,\d+|,\d+-\d+)*$");
			if (!rangeRegex.IsMatch(humanList))
				throw new ArgumentException("Input list must be in 1,2,3-5 format.");

			var outputList = new List<int>();
			var items = humanList.Split(',');
			foreach (var range in items.Select(item => item.Split('-')))
			{
				switch (range.Length)
				{
					case 1:
						var value = int.Parse(range[0]);
						outputList.Add(value);
						break;

					case 2:
						var rangeStart = int.Parse(range[0]);
						var rangeEnd = int.Parse(range[1]);
						if (rangeStart >= rangeEnd)
							throw new ArgumentException("Input list contains inverted range like 2-1.");
						for (var v = rangeStart; v <= rangeEnd; v++)
							outputList.Add(v);
						break;

					default:
						throw new ArgumentException("Input list contains duplicate range specifier like 1-2-3.");
				}
			}
			return outputList.OrderBy(i => i).ToList();
		}

		public static string ReplaceNewLineWithBr(this string input)
		{
			return input.Replace(Environment.NewLine, "<br />");
		}

		/// <summary>
		/// Insert <see cref="Environment.NewLine"/> in string to create multiple lines
		/// of maximum length <paramref name="wrapLength"/>. Spaces are located for
		/// insertion points but words exceeding the wrap length are split.
		/// </summary>
		public static string WrapAt(this string orig, int wrapLength)
		{
			if (orig.Length <= wrapLength)
				return orig;

			var sb = new StringBuilder();
			while (orig.Length > 0)
			{
				if (orig.Length <= wrapLength)
				{
					sb.AppendLine(orig);
					break;
				}
				var splitAt = orig.Substring(0, wrapLength).LastIndexOf(" ", StringComparison.Ordinal);
				if (splitAt <= 0)
					splitAt = wrapLength;
				sb.AppendLine(orig.Substring(0, splitAt).Trim());
				orig = orig.Substring(splitAt).Trim();
			}

			return sb.ToString();
		}
		#region Experimental
		/// <summary>
		/// Create a string which summarizes the differences between <paramref name="original"/> and <paramref name="modified"/> objects.
		/// </summary>
		public static List<ClassVariance> GetObjectDifferences(object original, object modified)
		{
			if (original == null || modified == null)
				throw new ArgumentException("Compared objects must not be null.");

			if (original.GetType() != modified.GetType())
				throw new ArgumentException("Compared objects must be of same type.");

			var variances = new List<ClassVariance>();
			var properties = original.GetType().GetProperties();
			foreach (var p in properties)
			{
				var originalValue = p.GetValue(original, null);
				var newValue = p.GetValue(modified, null);

				if (Equals(originalValue, newValue))
					continue;

				var s1 = originalValue?.ToString() ?? "null";
				var s2 = newValue?.ToString() ?? "null";
				variances.Add(new ClassVariance { Prop = p.Name, valA = s1, valB = s2 });
			}
			return variances;
		}

		public static string SummarizeDifferences(List<ClassVariance> differences)
		{
			return !differences.Any() ? "No changes." : string.Join(", ", differences);
		}

		/// <summary>
		/// Returns distinct non-null values from <paramref name="collection"/>.
		/// </summary>
		public static IEnumerable<int> DistinctValues(this IEnumerable<int?> collection)
		{
			return collection?.Where(v => v.HasValue).Select(v => v.Value).Distinct();
		}
		#endregion
	}
}