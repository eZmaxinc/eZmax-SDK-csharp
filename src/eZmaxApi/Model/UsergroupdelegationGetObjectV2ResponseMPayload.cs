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
    /// Payload for GET /2/object/usergroupdelegation/{pkiUsergroupdelegationID}
    /// </summary>
    [DataContract]
    public partial class UsergroupdelegationGetObjectV2ResponseMPayload :  IEquatable<UsergroupdelegationGetObjectV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupdelegationGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objUsergroupdelegation">objUsergroupdelegation (required).</param>
        public UsergroupdelegationGetObjectV2ResponseMPayload(UsergroupdelegationResponseCompound objUsergroupdelegation = default(UsergroupdelegationResponseCompound))
        {
            // to ensure "objUsergroupdelegation" is required (not null)
            if (objUsergroupdelegation == null)
            {
                throw new InvalidDataException("objUsergroupdelegation is a required property for UsergroupdelegationGetObjectV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjUsergroupdelegation = objUsergroupdelegation;
            }

        }

        /// <summary>
        /// Gets or Sets ObjUsergroupdelegation
        /// </summary>
        [DataMember(Name="objUsergroupdelegation", EmitDefaultValue=true)]
        public UsergroupdelegationResponseCompound ObjUsergroupdelegation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupdelegationGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjUsergroupdelegation: ").Append(ObjUsergroupdelegation).Append("\n");
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
            return this.Equals(input as UsergroupdelegationGetObjectV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if UsergroupdelegationGetObjectV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupdelegationGetObjectV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupdelegationGetObjectV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjUsergroupdelegation == input.ObjUsergroupdelegation ||
                    (this.ObjUsergroupdelegation != null &&
                    this.ObjUsergroupdelegation.Equals(input.ObjUsergroupdelegation))
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
                if (this.ObjUsergroupdelegation != null)
                    hashCode = hashCode * 59 + this.ObjUsergroupdelegation.GetHashCode();
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