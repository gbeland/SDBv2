namespace SDB.Forms.Admin
{
    partial class FormAdmin_Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOutputMethods = new System.Windows.Forms.TabPage();
            this.pnlOutputMethod_Editor = new System.Windows.Forms.Panel();
            this.btnOutputMethod_Editor_Cancel = new System.Windows.Forms.Button();
            this.btnOutputMethod_Editor_Save = new System.Windows.Forms.Button();
            this.txtOutputMethod_Description = new System.Windows.Forms.TextBox();
            this.lblOutputMethod_Description = new System.Windows.Forms.Label();
            this.olvOutputMethods = new BrightIdeasSoftware.ObjectListView();
            this.olcOutputMethodDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlOutputMethods_Control = new System.Windows.Forms.Panel();
            this.btnOutputMethod_Delete = new System.Windows.Forms.Button();
            this.btnOutputMethod_Edit = new System.Windows.Forms.Button();
            this.btnOutputMethod_Add = new System.Windows.Forms.Button();
            this.tabCabinetTypes = new System.Windows.Forms.TabPage();
            this.pnlCabinetType_Editor = new System.Windows.Forms.Panel();
            this.txtCabinetType_Description = new System.Windows.Forms.TextBox();
            this.lblCabinetType_Description = new System.Windows.Forms.Label();
            this.btnCabinetType_Editor_Cancel = new System.Windows.Forms.Button();
            this.btnCabinetType_Editor_Save = new System.Windows.Forms.Button();
            this.olvCabinetTypes = new BrightIdeasSoftware.ObjectListView();
            this.olcCabinetType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlCabinetTypes_Control = new System.Windows.Forms.Panel();
            this.btnCabinetType_Delete = new System.Windows.Forms.Button();
            this.btnCabinetType_Edit = new System.Windows.Forms.Button();
            this.btnCabinetType_Add = new System.Windows.Forms.Button();
            this.tabAssemblies = new System.Windows.Forms.TabPage();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.olvAssemblies = new BrightIdeasSoftware.ObjectListView();
            this.olvColAssembly_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssembly_AssyNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssembly_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssembly_Location = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColInventoryQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlAssembly_Control = new System.Windows.Forms.Panel();
            this.txtAssemblies_OfType = new System.Windows.Forms.TextBox();
            this.lblAssemblies_OfType = new System.Windows.Forms.Label();
            this.btnAssembly_Edit = new System.Windows.Forms.Button();
            this.btnAssembly_EnableDisable = new System.Windows.Forms.Button();
            this.lblAssembly_Qty = new System.Windows.Forms.Label();
            this.txtAssembly_Qty = new System.Windows.Forms.TextBox();
            this.btnAssembly_Delete = new System.Windows.Forms.Button();
            this.btnAssembly_Add = new System.Windows.Forms.Button();
            this.lblDivider1 = new System.Windows.Forms.Label();
            this.olvTypes = new BrightIdeasSoftware.ObjectListView();
            this.olcType_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_SerialNumberFormat = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_IsComputer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_AllowDiscard = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcCustomsDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcTariffCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlTypes_Control = new System.Windows.Forms.Panel();
            this.txtTypes_OfCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAssemblyType_Bottom = new System.Windows.Forms.Panel();
            this.pnlAssemblyType_BottomLeft = new System.Windows.Forms.Panel();
            this.btnType_Edit = new System.Windows.Forms.Button();
            this.btnType_Delete = new System.Windows.Forms.Button();
            this.btnType_Add = new System.Windows.Forms.Button();
            this.pnlType_BottomRight = new System.Windows.Forms.Panel();
            this.lblType_Qty = new System.Windows.Forms.Label();
            this.txtType_Qty = new System.Windows.Forms.TextBox();
            this.lblDivider2 = new System.Windows.Forms.Label();
            this.olvCategories = new BrightIdeasSoftware.ObjectListView();
            this.olcCategory_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcCategory_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlCategory_Control = new System.Windows.Forms.Panel();
            this.pnlAssemblyCategory_Bottom = new System.Windows.Forms.Panel();
            this.pnlAssemblyCategory_BottomLeft = new System.Windows.Forms.Panel();
            this.btnCategory_Edit = new System.Windows.Forms.Button();
            this.btnCategory_Delete = new System.Windows.Forms.Button();
            this.btnCategory_Add = new System.Windows.Forms.Button();
            this.pnlAssemblyCategory_BottomRight = new System.Windows.Forms.Panel();
            this.lblCategory_Qty = new System.Windows.Forms.Label();
            this.txtCategory_Qty = new System.Windows.Forms.TextBox();
            this.lblAssemblyCategories = new System.Windows.Forms.Label();
            this.tabCameras = new System.Windows.Forms.TabPage();
            this.pnlCameraTypes = new System.Windows.Forms.Panel();
            this.olvCameraTypes = new BrightIdeasSoftware.ObjectListView();
            this.olvColDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlCameraTypes_Control = new System.Windows.Forms.Panel();
            this.btnCameraType_Edit = new System.Windows.Forms.Button();
            this.btnCameraType_Remove = new System.Windows.Forms.Button();
            this.btnCameraType_Add = new System.Windows.Forms.Button();
            this.tabAssetTags = new System.Windows.Forms.TabPage();
            this.olvTags = new BrightIdeasSoftware.ObjectListView();
            this.olvColTags = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDesciption = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssetTag_Edit = new System.Windows.Forms.Button();
            this.btnAssetTag_Remove = new System.Windows.Forms.Button();
            this.btnAssetTag_Add = new System.Windows.Forms.Button();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRentalCompanies = new System.Windows.Forms.TabPage();
            this.pnlRentalCompany_Editor = new System.Windows.Forms.Panel();
            this.btnRentalDivision_Delete = new System.Windows.Forms.Button();
            this.lblDivisionEditHelp = new System.Windows.Forms.Label();
            this.btnRentalDivision_Add = new System.Windows.Forms.Button();
            this.btnRentalCompany_Editor_Cancel = new System.Windows.Forms.Button();
            this.btnRentalCompany_Editor_Save = new System.Windows.Forms.Button();
            this.olvRentalDivisions = new BrightIdeasSoftware.ObjectListView();
            this.olcDivisionName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlNumberFormats = new System.Windows.Forms.Panel();
            this.lblFormat_PickupNumber = new System.Windows.Forms.Label();
            this.lblNumberFormatHelp = new System.Windows.Forms.Label();
            this.lblFormat_EquipmentNumber = new System.Windows.Forms.Label();
            this.lblReservationNumber = new System.Windows.Forms.Label();
            this.lblFormat_ReservationNumber = new System.Windows.Forms.Label();
            this.txtFormat_ReservationNumber = new System.Windows.Forms.TextBox();
            this.chkUse_PickupNumber = new System.Windows.Forms.CheckBox();
            this.chkUse_ReservationNumber = new System.Windows.Forms.CheckBox();
            this.txtFormat_PickupNumber = new System.Windows.Forms.TextBox();
            this.lblEquipmentNumber = new System.Windows.Forms.Label();
            this.lblPickupNumber = new System.Windows.Forms.Label();
            this.txtFormat_EquipmentNumber = new System.Windows.Forms.TextBox();
            this.chkUse_EquipmentNumber = new System.Windows.Forms.CheckBox();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtRentalCompany_Name = new System.Windows.Forms.TextBox();
            this.lblRentalCompany_Name = new System.Windows.Forms.Label();
            this.olvRentalCompanies = new BrightIdeasSoftware.ObjectListView();
            this.olcRentalCompany = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAccount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRentalCompanies_Control = new System.Windows.Forms.Panel();
            this.btnRentalCompany_Delete = new System.Windows.Forms.Button();
            this.btnRentalCompany_Edit = new System.Windows.Forms.Button();
            this.btnRentalCompany_Add = new System.Windows.Forms.Button();
            this.tabLiftTypes = new System.Windows.Forms.TabPage();
            this.pnlLiftType_Editor = new System.Windows.Forms.Panel();
            this.txtLiftType_Description = new System.Windows.Forms.TextBox();
            this.lblLiftType_Description = new System.Windows.Forms.Label();
            this.btnLiftType_Editor_Cancel = new System.Windows.Forms.Button();
            this.btnLiftType_Editor_Save = new System.Windows.Forms.Button();
            this.olvLiftTypes = new BrightIdeasSoftware.ObjectListView();
            this.olcLiftType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlLiftTypes_Control = new System.Windows.Forms.Panel();
            this.btnLiftType_Delete = new System.Windows.Forms.Button();
            this.btnLiftType_Edit = new System.Windows.Forms.Button();
            this.btnLiftType_Add = new System.Windows.Forms.Button();
            this.tabSalesPeople = new System.Windows.Forms.TabPage();
            this.olvSalespeople = new BrightIdeasSoftware.ObjectListView();
            this.olvColFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPhone_Office = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPhone_Mobile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlSalespeople_Control = new System.Windows.Forms.Panel();
            this.btnSalesperson_Edit = new System.Windows.Forms.Button();
            this.btnSalesperson_Remove = new System.Windows.Forms.Button();
            this.btnSalesperson_Add = new System.Windows.Forms.Button();
            this.tabShippingMethods = new System.Windows.Forms.TabPage();
            this.grpSymptoms = new System.Windows.Forms.GroupBox();
            this.olvShipmentMethods = new BrightIdeasSoftware.ObjectListView();
            this.olcDisplayIndex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAbbreviation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDefault = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlSymptoms_Control = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabSymptonsSolutions = new System.Windows.Forms.TabPage();
            this.pnlSymptoms = new System.Windows.Forms.Panel();
            this.olvSymptoms = new BrightIdeasSoftware.ObjectListView();
            this.olcSymptom_Symptom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcSymptom_IsVisible = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSymptoms_Edit = new System.Windows.Forms.Button();
            this.btnSymptoms_Remove = new System.Windows.Forms.Button();
            this.btnSymptoms_Add = new System.Windows.Forms.Button();
            this.lblOwnershipInformation = new System.Windows.Forms.Label();
            this.pnlSolutions = new System.Windows.Forms.Panel();
            this.olvSolutions = new BrightIdeasSoftware.ObjectListView();
            this.olvColSolutions_Solution = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSolutions_RequiresParts = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlSolutions_Control = new System.Windows.Forms.Panel();
            this.btnSolutions_Edit = new System.Windows.Forms.Button();
            this.btnSolutions_Remove = new System.Windows.Forms.Button();
            this.btnSolutions_Add = new System.Windows.Forms.Button();
            this.lblSolutions = new System.Windows.Forms.Label();
            this.tabPMA = new System.Windows.Forms.TabPage();
            this.pnlPMAs = new System.Windows.Forms.Panel();
            this.olvPMAs = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlPMAs_Control = new System.Windows.Forms.Panel();
            this.btnPMA_Edit = new System.Windows.Forms.Button();
            this.btnPMA_Remove = new System.Windows.Forms.Button();
            this.btnPMA_Add = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.pnlUser_Create = new System.Windows.Forms.Panel();
            this.radCreateUser_UserType_SSR = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radCreateUser_UserType_Moderator = new System.Windows.Forms.RadioButton();
            this.lblUser_Create = new System.Windows.Forms.Label();
            this.txtCreateUser_Password_Confirm = new System.Windows.Forms.TextBox();
            this.txtCreateUser_Login = new System.Windows.Forms.TextBox();
            this.lblCreateUser_Password_Confirm = new System.Windows.Forms.Label();
            this.lblCreateUser_FirstName = new System.Windows.Forms.Label();
            this.txtCreateUser_Password = new System.Windows.Forms.TextBox();
            this.lblCreateUser_Login = new System.Windows.Forms.Label();
            this.lblCreateUser_Password = new System.Windows.Forms.Label();
            this.lblCreateUser_LastName = new System.Windows.Forms.Label();
            this.radCreateUser_UserType_Administrator = new System.Windows.Forms.RadioButton();
            this.lblCreateUser_Email = new System.Windows.Forms.Label();
            this.radCreateUser_UserType_Standard = new System.Windows.Forms.RadioButton();
            this.txtCreateUser_FirstName = new System.Windows.Forms.TextBox();
            this.lblCreateUser_UserType = new System.Windows.Forms.Label();
            this.txtCreateUser_LastName = new System.Windows.Forms.TextBox();
            this.txtCreateUser_Email = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.pnlUser_Modify = new System.Windows.Forms.Panel();
            this.radModifyUser_UserType_SSR = new System.Windows.Forms.RadioButton();
            this.txtModifyUser_Pin_Confirm = new System.Windows.Forms.TextBox();
            this.lblModifyUser_Pin_Confirm = new System.Windows.Forms.Label();
            this.txtModifyUser_Pin = new System.Windows.Forms.TextBox();
            this.lblModifyUser_Pin = new System.Windows.Forms.Label();
            this.radModifyUser_DisableLogin = new System.Windows.Forms.CheckBox();
            this.lblUser_Modify = new System.Windows.Forms.Label();
            this.radModifyUser_UserType_Moderator = new System.Windows.Forms.RadioButton();
            this.cmbModifyUser_SelectUser = new System.Windows.Forms.ComboBox();
            this.radModifyUser_UserType_Administrator = new System.Windows.Forms.RadioButton();
            this.lblModifyUser_SelectUser = new System.Windows.Forms.Label();
            this.radModifyUser_UserType_Standard = new System.Windows.Forms.RadioButton();
            this.lblModifyUser_Password = new System.Windows.Forms.Label();
            this.lblModifyUser_UserType = new System.Windows.Forms.Label();
            this.txtModifyUser_Password = new System.Windows.Forms.TextBox();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.lblModifyUser_Password_Confirm = new System.Windows.Forms.Label();
            this.txtModifyUser_Password_Confirm = new System.Windows.Forms.TextBox();
            this.tabRMAFailures = new System.Windows.Forms.TabPage();
            this.grpRootCauses = new System.Windows.Forms.GroupBox();
            this.olvRootCauses = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRootCauses_Control = new System.Windows.Forms.Panel();
            this.btnRootCause_Remove = new System.Windows.Forms.Button();
            this.btnRootCause_Edit = new System.Windows.Forms.Button();
            this.btnRootCause_Add = new System.Windows.Forms.Button();
            this.grpRepairTypes = new System.Windows.Forms.GroupBox();
            this.olvRepairTypes = new BrightIdeasSoftware.ObjectListView();
            this.olvColRepairType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRepairTypes_Control = new System.Windows.Forms.Panel();
            this.btnRepairType_Remove = new System.Windows.Forms.Button();
            this.btnRepairType_Edit = new System.Windows.Forms.Button();
            this.btnRepairType_Add = new System.Windows.Forms.Button();
            this.grpFailureTypes = new System.Windows.Forms.GroupBox();
            this.olvFailureTypes = new BrightIdeasSoftware.ObjectListView();
            this.olvColFailureType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlFailureTypes_Control = new System.Windows.Forms.Panel();
            this.btnFailureType_Remove = new System.Windows.Forms.Button();
            this.btnFailureType_Edit = new System.Windows.Forms.Button();
            this.btnFailureType_Add = new System.Windows.Forms.Button();
            this.tabRmaComponents = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.olvComponents = new BrightIdeasSoftware.ObjectListView();
            this.olvColComponent_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColComponent_CompNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColComponent_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColComponent_Location = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColComponent_Cost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColComponent_InventoryQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEnableDisable = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblDivider = new System.Windows.Forms.Label();
            this.tabRMAAreasZones = new System.Windows.Forms.TabPage();
            this.pnlAreas = new System.Windows.Forms.Panel();
            this.olvRmaAreas = new BrightIdeasSoftware.ObjectListView();
            this.olcAreaName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlAreaControl = new System.Windows.Forms.Panel();
            this.btnRMAArea_Edit = new System.Windows.Forms.Button();
            this.btnRMAArea_Remove = new System.Windows.Forms.Button();
            this.btnRMAArea_Add = new System.Windows.Forms.Button();
            this.lblAreaInfo = new System.Windows.Forms.Label();
            this.pnlZones = new System.Windows.Forms.Panel();
            this.olvRmaZones = new BrightIdeasSoftware.ObjectListView();
            this.olcZone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlZoneControl = new System.Windows.Forms.Panel();
            this.btnRmaZone_SetDefault = new System.Windows.Forms.Button();
            this.btnRmaZone_PrintLabel = new System.Windows.Forms.Button();
            this.btnRmaZone_Edit = new System.Windows.Forms.Button();
            this.btnRmaZone_Remove = new System.Windows.Forms.Button();
            this.btnRmaZone_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabAdminEmails = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.olvAdminEmails = new BrightIdeasSoftware.ObjectListView();
            this.olvColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabOutputMethods.SuspendLayout();
            this.pnlOutputMethod_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvOutputMethods)).BeginInit();
            this.pnlOutputMethods_Control.SuspendLayout();
            this.tabCabinetTypes.SuspendLayout();
            this.pnlCabinetType_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCabinetTypes)).BeginInit();
            this.pnlCabinetTypes_Control.SuspendLayout();
            this.tabAssemblies.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).BeginInit();
            this.pnlAssembly_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTypes)).BeginInit();
            this.pnlTypes_Control.SuspendLayout();
            this.pnlAssemblyType_Bottom.SuspendLayout();
            this.pnlAssemblyType_BottomLeft.SuspendLayout();
            this.pnlType_BottomRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCategories)).BeginInit();
            this.pnlCategory_Control.SuspendLayout();
            this.pnlAssemblyCategory_Bottom.SuspendLayout();
            this.pnlAssemblyCategory_BottomLeft.SuspendLayout();
            this.pnlAssemblyCategory_BottomRight.SuspendLayout();
            this.tabCameras.SuspendLayout();
            this.pnlCameraTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCameraTypes)).BeginInit();
            this.pnlCameraTypes_Control.SuspendLayout();
            this.tabAssetTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTags)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabRentals.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRentalCompanies.SuspendLayout();
            this.pnlRentalCompany_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalDivisions)).BeginInit();
            this.pnlNumberFormats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalCompanies)).BeginInit();
            this.pnlRentalCompanies_Control.SuspendLayout();
            this.tabLiftTypes.SuspendLayout();
            this.pnlLiftType_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLiftTypes)).BeginInit();
            this.pnlLiftTypes_Control.SuspendLayout();
            this.tabSalesPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSalespeople)).BeginInit();
            this.pnlSalespeople_Control.SuspendLayout();
            this.tabShippingMethods.SuspendLayout();
            this.grpSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvShipmentMethods)).BeginInit();
            this.pnlSymptoms_Control.SuspendLayout();
            this.tabSymptonsSolutions.SuspendLayout();
            this.pnlSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlSolutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSolutions)).BeginInit();
            this.pnlSolutions_Control.SuspendLayout();
            this.tabPMA.SuspendLayout();
            this.pnlPMAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPMAs)).BeginInit();
            this.pnlPMAs_Control.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.pnlUser_Create.SuspendLayout();
            this.pnlUser_Modify.SuspendLayout();
            this.tabRMAFailures.SuspendLayout();
            this.grpRootCauses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRootCauses)).BeginInit();
            this.pnlRootCauses_Control.SuspendLayout();
            this.grpRepairTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepairTypes)).BeginInit();
            this.pnlRepairTypes_Control.SuspendLayout();
            this.grpFailureTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFailureTypes)).BeginInit();
            this.pnlFailureTypes_Control.SuspendLayout();
            this.tabRmaComponents.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvComponents)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.tabRMAAreasZones.SuspendLayout();
            this.pnlAreas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRmaAreas)).BeginInit();
            this.pnlAreaControl.SuspendLayout();
            this.pnlZones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRmaZones)).BeginInit();
            this.pnlZoneControl.SuspendLayout();
            this.tabAdminEmails.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAdminEmails)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOutputMethods);
            this.tabControl1.Controls.Add(this.tabCabinetTypes);
            this.tabControl1.Controls.Add(this.tabAssemblies);
            this.tabControl1.Controls.Add(this.tabCameras);
            this.tabControl1.Controls.Add(this.tabAssetTags);
            this.tabControl1.Controls.Add(this.tabRentals);
            this.tabControl1.Controls.Add(this.tabSalesPeople);
            this.tabControl1.Controls.Add(this.tabShippingMethods);
            this.tabControl1.Controls.Add(this.tabSymptonsSolutions);
            this.tabControl1.Controls.Add(this.tabPMA);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabRMAFailures);
            this.tabControl1.Controls.Add(this.tabRmaComponents);
            this.tabControl1.Controls.Add(this.tabRMAAreasZones);
            this.tabControl1.Controls.Add(this.tabAdminEmails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 954);
            this.tabControl1.TabIndex = 1;
            // 
            // tabOutputMethods
            // 
            this.tabOutputMethods.Controls.Add(this.pnlOutputMethod_Editor);
            this.tabOutputMethods.Controls.Add(this.olvOutputMethods);
            this.tabOutputMethods.Controls.Add(this.pnlOutputMethods_Control);
            this.tabOutputMethods.Location = new System.Drawing.Point(4, 22);
            this.tabOutputMethods.Name = "tabOutputMethods";
            this.tabOutputMethods.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutputMethods.Size = new System.Drawing.Size(1266, 928);
            this.tabOutputMethods.TabIndex = 0;
            this.tabOutputMethods.Text = "Output Methods";
            this.tabOutputMethods.UseVisualStyleBackColor = true;
            // 
            // pnlOutputMethod_Editor
            // 
            this.pnlOutputMethod_Editor.BackColor = System.Drawing.Color.LightGray;
            this.pnlOutputMethod_Editor.Controls.Add(this.btnOutputMethod_Editor_Cancel);
            this.pnlOutputMethod_Editor.Controls.Add(this.btnOutputMethod_Editor_Save);
            this.pnlOutputMethod_Editor.Controls.Add(this.txtOutputMethod_Description);
            this.pnlOutputMethod_Editor.Controls.Add(this.lblOutputMethod_Description);
            this.pnlOutputMethod_Editor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOutputMethod_Editor.Location = new System.Drawing.Point(3, 825);
            this.pnlOutputMethod_Editor.Name = "pnlOutputMethod_Editor";
            this.pnlOutputMethod_Editor.Size = new System.Drawing.Size(1260, 100);
            this.pnlOutputMethod_Editor.TabIndex = 1;
            this.pnlOutputMethod_Editor.Visible = false;
            // 
            // btnOutputMethod_Editor_Cancel
            // 
            this.btnOutputMethod_Editor_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputMethod_Editor_Cancel.Location = new System.Drawing.Point(1051, 74);
            this.btnOutputMethod_Editor_Cancel.Name = "btnOutputMethod_Editor_Cancel";
            this.btnOutputMethod_Editor_Cancel.Size = new System.Drawing.Size(100, 23);
            this.btnOutputMethod_Editor_Cancel.TabIndex = 10;
            this.btnOutputMethod_Editor_Cancel.Text = "Cancel";
            this.btnOutputMethod_Editor_Cancel.UseVisualStyleBackColor = true;
            this.btnOutputMethod_Editor_Cancel.Click += new System.EventHandler(this.btnOutputMethod_Editor_Cancel_Click);
            // 
            // btnOutputMethod_Editor_Save
            // 
            this.btnOutputMethod_Editor_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputMethod_Editor_Save.Location = new System.Drawing.Point(1157, 74);
            this.btnOutputMethod_Editor_Save.Name = "btnOutputMethod_Editor_Save";
            this.btnOutputMethod_Editor_Save.Size = new System.Drawing.Size(100, 23);
            this.btnOutputMethod_Editor_Save.TabIndex = 9;
            this.btnOutputMethod_Editor_Save.Text = "Save";
            this.btnOutputMethod_Editor_Save.UseVisualStyleBackColor = true;
            this.btnOutputMethod_Editor_Save.Click += new System.EventHandler(this.btnOutputMethod_Editor_Save_Click);
            // 
            // txtOutputMethod_Description
            // 
            this.txtOutputMethod_Description.Location = new System.Drawing.Point(94, 22);
            this.txtOutputMethod_Description.MaxLength = 45;
            this.txtOutputMethod_Description.Name = "txtOutputMethod_Description";
            this.txtOutputMethod_Description.Size = new System.Drawing.Size(189, 20);
            this.txtOutputMethod_Description.TabIndex = 1;
            this.txtOutputMethod_Description.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblOutputMethod_Description
            // 
            this.lblOutputMethod_Description.AutoSize = true;
            this.lblOutputMethod_Description.Location = new System.Drawing.Point(28, 25);
            this.lblOutputMethod_Description.Name = "lblOutputMethod_Description";
            this.lblOutputMethod_Description.Size = new System.Drawing.Size(60, 13);
            this.lblOutputMethod_Description.TabIndex = 0;
            this.lblOutputMethod_Description.Text = "Description";
            // 
            // olvOutputMethods
            // 
            this.olvOutputMethods.AllColumns.Add(this.olcOutputMethodDescription);
            this.olvOutputMethods.AllowColumnReorder = true;
            this.olvOutputMethods.CellEditUseWholeCell = false;
            this.olvOutputMethods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcOutputMethodDescription});
            this.olvOutputMethods.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvOutputMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvOutputMethods.EmptyListMsg = "No Output Methods";
            this.olvOutputMethods.FullRowSelect = true;
            this.olvOutputMethods.GridLines = true;
            this.olvOutputMethods.HideSelection = false;
            this.olvOutputMethods.Location = new System.Drawing.Point(3, 33);
            this.olvOutputMethods.MultiSelect = false;
            this.olvOutputMethods.Name = "olvOutputMethods";
            this.olvOutputMethods.SelectAllOnControlA = false;
            this.olvOutputMethods.ShowGroups = false;
            this.olvOutputMethods.Size = new System.Drawing.Size(1260, 892);
            this.olvOutputMethods.TabIndex = 0;
            this.olvOutputMethods.UseCompatibleStateImageBehavior = false;
            this.olvOutputMethods.UseOverlays = false;
            this.olvOutputMethods.View = System.Windows.Forms.View.Details;
            this.olvOutputMethods.SelectionChanged += new System.EventHandler(this.olvOutputMethods_SelectionChanged);
            this.olvOutputMethods.DoubleClick += new System.EventHandler(this.olvOutputMethods_DoubleClick);
            // 
            // olcOutputMethodDescription
            // 
            this.olcOutputMethodDescription.AspectName = "Description";
            this.olcOutputMethodDescription.Text = "Description";
            this.olcOutputMethodDescription.Width = 300;
            // 
            // pnlOutputMethods_Control
            // 
            this.pnlOutputMethods_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlOutputMethods_Control.Controls.Add(this.btnOutputMethod_Delete);
            this.pnlOutputMethods_Control.Controls.Add(this.btnOutputMethod_Edit);
            this.pnlOutputMethods_Control.Controls.Add(this.btnOutputMethod_Add);
            this.pnlOutputMethods_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOutputMethods_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlOutputMethods_Control.Name = "pnlOutputMethods_Control";
            this.pnlOutputMethods_Control.Size = new System.Drawing.Size(1260, 30);
            this.pnlOutputMethods_Control.TabIndex = 0;
            // 
            // btnOutputMethod_Delete
            // 
            this.btnOutputMethod_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOutputMethod_Delete.Location = new System.Drawing.Point(109, 4);
            this.btnOutputMethod_Delete.Name = "btnOutputMethod_Delete";
            this.btnOutputMethod_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnOutputMethod_Delete.TabIndex = 1;
            this.btnOutputMethod_Delete.Text = "Delete Method";
            this.btnOutputMethod_Delete.UseVisualStyleBackColor = false;
            this.btnOutputMethod_Delete.Click += new System.EventHandler(this.btnOutputMethod_Delete_Click);
            // 
            // btnOutputMethod_Edit
            // 
            this.btnOutputMethod_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnOutputMethod_Edit.Location = new System.Drawing.Point(215, 4);
            this.btnOutputMethod_Edit.Name = "btnOutputMethod_Edit";
            this.btnOutputMethod_Edit.Size = new System.Drawing.Size(100, 23);
            this.btnOutputMethod_Edit.TabIndex = 2;
            this.btnOutputMethod_Edit.Text = "Edit Method";
            this.btnOutputMethod_Edit.UseVisualStyleBackColor = false;
            this.btnOutputMethod_Edit.Click += new System.EventHandler(this.btnOutputMethod_Edit_Click);
            // 
            // btnOutputMethod_Add
            // 
            this.btnOutputMethod_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOutputMethod_Add.Location = new System.Drawing.Point(3, 4);
            this.btnOutputMethod_Add.Name = "btnOutputMethod_Add";
            this.btnOutputMethod_Add.Size = new System.Drawing.Size(100, 23);
            this.btnOutputMethod_Add.TabIndex = 0;
            this.btnOutputMethod_Add.Text = "Add Method";
            this.btnOutputMethod_Add.UseVisualStyleBackColor = false;
            // 
            // tabCabinetTypes
            // 
            this.tabCabinetTypes.Controls.Add(this.pnlCabinetType_Editor);
            this.tabCabinetTypes.Controls.Add(this.olvCabinetTypes);
            this.tabCabinetTypes.Controls.Add(this.pnlCabinetTypes_Control);
            this.tabCabinetTypes.Location = new System.Drawing.Point(4, 22);
            this.tabCabinetTypes.Name = "tabCabinetTypes";
            this.tabCabinetTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabCabinetTypes.Size = new System.Drawing.Size(1266, 928);
            this.tabCabinetTypes.TabIndex = 1;
            this.tabCabinetTypes.Text = "Cabinet Types";
            this.tabCabinetTypes.UseVisualStyleBackColor = true;
            // 
            // pnlCabinetType_Editor
            // 
            this.pnlCabinetType_Editor.BackColor = System.Drawing.Color.LightGray;
            this.pnlCabinetType_Editor.Controls.Add(this.txtCabinetType_Description);
            this.pnlCabinetType_Editor.Controls.Add(this.lblCabinetType_Description);
            this.pnlCabinetType_Editor.Controls.Add(this.btnCabinetType_Editor_Cancel);
            this.pnlCabinetType_Editor.Controls.Add(this.btnCabinetType_Editor_Save);
            this.pnlCabinetType_Editor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCabinetType_Editor.Location = new System.Drawing.Point(3, 825);
            this.pnlCabinetType_Editor.Name = "pnlCabinetType_Editor";
            this.pnlCabinetType_Editor.Size = new System.Drawing.Size(1260, 100);
            this.pnlCabinetType_Editor.TabIndex = 2;
            this.pnlCabinetType_Editor.Visible = false;
            // 
            // txtCabinetType_Description
            // 
            this.txtCabinetType_Description.Location = new System.Drawing.Point(94, 22);
            this.txtCabinetType_Description.MaxLength = 32;
            this.txtCabinetType_Description.Name = "txtCabinetType_Description";
            this.txtCabinetType_Description.Size = new System.Drawing.Size(189, 20);
            this.txtCabinetType_Description.TabIndex = 1;
            this.txtCabinetType_Description.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblCabinetType_Description
            // 
            this.lblCabinetType_Description.AutoSize = true;
            this.lblCabinetType_Description.Location = new System.Drawing.Point(28, 25);
            this.lblCabinetType_Description.Name = "lblCabinetType_Description";
            this.lblCabinetType_Description.Size = new System.Drawing.Size(60, 13);
            this.lblCabinetType_Description.TabIndex = 0;
            this.lblCabinetType_Description.Text = "Description";
            // 
            // btnCabinetType_Editor_Cancel
            // 
            this.btnCabinetType_Editor_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCabinetType_Editor_Cancel.Location = new System.Drawing.Point(1051, 74);
            this.btnCabinetType_Editor_Cancel.Name = "btnCabinetType_Editor_Cancel";
            this.btnCabinetType_Editor_Cancel.Size = new System.Drawing.Size(100, 23);
            this.btnCabinetType_Editor_Cancel.TabIndex = 3;
            this.btnCabinetType_Editor_Cancel.Text = "Cancel";
            this.btnCabinetType_Editor_Cancel.UseVisualStyleBackColor = true;
            this.btnCabinetType_Editor_Cancel.Click += new System.EventHandler(this.btnCabinetType_Editor_Cancel_Click);
            // 
            // btnCabinetType_Editor_Save
            // 
            this.btnCabinetType_Editor_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCabinetType_Editor_Save.Location = new System.Drawing.Point(1157, 74);
            this.btnCabinetType_Editor_Save.Name = "btnCabinetType_Editor_Save";
            this.btnCabinetType_Editor_Save.Size = new System.Drawing.Size(100, 23);
            this.btnCabinetType_Editor_Save.TabIndex = 2;
            this.btnCabinetType_Editor_Save.Text = "Save";
            this.btnCabinetType_Editor_Save.UseVisualStyleBackColor = true;
            this.btnCabinetType_Editor_Save.Click += new System.EventHandler(this.btnCabinetType_Editor_Save_Click);
            // 
            // olvCabinetTypes
            // 
            this.olvCabinetTypes.AllColumns.Add(this.olcCabinetType_Description);
            this.olvCabinetTypes.AllowColumnReorder = true;
            this.olvCabinetTypes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvCabinetTypes.CellEditUseWholeCell = false;
            this.olvCabinetTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcCabinetType_Description});
            this.olvCabinetTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCabinetTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvCabinetTypes.EmptyListMsg = "No Cabinet Types";
            this.olvCabinetTypes.FullRowSelect = true;
            this.olvCabinetTypes.GridLines = true;
            this.olvCabinetTypes.HideSelection = false;
            this.olvCabinetTypes.Location = new System.Drawing.Point(3, 33);
            this.olvCabinetTypes.MultiSelect = false;
            this.olvCabinetTypes.Name = "olvCabinetTypes";
            this.olvCabinetTypes.SelectAllOnControlA = false;
            this.olvCabinetTypes.ShowGroups = false;
            this.olvCabinetTypes.Size = new System.Drawing.Size(1260, 892);
            this.olvCabinetTypes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvCabinetTypes.TabIndex = 1;
            this.olvCabinetTypes.UseCompatibleStateImageBehavior = false;
            this.olvCabinetTypes.UseOverlays = false;
            this.olvCabinetTypes.View = System.Windows.Forms.View.Details;
            this.olvCabinetTypes.SelectionChanged += new System.EventHandler(this.olvCabinetTypes_SelectedIndexChanged);
            this.olvCabinetTypes.DoubleClick += new System.EventHandler(this.olvCabinetTypes_DoubleClick);
            // 
            // olcCabinetType_Description
            // 
            this.olcCabinetType_Description.AspectName = "Description";
            this.olcCabinetType_Description.Text = "Description";
            this.olcCabinetType_Description.Width = 300;
            // 
            // pnlCabinetTypes_Control
            // 
            this.pnlCabinetTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCabinetTypes_Control.Controls.Add(this.btnCabinetType_Delete);
            this.pnlCabinetTypes_Control.Controls.Add(this.btnCabinetType_Edit);
            this.pnlCabinetTypes_Control.Controls.Add(this.btnCabinetType_Add);
            this.pnlCabinetTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabinetTypes_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlCabinetTypes_Control.Name = "pnlCabinetTypes_Control";
            this.pnlCabinetTypes_Control.Size = new System.Drawing.Size(1260, 30);
            this.pnlCabinetTypes_Control.TabIndex = 0;
            // 
            // btnCabinetType_Delete
            // 
            this.btnCabinetType_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCabinetType_Delete.Location = new System.Drawing.Point(109, 4);
            this.btnCabinetType_Delete.Name = "btnCabinetType_Delete";
            this.btnCabinetType_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnCabinetType_Delete.TabIndex = 1;
            this.btnCabinetType_Delete.Text = "Delete Cabinet";
            this.btnCabinetType_Delete.UseVisualStyleBackColor = false;
            this.btnCabinetType_Delete.Click += new System.EventHandler(this.btnCabinetType_Delete_Click);
            // 
            // btnCabinetType_Edit
            // 
            this.btnCabinetType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnCabinetType_Edit.Location = new System.Drawing.Point(215, 4);
            this.btnCabinetType_Edit.Name = "btnCabinetType_Edit";
            this.btnCabinetType_Edit.Size = new System.Drawing.Size(100, 23);
            this.btnCabinetType_Edit.TabIndex = 2;
            this.btnCabinetType_Edit.Text = "Edit Cabinet";
            this.btnCabinetType_Edit.UseVisualStyleBackColor = false;
            this.btnCabinetType_Edit.Click += new System.EventHandler(this.btnCabinetType_Edit_Click);
            // 
            // btnCabinetType_Add
            // 
            this.btnCabinetType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCabinetType_Add.Location = new System.Drawing.Point(3, 4);
            this.btnCabinetType_Add.Name = "btnCabinetType_Add";
            this.btnCabinetType_Add.Size = new System.Drawing.Size(100, 23);
            this.btnCabinetType_Add.TabIndex = 0;
            this.btnCabinetType_Add.Text = "Add Cabinet";
            this.btnCabinetType_Add.UseVisualStyleBackColor = false;
            this.btnCabinetType_Add.Click += new System.EventHandler(this.btnCabinetType_Add_Click);
            // 
            // tabAssemblies
            // 
            this.tabAssemblies.Controls.Add(this.pnlContainer);
            this.tabAssemblies.Location = new System.Drawing.Point(4, 22);
            this.tabAssemblies.Name = "tabAssemblies";
            this.tabAssemblies.Size = new System.Drawing.Size(1266, 928);
            this.tabAssemblies.TabIndex = 2;
            this.tabAssemblies.Text = "Assemblies";
            this.tabAssemblies.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Controls.Add(this.olvAssemblies);
            this.pnlContainer.Controls.Add(this.pnlAssembly_Control);
            this.pnlContainer.Controls.Add(this.lblDivider1);
            this.pnlContainer.Controls.Add(this.olvTypes);
            this.pnlContainer.Controls.Add(this.pnlTypes_Control);
            this.pnlContainer.Controls.Add(this.lblDivider2);
            this.pnlContainer.Controls.Add(this.olvCategories);
            this.pnlContainer.Controls.Add(this.pnlCategory_Control);
            this.pnlContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1260, 922);
            this.pnlContainer.TabIndex = 6;
            // 
            // olvAssemblies
            // 
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_ID);
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_AssyNumber);
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_Description);
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_Location);
            this.olvAssemblies.AllColumns.Add(this.olvColCost);
            this.olvAssemblies.AllColumns.Add(this.olvColInventoryQty);
            this.olvAssemblies.CellEditTabChangesRows = true;
            this.olvAssemblies.CellEditUseWholeCell = false;
            this.olvAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColAssembly_ID,
            this.olvColAssembly_AssyNumber,
            this.olvColAssembly_Description,
            this.olvColAssembly_Location,
            this.olvColCost,
            this.olvColInventoryQty});
            this.olvAssemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAssemblies.EmptyListMsg = "No type selected.";
            this.olvAssemblies.FullRowSelect = true;
            this.olvAssemblies.GridLines = true;
            this.olvAssemblies.HasCollapsibleGroups = false;
            this.olvAssemblies.HideSelection = false;
            this.olvAssemblies.Location = new System.Drawing.Point(0, 552);
            this.olvAssemblies.MultiSelect = false;
            this.olvAssemblies.Name = "olvAssemblies";
            this.olvAssemblies.SelectAllOnControlA = false;
            this.olvAssemblies.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvAssemblies.ShowCommandMenuOnRightClick = true;
            this.olvAssemblies.ShowGroups = false;
            this.olvAssemblies.ShowItemCountOnGroups = true;
            this.olvAssemblies.Size = new System.Drawing.Size(1260, 370);
            this.olvAssemblies.SortGroupItemsByPrimaryColumn = false;
            this.olvAssemblies.TabIndex = 0;
            this.olvAssemblies.UseCompatibleStateImageBehavior = false;
            this.olvAssemblies.View = System.Windows.Forms.View.Details;
            this.olvAssemblies.SelectedIndexChanged += new System.EventHandler(this.olvAssemblies_SelectedIndexChanged);
            // 
            // olvColAssembly_ID
            // 
            this.olvColAssembly_ID.AspectName = "ID";
            this.olvColAssembly_ID.Groupable = false;
            this.olvColAssembly_ID.IsEditable = false;
            this.olvColAssembly_ID.IsVisible = false;
            this.olvColAssembly_ID.Searchable = false;
            this.olvColAssembly_ID.Sortable = false;
            this.olvColAssembly_ID.Text = "ID";
            this.olvColAssembly_ID.Width = 0;
            // 
            // olvColAssembly_AssyNumber
            // 
            this.olvColAssembly_AssyNumber.AspectName = "AssemblyNumber";
            this.olvColAssembly_AssyNumber.Groupable = false;
            this.olvColAssembly_AssyNumber.Hideable = false;
            this.olvColAssembly_AssyNumber.IsEditable = false;
            this.olvColAssembly_AssyNumber.Text = "Assembly #";
            this.olvColAssembly_AssyNumber.Width = 140;
            // 
            // olvColAssembly_Description
            // 
            this.olvColAssembly_Description.AspectName = "Description";
            this.olvColAssembly_Description.FillsFreeSpace = true;
            this.olvColAssembly_Description.Groupable = false;
            this.olvColAssembly_Description.Hideable = false;
            this.olvColAssembly_Description.IsEditable = false;
            this.olvColAssembly_Description.Text = "Description";
            this.olvColAssembly_Description.Width = 300;
            // 
            // olvColAssembly_Location
            // 
            this.olvColAssembly_Location.AspectName = "Location";
            this.olvColAssembly_Location.Hideable = false;
            this.olvColAssembly_Location.IsEditable = false;
            this.olvColAssembly_Location.Text = "Location";
            this.olvColAssembly_Location.Width = 70;
            // 
            // olvColCost
            // 
            this.olvColCost.AspectName = "Cost";
            this.olvColCost.AspectToStringFormat = "{0:0.00}";
            this.olvColCost.AutoCompleteEditor = false;
            this.olvColCost.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColCost.Groupable = false;
            this.olvColCost.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColCost.Hideable = false;
            this.olvColCost.IsEditable = false;
            this.olvColCost.Searchable = false;
            this.olvColCost.Text = "Cost";
            this.olvColCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColInventoryQty
            // 
            this.olvColInventoryQty.AspectName = "InventoryQty";
            this.olvColInventoryQty.AutoCompleteEditor = false;
            this.olvColInventoryQty.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColInventoryQty.Groupable = false;
            this.olvColInventoryQty.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColInventoryQty.Hideable = false;
            this.olvColInventoryQty.IsEditable = false;
            this.olvColInventoryQty.Searchable = false;
            this.olvColInventoryQty.Text = "Inv. Qty";
            this.olvColInventoryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlAssembly_Control
            // 
            this.pnlAssembly_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssembly_Control.Controls.Add(this.txtAssemblies_OfType);
            this.pnlAssembly_Control.Controls.Add(this.lblAssemblies_OfType);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_Edit);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_EnableDisable);
            this.pnlAssembly_Control.Controls.Add(this.lblAssembly_Qty);
            this.pnlAssembly_Control.Controls.Add(this.txtAssembly_Qty);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_Delete);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_Add);
            this.pnlAssembly_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssembly_Control.Location = new System.Drawing.Point(0, 502);
            this.pnlAssembly_Control.Name = "pnlAssembly_Control";
            this.pnlAssembly_Control.Size = new System.Drawing.Size(1260, 50);
            this.pnlAssembly_Control.TabIndex = 9;
            // 
            // txtAssemblies_OfType
            // 
            this.txtAssemblies_OfType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAssemblies_OfType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAssemblies_OfType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssemblies_OfType.Location = new System.Drawing.Point(125, 6);
            this.txtAssemblies_OfType.Name = "txtAssemblies_OfType";
            this.txtAssemblies_OfType.ReadOnly = true;
            this.txtAssemblies_OfType.Size = new System.Drawing.Size(532, 13);
            this.txtAssemblies_OfType.TabIndex = 14;
            this.txtAssemblies_OfType.TabStop = false;
            this.txtAssemblies_OfType.Text = "(None Selected)";
            // 
            // lblAssemblies_OfType
            // 
            this.lblAssemblies_OfType.AutoSize = true;
            this.lblAssemblies_OfType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblies_OfType.Location = new System.Drawing.Point(3, 6);
            this.lblAssemblies_OfType.Name = "lblAssemblies_OfType";
            this.lblAssemblies_OfType.Size = new System.Drawing.Size(73, 13);
            this.lblAssemblies_OfType.TabIndex = 13;
            this.lblAssemblies_OfType.Text = "Assemblies:";
            // 
            // btnAssembly_Edit
            // 
            this.btnAssembly_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnAssembly_Edit.Location = new System.Drawing.Point(387, 22);
            this.btnAssembly_Edit.Name = "btnAssembly_Edit";
            this.btnAssembly_Edit.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_Edit.TabIndex = 12;
            this.btnAssembly_Edit.Text = "Edit Assembly";
            this.btnAssembly_Edit.UseVisualStyleBackColor = false;
            this.btnAssembly_Edit.Click += new System.EventHandler(this.btnAssembly_Edit_Click);
            // 
            // btnAssembly_EnableDisable
            // 
            this.btnAssembly_EnableDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAssembly_EnableDisable.Location = new System.Drawing.Point(259, 22);
            this.btnAssembly_EnableDisable.Name = "btnAssembly_EnableDisable";
            this.btnAssembly_EnableDisable.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_EnableDisable.TabIndex = 11;
            this.btnAssembly_EnableDisable.Text = "Disable Assembly";
            this.btnAssembly_EnableDisable.UseVisualStyleBackColor = false;
            this.btnAssembly_EnableDisable.Click += new System.EventHandler(this.btnAssembly_EnableDisable_Click);
            // 
            // lblAssembly_Qty
            // 
            this.lblAssembly_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssembly_Qty.AutoSize = true;
            this.lblAssembly_Qty.Location = new System.Drawing.Point(1129, 27);
            this.lblAssembly_Qty.Name = "lblAssembly_Qty";
            this.lblAssembly_Qty.Size = new System.Drawing.Size(62, 13);
            this.lblAssembly_Qty.TabIndex = 9;
            this.lblAssembly_Qty.Text = "Assemblies:";
            // 
            // txtAssembly_Qty
            // 
            this.txtAssembly_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssembly_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssembly_Qty.Location = new System.Drawing.Point(1197, 22);
            this.txtAssembly_Qty.Name = "txtAssembly_Qty";
            this.txtAssembly_Qty.ReadOnly = true;
            this.txtAssembly_Qty.Size = new System.Drawing.Size(60, 22);
            this.txtAssembly_Qty.TabIndex = 10;
            this.txtAssembly_Qty.TabStop = false;
            // 
            // btnAssembly_Delete
            // 
            this.btnAssembly_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssembly_Delete.Location = new System.Drawing.Point(131, 22);
            this.btnAssembly_Delete.Name = "btnAssembly_Delete";
            this.btnAssembly_Delete.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_Delete.TabIndex = 1;
            this.btnAssembly_Delete.Text = "Delete Assembly";
            this.btnAssembly_Delete.UseVisualStyleBackColor = false;
            this.btnAssembly_Delete.Click += new System.EventHandler(this.btnAssembly_Delete_Click);
            // 
            // btnAssembly_Add
            // 
            this.btnAssembly_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssembly_Add.Location = new System.Drawing.Point(3, 22);
            this.btnAssembly_Add.Name = "btnAssembly_Add";
            this.btnAssembly_Add.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_Add.TabIndex = 0;
            this.btnAssembly_Add.Text = "Add &Assembly";
            this.btnAssembly_Add.UseVisualStyleBackColor = false;
            this.btnAssembly_Add.Click += new System.EventHandler(this.btnAssembly_Add_Click);
            // 
            // lblDivider1
            // 
            this.lblDivider1.BackColor = System.Drawing.Color.Black;
            this.lblDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDivider1.Location = new System.Drawing.Point(0, 501);
            this.lblDivider1.Name = "lblDivider1";
            this.lblDivider1.Size = new System.Drawing.Size(1260, 1);
            this.lblDivider1.TabIndex = 11;
            // 
            // olvTypes
            // 
            this.olvTypes.AllColumns.Add(this.olcType_ID);
            this.olvTypes.AllColumns.Add(this.olcType_Description);
            this.olvTypes.AllColumns.Add(this.olcType_SerialNumberFormat);
            this.olvTypes.AllColumns.Add(this.olcType_IsComputer);
            this.olvTypes.AllColumns.Add(this.olcType_AllowDiscard);
            this.olvTypes.AllColumns.Add(this.olcCustomsDescription);
            this.olvTypes.AllColumns.Add(this.olcTariffCode);
            this.olvTypes.CellEditTabChangesRows = true;
            this.olvTypes.CellEditUseWholeCell = false;
            this.olvTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcType_ID,
            this.olcType_Description,
            this.olcType_SerialNumberFormat,
            this.olcType_IsComputer,
            this.olcType_AllowDiscard,
            this.olcCustomsDescription,
            this.olcTariffCode});
            this.olvTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvTypes.EmptyListMsg = "No category selected.";
            this.olvTypes.FullRowSelect = true;
            this.olvTypes.GridLines = true;
            this.olvTypes.HasCollapsibleGroups = false;
            this.olvTypes.HideSelection = false;
            this.olvTypes.Location = new System.Drawing.Point(0, 301);
            this.olvTypes.MultiSelect = false;
            this.olvTypes.Name = "olvTypes";
            this.olvTypes.SelectAllOnControlA = false;
            this.olvTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvTypes.ShowCommandMenuOnRightClick = true;
            this.olvTypes.ShowGroups = false;
            this.olvTypes.ShowItemCountOnGroups = true;
            this.olvTypes.Size = new System.Drawing.Size(1260, 200);
            this.olvTypes.SortGroupItemsByPrimaryColumn = false;
            this.olvTypes.TabIndex = 10;
            this.olvTypes.UseCompatibleStateImageBehavior = false;
            this.olvTypes.View = System.Windows.Forms.View.Details;
            this.olvTypes.SelectedIndexChanged += new System.EventHandler(this.olvTypes_SelectedIndexChanged);
            // 
            // olcType_ID
            // 
            this.olcType_ID.AspectName = "ID";
            this.olcType_ID.Groupable = false;
            this.olcType_ID.IsEditable = false;
            this.olcType_ID.IsVisible = false;
            this.olcType_ID.Searchable = false;
            this.olcType_ID.Sortable = false;
            this.olcType_ID.Text = "ID";
            this.olcType_ID.Width = 0;
            // 
            // olcType_Description
            // 
            this.olcType_Description.AspectName = "Description";
            this.olcType_Description.FillsFreeSpace = true;
            this.olcType_Description.Groupable = false;
            this.olcType_Description.Hideable = false;
            this.olcType_Description.IsEditable = false;
            this.olcType_Description.Text = "Description";
            this.olcType_Description.Width = 380;
            // 
            // olcType_SerialNumberFormat
            // 
            this.olcType_SerialNumberFormat.AspectName = "SerialNumberFormat";
            this.olcType_SerialNumberFormat.Text = "SN Format";
            this.olcType_SerialNumberFormat.Width = 100;
            // 
            // olcType_IsComputer
            // 
            this.olcType_IsComputer.AspectName = "IsComputer";
            this.olcType_IsComputer.IsEditable = false;
            this.olcType_IsComputer.Text = "Req. Prep";
            this.olcType_IsComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcType_IsComputer.ToolTipText = "Requires preparation before shipping.";
            this.olcType_IsComputer.Width = 68;
            // 
            // olcType_AllowDiscard
            // 
            this.olcType_AllowDiscard.AspectName = "AllowDiscard";
            this.olcType_AllowDiscard.IsEditable = false;
            this.olcType_AllowDiscard.Text = "Discardable";
            this.olcType_AllowDiscard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcType_AllowDiscard.ToolTipText = "Is allowed to be discarded when creating RMA.";
            this.olcType_AllowDiscard.Width = 68;
            // 
            // olcCustomsDescription
            // 
            this.olcCustomsDescription.AspectName = "CustomsDescription";
            this.olcCustomsDescription.Text = "Customs Description";
            this.olcCustomsDescription.ToolTipText = "Brief description for customs purposes during import/export.";
            this.olcCustomsDescription.Width = 150;
            // 
            // olcTariffCode
            // 
            this.olcTariffCode.AspectName = "TariffCode";
            this.olcTariffCode.Text = "Tariff Code";
            this.olcTariffCode.ToolTipText = "Harmonized tariff code for import/export during shipping.";
            this.olcTariffCode.Width = 70;
            // 
            // pnlTypes_Control
            // 
            this.pnlTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTypes_Control.Controls.Add(this.txtTypes_OfCategory);
            this.pnlTypes_Control.Controls.Add(this.label2);
            this.pnlTypes_Control.Controls.Add(this.pnlAssemblyType_Bottom);
            this.pnlTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTypes_Control.Location = new System.Drawing.Point(0, 251);
            this.pnlTypes_Control.Name = "pnlTypes_Control";
            this.pnlTypes_Control.Size = new System.Drawing.Size(1260, 50);
            this.pnlTypes_Control.TabIndex = 8;
            // 
            // txtTypes_OfCategory
            // 
            this.txtTypes_OfCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTypes_OfCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypes_OfCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypes_OfCategory.Location = new System.Drawing.Point(125, 6);
            this.txtTypes_OfCategory.Name = "txtTypes_OfCategory";
            this.txtTypes_OfCategory.ReadOnly = true;
            this.txtTypes_OfCategory.Size = new System.Drawing.Size(532, 13);
            this.txtTypes_OfCategory.TabIndex = 15;
            this.txtTypes_OfCategory.TabStop = false;
            this.txtTypes_OfCategory.Text = "(None Selected)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Types:";
            // 
            // pnlAssemblyType_Bottom
            // 
            this.pnlAssemblyType_Bottom.Controls.Add(this.pnlAssemblyType_BottomLeft);
            this.pnlAssemblyType_Bottom.Controls.Add(this.pnlType_BottomRight);
            this.pnlAssemblyType_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssemblyType_Bottom.Location = new System.Drawing.Point(0, 20);
            this.pnlAssemblyType_Bottom.Name = "pnlAssemblyType_Bottom";
            this.pnlAssemblyType_Bottom.Size = new System.Drawing.Size(1260, 30);
            this.pnlAssemblyType_Bottom.TabIndex = 11;
            // 
            // pnlAssemblyType_BottomLeft
            // 
            this.pnlAssemblyType_BottomLeft.Controls.Add(this.btnType_Edit);
            this.pnlAssemblyType_BottomLeft.Controls.Add(this.btnType_Delete);
            this.pnlAssemblyType_BottomLeft.Controls.Add(this.btnType_Add);
            this.pnlAssemblyType_BottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssemblyType_BottomLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlAssemblyType_BottomLeft.Name = "pnlAssemblyType_BottomLeft";
            this.pnlAssemblyType_BottomLeft.Size = new System.Drawing.Size(1120, 30);
            this.pnlAssemblyType_BottomLeft.TabIndex = 9;
            // 
            // btnType_Edit
            // 
            this.btnType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnType_Edit.Location = new System.Drawing.Point(259, 4);
            this.btnType_Edit.Name = "btnType_Edit";
            this.btnType_Edit.Size = new System.Drawing.Size(120, 23);
            this.btnType_Edit.TabIndex = 2;
            this.btnType_Edit.Text = "Edit Type";
            this.btnType_Edit.UseVisualStyleBackColor = false;
            this.btnType_Edit.Click += new System.EventHandler(this.btnTypes_Edit_Click);
            // 
            // btnType_Delete
            // 
            this.btnType_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnType_Delete.Location = new System.Drawing.Point(131, 4);
            this.btnType_Delete.Name = "btnType_Delete";
            this.btnType_Delete.Size = new System.Drawing.Size(120, 23);
            this.btnType_Delete.TabIndex = 1;
            this.btnType_Delete.Text = "Delete Type";
            this.btnType_Delete.UseVisualStyleBackColor = false;
            this.btnType_Delete.Click += new System.EventHandler(this.btnTypes_Delete_Click);
            // 
            // btnType_Add
            // 
            this.btnType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnType_Add.Location = new System.Drawing.Point(3, 4);
            this.btnType_Add.Name = "btnType_Add";
            this.btnType_Add.Size = new System.Drawing.Size(120, 23);
            this.btnType_Add.TabIndex = 0;
            this.btnType_Add.Text = "Add &Type";
            this.btnType_Add.UseVisualStyleBackColor = false;
            this.btnType_Add.Click += new System.EventHandler(this.btnTypes_Add_Click);
            // 
            // pnlType_BottomRight
            // 
            this.pnlType_BottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlType_BottomRight.Controls.Add(this.lblType_Qty);
            this.pnlType_BottomRight.Controls.Add(this.txtType_Qty);
            this.pnlType_BottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlType_BottomRight.Location = new System.Drawing.Point(1120, 0);
            this.pnlType_BottomRight.Name = "pnlType_BottomRight";
            this.pnlType_BottomRight.Size = new System.Drawing.Size(140, 30);
            this.pnlType_BottomRight.TabIndex = 10;
            // 
            // lblType_Qty
            // 
            this.lblType_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType_Qty.AutoSize = true;
            this.lblType_Qty.Location = new System.Drawing.Point(32, 9);
            this.lblType_Qty.Name = "lblType_Qty";
            this.lblType_Qty.Size = new System.Drawing.Size(39, 13);
            this.lblType_Qty.TabIndex = 7;
            this.lblType_Qty.Text = "Types:";
            // 
            // txtType_Qty
            // 
            this.txtType_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType_Qty.Location = new System.Drawing.Point(77, 4);
            this.txtType_Qty.Name = "txtType_Qty";
            this.txtType_Qty.ReadOnly = true;
            this.txtType_Qty.Size = new System.Drawing.Size(60, 22);
            this.txtType_Qty.TabIndex = 8;
            this.txtType_Qty.TabStop = false;
            // 
            // lblDivider2
            // 
            this.lblDivider2.BackColor = System.Drawing.Color.Black;
            this.lblDivider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDivider2.Location = new System.Drawing.Point(0, 250);
            this.lblDivider2.Name = "lblDivider2";
            this.lblDivider2.Size = new System.Drawing.Size(1260, 1);
            this.lblDivider2.TabIndex = 12;
            // 
            // olvCategories
            // 
            this.olvCategories.AllColumns.Add(this.olcCategory_ID);
            this.olvCategories.AllColumns.Add(this.olcCategory_Description);
            this.olvCategories.CellEditUseWholeCell = false;
            this.olvCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcCategory_ID,
            this.olcCategory_Description});
            this.olvCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvCategories.EmptyListMsg = "No categories defined.";
            this.olvCategories.FullRowSelect = true;
            this.olvCategories.GridLines = true;
            this.olvCategories.HasCollapsibleGroups = false;
            this.olvCategories.HideSelection = false;
            this.olvCategories.Location = new System.Drawing.Point(0, 50);
            this.olvCategories.MultiSelect = false;
            this.olvCategories.Name = "olvCategories";
            this.olvCategories.SelectAllOnControlA = false;
            this.olvCategories.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvCategories.ShowCommandMenuOnRightClick = true;
            this.olvCategories.ShowGroups = false;
            this.olvCategories.ShowItemCountOnGroups = true;
            this.olvCategories.Size = new System.Drawing.Size(1260, 200);
            this.olvCategories.SortGroupItemsByPrimaryColumn = false;
            this.olvCategories.TabIndex = 0;
            this.olvCategories.UseCompatibleStateImageBehavior = false;
            this.olvCategories.View = System.Windows.Forms.View.Details;
            this.olvCategories.SelectedIndexChanged += new System.EventHandler(this.olvCategories_SelectedIndexChanged);
            // 
            // olcCategory_ID
            // 
            this.olcCategory_ID.AspectName = "ID";
            this.olcCategory_ID.Groupable = false;
            this.olcCategory_ID.IsEditable = false;
            this.olcCategory_ID.IsVisible = false;
            this.olcCategory_ID.Sortable = false;
            this.olcCategory_ID.Width = 0;
            // 
            // olcCategory_Description
            // 
            this.olcCategory_Description.AspectName = "Description";
            this.olcCategory_Description.Text = "Description";
            this.olcCategory_Description.Width = 380;
            // 
            // pnlCategory_Control
            // 
            this.pnlCategory_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCategory_Control.Controls.Add(this.pnlAssemblyCategory_Bottom);
            this.pnlCategory_Control.Controls.Add(this.lblAssemblyCategories);
            this.pnlCategory_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory_Control.Name = "pnlCategory_Control";
            this.pnlCategory_Control.Size = new System.Drawing.Size(1260, 50);
            this.pnlCategory_Control.TabIndex = 11;
            // 
            // pnlAssemblyCategory_Bottom
            // 
            this.pnlAssemblyCategory_Bottom.Controls.Add(this.pnlAssemblyCategory_BottomLeft);
            this.pnlAssemblyCategory_Bottom.Controls.Add(this.pnlAssemblyCategory_BottomRight);
            this.pnlAssemblyCategory_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssemblyCategory_Bottom.Location = new System.Drawing.Point(0, 20);
            this.pnlAssemblyCategory_Bottom.Name = "pnlAssemblyCategory_Bottom";
            this.pnlAssemblyCategory_Bottom.Size = new System.Drawing.Size(1260, 30);
            this.pnlAssemblyCategory_Bottom.TabIndex = 15;
            // 
            // pnlAssemblyCategory_BottomLeft
            // 
            this.pnlAssemblyCategory_BottomLeft.Controls.Add(this.btnCategory_Edit);
            this.pnlAssemblyCategory_BottomLeft.Controls.Add(this.btnCategory_Delete);
            this.pnlAssemblyCategory_BottomLeft.Controls.Add(this.btnCategory_Add);
            this.pnlAssemblyCategory_BottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssemblyCategory_BottomLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlAssemblyCategory_BottomLeft.Name = "pnlAssemblyCategory_BottomLeft";
            this.pnlAssemblyCategory_BottomLeft.Size = new System.Drawing.Size(1120, 30);
            this.pnlAssemblyCategory_BottomLeft.TabIndex = 9;
            // 
            // btnCategory_Edit
            // 
            this.btnCategory_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnCategory_Edit.Location = new System.Drawing.Point(259, 4);
            this.btnCategory_Edit.Name = "btnCategory_Edit";
            this.btnCategory_Edit.Size = new System.Drawing.Size(120, 23);
            this.btnCategory_Edit.TabIndex = 2;
            this.btnCategory_Edit.Text = "Edit Category";
            this.btnCategory_Edit.UseVisualStyleBackColor = false;
            this.btnCategory_Edit.Click += new System.EventHandler(this.btnCategory_Edit_Click);
            // 
            // btnCategory_Delete
            // 
            this.btnCategory_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCategory_Delete.Location = new System.Drawing.Point(131, 4);
            this.btnCategory_Delete.Name = "btnCategory_Delete";
            this.btnCategory_Delete.Size = new System.Drawing.Size(120, 23);
            this.btnCategory_Delete.TabIndex = 1;
            this.btnCategory_Delete.Text = "Delete Category";
            this.btnCategory_Delete.UseVisualStyleBackColor = false;
            this.btnCategory_Delete.Click += new System.EventHandler(this.btnCategory_Delete_Click);
            // 
            // btnCategory_Add
            // 
            this.btnCategory_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCategory_Add.Location = new System.Drawing.Point(3, 4);
            this.btnCategory_Add.Name = "btnCategory_Add";
            this.btnCategory_Add.Size = new System.Drawing.Size(120, 23);
            this.btnCategory_Add.TabIndex = 0;
            this.btnCategory_Add.Text = "Add &Category";
            this.btnCategory_Add.UseVisualStyleBackColor = false;
            this.btnCategory_Add.Click += new System.EventHandler(this.btnCategory_Add_Click);
            // 
            // pnlAssemblyCategory_BottomRight
            // 
            this.pnlAssemblyCategory_BottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssemblyCategory_BottomRight.Controls.Add(this.lblCategory_Qty);
            this.pnlAssemblyCategory_BottomRight.Controls.Add(this.txtCategory_Qty);
            this.pnlAssemblyCategory_BottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAssemblyCategory_BottomRight.Location = new System.Drawing.Point(1120, 0);
            this.pnlAssemblyCategory_BottomRight.Name = "pnlAssemblyCategory_BottomRight";
            this.pnlAssemblyCategory_BottomRight.Size = new System.Drawing.Size(140, 30);
            this.pnlAssemblyCategory_BottomRight.TabIndex = 10;
            // 
            // lblCategory_Qty
            // 
            this.lblCategory_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory_Qty.AutoSize = true;
            this.lblCategory_Qty.Location = new System.Drawing.Point(11, 9);
            this.lblCategory_Qty.Name = "lblCategory_Qty";
            this.lblCategory_Qty.Size = new System.Drawing.Size(60, 13);
            this.lblCategory_Qty.TabIndex = 7;
            this.lblCategory_Qty.Text = "Categories:";
            // 
            // txtCategory_Qty
            // 
            this.txtCategory_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory_Qty.Location = new System.Drawing.Point(77, 4);
            this.txtCategory_Qty.Name = "txtCategory_Qty";
            this.txtCategory_Qty.ReadOnly = true;
            this.txtCategory_Qty.Size = new System.Drawing.Size(60, 22);
            this.txtCategory_Qty.TabIndex = 8;
            this.txtCategory_Qty.TabStop = false;
            // 
            // lblAssemblyCategories
            // 
            this.lblAssemblyCategories.AutoSize = true;
            this.lblAssemblyCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyCategories.Location = new System.Drawing.Point(3, 6);
            this.lblAssemblyCategories.Name = "lblAssemblyCategories";
            this.lblAssemblyCategories.Size = new System.Drawing.Size(71, 13);
            this.lblAssemblyCategories.TabIndex = 14;
            this.lblAssemblyCategories.Text = "Categories:";
            // 
            // tabCameras
            // 
            this.tabCameras.Controls.Add(this.pnlCameraTypes);
            this.tabCameras.Location = new System.Drawing.Point(4, 22);
            this.tabCameras.Name = "tabCameras";
            this.tabCameras.Size = new System.Drawing.Size(1266, 928);
            this.tabCameras.TabIndex = 3;
            this.tabCameras.Text = "Cameras";
            this.tabCameras.UseVisualStyleBackColor = true;
            // 
            // pnlCameraTypes
            // 
            this.pnlCameraTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCameraTypes.Controls.Add(this.olvCameraTypes);
            this.pnlCameraTypes.Controls.Add(this.pnlCameraTypes_Control);
            this.pnlCameraTypes.Location = new System.Drawing.Point(3, 3);
            this.pnlCameraTypes.Name = "pnlCameraTypes";
            this.pnlCameraTypes.Size = new System.Drawing.Size(1263, 925);
            this.pnlCameraTypes.TabIndex = 3;
            // 
            // olvCameraTypes
            // 
            this.olvCameraTypes.AllColumns.Add(this.olvColDescription);
            this.olvCameraTypes.CellEditUseWholeCell = false;
            this.olvCameraTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColDescription});
            this.olvCameraTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCameraTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvCameraTypes.FullRowSelect = true;
            this.olvCameraTypes.GridLines = true;
            this.olvCameraTypes.HasCollapsibleGroups = false;
            this.olvCameraTypes.Location = new System.Drawing.Point(0, 30);
            this.olvCameraTypes.MultiSelect = false;
            this.olvCameraTypes.Name = "olvCameraTypes";
            this.olvCameraTypes.SelectAllOnControlA = false;
            this.olvCameraTypes.SelectColumnsOnRightClick = false;
            this.olvCameraTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvCameraTypes.ShowFilterMenuOnRightClick = false;
            this.olvCameraTypes.ShowGroups = false;
            this.olvCameraTypes.ShowImagesOnSubItems = true;
            this.olvCameraTypes.Size = new System.Drawing.Size(1263, 895);
            this.olvCameraTypes.TabIndex = 1;
            this.olvCameraTypes.UseCompatibleStateImageBehavior = false;
            this.olvCameraTypes.View = System.Windows.Forms.View.Details;
            this.olvCameraTypes.SelectedIndexChanged += new System.EventHandler(this.olvCameraTypes_SelectedIndexChanged);
            this.olvCameraTypes.DoubleClick += new System.EventHandler(this.olvCameraTypes_DoubleClick);
            // 
            // olvColDescription
            // 
            this.olvColDescription.AspectName = "Description";
            this.olvColDescription.Text = "Description";
            this.olvColDescription.Width = 280;
            // 
            // pnlCameraTypes_Control
            // 
            this.pnlCameraTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Edit);
            this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Remove);
            this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Add);
            this.pnlCameraTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCameraTypes_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlCameraTypes_Control.Name = "pnlCameraTypes_Control";
            this.pnlCameraTypes_Control.Size = new System.Drawing.Size(1263, 30);
            this.pnlCameraTypes_Control.TabIndex = 0;
            // 
            // btnCameraType_Edit
            // 
            this.btnCameraType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnCameraType_Edit.Location = new System.Drawing.Point(175, 3);
            this.btnCameraType_Edit.Name = "btnCameraType_Edit";
            this.btnCameraType_Edit.Size = new System.Drawing.Size(80, 23);
            this.btnCameraType_Edit.TabIndex = 2;
            this.btnCameraType_Edit.Text = "Edit";
            this.btnCameraType_Edit.UseVisualStyleBackColor = false;
            this.btnCameraType_Edit.Click += new System.EventHandler(this.btnCameraType_Edit_Click);
            // 
            // btnCameraType_Remove
            // 
            this.btnCameraType_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCameraType_Remove.Location = new System.Drawing.Point(89, 3);
            this.btnCameraType_Remove.Name = "btnCameraType_Remove";
            this.btnCameraType_Remove.Size = new System.Drawing.Size(80, 23);
            this.btnCameraType_Remove.TabIndex = 1;
            this.btnCameraType_Remove.Text = "Remove";
            this.btnCameraType_Remove.UseVisualStyleBackColor = false;
            this.btnCameraType_Remove.Click += new System.EventHandler(this.btnCameraType_Remove_Click);
            // 
            // btnCameraType_Add
            // 
            this.btnCameraType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCameraType_Add.Location = new System.Drawing.Point(3, 3);
            this.btnCameraType_Add.Name = "btnCameraType_Add";
            this.btnCameraType_Add.Size = new System.Drawing.Size(80, 23);
            this.btnCameraType_Add.TabIndex = 0;
            this.btnCameraType_Add.Text = "Add";
            this.btnCameraType_Add.UseVisualStyleBackColor = false;
            this.btnCameraType_Add.Click += new System.EventHandler(this.btnCameraType_Add_Click);
            // 
            // tabAssetTags
            // 
            this.tabAssetTags.Controls.Add(this.olvTags);
            this.tabAssetTags.Controls.Add(this.panel1);
            this.tabAssetTags.Location = new System.Drawing.Point(4, 22);
            this.tabAssetTags.Name = "tabAssetTags";
            this.tabAssetTags.Size = new System.Drawing.Size(1266, 928);
            this.tabAssetTags.TabIndex = 4;
            this.tabAssetTags.Text = "Asset Tags";
            this.tabAssetTags.UseVisualStyleBackColor = true;
            // 
            // olvTags
            // 
            this.olvTags.AllColumns.Add(this.olvColTags);
            this.olvTags.AllColumns.Add(this.olvColDesciption);
            this.olvTags.CellEditUseWholeCell = false;
            this.olvTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTags,
            this.olvColDesciption});
            this.olvTags.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTags.FullRowSelect = true;
            this.olvTags.GridLines = true;
            this.olvTags.HasCollapsibleGroups = false;
            this.olvTags.Location = new System.Drawing.Point(0, 0);
            this.olvTags.MultiSelect = false;
            this.olvTags.Name = "olvTags";
            this.olvTags.SelectAllOnControlA = false;
            this.olvTags.SelectColumnsOnRightClick = false;
            this.olvTags.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvTags.ShowFilterMenuOnRightClick = false;
            this.olvTags.ShowGroups = false;
            this.olvTags.ShowImagesOnSubItems = true;
            this.olvTags.Size = new System.Drawing.Size(1266, 891);
            this.olvTags.TabIndex = 8;
            this.olvTags.UseCompatibleStateImageBehavior = false;
            this.olvTags.View = System.Windows.Forms.View.Details;
            // 
            // olvColTags
            // 
            this.olvColTags.AspectName = "Tag";
            this.olvColTags.Text = "Tags";
            this.olvColTags.Width = 105;
            // 
            // olvColDesciption
            // 
            this.olvColDesciption.AspectName = "Description";
            this.olvColDesciption.Text = "Description";
            this.olvColDesciption.Width = 1159;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnAssetTag_Edit);
            this.panel1.Controls.Add(this.btnAssetTag_Remove);
            this.panel1.Controls.Add(this.btnAssetTag_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 891);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 37);
            this.panel1.TabIndex = 7;
            // 
            // btnAssetTag_Edit
            // 
            this.btnAssetTag_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnAssetTag_Edit.Location = new System.Drawing.Point(175, 3);
            this.btnAssetTag_Edit.Name = "btnAssetTag_Edit";
            this.btnAssetTag_Edit.Size = new System.Drawing.Size(80, 23);
            this.btnAssetTag_Edit.TabIndex = 2;
            this.btnAssetTag_Edit.Text = "Edit";
            this.btnAssetTag_Edit.UseVisualStyleBackColor = false;
            this.btnAssetTag_Edit.Click += new System.EventHandler(this.btnAssetTag_Edit_Click);
            // 
            // btnAssetTag_Remove
            // 
            this.btnAssetTag_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssetTag_Remove.Location = new System.Drawing.Point(89, 3);
            this.btnAssetTag_Remove.Name = "btnAssetTag_Remove";
            this.btnAssetTag_Remove.Size = new System.Drawing.Size(80, 23);
            this.btnAssetTag_Remove.TabIndex = 1;
            this.btnAssetTag_Remove.Text = "Remove";
            this.btnAssetTag_Remove.UseVisualStyleBackColor = false;
            this.btnAssetTag_Remove.Click += new System.EventHandler(this.btnAssetTag_Remove_Click);
            // 
            // btnAssetTag_Add
            // 
            this.btnAssetTag_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssetTag_Add.Location = new System.Drawing.Point(3, 3);
            this.btnAssetTag_Add.Name = "btnAssetTag_Add";
            this.btnAssetTag_Add.Size = new System.Drawing.Size(80, 23);
            this.btnAssetTag_Add.TabIndex = 0;
            this.btnAssetTag_Add.Text = "Add";
            this.btnAssetTag_Add.UseVisualStyleBackColor = false;
            this.btnAssetTag_Add.Click += new System.EventHandler(this.btnAssetTag_Add_Click);
            // 
            // tabRentals
            // 
            this.tabRentals.Controls.Add(this.tabControl2);
            this.tabRentals.Location = new System.Drawing.Point(4, 22);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Size = new System.Drawing.Size(1266, 928);
            this.tabRentals.TabIndex = 5;
            this.tabRentals.Text = "Rentals";
            this.tabRentals.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRentalCompanies);
            this.tabControl2.Controls.Add(this.tabLiftTypes);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1266, 928);
            this.tabControl2.TabIndex = 1;
            // 
            // tabRentalCompanies
            // 
            this.tabRentalCompanies.Controls.Add(this.pnlRentalCompany_Editor);
            this.tabRentalCompanies.Controls.Add(this.olvRentalCompanies);
            this.tabRentalCompanies.Controls.Add(this.pnlRentalCompanies_Control);
            this.tabRentalCompanies.Location = new System.Drawing.Point(4, 22);
            this.tabRentalCompanies.Name = "tabRentalCompanies";
            this.tabRentalCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentalCompanies.Size = new System.Drawing.Size(1258, 902);
            this.tabRentalCompanies.TabIndex = 0;
            this.tabRentalCompanies.Text = "Rental Companies";
            this.tabRentalCompanies.UseVisualStyleBackColor = true;
            // 
            // pnlRentalCompany_Editor
            // 
            this.pnlRentalCompany_Editor.BackColor = System.Drawing.Color.LightGray;
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalDivision_Delete);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblDivisionEditHelp);
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalDivision_Add);
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalCompany_Editor_Cancel);
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalCompany_Editor_Save);
            this.pnlRentalCompany_Editor.Controls.Add(this.olvRentalDivisions);
            this.pnlRentalCompany_Editor.Controls.Add(this.pnlNumberFormats);
            this.pnlRentalCompany_Editor.Controls.Add(this.txtTelephoneNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblTelephoneNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.txtAccountNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblAccountNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.txtRentalCompany_Name);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblRentalCompany_Name);
            this.pnlRentalCompany_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentalCompany_Editor.Location = new System.Drawing.Point(3, 33);
            this.pnlRentalCompany_Editor.Name = "pnlRentalCompany_Editor";
            this.pnlRentalCompany_Editor.Size = new System.Drawing.Size(1252, 866);
            this.pnlRentalCompany_Editor.TabIndex = 1;
            this.pnlRentalCompany_Editor.Visible = false;
            // 
            // btnRentalDivision_Delete
            // 
            this.btnRentalDivision_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRentalDivision_Delete.Location = new System.Drawing.Point(109, 98);
            this.btnRentalDivision_Delete.Name = "btnRentalDivision_Delete";
            this.btnRentalDivision_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnRentalDivision_Delete.TabIndex = 8;
            this.btnRentalDivision_Delete.Text = "Delete Division";
            this.btnRentalDivision_Delete.UseVisualStyleBackColor = false;
            this.btnRentalDivision_Delete.Click += new System.EventHandler(this.btnRentalDivision_Delete_Click);
            // 
            // lblDivisionEditHelp
            // 
            this.lblDivisionEditHelp.AutoSize = true;
            this.lblDivisionEditHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisionEditHelp.Location = new System.Drawing.Point(493, 504);
            this.lblDivisionEditHelp.Name = "lblDivisionEditHelp";
            this.lblDivisionEditHelp.Size = new System.Drawing.Size(250, 13);
            this.lblDivisionEditHelp.TabIndex = 12;
            this.lblDivisionEditHelp.Text = "Double-click or press F2 to edit Division information.";
            // 
            // btnRentalDivision_Add
            // 
            this.btnRentalDivision_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRentalDivision_Add.Location = new System.Drawing.Point(3, 98);
            this.btnRentalDivision_Add.Name = "btnRentalDivision_Add";
            this.btnRentalDivision_Add.Size = new System.Drawing.Size(100, 23);
            this.btnRentalDivision_Add.TabIndex = 7;
            this.btnRentalDivision_Add.Text = "Add Division";
            this.btnRentalDivision_Add.UseVisualStyleBackColor = false;
            this.btnRentalDivision_Add.Click += new System.EventHandler(this.btnRentalDivision_Add_Click);
            // 
            // btnRentalCompany_Editor_Cancel
            // 
            this.btnRentalCompany_Editor_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentalCompany_Editor_Cancel.Location = new System.Drawing.Point(1043, 840);
            this.btnRentalCompany_Editor_Cancel.Name = "btnRentalCompany_Editor_Cancel";
            this.btnRentalCompany_Editor_Cancel.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Editor_Cancel.TabIndex = 11;
            this.btnRentalCompany_Editor_Cancel.Text = "Cancel";
            this.btnRentalCompany_Editor_Cancel.UseVisualStyleBackColor = true;
            // 
            // btnRentalCompany_Editor_Save
            // 
            this.btnRentalCompany_Editor_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentalCompany_Editor_Save.Location = new System.Drawing.Point(1149, 840);
            this.btnRentalCompany_Editor_Save.Name = "btnRentalCompany_Editor_Save";
            this.btnRentalCompany_Editor_Save.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Editor_Save.TabIndex = 10;
            this.btnRentalCompany_Editor_Save.Text = "Save";
            this.btnRentalCompany_Editor_Save.UseVisualStyleBackColor = true;
            // 
            // olvRentalDivisions
            // 
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionName);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionAddress);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionCity);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionState);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionZip);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionCountry);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionTelephone);
            this.olvRentalDivisions.AllowColumnReorder = true;
            this.olvRentalDivisions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvRentalDivisions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvRentalDivisions.CellEditUseWholeCell = false;
            this.olvRentalDivisions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcDivisionName,
            this.olcDivisionAddress,
            this.olcDivisionCity,
            this.olcDivisionState,
            this.olcDivisionZip,
            this.olcDivisionCountry,
            this.olcDivisionTelephone});
            this.olvRentalDivisions.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRentalDivisions.EmptyListMsg = "No divisions.";
            this.olvRentalDivisions.FullRowSelect = true;
            this.olvRentalDivisions.GridLines = true;
            this.olvRentalDivisions.HideSelection = false;
            this.olvRentalDivisions.Location = new System.Drawing.Point(3, 127);
            this.olvRentalDivisions.MultiSelect = false;
            this.olvRentalDivisions.Name = "olvRentalDivisions";
            this.olvRentalDivisions.SelectAllOnControlA = false;
            this.olvRentalDivisions.ShowGroups = false;
            this.olvRentalDivisions.Size = new System.Drawing.Size(1246, 707);
            this.olvRentalDivisions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvRentalDivisions.TabIndex = 9;
            this.olvRentalDivisions.UseCompatibleStateImageBehavior = false;
            this.olvRentalDivisions.UseOverlays = false;
            this.olvRentalDivisions.View = System.Windows.Forms.View.Details;
            // 
            // olcDivisionName
            // 
            this.olcDivisionName.AspectName = "Name";
            this.olcDivisionName.Text = "Division";
            this.olcDivisionName.Width = 150;
            // 
            // olcDivisionAddress
            // 
            this.olcDivisionAddress.AspectName = "Address";
            this.olcDivisionAddress.Text = "Address";
            this.olcDivisionAddress.Width = 140;
            // 
            // olcDivisionCity
            // 
            this.olcDivisionCity.AspectName = "City";
            this.olcDivisionCity.Text = "City";
            this.olcDivisionCity.Width = 100;
            // 
            // olcDivisionState
            // 
            this.olcDivisionState.AspectName = "State";
            this.olcDivisionState.Text = "State";
            // 
            // olcDivisionZip
            // 
            this.olcDivisionZip.AspectName = "Zip";
            this.olcDivisionZip.Text = "Zip";
            this.olcDivisionZip.Width = 75;
            // 
            // olcDivisionCountry
            // 
            this.olcDivisionCountry.AspectName = "Country";
            this.olcDivisionCountry.Text = "Country";
            this.olcDivisionCountry.Width = 100;
            // 
            // olcDivisionTelephone
            // 
            this.olcDivisionTelephone.AspectName = "Telephone";
            this.olcDivisionTelephone.Text = "Telephone";
            this.olcDivisionTelephone.Width = 100;
            // 
            // pnlNumberFormats
            // 
            this.pnlNumberFormats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNumberFormats.Controls.Add(this.lblFormat_PickupNumber);
            this.pnlNumberFormats.Controls.Add(this.lblNumberFormatHelp);
            this.pnlNumberFormats.Controls.Add(this.lblFormat_EquipmentNumber);
            this.pnlNumberFormats.Controls.Add(this.lblReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.lblFormat_ReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.txtFormat_ReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.chkUse_PickupNumber);
            this.pnlNumberFormats.Controls.Add(this.chkUse_ReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.txtFormat_PickupNumber);
            this.pnlNumberFormats.Controls.Add(this.lblEquipmentNumber);
            this.pnlNumberFormats.Controls.Add(this.lblPickupNumber);
            this.pnlNumberFormats.Controls.Add(this.txtFormat_EquipmentNumber);
            this.pnlNumberFormats.Controls.Add(this.chkUse_EquipmentNumber);
            this.pnlNumberFormats.Location = new System.Drawing.Point(282, 6);
            this.pnlNumberFormats.Name = "pnlNumberFormats";
            this.pnlNumberFormats.Size = new System.Drawing.Size(490, 98);
            this.pnlNumberFormats.TabIndex = 6;
            // 
            // lblFormat_PickupNumber
            // 
            this.lblFormat_PickupNumber.AutoSize = true;
            this.lblFormat_PickupNumber.Enabled = false;
            this.lblFormat_PickupNumber.Location = new System.Drawing.Point(248, 42);
            this.lblFormat_PickupNumber.Name = "lblFormat_PickupNumber";
            this.lblFormat_PickupNumber.Size = new System.Drawing.Size(39, 13);
            this.lblFormat_PickupNumber.TabIndex = 10;
            this.lblFormat_PickupNumber.Text = "Format";
            // 
            // lblNumberFormatHelp
            // 
            this.lblNumberFormatHelp.AutoSize = true;
            this.lblNumberFormatHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumberFormatHelp.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberFormatHelp.Location = new System.Drawing.Point(379, 0);
            this.lblNumberFormatHelp.Name = "lblNumberFormatHelp";
            this.lblNumberFormatHelp.Size = new System.Drawing.Size(109, 91);
            this.lblNumberFormatHelp.TabIndex = 12;
            this.lblNumberFormatHelp.Text = "# = Number\r\nX = Letter\r\n* = Any Character\r\n. = Period\r\n- = Hyphen\r\n? = No Validat" +
    "ion\r\nSpaces as-is.";
            // 
            // lblFormat_EquipmentNumber
            // 
            this.lblFormat_EquipmentNumber.AutoSize = true;
            this.lblFormat_EquipmentNumber.Enabled = false;
            this.lblFormat_EquipmentNumber.Location = new System.Drawing.Point(124, 42);
            this.lblFormat_EquipmentNumber.Name = "lblFormat_EquipmentNumber";
            this.lblFormat_EquipmentNumber.Size = new System.Drawing.Size(39, 13);
            this.lblFormat_EquipmentNumber.TabIndex = 6;
            this.lblFormat_EquipmentNumber.Text = "Format";
            // 
            // lblReservationNumber
            // 
            this.lblReservationNumber.AutoSize = true;
            this.lblReservationNumber.Location = new System.Drawing.Point(3, 6);
            this.lblReservationNumber.Name = "lblReservationNumber";
            this.lblReservationNumber.Size = new System.Drawing.Size(104, 13);
            this.lblReservationNumber.TabIndex = 0;
            this.lblReservationNumber.Text = "Reservation Number";
            // 
            // lblFormat_ReservationNumber
            // 
            this.lblFormat_ReservationNumber.AutoSize = true;
            this.lblFormat_ReservationNumber.Enabled = false;
            this.lblFormat_ReservationNumber.Location = new System.Drawing.Point(3, 42);
            this.lblFormat_ReservationNumber.Name = "lblFormat_ReservationNumber";
            this.lblFormat_ReservationNumber.Size = new System.Drawing.Size(39, 13);
            this.lblFormat_ReservationNumber.TabIndex = 2;
            this.lblFormat_ReservationNumber.Text = "Format";
            // 
            // txtFormat_ReservationNumber
            // 
            this.txtFormat_ReservationNumber.Enabled = false;
            this.txtFormat_ReservationNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat_ReservationNumber.Location = new System.Drawing.Point(3, 58);
            this.txtFormat_ReservationNumber.MaxLength = 16;
            this.txtFormat_ReservationNumber.Name = "txtFormat_ReservationNumber";
            this.txtFormat_ReservationNumber.Size = new System.Drawing.Size(118, 23);
            this.txtFormat_ReservationNumber.TabIndex = 3;
            // 
            // chkUse_PickupNumber
            // 
            this.chkUse_PickupNumber.AutoSize = true;
            this.chkUse_PickupNumber.Location = new System.Drawing.Point(251, 22);
            this.chkUse_PickupNumber.Name = "chkUse_PickupNumber";
            this.chkUse_PickupNumber.Size = new System.Drawing.Size(45, 17);
            this.chkUse_PickupNumber.TabIndex = 9;
            this.chkUse_PickupNumber.Text = "Use";
            this.chkUse_PickupNumber.UseVisualStyleBackColor = true;
            this.chkUse_PickupNumber.Click += new System.EventHandler(this.chkUse_PickupNumber_CheckedChanged);
            // 
            // chkUse_ReservationNumber
            // 
            this.chkUse_ReservationNumber.AutoSize = true;
            this.chkUse_ReservationNumber.Location = new System.Drawing.Point(6, 22);
            this.chkUse_ReservationNumber.Name = "chkUse_ReservationNumber";
            this.chkUse_ReservationNumber.Size = new System.Drawing.Size(45, 17);
            this.chkUse_ReservationNumber.TabIndex = 1;
            this.chkUse_ReservationNumber.Text = "Use";
            this.chkUse_ReservationNumber.UseVisualStyleBackColor = true;
            this.chkUse_ReservationNumber.Click += new System.EventHandler(this.chkUse_ReservationNumber_CheckedChanged);
            // 
            // txtFormat_PickupNumber
            // 
            this.txtFormat_PickupNumber.Enabled = false;
            this.txtFormat_PickupNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat_PickupNumber.Location = new System.Drawing.Point(251, 58);
            this.txtFormat_PickupNumber.MaxLength = 16;
            this.txtFormat_PickupNumber.Name = "txtFormat_PickupNumber";
            this.txtFormat_PickupNumber.Size = new System.Drawing.Size(118, 23);
            this.txtFormat_PickupNumber.TabIndex = 11;
            // 
            // lblEquipmentNumber
            // 
            this.lblEquipmentNumber.AutoSize = true;
            this.lblEquipmentNumber.Location = new System.Drawing.Point(124, 6);
            this.lblEquipmentNumber.Name = "lblEquipmentNumber";
            this.lblEquipmentNumber.Size = new System.Drawing.Size(97, 13);
            this.lblEquipmentNumber.TabIndex = 4;
            this.lblEquipmentNumber.Text = "Equipment Number";
            // 
            // lblPickupNumber
            // 
            this.lblPickupNumber.AutoSize = true;
            this.lblPickupNumber.Location = new System.Drawing.Point(248, 6);
            this.lblPickupNumber.Name = "lblPickupNumber";
            this.lblPickupNumber.Size = new System.Drawing.Size(83, 13);
            this.lblPickupNumber.TabIndex = 8;
            this.lblPickupNumber.Text = "Pick-up Number";
            // 
            // txtFormat_EquipmentNumber
            // 
            this.txtFormat_EquipmentNumber.Enabled = false;
            this.txtFormat_EquipmentNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat_EquipmentNumber.Location = new System.Drawing.Point(127, 58);
            this.txtFormat_EquipmentNumber.MaxLength = 16;
            this.txtFormat_EquipmentNumber.Name = "txtFormat_EquipmentNumber";
            this.txtFormat_EquipmentNumber.Size = new System.Drawing.Size(118, 23);
            this.txtFormat_EquipmentNumber.TabIndex = 7;
            // 
            // chkUse_EquipmentNumber
            // 
            this.chkUse_EquipmentNumber.AutoSize = true;
            this.chkUse_EquipmentNumber.Location = new System.Drawing.Point(127, 22);
            this.chkUse_EquipmentNumber.Name = "chkUse_EquipmentNumber";
            this.chkUse_EquipmentNumber.Size = new System.Drawing.Size(45, 17);
            this.chkUse_EquipmentNumber.TabIndex = 5;
            this.chkUse_EquipmentNumber.Text = "Use";
            this.chkUse_EquipmentNumber.UseVisualStyleBackColor = true;
            this.chkUse_EquipmentNumber.Click += new System.EventHandler(this.chkUse_EquipmentNumber_CheckedChanged);
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(142, 58);
            this.txtTelephoneNumber.MaxLength = 20;
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(116, 20);
            this.txtTelephoneNumber.TabIndex = 5;
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(12, 61);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(124, 13);
            this.lblTelephoneNumber.TabIndex = 4;
            this.lblTelephoneNumber.Text = "Main Telephone Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(142, 32);
            this.txtAccountNumber.MaxLength = 20;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(116, 20);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 35);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(107, 13);
            this.lblAccountNumber.TabIndex = 2;
            this.lblAccountNumber.Text = "Account #";
            // 
            // txtRentalCompany_Name
            // 
            this.txtRentalCompany_Name.Location = new System.Drawing.Point(69, 6);
            this.txtRentalCompany_Name.MaxLength = 45;
            this.txtRentalCompany_Name.Name = "txtRentalCompany_Name";
            this.txtRentalCompany_Name.Size = new System.Drawing.Size(189, 20);
            this.txtRentalCompany_Name.TabIndex = 1;
            // 
            // lblRentalCompany_Name
            // 
            this.lblRentalCompany_Name.AutoSize = true;
            this.lblRentalCompany_Name.Location = new System.Drawing.Point(12, 9);
            this.lblRentalCompany_Name.Name = "lblRentalCompany_Name";
            this.lblRentalCompany_Name.Size = new System.Drawing.Size(51, 13);
            this.lblRentalCompany_Name.TabIndex = 0;
            this.lblRentalCompany_Name.Text = "Company";
            // 
            // olvRentalCompanies
            // 
            this.olvRentalCompanies.AllColumns.Add(this.olcRentalCompany);
            this.olvRentalCompanies.AllColumns.Add(this.olcAccount);
            this.olvRentalCompanies.AllColumns.Add(this.olcTelephone);
            this.olvRentalCompanies.AllowColumnReorder = true;
            this.olvRentalCompanies.CellEditUseWholeCell = false;
            this.olvRentalCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcRentalCompany,
            this.olcAccount,
            this.olcTelephone});
            this.olvRentalCompanies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRentalCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRentalCompanies.EmptyListMsg = "No rental companies.";
            this.olvRentalCompanies.FullRowSelect = true;
            this.olvRentalCompanies.GridLines = true;
            this.olvRentalCompanies.HideSelection = false;
            this.olvRentalCompanies.Location = new System.Drawing.Point(3, 33);
            this.olvRentalCompanies.MultiSelect = false;
            this.olvRentalCompanies.Name = "olvRentalCompanies";
            this.olvRentalCompanies.SelectAllOnControlA = false;
            this.olvRentalCompanies.ShowGroups = false;
            this.olvRentalCompanies.Size = new System.Drawing.Size(1252, 866);
            this.olvRentalCompanies.TabIndex = 0;
            this.olvRentalCompanies.UseCompatibleStateImageBehavior = false;
            this.olvRentalCompanies.UseOverlays = false;
            this.olvRentalCompanies.View = System.Windows.Forms.View.Details;
            // 
            // olcRentalCompany
            // 
            this.olcRentalCompany.AspectName = "Company";
            this.olcRentalCompany.Text = "Rental Company";
            this.olcRentalCompany.Width = 300;
            // 
            // olcAccount
            // 
            this.olcAccount.AspectName = "AccountNumber";
            this.olcAccount.Text = "Account";
            this.olcAccount.Width = 100;
            // 
            // olcTelephone
            // 
            this.olcTelephone.AspectName = "Telephone";
            this.olcTelephone.Text = "Telephone";
            this.olcTelephone.Width = 100;
            // 
            // pnlRentalCompanies_Control
            // 
            this.pnlRentalCompanies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRentalCompanies_Control.Controls.Add(this.btnRentalCompany_Delete);
            this.pnlRentalCompanies_Control.Controls.Add(this.btnRentalCompany_Edit);
            this.pnlRentalCompanies_Control.Controls.Add(this.btnRentalCompany_Add);
            this.pnlRentalCompanies_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRentalCompanies_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlRentalCompanies_Control.Name = "pnlRentalCompanies_Control";
            this.pnlRentalCompanies_Control.Size = new System.Drawing.Size(1252, 30);
            this.pnlRentalCompanies_Control.TabIndex = 0;
            // 
            // btnRentalCompany_Delete
            // 
            this.btnRentalCompany_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRentalCompany_Delete.Location = new System.Drawing.Point(109, 4);
            this.btnRentalCompany_Delete.Name = "btnRentalCompany_Delete";
            this.btnRentalCompany_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Delete.TabIndex = 1;
            this.btnRentalCompany_Delete.Text = "Delete Company";
            this.btnRentalCompany_Delete.UseVisualStyleBackColor = false;
            this.btnRentalCompany_Delete.Click += new System.EventHandler(this.btnRentalCompany_Delete_Click);
            // 
            // btnRentalCompany_Edit
            // 
            this.btnRentalCompany_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnRentalCompany_Edit.Location = new System.Drawing.Point(215, 4);
            this.btnRentalCompany_Edit.Name = "btnRentalCompany_Edit";
            this.btnRentalCompany_Edit.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Edit.TabIndex = 2;
            this.btnRentalCompany_Edit.Text = "Edit Company";
            this.btnRentalCompany_Edit.UseVisualStyleBackColor = false;
            this.btnRentalCompany_Edit.Click += new System.EventHandler(this.btnRentalCompany_Edit_Click);
            // 
            // btnRentalCompany_Add
            // 
            this.btnRentalCompany_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRentalCompany_Add.Location = new System.Drawing.Point(3, 4);
            this.btnRentalCompany_Add.Name = "btnRentalCompany_Add";
            this.btnRentalCompany_Add.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Add.TabIndex = 0;
            this.btnRentalCompany_Add.Text = "Add Company";
            this.btnRentalCompany_Add.UseVisualStyleBackColor = false;
            this.btnRentalCompany_Add.Click += new System.EventHandler(this.btnRentalCompany_Add_Click);
            // 
            // tabLiftTypes
            // 
            this.tabLiftTypes.Controls.Add(this.pnlLiftType_Editor);
            this.tabLiftTypes.Controls.Add(this.olvLiftTypes);
            this.tabLiftTypes.Controls.Add(this.pnlLiftTypes_Control);
            this.tabLiftTypes.Location = new System.Drawing.Point(4, 22);
            this.tabLiftTypes.Name = "tabLiftTypes";
            this.tabLiftTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiftTypes.Size = new System.Drawing.Size(1258, 902);
            this.tabLiftTypes.TabIndex = 1;
            this.tabLiftTypes.Text = "Lift Types";
            this.tabLiftTypes.UseVisualStyleBackColor = true;
            // 
            // pnlLiftType_Editor
            // 
            this.pnlLiftType_Editor.BackColor = System.Drawing.Color.LightGray;
            this.pnlLiftType_Editor.Controls.Add(this.txtLiftType_Description);
            this.pnlLiftType_Editor.Controls.Add(this.lblLiftType_Description);
            this.pnlLiftType_Editor.Controls.Add(this.btnLiftType_Editor_Cancel);
            this.pnlLiftType_Editor.Controls.Add(this.btnLiftType_Editor_Save);
            this.pnlLiftType_Editor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLiftType_Editor.Location = new System.Drawing.Point(3, 799);
            this.pnlLiftType_Editor.Name = "pnlLiftType_Editor";
            this.pnlLiftType_Editor.Size = new System.Drawing.Size(1252, 100);
            this.pnlLiftType_Editor.TabIndex = 2;
            this.pnlLiftType_Editor.Visible = false;
            // 
            // txtLiftType_Description
            // 
            this.txtLiftType_Description.Location = new System.Drawing.Point(94, 22);
            this.txtLiftType_Description.MaxLength = 32;
            this.txtLiftType_Description.Name = "txtLiftType_Description";
            this.txtLiftType_Description.Size = new System.Drawing.Size(189, 20);
            this.txtLiftType_Description.TabIndex = 1;
            // 
            // lblLiftType_Description
            // 
            this.lblLiftType_Description.AutoSize = true;
            this.lblLiftType_Description.Location = new System.Drawing.Point(28, 25);
            this.lblLiftType_Description.Name = "lblLiftType_Description";
            this.lblLiftType_Description.Size = new System.Drawing.Size(60, 13);
            this.lblLiftType_Description.TabIndex = 0;
            this.lblLiftType_Description.Text = "Description";
            // 
            // btnLiftType_Editor_Cancel
            // 
            this.btnLiftType_Editor_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiftType_Editor_Cancel.Location = new System.Drawing.Point(1043, 74);
            this.btnLiftType_Editor_Cancel.Name = "btnLiftType_Editor_Cancel";
            this.btnLiftType_Editor_Cancel.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Editor_Cancel.TabIndex = 3;
            this.btnLiftType_Editor_Cancel.Text = "Cancel";
            this.btnLiftType_Editor_Cancel.UseVisualStyleBackColor = true;
            // 
            // btnLiftType_Editor_Save
            // 
            this.btnLiftType_Editor_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiftType_Editor_Save.Location = new System.Drawing.Point(1149, 74);
            this.btnLiftType_Editor_Save.Name = "btnLiftType_Editor_Save";
            this.btnLiftType_Editor_Save.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Editor_Save.TabIndex = 2;
            this.btnLiftType_Editor_Save.Text = "Save";
            this.btnLiftType_Editor_Save.UseVisualStyleBackColor = true;
            // 
            // olvLiftTypes
            // 
            this.olvLiftTypes.AllColumns.Add(this.olcLiftType_Description);
            this.olvLiftTypes.AllowColumnReorder = true;
            this.olvLiftTypes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvLiftTypes.CellEditUseWholeCell = false;
            this.olvLiftTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcLiftType_Description});
            this.olvLiftTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvLiftTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvLiftTypes.EmptyListMsg = "No lift types.";
            this.olvLiftTypes.FullRowSelect = true;
            this.olvLiftTypes.GridLines = true;
            this.olvLiftTypes.HideSelection = false;
            this.olvLiftTypes.Location = new System.Drawing.Point(3, 33);
            this.olvLiftTypes.MultiSelect = false;
            this.olvLiftTypes.Name = "olvLiftTypes";
            this.olvLiftTypes.SelectAllOnControlA = false;
            this.olvLiftTypes.ShowGroups = false;
            this.olvLiftTypes.Size = new System.Drawing.Size(1252, 866);
            this.olvLiftTypes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvLiftTypes.TabIndex = 1;
            this.olvLiftTypes.UseCompatibleStateImageBehavior = false;
            this.olvLiftTypes.UseOverlays = false;
            this.olvLiftTypes.View = System.Windows.Forms.View.Details;
            // 
            // olcLiftType_Description
            // 
            this.olcLiftType_Description.AspectName = "Description";
            this.olcLiftType_Description.Text = "Description";
            this.olcLiftType_Description.Width = 300;
            // 
            // pnlLiftTypes_Control
            // 
            this.pnlLiftTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlLiftTypes_Control.Controls.Add(this.btnLiftType_Delete);
            this.pnlLiftTypes_Control.Controls.Add(this.btnLiftType_Edit);
            this.pnlLiftTypes_Control.Controls.Add(this.btnLiftType_Add);
            this.pnlLiftTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLiftTypes_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlLiftTypes_Control.Name = "pnlLiftTypes_Control";
            this.pnlLiftTypes_Control.Size = new System.Drawing.Size(1252, 30);
            this.pnlLiftTypes_Control.TabIndex = 0;
            // 
            // btnLiftType_Delete
            // 
            this.btnLiftType_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLiftType_Delete.Location = new System.Drawing.Point(109, 4);
            this.btnLiftType_Delete.Name = "btnLiftType_Delete";
            this.btnLiftType_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Delete.TabIndex = 1;
            this.btnLiftType_Delete.Text = "Delete Lift Type";
            this.btnLiftType_Delete.UseVisualStyleBackColor = false;
            // 
            // btnLiftType_Edit
            // 
            this.btnLiftType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnLiftType_Edit.Location = new System.Drawing.Point(215, 4);
            this.btnLiftType_Edit.Name = "btnLiftType_Edit";
            this.btnLiftType_Edit.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Edit.TabIndex = 2;
            this.btnLiftType_Edit.Text = "Edit Lift Type";
            this.btnLiftType_Edit.UseVisualStyleBackColor = false;
            // 
            // btnLiftType_Add
            // 
            this.btnLiftType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLiftType_Add.Location = new System.Drawing.Point(3, 4);
            this.btnLiftType_Add.Name = "btnLiftType_Add";
            this.btnLiftType_Add.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Add.TabIndex = 0;
            this.btnLiftType_Add.Text = "Add Lift Type";
            this.btnLiftType_Add.UseVisualStyleBackColor = false;
            // 
            // tabSalesPeople
            // 
            this.tabSalesPeople.Controls.Add(this.olvSalespeople);
            this.tabSalesPeople.Controls.Add(this.pnlSalespeople_Control);
            this.tabSalesPeople.Location = new System.Drawing.Point(4, 22);
            this.tabSalesPeople.Name = "tabSalesPeople";
            this.tabSalesPeople.Size = new System.Drawing.Size(1266, 928);
            this.tabSalesPeople.TabIndex = 6;
            this.tabSalesPeople.Text = "Sales People";
            this.tabSalesPeople.UseVisualStyleBackColor = true;
            // 
            // olvSalespeople
            // 
            this.olvSalespeople.AllColumns.Add(this.olvColFirstName);
            this.olvSalespeople.AllColumns.Add(this.olvColLastName);
            this.olvSalespeople.AllColumns.Add(this.olvColAddress);
            this.olvSalespeople.AllColumns.Add(this.olvColCity);
            this.olvSalespeople.AllColumns.Add(this.olvColState);
            this.olvSalespeople.AllColumns.Add(this.olvColZip);
            this.olvSalespeople.AllColumns.Add(this.olvColCountry);
            this.olvSalespeople.AllColumns.Add(this.olvColEmail);
            this.olvSalespeople.AllColumns.Add(this.olvColPhone_Office);
            this.olvSalespeople.AllColumns.Add(this.olvColPhone_Mobile);
            this.olvSalespeople.CellEditUseWholeCell = false;
            this.olvSalespeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColFirstName,
            this.olvColLastName,
            this.olvColAddress,
            this.olvColCity,
            this.olvColState,
            this.olvColZip,
            this.olvColCountry,
            this.olvColEmail,
            this.olvColPhone_Office,
            this.olvColPhone_Mobile});
            this.olvSalespeople.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSalespeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvSalespeople.FullRowSelect = true;
            this.olvSalespeople.GridLines = true;
            this.olvSalespeople.HasCollapsibleGroups = false;
            this.olvSalespeople.Location = new System.Drawing.Point(0, 30);
            this.olvSalespeople.MultiSelect = false;
            this.olvSalespeople.Name = "olvSalespeople";
            this.olvSalespeople.SelectAllOnControlA = false;
            this.olvSalespeople.SelectColumnsOnRightClick = false;
            this.olvSalespeople.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvSalespeople.ShowFilterMenuOnRightClick = false;
            this.olvSalespeople.ShowGroups = false;
            this.olvSalespeople.ShowImagesOnSubItems = true;
            this.olvSalespeople.Size = new System.Drawing.Size(1266, 898);
            this.olvSalespeople.TabIndex = 2;
            this.olvSalespeople.UseCompatibleStateImageBehavior = false;
            this.olvSalespeople.View = System.Windows.Forms.View.Details;
            // 
            // olvColFirstName
            // 
            this.olvColFirstName.AspectName = "FirstName";
            this.olvColFirstName.Text = "First Name";
            this.olvColFirstName.Width = 120;
            // 
            // olvColLastName
            // 
            this.olvColLastName.AspectName = "LastName";
            this.olvColLastName.Text = "Last Name";
            this.olvColLastName.Width = 120;
            // 
            // olvColAddress
            // 
            this.olvColAddress.AspectName = "Address";
            this.olvColAddress.Text = "Address";
            this.olvColAddress.Width = 200;
            // 
            // olvColCity
            // 
            this.olvColCity.AspectName = "City";
            this.olvColCity.Text = "City";
            this.olvColCity.Width = 100;
            // 
            // olvColState
            // 
            this.olvColState.AspectName = "State";
            this.olvColState.Text = "State";
            // 
            // olvColZip
            // 
            this.olvColZip.AspectName = "Zip";
            this.olvColZip.Text = "Zip";
            // 
            // olvColCountry
            // 
            this.olvColCountry.AspectName = "Country";
            this.olvColCountry.Text = "Country";
            this.olvColCountry.Width = 100;
            // 
            // olvColEmail
            // 
            this.olvColEmail.AspectName = "Email";
            this.olvColEmail.Text = "Email";
            this.olvColEmail.Width = 100;
            // 
            // olvColPhone_Office
            // 
            this.olvColPhone_Office.AspectName = "Phone_Office";
            this.olvColPhone_Office.Text = "Office";
            this.olvColPhone_Office.Width = 80;
            // 
            // olvColPhone_Mobile
            // 
            this.olvColPhone_Mobile.AspectName = "Phone_Mobile";
            this.olvColPhone_Mobile.Text = "Mobile";
            this.olvColPhone_Mobile.Width = 80;
            // 
            // pnlSalespeople_Control
            // 
            this.pnlSalespeople_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSalespeople_Control.Controls.Add(this.btnSalesperson_Edit);
            this.pnlSalespeople_Control.Controls.Add(this.btnSalesperson_Remove);
            this.pnlSalespeople_Control.Controls.Add(this.btnSalesperson_Add);
            this.pnlSalespeople_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalespeople_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlSalespeople_Control.Name = "pnlSalespeople_Control";
            this.pnlSalespeople_Control.Size = new System.Drawing.Size(1266, 30);
            this.pnlSalespeople_Control.TabIndex = 3;
            // 
            // btnSalesperson_Edit
            // 
            this.btnSalesperson_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalesperson_Edit.Location = new System.Drawing.Point(297, 3);
            this.btnSalesperson_Edit.Name = "btnSalesperson_Edit";
            this.btnSalesperson_Edit.Size = new System.Drawing.Size(140, 23);
            this.btnSalesperson_Edit.TabIndex = 13;
            this.btnSalesperson_Edit.Text = "Edit Salesperson";
            this.btnSalesperson_Edit.UseVisualStyleBackColor = false;
            // 
            // btnSalesperson_Remove
            // 
            this.btnSalesperson_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalesperson_Remove.Location = new System.Drawing.Point(151, 3);
            this.btnSalesperson_Remove.Name = "btnSalesperson_Remove";
            this.btnSalesperson_Remove.Size = new System.Drawing.Size(140, 23);
            this.btnSalesperson_Remove.TabIndex = 3;
            this.btnSalesperson_Remove.Text = "Remove Salesperson";
            this.btnSalesperson_Remove.UseVisualStyleBackColor = false;
            // 
            // btnSalesperson_Add
            // 
            this.btnSalesperson_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalesperson_Add.Location = new System.Drawing.Point(3, 3);
            this.btnSalesperson_Add.Name = "btnSalesperson_Add";
            this.btnSalesperson_Add.Size = new System.Drawing.Size(140, 23);
            this.btnSalesperson_Add.TabIndex = 2;
            this.btnSalesperson_Add.Text = "Add Salesperson";
            this.btnSalesperson_Add.UseVisualStyleBackColor = false;
            // 
            // tabShippingMethods
            // 
            this.tabShippingMethods.Controls.Add(this.grpSymptoms);
            this.tabShippingMethods.Location = new System.Drawing.Point(4, 22);
            this.tabShippingMethods.Name = "tabShippingMethods";
            this.tabShippingMethods.Size = new System.Drawing.Size(1266, 928);
            this.tabShippingMethods.TabIndex = 7;
            this.tabShippingMethods.Text = "Shipping Methods";
            this.tabShippingMethods.UseVisualStyleBackColor = true;
            // 
            // grpSymptoms
            // 
            this.grpSymptoms.Controls.Add(this.olvShipmentMethods);
            this.grpSymptoms.Controls.Add(this.pnlSymptoms_Control);
            this.grpSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSymptoms.Location = new System.Drawing.Point(0, 0);
            this.grpSymptoms.Name = "grpSymptoms";
            this.grpSymptoms.Size = new System.Drawing.Size(1266, 928);
            this.grpSymptoms.TabIndex = 1;
            this.grpSymptoms.TabStop = false;
            // 
            // olvShipmentMethods
            // 
            this.olvShipmentMethods.AllColumns.Add(this.olcDisplayIndex);
            this.olvShipmentMethods.AllColumns.Add(this.olcDescription);
            this.olvShipmentMethods.AllColumns.Add(this.olcAbbreviation);
            this.olvShipmentMethods.AllColumns.Add(this.olcDefault);
            this.olvShipmentMethods.CellEditUseWholeCell = false;
            this.olvShipmentMethods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcDisplayIndex,
            this.olcDescription,
            this.olcAbbreviation,
            this.olcDefault});
            this.olvShipmentMethods.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvShipmentMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvShipmentMethods.EmptyListMsg = "No Shipment Methods Defined";
            this.olvShipmentMethods.FullRowSelect = true;
            this.olvShipmentMethods.GridLines = true;
            this.olvShipmentMethods.HideSelection = false;
            this.olvShipmentMethods.Location = new System.Drawing.Point(3, 46);
            this.olvShipmentMethods.MultiSelect = false;
            this.olvShipmentMethods.Name = "olvShipmentMethods";
            this.olvShipmentMethods.SelectAllOnControlA = false;
            this.olvShipmentMethods.ShowGroups = false;
            this.olvShipmentMethods.Size = new System.Drawing.Size(1260, 879);
            this.olvShipmentMethods.TabIndex = 1;
            this.olvShipmentMethods.UseCompatibleStateImageBehavior = false;
            this.olvShipmentMethods.View = System.Windows.Forms.View.Details;
            // 
            // olcDisplayIndex
            // 
            this.olcDisplayIndex.AspectName = "DisplayIndex";
            this.olcDisplayIndex.Groupable = false;
            this.olcDisplayIndex.Text = "#";
            this.olcDisplayIndex.Width = 25;
            // 
            // olcDescription
            // 
            this.olcDescription.AspectName = "Description";
            this.olcDescription.FillsFreeSpace = true;
            this.olcDescription.Groupable = false;
            this.olcDescription.Text = "Shipment Method";
            this.olcDescription.Width = 240;
            // 
            // olcAbbreviation
            // 
            this.olcAbbreviation.AspectName = "Abbreviation";
            this.olcAbbreviation.Text = "Abv.";
            this.olcAbbreviation.Width = 80;
            // 
            // olcDefault
            // 
            this.olcDefault.AspectName = "Default";
            this.olcDefault.CheckBoxes = true;
            this.olcDefault.Groupable = false;
            this.olcDefault.Sortable = false;
            this.olcDefault.Text = "Default";
            // 
            // pnlSymptoms_Control
            // 
            this.pnlSymptoms_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSymptoms_Control.Controls.Add(this.btnEdit);
            this.pnlSymptoms_Control.Controls.Add(this.btnMoveUp);
            this.pnlSymptoms_Control.Controls.Add(this.btnDefault);
            this.pnlSymptoms_Control.Controls.Add(this.btnRemove);
            this.pnlSymptoms_Control.Controls.Add(this.btnAdd);
            this.pnlSymptoms_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSymptoms_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlSymptoms_Control.Name = "pnlSymptoms_Control";
            this.pnlSymptoms_Control.Size = new System.Drawing.Size(1260, 30);
            this.pnlSymptoms_Control.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(177, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoveUp.Location = new System.Drawing.Point(372, 4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(80, 23);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDefault.Location = new System.Drawing.Point(284, 4);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(80, 23);
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "Set Default";
            this.btnDefault.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemove.Location = new System.Drawing.Point(91, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tabSymptonsSolutions
            // 
            this.tabSymptonsSolutions.Controls.Add(this.pnlSymptoms);
            this.tabSymptonsSolutions.Controls.Add(this.pnlSolutions);
            this.tabSymptonsSolutions.Location = new System.Drawing.Point(4, 22);
            this.tabSymptonsSolutions.Name = "tabSymptonsSolutions";
            this.tabSymptonsSolutions.Size = new System.Drawing.Size(1266, 928);
            this.tabSymptonsSolutions.TabIndex = 8;
            this.tabSymptonsSolutions.Text = "Symptoms & Solutions";
            this.tabSymptonsSolutions.UseVisualStyleBackColor = true;
            // 
            // pnlSymptoms
            // 
            this.pnlSymptoms.Controls.Add(this.olvSymptoms);
            this.pnlSymptoms.Controls.Add(this.panel2);
            this.pnlSymptoms.Controls.Add(this.lblOwnershipInformation);
            this.pnlSymptoms.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSymptoms.Location = new System.Drawing.Point(0, 0);
            this.pnlSymptoms.Name = "pnlSymptoms";
            this.pnlSymptoms.Size = new System.Drawing.Size(568, 928);
            this.pnlSymptoms.TabIndex = 2;
            this.pnlSymptoms.Text = "Symptoms";
            // 
            // olvSymptoms
            // 
            this.olvSymptoms.AllColumns.Add(this.olcSymptom_Symptom);
            this.olvSymptoms.AllColumns.Add(this.olcSymptom_IsVisible);
            this.olvSymptoms.CellEditUseWholeCell = false;
            this.olvSymptoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcSymptom_Symptom,
            this.olcSymptom_IsVisible});
            this.olvSymptoms.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSymptoms.Dock = System.Windows.Forms.DockStyle.Left;
            this.olvSymptoms.EmptyListMsg = "No Symptoms Defined";
            this.olvSymptoms.FullRowSelect = true;
            this.olvSymptoms.GridLines = true;
            this.olvSymptoms.HideSelection = false;
            this.olvSymptoms.Location = new System.Drawing.Point(0, 47);
            this.olvSymptoms.MultiSelect = false;
            this.olvSymptoms.Name = "olvSymptoms";
            this.olvSymptoms.SelectAllOnControlA = false;
            this.olvSymptoms.ShowGroups = false;
            this.olvSymptoms.Size = new System.Drawing.Size(565, 881);
            this.olvSymptoms.TabIndex = 2;
            this.olvSymptoms.UseCompatibleStateImageBehavior = false;
            this.olvSymptoms.View = System.Windows.Forms.View.Details;
            // 
            // olcSymptom_Symptom
            // 
            this.olcSymptom_Symptom.AspectName = "Symptom";
            this.olcSymptom_Symptom.FillsFreeSpace = true;
            this.olcSymptom_Symptom.Groupable = false;
            this.olcSymptom_Symptom.IsEditable = false;
            this.olcSymptom_Symptom.Text = "Symptom";
            this.olcSymptom_Symptom.Width = 200;
            // 
            // olcSymptom_IsVisible
            // 
            this.olcSymptom_IsVisible.AspectName = "IsVisible";
            this.olcSymptom_IsVisible.CheckBoxes = true;
            this.olcSymptom_IsVisible.IsEditable = false;
            this.olcSymptom_IsVisible.Text = "Is Visible";
            this.olcSymptom_IsVisible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcSymptom_IsVisible.ToolTipText = "Is visible on camera check";
            this.olcSymptom_IsVisible.Width = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnSymptoms_Edit);
            this.panel2.Controls.Add(this.btnSymptoms_Remove);
            this.panel2.Controls.Add(this.btnSymptoms_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 30);
            this.panel2.TabIndex = 1;
            // 
            // btnSymptoms_Edit
            // 
            this.btnSymptoms_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSymptoms_Edit.Location = new System.Drawing.Point(179, 4);
            this.btnSymptoms_Edit.Name = "btnSymptoms_Edit";
            this.btnSymptoms_Edit.Size = new System.Drawing.Size(80, 23);
            this.btnSymptoms_Edit.TabIndex = 2;
            this.btnSymptoms_Edit.Text = "Edit";
            this.btnSymptoms_Edit.UseVisualStyleBackColor = false;
            // 
            // btnSymptoms_Remove
            // 
            this.btnSymptoms_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSymptoms_Remove.Location = new System.Drawing.Point(91, 4);
            this.btnSymptoms_Remove.Name = "btnSymptoms_Remove";
            this.btnSymptoms_Remove.Size = new System.Drawing.Size(80, 23);
            this.btnSymptoms_Remove.TabIndex = 1;
            this.btnSymptoms_Remove.Text = "Remove";
            this.btnSymptoms_Remove.UseVisualStyleBackColor = false;
            // 
            // btnSymptoms_Add
            // 
            this.btnSymptoms_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSymptoms_Add.Location = new System.Drawing.Point(3, 4);
            this.btnSymptoms_Add.Name = "btnSymptoms_Add";
            this.btnSymptoms_Add.Size = new System.Drawing.Size(80, 23);
            this.btnSymptoms_Add.TabIndex = 0;
            this.btnSymptoms_Add.Text = "Add";
            this.btnSymptoms_Add.UseVisualStyleBackColor = false;
            // 
            // lblOwnershipInformation
            // 
            this.lblOwnershipInformation.AutoEllipsis = true;
            this.lblOwnershipInformation.BackColor = System.Drawing.Color.Black;
            this.lblOwnershipInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOwnershipInformation.ForeColor = System.Drawing.Color.White;
            this.lblOwnershipInformation.Location = new System.Drawing.Point(0, 0);
            this.lblOwnershipInformation.Name = "lblOwnershipInformation";
            this.lblOwnershipInformation.Size = new System.Drawing.Size(568, 17);
            this.lblOwnershipInformation.TabIndex = 0;
            this.lblOwnershipInformation.Text = "Symptoms";
            this.lblOwnershipInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSolutions
            // 
            this.pnlSolutions.Controls.Add(this.olvSolutions);
            this.pnlSolutions.Controls.Add(this.pnlSolutions_Control);
            this.pnlSolutions.Controls.Add(this.lblSolutions);
            this.pnlSolutions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSolutions.Location = new System.Drawing.Point(574, 0);
            this.pnlSolutions.Name = "pnlSolutions";
            this.pnlSolutions.Size = new System.Drawing.Size(692, 928);
            this.pnlSolutions.TabIndex = 3;
            this.pnlSolutions.Text = "Solutions";
            // 
            // olvSolutions
            // 
            this.olvSolutions.AllColumns.Add(this.olvColSolutions_Solution);
            this.olvSolutions.AllColumns.Add(this.olvColSolutions_RequiresParts);
            this.olvSolutions.CellEditUseWholeCell = false;
            this.olvSolutions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSolutions_Solution,
            this.olvColSolutions_RequiresParts});
            this.olvSolutions.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvSolutions.EmptyListMsg = "No Solutions Defined";
            this.olvSolutions.FullRowSelect = true;
            this.olvSolutions.GridLines = true;
            this.olvSolutions.HideSelection = false;
            this.olvSolutions.Location = new System.Drawing.Point(0, 47);
            this.olvSolutions.MultiSelect = false;
            this.olvSolutions.Name = "olvSolutions";
            this.olvSolutions.SelectAllOnControlA = false;
            this.olvSolutions.ShowGroups = false;
            this.olvSolutions.Size = new System.Drawing.Size(692, 881);
            this.olvSolutions.TabIndex = 2;
            this.olvSolutions.UseCompatibleStateImageBehavior = false;
            this.olvSolutions.UseOverlays = false;
            this.olvSolutions.View = System.Windows.Forms.View.Details;
            // 
            // olvColSolutions_Solution
            // 
            this.olvColSolutions_Solution.AspectName = "Solution";
            this.olvColSolutions_Solution.FillsFreeSpace = true;
            this.olvColSolutions_Solution.Groupable = false;
            this.olvColSolutions_Solution.IsEditable = false;
            this.olvColSolutions_Solution.Text = "Solution";
            this.olvColSolutions_Solution.Width = 200;
            // 
            // olvColSolutions_RequiresParts
            // 
            this.olvColSolutions_RequiresParts.AspectName = "RequiresParts";
            this.olvColSolutions_RequiresParts.CheckBoxes = true;
            this.olvColSolutions_RequiresParts.Groupable = false;
            this.olvColSolutions_RequiresParts.IsEditable = false;
            this.olvColSolutions_RequiresParts.Text = "Requires Parts";
            this.olvColSolutions_RequiresParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColSolutions_RequiresParts.Width = 90;
            // 
            // pnlSolutions_Control
            // 
            this.pnlSolutions_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSolutions_Control.Controls.Add(this.btnSolutions_Edit);
            this.pnlSolutions_Control.Controls.Add(this.btnSolutions_Remove);
            this.pnlSolutions_Control.Controls.Add(this.btnSolutions_Add);
            this.pnlSolutions_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolutions_Control.Location = new System.Drawing.Point(0, 17);
            this.pnlSolutions_Control.Name = "pnlSolutions_Control";
            this.pnlSolutions_Control.Size = new System.Drawing.Size(692, 30);
            this.pnlSolutions_Control.TabIndex = 1;
            // 
            // btnSolutions_Edit
            // 
            this.btnSolutions_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSolutions_Edit.Location = new System.Drawing.Point(179, 4);
            this.btnSolutions_Edit.Name = "btnSolutions_Edit";
            this.btnSolutions_Edit.Size = new System.Drawing.Size(80, 23);
            this.btnSolutions_Edit.TabIndex = 2;
            this.btnSolutions_Edit.Text = "Edit";
            this.btnSolutions_Edit.UseVisualStyleBackColor = false;
            // 
            // btnSolutions_Remove
            // 
            this.btnSolutions_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSolutions_Remove.Location = new System.Drawing.Point(91, 4);
            this.btnSolutions_Remove.Name = "btnSolutions_Remove";
            this.btnSolutions_Remove.Size = new System.Drawing.Size(80, 23);
            this.btnSolutions_Remove.TabIndex = 1;
            this.btnSolutions_Remove.Text = "Remove";
            this.btnSolutions_Remove.UseVisualStyleBackColor = false;
            // 
            // btnSolutions_Add
            // 
            this.btnSolutions_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSolutions_Add.Location = new System.Drawing.Point(3, 4);
            this.btnSolutions_Add.Name = "btnSolutions_Add";
            this.btnSolutions_Add.Size = new System.Drawing.Size(80, 23);
            this.btnSolutions_Add.TabIndex = 0;
            this.btnSolutions_Add.Text = "Add";
            this.btnSolutions_Add.UseVisualStyleBackColor = false;
            // 
            // lblSolutions
            // 
            this.lblSolutions.AutoEllipsis = true;
            this.lblSolutions.BackColor = System.Drawing.Color.Black;
            this.lblSolutions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSolutions.ForeColor = System.Drawing.Color.White;
            this.lblSolutions.Location = new System.Drawing.Point(0, 0);
            this.lblSolutions.Name = "lblSolutions";
            this.lblSolutions.Size = new System.Drawing.Size(692, 17);
            this.lblSolutions.TabIndex = 0;
            this.lblSolutions.Text = "Solutions";
            this.lblSolutions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPMA
            // 
            this.tabPMA.Controls.Add(this.pnlPMAs);
            this.tabPMA.Location = new System.Drawing.Point(4, 22);
            this.tabPMA.Name = "tabPMA";
            this.tabPMA.Size = new System.Drawing.Size(1266, 928);
            this.tabPMA.TabIndex = 9;
            this.tabPMA.Text = "Preventive Maintainance Actions";
            this.tabPMA.UseVisualStyleBackColor = true;
            // 
            // pnlPMAs
            // 
            this.pnlPMAs.Controls.Add(this.olvPMAs);
            this.pnlPMAs.Controls.Add(this.pnlPMAs_Control);
            this.pnlPMAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPMAs.Location = new System.Drawing.Point(0, 0);
            this.pnlPMAs.Name = "pnlPMAs";
            this.pnlPMAs.Size = new System.Drawing.Size(1266, 928);
            this.pnlPMAs.TabIndex = 3;
            // 
            // olvPMAs
            // 
            this.olvPMAs.AllColumns.Add(this.olvColumn1);
            this.olvPMAs.CellEditUseWholeCell = false;
            this.olvPMAs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.olvPMAs.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPMAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPMAs.FullRowSelect = true;
            this.olvPMAs.GridLines = true;
            this.olvPMAs.HasCollapsibleGroups = false;
            this.olvPMAs.Location = new System.Drawing.Point(0, 30);
            this.olvPMAs.MultiSelect = false;
            this.olvPMAs.Name = "olvPMAs";
            this.olvPMAs.SelectAllOnControlA = false;
            this.olvPMAs.SelectColumnsOnRightClick = false;
            this.olvPMAs.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvPMAs.ShowFilterMenuOnRightClick = false;
            this.olvPMAs.ShowGroups = false;
            this.olvPMAs.ShowImagesOnSubItems = true;
            this.olvPMAs.Size = new System.Drawing.Size(1266, 898);
            this.olvPMAs.TabIndex = 0;
            this.olvPMAs.UseCompatibleStateImageBehavior = false;
            this.olvPMAs.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Description";
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Text = "Description";
            this.olvColumn1.Width = 300;
            // 
            // pnlPMAs_Control
            // 
            this.pnlPMAs_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPMAs_Control.Controls.Add(this.btnPMA_Edit);
            this.pnlPMAs_Control.Controls.Add(this.btnPMA_Remove);
            this.pnlPMAs_Control.Controls.Add(this.btnPMA_Add);
            this.pnlPMAs_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPMAs_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlPMAs_Control.Name = "pnlPMAs_Control";
            this.pnlPMAs_Control.Size = new System.Drawing.Size(1266, 30);
            this.pnlPMAs_Control.TabIndex = 1;
            // 
            // btnPMA_Edit
            // 
            this.btnPMA_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnPMA_Edit.Location = new System.Drawing.Point(297, 3);
            this.btnPMA_Edit.Name = "btnPMA_Edit";
            this.btnPMA_Edit.Size = new System.Drawing.Size(140, 23);
            this.btnPMA_Edit.TabIndex = 13;
            this.btnPMA_Edit.Text = "Edit PMA";
            this.btnPMA_Edit.UseVisualStyleBackColor = false;
            // 
            // btnPMA_Remove
            // 
            this.btnPMA_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPMA_Remove.Location = new System.Drawing.Point(151, 3);
            this.btnPMA_Remove.Name = "btnPMA_Remove";
            this.btnPMA_Remove.Size = new System.Drawing.Size(140, 23);
            this.btnPMA_Remove.TabIndex = 3;
            this.btnPMA_Remove.Text = "Remove PMA";
            this.btnPMA_Remove.UseVisualStyleBackColor = false;
            // 
            // btnPMA_Add
            // 
            this.btnPMA_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPMA_Add.Location = new System.Drawing.Point(3, 3);
            this.btnPMA_Add.Name = "btnPMA_Add";
            this.btnPMA_Add.Size = new System.Drawing.Size(140, 23);
            this.btnPMA_Add.TabIndex = 2;
            this.btnPMA_Add.Text = "Add PMA";
            this.btnPMA_Add.UseVisualStyleBackColor = false;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.pnlUser_Create);
            this.tabUsers.Controls.Add(this.pnlUser_Modify);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1266, 928);
            this.tabUsers.TabIndex = 10;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // pnlUser_Create
            // 
            this.pnlUser_Create.BackColor = System.Drawing.Color.LightGray;
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_SSR);
            this.pnlUser_Create.Controls.Add(this.label1);
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_Moderator);
            this.pnlUser_Create.Controls.Add(this.lblUser_Create);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Password_Confirm);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Login);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Password_Confirm);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_FirstName);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Password);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Login);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Password);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_LastName);
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_Administrator);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Email);
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_Standard);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_FirstName);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_UserType);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_LastName);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Email);
            this.pnlUser_Create.Controls.Add(this.btnCreateUser);
            this.pnlUser_Create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUser_Create.Location = new System.Drawing.Point(0, 379);
            this.pnlUser_Create.Name = "pnlUser_Create";
            this.pnlUser_Create.Size = new System.Drawing.Size(1266, 549);
            this.pnlUser_Create.TabIndex = 3;
            // 
            // radCreateUser_UserType_SSR
            // 
            this.radCreateUser_UserType_SSR.AutoSize = true;
            this.radCreateUser_UserType_SSR.Location = new System.Drawing.Point(198, 179);
            this.radCreateUser_UserType_SSR.Name = "radCreateUser_UserType_SSR";
            this.radCreateUser_UserType_SSR.Size = new System.Drawing.Size(47, 17);
            this.radCreateUser_UserType_SSR.TabIndex = 23;
            this.radCreateUser_UserType_SSR.Text = "SSR";
            this.radCreateUser_UserType_SSR.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(280, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "(Employee #)";
            // 
            // radCreateUser_UserType_Moderator
            // 
            this.radCreateUser_UserType_Moderator.AutoSize = true;
            this.radCreateUser_UserType_Moderator.Location = new System.Drawing.Point(119, 179);
            this.radCreateUser_UserType_Moderator.Name = "radCreateUser_UserType_Moderator";
            this.radCreateUser_UserType_Moderator.Size = new System.Drawing.Size(73, 17);
            this.radCreateUser_UserType_Moderator.TabIndex = 19;
            this.radCreateUser_UserType_Moderator.Text = "Moderator";
            this.radCreateUser_UserType_Moderator.UseVisualStyleBackColor = true;
            // 
            // lblUser_Create
            // 
            this.lblUser_Create.AutoEllipsis = true;
            this.lblUser_Create.BackColor = System.Drawing.Color.Black;
            this.lblUser_Create.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Create.ForeColor = System.Drawing.Color.White;
            this.lblUser_Create.Location = new System.Drawing.Point(0, 0);
            this.lblUser_Create.Name = "lblUser_Create";
            this.lblUser_Create.Size = new System.Drawing.Size(1266, 17);
            this.lblUser_Create.TabIndex = 0;
            this.lblUser_Create.Text = "Create User";
            this.lblUser_Create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreateUser_Password_Confirm
            // 
            this.txtCreateUser_Password_Confirm.Location = new System.Drawing.Point(111, 142);
            this.txtCreateUser_Password_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Password_Confirm.MaxLength = 50;
            this.txtCreateUser_Password_Confirm.Name = "txtCreateUser_Password_Confirm";
            this.txtCreateUser_Password_Confirm.PasswordChar = '*';
            this.txtCreateUser_Password_Confirm.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Password_Confirm.TabIndex = 12;
            this.txtCreateUser_Password_Confirm.UseSystemPasswordChar = true;
            // 
            // txtCreateUser_Login
            // 
            this.txtCreateUser_Login.Location = new System.Drawing.Point(111, 19);
            this.txtCreateUser_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Login.MaxLength = 20;
            this.txtCreateUser_Login.Name = "txtCreateUser_Login";
            this.txtCreateUser_Login.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Login.TabIndex = 2;
            // 
            // lblCreateUser_Password_Confirm
            // 
            this.lblCreateUser_Password_Confirm.AutoSize = true;
            this.lblCreateUser_Password_Confirm.Location = new System.Drawing.Point(11, 145);
            this.lblCreateUser_Password_Confirm.Name = "lblCreateUser_Password_Confirm";
            this.lblCreateUser_Password_Confirm.Size = new System.Drawing.Size(94, 13);
            this.lblCreateUser_Password_Confirm.TabIndex = 11;
            this.lblCreateUser_Password_Confirm.Text = "Confirm Password:";
            this.lblCreateUser_Password_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreateUser_FirstName
            // 
            this.lblCreateUser_FirstName.AutoSize = true;
            this.lblCreateUser_FirstName.Location = new System.Drawing.Point(45, 47);
            this.lblCreateUser_FirstName.Name = "lblCreateUser_FirstName";
            this.lblCreateUser_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lblCreateUser_FirstName.TabIndex = 3;
            this.lblCreateUser_FirstName.Text = "First Name:";
            this.lblCreateUser_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCreateUser_Password
            // 
            this.txtCreateUser_Password.Location = new System.Drawing.Point(111, 118);
            this.txtCreateUser_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Password.MaxLength = 50;
            this.txtCreateUser_Password.Name = "txtCreateUser_Password";
            this.txtCreateUser_Password.PasswordChar = '*';
            this.txtCreateUser_Password.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Password.TabIndex = 10;
            this.txtCreateUser_Password.UseSystemPasswordChar = true;
            // 
            // lblCreateUser_Login
            // 
            this.lblCreateUser_Login.AutoSize = true;
            this.lblCreateUser_Login.Location = new System.Drawing.Point(44, 22);
            this.lblCreateUser_Login.Name = "lblCreateUser_Login";
            this.lblCreateUser_Login.Size = new System.Drawing.Size(61, 13);
            this.lblCreateUser_Login.TabIndex = 1;
            this.lblCreateUser_Login.Text = "User Login:";
            this.lblCreateUser_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreateUser_Password
            // 
            this.lblCreateUser_Password.AutoSize = true;
            this.lblCreateUser_Password.Location = new System.Drawing.Point(49, 121);
            this.lblCreateUser_Password.Name = "lblCreateUser_Password";
            this.lblCreateUser_Password.Size = new System.Drawing.Size(56, 13);
            this.lblCreateUser_Password.TabIndex = 9;
            this.lblCreateUser_Password.Text = "Password:";
            this.lblCreateUser_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreateUser_LastName
            // 
            this.lblCreateUser_LastName.AutoSize = true;
            this.lblCreateUser_LastName.Location = new System.Drawing.Point(44, 72);
            this.lblCreateUser_LastName.Name = "lblCreateUser_LastName";
            this.lblCreateUser_LastName.Size = new System.Drawing.Size(61, 13);
            this.lblCreateUser_LastName.TabIndex = 5;
            this.lblCreateUser_LastName.Text = "Last Name:";
            this.lblCreateUser_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radCreateUser_UserType_Administrator
            // 
            this.radCreateUser_UserType_Administrator.AutoSize = true;
            this.radCreateUser_UserType_Administrator.Location = new System.Drawing.Point(251, 179);
            this.radCreateUser_UserType_Administrator.Name = "radCreateUser_UserType_Administrator";
            this.radCreateUser_UserType_Administrator.Size = new System.Drawing.Size(85, 17);
            this.radCreateUser_UserType_Administrator.TabIndex = 20;
            this.radCreateUser_UserType_Administrator.Text = "Administrator";
            this.radCreateUser_UserType_Administrator.UseVisualStyleBackColor = true;
            // 
            // lblCreateUser_Email
            // 
            this.lblCreateUser_Email.AutoSize = true;
            this.lblCreateUser_Email.Location = new System.Drawing.Point(66, 97);
            this.lblCreateUser_Email.Name = "lblCreateUser_Email";
            this.lblCreateUser_Email.Size = new System.Drawing.Size(39, 13);
            this.lblCreateUser_Email.TabIndex = 7;
            this.lblCreateUser_Email.Text = "E-Mail:";
            this.lblCreateUser_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radCreateUser_UserType_Standard
            // 
            this.radCreateUser_UserType_Standard.AutoSize = true;
            this.radCreateUser_UserType_Standard.Checked = true;
            this.radCreateUser_UserType_Standard.Location = new System.Drawing.Point(45, 179);
            this.radCreateUser_UserType_Standard.Name = "radCreateUser_UserType_Standard";
            this.radCreateUser_UserType_Standard.Size = new System.Drawing.Size(68, 17);
            this.radCreateUser_UserType_Standard.TabIndex = 18;
            this.radCreateUser_UserType_Standard.TabStop = true;
            this.radCreateUser_UserType_Standard.Text = "Standard";
            this.radCreateUser_UserType_Standard.UseVisualStyleBackColor = true;
            // 
            // txtCreateUser_FirstName
            // 
            this.txtCreateUser_FirstName.Location = new System.Drawing.Point(111, 44);
            this.txtCreateUser_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_FirstName.MaxLength = 20;
            this.txtCreateUser_FirstName.Name = "txtCreateUser_FirstName";
            this.txtCreateUser_FirstName.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_FirstName.TabIndex = 4;
            // 
            // lblCreateUser_UserType
            // 
            this.lblCreateUser_UserType.AutoSize = true;
            this.lblCreateUser_UserType.Location = new System.Drawing.Point(11, 179);
            this.lblCreateUser_UserType.Name = "lblCreateUser_UserType";
            this.lblCreateUser_UserType.Size = new System.Drawing.Size(34, 13);
            this.lblCreateUser_UserType.TabIndex = 17;
            this.lblCreateUser_UserType.Text = "Type:";
            this.lblCreateUser_UserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCreateUser_LastName
            // 
            this.txtCreateUser_LastName.Location = new System.Drawing.Point(111, 69);
            this.txtCreateUser_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_LastName.MaxLength = 20;
            this.txtCreateUser_LastName.Name = "txtCreateUser_LastName";
            this.txtCreateUser_LastName.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_LastName.TabIndex = 6;
            // 
            // txtCreateUser_Email
            // 
            this.txtCreateUser_Email.Location = new System.Drawing.Point(111, 94);
            this.txtCreateUser_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Email.MaxLength = 35;
            this.txtCreateUser_Email.Name = "txtCreateUser_Email";
            this.txtCreateUser_Email.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Email.TabIndex = 8;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.AutoSize = true;
            this.btnCreateUser.Location = new System.Drawing.Point(239, 237);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(120, 23);
            this.btnCreateUser.TabIndex = 21;
            this.btnCreateUser.Text = "Create New User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // pnlUser_Modify
            // 
            this.pnlUser_Modify.BackColor = System.Drawing.Color.LightGray;
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_SSR);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Pin_Confirm);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Pin_Confirm);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Pin);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Pin);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_DisableLogin);
            this.pnlUser_Modify.Controls.Add(this.lblUser_Modify);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_Moderator);
            this.pnlUser_Modify.Controls.Add(this.cmbModifyUser_SelectUser);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_Administrator);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_SelectUser);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_Standard);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Password);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_UserType);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Password);
            this.pnlUser_Modify.Controls.Add(this.btnModifyUser);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Password_Confirm);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Password_Confirm);
            this.pnlUser_Modify.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser_Modify.Location = new System.Drawing.Point(0, 0);
            this.pnlUser_Modify.Name = "pnlUser_Modify";
            this.pnlUser_Modify.Size = new System.Drawing.Size(1266, 376);
            this.pnlUser_Modify.TabIndex = 2;
            // 
            // radModifyUser_UserType_SSR
            // 
            this.radModifyUser_UserType_SSR.AutoSize = true;
            this.radModifyUser_UserType_SSR.Location = new System.Drawing.Point(190, 150);
            this.radModifyUser_UserType_SSR.Name = "radModifyUser_UserType_SSR";
            this.radModifyUser_UserType_SSR.Size = new System.Drawing.Size(47, 17);
            this.radModifyUser_UserType_SSR.TabIndex = 24;
            this.radModifyUser_UserType_SSR.Text = "SSR";
            this.radModifyUser_UserType_SSR.UseVisualStyleBackColor = true;
            // 
            // txtModifyUser_Pin_Confirm
            // 
            this.txtModifyUser_Pin_Confirm.Location = new System.Drawing.Point(111, 128);
            this.txtModifyUser_Pin_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Pin_Confirm.MaxLength = 50;
            this.txtModifyUser_Pin_Confirm.Name = "txtModifyUser_Pin_Confirm";
            this.txtModifyUser_Pin_Confirm.PasswordChar = '*';
            this.txtModifyUser_Pin_Confirm.Size = new System.Drawing.Size(83, 20);
            this.txtModifyUser_Pin_Confirm.TabIndex = 10;
            this.txtModifyUser_Pin_Confirm.UseSystemPasswordChar = true;
            // 
            // lblModifyUser_Pin_Confirm
            // 
            this.lblModifyUser_Pin_Confirm.AutoSize = true;
            this.lblModifyUser_Pin_Confirm.Location = new System.Drawing.Point(39, 131);
            this.lblModifyUser_Pin_Confirm.Name = "lblModifyUser_Pin_Confirm";
            this.lblModifyUser_Pin_Confirm.Size = new System.Drawing.Size(66, 13);
            this.lblModifyUser_Pin_Confirm.TabIndex = 9;
            this.lblModifyUser_Pin_Confirm.Text = "Confirm PIN:";
            this.lblModifyUser_Pin_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModifyUser_Pin
            // 
            this.txtModifyUser_Pin.Location = new System.Drawing.Point(111, 104);
            this.txtModifyUser_Pin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Pin.MaxLength = 50;
            this.txtModifyUser_Pin.Name = "txtModifyUser_Pin";
            this.txtModifyUser_Pin.PasswordChar = '*';
            this.txtModifyUser_Pin.Size = new System.Drawing.Size(83, 20);
            this.txtModifyUser_Pin.TabIndex = 8;
            this.txtModifyUser_Pin.UseSystemPasswordChar = true;
            // 
            // lblModifyUser_Pin
            // 
            this.lblModifyUser_Pin.AutoSize = true;
            this.lblModifyUser_Pin.Location = new System.Drawing.Point(52, 107);
            this.lblModifyUser_Pin.Name = "lblModifyUser_Pin";
            this.lblModifyUser_Pin.Size = new System.Drawing.Size(53, 13);
            this.lblModifyUser_Pin.TabIndex = 7;
            this.lblModifyUser_Pin.Text = "New PIN:";
            this.lblModifyUser_Pin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radModifyUser_DisableLogin
            // 
            this.radModifyUser_DisableLogin.AutoSize = true;
            this.radModifyUser_DisableLogin.Location = new System.Drawing.Point(280, 27);
            this.radModifyUser_DisableLogin.Name = "radModifyUser_DisableLogin";
            this.radModifyUser_DisableLogin.Size = new System.Drawing.Size(67, 30);
            this.radModifyUser_DisableLogin.TabIndex = 2;
            this.radModifyUser_DisableLogin.Text = "Login\r\nDisabled";
            this.radModifyUser_DisableLogin.UseVisualStyleBackColor = true;
            // 
            // lblUser_Modify
            // 
            this.lblUser_Modify.AutoEllipsis = true;
            this.lblUser_Modify.BackColor = System.Drawing.Color.Black;
            this.lblUser_Modify.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Modify.ForeColor = System.Drawing.Color.White;
            this.lblUser_Modify.Location = new System.Drawing.Point(0, 0);
            this.lblUser_Modify.Name = "lblUser_Modify";
            this.lblUser_Modify.Size = new System.Drawing.Size(1266, 17);
            this.lblUser_Modify.TabIndex = 0;
            this.lblUser_Modify.Text = "Modify User";
            this.lblUser_Modify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radModifyUser_UserType_Moderator
            // 
            this.radModifyUser_UserType_Moderator.AutoSize = true;
            this.radModifyUser_UserType_Moderator.Location = new System.Drawing.Point(111, 150);
            this.radModifyUser_UserType_Moderator.Name = "radModifyUser_UserType_Moderator";
            this.radModifyUser_UserType_Moderator.Size = new System.Drawing.Size(73, 17);
            this.radModifyUser_UserType_Moderator.TabIndex = 13;
            this.radModifyUser_UserType_Moderator.Text = "Moderator";
            this.radModifyUser_UserType_Moderator.UseVisualStyleBackColor = true;
            // 
            // cmbModifyUser_SelectUser
            // 
            this.cmbModifyUser_SelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyUser_SelectUser.FormattingEnabled = true;
            this.cmbModifyUser_SelectUser.Location = new System.Drawing.Point(111, 31);
            this.cmbModifyUser_SelectUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModifyUser_SelectUser.Name = "cmbModifyUser_SelectUser";
            this.cmbModifyUser_SelectUser.Size = new System.Drawing.Size(163, 21);
            this.cmbModifyUser_SelectUser.TabIndex = 1;
            // 
            // radModifyUser_UserType_Administrator
            // 
            this.radModifyUser_UserType_Administrator.AutoSize = true;
            this.radModifyUser_UserType_Administrator.Location = new System.Drawing.Point(243, 150);
            this.radModifyUser_UserType_Administrator.Name = "radModifyUser_UserType_Administrator";
            this.radModifyUser_UserType_Administrator.Size = new System.Drawing.Size(85, 17);
            this.radModifyUser_UserType_Administrator.TabIndex = 14;
            this.radModifyUser_UserType_Administrator.Text = "Administrator";
            this.radModifyUser_UserType_Administrator.UseVisualStyleBackColor = true;
            // 
            // lblModifyUser_SelectUser
            // 
            this.lblModifyUser_SelectUser.AutoSize = true;
            this.lblModifyUser_SelectUser.Location = new System.Drawing.Point(42, 34);
            this.lblModifyUser_SelectUser.Name = "lblModifyUser_SelectUser";
            this.lblModifyUser_SelectUser.Size = new System.Drawing.Size(63, 13);
            this.lblModifyUser_SelectUser.TabIndex = 0;
            this.lblModifyUser_SelectUser.Text = "Select user:";
            // 
            // radModifyUser_UserType_Standard
            // 
            this.radModifyUser_UserType_Standard.AutoSize = true;
            this.radModifyUser_UserType_Standard.Checked = true;
            this.radModifyUser_UserType_Standard.Location = new System.Drawing.Point(45, 150);
            this.radModifyUser_UserType_Standard.Name = "radModifyUser_UserType_Standard";
            this.radModifyUser_UserType_Standard.Size = new System.Drawing.Size(68, 17);
            this.radModifyUser_UserType_Standard.TabIndex = 12;
            this.radModifyUser_UserType_Standard.TabStop = true;
            this.radModifyUser_UserType_Standard.Text = "Standard";
            this.radModifyUser_UserType_Standard.UseVisualStyleBackColor = true;
            // 
            // lblModifyUser_Password
            // 
            this.lblModifyUser_Password.AutoSize = true;
            this.lblModifyUser_Password.Location = new System.Drawing.Point(24, 59);
            this.lblModifyUser_Password.Name = "lblModifyUser_Password";
            this.lblModifyUser_Password.Size = new System.Drawing.Size(81, 13);
            this.lblModifyUser_Password.TabIndex = 3;
            this.lblModifyUser_Password.Text = "New Password:";
            this.lblModifyUser_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModifyUser_UserType
            // 
            this.lblModifyUser_UserType.AutoSize = true;
            this.lblModifyUser_UserType.Location = new System.Drawing.Point(11, 150);
            this.lblModifyUser_UserType.Name = "lblModifyUser_UserType";
            this.lblModifyUser_UserType.Size = new System.Drawing.Size(34, 13);
            this.lblModifyUser_UserType.TabIndex = 11;
            this.lblModifyUser_UserType.Text = "Type:";
            this.lblModifyUser_UserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModifyUser_Password
            // 
            this.txtModifyUser_Password.Location = new System.Drawing.Point(111, 56);
            this.txtModifyUser_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Password.MaxLength = 50;
            this.txtModifyUser_Password.Name = "txtModifyUser_Password";
            this.txtModifyUser_Password.PasswordChar = '*';
            this.txtModifyUser_Password.Size = new System.Drawing.Size(163, 20);
            this.txtModifyUser_Password.TabIndex = 4;
            this.txtModifyUser_Password.UseSystemPasswordChar = true;
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.AutoSize = true;
            this.btnModifyUser.Location = new System.Drawing.Point(239, 172);
            this.btnModifyUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(120, 23);
            this.btnModifyUser.TabIndex = 15;
            this.btnModifyUser.Text = "Modify User";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            // 
            // lblModifyUser_Password_Confirm
            // 
            this.lblModifyUser_Password_Confirm.AutoSize = true;
            this.lblModifyUser_Password_Confirm.Location = new System.Drawing.Point(11, 83);
            this.lblModifyUser_Password_Confirm.Name = "lblModifyUser_Password_Confirm";
            this.lblModifyUser_Password_Confirm.Size = new System.Drawing.Size(94, 13);
            this.lblModifyUser_Password_Confirm.TabIndex = 5;
            this.lblModifyUser_Password_Confirm.Text = "Confirm Password:";
            this.lblModifyUser_Password_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModifyUser_Password_Confirm
            // 
            this.txtModifyUser_Password_Confirm.Location = new System.Drawing.Point(111, 80);
            this.txtModifyUser_Password_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Password_Confirm.MaxLength = 50;
            this.txtModifyUser_Password_Confirm.Name = "txtModifyUser_Password_Confirm";
            this.txtModifyUser_Password_Confirm.PasswordChar = '*';
            this.txtModifyUser_Password_Confirm.Size = new System.Drawing.Size(163, 20);
            this.txtModifyUser_Password_Confirm.TabIndex = 6;
            this.txtModifyUser_Password_Confirm.UseSystemPasswordChar = true;
            // 
            // tabRMAFailures
            // 
            this.tabRMAFailures.Controls.Add(this.grpRootCauses);
            this.tabRMAFailures.Controls.Add(this.grpRepairTypes);
            this.tabRMAFailures.Controls.Add(this.grpFailureTypes);
            this.tabRMAFailures.Location = new System.Drawing.Point(4, 22);
            this.tabRMAFailures.Name = "tabRMAFailures";
            this.tabRMAFailures.Size = new System.Drawing.Size(1266, 928);
            this.tabRMAFailures.TabIndex = 11;
            this.tabRMAFailures.Text = "RMA Failure Types";
            this.tabRMAFailures.UseVisualStyleBackColor = true;
            // 
            // grpRootCauses
            // 
            this.grpRootCauses.Controls.Add(this.olvRootCauses);
            this.grpRootCauses.Controls.Add(this.pnlRootCauses_Control);
            this.grpRootCauses.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpRootCauses.Location = new System.Drawing.Point(872, 0);
            this.grpRootCauses.Name = "grpRootCauses";
            this.grpRootCauses.Size = new System.Drawing.Size(394, 928);
            this.grpRootCauses.TabIndex = 5;
            this.grpRootCauses.TabStop = false;
            this.grpRootCauses.Text = "Root Causes";
            // 
            // olvRootCauses
            // 
            this.olvRootCauses.AllColumns.Add(this.olvColumn2);
            this.olvRootCauses.CellEditTabChangesRows = true;
            this.olvRootCauses.CellEditUseWholeCell = false;
            this.olvRootCauses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2});
            this.olvRootCauses.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRootCauses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRootCauses.EmptyListMsg = "No root causes defined.";
            this.olvRootCauses.FullRowSelect = true;
            this.olvRootCauses.GridLines = true;
            this.olvRootCauses.HasCollapsibleGroups = false;
            this.olvRootCauses.HideSelection = false;
            this.olvRootCauses.Location = new System.Drawing.Point(3, 46);
            this.olvRootCauses.MultiSelect = false;
            this.olvRootCauses.Name = "olvRootCauses";
            this.olvRootCauses.SelectAllOnControlA = false;
            this.olvRootCauses.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvRootCauses.ShowCommandMenuOnRightClick = true;
            this.olvRootCauses.ShowGroups = false;
            this.olvRootCauses.ShowItemCountOnGroups = true;
            this.olvRootCauses.Size = new System.Drawing.Size(388, 879);
            this.olvRootCauses.SortGroupItemsByPrimaryColumn = false;
            this.olvRootCauses.TabIndex = 1;
            this.olvRootCauses.UseCompatibleStateImageBehavior = false;
            this.olvRootCauses.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Description";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Groupable = false;
            this.olvColumn2.Hideable = false;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "Description";
            this.olvColumn2.Width = 300;
            // 
            // pnlRootCauses_Control
            // 
            this.pnlRootCauses_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRootCauses_Control.Controls.Add(this.btnRootCause_Remove);
            this.pnlRootCauses_Control.Controls.Add(this.btnRootCause_Edit);
            this.pnlRootCauses_Control.Controls.Add(this.btnRootCause_Add);
            this.pnlRootCauses_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRootCauses_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlRootCauses_Control.Name = "pnlRootCauses_Control";
            this.pnlRootCauses_Control.Size = new System.Drawing.Size(388, 30);
            this.pnlRootCauses_Control.TabIndex = 0;
            // 
            // btnRootCause_Remove
            // 
            this.btnRootCause_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRootCause_Remove.Location = new System.Drawing.Point(89, 4);
            this.btnRootCause_Remove.Name = "btnRootCause_Remove";
            this.btnRootCause_Remove.Size = new System.Drawing.Size(80, 23);
            this.btnRootCause_Remove.TabIndex = 1;
            this.btnRootCause_Remove.Text = "Remove";
            this.btnRootCause_Remove.UseVisualStyleBackColor = false;
            // 
            // btnRootCause_Edit
            // 
            this.btnRootCause_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnRootCause_Edit.Location = new System.Drawing.Point(175, 4);
            this.btnRootCause_Edit.Name = "btnRootCause_Edit";
            this.btnRootCause_Edit.Size = new System.Drawing.Size(80, 23);
            this.btnRootCause_Edit.TabIndex = 2;
            this.btnRootCause_Edit.Text = "Edit";
            this.btnRootCause_Edit.UseVisualStyleBackColor = false;
            // 
            // btnRootCause_Add
            // 
            this.btnRootCause_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRootCause_Add.Location = new System.Drawing.Point(3, 4);
            this.btnRootCause_Add.Name = "btnRootCause_Add";
            this.btnRootCause_Add.Size = new System.Drawing.Size(80, 23);
            this.btnRootCause_Add.TabIndex = 0;
            this.btnRootCause_Add.Text = "Add";
            this.btnRootCause_Add.UseVisualStyleBackColor = false;
            // 
            // grpRepairTypes
            // 
            this.grpRepairTypes.Controls.Add(this.olvRepairTypes);
            this.grpRepairTypes.Controls.Add(this.pnlRepairTypes_Control);
            this.grpRepairTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRepairTypes.Location = new System.Drawing.Point(394, 0);
            this.grpRepairTypes.Name = "grpRepairTypes";
            this.grpRepairTypes.Size = new System.Drawing.Size(872, 928);
            this.grpRepairTypes.TabIndex = 4;
            this.grpRepairTypes.TabStop = false;
            this.grpRepairTypes.Text = "Assembly Repair Types";
            // 
            // olvRepairTypes
            // 
            this.olvRepairTypes.AllColumns.Add(this.olvColRepairType_Description);
            this.olvRepairTypes.CellEditTabChangesRows = true;
            this.olvRepairTypes.CellEditUseWholeCell = false;
            this.olvRepairTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRepairType_Description});
            this.olvRepairTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRepairTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRepairTypes.EmptyListMsg = "No repair types defined.";
            this.olvRepairTypes.FullRowSelect = true;
            this.olvRepairTypes.GridLines = true;
            this.olvRepairTypes.HasCollapsibleGroups = false;
            this.olvRepairTypes.HideSelection = false;
            this.olvRepairTypes.Location = new System.Drawing.Point(3, 46);
            this.olvRepairTypes.MultiSelect = false;
            this.olvRepairTypes.Name = "olvRepairTypes";
            this.olvRepairTypes.SelectAllOnControlA = false;
            this.olvRepairTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvRepairTypes.ShowCommandMenuOnRightClick = true;
            this.olvRepairTypes.ShowGroups = false;
            this.olvRepairTypes.ShowItemCountOnGroups = true;
            this.olvRepairTypes.Size = new System.Drawing.Size(866, 879);
            this.olvRepairTypes.SortGroupItemsByPrimaryColumn = false;
            this.olvRepairTypes.TabIndex = 1;
            this.olvRepairTypes.UseCompatibleStateImageBehavior = false;
            this.olvRepairTypes.View = System.Windows.Forms.View.Details;
            // 
            // olvColRepairType_Description
            // 
            this.olvColRepairType_Description.AspectName = "Description";
            this.olvColRepairType_Description.FillsFreeSpace = true;
            this.olvColRepairType_Description.Groupable = false;
            this.olvColRepairType_Description.Hideable = false;
            this.olvColRepairType_Description.IsEditable = false;
            this.olvColRepairType_Description.Text = "Description";
            this.olvColRepairType_Description.Width = 300;
            // 
            // pnlRepairTypes_Control
            // 
            this.pnlRepairTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRepairTypes_Control.Controls.Add(this.btnRepairType_Remove);
            this.pnlRepairTypes_Control.Controls.Add(this.btnRepairType_Edit);
            this.pnlRepairTypes_Control.Controls.Add(this.btnRepairType_Add);
            this.pnlRepairTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepairTypes_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlRepairTypes_Control.Name = "pnlRepairTypes_Control";
            this.pnlRepairTypes_Control.Size = new System.Drawing.Size(866, 30);
            this.pnlRepairTypes_Control.TabIndex = 0;
            // 
            // btnRepairType_Remove
            // 
            this.btnRepairType_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRepairType_Remove.Location = new System.Drawing.Point(89, 4);
            this.btnRepairType_Remove.Name = "btnRepairType_Remove";
            this.btnRepairType_Remove.Size = new System.Drawing.Size(80, 23);
            this.btnRepairType_Remove.TabIndex = 1;
            this.btnRepairType_Remove.Text = "Remove";
            this.btnRepairType_Remove.UseVisualStyleBackColor = false;
            // 
            // btnRepairType_Edit
            // 
            this.btnRepairType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnRepairType_Edit.Location = new System.Drawing.Point(175, 4);
            this.btnRepairType_Edit.Name = "btnRepairType_Edit";
            this.btnRepairType_Edit.Size = new System.Drawing.Size(80, 23);
            this.btnRepairType_Edit.TabIndex = 2;
            this.btnRepairType_Edit.Text = "Edit";
            this.btnRepairType_Edit.UseVisualStyleBackColor = false;
            // 
            // btnRepairType_Add
            // 
            this.btnRepairType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRepairType_Add.Location = new System.Drawing.Point(3, 4);
            this.btnRepairType_Add.Name = "btnRepairType_Add";
            this.btnRepairType_Add.Size = new System.Drawing.Size(80, 23);
            this.btnRepairType_Add.TabIndex = 0;
            this.btnRepairType_Add.Text = "Add";
            this.btnRepairType_Add.UseVisualStyleBackColor = false;
            // 
            // grpFailureTypes
            // 
            this.grpFailureTypes.Controls.Add(this.olvFailureTypes);
            this.grpFailureTypes.Controls.Add(this.pnlFailureTypes_Control);
            this.grpFailureTypes.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpFailureTypes.Location = new System.Drawing.Point(0, 0);
            this.grpFailureTypes.Name = "grpFailureTypes";
            this.grpFailureTypes.Size = new System.Drawing.Size(394, 928);
            this.grpFailureTypes.TabIndex = 3;
            this.grpFailureTypes.TabStop = false;
            this.grpFailureTypes.Text = "Assembly Failure Types";
            // 
            // olvFailureTypes
            // 
            this.olvFailureTypes.AllColumns.Add(this.olvColFailureType_Description);
            this.olvFailureTypes.CellEditTabChangesRows = true;
            this.olvFailureTypes.CellEditUseWholeCell = false;
            this.olvFailureTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColFailureType_Description});
            this.olvFailureTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFailureTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvFailureTypes.EmptyListMsg = "No failure types defined.";
            this.olvFailureTypes.FullRowSelect = true;
            this.olvFailureTypes.GridLines = true;
            this.olvFailureTypes.HasCollapsibleGroups = false;
            this.olvFailureTypes.HideSelection = false;
            this.olvFailureTypes.Location = new System.Drawing.Point(3, 46);
            this.olvFailureTypes.MultiSelect = false;
            this.olvFailureTypes.Name = "olvFailureTypes";
            this.olvFailureTypes.SelectAllOnControlA = false;
            this.olvFailureTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvFailureTypes.ShowCommandMenuOnRightClick = true;
            this.olvFailureTypes.ShowGroups = false;
            this.olvFailureTypes.ShowItemCountOnGroups = true;
            this.olvFailureTypes.Size = new System.Drawing.Size(388, 879);
            this.olvFailureTypes.SortGroupItemsByPrimaryColumn = false;
            this.olvFailureTypes.TabIndex = 1;
            this.olvFailureTypes.UseCompatibleStateImageBehavior = false;
            this.olvFailureTypes.View = System.Windows.Forms.View.Details;
            // 
            // olvColFailureType_Description
            // 
            this.olvColFailureType_Description.AspectName = "Description";
            this.olvColFailureType_Description.FillsFreeSpace = true;
            this.olvColFailureType_Description.Groupable = false;
            this.olvColFailureType_Description.Hideable = false;
            this.olvColFailureType_Description.IsEditable = false;
            this.olvColFailureType_Description.Text = "Description";
            this.olvColFailureType_Description.Width = 300;
            // 
            // pnlFailureTypes_Control
            // 
            this.pnlFailureTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlFailureTypes_Control.Controls.Add(this.btnFailureType_Remove);
            this.pnlFailureTypes_Control.Controls.Add(this.btnFailureType_Edit);
            this.pnlFailureTypes_Control.Controls.Add(this.btnFailureType_Add);
            this.pnlFailureTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFailureTypes_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlFailureTypes_Control.Name = "pnlFailureTypes_Control";
            this.pnlFailureTypes_Control.Size = new System.Drawing.Size(388, 30);
            this.pnlFailureTypes_Control.TabIndex = 0;
            // 
            // btnFailureType_Remove
            // 
            this.btnFailureType_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFailureType_Remove.Location = new System.Drawing.Point(89, 4);
            this.btnFailureType_Remove.Name = "btnFailureType_Remove";
            this.btnFailureType_Remove.Size = new System.Drawing.Size(80, 23);
            this.btnFailureType_Remove.TabIndex = 1;
            this.btnFailureType_Remove.Text = "Remove";
            this.btnFailureType_Remove.UseVisualStyleBackColor = false;
            // 
            // btnFailureType_Edit
            // 
            this.btnFailureType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnFailureType_Edit.Location = new System.Drawing.Point(175, 4);
            this.btnFailureType_Edit.Name = "btnFailureType_Edit";
            this.btnFailureType_Edit.Size = new System.Drawing.Size(80, 23);
            this.btnFailureType_Edit.TabIndex = 2;
            this.btnFailureType_Edit.Text = "Edit";
            this.btnFailureType_Edit.UseVisualStyleBackColor = false;
            // 
            // btnFailureType_Add
            // 
            this.btnFailureType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFailureType_Add.Location = new System.Drawing.Point(3, 4);
            this.btnFailureType_Add.Name = "btnFailureType_Add";
            this.btnFailureType_Add.Size = new System.Drawing.Size(80, 23);
            this.btnFailureType_Add.TabIndex = 0;
            this.btnFailureType_Add.Text = "Add";
            this.btnFailureType_Add.UseVisualStyleBackColor = false;
            // 
            // tabRmaComponents
            // 
            this.tabRmaComponents.Controls.Add(this.panel3);
            this.tabRmaComponents.Location = new System.Drawing.Point(4, 22);
            this.tabRmaComponents.Name = "tabRmaComponents";
            this.tabRmaComponents.Size = new System.Drawing.Size(1266, 928);
            this.tabRmaComponents.TabIndex = 12;
            this.tabRmaComponents.Text = "RMA Components";
            this.tabRmaComponents.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.olvComponents);
            this.panel3.Controls.Add(this.pnlControl);
            this.panel3.Controls.Add(this.lblDivider);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1266, 928);
            this.panel3.TabIndex = 5;
            // 
            // olvComponents
            // 
            this.olvComponents.AllColumns.Add(this.olvColComponent_ID);
            this.olvComponents.AllColumns.Add(this.olvColComponent_CompNumber);
            this.olvComponents.AllColumns.Add(this.olvColComponent_Description);
            this.olvComponents.AllColumns.Add(this.olvColComponent_Location);
            this.olvComponents.AllColumns.Add(this.olvColComponent_Cost);
            this.olvComponents.AllColumns.Add(this.olvColComponent_InventoryQty);
            this.olvComponents.CellEditTabChangesRows = true;
            this.olvComponents.CellEditUseWholeCell = false;
            this.olvComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColComponent_ID,
            this.olvColComponent_CompNumber,
            this.olvColComponent_Description,
            this.olvColComponent_Location,
            this.olvColComponent_Cost,
            this.olvColComponent_InventoryQty});
            this.olvComponents.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvComponents.EmptyListMsg = "No components defined.";
            this.olvComponents.FullRowSelect = true;
            this.olvComponents.GridLines = true;
            this.olvComponents.HasCollapsibleGroups = false;
            this.olvComponents.HideSelection = false;
            this.olvComponents.Location = new System.Drawing.Point(0, 31);
            this.olvComponents.MultiSelect = false;
            this.olvComponents.Name = "olvComponents";
            this.olvComponents.SelectAllOnControlA = false;
            this.olvComponents.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvComponents.ShowCommandMenuOnRightClick = true;
            this.olvComponents.ShowGroups = false;
            this.olvComponents.ShowItemCountOnGroups = true;
            this.olvComponents.Size = new System.Drawing.Size(1266, 897);
            this.olvComponents.SortGroupItemsByPrimaryColumn = false;
            this.olvComponents.TabIndex = 0;
            this.olvComponents.UseCompatibleStateImageBehavior = false;
            this.olvComponents.View = System.Windows.Forms.View.Details;
            // 
            // olvColComponent_ID
            // 
            this.olvColComponent_ID.AspectName = "ID";
            this.olvColComponent_ID.Groupable = false;
            this.olvColComponent_ID.IsEditable = false;
            this.olvColComponent_ID.IsVisible = false;
            this.olvColComponent_ID.Searchable = false;
            this.olvColComponent_ID.Sortable = false;
            this.olvColComponent_ID.Text = "ID";
            this.olvColComponent_ID.Width = 0;
            // 
            // olvColComponent_CompNumber
            // 
            this.olvColComponent_CompNumber.AspectName = "ComponentNumber";
            this.olvColComponent_CompNumber.Groupable = false;
            this.olvColComponent_CompNumber.Hideable = false;
            this.olvColComponent_CompNumber.IsEditable = false;
            this.olvColComponent_CompNumber.Text = "Component #";
            this.olvColComponent_CompNumber.Width = 140;
            // 
            // olvColComponent_Description
            // 
            this.olvColComponent_Description.AspectName = "Description";
            this.olvColComponent_Description.FillsFreeSpace = true;
            this.olvColComponent_Description.Groupable = false;
            this.olvColComponent_Description.Hideable = false;
            this.olvColComponent_Description.IsEditable = false;
            this.olvColComponent_Description.Text = "Description";
            this.olvColComponent_Description.Width = 300;
            // 
            // olvColComponent_Location
            // 
            this.olvColComponent_Location.AspectName = "Location";
            this.olvColComponent_Location.Hideable = false;
            this.olvColComponent_Location.IsEditable = false;
            this.olvColComponent_Location.Text = "Location";
            this.olvColComponent_Location.Width = 70;
            // 
            // olvColComponent_Cost
            // 
            this.olvColComponent_Cost.AspectName = "Cost";
            this.olvColComponent_Cost.AspectToStringFormat = "{0:0.000}";
            this.olvColComponent_Cost.AutoCompleteEditor = false;
            this.olvColComponent_Cost.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColComponent_Cost.Groupable = false;
            this.olvColComponent_Cost.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColComponent_Cost.Hideable = false;
            this.olvColComponent_Cost.IsEditable = false;
            this.olvColComponent_Cost.Searchable = false;
            this.olvColComponent_Cost.Text = "Cost";
            this.olvColComponent_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColComponent_InventoryQty
            // 
            this.olvColComponent_InventoryQty.AspectName = "InventoryQty";
            this.olvColComponent_InventoryQty.AutoCompleteEditor = false;
            this.olvColComponent_InventoryQty.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColComponent_InventoryQty.Groupable = false;
            this.olvColComponent_InventoryQty.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColComponent_InventoryQty.Hideable = false;
            this.olvColComponent_InventoryQty.IsEditable = false;
            this.olvColComponent_InventoryQty.Searchable = false;
            this.olvColComponent_InventoryQty.Text = "Inv. Qty";
            this.olvColComponent_InventoryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlControl.Controls.Add(this.button4);
            this.pnlControl.Controls.Add(this.btnEnableDisable);
            this.pnlControl.Controls.Add(this.lblQty);
            this.pnlControl.Controls.Add(this.txtQty);
            this.pnlControl.Controls.Add(this.btnDelete);
            this.pnlControl.Controls.Add(this.button5);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 1);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1266, 30);
            this.pnlControl.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(387, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "&Edit Component";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnEnableDisable
            // 
            this.btnEnableDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEnableDisable.Location = new System.Drawing.Point(259, 4);
            this.btnEnableDisable.Name = "btnEnableDisable";
            this.btnEnableDisable.Size = new System.Drawing.Size(120, 23);
            this.btnEnableDisable.TabIndex = 11;
            this.btnEnableDisable.Text = "Disable Component";
            this.btnEnableDisable.UseVisualStyleBackColor = false;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(1128, 9);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(69, 13);
            this.lblQty.TabIndex = 9;
            this.lblQty.Text = "Components:";
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1203, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(60, 22);
            this.txtQty.TabIndex = 10;
            this.txtQty.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(131, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Component";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "&Add Component";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.Black;
            this.lblDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDivider.Location = new System.Drawing.Point(0, 0);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(1266, 1);
            this.lblDivider.TabIndex = 11;
            // 
            // tabRMAAreasZones
            // 
            this.tabRMAAreasZones.Controls.Add(this.pnlAreas);
            this.tabRMAAreasZones.Controls.Add(this.pnlZones);
            this.tabRMAAreasZones.Location = new System.Drawing.Point(4, 22);
            this.tabRMAAreasZones.Name = "tabRMAAreasZones";
            this.tabRMAAreasZones.Size = new System.Drawing.Size(1266, 928);
            this.tabRMAAreasZones.TabIndex = 13;
            this.tabRMAAreasZones.Text = "RMA Areas & Zones";
            this.tabRMAAreasZones.UseVisualStyleBackColor = true;
            // 
            // pnlAreas
            // 
            this.pnlAreas.Controls.Add(this.olvRmaAreas);
            this.pnlAreas.Controls.Add(this.pnlAreaControl);
            this.pnlAreas.Controls.Add(this.lblAreaInfo);
            this.pnlAreas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAreas.Location = new System.Drawing.Point(0, 0);
            this.pnlAreas.Name = "pnlAreas";
            this.pnlAreas.Size = new System.Drawing.Size(565, 928);
            this.pnlAreas.TabIndex = 8;
            // 
            // olvRmaAreas
            // 
            this.olvRmaAreas.AllColumns.Add(this.olcAreaName);
            this.olvRmaAreas.CellEditTabChangesRows = true;
            this.olvRmaAreas.CellEditUseWholeCell = false;
            this.olvRmaAreas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcAreaName});
            this.olvRmaAreas.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRmaAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRmaAreas.EmptyListMsg = "No RMA zones defined.";
            this.olvRmaAreas.FullRowSelect = true;
            this.olvRmaAreas.GridLines = true;
            this.olvRmaAreas.HasCollapsibleGroups = false;
            this.olvRmaAreas.HideSelection = false;
            this.olvRmaAreas.Location = new System.Drawing.Point(0, 43);
            this.olvRmaAreas.MultiSelect = false;
            this.olvRmaAreas.Name = "olvRmaAreas";
            this.olvRmaAreas.SelectAllOnControlA = false;
            this.olvRmaAreas.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvRmaAreas.ShowCommandMenuOnRightClick = true;
            this.olvRmaAreas.ShowGroups = false;
            this.olvRmaAreas.ShowItemCountOnGroups = true;
            this.olvRmaAreas.Size = new System.Drawing.Size(565, 885);
            this.olvRmaAreas.SortGroupItemsByPrimaryColumn = false;
            this.olvRmaAreas.TabIndex = 1;
            this.olvRmaAreas.UseCompatibleStateImageBehavior = false;
            this.olvRmaAreas.View = System.Windows.Forms.View.Details;
            // 
            // olcAreaName
            // 
            this.olcAreaName.AspectName = "AreaName";
            this.olcAreaName.FillsFreeSpace = true;
            this.olcAreaName.Groupable = false;
            this.olcAreaName.Hideable = false;
            this.olcAreaName.IsEditable = false;
            this.olcAreaName.Text = "Area";
            this.olcAreaName.Width = 300;
            // 
            // pnlAreaControl
            // 
            this.pnlAreaControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAreaControl.Controls.Add(this.btnRMAArea_Edit);
            this.pnlAreaControl.Controls.Add(this.btnRMAArea_Remove);
            this.pnlAreaControl.Controls.Add(this.btnRMAArea_Add);
            this.pnlAreaControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAreaControl.Location = new System.Drawing.Point(0, 13);
            this.pnlAreaControl.Name = "pnlAreaControl";
            this.pnlAreaControl.Size = new System.Drawing.Size(565, 30);
            this.pnlAreaControl.TabIndex = 6;
            // 
            // btnRMAArea_Edit
            // 
            this.btnRMAArea_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnRMAArea_Edit.Location = new System.Drawing.Point(159, 4);
            this.btnRMAArea_Edit.Name = "btnRMAArea_Edit";
            this.btnRMAArea_Edit.Size = new System.Drawing.Size(70, 23);
            this.btnRMAArea_Edit.TabIndex = 2;
            this.btnRMAArea_Edit.Text = "Edit";
            this.btnRMAArea_Edit.UseVisualStyleBackColor = false;
            // 
            // btnRMAArea_Remove
            // 
            this.btnRMAArea_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRMAArea_Remove.Location = new System.Drawing.Point(81, 4);
            this.btnRMAArea_Remove.Name = "btnRMAArea_Remove";
            this.btnRMAArea_Remove.Size = new System.Drawing.Size(70, 23);
            this.btnRMAArea_Remove.TabIndex = 1;
            this.btnRMAArea_Remove.Text = "Remove";
            this.btnRMAArea_Remove.UseVisualStyleBackColor = false;
            // 
            // btnRMAArea_Add
            // 
            this.btnRMAArea_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRMAArea_Add.Location = new System.Drawing.Point(3, 4);
            this.btnRMAArea_Add.Name = "btnRMAArea_Add";
            this.btnRMAArea_Add.Size = new System.Drawing.Size(70, 23);
            this.btnRMAArea_Add.TabIndex = 0;
            this.btnRMAArea_Add.Text = "Add";
            this.btnRMAArea_Add.UseVisualStyleBackColor = false;
            // 
            // lblAreaInfo
            // 
            this.lblAreaInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAreaInfo.Location = new System.Drawing.Point(0, 0);
            this.lblAreaInfo.Name = "lblAreaInfo";
            this.lblAreaInfo.Size = new System.Drawing.Size(565, 13);
            this.lblAreaInfo.TabIndex = 0;
            this.lblAreaInfo.Text = "Areas are sections of the RMA storage and repair facility.";
            // 
            // pnlZones
            // 
            this.pnlZones.Controls.Add(this.olvRmaZones);
            this.pnlZones.Controls.Add(this.pnlZoneControl);
            this.pnlZones.Controls.Add(this.label3);
            this.pnlZones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlZones.Location = new System.Drawing.Point(568, 0);
            this.pnlZones.Name = "pnlZones";
            this.pnlZones.Size = new System.Drawing.Size(698, 928);
            this.pnlZones.TabIndex = 7;
            // 
            // olvRmaZones
            // 
            this.olvRmaZones.AllColumns.Add(this.olcZone);
            this.olvRmaZones.AllColumns.Add(this.olvColumn3);
            this.olvRmaZones.CellEditTabChangesRows = true;
            this.olvRmaZones.CellEditUseWholeCell = false;
            this.olvRmaZones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcZone,
            this.olvColumn3});
            this.olvRmaZones.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRmaZones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRmaZones.EmptyListMsg = "No RMA zones defined.";
            this.olvRmaZones.FullRowSelect = true;
            this.olvRmaZones.GridLines = true;
            this.olvRmaZones.HasCollapsibleGroups = false;
            this.olvRmaZones.HideSelection = false;
            this.olvRmaZones.Location = new System.Drawing.Point(0, 43);
            this.olvRmaZones.Name = "olvRmaZones";
            this.olvRmaZones.SelectAllOnControlA = false;
            this.olvRmaZones.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvRmaZones.ShowCommandMenuOnRightClick = true;
            this.olvRmaZones.ShowGroups = false;
            this.olvRmaZones.ShowItemCountOnGroups = true;
            this.olvRmaZones.Size = new System.Drawing.Size(698, 885);
            this.olvRmaZones.SortGroupItemsByPrimaryColumn = false;
            this.olvRmaZones.TabIndex = 1;
            this.olvRmaZones.UseCompatibleStateImageBehavior = false;
            this.olvRmaZones.View = System.Windows.Forms.View.Details;
            // 
            // olcZone
            // 
            this.olcZone.AspectName = "ZoneName";
            this.olcZone.FillsFreeSpace = true;
            this.olcZone.Groupable = false;
            this.olcZone.Hideable = false;
            this.olcZone.IsEditable = false;
            this.olcZone.Text = "Zone";
            this.olcZone.Width = 300;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "IsDefault";
            this.olvColumn3.Text = "Default";
            // 
            // pnlZoneControl
            // 
            this.pnlZoneControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlZoneControl.Controls.Add(this.btnRmaZone_SetDefault);
            this.pnlZoneControl.Controls.Add(this.btnRmaZone_PrintLabel);
            this.pnlZoneControl.Controls.Add(this.btnRmaZone_Edit);
            this.pnlZoneControl.Controls.Add(this.btnRmaZone_Remove);
            this.pnlZoneControl.Controls.Add(this.btnRmaZone_Add);
            this.pnlZoneControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZoneControl.Location = new System.Drawing.Point(0, 13);
            this.pnlZoneControl.Name = "pnlZoneControl";
            this.pnlZoneControl.Size = new System.Drawing.Size(698, 30);
            this.pnlZoneControl.TabIndex = 6;
            // 
            // btnRmaZone_SetDefault
            // 
            this.btnRmaZone_SetDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRmaZone_SetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRmaZone_SetDefault.Location = new System.Drawing.Point(545, 4);
            this.btnRmaZone_SetDefault.Name = "btnRmaZone_SetDefault";
            this.btnRmaZone_SetDefault.Size = new System.Drawing.Size(70, 23);
            this.btnRmaZone_SetDefault.TabIndex = 4;
            this.btnRmaZone_SetDefault.Text = "Set Default";
            this.btnRmaZone_SetDefault.UseVisualStyleBackColor = false;
            // 
            // btnRmaZone_PrintLabel
            // 
            this.btnRmaZone_PrintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRmaZone_PrintLabel.BackColor = System.Drawing.SystemColors.Control;
            this.btnRmaZone_PrintLabel.Location = new System.Drawing.Point(621, 4);
            this.btnRmaZone_PrintLabel.Name = "btnRmaZone_PrintLabel";
            this.btnRmaZone_PrintLabel.Size = new System.Drawing.Size(74, 23);
            this.btnRmaZone_PrintLabel.TabIndex = 3;
            this.btnRmaZone_PrintLabel.Text = "Print Label";
            this.btnRmaZone_PrintLabel.UseVisualStyleBackColor = false;
            // 
            // btnRmaZone_Edit
            // 
            this.btnRmaZone_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnRmaZone_Edit.Location = new System.Drawing.Point(159, 4);
            this.btnRmaZone_Edit.Name = "btnRmaZone_Edit";
            this.btnRmaZone_Edit.Size = new System.Drawing.Size(70, 23);
            this.btnRmaZone_Edit.TabIndex = 2;
            this.btnRmaZone_Edit.Text = "Edit";
            this.btnRmaZone_Edit.UseVisualStyleBackColor = false;
            // 
            // btnRmaZone_Remove
            // 
            this.btnRmaZone_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRmaZone_Remove.Location = new System.Drawing.Point(81, 4);
            this.btnRmaZone_Remove.Name = "btnRmaZone_Remove";
            this.btnRmaZone_Remove.Size = new System.Drawing.Size(70, 23);
            this.btnRmaZone_Remove.TabIndex = 1;
            this.btnRmaZone_Remove.Text = "Remove";
            this.btnRmaZone_Remove.UseVisualStyleBackColor = false;
            // 
            // btnRmaZone_Add
            // 
            this.btnRmaZone_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRmaZone_Add.Location = new System.Drawing.Point(3, 4);
            this.btnRmaZone_Add.Name = "btnRmaZone_Add";
            this.btnRmaZone_Add.Size = new System.Drawing.Size(70, 23);
            this.btnRmaZone_Add.TabIndex = 0;
            this.btnRmaZone_Add.Text = "Add";
            this.btnRmaZone_Add.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(698, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zones are specific locations within an area.";
            // 
            // tabAdminEmails
            // 
            this.tabAdminEmails.Controls.Add(this.panel4);
            this.tabAdminEmails.Location = new System.Drawing.Point(4, 22);
            this.tabAdminEmails.Name = "tabAdminEmails";
            this.tabAdminEmails.Size = new System.Drawing.Size(1266, 928);
            this.tabAdminEmails.TabIndex = 14;
            this.tabAdminEmails.Text = "Admin Email";
            this.tabAdminEmails.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.olvAdminEmails);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1266, 928);
            this.panel4.TabIndex = 3;
            // 
            // olvAdminEmails
            // 
            this.olvAdminEmails.AllColumns.Add(this.olvColName);
            this.olvAdminEmails.AllColumns.Add(this.olvColumn4);
            this.olvAdminEmails.CellEditUseWholeCell = false;
            this.olvAdminEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColName,
            this.olvColumn4});
            this.olvAdminEmails.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAdminEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAdminEmails.FullRowSelect = true;
            this.olvAdminEmails.GridLines = true;
            this.olvAdminEmails.HasCollapsibleGroups = false;
            this.olvAdminEmails.Location = new System.Drawing.Point(0, 30);
            this.olvAdminEmails.MultiSelect = false;
            this.olvAdminEmails.Name = "olvAdminEmails";
            this.olvAdminEmails.SelectAllOnControlA = false;
            this.olvAdminEmails.SelectColumnsOnRightClick = false;
            this.olvAdminEmails.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvAdminEmails.ShowFilterMenuOnRightClick = false;
            this.olvAdminEmails.ShowGroups = false;
            this.olvAdminEmails.ShowImagesOnSubItems = true;
            this.olvAdminEmails.Size = new System.Drawing.Size(1266, 898);
            this.olvAdminEmails.TabIndex = 0;
            this.olvAdminEmails.UseCompatibleStateImageBehavior = false;
            this.olvAdminEmails.View = System.Windows.Forms.View.Details;
            // 
            // olvColName
            // 
            this.olvColName.AspectName = "Name";
            this.olvColName.Text = "Name";
            this.olvColName.Width = 180;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Email";
            this.olvColumn4.FillsFreeSpace = true;
            this.olvColumn4.Text = "Email Address";
            this.olvColumn4.Width = 410;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1266, 30);
            this.panel5.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(175, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(89, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // FormAdmin_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 954);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin_Config";
            this.Text = "FormAdmin_Config";
            this.tabControl1.ResumeLayout(false);
            this.tabOutputMethods.ResumeLayout(false);
            this.pnlOutputMethod_Editor.ResumeLayout(false);
            this.pnlOutputMethod_Editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvOutputMethods)).EndInit();
            this.pnlOutputMethods_Control.ResumeLayout(false);
            this.tabCabinetTypes.ResumeLayout(false);
            this.pnlCabinetType_Editor.ResumeLayout(false);
            this.pnlCabinetType_Editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCabinetTypes)).EndInit();
            this.pnlCabinetTypes_Control.ResumeLayout(false);
            this.tabAssemblies.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).EndInit();
            this.pnlAssembly_Control.ResumeLayout(false);
            this.pnlAssembly_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTypes)).EndInit();
            this.pnlTypes_Control.ResumeLayout(false);
            this.pnlTypes_Control.PerformLayout();
            this.pnlAssemblyType_Bottom.ResumeLayout(false);
            this.pnlAssemblyType_BottomLeft.ResumeLayout(false);
            this.pnlType_BottomRight.ResumeLayout(false);
            this.pnlType_BottomRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCategories)).EndInit();
            this.pnlCategory_Control.ResumeLayout(false);
            this.pnlCategory_Control.PerformLayout();
            this.pnlAssemblyCategory_Bottom.ResumeLayout(false);
            this.pnlAssemblyCategory_BottomLeft.ResumeLayout(false);
            this.pnlAssemblyCategory_BottomRight.ResumeLayout(false);
            this.pnlAssemblyCategory_BottomRight.PerformLayout();
            this.tabCameras.ResumeLayout(false);
            this.pnlCameraTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvCameraTypes)).EndInit();
            this.pnlCameraTypes_Control.ResumeLayout(false);
            this.tabAssetTags.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvTags)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabRentals.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRentalCompanies.ResumeLayout(false);
            this.pnlRentalCompany_Editor.ResumeLayout(false);
            this.pnlRentalCompany_Editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalDivisions)).EndInit();
            this.pnlNumberFormats.ResumeLayout(false);
            this.pnlNumberFormats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalCompanies)).EndInit();
            this.pnlRentalCompanies_Control.ResumeLayout(false);
            this.tabLiftTypes.ResumeLayout(false);
            this.pnlLiftType_Editor.ResumeLayout(false);
            this.pnlLiftType_Editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLiftTypes)).EndInit();
            this.pnlLiftTypes_Control.ResumeLayout(false);
            this.tabSalesPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvSalespeople)).EndInit();
            this.pnlSalespeople_Control.ResumeLayout(false);
            this.tabShippingMethods.ResumeLayout(false);
            this.grpSymptoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvShipmentMethods)).EndInit();
            this.pnlSymptoms_Control.ResumeLayout(false);
            this.tabSymptonsSolutions.ResumeLayout(false);
            this.pnlSymptoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlSolutions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvSolutions)).EndInit();
            this.pnlSolutions_Control.ResumeLayout(false);
            this.tabPMA.ResumeLayout(false);
            this.pnlPMAs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPMAs)).EndInit();
            this.pnlPMAs_Control.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.pnlUser_Create.ResumeLayout(false);
            this.pnlUser_Create.PerformLayout();
            this.pnlUser_Modify.ResumeLayout(false);
            this.pnlUser_Modify.PerformLayout();
            this.tabRMAFailures.ResumeLayout(false);
            this.grpRootCauses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRootCauses)).EndInit();
            this.pnlRootCauses_Control.ResumeLayout(false);
            this.grpRepairTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRepairTypes)).EndInit();
            this.pnlRepairTypes_Control.ResumeLayout(false);
            this.grpFailureTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvFailureTypes)).EndInit();
            this.pnlFailureTypes_Control.ResumeLayout(false);
            this.tabRmaComponents.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvComponents)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.tabRMAAreasZones.ResumeLayout(false);
            this.pnlAreas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRmaAreas)).EndInit();
            this.pnlAreaControl.ResumeLayout(false);
            this.pnlZones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRmaZones)).EndInit();
            this.pnlZoneControl.ResumeLayout(false);
            this.tabAdminEmails.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAdminEmails)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOutputMethods;
        private System.Windows.Forms.Panel pnlOutputMethod_Editor;
        private System.Windows.Forms.Button btnOutputMethod_Editor_Cancel;
        private System.Windows.Forms.Button btnOutputMethod_Editor_Save;
        private System.Windows.Forms.TextBox txtOutputMethod_Description;
        private System.Windows.Forms.Label lblOutputMethod_Description;
        private BrightIdeasSoftware.ObjectListView olvOutputMethods;
        private BrightIdeasSoftware.OLVColumn olcOutputMethodDescription;
        private System.Windows.Forms.Panel pnlOutputMethods_Control;
        private System.Windows.Forms.Button btnOutputMethod_Delete;
        private System.Windows.Forms.Button btnOutputMethod_Edit;
        private System.Windows.Forms.Button btnOutputMethod_Add;
        private System.Windows.Forms.TabPage tabCabinetTypes;
        private System.Windows.Forms.Panel pnlCabinetType_Editor;
        private System.Windows.Forms.TextBox txtCabinetType_Description;
        private System.Windows.Forms.Label lblCabinetType_Description;
        private System.Windows.Forms.Button btnCabinetType_Editor_Cancel;
        private System.Windows.Forms.Button btnCabinetType_Editor_Save;
        private BrightIdeasSoftware.ObjectListView olvCabinetTypes;
        private BrightIdeasSoftware.OLVColumn olcCabinetType_Description;
        private System.Windows.Forms.Panel pnlCabinetTypes_Control;
        private System.Windows.Forms.Button btnCabinetType_Delete;
        private System.Windows.Forms.Button btnCabinetType_Edit;
        private System.Windows.Forms.Button btnCabinetType_Add;
        private System.Windows.Forms.TabPage tabAssemblies;
        private System.Windows.Forms.TabPage tabCameras;
        private System.Windows.Forms.TabPage tabAssetTags;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.TabPage tabSalesPeople;
        private System.Windows.Forms.TabPage tabShippingMethods;
        private System.Windows.Forms.TabPage tabSymptonsSolutions;
        private System.Windows.Forms.TabPage tabPMA;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabRMAFailures;
        private System.Windows.Forms.TabPage tabRmaComponents;
        private System.Windows.Forms.TabPage tabRMAAreasZones;
        private System.Windows.Forms.Panel pnlContainer;
        private BrightIdeasSoftware.ObjectListView olvAssemblies;
        private BrightIdeasSoftware.OLVColumn olvColAssembly_ID;
        private BrightIdeasSoftware.OLVColumn olvColAssembly_AssyNumber;
        private BrightIdeasSoftware.OLVColumn olvColAssembly_Description;
        private BrightIdeasSoftware.OLVColumn olvColAssembly_Location;
        private BrightIdeasSoftware.OLVColumn olvColCost;
        private BrightIdeasSoftware.OLVColumn olvColInventoryQty;
        private System.Windows.Forms.Panel pnlAssembly_Control;
        private System.Windows.Forms.TextBox txtAssemblies_OfType;
        private System.Windows.Forms.Label lblAssemblies_OfType;
        private System.Windows.Forms.Button btnAssembly_Edit;
        private System.Windows.Forms.Button btnAssembly_EnableDisable;
        private System.Windows.Forms.Label lblAssembly_Qty;
        private System.Windows.Forms.TextBox txtAssembly_Qty;
        private System.Windows.Forms.Button btnAssembly_Delete;
        private System.Windows.Forms.Button btnAssembly_Add;
        private System.Windows.Forms.Label lblDivider1;
        private BrightIdeasSoftware.ObjectListView olvTypes;
        private BrightIdeasSoftware.OLVColumn olcType_ID;
        private BrightIdeasSoftware.OLVColumn olcType_Description;
        private BrightIdeasSoftware.OLVColumn olcType_SerialNumberFormat;
        private BrightIdeasSoftware.OLVColumn olcType_IsComputer;
        private BrightIdeasSoftware.OLVColumn olcType_AllowDiscard;
        private BrightIdeasSoftware.OLVColumn olcCustomsDescription;
        private BrightIdeasSoftware.OLVColumn olcTariffCode;
        private System.Windows.Forms.Panel pnlTypes_Control;
        private System.Windows.Forms.TextBox txtTypes_OfCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAssemblyType_Bottom;
        private System.Windows.Forms.Panel pnlAssemblyType_BottomLeft;
        private System.Windows.Forms.Button btnType_Edit;
        private System.Windows.Forms.Button btnType_Delete;
        private System.Windows.Forms.Button btnType_Add;
        private System.Windows.Forms.Panel pnlType_BottomRight;
        private System.Windows.Forms.Label lblType_Qty;
        private System.Windows.Forms.TextBox txtType_Qty;
        private System.Windows.Forms.Label lblDivider2;
        private BrightIdeasSoftware.ObjectListView olvCategories;
        private BrightIdeasSoftware.OLVColumn olcCategory_ID;
        private BrightIdeasSoftware.OLVColumn olcCategory_Description;
        private System.Windows.Forms.Panel pnlCategory_Control;
        private System.Windows.Forms.Panel pnlAssemblyCategory_Bottom;
        private System.Windows.Forms.Panel pnlAssemblyCategory_BottomLeft;
        private System.Windows.Forms.Button btnCategory_Edit;
        private System.Windows.Forms.Button btnCategory_Delete;
        private System.Windows.Forms.Button btnCategory_Add;
        private System.Windows.Forms.Panel pnlAssemblyCategory_BottomRight;
        private System.Windows.Forms.Label lblCategory_Qty;
        private System.Windows.Forms.TextBox txtCategory_Qty;
        private System.Windows.Forms.Label lblAssemblyCategories;
        private System.Windows.Forms.TabPage tabAdminEmails;
        private System.Windows.Forms.Panel pnlCameraTypes;
        private BrightIdeasSoftware.ObjectListView olvCameraTypes;
        private BrightIdeasSoftware.OLVColumn olvColDescription;
        private System.Windows.Forms.Panel pnlCameraTypes_Control;
        private System.Windows.Forms.Button btnCameraType_Edit;
        private System.Windows.Forms.Button btnCameraType_Remove;
        private System.Windows.Forms.Button btnCameraType_Add;
        private BrightIdeasSoftware.ObjectListView olvTags;
        private BrightIdeasSoftware.OLVColumn olvColTags;
        private BrightIdeasSoftware.OLVColumn olvColDesciption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssetTag_Edit;
        private System.Windows.Forms.Button btnAssetTag_Remove;
        private System.Windows.Forms.Button btnAssetTag_Add;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRentalCompanies;
        private System.Windows.Forms.Panel pnlRentalCompany_Editor;
        private System.Windows.Forms.Button btnRentalDivision_Delete;
        private System.Windows.Forms.Label lblDivisionEditHelp;
        private System.Windows.Forms.Button btnRentalDivision_Add;
        private System.Windows.Forms.Button btnRentalCompany_Editor_Cancel;
        private System.Windows.Forms.Button btnRentalCompany_Editor_Save;
        private BrightIdeasSoftware.ObjectListView olvRentalDivisions;
        private BrightIdeasSoftware.OLVColumn olcDivisionName;
        private BrightIdeasSoftware.OLVColumn olcDivisionAddress;
        private BrightIdeasSoftware.OLVColumn olcDivisionCity;
        private BrightIdeasSoftware.OLVColumn olcDivisionState;
        private BrightIdeasSoftware.OLVColumn olcDivisionZip;
        private BrightIdeasSoftware.OLVColumn olcDivisionCountry;
        private BrightIdeasSoftware.OLVColumn olcDivisionTelephone;
        private System.Windows.Forms.Panel pnlNumberFormats;
        private System.Windows.Forms.Label lblFormat_PickupNumber;
        private System.Windows.Forms.Label lblNumberFormatHelp;
        private System.Windows.Forms.Label lblFormat_EquipmentNumber;
        private System.Windows.Forms.Label lblReservationNumber;
        private System.Windows.Forms.Label lblFormat_ReservationNumber;
        private System.Windows.Forms.TextBox txtFormat_ReservationNumber;
        private System.Windows.Forms.CheckBox chkUse_PickupNumber;
        private System.Windows.Forms.CheckBox chkUse_ReservationNumber;
        private System.Windows.Forms.TextBox txtFormat_PickupNumber;
        private System.Windows.Forms.Label lblEquipmentNumber;
        private System.Windows.Forms.Label lblPickupNumber;
        private System.Windows.Forms.TextBox txtFormat_EquipmentNumber;
        private System.Windows.Forms.CheckBox chkUse_EquipmentNumber;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtRentalCompany_Name;
        private System.Windows.Forms.Label lblRentalCompany_Name;
        private BrightIdeasSoftware.ObjectListView olvRentalCompanies;
        private BrightIdeasSoftware.OLVColumn olcRentalCompany;
        private BrightIdeasSoftware.OLVColumn olcAccount;
        private BrightIdeasSoftware.OLVColumn olcTelephone;
        private System.Windows.Forms.Panel pnlRentalCompanies_Control;
        private System.Windows.Forms.Button btnRentalCompany_Delete;
        private System.Windows.Forms.Button btnRentalCompany_Edit;
        private System.Windows.Forms.Button btnRentalCompany_Add;
        private System.Windows.Forms.TabPage tabLiftTypes;
        private System.Windows.Forms.Panel pnlLiftType_Editor;
        private System.Windows.Forms.TextBox txtLiftType_Description;
        private System.Windows.Forms.Label lblLiftType_Description;
        private System.Windows.Forms.Button btnLiftType_Editor_Cancel;
        private System.Windows.Forms.Button btnLiftType_Editor_Save;
        private BrightIdeasSoftware.ObjectListView olvLiftTypes;
        private BrightIdeasSoftware.OLVColumn olcLiftType_Description;
        private System.Windows.Forms.Panel pnlLiftTypes_Control;
        private System.Windows.Forms.Button btnLiftType_Delete;
        private System.Windows.Forms.Button btnLiftType_Edit;
        private System.Windows.Forms.Button btnLiftType_Add;
        private BrightIdeasSoftware.ObjectListView olvSalespeople;
        private BrightIdeasSoftware.OLVColumn olvColFirstName;
        private BrightIdeasSoftware.OLVColumn olvColLastName;
        private BrightIdeasSoftware.OLVColumn olvColAddress;
        private BrightIdeasSoftware.OLVColumn olvColCity;
        private BrightIdeasSoftware.OLVColumn olvColState;
        private BrightIdeasSoftware.OLVColumn olvColZip;
        private BrightIdeasSoftware.OLVColumn olvColCountry;
        private BrightIdeasSoftware.OLVColumn olvColEmail;
        private BrightIdeasSoftware.OLVColumn olvColPhone_Office;
        private BrightIdeasSoftware.OLVColumn olvColPhone_Mobile;
        private System.Windows.Forms.Panel pnlSalespeople_Control;
        private System.Windows.Forms.Button btnSalesperson_Edit;
        private System.Windows.Forms.Button btnSalesperson_Remove;
        private System.Windows.Forms.Button btnSalesperson_Add;
        private System.Windows.Forms.GroupBox grpSymptoms;
        private BrightIdeasSoftware.ObjectListView olvShipmentMethods;
        private BrightIdeasSoftware.OLVColumn olcDisplayIndex;
        private BrightIdeasSoftware.OLVColumn olcDescription;
        private BrightIdeasSoftware.OLVColumn olcAbbreviation;
        private BrightIdeasSoftware.OLVColumn olcDefault;
        private System.Windows.Forms.Panel pnlSymptoms_Control;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlSymptoms;
        private BrightIdeasSoftware.ObjectListView olvSymptoms;
        private BrightIdeasSoftware.OLVColumn olcSymptom_Symptom;
        private BrightIdeasSoftware.OLVColumn olcSymptom_IsVisible;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSymptoms_Edit;
        private System.Windows.Forms.Button btnSymptoms_Remove;
        private System.Windows.Forms.Button btnSymptoms_Add;
        private System.Windows.Forms.Label lblOwnershipInformation;
        private System.Windows.Forms.Panel pnlSolutions;
        private BrightIdeasSoftware.ObjectListView olvSolutions;
        private BrightIdeasSoftware.OLVColumn olvColSolutions_Solution;
        private BrightIdeasSoftware.OLVColumn olvColSolutions_RequiresParts;
        private System.Windows.Forms.Panel pnlSolutions_Control;
        private System.Windows.Forms.Button btnSolutions_Edit;
        private System.Windows.Forms.Button btnSolutions_Remove;
        private System.Windows.Forms.Button btnSolutions_Add;
        private System.Windows.Forms.Label lblSolutions;
        private System.Windows.Forms.Panel pnlPMAs;
        private BrightIdeasSoftware.ObjectListView olvPMAs;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.Panel pnlPMAs_Control;
        private System.Windows.Forms.Button btnPMA_Edit;
        private System.Windows.Forms.Button btnPMA_Remove;
        private System.Windows.Forms.Button btnPMA_Add;
        private System.Windows.Forms.Panel pnlUser_Create;
        private System.Windows.Forms.RadioButton radCreateUser_UserType_SSR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radCreateUser_UserType_Moderator;
        private System.Windows.Forms.Label lblUser_Create;
        private System.Windows.Forms.TextBox txtCreateUser_Password_Confirm;
        private System.Windows.Forms.TextBox txtCreateUser_Login;
        private System.Windows.Forms.Label lblCreateUser_Password_Confirm;
        private System.Windows.Forms.Label lblCreateUser_FirstName;
        private System.Windows.Forms.TextBox txtCreateUser_Password;
        private System.Windows.Forms.Label lblCreateUser_Login;
        private System.Windows.Forms.Label lblCreateUser_Password;
        private System.Windows.Forms.Label lblCreateUser_LastName;
        private System.Windows.Forms.RadioButton radCreateUser_UserType_Administrator;
        private System.Windows.Forms.Label lblCreateUser_Email;
        private System.Windows.Forms.RadioButton radCreateUser_UserType_Standard;
        private System.Windows.Forms.TextBox txtCreateUser_FirstName;
        private System.Windows.Forms.Label lblCreateUser_UserType;
        private System.Windows.Forms.TextBox txtCreateUser_LastName;
        private System.Windows.Forms.TextBox txtCreateUser_Email;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Panel pnlUser_Modify;
        private System.Windows.Forms.RadioButton radModifyUser_UserType_SSR;
        private System.Windows.Forms.TextBox txtModifyUser_Pin_Confirm;
        private System.Windows.Forms.Label lblModifyUser_Pin_Confirm;
        private System.Windows.Forms.TextBox txtModifyUser_Pin;
        private System.Windows.Forms.Label lblModifyUser_Pin;
        private System.Windows.Forms.CheckBox radModifyUser_DisableLogin;
        private System.Windows.Forms.Label lblUser_Modify;
        private System.Windows.Forms.RadioButton radModifyUser_UserType_Moderator;
        private System.Windows.Forms.ComboBox cmbModifyUser_SelectUser;
        private System.Windows.Forms.RadioButton radModifyUser_UserType_Administrator;
        private System.Windows.Forms.Label lblModifyUser_SelectUser;
        private System.Windows.Forms.RadioButton radModifyUser_UserType_Standard;
        private System.Windows.Forms.Label lblModifyUser_Password;
        private System.Windows.Forms.Label lblModifyUser_UserType;
        private System.Windows.Forms.TextBox txtModifyUser_Password;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Label lblModifyUser_Password_Confirm;
        private System.Windows.Forms.TextBox txtModifyUser_Password_Confirm;
        private System.Windows.Forms.GroupBox grpRootCauses;
        private BrightIdeasSoftware.ObjectListView olvRootCauses;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Panel pnlRootCauses_Control;
        private System.Windows.Forms.Button btnRootCause_Remove;
        private System.Windows.Forms.Button btnRootCause_Edit;
        private System.Windows.Forms.Button btnRootCause_Add;
        private System.Windows.Forms.GroupBox grpRepairTypes;
        private BrightIdeasSoftware.ObjectListView olvRepairTypes;
        private BrightIdeasSoftware.OLVColumn olvColRepairType_Description;
        private System.Windows.Forms.Panel pnlRepairTypes_Control;
        private System.Windows.Forms.Button btnRepairType_Remove;
        private System.Windows.Forms.Button btnRepairType_Edit;
        private System.Windows.Forms.Button btnRepairType_Add;
        private System.Windows.Forms.GroupBox grpFailureTypes;
        private BrightIdeasSoftware.ObjectListView olvFailureTypes;
        private BrightIdeasSoftware.OLVColumn olvColFailureType_Description;
        private System.Windows.Forms.Panel pnlFailureTypes_Control;
        private System.Windows.Forms.Button btnFailureType_Remove;
        private System.Windows.Forms.Button btnFailureType_Edit;
        private System.Windows.Forms.Button btnFailureType_Add;
        private System.Windows.Forms.Panel panel3;
        private BrightIdeasSoftware.ObjectListView olvComponents;
        private BrightIdeasSoftware.OLVColumn olvColComponent_ID;
        private BrightIdeasSoftware.OLVColumn olvColComponent_CompNumber;
        private BrightIdeasSoftware.OLVColumn olvColComponent_Description;
        private BrightIdeasSoftware.OLVColumn olvColComponent_Location;
        private BrightIdeasSoftware.OLVColumn olvColComponent_Cost;
        private BrightIdeasSoftware.OLVColumn olvColComponent_InventoryQty;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEnableDisable;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Panel pnlAreas;
        private BrightIdeasSoftware.ObjectListView olvRmaAreas;
        private BrightIdeasSoftware.OLVColumn olcAreaName;
        private System.Windows.Forms.Panel pnlAreaControl;
        private System.Windows.Forms.Button btnRMAArea_Edit;
        private System.Windows.Forms.Button btnRMAArea_Remove;
        private System.Windows.Forms.Button btnRMAArea_Add;
        private System.Windows.Forms.Label lblAreaInfo;
        private System.Windows.Forms.Panel pnlZones;
        private BrightIdeasSoftware.ObjectListView olvRmaZones;
        private BrightIdeasSoftware.OLVColumn olcZone;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Panel pnlZoneControl;
        private System.Windows.Forms.Button btnRmaZone_SetDefault;
        private System.Windows.Forms.Button btnRmaZone_PrintLabel;
        private System.Windows.Forms.Button btnRmaZone_Edit;
        private System.Windows.Forms.Button btnRmaZone_Remove;
        private System.Windows.Forms.Button btnRmaZone_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private BrightIdeasSoftware.ObjectListView olvAdminEmails;
        private BrightIdeasSoftware.OLVColumn olvColName;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}