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
    /// Payload for POST /1/object/signature
    /// </summary>
    [DataContract]
    public partial class SignatureCreateObjectV1ResponseMPayload :  IEquatable<SignatureCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiSignatureID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public SignatureCreateObjectV1ResponseMPayload(List<int> aPkiSignatureID = default(List<int>))
        {
            // to ensure "aPkiSignatureID" is required (not null)
            if (aPkiSignatureID == null)
            {
                throw new InvalidDataException("aPkiSignatureID is a required property for SignatureCreateObjectV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.APkiSignatureID = aPkiSignatureID;
            }

        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name="a_pkiSignatureID", EmitDefaultValue=true)]
        public List<int> APkiSignatureID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureCreateObjectV1ResponseMPayload {\n");
            sb.Append("  APkiSignatureID: ").Append(APkiSignatureID).Append("\n");
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
            return this.Equals(input as SignatureCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if SignatureCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APkiSignatureID == input.APkiSignatureID ||
                    this.APkiSignatureID != null &&
                    input.APkiSignatureID != null &&
                    this.APkiSignatureID.SequenceEqual(input.APkiSignatureID)
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
                if (this.APkiSignatureID != null)
                    hashCode = hashCode * 59 + this.APkiSignatureID.GetHashCode();
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