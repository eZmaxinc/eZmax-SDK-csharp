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
    /// Generic Error Message
    /// </summary>
    [DataContract(Name = "Common-Response-Error-TooManyRequests")]
    public partial class CommonResponseErrorTooManyRequests : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EErrorCode
        /// </summary>
        [DataMember(Name = "eErrorCode", IsRequired = true, EmitDefaultValue = true)]
        public FieldEErrorCode EErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseErrorTooManyRequests" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseErrorTooManyRequests() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseErrorTooManyRequests" /> class.
        /// </summary>
        /// <param name="sErrorMessage">The message giving details about the error (required).</param>
        /// <param name="eErrorCode">eErrorCode (required).</param>
        /// <param name="aSErrorMessagedetail">More error message detail.</param>
        public CommonResponseErrorTooManyRequests(string sErrorMessage = default(string), FieldEErrorCode eErrorCode = default(FieldEErrorCode), List<string> aSErrorMessagedetail = default(List<string>))
        {
            // to ensure "sErrorMessage" is required (not null)
            if (sErrorMessage == null)
            {
                throw new ArgumentNullException("sErrorMessage is a required property for CommonResponseErrorTooManyRequests and cannot be null");
            }
            this.SErrorMessage = sErrorMessage;
            this.EErrorCode = eErrorCode;
            this.ASErrorMessagedetail = aSErrorMessagedetail;
        }

        /// <summary>
        /// The message giving details about the error
        /// </summary>
        /// <value>The message giving details about the error</value>
        /* <example>Invalid Signature Headers</example>*/
        [DataMember(Name = "sErrorMessage", IsRequired = true, EmitDefaultValue = true)]
        public string SErrorMessage { get; set; }

        /// <summary>
        /// More error message detail
        /// </summary>
        /// <value>More error message detail</value>
        [DataMember(Name = "a_sErrorMessagedetail", EmitDefaultValue = false)]
        public List<string> ASErrorMessagedetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonResponseErrorTooManyRequests {\n");
            sb.Append("  SErrorMessage: ").Append(SErrorMessage).Append("\n");
            sb.Append("  EErrorCode: ").Append(EErrorCode).Append("\n");
            sb.Append("  ASErrorMessagedetail: ").Append(ASErrorMessagedetail).Append("\n");
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
            if (this.SErrorMessage != null) {
                // SErrorMessage (string) pattern
                Regex regexSErrorMessage = new Regex(@"^.{0,500}$", RegexOptions.CultureInvariant);
                if (!regexSErrorMessage.Match(this.SErrorMessage).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SErrorMessage, must match a pattern of " + regexSErrorMessage, new [] { "SErrorMessage" });
                }
            }

            yield break;
        }
    }

}
