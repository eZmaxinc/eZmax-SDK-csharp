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
    /// Request for POST /1/object/cors
    /// </summary>
    [DataContract]
    public partial class CorsCreateObjectV1Request :  IEquatable<CorsCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorsCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CorsCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CorsCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjCors">aObjCors (required).</param>
        public CorsCreateObjectV1Request(List<CorsRequestCompound> aObjCors = default(List<CorsRequestCompound>))
        {
            // to ensure "aObjCors" is required (not null)
            if (aObjCors == null)
            {
                throw new InvalidDataException("aObjCors is a required property for CorsCreateObjectV1Request and cannot be null");
            }
            else
            {
                this.AObjCors = aObjCors;
            }

        }

        /// <summary>
        /// Gets or Sets AObjCors
        /// </summary>
        [DataMember(Name="a_objCors", EmitDefaultValue=true)]
        public List<CorsRequestCompound> AObjCors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorsCreateObjectV1Request {\n");
            sb.Append("  AObjCors: ").Append(AObjCors).Append("\n");
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
            return this.Equals(input as CorsCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if CorsCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of CorsCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorsCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjCors == input.AObjCors ||
                    this.AObjCors != null &&
                    input.AObjCors != null &&
                    this.AObjCors.SequenceEqual(input.AObjCors)
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
                if (this.AObjCors != null)
                    hashCode = hashCode * 59 + this.AObjCors.GetHashCode();
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