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
    /// A Discussionmessage Object
    /// </summary>
    [DataContract(Name = "discussionmessage-Response")]
    public partial class DiscussionmessageResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EDiscussionmessageStatus
        /// </summary>
        [DataMember(Name = "eDiscussionmessageStatus", IsRequired = true, EmitDefaultValue = true)]
        public FieldEDiscussionmessageStatus EDiscussionmessageStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionmessageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscussionmessageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionmessageResponse" /> class.
        /// </summary>
        /// <param name="pkiDiscussionmessageID">The unique ID of the Discussionmessage (required).</param>
        /// <param name="fkiDiscussionID">The unique ID of the Discussion (required).</param>
        /// <param name="fkiDiscussionmembershipID">The unique ID of the Discussionmembership.</param>
        /// <param name="fkiDiscussionmembershipIDActionrequired">The unique ID of the Discussionmembership.</param>
        /// <param name="eDiscussionmessageStatus">eDiscussionmessageStatus (required).</param>
        /// <param name="tDiscussionmessageContent">The content of the Discussionmessage (required).</param>
        /// <param name="sDiscussionmessageCreatorname">The name the creator of the Discussionmessage. (required).</param>
        /// <param name="sDiscussionmessageActionrequiredname">The name the Actionrequired of the Discussionmessage..</param>
        /// <param name="objAudit">objAudit (required).</param>
        public DiscussionmessageResponse(int pkiDiscussionmessageID = default(int), int fkiDiscussionID = default(int), int fkiDiscussionmembershipID = default(int), int fkiDiscussionmembershipIDActionrequired = default(int), FieldEDiscussionmessageStatus eDiscussionmessageStatus = default(FieldEDiscussionmessageStatus), string tDiscussionmessageContent = default(string), string sDiscussionmessageCreatorname = default(string), string sDiscussionmessageActionrequiredname = default(string), CommonAudit objAudit = default(CommonAudit))
        {
            this.PkiDiscussionmessageID = pkiDiscussionmessageID;
            this.FkiDiscussionID = fkiDiscussionID;
            this.EDiscussionmessageStatus = eDiscussionmessageStatus;
            // to ensure "tDiscussionmessageContent" is required (not null)
            if (tDiscussionmessageContent == null)
            {
                throw new ArgumentNullException("tDiscussionmessageContent is a required property for DiscussionmessageResponse and cannot be null");
            }
            this.TDiscussionmessageContent = tDiscussionmessageContent;
            // to ensure "sDiscussionmessageCreatorname" is required (not null)
            if (sDiscussionmessageCreatorname == null)
            {
                throw new ArgumentNullException("sDiscussionmessageCreatorname is a required property for DiscussionmessageResponse and cannot be null");
            }
            this.SDiscussionmessageCreatorname = sDiscussionmessageCreatorname;
            // to ensure "objAudit" is required (not null)
            if (objAudit == null)
            {
                throw new ArgumentNullException("objAudit is a required property for DiscussionmessageResponse and cannot be null");
            }
            this.ObjAudit = objAudit;
            this.FkiDiscussionmembershipID = fkiDiscussionmembershipID;
            this.FkiDiscussionmembershipIDActionrequired = fkiDiscussionmembershipIDActionrequired;
            this.SDiscussionmessageActionrequiredname = sDiscussionmessageActionrequiredname;
        }

        /// <summary>
        /// The unique ID of the Discussionmessage
        /// </summary>
        /// <value>The unique ID of the Discussionmessage</value>
        /* <example>123</example>*/
        [DataMember(Name = "pkiDiscussionmessageID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiDiscussionmessageID { get; set; }

        /// <summary>
        /// The unique ID of the Discussion
        /// </summary>
        /// <value>The unique ID of the Discussion</value>
        /* <example>125</example>*/
        [DataMember(Name = "fkiDiscussionID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiDiscussionID { get; set; }

        /// <summary>
        /// The unique ID of the Discussionmembership
        /// </summary>
        /// <value>The unique ID of the Discussionmembership</value>
        /* <example>165</example>*/
        [DataMember(Name = "fkiDiscussionmembershipID", EmitDefaultValue = false)]
        public int FkiDiscussionmembershipID { get; set; }

        /// <summary>
        /// The unique ID of the Discussionmembership
        /// </summary>
        /// <value>The unique ID of the Discussionmembership</value>
        /* <example>165</example>*/
        [DataMember(Name = "fkiDiscussionmembershipIDActionrequired", EmitDefaultValue = false)]
        public int FkiDiscussionmembershipIDActionrequired { get; set; }

        /// <summary>
        /// The content of the Discussionmessage
        /// </summary>
        /// <value>The content of the Discussionmessage</value>
        /* <example>Hello, this is an example of content in a message</example>*/
        [DataMember(Name = "tDiscussionmessageContent", IsRequired = true, EmitDefaultValue = true)]
        public string TDiscussionmessageContent { get; set; }

        /// <summary>
        /// The name the creator of the Discussionmessage.
        /// </summary>
        /// <value>The name the creator of the Discussionmessage.</value>
        /* <example>John Doe</example>*/
        [DataMember(Name = "sDiscussionmessageCreatorname", IsRequired = true, EmitDefaultValue = true)]
        public string SDiscussionmessageCreatorname { get; set; }

        /// <summary>
        /// The name the Actionrequired of the Discussionmessage.
        /// </summary>
        /// <value>The name the Actionrequired of the Discussionmessage.</value>
        /* <example>Jane Doe</example>*/
        [DataMember(Name = "sDiscussionmessageActionrequiredname", EmitDefaultValue = false)]
        public string SDiscussionmessageActionrequiredname { get; set; }

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
            sb.Append("class DiscussionmessageResponse {\n");
            sb.Append("  PkiDiscussionmessageID: ").Append(PkiDiscussionmessageID).Append("\n");
            sb.Append("  FkiDiscussionID: ").Append(FkiDiscussionID).Append("\n");
            sb.Append("  FkiDiscussionmembershipID: ").Append(FkiDiscussionmembershipID).Append("\n");
            sb.Append("  FkiDiscussionmembershipIDActionrequired: ").Append(FkiDiscussionmembershipIDActionrequired).Append("\n");
            sb.Append("  EDiscussionmessageStatus: ").Append(EDiscussionmessageStatus).Append("\n");
            sb.Append("  TDiscussionmessageContent: ").Append(TDiscussionmessageContent).Append("\n");
            sb.Append("  SDiscussionmessageCreatorname: ").Append(SDiscussionmessageCreatorname).Append("\n");
            sb.Append("  SDiscussionmessageActionrequiredname: ").Append(SDiscussionmessageActionrequiredname).Append("\n");
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
            // PkiDiscussionmessageID (int) maximum
            if (this.PkiDiscussionmessageID > (int)16777215)
            {
                yield return new ValidationResult("Invalid value for PkiDiscussionmessageID, must be a value less than or equal to 16777215.", new [] { "PkiDiscussionmessageID" });
            }

            // PkiDiscussionmessageID (int) minimum
            if (this.PkiDiscussionmessageID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiDiscussionmessageID, must be a value greater than or equal to 0.", new [] { "PkiDiscussionmessageID" });
            }

            // FkiDiscussionID (int) maximum
            if (this.FkiDiscussionID > (int)16777215)
            {
                yield return new ValidationResult("Invalid value for FkiDiscussionID, must be a value less than or equal to 16777215.", new [] { "FkiDiscussionID" });
            }

            // FkiDiscussionID (int) minimum
            if (this.FkiDiscussionID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiDiscussionID, must be a value greater than or equal to 0.", new [] { "FkiDiscussionID" });
            }

            // FkiDiscussionmembershipID (int) maximum
            if (this.FkiDiscussionmembershipID > (int)16777215)
            {
                yield return new ValidationResult("Invalid value for FkiDiscussionmembershipID, must be a value less than or equal to 16777215.", new [] { "FkiDiscussionmembershipID" });
            }

            // FkiDiscussionmembershipID (int) minimum
            if (this.FkiDiscussionmembershipID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiDiscussionmembershipID, must be a value greater than or equal to 0.", new [] { "FkiDiscussionmembershipID" });
            }

            // FkiDiscussionmembershipIDActionrequired (int) maximum
            if (this.FkiDiscussionmembershipIDActionrequired > (int)16777215)
            {
                yield return new ValidationResult("Invalid value for FkiDiscussionmembershipIDActionrequired, must be a value less than or equal to 16777215.", new [] { "FkiDiscussionmembershipIDActionrequired" });
            }

            // FkiDiscussionmembershipIDActionrequired (int) minimum
            if (this.FkiDiscussionmembershipIDActionrequired < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiDiscussionmembershipIDActionrequired, must be a value greater than or equal to 0.", new [] { "FkiDiscussionmembershipIDActionrequired" });
            }

            if (this.TDiscussionmessageContent != null) {
                // TDiscussionmessageContent (string) pattern
                Regex regexTDiscussionmessageContent = new Regex(@"^.{0,65535}$", RegexOptions.CultureInvariant);
                if (!regexTDiscussionmessageContent.Match(this.TDiscussionmessageContent).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TDiscussionmessageContent, must match a pattern of " + regexTDiscussionmessageContent, new [] { "TDiscussionmessageContent" });
                }
            }

            if (this.SDiscussionmessageCreatorname != null) {
                // SDiscussionmessageCreatorname (string) pattern
                Regex regexSDiscussionmessageCreatorname = new Regex(@"^.{0,75}$", RegexOptions.CultureInvariant);
                if (!regexSDiscussionmessageCreatorname.Match(this.SDiscussionmessageCreatorname).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SDiscussionmessageCreatorname, must match a pattern of " + regexSDiscussionmessageCreatorname, new [] { "SDiscussionmessageCreatorname" });
                }
            }

            if (this.SDiscussionmessageActionrequiredname != null) {
                // SDiscussionmessageActionrequiredname (string) pattern
                Regex regexSDiscussionmessageActionrequiredname = new Regex(@"^.{0,75}$", RegexOptions.CultureInvariant);
                if (!regexSDiscussionmessageActionrequiredname.Match(this.SDiscussionmessageActionrequiredname).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SDiscussionmessageActionrequiredname, must match a pattern of " + regexSDiscussionmessageActionrequiredname, new [] { "SDiscussionmessageActionrequiredname" });
                }
            }

            yield break;
        }
    }

}
