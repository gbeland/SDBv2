using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SDB.Classes.General;

namespace SDB.Classes.RMA
{
	public static class ClassLegacyRMA_PDFPrint
	{
		/// <summary>
		/// Creates a PDF based on a ClassRMADetailObject (the data) and a filename.
		/// </summary>
		/// <param name="rdo">Data object with the RMA information to print to PDF.</param>
		/// <param name="strPDFFileName">PDF filename.</param>
		public static void Create(ClassLegacyRMA rdo, string strPDFFileName)
		{
			Document itsDocument = new Document(new Rectangle(11F * 72F, 8.5F * 72F), 36F, 36F, 36F, 36F);
			try
			{
				// initialize pdf
				PdfWriter writer = PdfWriter.GetInstance(itsDocument, new FileStream(strPDFFileName, FileMode.Create));
				itsDocument.Open();
				PdfContentByte cb = writer.DirectContent;
				writeRMADetail(rdo, cb);
			}
			catch (DocumentException de)
			{
				Console.Error.WriteLine(de.Message);
			}
			catch (IOException ioe)
			{
				MessageBox.Show("Could not generate PDF. Is the file in use?");
				Console.Error.WriteLine(ioe.Message);
			}
			itsDocument.Close();
		}

		[DllImport("shell32.dll")]
		private static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, uint dwFlags, [Out] StringBuilder pszPath);

		private static string GetFontFolderPath()
		{
			// ref: http://www.atalasoft.com/cs/blogs/stevehawley/archive/2008/08/25/getting-the-fonts-folder.aspx
			StringBuilder sb = new StringBuilder();
			SHGetFolderPath(IntPtr.Zero, 0x0014, IntPtr.Zero, 0x0000, sb);

			return sb.ToString();
		}

		/// <summary>
		/// Draws a string of text on PDF document.
		/// </summary>
		/// <param name="text">String to print</param>
		/// <param name="colorPercentage">int 0 - 100 where 0 = black ... 100 = white</param>
		/// <param name="font">Basefont font object</param>
		/// <param name="fontSize">int Font Size in points</param>
		/// <param name="x">Origin X-coordinate for string in inches. This point is at the left of left-justified text, center of center-justified, etc.</param>
		/// <param name="y">Origin Y-coordinate for string in inches.</param>
		/// <param name="a">Alignment character: 'L', 'C', 'R' for left-, center-, and right-justification respectively. Incorrect values are left-justified.</param>
		/// <param name="cb">PdfContentByte thinger required for absolute positioning of objects on PDF.</param>
		private static void drawText(string text, int colorPercentage, BaseFont font, int fontSize, float x, float y, char a, PdfContentByte cb)
		{
			if (text == "") return;
			// inches to drawing units
			x = x * 72;
			y = 612 - (y * 72);
			float r = 255 * (colorPercentage / 100);
			float g = 255 * (colorPercentage / 100);
			float b = 255 * (colorPercentage / 100);

			// show a little thingy at the origin for debugging
			//cb.SetLineWidth(.1F);
			//cb.SetColorStroke(Color.RED);
			//cb.MoveTo(X - 1, Y - 1);
			//cb.LineTo(X + 1, Y + 1);
			//cb.Stroke();
			//cb.MoveTo(X + 1, Y - 1);
			//cb.LineTo(X - 1, Y + 1);
			//cb.Stroke();

			int intAlignment;
			switch (a)
			{
				case 'R':
					intAlignment = PdfContentByte.ALIGN_RIGHT;
					break;
				case 'C':
					intAlignment = PdfContentByte.ALIGN_CENTER;
					break;
				default: // 'L'
					intAlignment = PdfContentByte.ALIGN_LEFT;
					break;
			}
			cb.BeginText();
			cb.SetFontAndSize(font, fontSize);
			cb.SetColorFill(new BaseColor(r, g, b));
			cb.ShowTextAligned(intAlignment, text, x, y, 0);
			cb.EndText();
		}

