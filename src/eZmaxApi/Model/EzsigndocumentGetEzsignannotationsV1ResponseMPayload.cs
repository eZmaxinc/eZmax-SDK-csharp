/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.17
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
    /// Payload for GET /1/object/ezsigndocument/{pkiEzsigndocument}/getEzsignannotations
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentGetEzsignannotationsV1ResponseMPayload :  IEquatable<EzsigndocumentGetEzsignannotationsV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetEzsignannotationsV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentGetEzsignannotationsV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetEzsignannotationsV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsignannotation">aObjEzsignannotation (required).</param>
        public EzsigndocumentGetEzsignannotationsV1ResponseMPayload(List<EzsignannotationResponseCompound> aObjEzsignannotation = default(List<EzsignannotationResponseCompound>))
        {
            // to ensure "aObjEzsignannotation" is required (not null)
            if (aObjEzsignannotation == null)
            {
                throw new InvalidDataException("aObjEzsignannotation is a required property for EzsigndocumentGetEzsignannotationsV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjEzsignannotation = aObjEzsignannotation;
            }

        }

        /// <summary>
        /// Gets or Sets AObjEzsignannotation
        /// </summary>
        [DataMember(Name="a_objEzsignannotation", EmitDefaultValue=true)]
        public List<EzsignannotationResponseCompound> AObjEzsignannotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentGetEzsignannotationsV1ResponseMPayload {\n");
            sb.Append("  AObjEzsignannotation: ").Append(AObjEzsignannotation).Append("\n");
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
            return this.Equals(input as EzsigndocumentGetEzsignannotationsV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigndocumentGetEzsignannotationsV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentGetEzsignannotationsV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentGetEzsignannotationsV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjEzsignannotation == input.AObjEzsignannotation ||
                    this.AObjEzsignannotation != null &&
                    input.AObjEzsignannotation != null &&
                    this.AObjEzsignannotation.SequenceEqual(input.AObjEzsignannotation)
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
                if (this.AObjEzsignannotation != null)
                    hashCode = hashCode * 59 + this.AObjEzsignannotation.GetHashCode();
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