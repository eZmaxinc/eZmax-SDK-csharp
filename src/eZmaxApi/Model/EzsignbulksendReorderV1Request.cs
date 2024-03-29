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
    /// Request for POST /1/object/ezsignbulksend/{pkiEzsignbulksendID}/reorder
    /// </summary>
    [DataContract]
    public partial class EzsignbulksendReorderV1Request :  IEquatable<EzsignbulksendReorderV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendReorderV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignbulksendReorderV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendReorderV1Request" /> class.
        /// </summary>
        /// <param name="aPkiEzsignbulksenddocumentmappingID">aPkiEzsignbulksenddocumentmappingID (required).</param>
        public EzsignbulksendReorderV1Request(List<int> aPkiEzsignbulksenddocumentmappingID = default(List<int>))
        {
            // to ensure "aPkiEzsignbulksenddocumentmappingID" is required (not null)
            if (aPkiEzsignbulksenddocumentmappingID == null)
            {
                throw new InvalidDataException("aPkiEzsignbulksenddocumentmappingID is a required property for EzsignbulksendReorderV1Request and cannot be null");
            }
            else
            {
                this.APkiEzsignbulksenddocumentmappingID = aPkiEzsignbulksenddocumentmappingID;
            }

        }

        /// <summary>
        /// Gets or Sets APkiEzsignbulksenddocumentmappingID
        /// </summary>
        [DataMember(Name="a_pkiEzsignbulksenddocumentmappingID", EmitDefaultValue=true)]
        public List<int> APkiEzsignbulksenddocumentmappingID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignbulksendReorderV1Request {\n");
            sb.Append("  APkiEzsignbulksenddocumentmappingID: ").Append(APkiEzsignbulksenddocumentmappingID).Append("\n");
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
            return this.Equals(input as EzsignbulksendReorderV1Request);
        }

        /// <summary>
        /// Returns true if EzsignbulksendReorderV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignbulksendReorderV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignbulksendReorderV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APkiEzsignbulksenddocumentmappingID == input.APkiEzsignbulksenddocumentmappingID ||
                    this.APkiEzsignbulksenddocumentmappingID != null &&
                    input.APkiEzsignbulksenddocumentmappingID != null &&
                    this.APkiEzsignbulksenddocumentmappingID.SequenceEqual(input.APkiEzsignbulksenddocumentmappingID)
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
                if (this.APkiEzsignbulksenddocumentmappingID != null)
                    hashCode = hashCode * 59 + this.APkiEzsignbulksenddocumentmappingID.GetHashCode();
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