		private static void drawCol(string text, int colorPercentage, BaseFont font, int fontSize, float x, float y, float w, float h, char a, PdfContentByte cb)
		{
			/* origin is at bottom left of first line... however if the column needs to be two or more rows, the origin 
			 * is shifted down based on leading, this calculation is done to determine LLY (see below)
			 * */
			if (text == "") return;
			// inches to drawing units
			float fltLeading = fontSize * 1.2F;
			float llx = x * 72;
			float lly = 612 - (y * 72 + (((float)Math.Floor((h * 72) / fltLeading) - 1 ) * fltLeading));
			float urx = (x + w) * 72;
			float ury = 612 - (y * 72) + fltLeading;
			//X = X * 72;
			//Y = 612 - (Y * 72);
			//W = W * 72;
			//H = H * 72;
			float r = 255 * (colorPercentage / 100);
			float g = 255 * (colorPercentage / 100);
			float b = 255 * (colorPercentage / 100);

			// draw a box around the column for debugging
			//cb.SetLineWidth(.1F);
			//cb.SetColorStroke(Color.CYAN);
			//cb.Rectangle(LLX, URY, URX - LLX, LLY - URY);
			//cb.Stroke();
			
			// show an X at the origin for debugging
			//drawDebugX(X, Y, 3, Color.RED, cb);
			// other X's for debugging
			//drawDebugX(URX, URY, 2, Color.ORANGE, cb);
			//drawDebugX(LLX, LLY, 1, Color.GREEN, cb);

			int intAlignment;
			switch (a)
			{
				case 'R':
					intAlignment = PdfContentByte.ALIGN_RIGHT;
					break;
				case 'C':
					intAlignment = PdfContentByte.ALIGN_CENTER;
					break;
				default: // 'L'
					intAlignment = PdfContentByte.ALIGN_LEFT;
					break;
			}
			Phrase phText = new Phrase(fltLeading, text, new Font(font, fontSize, Font.NORMAL, new BaseColor(r, g, b)));
			ColumnText ct = new ColumnText(cb);
			ct.SetSimpleColumn(llx, lly, urx, ury + 1F, fltLeading, intAlignment); // add 1 point to height for buffer
			ct.AddText(phText);
			ct.Go(false);
		}

		/// <summary>
		/// Draws a rectangle on the PDF document.
		/// </summary>
		/// <param name="intColorPercentage">int 0 - 100 where 0 = black ... 100 = white</param>
		/// <param name="x">Top left X-coordinate of rectangle in inches.</param>
		/// <param name="y">Top left Y-coordinate of rectangle in inches.</param>
		/// <param name="x2">Bottom right X-coordinate of rectangle in inches.</param>
		/// <param name="y2">Bottom right Y-coordinate of rectangle in inches.</param>
		/// <param name="boolFilled">Boolean whether the rectangle is filled.</param>
		/// <param name="cb">PdfContentByte thinger required for absolute positioning of objects on PDF.</param>
		private static void drawBox(int intColorPercentage, float x, float y, float x2, float y2, bool boolFilled, PdfContentByte cb)
		{
			// inches to drawing units
			x = x * 72;
			y = 612 - (y * 72);
			x2 = x2 * 72;
			y2 = 612 - (y2 * 72);
			float r = intColorPercentage / 100F;
			float g = intColorPercentage / 100F;
			float b = intColorPercentage / 100F;

			// show X at the origin for debugging
			//drawDebug(X, Y, 2, Color.RED, cb);

			cb.SetLineWidth(1F);
			cb.SetColorStroke(new BaseColor(r, g, b));
			cb.Rectangle(x, y, x2 - x, y2 - y);

			if (boolFilled)
			{
				cb.SetColorFill(new BaseColor(r, g, b));
				cb.Fill();
			}
			cb.Stroke();
		}

