/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
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
    /// 352 Redirect Message containing secret question
    /// </summary>
    [DataContract]
    public partial class CommonResponseRedirectSSecretquestionTextX :  IEquatable<CommonResponseRedirectSSecretquestionTextX>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseRedirectSSecretquestionTextX" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseRedirectSSecretquestionTextX() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseRedirectSSecretquestionTextX" /> class.
        /// </summary>
        /// <param name="sSecretquestionTextX">The text of the Secretquestion in the language of the requester (required).</param>
        public CommonResponseRedirectSSecretquestionTextX(string sSecretquestionTextX = default(string))
        {
            // to ensure "sSecretquestionTextX" is required (not null)
            if (sSecretquestionTextX == null)
            {
                throw new InvalidDataException("sSecretquestionTextX is a required property for CommonResponseRedirectSSecretquestionTextX and cannot be null");
            }
            else
            {
                this.SSecretquestionTextX = sSecretquestionTextX;
            }

        }

        /// <summary>
        /// The text of the Secretquestion in the language of the requester
        /// </summary>
        /// <value>The text of the Secretquestion in the language of the requester</value>
        [DataMember(Name="sSecretquestionTextX", EmitDefaultValue=true)]
        public string SSecretquestionTextX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseRedirectSSecretquestionTextX {\n");
            sb.Append("  SSecretquestionTextX: ").Append(SSecretquestionTextX).Append("\n");
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
            return this.Equals(input as CommonResponseRedirectSSecretquestionTextX);
        }

        /// <summary>
        /// Returns true if CommonResponseRedirectSSecretquestionTextX instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponseRedirectSSecretquestionTextX to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponseRedirectSSecretquestionTextX input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SSecretquestionTextX == input.SSecretquestionTextX ||
                    (this.SSecretquestionTextX != null &&
                    this.SSecretquestionTextX.Equals(input.SSecretquestionTextX))
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
                if (this.SSecretquestionTextX != null)
                    hashCode = hashCode * 59 + this.SSecretquestionTextX.GetHashCode();
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