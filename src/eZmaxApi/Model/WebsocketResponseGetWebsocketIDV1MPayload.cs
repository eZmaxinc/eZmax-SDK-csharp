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
    /// Payload for Websocket GetWebsocketID V1
    /// </summary>
    [DataContract(Name = "Websocket-Response-GetWebsocketID-V1-mPayload")]
    public partial class WebsocketResponseGetWebsocketIDV1MPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketResponseGetWebsocketIDV1MPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketResponseGetWebsocketIDV1MPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketResponseGetWebsocketIDV1MPayload" /> class.
        /// </summary>
        /// <param name="sWebsocketID">The Unique ID of the Websocket Connection (required).</param>
        public WebsocketResponseGetWebsocketIDV1MPayload(string sWebsocketID = default(string))
        {
            // to ensure "sWebsocketID" is required (not null)
            if (sWebsocketID == null)
            {
                throw new ArgumentNullException("sWebsocketID is a required property for WebsocketResponseGetWebsocketIDV1MPayload and cannot be null");
            }
            this.SWebsocketID = sWebsocketID;
        }

        /// <summary>
        /// The Unique ID of the Websocket Connection
        /// </summary>
        /// <value>The Unique ID of the Websocket Connection</value>
        /* <example>G_omidyY4osCFEQ&#x3D;</example>*/
        [DataMember(Name = "sWebsocketID", IsRequired = true, EmitDefaultValue = true)]
        public string SWebsocketID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsocketResponseGetWebsocketIDV1MPayload {\n");
            sb.Append("  SWebsocketID: ").Append(SWebsocketID).Append("\n");
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
            if (this.SWebsocketID != null) {
                // SWebsocketID (string) pattern
                Regex regexSWebsocketID = new Regex(@"^[a-zA-Z0-9_-]{15}=$", RegexOptions.CultureInvariant);
                if (!regexSWebsocketID.Match(this.SWebsocketID).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SWebsocketID, must match a pattern of " + regexSWebsocketID, new [] { "SWebsocketID" });
                }
            }

            yield break;
        }
    }

}
