using MySql.Data.MySqlClient;
using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SDB.Classes.Admin;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.RMA;
using SDB.Classes.Shipments;
using SDB.Classes.Ticket;
using SDB.Classes.User;
using SDB.Forms.Assembly;
using SDB.Forms.Asset;
using SDB.Forms.RMA;
using SDB.Forms.Ticket;

namespace SDB.Forms.Admin
{
    public partial class FormAdmin_Config : Form
    {

        #region Main

        private enum EditAddMode
        {
            Edit,
            Add
        };

        public FormAdmin_Config()
        {
            InitializeComponent();

            #region button actions 
            this.btnOutputMethod_Editor_Cancel.Click += new System.EventHandler(this.btnOutputMethod_Editor_Cancel_Click);
            this.btnOutputMethod_Editor_Save.Click += new System.EventHandler(this.btnOutputMethod_Editor_Save_Click);
            this.txtOutputMethod_Description.Enter += new System.EventHandler(this.TextBox_Enter);
            this.olvOutputMethods.SelectionChanged += new System.EventHandler(this.olvOutputMethods_SelectionChanged);
            this.olvOutputMethods.DoubleClick += new System.EventHandler(this.olvOutputMethods_DoubleClick);
            this.btnOutputMethod_Delete.Click += new System.EventHandler(this.btnOutputMethod_Delete_Click);
            this.btnOutputMethod_Edit.Click += new System.EventHandler(this.btnOutputMethod_Edit_Click);
            this.btnOutputMethod_Add.Click += new System.EventHandler(this.btnOutputMethod_Add_Click);
            this.txtCabinetType_Description.Enter += new System.EventHandler(this.TextBox_Enter);
            this.btnCabinetType_Editor_Cancel.Click += new System.EventHandler(this.btnCabinetType_Editor_Cancel_Click);
            this.btnCabinetType_Editor_Save.Click += new System.EventHandler(this.btnCabinetType_Editor_Save_Click);
            this.olvCabinetTypes.SelectedIndexChanged += new System.EventHandler(this.olvCabinetTypes_SelectedIndexChanged);
            this.olvCabinetTypes.DoubleClick += new System.EventHandler(this.olvCabinetTypes_DoubleClick);
            this.btnCabinetType_Delete.Click += new System.EventHandler(this.btnCabinetType_Delete_Click);
            this.btnCabinetType_Edit.Click += new System.EventHandler(this.btnCabinetType_Edit_Click);
            this.btnCabinetType_Add.Click += new System.EventHandler(this.btnCabinetType_Add_Click);
            this.olvAssemblies.SelectedIndexChanged += new System.EventHandler(this.olvAssemblies_SelectedIndexChanged);
            this.olvAssemblies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvAssemblies_MouseDoubleClick);
            this.btnAssembly_Edit.Click += new System.EventHandler(this.btnAssembly_Edit_Click);
            this.btnAssembly_EnableDisable.Click += new System.EventHandler(this.btnAssembly_EnableDisable_Click);
            this.btnAssembly_Delete.Click += new System.EventHandler(this.btnAssembly_Delete_Click);
            this.btnAssembly_Add.Click += new System.EventHandler(this.btnAssembly_Add_Click);
            this.olvTypes.SelectedIndexChanged += new System.EventHandler(this.olvTypes_SelectedIndexChanged);
            this.olvTypes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTypes_MouseDoubleClick);
            this.btnType_Edit.Click += new System.EventHandler(this.btnTypes_Edit_Click);
            this.btnType_Delete.Click += new System.EventHandler(this.btnTypes_Delete_Click);
            this.btnType_Add.Click += new System.EventHandler(this.btnTypes_Add_Click);
            this.olvCategories.SelectedIndexChanged += new System.EventHandler(this.olvCategories_SelectedIndexChanged);
            this.olvCategories.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvCategories_MouseDoubleClick);
            this.btnCategory_Edit.Click += new System.EventHandler(this.btnCategory_Edit_Click);
            this.btnCategory_Delete.Click += new System.EventHandler(this.btnCategory_Delete_Click);
            this.btnCategory_Add.Click += new System.EventHandler(this.btnCategory_Add_Click);
            this.btnAssetTag_Edit.Click += new System.EventHandler(this.btnAssetTag_Edit_Click);
            this.btnCameraType_Remove.Click += new System.EventHandler(this.btnCameraType_Remove_Click);
            this.btnCameraType_Add.Click += new System.EventHandler(this.btnCameraType_Add_Click);
            this.btnRentalDivision_Delete.Click += new System.EventHandler(this.btnRentalDivision_Delete_Click);
            this.btnRentalDivision_Add.Click += new System.EventHandler(this.btnRentalDivision_Add_Click);
            this.btnRentalCompany_Editor_Cancel.Click += new System.EventHandler(this.btnRentalCompany_Editor_Cancel_Click);
            this.btnRentalCompany_Editor_Save.Click += new System.EventHandler(this.btnRentalCompany_Editor_Save_Click);
            this.chkUse_PickupNumber.CheckedChanged += new System.EventHandler(this.chkUse_PickupNumber_CheckedChanged);
            this.chkUse_ReservationNumber.CheckedChanged += new System.EventHandler(this.chkUse_ReservationNumber_CheckedChanged);
            this.txtFormat_PickupNumber.TextChanged += new System.EventHandler(this.txtFormat_PickupNumber_TextChanged);
            this.txtFormat_PickupNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtFormat_ReservationNumber.TextChanged += new System.EventHandler(this.txtFormat_ReservationNumber_TextChanged);
            this.txtFormat_ReservationNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtFormat_EquipmentNumber.TextChanged += new System.EventHandler(this.txtFormat_EquipmentNumber_TextChanged);
            this.txtFormat_EquipmentNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            this.chkUse_EquipmentNumber.CheckedChanged += new System.EventHandler(this.chkUse_EquipmentNumber_CheckedChanged);
            this.txtAccountNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtRentalCompany_Name.Enter += new System.EventHandler(this.TextBox_Enter);
            this.olvRentalCompanies.SelectionChanged += new System.EventHandler(this.olvRentalCompanies_SelectionChanged);
            this.olvRentalCompanies.DoubleClick += new System.EventHandler(this.olvRentalCompanies_DoubleClick);
            this.btnRentalCompany_Delete.Click += new System.EventHandler(this.btnRentalCompany_Delete_Click);
            this.btnRentalCompany_Edit.Click += new System.EventHandler(this.btnRentalCompany_Edit_Click);
            this.btnRentalCompany_Add.Click += new System.EventHandler(this.btnRentalCompany_Add_Click);
            this.txtLiftType_Description.Enter += new System.EventHandler(this.TextBox_Enter);
            this.btnLiftType_Editor_Cancel.Click += new System.EventHandler(this.btnLiftType_Editor_Cancel_Click);
            this.btnLiftType_Editor_Save.Click += new System.EventHandler(this.btnLiftType_Editor_Save_Click);
            this.olvLiftTypes.SelectedIndexChanged += new System.EventHandler(this.olvLiftTypes_SelectedIndexChanged);
            this.olvLiftTypes.DoubleClick += new System.EventHandler(this.olvLiftTypes_DoubleClick);
            this.btnLiftType_Delete.Click += new System.EventHandler(this.btnLiftType_Delete_Click);
            this.btnLiftType_Edit.Click += new System.EventHandler(this.btnLiftType_Edit_Click);
            this.btnLiftType_Add.Click += new System.EventHandler(this.btnLiftType_Add_Click);

            #endregion

            olvCabinetTypes.PrimarySortColumn = olcCabinetType_Description;
            olvCabinetTypes.PrimarySortOrder = SortOrder.Ascending;

            olvOutputMethods.PrimarySortColumn = olcOutputMethodDescription;
            olvOutputMethods.PrimarySortOrder = SortOrder.Ascending;

            olvTypes.PrimarySortColumn = olcType_Description;
            olvTypes.PrimarySortOrder = SortOrder.Ascending;

            olvAssemblies.FormatRow += olvAssemblies_FormatRow;
            olvAssemblies.PrimarySortColumn = olvColAssembly_Description;
            olvAssemblies.PrimarySortOrder = SortOrder.Ascending;

            olcType_IsComputer.AspectGetter = x => ((ClassAssemblyType)x).IsComputer;
            olcType_IsComputer.AspectToStringConverter = x => string.Empty;
            olcType_IsComputer.ImageGetter = x => ((ClassAssemblyType)x).IsComputer ? "computer" : "none";

            olcType_AllowDiscard.AspectGetter = x => ((ClassAssemblyType)x).AllowDiscard;
            olcType_AllowDiscard.AspectToStringConverter = x => string.Empty;
            olcType_AllowDiscard.ImageGetter = x => ((ClassAssemblyType)x).AllowDiscard ? "trash" : "none";

            olvRentalCompanies.PrimarySortColumn = olcRentalCompany;
            olvRentalCompanies.PrimarySortOrder = SortOrder.Ascending;

            olvRentalDivisions.PrimarySortColumn = olcDivisionName;
            olvRentalDivisions.PrimarySortOrder = SortOrder.Ascending;

            olvComponents.FormatRow += olvComponents_FormatRow;

            olcDefault.AspectToStringConverter = delegate (object x)
            {
                var isDefault = (bool)x;
                return isDefault ? "True" : string.Empty;
            };


        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.SelectAll();
        }

        private void Populate()
        {
            _selectedOutputMethod = null;
            _outputMethods = ClassOutputMethod.GetAll().ToList();
            olvOutputMethods.SetObjects(_outputMethods);

            _selectedCabinetType = null;
            _cabinetTypes = ClassCabinetType.GetAll().ToList();
            olvCabinetTypes.SetObjects(_cabinetTypes);
        }

        #endregion

        #region Output Methods

        private EditAddMode _outputMethodEditMode;
        private ClassOutputMethod _selectedOutputMethod;
        private List<ClassOutputMethod> _outputMethods = new List<ClassOutputMethod>();

        private void olvOutputMethods_SelectionChanged(object sender, EventArgs e)
        {
            ShowOutputMethodEditor(false);
            _selectedOutputMethod = (ClassOutputMethod)olvOutputMethods.SelectedObject;
        }

        private void olvOutputMethods_DoubleClick(object sender, EventArgs e)
        {
            EditOutputMethod();
        }

        private void btnOutputMethod_Add_Click(object sender, EventArgs e)
        {
            AddOutputMethod();
        }

        private void btnOutputMethod_Delete_Click(object sender, EventArgs e)
        {
            DeleteOutputMethod();
        }

        private void btnOutputMethod_Edit_Click(object sender, EventArgs e)
        {
            EditOutputMethod();
        }

        private void AddOutputMethod()
        {
            _outputMethodEditMode = EditAddMode.Add;
            ClearOutputMethodEditor();
            ShowOutputMethodEditor(true);
        }

        private void ClearOutputMethodEditor()
        {
            foreach (var tb in pnlOutputMethod_Editor.Controls.OfType<TextBox>())
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

        private void DeleteOutputMethod()
        {
            if (_selectedOutputMethod == null)
                return;

            int usedQty = ClassOutputMethod.GetUsedQty(_selectedOutputMethod.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Output Method?", _selectedOutputMethod.Description, usedQty, Environment.NewLine),
                                    "Output Method In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                using (FormAsset_OutputMethod_Select frmOutputMethod = new FormAsset_OutputMethod_Select())
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

        private void ShowOutputMethodEditor(bool show)
        {
            foreach (var b in pnlOutputMethods_Control.Controls.OfType<Button>())
                b.Enabled = !show;

            olvOutputMethods.Visible = !show;
            pnlOutputMethod_Editor.Visible = show;

            if (show)
                txtOutputMethod_Description.Select();
        }

        private void PopulateOutputMethodEditor(ClassOutputMethod outputMethod)
        {
            txtOutputMethod_Description.Text = outputMethod.Description;
        }

        private void btnOutputMethod_Editor_Cancel_Click(object sender, EventArgs e)
        {
            ClearOutputMethodEditor();
            ShowOutputMethodEditor(false);
        }

        private void btnOutputMethod_Editor_Save_Click(object sender, EventArgs e)
        {
            #region Validation
            string errors;
            if (!ValidateOutputMethodInformation(out errors))
            {
                MessageBox.Show(errors, "Output Method Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            switch (_outputMethodEditMode)
            {
                case EditAddMode.Add:
                    ClassOutputMethod newOutputMethod = CreateOutputMethodFromEditor();
                    try
                    {
                        ClassOutputMethod.AddNew(ref newOutputMethod);
                    }
                    catch (MySqlException exc)
                    {
                        ClassLogFile.AppendToLog(exc);
                        string errorMessage = string.Format("An error occurred adding \"{0}\": {1}", newOutputMethod.Description, exc.Message);
                        MessageBox.Show(errorMessage, "Error Saving Output Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case EditAddMode.Edit:
                    ClassOutputMethod modifiedOutputMethod = CreateOutputMethodFromEditor();
                    modifiedOutputMethod.ID = _selectedOutputMethod.ID;
                    try
                    {
                        ClassOutputMethod.Update(modifiedOutputMethod);
                    }
                    catch (MySqlException exc)
                    {
                        ClassLogFile.AppendToLog(exc);
                        string errorMessage = string.Format("An error occurred updating \"{0}\": {1}", modifiedOutputMethod.Description, exc.Message);
                        MessageBox.Show(errorMessage, "Error Saving Output Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            Populate();
            ClearOutputMethodEditor();
            ShowOutputMethodEditor(false);
        }

        /// <summary>
        /// Validates data on the output method editor and returns true if valid.
        /// If not, errors are contained in the string <paramref name=">errors"/>.
        /// </summary>
        private bool ValidateOutputMethodInformation(out string errors)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(txtOutputMethod_Description.Text))
                sb.AppendLine("Output Method description cannot be blank.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private ClassOutputMethod CreateOutputMethodFromEditor()
        {
            ClassOutputMethod newOutputMethod = new ClassOutputMethod();

            newOutputMethod.Description = txtOutputMethod_Description.Text.Trim();

            return newOutputMethod;
        }

        #endregion

        #region Cabinet Types

        private EditAddMode _cabinetTypeEditMode;
        private ClassCabinetType _selectedCabinetType;
        private List<ClassCabinetType> _cabinetTypes = new List<ClassCabinetType>();

        private void btnCabinetType_Add_Click(object sender, EventArgs e)
        {
            AddCabinetType();
        }

        private void olvCabinetTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCabinetTypeEditor(false);
            _selectedCabinetType = (ClassCabinetType)olvCabinetTypes.SelectedObject;
        }

        /// <summary>
        /// Validates data on the cabinet type editor and returns true if valid.
        /// If not, errors are contained in the string <paramref name=">errors"/>.
        /// </summary>
        private bool ValidateCabinetTypeInformation(out string errors)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(txtCabinetType_Description.Text))
                sb.AppendLine("Cabinet Type description cannot be blank.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private ClassCabinetType CreateCabinetTypeFromEditor()
        {
            ClassCabinetType newCabinetType = new ClassCabinetType();

            newCabinetType.Description = txtCabinetType_Description.Text.Trim();

            return newCabinetType;
        }

        private void btnCabinetType_Editor_Save_Click(object sender, EventArgs e)
        {

        }

        private void btnCabinetType_Editor_Cancel_Click(object sender, EventArgs e)
        {
            ClearCabinetTypeEditor();
            ShowCabinetTypeEditor(false);
        }

        private void PopulateCabinetTypeEditor(ClassCabinetType cabinetType)
        {
            txtCabinetType_Description.Text = cabinetType.Description;
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

        private void DeleteCabinetType()
        {
            if (_selectedCabinetType == null)
                return;

            int usedQty = ClassCabinetType.GetUsedQty(_selectedCabinetType.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Cabinet Type?", _selectedCabinetType.Description, usedQty, Environment.NewLine),
                                    "Cabinet Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                using (FormAsset_CabinetType_Select frmCabinetType = new FormAsset_CabinetType_Select())
                {
                    if (frmCabinetType.ShowDialog() != DialogResult.OK)
                        return;

                    if (frmCabinetType.CabinetType.ID == _selectedCabinetType.ID)
                    {
                        MessageBox.Show("Cannot merge Cabinet Type with itself.", "Merge Cabinet Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show(string.Format("Cabinet Type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedCabinetType.Description, frmCabinetType.CabinetType.Description),
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
                if (MessageBox.Show(string.Format("Are you sure you want to remove Cabinet Type '{0}'?", _selectedCabinetType.Description),
                                    "Confirm Remove Cabinet Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassCabinetType.Delete(_selectedCabinetType.ID);
            }

            Populate();
        }

        private void EditCabinetType()
        {
            if (_selectedCabinetType == null)
                return;

            ClearCabinetTypeEditor();
            PopulateCabinetTypeEditor(_selectedCabinetType);
            ShowCabinetTypeEditor(true);
        }

        private void btnCabinetType_Edit_Click(object sender, EventArgs e)
        {
            EditCabinetType();
        }

        private void btnCabinetType_Delete_Click(object sender, EventArgs e)
        {
            DeleteCabinetType();
        }

        private void olvCabinetTypes_DoubleClick(object sender, EventArgs e)
        {
            EditCabinetType();
        }

        private void AddCabinetType()
        {
            _cabinetTypeEditMode = EditAddMode.Add;
            ClearCabinetTypeEditor();
            ShowCabinetTypeEditor(true);
        }

        private void ClearCabinetTypeEditor()
        {
            foreach (var tb in pnlCabinetType_Editor.Controls.OfType<TextBox>())
                tb.Clear();
        }


        #endregion

        #region Assembly
        private List<ClassAssemblyCategory> _categories = new List<ClassAssemblyCategory>();
        private ClassAssemblyCategory _selectedCategory;
        private List<ClassAssemblyType> _types = new List<ClassAssemblyType>();
        private ClassAssemblyType _selectedType;
        private List<ClassAssembly> _assemblies = new List<ClassAssembly>();
        private ClassAssembly _selectedAssembly;

        private void FormPartsManagement_Load(object sender, EventArgs e)
        {
            Populate_Categories();
        }

        private void Populate_Categories()
        {
            _categories = ClassAssemblyCategory.GetAll().ToList();

            olvCategories.SetObjects(_categories);
            txtCategory_Qty.Text = _categories.Count.ToString(CultureInfo.InvariantCulture);

            Populate_Types();
        }

        private void olvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCategory = (ClassAssemblyCategory)olvCategories.SelectedObject;
            _selectedType = null;
            _selectedAssembly = null;
            Populate_Types();
        }

        private void btnCategory_Add_Click(object sender, EventArgs e)
        {
            using (var categoryEditor = new FormAdmin_AssemblyCategory_AddEdit(false))
            {
                if (categoryEditor.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Categories();
            }
        }

        private void btnCategory_Edit_Click(object sender, EventArgs e)
        {
            Category_Edit();
        }

        private void btnCategory_Delete_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null)
                return;

            var usedQty = ClassAssemblyCategory.GetUsedQty(_selectedCategory.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Assembly Category?", _selectedCategory.Description, usedQty, Environment.NewLine),
        "Assembly Category In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                using (var categorySelector = new FormAssemblyCategory_Select())
                {
                    categorySelector.SetInfoLabel("Select an assembly category:");
                    if (categorySelector.ShowDialog() != DialogResult.OK)
                        return;
                    if (categorySelector.AssemblyCategory.ID == _selectedCategory.ID)
                    {
                        MessageBox.Show("Cannot merge Assembly Category with itself.", "Merge Assembly Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show(string.Format("Assembly Category '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedCategory.Description, categorySelector.AssemblyCategory.Description),
                        "Confirm Assembly Category Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassAssemblyCategory.Merge(_selectedCategory.ID, categorySelector.AssemblyCategory.ID);
                        ClassAssemblyCategory.Delete(_selectedCategory);
                        MessageBox.Show("Assembly Category merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Assembly Category merge failed: " + exc.Message, "Merge Assembly Category Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove Assembly Category '{0}'?", _selectedCategory.Description),
        "Confirm Remove Assembly Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassAssemblyCategory.Delete(_selectedCategory);
                //MessageBox.Show("Assembly Category remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Populate_Categories();
        }

        private void olvCategories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Category_Edit();
        }

        private void Category_Edit()
        {
            if (_selectedCategory == null)
                return;

            var selectedIndex = olvCategories.IndexOf(olvCategories.SelectedObject);

            using (var categoryEditor = new FormAdmin_AssemblyCategory_AddEdit(true, _selectedCategory.ID))
            {
                if (categoryEditor.ShowDialog() != DialogResult.OK)
                    return;

                Populate_Categories();
            }

            // Select and show last-edited item if possible
            try
            {
                olvCategories.Select();
                olvCategories.TopItemIndex = selectedIndex;
                olvCategories.SelectedIndex = selectedIndex;
            }
            catch
            {
            }
        }

        private void Populate_Types()
        {
            _types = _selectedCategory == null ? null : ClassAssemblyType.GetByCategory(_selectedCategory).ToList();

            olvTypes.EmptyListMsg = _selectedCategory == null ? "No category selected." : "No types in this category.";
            txtTypes_OfCategory.Text = _selectedCategory == null ? "(None Selected)" : _selectedCategory.Description;

            olvTypes.SetObjects(_types);
            txtType_Qty.Text = _types == null ? "0" : _types.Count.ToString(CultureInfo.InvariantCulture);

            Populate_Assemblies();
        }

        private void olvTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedType = (ClassAssemblyType)olvTypes.SelectedObject;
            _selectedAssembly = null;
            Populate_Assemblies();
        }

        private void btnTypes_Add_Click(object sender, EventArgs e)
        {
            using (var fata = new FormAdmin_AssemblyType_AddEdit(_selectedCategory, false))
            {
                if (fata.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Types();
            }
        }

        private void btnTypes_Edit_Click(object sender, EventArgs e)
        {
            Type_Edit();
        }

        private void btnTypes_Delete_Click(object sender, EventArgs e)
        {
            if (_selectedType == null)
                return;

            var usedQty = ClassAssemblyType.GetUsedQty(_selectedType.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Assembly Type?", _selectedType.Description, usedQty, Environment.NewLine),
                    "Assembly Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                using (var fats = new FormAssemblyType_Select())
                {
                    fats.ShowQuantity(false);
                    fats.SetInfoLabel("Select an assembly type:");
                    if (fats.ShowDialog() != DialogResult.OK)
                        return;
                    if (fats.AssemblyType.ID == _selectedType.ID)
                    {
                        MessageBox.Show("Cannot merge Assembly Type with itself.", "Merge Assembly Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show(string.Format("Assembly Type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedType.Description, fats.AssemblyType.Description),
                        "Confirm Assembly Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassAssemblyType.Merge(_selectedType.ID, fats.AssemblyType.ID);
                        ClassAssemblyType.Delete(_selectedType);
                        MessageBox.Show("Assembly Type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Assembly Type merge failed: " + exc.Message, "Merge Assembly Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove Assembly Type '{0}'?", _selectedType.Description),
                    "Confirm Remove Assembly Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassAssemblyType.Delete(_selectedType);
                //MessageBox.Show("Assembly Type remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Populate_Types();
        }

        private void olvTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Type_Edit();
        }

        private void Type_Edit()
        {
            if (_selectedType == null)
                return;

            var selectedIndex = olvTypes.IndexOf(olvTypes.SelectedObject);

            using (var fata = new FormAdmin_AssemblyType_AddEdit(_selectedCategory, true, _selectedType.ID))
            {
                if (fata.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Types();
            }

            // Select and show last-edited item if possible
            try
            {
                olvTypes.Select();
                olvTypes.TopItemIndex = selectedIndex;
                olvTypes.SelectedIndex = selectedIndex;
            }
            catch
            {
            }
        }

        private void olvAssemblies_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            var assembly = (ClassAssembly)e.Model;
            if (assembly.Disabled)
                e.Item.ForeColor = Color.LightGray;
        }

        private void Populate_Assemblies()
        {
            _assemblies = _selectedType == null ? null : ClassAssembly.GetByType(_selectedType).ToList();

            olvAssemblies.EmptyListMsg = _selectedType == null ? "No type selected." : "No assemblies of this type.";
            txtAssemblies_OfType.Text = _selectedType == null ? "(None Selected)" : _selectedType.Description;

            olvAssemblies.SetObjects(_assemblies);
            txtAssembly_Qty.Text = _assemblies == null ? "0" : _assemblies.Count.ToString(CultureInfo.InvariantCulture);
        }

        private void olvAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedAssembly();
        }

        private void RefreshSelectedAssembly()
        {
            _selectedAssembly = (ClassAssembly)olvAssemblies.SelectedObject;
            if (_selectedAssembly == null)
                return;
            btnAssembly_EnableDisable.Text = _selectedAssembly.Disabled ? "Enable Assembly" : "Disable Assembly";
        }

        private void btnAssembly_Add_Click(object sender, EventArgs e)
        {
            using (var faa = new FormAdmin_Assembly_AddEdit(false))
            {
                if (faa.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Assemblies();
            }
        }

        private void btnAssembly_Edit_Click(object sender, EventArgs e)
        {
            Assembly_Edit();
        }

        private void olvAssemblies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Assembly_Edit();
        }

        private void Assembly_Edit()
        {
            if (_selectedAssembly == null)
                return;

            var selectedIndex = olvAssemblies.IndexOf(olvAssemblies.SelectedObject);

            using (var faa = new FormAdmin_Assembly_AddEdit(true, _selectedAssembly.ID))
            {
                if (faa.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Assemblies();
            }

            // Select and show last-edited item if possible
            try
            {
                olvAssemblies.Select();
                olvAssemblies.TopItemIndex = selectedIndex;
                olvAssemblies.SelectedIndex = selectedIndex;
            }
            catch
            {
            }
        }

        private void btnAssembly_Delete_Click(object sender, EventArgs e)
        {
            if (_selectedAssembly == null)
                return;

            var usedQty = ClassAssembly.GetUsedQty(_selectedAssembly.ID);
            if (usedQty > 0)
            {
                var message = string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another assembly?", _selectedAssembly.Description, usedQty, Environment.NewLine);
                if (MessageBox.Show(message, "Assembly In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (var fas = new FormAdmin_Assembly_Select(true))
                {
                    if (fas.ShowDialog() != DialogResult.OK)
                        return;
                    if (fas.Assembly.ID == _selectedAssembly.ID)
                    {
                        MessageBox.Show("Cannot merge assembly with itself.", "Merge Assembly Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var confirmation = string.Format("Assembly '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedAssembly.Description, fas.Assembly.Description);
                    if (MessageBox.Show(confirmation, "Confirm Assembly Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassAssembly.Merge(_selectedAssembly, fas.Assembly);
                        ClassAssembly.Delete(_selectedAssembly);
                        MessageBox.Show("Assembly merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Assembly merge failed: " + exc.Message, "Merge Assembly Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove assembly '{0}'?", _selectedAssembly.Description),
                    "Confirm Remove Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassAssembly.Delete(_selectedAssembly);
                //MessageBox.Show("Assembly remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _selectedAssembly = null;
            Populate_Assemblies();
        }

        private void btnAssembly_EnableDisable_Click(object sender, EventArgs e)
        {
            if (_selectedAssembly == null)
                return;

            var disabledReminder = false;
            var tempAssy = new ClassAssembly();
            if (!_selectedAssembly.Disabled)
            {
                if (MessageBox.Show("Are you sure you want to disable the selected assembly?", "Confirm Assembly Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                ClassAssembly.Disable(_selectedAssembly, true);
                disabledReminder = true;
                tempAssy = _selectedAssembly;
            }
            else
                ClassAssembly.Disable(_selectedAssembly, false);

            Populate_Assemblies();
            RefreshSelectedAssembly();

            if (disabledReminder && MessageBox.Show("Do you want to specify a replacement assembly?", "Replacement Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _selectedAssembly = tempAssy;
                Assembly_Edit();
            }
        }

        #endregion

        #region Camera Types

        private List<ClassCameraType> _cameraTypes = new List<ClassCameraType>();
        private ClassCameraType _selectedCameraType;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Populate_CameraTypes()
        {
            _cameraTypes = ClassCameraType.GetCameraTypes().ToList();
            olvCameraTypes.SetObjects(_cameraTypes);
        }

        private void olvCameraTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCameraType = (ClassCameraType)olvCameraTypes.SelectedObject;
        }

        private void btnCameraType_Add_Click(object sender, EventArgs e)
        {
            using (FormAdmin_CameraType_AddEdit frmCamTypeAddEdit = new FormAdmin_CameraType_AddEdit(false))
            {
                if (frmCamTypeAddEdit.ShowDialog() != DialogResult.OK)
                    return;

                Populate_CameraTypes();
            }
        }

        private void btnCameraType_Edit_Click(object sender, EventArgs e)
        {
            CameraType_Edit();
        }

        private void olvCameraTypes_DoubleClick(object sender, EventArgs e)
        {
            CameraType_Edit();
        }

        private void CameraType_Edit()
        {
            if (_selectedCameraType == null)
                return;

            using (FormAdmin_CameraType_AddEdit frmCamTypeAddEdit = new FormAdmin_CameraType_AddEdit(true, _selectedCameraType.ID))
            {
                if (frmCamTypeAddEdit.ShowDialog() != DialogResult.OK)
                    return;

                Populate_CameraTypes();
            }
        }

        private void btnCameraType_Remove_Click(object sender, EventArgs e)
        {
            if (_selectedCameraType == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete the selected camera type?", "Confirm Camera Type Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            // Check if the camera type is used for any asset
            int cameraTypeUsedQty = ClassCameraType.GetUsedQty(_selectedCameraType.ID);
            if (cameraTypeUsedQty > 0)
            {
                MessageBox.Show(string.Format("This camera type is used {0} time{1} in the database. It cannot be deleted.", cameraTypeUsedQty, cameraTypeUsedQty == 1 ? string.Empty : "s"), "Camera Type In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ClassCameraType.Delete(_selectedCameraType.ID);
            Populate_CameraTypes();
        }

        #endregion

        #region Asset Tags
        private List<ClassCustomerAssetTag> _tags = new List<ClassCustomerAssetTag>();
        private FormAdmin_AssetTags_New _formNewAddTag;

        private void Populate_AssetTags()
        {
            _tags = ClassCustomerAssetTag.GetAll().ToList();
            olvTags.SetObjects(_tags);
        }

        private void btnAssetTag_Add_Click(object sender, EventArgs e)
        {
            _formNewAddTag = new FormAdmin_AssetTags_New();
            var result = _formNewAddTag.ShowDialog();
            if (result == DialogResult.OK)
            {
                ClassCustomerAssetTag newTag = new ClassCustomerAssetTag();
                newTag.Tag = _formNewAddTag.AssetTag;
                newTag.Description = _formNewAddTag.Description;
                ClassCustomerAssetTag.AddNew(ref newTag);
                Populate_AssetTags();
            }
        }

        private void btnAssetTag_Remove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this tag?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ClassCustomerAssetTag.Delete(((ClassCustomerAssetTag)(olvTags.SelectedObject)).Id);
                Populate_AssetTags();
            }
        }

        private void btnAssetTag_Edit_Click(object sender, EventArgs e)
        {
            var obj = (ClassCustomerAssetTag)olvTags.SelectedObject;
            _formNewAddTag = new FormAdmin_AssetTags_New(obj.Tag, obj.Description);
            var result = _formNewAddTag.ShowDialog();
            if (result == DialogResult.OK)
            {
                obj.Tag = _formNewAddTag.AssetTag;
                obj.Description = _formNewAddTag.Description;
                ClassCustomerAssetTag.Update(obj);
                Populate_AssetTags();
            }
        }
        #endregion

        #region Rental

        private EditAddMode _rentalCompanyEditMode;
        private EditAddMode _liftTypeEditMode;
        private ClassRentalCompany _selectedRentalCompany;
        private List<ClassRentalCompany> _rentalCompanies = new List<ClassRentalCompany>();
        private ClassLiftType _selectedLiftType;
        private List<ClassLiftType> _liftTypes = new List<ClassLiftType>();
        private bool _ignoreStateChange;
        private readonly Color _numberFormatBgColorValid = SystemColors.Window;
        private readonly Color _numberFormatBgColorInvalid = Color.FromArgb(255, 192, 192);

        private void PopulateRental()
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

            PopulateRental();
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

            PopulateRental();
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

            if (olvRentalDivisions.Objects != null)
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
            var newDivision = new ClassRentalDivision { Name = "New Division" };
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
        #endregion

        #region Sales People

        private List<ClassSalesperson> _salespeople = new List<ClassSalesperson>();
        private ClassSalesperson _selectedSalesperson;

        private void Populate_Salespeople()
        {
            _salespeople = ClassSalesperson.GetSalespeople().ToList();
            olvSalespeople.SetObjects(_salespeople);
        }

        private void olvSalespeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSalesperson = (ClassSalesperson)olvSalespeople.SelectedObject;
        }

        private void btnSalesperson_Add_Click(object sender, EventArgs e)
        {
            using (FormAdmin_Salespeople_AddEdit frmSalespeopleAddEdit = new FormAdmin_Salespeople_AddEdit(false))
            {
                if (frmSalespeopleAddEdit.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Salespeople();
            }
        }

        private void btnSalesperson_Edit_Click(object sender, EventArgs e)
        {
            Salesperson_Edit();
        }

        private void olvSalespeople_DoubleClick(object sender, EventArgs e)
        {
            Salesperson_Edit();
        }

        private void Salesperson_Edit()
        {
            if (_selectedSalesperson == null)
                return;
            using (FormAdmin_Salespeople_AddEdit frmSalespersonAddEdit = new FormAdmin_Salespeople_AddEdit(true, _selectedSalesperson.ID))
            {
                if (frmSalespersonAddEdit.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Salespeople();
            }
        }

        private void btnSalesperson_Remove_Click(object sender, EventArgs e)
        {
            if (_selectedSalesperson == null) return;
            if (MessageBox.Show("Are you sure you want to delete the selected salesperson?", "Confirm Salesperson Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            // Check if the camera type is used for any asset
            int salespersonUsedQty = ClassSalesperson.GetUsedQty(_selectedSalesperson.ID);
            if (salespersonUsedQty > 0)
            {
                MessageBox.Show(string.Format("This salesperson is used {0} time{1} in the database. It cannot be deleted.", salespersonUsedQty, salespersonUsedQty == 1 ? string.Empty : "s"), "Salesperson In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ClassSalesperson.Delete(_selectedSalesperson);
            Populate_Salespeople();
        }

        #endregion

        #region Shipping Methods

        private List<ClassShipment_Method> _shipmentMethods = new List<ClassShipment_Method>();
        private ClassShipment_Method _selectedShipmentMethod;

        private void Populate_ShipmentMethods()
        {
            _shipmentMethods = ClassShipment_Method.GetAll().ToList();
            olvShipmentMethods.SetObjects(_shipmentMethods);
        }

        private void olvShipmentMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedShipmentMethod = (ClassShipment_Method)olvShipmentMethods.SelectedObject;
        }

        private void olvShipmentMethods_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            var sm = (ClassShipment_Method)e.Model;
            if (!sm.Default)
                return;
            e.Item.BackColor = Color.PaleGreen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAdmin_ShipmentMethod_AddEdit frmShipmentMethodAddEdit = new FormAdmin_ShipmentMethod_AddEdit(false))
            {
                if (frmShipmentMethodAddEdit.ShowDialog(this) != DialogResult.OK)
                    return;

                Populate_ShipmentMethods();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShipmentMethod_Edit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_selectedShipmentMethod == null)
                return;

            int usedQty = ClassShipment_Method.GetUsedQty(_selectedShipmentMethod.ID);
            if (usedQty == 0)
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove \"{0}\"?", _selectedShipmentMethod.Description), "Confirm Remove Shipment Method", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                ClassShipment_Method.Delete(_selectedShipmentMethod.ID);
                Populate_ShipmentMethods();
                return;
            }
            MessageBox.Show(string.Format("\"{0}\" is used {1} time{2} in the database. You cannot remove it.", _selectedShipmentMethod.Description, usedQty, usedQty == 1 ? string.Empty : "s"), "Cannot Remove Shipment Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void olvShipmentMethods_DoubleClick(object sender, EventArgs e)
        {
            ShipmentMethod_Edit();
        }

        private void ShipmentMethod_Edit()
        {
            if (_selectedShipmentMethod == null)
                return;

            using (FormAdmin_ShipmentMethod_AddEdit frmAdminEmailAddEdit = new FormAdmin_ShipmentMethod_AddEdit(true, _selectedShipmentMethod.ID))
            {
                if (frmAdminEmailAddEdit.ShowDialog() != DialogResult.OK)
                    return;

                Populate_ShipmentMethods();
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (_selectedShipmentMethod == null)
                return;

            ClassShipment_Method.SetDefault(_selectedShipmentMethod.ID);
            Populate_ShipmentMethods();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (_selectedShipmentMethod == null)
                return;

            ClassShipment_Method.MoveUp(_selectedShipmentMethod.ID);
            Populate_ShipmentMethods();
        }

        #endregion

        #region Symptoms Solutions

        private List<ClassTicket_Symptom> _symptoms;
        private List<ClassTicket_Solution> _solutions;

        private void PopulateSymptomsSolutions()
        {
            _symptoms = ClassTicket_Symptom.GetAll().ToList();
            _solutions = ClassTicket_Solution.GetAll().ToList();

            olvSymptoms.SetObjects(_symptoms);
            olvSolutions.SetObjects(_solutions);
        }

        private void btnSymptoms_Add_Click(object sender, EventArgs e)
        {
            using (var symptomEditForm = new FormAdmin_Symptom_AddEdit())
            {
                if (symptomEditForm.ShowDialog(this) != DialogResult.OK)
                    return;

                var newSymptom = symptomEditForm.Symptom;
                ClassTicket_Symptom.AddNew(ref newSymptom);
                PopulateSymptomsSolutions();
            }
        }

        private void btnSymptoms_Edit_Click(object sender, EventArgs e)
        {
            Symptom_Edit();
        }

        private void Symptom_Edit()
        {
            var selectedSymptom = (ClassTicket_Symptom)olvSymptoms.SelectedObject;
            if (selectedSymptom == null)
                return;

            using (var symptomEditForm = new FormAdmin_Symptom_AddEdit(selectedSymptom))
            {
                if (symptomEditForm.ShowDialog(this) != DialogResult.OK)
                    return;

                ClassTicket_Symptom.Update(selectedSymptom);
                PopulateSymptomsSolutions();
            }
        }

        private void btnSolutions_Add_Click(object sender, EventArgs e)
        {
            using (var solutionEditForm = new FormAdmin_Solution_AddEdit())
            {
                if (solutionEditForm.ShowDialog(this) != DialogResult.OK)
                    return;

                var newSolution = solutionEditForm.Solution;
                ClassTicket_Solution.AddNew(ref newSolution);
                PopulateSymptomsSolutions();
            }
        }

        private void btnSolutions_Edit_Click(object sender, EventArgs e)
        {
            Solution_Edit();
        }

        private void Solution_Edit()
        {
            var selectedSolution = (ClassTicket_Solution)olvSolutions.SelectedObject;
            if (selectedSolution == null)
                return;

            using (var solutionEditForm = new FormAdmin_Solution_AddEdit(selectedSolution))
            {
                if (solutionEditForm.ShowDialog(this) != DialogResult.OK)
                    return;

                ClassTicket_Solution.Update(selectedSolution);
                PopulateSymptomsSolutions();
            }
        }

        private void btnSymptoms_Remove_Click(object sender, EventArgs e)
        {
            if (olvSymptoms.SelectedItem == null)
                return;

            var selectedSymptom = (ClassTicket_Symptom)olvSymptoms.SelectedObject;
            var usedQty = ClassTicket_Symptom.GetUsedQty(selectedSymptom.ID);
            if (usedQty > 0)
            {
                var message = string.Format("Cannot remove \"{0}\" because it is used {1} time{2} in the database.{3}{3}Do you want to merge it with another symptom?", selectedSymptom.Symptom, usedQty, usedQty == 1 ? string.Empty : "s", Environment.NewLine);
                if (MessageBox.Show(message, "Symptom In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (var symptomSelectForm = new FormAdmin_Symptom_Select())
                {
                    if (symptomSelectForm.ShowDialog() != DialogResult.OK)
                        return;

                    if (symptomSelectForm.Symptom.ID == selectedSymptom.ID)
                    {
                        MessageBox.Show("Cannot merge symptom with itself.", "Merge Symptom Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var confirmation = string.Format("Symptom '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", selectedSymptom.Symptom, symptomSelectForm.Symptom.Symptom);
                    if (MessageBox.Show(confirmation, "Confirm Symptom Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        selectedSymptom.Merge(symptomSelectForm.Symptom.ID);
                        selectedSymptom.Delete();
                        MessageBox.Show("Symptom merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Symptom merge failed: " + exc.Message, "Symptom Merge Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var question = string.Format("Are you sure you want to remove \"{0}\"?", selectedSymptom.Symptom);
                if (MessageBox.Show(question, "Confirm Remove Symptom", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                selectedSymptom.Delete();
            }
            PopulateSymptomsSolutions();
        }

        private void btnSolutions_Remove_Click(object sender, EventArgs e)
        {
            if (olvSolutions.SelectedItem == null)
                return;

            var selectedSolution = (ClassTicket_Solution)olvSolutions.SelectedObject;
            var usedQty = ClassTicket_Solution.GetUsedQty(selectedSolution.ID);
            if (usedQty > 0)
            {
                var message = string.Format("Cannot remove \"{0}\" because it is used {1} time{2} in the database.{3}{3}Do you want to merge it with another solution?", selectedSolution.Solution, usedQty, usedQty == 1 ? string.Empty : "s", Environment.NewLine);
                if (MessageBox.Show(message, "Solution In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (var solutionSelectForm = new FormAdmin_Solution_Select())
                {
                    if (solutionSelectForm.ShowDialog() != DialogResult.OK)
                        return;

                    if (solutionSelectForm.Solution.ID == selectedSolution.ID)
                    {
                        MessageBox.Show("Cannot merge solution with itself.", "Merge Solution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var confirmation = string.Format("Solution '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", selectedSolution.Solution, solutionSelectForm.Solution);
                    if (MessageBox.Show(confirmation, "Confirm Solution Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        selectedSolution.Merge(solutionSelectForm.Solution.ID);
                        selectedSolution.Delete();
                        MessageBox.Show("Solution merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Solution merge failed: " + exc.Message, "Solution Merge Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var question = string.Format("Are you sure you want to remove \"{0}\"?", selectedSolution.Solution);
                if (MessageBox.Show(question, "Confirm Remove Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                selectedSolution.Delete();
                PopulateSymptomsSolutions();
            }
        }

        private void FormAdmin_SymptomsSolutions_ResizeEnd(object sender, EventArgs e)
        {
            var margin = pnlSymptoms.Left;
            var panelWidth = (Width / 2) - (margin * 3);
            pnlSymptoms.Width = panelWidth;

            pnlSolutions.Location = new Point((Width / 2) + (margin / 2), pnlSolutions.Top);
            pnlSolutions.Width = panelWidth;
        }

        private void olvSymptoms_DoubleClick(object sender, EventArgs e)
        {
            Symptom_Edit();
        }

        private void olvSolutions_DoubleClick(object sender, EventArgs e)
        {
            Solution_Edit();
        }

        #endregion

        #region PMA

        private List<ClassPreventiveMaintenanceAction> _pmas = new List<ClassPreventiveMaintenanceAction>();
        private ClassPreventiveMaintenanceAction _selectedPMA;

        private void Populate_PMAs()
        {
            _pmas = ClassPreventiveMaintenanceAction.GetPreventiveMaintenanceActions().ToList();
            olvPMAs.SetObjects(_pmas);
        }

        private void olvPMAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPMA = (ClassPreventiveMaintenanceAction)olvPMAs.SelectedObject;
            if (_selectedPMA == null)
                return;
        }

        private void btnPMA_Add_Click(object sender, EventArgs e)
        {
            using (FormAdmin_PMAs_AddEdit frmPMAAddEdit = new FormAdmin_PMAs_AddEdit(false))
            {
                if (frmPMAAddEdit.ShowDialog() != DialogResult.OK)
                    return;
                Populate_PMAs();
            }
        }

        private void btnPMA_Edit_Click(object sender, EventArgs e)
        {
            PMA_Edit();
        }

        private void olvPMAs_DoubleClick(object sender, EventArgs e)
        {
            PMA_Edit();
        }

        private void PMA_Edit()
        {
            if (_selectedPMA == null)
                return;
            using (FormAdmin_PMAs_AddEdit frmPMAAddEdit = new FormAdmin_PMAs_AddEdit(true, _selectedPMA.ID))
            {
                if (frmPMAAddEdit.ShowDialog() != DialogResult.OK)
                    return;
                Populate_PMAs();
            }
        }

        private void btnPMA_Remove_Click(object sender, EventArgs e)
        {
            if (_selectedPMA == null) return;
            if (MessageBox.Show("Are you sure you want to delete the selected preventive maintenance action?", "Confirm PMA Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            // Check if the PMA is used for anything
            int PMAUsedQty = ClassPreventiveMaintenanceAction.GetUsedQty(_selectedPMA.ID);
            if (PMAUsedQty > 0)
            {
                MessageBox.Show(string.Format("This preventive maintenance action is used {0} time{1} in the database. It cannot be deleted.", PMAUsedQty, PMAUsedQty == 1 ? string.Empty : "s"), "PMA In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ClassPreventiveMaintenanceAction.Delete(_selectedPMA);
            Populate_PMAs();
        }

        #endregion

        #region Users

        private void PopulateUsers()
        {
            _ignoreStateChange = true;

            cmbModifyUser_SelectUser.DisplayMember = "DisplayMember";
            cmbModifyUser_SelectUser.ValueMember = "ID";
            cmbModifyUser_SelectUser.DataSource = ClassUser.GetAll(ClassUser.UserAccountStatus.All);
            cmbModifyUser_SelectUser.SelectedIndex = -1;

            _ignoreStateChange = false;
        }

        private void btnUser_Modify_Click(object sender, EventArgs e)
        {
            var selectedUser = (ClassUser)cmbModifyUser_SelectUser.SelectedItem;

            if (selectedUser == null)
                return;

            if (!string.IsNullOrWhiteSpace(txtModifyUser_Password.Text.Trim()))
            {
                string errors;
                if (!Validate_ModifyUser_Password(out errors))
                {
                    MessageBox.Show(errors, "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClassUser.SetPassword(selectedUser.ID, txtModifyUser_Password.Text.Trim());
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, "Changed password");
                MessageBox.Show(string.Format("Password successfully changed for \"{0} {1}\".", selectedUser.First, selectedUser.Last), "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!string.IsNullOrWhiteSpace(txtModifyUser_Pin.Text.Trim()))
            {
                string errors;
                if (!Validate_ModifyUser_Pin(out errors))
                {
                    MessageBox.Show(errors, "Pin Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClassUser.SetPin(selectedUser.ID, txtModifyUser_Pin.Text.Trim());
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, "Changed PIN");
                MessageBox.Show(string.Format("PIN successfully changed for \"{0} {1}\".", selectedUser.First, selectedUser.Last), "PIN Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string newUserType;
            if (radModifyUser_UserType_Administrator.Checked)
                newUserType = ClassUser.USERTYPE_ADMIN;
            else if (radModifyUser_UserType_Moderator.Checked)
                newUserType = ClassUser.USERTYPE_MODERATOR;
            else if (radModifyUser_UserType_SSR.Checked)
                newUserType = ClassUser.USERTYPE_SSR;
            else
                newUserType = ClassUser.USERTYPE_STANDARD;

            if (selectedUser.UserType != newUserType)
            {
                ClassUser.SetType(selectedUser.ID, newUserType);
                var changeString = string.Format("from {0} to {1}", selectedUser.UserType, newUserType);
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, changeString);
                MessageBox.Show(string.Format("\"{0} {1}\" successfully changed {2}.", selectedUser.First, selectedUser.Last, changeString), "User Type Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (selectedUser.LoginDisabled != radModifyUser_DisableLogin.Checked)
            {
                ClassUser.SetLoginDisabled(selectedUser.ID, radModifyUser_DisableLogin.Checked);
                var changeString = string.Format("from {0} to {1}", selectedUser.LoginDisabled ? "Disabled" : "Enabled", radModifyUser_DisableLogin.Checked ? "Disabled" : "Enabled");
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, selectedUser.ID, changeString);
                MessageBox.Show(string.Format("\"{0} {1}\" successfully changed {2}.", selectedUser.First, selectedUser.Last, changeString), "User Account Status Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (radModifyUser_DisableLogin.Checked)
                {
                    ClassSubscription.UnsubscribeAll(selectedUser.ID);
                    ClassNotification.DeleteAllByUser(selectedUser.ID);
                }
            }
            ClearControls_ModifyUser();
            PopulateUsers();
        }

        private void btnUser_New_Click(object sender, EventArgs e)
        {
            int newUserID;
            string errors;
            if (!Validate_NewUser(out errors, out newUserID))
            {
                MessageBox.Show(errors, "Create User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new ClassUser
            {
                ID = newUserID,
                First = txtCreateUser_FirstName.Text.Trim(),
                Last = txtCreateUser_LastName.Text.Trim(),
                Email = txtCreateUser_Email.Text.Trim()
            };
            var initialPassword = txtCreateUser_Password.Text;

            if (radCreateUser_UserType_Administrator.Checked)
                newUser.UserType = ClassUser.USERTYPE_ADMIN;
            else if (radCreateUser_UserType_Moderator.Checked)
                newUser.UserType = ClassUser.USERTYPE_MODERATOR;
            else if (radCreateUser_UserType_SSR.Checked)
                newUser.UserType = ClassUser.USERTYPE_SSR;
            else
                newUser.UserType = ClassUser.USERTYPE_STANDARD;
            try
            {
                ClassUser.AddNew(newUser, initialPassword);
            }
            catch (MySqlException mexc)
            {
                MessageBox.Show(string.Format("User could not be added. Is the login unique?{0}{0}{1}", Environment.NewLine, mexc.Message), "Create User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ClassEmailQueue.Add(ClassEmailQueue.EmailTypeEnum.NewUser, ClassEmailGenerator.GenerateEmail_NewUser(newUser, initialPassword));
            }
            catch (Exception exc)
            {
                ClassLogFile.AppendToLog("Unable to send new user email.", exc);
            }

            ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.User, newUser.ID, string.Format("{0} {1}", newUser.First, newUser.Last));
            MessageBox.Show(string.Format("\"{0} {1}\" successfully added using login \"{2}\".", newUser.First, newUser.Last, newUser.ID), "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearControls_NewUser();
            PopulateUsers();
        }

        private bool Validate_ModifyUser_Password(out string errors)
        {
            var sb = new StringBuilder();

            if (txtModifyUser_Password.Text.Trim().Length < 6)
                sb.AppendLine("New password must be at least 6 characters.");

            if (txtModifyUser_Password.Text.Trim() != txtModifyUser_Password_Confirm.Text.Trim())
                sb.AppendLine("Passwords do not match.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private bool Validate_ModifyUser_Pin(out string errors)
        {
            var sb = new StringBuilder();

            if (txtModifyUser_Pin.Text.Trim().Length < 4)
                sb.AppendLine("New PIN must be at least 4 characters.");

            if (txtModifyUser_Pin.Text.Trim() != txtModifyUser_Pin_Confirm.Text.Trim())
                sb.AppendLine("PINs do not match.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private bool Validate_NewUser(out string errors, out int newUserID)
        {
            var sb = new StringBuilder();

            if (!int.TryParse(txtCreateUser_Login.Text.Trim(), out newUserID))
                sb.AppendLine("New user logins must be numeric only.");

            if (string.IsNullOrWhiteSpace(txtCreateUser_FirstName.Text.Trim()))
                sb.AppendLine("First name cannot be blank.");

            if (string.IsNullOrWhiteSpace(txtCreateUser_LastName.Text.Trim()))
                sb.AppendLine("Last name cannot be blank.");

            if (!ClassUtility.ValidateEmailAddress(txtCreateUser_Email.Text.Trim()))
                sb.AppendLine("Email address required.");

            if (string.IsNullOrWhiteSpace(txtCreateUser_Password.Text.Trim()))
                sb.AppendLine("Password cannot be blank.");

            if (txtCreateUser_Password.Text.Trim().Length < 6)
                sb.AppendLine("Password must be at least 6 characters.");

            if (txtCreateUser_Password.Text.Trim() != txtCreateUser_Password_Confirm.Text.Trim())
                sb.AppendLine("Passwords do not match.");

            errors = sb.ToString();
            return string.IsNullOrEmpty(errors);
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ignoreStateChange)
                return;

            var selectedUser = (ClassUser)cmbModifyUser_SelectUser.SelectedItem;
            switch (selectedUser.UserType)
            {
                case ClassUser.USERTYPE_ADMIN:
                    radModifyUser_UserType_Administrator.Checked = true;
                    break;
                case ClassUser.USERTYPE_MODERATOR:
                    radModifyUser_UserType_Moderator.Checked = true;
                    break;
                case ClassUser.USERTYPE_SSR:
                    radModifyUser_UserType_SSR.Checked = true;
                    break;
                default:
                    radModifyUser_UserType_Standard.Checked = true;
                    break;
            }
            radModifyUser_DisableLogin.Checked = selectedUser.LoginDisabled;
        }

        private void ClearControls_ModifyUser()
        {
            foreach (var textBox in pnlUser_Modify.Controls.OfType<TextBox>())
                textBox.Clear();
            radModifyUser_UserType_Standard.Checked = true;
            radModifyUser_DisableLogin.Checked = false;
        }

        private void ClearControls_NewUser()
        {
            foreach (var textBox in pnlUser_Create.Controls.OfType<TextBox>())
                textBox.Clear();
            radCreateUser_UserType_Standard.Checked = true;
        }

        private void pnlUser_Modify_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnModifyUser;
        }

        private void pnlUser_Create_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnCreateUser;
        }

        #endregion

        #region RMA Failures

        private List<ClassRMA_FailureType> _failureTypes = new List<ClassRMA_FailureType>();
        private List<ClassRMA_RepairType> _repairTypes = new List<ClassRMA_RepairType>();
        private List<ClassRMA_RootCause> _rootCauses = new List<ClassRMA_RootCause>();

        private void PopulateRMAFailures()
        {
            _failureTypes = ClassRMA_FailureType.GetAll().ToList();
            _repairTypes = ClassRMA_RepairType.GetAll().ToList();
            _rootCauses = ClassRMA_RootCause.GetAll().ToList();

            olvFailureTypes.SetObjects(_failureTypes);
            olvRepairTypes.SetObjects(_repairTypes);
            olvRootCauses.SetObjects(_rootCauses);
        }

        #region FailureTypes
        private void btnFailureType_Add_Click(object sender, EventArgs e)
        {
            using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(false))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    ClassRMA_FailureType.AddNew(fae.Description);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not add Failure Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Failure Type Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateRMAFailures();
        }

        private void btnFailureType_Edit_Click(object sender, EventArgs e)
        {
            if (olvFailureTypes.SelectedItem == null)
                return;

            ClassRMA_FailureType selectedFailureType = (ClassRMA_FailureType)olvFailureTypes.SelectedObject;
            using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(true, selectedFailureType.Description))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    selectedFailureType.Description = fae.Description;
                    ClassRMA_FailureType.Update(selectedFailureType);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not update Failure Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Failure Type Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateRMAFailures();
        }

        private void btnFailureType_Remove_Click(object sender, EventArgs e)
        {
            if (olvFailureTypes.SelectedItem == null)
                return;

            ClassRMA_FailureType selectedFailureType = (ClassRMA_FailureType)olvFailureTypes.SelectedObject;
            int usedQty = ClassRMA_FailureType.GetUsedQty(selectedFailureType.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another failure type?", selectedFailureType.Description, usedQty, Environment.NewLine),
                    "Failure Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (FormRMA_FailureType_Select ffts = new FormRMA_FailureType_Select())
                {
                    if (ffts.ShowDialog() != DialogResult.OK)
                        return;

                    if (ffts.FailureType.ID == selectedFailureType.ID)
                    {
                        MessageBox.Show("Cannot merge Failure Type with itself.", "Merge Failure Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show(string.Format("Failure type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", selectedFailureType.Description, ffts.FailureType.Description),
                        "Confirm Failure Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;

                    try
                    {
                        ClassRMA_FailureType.Merge(selectedFailureType.ID, ffts.FailureType.ID);
                        ClassRMA_FailureType.Delete(selectedFailureType.ID);
                        MessageBox.Show("Failure type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Component merge failed: " + exc.Message, "Merge Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove failure type '{0}'?", selectedFailureType.Description),
                    "Confirm Remove Failure Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                ClassRMA_FailureType.Delete(selectedFailureType.ID);
                MessageBox.Show("Failure type remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulateRMAFailures();
        }
        #endregion

        #region Repair Types
        private void btnRepairTypes_Add_Click(object sender, EventArgs e)
        {
            using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(false))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    ClassRMA_RepairType.AddNew(fae.Description);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not add Repair Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Repair Type Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateRMAFailures();
        }

        private void btnRepairType_Edit_Click(object sender, EventArgs e)
        {
            if (olvRepairTypes.SelectedItem == null) return;
            ClassRMA_RepairType SelectedRepairType = (ClassRMA_RepairType)olvRepairTypes.SelectedObject;
            using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(true, SelectedRepairType.Description))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    SelectedRepairType.Description = fae.Description;
                    ClassRMA_RepairType.Update(SelectedRepairType);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not update Repair Type. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Repair Type Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateRMAFailures();
        }

        private void btnRepairType_Remove_Click(object sender, EventArgs e)
        {
            if (olvRepairTypes.SelectedItem == null) return;
            ClassRMA_RepairType SelectedRepairType = (ClassRMA_RepairType)olvRepairTypes.SelectedObject;
            int UsedQty = ClassRMA_RepairType.GetUsedQty(SelectedRepairType.ID);
            if (UsedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another repair type?", SelectedRepairType.Description, UsedQty, Environment.NewLine),
                    "Repair Type In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                using (FormRMA_RepairType_Select frts = new FormRMA_RepairType_Select())
                {
                    if (frts.ShowDialog() != DialogResult.OK)
                        return;
                    if (frts.RepairType.ID == SelectedRepairType.ID)
                    {
                        MessageBox.Show("Cannot merge Repair Type with itself.", "Merge Repair Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show(string.Format("Repair type '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", SelectedRepairType.Description, frts.RepairType.Description),
                        "Confirm Repair Type Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassRMA_RepairType.Merge(SelectedRepairType.ID, frts.RepairType.ID);
                        ClassRMA_RepairType.Delete(SelectedRepairType.ID);
                        MessageBox.Show("Repair Type merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Repair Type merge failed: " + exc.Message, "Merge Repair Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove repair type '{0}'?", SelectedRepairType.Description),
                    "Confirm Remove Repair Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassRMA_RepairType.Delete(SelectedRepairType.ID);
                MessageBox.Show("Repair type remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulateRMAFailures();
        }
        #endregion

        #region Root Causes
        private void btnRootCause_Add_Click(object sender, EventArgs e)
        {
            using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(false))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    ClassRMA_RootCause.AddNew(fae.Description);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not update or add root cause. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Root Cause Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateRMAFailures();
        }

        private void btnRootCause_Edit_Click(object sender, EventArgs e)
        {
            if (olvRootCauses.SelectedItem == null) return;
            ClassRMA_RootCause selectedRootCause = (ClassRMA_RootCause)olvRootCauses.SelectedObject;
            using (FormAdmin_RMA_FailureRepair_AddEdit fae = new FormAdmin_RMA_FailureRepair_AddEdit(true, selectedRootCause.Description))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    selectedRootCause.Description = fae.Description;
                    ClassRMA_RootCause.Update(selectedRootCause);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not update or add Root Cause. Ensure the description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Root Cause Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateRMAFailures();
        }

        private void btnRootCause_Remove_Click(object sender, EventArgs e)
        {
            if (olvRootCauses.SelectedItem == null) return;
            ClassRMA_RootCause SelectedRootCause = (ClassRMA_RootCause)olvRootCauses.SelectedObject;
            int UsedQty = ClassRMA_RootCause.GetUsedQty(SelectedRootCause.ID);
            if (UsedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Root Cause?", SelectedRootCause.Description, UsedQty, Environment.NewLine),
                    "Root Cause In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                using (FormRMA_RootCause_Select frcs = new FormRMA_RootCause_Select())
                {
                    if (frcs.ShowDialog() != DialogResult.OK)
                        return;
                    if (frcs.RootCause.ID == SelectedRootCause.ID)
                    {
                        MessageBox.Show("Cannot merge Root Cause with itself.", "Merge Root Cause Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show(string.Format("Root Cause '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", SelectedRootCause.Description, frcs.RootCause.Description),
                        "Confirm Root Cause Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassRMA_RootCause.Merge(SelectedRootCause.ID, frcs.RootCause.ID);
                        ClassRMA_RootCause.Delete(SelectedRootCause.ID);
                        MessageBox.Show("Root Cause merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Root Cause merge failed: " + exc.Message, "Merge Root Cause Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove Root Cause '{0}'?", SelectedRootCause.Description),
                    "Confirm Remove Root Cause", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassRMA_RootCause.Delete(SelectedRootCause.ID);
                MessageBox.Show("Root Cause remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulateRMAFailures();
        }
        #endregion

        #endregion

        #region RMA Components

        private List<ClassComponent> _components = new List<ClassComponent>();
        private ClassComponent _selectedComponent;

        private void olvComponents_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            var component = (ClassComponent)e.Model;
            if (component.Disabled)
                e.Item.ForeColor = Color.LightGray;
        }

        private void Populate_Components()
        {
            _components = ClassComponent.GetAll().OrderBy(c => c.Description).ToList();
            olvComponents.SetObjects(_components);
            txtQty.Text = _components.Count.ToString();
        }

        private void olvComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedComponent = (ClassComponent)olvComponents.SelectedObject;
            if (_selectedComponent == null)
                return;
            btnEnableDisable.Text = _selectedComponent.Disabled ? "Enable Component" : "Disable Component";
        }

        private void btnComponent_Add_Click(object sender, EventArgs e)
        {
            using (var fca = new FormAdmin_Component_AddEdit(false))
            {
                if (fca.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Components();
            }
        }

        private void btnComponent_Edit_Click(object sender, EventArgs e)
        {
            Component_Edit();
        }

        private void olvComponents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Component_Edit();
        }

        private void Component_Edit()
        {
            if (_selectedComponent == null)
                return;
            using (var fca = new FormAdmin_Component_AddEdit(true, _selectedComponent.ID))
            {
                if (fca.ShowDialog() != DialogResult.OK)
                    return;
                Populate_Components();
            }
        }

        private void btnComponent_Delete_Click(object sender, EventArgs e)
        {
            if (_selectedComponent == null)
                return;
            var usedQty = ClassComponent.GetUsedQty(_selectedComponent.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Component?", _selectedComponent.Description, usedQty, Environment.NewLine),
                    "Component In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                using (var componentSelectForm = new FormRMA_Component_Select())
                {
                    componentSelectForm.ShowControlsForRMA(false);
                    componentSelectForm.SetInfoLabel("Select a component:");
                    if (componentSelectForm.ShowDialog() != DialogResult.OK)
                        return;
                    if (componentSelectForm.RMAComponents[0].Component.ID == _selectedComponent.ID)
                    {
                        MessageBox.Show("Cannot merge Component with itself.", "Merge Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show(string.Format("Component '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedComponent.Description, componentSelectForm.RMAComponents[0].Component.Description),
                        "Confirm Component Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                    try
                    {
                        ClassComponent.Merge(_selectedComponent.ID, componentSelectForm.RMAComponents[0].Component.ID);
                        ClassComponent.Delete(_selectedComponent);
                        MessageBox.Show("Component merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Component merge failed: " + exc.Message, "Merge Component Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove Component '{0}'?", _selectedComponent.Description),
                    "Confirm Remove Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassComponent.Delete(_selectedComponent);
                MessageBox.Show("Component remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Populate_Components();

            #region Deprecated
            //if (_selectedComponent == null)
            //    return;
            //if (MessageBox.Show("Are you sure you want to delete the selected component?", "Confirm Component Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            //    return;

            //// Check if the component is used for any RMA
            //int ComponentUsedQty = ClassYSO.Component_UsedQty(_selectedComponent.ID);
            //if (ComponentUsedQty > 0)
            //{
            //    MessageBox.Show(string.Format("This component is used {0} time{1} in the database. It cannot be deleted.", ComponentUsedQty, ComponentUsedQty == 1 ? string.Empty : "s"), "Component In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //ClassYSO.Component_Delete(_selectedComponent);
            //Populate_Components();
            #endregion
        }

        private void btnComponent_EnableDisable_Click(object sender, EventArgs e)
        {
            if (_selectedComponent == null) return;
            if (!_selectedComponent.Disabled)
            {
                if (MessageBox.Show("Are you sure you want to disable the selected component?", "Confirm Component Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                ClassComponent.Disable(_selectedComponent.ID, true);
            }
            else
                ClassComponent.Disable(_selectedComponent.ID, false);

            Populate_Components();
        }

        #endregion

        #region RMA Areas & Zones

        private List<ClassRMA_Area> _areas = new List<ClassRMA_Area>();
        private ClassRMA_Area _selectedArea;

        private List<ClassRMA_Zone> _zones = new List<ClassRMA_Zone>();
        private ClassRMA_Zone _selectedZone;

        private void Populate_Areas()
        {
            _areas = ClassRMA_Area.GetAll().ToList();

            olvRmaAreas.SetObjects(_areas);
            olvRmaZones.SetObjects(null);
        }

        private void Populate_Zones()
        {
            _zones = olvRmaAreas.SelectedObject == null ? null : ClassRMA_Zone.GetByArea(_selectedArea.ID);
            olvRmaZones.SetObjects(_zones);
        }

        private void olvRMAAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedArea = (ClassRMA_Area)olvRmaAreas.SelectedObject;
            _selectedZone = null;
            Populate_Zones();
        }

        private void olvRmaZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvRmaZones.SelectedItems.Count == 1)
                _selectedZone = (ClassRMA_Zone)olvRmaZones.SelectedObject;
            else
                _selectedZone = null;
        }

        private void olvRmaZones_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            var zone = (ClassRMA_Zone)e.Model;
            if (!zone.IsDefault)
                return;
            e.Item.BackColor = Color.PaleGreen;
        }

        private void btnRMAZone_Add_Click(object sender, EventArgs e)
        {
            if (_selectedArea == null)
                return;

            using (var fae = new FormAdmin_RMA_Zone_AddEdit(false))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    ClassRMA_Zone.AddNew(fae.Zone, _selectedArea.ID);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not add Zone. Ensure the Zone Name is unique within its Area.{0}{0}{1}", Environment.NewLine, exc.Message), "Zone Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Populate_Zones();
        }

        private void olvRmaZones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RmaZone_Edit();
        }

        private void btnRmaZone_Edit_Click(object sender, EventArgs e)
        {
            RmaZone_Edit();
        }

        private void btnRmaZone_SetDefault_Click(object sender, EventArgs e)
        {
            if (_selectedZone == null)
                return;

            ClassRMA_Zone.SetDefault(_selectedZone.ID);
            Populate_Zones();

        }

        private void RmaZone_Edit()
        {
            if (_selectedZone == null)
                return;

            var selectedIndex = olvRmaZones.IndexOf(olvRmaZones.SelectedObject);

            using (var fae = new FormAdmin_RMA_Zone_AddEdit(true, _selectedZone.ZoneName))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _selectedZone.ZoneName = fae.Zone;
                    ClassRMA_Zone.Update(_selectedZone);

                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not update Zone. Ensure the Zone Name is unique within its Area.{0}{0}{1}", Environment.NewLine, exc.Message), "Zone Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Populate_Zones();

            // Select and show last-edited item if possible
            try
            {
                olvRmaZones.Select();
                olvRmaZones.TopItemIndex = selectedIndex;
                olvRmaZones.SelectedIndex = selectedIndex;
            }
            catch
            {
            }
        }

        private void btnRMAZone_Remove_Click(object sender, EventArgs e)
        {
            if (_selectedZone == null)
                return;

            int usedQty = ClassRMA_Zone.GetUsedQty(_selectedZone.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another zone?", _selectedZone.ZoneName, usedQty, Environment.NewLine),
                    "Zone In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (var fzs = new FormRMA_AreaZone_Select())
                {
                    if (fzs.ShowDialog() != DialogResult.OK)
                        return;

                    if (fzs.SelectedZone == null)
                        return;

                    if (fzs.SelectedZone.ID == _selectedZone.ID)
                    {
                        MessageBox.Show("Cannot merge Zone with itself.", "Merge Zone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show(string.Format("Zone '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedZone.ZoneName, fzs.SelectedZone.ZoneName),
                        "Confirm Zone Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;

                    try
                    {
                        ClassRMA_Zone.Merge(_selectedZone.ID, fzs.SelectedZone.ID);
                        ClassRMA_Zone.Delete(_selectedZone.ID);
                        MessageBox.Show("Zone merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Zone merge failed: " + exc.Message, "Merge Zone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove Zone '{0}'?", _selectedZone.ZoneName),
                    "Confirm Remove Zone", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                ClassRMA_Zone.Delete(_selectedZone.ID);
                //MessageBox.Show("Zone remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _selectedZone = null;
            Populate_Zones();
        }

        private void btnRmaZone_PrintLabel_Click(object sender, EventArgs e)
        {
            var selectedZones = olvRmaZones.SelectedObjects.Cast<ClassRMA_Zone>().ToList();
            PrintZoneLabels(selectedZones);
        }

        private void PrintZoneLabels(List<ClassRMA_Zone> zones)
        {
            if (zones == null || !zones.Any())
                return;

            const int LABEL_PRINT_TIMEOUT = 10000; // ms
            var rmaZoneLabelWithPath = Path.Combine(Application.StartupPath, @"Required Files", ClassRMA_Zone.RMA_ZONE_LABEL_DOCUMENT);

            #region Validation
            if (string.IsNullOrEmpty(GS.Settings.RMA_ZoneLabel_PrinterName))
            {
                MessageBox.Show("No printer selected for RMA Zone Labels.", "Printer Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!File.Exists(rmaZoneLabelWithPath))
            {
                var message = string.Format("Error: Could not find the RMA Zone Label Document \"{0}\". Label printing is not possible.", rmaZoneLabelWithPath);
                MessageBox.Show(message, "Missing Label Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            Engine barTenderEngine = new Engine(true);
            LabelFormatDocument barTenderDocument;

            try
            {
                barTenderDocument = barTenderEngine.Documents.Open(rmaZoneLabelWithPath);
            }
            catch (COMException comException)
            {
                var message = string.Format("Error opening RMA Zone Label Document \"{0}\":{1}{1}{2}", rmaZoneLabelWithPath, Environment.NewLine, comException.Message);
                MessageBox.Show(message, "Error Opening Label Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barTenderEngine.Stop();
                return;
            }

            barTenderDocument.PrintSetup.IdenticalCopiesOfLabel = 2; // Printed label is designed to be half of a physical 4x6 label, print two above-and-below on the same label
            barTenderDocument.PrintSetup.NumberOfSerializedLabels = 1;
            barTenderDocument.PrintSetup.PrinterName = GS.Settings.RMA_ZoneLabel_PrinterName;

            var sbSummary = new StringBuilder();
            var sbDetail = new StringBuilder();

            foreach (var zone in zones)
            {
                barTenderDocument.SubStrings["area_name"].Value = ClassRMA_Area.GetByID(zone.Area_ID).AreaName;
                barTenderDocument.SubStrings["zone_name"].Value = zone.ZoneName;
                barTenderDocument.SubStrings["zone_id"].Value = string.Format("Z{0:00000}", zone.ID);

                Seagull.BarTender.Print.Messages printMessages;
                Result printResult = barTenderDocument.Print(zone.ZoneName, LABEL_PRINT_TIMEOUT, out printMessages);
                var messageString = printMessages.Aggregate("\n\nMessages:", (current, m) => current + ("\n\n" + m.Text));
                sbSummary.AppendFormat("{0}: {1}", zone.ZoneName, printResult == Result.Success ? "Success" : "Failed").AppendLine();
                sbDetail.AppendFormat("{0}{1}{1}", messageString, Environment.NewLine);
            }

            barTenderEngine.Stop();

            var summaryMessage = string.Format("{0}{1}{1}Show details?", sbSummary, Environment.NewLine);
            if (MessageBox.Show(summaryMessage, "Label Print Results", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            MessageBox.Show(sbDetail.ToString());
        }

        private void btnRMAArea_Add_Click(object sender, EventArgs e)
        {
            using (var fae = new FormAdmin_RMA_Area_AddEdit(false))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    ClassRMA_Area.AddNew(fae.Area);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not add Area. Ensure the Area Name is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Area Add: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Populate_Areas();
        }

        private void btnRMAArea_Remove_Click(object sender, EventArgs e)
        {
            if (_selectedArea == null)
                return;

            int usedQty = ClassRMA_Area.GetUsedQty(_selectedArea.ID);
            if (usedQty > 0)
            {
                if (MessageBox.Show(string.Format("Cannot remove '{0}' because it is used {1} time(s) in the database.{2}{2}Do you want to merge it with another Area?", _selectedArea.AreaName, usedQty, Environment.NewLine),
                    "Area In Use: Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                using (var fzs = new FormRMA_AreaZone_Select(FormRMA_AreaZone_Select.AreaZoneSelect.AreaOnly))
                {
                    if (fzs.ShowDialog() != DialogResult.OK)
                        return;

                    if (fzs.SelectedArea == null)
                        return;

                    if (fzs.SelectedArea.ID == _selectedArea.ID)
                    {
                        MessageBox.Show("Cannot merge Area with itself.", "Merge Area Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show(string.Format("Area '{0}' will be replaced with '{1}' throughout the database. Do you want to proceed?", _selectedArea.AreaName, fzs.SelectedArea.AreaName),
                        "Confirm Area Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;

                    try
                    {
                        ClassRMA_Area.Merge(_selectedArea.ID, fzs.SelectedArea.ID);
                        ClassRMA_Area.Delete(_selectedArea.ID);
                        MessageBox.Show("Area merge complete.", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException exc)
                    {
                        MessageBox.Show("Area merge failed: " + exc.Message, "Merge Area Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove Area '{0}'?", _selectedArea.AreaName),
                    "Confirm Remove Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                ClassRMA_Area.Delete(_selectedArea.ID);
                //MessageBox.Show("Area remove complete.", "Remove Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _selectedArea = null;
            Populate_Areas();
        }

        private void olvRmaAreas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RmaArea_Edit();

        }
        private void btnRMAArea_Edit_Click(object sender, EventArgs e)
        {
            RmaArea_Edit();
        }

        private void RmaArea_Edit()
        {
            if (_selectedArea == null)
                return;

            var selectedIndex = olvRmaAreas.IndexOf(olvRmaAreas.SelectedObject);

            using (var fae = new FormAdmin_RMA_Area_AddEdit(true, _selectedArea.AreaName))
            {
                if (fae.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _selectedArea.AreaName = fae.Area;
                    ClassRMA_Area.Update(_selectedArea);
                }
                catch (Exception exc)
                {
                    ClassLogFile.AppendToLog(exc);
                    MessageBox.Show(string.Format("Could not update Area. Ensure the Area Name is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Area Edit: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Populate_Areas();

            // Select and show last-edited item if possible
            try
            {
                olvRmaAreas.Select();
                olvRmaAreas.TopItemIndex = selectedIndex;
                olvRmaAreas.SelectedIndex = selectedIndex;
            }
            catch
            {
            }
        }

        #endregion

        #region Admin Email

        private List<ClassAdminEmail> _adminEmails = new List<ClassAdminEmail>();
        private ClassAdminEmail _selectedAdminEmail;

        private void Populate_AdminEmails()
        {
            _adminEmails = ClassAdminEmail.GetAll().ToList();
            olvAdminEmails.SetObjects(_adminEmails);
        }

        private void olvAdminEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAdminEmail = (ClassAdminEmail)olvAdminEmails.SelectedObject;
        }

        private void btnAdd_AdminEmail_Click(object sender, EventArgs e)
        {
            using (var frmAdminEmailAddEdit = new FormAdmin_Email_AddEdit(false))
            {
                if (frmAdminEmailAddEdit.ShowDialog() != DialogResult.OK)
                    return;

                Populate_AdminEmails();
            }
        }

        private void btnEdit_AdminEmail_Click(object sender, EventArgs e)
        {
            AdminEmail_Edit();
        }

        private void btnRemove_AdminEmail_Click(object sender, EventArgs e)
        {
            if (_selectedAdminEmail == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete the selected admin email?", "Confirm Admin Email Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            ClassAdminEmail.Delete(_selectedAdminEmail.ID);
            Populate_AdminEmails();
        }

        private void olvAdminEmails_DoubleClick(object sender, EventArgs e)
        {
            AdminEmail_Edit();
        }

        private void AdminEmail_Edit()
        {
            if (_selectedAdminEmail == null)
                return;

            using (var frmAdminEmailAddEdit = new FormAdmin_Email_AddEdit(true, _selectedAdminEmail.ID))
            {
                if (frmAdminEmailAddEdit.ShowDialog() != DialogResult.OK)
                    return;

                Populate_AdminEmails();
            }
        }


        #endregion

    }
}