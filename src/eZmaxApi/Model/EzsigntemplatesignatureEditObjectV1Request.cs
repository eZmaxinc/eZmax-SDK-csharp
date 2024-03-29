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
    /// Request for PUT /1/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID}
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatesignatureEditObjectV1Request :  IEquatable<EzsigntemplatesignatureEditObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatesignatureEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsigntemplatesignature">objEzsigntemplatesignature (required).</param>
        public EzsigntemplatesignatureEditObjectV1Request(EzsigntemplatesignatureRequestCompound objEzsigntemplatesignature = default(EzsigntemplatesignatureRequestCompound))
        {
            // to ensure "objEzsigntemplatesignature" is required (not null)
            if (objEzsigntemplatesignature == null)
            {
                throw new InvalidDataException("objEzsigntemplatesignature is a required property for EzsigntemplatesignatureEditObjectV1Request and cannot be null");
            }
            else
            {
                this.ObjEzsigntemplatesignature = objEzsigntemplatesignature;
            }

        }

        /// <summary>
        /// Gets or Sets ObjEzsigntemplatesignature
        /// </summary>
        [DataMember(Name="objEzsigntemplatesignature", EmitDefaultValue=true)]
        public EzsigntemplatesignatureRequestCompound ObjEzsigntemplatesignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplatesignatureEditObjectV1Request {\n");
            sb.Append("  ObjEzsigntemplatesignature: ").Append(ObjEzsigntemplatesignature).Append("\n");
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
            return this.Equals(input as EzsigntemplatesignatureEditObjectV1Request);
        }

        /// <summary>
        /// Returns true if EzsigntemplatesignatureEditObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatesignatureEditObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatesignatureEditObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsigntemplatesignature == input.ObjEzsigntemplatesignature ||
                    (this.ObjEzsigntemplatesignature != null &&
                    this.ObjEzsigntemplatesignature.Equals(input.ObjEzsigntemplatesignature))
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
                if (this.ObjEzsigntemplatesignature != null)
                    hashCode = hashCode * 59 + this.ObjEzsigntemplatesignature.GetHashCode();
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
