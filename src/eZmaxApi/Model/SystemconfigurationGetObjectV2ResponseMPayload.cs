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
    /// Payload for GET /2/object/systemconfiguration/{pkiSystemconfigurationID}
    /// </summary>
    [DataContract]
    public partial class SystemconfigurationGetObjectV2ResponseMPayload :  IEquatable<SystemconfigurationGetObjectV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemconfigurationGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemconfigurationGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemconfigurationGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objSystemconfiguration">objSystemconfiguration (required).</param>
        public SystemconfigurationGetObjectV2ResponseMPayload(SystemconfigurationResponseCompound objSystemconfiguration = default(SystemconfigurationResponseCompound))
        {
            // to ensure "objSystemconfiguration" is required (not null)
            if (objSystemconfiguration == null)
            {
                throw new InvalidDataException("objSystemconfiguration is a required property for SystemconfigurationGetObjectV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjSystemconfiguration = objSystemconfiguration;
            }

        }

        /// <summary>
        /// Gets or Sets ObjSystemconfiguration
        /// </summary>
        [DataMember(Name="objSystemconfiguration", EmitDefaultValue=true)]
        public SystemconfigurationResponseCompound ObjSystemconfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemconfigurationGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjSystemconfiguration: ").Append(ObjSystemconfiguration).Append("\n");
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
            return this.Equals(input as SystemconfigurationGetObjectV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if SystemconfigurationGetObjectV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemconfigurationGetObjectV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemconfigurationGetObjectV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjSystemconfiguration == input.ObjSystemconfiguration ||
                    (this.ObjSystemconfiguration != null &&
                    this.ObjSystemconfiguration.Equals(input.ObjSystemconfiguration))
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
                if (this.ObjSystemconfiguration != null)
                    hashCode = hashCode * 59 + this.ObjSystemconfiguration.GetHashCode();
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