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
    /// A Franchiseoffice AutocompleteElement Response
    /// </summary>
    [DataContract]
    public partial class FranchiseofficeAutocompleteElementResponse :  IEquatable<FranchiseofficeAutocompleteElementResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchiseofficeAutocompleteElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FranchiseofficeAutocompleteElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchiseofficeAutocompleteElementResponse" /> class.
        /// </summary>
        /// <param name="sFranchiseofficeDescription">The description of the Franchiseoffice in the language of the requester (required).</param>
        /// <param name="pkiFranchiseofficeID">The unique ID of the Franchisereoffice (required).</param>
        /// <param name="bFranchiseofficeIsactive">Whether the Franchiseoffice is active or not (required).</param>
        public FranchiseofficeAutocompleteElementResponse(string sFranchiseofficeDescription = default(string), int pkiFranchiseofficeID = default(int), bool bFranchiseofficeIsactive = default(bool))
        {
            // to ensure "sFranchiseofficeDescription" is required (not null)
            if (sFranchiseofficeDescription == null)
            {
                throw new InvalidDataException("sFranchiseofficeDescription is a required property for FranchiseofficeAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.SFranchiseofficeDescription = sFranchiseofficeDescription;
            }

            // to ensure "pkiFranchiseofficeID" is required (not null)
            if (pkiFranchiseofficeID == null)
            {
                throw new InvalidDataException("pkiFranchiseofficeID is a required property for FranchiseofficeAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.PkiFranchiseofficeID = pkiFranchiseofficeID;
            }

            // to ensure "bFranchiseofficeIsactive" is required (not null)
            if (bFranchiseofficeIsactive == null)
            {
                throw new InvalidDataException("bFranchiseofficeIsactive is a required property for FranchiseofficeAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.BFranchiseofficeIsactive = bFranchiseofficeIsactive;
            }

        }

        /// <summary>
        /// The description of the Franchiseoffice in the language of the requester
        /// </summary>
        /// <value>The description of the Franchiseoffice in the language of the requester</value>
        [DataMember(Name="sFranchiseofficeDescription", EmitDefaultValue=true)]
        public string SFranchiseofficeDescription { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereoffice
        /// </summary>
        /// <value>The unique ID of the Franchisereoffice</value>
        [DataMember(Name="pkiFranchiseofficeID", EmitDefaultValue=true)]
        public int PkiFranchiseofficeID { get; set; }

        /// <summary>
        /// Whether the Franchiseoffice is active or not
        /// </summary>
        /// <value>Whether the Franchiseoffice is active or not</value>
        [DataMember(Name="bFranchiseofficeIsactive", EmitDefaultValue=true)]
        public bool BFranchiseofficeIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchiseofficeAutocompleteElementResponse {\n");
            sb.Append("  SFranchiseofficeDescription: ").Append(SFranchiseofficeDescription).Append("\n");
            sb.Append("  PkiFranchiseofficeID: ").Append(PkiFranchiseofficeID).Append("\n");
            sb.Append("  BFranchiseofficeIsactive: ").Append(BFranchiseofficeIsactive).Append("\n");
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
            return this.Equals(input as FranchiseofficeAutocompleteElementResponse);
        }

        /// <summary>
        /// Returns true if FranchiseofficeAutocompleteElementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchiseofficeAutocompleteElementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchiseofficeAutocompleteElementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SFranchiseofficeDescription == input.SFranchiseofficeDescription ||
                    (this.SFranchiseofficeDescription != null &&
                    this.SFranchiseofficeDescription.Equals(input.SFranchiseofficeDescription))
                ) && 
                (
                    this.PkiFranchiseofficeID == input.PkiFranchiseofficeID ||
                    (this.PkiFranchiseofficeID != null &&
                    this.PkiFranchiseofficeID.Equals(input.PkiFranchiseofficeID))
                ) && 
                (
                    this.BFranchiseofficeIsactive == input.BFranchiseofficeIsactive ||
                    (this.BFranchiseofficeIsactive != null &&
                    this.BFranchiseofficeIsactive.Equals(input.BFranchiseofficeIsactive))
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
                if (this.SFranchiseofficeDescription != null)
                    hashCode = hashCode * 59 + this.SFranchiseofficeDescription.GetHashCode();
                if (this.PkiFranchiseofficeID != null)
                    hashCode = hashCode * 59 + this.PkiFranchiseofficeID.GetHashCode();
                if (this.BFranchiseofficeIsactive != null)
                    hashCode = hashCode * 59 + this.BFranchiseofficeIsactive.GetHashCode();
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


            // PkiFranchiseofficeID (int) minimum
            if(this.PkiFranchiseofficeID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiFranchiseofficeID, must be a value greater than or equal to 0.", new [] { "PkiFranchiseofficeID" });
            }

            yield break;
        }
    }

}