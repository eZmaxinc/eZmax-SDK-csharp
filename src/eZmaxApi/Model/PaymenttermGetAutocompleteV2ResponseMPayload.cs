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
    /// Payload for POST /2/object/paymentterm/getAutocomplete
    /// </summary>
    [DataContract]
    public partial class PaymenttermGetAutocompleteV2ResponseMPayload :  IEquatable<PaymenttermGetAutocompleteV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymenttermGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjPaymentterm">An array of Paymentterm autocomplete element response..</param>
        public PaymenttermGetAutocompleteV2ResponseMPayload(List<PaymenttermAutocompleteElementResponse> aObjPaymentterm = default(List<PaymenttermAutocompleteElementResponse>))
        {
            this.AObjPaymentterm = aObjPaymentterm;
        }

        /// <summary>
        /// An array of Paymentterm autocomplete element response.
        /// </summary>
        /// <value>An array of Paymentterm autocomplete element response.</value>
        [DataMember(Name="a_objPaymentterm", EmitDefaultValue=false)]
        public List<PaymenttermAutocompleteElementResponse> AObjPaymentterm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymenttermGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjPaymentterm: ").Append(AObjPaymentterm).Append("\n");
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
            return this.Equals(input as PaymenttermGetAutocompleteV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if PaymenttermGetAutocompleteV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymenttermGetAutocompleteV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymenttermGetAutocompleteV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjPaymentterm == input.AObjPaymentterm ||
                    this.AObjPaymentterm != null &&
                    input.AObjPaymentterm != null &&
                    this.AObjPaymentterm.SequenceEqual(input.AObjPaymentterm)
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
                if (this.AObjPaymentterm != null)
                    hashCode = hashCode * 59 + this.AObjPaymentterm.GetHashCode();
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