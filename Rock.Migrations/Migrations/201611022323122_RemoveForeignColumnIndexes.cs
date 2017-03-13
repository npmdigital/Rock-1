// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
namespace Rock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    /// <summary>
    ///
    /// </summary>
    public partial class RemoveForeignColumnIndexes : Rock.Migrations.RockMigration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            // NOTE: The 201610312310571_ConnectionGroupConfig probably already deleted these indexes, 
            // but we needed to create this migration after removing the [Index] attribute off of Entity.ForeignId, Entity.ForeignGuid, and Entity.ForeignKey
            // so that new Entities won't create Foreign Indexes

            // DbMigration.DropIndex renders a "IF EXISTS... DROP INDEX...", so it won't complain if the index has already been deleted
            DropIndex( "dbo.AttendanceCode", new[] { "ForeignId" });
            DropIndex("dbo.AttendanceCode", new[] { "ForeignGuid" });
            DropIndex("dbo.AttendanceCode", new[] { "ForeignKey" });
            DropIndex("dbo.Attendance", new[] { "ForeignId" });
            DropIndex("dbo.Attendance", new[] { "ForeignGuid" });
            DropIndex("dbo.Attendance", new[] { "ForeignKey" });
            DropIndex("dbo.Campus", new[] { "ForeignId" });
            DropIndex("dbo.Campus", new[] { "ForeignGuid" });
            DropIndex("dbo.Campus", new[] { "ForeignKey" });
            DropIndex("dbo.PersonAlias", new[] { "ForeignId" });
            DropIndex("dbo.PersonAlias", new[] { "ForeignGuid" });
            DropIndex("dbo.PersonAlias", new[] { "ForeignKey" });
            DropIndex("dbo.Person", new[] { "ForeignId" });
            DropIndex("dbo.Person", new[] { "ForeignGuid" });
            DropIndex("dbo.Person", new[] { "ForeignKey" });
            DropIndex("dbo.DefinedValue", new[] { "ForeignId" });
            DropIndex("dbo.DefinedValue", new[] { "ForeignGuid" });
            DropIndex("dbo.DefinedValue", new[] { "ForeignKey" });
            DropIndex("dbo.DefinedType", new[] { "ForeignId" });
            DropIndex("dbo.DefinedType", new[] { "ForeignGuid" });
            DropIndex("dbo.DefinedType", new[] { "ForeignKey" });
            DropIndex("dbo.Category", new[] { "ForeignId" });
            DropIndex("dbo.Category", new[] { "ForeignGuid" });
            DropIndex("dbo.Category", new[] { "ForeignKey" });
            DropIndex("dbo.EntityType", new[] { "ForeignId" });
            DropIndex("dbo.EntityType", new[] { "ForeignGuid" });
            DropIndex("dbo.EntityType", new[] { "ForeignKey" });
            DropIndex("dbo.FieldType", new[] { "ForeignId" });
            DropIndex("dbo.FieldType", new[] { "ForeignGuid" });
            DropIndex("dbo.FieldType", new[] { "ForeignKey" });
            DropIndex("dbo.Group", new[] { "ForeignId" });
            DropIndex("dbo.Group", new[] { "ForeignGuid" });
            DropIndex("dbo.Group", new[] { "ForeignKey" });
            DropIndex("dbo.SystemEmail", new[] { "ForeignId" });
            DropIndex("dbo.SystemEmail", new[] { "ForeignGuid" });
            DropIndex("dbo.SystemEmail", new[] { "ForeignKey" });
            DropIndex("dbo.GroupLocation", new[] { "ForeignId" });
            DropIndex("dbo.GroupLocation", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupLocation", new[] { "ForeignKey" });
            DropIndex("dbo.Location", new[] { "ForeignId" });
            DropIndex("dbo.Location", new[] { "ForeignGuid" });
            DropIndex("dbo.Location", new[] { "ForeignKey" });
            DropIndex("dbo.BinaryFile", new[] { "ForeignId" });
            DropIndex("dbo.BinaryFile", new[] { "ForeignGuid" });
            DropIndex("dbo.BinaryFile", new[] { "ForeignKey" });
            DropIndex("dbo.BinaryFileType", new[] { "ForeignId" });
            DropIndex("dbo.BinaryFileType", new[] { "ForeignGuid" });
            DropIndex("dbo.BinaryFileType", new[] { "ForeignKey" });
            DropIndex("dbo.BinaryFileData", new[] { "ForeignId" });
            DropIndex("dbo.BinaryFileData", new[] { "ForeignGuid" });
            DropIndex("dbo.BinaryFileData", new[] { "ForeignKey" });
            DropIndex("dbo.Device", new[] { "ForeignId" });
            DropIndex("dbo.Device", new[] { "ForeignGuid" });
            DropIndex("dbo.Device", new[] { "ForeignKey" });
            DropIndex("dbo.Schedule", new[] { "ForeignId" });
            DropIndex("dbo.Schedule", new[] { "ForeignGuid" });
            DropIndex("dbo.Schedule", new[] { "ForeignKey" });
            DropIndex("dbo.GroupMemberWorkflowTrigger", new[] { "ForeignId" });
            DropIndex("dbo.GroupMemberWorkflowTrigger", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupMemberWorkflowTrigger", new[] { "ForeignKey" });
            DropIndex("dbo.GroupType", new[] { "ForeignId" });
            DropIndex("dbo.GroupType", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupType", new[] { "ForeignKey" });
            DropIndex("dbo.GroupTypeRole", new[] { "ForeignId" });
            DropIndex("dbo.GroupTypeRole", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupTypeRole", new[] { "ForeignKey" });
            DropIndex("dbo.GroupScheduleExclusion", new[] { "ForeignId" });
            DropIndex("dbo.GroupScheduleExclusion", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupScheduleExclusion", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowType", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowType", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowType", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowActivityType", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowActivityType", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowActivityType", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowActionType", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowActionType", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowActionType", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowActionForm", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowActionForm", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowActionForm", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowActionFormAttribute", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowActionFormAttribute", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowActionFormAttribute", new[] { "ForeignKey" });
            DropIndex("dbo.Attribute", new[] { "ForeignId" });
            DropIndex("dbo.Attribute", new[] { "ForeignGuid" });
            DropIndex("dbo.Attribute", new[] { "ForeignKey" });
            DropIndex("dbo.AttributeQualifier", new[] { "ForeignId" });
            DropIndex("dbo.AttributeQualifier", new[] { "ForeignGuid" });
            DropIndex("dbo.AttributeQualifier", new[] { "ForeignKey" });
            DropIndex("dbo.GroupRequirement", new[] { "ForeignId" });
            DropIndex("dbo.GroupRequirement", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupRequirement", new[] { "ForeignKey" });
            DropIndex("dbo.GroupRequirementType", new[] { "ForeignId" });
            DropIndex("dbo.GroupRequirementType", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupRequirementType", new[] { "ForeignKey" });
            DropIndex("dbo.DataView", new[] { "ForeignId" });
            DropIndex("dbo.DataView", new[] { "ForeignGuid" });
            DropIndex("dbo.DataView", new[] { "ForeignKey" });
            DropIndex("dbo.DataViewFilter", new[] { "ForeignId" });
            DropIndex("dbo.DataViewFilter", new[] { "ForeignGuid" });
            DropIndex("dbo.DataViewFilter", new[] { "ForeignKey" });
            DropIndex("dbo.EventItemOccurrenceGroupMap", new[] { "ForeignId" });
            DropIndex("dbo.EventItemOccurrenceGroupMap", new[] { "ForeignGuid" });
            DropIndex("dbo.EventItemOccurrenceGroupMap", new[] { "ForeignKey" });
            DropIndex("dbo.EventItemOccurrence", new[] { "ForeignId" });
            DropIndex("dbo.EventItemOccurrence", new[] { "ForeignGuid" });
            DropIndex("dbo.EventItemOccurrence", new[] { "ForeignKey" });
            DropIndex("dbo.EventItemOccurrenceChannelItem", new[] { "ForeignId" });
            DropIndex("dbo.EventItemOccurrenceChannelItem", new[] { "ForeignGuid" });
            DropIndex("dbo.EventItemOccurrenceChannelItem", new[] { "ForeignKey" });
            DropIndex("dbo.ContentChannelItem", new[] { "ForeignId" });
            DropIndex("dbo.ContentChannelItem", new[] { "ForeignGuid" });
            DropIndex("dbo.ContentChannelItem", new[] { "ForeignKey" });
            DropIndex("dbo.ContentChannelItemAssociation", new[] { "ForeignId" });
            DropIndex("dbo.ContentChannelItemAssociation", new[] { "ForeignGuid" });
            DropIndex("dbo.ContentChannelItemAssociation", new[] { "ForeignKey" });
            DropIndex("dbo.ContentChannel", new[] { "ForeignId" });
            DropIndex("dbo.ContentChannel", new[] { "ForeignGuid" });
            DropIndex("dbo.ContentChannel", new[] { "ForeignKey" });
            DropIndex("dbo.ContentChannelType", new[] { "ForeignId" });
            DropIndex("dbo.ContentChannelType", new[] { "ForeignGuid" });
            DropIndex("dbo.ContentChannelType", new[] { "ForeignKey" });
            DropIndex("dbo.EventItem", new[] { "ForeignId" });
            DropIndex("dbo.EventItem", new[] { "ForeignGuid" });
            DropIndex("dbo.EventItem", new[] { "ForeignKey" });
            DropIndex("dbo.EventCalendarItem", new[] { "ForeignId" });
            DropIndex("dbo.EventCalendarItem", new[] { "ForeignGuid" });
            DropIndex("dbo.EventCalendarItem", new[] { "ForeignKey" });
            DropIndex("dbo.EventCalendar", new[] { "ForeignId" });
            DropIndex("dbo.EventCalendar", new[] { "ForeignGuid" });
            DropIndex("dbo.EventCalendar", new[] { "ForeignKey" });
            DropIndex("dbo.EventCalendarContentChannel", new[] { "ForeignId" });
            DropIndex("dbo.EventCalendarContentChannel", new[] { "ForeignGuid" });
            DropIndex("dbo.EventCalendarContentChannel", new[] { "ForeignKey" });
            DropIndex("dbo.EventItemAudience", new[] { "ForeignId" });
            DropIndex("dbo.EventItemAudience", new[] { "ForeignGuid" });
            DropIndex("dbo.EventItemAudience", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationInstance", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationInstance", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationInstance", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialAccount", new[] { "ForeignId" });
            DropIndex("dbo.FinancialAccount", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialAccount", new[] { "ForeignKey" });
            DropIndex("dbo.Registration", new[] { "ForeignId" });
            DropIndex("dbo.Registration", new[] { "ForeignGuid" });
            DropIndex("dbo.Registration", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationRegistrant", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationRegistrant", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationRegistrant", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationRegistrantFee", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationRegistrantFee", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationRegistrantFee", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationTemplateFee", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationTemplateFee", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationTemplateFee", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationTemplate", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationTemplate", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationTemplate", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationTemplateDiscount", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationTemplateDiscount", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationTemplateDiscount", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialGateway", new[] { "ForeignId" });
            DropIndex("dbo.FinancialGateway", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialGateway", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationTemplateForm", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationTemplateForm", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationTemplateForm", new[] { "ForeignKey" });
            DropIndex("dbo.RegistrationTemplateFormField", new[] { "ForeignId" });
            DropIndex("dbo.RegistrationTemplateFormField", new[] { "ForeignGuid" });
            DropIndex("dbo.RegistrationTemplateFormField", new[] { "ForeignKey" });
            DropIndex("dbo.SignatureDocumentTemplate", new[] { "ForeignId" });
            DropIndex("dbo.SignatureDocumentTemplate", new[] { "ForeignGuid" });
            DropIndex("dbo.SignatureDocumentTemplate", new[] { "ForeignKey" });
            DropIndex("dbo.SignatureDocument", new[] { "ForeignId" });
            DropIndex("dbo.SignatureDocument", new[] { "ForeignGuid" });
            DropIndex("dbo.SignatureDocument", new[] { "ForeignKey" });
            DropIndex("dbo.GroupMember", new[] { "ForeignId" });
            DropIndex("dbo.GroupMember", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupMember", new[] { "ForeignKey" });
            DropIndex("dbo.GroupMemberRequirement", new[] { "ForeignId" });
            DropIndex("dbo.GroupMemberRequirement", new[] { "ForeignGuid" });
            DropIndex("dbo.GroupMemberRequirement", new[] { "ForeignKey" });
            DropIndex("dbo.PhoneNumber", new[] { "ForeignId" });
            DropIndex("dbo.PhoneNumber", new[] { "ForeignGuid" });
            DropIndex("dbo.PhoneNumber", new[] { "ForeignKey" });
            DropIndex("dbo.UserLogin", new[] { "ForeignId" });
            DropIndex("dbo.UserLogin", new[] { "ForeignGuid" });
            DropIndex("dbo.UserLogin", new[] { "ForeignKey" });
            DropIndex("dbo.AttributeValue", new[] { "ForeignId" });
            DropIndex("dbo.AttributeValue", new[] { "ForeignGuid" });
            DropIndex("dbo.AttributeValue", new[] { "ForeignKey" });
            DropIndex("dbo.AuditDetail", new[] { "ForeignId" });
            DropIndex("dbo.AuditDetail", new[] { "ForeignGuid" });
            DropIndex("dbo.AuditDetail", new[] { "ForeignKey" });
            DropIndex("dbo.Audit", new[] { "ForeignId" });
            DropIndex("dbo.Audit", new[] { "ForeignGuid" });
            DropIndex("dbo.Audit", new[] { "ForeignKey" });
            DropIndex("dbo.Auth", new[] { "ForeignId" });
            DropIndex("dbo.Auth", new[] { "ForeignGuid" });
            DropIndex("dbo.Auth", new[] { "ForeignKey" });
            DropIndex("dbo.BackgroundCheck", new[] { "ForeignId" });
            DropIndex("dbo.BackgroundCheck", new[] { "ForeignGuid" });
            DropIndex("dbo.BackgroundCheck", new[] { "ForeignKey" });
            DropIndex("dbo.Workflow", new[] { "ForeignId" });
            DropIndex("dbo.Workflow", new[] { "ForeignGuid" });
            DropIndex("dbo.Workflow", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowActivity", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowActivity", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowActivity", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowAction", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowAction", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowAction", new[] { "ForeignKey" });
            DropIndex("dbo.BenevolenceRequestDocument", new[] { "ForeignId" });
            DropIndex("dbo.BenevolenceRequestDocument", new[] { "ForeignGuid" });
            DropIndex("dbo.BenevolenceRequestDocument", new[] { "ForeignKey" });
            DropIndex("dbo.BenevolenceRequest", new[] { "ForeignId" });
            DropIndex("dbo.BenevolenceRequest", new[] { "ForeignGuid" });
            DropIndex("dbo.BenevolenceRequest", new[] { "ForeignKey" });
            DropIndex("dbo.BenevolenceResult", new[] { "ForeignId" });
            DropIndex("dbo.BenevolenceResult", new[] { "ForeignGuid" });
            DropIndex("dbo.BenevolenceResult", new[] { "ForeignKey" });
            DropIndex("dbo.Block", new[] { "ForeignId" });
            DropIndex("dbo.Block", new[] { "ForeignGuid" });
            DropIndex("dbo.Block", new[] { "ForeignKey" });
            DropIndex("dbo.BlockType", new[] { "ForeignId" });
            DropIndex("dbo.BlockType", new[] { "ForeignGuid" });
            DropIndex("dbo.BlockType", new[] { "ForeignKey" });
            DropIndex("dbo.Layout", new[] { "ForeignId" });
            DropIndex("dbo.Layout", new[] { "ForeignGuid" });
            DropIndex("dbo.Layout", new[] { "ForeignKey" });
            DropIndex("dbo.Page", new[] { "ForeignId" });
            DropIndex("dbo.Page", new[] { "ForeignGuid" });
            DropIndex("dbo.Page", new[] { "ForeignKey" });
            DropIndex("dbo.PageContext", new[] { "ForeignId" });
            DropIndex("dbo.PageContext", new[] { "ForeignGuid" });
            DropIndex("dbo.PageContext", new[] { "ForeignKey" });
            DropIndex("dbo.PageRoute", new[] { "ForeignId" });
            DropIndex("dbo.PageRoute", new[] { "ForeignGuid" });
            DropIndex("dbo.PageRoute", new[] { "ForeignKey" });
            DropIndex("dbo.Site", new[] { "ForeignId" });
            DropIndex("dbo.Site", new[] { "ForeignGuid" });
            DropIndex("dbo.Site", new[] { "ForeignKey" });
            DropIndex("dbo.SiteDomain", new[] { "ForeignId" });
            DropIndex("dbo.SiteDomain", new[] { "ForeignGuid" });
            DropIndex("dbo.SiteDomain", new[] { "ForeignKey" });
            DropIndex("dbo.CommunicationRecipientActivity", new[] { "ForeignId" });
            DropIndex("dbo.CommunicationRecipientActivity", new[] { "ForeignGuid" });
            DropIndex("dbo.CommunicationRecipientActivity", new[] { "ForeignKey" });
            DropIndex("dbo.CommunicationRecipient", new[] { "ForeignId" });
            DropIndex("dbo.CommunicationRecipient", new[] { "ForeignGuid" });
            DropIndex("dbo.CommunicationRecipient", new[] { "ForeignKey" });
            DropIndex("dbo.Communication", new[] { "ForeignId" });
            DropIndex("dbo.Communication", new[] { "ForeignGuid" });
            DropIndex("dbo.Communication", new[] { "ForeignKey" });
            DropIndex("dbo.CommunicationTemplate", new[] { "ForeignId" });
            DropIndex("dbo.CommunicationTemplate", new[] { "ForeignGuid" });
            DropIndex("dbo.CommunicationTemplate", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionActivityType", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionActivityType", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionActivityType", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionType", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionType", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionType", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionOpportunity", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionOpportunity", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionOpportunity", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionOpportunityCampus", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionOpportunityCampus", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionOpportunityCampus", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionOpportunityConnectorGroup", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionOpportunityConnectorGroup", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionOpportunityConnectorGroup", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionOpportunityGroupConfig", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionOpportunityGroupConfig", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionOpportunityGroupConfig", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionOpportunityGroup", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionOpportunityGroup", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionOpportunityGroup", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionRequest", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionRequest", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionRequest", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionRequestActivity", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionRequestActivity", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionRequestActivity", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionRequestWorkflow", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionRequestWorkflow", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionRequestWorkflow", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionWorkflow", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionWorkflow", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionWorkflow", new[] { "ForeignKey" });
            DropIndex("dbo.ConnectionStatus", new[] { "ForeignId" });
            DropIndex("dbo.ConnectionStatus", new[] { "ForeignGuid" });
            DropIndex("dbo.ConnectionStatus", new[] { "ForeignKey" });
            DropIndex("dbo.EntitySetItem", new[] { "ForeignId" });
            DropIndex("dbo.EntitySetItem", new[] { "ForeignGuid" });
            DropIndex("dbo.EntitySetItem", new[] { "ForeignKey" });
            DropIndex("dbo.EntitySet", new[] { "ForeignId" });
            DropIndex("dbo.EntitySet", new[] { "ForeignGuid" });
            DropIndex("dbo.EntitySet", new[] { "ForeignKey" });
            DropIndex("dbo.ExceptionLog", new[] { "ForeignId" });
            DropIndex("dbo.ExceptionLog", new[] { "ForeignGuid" });
            DropIndex("dbo.ExceptionLog", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialBatch", new[] { "ForeignId" });
            DropIndex("dbo.FinancialBatch", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialBatch", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialTransaction", new[] { "ForeignId" });
            DropIndex("dbo.FinancialTransaction", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialTransaction", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialPaymentDetail", new[] { "ForeignId" });
            DropIndex("dbo.FinancialPaymentDetail", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialPaymentDetail", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialTransactionImage", new[] { "ForeignId" });
            DropIndex("dbo.FinancialTransactionImage", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialTransactionImage", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialTransactionRefund", new[] { "ForeignId" });
            DropIndex("dbo.FinancialTransactionRefund", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialTransactionRefund", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialScheduledTransaction", new[] { "ForeignId" });
            DropIndex("dbo.FinancialScheduledTransaction", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialScheduledTransaction", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialScheduledTransactionDetail", new[] { "ForeignId" });
            DropIndex("dbo.FinancialScheduledTransactionDetail", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialScheduledTransactionDetail", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialTransactionDetail", new[] { "ForeignId" });
            DropIndex("dbo.FinancialTransactionDetail", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialTransactionDetail", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialPersonBankAccount", new[] { "ForeignId" });
            DropIndex("dbo.FinancialPersonBankAccount", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialPersonBankAccount", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialPersonSavedAccount", new[] { "ForeignId" });
            DropIndex("dbo.FinancialPersonSavedAccount", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialPersonSavedAccount", new[] { "ForeignKey" });
            DropIndex("dbo.FinancialPledge", new[] { "ForeignId" });
            DropIndex("dbo.FinancialPledge", new[] { "ForeignGuid" });
            DropIndex("dbo.FinancialPledge", new[] { "ForeignKey" });
            DropIndex("dbo.FollowingEventNotification", new[] { "ForeignId" });
            DropIndex("dbo.FollowingEventNotification", new[] { "ForeignGuid" });
            DropIndex("dbo.FollowingEventNotification", new[] { "ForeignKey" });
            DropIndex("dbo.FollowingEventType", new[] { "ForeignId" });
            DropIndex("dbo.FollowingEventType", new[] { "ForeignGuid" });
            DropIndex("dbo.FollowingEventType", new[] { "ForeignKey" });
            DropIndex("dbo.FollowingEventSubscription", new[] { "ForeignId" });
            DropIndex("dbo.FollowingEventSubscription", new[] { "ForeignGuid" });
            DropIndex("dbo.FollowingEventSubscription", new[] { "ForeignKey" });
            DropIndex("dbo.Following", new[] { "ForeignId" });
            DropIndex("dbo.Following", new[] { "ForeignGuid" });
            DropIndex("dbo.Following", new[] { "ForeignKey" });
            DropIndex("dbo.FollowingSuggested", new[] { "ForeignId" });
            DropIndex("dbo.FollowingSuggested", new[] { "ForeignGuid" });
            DropIndex("dbo.FollowingSuggested", new[] { "ForeignKey" });
            DropIndex("dbo.FollowingSuggestionType", new[] { "ForeignId" });
            DropIndex("dbo.FollowingSuggestionType", new[] { "ForeignGuid" });
            DropIndex("dbo.FollowingSuggestionType", new[] { "ForeignKey" });
            DropIndex("dbo.History", new[] { "ForeignId" });
            DropIndex("dbo.History", new[] { "ForeignGuid" });
            DropIndex("dbo.History", new[] { "ForeignKey" });
            DropIndex("dbo.HtmlContent", new[] { "ForeignId" });
            DropIndex("dbo.HtmlContent", new[] { "ForeignGuid" });
            DropIndex("dbo.HtmlContent", new[] { "ForeignKey" });
            DropIndex("dbo.MergeTemplate", new[] { "ForeignId" });
            DropIndex("dbo.MergeTemplate", new[] { "ForeignGuid" });
            DropIndex("dbo.MergeTemplate", new[] { "ForeignKey" });
            DropIndex("dbo.MetricCategory", new[] { "ForeignId" });
            DropIndex("dbo.MetricCategory", new[] { "ForeignGuid" });
            DropIndex("dbo.MetricCategory", new[] { "ForeignKey" });
            DropIndex("dbo.Metric", new[] { "ForeignId" });
            DropIndex("dbo.Metric", new[] { "ForeignGuid" });
            DropIndex("dbo.Metric", new[] { "ForeignKey" });
            DropIndex("dbo.MetricPartition", new[] { "ForeignId" });
            DropIndex("dbo.MetricPartition", new[] { "ForeignGuid" });
            DropIndex("dbo.MetricPartition", new[] { "ForeignKey" });
            DropIndex("dbo.MetricValue", new[] { "ForeignId" });
            DropIndex("dbo.MetricValue", new[] { "ForeignGuid" });
            DropIndex("dbo.MetricValue", new[] { "ForeignKey" });
            DropIndex("dbo.MetricValuePartition", new[] { "ForeignId" });
            DropIndex("dbo.MetricValuePartition", new[] { "ForeignGuid" });
            DropIndex("dbo.MetricValuePartition", new[] { "ForeignKey" });
            DropIndex("dbo.Note", new[] { "ForeignId" });
            DropIndex("dbo.Note", new[] { "ForeignGuid" });
            DropIndex("dbo.Note", new[] { "ForeignKey" });
            DropIndex("dbo.NoteType", new[] { "ForeignId" });
            DropIndex("dbo.NoteType", new[] { "ForeignGuid" });
            DropIndex("dbo.NoteType", new[] { "ForeignKey" });
            DropIndex("dbo.NotificationRecipient", new[] { "ForeignId" });
            DropIndex("dbo.NotificationRecipient", new[] { "ForeignGuid" });
            DropIndex("dbo.NotificationRecipient", new[] { "ForeignKey" });
            DropIndex("dbo.Notification", new[] { "ForeignId" });
            DropIndex("dbo.Notification", new[] { "ForeignGuid" });
            DropIndex("dbo.Notification", new[] { "ForeignKey" });
            DropIndex("dbo.PageView", new[] { "ForeignId" });
            DropIndex("dbo.PageView", new[] { "ForeignGuid" });
            DropIndex("dbo.PageView", new[] { "ForeignKey" });
            DropIndex("dbo.PageViewSession", new[] { "ForeignId" });
            DropIndex("dbo.PageViewSession", new[] { "ForeignGuid" });
            DropIndex("dbo.PageViewSession", new[] { "ForeignKey" });
            DropIndex("dbo.PageViewUserAgent", new[] { "ForeignId" });
            DropIndex("dbo.PageViewUserAgent", new[] { "ForeignGuid" });
            DropIndex("dbo.PageViewUserAgent", new[] { "ForeignKey" });
            DropIndex("dbo.PersonBadge", new[] { "ForeignId" });
            DropIndex("dbo.PersonBadge", new[] { "ForeignGuid" });
            DropIndex("dbo.PersonBadge", new[] { "ForeignKey" });
            DropIndex("dbo.PersonDuplicate", new[] { "ForeignId" });
            DropIndex("dbo.PersonDuplicate", new[] { "ForeignGuid" });
            DropIndex("dbo.PersonDuplicate", new[] { "ForeignKey" });
            DropIndex("dbo.PersonPreviousName", new[] { "ForeignId" });
            DropIndex("dbo.PersonPreviousName", new[] { "ForeignGuid" });
            DropIndex("dbo.PersonPreviousName", new[] { "ForeignKey" });
            DropIndex("dbo.PersonViewed", new[] { "ForeignId" });
            DropIndex("dbo.PersonViewed", new[] { "ForeignGuid" });
            DropIndex("dbo.PersonViewed", new[] { "ForeignKey" });
            DropIndex("dbo.PluginMigration", new[] { "ForeignId" });
            DropIndex("dbo.PluginMigration", new[] { "ForeignGuid" });
            DropIndex("dbo.PluginMigration", new[] { "ForeignKey" });
            DropIndex("dbo.PrayerRequest", new[] { "ForeignId" });
            DropIndex("dbo.PrayerRequest", new[] { "ForeignGuid" });
            DropIndex("dbo.PrayerRequest", new[] { "ForeignKey" });
            DropIndex("dbo.ReportField", new[] { "ForeignId" });
            DropIndex("dbo.ReportField", new[] { "ForeignGuid" });
            DropIndex("dbo.ReportField", new[] { "ForeignKey" });
            DropIndex("dbo.Report", new[] { "ForeignId" });
            DropIndex("dbo.Report", new[] { "ForeignGuid" });
            DropIndex("dbo.Report", new[] { "ForeignKey" });
            DropIndex("dbo.RestAction", new[] { "ForeignId" });
            DropIndex("dbo.RestAction", new[] { "ForeignGuid" });
            DropIndex("dbo.RestAction", new[] { "ForeignKey" });
            DropIndex("dbo.RestController", new[] { "ForeignId" });
            DropIndex("dbo.RestController", new[] { "ForeignGuid" });
            DropIndex("dbo.RestController", new[] { "ForeignKey" });
            DropIndex("dbo.ServiceJob", new[] { "ForeignId" });
            DropIndex("dbo.ServiceJob", new[] { "ForeignGuid" });
            DropIndex("dbo.ServiceJob", new[] { "ForeignKey" });
            DropIndex("dbo.ServiceLog", new[] { "ForeignId" });
            DropIndex("dbo.ServiceLog", new[] { "ForeignGuid" });
            DropIndex("dbo.ServiceLog", new[] { "ForeignKey" });
            DropIndex("dbo.TaggedItem", new[] { "ForeignId" });
            DropIndex("dbo.TaggedItem", new[] { "ForeignGuid" });
            DropIndex("dbo.TaggedItem", new[] { "ForeignKey" });
            DropIndex("dbo.Tag", new[] { "ForeignId" });
            DropIndex("dbo.Tag", new[] { "ForeignGuid" });
            DropIndex("dbo.Tag", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowLog", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowLog", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowLog", new[] { "ForeignKey" });
            DropIndex("dbo.WorkflowTrigger", new[] { "ForeignId" });
            DropIndex("dbo.WorkflowTrigger", new[] { "ForeignGuid" });
            DropIndex("dbo.WorkflowTrigger", new[] { "ForeignKey" });
        }
        
        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
        }
    }
}