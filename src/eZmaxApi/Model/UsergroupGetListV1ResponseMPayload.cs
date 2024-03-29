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
    /// Payload for GET /1/object/usergroup/getList
    /// </summary>
    [DataContract]
    public partial class UsergroupGetListV1ResponseMPayload :  IEquatable<UsergroupGetListV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupGetListV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupGetListV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupGetListV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjUsergroup">aObjUsergroup (required).</param>
        /// <param name="iRowReturned">The number of rows returned (required).</param>
        /// <param name="iRowFiltered">The number of rows matching your filters (if any) or the total number of rows (required).</param>
        public UsergroupGetListV1ResponseMPayload(List<UsergroupListElement> aObjUsergroup = default(List<UsergroupListElement>), int iRowReturned = default(int), int iRowFiltered = default(int))
        {
            // to ensure "aObjUsergroup" is required (not null)
            if (aObjUsergroup == null)
            {
                throw new InvalidDataException("aObjUsergroup is a required property for UsergroupGetListV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjUsergroup = aObjUsergroup;
            }

            // to ensure "iRowReturned" is required (not null)
            if (iRowReturned == null)
            {
                throw new InvalidDataException("iRowReturned is a required property for UsergroupGetListV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.IRowReturned = iRowReturned;
            }

            // to ensure "iRowFiltered" is required (not null)
            if (iRowFiltered == null)
            {
                throw new InvalidDataException("iRowFiltered is a required property for UsergroupGetListV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.IRowFiltered = iRowFiltered;
            }

        }

        /// <summary>
        /// Gets or Sets AObjUsergroup
        /// </summary>
        [DataMember(Name="a_objUsergroup", EmitDefaultValue=true)]
        public List<UsergroupListElement> AObjUsergroup { get; set; }

        /// <summary>
        /// The number of rows returned
        /// </summary>
        /// <value>The number of rows returned</value>
        [DataMember(Name="iRowReturned", EmitDefaultValue=true)]
        public int IRowReturned { get; set; }

        /// <summary>
        /// The number of rows matching your filters (if any) or the total number of rows
        /// </summary>
        /// <value>The number of rows matching your filters (if any) or the total number of rows</value>
        [DataMember(Name="iRowFiltered", EmitDefaultValue=true)]
        public int IRowFiltered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupGetListV1ResponseMPayload {\n");
            sb.Append("  AObjUsergroup: ").Append(AObjUsergroup).Append("\n");
            sb.Append("  IRowReturned: ").Append(IRowReturned).Append("\n");
            sb.Append("  IRowFiltered: ").Append(IRowFiltered).Append("\n");
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
            return this.Equals(input as UsergroupGetListV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if UsergroupGetListV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupGetListV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupGetListV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjUsergroup == input.AObjUsergroup ||
                    this.AObjUsergroup != null &&
                    input.AObjUsergroup != null &&
                    this.AObjUsergroup.SequenceEqual(input.AObjUsergroup)
                ) && 
                (
                    this.IRowReturned == input.IRowReturned ||
                    (this.IRowReturned != null &&
                    this.IRowReturned.Equals(input.IRowReturned))
                ) && 
                (
                    this.IRowFiltered == input.IRowFiltered ||
                    (this.IRowFiltered != null &&
                    this.IRowFiltered.Equals(input.IRowFiltered))
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
                if (this.AObjUsergroup != null)
                    hashCode = hashCode * 59 + this.AObjUsergroup.GetHashCode();
                if (this.IRowReturned != null)
                    hashCode = hashCode * 59 + this.IRowReturned.GetHashCode();
                if (this.IRowFiltered != null)
                    hashCode = hashCode * 59 + this.IRowFiltered.GetHashCode();
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
