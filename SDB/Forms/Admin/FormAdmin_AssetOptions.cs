using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Forms.Asset;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_AssetOptions : Form
	{
		private enum EditAddMode
		{
			Edit,
			Add
		};

		private EditAddMode _outputMethodEditMode;
		private ClassOutputMethod _selectedOutputMethod;
		private List<ClassOutputMethod> _outputMethods = new List<ClassOutputMethod>();

		private EditAddMode _cabinetTypeEditMode;
		private ClassCabinetType _selectedCabinetType;
		private List<ClassCabinetType> _cabinetTypes = new List<ClassCabinetType>();

		private EditAddMode _controllerHwEditMode;
		private ControllerHardware _selectedControllerHardware;
		private List<ControllerHardware> _controllerHardware = new List<ControllerHardware>();

		private EditAddMode _controllerSwEditMode;
		private ControllerSoftware _selectedControllerSoftware;
		private List<ControllerSoftware> _controllerSoftware = new List<ControllerSoftware>();

		private EditAddMode _controllerConnEditMode;
		private ControllerConnection _selectedControllerConnection;
		private List<ControllerConnection> _controllerConnections = new List<ControllerConnection>();

        private EditAddMode _clientConnEditMode;
        private ClassClientConnection _selectedClientConnection;
        private List<ClassClientConnection> _clientConnections = new List<ClassClientConnection>();

        private EditAddMode _playerSoftwareEditMode;
        private ClassPlayerSoftware _selectedPlayerSoftware;
        private List<ClassPlayerSoftware> _playerSoftwares = new List<ClassPlayerSoftware>();

		public FormAdmin_AssetOptions()
		{
			InitializeComponent();

			olvCabinetTypes.PrimarySortColumn = olcCabinetType_Description;
			olvCabinetTypes.PrimarySortOrder = SortOrder.Ascending;

			olvOutputMethods.PrimarySortColumn = olcOutputMethodDescription;
			olvOutputMethods.PrimarySortOrder = SortOrder.Ascending;

			olvControllerHw.PrimarySortColumn = olcControllerHw_Description;
			olvControllerHw.PrimarySortOrder = SortOrder.Ascending;

			olvControllerSw.PrimarySortColumn = olcControllerSw_Description;
			olvControllerSw.PrimarySortOrder = SortOrder.Ascending;

			olvControllerConn.PrimarySortColumn = olcControllerConn_Description;
			olvControllerConn.PrimarySortOrder = SortOrder.Ascending;

            olvClientConns.PrimarySortColumn = olcClientConn;
            olvClientConns.PrimarySortOrder = SortOrder.Ascending;

            olvPlayerSoftware.PrimarySortColumn = olvColPlayerSoftware;
            olvPlayerSoftware.PrimarySortOrder = SortOrder.Ascending;
        }

        private void FormAdmin_AssetOptions_Load(object sender, EventArgs e)
		{
			Populate();
		}

		private void Populate()
		{
			_selectedOutputMethod = null;
			_outputMethods = ClassOutputMethod.GetAll().ToList();
			olvOutputMethods.SetObjects(_outputMethods);

			_selectedCabinetType = null;
			_cabinetTypes = ClassCabinetType.GetAll().ToList();
			olvCabinetTypes.SetObjects(_cabinetTypes);

			_selectedControllerHardware = null;
			_controllerHardware = ControllerHardware.GetAll().ToList();
			olvControllerHw.SetObjects(_controllerHardware);

			_selectedControllerSoftware = null;
			_controllerSoftware = ControllerSoftware.GetAll().ToList();
			olvControllerSw.SetObjects(_controllerSoftware);

			_selectedControllerConnection = null;
			_controllerConnections = ControllerConnection.GetAll().ToList();
			olvControllerConn.SetObjects(_controllerConnections);

            _selectedClientConnection = null;
            _clientConnections = ClassClientConnection.GetAll().ToList();
            olvClientConns.SetObjects(_clientConnections);

            _selectedPlayerSoftware = null;
            _playerSoftwares = ClassPlayerSoftware.GetAll().ToList();
            olvPlayerSoftware.SetObjects(_playerSoftwares);
		}

		private void olvOutputMethods_SelectionChanged(object sender, EventArgs e)
		{
			ShowOutputMethodEditor(false);
			_selectedOutputMethod = (ClassOutputMethod)olvOutputMethods.SelectedObject;
		}
		private void olvCabinetTypes_SelectionChanged(object sender, EventArgs e)
		{
			ShowCabinetTypeEditor(false);
			_selectedCabinetType = (ClassCabinetType)olvCabinetTypes.SelectedObject;
		}
		private void olvControllerHw_SelectionChanged(object sender, EventArgs e)
		{
			ShowControllerHwEditor(false);
			_selectedControllerHardware = (ControllerHardware)olvControllerHw.SelectedObject;
		}
		private void olvControllerSw_SelectionChanged(object sender, EventArgs e)
		{
			ShowControllerSwEditor(false);
			_selectedControllerSoftware = (ControllerSoftware)olvControllerSw.SelectedObject;
		}
		private void olvControllerConn_SelectionChanged(object sender, EventArgs e)
		{
			ShowControllerConnEditor(false);
			_selectedControllerConnection = (ControllerConnection)olvControllerConn.SelectedObject;
		}
        private void olvClientConn_SelectionChanged(object sender, EventArgs e)
        {
            ShowClientConnEditor(false);
            _selectedClientConnection = (ClassClientConnection)olvClientConns.SelectedObject;
        }

        //NEW
        private void olvPlayerSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void olvOutputMethods_DoubleClick(object sender, EventArgs e)
		{
			EditOutputMethod();
		}
		private void olvCabinetTypes_DoubleClick(object sender, EventArgs e)
		{
			EditCabinetType();
		}
		private void olvControllerHw_DoubleClick(object sender, EventArgs e)
		{
			EditControllerHardware();
		}
		private void olvControllerSw_DoubleClick(object sender, EventArgs e)
		{
			EditControllerSoftware();
		}
		private void olvControllerConn_DoubleClick(object sender, EventArgs e)
		{
			EditControllerConnection();
		}
        private void olvClientConn_DoubleClick(object sender, EventArgs e)
        {
            EditClientConnection();
        }

        //NEW
        private void olvPlayerSoftware_DoubleClick(object sender, EventArgs e)
        {
            EditPlayerSoftware();
        }


        private void btnOutputMethod_Add_Click(object sender, EventArgs e)
		{
			AddOutputMethod();
		}
		private void btnCabinetType_Add_Click(object sender, EventArgs e)
		{
			AddCabinetType();
		}
		private void btnControllerHw_Add_Click(object sender, EventArgs e)
		{
			AddControllerHardware();
		}
		private void btnControllerSw_Add_Click(object sender, EventArgs e)
		{
			AddControllerSoftware();
		}
		private void btnControllerConn_Add_Click(object sender, EventArgs e)
		{
			AddControllerConnection();
		}
        private void btnClientConn_Add_Click(object sender, EventArgs e)
        {
            _clientConnEditMode = EditAddMode.Add;
            AddClientConnection();
        }

        //NEW
        private void btnPlayerSoftware_Add_Click(object sender, EventArgs e)
        {
            _playerSoftwareEditMode = EditAddMode.Add;
            AddPlayerSoftware();
        }


        private void btnOutputMethod_Delete_Click(object sender, EventArgs e)
		{
			DeleteOutputMethod();
		}
		private void btnCabinetType_Delete_Click(object sender, EventArgs e)
		{
			DeleteCabinetType();
		}
		private void btnControllerHw_Delete_Click(object sender, EventArgs e)
		{
			DeleteControllerHardware();
		}
		private void btnControllerSw_Delete_Click(object sender, EventArgs e)
		{
			DeleteControllerSoftware();
		}
		private void btnControllerConn_Delete_Click(object sender, EventArgs e)
		{
			DeleteControllerConnection();
		}
        private void btnClientConn_Delete_Click(object sender, EventArgs e)
        {
            DeleteClientConnection();
        }

        //NEW
        private void btnPlayerSoftware_Delete_Click(object sender, EventArgs e)
        {
            DeletePlayerSoftware();
        }

        private void btnOutputMethod_Edit_Click(object sender, EventArgs e)
		{
			EditOutputMethod();
		}
		private void btnCabinetType_Edit_Click(object sender, EventArgs e)
		{
			EditCabinetType();
		}
		private void btnControllerHw_Edit_Click(object sender, EventArgs e)
		{
			EditControllerHardware();
		}
		private void btnControllerSw_Edit_Click(object sender, EventArgs e)
		{
			EditControllerSoftware();
		}
		private void btnControllerConn_Edit_Click(object sender, EventArgs e)
		{
			EditControllerConnection();
		}
        private void btnClientConn_Edit_Click(object sender, EventArgs e)
        {
            _clientConnEditMode = EditAddMode.Edit;
            EditClientConnection();
        }

        //NEW
        private void btnPlayerSoftware_Edit_Click(object sender, EventArgs e)
        {
            _playerSoftwareEditMode = EditAddMode.Edit;
            EditPlayerSoftware();
        }

        private void AddOutputMethod()
		{
			_outputMethodEditMode = EditAddMode.Add;
			ClearOutputMethodEditor();
			ShowOutputMethodEditor(true);
		}
		private void AddCabinetType()
		{
			_cabinetTypeEditMode = EditAddMode.Add;
			ClearCabinetTypeEditor();
			ShowCabinetTypeEditor(true);
		}
		private void AddControllerHardware()
		{
			_controllerHwEditMode = EditAddMode.Add;
			ClearControllerHwEditor();
			ShowControllerHwEditor(true);
		}
		private void AddControllerSoftware()
		{
			_controllerSwEditMode = EditAddMode.Add;
			ClearControllerSwEditor();
			ShowControllerSwEditor(true);
		}
		private void AddControllerConnection()
		{
			_controllerConnEditMode = EditAddMode.Add;
			ClearControllerConnEditor();
			ShowControllerConnEditor(true);
		}
        private void AddClientConnection()
        {
            _clientConnEditMode = EditAddMode.Add;
            ClearClientConnEditor();
            ShowClientConnEditor(true);
        }

        //New
        private void AddPlayerSoftware()
        {
            _playerSoftwareEditMode = EditAddMode.Add;
            ClearPlayerSoftwareEditor();
            ShowPlayerSoftwareEditor(true);
        }


        private void ClearOutputMethodEditor()
		{
			foreach (var tb in pnlOutputMethod_Editor.Controls.OfType<TextBox>())
				tb.Clear();
		}
		private void ClearCabinetTypeEditor()
		{
			foreach (var tb in pnlCabinetType_Editor.Controls.OfType<TextBox>())
				tb.Clear();
		}
		private void ClearControllerHwEditor()
		{
			foreach (var tb in pnlControllerHw_Editor.Controls.OfType<TextBox>())
				tb.Clear();
		}
		private void ClearControllerSwEditor()
		{
			foreach (var tb in pnlControllerSw_Editor.Controls.OfType<TextBox>())
				tb.Clear();
		}
		private void ClearControllerConnEditor()
		{
			foreach (var tb in pnlControllerConn_Editor.Controls.OfType<TextBox>())
				tb.Clear();
		}
        private void ClearClientConnEditor()
        {
            foreach (var tb in pnlClientConn_Editor.Controls.OfType<TextBox>())
                tb.Clear();
        }

        //NEW
        private void ClearPlayerSoftwareEditor()
        {
            foreach (var tb in pnlPlayerSoftware_Editor.Controls.OfType<TextBox>())
                tb.Clear();
        }



        private void EditOutputMethod()
		{
			if (_selectedOutputMethod == null)
				return;

			_outputMethodEditMode = EditAddMode.Edit;
			ClearOutputMethodEditor();
			PopulateOutputMethodEditor(_selectedOutputMethod);
			ShowOutputMethodEditor(true);
		}
		private void EditCabinetType()
		{
			if (_selectedCabinetType == null)
				return;

			ClearCabinetTypeEditor();
			PopulateCabinetTypeEditor(_selectedCabinetType);
			ShowCabinetTypeEditor(true);
		}
		private void EditControllerHardware()
		{
			if (_selectedControllerHardware == null)
				return;

			ClearControllerHwEditor();
			PopulateControllerHardwareEditor(_selectedControllerHardware);
			ShowControllerHwEditor(true);
		}
		private void EditControllerSoftware()
		{
			if (_selectedControllerSoftware == null)
				return;

			ClearControllerSwEditor();
			PopulateControllerSoftwareEditor(_selectedControllerSoftware);
			ShowControllerSwEditor(true);
		}
		private void EditControllerConnection()
		{
			if (_selectedControllerConnection == null)
				return;

			ClearControllerConnEditor();
			PopulateControllerConnectionEditor(_selectedControllerConnection);
			ShowControllerConnEditor(true);
		}
        private void EditClientConnection()
        {
            if (_selectedClientConnection == null)
                return;

            ClearClientConnEditor();
            PopulateClientConnectionEditor(_selectedClientConnection);
            ShowClientConnEditor(true);
        }

        //NEW
        private void EditPlayerSoftware()
        {
            if (_selectedPlayerSoftware == null)
                return;

            ClearPlayerSoftwareEditor();
            PopulatePlayerSoftwareEditor(_selectedPlayerSoftware);
            ShowPlayerSoftwareEditor(true);
        }



        private void DeleteOutputMethod()
		{
			if (_selectedOutputMethod == null)
				return;

			var usedQty = ClassOutputMethod.GetUsedQty(_selectedOutputMethod.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Output Method?", _selectedOutputMethod.Description, usedQty, Environment.NewLine),
									"Output Method In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (var frmOutputMethod = new FormAsset_OutputMethod_Select())
				{
					if (frmOutputMethod.ShowDialog() != DialogResult.OK)
						return;

					if (frmOutputMethod.OutputMethod.ID == _selectedOutputMethod.ID)
					{
						MessageBox.Show("Cannot merge Output Method with itself.", "Merge Output Method Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show(string.Format("Output Method '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedOutputMethod.Description, frmOutputMethod.OutputMethod.Description),
										"Confirm Output Method Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassOutputMethod.Merge(_selectedOutputMethod.ID, frmOutputMethod.OutputMethod.ID);
						ClassOutputMethod.Delete(_selectedCabinetType.ID);
						MessageBox.Show("Output Method merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Output Method merge failed: " + exc.Message, "Merge Output Method Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Format("Are you sure you want to remove Output Method '{0}'?", _selectedOutputMethod.Description),
									"Confirm Remove Output Method", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassOutputMethod.Delete(_selectedOutputMethod.ID);
			}

			Populate();
		}
		private void DeleteCabinetType()
		{
			if (_selectedCabinetType == null)
				return;

			var usedQty = ClassCabinetType.GetUsedQty(_selectedCabinetType.ID);
			if (usedQty > 0)
			{
				if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Cabinet Type?", _selectedCabinetType.Description, usedQty, Environment.NewLine),
									"Cabinet Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				using (var frmCabinetType = new FormAsset_CabinetType_Select())
				{
					if (frmCabinetType.ShowDialog() != DialogResult.OK)
						return;

					if (frmCabinetType.CabinetType.ID == _selectedCabinetType.ID)
					{
						MessageBox.Show("Cannot merge Cabinet Type with itself.", "Merge Cabinet Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if (MessageBox.Show($"Cabinet Type '{_selectedCabinetType.Description}' will be replaced with '{frmCabinetType.CabinetType.Description}' throughout the database. Do you want to proceed?",
										"Confirm Cabinet Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ClassCabinetType.Merge(_selectedCabinetType.ID, frmCabinetType.CabinetType.ID);
						ClassCabinetType.Delete(_selectedCabinetType.ID);
						MessageBox.Show("Cabinet Type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show("Cabinet Type merge failed: " + exc.Message, "Merge Cabinet Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				if (MessageBox.Show($"Are you sure you want to remove Cabinet Type '{_selectedCabinetType.Description}'?",
									"Confirm Remove Cabinet Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ClassCabinetType.Delete(_selectedCabinetType.ID);
			}

			Populate();
		}
		private void DeleteControllerHardware()
		{
			const string OBJECT_NAME = "Controller Hardware";
			var doubleNewLine = string.Format("{0}{0}", Environment.NewLine);

			if (_selectedControllerHardware == null)
				return;

			var usedQty = ControllerHardware.GetUsedQty(_selectedControllerHardware.ID);
			if (usedQty > 0)
			{
				var message = $"Cannot remove '{_selectedControllerHardware.Description}' because it is used {usedQty} time(s) in the database.{doubleNewLine}Do you want to merge it with another {OBJECT_NAME}?";
				if (MessageBox.Show(message, $"{OBJECT_NAME} In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var controllerHardwareSelectForm = new FormAsset_ControllerHardware_Select())
				{
					if (controllerHardwareSelectForm.ShowDialog() != DialogResult.OK)
						return;

					if (controllerHardwareSelectForm.ControllerHardware.ID == _selectedControllerHardware.ID)
					{
						MessageBox.Show($"Cannot merge {OBJECT_NAME} with itself.", $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					var question = $"{OBJECT_NAME} '{_selectedControllerHardware.Description}' will be replaced with '{controllerHardwareSelectForm.ControllerHardware.Description}' throughout the database. Do you want to proceed?";
					if (MessageBox.Show(question, $"Confirm {OBJECT_NAME} Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ControllerHardware.Merge(_selectedControllerHardware.ID, controllerHardwareSelectForm.ControllerHardware.ID);
						ControllerHardware.Delete(_selectedControllerHardware.ID);
						MessageBox.Show($"{OBJECT_NAME} merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show($"{OBJECT_NAME} merge failed: " + exc.Message, $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				var question = $"Are you sure you want to remove {OBJECT_NAME} '{_selectedControllerHardware.Description}'?";
				if (MessageBox.Show(question, $"Confirm Remove {OBJECT_NAME}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ControllerHardware.Delete(_selectedControllerHardware.ID);
			}

			Populate();
		}
		private void DeleteControllerSoftware()
		{
			const string OBJECT_NAME = "Controller Software";
			var doubleNewLine = string.Format("{0}{0}", Environment.NewLine);

			if (_selectedControllerSoftware == null)
				return;

			var usedQty = ControllerSoftware.GetUsedQty(_selectedControllerSoftware.ID);
			if (usedQty > 0)
			{
				var message = $"Cannot remove '{_selectedControllerSoftware.Description}' because it is used {usedQty} time(s) in the database.{doubleNewLine}Do you want to merge it with another {OBJECT_NAME}?";
				if (MessageBox.Show(message, $"{OBJECT_NAME} In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var controllerSoftwareSelectForm = new FormAsset_ControllerSoftware_Select())
				{
					if (controllerSoftwareSelectForm.ShowDialog() != DialogResult.OK)
						return;

					if (controllerSoftwareSelectForm.ControllerSoftware.ID == _selectedControllerSoftware.ID)
					{
						MessageBox.Show($"Cannot merge {OBJECT_NAME} with itself.", $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					var question = $"{OBJECT_NAME} '{_selectedControllerSoftware.Description}' will be replaced with '{controllerSoftwareSelectForm.ControllerSoftware.Description}' throughout the database. Do you want to proceed?";
					if (MessageBox.Show(question, $"Confirm {OBJECT_NAME} Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ControllerSoftware.Merge(_selectedControllerSoftware.ID, controllerSoftwareSelectForm.ControllerSoftware.ID);
						ControllerSoftware.Delete(_selectedControllerSoftware.ID);
						MessageBox.Show($"{OBJECT_NAME} merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show($"{OBJECT_NAME} merge failed: " + exc.Message, $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				var question = $"Are you sure you want to remove {OBJECT_NAME} '{_selectedControllerSoftware.Description}'?";
				if (MessageBox.Show(question, $"Confirm Remove {OBJECT_NAME}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ControllerHardware.Delete(_selectedControllerSoftware.ID);
			}

			Populate();
		}
		private void DeleteControllerConnection()
		{
			const string OBJECT_NAME = "Controller Connection";
			var doubleNewLine = string.Format("{0}{0}", Environment.NewLine);

			if (_selectedControllerConnection == null)
				return;

			var usedQty = ControllerConnection.GetUsedQty(_selectedControllerConnection.ID);
			if (usedQty > 0)
			{
				var message = $"Cannot remove '{_selectedControllerConnection.Description}' because it is used {usedQty} time(s) in the database.{doubleNewLine}Do you want to merge it with another {OBJECT_NAME}?";
				if (MessageBox.Show(message, $"{OBJECT_NAME} In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				using (var controllerConnectionSelectForm = new FormAsset_ControllerConnection_Select())
				{
					if (controllerConnectionSelectForm.ShowDialog() != DialogResult.OK)
						return;

					if (controllerConnectionSelectForm.ControllerConnection.ID == _selectedControllerConnection.ID)
					{
						MessageBox.Show($"Cannot merge {OBJECT_NAME} with itself.", $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					var question = $"{OBJECT_NAME} '{_selectedControllerConnection.Description}' will be replaced with '{controllerConnectionSelectForm.ControllerConnection.Description}' throughout the database. Do you want to proceed?";
					if (MessageBox.Show(question, $"Confirm {OBJECT_NAME} Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
						return;
					try
					{
						ControllerConnection.Merge(_selectedControllerConnection.ID, controllerConnectionSelectForm.ControllerConnection.ID);
						ControllerConnection.Delete(_selectedControllerConnection.ID);
						MessageBox.Show($"{OBJECT_NAME} merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (MySqlException exc)
					{
						MessageBox.Show($"{OBJECT_NAME} merge failed: " + exc.Message, $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				var question = $"Are you sure you want to remove {OBJECT_NAME} '{_selectedControllerConnection.Description}'?";
				if (MessageBox.Show(question, $"Confirm Remove {OBJECT_NAME}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				ControllerConnection.Delete(_selectedControllerConnection.ID);
			}

			Populate();
		}
        private void DeleteClientConnection()
        {
            const string OBJECT_NAME = "Client Connection";
            var doubleNewLine = string.Format("{0}{0}", Environment.NewLine);

            if (_selectedClientConnection == null)
                return;

            var usedQty = ClassClientConnection.GetUsedQty(_selectedClientConnection.ID);
            if (usedQty > 0)
            {
                var message = $"Cannot remove '{_selectedClientConnection.Description}' because it is used {usedQty} time(s) in the database.{doubleNewLine}Do you want to merge it with another {OBJECT_NAME}?";
                if (MessageBox.Show(message, $"{OBJECT_NAME} In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (var clientConnectionSelectForm = new FormAsset_ClientConnection_Select())
                {
                    if (clientConnectionSelectForm.ShowDialog() != DialogResult.OK)
                        return;

                    if (clientConnectionSelectForm.ClientConnection.ID == _selectedClientConnection.ID)
                    {
                        MessageBox.Show($"Cannot merge {OBJECT_NAME} with itself.", $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var question = $"{OBJECT_NAME} '{_selectedClientConnection.Description}' will be replaced with '{clientConnectionSelectForm.ClientConnection.Description}' throughout the database. Do you want to proceed?";
                    if (MessageBox.Show(question, $"Confirm {OBJECT_NAME} Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassClientConnection.Merge(_selectedClientConnection.ID, clientConnectionSelectForm.ClientConnection.ID);
                        ClassClientConnection.Delete(_selectedClientConnection.ID);
                        MessageBox.Show($"{OBJECT_NAME} merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show($"{OBJECT_NAME} merge failed: " + exc.Message, $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var question = $"Are you sure you want to remove {OBJECT_NAME} '{_selectedClientConnection.Description}'?";
                if (MessageBox.Show(question, $"Confirm Remove {OBJECT_NAME}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassClientConnection.Delete(_selectedClientConnection.ID);
            }

            Populate();
        }

        //NEW
        private void DeletePlayerSoftware()
        {
            const string OBJECT_NAME = "Player Software";
            var doubleNewLine = string.Format("{0}{0}", Environment.NewLine);

            if (_selectedPlayerSoftware == null)
                return;

            var usedQty = ClassPlayerSoftware.GetUsedQty(_selectedPlayerSoftware.ID);
            if (usedQty > 0)
            {
                var message = $"Cannot remove '{_selectedPlayerSoftware.Description}' because it is used {usedQty} time(s) in the database.{doubleNewLine}Do you want to merge it with another {OBJECT_NAME}?";
                if (MessageBox.Show(message, $"{OBJECT_NAME} In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (var playersoftwareSelectForm = new FormPlayerSoftware_Select())
                {
                    if (playersoftwareSelectForm.ShowDialog() != DialogResult.OK)
                        return;

                    if (playersoftwareSelectForm.PlayerSoftware.ID == _selectedPlayerSoftware.ID)
                    {
                        MessageBox.Show($"Cannot merge {OBJECT_NAME} with itself.", $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var question = $"{OBJECT_NAME} '{_selectedPlayerSoftware.Description}' will be replaced with '{playersoftwareSelectForm.PlayerSoftware.Description}' throughout the database. Do you want to proceed?";
                    if (MessageBox.Show(question, $"Confirm {OBJECT_NAME} Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassClientConnection.Merge(_selectedPlayerSoftware.ID, playersoftwareSelectForm.PlayerSoftware.ID);
                        ClassClientConnection.Delete(_selectedPlayerSoftware.ID);
                        MessageBox.Show($"{OBJECT_NAME} merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show($"{OBJECT_NAME} merge failed: " + exc.Message, $"Merge {OBJECT_NAME} Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var question = $"Are you sure you want to remove {OBJECT_NAME} '{_selectedPlayerSoftware.Description}'?";
                if (MessageBox.Show(question, $"Confirm Remove {OBJECT_NAME}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassClientConnection.Delete(_selectedPlayerSoftware.ID);
            }

            Populate();
        }


        private void ShowOutputMethodEditor(bool show)
		{
			foreach (var b in pnlOutputMethods_Control.Controls.OfType<Button>())
				b.Enabled = !show;

			olvOutputMethods.Visible = !show;
			pnlOutputMethod_Editor.Visible = show;

			if (show)
				txtOutputMethod_Description.Select();
		}
		private void ShowCabinetTypeEditor(bool show)
		{
			foreach (var b in pnlCabinetTypes_Control.Controls.OfType<Button>())
				b.Enabled = !show;

			olvCabinetTypes.Visible = !show;
			pnlCabinetType_Editor.Visible = show;

			if (show)
				txtCabinetType_Description.Select();
		}
		private void ShowControllerHwEditor(bool show)
		{
			foreach (var b in pnlControllerHw_Control.Controls.OfType<Button>())
				b.Enabled = !show;

			olvControllerHw.Visible = !show;
			pnlControllerHw_Editor.Visible = show;

			if (show)
				txtControllerHw_Description.Select();
		}
		private void ShowControllerSwEditor(bool show)
		{
			foreach (var b in pnlControllerSw_Control.Controls.OfType<Button>())
				b.Enabled = !show;

			olvControllerSw.Visible = !show;
			pnlControllerSw_Editor.Visible = show;

			if (show)
				txtControllerSw_Description.Select();
		}
		private void ShowControllerConnEditor(bool show)
		{
			foreach (var b in pnlControllerConn_Control.Controls.OfType<Button>())
				b.Enabled = !show;

			olvControllerConn.Visible = !show;
			pnlControllerConn_Editor.Visible = show;

			if (show)
				txtControllerConn_Description.Select();
		}
        private void ShowClientConnEditor(bool show)
        {
            foreach (var b in pnlClientConn_Control.Controls.OfType<Button>())
                b.Enabled = !show;

            olvClientConns.Visible = !show;
            pnlClientConn_Editor.Visible = show;
         
            if (show)
                tbxClientDescription.Select();
        }

        //NEW
        private void ShowPlayerSoftwareEditor(bool show)
        {
            foreach (var b in pnlPlayerSoftware_Control.Controls.OfType<Button>())
                b.Enabled = !show;

            olvPlayerSoftware.Visible = !show;
            pnlPlayerSoftware_Editor.Visible = show;

            if (show)
                tbxPlayerSoftwareDescription.Select();
        }


        private void PopulateOutputMethodEditor(ClassOutputMethod outputMethod)
		{
			txtOutputMethod_Description.Text = outputMethod.Description;
		}
		private void PopulateCabinetTypeEditor(ClassCabinetType cabinetType)
		{
			txtCabinetType_Description.Text = cabinetType.Description;
		}
		private void PopulateControllerHardwareEditor(ControllerHardware controllerHardware)
		{
			txtControllerHw_Description.Text = controllerHardware.Description;
		}
		private void PopulateControllerSoftwareEditor(ControllerSoftware controllerSoftware)
		{
			txtControllerSw_Description.Text = controllerSoftware.Description;
			chkControllerSw_WeaveEnabled.Checked = controllerSoftware.IsWeaveEnabled;
		}
		private void PopulateControllerConnectionEditor(ControllerConnection controllerConnection)
		{
			txtControllerConn_Description.Text = controllerConnection.Description;
		}
        private void PopulateClientConnectionEditor(ClassClientConnection clientConnection)
        {
            tbxClientDescription.Text = clientConnection.Description;
        }

        //NEW
        private void PopulatePlayerSoftwareEditor(ClassPlayerSoftware playerSoftware)
        {
            tbxPlayerSoftwareDescription.Text = playerSoftware.Description;
        }



        private void btnOutputMethod_Editor_Cancel_Click(object sender, EventArgs e)
		{
			ClearOutputMethodEditor();
			ShowOutputMethodEditor(false);
		}
		private void btnCabinetType_Editor_Cancel_Click(object sender, EventArgs e)
		{
			ClearCabinetTypeEditor();
			ShowCabinetTypeEditor(false);
		}
		private void btnControllerHw_Editor_Cancel_Click(object sender, EventArgs e)
		{
			ClearControllerHwEditor();
			ShowControllerHwEditor(false);
		}
		private void btnControllerSw_Editor_Cancel_Click(object sender, EventArgs e)
		{
			ClearControllerSwEditor();
			ShowControllerSwEditor(false);
		}
		private void btnControllerConn_Editor_Cancel_Click(object sender, EventArgs e)
		{
			ClearControllerConnEditor();
			ShowControllerConnEditor(false);
		}
        private void btnClientConn_Editor_Cancel_Click(object sender, EventArgs e)
        {
            ClearClientConnEditor();
            ShowClientConnEditor(false);
        }

        //NEW
        private void btPlayerSoftware_Editor_Cancel_Click(object sender, EventArgs e)
        {
            ClearPlayerSoftwareEditor();
            ShowPlayerSoftwareEditor(false);
        }


        private void btnOutputMethod_Editor_Save_Click(object sender, EventArgs e)
		{
			#region Validation
			if (!ValidateOutputMethodInformation(out var errors))
			{
				MessageBox.Show(errors, "Output Method Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			#endregion

			switch (_outputMethodEditMode)
			{
				case EditAddMode.Add:
					var newOutputMethod = CreateOutputMethodFromEditor();
					try
					{
						ClassOutputMethod.AddNew(ref newOutputMethod);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred adding \"{newOutputMethod.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Output Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case EditAddMode.Edit:
					var modifiedOutputMethod = CreateOutputMethodFromEditor();
					modifiedOutputMethod.ID = _selectedOutputMethod.ID;
					try
					{
						ClassOutputMethod.Update(modifiedOutputMethod);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred updating \"{modifiedOutputMethod.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Output Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			Populate();
			ClearOutputMethodEditor();
			ShowOutputMethodEditor(false);
		}
		private void btnCabinetType_Editor_Save_Click(object sender, EventArgs e)
		{
			#region Validation
			if (!ValidateCabinetTypeInformation(out var errors))
			{
				MessageBox.Show(errors, "Cabinet Type Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			#endregion

			switch (_cabinetTypeEditMode)
			{
				case EditAddMode.Add:
					var newCabinetType = CreateCabinetTypeFromEditor();
					try
					{
						ClassCabinetType.AddNew(ref newCabinetType);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred adding \"{newCabinetType.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Cabinet Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case EditAddMode.Edit:
					var modifiedCabinetType = CreateCabinetTypeFromEditor();
					modifiedCabinetType.ID = _selectedCabinetType.ID;
					try
					{
						ClassCabinetType.Update(modifiedCabinetType);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred updating \"{modifiedCabinetType.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Cabinet Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			Populate();
			ClearCabinetTypeEditor();
			ShowCabinetTypeEditor(false);
		}
		private void btnControllerHw_Editor_Save_Click(object sender, EventArgs e)
		{
			#region Validation
			if (!ValidateControllerHardwareInformation(out var errors))
			{
				MessageBox.Show(errors, "Controller Hardware Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			#endregion

			switch (_controllerHwEditMode)
			{
				case EditAddMode.Add:
					var newControllerHardware = CreateControllerHardwareFromEditor();
					try
					{
						ControllerHardware.AddNew(ref newControllerHardware);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred adding \"{newControllerHardware.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Controller Hardware", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case EditAddMode.Edit:
					var modifiedControllerHardware = CreateControllerHardwareFromEditor();
					modifiedControllerHardware.ID = _selectedControllerHardware.ID;
					try
					{
						ControllerHardware.Update(modifiedControllerHardware);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred updating \"{modifiedControllerHardware.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Controller Hardware", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			Populate();
			ClearControllerHwEditor();
			ShowControllerHwEditor(false);
		}
		private void btnControllerSw_Editor_Save_Click(object sender, EventArgs e)
		{
			#region Validation
			if (!ValidateControllerSoftwareInformation(out var errors))
			{
				MessageBox.Show(errors, "Controller Software Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			#endregion

			switch (_controllerSwEditMode)
			{
				case EditAddMode.Add:
					var newControllerSoftware = CreateControllerSoftwareFromEditor();
					try
					{
						ControllerSoftware.AddNew(ref newControllerSoftware);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred adding \"{newControllerSoftware.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Controller Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case EditAddMode.Edit:
					var modifiedControllerSoftware = CreateControllerSoftwareFromEditor();
					modifiedControllerSoftware.ID = _selectedControllerSoftware.ID;
					try
					{
						ControllerSoftware.Update(modifiedControllerSoftware);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred updating \"{modifiedControllerSoftware.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Controller Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			Populate();
			ClearControllerSwEditor();
			ShowControllerSwEditor(false);
		}
		private void btnControllerConn_Editor_Save_Click(object sender, EventArgs e)
		{
			#region Validation
			if (!ValidateControllerConnectionInformation(out var errors))
			{
				MessageBox.Show(errors, "Controller Connection Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			#endregion

			switch (_controllerConnEditMode)
			{
				case EditAddMode.Add:
					var newControllerConnection = CreateControllerConnectionFromEditor();
					try
					{
						ControllerConnection.AddNew(ref newControllerConnection);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred adding \"{newControllerConnection.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Controller Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;

				case EditAddMode.Edit:
					var modifiedControllerConnection = CreateControllerConnectionFromEditor();
					modifiedControllerConnection.ID = _selectedControllerConnection.ID;
					try
					{
						ControllerConnection.Update(modifiedControllerConnection);
					}
					catch (MySqlException exc)
					{
						ClassLogFile.AppendToLog(exc);
						var errorMessage = $"An error occurred updating \"{modifiedControllerConnection.Description}\": {exc.Message}";
						MessageBox.Show(errorMessage, "Error Saving Controller Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}

			Populate();
			ClearControllerConnEditor();
			ShowControllerConnEditor(false);
		}

        private void btnClientConn_Editor_Save_Click(object sender, EventArgs e)
        {
            #region Validation
            if (!ValidateClientConnectionInformation(out var errors))
            {
                MessageBox.Show(errors, "Client Connection Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            switch (_clientConnEditMode)
            {
                case EditAddMode.Add:
                    var newClientConnection = CreateClientConnectionFromEditor();
                    try
                    {
                        ClassClientConnection.AddNew(ref newClientConnection);
                    }
                    catch (MySqlException exc)
                    {
                        ClassLogFile.AppendToLog(exc);
                        var errorMessage = $"An error occurred adding \"{newClientConnection.Description}\": {exc.Message}";
                        MessageBox.Show(errorMessage, "Error Saving Client Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case EditAddMode.Edit:
                    var modifiedClientConnection = CreateClientConnectionFromEditor();
                    modifiedClientConnection.ID = _selectedClientConnection.ID;
                    try
                    {
                        ClassClientConnection.Update(modifiedClientConnection);
                    }
                    catch (MySqlException exc)
                    {
                        ClassLogFile.AppendToLog(exc);
                        var errorMessage = $"An error occurred updating \"{modifiedClientConnection.Description}\": {exc.Message}";
                        MessageBox.Show(errorMessage, "Error Saving Controller Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            Populate();
            ClearClientConnEditor();
            ShowClientConnEditor(false);
        }

        //NEW 
        private void btnPlayerSoftware_Editor_Save_Click(object sender, EventArgs e)
        {
            #region Validation
            if (!ValidatePlayerSoftwareInformation(out var errors))
            {
                MessageBox.Show(errors, "Player Software Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            switch (_playerSoftwareEditMode)
            {
                case EditAddMode.Add:
                    var newPlayerSoftware = CreatePlayerSoftwareFromEditor();
                    try
                    {
                        ClassPlayerSoftware.AddNew(ref newPlayerSoftware);
                    }
                    catch (MySqlException exc)
                    {
                        ClassLogFile.AppendToLog(exc);
                        var errorMessage = $"An error occurred adding \"{newPlayerSoftware.Description}\": {exc.Message}";
                        MessageBox.Show(errorMessage, "Error Saving Player Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case EditAddMode.Edit:
                    var modifiedPlayerSoftware = CreatePlayerSoftwareFromEditor();
                    modifiedPlayerSoftware.ID = _selectedPlayerSoftware.ID;
                    try
                    {
                        ClassPlayerSoftware.Update(modifiedPlayerSoftware);
                    }
                    catch (MySqlException exc)
                    {
                        ClassLogFile.AppendToLog(exc);
                        var errorMessage = $"An error occurred updating \"{modifiedPlayerSoftware.Description}\": {exc.Message}";
                        MessageBox.Show(errorMessage, "Error Saving Player Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            Populate();
            ClearPlayerSoftwareEditor();
            ShowPlayerSoftwareEditor(false);
        }



        private bool ValidateOutputMethodInformation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtOutputMethod_Description.Text))
				sb.AppendLine("Output Method description cannot be blank.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}
		private bool ValidateCabinetTypeInformation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtCabinetType_Description.Text))
				sb.AppendLine("Cabinet Type description cannot be blank.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}
		private bool ValidateControllerHardwareInformation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtControllerHw_Description.Text))
				sb.AppendLine("Controller Hardware description cannot be blank.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}
		private bool ValidateControllerSoftwareInformation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtControllerSw_Description.Text))
				sb.AppendLine("Controller Software description cannot be blank.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}
		private bool ValidateControllerConnectionInformation(out string errors)
		{
			var sb = new StringBuilder();

			if (string.IsNullOrEmpty(txtControllerConn_Description.Text))
				sb.AppendLine("Controller Connection description cannot be blank.");

			errors = sb.ToString();
			return string.IsNullOrEmpty(errors);
		}
        private bool ValidateClientConnectionInformation(out string errors)
        {
            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(tbxClientDescription.Text))
                sb.AppendLine("Client Connection description cannot be blank.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        //NEW
        private bool ValidatePlayerSoftwareInformation(out string errors)
        {
            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(tbxPlayerSoftwareDescription.Text))
                sb.AppendLine("Software description cannot be blank.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private ClassOutputMethod CreateOutputMethodFromEditor()
		{
			return new ClassOutputMethod
			{
				Description = txtOutputMethod_Description.Text.Trim()
			};
		}
		private ClassCabinetType CreateCabinetTypeFromEditor()
		{
			return new ClassCabinetType
			{
				Description = txtCabinetType_Description.Text.Trim()
			};
		}
		private ControllerHardware CreateControllerHardwareFromEditor()
		{
			return new ControllerHardware
			{
				Description = txtControllerHw_Description.Text.Trim()
			};
		}
		private ControllerSoftware CreateControllerSoftwareFromEditor()
		{
			return new ControllerSoftware
			       {
				       Description = txtControllerSw_Description.Text.Trim(),
					   IsWeaveEnabled = chkControllerSw_WeaveEnabled.Checked
			       };
		}
		private ControllerConnection CreateControllerConnectionFromEditor()
		{
			return new ControllerConnection
			       {
				       Description = txtControllerConn_Description.Text.Trim()
			       };
		}
        private ClassClientConnection CreateClientConnectionFromEditor()
        {
            return new ClassClientConnection
            {
                Description = tbxClientDescription.Text.Trim()
            };
        }

        //NEW
        private ClassPlayerSoftware CreatePlayerSoftwareFromEditor()
        {
            return new ClassPlayerSoftware
            {
                Description = tbxPlayerSoftwareDescription.Text.Trim()
            };
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

        
    }
}