/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// EzsignformfieldgroupResponseCompoundAllOf
    /// </summary>
    [DataContract]
    public partial class EzsignformfieldgroupResponseCompoundAllOf :  IEquatable<EzsignformfieldgroupResponseCompoundAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignformfieldgroupResponseCompoundAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignformfieldgroupResponseCompoundAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignformfieldgroupResponseCompoundAllOf" /> class.
        /// </summary>
        /// <param name="aObjEzsignformfield">aObjEzsignformfield (required).</param>
        public EzsignformfieldgroupResponseCompoundAllOf(List<EzsignformfieldResponse> aObjEzsignformfield = default(List<EzsignformfieldResponse>))
        {
            // to ensure "aObjEzsignformfield" is required (not null)
            if (aObjEzsignformfield == null)
            {
                throw new InvalidDataException("aObjEzsignformfield is a required property for EzsignformfieldgroupResponseCompoundAllOf and cannot be null");
            }
            else
            {
                this.AObjEzsignformfield = aObjEzsignformfield;
            }

        }

        /// <summary>
        /// Gets or Sets AObjEzsignformfield
        /// </summary>
        [DataMember(Name="a_objEzsignformfield", EmitDefaultValue=true)]
        public List<EzsignformfieldResponse> AObjEzsignformfield { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignformfieldgroupResponseCompoundAllOf {\n");
            sb.Append("  AObjEzsignformfield: ").Append(AObjEzsignformfield).Append("\n");
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
            return this.Equals(input as EzsignformfieldgroupResponseCompoundAllOf);
        }

        /// <summary>
        /// Returns true if EzsignformfieldgroupResponseCompoundAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignformfieldgroupResponseCompoundAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignformfieldgroupResponseCompoundAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjEzsignformfield == input.AObjEzsignformfield ||
                    this.AObjEzsignformfield != null &&
                    input.AObjEzsignformfield != null &&
                    this.AObjEzsignformfield.SequenceEqual(input.AObjEzsignformfield)
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
                if (this.AObjEzsignformfield != null)
                    hashCode = hashCode * 59 + this.AObjEzsignformfield.GetHashCode();
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