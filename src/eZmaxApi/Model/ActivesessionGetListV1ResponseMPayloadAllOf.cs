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
    /// ActivesessionGetListV1ResponseMPayloadAllOf
    /// </summary>
    [DataContract]
    public partial class ActivesessionGetListV1ResponseMPayloadAllOf :  IEquatable<ActivesessionGetListV1ResponseMPayloadAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivesessionGetListV1ResponseMPayloadAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivesessionGetListV1ResponseMPayloadAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivesessionGetListV1ResponseMPayloadAllOf" /> class.
        /// </summary>
        /// <param name="aObjActivesession">aObjActivesession (required).</param>
        public ActivesessionGetListV1ResponseMPayloadAllOf(List<ActivesessionListElement> aObjActivesession = default(List<ActivesessionListElement>))
        {
            // to ensure "aObjActivesession" is required (not null)
            if (aObjActivesession == null)
            {
                throw new InvalidDataException("aObjActivesession is a required property for ActivesessionGetListV1ResponseMPayloadAllOf and cannot be null");
            }
            else
            {
                this.AObjActivesession = aObjActivesession;
            }

        }

        /// <summary>
        /// Gets or Sets AObjActivesession
        /// </summary>
        [DataMember(Name="a_objActivesession", EmitDefaultValue=true)]
        public List<ActivesessionListElement> AObjActivesession { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivesessionGetListV1ResponseMPayloadAllOf {\n");
            sb.Append("  AObjActivesession: ").Append(AObjActivesession).Append("\n");
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
            return this.Equals(input as ActivesessionGetListV1ResponseMPayloadAllOf);
        }

        /// <summary>
        /// Returns true if ActivesessionGetListV1ResponseMPayloadAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivesessionGetListV1ResponseMPayloadAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivesessionGetListV1ResponseMPayloadAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjActivesession == input.AObjActivesession ||
                    this.AObjActivesession != null &&
                    input.AObjActivesession != null &&
                    this.AObjActivesession.SequenceEqual(input.AObjActivesession)
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
                if (this.AObjActivesession != null)
                    hashCode = hashCode * 59 + this.AObjActivesession.GetHashCode();
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