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
    /// Request for POST /1/object/usergroupdelegation
    /// </summary>
    [DataContract]
    public partial class UsergroupdelegationCreateObjectV1Request :  IEquatable<UsergroupdelegationCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupdelegationCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjUsergroupdelegation">aObjUsergroupdelegation (required).</param>
        public UsergroupdelegationCreateObjectV1Request(List<UsergroupdelegationRequestCompound> aObjUsergroupdelegation = default(List<UsergroupdelegationRequestCompound>))
        {
            // to ensure "aObjUsergroupdelegation" is required (not null)
            if (aObjUsergroupdelegation == null)
            {
                throw new InvalidDataException("aObjUsergroupdelegation is a required property for UsergroupdelegationCreateObjectV1Request and cannot be null");
            }
            else
            {
                this.AObjUsergroupdelegation = aObjUsergroupdelegation;
            }

        }

        /// <summary>
        /// Gets or Sets AObjUsergroupdelegation
        /// </summary>
        [DataMember(Name="a_objUsergroupdelegation", EmitDefaultValue=true)]
        public List<UsergroupdelegationRequestCompound> AObjUsergroupdelegation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupdelegationCreateObjectV1Request {\n");
            sb.Append("  AObjUsergroupdelegation: ").Append(AObjUsergroupdelegation).Append("\n");
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
            return this.Equals(input as UsergroupdelegationCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if UsergroupdelegationCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupdelegationCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupdelegationCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjUsergroupdelegation == input.AObjUsergroupdelegation ||
                    this.AObjUsergroupdelegation != null &&
                    input.AObjUsergroupdelegation != null &&
                    this.AObjUsergroupdelegation.SequenceEqual(input.AObjUsergroupdelegation)
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
                if (this.AObjUsergroupdelegation != null)
                    hashCode = hashCode * 59 + this.AObjUsergroupdelegation.GetHashCode();
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