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
    /// Payload for GET /1/object/ezsignbulksend/getList
    /// </summary>
    [DataContract]
    public partial class EzsignbulksendGetListV1ResponseMPayload :  IEquatable<EzsignbulksendGetListV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendGetListV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignbulksendGetListV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendGetListV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsignbulksend">aObjEzsignbulksend (required).</param>
        /// <param name="iRowReturned">The number of rows returned (required).</param>
        /// <param name="iRowFiltered">The number of rows matching your filters (if any) or the total number of rows (required).</param>
        public EzsignbulksendGetListV1ResponseMPayload(List<EzsignbulksendListElement> aObjEzsignbulksend = default(List<EzsignbulksendListElement>), int iRowReturned = default(int), int iRowFiltered = default(int))
        {
            // to ensure "aObjEzsignbulksend" is required (not null)
            if (aObjEzsignbulksend == null)
            {
                throw new InvalidDataException("aObjEzsignbulksend is a required property for EzsignbulksendGetListV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjEzsignbulksend = aObjEzsignbulksend;
            }

            // to ensure "iRowReturned" is required (not null)
            if (iRowReturned == null)
            {
                throw new InvalidDataException("iRowReturned is a required property for EzsignbulksendGetListV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.IRowReturned = iRowReturned;
            }

            // to ensure "iRowFiltered" is required (not null)
            if (iRowFiltered == null)
            {
                throw new InvalidDataException("iRowFiltered is a required property for EzsignbulksendGetListV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.IRowFiltered = iRowFiltered;
            }

        }

        /// <summary>
        /// Gets or Sets AObjEzsignbulksend
        /// </summary>
        [DataMember(Name="a_objEzsignbulksend", EmitDefaultValue=true)]
        public List<EzsignbulksendListElement> AObjEzsignbulksend { get; set; }

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
            sb.Append("class EzsignbulksendGetListV1ResponseMPayload {\n");
            sb.Append("  AObjEzsignbulksend: ").Append(AObjEzsignbulksend).Append("\n");
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
            return this.Equals(input as EzsignbulksendGetListV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsignbulksendGetListV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignbulksendGetListV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignbulksendGetListV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjEzsignbulksend == input.AObjEzsignbulksend ||
                    this.AObjEzsignbulksend != null &&
                    input.AObjEzsignbulksend != null &&
                    this.AObjEzsignbulksend.SequenceEqual(input.AObjEzsignbulksend)
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
                if (this.AObjEzsignbulksend != null)
                    hashCode = hashCode * 59 + this.AObjEzsignbulksend.GetHashCode();
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
