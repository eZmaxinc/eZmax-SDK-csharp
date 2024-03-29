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
    /// Request for POST /1/object/ezsigntemplatesigner
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatesignerCreateObjectV1Request :  IEquatable<EzsigntemplatesignerCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignerCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatesignerCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignerCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjEzsigntemplatesigner">aObjEzsigntemplatesigner (required).</param>
        public EzsigntemplatesignerCreateObjectV1Request(List<EzsigntemplatesignerRequestCompound> aObjEzsigntemplatesigner = default(List<EzsigntemplatesignerRequestCompound>))
        {
            // to ensure "aObjEzsigntemplatesigner" is required (not null)
            if (aObjEzsigntemplatesigner == null)
            {
                throw new InvalidDataException("aObjEzsigntemplatesigner is a required property for EzsigntemplatesignerCreateObjectV1Request and cannot be null");
            }
            else
            {
                this.AObjEzsigntemplatesigner = aObjEzsigntemplatesigner;
            }

        }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplatesigner
        /// </summary>
        [DataMember(Name="a_objEzsigntemplatesigner", EmitDefaultValue=true)]
        public List<EzsigntemplatesignerRequestCompound> AObjEzsigntemplatesigner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplatesignerCreateObjectV1Request {\n");
            sb.Append("  AObjEzsigntemplatesigner: ").Append(AObjEzsigntemplatesigner).Append("\n");
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
            return this.Equals(input as EzsigntemplatesignerCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if EzsigntemplatesignerCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatesignerCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatesignerCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjEzsigntemplatesigner == input.AObjEzsigntemplatesigner ||
                    this.AObjEzsigntemplatesigner != null &&
                    input.AObjEzsigntemplatesigner != null &&
                    this.AObjEzsigntemplatesigner.SequenceEqual(input.AObjEzsigntemplatesigner)
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
                if (this.AObjEzsigntemplatesigner != null)
                    hashCode = hashCode * 59 + this.AObjEzsigntemplatesigner.GetHashCode();
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
