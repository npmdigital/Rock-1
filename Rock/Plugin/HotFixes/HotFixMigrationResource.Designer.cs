﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rock.Plugin.HotFixes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class HotFixMigrationResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HotFixMigrationResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Rock.Plugin.HotFixes.HotFixMigrationResource", typeof(HotFixMigrationResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [DefinedType]
        ///SET [helptext] = &apos;
        ///Label merge fields are defined with a liquid syntax. Click the &apos;&apos;Show Merge Fields&apos;&apos; button below to view the available merge fields.
        ///&lt;p&gt;
        ///    &lt;a data-toggle=&apos;&apos;collapse&apos;&apos;  href=&apos;&apos;#collapseMergeFields&apos;&apos; class=&apos;&apos;btn btn-action btn-xs&apos;&apos;&gt;Show/Hide Merge Fields&lt;/a&gt;
        ///&lt;/p&gt;
        ///&lt;div id=&apos;&apos;collapseMergeFields&apos;&apos; class=&apos;&apos;panel-collapse collapse&apos;&apos;&gt;
        ///&lt;div class=&apos;&apos;alert alert-info lava-debug&apos;&apos;&gt;
        ///    &lt;div class=&apos;&apos;panel panel-default panel-lavadebug&apos;&apos;&gt;
        ///        &lt;div class=&apos;&apos;panel-head [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _039_MigrationRollupsForV7_2_UpdateCheckInMergefieldDebugInfo {
            get {
                return ResourceManager.GetString("_039_MigrationRollupsForV7_2_UpdateCheckInMergefieldDebugInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @simpleCommunicationDetailBlockId INT = (
        /// SELECT TOP 1 Id
        /// FROM [Block]
        /// WHERE [Guid] = &apos;A02F7695-4C6E-44E9-84CB-42E6F51F285F&apos;
        /// )
        ///
        /// DECLARE @wizardCommunicationDetailBlockId INT = (
        /// SELECT TOP 1 Id
        /// FROM [Block]
        /// WHERE [Guid] = &apos;25D890B9-9609-4B63-AD25-4AE427205563&apos;
        /// )
        ///
        ///DECLARE @entityTypeIdBlock INT = (
        /// SELECT TOP 1 Id
        /// FROM EntityType
        /// WHERE [Guid] = &apos;D89555CA-9AE4-4D62-8AF1-E5E463C1EF65&apos;
        /// ) /* Rock.Model.Block */
        ///
        ///
        ///INSERT INTO [Auth] (
        /// EntityTypeid
        /// ,EntityId
        /// ,[Order]
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _041_MigrationRollupsForV7_3_UpdateWizardCommunicationDetailApprovers {
            get {
                return ResourceManager.GetString("_041_MigrationRollupsForV7_3_UpdateWizardCommunicationDetailApprovers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        /// 		This stored procedure detects potential duplicate person records and stores the results in [PersonDuplicate]
        ///	&lt;/summary&gt;
        ///	
        ///	&lt;remarks&gt;	
        ///		Uses the following constants:
        ///			* Group Type - Family: &apos;790E3215-3B10-442B-AF69-616C0DCB998E&apos;
        ///            * Location Type - Home: &apos;8C52E53C-2A66-435A-AE6E-5EE307D9A0DC&apos;
        ///            * Phone Type - Home: &apos;407E7E45-7B2E-4FCD-9605-ECB1339F2453&apos;
        ///            * Phone Type - Cell: &apos;AA8732FB-2CEA-4C76-8D6D-6AAA2C6A4303&apos;
        ///	&lt;/remarks&gt;
        ///	&lt;code&gt;
        ///		EX [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _043_MoreMigrationRollupsForV7_3_spCrm_PersonDuplicateFinder {
            get {
                return ResourceManager.GetString("_043_MoreMigrationRollupsForV7_3_spCrm_PersonDuplicateFinder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        /// 		This function converts a comma-delimited string of values into a table of values
        ///        It comes from http://www.sqlservercentral.com/articles/Tally+Table/72993/
        ///	&lt;/summary&gt;
        ///	&lt;returns&gt;
        ///		* id
        ///	&lt;/returns&gt;
        ///	&lt;remarks&gt;
        ///		Used by spFinance_ContributionStatementQuery
        ///	&lt;/remarks&gt;
        ///	&lt;code&gt;
        ///		SELECT * FROM [dbo].[ufnUtility_CsvToTable](&apos;1,3,7,11,13&apos;) 
        ///	&lt;/code&gt;
        ///&lt;/doc&gt;
        ///*/
        ///ALTER FUNCTION [dbo].[ufnUtility_CsvToTable] 
        ///(
        ///	@pString VARCHAR(8000)
        ///)
        ///RETURNS TABLE WITH SCHEMABINDI [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _043_MoreMigrationRollupsForV7_3_ufnUtility_CsvToTable {
            get {
                return ResourceManager.GetString("_043_MoreMigrationRollupsForV7_3_ufnUtility_CsvToTable", resourceCulture);
            }
        }
    }
}
