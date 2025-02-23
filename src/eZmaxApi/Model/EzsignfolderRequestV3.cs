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
    /// An Ezsignfolder Object
    /// </summary>
    [DataContract(Name = "ezsignfolder-RequestV3")]
    public partial class EzsignfolderRequestV3 : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EEzsignfolderDocumentdependency
        /// </summary>
        [DataMember(Name = "eEzsignfolderDocumentdependency", EmitDefaultValue = false)]
        public FieldEEzsignfolderDocumentdependency? EEzsignfolderDocumentdependency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderRequestV3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderRequestV3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderRequestV3" /> class.
        /// </summary>
        /// <param name="pkiEzsignfolderID">The unique ID of the Ezsignfolder.</param>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype. (required).</param>
        /// <param name="fkiTimezoneID">The unique ID of the Timezone.</param>
        /// <param name="fkiEzsigntsarequirementID">The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|.</param>
        /// <param name="eEzsignfolderDocumentdependency">eEzsignfolderDocumentdependency.</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsignfolder (required).</param>
        /// <param name="tEzsignfolderNote">Note about the Ezsignfolder.</param>
        /// <param name="tEzsignfolderMessage">A custom text message that will be added to the email sent..</param>
        /// <param name="iEzsignfolderSendreminderfirstdays">The number of days before the the first reminder sending (required).</param>
        /// <param name="iEzsignfolderSendreminderotherdays">The number of days after the first reminder sending (required).</param>
        /// <param name="sEzsignfolderExternalid">This field can be used to store an External ID from the client&#39;s system.  Anything can be stored in this field, it will never be evaluated by the eZmax system and will be returned AS-IS.  To store multiple values, consider using a JSON formatted structure, a URL encoded string, a CSV or any other custom format. .</param>
        public EzsignfolderRequestV3(int pkiEzsignfolderID = default(int), int fkiEzsignfoldertypeID = default(int), int fkiTimezoneID = default(int), int fkiEzsigntsarequirementID = default(int), FieldEEzsignfolderDocumentdependency? eEzsignfolderDocumentdependency = default(FieldEEzsignfolderDocumentdependency?), string sEzsignfolderDescription = default(string), string tEzsignfolderNote = default(string), string tEzsignfolderMessage = default(string), int iEzsignfolderSendreminderfirstdays = default(int), int iEzsignfolderSendreminderotherdays = default(int), string sEzsignfolderExternalid = default(string))
        {
            this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            // to ensure "sEzsignfolderDescription" is required (not null)
            if (sEzsignfolderDescription == null)
            {
                throw new ArgumentNullException("sEzsignfolderDescription is a required property for EzsignfolderRequestV3 and cannot be null");
            }
            this.SEzsignfolderDescription = sEzsignfolderDescription;
            this.IEzsignfolderSendreminderfirstdays = iEzsignfolderSendreminderfirstdays;
            this.IEzsignfolderSendreminderotherdays = iEzsignfolderSendreminderotherdays;
            this.PkiEzsignfolderID = pkiEzsignfolderID;
            this.FkiTimezoneID = fkiTimezoneID;
            this.FkiEzsigntsarequirementID = fkiEzsigntsarequirementID;
            this.EEzsignfolderDocumentdependency = eEzsignfolderDocumentdependency;
            this.TEzsignfolderNote = tEzsignfolderNote;
            this.TEzsignfolderMessage = tEzsignfolderMessage;
            this.SEzsignfolderExternalid = sEzsignfolderExternalid;
        }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        /* <example>33</example>*/
        [DataMember(Name = "pkiEzsignfolderID", EmitDefaultValue = false)]
        public int PkiEzsignfolderID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.</value>
        /* <example>5</example>*/
        [DataMember(Name = "fkiEzsignfoldertypeID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The unique ID of the Timezone
        /// </summary>
        /// <value>The unique ID of the Timezone</value>
        /* <example>247</example>*/
        [DataMember(Name = "fkiTimezoneID", EmitDefaultValue = false)]
        public int FkiTimezoneID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|
        /// </summary>
        /// <value>The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|</value>
        /* <example>1</example>*/
        [DataMember(Name = "fkiEzsigntsarequirementID", EmitDefaultValue = false)]
        public int FkiEzsigntsarequirementID { get; set; }

        /// <summary>
        /// The description of the Ezsignfolder
        /// </summary>
        /// <value>The description of the Ezsignfolder</value>
        /* <example>Test eZsign Folder</example>*/
        [DataMember(Name = "sEzsignfolderDescription", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsignfolderDescription { get; set; }

        /// <summary>
        /// Note about the Ezsignfolder
        /// </summary>
        /// <value>Note about the Ezsignfolder</value>
        /* <example>This is a note</example>*/
        [DataMember(Name = "tEzsignfolderNote", EmitDefaultValue = false)]
        public string TEzsignfolderNote { get; set; }

        /// <summary>
        /// A custom text message that will be added to the email sent.
        /// </summary>
        /// <value>A custom text message that will be added to the email sent.</value>
        /* <example>Hi everyone,

This is the document I need you to review.

Could you sign it before Monday please.

Best Regards.

Mary</example>*/
        [DataMember(Name = "tEzsignfolderMessage", EmitDefaultValue = false)]
        public string TEzsignfolderMessage { get; set; }

        /// <summary>
        /// The number of days before the the first reminder sending
        /// </summary>
        /// <value>The number of days before the the first reminder sending</value>
        /* <example>30</example>*/
        [DataMember(Name = "iEzsignfolderSendreminderfirstdays", IsRequired = true, EmitDefaultValue = true)]
        public int IEzsignfolderSendreminderfirstdays { get; set; }

        /// <summary>
        /// The number of days after the first reminder sending
        /// </summary>
        /// <value>The number of days after the first reminder sending</value>
        /* <example>30</example>*/
        [DataMember(Name = "iEzsignfolderSendreminderotherdays", IsRequired = true, EmitDefaultValue = true)]
        public int IEzsignfolderSendreminderotherdays { get; set; }

        /// <summary>
        /// This field can be used to store an External ID from the client&#39;s system.  Anything can be stored in this field, it will never be evaluated by the eZmax system and will be returned AS-IS.  To store multiple values, consider using a JSON formatted structure, a URL encoded string, a CSV or any other custom format. 
        /// </summary>
        /// <value>This field can be used to store an External ID from the client&#39;s system.  Anything can be stored in this field, it will never be evaluated by the eZmax system and will be returned AS-IS.  To store multiple values, consider using a JSON formatted structure, a URL encoded string, a CSV or any other custom format. </value>
        /* <example>{&quot;ID&quot;: 1234, &quot;TAGS&quot;: [&quot;tag1&quot;, &quot;tag2&quot;, &quot;tag3&quot;]}</example>*/
        [DataMember(Name = "sEzsignfolderExternalid", EmitDefaultValue = false)]
        public string SEzsignfolderExternalid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignfolderRequestV3 {\n");
            sb.Append("  PkiEzsignfolderID: ").Append(PkiEzsignfolderID).Append("\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  FkiTimezoneID: ").Append(FkiTimezoneID).Append("\n");
            sb.Append("  FkiEzsigntsarequirementID: ").Append(FkiEzsigntsarequirementID).Append("\n");
            sb.Append("  EEzsignfolderDocumentdependency: ").Append(EEzsignfolderDocumentdependency).Append("\n");
            sb.Append("  SEzsignfolderDescription: ").Append(SEzsignfolderDescription).Append("\n");
            sb.Append("  TEzsignfolderNote: ").Append(TEzsignfolderNote).Append("\n");
            sb.Append("  TEzsignfolderMessage: ").Append(TEzsignfolderMessage).Append("\n");
            sb.Append("  IEzsignfolderSendreminderfirstdays: ").Append(IEzsignfolderSendreminderfirstdays).Append("\n");
            sb.Append("  IEzsignfolderSendreminderotherdays: ").Append(IEzsignfolderSendreminderotherdays).Append("\n");
            sb.Append("  SEzsignfolderExternalid: ").Append(SEzsignfolderExternalid).Append("\n");
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
            // PkiEzsignfolderID (int) minimum
            if (this.PkiEzsignfolderID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzsignfolderID, must be a value greater than or equal to 0.", new [] { "PkiEzsignfolderID" });
            }

            // FkiEzsignfoldertypeID (int) maximum
            if (this.FkiEzsignfoldertypeID > (int)65535)
            {
                yield return new ValidationResult("Invalid value for FkiEzsignfoldertypeID, must be a value less than or equal to 65535.", new [] { "FkiEzsignfoldertypeID" });
            }

            // FkiEzsignfoldertypeID (int) minimum
            if (this.FkiEzsignfoldertypeID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsignfoldertypeID, must be a value greater than or equal to 0.", new [] { "FkiEzsignfoldertypeID" });
            }

            // FkiTimezoneID (int) minimum
            if (this.FkiTimezoneID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiTimezoneID, must be a value greater than or equal to 0.", new [] { "FkiTimezoneID" });
            }

            // FkiEzsigntsarequirementID (int) maximum
            if (this.FkiEzsigntsarequirementID > (int)3)
            {
                yield return new ValidationResult("Invalid value for FkiEzsigntsarequirementID, must be a value less than or equal to 3.", new [] { "FkiEzsigntsarequirementID" });
            }

            // FkiEzsigntsarequirementID (int) minimum
            if (this.FkiEzsigntsarequirementID < (int)1)
            {
                yield return new ValidationResult("Invalid value for FkiEzsigntsarequirementID, must be a value greater than or equal to 1.", new [] { "FkiEzsigntsarequirementID" });
            }

            if (this.SEzsignfolderDescription != null) {
                // SEzsignfolderDescription (string) pattern
                Regex regexSEzsignfolderDescription = new Regex(@"^.{0,75}$", RegexOptions.CultureInvariant);
                if (!regexSEzsignfolderDescription.Match(this.SEzsignfolderDescription).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignfolderDescription, must match a pattern of " + regexSEzsignfolderDescription, new [] { "SEzsignfolderDescription" });
                }
            }

            // IEzsignfolderSendreminderfirstdays (int) maximum
            if (this.IEzsignfolderSendreminderfirstdays > (int)255)
            {
                yield return new ValidationResult("Invalid value for IEzsignfolderSendreminderfirstdays, must be a value less than or equal to 255.", new [] { "IEzsignfolderSendreminderfirstdays" });
            }

            // IEzsignfolderSendreminderfirstdays (int) minimum
            if (this.IEzsignfolderSendreminderfirstdays < (int)0)
            {
                yield return new ValidationResult("Invalid value for IEzsignfolderSendreminderfirstdays, must be a value greater than or equal to 0.", new [] { "IEzsignfolderSendreminderfirstdays" });
            }

            // IEzsignfolderSendreminderotherdays (int) maximum
            if (this.IEzsignfolderSendreminderotherdays > (int)255)
            {
                yield return new ValidationResult("Invalid value for IEzsignfolderSendreminderotherdays, must be a value less than or equal to 255.", new [] { "IEzsignfolderSendreminderotherdays" });
            }

            // IEzsignfolderSendreminderotherdays (int) minimum
            if (this.IEzsignfolderSendreminderotherdays < (int)0)
            {
                yield return new ValidationResult("Invalid value for IEzsignfolderSendreminderotherdays, must be a value greater than or equal to 0.", new [] { "IEzsignfolderSendreminderotherdays" });
            }

            if (this.SEzsignfolderExternalid != null) {
                // SEzsignfolderExternalid (string) pattern
                Regex regexSEzsignfolderExternalid = new Regex(@"^.{0,128}$", RegexOptions.CultureInvariant);
                if (!regexSEzsignfolderExternalid.Match(this.SEzsignfolderExternalid).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignfolderExternalid, must match a pattern of " + regexSEzsignfolderExternalid, new [] { "SEzsignfolderExternalid" });
                }
            }

            yield break;
        }
    }

}
