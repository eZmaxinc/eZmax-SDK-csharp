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
    /// Generic Warning Message
    /// </summary>
    [DataContract(Name = "Common-Response-Warning")]
    public partial class CommonResponseWarning : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseWarning" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseWarning() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseWarning" /> class.
        /// </summary>
        /// <param name="sWarningMessage">More detail about the warning (required).</param>
        /// <param name="eWarningCode">The warning code. See documentation for valid values (required).</param>
        public CommonResponseWarning(string sWarningMessage = default(string), string eWarningCode = default(string))
        {
            // to ensure "sWarningMessage" is required (not null)
            if (sWarningMessage == null)
            {
                throw new ArgumentNullException("sWarningMessage is a required property for CommonResponseWarning and cannot be null");
            }
            this.SWarningMessage = sWarningMessage;
            // to ensure "eWarningCode" is required (not null)
            if (eWarningCode == null)
            {
                throw new ArgumentNullException("eWarningCode is a required property for CommonResponseWarning and cannot be null");
            }
            this.EWarningCode = eWarningCode;
        }

        /// <summary>
        /// More detail about the warning
        /// </summary>
        /// <value>More detail about the warning</value>
        [DataMember(Name = "sWarningMessage", IsRequired = true, EmitDefaultValue = true)]
        public string SWarningMessage { get; set; }

        /// <summary>
        /// The warning code. See documentation for valid values
        /// </summary>
        /// <value>The warning code. See documentation for valid values</value>
        [DataMember(Name = "eWarningCode", IsRequired = true, EmitDefaultValue = true)]
        public string EWarningCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonResponseWarning {\n");
            sb.Append("  SWarningMessage: ").Append(SWarningMessage).Append("\n");
            sb.Append("  EWarningCode: ").Append(EWarningCode).Append("\n");
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
