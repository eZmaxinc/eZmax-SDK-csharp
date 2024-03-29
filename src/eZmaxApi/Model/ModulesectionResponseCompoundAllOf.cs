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
    /// ModulesectionResponseCompoundAllOf
    /// </summary>
    [DataContract]
    public partial class ModulesectionResponseCompoundAllOf :  IEquatable<ModulesectionResponseCompoundAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModulesectionResponseCompoundAllOf" /> class.
        /// </summary>
        /// <param name="aObjPermission">aObjPermission.</param>
        public ModulesectionResponseCompoundAllOf(List<PermissionResponseCompound> aObjPermission = default(List<PermissionResponseCompound>))
        {
            this.AObjPermission = aObjPermission;
        }

        /// <summary>
        /// Gets or Sets AObjPermission
        /// </summary>
        [DataMember(Name="a_objPermission", EmitDefaultValue=false)]
        public List<PermissionResponseCompound> AObjPermission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModulesectionResponseCompoundAllOf {\n");
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
            return this.Equals(input as ModulesectionResponseCompoundAllOf);
        }

        /// <summary>
        /// Returns true if ModulesectionResponseCompoundAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ModulesectionResponseCompoundAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModulesectionResponseCompoundAllOf input)
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
