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
    /// A Usergroup AutocompleteElement Response
    /// </summary>
    [DataContract]
    public partial class UsergroupAutocompleteElementResponse :  IEquatable<UsergroupAutocompleteElementResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupAutocompleteElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupAutocompleteElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupAutocompleteElementResponse" /> class.
        /// </summary>
        /// <param name="sUsergroupNameX">The Name of the Usergroup in the language of the requester (required).</param>
        /// <param name="pkiUsergroupID">The unique ID of the Usergroup (required).</param>
        /// <param name="bUsergroupIsactive">Whether the Usergroup is active or not (required).</param>
        public UsergroupAutocompleteElementResponse(string sUsergroupNameX = default(string), int pkiUsergroupID = default(int), bool bUsergroupIsactive = default(bool))
        {
            // to ensure "sUsergroupNameX" is required (not null)
            if (sUsergroupNameX == null)
            {
                throw new InvalidDataException("sUsergroupNameX is a required property for UsergroupAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.SUsergroupNameX = sUsergroupNameX;
            }

            // to ensure "pkiUsergroupID" is required (not null)
            if (pkiUsergroupID == null)
            {
                throw new InvalidDataException("pkiUsergroupID is a required property for UsergroupAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.PkiUsergroupID = pkiUsergroupID;
            }

            // to ensure "bUsergroupIsactive" is required (not null)
            if (bUsergroupIsactive == null)
            {
                throw new InvalidDataException("bUsergroupIsactive is a required property for UsergroupAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.BUsergroupIsactive = bUsergroupIsactive;
            }

        }

        /// <summary>
        /// The Name of the Usergroup in the language of the requester
        /// </summary>
        /// <value>The Name of the Usergroup in the language of the requester</value>
        [DataMember(Name="sUsergroupNameX", EmitDefaultValue=true)]
        public string SUsergroupNameX { get; set; }

        /// <summary>
        /// The unique ID of the Usergroup
        /// </summary>
        /// <value>The unique ID of the Usergroup</value>
        [DataMember(Name="pkiUsergroupID", EmitDefaultValue=true)]
        public int PkiUsergroupID { get; set; }

        /// <summary>
        /// Whether the Usergroup is active or not
        /// </summary>
        /// <value>Whether the Usergroup is active or not</value>
        [DataMember(Name="bUsergroupIsactive", EmitDefaultValue=true)]
        public bool BUsergroupIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupAutocompleteElementResponse {\n");
            sb.Append("  SUsergroupNameX: ").Append(SUsergroupNameX).Append("\n");
            sb.Append("  PkiUsergroupID: ").Append(PkiUsergroupID).Append("\n");
            sb.Append("  BUsergroupIsactive: ").Append(BUsergroupIsactive).Append("\n");
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
            return this.Equals(input as UsergroupAutocompleteElementResponse);
        }

        /// <summary>
        /// Returns true if UsergroupAutocompleteElementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupAutocompleteElementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupAutocompleteElementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SUsergroupNameX == input.SUsergroupNameX ||
                    (this.SUsergroupNameX != null &&
                    this.SUsergroupNameX.Equals(input.SUsergroupNameX))
                ) && 
                (
                    this.PkiUsergroupID == input.PkiUsergroupID ||
                    (this.PkiUsergroupID != null &&
                    this.PkiUsergroupID.Equals(input.PkiUsergroupID))
                ) && 
                (
                    this.BUsergroupIsactive == input.BUsergroupIsactive ||
                    (this.BUsergroupIsactive != null &&
                    this.BUsergroupIsactive.Equals(input.BUsergroupIsactive))
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
                if (this.SUsergroupNameX != null)
                    hashCode = hashCode * 59 + this.SUsergroupNameX.GetHashCode();
                if (this.PkiUsergroupID != null)
                    hashCode = hashCode * 59 + this.PkiUsergroupID.GetHashCode();
                if (this.BUsergroupIsactive != null)
                    hashCode = hashCode * 59 + this.BUsergroupIsactive.GetHashCode();
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


            // PkiUsergroupID (int) minimum
            if(this.PkiUsergroupID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiUsergroupID, must be a value greater than or equal to 0.", new [] { "PkiUsergroupID" });
            }

            yield break;
        }
    }

}