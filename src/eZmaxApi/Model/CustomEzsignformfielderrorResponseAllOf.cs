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
    /// CustomEzsignformfielderrorResponseAllOf
    /// </summary>
    [DataContract]
    public partial class CustomEzsignformfielderrorResponseAllOf :  IEquatable<CustomEzsignformfielderrorResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignformfielderrorResponseAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEzsignformfielderrorResponseAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignformfielderrorResponseAllOf" /> class.
        /// </summary>
        /// <param name="sEzsignformfieldLabel">The Label for the Ezsignformfield (required).</param>
        /// <param name="aObjEzsignformfielderrortest">aObjEzsignformfielderrortest (required).</param>
        public CustomEzsignformfielderrorResponseAllOf(string sEzsignformfieldLabel = default(string), List<CustomEzsignformfielderrortestResponse> aObjEzsignformfielderrortest = default(List<CustomEzsignformfielderrortestResponse>))
        {
            // to ensure "sEzsignformfieldLabel" is required (not null)
            if (sEzsignformfieldLabel == null)
            {
                throw new InvalidDataException("sEzsignformfieldLabel is a required property for CustomEzsignformfielderrorResponseAllOf and cannot be null");
            }
            else
            {
                this.SEzsignformfieldLabel = sEzsignformfieldLabel;
            }

            // to ensure "aObjEzsignformfielderrortest" is required (not null)
            if (aObjEzsignformfielderrortest == null)
            {
                throw new InvalidDataException("aObjEzsignformfielderrortest is a required property for CustomEzsignformfielderrorResponseAllOf and cannot be null");
            }
            else
            {
                this.AObjEzsignformfielderrortest = aObjEzsignformfielderrortest;
            }

        }

        /// <summary>
        /// The Label for the Ezsignformfield
        /// </summary>
        /// <value>The Label for the Ezsignformfield</value>
        [DataMember(Name="sEzsignformfieldLabel", EmitDefaultValue=true)]
        public string SEzsignformfieldLabel { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsignformfielderrortest
        /// </summary>
        [DataMember(Name="a_objEzsignformfielderrortest", EmitDefaultValue=true)]
        public List<CustomEzsignformfielderrortestResponse> AObjEzsignformfielderrortest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEzsignformfielderrorResponseAllOf {\n");
            sb.Append("  SEzsignformfieldLabel: ").Append(SEzsignformfieldLabel).Append("\n");
            sb.Append("  AObjEzsignformfielderrortest: ").Append(AObjEzsignformfielderrortest).Append("\n");
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
            return this.Equals(input as CustomEzsignformfielderrorResponseAllOf);
        }

        /// <summary>
        /// Returns true if CustomEzsignformfielderrorResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEzsignformfielderrorResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEzsignformfielderrorResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SEzsignformfieldLabel == input.SEzsignformfieldLabel ||
                    (this.SEzsignformfieldLabel != null &&
                    this.SEzsignformfieldLabel.Equals(input.SEzsignformfieldLabel))
                ) && 
                (
                    this.AObjEzsignformfielderrortest == input.AObjEzsignformfielderrortest ||
                    this.AObjEzsignformfielderrortest != null &&
                    input.AObjEzsignformfielderrortest != null &&
                    this.AObjEzsignformfielderrortest.SequenceEqual(input.AObjEzsignformfielderrortest)
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
                if (this.SEzsignformfieldLabel != null)
                    hashCode = hashCode * 59 + this.SEzsignformfieldLabel.GetHashCode();
                if (this.AObjEzsignformfielderrortest != null)
                    hashCode = hashCode * 59 + this.AObjEzsignformfielderrortest.GetHashCode();
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
