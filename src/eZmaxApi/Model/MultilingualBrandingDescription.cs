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
    /// Description of the Branding
    /// </summary>
    [DataContract(Name = "Multilingual-BrandingDescription")]
    public partial class MultilingualBrandingDescription : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualBrandingDescription" /> class.
        /// </summary>
        /// <param name="sBrandingDescription1">The description of the Branding in French.</param>
        /// <param name="sBrandingDescription2">The description of the Branding in English.</param>
        public MultilingualBrandingDescription(string sBrandingDescription1 = default(string), string sBrandingDescription2 = default(string))
        {
            this.SBrandingDescription1 = sBrandingDescription1;
            this.SBrandingDescription2 = sBrandingDescription2;
        }

        /// <summary>
        /// The description of the Branding in French
        /// </summary>
        /// <value>The description of the Branding in French</value>
        /* <example>Compagnie X</example>*/
        [DataMember(Name = "sBrandingDescription1", EmitDefaultValue = false)]
        public string SBrandingDescription1 { get; set; }

        /// <summary>
        /// The description of the Branding in English
        /// </summary>
        /// <value>The description of the Branding in English</value>
        /* <example>Company X</example>*/
        [DataMember(Name = "sBrandingDescription2", EmitDefaultValue = false)]
        public string SBrandingDescription2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultilingualBrandingDescription {\n");
            sb.Append("  SBrandingDescription1: ").Append(SBrandingDescription1).Append("\n");
            sb.Append("  SBrandingDescription2: ").Append(SBrandingDescription2).Append("\n");
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
            yield break;
        }
    }

}
