/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// Payload for POST /1/object/usergroupdelegation
    /// </summary>
    [DataContract]
    public partial class UsergroupdelegationCreateObjectV1ResponseMPayload :  IEquatable<UsergroupdelegationCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupdelegationCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiUsergroupdelegationID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public UsergroupdelegationCreateObjectV1ResponseMPayload(List<int> aPkiUsergroupdelegationID = default(List<int>))
        {
            // to ensure "aPkiUsergroupdelegationID" is required (not null)
            if (aPkiUsergroupdelegationID == null)
            {
                throw new InvalidDataException("aPkiUsergroupdelegationID is a required property for UsergroupdelegationCreateObjectV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.APkiUsergroupdelegationID = aPkiUsergroupdelegationID;
            }

        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name="a_pkiUsergroupdelegationID", EmitDefaultValue=true)]
        public List<int> APkiUsergroupdelegationID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupdelegationCreateObjectV1ResponseMPayload {\n");
            sb.Append("  APkiUsergroupdelegationID: ").Append(APkiUsergroupdelegationID).Append("\n");
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
            return this.Equals(input as UsergroupdelegationCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if UsergroupdelegationCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupdelegationCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupdelegationCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APkiUsergroupdelegationID == input.APkiUsergroupdelegationID ||
                    this.APkiUsergroupdelegationID != null &&
                    input.APkiUsergroupdelegationID != null &&
                    this.APkiUsergroupdelegationID.SequenceEqual(input.APkiUsergroupdelegationID)
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
                if (this.APkiUsergroupdelegationID != null)
                    hashCode = hashCode * 59 + this.APkiUsergroupdelegationID.GetHashCode();
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