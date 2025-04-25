using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.Classes.User
{
    public class ClassUserGroup
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        #region Admin Options
        public bool CanEditAdministratorEmails { get; set; }
        public bool CanEditAssetOption { get; set; }
        public bool CanEditAssemblies { get; set; }
        public bool CanEditCameraTypes { get; set; }
        public bool CanEditCustomerCategories { get; set; }
        public bool CanEditRentals { get; set; }
        public bool CanEditSalesPeople { get; set; }
        public bool CanEditShipmentMethods { get; set; }
        public bool CanEditSymptomsAndSolutions { get; set; }
        public bool CanModifyUser { get; set; }
        public bool CanChangeUserGroups { get; set; }
        #endregion

        #region CameraChecks
        public bool DoesCameraChecks { get; set; }
        public bool CanAuditCameraChecks { get; set; }
        public bool CanPassFailedCameraChecks { get; set; }
        #endregion

        #region RMA
        public bool CanCreateRMA { get; set; }
        public bool CanModifyRMA { get; set; }
        public bool CanDeleteRMA { get; set; }
        public bool CanWorkOnRMA { get; set; }
        #endregion

        #region Shipment
        public bool CanCreateShipment { get; set; }
        public bool CanEditShipment { get; set; }
        public bool CanWorkOnShipment { get; set; }
        #endregion

        #region Ticket
        public bool CanCreateTicket { get; set; }
        public bool CanUpdateTicket { get; set; }
        public bool CanDeleteTicket { get; set; }
        public bool CanMoveTicket { get; set; }
        public bool CanSendOSA { get; set; }
        public bool CanOverrideOSA { get; set; }
        public bool CanCloseTicket { get; set; }
        public bool CanInvoice { get; set; }
        public bool CanCreateRental { get; set; }
        public bool CanEndRental { get; set; }
        #endregion

        #region General
        public bool CanDoGeneralNote { get; set; }
        #endregion

        #region Samsung
        public bool CanWorkOnSamsung { get; set; }

        #endregion

        #region Asset
        public bool CanCreateAsset { get; set; }
        public bool CanRetireAsset { get; set; }
        public bool CanDeleteAsset { get; set; }
        public bool CanEditOwnershipInfo { get; set; }
        public bool CanEditPhysicalSpecs { get; set; }
        public bool CanEditGeographicalInfo { get; set; }
        public bool CanEditAccessInfo { get; set; }
        public bool CanEditAssetNotes { get; set; }
        public bool CanEditServiceReminder { get; set; }
        public bool CanEditNetworkInfo { get; set; }
        public bool CanEditDocuments { get; set; }
        public bool CanEditMonitoringInfo { get; set; }
        public bool CanAddAssetJournalEntries { get; set; }
        public bool CanEditIBOMInfo { get; set; }
        public bool CanEditAssignedTechs { get; set; }

        #endregion

        #region Tech

        public bool CanAddTech { get; set; }
        public bool CanDeleteTech { get; set; }
        public bool CanEditTechInfo { get; set; }
        public bool CanEditTechContactInfo { get; set; }
        public bool CanEditTechNote { get; set; }

        #endregion

        #region Customer/Market
        public bool CanAddCustomer { get; set; }
        public bool CanAddCustomerCatorgory { get; set; }
        public bool CanEditCustomerInfo { get; set; }
        public bool CanAddMarket { get; set; }
        public bool CanEditMarketInfo { get; set; }
        public bool CanEditMarketContacts { get; set; }
        public bool CanEditMarketNotes { get; set; }
        
        #endregion

        public static void AddNew(ClassUserGroup ug)
        {
            if (ug == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO user_groups 
                                   (name, level, can_edit_admin_emails, can_edit_asset_options, can_edit_assemblies, can_edit_camera_types, can_edit_customer_categories, can_edit_rentals, can_edit_salespeople, can_edit_shipment_methods, can_edit_symptons_and_solutions, can_modify_user, does_camera_checks, can_audit_camera_checks, can_pass_fail_camera_checks, can_create_rma, can_modify_rma, can_delete_rma, can_work_on_rma, can_create_shipment, can_edit_shipment, can_work_on_shipment, can_create_ticket, can_update_ticket, can_delete_ticket, can_move_ticket, can_send_osa, can_override_osa, can_close_ticket, can_invoice,can_create_rental, can_end_rental, can_do_general_note, can_work_on_samsung, can_create_asset, can_retire_asset, can_delete_asset, can_edit_ownership_info, can_edit_physical_info, can_edit_geo_info, can_edit_access_info, can_edit_asset_note, can_edit_service_reminder, can_edit_network_info, can_edit_documents, can_edit_monitoring_info, can_add_asset_journal_entries, can_edit_ibom_info, can_edit_assignd_techs, can_add_tech, can_delete_tech, can_edit_tech_info, can_edit_tech_contact_info, can_edit_tech_note, can_add_customer, can_edit_customer_info, can_add_market, can_edit_market_info, can_edit_market_contact_info, can_edit_market_notes),
                            VALUES (@name, @level, @can_edit_admin_emails, @can_edit_asset_options, @can_edit_assemblies, @can_edit_camera_types, @can_edit_customer_categories, @can_edit_rentals, @can_edit_salespeople, @can_edit_shipment_methods, @can_edit_symptons_and_solutions, @can_modify_user, @does_camera_checks, @can_audit_camera_checks, @can_pass_fail_camera_checks, @can_create_rma, @can_modify_rma, @can_delete_rma, @can_work_on_rma, @can_create_shipment, @can_edit_shipment, @can_work_on_shipment, @can_create_ticket, @can_update_ticket, @can_delete_ticket, @can_move_ticket, @can_send_osa, @can_override_osa, @can_close_ticket, @can_invoice, @can_create_rental, @can_end_rental, @can_do_general_note, @can_work_on_samsung, @can_create_asset, @can_retire_asset, @can_delete_asset, @can_edit_ownership_info, @can_edit_physical_info, @can_edit_geo_info, @can_edit_access_info, @can_edit_asset_note, @can_edit_service_reminder, @can_edit_network_info, @can_edit_documents, @can_edit_monitoring_info, @can_add_asset_journal_entries, @can_edit_ibom_info, @can_edit_assignd_techs, @can_add_tech, @can_delete_tech, @can_edit_tech_info, @can_edit_tech_contact_info, @can_edit_tech_note, @can_add_customer, @can_edit_customer_info, @can_add_market, @can_edit_market_info, @can_edit_market_contact_info, @can_edit_market_notes);";
                    cmd.Parameters.AddWithValue("name", ug.Name);
                    cmd.Parameters.AddWithValue("level", ug.Level);
                    cmd.Parameters.AddWithValue("can_edit_admin_emails", ug.CanEditAdministratorEmails);
                    cmd.Parameters.AddWithValue("can_edit_asset_options", ug.CanEditAssemblies);
                    cmd.Parameters.AddWithValue("can_edit_assemblies", ug.CanEditAssemblies);
                    cmd.Parameters.AddWithValue("can_edit_camera_types", ug.CanEditCameraTypes);
                    cmd.Parameters.AddWithValue("can_edit_customer_categories", ug.CanEditCustomerCategories);
                    cmd.Parameters.AddWithValue("can_edit_rentals", ug.CanEditRentals);
                    cmd.Parameters.AddWithValue("can_edit_salespeople", ug.CanEditSalesPeople);
                    cmd.Parameters.AddWithValue("can_edit_shipment_methods", ug.CanEditShipmentMethods);
                    cmd.Parameters.AddWithValue("can_edit_symptons_and_solutions", ug);
                    cmd.Parameters.AddWithValue("can_modify_user", ug.CanModifyUser);
                    cmd.Parameters.AddWithValue("does_camera_checks", ug.DoesCameraChecks);
                    cmd.Parameters.AddWithValue("can_audit_camera_checks", ug.CanAuditCameraChecks);
                    cmd.Parameters.AddWithValue("can_pass_fail_camera_checks", ug.CanPassFailedCameraChecks);
                    cmd.Parameters.AddWithValue("can_create_rma", ug.CanCreateRMA);
                    cmd.Parameters.AddWithValue("can_modify_rma", ug.CanModifyRMA);
                    cmd.Parameters.AddWithValue("can_delete_rma", ug.CanDeleteRMA);
                    cmd.Parameters.AddWithValue("can_work_on_rma", ug.CanWorkOnRMA);
                    cmd.Parameters.AddWithValue("can_create_shipment", ug.CanCreateShipment);
                    cmd.Parameters.AddWithValue("can_edit_shipment", ug.CanEditShipment);
                    cmd.Parameters.AddWithValue("can_work_on_shipment", ug.CanWorkOnShipment);
                    cmd.Parameters.AddWithValue("can_create_ticket", ug.CanCreateTicket);
                    cmd.Parameters.AddWithValue("can_update_ticket", ug.CanUpdateTicket);
                    cmd.Parameters.AddWithValue("can_delete_ticket", ug.CanDeleteTicket);
                    cmd.Parameters.AddWithValue("can_move_ticket", ug.CanMoveTicket);
                    cmd.Parameters.AddWithValue("can_send_osa", ug.CanSendOSA);
                    cmd.Parameters.AddWithValue("can_override_osa", ug.CanOverrideOSA);
                    cmd.Parameters.AddWithValue("can_close_ticket", ug.CanCloseTicket);
                    cmd.Parameters.AddWithValue("can_invoice", ug.CanInvoice);
                    cmd.Parameters.AddWithValue("can_create_rental", ug.CanCreateRental);
                    cmd.Parameters.AddWithValue("can_end_rental", ug.CanEndRental);
                    cmd.Parameters.AddWithValue("can_do_general_note", ug.CanDoGeneralNote);
                    cmd.Parameters.AddWithValue("can_work_on_samsung", ug.CanWorkOnSamsung);
                    cmd.Parameters.AddWithValue("can_create_asset", ug.CanCreateAsset);
                    cmd.Parameters.AddWithValue("can_retire_asset", ug.CanRetireAsset);
                    cmd.Parameters.AddWithValue("can_delete_asset", ug.CanDeleteAsset);
                    cmd.Parameters.AddWithValue("can_edit_ownership_info", ug.CanEditOwnershipInfo);
                    cmd.Parameters.AddWithValue("can_edit_physical_info", ug.CanEditPhysicalSpecs);
                    cmd.Parameters.AddWithValue("can_edit_geo_info", ug.CanEditGeographicalInfo);
                    cmd.Parameters.AddWithValue("can_edit_access_info", ug.CanEditAccessInfo);
                    cmd.Parameters.AddWithValue("can_edit_asset_note", ug.CanEditAssetNotes);
                    cmd.Parameters.AddWithValue("can_edit_service_reminder", ug.CanEditServiceReminder);
                    cmd.Parameters.AddWithValue("can_edit_network_info", ug.CanEditNetworkInfo);
                    cmd.Parameters.AddWithValue("can_edit_documents", ug.CanEditDocuments);
                    cmd.Parameters.AddWithValue("can_edit_monitoring_info", ug.CanEditMonitoringInfo);
                    cmd.Parameters.AddWithValue("can_add_asset_journal_entries", ug.CanAddAssetJournalEntries);
                    cmd.Parameters.AddWithValue("can_edit_ibom_info", ug.CanEditIBOMInfo);
                    cmd.Parameters.AddWithValue("can_edit_assignd_techs", ug.CanEditAssignedTechs);
                    cmd.Parameters.AddWithValue("can_add_tech", ug.CanAddTech);
                    cmd.Parameters.AddWithValue("can_delete_tech", ug.CanDeleteTech);
                    cmd.Parameters.AddWithValue("can_edit_tech_info", ug.CanEditTechInfo);
                    cmd.Parameters.AddWithValue("can_edit_tech_contact_info", ug.CanEditTechContactInfo);
                    cmd.Parameters.AddWithValue("can_edit_tech_note", ug.CanEditTechNote);
                    cmd.Parameters.AddWithValue("can_add_customer", ug.CanAddCustomer);
                    cmd.Parameters.AddWithValue("can_edit_customer_info", ug.CanEditCustomerInfo);
                    cmd.Parameters.AddWithValue("can_add_market", ug.CanAddMarket);
                    cmd.Parameters.AddWithValue("can_edit_market_info", ug.CanEditMarketInfo);
                    cmd.Parameters.AddWithValue("can_edit_market_contact_info", ug);
                    cmd.Parameters.AddWithValue("can_edit_market_notes", ug);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public void Update(ClassUserGroup ug)
        {
           if (ug == null || ug.ID == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE user_groups 
                            SET name = @name, 
                                level= @level, 
                                can_edit_admin_emails = @can_edit_admin_emails, 
                                can_edit_asset_options = @can_edit_asset_options, 
                                can_edit_assemblies = @can_edit_assemblies, 
                                can_edit_camera_types = @can_edit_camera_types, 
                                can_edit_customer_categories = @can_edit_customer_categories, 
                                can_edit_customer_categories = @can_edit_rentals, @can_edit_salespeople, 
                                can_edit_customer_categories = @can_edit_shipment_methods, 
                                can_edit_customer_categories = @can_edit_symptons_and_solutions, 
                                can_modify_user = @can_modify_user, 
                                does_camera_checks = @does_camera_checks, 
                                can_audit_camera_checks = @can_audit_camera_checks, 
                                can_pass_fail_camera_checks = @can_pass_fail_camera_checks, 
                                can_create_rma = @can_create_rma,
                                can_modify_rma = @can_modify_rma, 
                                can_delete_rma = @can_delete_rma, 
                                can_work_on_rma = @can_work_on_rma, 
                                can_create_shipment = @can_create_shipment, 
                                can_edit_shipment = @can_edit_shipment, 
                                can_work_on_shipment @can_work_on_shipment,
                                can_create_ticket = @can_create_ticket, 
                                can_update_ticket = @can_update_ticket,
                                can_delete_ticket = @can_delete_ticket, 
                                can_move_ticket = @can_move_ticket, 
                                can_send_osa = @can_send_osa, 
                                can_override_osa = @can_override_osa, 
                                can_close_ticket = @can_close_ticket, 
                                can_invoice = @can_invoice,
                                can_create_rental = @can_create_rental, 
                                can_end_rental = @can_end_rental, 
                                can_do_general_note = @can_do_general_note,
                                can_work_on_samsung = @can_work_on_samsung, 
                                can_create_asset = @can_create_asset, 
                                can_retire_asset = @can_retire_asset, 
                                can_delete_asset = @can_delete_asset, 
                                can_edit_ownership_info = @can_edit_ownership_info,
                                can_edit_physical_info = @can_edit_physical_info, 
                                can_edit_geo_info = @can_edit_geo_info,
                                can_edit_access_info = @can_edit_access_info,
                                can_edit_asset_note = @can_edit_asset_note, 
                                can_edit_service_reminder = @can_edit_service_reminder,
                                can_edit_network_info = @can_edit_network_info,
                                can_edit_documents = @can_edit_documents,
                                can_edit_monitoring_info = @can_edit_monitoring_info, 
                                can_add_asset_journal_entries = @can_add_asset_journal_entries, 
                                can_edit_ibom_info = @can_edit_ibom_info, 
                                can_edit_assignd_techs = @can_edit_assignd_techs, 
                                can_add_tech = @can_add_tech, 
                                can_delete_tech = @can_delete_tech,
                                can_edit_tech_info = @can_edit_tech_info, 
                                can_edit_tech_contact_info = @can_edit_tech_contact_info, 
                                can_edit_tech_note = @can_edit_tech_note, 
                                can_add_customer = @can_add_customer, 
                                can_edit_customer_info = @can_edit_customer_info, 
                                can_edit_customer_info = @can_add_market, 
                                can_edit_market_info = @can_edit_market_info, 
                                @can_edit_market_contact_info, 
                                @can_edit_market_notes
                            WHERE id = @id;";
                    cmd.Parameters.AddWithValue("name", ug.ID);
                    cmd.Parameters.AddWithValue("name", ug.Name);
                    cmd.Parameters.AddWithValue("level", ug.Level);
                    cmd.Parameters.AddWithValue("can_edit_admin_emails", ug.CanEditAdministratorEmails);
                    cmd.Parameters.AddWithValue("can_edit_asset_options", ug.CanEditAssemblies);
                    cmd.Parameters.AddWithValue("can_edit_assemblies", ug.CanEditAssemblies);
                    cmd.Parameters.AddWithValue("can_edit_camera_types", ug.CanEditCameraTypes);
                    cmd.Parameters.AddWithValue("can_edit_customer_categories", ug.CanEditCustomerCategories);
                    cmd.Parameters.AddWithValue("can_edit_rentals", ug.CanEditRentals);
                    cmd.Parameters.AddWithValue("can_edit_salespeople", ug.CanEditSalesPeople);
                    cmd.Parameters.AddWithValue("can_edit_shipment_methods", ug.CanEditShipmentMethods);
                    cmd.Parameters.AddWithValue("can_edit_symptons_and_solutions", ug);
                    cmd.Parameters.AddWithValue("can_modify_user", ug.CanModifyUser);
                    cmd.Parameters.AddWithValue("does_camera_checks", ug.DoesCameraChecks);
                    cmd.Parameters.AddWithValue("can_audit_camera_checks", ug.CanAuditCameraChecks);
                    cmd.Parameters.AddWithValue("can_pass_fail_camera_checks", ug.CanPassFailedCameraChecks);
                    cmd.Parameters.AddWithValue("can_create_rma", ug.CanCreateRMA);
                    cmd.Parameters.AddWithValue("can_modify_rma", ug.CanModifyRMA);
                    cmd.Parameters.AddWithValue("can_delete_rma", ug.CanDeleteRMA);
                    cmd.Parameters.AddWithValue("can_work_on_rma", ug.CanWorkOnRMA);
                    cmd.Parameters.AddWithValue("can_create_shipment", ug.CanCreateShipment);
                    cmd.Parameters.AddWithValue("can_edit_shipment", ug.CanEditShipment);
                    cmd.Parameters.AddWithValue("can_work_on_shipment", ug.CanWorkOnShipment);
                    cmd.Parameters.AddWithValue("can_create_ticket", ug.CanCreateTicket);
                    cmd.Parameters.AddWithValue("can_update_ticket", ug.CanUpdateTicket);
                    cmd.Parameters.AddWithValue("can_delete_ticket", ug.CanDeleteTicket);
                    cmd.Parameters.AddWithValue("can_move_ticket", ug.CanMoveTicket);
                    cmd.Parameters.AddWithValue("can_send_osa", ug.CanSendOSA);
                    cmd.Parameters.AddWithValue("can_override_osa", ug.CanOverrideOSA);
                    cmd.Parameters.AddWithValue("can_close_ticket", ug.CanCloseTicket);
                    cmd.Parameters.AddWithValue("can_invoice", ug.CanInvoice);
                    cmd.Parameters.AddWithValue("can_create_rental", ug.CanCreateRental);
                    cmd.Parameters.AddWithValue("can_end_rental", ug.CanEndRental);
                    cmd.Parameters.AddWithValue("can_do_general_note", ug.CanDoGeneralNote);
                    cmd.Parameters.AddWithValue("can_work_on_samsung", ug.CanWorkOnSamsung);
                    cmd.Parameters.AddWithValue("can_create_asset", ug.CanCreateAsset);
                    cmd.Parameters.AddWithValue("can_retire_asset", ug.CanRetireAsset);
                    cmd.Parameters.AddWithValue("can_delete_asset", ug.CanDeleteAsset);
                    cmd.Parameters.AddWithValue("can_edit_ownership_info", ug.CanEditOwnershipInfo);
                    cmd.Parameters.AddWithValue("can_edit_physical_info", ug.CanEditPhysicalSpecs);
                    cmd.Parameters.AddWithValue("can_edit_geo_info", ug.CanEditGeographicalInfo);
                    cmd.Parameters.AddWithValue("can_edit_access_info", ug.CanEditAccessInfo);
                    cmd.Parameters.AddWithValue("can_edit_asset_note", ug.CanEditAssetNotes);
                    cmd.Parameters.AddWithValue("can_edit_service_reminder", ug.CanEditServiceReminder);
                    cmd.Parameters.AddWithValue("can_edit_network_info", ug.CanEditNetworkInfo);
                    cmd.Parameters.AddWithValue("can_edit_documents", ug.CanEditDocuments);
                    cmd.Parameters.AddWithValue("can_edit_monitoring_info", ug.CanEditMonitoringInfo);
                    cmd.Parameters.AddWithValue("can_add_asset_journal_entries", ug.CanAddAssetJournalEntries);
                    cmd.Parameters.AddWithValue("can_edit_ibom_info", ug.CanEditIBOMInfo);
                    cmd.Parameters.AddWithValue("can_edit_assignd_techs", ug.CanEditAssignedTechs);
                    cmd.Parameters.AddWithValue("can_add_tech", ug.CanAddTech);
                    cmd.Parameters.AddWithValue("can_delete_tech", ug.CanDeleteTech);
                    cmd.Parameters.AddWithValue("can_edit_tech_info", ug.CanEditTechInfo);
                    cmd.Parameters.AddWithValue("can_edit_tech_contact_info", ug.CanEditTechContactInfo);
                    cmd.Parameters.AddWithValue("can_edit_tech_note", ug.CanEditTechNote);
                    cmd.Parameters.AddWithValue("can_add_customer", ug.CanAddCustomer);
                    cmd.Parameters.AddWithValue("can_edit_customer_info", ug.CanEditCustomerInfo);
                    cmd.Parameters.AddWithValue("can_add_market", ug.CanAddMarket);
                    cmd.Parameters.AddWithValue("can_edit_market_info", ug.CanEditMarketInfo);
                    cmd.Parameters.AddWithValue("can_edit_market_contact_info", ug);
                    cmd.Parameters.AddWithValue("can_edit_market_notes", ug);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>        
        private static ClassUserGroup GetFromReader(MySqlDataReader reader)
        {
            ClassUserGroup ug = new ClassUserGroup
            {
                ID = reader.GetDBInt_Null("id"),
                Name = reader.GetDBString("name"),
                Level = reader.GetDBInt("level"),
                CanEditAdministratorEmails = reader.GetDBBool("can_edit_admin_emails"),
                CanEditAssetOption = reader.GetDBBool("can_edit_asset_options"),
                CanEditAssemblies = reader.GetDBBool("can_edit_assemblies"),
                CanEditCameraTypes = reader.GetDBBool("can_edit_camera_types"),
                CanEditCustomerCategories = reader.GetDBBool("can_edit_customer_categories"),
                CanEditRentals = reader.GetDBBool("can_edit_rentals"),
                CanEditSalesPeople = reader.GetDBBool("can_edit_salespeople"),
                CanEditShipmentMethods = reader.GetDBBool("can_edit_shipment_methods"),
                CanEditSymptomsAndSolutions = reader.GetDBBool("can_edit_symptons_and_solutions"),
                CanModifyUser = reader.GetDBBool("can_modify_user"),
                DoesCameraChecks = reader.GetDBBool("does_camera_checks"),
                CanAuditCameraChecks = reader.GetDBBool("can_audit_camera_checks"),
                CanPassFailedCameraChecks = reader.GetDBBool("can_pass_fail_camera_checks"), 
                CanCreateRMA = reader.GetDBBool("can_create_rma"),
                CanModifyRMA = reader.GetDBBool("can_modify_rma"),
                CanDeleteRMA = reader.GetDBBool("can_delete_rma"),
                CanWorkOnRMA = reader.GetDBBool("can_work_on_rma"),
                CanCreateShipment = reader.GetDBBool("can_create_shipment"),
                CanEditShipment = reader.GetDBBool("can_edit_shipment"),
                CanWorkOnShipment = reader.GetDBBool("can_work_on_shipment"),
                CanCreateTicket = reader.GetDBBool("can_create_ticket"),
                CanUpdateTicket = reader.GetDBBool("can_update_ticket"),
                CanDeleteTicket = reader.GetDBBool("can_delete_ticket"),
                CanMoveTicket = reader.GetDBBool("can_move_ticket"),
                CanSendOSA = reader.GetDBBool("can_send_osa"),
                CanOverrideOSA = reader.GetDBBool("can_override_osa"),
                CanCloseTicket = reader.GetDBBool("can_close_ticket"),
                CanInvoice = reader.GetDBBool("can_invoice"),
                CanCreateRental = reader.GetDBBool("can_create_rental"),
                CanEndRental = reader.GetDBBool("can_end_rental"),
                CanDoGeneralNote = reader.GetDBBool("can_do_general_note"),
                CanWorkOnSamsung = reader.GetDBBool("can_work_on_samsung"),
                CanCreateAsset = reader.GetDBBool("can_create_asset"),
                CanRetireAsset = reader.GetDBBool("can_retire_asset"),
                CanDeleteAsset = reader.GetDBBool("can_delete_asset"),
                CanEditOwnershipInfo = reader.GetDBBool("can_edit_ownership_info"),
                CanEditPhysicalSpecs = reader.GetDBBool("can_edit_physical_info"),
                CanEditGeographicalInfo = reader.GetDBBool("can_edit_geo_info"),
                CanEditAccessInfo = reader.GetDBBool("can_edit_access_info"),
                CanEditAssetNotes = reader.GetDBBool("can_edit_asset_note"),
                CanEditServiceReminder = reader.GetDBBool("can_edit_service_reminder"),
                CanEditNetworkInfo = reader.GetDBBool("can_edit_network_info"),
                CanEditDocuments = reader.GetDBBool("can_edit_documents"),
                CanEditMonitoringInfo = reader.GetDBBool("can_edit_monitoring_info"),
                CanAddAssetJournalEntries = reader.GetDBBool("can_add_asset_journal_entries"),
                CanEditIBOMInfo = reader.GetDBBool("can_edit_ibom_info"),
                CanEditAssignedTechs = reader.GetDBBool("can_edit_assignd_techs"),
                CanAddTech = reader.GetDBBool("can_add_tech"),
                CanDeleteTech = reader.GetDBBool("can_delete_tech"),
                CanEditTechInfo = reader.GetDBBool("can_edit_tech_info"),
                CanEditTechContactInfo = reader.GetDBBool("can_edit_tech_contact_info"),
                CanEditTechNote = reader.GetDBBool("can_edit_tech_note"),
                CanAddCustomer = reader.GetDBBool("can_add_customer"),
                CanEditCustomerInfo = reader.GetDBBool("can_edit_customer_info"),
                CanAddMarket = reader.GetDBBool("can_add_market"),
                CanEditMarketInfo = reader.GetDBBool("can_edit_market_info"),
                CanEditMarketContacts = reader.GetDBBool("can_edit_market_contact_info"),
                CanEditMarketNotes = reader.GetDBBool("can_edit_market_notes"),
            };
            return null;
        }
    }
}
