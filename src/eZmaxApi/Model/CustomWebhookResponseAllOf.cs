/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
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
    /// CustomWebhookResponseAllOf
    /// </summary>
    [DataContract]
    public partial class CustomWebhookResponseAllOf :  IEquatable<CustomWebhookResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomWebhookResponseAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomWebhookResponseAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomWebhookResponseAllOf" /> class.
        /// </summary>
        /// <param name="pksCustomerCode">The customer code assigned to your account (required).</param>
        /// <param name="bWebhookTest">Wheter the webhook received is a manual test or a real event (required).</param>
        public CustomWebhookResponseAllOf(string pksCustomerCode = default(string), bool bWebhookTest = default(bool))
        {
            // to ensure "pksCustomerCode" is required (not null)
            if (pksCustomerCode == null)
            {
                throw new InvalidDataException("pksCustomerCode is a required property for CustomWebhookResponseAllOf and cannot be null");
            }
            else
            {
                this.PksCustomerCode = pksCustomerCode;
            }

            // to ensure "bWebhookTest" is required (not null)
            if (bWebhookTest == null)
            {
                throw new InvalidDataException("bWebhookTest is a required property for CustomWebhookResponseAllOf and cannot be null");
            }
            else
            {
                this.BWebhookTest = bWebhookTest;
            }

        }

        /// <summary>
        /// The customer code assigned to your account
        /// </summary>
        /// <value>The customer code assigned to your account</value>
        [DataMember(Name="pksCustomerCode", EmitDefaultValue=true)]
        public string PksCustomerCode { get; set; }

        /// <summary>
        /// Wheter the webhook received is a manual test or a real event
        /// </summary>
        /// <value>Wheter the webhook received is a manual test or a real event</value>
        [DataMember(Name="bWebhookTest", EmitDefaultValue=true)]
        public bool BWebhookTest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomWebhookResponseAllOf {\n");
            sb.Append("  PksCustomerCode: ").Append(PksCustomerCode).Append("\n");
            sb.Append("  BWebhookTest: ").Append(BWebhookTest).Append("\n");
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
            return this.Equals(input as CustomWebhookResponseAllOf);
        }

        /// <summary>
        /// Returns true if CustomWebhookResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomWebhookResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomWebhookResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PksCustomerCode == input.PksCustomerCode ||
                    (this.PksCustomerCode != null &&
                    this.PksCustomerCode.Equals(input.PksCustomerCode))
                ) && 
                (
                    this.BWebhookTest == input.BWebhookTest ||
                    (this.BWebhookTest != null &&
                    this.BWebhookTest.Equals(input.BWebhookTest))
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
                if (this.PksCustomerCode != null)
                    hashCode = hashCode * 59 + this.PksCustomerCode.GetHashCode();
                if (this.BWebhookTest != null)
                    hashCode = hashCode * 59 + this.BWebhookTest.GetHashCode();
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
            // PksCustomerCode (string) maxLength
            if(this.PksCustomerCode != null && this.PksCustomerCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PksCustomerCode, length must be less than 6.", new [] { "PksCustomerCode" });
            }

            // PksCustomerCode (string) minLength
            if(this.PksCustomerCode != null && this.PksCustomerCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PksCustomerCode, length must be greater than 2.", new [] { "PksCustomerCode" });
            }

            yield break;
        }
    }

}