		/// <summary>
		/// Draws a straight line on PDF document.
		/// </summary>
		/// <param name="colorPercentage">int 0 - 100 where 0 = black ... 100 = white</param>
		/// <param name="x">Start of line X-coordinate in inches.</param>
		/// <param name="y">Start of line Y-coordinate in inches.</param>
		/// <param name="x2">End of line X-coordinate in inches.</param>
		/// <param name="y2">End of line Y-coordinate in inches.</param>
		/// <param name="diameter">Thickness of line (diameter of pen) in points.</param>
		/// <param name="cb">PdfContentByte thinger required for absolute positioning of objects on PDF.</param>
		private static void drawLine(int colorPercentage, float x, float y, float x2, float y2, float diameter, PdfContentByte cb)
		{
			// inches to drawing units
			x = x * 72;
			y = 612 - (y * 72);
			x2 = x2 * 72;
			y2 = 612 - (y2 * 72);
			float r = 255 * (colorPercentage / 100);
			float g = 255 * (colorPercentage / 100);
			float b = 255 * (colorPercentage / 100);
			cb.SetLineWidth(diameter);
			cb.SetRGBColorStrokeF(r, g, b);
			cb.MoveTo(x, y);
			cb.LineTo(x2, y2);
			cb.Stroke();
		}

		//private void drawDebugX(float X, float Y, float fltLen, Color C, PdfContentByte cb)
		//{
		//    cb.SetLineWidth(.1F);
		//    cb.SetColorStroke(C);
		//    cb.MoveTo(X - fltLen, Y - fltLen);
		//    cb.LineTo(X + fltLen, Y + fltLen);
		//    cb.Stroke();
		//    cb.MoveTo(X + fltLen, Y - fltLen);
		//    cb.LineTo(X - fltLen, Y + fltLen);
		//    cb.Stroke();
		//}

