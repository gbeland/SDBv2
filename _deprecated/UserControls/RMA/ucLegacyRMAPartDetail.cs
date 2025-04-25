using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.RMA;

namespace SDB.UserControls.RMA
{
	public partial class ucLegacyRMAPartDetail : UserControl
	{
		private ClassLegacyRMA.PartLine _part;

		public void SetPart(ClassLegacyRMA.PartLine Part)
		{
			_part = Part;
			lblShow_Job.Text = Part.JobNum;
			lblShow_MU.Text = Part.MU;
			lblShow_Display.Text = Part.DisplayName;
			lblShow_Qty.Text = Part.Qty.ToString();
			BackColor = (Part.Qty > 0 ? Color.Transparent : Color.DarkGray);
			Enabled = Part.Qty > 0;
			lblShow_Mfg.Text = Part.Mfg;
			lblShow_Description.Text = Part.Description;
			lblShow_Received.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", "", Part.ReceiveDate);
			lblShow_Zone.Text = Part.Zone;
			lblShow_Returned.Text = ClassUtility.StringFormatNull("{0:yyyy-MM-dd}", "", Part.ReturnDate);
			lblShow_Shipping.Text = Part.ShippingType;
			lblShow_Priority.Text = Part.Priority;
			lblShow_Tech.Text = Part.RepairTech;
			lblShow_Problem.Text = Part.Problem;
			lblShow_Repairs.Text = Part.Repairs;
		}

		public ClassLegacyRMA.PartLine GetPart()
		{
			return _part;
		}

		public void SetDesignation(int Designation)
		{
			lblRMAPartDesignation.Text = Designation.ToString("0");
		}

		public ucLegacyRMAPartDetail()
		{
			InitializeComponent();
		}
	}
}
