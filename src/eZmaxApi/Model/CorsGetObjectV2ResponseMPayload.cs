/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// Payload for GET /2/object/cors/{pkiCorsID}
    /// </summary>
    [DataContract]
    public partial class CorsGetObjectV2ResponseMPayload :  IEquatable<CorsGetObjectV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorsGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CorsGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CorsGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objCors">objCors (required).</param>
        public CorsGetObjectV2ResponseMPayload(CorsResponseCompound objCors = default(CorsResponseCompound))
        {
            // to ensure "objCors" is required (not null)
            if (objCors == null)
            {
                throw new InvalidDataException("objCors is a required property for CorsGetObjectV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjCors = objCors;
            }

        }

        /// <summary>
        /// Gets or Sets ObjCors
        /// </summary>
        [DataMember(Name="objCors", EmitDefaultValue=true)]
        public CorsResponseCompound ObjCors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorsGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjCors: ").Append(ObjCors).Append("\n");
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
            return this.Equals(input as CorsGetObjectV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if CorsGetObjectV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of CorsGetObjectV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorsGetObjectV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjCors == input.ObjCors ||
                    (this.ObjCors != null &&
                    this.ObjCors.Equals(input.ObjCors))
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
                if (this.ObjCors != null)
                    hashCode = hashCode * 59 + this.ObjCors.GetHashCode();
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