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
    /// CustomEzsignformfieldgroupRequestAllOf
    /// </summary>
    [DataContract]
    public partial class CustomEzsignformfieldgroupRequestAllOf :  IEquatable<CustomEzsignformfieldgroupRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignformfieldgroupRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEzsignformfieldgroupRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignformfieldgroupRequestAllOf" /> class.
        /// </summary>
        /// <param name="pkiEzsignformfieldgroupID">The unique ID of the Ezsignformfieldgroup.</param>
        /// <param name="sEzsignformfieldgroupLabel">The Label for the Ezsignformfieldgroup.</param>
        /// <param name="aObjEzsignformfield">An array containing all the values to fill the Ezsignform. (required).</param>
        public CustomEzsignformfieldgroupRequestAllOf(int pkiEzsignformfieldgroupID = default(int), string sEzsignformfieldgroupLabel = default(string), List<CustomEzsignformfieldRequest> aObjEzsignformfield = default(List<CustomEzsignformfieldRequest>))
        {
            // to ensure "aObjEzsignformfield" is required (not null)
            if (aObjEzsignformfield == null)
            {
                throw new InvalidDataException("aObjEzsignformfield is a required property for CustomEzsignformfieldgroupRequestAllOf and cannot be null");
            }
            else
            {
                this.AObjEzsignformfield = aObjEzsignformfield;
            }

            this.PkiEzsignformfieldgroupID = pkiEzsignformfieldgroupID;
            this.SEzsignformfieldgroupLabel = sEzsignformfieldgroupLabel;
        }

        /// <summary>
        /// The unique ID of the Ezsignformfieldgroup
        /// </summary>
        /// <value>The unique ID of the Ezsignformfieldgroup</value>
        [DataMember(Name="pkiEzsignformfieldgroupID", EmitDefaultValue=false)]
        public int PkiEzsignformfieldgroupID { get; set; }

        /// <summary>
        /// The Label for the Ezsignformfieldgroup
        /// </summary>
        /// <value>The Label for the Ezsignformfieldgroup</value>
        [DataMember(Name="sEzsignformfieldgroupLabel", EmitDefaultValue=false)]
        public string SEzsignformfieldgroupLabel { get; set; }

        /// <summary>
        /// An array containing all the values to fill the Ezsignform.
        /// </summary>
        /// <value>An array containing all the values to fill the Ezsignform.</value>
        [DataMember(Name="a_objEzsignformfield", EmitDefaultValue=true)]
        public List<CustomEzsignformfieldRequest> AObjEzsignformfield { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEzsignformfieldgroupRequestAllOf {\n");
            sb.Append("  PkiEzsignformfieldgroupID: ").Append(PkiEzsignformfieldgroupID).Append("\n");
            sb.Append("  SEzsignformfieldgroupLabel: ").Append(SEzsignformfieldgroupLabel).Append("\n");
            sb.Append("  AObjEzsignformfield: ").Append(AObjEzsignformfield).Append("\n");
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
            return this.Equals(input as CustomEzsignformfieldgroupRequestAllOf);
        }

        /// <summary>
        /// Returns true if CustomEzsignformfieldgroupRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEzsignformfieldgroupRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEzsignformfieldgroupRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsignformfieldgroupID == input.PkiEzsignformfieldgroupID ||
                    (this.PkiEzsignformfieldgroupID != null &&
                    this.PkiEzsignformfieldgroupID.Equals(input.PkiEzsignformfieldgroupID))
                ) && 
                (
                    this.SEzsignformfieldgroupLabel == input.SEzsignformfieldgroupLabel ||
                    (this.SEzsignformfieldgroupLabel != null &&
                    this.SEzsignformfieldgroupLabel.Equals(input.SEzsignformfieldgroupLabel))
                ) && 
                (
                    this.AObjEzsignformfield == input.AObjEzsignformfield ||
                    this.AObjEzsignformfield != null &&
                    input.AObjEzsignformfield != null &&
                    this.AObjEzsignformfield.SequenceEqual(input.AObjEzsignformfield)
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
                if (this.PkiEzsignformfieldgroupID != null)
                    hashCode = hashCode * 59 + this.PkiEzsignformfieldgroupID.GetHashCode();
                if (this.SEzsignformfieldgroupLabel != null)
                    hashCode = hashCode * 59 + this.SEzsignformfieldgroupLabel.GetHashCode();
                if (this.AObjEzsignformfield != null)
                    hashCode = hashCode * 59 + this.AObjEzsignformfield.GetHashCode();
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


            // PkiEzsignformfieldgroupID (int) minimum
            if(this.PkiEzsignformfieldgroupID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsignformfieldgroupID, must be a value greater than or equal to 0.", new [] { "PkiEzsignformfieldgroupID" });
            }

            // SEzsignformfieldgroupLabel (string) maxLength
            if(this.SEzsignformfieldgroupLabel != null && this.SEzsignformfieldgroupLabel.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignformfieldgroupLabel, length must be less than 50.", new [] { "SEzsignformfieldgroupLabel" });
            }

            // SEzsignformfieldgroupLabel (string) minLength
            if(this.SEzsignformfieldgroupLabel != null && this.SEzsignformfieldgroupLabel.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignformfieldgroupLabel, length must be greater than 1.", new [] { "SEzsignformfieldgroupLabel" });
            }



            yield break;
        }
    }

}