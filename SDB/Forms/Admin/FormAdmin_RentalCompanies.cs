using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Asset;
using SDB.Classes.Ticket;
using SDB.Forms.Asset;
using SDB.Forms.Ticket;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_RentalCompanies : Form
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		private enum EditAddMode
		{
			Edit,
			Add
		};
		#endregion

		#region Private Fields
		private EditAddMode _rentalCompanyEditMode;
		private EditAddMode _liftTypeEditMode;
		private ClassRentalCompany _selectedRentalCompany;
		private List<ClassRentalCompany> _rentalCompanies = new List<ClassRentalCompany>();
		private ClassLiftType _selectedLiftType;
		private List<ClassLiftType> _liftTypes = new List<ClassLiftType>();
		private bool _ignoreStateChange;
		private readonly Color _numberFormatBgColorValid = SystemColors.Window;
		private readonly Color _numberFormatBgColorInvalid = Color.FromArgb(255, 192, 192);
		#endregion

		#region Public Properties
		#endregion

		#region Constructor
		public FormAdmin_RentalCompanies()
		{
			InitializeComponent();

			olvRentalCompanies.PrimarySortColumn = olcRentalCompany;
			olvRentalCompanies.PrimarySortOrder = SortOrder.Ascending;

			olvRentalDivisions.PrimarySortColumn = olcDivisionName;
			olvRentalDivisions.PrimarySortOrder = SortOrder.Ascending;
		}
		#endregion

		#region Private Methods
		private void FormAdmin_RentalCompanies_Load(object sender, EventArgs e)
		{
			Populate();
		}

		private void Populate()
		{
			_selectedRentalCompany = null;
			_rentalCompanies = ClassRentalCompany.GetAll().ToList();
			olvRentalCompanies.SetObjects(_rentalCompanies);

			_selectedLiftType = null;
			_liftTypes = ClassLiftType.GetAll().ToList();
			olvLiftTypes.SetObjects(_liftTypes);
		}

		private void olvRentalCompanies_SelectionChanged(object sender, EventArgs e)
		{
			ShowRentalCompanyEditor(false);
			_selectedRentalCompany = (ClassRentalCompany)olvRentalCompanies.SelectedObject;
		}

		private void olvLiftTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowLiftTypeEditor(false);
			_selectedLiftType = (ClassLiftType)olvLiftTypes.SelectedObject;
		}

		private void olvRentalCompanies_DoubleClick(object sender, EventArgs e)
		{
			EditRentalCompany();
		}

		private void olvLiftTypes_DoubleClick(object sender, EventArgs e)
		{
			EditLiftType();
		}

		private void btnRentalCompany_Add_Click(object sender, EventArgs e)
		{
			AddRentalCompany();
		}

		private void btnLiftType_Add_Click(object sender, EventArgs e)
		{
			AddLiftType();
		}

		private void btnRentalCompany_Delete_Click(object sender, EventArgs e)
		{
			DeleteRentalCompany();
		}

		private void btnLiftType_Delete_Click(object sender, EventArgs e)
		{
			DeleteLiftType();
		}

		private void btnRentalCompany_Edit_Click(object sender, EventArgs e)
		{
			EditRentalCompany();
		}

		private void btnLiftType_Edit_Click(object sender, EventArgs e)
		{
			EditLiftType();
		}

		private void AddRentalCompany()
		{
			_rentalCompanyEditMode = EditAddMode.Add;
			ClearRentalCompanyEditor();
			ShowRentalCompanyEditor(true);
		}

		private void AddLiftType()
		{
			_liftTypeEditMode = EditAddMode.Add;
			ClearLiftTypeEditor();
			ShowLiftTypeEditor(true);
		}

		private void ClearRentalCompanyEditor()
		{
			_ignoreStateChange = true;
			foreach (var tb in pnlRentalCompany_Editor.Controls.OfType<TextBox>())
				tb.Clear();

			foreach (var cb in pnlNumberFormats.Controls.OfType<CheckBox>())
				cb.Checked = false;

			foreach (var tb in pnlNumberFormats.Controls.OfType<TextBox>())
			{
				tb.Clear();
				tb.BackColor = SystemColors.Window;
			}

			olvRentalDivisions.SetObjects(null);
			_ignoreStateChange = false;
		}

		private void ClearLiftTypeEditor()
		{
			_ignoreStateChange = true;
			foreach (var tb in pnlLiftType_Editor.Controls.OfType<TextBox>())
				tb.Clear();
			_ignoreStateChange = false;
		}

		private void EditRentalCompany()
		{
			if (_selectedRentalCompany == null)
				return;

			_rentalCompanyEditMode = EditAddMode.Edit;
			ClearRentalCompanyEditor();
			PopulateRentalCompanyEditor(_selectedRentalCompany);
			ShowRentalCompanyEditor(true);
		}

		private void EditLiftType()
		{
			if (_selectedLiftType == null)
				return;

			ClearLiftTypeEditor();
			PopulateLiftTypeEditor(_selectedLiftType);
			ShowLiftTypeEditor(true);
		}

		private void DeleteRentalCompany()
		{
			if (_selectedRentalCompany == null)
				return;

			var usedQty = ClassRentalCompany.GetUsedQty(_selectedRentalCompany.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Rental Company?", _selectedRentalCompany.Company, usedQty, Environment.NewLine),
				                    "Rental Company In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (var frc = new FormRentalCompany_Select())
				{
					if (frc.ShowDialog() != DialogResult.OK)
						return;

					if (frc.RentalCompany.ID == _selectedRentalCompany.ID)
					{
						MessageBox.Show("Cannot merge Rental Company with itself.", "Merge Rental Company Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Rental Company '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedRentalCompany.Company, frc.RentalCompany.Company),
					                    "Confirm Rental Company Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassRentalCompany.Merge(_selectedRentalCompany.ID, frc.RentalCompany.ID);
						ClassRentalCompany.Delete(_selectedRentalCompany);
						MessageBox.Show("Rental Company merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Rental Company merge failed: " + exc.Message, "Merge Rental Company Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Rental Company '{0}'?", _selectedRentalCompany.Company),
				                    "Confirm Remove Rental Company", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassRentalCompany.Delete(_selectedRentalCompany);
				//MessageBox.Show("Rental Company remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			Populate();
		}

		private void DeleteLiftType()
		{
			if (_selectedLiftType == null)
				return;

			var usedQty = ClassLiftType.GetUsedQty(_selectedLiftType.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Lift Type?", _selectedLiftType.Description, usedQty, Environment.NewLine),
				                    "Lift Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (var flt = new FormLiftType_Select())
				{
					if (flt.ShowDialog() != DialogResult.OK)
						return;

					if (flt.LiftType.ID == _selectedLiftType.ID)
					{
						MessageBox.Show("Cannot merge Lift Type with itself.", "Merge Lift Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Lift Type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedLiftType.Description, flt.LiftType.Description),
					                    "Confirm Lift Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassLiftType.Merge(_selectedLiftType.ID, flt.LiftType.ID);
						ClassLiftType.Delete(_selectedLiftType);
						MessageBox.Show("Lift Type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Lift Type merge failed: " + exc.Message, "Merge Lift Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Lift Type '{0}'?", _selectedLiftType.Description),
				                    "Confirm Remove Lift Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassLiftType.Delete(_selectedLiftType);
				//MessageBox.Show("Lift Type remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			Populate();
		}

		private void ShowRentalCompanyEditor(bool show)
		{
			foreach (var b in pnlRentalCompanies_Control.Controls.OfType<Button>())
				b.Enabled = !show;

			olvRentalCompanies.Visible = !show;
			pnlRentalCompany_Editor.Visible = show;

			if (show)
				txtRentalCompany_Name.Select();
		}

		private void ShowLiftTypeEditor(bool show)
		{
			foreach (var b in pnlLiftTypes_Control.Controls.OfType<Button>())
				b.Enabled = !show;

			olvLiftTypes.Visible = !show;
			pnlLiftType_Editor.Visible = show;

			if (show)
				txtLiftType_Description.Select();
		}

		private void PopulateRentalCompanyEditor(ClassRentalCompany rentalCompany)
		{
			_ignoreStateChange = true;
			txtRentalCompany_Name.Text = rentalCompany.Company;
			txtAccountNumber.Text = rentalCompany.AccountNumber;
			txtTelephoneNumber.Text = rentalCompany.Telephone;

			chkUse_ReservationNumber.Checked = rentalCompany.UsesReservationNumber;
			chkUse_EquipmentNumber.Checked = rentalCompany.UsesEquipmentNumber;
			chkUse_PickupNumber.Checked = rentalCompany.UsesPickupNumber;

			txtFormat_ReservationNumber.Text = rentalCompany.ReservationNumber_Format;
			txtFormat_EquipmentNumber.Text = rentalCompany.EquipmentNumber_Format;
			txtFormat_PickupNumber.Text = rentalCompany.PickupNumber_Format;

			rentalCompany.Divisions = ClassRentalDivision.GetByRentalCompany(rentalCompany.ID).ToList();
			olvRentalDivisions.SetObjects(rentalCompany.Divisions);
			_ignoreStateChange = false;
		}

		private void PopulateLiftTypeEditor(ClassLiftType liftType)
		{
			_ignoreStateChange = true;

			txtLiftType_Description.Text = liftType.Description;

			_ignoreStateChange = false;
		}

		private void btnRentalCompany_Editor_Cancel_Click(object sender, EventArgs e)
		{
			ClearRentalCompanyEditor();
			ShowRentalCompanyEditor(false);
		}

		private void btnLiftType_Editor_Cancel_Click(object sender, EventArgs e)
		{
			ClearLiftTypeEditor();
			ShowLiftTypeEditor(false);
		}

		private void btnRentalCompany_Editor_Save_Click(object sender, EventArgs e)
		{
			#region Validation
			string errors;
			if (!ValidateRentalCompanyInformation(out errors))
			{
				MessageBox.Show(errors, "Rental Company Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			#endregion

			switch (_rentalCompanyEditMode)
			{
				case EditAddMode.Add:
					var newRentalCompany = CreateRentalCompanyFromEditor();
					try
					{
						ClassRentalCompany.AddNew(ref newRentalCompany);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Error adding new rental company: " + exc.Message, "Error Adding Rental Company", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case EditAddMode.Edit:
					var modifiedRentalCompany = CreateRentalCompanyFromEditor();
					modifiedRentalCompany.ID = _selectedRentalCompany.ID;
					try
					{
						ClassRentalCompany.Update(modifiedRentalCompany);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Error updating rental company: " + exc.Message, "Error Updating Rental Company", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			Populate();
			ClearRentalCompanyEditor();
			ShowRentalCompanyEditor(false);
		}

		private void btnLiftType_Editor_Save_Click(object sender, EventArgs e)
		{
			#region Validation
			string errors;
			if (!ValidateLiftTypeInformation(out errors))
			{
				MessageBox.Show(errors, "Lift Type Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			#endregion

			switch (_liftTypeEditMode)
			{
				case EditAddMode.Add:
					var newLiftType = CreateLiftTypeFromEditor();
					ClassLiftType.AddNew(ref newLiftType);
					//string addedMessage = string.Format("New Lift Type '{0}' added.", newLiftType.Description);
					//MessageBox.Show(addedMessage, "Lift Type Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;

				case EditAddMode.Edit:
					var modifiedLiftType = CreateLiftTypeFromEditor();
					modifiedLiftType.ID = _selectedLiftType.ID;
					ClassLiftType.Update(modifiedLiftType);
					//string editedMessage = string.Format("Lift Type '{0}' successfully modified.", modifiedLiftType.Description);
					//MessageBox.Show(editedMessage, "Lift Type Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
			}

			Populate();
			ClearLiftTypeEditor();
			ShowLiftTypeEditor(false);
		}

		/// <summary>
		/// Validates data on the rental company editor and returns true if valid.
		/// If not, errors are contained in the string <paramref name=">errors"/>.
		/// </summary>
		private bool ValidateRentalCompanyInformation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtRentalCompany_Name.Text))
				sb.AppendLine("Company name cannot be blank.");

			if (!Validate_ReservationNumber())
				sb.AppendLine("Reservation number format is invalid.");

			if (!Validate_EquipmentNumber())
				sb.AppendLine("Equipment number format is invalid.");

			if (!Validate_PickupNumber())
				sb.AppendLine("Pickup number format is invalid.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		/// <summary>
		/// Validates data on the lift type editor and returns true if valid.
		/// If not, errors are contained in the string <paramref name=">errors"/>.
		/// </summary>
		private bool ValidateLiftTypeInformation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtLiftType_Description.Text))
				sb.AppendLine("Lift Type description cannot be blank.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}

		private ClassRentalCompany CreateRentalCompanyFromEditor()
		{
			var newRentalCompany = new ClassRentalCompany();

			newRentalCompany.Company = txtRentalCompany_Name.Text.Trim();
			newRentalCompany.AccountNumber = txtAccountNumber.Text.Trim();
			newRentalCompany.Telephone = txtTelephoneNumber.Text.Trim();

			newRentalCompany.UsesReservationNumber = chkUse_ReservationNumber.Checked;
			newRentalCompany.UsesEquipmentNumber = chkUse_EquipmentNumber.Checked;
			newRentalCompany.UsesPickupNumber = chkUse_PickupNumber.Checked;

			newRentalCompany.ReservationNumber_Format = txtFormat_ReservationNumber.Text.Trim();
			newRentalCompany.EquipmentNumber_Format = txtFormat_EquipmentNumber.Text.Trim();
			newRentalCompany.PickupNumber_Format = txtFormat_PickupNumber.Text.Trim();

			if(olvRentalDivisions.Objects!=null)
				newRentalCompany.Divisions = olvRentalDivisions.Objects.Cast<ClassRentalDivision>().ToList();

			return newRentalCompany;
		}

		private ClassLiftType CreateLiftTypeFromEditor()
		{
			var newLiftType = new ClassLiftType();

			newLiftType.Description = txtLiftType_Description.Text.Trim();

			return newLiftType;
		}

		private void chkUse_ReservationNumber_CheckedChanged(object sender, EventArgs e)
		{
			var enabled = chkUse_ReservationNumber.Checked;
			lblFormat_ReservationNumber.Enabled = enabled;
			txtFormat_ReservationNumber.Enabled = enabled;
			if (!enabled)
				txtFormat_ReservationNumber.BackColor = _numberFormatBgColorValid;
		}

		private void chkUse_EquipmentNumber_CheckedChanged(object sender, EventArgs e)
		{
			var enabled = chkUse_EquipmentNumber.Checked;
			lblFormat_EquipmentNumber.Enabled = enabled;
			txtFormat_EquipmentNumber.Enabled = enabled;
			if (!enabled)
				txtFormat_EquipmentNumber.BackColor = _numberFormatBgColorValid;
		}

		private void chkUse_PickupNumber_CheckedChanged(object sender, EventArgs e)
		{
			var enabled = chkUse_PickupNumber.Checked;
			lblFormat_PickupNumber.Enabled = enabled;
			txtFormat_PickupNumber.Enabled = enabled;
			if (!enabled)
				txtFormat_PickupNumber.BackColor = _numberFormatBgColorValid;
		}

		private void txtFormat_ReservationNumber_TextChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			Validate_ReservationNumber();
		}

		private void txtFormat_EquipmentNumber_TextChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			Validate_EquipmentNumber();
		}

		private void txtFormat_PickupNumber_TextChanged(object sender, EventArgs e)
		{
			if (_ignoreStateChange)
				return;

			Validate_PickupNumber();
		}

		private bool Validate_ReservationNumber()
		{
			var valid = !chkUse_ReservationNumber.Checked || ClassRentalCompany.NUMBER_FORMAT_REG_EX.IsMatch(txtFormat_ReservationNumber.Text);
			txtFormat_ReservationNumber.BackColor = valid ? _numberFormatBgColorValid : _numberFormatBgColorInvalid;
			return valid;
		}

		private bool Validate_EquipmentNumber()
		{
			var valid = !chkUse_EquipmentNumber.Checked || ClassRentalCompany.NUMBER_FORMAT_REG_EX.IsMatch(txtFormat_EquipmentNumber.Text);
			txtFormat_EquipmentNumber.BackColor = valid ? _numberFormatBgColorValid : _numberFormatBgColorInvalid;
			return valid;
		}

		private bool Validate_PickupNumber()
		{
			var valid = !chkUse_PickupNumber.Checked || ClassRentalCompany.NUMBER_FORMAT_REG_EX.IsMatch(txtFormat_PickupNumber.Text);
			txtFormat_PickupNumber.BackColor = valid ? _numberFormatBgColorValid : _numberFormatBgColorInvalid;
			return valid;
		}

		private void btnRentalDivision_Add_Click(object sender, EventArgs e)
		{
			var newDivision = new ClassRentalDivision {Name = "New Division"};
			olvRentalDivisions.AddObject(newDivision);
			olvRentalDivisions.SelectedObject = newDivision;
			olvRentalDivisions.EnsureVisible(olvRentalDivisions.IndexOf(newDivision));
			olvRentalDivisions.Select();
		}

		private void btnRentalDivision_Delete_Click(object sender, EventArgs e)
		{
			var selectedDivision = (ClassRentalDivision)olvRentalDivisions.SelectedObject;
			if (selectedDivision == null)
				return;

			if (MessageBox.Show(string.Format("Are you sure you want to remove Division '{0}'?", selectedDivision.Name),
			                    "Confirm Remove Division", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			olvRentalDivisions.RemoveObject(selectedDivision);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var t = (TextBox)sender;
			t.SelectAll();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		#region Public Methods
		#endregion
	}
}