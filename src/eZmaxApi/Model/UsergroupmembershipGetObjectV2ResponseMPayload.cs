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
    /// Payload for GET /2/object/usergroupmembership/{pkiUsergroupmembershipID}
    /// </summary>
    [DataContract]
    public partial class UsergroupmembershipGetObjectV2ResponseMPayload :  IEquatable<UsergroupmembershipGetObjectV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupmembershipGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupmembershipGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupmembershipGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objUsergroupmembership">objUsergroupmembership (required).</param>
        public UsergroupmembershipGetObjectV2ResponseMPayload(UsergroupmembershipResponseCompound objUsergroupmembership = default(UsergroupmembershipResponseCompound))
        {
            // to ensure "objUsergroupmembership" is required (not null)
            if (objUsergroupmembership == null)
            {
                throw new InvalidDataException("objUsergroupmembership is a required property for UsergroupmembershipGetObjectV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjUsergroupmembership = objUsergroupmembership;
            }

        }

        /// <summary>
        /// Gets or Sets ObjUsergroupmembership
        /// </summary>
        [DataMember(Name="objUsergroupmembership", EmitDefaultValue=true)]
        public UsergroupmembershipResponseCompound ObjUsergroupmembership { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupmembershipGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjUsergroupmembership: ").Append(ObjUsergroupmembership).Append("\n");
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
            return this.Equals(input as UsergroupmembershipGetObjectV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if UsergroupmembershipGetObjectV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupmembershipGetObjectV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupmembershipGetObjectV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjUsergroupmembership == input.ObjUsergroupmembership ||
                    (this.ObjUsergroupmembership != null &&
                    this.ObjUsergroupmembership.Equals(input.ObjUsergroupmembership))
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
                if (this.ObjUsergroupmembership != null)
                    hashCode = hashCode * 59 + this.ObjUsergroupmembership.GetHashCode();
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