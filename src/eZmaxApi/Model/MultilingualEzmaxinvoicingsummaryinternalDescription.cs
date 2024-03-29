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
    /// Description of the Ezmaxinvoicingsummaryinternal
    /// </summary>
    [DataContract]
    public partial class MultilingualEzmaxinvoicingsummaryinternalDescription :  IEquatable<MultilingualEzmaxinvoicingsummaryinternalDescription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualEzmaxinvoicingsummaryinternalDescription" /> class.
        /// </summary>
        /// <param name="sEzmaxinvoicingsummaryinternalDescription1">The Ezmaxinvoicingsummaryinternal description in French.</param>
        /// <param name="sEzmaxinvoicingsummaryinternalDescription2">The Ezmaxinvoicingsummaryinternal description in English.</param>
        public MultilingualEzmaxinvoicingsummaryinternalDescription(string sEzmaxinvoicingsummaryinternalDescription1 = default(string), string sEzmaxinvoicingsummaryinternalDescription2 = default(string))
        {
            this.SEzmaxinvoicingsummaryinternalDescription1 = sEzmaxinvoicingsummaryinternalDescription1;
            this.SEzmaxinvoicingsummaryinternalDescription2 = sEzmaxinvoicingsummaryinternalDescription2;
        }

        /// <summary>
        /// The Ezmaxinvoicingsummaryinternal description in French
        /// </summary>
        /// <value>The Ezmaxinvoicingsummaryinternal description in French</value>
        [DataMember(Name="sEzmaxinvoicingsummaryinternalDescription1", EmitDefaultValue=false)]
        public string SEzmaxinvoicingsummaryinternalDescription1 { get; set; }

        /// <summary>
        /// The Ezmaxinvoicingsummaryinternal description in English
        /// </summary>
        /// <value>The Ezmaxinvoicingsummaryinternal description in English</value>
        [DataMember(Name="sEzmaxinvoicingsummaryinternalDescription2", EmitDefaultValue=false)]
        public string SEzmaxinvoicingsummaryinternalDescription2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultilingualEzmaxinvoicingsummaryinternalDescription {\n");
            sb.Append("  SEzmaxinvoicingsummaryinternalDescription1: ").Append(SEzmaxinvoicingsummaryinternalDescription1).Append("\n");
            sb.Append("  SEzmaxinvoicingsummaryinternalDescription2: ").Append(SEzmaxinvoicingsummaryinternalDescription2).Append("\n");
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
            return this.Equals(input as MultilingualEzmaxinvoicingsummaryinternalDescription);
        }

        /// <summary>
        /// Returns true if MultilingualEzmaxinvoicingsummaryinternalDescription instances are equal
        /// </summary>
        /// <param name="input">Instance of MultilingualEzmaxinvoicingsummaryinternalDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultilingualEzmaxinvoicingsummaryinternalDescription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SEzmaxinvoicingsummaryinternalDescription1 == input.SEzmaxinvoicingsummaryinternalDescription1 ||
                    (this.SEzmaxinvoicingsummaryinternalDescription1 != null &&
                    this.SEzmaxinvoicingsummaryinternalDescription1.Equals(input.SEzmaxinvoicingsummaryinternalDescription1))
                ) && 
                (
                    this.SEzmaxinvoicingsummaryinternalDescription2 == input.SEzmaxinvoicingsummaryinternalDescription2 ||
                    (this.SEzmaxinvoicingsummaryinternalDescription2 != null &&
                    this.SEzmaxinvoicingsummaryinternalDescription2.Equals(input.SEzmaxinvoicingsummaryinternalDescription2))
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
                if (this.SEzmaxinvoicingsummaryinternalDescription1 != null)
                    hashCode = hashCode * 59 + this.SEzmaxinvoicingsummaryinternalDescription1.GetHashCode();
                if (this.SEzmaxinvoicingsummaryinternalDescription2 != null)
                    hashCode = hashCode * 59 + this.SEzmaxinvoicingsummaryinternalDescription2.GetHashCode();
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
            // SEzmaxinvoicingsummaryinternalDescription1 (string) maxLength
            if(this.SEzmaxinvoicingsummaryinternalDescription1 != null && this.SEzmaxinvoicingsummaryinternalDescription1.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzmaxinvoicingsummaryinternalDescription1, length must be less than 70.", new [] { "SEzmaxinvoicingsummaryinternalDescription1" });
            }


            // SEzmaxinvoicingsummaryinternalDescription2 (string) maxLength
            if(this.SEzmaxinvoicingsummaryinternalDescription2 != null && this.SEzmaxinvoicingsummaryinternalDescription2.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzmaxinvoicingsummaryinternalDescription2, length must be less than 70.", new [] { "SEzmaxinvoicingsummaryinternalDescription2" });
            }


            yield break;
        }
    }

}
