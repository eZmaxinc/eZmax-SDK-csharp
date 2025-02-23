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
    /// The description of the Ezsignsigningreason
    /// </summary>
    [DataContract(Name = "Multilingual-EzsignsigningreasonDescription")]
    public partial class MultilingualEzsignsigningreasonDescription : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualEzsignsigningreasonDescription" /> class.
        /// </summary>
        /// <param name="sEzsignsigningreasonDescription1">The description of the Ezsignsigningreason in French.</param>
        /// <param name="sEzsignsigningreasonDescription2">The description of the Ezsignsigningreason in English.</param>
        public MultilingualEzsignsigningreasonDescription(string sEzsignsigningreasonDescription1 = default(string), string sEzsignsigningreasonDescription2 = default(string))
        {
            this.SEzsignsigningreasonDescription1 = sEzsignsigningreasonDescription1;
            this.SEzsignsigningreasonDescription2 = sEzsignsigningreasonDescription2;
        }

        /// <summary>
        /// The description of the Ezsignsigningreason in French
        /// </summary>
        /// <value>The description of the Ezsignsigningreason in French</value>
        /* <example>J&#39;approuve ce document</example>*/
        [DataMember(Name = "sEzsignsigningreasonDescription1", EmitDefaultValue = false)]
        public string SEzsignsigningreasonDescription1 { get; set; }

        /// <summary>
        /// The description of the Ezsignsigningreason in English
        /// </summary>
        /// <value>The description of the Ezsignsigningreason in English</value>
        /* <example>I approve this document</example>*/
        [DataMember(Name = "sEzsignsigningreasonDescription2", EmitDefaultValue = false)]
        public string SEzsignsigningreasonDescription2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultilingualEzsignsigningreasonDescription {\n");
            sb.Append("  SEzsignsigningreasonDescription1: ").Append(SEzsignsigningreasonDescription1).Append("\n");
            sb.Append("  SEzsignsigningreasonDescription2: ").Append(SEzsignsigningreasonDescription2).Append("\n");
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
            if (this.SEzsignsigningreasonDescription1 != null) {
                // SEzsignsigningreasonDescription1 (string) pattern
                Regex regexSEzsignsigningreasonDescription1 = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSEzsignsigningreasonDescription1.Match(this.SEzsignsigningreasonDescription1).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignsigningreasonDescription1, must match a pattern of " + regexSEzsignsigningreasonDescription1, new [] { "SEzsignsigningreasonDescription1" });
                }
            }

            if (this.SEzsignsigningreasonDescription2 != null) {
                // SEzsignsigningreasonDescription2 (string) pattern
                Regex regexSEzsignsigningreasonDescription2 = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSEzsignsigningreasonDescription2.Match(this.SEzsignsigningreasonDescription2).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignsigningreasonDescription2, must match a pattern of " + regexSEzsignsigningreasonDescription2, new [] { "SEzsignsigningreasonDescription2" });
                }
            }

            yield break;
        }
    }

}
