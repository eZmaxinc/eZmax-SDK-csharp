/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.47
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
    /// EzsignsignerRequestCompoundAllOf
    /// </summary>
    [DataContract]
    public partial class EzsignsignerRequestCompoundAllOf :  IEquatable<EzsignsignerRequestCompoundAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignerRequestCompoundAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignerRequestCompoundAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignerRequestCompoundAllOf" /> class.
        /// </summary>
        /// <param name="objContact">objContact (required).</param>
        public EzsignsignerRequestCompoundAllOf(EzsignsignerRequestCompoundContact objContact = default(EzsignsignerRequestCompoundContact))
        {
            // to ensure "objContact" is required (not null)
            if (objContact == null)
            {
                throw new InvalidDataException("objContact is a required property for EzsignsignerRequestCompoundAllOf and cannot be null");
            }
            else
            {
                this.ObjContact = objContact;
            }

        }

        /// <summary>
        /// Gets or Sets ObjContact
        /// </summary>
        [DataMember(Name="objContact", EmitDefaultValue=true)]
        public EzsignsignerRequestCompoundContact ObjContact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignerRequestCompoundAllOf {\n");
            sb.Append("  ObjContact: ").Append(ObjContact).Append("\n");
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
            return this.Equals(input as EzsignsignerRequestCompoundAllOf);
        }

        /// <summary>
        /// Returns true if EzsignsignerRequestCompoundAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignerRequestCompoundAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignerRequestCompoundAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjContact == input.ObjContact ||
                    (this.ObjContact != null &&
                    this.ObjContact.Equals(input.ObjContact))
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
                if (this.ObjContact != null)
                    hashCode = hashCode * 59 + this.ObjContact.GetHashCode();
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