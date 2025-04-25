using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Forms.Ticket
{
	public partial class FormTicket_Rental : Form
	{
		private readonly ClassTicket _ticket;

		private ClassLiftType _selectedLiftType;
		private ClassRentalCompany _selectedRentalCompany;
		private readonly List<ClassRentalDivision> _rentalDivisions;

		private static readonly Color _invalidBgColor = Color.FromArgb(255, 192, 192);
		private static readonly Color _validBgColor = Color.FromArgb(192, 255, 192);

		private enum FormMode
		{
			StartRental,
			EndRental
		};

		private readonly FormMode _formEditMode;

		public ClassTicket_Rental TicketRental { get; private set; }

		/// <summary>
		/// Specify <paramref name="ticket"/> to CREATE a new <see cref="ClassTicket_Rental"/>.
		/// Specify both <paramref name="ticket"/> and <paramref name="ticketRental"/> to END an existing <see cref="ClassTicket_Rental"/>.
		/// </summary>
		public FormTicket_Rental(ClassTicket ticket, ClassTicket_Rental ticketRental = null)
		{
			InitializeComponent();
			_ticket = ticket;

			var liftTypes = ClassLiftType.GetAll().ToList();
			var rentalCompanies = ClassRentalCompany.GetAll().ToList();
			_rentalDivisions = ClassRentalDivision.GetAll().ToList();

			cmbRental_LiftType.DisplayMember = "DisplayMember";
			cmbRental_LiftType.ValueMember = "ID";
			cmbRental_LiftType.DataSource = liftTypes;

			cmbRental_RentalCompany.DisplayMember = "DisplayMember";
			cmbRental_RentalCompany.ValueMember = "ID";
			cmbRental_RentalCompany.DataSource = rentalCompanies;

			TicketRental = ticketRental;

			_formEditMode = TicketRental == null ? FormMode.StartRental : FormMode.EndRental;
		}

		private void FormTicket_Rental_Load(object sender, EventArgs e)
		{
			txtDetails_TicketNumber.Text = $"{_ticket.ID}";
			txtDetails_Asset_AssetName.Text = _ticket.ExtraProperties.AssetName;
			txtDetails_AssignedTech.Text = _ticket.ExtraProperties.AssignedTechName;

			var asset = ClassAsset.GetByID(_ticket.AssetID);
			txtDetails_Asset_HAGL.Text = $"{asset.HeightAboveGroundLevel}";
			txtDetails_LiftType.Text = asset.LiftTypeId.HasValue ? ClassLiftType.GetByID(asset.LiftTypeId.Value).Description : string.Empty;
			txtDetails_LiftHeight.Text = $"{asset.Lift_Height}";

			Populate();
			SetFormMode();
		}

		private void Populate()
		{
			if (TicketRental == null)
			{
				cmbRental_RentalCompany.SelectedIndex = -1;
				cmbRental_LiftType.SelectedIndex = -1;
			}
			else
			{
				cmbRental_RentalCompany.SelectedValue = TicketRental.Rental_Company_ID;
				if (TicketRental.Lift_Type_ID.HasValue)
					cmbRental_LiftType.SelectedValue = TicketRental.Lift_Type_ID;
				else
					cmbRental_LiftType.SelectedIndex = -1;
			}

			numRental_LiftHeight.Value = TicketRental == null ? 0 : TicketRental.Lift_Height.GetValueOrDefault(0);
			txtRental_Reservation.Text = TicketRental == null ? string.Empty : TicketRental.Reservation_Number;
			txtRental_Equipment.Text = TicketRental == null ? string.Empty : TicketRental.Equipment_Number;
			txtRental_Pickup.Text = TicketRental == null ? string.Empty : TicketRental.PickUp_Number;
		}

		private void PopulateForSelectedRentalCompany()
		{
			ShowReservationNumberControls(_selectedRentalCompany != null && _selectedRentalCompany.UsesReservationNumber);
			ShowEquipmentNumberControls(_selectedRentalCompany != null && _selectedRentalCompany.UsesEquipmentNumber);
			ShowPickupNumberControls(_selectedRentalCompany != null && _selectedRentalCompany.UsesPickupNumber);

			lblRental_ReservationFormat.Text = _selectedRentalCompany == null ? string.Empty : _selectedRentalCompany.ReservationNumber_Format;
			lblRental_EquipmentFormat.Text = _selectedRentalCompany == null ? string.Empty : _selectedRentalCompany.EquipmentNumber_Format;
			lblRental_PickupFormat.Text = _selectedRentalCompany == null ? string.Empty : _selectedRentalCompany.PickupNumber_Format;

			txtRental_Telephone.Text = _selectedRentalCompany == null ? string.Empty : _selectedRentalCompany.Telephone;
			txtRental_AccountNumber.Text = _selectedRentalCompany == null ? string.Empty : _selectedRentalCompany.AccountNumber;

			olvRentalDivisions.SetObjects(_selectedRentalCompany == null ? null : _rentalDivisions.Where(d => d.Rental_Company_ID == _selectedRentalCompany.ID));
		}

		/// <summary>
		/// Shows or hides reservation number controls.
		/// </summary>
		private void ShowReservationNumberControls(bool show)
		{
			lblRental_Reservation.Visible = show;
			txtRental_Reservation.Visible = show;
			lblRental_ReservationFormat.Visible = show;
		}

		private void ShowEquipmentNumberControls(bool show)
		{
			lblRental_Equipment.Visible = show;
			txtRental_Equipment.Visible = show;
			lblRental_EquipmentFormat.Visible = show;
		}

		private void ShowPickupNumberControls(bool show)
		{
			lblRental_Pickup.Visible = show;
			txtRental_Pickup.Visible = show;
			lblRental_PickupFormat.Visible = show;
		}

		private void SetFormMode()
		{
			btnOK.Text = _formEditMode == FormMode.StartRental ? "Start Rental" : "End Rental";
			// If the form mode is "EndRental" then the company, lift type, lift height, reservation number, and equipment number cannot be changed.
			if (_formEditMode == FormMode.EndRental)
			{
				cmbRental_RentalCompany.Enabled = false;
				cmbRental_LiftType.Enabled = false;
				numRental_LiftHeight.Enabled = false;
			}

			EnableReservationNumberControls(_formEditMode == FormMode.StartRental);
			EnableEquipmentNumberControls(_formEditMode == FormMode.StartRental);
			EnablePickupNumberControls(_formEditMode == FormMode.EndRental);
		}

		private void EnableReservationNumberControls(bool enable)
		{
			lblRental_Reservation.Enabled = enable;
			txtRental_Reservation.Enabled = enable;
			lblRental_ReservationFormat.Enabled = enable;
		}

		private void EnableEquipmentNumberControls(bool enable)
		{
			lblRental_Equipment.Enabled = enable;
			txtRental_Equipment.Enabled = enable;
			lblRental_EquipmentFormat.Enabled = enable;
		}

		private void EnablePickupNumberControls(bool enable)
		{
			lblRental_Pickup.Enabled = enable;
			txtRental_Pickup.Enabled = enable;
			lblRental_PickupFormat.Enabled = enable;
		}

		private void cmbRental_RentalCompany_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedRentalCompany = (ClassRentalCompany)cmbRental_RentalCompany.SelectedItem;

			PopulateForSelectedRentalCompany();
		}

		private void cmbRental_LiftType_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedLiftType = (ClassLiftType)cmbRental_LiftType.SelectedItem;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void numUpDown_Enter(object sender, EventArgs e)
		{
			var n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string errors;
			switch (_formEditMode)
			{
				case FormMode.StartRental:
					if (!Validate_StartRental(out errors))
					{
						MessageBox.Show(errors, "Rental Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					
					TicketRental = CreateTicketRentalFromControls();
					TicketRental.Reservation_Start = ClassDatabase.GetCurrentTime();
					break;

				case FormMode.EndRental:
					if (!Validate_EndRental(out errors))
					{
						MessageBox.Show(errors, "Rental End Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					TicketRental = CreateTicketRentalFromControls();
					TicketRental.Reservation_End = ClassDatabase.GetCurrentTime();
					break;
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private bool Validate_StartRental(out string errors)
		{
			var sb = new StringBuilder();

			if (cmbRental_LiftType.SelectedIndex < 0)
				sb.AppendLine("Selected lift type is invalid.");

			if (numRental_LiftHeight.Value == 0)
				sb.AppendLine("Selected lift height is invalid.");

			if (!_selectedRentalCompany.Validate_ReservationNumber(txtRental_Reservation.Text))
				sb.AppendLine("Reservation number is invalid.");

			if (!_selectedRentalCompany.Validate_EquipmentNumber(txtRental_Equipment.Text))
				sb.AppendLine("Equipment number is invalid.");

			errors = sb.ToString();
			return (string.IsNullOrEmpty(errors));
		}

		private bool Validate_EndRental(out string errors)
		{
			var sb = new StringBuilder();

			if (!_selectedRentalCompany.Validate_PickupNumber(txtRental_Pickup.Text))
				sb.AppendLine("Pickup number is invalid.");

			errors = sb.ToString();
			return (string.IsNullOrEmpty(errors));
		}

		private ClassTicket_Rental CreateTicketRentalFromControls()
		{
			return new ClassTicket_Rental
					   {
						   ID = TicketRental?.ID ?? -1,
						   Ticket_ID = _ticket.ID,
						   Rental_Company_ID = _selectedRentalCompany.ID,
						   Rental_Company_Name = _selectedRentalCompany.Company,
						   Reservation_Start = TicketRental?.Reservation_Start ?? ClassDatabase.GetCurrentTime(),
						   Reservation_Number = txtRental_Reservation.Text.NullIfEmpty(),
						   Equipment_Number = txtRental_Equipment.Text.NullIfEmpty(),
						   PickUp_Number = txtRental_Pickup.Text.NullIfEmpty(),
						   Lift_Type_ID = _selectedLiftType?.ID,
						   Lift_Height = numRental_LiftHeight.Value == 0 ? (int?)null : (int)numRental_LiftHeight.Value
					   };
		}

		private void txtRental_Reservation_TextChanged(object sender, EventArgs e)
		{
			var valid = _selectedRentalCompany.Validate_ReservationNumber(txtRental_Reservation.Text);
			lblRental_Reservation_Valid.Text = valid ? "VALID" : "INVALID";
			lblRental_Reservation_Valid.BackColor = valid ? _validBgColor : _invalidBgColor;
		}

		private void txtRental_Equipment_TextChanged(object sender, EventArgs e)
		{
			var valid = _selectedRentalCompany.Validate_EquipmentNumber(txtRental_Equipment.Text);
			lblRental_Equipment_Valid.Text = valid ? "VALID" : "INVALID";
			lblRental_Equipment_Valid.BackColor = valid ? _validBgColor : _invalidBgColor;
		}

		private void txtRental_Pickup_TextChanged(object sender, EventArgs e)
		{
			var valid = _selectedRentalCompany.Validate_PickupNumber(txtRental_Pickup.Text);
			lblRental_Pickup_Valid.Text = valid ? "VALID" : "INVALID";
			lblRental_Pickup_Valid.BackColor = valid ? _validBgColor : _invalidBgColor;
		}
	}
}