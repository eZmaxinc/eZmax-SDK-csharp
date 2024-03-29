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
    /// A Ezsigntemplatepackage Object
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatepackageResponse :  IEquatable<EzsigntemplatepackageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatepackageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackageResponse" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplatepackageID">The unique ID of the Ezsigntemplatepackage (required).</param>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype. (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sLanguageNameX">The Name of the Language in the language of the requester (required).</param>
        /// <param name="sEzsigntemplatepackageDescription">The description of the Ezsigntemplatepackage (required).</param>
        /// <param name="bEzsigntemplatepackageAdminonly">Whether the Ezsigntemplatepackage can be accessed by admin users only (eUserType&#x3D;Normal) (required).</param>
        /// <param name="bEzsigntemplatepackageNeedvalidation">Whether the Ezsignbulksend was automatically modified and needs a manual validation (required).</param>
        /// <param name="bEzsigntemplatepackageIsactive">Whether the Ezsigntemplatepackage is active or not (required).</param>
        /// <param name="sEzsignfoldertypeNameX">The name of the Ezsignfoldertype in the language of the requester (required).</param>
        public EzsigntemplatepackageResponse(int pkiEzsigntemplatepackageID = default(int), int fkiEzsignfoldertypeID = default(int), int fkiLanguageID = default(int), string sLanguageNameX = default(string), string sEzsigntemplatepackageDescription = default(string), bool bEzsigntemplatepackageAdminonly = default(bool), bool bEzsigntemplatepackageNeedvalidation = default(bool), bool bEzsigntemplatepackageIsactive = default(bool), string sEzsignfoldertypeNameX = default(string))
        {
            // to ensure "pkiEzsigntemplatepackageID" is required (not null)
            if (pkiEzsigntemplatepackageID == null)
            {
                throw new InvalidDataException("pkiEzsigntemplatepackageID is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.PkiEzsigntemplatepackageID = pkiEzsigntemplatepackageID;
            }

            // to ensure "fkiEzsignfoldertypeID" is required (not null)
            if (fkiEzsignfoldertypeID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldertypeID is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            }

            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.FkiLanguageID = fkiLanguageID;
            }

            // to ensure "sLanguageNameX" is required (not null)
            if (sLanguageNameX == null)
            {
                throw new InvalidDataException("sLanguageNameX is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.SLanguageNameX = sLanguageNameX;
            }

            // to ensure "sEzsigntemplatepackageDescription" is required (not null)
            if (sEzsigntemplatepackageDescription == null)
            {
                throw new InvalidDataException("sEzsigntemplatepackageDescription is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.SEzsigntemplatepackageDescription = sEzsigntemplatepackageDescription;
            }

            // to ensure "bEzsigntemplatepackageAdminonly" is required (not null)
            if (bEzsigntemplatepackageAdminonly == null)
            {
                throw new InvalidDataException("bEzsigntemplatepackageAdminonly is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.BEzsigntemplatepackageAdminonly = bEzsigntemplatepackageAdminonly;
            }

            // to ensure "bEzsigntemplatepackageNeedvalidation" is required (not null)
            if (bEzsigntemplatepackageNeedvalidation == null)
            {
                throw new InvalidDataException("bEzsigntemplatepackageNeedvalidation is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.BEzsigntemplatepackageNeedvalidation = bEzsigntemplatepackageNeedvalidation;
            }

            // to ensure "bEzsigntemplatepackageIsactive" is required (not null)
            if (bEzsigntemplatepackageIsactive == null)
            {
                throw new InvalidDataException("bEzsigntemplatepackageIsactive is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.BEzsigntemplatepackageIsactive = bEzsigntemplatepackageIsactive;
            }

            // to ensure "sEzsignfoldertypeNameX" is required (not null)
            if (sEzsignfoldertypeNameX == null)
            {
                throw new InvalidDataException("sEzsignfoldertypeNameX is a required property for EzsigntemplatepackageResponse and cannot be null");
            }
            else
            {
                this.SEzsignfoldertypeNameX = sEzsignfoldertypeNameX;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsigntemplatepackage
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatepackage</value>
        [DataMember(Name="pkiEzsigntemplatepackageID", EmitDefaultValue=true)]
        public int PkiEzsigntemplatepackageID { get; set; }

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
        /// The Name of the Language in the language of the requester
        /// </summary>
        /// <value>The Name of the Language in the language of the requester</value>
        [DataMember(Name="sLanguageNameX", EmitDefaultValue=true)]
        public string SLanguageNameX { get; set; }

        /// <summary>
        /// The description of the Ezsigntemplatepackage
        /// </summary>
        /// <value>The description of the Ezsigntemplatepackage</value>
        [DataMember(Name="sEzsigntemplatepackageDescription", EmitDefaultValue=true)]
        public string SEzsigntemplatepackageDescription { get; set; }

        /// <summary>
        /// Whether the Ezsigntemplatepackage can be accessed by admin users only (eUserType&#x3D;Normal)
        /// </summary>
        /// <value>Whether the Ezsigntemplatepackage can be accessed by admin users only (eUserType&#x3D;Normal)</value>
        [DataMember(Name="bEzsigntemplatepackageAdminonly", EmitDefaultValue=true)]
        public bool BEzsigntemplatepackageAdminonly { get; set; }

        /// <summary>
        /// Whether the Ezsignbulksend was automatically modified and needs a manual validation
        /// </summary>
        /// <value>Whether the Ezsignbulksend was automatically modified and needs a manual validation</value>
        [DataMember(Name="bEzsigntemplatepackageNeedvalidation", EmitDefaultValue=true)]
        public bool BEzsigntemplatepackageNeedvalidation { get; set; }

        /// <summary>
        /// Whether the Ezsigntemplatepackage is active or not
        /// </summary>
        /// <value>Whether the Ezsigntemplatepackage is active or not</value>
        [DataMember(Name="bEzsigntemplatepackageIsactive", EmitDefaultValue=true)]
        public bool BEzsigntemplatepackageIsactive { get; set; }

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
            sb.Append("class EzsigntemplatepackageResponse {\n");
            sb.Append("  PkiEzsigntemplatepackageID: ").Append(PkiEzsigntemplatepackageID).Append("\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  SLanguageNameX: ").Append(SLanguageNameX).Append("\n");
            sb.Append("  SEzsigntemplatepackageDescription: ").Append(SEzsigntemplatepackageDescription).Append("\n");
            sb.Append("  BEzsigntemplatepackageAdminonly: ").Append(BEzsigntemplatepackageAdminonly).Append("\n");
            sb.Append("  BEzsigntemplatepackageNeedvalidation: ").Append(BEzsigntemplatepackageNeedvalidation).Append("\n");
            sb.Append("  BEzsigntemplatepackageIsactive: ").Append(BEzsigntemplatepackageIsactive).Append("\n");
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
            return this.Equals(input as EzsigntemplatepackageResponse);
        }

        /// <summary>
        /// Returns true if EzsigntemplatepackageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatepackageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatepackageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsigntemplatepackageID == input.PkiEzsigntemplatepackageID ||
                    (this.PkiEzsigntemplatepackageID != null &&
                    this.PkiEzsigntemplatepackageID.Equals(input.PkiEzsigntemplatepackageID))
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
                    this.SLanguageNameX == input.SLanguageNameX ||
                    (this.SLanguageNameX != null &&
                    this.SLanguageNameX.Equals(input.SLanguageNameX))
                ) && 
                (
                    this.SEzsigntemplatepackageDescription == input.SEzsigntemplatepackageDescription ||
                    (this.SEzsigntemplatepackageDescription != null &&
                    this.SEzsigntemplatepackageDescription.Equals(input.SEzsigntemplatepackageDescription))
                ) && 
                (
                    this.BEzsigntemplatepackageAdminonly == input.BEzsigntemplatepackageAdminonly ||
                    (this.BEzsigntemplatepackageAdminonly != null &&
                    this.BEzsigntemplatepackageAdminonly.Equals(input.BEzsigntemplatepackageAdminonly))
                ) && 
                (
                    this.BEzsigntemplatepackageNeedvalidation == input.BEzsigntemplatepackageNeedvalidation ||
                    (this.BEzsigntemplatepackageNeedvalidation != null &&
                    this.BEzsigntemplatepackageNeedvalidation.Equals(input.BEzsigntemplatepackageNeedvalidation))
                ) && 
                (
                    this.BEzsigntemplatepackageIsactive == input.BEzsigntemplatepackageIsactive ||
                    (this.BEzsigntemplatepackageIsactive != null &&
                    this.BEzsigntemplatepackageIsactive.Equals(input.BEzsigntemplatepackageIsactive))
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
                if (this.PkiEzsigntemplatepackageID != null)
                    hashCode = hashCode * 59 + this.PkiEzsigntemplatepackageID.GetHashCode();
                if (this.FkiEzsignfoldertypeID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfoldertypeID.GetHashCode();
                if (this.FkiLanguageID != null)
                    hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.SLanguageNameX != null)
                    hashCode = hashCode * 59 + this.SLanguageNameX.GetHashCode();
                if (this.SEzsigntemplatepackageDescription != null)
                    hashCode = hashCode * 59 + this.SEzsigntemplatepackageDescription.GetHashCode();
                if (this.BEzsigntemplatepackageAdminonly != null)
                    hashCode = hashCode * 59 + this.BEzsigntemplatepackageAdminonly.GetHashCode();
                if (this.BEzsigntemplatepackageNeedvalidation != null)
                    hashCode = hashCode * 59 + this.BEzsigntemplatepackageNeedvalidation.GetHashCode();
                if (this.BEzsigntemplatepackageIsactive != null)
                    hashCode = hashCode * 59 + this.BEzsigntemplatepackageIsactive.GetHashCode();
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


            // PkiEzsigntemplatepackageID (int) minimum
            if(this.PkiEzsigntemplatepackageID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsigntemplatepackageID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplatepackageID" });
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

            yield break;
        }
    }

}
