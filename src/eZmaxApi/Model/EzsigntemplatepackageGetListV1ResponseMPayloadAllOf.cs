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
    /// EzsigntemplatepackageGetListV1ResponseMPayloadAllOf
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatepackageGetListV1ResponseMPayloadAllOf :  IEquatable<EzsigntemplatepackageGetListV1ResponseMPayloadAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackageGetListV1ResponseMPayloadAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatepackageGetListV1ResponseMPayloadAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackageGetListV1ResponseMPayloadAllOf" /> class.
        /// </summary>
        /// <param name="aObjEzsigntemplatepackage">aObjEzsigntemplatepackage (required).</param>
        public EzsigntemplatepackageGetListV1ResponseMPayloadAllOf(List<EzsigntemplatepackageListElement> aObjEzsigntemplatepackage = default(List<EzsigntemplatepackageListElement>))
        {
            // to ensure "aObjEzsigntemplatepackage" is required (not null)
            if (aObjEzsigntemplatepackage == null)
            {
                throw new InvalidDataException("aObjEzsigntemplatepackage is a required property for EzsigntemplatepackageGetListV1ResponseMPayloadAllOf and cannot be null");
            }
            else
            {
                this.AObjEzsigntemplatepackage = aObjEzsigntemplatepackage;
            }

        }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplatepackage
        /// </summary>
        [DataMember(Name="a_objEzsigntemplatepackage", EmitDefaultValue=true)]
        public List<EzsigntemplatepackageListElement> AObjEzsigntemplatepackage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplatepackageGetListV1ResponseMPayloadAllOf {\n");
            sb.Append("  AObjEzsigntemplatepackage: ").Append(AObjEzsigntemplatepackage).Append("\n");
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
            return this.Equals(input as EzsigntemplatepackageGetListV1ResponseMPayloadAllOf);
        }

        /// <summary>
        /// Returns true if EzsigntemplatepackageGetListV1ResponseMPayloadAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatepackageGetListV1ResponseMPayloadAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatepackageGetListV1ResponseMPayloadAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjEzsigntemplatepackage == input.AObjEzsigntemplatepackage ||
                    this.AObjEzsigntemplatepackage != null &&
                    input.AObjEzsigntemplatepackage != null &&
                    this.AObjEzsigntemplatepackage.SequenceEqual(input.AObjEzsigntemplatepackage)
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
                if (this.AObjEzsigntemplatepackage != null)
                    hashCode = hashCode * 59 + this.AObjEzsigntemplatepackage.GetHashCode();
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
