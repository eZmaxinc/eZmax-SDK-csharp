/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
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
    /// Payload for POST /2/object/department/getAutocomplete
    /// </summary>
    [DataContract]
    public partial class DepartmentGetAutocompleteV2ResponseMPayload :  IEquatable<DepartmentGetAutocompleteV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepartmentGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjDepartment">An array of Department autocomplete element response. (required).</param>
        public DepartmentGetAutocompleteV2ResponseMPayload(List<DepartmentAutocompleteElementResponse> aObjDepartment = default(List<DepartmentAutocompleteElementResponse>))
        {
            // to ensure "aObjDepartment" is required (not null)
            if (aObjDepartment == null)
            {
                throw new InvalidDataException("aObjDepartment is a required property for DepartmentGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjDepartment = aObjDepartment;
            }

        }

        /// <summary>
        /// An array of Department autocomplete element response.
        /// </summary>
        /// <value>An array of Department autocomplete element response.</value>
        [DataMember(Name="a_objDepartment", EmitDefaultValue=true)]
        public List<DepartmentAutocompleteElementResponse> AObjDepartment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepartmentGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjDepartment: ").Append(AObjDepartment).Append("\n");
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
            return this.Equals(input as DepartmentGetAutocompleteV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if DepartmentGetAutocompleteV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of DepartmentGetAutocompleteV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepartmentGetAutocompleteV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjDepartment == input.AObjDepartment ||
                    this.AObjDepartment != null &&
                    input.AObjDepartment != null &&
                    this.AObjDepartment.SequenceEqual(input.AObjDepartment)
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
                if (this.AObjDepartment != null)
                    hashCode = hashCode * 59 + this.AObjDepartment.GetHashCode();
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