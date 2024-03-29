/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.18
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
    /// Request for POST /1/object/ezsignfolder/{pkiEzsignfolderID}/batchDownload
    /// </summary>
    [DataContract]
    public partial class EzsignfolderBatchDownloadV1Request :  IEquatable<EzsignfolderBatchDownloadV1Request>, IValidatableObject
    {
        /// <summary>
        /// Defines AEDocumentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AEDocumentTypeEnum
        {
            /// <summary>
            /// Enum Signed for value: Signed
            /// </summary>
            [EnumMember(Value = "Signed")]
            Signed = 1,

            /// <summary>
            /// Enum Proof for value: Proof
            /// </summary>
            [EnumMember(Value = "Proof")]
            Proof = 2,

            /// <summary>
            /// Enum Proofdocument for value: Proofdocument
            /// </summary>
            [EnumMember(Value = "Proofdocument")]
            Proofdocument = 3

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderBatchDownloadV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderBatchDownloadV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderBatchDownloadV1Request" /> class.
        /// </summary>
        /// <param name="aPkiEzsigndocumentID">aPkiEzsigndocumentID (required).</param>
        /// <param name="aEDocumentType">The type of document to retrieve.  1. **Signed** Is the final document once all signatures were applied. 2. **Proofdocument** Is the evidence report. 3. **Proof** Is the complete evidence archive including all of the above and more. (required).</param>
        public EzsignfolderBatchDownloadV1Request(List<int> aPkiEzsigndocumentID = default(List<int>), List<AEDocumentTypeEnum> aEDocumentType = default(List<AEDocumentTypeEnum>))
        {
            // to ensure "aPkiEzsigndocumentID" is required (not null)
            if (aPkiEzsigndocumentID == null)
            {
                throw new InvalidDataException("aPkiEzsigndocumentID is a required property for EzsignfolderBatchDownloadV1Request and cannot be null");
            }
            else
            {
                this.APkiEzsigndocumentID = aPkiEzsigndocumentID;
            }

            // to ensure "aEDocumentType" is required (not null)
            if (aEDocumentType == null)
            {
                throw new InvalidDataException("aEDocumentType is a required property for EzsignfolderBatchDownloadV1Request and cannot be null");
            }
            else
            {
                this.AEDocumentType = aEDocumentType;
            }

        }

        /// <summary>
        /// Gets or Sets APkiEzsigndocumentID
        /// </summary>
        [DataMember(Name="a_pkiEzsigndocumentID", EmitDefaultValue=true)]
        public List<int> APkiEzsigndocumentID { get; set; }

        /// <summary>
        /// The type of document to retrieve.  1. **Signed** Is the final document once all signatures were applied. 2. **Proofdocument** Is the evidence report. 3. **Proof** Is the complete evidence archive including all of the above and more.
        /// </summary>
        /// <value>The type of document to retrieve.  1. **Signed** Is the final document once all signatures were applied. 2. **Proofdocument** Is the evidence report. 3. **Proof** Is the complete evidence archive including all of the above and more.</value>
        [DataMember(Name="a_eDocumentType", EmitDefaultValue=true)]
        public List<EzsignfolderBatchDownloadV1Request.AEDocumentTypeEnum> AEDocumentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderBatchDownloadV1Request {\n");
            sb.Append("  APkiEzsigndocumentID: ").Append(APkiEzsigndocumentID).Append("\n");
            sb.Append("  AEDocumentType: ").Append(AEDocumentType).Append("\n");
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
            return this.Equals(input as EzsignfolderBatchDownloadV1Request);
        }

        /// <summary>
        /// Returns true if EzsignfolderBatchDownloadV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderBatchDownloadV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderBatchDownloadV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APkiEzsigndocumentID == input.APkiEzsigndocumentID ||
                    this.APkiEzsigndocumentID != null &&
                    input.APkiEzsigndocumentID != null &&
                    this.APkiEzsigndocumentID.SequenceEqual(input.APkiEzsigndocumentID)
                ) && 
                (
                    this.AEDocumentType == input.AEDocumentType ||
                    this.AEDocumentType != null &&
                    input.AEDocumentType != null &&
                    this.AEDocumentType.SequenceEqual(input.AEDocumentType)
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
                if (this.APkiEzsigndocumentID != null)
                    hashCode = hashCode * 59 + this.APkiEzsigndocumentID.GetHashCode();
                if (this.AEDocumentType != null)
                    hashCode = hashCode * 59 + this.AEDocumentType.GetHashCode();
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


            yield break;
        }
    }

}
