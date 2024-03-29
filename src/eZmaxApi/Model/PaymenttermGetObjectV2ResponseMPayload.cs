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
    /// Payload for GET /2/object/paymentterm/{pkiPaymenttermID}
    /// </summary>
    [DataContract]
    public partial class PaymenttermGetObjectV2ResponseMPayload :  IEquatable<PaymenttermGetObjectV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymenttermGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymenttermGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymenttermGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objPaymentterm">objPaymentterm (required).</param>
        public PaymenttermGetObjectV2ResponseMPayload(PaymenttermResponseCompound objPaymentterm = default(PaymenttermResponseCompound))
        {
            // to ensure "objPaymentterm" is required (not null)
            if (objPaymentterm == null)
            {
                throw new InvalidDataException("objPaymentterm is a required property for PaymenttermGetObjectV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjPaymentterm = objPaymentterm;
            }

        }

        /// <summary>
        /// Gets or Sets ObjPaymentterm
        /// </summary>
        [DataMember(Name="objPaymentterm", EmitDefaultValue=true)]
        public PaymenttermResponseCompound ObjPaymentterm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymenttermGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjPaymentterm: ").Append(ObjPaymentterm).Append("\n");
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
            return this.Equals(input as PaymenttermGetObjectV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if PaymenttermGetObjectV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymenttermGetObjectV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymenttermGetObjectV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjPaymentterm == input.ObjPaymentterm ||
                    (this.ObjPaymentterm != null &&
                    this.ObjPaymentterm.Equals(input.ObjPaymentterm))
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
                if (this.ObjPaymentterm != null)
                    hashCode = hashCode * 59 + this.ObjPaymentterm.GetHashCode();
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
