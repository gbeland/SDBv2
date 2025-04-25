using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.UserControls.Ticket
{
	public partial class TicketRentals : UserControl
	{
		public delegate void CreateTicketRentalEvent();
		public delegate void EndTicketRentalEvent(ClassTicket_Rental ticketRental);

		public event CreateTicketRentalEvent CreateTicketRental;
		public event EndTicketRentalEvent EndTicketRental;

		public TicketRentals()
		{
			InitializeComponent();

			olvRentals.PrimarySortColumn = olcStart;
			olvRentals.PrimarySortOrder = SortOrder.Descending;
		}

		public void SetObjects<T>(IEnumerable<T> collection)
		{
			olvRentals.SetObjects(collection);
		}

		public void Clear()
		{
			olvRentals.SetObjects(null);
		}

		private void btnNewRental_Click(object sender, EventArgs e)
		{
			CreateTicketRental?.Invoke();
		}

		private void btnEndRental_Click(object sender, EventArgs e)
		{
			if (EndTicketRental == null)
				return;

			var ticketRental = (ClassTicket_Rental)olvRentals.SelectedObject;
			EndTicketRental(ticketRental);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var ticketRental = (ClassTicket_Rental)olvRentals.SelectedObject;
			DeleteTicketRental(ticketRental);
		}

		private void DeleteTicketRental(ClassTicket_Rental ticketRental)
		{
			if (ticketRental == null)
				return;

			// Allowed only by moderators/admins
			if (!GS.Settings.LoggedOnUser.IsAdmin && !GS.Settings.LoggedOnUser.IsMod)
				return;

			if (MessageBox.Show("Are you sure you want to delete this rental?", "Confirm Delete Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			ClassTicket_Rental.Delete(ticketRental);
		}

		/// <summary>
		/// Locks or unlocks controls for editing.
		/// </summary>
		public void LockControls(bool isLocked)
		{
			foreach (var button in pnlControl.Controls.OfType<Button>())
				button.Enabled = !isLocked;
		}
	}
}