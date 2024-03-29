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
    /// A Billingentityinternal List Element
    /// </summary>
    [DataContract]
    public partial class BillingentityinternalListElement :  IEquatable<BillingentityinternalListElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingentityinternalListElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingentityinternalListElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingentityinternalListElement" /> class.
        /// </summary>
        /// <param name="pkiBillingentityinternalID">The unique ID of the Billingentityinternal. (required).</param>
        /// <param name="sBillingentityinternalDescriptionX">The description of the Billingentityinternal in the language of the requester (required).</param>
        public BillingentityinternalListElement(int pkiBillingentityinternalID = default(int), string sBillingentityinternalDescriptionX = default(string))
        {
            // to ensure "pkiBillingentityinternalID" is required (not null)
            if (pkiBillingentityinternalID == null)
            {
                throw new InvalidDataException("pkiBillingentityinternalID is a required property for BillingentityinternalListElement and cannot be null");
            }
            else
            {
                this.PkiBillingentityinternalID = pkiBillingentityinternalID;
            }

            // to ensure "sBillingentityinternalDescriptionX" is required (not null)
            if (sBillingentityinternalDescriptionX == null)
            {
                throw new InvalidDataException("sBillingentityinternalDescriptionX is a required property for BillingentityinternalListElement and cannot be null");
            }
            else
            {
                this.SBillingentityinternalDescriptionX = sBillingentityinternalDescriptionX;
            }

        }

        /// <summary>
        /// The unique ID of the Billingentityinternal.
        /// </summary>
        /// <value>The unique ID of the Billingentityinternal.</value>
        [DataMember(Name="pkiBillingentityinternalID", EmitDefaultValue=true)]
        public int PkiBillingentityinternalID { get; set; }

        /// <summary>
        /// The description of the Billingentityinternal in the language of the requester
        /// </summary>
        /// <value>The description of the Billingentityinternal in the language of the requester</value>
        [DataMember(Name="sBillingentityinternalDescriptionX", EmitDefaultValue=true)]
        public string SBillingentityinternalDescriptionX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingentityinternalListElement {\n");
            sb.Append("  PkiBillingentityinternalID: ").Append(PkiBillingentityinternalID).Append("\n");
            sb.Append("  SBillingentityinternalDescriptionX: ").Append(SBillingentityinternalDescriptionX).Append("\n");
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
            return this.Equals(input as BillingentityinternalListElement);
        }

        /// <summary>
        /// Returns true if BillingentityinternalListElement instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingentityinternalListElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingentityinternalListElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiBillingentityinternalID == input.PkiBillingentityinternalID ||
                    (this.PkiBillingentityinternalID != null &&
                    this.PkiBillingentityinternalID.Equals(input.PkiBillingentityinternalID))
                ) && 
                (
                    this.SBillingentityinternalDescriptionX == input.SBillingentityinternalDescriptionX ||
                    (this.SBillingentityinternalDescriptionX != null &&
                    this.SBillingentityinternalDescriptionX.Equals(input.SBillingentityinternalDescriptionX))
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
                if (this.PkiBillingentityinternalID != null)
                    hashCode = hashCode * 59 + this.PkiBillingentityinternalID.GetHashCode();
                if (this.SBillingentityinternalDescriptionX != null)
                    hashCode = hashCode * 59 + this.SBillingentityinternalDescriptionX.GetHashCode();
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


            // PkiBillingentityinternalID (int) minimum
            if(this.PkiBillingentityinternalID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiBillingentityinternalID, must be a value greater than or equal to 0.", new [] { "PkiBillingentityinternalID" });
            }

            yield break;
        }
    }

}
