/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// A Custom Ezsignfoldertype Object
    /// </summary>
    [DataContract(Name = "Custom-Ezsignfoldertype-Response")]
    public partial class CustomEzsignfoldertypeResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignfoldertypeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEzsignfoldertypeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignfoldertypeResponse" /> class.
        /// </summary>
        /// <param name="pkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype. (required).</param>
        /// <param name="sEzsignfoldertypeNameX">The name of the Ezsignfoldertype in the language of the requester.</param>
        /// <param name="bEzsignfoldertypeSendproofezsignsigner">Whether we send the proof in the email to Ezsignsigner.</param>
        /// <param name="bEzsignfoldertypeAllowdownloadattachmentezsignsigner">Whether we allow the Ezsigndocument to be downloaded by an Ezsignsigner.</param>
        /// <param name="bEzsignfoldertypeAllowdownloadproofezsignsigner">Whether we allow the proof to be downloaded by an Ezsignsigner.</param>
        /// <param name="bEzsignfoldertypeDelegate">Wheter if delegation of signature is allowed to another user or not.</param>
        /// <param name="bEzsignfoldertypeDiscussion">Wheter if creating a new Discussion is allowed or not.</param>
        /// <param name="bEzsignfoldertypeReassignezsignsigner">Wheter if Reassignment of signature is allowed by a signatory to another signatory or not.</param>
        /// <param name="bEzsignfoldertypeReassignuser">Wheter if Reassignment of signature is allowed by a user to a signatory or another user or not.</param>
        public CustomEzsignfoldertypeResponse(int pkiEzsignfoldertypeID = default(int), string sEzsignfoldertypeNameX = default(string), bool bEzsignfoldertypeSendproofezsignsigner = default(bool), bool bEzsignfoldertypeAllowdownloadattachmentezsignsigner = default(bool), bool bEzsignfoldertypeAllowdownloadproofezsignsigner = default(bool), bool bEzsignfoldertypeDelegate = default(bool), bool bEzsignfoldertypeDiscussion = default(bool), bool bEzsignfoldertypeReassignezsignsigner = default(bool), bool bEzsignfoldertypeReassignuser = default(bool))
        {
            this.PkiEzsignfoldertypeID = pkiEzsignfoldertypeID;
            this.SEzsignfoldertypeNameX = sEzsignfoldertypeNameX;
            this.BEzsignfoldertypeSendproofezsignsigner = bEzsignfoldertypeSendproofezsignsigner;
            this.BEzsignfoldertypeAllowdownloadattachmentezsignsigner = bEzsignfoldertypeAllowdownloadattachmentezsignsigner;
            this.BEzsignfoldertypeAllowdownloadproofezsignsigner = bEzsignfoldertypeAllowdownloadproofezsignsigner;
            this.BEzsignfoldertypeDelegate = bEzsignfoldertypeDelegate;
            this.BEzsignfoldertypeDiscussion = bEzsignfoldertypeDiscussion;
            this.BEzsignfoldertypeReassignezsignsigner = bEzsignfoldertypeReassignezsignsigner;
            this.BEzsignfoldertypeReassignuser = bEzsignfoldertypeReassignuser;
        }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.</value>
        /* <example>5</example>*/
        [DataMember(Name = "pkiEzsignfoldertypeID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The name of the Ezsignfoldertype in the language of the requester
        /// </summary>
        /// <value>The name of the Ezsignfoldertype in the language of the requester</value>
        /* <example>Default</example>*/
        [DataMember(Name = "sEzsignfoldertypeNameX", EmitDefaultValue = false)]
        public string SEzsignfoldertypeNameX { get; set; }

        /// <summary>
        /// Whether we send the proof in the email to Ezsignsigner
        /// </summary>
        /// <value>Whether we send the proof in the email to Ezsignsigner</value>
        /* <example>false</example>*/
        [DataMember(Name = "bEzsignfoldertypeSendproofezsignsigner", EmitDefaultValue = true)]
        public bool BEzsignfoldertypeSendproofezsignsigner { get; set; }

        /// <summary>
        /// Whether we allow the Ezsigndocument to be downloaded by an Ezsignsigner
        /// </summary>
        /// <value>Whether we allow the Ezsigndocument to be downloaded by an Ezsignsigner</value>
        /* <example>false</example>*/
        [DataMember(Name = "bEzsignfoldertypeAllowdownloadattachmentezsignsigner", EmitDefaultValue = true)]
        public bool BEzsignfoldertypeAllowdownloadattachmentezsignsigner { get; set; }

        /// <summary>
        /// Whether we allow the proof to be downloaded by an Ezsignsigner
        /// </summary>
        /// <value>Whether we allow the proof to be downloaded by an Ezsignsigner</value>
        /* <example>false</example>*/
        [DataMember(Name = "bEzsignfoldertypeAllowdownloadproofezsignsigner", EmitDefaultValue = true)]
        public bool BEzsignfoldertypeAllowdownloadproofezsignsigner { get; set; }

        /// <summary>
        /// Wheter if delegation of signature is allowed to another user or not
        /// </summary>
        /// <value>Wheter if delegation of signature is allowed to another user or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bEzsignfoldertypeDelegate", EmitDefaultValue = true)]
        public bool BEzsignfoldertypeDelegate { get; set; }

        /// <summary>
        /// Wheter if creating a new Discussion is allowed or not
        /// </summary>
        /// <value>Wheter if creating a new Discussion is allowed or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bEzsignfoldertypeDiscussion", EmitDefaultValue = true)]
        public bool BEzsignfoldertypeDiscussion { get; set; }

        /// <summary>
        /// Wheter if Reassignment of signature is allowed by a signatory to another signatory or not
        /// </summary>
        /// <value>Wheter if Reassignment of signature is allowed by a signatory to another signatory or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bEzsignfoldertypeReassignezsignsigner", EmitDefaultValue = true)]
        public bool BEzsignfoldertypeReassignezsignsigner { get; set; }

        /// <summary>
        /// Wheter if Reassignment of signature is allowed by a user to a signatory or another user or not
        /// </summary>
        /// <value>Wheter if Reassignment of signature is allowed by a user to a signatory or another user or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bEzsignfoldertypeReassignuser", EmitDefaultValue = true)]
        public bool BEzsignfoldertypeReassignuser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomEzsignfoldertypeResponse {\n");
            sb.Append("  PkiEzsignfoldertypeID: ").Append(PkiEzsignfoldertypeID).Append("\n");
            sb.Append("  SEzsignfoldertypeNameX: ").Append(SEzsignfoldertypeNameX).Append("\n");
            sb.Append("  BEzsignfoldertypeSendproofezsignsigner: ").Append(BEzsignfoldertypeSendproofezsignsigner).Append("\n");
            sb.Append("  BEzsignfoldertypeAllowdownloadattachmentezsignsigner: ").Append(BEzsignfoldertypeAllowdownloadattachmentezsignsigner).Append("\n");
            sb.Append("  BEzsignfoldertypeAllowdownloadproofezsignsigner: ").Append(BEzsignfoldertypeAllowdownloadproofezsignsigner).Append("\n");
            sb.Append("  BEzsignfoldertypeDelegate: ").Append(BEzsignfoldertypeDelegate).Append("\n");
            sb.Append("  BEzsignfoldertypeDiscussion: ").Append(BEzsignfoldertypeDiscussion).Append("\n");
            sb.Append("  BEzsignfoldertypeReassignezsignsigner: ").Append(BEzsignfoldertypeReassignezsignsigner).Append("\n");
            sb.Append("  BEzsignfoldertypeReassignuser: ").Append(BEzsignfoldertypeReassignuser).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PkiEzsignfoldertypeID (int) maximum
            if (this.PkiEzsignfoldertypeID > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsignfoldertypeID, must be a value less than or equal to 65535.", new [] { "PkiEzsignfoldertypeID" });
            }

            // PkiEzsignfoldertypeID (int) minimum
            if (this.PkiEzsignfoldertypeID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsignfoldertypeID, must be a value greater than or equal to 0.", new [] { "PkiEzsignfoldertypeID" });
            }

            yield break;
        }
    }

}
