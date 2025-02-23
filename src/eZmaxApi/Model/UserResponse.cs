/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.1
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// A User Object
    /// </summary>
    [DataContract(Name = "user-Response")]
    public partial class UserResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EUserOrigin
        /// </summary>
        [DataMember(Name = "eUserOrigin", IsRequired = true, EmitDefaultValue = true)]
        public FieldEUserOrigin EUserOrigin { get; set; }

        /// <summary>
        /// Gets or Sets EUserType
        /// </summary>
        [DataMember(Name = "eUserType", IsRequired = true, EmitDefaultValue = true)]
        public FieldEUserType EUserType { get; set; }

        /// <summary>
        /// Gets or Sets EUserLogintype
        /// </summary>
        [DataMember(Name = "eUserLogintype", IsRequired = true, EmitDefaultValue = true)]
        public FieldEUserLogintype EUserLogintype { get; set; }

        /// <summary>
        /// Gets or Sets EUserEzsignaccess
        /// </summary>
        [DataMember(Name = "eUserEzsignaccess", IsRequired = true, EmitDefaultValue = true)]
        public FieldEUserEzsignaccess EUserEzsignaccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        /// <param name="pkiUserID">The unique ID of the User (required).</param>
        /// <param name="fkiAgentID">The unique ID of the Agent..</param>
        /// <param name="fkiBrokerID">The unique ID of the Broker..</param>
        /// <param name="fkiAssistantID">The unique ID of the Assistant..</param>
        /// <param name="fkiEmployeeID">The unique ID of the Employee..</param>
        /// <param name="fkiCompanyIDDefault">The unique ID of the Company (required).</param>
        /// <param name="sCompanyNameX">The Name of the Company in the language of the requester (required).</param>
        /// <param name="fkiDepartmentIDDefault">The unique ID of the Department (required).</param>
        /// <param name="sDepartmentNameX">The Name of the Department in the language of the requester (required).</param>
        /// <param name="fkiTimezoneID">The unique ID of the Timezone (required).</param>
        /// <param name="sTimezoneName">The description of the Timezone (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sLanguageNameX">The Name of the Language in the language of the requester (required).</param>
        /// <param name="objEmail">objEmail (required).</param>
        /// <param name="fkiBillingentityinternalID">The unique ID of the Billingentityinternal. (required).</param>
        /// <param name="sBillingentityinternalDescriptionX">The description of the Billingentityinternal in the language of the requester (required).</param>
        /// <param name="objPhoneHome">objPhoneHome.</param>
        /// <param name="objPhoneSMS">objPhoneSMS.</param>
        /// <param name="fkiSecretquestionID">The unique ID of the Secretquestion.  Valid values:  |Value|Description| |-|-| |1|The name of the hospital in which you were born| |2|The name of your grade school| |3|The last name of your favorite teacher| |4|Your favorite sports team| |5|Your favorite TV show| |6|Your favorite movie| |7|The name of the street on which you grew up| |8|The name of your first employer| |9|Your first car| |10|Your favorite food| |11|The name of your first pet| |12|Favorite musician/band| |13|What instrument you play| |14|Your father&#39;s middle name| |15|Your mother&#39;s maiden name| |16|Name of your eldest child| |17|Your spouse&#39;s middle name| |18|Favorite restaurant| |19|Childhood nickname| |20|Favorite vacation destination| |21|Your boat&#39;s name| |22|Date of Birth (YYYY-MM-DD)| |22|Secret Code| |22|Your reference code|.</param>
        /// <param name="fkiModuleIDForm">The unique ID of the Module.</param>
        /// <param name="sModuleNameX">The Name of the Module in the language of the requester.</param>
        /// <param name="eUserOrigin">eUserOrigin (required).</param>
        /// <param name="eUserType">eUserType (required).</param>
        /// <param name="eUserLogintype">eUserLogintype (required).</param>
        /// <param name="sUserFirstname">The first name of the user (required).</param>
        /// <param name="sUserLastname">The last name of the user (required).</param>
        /// <param name="sUserLoginname">The login name of the User. (required).</param>
        /// <param name="sUserJobtitle">The job title of the user.</param>
        /// <param name="eUserEzsignaccess">eUserEzsignaccess (required).</param>
        /// <param name="dtUserLastlogondate">The last logon date of the User.</param>
        /// <param name="dtUserPasswordchanged">The date at which the User&#39;s password was last changed.</param>
        /// <param name="dtUserEzsignprepaidexpiration">The eZsign prepaid expiration date.</param>
        /// <param name="bUserIsactive">Whether the User is active or not (required).</param>
        /// <param name="bUserValidatebyadministration">Whether if the transactions in which the User is implicated must be validated by administrative personnel or not.</param>
        /// <param name="bUserValidatebydirector">Whether if the transactions in which the User is implicated must be validated by a director or not.</param>
        /// <param name="bUserAttachmentautoverified">Whether if Attachments uploaded by the User must be validated or not.</param>
        /// <param name="bUserChangepassword">Whether if the User is forced to change its password (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public UserResponse(int pkiUserID = default(int), int fkiAgentID = default(int), int fkiBrokerID = default(int), int fkiAssistantID = default(int), int fkiEmployeeID = default(int), int fkiCompanyIDDefault = default(int), string sCompanyNameX = default(string), int fkiDepartmentIDDefault = default(int), string sDepartmentNameX = default(string), int fkiTimezoneID = default(int), string sTimezoneName = default(string), int fkiLanguageID = default(int), string sLanguageNameX = default(string), EmailResponseCompound objEmail = default(EmailResponseCompound), int fkiBillingentityinternalID = default(int), string sBillingentityinternalDescriptionX = default(string), PhoneResponseCompound objPhoneHome = default(PhoneResponseCompound), PhoneResponseCompound objPhoneSMS = default(PhoneResponseCompound), int fkiSecretquestionID = default(int), int fkiModuleIDForm = default(int), string sModuleNameX = default(string), FieldEUserOrigin eUserOrigin = default(FieldEUserOrigin), FieldEUserType eUserType = default(FieldEUserType), FieldEUserLogintype eUserLogintype = default(FieldEUserLogintype), string sUserFirstname = default(string), string sUserLastname = default(string), string sUserLoginname = default(string), string sUserJobtitle = default(string), FieldEUserEzsignaccess eUserEzsignaccess = default(FieldEUserEzsignaccess), string dtUserLastlogondate = default(string), string dtUserPasswordchanged = default(string), string dtUserEzsignprepaidexpiration = default(string), bool bUserIsactive = default(bool), bool bUserValidatebyadministration = default(bool), bool bUserValidatebydirector = default(bool), bool bUserAttachmentautoverified = default(bool), bool bUserChangepassword = default(bool), CommonAudit objAudit = default(CommonAudit))
        {
            this.PkiUserID = pkiUserID;
            this.FkiCompanyIDDefault = fkiCompanyIDDefault;
            // to ensure "sCompanyNameX" is required (not null)
            if (sCompanyNameX == null)
            {
                throw new ArgumentNullException("sCompanyNameX is a required property for UserResponse and cannot be null");
            }
            this.SCompanyNameX = sCompanyNameX;
            this.FkiDepartmentIDDefault = fkiDepartmentIDDefault;
            // to ensure "sDepartmentNameX" is required (not null)
            if (sDepartmentNameX == null)
            {
                throw new ArgumentNullException("sDepartmentNameX is a required property for UserResponse and cannot be null");
            }
            this.SDepartmentNameX = sDepartmentNameX;
            this.FkiTimezoneID = fkiTimezoneID;
            // to ensure "sTimezoneName" is required (not null)
            if (sTimezoneName == null)
            {
                throw new ArgumentNullException("sTimezoneName is a required property for UserResponse and cannot be null");
            }
            this.STimezoneName = sTimezoneName;
            this.FkiLanguageID = fkiLanguageID;
            // to ensure "sLanguageNameX" is required (not null)
            if (sLanguageNameX == null)
            {
                throw new ArgumentNullException("sLanguageNameX is a required property for UserResponse and cannot be null");
            }
            this.SLanguageNameX = sLanguageNameX;
            // to ensure "objEmail" is required (not null)
            if (objEmail == null)
            {
                throw new ArgumentNullException("objEmail is a required property for UserResponse and cannot be null");
            }
            this.ObjEmail = objEmail;
            this.FkiBillingentityinternalID = fkiBillingentityinternalID;
            // to ensure "sBillingentityinternalDescriptionX" is required (not null)
            if (sBillingentityinternalDescriptionX == null)
            {
                throw new ArgumentNullException("sBillingentityinternalDescriptionX is a required property for UserResponse and cannot be null");
            }
            this.SBillingentityinternalDescriptionX = sBillingentityinternalDescriptionX;
            this.EUserOrigin = eUserOrigin;
            this.EUserType = eUserType;
            this.EUserLogintype = eUserLogintype;
            // to ensure "sUserFirstname" is required (not null)
            if (sUserFirstname == null)
            {
                throw new ArgumentNullException("sUserFirstname is a required property for UserResponse and cannot be null");
            }
            this.SUserFirstname = sUserFirstname;
            // to ensure "sUserLastname" is required (not null)
            if (sUserLastname == null)
            {
                throw new ArgumentNullException("sUserLastname is a required property for UserResponse and cannot be null");
            }
            this.SUserLastname = sUserLastname;
            // to ensure "sUserLoginname" is required (not null)
            if (sUserLoginname == null)
            {
                throw new ArgumentNullException("sUserLoginname is a required property for UserResponse and cannot be null");
            }
            this.SUserLoginname = sUserLoginname;
            this.EUserEzsignaccess = eUserEzsignaccess;
            this.BUserIsactive = bUserIsactive;
            this.BUserChangepassword = bUserChangepassword;
            // to ensure "objAudit" is required (not null)
            if (objAudit == null)
            {
                throw new ArgumentNullException("objAudit is a required property for UserResponse and cannot be null");
            }
            this.ObjAudit = objAudit;
            this.FkiAgentID = fkiAgentID;
            this.FkiBrokerID = fkiBrokerID;
            this.FkiAssistantID = fkiAssistantID;
            this.FkiEmployeeID = fkiEmployeeID;
            this.ObjPhoneHome = objPhoneHome;
            this.ObjPhoneSMS = objPhoneSMS;
            this.FkiSecretquestionID = fkiSecretquestionID;
            this.FkiModuleIDForm = fkiModuleIDForm;
            this.SModuleNameX = sModuleNameX;
            this.SUserJobtitle = sUserJobtitle;
            this.DtUserLastlogondate = dtUserLastlogondate;
            this.DtUserPasswordchanged = dtUserPasswordchanged;
            this.DtUserEzsignprepaidexpiration = dtUserEzsignprepaidexpiration;
            this.BUserValidatebyadministration = bUserValidatebyadministration;
            this.BUserValidatebydirector = bUserValidatebydirector;
            this.BUserAttachmentautoverified = bUserAttachmentautoverified;
        }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        /* <example>70</example>*/
        [DataMember(Name = "pkiUserID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiUserID { get; set; }

        /// <summary>
        /// The unique ID of the Agent.
        /// </summary>
        /// <value>The unique ID of the Agent.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiAgentID", EmitDefaultValue = false)]
        public int FkiAgentID { get; set; }

        /// <summary>
        /// The unique ID of the Broker.
        /// </summary>
        /// <value>The unique ID of the Broker.</value>
        /* <example>26</example>*/
        [DataMember(Name = "fkiBrokerID", EmitDefaultValue = false)]
        public int FkiBrokerID { get; set; }

        /// <summary>
        /// The unique ID of the Assistant.
        /// </summary>
        /// <value>The unique ID of the Assistant.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiAssistantID", EmitDefaultValue = false)]
        public int FkiAssistantID { get; set; }

        /// <summary>
        /// The unique ID of the Employee.
        /// </summary>
        /// <value>The unique ID of the Employee.</value>
        /* <example>31</example>*/
        [DataMember(Name = "fkiEmployeeID", EmitDefaultValue = false)]
        public int FkiEmployeeID { get; set; }

        /// <summary>
        /// The unique ID of the Company
        /// </summary>
        /// <value>The unique ID of the Company</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiCompanyIDDefault", IsRequired = true, EmitDefaultValue = true)]
        public int FkiCompanyIDDefault { get; set; }

        /// <summary>
        /// The Name of the Company in the language of the requester
        /// </summary>
        /// <value>The Name of the Company in the language of the requester</value>
        /* <example>Acme inc.</example>*/
        [DataMember(Name = "sCompanyNameX", IsRequired = true, EmitDefaultValue = true)]
        public string SCompanyNameX { get; set; }

        /// <summary>
        /// The unique ID of the Department
        /// </summary>
        /// <value>The unique ID of the Department</value>
        /* <example>21</example>*/
        [DataMember(Name = "fkiDepartmentIDDefault", IsRequired = true, EmitDefaultValue = true)]
        public int FkiDepartmentIDDefault { get; set; }

        /// <summary>
        /// The Name of the Department in the language of the requester
        /// </summary>
        /// <value>The Name of the Department in the language of the requester</value>
        /* <example>Head Office</example>*/
        [DataMember(Name = "sDepartmentNameX", IsRequired = true, EmitDefaultValue = true)]
        public string SDepartmentNameX { get; set; }

        /// <summary>
        /// The unique ID of the Timezone
        /// </summary>
        /// <value>The unique ID of the Timezone</value>
        /* <example>247</example>*/
        [DataMember(Name = "fkiTimezoneID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiTimezoneID { get; set; }

        /// <summary>
        /// The description of the Timezone
        /// </summary>
        /// <value>The description of the Timezone</value>
        /* <example>Default</example>*/
        [DataMember(Name = "sTimezoneName", IsRequired = true, EmitDefaultValue = true)]
        public string STimezoneName { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        /* <example>2</example>*/
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// The Name of the Language in the language of the requester
        /// </summary>
        /// <value>The Name of the Language in the language of the requester</value>
        /* <example>English</example>*/
        [DataMember(Name = "sLanguageNameX", IsRequired = true, EmitDefaultValue = true)]
        public string SLanguageNameX { get; set; }

        /// <summary>
        /// Gets or Sets ObjEmail
        /// </summary>
        [DataMember(Name = "objEmail", IsRequired = true, EmitDefaultValue = true)]
        public EmailResponseCompound ObjEmail { get; set; }

        /// <summary>
        /// The unique ID of the Billingentityinternal.
        /// </summary>
        /// <value>The unique ID of the Billingentityinternal.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiBillingentityinternalID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiBillingentityinternalID { get; set; }

        /// <summary>
        /// The description of the Billingentityinternal in the language of the requester
        /// </summary>
        /// <value>The description of the Billingentityinternal in the language of the requester</value>
        /* <example>Default</example>*/
        [DataMember(Name = "sBillingentityinternalDescriptionX", IsRequired = true, EmitDefaultValue = true)]
        public string SBillingentityinternalDescriptionX { get; set; }

        /// <summary>
        /// Gets or Sets ObjPhoneHome
        /// </summary>
        [DataMember(Name = "objPhoneHome", EmitDefaultValue = false)]
        public PhoneResponseCompound ObjPhoneHome { get; set; }

        /// <summary>
        /// Gets or Sets ObjPhoneSMS
        /// </summary>
        [DataMember(Name = "objPhoneSMS", EmitDefaultValue = false)]
        public PhoneResponseCompound ObjPhoneSMS { get; set; }

        /// <summary>
        /// The unique ID of the Secretquestion.  Valid values:  |Value|Description| |-|-| |1|The name of the hospital in which you were born| |2|The name of your grade school| |3|The last name of your favorite teacher| |4|Your favorite sports team| |5|Your favorite TV show| |6|Your favorite movie| |7|The name of the street on which you grew up| |8|The name of your first employer| |9|Your first car| |10|Your favorite food| |11|The name of your first pet| |12|Favorite musician/band| |13|What instrument you play| |14|Your father&#39;s middle name| |15|Your mother&#39;s maiden name| |16|Name of your eldest child| |17|Your spouse&#39;s middle name| |18|Favorite restaurant| |19|Childhood nickname| |20|Favorite vacation destination| |21|Your boat&#39;s name| |22|Date of Birth (YYYY-MM-DD)| |22|Secret Code| |22|Your reference code|
        /// </summary>
        /// <value>The unique ID of the Secretquestion.  Valid values:  |Value|Description| |-|-| |1|The name of the hospital in which you were born| |2|The name of your grade school| |3|The last name of your favorite teacher| |4|Your favorite sports team| |5|Your favorite TV show| |6|Your favorite movie| |7|The name of the street on which you grew up| |8|The name of your first employer| |9|Your first car| |10|Your favorite food| |11|The name of your first pet| |12|Favorite musician/band| |13|What instrument you play| |14|Your father&#39;s middle name| |15|Your mother&#39;s maiden name| |16|Name of your eldest child| |17|Your spouse&#39;s middle name| |18|Favorite restaurant| |19|Childhood nickname| |20|Favorite vacation destination| |21|Your boat&#39;s name| |22|Date of Birth (YYYY-MM-DD)| |22|Secret Code| |22|Your reference code|</value>
        /* <example>7</example>*/
        [DataMember(Name = "fkiSecretquestionID", EmitDefaultValue = false)]
        public int FkiSecretquestionID { get; set; }

        /// <summary>
        /// The unique ID of the Module
        /// </summary>
        /// <value>The unique ID of the Module</value>
        /* <example>40</example>*/
        [DataMember(Name = "fkiModuleIDForm", EmitDefaultValue = false)]
        public int FkiModuleIDForm { get; set; }

        /// <summary>
        /// The Name of the Module in the language of the requester
        /// </summary>
        /// <value>The Name of the Module in the language of the requester</value>
        /* <example>Purchase</example>*/
        [DataMember(Name = "sModuleNameX", EmitDefaultValue = false)]
        public string SModuleNameX { get; set; }

        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        /* <example>John</example>*/
        [DataMember(Name = "sUserFirstname", IsRequired = true, EmitDefaultValue = true)]
        public string SUserFirstname { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        /* <example>Doe</example>*/
        [DataMember(Name = "sUserLastname", IsRequired = true, EmitDefaultValue = true)]
        public string SUserLastname { get; set; }

        /// <summary>
        /// The login name of the User.
        /// </summary>
        /// <value>The login name of the User.</value>
        /* <example>JohnDoe</example>*/
        [DataMember(Name = "sUserLoginname", IsRequired = true, EmitDefaultValue = true)]
        public string SUserLoginname { get; set; }

        /// <summary>
        /// The job title of the user
        /// </summary>
        /// <value>The job title of the user</value>
        /* <example>Sales Representative</example>*/
        [DataMember(Name = "sUserJobtitle", EmitDefaultValue = false)]
        public string SUserJobtitle { get; set; }

        /// <summary>
        /// The last logon date of the User
        /// </summary>
        /// <value>The last logon date of the User</value>
        /* <example>2020-12-31 23:59:59</example>*/
        [DataMember(Name = "dtUserLastlogondate", EmitDefaultValue = false)]
        public string DtUserLastlogondate { get; set; }

        /// <summary>
        /// The date at which the User&#39;s password was last changed
        /// </summary>
        /// <value>The date at which the User&#39;s password was last changed</value>
        /* <example>2020-12-31 23:59:59</example>*/
        [DataMember(Name = "dtUserPasswordchanged", EmitDefaultValue = false)]
        public string DtUserPasswordchanged { get; set; }

        /// <summary>
        /// The eZsign prepaid expiration date
        /// </summary>
        /// <value>The eZsign prepaid expiration date</value>
        /* <example>2020-12-31</example>*/
        [DataMember(Name = "dtUserEzsignprepaidexpiration", EmitDefaultValue = false)]
        public string DtUserEzsignprepaidexpiration { get; set; }

        /// <summary>
        /// Whether the User is active or not
        /// </summary>
        /// <value>Whether the User is active or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bUserIsactive", IsRequired = true, EmitDefaultValue = true)]
        public bool BUserIsactive { get; set; }

        /// <summary>
        /// Whether if the transactions in which the User is implicated must be validated by administrative personnel or not
        /// </summary>
        /// <value>Whether if the transactions in which the User is implicated must be validated by administrative personnel or not</value>
        /* <example>false</example>*/
        [DataMember(Name = "bUserValidatebyadministration", EmitDefaultValue = true)]
        public bool BUserValidatebyadministration { get; set; }

        /// <summary>
        /// Whether if the transactions in which the User is implicated must be validated by a director or not
        /// </summary>
        /// <value>Whether if the transactions in which the User is implicated must be validated by a director or not</value>
        /* <example>false</example>*/
        [DataMember(Name = "bUserValidatebydirector", EmitDefaultValue = true)]
        public bool BUserValidatebydirector { get; set; }

        /// <summary>
        /// Whether if Attachments uploaded by the User must be validated or not
        /// </summary>
        /// <value>Whether if Attachments uploaded by the User must be validated or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bUserAttachmentautoverified", EmitDefaultValue = true)]
        public bool BUserAttachmentautoverified { get; set; }

        /// <summary>
        /// Whether if the User is forced to change its password
        /// </summary>
        /// <value>Whether if the User is forced to change its password</value>
        /* <example>true</example>*/
        [DataMember(Name = "bUserChangepassword", IsRequired = true, EmitDefaultValue = true)]
        public bool BUserChangepassword { get; set; }

        /// <summary>
        /// Gets or Sets ObjAudit
        /// </summary>
        [DataMember(Name = "objAudit", IsRequired = true, EmitDefaultValue = true)]
        public CommonAudit ObjAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserResponse {\n");
            sb.Append("  PkiUserID: ").Append(PkiUserID).Append("\n");
            sb.Append("  FkiAgentID: ").Append(FkiAgentID).Append("\n");
            sb.Append("  FkiBrokerID: ").Append(FkiBrokerID).Append("\n");
            sb.Append("  FkiAssistantID: ").Append(FkiAssistantID).Append("\n");
            sb.Append("  FkiEmployeeID: ").Append(FkiEmployeeID).Append("\n");
            sb.Append("  FkiCompanyIDDefault: ").Append(FkiCompanyIDDefault).Append("\n");
            sb.Append("  SCompanyNameX: ").Append(SCompanyNameX).Append("\n");
            sb.Append("  FkiDepartmentIDDefault: ").Append(FkiDepartmentIDDefault).Append("\n");
            sb.Append("  SDepartmentNameX: ").Append(SDepartmentNameX).Append("\n");
            sb.Append("  FkiTimezoneID: ").Append(FkiTimezoneID).Append("\n");
            sb.Append("  STimezoneName: ").Append(STimezoneName).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  SLanguageNameX: ").Append(SLanguageNameX).Append("\n");
            sb.Append("  ObjEmail: ").Append(ObjEmail).Append("\n");
            sb.Append("  FkiBillingentityinternalID: ").Append(FkiBillingentityinternalID).Append("\n");
            sb.Append("  SBillingentityinternalDescriptionX: ").Append(SBillingentityinternalDescriptionX).Append("\n");
            sb.Append("  ObjPhoneHome: ").Append(ObjPhoneHome).Append("\n");
            sb.Append("  ObjPhoneSMS: ").Append(ObjPhoneSMS).Append("\n");
            sb.Append("  FkiSecretquestionID: ").Append(FkiSecretquestionID).Append("\n");
            sb.Append("  FkiModuleIDForm: ").Append(FkiModuleIDForm).Append("\n");
            sb.Append("  SModuleNameX: ").Append(SModuleNameX).Append("\n");
            sb.Append("  EUserOrigin: ").Append(EUserOrigin).Append("\n");
            sb.Append("  EUserType: ").Append(EUserType).Append("\n");
            sb.Append("  EUserLogintype: ").Append(EUserLogintype).Append("\n");
            sb.Append("  SUserFirstname: ").Append(SUserFirstname).Append("\n");
            sb.Append("  SUserLastname: ").Append(SUserLastname).Append("\n");
            sb.Append("  SUserLoginname: ").Append(SUserLoginname).Append("\n");
            sb.Append("  SUserJobtitle: ").Append(SUserJobtitle).Append("\n");
            sb.Append("  EUserEzsignaccess: ").Append(EUserEzsignaccess).Append("\n");
            sb.Append("  DtUserLastlogondate: ").Append(DtUserLastlogondate).Append("\n");
            sb.Append("  DtUserPasswordchanged: ").Append(DtUserPasswordchanged).Append("\n");
            sb.Append("  DtUserEzsignprepaidexpiration: ").Append(DtUserEzsignprepaidexpiration).Append("\n");
            sb.Append("  BUserIsactive: ").Append(BUserIsactive).Append("\n");
            sb.Append("  BUserValidatebyadministration: ").Append(BUserValidatebyadministration).Append("\n");
            sb.Append("  BUserValidatebydirector: ").Append(BUserValidatebydirector).Append("\n");
            sb.Append("  BUserAttachmentautoverified: ").Append(BUserAttachmentautoverified).Append("\n");
            sb.Append("  BUserChangepassword: ").Append(BUserChangepassword).Append("\n");
            sb.Append("  ObjAudit: ").Append(ObjAudit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PkiUserID (int) minimum
            if (this.PkiUserID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiUserID, must be a value greater than or equal to 0.", new [] { "PkiUserID" });
            }

            // FkiAgentID (int) minimum
            if (this.FkiAgentID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiAgentID, must be a value greater than or equal to 0.", new [] { "FkiAgentID" });
            }

            // FkiBrokerID (int) minimum
            if (this.FkiBrokerID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiBrokerID, must be a value greater than or equal to 0.", new [] { "FkiBrokerID" });
            }

            // FkiAssistantID (int) minimum
            if (this.FkiAssistantID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiAssistantID, must be a value greater than or equal to 0.", new [] { "FkiAssistantID" });
            }

            // FkiEmployeeID (int) minimum
            if (this.FkiEmployeeID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEmployeeID, must be a value greater than or equal to 0.", new [] { "FkiEmployeeID" });
            }

            // FkiCompanyIDDefault (int) maximum
            if (this.FkiCompanyIDDefault > (int)255)
            {
                yield return new ValidationResult("Invalid value for FkiCompanyIDDefault, must be a value less than or equal to 255.", new [] { "FkiCompanyIDDefault" });
            }

            // FkiCompanyIDDefault (int) minimum
            if (this.FkiCompanyIDDefault < (int)1)
            {
                yield return new ValidationResult("Invalid value for FkiCompanyIDDefault, must be a value greater than or equal to 1.", new [] { "FkiCompanyIDDefault" });
            }

            // FkiDepartmentIDDefault (int) minimum
            if (this.FkiDepartmentIDDefault < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiDepartmentIDDefault, must be a value greater than or equal to 0.", new [] { "FkiDepartmentIDDefault" });
            }

            // FkiTimezoneID (int) minimum
            if (this.FkiTimezoneID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiTimezoneID, must be a value greater than or equal to 0.", new [] { "FkiTimezoneID" });
            }

            // FkiLanguageID (int) maximum
            if (this.FkiLanguageID > (int)2)
            {
                yield return new ValidationResult("Invalid value for FkiLanguageID, must be a value less than or equal to 2.", new [] { "FkiLanguageID" });
            }

            // FkiLanguageID (int) minimum
            if (this.FkiLanguageID < (int)1)
            {
                yield return new ValidationResult("Invalid value for FkiLanguageID, must be a value greater than or equal to 1.", new [] { "FkiLanguageID" });
            }

            // FkiBillingentityinternalID (int) minimum
            if (this.FkiBillingentityinternalID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiBillingentityinternalID, must be a value greater than or equal to 0.", new [] { "FkiBillingentityinternalID" });
            }

            // FkiSecretquestionID (int) minimum
            if (this.FkiSecretquestionID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiSecretquestionID, must be a value greater than or equal to 0.", new [] { "FkiSecretquestionID" });
            }

            // FkiModuleIDForm (int) minimum
            if (this.FkiModuleIDForm < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiModuleIDForm, must be a value greater than or equal to 0.", new [] { "FkiModuleIDForm" });
            }

            if (this.SUserLoginname != null) {
                // SUserLoginname (string) pattern
                Regex regexSUserLoginname = new Regex(@"^(?:([\w.%+\-!#$%&'*+\/=?^`{|}~]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,20})|([a-zA-Z0-9]){1,32})$", RegexOptions.CultureInvariant);
                if (!regexSUserLoginname.Match(this.SUserLoginname).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SUserLoginname, must match a pattern of " + regexSUserLoginname, new [] { "SUserLoginname" });
                }
            }

            if (this.SUserJobtitle != null) {
                // SUserJobtitle (string) pattern
                Regex regexSUserJobtitle = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSUserJobtitle.Match(this.SUserJobtitle).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SUserJobtitle, must match a pattern of " + regexSUserJobtitle, new [] { "SUserJobtitle" });
                }
            }

            if (this.DtUserLastlogondate != null) {
                // DtUserLastlogondate (string) pattern
                Regex regexDtUserLastlogondate = new Regex(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1]) ([01]?[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])$", RegexOptions.CultureInvariant);
                if (!regexDtUserLastlogondate.Match(this.DtUserLastlogondate).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DtUserLastlogondate, must match a pattern of " + regexDtUserLastlogondate, new [] { "DtUserLastlogondate" });
                }
            }

            if (this.DtUserPasswordchanged != null) {
                // DtUserPasswordchanged (string) pattern
                Regex regexDtUserPasswordchanged = new Regex(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1]) ([01]?[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])$", RegexOptions.CultureInvariant);
                if (!regexDtUserPasswordchanged.Match(this.DtUserPasswordchanged).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DtUserPasswordchanged, must match a pattern of " + regexDtUserPasswordchanged, new [] { "DtUserPasswordchanged" });
                }
            }

            if (this.DtUserEzsignprepaidexpiration != null) {
                // DtUserEzsignprepaidexpiration (string) pattern
                Regex regexDtUserEzsignprepaidexpiration = new Regex(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$", RegexOptions.CultureInvariant);
                if (!regexDtUserEzsignprepaidexpiration.Match(this.DtUserEzsignprepaidexpiration).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DtUserEzsignprepaidexpiration, must match a pattern of " + regexDtUserEzsignprepaidexpiration, new [] { "DtUserEzsignprepaidexpiration" });
                }
            }

            yield break;
        }
    }

}
