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
    /// CustomEzsignformfieldRequestAllOf
    /// </summary>
    [DataContract]
    public partial class CustomEzsignformfieldRequestAllOf :  IEquatable<CustomEzsignformfieldRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignformfieldRequestAllOf" /> class.
        /// </summary>
        /// <param name="pkiEzsignformfieldID">The unique ID of the Ezsignformfield.</param>
        /// <param name="sEzsignformfieldLabel">The Label for the Ezsignformfield.</param>
        /// <param name="bEzsignformfieldSelected">Whether the Ezsignformfield is selected or not by default.  This can only be set if eEzsignformfieldgroupType is **Checkbox** or **Radio**.</param>
        /// <param name="sEzsignformfieldEnteredvalue">This is the value enterred for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is **Dropdown**, **Text** or **Textarea**.</param>
        public CustomEzsignformfieldRequestAllOf(int pkiEzsignformfieldID = default(int), string sEzsignformfieldLabel = default(string), bool bEzsignformfieldSelected = default(bool), string sEzsignformfieldEnteredvalue = default(string))
        {
            this.PkiEzsignformfieldID = pkiEzsignformfieldID;
            this.SEzsignformfieldLabel = sEzsignformfieldLabel;
            this.BEzsignformfieldSelected = bEzsignformfieldSelected;
            this.SEzsignformfieldEnteredvalue = sEzsignformfieldEnteredvalue;
        }

        /// <summary>
        /// The unique ID of the Ezsignformfield
        /// </summary>
        /// <value>The unique ID of the Ezsignformfield</value>
        [DataMember(Name="pkiEzsignformfieldID", EmitDefaultValue=false)]
        public int PkiEzsignformfieldID { get; set; }

        /// <summary>
        /// The Label for the Ezsignformfield
        /// </summary>
        /// <value>The Label for the Ezsignformfield</value>
        [DataMember(Name="sEzsignformfieldLabel", EmitDefaultValue=false)]
        public string SEzsignformfieldLabel { get; set; }

        /// <summary>
        /// Whether the Ezsignformfield is selected or not by default.  This can only be set if eEzsignformfieldgroupType is **Checkbox** or **Radio**
        /// </summary>
        /// <value>Whether the Ezsignformfield is selected or not by default.  This can only be set if eEzsignformfieldgroupType is **Checkbox** or **Radio**</value>
        [DataMember(Name="bEzsignformfieldSelected", EmitDefaultValue=false)]
        public bool BEzsignformfieldSelected { get; set; }

        /// <summary>
        /// This is the value enterred for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is **Dropdown**, **Text** or **Textarea**
        /// </summary>
        /// <value>This is the value enterred for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is **Dropdown**, **Text** or **Textarea**</value>
        [DataMember(Name="sEzsignformfieldEnteredvalue", EmitDefaultValue=false)]
        public string SEzsignformfieldEnteredvalue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEzsignformfieldRequestAllOf {\n");
            sb.Append("  PkiEzsignformfieldID: ").Append(PkiEzsignformfieldID).Append("\n");
            sb.Append("  SEzsignformfieldLabel: ").Append(SEzsignformfieldLabel).Append("\n");
            sb.Append("  BEzsignformfieldSelected: ").Append(BEzsignformfieldSelected).Append("\n");
            sb.Append("  SEzsignformfieldEnteredvalue: ").Append(SEzsignformfieldEnteredvalue).Append("\n");
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
            return this.Equals(input as CustomEzsignformfieldRequestAllOf);
        }

        /// <summary>
        /// Returns true if CustomEzsignformfieldRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEzsignformfieldRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEzsignformfieldRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsignformfieldID == input.PkiEzsignformfieldID ||
                    (this.PkiEzsignformfieldID != null &&
                    this.PkiEzsignformfieldID.Equals(input.PkiEzsignformfieldID))
                ) && 
                (
                    this.SEzsignformfieldLabel == input.SEzsignformfieldLabel ||
                    (this.SEzsignformfieldLabel != null &&
                    this.SEzsignformfieldLabel.Equals(input.SEzsignformfieldLabel))
                ) && 
                (
                    this.BEzsignformfieldSelected == input.BEzsignformfieldSelected ||
                    (this.BEzsignformfieldSelected != null &&
                    this.BEzsignformfieldSelected.Equals(input.BEzsignformfieldSelected))
                ) && 
                (
                    this.SEzsignformfieldEnteredvalue == input.SEzsignformfieldEnteredvalue ||
                    (this.SEzsignformfieldEnteredvalue != null &&
                    this.SEzsignformfieldEnteredvalue.Equals(input.SEzsignformfieldEnteredvalue))
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
                if (this.PkiEzsignformfieldID != null)
                    hashCode = hashCode * 59 + this.PkiEzsignformfieldID.GetHashCode();
                if (this.SEzsignformfieldLabel != null)
                    hashCode = hashCode * 59 + this.SEzsignformfieldLabel.GetHashCode();
                if (this.BEzsignformfieldSelected != null)
                    hashCode = hashCode * 59 + this.BEzsignformfieldSelected.GetHashCode();
                if (this.SEzsignformfieldEnteredvalue != null)
                    hashCode = hashCode * 59 + this.SEzsignformfieldEnteredvalue.GetHashCode();
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


            // PkiEzsignformfieldID (int) minimum
            if(this.PkiEzsignformfieldID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsignformfieldID, must be a value greater than or equal to 0.", new [] { "PkiEzsignformfieldID" });
            }

            yield break;
        }
    }

}