/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.17
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
    /// Request for PUT /1/object/usergroup/{pkiUsergroupID}
    /// </summary>
    [DataContract]
    public partial class UsergroupEditObjectV1Request :  IEquatable<UsergroupEditObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objUsergroup">objUsergroup (required).</param>
        public UsergroupEditObjectV1Request(UsergroupRequestCompound objUsergroup = default(UsergroupRequestCompound))
        {
            // to ensure "objUsergroup" is required (not null)
            if (objUsergroup == null)
            {
                throw new InvalidDataException("objUsergroup is a required property for UsergroupEditObjectV1Request and cannot be null");
            }
            else
            {
                this.ObjUsergroup = objUsergroup;
            }

        }

        /// <summary>
        /// Gets or Sets ObjUsergroup
        /// </summary>
        [DataMember(Name="objUsergroup", EmitDefaultValue=true)]
        public UsergroupRequestCompound ObjUsergroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupEditObjectV1Request {\n");
            sb.Append("  ObjUsergroup: ").Append(ObjUsergroup).Append("\n");
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
            return this.Equals(input as UsergroupEditObjectV1Request);
        }

        /// <summary>
        /// Returns true if UsergroupEditObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupEditObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupEditObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjUsergroup == input.ObjUsergroup ||
                    (this.ObjUsergroup != null &&
                    this.ObjUsergroup.Equals(input.ObjUsergroup))
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
                if (this.ObjUsergroup != null)
                    hashCode = hashCode * 59 + this.ObjUsergroup.GetHashCode();
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