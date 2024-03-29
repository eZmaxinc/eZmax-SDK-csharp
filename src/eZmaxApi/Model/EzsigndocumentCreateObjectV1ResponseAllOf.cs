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
    /// EzsigndocumentCreateObjectV1ResponseAllOf
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentCreateObjectV1ResponseAllOf :  IEquatable<EzsigndocumentCreateObjectV1ResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentCreateObjectV1ResponseAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentCreateObjectV1ResponseAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentCreateObjectV1ResponseAllOf" /> class.
        /// </summary>
        /// <param name="mPayload">mPayload (required).</param>
        public EzsigndocumentCreateObjectV1ResponseAllOf(EzsigndocumentCreateObjectV1ResponseMPayload mPayload = default(EzsigndocumentCreateObjectV1ResponseMPayload))
        {
            // to ensure "mPayload" is required (not null)
            if (mPayload == null)
            {
                throw new InvalidDataException("mPayload is a required property for EzsigndocumentCreateObjectV1ResponseAllOf and cannot be null");
            }
            else
            {
                this.MPayload = mPayload;
            }

        }

        /// <summary>
        /// Gets or Sets MPayload
        /// </summary>
        [DataMember(Name="mPayload", EmitDefaultValue=true)]
        public EzsigndocumentCreateObjectV1ResponseMPayload MPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentCreateObjectV1ResponseAllOf {\n");
            sb.Append("  MPayload: ").Append(MPayload).Append("\n");
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
            return this.Equals(input as EzsigndocumentCreateObjectV1ResponseAllOf);
        }

        /// <summary>
        /// Returns true if EzsigndocumentCreateObjectV1ResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentCreateObjectV1ResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentCreateObjectV1ResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MPayload == input.MPayload ||
                    (this.MPayload != null &&
                    this.MPayload.Equals(input.MPayload))
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
                if (this.MPayload != null)
                    hashCode = hashCode * 59 + this.MPayload.GetHashCode();
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
