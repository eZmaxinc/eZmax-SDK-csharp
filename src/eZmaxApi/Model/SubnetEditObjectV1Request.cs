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
    /// Request for PUT /1/object/subnet/{pkiSubnetID}
    /// </summary>
    [DataContract]
    public partial class SubnetEditObjectV1Request :  IEquatable<SubnetEditObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubnetEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubnetEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubnetEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objSubnet">objSubnet (required).</param>
        public SubnetEditObjectV1Request(SubnetRequestCompound objSubnet = default(SubnetRequestCompound))
        {
            // to ensure "objSubnet" is required (not null)
            if (objSubnet == null)
            {
                throw new InvalidDataException("objSubnet is a required property for SubnetEditObjectV1Request and cannot be null");
            }
            else
            {
                this.ObjSubnet = objSubnet;
            }

        }

        /// <summary>
        /// Gets or Sets ObjSubnet
        /// </summary>
        [DataMember(Name="objSubnet", EmitDefaultValue=true)]
        public SubnetRequestCompound ObjSubnet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubnetEditObjectV1Request {\n");
            sb.Append("  ObjSubnet: ").Append(ObjSubnet).Append("\n");
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
            return this.Equals(input as SubnetEditObjectV1Request);
        }

        /// <summary>
        /// Returns true if SubnetEditObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of SubnetEditObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubnetEditObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjSubnet == input.ObjSubnet ||
                    (this.ObjSubnet != null &&
                    this.ObjSubnet.Equals(input.ObjSubnet))
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
                if (this.ObjSubnet != null)
                    hashCode = hashCode * 59 + this.ObjSubnet.GetHashCode();
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