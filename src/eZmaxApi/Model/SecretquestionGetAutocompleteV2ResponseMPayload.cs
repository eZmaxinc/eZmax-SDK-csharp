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
    /// Payload for POST /2/object/secretquestion/getAutocomplete
    /// </summary>
    [DataContract]
    public partial class SecretquestionGetAutocompleteV2ResponseMPayload :  IEquatable<SecretquestionGetAutocompleteV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretquestionGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecretquestionGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretquestionGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjSecretquestion">An array of Secretquestion autocomplete element response. (required).</param>
        public SecretquestionGetAutocompleteV2ResponseMPayload(List<SecretquestionAutocompleteElementResponse> aObjSecretquestion = default(List<SecretquestionAutocompleteElementResponse>))
        {
            // to ensure "aObjSecretquestion" is required (not null)
            if (aObjSecretquestion == null)
            {
                throw new InvalidDataException("aObjSecretquestion is a required property for SecretquestionGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjSecretquestion = aObjSecretquestion;
            }

        }

        /// <summary>
        /// An array of Secretquestion autocomplete element response.
        /// </summary>
        /// <value>An array of Secretquestion autocomplete element response.</value>
        [DataMember(Name="a_objSecretquestion", EmitDefaultValue=true)]
        public List<SecretquestionAutocompleteElementResponse> AObjSecretquestion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretquestionGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjSecretquestion: ").Append(AObjSecretquestion).Append("\n");
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
            return this.Equals(input as SecretquestionGetAutocompleteV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if SecretquestionGetAutocompleteV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of SecretquestionGetAutocompleteV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecretquestionGetAutocompleteV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjSecretquestion == input.AObjSecretquestion ||
                    this.AObjSecretquestion != null &&
                    input.AObjSecretquestion != null &&
                    this.AObjSecretquestion.SequenceEqual(input.AObjSecretquestion)
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
                if (this.AObjSecretquestion != null)
                    hashCode = hashCode * 59 + this.AObjSecretquestion.GetHashCode();
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