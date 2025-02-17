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
    /// Generic AutocompleteElement Response
    /// </summary>
    [DataContract(Name = "Custom-Communicationrecipientsrecipient-Response")]
    public partial class CustomCommunicationrecipientsrecipientResponse : IValidatableObject
    {
        /// <summary>
        /// Defines ECommunicationrecipientsrecipientObjecttype
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ECommunicationrecipientsrecipientObjecttypeEnum
        {
            /// <summary>
            /// Enum Agent for value: Agent
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent = 1,

            /// <summary>
            /// Enum Agentincorporation for value: Agentincorporation
            /// </summary>
            [EnumMember(Value = "Agentincorporation")]
            Agentincorporation = 2,

            /// <summary>
            /// Enum Assistant for value: Assistant
            /// </summary>
            [EnumMember(Value = "Assistant")]
            Assistant = 3,

            /// <summary>
            /// Enum Broker for value: Broker
            /// </summary>
            [EnumMember(Value = "Broker")]
            Broker = 4,

            /// <summary>
            /// Enum Contact for value: Contact
            /// </summary>
            [EnumMember(Value = "Contact")]
            Contact = 5,

            /// <summary>
            /// Enum Customer for value: Customer
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer = 6,

            /// <summary>
            /// Enum Employee for value: Employee
            /// </summary>
            [EnumMember(Value = "Employee")]
            Employee = 7,

            /// <summary>
            /// Enum Externalbroker for value: Externalbroker
            /// </summary>
            [EnumMember(Value = "Externalbroker")]
            Externalbroker = 8,

            /// <summary>
            /// Enum Ezcomagent for value: Ezcomagent
            /// </summary>
            [EnumMember(Value = "Ezcomagent")]
            Ezcomagent = 9,

            /// <summary>
            /// Enum Ezcomcompany for value: Ezcomcompany
            /// </summary>
            [EnumMember(Value = "Ezcomcompany")]
            Ezcomcompany = 10,

            /// <summary>
            /// Enum Ezsignsigner for value: Ezsignsigner
            /// </summary>
            [EnumMember(Value = "Ezsignsigner")]
            Ezsignsigner = 11,

            /// <summary>
            /// Enum Franchiseoffice for value: Franchiseoffice
            /// </summary>
            [EnumMember(Value = "Franchiseoffice")]
            Franchiseoffice = 12,

            /// <summary>
            /// Enum Notary for value: Notary
            /// </summary>
            [EnumMember(Value = "Notary")]
            Notary = 13,

            /// <summary>
            /// Enum Rewardmember for value: Rewardmember
            /// </summary>
            [EnumMember(Value = "Rewardmember")]
            Rewardmember = 14,

            /// <summary>
            /// Enum Supplier for value: Supplier
            /// </summary>
            [EnumMember(Value = "Supplier")]
            Supplier = 15,

            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 16
        }


        /// <summary>
        /// Gets or Sets ECommunicationrecipientsrecipientObjecttype
        /// </summary>
        /* <example>User</example>*/
        [DataMember(Name = "eCommunicationrecipientsrecipientObjecttype", IsRequired = true, EmitDefaultValue = true)]
        public ECommunicationrecipientsrecipientObjecttypeEnum ECommunicationrecipientsrecipientObjecttype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCommunicationrecipientsrecipientResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomCommunicationrecipientsrecipientResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCommunicationrecipientsrecipientResponse" /> class.
        /// </summary>
        /// <param name="fkiAgentID">The unique ID of the Agent..</param>
        /// <param name="fkiBrokerID">The unique ID of the Broker..</param>
        /// <param name="fkiContactID">The unique ID of the Contact.</param>
        /// <param name="fkiCustomerID">The unique ID of the Customer..</param>
        /// <param name="fkiEmployeeID">The unique ID of the Employee..</param>
        /// <param name="fkiEzsignsignerID">The unique ID of the Ezsignsigner.</param>
        /// <param name="fkiFranchiseofficeID">The unique ID of the Franchisereoffice.</param>
        /// <param name="fkiUserID">The unique ID of the User.</param>
        /// <param name="fkiAgentincorporationID">The unique ID of the Agentincorporation..</param>
        /// <param name="fkiAssistantID">The unique ID of the Assistant..</param>
        /// <param name="fkiExternalbrokerID">The unique ID of the Externalbroker..</param>
        /// <param name="fkiEzcomagentID">The unique ID of the Ezcomagent..</param>
        /// <param name="fkiNotaryID">The unique ID of the Notary..</param>
        /// <param name="fkiRewardmemberID">The unique ID of the Rewardmember..</param>
        /// <param name="fkiSupplierID">The unique ID of the Supplier..</param>
        /// <param name="eCommunicationrecipientsrecipientObjecttype">eCommunicationrecipientsrecipientObjecttype (required).</param>
        /// <param name="objContactName">objContactName (required).</param>
        /// <param name="objEmail">objEmail.</param>
        /// <param name="objPhoneFax">objPhoneFax.</param>
        /// <param name="objPhoneSMS">objPhoneSMS.</param>
        public CustomCommunicationrecipientsrecipientResponse(int fkiAgentID = default(int), int fkiBrokerID = default(int), int fkiContactID = default(int), int fkiCustomerID = default(int), int fkiEmployeeID = default(int), int fkiEzsignsignerID = default(int), int fkiFranchiseofficeID = default(int), int fkiUserID = default(int), int fkiAgentincorporationID = default(int), int fkiAssistantID = default(int), int fkiExternalbrokerID = default(int), int fkiEzcomagentID = default(int), int fkiNotaryID = default(int), int fkiRewardmemberID = default(int), int fkiSupplierID = default(int), ECommunicationrecipientsrecipientObjecttypeEnum eCommunicationrecipientsrecipientObjecttype = default(ECommunicationrecipientsrecipientObjecttypeEnum), CustomContactNameResponse objContactName = default(CustomContactNameResponse), EmailResponseCompound objEmail = default(EmailResponseCompound), PhoneResponseCompound objPhoneFax = default(PhoneResponseCompound), PhoneResponseCompound objPhoneSMS = default(PhoneResponseCompound))
        {
            this.ECommunicationrecipientsrecipientObjecttype = eCommunicationrecipientsrecipientObjecttype;
            // to ensure "objContactName" is required (not null)
            if (objContactName == null)
            {
                throw new ArgumentNullException("objContactName is a required property for CustomCommunicationrecipientsrecipientResponse and cannot be null");
            }
            this.ObjContactName = objContactName;
            this.FkiAgentID = fkiAgentID;
            this.FkiBrokerID = fkiBrokerID;
            this.FkiContactID = fkiContactID;
            this.FkiCustomerID = fkiCustomerID;
            this.FkiEmployeeID = fkiEmployeeID;
            this.FkiEzsignsignerID = fkiEzsignsignerID;
            this.FkiFranchiseofficeID = fkiFranchiseofficeID;
            this.FkiUserID = fkiUserID;
            this.FkiAgentincorporationID = fkiAgentincorporationID;
            this.FkiAssistantID = fkiAssistantID;
            this.FkiExternalbrokerID = fkiExternalbrokerID;
            this.FkiEzcomagentID = fkiEzcomagentID;
            this.FkiNotaryID = fkiNotaryID;
            this.FkiRewardmemberID = fkiRewardmemberID;
            this.FkiSupplierID = fkiSupplierID;
            this.ObjEmail = objEmail;
            this.ObjPhoneFax = objPhoneFax;
            this.ObjPhoneSMS = objPhoneSMS;
        }

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
        /// The unique ID of the Contact
        /// </summary>
        /// <value>The unique ID of the Contact</value>
        /* <example>21</example>*/
        [DataMember(Name = "fkiContactID", EmitDefaultValue = false)]
        public int FkiContactID { get; set; }

        /// <summary>
        /// The unique ID of the Customer.
        /// </summary>
        /// <value>The unique ID of the Customer.</value>
        /* <example>18</example>*/
        [DataMember(Name = "fkiCustomerID", EmitDefaultValue = false)]
        public int FkiCustomerID { get; set; }

        /// <summary>
        /// The unique ID of the Employee.
        /// </summary>
        /// <value>The unique ID of the Employee.</value>
        /* <example>31</example>*/
        [DataMember(Name = "fkiEmployeeID", EmitDefaultValue = false)]
        public int FkiEmployeeID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignsigner
        /// </summary>
        /// <value>The unique ID of the Ezsignsigner</value>
        /* <example>89</example>*/
        [DataMember(Name = "fkiEzsignsignerID", EmitDefaultValue = false)]
        public int FkiEzsignsignerID { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereoffice
        /// </summary>
        /// <value>The unique ID of the Franchisereoffice</value>
        /* <example>50</example>*/
        [DataMember(Name = "fkiFranchiseofficeID", EmitDefaultValue = false)]
        public int FkiFranchiseofficeID { get; set; }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        /* <example>70</example>*/
        [DataMember(Name = "fkiUserID", EmitDefaultValue = false)]
        public int FkiUserID { get; set; }

        /// <summary>
        /// The unique ID of the Agentincorporation.
        /// </summary>
        /// <value>The unique ID of the Agentincorporation.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiAgentincorporationID", EmitDefaultValue = false)]
        public int FkiAgentincorporationID { get; set; }

        /// <summary>
        /// The unique ID of the Assistant.
        /// </summary>
        /// <value>The unique ID of the Assistant.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiAssistantID", EmitDefaultValue = false)]
        public int FkiAssistantID { get; set; }

        /// <summary>
        /// The unique ID of the Externalbroker.
        /// </summary>
        /// <value>The unique ID of the Externalbroker.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiExternalbrokerID", EmitDefaultValue = false)]
        public int FkiExternalbrokerID { get; set; }

        /// <summary>
        /// The unique ID of the Ezcomagent.
        /// </summary>
        /// <value>The unique ID of the Ezcomagent.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiEzcomagentID", EmitDefaultValue = false)]
        public int FkiEzcomagentID { get; set; }

        /// <summary>
        /// The unique ID of the Notary.
        /// </summary>
        /// <value>The unique ID of the Notary.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiNotaryID", EmitDefaultValue = false)]
        public int FkiNotaryID { get; set; }

        /// <summary>
        /// The unique ID of the Rewardmember.
        /// </summary>
        /// <value>The unique ID of the Rewardmember.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiRewardmemberID", EmitDefaultValue = false)]
        public int FkiRewardmemberID { get; set; }

        /// <summary>
        /// The unique ID of the Supplier.
        /// </summary>
        /// <value>The unique ID of the Supplier.</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiSupplierID", EmitDefaultValue = false)]
        public int FkiSupplierID { get; set; }

        /// <summary>
        /// Gets or Sets ObjContactName
        /// </summary>
        [DataMember(Name = "objContactName", IsRequired = true, EmitDefaultValue = true)]
        public CustomContactNameResponse ObjContactName { get; set; }

        /// <summary>
        /// Gets or Sets ObjEmail
        /// </summary>
        [DataMember(Name = "objEmail", EmitDefaultValue = false)]
        public EmailResponseCompound ObjEmail { get; set; }

        /// <summary>
        /// Gets or Sets ObjPhoneFax
        /// </summary>
        [DataMember(Name = "objPhoneFax", EmitDefaultValue = false)]
        public PhoneResponseCompound ObjPhoneFax { get; set; }

        /// <summary>
        /// Gets or Sets ObjPhoneSMS
        /// </summary>
        [DataMember(Name = "objPhoneSMS", EmitDefaultValue = false)]
        public PhoneResponseCompound ObjPhoneSMS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomCommunicationrecipientsrecipientResponse {\n");
            sb.Append("  FkiAgentID: ").Append(FkiAgentID).Append("\n");
            sb.Append("  FkiBrokerID: ").Append(FkiBrokerID).Append("\n");
            sb.Append("  FkiContactID: ").Append(FkiContactID).Append("\n");
            sb.Append("  FkiCustomerID: ").Append(FkiCustomerID).Append("\n");
            sb.Append("  FkiEmployeeID: ").Append(FkiEmployeeID).Append("\n");
            sb.Append("  FkiEzsignsignerID: ").Append(FkiEzsignsignerID).Append("\n");
            sb.Append("  FkiFranchiseofficeID: ").Append(FkiFranchiseofficeID).Append("\n");
            sb.Append("  FkiUserID: ").Append(FkiUserID).Append("\n");
            sb.Append("  FkiAgentincorporationID: ").Append(FkiAgentincorporationID).Append("\n");
            sb.Append("  FkiAssistantID: ").Append(FkiAssistantID).Append("\n");
            sb.Append("  FkiExternalbrokerID: ").Append(FkiExternalbrokerID).Append("\n");
            sb.Append("  FkiEzcomagentID: ").Append(FkiEzcomagentID).Append("\n");
            sb.Append("  FkiNotaryID: ").Append(FkiNotaryID).Append("\n");
            sb.Append("  FkiRewardmemberID: ").Append(FkiRewardmemberID).Append("\n");
            sb.Append("  FkiSupplierID: ").Append(FkiSupplierID).Append("\n");
            sb.Append("  ECommunicationrecipientsrecipientObjecttype: ").Append(ECommunicationrecipientsrecipientObjecttype).Append("\n");
            sb.Append("  ObjContactName: ").Append(ObjContactName).Append("\n");
            sb.Append("  ObjEmail: ").Append(ObjEmail).Append("\n");
            sb.Append("  ObjPhoneFax: ").Append(ObjPhoneFax).Append("\n");
            sb.Append("  ObjPhoneSMS: ").Append(ObjPhoneSMS).Append("\n");
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

            // FkiContactID (int) minimum
            if (this.FkiContactID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiContactID, must be a value greater than or equal to 0.", new [] { "FkiContactID" });
            }

            // FkiCustomerID (int) minimum
            if (this.FkiCustomerID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiCustomerID, must be a value greater than or equal to 0.", new [] { "FkiCustomerID" });
            }

            // FkiEmployeeID (int) minimum
            if (this.FkiEmployeeID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEmployeeID, must be a value greater than or equal to 0.", new [] { "FkiEmployeeID" });
            }

            // FkiEzsignsignerID (int) minimum
            if (this.FkiEzsignsignerID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsignsignerID, must be a value greater than or equal to 0.", new [] { "FkiEzsignsignerID" });
            }

            // FkiFranchiseofficeID (int) minimum
            if (this.FkiFranchiseofficeID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiFranchiseofficeID, must be a value greater than or equal to 0.", new [] { "FkiFranchiseofficeID" });
            }

            // FkiUserID (int) minimum
            if (this.FkiUserID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiUserID, must be a value greater than or equal to 0.", new [] { "FkiUserID" });
            }

            // FkiAgentincorporationID (int) minimum
            if (this.FkiAgentincorporationID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiAgentincorporationID, must be a value greater than or equal to 0.", new [] { "FkiAgentincorporationID" });
            }

            // FkiAssistantID (int) minimum
            if (this.FkiAssistantID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiAssistantID, must be a value greater than or equal to 0.", new [] { "FkiAssistantID" });
            }

            // FkiExternalbrokerID (int) minimum
            if (this.FkiExternalbrokerID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiExternalbrokerID, must be a value greater than or equal to 0.", new [] { "FkiExternalbrokerID" });
            }

            // FkiEzcomagentID (int) minimum
            if (this.FkiEzcomagentID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzcomagentID, must be a value greater than or equal to 0.", new [] { "FkiEzcomagentID" });
            }

            // FkiNotaryID (int) minimum
            if (this.FkiNotaryID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiNotaryID, must be a value greater than or equal to 0.", new [] { "FkiNotaryID" });
            }

            // FkiRewardmemberID (int) minimum
            if (this.FkiRewardmemberID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiRewardmemberID, must be a value greater than or equal to 0.", new [] { "FkiRewardmemberID" });
            }

            // FkiSupplierID (int) minimum
            if (this.FkiSupplierID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiSupplierID, must be a value greater than or equal to 0.", new [] { "FkiSupplierID" });
            }

            yield break;
        }
    }

}
