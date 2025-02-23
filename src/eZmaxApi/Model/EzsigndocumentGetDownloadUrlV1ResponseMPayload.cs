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
    /// Payload for GET /1/object/ezsigndocument/{pkiEzsigndocument}/getDownloadUrl
    /// </summary>
    [DataContract(Name = "ezsigndocument-getDownloadUrl-v1-Response-mPayload")]
    public partial class EzsigndocumentGetDownloadUrlV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetDownloadUrlV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentGetDownloadUrlV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetDownloadUrlV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="sDownloadUrl">The Url to the requested document.  Url will expire after 5 minutes. (required).</param>
        public EzsigndocumentGetDownloadUrlV1ResponseMPayload(string sDownloadUrl = default(string))
        {
            // to ensure "sDownloadUrl" is required (not null)
            if (sDownloadUrl == null)
            {
                throw new ArgumentNullException("sDownloadUrl is a required property for EzsigndocumentGetDownloadUrlV1ResponseMPayload and cannot be null");
            }
            this.SDownloadUrl = sDownloadUrl;
        }

        /// <summary>
        /// The Url to the requested document.  Url will expire after 5 minutes.
        /// </summary>
        /// <value>The Url to the requested document.  Url will expire after 5 minutes.</value>
        /* <example>http://www.example.com/document.pdf</example>*/
        [DataMember(Name = "sDownloadUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SDownloadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigndocumentGetDownloadUrlV1ResponseMPayload {\n");
            sb.Append("  SDownloadUrl: ").Append(SDownloadUrl).Append("\n");
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
