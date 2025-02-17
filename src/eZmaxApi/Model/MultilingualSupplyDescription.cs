/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.1
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// The description1 of the Supply
    /// </summary>
    [DataContract(Name = "Multilingual-SupplyDescription")]
    public partial class MultilingualSupplyDescription : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualSupplyDescription" /> class.
        /// </summary>
        /// <param name="sSupplyDescription1">The description of the Supply in French.</param>
        /// <param name="sSupplyDescription2">The description of the Supply in English.</param>
        public MultilingualSupplyDescription(string sSupplyDescription1 = default(string), string sSupplyDescription2 = default(string))
        {
            this.SSupplyDescription1 = sSupplyDescription1;
            this.SSupplyDescription2 = sSupplyDescription2;
        }

        /// <summary>
        /// The description of the Supply in French
        /// </summary>
        /// <value>The description of the Supply in French</value>
        /* <example>Papier lettre paquet</example>*/
        [DataMember(Name = "sSupplyDescription1", EmitDefaultValue = false)]
        public string SSupplyDescription1 { get; set; }

        /// <summary>
        /// The description of the Supply in English
        /// </summary>
        /// <value>The description of the Supply in English</value>
        /* <example>Letter paper package</example>*/
        [DataMember(Name = "sSupplyDescription2", EmitDefaultValue = false)]
        public string SSupplyDescription2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultilingualSupplyDescription {\n");
            sb.Append("  SSupplyDescription1: ").Append(SSupplyDescription1).Append("\n");
            sb.Append("  SSupplyDescription2: ").Append(SSupplyDescription2).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (this.SSupplyDescription1 != null) {
                // SSupplyDescription1 (string) pattern
                Regex regexSSupplyDescription1 = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSSupplyDescription1.Match(this.SSupplyDescription1).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SSupplyDescription1, must match a pattern of " + regexSSupplyDescription1, new [] { "SSupplyDescription1" });
                }
            }

            if (this.SSupplyDescription2 != null) {
                // SSupplyDescription2 (string) pattern
                Regex regexSSupplyDescription2 = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSSupplyDescription2.Match(this.SSupplyDescription2).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SSupplyDescription2, must match a pattern of " + regexSSupplyDescription2, new [] { "SSupplyDescription2" });
                }
            }

            yield break;
        }
    }

}
