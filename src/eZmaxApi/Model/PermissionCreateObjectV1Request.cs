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
    /// Request for POST /1/object/permission
    /// </summary>
    [DataContract]
    public partial class PermissionCreateObjectV1Request :  IEquatable<PermissionCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PermissionCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjPermission">aObjPermission (required).</param>
        public PermissionCreateObjectV1Request(List<PermissionRequestCompound> aObjPermission = default(List<PermissionRequestCompound>))
        {
            // to ensure "aObjPermission" is required (not null)
            if (aObjPermission == null)
            {
                throw new InvalidDataException("aObjPermission is a required property for PermissionCreateObjectV1Request and cannot be null");
            }
            else
            {
                this.AObjPermission = aObjPermission;
            }

        }

        /// <summary>
        /// Gets or Sets AObjPermission
        /// </summary>
        [DataMember(Name="a_objPermission", EmitDefaultValue=true)]
        public List<PermissionRequestCompound> AObjPermission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionCreateObjectV1Request {\n");
            sb.Append("  AObjPermission: ").Append(AObjPermission).Append("\n");
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
            return this.Equals(input as PermissionCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if PermissionCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjPermission == input.AObjPermission ||
                    this.AObjPermission != null &&
                    input.AObjPermission != null &&
                    this.AObjPermission.SequenceEqual(input.AObjPermission)
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
                if (this.AObjPermission != null)
                    hashCode = hashCode * 59 + this.AObjPermission.GetHashCode();
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