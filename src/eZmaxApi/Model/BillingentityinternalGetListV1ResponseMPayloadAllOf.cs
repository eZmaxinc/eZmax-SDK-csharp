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
    /// BillingentityinternalGetListV1ResponseMPayloadAllOf
    /// </summary>
    [DataContract]
    public partial class BillingentityinternalGetListV1ResponseMPayloadAllOf :  IEquatable<BillingentityinternalGetListV1ResponseMPayloadAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingentityinternalGetListV1ResponseMPayloadAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingentityinternalGetListV1ResponseMPayloadAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingentityinternalGetListV1ResponseMPayloadAllOf" /> class.
        /// </summary>
        /// <param name="aObjBillingentityinternal">aObjBillingentityinternal (required).</param>
        public BillingentityinternalGetListV1ResponseMPayloadAllOf(List<BillingentityinternalListElement> aObjBillingentityinternal = default(List<BillingentityinternalListElement>))
        {
            // to ensure "aObjBillingentityinternal" is required (not null)
            if (aObjBillingentityinternal == null)
            {
                throw new InvalidDataException("aObjBillingentityinternal is a required property for BillingentityinternalGetListV1ResponseMPayloadAllOf and cannot be null");
            }
            else
            {
                this.AObjBillingentityinternal = aObjBillingentityinternal;
            }

        }

        /// <summary>
        /// Gets or Sets AObjBillingentityinternal
        /// </summary>
        [DataMember(Name="a_objBillingentityinternal", EmitDefaultValue=true)]
        public List<BillingentityinternalListElement> AObjBillingentityinternal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingentityinternalGetListV1ResponseMPayloadAllOf {\n");
            sb.Append("  AObjBillingentityinternal: ").Append(AObjBillingentityinternal).Append("\n");
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
            return this.Equals(input as BillingentityinternalGetListV1ResponseMPayloadAllOf);
        }

        /// <summary>
        /// Returns true if BillingentityinternalGetListV1ResponseMPayloadAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingentityinternalGetListV1ResponseMPayloadAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingentityinternalGetListV1ResponseMPayloadAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjBillingentityinternal == input.AObjBillingentityinternal ||
                    this.AObjBillingentityinternal != null &&
                    input.AObjBillingentityinternal != null &&
                    this.AObjBillingentityinternal.SequenceEqual(input.AObjBillingentityinternal)
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
                if (this.AObjBillingentityinternal != null)
                    hashCode = hashCode * 59 + this.AObjBillingentityinternal.GetHashCode();
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