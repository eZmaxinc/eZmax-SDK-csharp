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
    /// Payload for GET /2/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID}
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatesignatureGetObjectV2ResponseMPayload :  IEquatable<EzsigntemplatesignatureGetObjectV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatesignatureGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objEzsigntemplatesignature">objEzsigntemplatesignature (required).</param>
        public EzsigntemplatesignatureGetObjectV2ResponseMPayload(EzsigntemplatesignatureResponseCompound objEzsigntemplatesignature = default(EzsigntemplatesignatureResponseCompound))
        {
            // to ensure "objEzsigntemplatesignature" is required (not null)
            if (objEzsigntemplatesignature == null)
            {
                throw new InvalidDataException("objEzsigntemplatesignature is a required property for EzsigntemplatesignatureGetObjectV2ResponseMPayload and cannot be null");
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
        public EzsigntemplatesignatureResponseCompound ObjEzsigntemplatesignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplatesignatureGetObjectV2ResponseMPayload {\n");
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
            return this.Equals(input as EzsigntemplatesignatureGetObjectV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigntemplatesignatureGetObjectV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatesignatureGetObjectV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatesignatureGetObjectV2ResponseMPayload input)
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