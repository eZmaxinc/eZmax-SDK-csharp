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
    /// A Ezsigntemplate List Element
    /// </summary>
    [DataContract]
    public partial class EzsigntemplateListElement :  IEquatable<EzsigntemplateListElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateListElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplateListElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateListElement" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplateID">The unique ID of the Ezsigntemplate (required).</param>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype. (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sEzsigntemplateDescription">The description of the Ezsigntemplate (required).</param>
        /// <param name="iEzsigntemplatedocumentPagetotal">The number of pages in the Ezsigntemplatedocument..</param>
        /// <param name="iEzsigntemplateSignaturetotal">The number of total signatures in the Ezsigntemplate..</param>
        /// <param name="iEzsigntemplateFormfieldtotal">The number of total form fields in the Ezsigntemplate..</param>
        /// <param name="bEzsigntemplateIncomplete">Indicate the Ezsigntemplate is incomplete and cannot be used (required).</param>
        /// <param name="sEzsignfoldertypeNameX">The name of the Ezsignfoldertype in the language of the requester (required).</param>
        public EzsigntemplateListElement(int pkiEzsigntemplateID = default(int), int fkiEzsignfoldertypeID = default(int), int fkiLanguageID = default(int), string sEzsigntemplateDescription = default(string), int iEzsigntemplatedocumentPagetotal = default(int), int iEzsigntemplateSignaturetotal = default(int), int iEzsigntemplateFormfieldtotal = default(int), bool bEzsigntemplateIncomplete = default(bool), string sEzsignfoldertypeNameX = default(string))
        {
            // to ensure "pkiEzsigntemplateID" is required (not null)
            if (pkiEzsigntemplateID == null)
            {
                throw new InvalidDataException("pkiEzsigntemplateID is a required property for EzsigntemplateListElement and cannot be null");
            }
            else
            {
                this.PkiEzsigntemplateID = pkiEzsigntemplateID;
            }

            // to ensure "fkiEzsignfoldertypeID" is required (not null)
            if (fkiEzsignfoldertypeID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldertypeID is a required property for EzsigntemplateListElement and cannot be null");
            }
            else
            {
                this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            }

            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for EzsigntemplateListElement and cannot be null");
            }
            else
            {
                this.FkiLanguageID = fkiLanguageID;
            }

            // to ensure "sEzsigntemplateDescription" is required (not null)
            if (sEzsigntemplateDescription == null)
            {
                throw new InvalidDataException("sEzsigntemplateDescription is a required property for EzsigntemplateListElement and cannot be null");
            }
            else
            {
                this.SEzsigntemplateDescription = sEzsigntemplateDescription;
            }

            // to ensure "bEzsigntemplateIncomplete" is required (not null)
            if (bEzsigntemplateIncomplete == null)
            {
                throw new InvalidDataException("bEzsigntemplateIncomplete is a required property for EzsigntemplateListElement and cannot be null");
            }
            else
            {
                this.BEzsigntemplateIncomplete = bEzsigntemplateIncomplete;
            }

            // to ensure "sEzsignfoldertypeNameX" is required (not null)
            if (sEzsignfoldertypeNameX == null)
            {
                throw new InvalidDataException("sEzsignfoldertypeNameX is a required property for EzsigntemplateListElement and cannot be null");
            }
            else
            {
                this.SEzsignfoldertypeNameX = sEzsignfoldertypeNameX;
            }

            this.IEzsigntemplatedocumentPagetotal = iEzsigntemplatedocumentPagetotal;
            this.IEzsigntemplateSignaturetotal = iEzsigntemplateSignaturetotal;
            this.IEzsigntemplateFormfieldtotal = iEzsigntemplateFormfieldtotal;
        }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        [DataMember(Name="pkiEzsigntemplateID", EmitDefaultValue=true)]
        public int PkiEzsigntemplateID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.</value>
        [DataMember(Name="fkiEzsignfoldertypeID", EmitDefaultValue=true)]
        public int FkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// The description of the Ezsigntemplate
        /// </summary>
        /// <value>The description of the Ezsigntemplate</value>
        [DataMember(Name="sEzsigntemplateDescription", EmitDefaultValue=true)]
        public string SEzsigntemplateDescription { get; set; }

        /// <summary>
        /// The number of pages in the Ezsigntemplatedocument.
        /// </summary>
        /// <value>The number of pages in the Ezsigntemplatedocument.</value>
        [DataMember(Name="iEzsigntemplatedocumentPagetotal", EmitDefaultValue=false)]
        public int IEzsigntemplatedocumentPagetotal { get; set; }

        /// <summary>
        /// The number of total signatures in the Ezsigntemplate.
        /// </summary>
        /// <value>The number of total signatures in the Ezsigntemplate.</value>
        [DataMember(Name="iEzsigntemplateSignaturetotal", EmitDefaultValue=false)]
        public int IEzsigntemplateSignaturetotal { get; set; }

        /// <summary>
        /// The number of total form fields in the Ezsigntemplate.
        /// </summary>
        /// <value>The number of total form fields in the Ezsigntemplate.</value>
        [DataMember(Name="iEzsigntemplateFormfieldtotal", EmitDefaultValue=false)]
        public int IEzsigntemplateFormfieldtotal { get; set; }

        /// <summary>
        /// Indicate the Ezsigntemplate is incomplete and cannot be used
        /// </summary>
        /// <value>Indicate the Ezsigntemplate is incomplete and cannot be used</value>
        [DataMember(Name="bEzsigntemplateIncomplete", EmitDefaultValue=true)]
        public bool BEzsigntemplateIncomplete { get; set; }

        /// <summary>
        /// The name of the Ezsignfoldertype in the language of the requester
        /// </summary>
        /// <value>The name of the Ezsignfoldertype in the language of the requester</value>
        [DataMember(Name="sEzsignfoldertypeNameX", EmitDefaultValue=true)]
        public string SEzsignfoldertypeNameX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplateListElement {\n");
            sb.Append("  PkiEzsigntemplateID: ").Append(PkiEzsigntemplateID).Append("\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  SEzsigntemplateDescription: ").Append(SEzsigntemplateDescription).Append("\n");
            sb.Append("  IEzsigntemplatedocumentPagetotal: ").Append(IEzsigntemplatedocumentPagetotal).Append("\n");
            sb.Append("  IEzsigntemplateSignaturetotal: ").Append(IEzsigntemplateSignaturetotal).Append("\n");
            sb.Append("  IEzsigntemplateFormfieldtotal: ").Append(IEzsigntemplateFormfieldtotal).Append("\n");
            sb.Append("  BEzsigntemplateIncomplete: ").Append(BEzsigntemplateIncomplete).Append("\n");
            sb.Append("  SEzsignfoldertypeNameX: ").Append(SEzsignfoldertypeNameX).Append("\n");
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
            return this.Equals(input as EzsigntemplateListElement);
        }

        /// <summary>
        /// Returns true if EzsigntemplateListElement instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplateListElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplateListElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsigntemplateID == input.PkiEzsigntemplateID ||
                    (this.PkiEzsigntemplateID != null &&
                    this.PkiEzsigntemplateID.Equals(input.PkiEzsigntemplateID))
                ) && 
                (
                    this.FkiEzsignfoldertypeID == input.FkiEzsignfoldertypeID ||
                    (this.FkiEzsignfoldertypeID != null &&
                    this.FkiEzsignfoldertypeID.Equals(input.FkiEzsignfoldertypeID))
                ) && 
                (
                    this.FkiLanguageID == input.FkiLanguageID ||
                    (this.FkiLanguageID != null &&
                    this.FkiLanguageID.Equals(input.FkiLanguageID))
                ) && 
                (
                    this.SEzsigntemplateDescription == input.SEzsigntemplateDescription ||
                    (this.SEzsigntemplateDescription != null &&
                    this.SEzsigntemplateDescription.Equals(input.SEzsigntemplateDescription))
                ) && 
                (
                    this.IEzsigntemplatedocumentPagetotal == input.IEzsigntemplatedocumentPagetotal ||
                    (this.IEzsigntemplatedocumentPagetotal != null &&
                    this.IEzsigntemplatedocumentPagetotal.Equals(input.IEzsigntemplatedocumentPagetotal))
                ) && 
                (
                    this.IEzsigntemplateSignaturetotal == input.IEzsigntemplateSignaturetotal ||
                    (this.IEzsigntemplateSignaturetotal != null &&
                    this.IEzsigntemplateSignaturetotal.Equals(input.IEzsigntemplateSignaturetotal))
                ) && 
                (
                    this.IEzsigntemplateFormfieldtotal == input.IEzsigntemplateFormfieldtotal ||
                    (this.IEzsigntemplateFormfieldtotal != null &&
                    this.IEzsigntemplateFormfieldtotal.Equals(input.IEzsigntemplateFormfieldtotal))
                ) && 
                (
                    this.BEzsigntemplateIncomplete == input.BEzsigntemplateIncomplete ||
                    (this.BEzsigntemplateIncomplete != null &&
                    this.BEzsigntemplateIncomplete.Equals(input.BEzsigntemplateIncomplete))
                ) && 
                (
                    this.SEzsignfoldertypeNameX == input.SEzsignfoldertypeNameX ||
                    (this.SEzsignfoldertypeNameX != null &&
                    this.SEzsignfoldertypeNameX.Equals(input.SEzsignfoldertypeNameX))
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
                if (this.PkiEzsigntemplateID != null)
                    hashCode = hashCode * 59 + this.PkiEzsigntemplateID.GetHashCode();
                if (this.FkiEzsignfoldertypeID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfoldertypeID.GetHashCode();
                if (this.FkiLanguageID != null)
                    hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.SEzsigntemplateDescription != null)
                    hashCode = hashCode * 59 + this.SEzsigntemplateDescription.GetHashCode();
                if (this.IEzsigntemplatedocumentPagetotal != null)
                    hashCode = hashCode * 59 + this.IEzsigntemplatedocumentPagetotal.GetHashCode();
                if (this.IEzsigntemplateSignaturetotal != null)
                    hashCode = hashCode * 59 + this.IEzsigntemplateSignaturetotal.GetHashCode();
                if (this.IEzsigntemplateFormfieldtotal != null)
                    hashCode = hashCode * 59 + this.IEzsigntemplateFormfieldtotal.GetHashCode();
                if (this.BEzsigntemplateIncomplete != null)
                    hashCode = hashCode * 59 + this.BEzsigntemplateIncomplete.GetHashCode();
                if (this.SEzsignfoldertypeNameX != null)
                    hashCode = hashCode * 59 + this.SEzsignfoldertypeNameX.GetHashCode();
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


            // PkiEzsigntemplateID (int) minimum
            if(this.PkiEzsigntemplateID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsigntemplateID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplateID" });
            }



            // FkiEzsignfoldertypeID (int) minimum
            if(this.FkiEzsignfoldertypeID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignfoldertypeID, must be a value greater than or equal to 0.", new [] { "FkiEzsignfoldertypeID" });
            }



            // FkiLanguageID (int) maximum
            if(this.FkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value less than or equal to 2.", new [] { "FkiLanguageID" });
            }

            // FkiLanguageID (int) minimum
            if(this.FkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value greater than or equal to 1.", new [] { "FkiLanguageID" });
            }



            // IEzsigntemplatedocumentPagetotal (int) minimum
            if(this.IEzsigntemplatedocumentPagetotal < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzsigntemplatedocumentPagetotal, must be a value greater than or equal to 1.", new [] { "IEzsigntemplatedocumentPagetotal" });
            }

            yield break;
        }
    }

}
