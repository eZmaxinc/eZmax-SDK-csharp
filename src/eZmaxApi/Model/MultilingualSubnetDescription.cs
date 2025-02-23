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
    /// The description of the Subnet
    /// </summary>
    [DataContract(Name = "Multilingual-SubnetDescription")]
    public partial class MultilingualSubnetDescription : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualSubnetDescription" /> class.
        /// </summary>
        /// <param name="sSubnetDescription1">The description of the Subnet in French.</param>
        /// <param name="sSubnetDescription2">The description of the Subnet in English.</param>
        public MultilingualSubnetDescription(string sSubnetDescription1 = default(string), string sSubnetDescription2 = default(string))
        {
            this.SSubnetDescription1 = sSubnetDescription1;
            this.SSubnetDescription2 = sSubnetDescription2;
        }

        /// <summary>
        /// The description of the Subnet in French
        /// </summary>
        /// <value>The description of the Subnet in French</value>
        /* <example>Bureau chef</example>*/
        [DataMember(Name = "sSubnetDescription1", EmitDefaultValue = false)]
        public string SSubnetDescription1 { get; set; }

        /// <summary>
        /// The description of the Subnet in English
        /// </summary>
        /// <value>The description of the Subnet in English</value>
        /* <example>Head office</example>*/
        [DataMember(Name = "sSubnetDescription2", EmitDefaultValue = false)]
        public string SSubnetDescription2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultilingualSubnetDescription {\n");
            sb.Append("  SSubnetDescription1: ").Append(SSubnetDescription1).Append("\n");
            sb.Append("  SSubnetDescription2: ").Append(SSubnetDescription2).Append("\n");
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
            if (this.SSubnetDescription1 != null) {
                // SSubnetDescription1 (string) pattern
                Regex regexSSubnetDescription1 = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSSubnetDescription1.Match(this.SSubnetDescription1).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SSubnetDescription1, must match a pattern of " + regexSSubnetDescription1, new [] { "SSubnetDescription1" });
                }
            }

            if (this.SSubnetDescription2 != null) {
                // SSubnetDescription2 (string) pattern
                Regex regexSSubnetDescription2 = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSSubnetDescription2.Match(this.SSubnetDescription2).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SSubnetDescription2, must match a pattern of " + regexSSubnetDescription2, new [] { "SSubnetDescription2" });
                }
            }

            yield break;
        }
    }

}
