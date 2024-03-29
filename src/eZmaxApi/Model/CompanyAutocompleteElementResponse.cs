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
    /// A Company AutocompleteElement Response
    /// </summary>
    [DataContract]
    public partial class CompanyAutocompleteElementResponse :  IEquatable<CompanyAutocompleteElementResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyAutocompleteElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyAutocompleteElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyAutocompleteElementResponse" /> class.
        /// </summary>
        /// <param name="pkiCompanyID">The unique ID of the Company (required).</param>
        /// <param name="sCompanyNameX">The Name of the Company in the language of the requester (required).</param>
        /// <param name="bCompanyIsactive">Whether the Company is active or not (required).</param>
        public CompanyAutocompleteElementResponse(int pkiCompanyID = default(int), string sCompanyNameX = default(string), bool bCompanyIsactive = default(bool))
        {
            // to ensure "pkiCompanyID" is required (not null)
            if (pkiCompanyID == null)
            {
                throw new InvalidDataException("pkiCompanyID is a required property for CompanyAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.PkiCompanyID = pkiCompanyID;
            }

            // to ensure "sCompanyNameX" is required (not null)
            if (sCompanyNameX == null)
            {
                throw new InvalidDataException("sCompanyNameX is a required property for CompanyAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.SCompanyNameX = sCompanyNameX;
            }

            // to ensure "bCompanyIsactive" is required (not null)
            if (bCompanyIsactive == null)
            {
                throw new InvalidDataException("bCompanyIsactive is a required property for CompanyAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.BCompanyIsactive = bCompanyIsactive;
            }

        }

        /// <summary>
        /// The unique ID of the Company
        /// </summary>
        /// <value>The unique ID of the Company</value>
        [DataMember(Name="pkiCompanyID", EmitDefaultValue=true)]
        public int PkiCompanyID { get; set; }

        /// <summary>
        /// The Name of the Company in the language of the requester
        /// </summary>
        /// <value>The Name of the Company in the language of the requester</value>
        [DataMember(Name="sCompanyNameX", EmitDefaultValue=true)]
        public string SCompanyNameX { get; set; }

        /// <summary>
        /// Whether the Company is active or not
        /// </summary>
        /// <value>Whether the Company is active or not</value>
        [DataMember(Name="bCompanyIsactive", EmitDefaultValue=true)]
        public bool BCompanyIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyAutocompleteElementResponse {\n");
            sb.Append("  PkiCompanyID: ").Append(PkiCompanyID).Append("\n");
            sb.Append("  SCompanyNameX: ").Append(SCompanyNameX).Append("\n");
            sb.Append("  BCompanyIsactive: ").Append(BCompanyIsactive).Append("\n");
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
            return this.Equals(input as CompanyAutocompleteElementResponse);
        }

        /// <summary>
        /// Returns true if CompanyAutocompleteElementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyAutocompleteElementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyAutocompleteElementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiCompanyID == input.PkiCompanyID ||
                    (this.PkiCompanyID != null &&
                    this.PkiCompanyID.Equals(input.PkiCompanyID))
                ) && 
                (
                    this.SCompanyNameX == input.SCompanyNameX ||
                    (this.SCompanyNameX != null &&
                    this.SCompanyNameX.Equals(input.SCompanyNameX))
                ) && 
                (
                    this.BCompanyIsactive == input.BCompanyIsactive ||
                    (this.BCompanyIsactive != null &&
                    this.BCompanyIsactive.Equals(input.BCompanyIsactive))
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
                if (this.PkiCompanyID != null)
                    hashCode = hashCode * 59 + this.PkiCompanyID.GetHashCode();
                if (this.SCompanyNameX != null)
                    hashCode = hashCode * 59 + this.SCompanyNameX.GetHashCode();
                if (this.BCompanyIsactive != null)
                    hashCode = hashCode * 59 + this.BCompanyIsactive.GetHashCode();
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


            // PkiCompanyID (int) maximum
            if(this.PkiCompanyID > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiCompanyID, must be a value less than or equal to 255.", new [] { "PkiCompanyID" });
            }

            // PkiCompanyID (int) minimum
            if(this.PkiCompanyID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiCompanyID, must be a value greater than or equal to 1.", new [] { "PkiCompanyID" });
            }

            yield break;
        }
    }

}
