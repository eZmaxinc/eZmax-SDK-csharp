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
    /// Request for POST /1/object/activesession/generateFederationToken
    /// </summary>
    [DataContract(Name = "activesession-generateFederationToken-v1-Request")]
    public partial class ActivesessionGenerateFederationTokenV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivesessionGenerateFederationTokenV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivesessionGenerateFederationTokenV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivesessionGenerateFederationTokenV1Request" /> class.
        /// </summary>
        /// <param name="fksEzmaxcustomerCode">The Ezmaxcustomer code (required).</param>
        public ActivesessionGenerateFederationTokenV1Request(string fksEzmaxcustomerCode = default(string))
        {
            // to ensure "fksEzmaxcustomerCode" is required (not null)
            if (fksEzmaxcustomerCode == null)
            {
                throw new ArgumentNullException("fksEzmaxcustomerCode is a required property for ActivesessionGenerateFederationTokenV1Request and cannot be null");
            }
            this.FksEzmaxcustomerCode = fksEzmaxcustomerCode;
        }

        /// <summary>
        /// The Ezmaxcustomer code
        /// </summary>
        /// <value>The Ezmaxcustomer code</value>
        /* <example>demo</example>*/
        [DataMember(Name = "fksEzmaxcustomerCode", IsRequired = true, EmitDefaultValue = true)]
        public string FksEzmaxcustomerCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivesessionGenerateFederationTokenV1Request {\n");
            sb.Append("  FksEzmaxcustomerCode: ").Append(FksEzmaxcustomerCode).Append("\n");
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
            // FksEzmaxcustomerCode (string) maxLength
            if (this.FksEzmaxcustomerCode != null && this.FksEzmaxcustomerCode.Length > 6)
            {
                yield return new ValidationResult("Invalid value for FksEzmaxcustomerCode, length must be less than 6.", new [] { "FksEzmaxcustomerCode" });
            }

            // FksEzmaxcustomerCode (string) minLength
            if (this.FksEzmaxcustomerCode != null && this.FksEzmaxcustomerCode.Length < 2)
            {
                yield return new ValidationResult("Invalid value for FksEzmaxcustomerCode, length must be greater than 2.", new [] { "FksEzmaxcustomerCode" });
            }

            if (this.FksEzmaxcustomerCode != null) {
                // FksEzmaxcustomerCode (string) pattern
                Regex regexFksEzmaxcustomerCode = new Regex(@"^[a-z\d]{2,6}$", RegexOptions.CultureInvariant);
                if (!regexFksEzmaxcustomerCode.Match(this.FksEzmaxcustomerCode).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FksEzmaxcustomerCode, must match a pattern of " + regexFksEzmaxcustomerCode, new [] { "FksEzmaxcustomerCode" });
                }
            }

            yield break;
        }
    }

}