		private static void writeRMADetail(ClassLegacyRMA rdo, PdfContentByte cb)
		{
			// define fonts
			BaseFont bfArial = BaseFont.CreateFont(GetFontFolderPath() + "\\arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED);
			BaseFont bfArialBold = BaseFont.CreateFont(GetFontFolderPath() + "\\arialbd.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED);
			//BaseFont bfArialI = BaseFont.CreateFont(GetFontFolderPath() + "\\ariali.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED);
			BaseFont bfArialBoldItalic = BaseFont.CreateFont(GetFontFolderPath() + "\\arialbi.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED);

			// Block Variables
			float fltTemp; // temporary for use within blocks

			#region Header and General
			float fltT = 1.5F;
			float fltS = .20F;

			// Header Box
			drawBox(0, 0.5F, 0.5F, 10.5F, 1.125F, false, cb);
			drawText("Yesco V.R.S. Database", 0, bfArialBold, 24, 5.5F, 0.85F, 'C', cb);
			drawText("RMA", 0, bfArialBold, 10, 0.75F, 1F, 'L', cb);
			drawText("Ticketing Management System", 0, bfArial, 10, 5.5F, 1F, 'C', cb);

			// Main Box
			drawBox(0, 0.5F, 1.25F, 10.5F, 8.0F, false, cb);

			// RMA#
			float fltL = .75F;
			drawText("RMA#", 0, bfArialBold, 10, fltL, fltTemp = fltT, 'L', cb);
			drawText(rdo.ID.ToString(), 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// APR
			drawText("APR Type", 0, bfArialBold, 10, fltL, fltTemp = fltT + fltS * 3, 'L', cb);
			drawText(rdo.APR, 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// Date Issued
			fltL = 1.8F;
			drawText("Date Issued", 0, bfArialBold, 10, fltL, fltTemp = fltT, 'L', cb);
			drawText(rdo.IssuedDate.ToString("yyyy-MM-dd"), 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// Issued By
			fltL = 3.0F;
			drawText("Issued By", 0, bfArialBold, 10, fltL, fltTemp = fltT, 'L', cb);
			drawText(rdo.IssuedBy, 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// Customer Work Order
			drawText("Cust. WO#", 0, bfArialBold, 10, fltL, fltTemp = fltT + fltS * 3, 'L', cb);
			drawText(rdo.CustomerWorkOrder, 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// PO
			fltL = 4.5F;
			drawText("PO", 0, bfArialBold, 10, fltL, fltTemp = fltT, 'L', cb);
			drawText(rdo.PONum, 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// Ticket Number
			drawText("Ticket", 0, bfArialBold, 10, fltL, fltTemp = fltT + fltS * 3, 'L', cb);
			drawText(rdo.Ticket_ID.ToString(), 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// Customer
			fltL = 5.4F;
			drawText("Customer", 0, bfArialBold, 10, fltL, fltTemp = fltT, 'L', cb);
			drawText(rdo.CustName, 0, bfArial, 10, fltL, fltTemp += fltS, 'L', cb);
			drawText(rdo.CustAddress, 0, bfArial, 10, fltL, fltTemp += fltS, 'L', cb);
			drawText(rdo.CustCSZ, 0, bfArial, 10, fltL, fltTemp += fltS, 'L', cb);
			drawText(rdo.CustTel, 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			// Ship to
			fltL = 8F;
			drawText("Ship To", 0, bfArialBold, 10, fltL, fltTemp = fltT, 'L', cb);
			drawText(rdo.CustShipName, 0, bfArial, 10, fltL, fltTemp += fltS, 'L', cb);
			drawText(rdo.CustShipAddress, 0, bfArial, 10, fltL, fltTemp += fltS, 'L', cb);
			drawText(rdo.CustShipCSZ, 0, bfArial, 10, fltL, fltTemp += fltS, 'L', cb);
			drawText(rdo.CustShipTel, 0, bfArial, 10, fltL, fltTemp + fltS, 'L', cb);

			drawLine(0, .5F, 2.825F, 10.5F, 2.825F, 1F, cb);
			#endregion

			#region PartsColumnDefinitions
			// column widths
			const float FLT_JOB = 0.775F;
			const float FLT_MU = 0.6F;
			const float FLT_DSP = 1.1F;
			const float FLT_QTY = 0.4F;
			const float FLT_MFG = 0.6F;
			const float FLT_DSC = 1.7F;
			const float FLT_RCV = 0.8F;
			const float FLT_ZNE = 0.4F;
			const float FLT_RET = 0.8F;
			const float FLT_SHP = 0.9F;
			const float FLT_PRI = 0.8F;
			const float FLT_TCH = 0.65F;
			// Problem/Repairs labels:
			const float FLT_PRL = FLT_JOB;
			// Problem/Repairs lines:
			const float FLT_PRD = FLT_MU + FLT_DSP + FLT_QTY + FLT_MFG + FLT_DSC + FLT_RCV + FLT_RET + FLT_SHP + FLT_PRI + FLT_TCH;
			#endregion

			#region PartsHeader
			fltL = .625F;
			fltT = 3F;
			BaseFont bfPh = bfArialBold;
			const int INT_PH_FONT_SIZE = 10;
			float fltHeight = (float)INT_PH_FONT_SIZE / 72 * 1.2F; // one line of leading (in inches)
			drawCol("Job", 0, bfPh, INT_PH_FONT_SIZE, fltTemp = fltL + .125F, fltT, FLT_JOB, fltHeight, 'L', cb);
			drawCol("MU", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_JOB, fltT, FLT_MU, fltHeight, 'L', cb);
			drawCol("Display", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_MU, fltT, FLT_DSP, fltHeight, 'L', cb);
			drawCol("Qty.", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_DSP, fltT, FLT_QTY, fltHeight, 'L', cb);
			drawCol("Mfg.", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_QTY, fltT, FLT_MFG, fltHeight, 'L', cb);
			drawCol("Description", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_MFG, fltT, FLT_DSC, fltHeight, 'L', cb);
			drawCol("Received", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_DSC, fltT, FLT_RCV, fltHeight, 'L', cb);
			drawCol("Zone", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_RCV, fltT, FLT_ZNE, fltHeight, 'L', cb);
			drawCol("Returned", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_ZNE, fltT, FLT_RET, fltHeight, 'L', cb);
			drawCol("Shipping", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_RET, fltT, FLT_SHP, fltHeight, 'L', cb);
			drawCol("Priority", 0, bfPh, INT_PH_FONT_SIZE, fltTemp += FLT_SHP, fltT, FLT_PRI, fltHeight, 'L', cb);
			drawCol("Tech", 0, bfPh, INT_PH_FONT_SIZE, fltTemp + FLT_SHP, fltT, FLT_TCH, fltHeight, 'L', cb);
			#endregion

			#region PartsLines
			fltL = .625F;
			fltT = 3.2F;
			fltS = .825F; // distance vertically between parts groups
			var bfPl = bfArial;
			const int INT_PL_FONT_SIZE = 9;
			fltHeight = ((float)INT_PL_FONT_SIZE / 72) * 1.2F; // one line of leading (in inches)
			for (var g = 0; g < rdo.PartData.Count(); g++)
			{
				drawBox(90, fltL - .015F, fltT - .15F, fltL + 9.745F, fltT + .5F, true, cb); // gray background on each part line
				drawCol((g + 1).ToString(), 0, bfArialBold, INT_PL_FONT_SIZE, fltTemp = fltL, fltT, .125F, fltHeight, 'L', cb); // bold numbering, left side
				drawCol(rdo.PartData[g].JobNum, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += .125F, fltT, FLT_JOB, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].MU, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_JOB, fltT, FLT_MU, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].DisplayName, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_MU, fltT, FLT_DSP, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].Qty.ToString(), 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_DSP, fltT, FLT_QTY, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].Mfg, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_QTY, fltT, FLT_MFG, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].Description, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_MFG, fltT, FLT_DSC, fltHeight, 'L', cb);
				drawCol(ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", "", rdo.PartData[g].ReceiveDate), 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_DSC, fltT, FLT_RCV, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].Zone, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_RCV, fltT, FLT_ZNE, fltHeight, 'L', cb);
				drawCol(ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", "", rdo.PartData[g].ReturnDate), 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_ZNE, fltT, FLT_RET, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].ShippingType, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_RET, fltT, FLT_SHP, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].Priority, 0, bfPl, INT_PL_FONT_SIZE, fltTemp += FLT_SHP, fltT, FLT_PRI, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].RepairTech, 0, bfPl, INT_PL_FONT_SIZE, fltTemp + FLT_SHP, fltT, FLT_TCH, fltHeight, 'L', cb);
				drawCol("Problem:", 0, bfArialBoldItalic, INT_PL_FONT_SIZE, fltTemp = fltL + .125F, fltT + fltHeight * 2F, FLT_PRL, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].Problem, 0, bfPl, INT_PL_FONT_SIZE, fltTemp + FLT_PRL, fltT + fltHeight * 2F, FLT_PRD, fltHeight, 'L', cb);
				drawCol("Repairs:", 0, bfArialBoldItalic, INT_PL_FONT_SIZE, fltTemp = fltL + .125F, fltT + fltHeight * 3F, FLT_PRL, fltHeight, 'L', cb);
				drawCol(rdo.PartData[g].Repairs, 0, bfPl, INT_PL_FONT_SIZE, fltTemp + FLT_PRL, fltT + fltHeight * 3F, FLT_PRD, fltHeight * 2F, 'L', cb);
				fltT += fltS;
			}
			#endregion

			#region Yesco Notes
			fltL = .625F;
			fltT = 7.125F;
			fltS = .15F;
			drawText("Yesco Notes:", 0, bfArialBold, 10, fltL, fltT, 'L', cb);
			drawText(rdo.YescoNotes, 0, bfArial, 10, fltL, fltT + fltS, 'L', cb);
			#endregion

			#region Customer Requests
			fltL = .625F;
			fltT = 7.625F;
			fltS = .15F;
			drawText("Customer Requests:", 0, bfArialBold, 10, fltL, fltT, 'L', cb);
			drawCol(rdo.CustomerRequests, 0, bfArial, 10, fltL, fltT + fltS, 9.75F, .45F, 'L', cb);
			#endregion
		}
	}
}