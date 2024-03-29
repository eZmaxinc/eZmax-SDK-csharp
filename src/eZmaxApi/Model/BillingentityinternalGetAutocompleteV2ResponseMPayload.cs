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
    /// Payload for POST /2/object/billingentityinternal/getAutocomplete
    /// </summary>
    [DataContract]
    public partial class BillingentityinternalGetAutocompleteV2ResponseMPayload :  IEquatable<BillingentityinternalGetAutocompleteV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingentityinternalGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingentityinternalGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingentityinternalGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjBillingentityinternal">An array of Billingentityinternal object containing the description, ID and active status about the element. (required).</param>
        public BillingentityinternalGetAutocompleteV2ResponseMPayload(List<BillingentityinternalAutocompleteElementResponse> aObjBillingentityinternal = default(List<BillingentityinternalAutocompleteElementResponse>))
        {
            // to ensure "aObjBillingentityinternal" is required (not null)
            if (aObjBillingentityinternal == null)
            {
                throw new InvalidDataException("aObjBillingentityinternal is a required property for BillingentityinternalGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjBillingentityinternal = aObjBillingentityinternal;
            }

        }

        /// <summary>
        /// An array of Billingentityinternal object containing the description, ID and active status about the element.
        /// </summary>
        /// <value>An array of Billingentityinternal object containing the description, ID and active status about the element.</value>
        [DataMember(Name="a_objBillingentityinternal", EmitDefaultValue=true)]
        public List<BillingentityinternalAutocompleteElementResponse> AObjBillingentityinternal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingentityinternalGetAutocompleteV2ResponseMPayload {\n");
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
            return this.Equals(input as BillingentityinternalGetAutocompleteV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if BillingentityinternalGetAutocompleteV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingentityinternalGetAutocompleteV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingentityinternalGetAutocompleteV2ResponseMPayload input)
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
