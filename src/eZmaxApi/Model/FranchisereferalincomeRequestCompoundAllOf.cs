/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.47
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
    /// FranchisereferalincomeRequestCompoundAllOf
    /// </summary>
    [DataContract]
    public partial class FranchisereferalincomeRequestCompoundAllOf :  IEquatable<FranchisereferalincomeRequestCompoundAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequestCompoundAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FranchisereferalincomeRequestCompoundAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequestCompoundAllOf" /> class.
        /// </summary>
        /// <param name="objAddress">objAddress.</param>
        /// <param name="aObjContact">aObjContact (required).</param>
        public FranchisereferalincomeRequestCompoundAllOf(AddressRequest objAddress = default(AddressRequest), List<ContactRequestCompound> aObjContact = default(List<ContactRequestCompound>))
        {
            // to ensure "aObjContact" is required (not null)
            if (aObjContact == null)
            {
                throw new InvalidDataException("aObjContact is a required property for FranchisereferalincomeRequestCompoundAllOf and cannot be null");
            }
            else
            {
                this.AObjContact = aObjContact;
            }

            this.ObjAddress = objAddress;
        }

        /// <summary>
        /// Gets or Sets ObjAddress
        /// </summary>
        [DataMember(Name="objAddress", EmitDefaultValue=false)]
        public AddressRequest ObjAddress { get; set; }

        /// <summary>
        /// Gets or Sets AObjContact
        /// </summary>
        [DataMember(Name="a_objContact", EmitDefaultValue=true)]
        public List<ContactRequestCompound> AObjContact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeRequestCompoundAllOf {\n");
            sb.Append("  ObjAddress: ").Append(ObjAddress).Append("\n");
            sb.Append("  AObjContact: ").Append(AObjContact).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeRequestCompoundAllOf);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeRequestCompoundAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeRequestCompoundAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeRequestCompoundAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjAddress == input.ObjAddress ||
                    (this.ObjAddress != null &&
                    this.ObjAddress.Equals(input.ObjAddress))
                ) && 
                (
                    this.AObjContact == input.AObjContact ||
                    this.AObjContact != null &&
                    input.AObjContact != null &&
                    this.AObjContact.SequenceEqual(input.AObjContact)
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
                if (this.ObjAddress != null)
                    hashCode = hashCode * 59 + this.ObjAddress.GetHashCode();
                if (this.AObjContact != null)
                    hashCode = hashCode * 59 + this.AObjContact.GetHashCode();
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