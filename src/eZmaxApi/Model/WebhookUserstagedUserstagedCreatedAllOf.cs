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
    /// WebhookUserstagedUserstagedCreatedAllOf
    /// </summary>
    [DataContract]
    public partial class WebhookUserstagedUserstagedCreatedAllOf :  IEquatable<WebhookUserstagedUserstagedCreatedAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUserstagedUserstagedCreatedAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookUserstagedUserstagedCreatedAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUserstagedUserstagedCreatedAllOf" /> class.
        /// </summary>
        /// <param name="objUserstaged">objUserstaged (required).</param>
        public WebhookUserstagedUserstagedCreatedAllOf(UserstagedResponseCompound objUserstaged = default(UserstagedResponseCompound))
        {
            // to ensure "objUserstaged" is required (not null)
            if (objUserstaged == null)
            {
                throw new InvalidDataException("objUserstaged is a required property for WebhookUserstagedUserstagedCreatedAllOf and cannot be null");
            }
            else
            {
                this.ObjUserstaged = objUserstaged;
            }

        }

        /// <summary>
        /// Gets or Sets ObjUserstaged
        /// </summary>
        [DataMember(Name="objUserstaged", EmitDefaultValue=true)]
        public UserstagedResponseCompound ObjUserstaged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookUserstagedUserstagedCreatedAllOf {\n");
            sb.Append("  ObjUserstaged: ").Append(ObjUserstaged).Append("\n");
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
            return this.Equals(input as WebhookUserstagedUserstagedCreatedAllOf);
        }

        /// <summary>
        /// Returns true if WebhookUserstagedUserstagedCreatedAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookUserstagedUserstagedCreatedAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookUserstagedUserstagedCreatedAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjUserstaged == input.ObjUserstaged ||
                    (this.ObjUserstaged != null &&
                    this.ObjUserstaged.Equals(input.ObjUserstaged))
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
                if (this.ObjUserstaged != null)
                    hashCode = hashCode * 59 + this.ObjUserstaged.GetHashCode();
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