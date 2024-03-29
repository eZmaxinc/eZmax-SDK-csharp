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
    /// Response for Websocket GetWebsocketID V1
    /// </summary>
    [DataContract]
    public partial class WebsocketResponseGetWebsocketIDV1 :  IEquatable<WebsocketResponseGetWebsocketIDV1>, IValidatableObject
    {
        /// <summary>
        /// The Type of message
        /// </summary>
        /// <value>The Type of message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EWebsocketMessagetypeEnum
        {
            /// <summary>
            /// Enum ResponseGetWebsocketIDV1 for value: Response-GetWebsocketID-V1
            /// </summary>
            [EnumMember(Value = "Response-GetWebsocketID-V1")]
            ResponseGetWebsocketIDV1 = 1

        }

        /// <summary>
        /// The Type of message
        /// </summary>
        /// <value>The Type of message</value>
        [DataMember(Name="eWebsocketMessagetype", EmitDefaultValue=true)]
        public EWebsocketMessagetypeEnum EWebsocketMessagetype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketResponseGetWebsocketIDV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebsocketResponseGetWebsocketIDV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketResponseGetWebsocketIDV1" /> class.
        /// </summary>
        /// <param name="eWebsocketMessagetype">The Type of message (required).</param>
        /// <param name="mPayload">mPayload (required).</param>
        public WebsocketResponseGetWebsocketIDV1(EWebsocketMessagetypeEnum eWebsocketMessagetype = default(EWebsocketMessagetypeEnum), WebsocketResponseGetWebsocketIDV1MPayload mPayload = default(WebsocketResponseGetWebsocketIDV1MPayload))
        {
            // to ensure "eWebsocketMessagetype" is required (not null)
            if (eWebsocketMessagetype == null)
            {
                throw new InvalidDataException("eWebsocketMessagetype is a required property for WebsocketResponseGetWebsocketIDV1 and cannot be null");
            }
            else
            {
                this.EWebsocketMessagetype = eWebsocketMessagetype;
            }

            // to ensure "mPayload" is required (not null)
            if (mPayload == null)
            {
                throw new InvalidDataException("mPayload is a required property for WebsocketResponseGetWebsocketIDV1 and cannot be null");
            }
            else
            {
                this.MPayload = mPayload;
            }

        }


        /// <summary>
        /// Gets or Sets MPayload
        /// </summary>
        [DataMember(Name="mPayload", EmitDefaultValue=true)]
        public WebsocketResponseGetWebsocketIDV1MPayload MPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebsocketResponseGetWebsocketIDV1 {\n");
            sb.Append("  EWebsocketMessagetype: ").Append(EWebsocketMessagetype).Append("\n");
            sb.Append("  MPayload: ").Append(MPayload).Append("\n");
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
            return this.Equals(input as WebsocketResponseGetWebsocketIDV1);
        }

        /// <summary>
        /// Returns true if WebsocketResponseGetWebsocketIDV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsocketResponseGetWebsocketIDV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsocketResponseGetWebsocketIDV1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EWebsocketMessagetype == input.EWebsocketMessagetype ||
                    (this.EWebsocketMessagetype != null &&
                    this.EWebsocketMessagetype.Equals(input.EWebsocketMessagetype))
                ) && 
                (
                    this.MPayload == input.MPayload ||
                    (this.MPayload != null &&
                    this.MPayload.Equals(input.MPayload))
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
                if (this.EWebsocketMessagetype != null)
                    hashCode = hashCode * 59 + this.EWebsocketMessagetype.GetHashCode();
                if (this.MPayload != null)
                    hashCode = hashCode * 59 + this.MPayload.GetHashCode();
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
            yield break;
        }
    }

}
