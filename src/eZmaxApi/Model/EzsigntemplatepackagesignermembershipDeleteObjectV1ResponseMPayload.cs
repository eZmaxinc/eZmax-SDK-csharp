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
    /// Payload for DELETE /1/object/ezsigntemplatepackagesignermembership/{pkiEzsigntemplatepackagesignermembershipID}
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload :  IEquatable<EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="bEzsigntemplatepackageNeedvalidation">Whether the Ezsignbulksend was automatically modified and needs a manual validation (required).</param>
        /// <param name="bEzsignbulksendNeedvalidation">Whether the Ezsigntemplatepackage was automatically modified and needs a manual validation (required).</param>
        public EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload(bool bEzsigntemplatepackageNeedvalidation = default(bool), bool bEzsignbulksendNeedvalidation = default(bool))
        {
            // to ensure "bEzsigntemplatepackageNeedvalidation" is required (not null)
            if (bEzsigntemplatepackageNeedvalidation == null)
            {
                throw new InvalidDataException("bEzsigntemplatepackageNeedvalidation is a required property for EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.BEzsigntemplatepackageNeedvalidation = bEzsigntemplatepackageNeedvalidation;
            }

            // to ensure "bEzsignbulksendNeedvalidation" is required (not null)
            if (bEzsignbulksendNeedvalidation == null)
            {
                throw new InvalidDataException("bEzsignbulksendNeedvalidation is a required property for EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.BEzsignbulksendNeedvalidation = bEzsignbulksendNeedvalidation;
            }

        }

        /// <summary>
        /// Whether the Ezsignbulksend was automatically modified and needs a manual validation
        /// </summary>
        /// <value>Whether the Ezsignbulksend was automatically modified and needs a manual validation</value>
        [DataMember(Name="bEzsigntemplatepackageNeedvalidation", EmitDefaultValue=true)]
        public bool BEzsigntemplatepackageNeedvalidation { get; set; }

        /// <summary>
        /// Whether the Ezsigntemplatepackage was automatically modified and needs a manual validation
        /// </summary>
        /// <value>Whether the Ezsigntemplatepackage was automatically modified and needs a manual validation</value>
        [DataMember(Name="bEzsignbulksendNeedvalidation", EmitDefaultValue=true)]
        public bool BEzsignbulksendNeedvalidation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload {\n");
            sb.Append("  BEzsigntemplatepackageNeedvalidation: ").Append(BEzsigntemplatepackageNeedvalidation).Append("\n");
            sb.Append("  BEzsignbulksendNeedvalidation: ").Append(BEzsignbulksendNeedvalidation).Append("\n");
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
            return this.Equals(input as EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatepackagesignermembershipDeleteObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BEzsigntemplatepackageNeedvalidation == input.BEzsigntemplatepackageNeedvalidation ||
                    (this.BEzsigntemplatepackageNeedvalidation != null &&
                    this.BEzsigntemplatepackageNeedvalidation.Equals(input.BEzsigntemplatepackageNeedvalidation))
                ) && 
                (
                    this.BEzsignbulksendNeedvalidation == input.BEzsignbulksendNeedvalidation ||
                    (this.BEzsignbulksendNeedvalidation != null &&
                    this.BEzsignbulksendNeedvalidation.Equals(input.BEzsignbulksendNeedvalidation))
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
                if (this.BEzsigntemplatepackageNeedvalidation != null)
                    hashCode = hashCode * 59 + this.BEzsigntemplatepackageNeedvalidation.GetHashCode();
                if (this.BEzsignbulksendNeedvalidation != null)
                    hashCode = hashCode * 59 + this.BEzsignbulksendNeedvalidation.GetHashCode();
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