/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// A custom Webhook object
    /// </summary>
    [DataContract]
    public partial class CustomWebhookResponse :  IEquatable<CustomWebhookResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomWebhookResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomWebhookResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomWebhookResponse" /> class.
        /// </summary>
        /// <param name="pksCustomerCode">The customer code assigned to your account (required).</param>
        /// <param name="bWebhookTest">Wheter the webhook received is a manual test or a real event (required).</param>
        /// <param name="pkiWebhookID">The unique ID of the Webhook (required).</param>
        /// <param name="sWebhookDescription">The description of the Webhook (required).</param>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype..</param>
        /// <param name="sEzsignfoldertypeNameX">The name of the Ezsignfoldertype in the language of the requester.</param>
        /// <param name="eWebhookModule">eWebhookModule (required).</param>
        /// <param name="eWebhookEzsignevent">eWebhookEzsignevent.</param>
        /// <param name="eWebhookManagementevent">eWebhookManagementevent.</param>
        /// <param name="sWebhookUrl">The URL of the Webhook callback (required).</param>
        /// <param name="sWebhookEmailfailed">The email that will receive the Webhook in case all attempts fail (required).</param>
        /// <param name="bWebhookIsactive">Whether the Webhook is active or not.</param>
        /// <param name="bWebhookSkipsslvalidation">Wheter the server&#39;s SSL certificate should be validated or not. Not recommended to skip for production use (required).</param>
        public CustomWebhookResponse(string pksCustomerCode = default(string), bool bWebhookTest = default(bool), int pkiWebhookID = default(int), string sWebhookDescription = default(string), int fkiEzsignfoldertypeID = default(int), string sEzsignfoldertypeNameX = default(string), FieldEWebhookModule eWebhookModule = default(FieldEWebhookModule), FieldEWebhookEzsignevent eWebhookEzsignevent = default(FieldEWebhookEzsignevent), FieldEWebhookManagementevent eWebhookManagementevent = default(FieldEWebhookManagementevent), string sWebhookUrl = default(string), string sWebhookEmailfailed = default(string), bool bWebhookIsactive = default(bool), bool bWebhookSkipsslvalidation = default(bool))
        {
            // to ensure "pksCustomerCode" is required (not null)
            if (pksCustomerCode == null)
            {
                throw new InvalidDataException("pksCustomerCode is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.PksCustomerCode = pksCustomerCode;
            }

            // to ensure "bWebhookTest" is required (not null)
            if (bWebhookTest == null)
            {
                throw new InvalidDataException("bWebhookTest is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.BWebhookTest = bWebhookTest;
            }

            // to ensure "pkiWebhookID" is required (not null)
            if (pkiWebhookID == null)
            {
                throw new InvalidDataException("pkiWebhookID is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.PkiWebhookID = pkiWebhookID;
            }

            // to ensure "sWebhookDescription" is required (not null)
            if (sWebhookDescription == null)
            {
                throw new InvalidDataException("sWebhookDescription is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.SWebhookDescription = sWebhookDescription;
            }

            // to ensure "eWebhookModule" is required (not null)
            if (eWebhookModule == null)
            {
                throw new InvalidDataException("eWebhookModule is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.EWebhookModule = eWebhookModule;
            }

            // to ensure "sWebhookUrl" is required (not null)
            if (sWebhookUrl == null)
            {
                throw new InvalidDataException("sWebhookUrl is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.SWebhookUrl = sWebhookUrl;
            }

            // to ensure "sWebhookEmailfailed" is required (not null)
            if (sWebhookEmailfailed == null)
            {
                throw new InvalidDataException("sWebhookEmailfailed is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.SWebhookEmailfailed = sWebhookEmailfailed;
            }

            // to ensure "bWebhookSkipsslvalidation" is required (not null)
            if (bWebhookSkipsslvalidation == null)
            {
                throw new InvalidDataException("bWebhookSkipsslvalidation is a required property for CustomWebhookResponse and cannot be null");
            }
            else
            {
                this.BWebhookSkipsslvalidation = bWebhookSkipsslvalidation;
            }

            this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            this.SEzsignfoldertypeNameX = sEzsignfoldertypeNameX;
            this.EWebhookEzsignevent = eWebhookEzsignevent;
            this.EWebhookManagementevent = eWebhookManagementevent;
            this.BWebhookIsactive = bWebhookIsactive;
        }

        /// <summary>
        /// The customer code assigned to your account
        /// </summary>
        /// <value>The customer code assigned to your account</value>
        [DataMember(Name="pksCustomerCode", EmitDefaultValue=true)]
        public string PksCustomerCode { get; set; }

        /// <summary>
        /// Wheter the webhook received is a manual test or a real event
        /// </summary>
        /// <value>Wheter the webhook received is a manual test or a real event</value>
        [DataMember(Name="bWebhookTest", EmitDefaultValue=true)]
        public bool BWebhookTest { get; set; }

        /// <summary>
        /// The unique ID of the Webhook
        /// </summary>
        /// <value>The unique ID of the Webhook</value>
        [DataMember(Name="pkiWebhookID", EmitDefaultValue=true)]
        public int PkiWebhookID { get; set; }

        /// <summary>
        /// The description of the Webhook
        /// </summary>
        /// <value>The description of the Webhook</value>
        [DataMember(Name="sWebhookDescription", EmitDefaultValue=true)]
        public string SWebhookDescription { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.</value>
        [DataMember(Name="fkiEzsignfoldertypeID", EmitDefaultValue=false)]
        public int FkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The name of the Ezsignfoldertype in the language of the requester
        /// </summary>
        /// <value>The name of the Ezsignfoldertype in the language of the requester</value>
        [DataMember(Name="sEzsignfoldertypeNameX", EmitDefaultValue=false)]
        public string SEzsignfoldertypeNameX { get; set; }

        /// <summary>
        /// Gets or Sets EWebhookModule
        /// </summary>
        [DataMember(Name="eWebhookModule", EmitDefaultValue=true)]
        public FieldEWebhookModule EWebhookModule { get; set; }

        /// <summary>
        /// Gets or Sets EWebhookEzsignevent
        /// </summary>
        [DataMember(Name="eWebhookEzsignevent", EmitDefaultValue=false)]
        public FieldEWebhookEzsignevent EWebhookEzsignevent { get; set; }

        /// <summary>
        /// Gets or Sets EWebhookManagementevent
        /// </summary>
        [DataMember(Name="eWebhookManagementevent", EmitDefaultValue=false)]
        public FieldEWebhookManagementevent EWebhookManagementevent { get; set; }

        /// <summary>
        /// The URL of the Webhook callback
        /// </summary>
        /// <value>The URL of the Webhook callback</value>
        [DataMember(Name="sWebhookUrl", EmitDefaultValue=true)]
        public string SWebhookUrl { get; set; }

        /// <summary>
        /// The email that will receive the Webhook in case all attempts fail
        /// </summary>
        /// <value>The email that will receive the Webhook in case all attempts fail</value>
        [DataMember(Name="sWebhookEmailfailed", EmitDefaultValue=true)]
        public string SWebhookEmailfailed { get; set; }

        /// <summary>
        /// Whether the Webhook is active or not
        /// </summary>
        /// <value>Whether the Webhook is active or not</value>
        [DataMember(Name="bWebhookIsactive", EmitDefaultValue=false)]
        public bool BWebhookIsactive { get; set; }

        /// <summary>
        /// Wheter the server&#39;s SSL certificate should be validated or not. Not recommended to skip for production use
        /// </summary>
        /// <value>Wheter the server&#39;s SSL certificate should be validated or not. Not recommended to skip for production use</value>
        [DataMember(Name="bWebhookSkipsslvalidation", EmitDefaultValue=true)]
        public bool BWebhookSkipsslvalidation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomWebhookResponse {\n");
            sb.Append("  PksCustomerCode: ").Append(PksCustomerCode).Append("\n");
            sb.Append("  BWebhookTest: ").Append(BWebhookTest).Append("\n");
            sb.Append("  PkiWebhookID: ").Append(PkiWebhookID).Append("\n");
            sb.Append("  SWebhookDescription: ").Append(SWebhookDescription).Append("\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  SEzsignfoldertypeNameX: ").Append(SEzsignfoldertypeNameX).Append("\n");
            sb.Append("  EWebhookModule: ").Append(EWebhookModule).Append("\n");
            sb.Append("  EWebhookEzsignevent: ").Append(EWebhookEzsignevent).Append("\n");
            sb.Append("  EWebhookManagementevent: ").Append(EWebhookManagementevent).Append("\n");
            sb.Append("  SWebhookUrl: ").Append(SWebhookUrl).Append("\n");
            sb.Append("  SWebhookEmailfailed: ").Append(SWebhookEmailfailed).Append("\n");
            sb.Append("  BWebhookIsactive: ").Append(BWebhookIsactive).Append("\n");
            sb.Append("  BWebhookSkipsslvalidation: ").Append(BWebhookSkipsslvalidation).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomWebhookResponse);
        }

        /// <summary>
        /// Returns true if CustomWebhookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomWebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomWebhookResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PksCustomerCode == input.PksCustomerCode ||
                    (this.PksCustomerCode != null &&
                    this.PksCustomerCode.Equals(input.PksCustomerCode))
                ) && 
                (
                    this.BWebhookTest == input.BWebhookTest ||
                    (this.BWebhookTest != null &&
                    this.BWebhookTest.Equals(input.BWebhookTest))
                ) && 
                (
                    this.PkiWebhookID == input.PkiWebhookID ||
                    (this.PkiWebhookID != null &&
                    this.PkiWebhookID.Equals(input.PkiWebhookID))
                ) && 
                (
                    this.SWebhookDescription == input.SWebhookDescription ||
                    (this.SWebhookDescription != null &&
                    this.SWebhookDescription.Equals(input.SWebhookDescription))
                ) && 
                (
                    this.FkiEzsignfoldertypeID == input.FkiEzsignfoldertypeID ||
                    (this.FkiEzsignfoldertypeID != null &&
                    this.FkiEzsignfoldertypeID.Equals(input.FkiEzsignfoldertypeID))
                ) && 
                (
                    this.SEzsignfoldertypeNameX == input.SEzsignfoldertypeNameX ||
                    (this.SEzsignfoldertypeNameX != null &&
                    this.SEzsignfoldertypeNameX.Equals(input.SEzsignfoldertypeNameX))
                ) && 
                (
                    this.EWebhookModule == input.EWebhookModule ||
                    (this.EWebhookModule != null &&
                    this.EWebhookModule.Equals(input.EWebhookModule))
                ) && 
                (
                    this.EWebhookEzsignevent == input.EWebhookEzsignevent ||
                    (this.EWebhookEzsignevent != null &&
                    this.EWebhookEzsignevent.Equals(input.EWebhookEzsignevent))
                ) && 
                (
                    this.EWebhookManagementevent == input.EWebhookManagementevent ||
                    (this.EWebhookManagementevent != null &&
                    this.EWebhookManagementevent.Equals(input.EWebhookManagementevent))
                ) && 
                (
                    this.SWebhookUrl == input.SWebhookUrl ||
                    (this.SWebhookUrl != null &&
                    this.SWebhookUrl.Equals(input.SWebhookUrl))
                ) && 
                (
                    this.SWebhookEmailfailed == input.SWebhookEmailfailed ||
                    (this.SWebhookEmailfailed != null &&
                    this.SWebhookEmailfailed.Equals(input.SWebhookEmailfailed))
                ) && 
                (
                    this.BWebhookIsactive == input.BWebhookIsactive ||
                    (this.BWebhookIsactive != null &&
                    this.BWebhookIsactive.Equals(input.BWebhookIsactive))
                ) && 
                (
                    this.BWebhookSkipsslvalidation == input.BWebhookSkipsslvalidation ||
                    (this.BWebhookSkipsslvalidation != null &&
                    this.BWebhookSkipsslvalidation.Equals(input.BWebhookSkipsslvalidation))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PksCustomerCode != null)
                    hashCode = hashCode * 59 + this.PksCustomerCode.GetHashCode();
                if (this.BWebhookTest != null)
                    hashCode = hashCode * 59 + this.BWebhookTest.GetHashCode();
                if (this.PkiWebhookID != null)
                    hashCode = hashCode * 59 + this.PkiWebhookID.GetHashCode();
                if (this.SWebhookDescription != null)
                    hashCode = hashCode * 59 + this.SWebhookDescription.GetHashCode();
                if (this.FkiEzsignfoldertypeID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfoldertypeID.GetHashCode();
                if (this.SEzsignfoldertypeNameX != null)
                    hashCode = hashCode * 59 + this.SEzsignfoldertypeNameX.GetHashCode();
                if (this.EWebhookModule != null)
                    hashCode = hashCode * 59 + this.EWebhookModule.GetHashCode();
                if (this.EWebhookEzsignevent != null)
                    hashCode = hashCode * 59 + this.EWebhookEzsignevent.GetHashCode();
                if (this.EWebhookManagementevent != null)
                    hashCode = hashCode * 59 + this.EWebhookManagementevent.GetHashCode();
                if (this.SWebhookUrl != null)
                    hashCode = hashCode * 59 + this.SWebhookUrl.GetHashCode();
                if (this.SWebhookEmailfailed != null)
                    hashCode = hashCode * 59 + this.SWebhookEmailfailed.GetHashCode();
                if (this.BWebhookIsactive != null)
                    hashCode = hashCode * 59 + this.BWebhookIsactive.GetHashCode();
                if (this.BWebhookSkipsslvalidation != null)
                    hashCode = hashCode * 59 + this.BWebhookSkipsslvalidation.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PksCustomerCode (string) maxLength
            if(this.PksCustomerCode != null && this.PksCustomerCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PksCustomerCode, length must be less than 6.", new [] { "PksCustomerCode" });
            }

            // PksCustomerCode (string) minLength
            if(this.PksCustomerCode != null && this.PksCustomerCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PksCustomerCode, length must be greater than 2.", new [] { "PksCustomerCode" });
            }



            // FkiEzsignfoldertypeID (int) minimum
            if(this.FkiEzsignfoldertypeID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignfoldertypeID, must be a value greater than or equal to 0.", new [] { "FkiEzsignfoldertypeID" });
            }

            yield break;
        }
    }

}