/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.3
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
    /// An Ezsignfolder List Element
    /// </summary>
    [DataContract]
    public partial class EzsignfolderListElement :  IEquatable<EzsignfolderListElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderListElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderListElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderListElement" /> class.
        /// </summary>
        /// <param name="pkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype. (required).</param>
        /// <param name="eEzsignfoldertypePrivacylevel">eEzsignfoldertypePrivacylevel (required).</param>
        /// <param name="sEzsignfoldertypeNameX">The name of the Ezsignfoldertype in the language of the requester (required).</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsign Folder (required).</param>
        /// <param name="eEzsignfolderStep">eEzsignfolderStep (required).</param>
        /// <param name="dtCreatedDate">The date and time at which the object was created (required).</param>
        /// <param name="dtEzsignfolderSentdate">dtEzsignfolderSentdate (required).</param>
        /// <param name="dtDueDate">The date at which no more signature will be accepted on the folder (required).</param>
        /// <param name="iTotalDocument">The total number of Ezsigndocument in the folder (required).</param>
        /// <param name="iTotalDocumentEdm">The total number of Ezsigndocument in the folder that were saved in the edm system (required).</param>
        /// <param name="iTotalSignature">The total number of signature blocks in all Ezsigndocuments in the folder (required).</param>
        /// <param name="iTotalSignatureSigned">The total number of already signed signature blocks in all Ezsigndocuments in the folder (required).</param>
        public EzsignfolderListElement(int pkiEzsignfolderID = default(int), int fkiEzsignfoldertypeID = default(int), FieldEEzsignfoldertypePrivacylevel eEzsignfoldertypePrivacylevel = default(FieldEEzsignfoldertypePrivacylevel), string sEzsignfoldertypeNameX = default(string), string sEzsignfolderDescription = default(string), FieldEEzsignfolderStep eEzsignfolderStep = default(FieldEEzsignfolderStep), string dtCreatedDate = default(string), OneOfstringobject dtEzsignfolderSentdate = default(OneOfstringobject), OneOfstringobject dtDueDate = default(OneOfstringobject), int iTotalDocument = default(int), int iTotalDocumentEdm = default(int), int iTotalSignature = default(int), int iTotalSignatureSigned = default(int))
        {
            // to ensure "pkiEzsignfolderID" is required (not null)
            if (pkiEzsignfolderID == null)
            {
                throw new InvalidDataException("pkiEzsignfolderID is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.PkiEzsignfolderID = pkiEzsignfolderID;
            }

            // to ensure "fkiEzsignfoldertypeID" is required (not null)
            if (fkiEzsignfoldertypeID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldertypeID is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            }

            // to ensure "eEzsignfoldertypePrivacylevel" is required (not null)
            if (eEzsignfoldertypePrivacylevel == null)
            {
                throw new InvalidDataException("eEzsignfoldertypePrivacylevel is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.EEzsignfoldertypePrivacylevel = eEzsignfoldertypePrivacylevel;
            }

            // to ensure "sEzsignfoldertypeNameX" is required (not null)
            if (sEzsignfoldertypeNameX == null)
            {
                throw new InvalidDataException("sEzsignfoldertypeNameX is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.SEzsignfoldertypeNameX = sEzsignfoldertypeNameX;
            }

            // to ensure "sEzsignfolderDescription" is required (not null)
            if (sEzsignfolderDescription == null)
            {
                throw new InvalidDataException("sEzsignfolderDescription is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.SEzsignfolderDescription = sEzsignfolderDescription;
            }

            // to ensure "eEzsignfolderStep" is required (not null)
            if (eEzsignfolderStep == null)
            {
                throw new InvalidDataException("eEzsignfolderStep is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.EEzsignfolderStep = eEzsignfolderStep;
            }

            // to ensure "dtCreatedDate" is required (not null)
            if (dtCreatedDate == null)
            {
                throw new InvalidDataException("dtCreatedDate is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.DtCreatedDate = dtCreatedDate;
            }

            // to ensure "dtEzsignfolderSentdate" is required (not null)
            if (dtEzsignfolderSentdate == null)
            {
                throw new InvalidDataException("dtEzsignfolderSentdate is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.DtEzsignfolderSentdate = dtEzsignfolderSentdate;
            }

            this.DtEzsignfolderSentdate = dtEzsignfolderSentdate;
            // to ensure "dtDueDate" is required (not null)
            if (dtDueDate == null)
            {
                throw new InvalidDataException("dtDueDate is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.DtDueDate = dtDueDate;
            }

            this.DtDueDate = dtDueDate;
            // to ensure "iTotalDocument" is required (not null)
            if (iTotalDocument == null)
            {
                throw new InvalidDataException("iTotalDocument is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.ITotalDocument = iTotalDocument;
            }

            // to ensure "iTotalDocumentEdm" is required (not null)
            if (iTotalDocumentEdm == null)
            {
                throw new InvalidDataException("iTotalDocumentEdm is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.ITotalDocumentEdm = iTotalDocumentEdm;
            }

            // to ensure "iTotalSignature" is required (not null)
            if (iTotalSignature == null)
            {
                throw new InvalidDataException("iTotalSignature is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.ITotalSignature = iTotalSignature;
            }

            // to ensure "iTotalSignatureSigned" is required (not null)
            if (iTotalSignatureSigned == null)
            {
                throw new InvalidDataException("iTotalSignatureSigned is a required property for EzsignfolderListElement and cannot be null");
            }
            else
            {
                this.ITotalSignatureSigned = iTotalSignatureSigned;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name="pkiEzsignfolderID", EmitDefaultValue=true)]
        public int PkiEzsignfolderID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.</value>
        [DataMember(Name="fkiEzsignfoldertypeID", EmitDefaultValue=true)]
        public int FkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// Gets or Sets EEzsignfoldertypePrivacylevel
        /// </summary>
        [DataMember(Name="eEzsignfoldertypePrivacylevel", EmitDefaultValue=true)]
        public FieldEEzsignfoldertypePrivacylevel EEzsignfoldertypePrivacylevel { get; set; }

        /// <summary>
        /// The name of the Ezsignfoldertype in the language of the requester
        /// </summary>
        /// <value>The name of the Ezsignfoldertype in the language of the requester</value>
        [DataMember(Name="sEzsignfoldertypeNameX", EmitDefaultValue=true)]
        public string SEzsignfoldertypeNameX { get; set; }

        /// <summary>
        /// The description of the Ezsign Folder
        /// </summary>
        /// <value>The description of the Ezsign Folder</value>
        [DataMember(Name="sEzsignfolderDescription", EmitDefaultValue=true)]
        public string SEzsignfolderDescription { get; set; }

        /// <summary>
        /// Gets or Sets EEzsignfolderStep
        /// </summary>
        [DataMember(Name="eEzsignfolderStep", EmitDefaultValue=true)]
        public FieldEEzsignfolderStep EEzsignfolderStep { get; set; }

        /// <summary>
        /// The date and time at which the object was created
        /// </summary>
        /// <value>The date and time at which the object was created</value>
        [DataMember(Name="dtCreatedDate", EmitDefaultValue=true)]
        public string DtCreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets DtEzsignfolderSentdate
        /// </summary>
        [DataMember(Name="dtEzsignfolderSentdate", EmitDefaultValue=true)]
        public OneOfstringobject DtEzsignfolderSentdate { get; set; }

        /// <summary>
        /// The date at which no more signature will be accepted on the folder
        /// </summary>
        /// <value>The date at which no more signature will be accepted on the folder</value>
        [DataMember(Name="dtDueDate", EmitDefaultValue=true)]
        public OneOfstringobject DtDueDate { get; set; }

        /// <summary>
        /// The total number of Ezsigndocument in the folder
        /// </summary>
        /// <value>The total number of Ezsigndocument in the folder</value>
        [DataMember(Name="iTotalDocument", EmitDefaultValue=true)]
        public int ITotalDocument { get; set; }

        /// <summary>
        /// The total number of Ezsigndocument in the folder that were saved in the edm system
        /// </summary>
        /// <value>The total number of Ezsigndocument in the folder that were saved in the edm system</value>
        [DataMember(Name="iTotalDocumentEdm", EmitDefaultValue=true)]
        public int ITotalDocumentEdm { get; set; }

        /// <summary>
        /// The total number of signature blocks in all Ezsigndocuments in the folder
        /// </summary>
        /// <value>The total number of signature blocks in all Ezsigndocuments in the folder</value>
        [DataMember(Name="iTotalSignature", EmitDefaultValue=true)]
        public int ITotalSignature { get; set; }

        /// <summary>
        /// The total number of already signed signature blocks in all Ezsigndocuments in the folder
        /// </summary>
        /// <value>The total number of already signed signature blocks in all Ezsigndocuments in the folder</value>
        [DataMember(Name="iTotalSignatureSigned", EmitDefaultValue=true)]
        public int ITotalSignatureSigned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderListElement {\n");
            sb.Append("  PkiEzsignfolderID: ").Append(PkiEzsignfolderID).Append("\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  EEzsignfoldertypePrivacylevel: ").Append(EEzsignfoldertypePrivacylevel).Append("\n");
            sb.Append("  SEzsignfoldertypeNameX: ").Append(SEzsignfoldertypeNameX).Append("\n");
            sb.Append("  SEzsignfolderDescription: ").Append(SEzsignfolderDescription).Append("\n");
            sb.Append("  EEzsignfolderStep: ").Append(EEzsignfolderStep).Append("\n");
            sb.Append("  DtCreatedDate: ").Append(DtCreatedDate).Append("\n");
            sb.Append("  DtEzsignfolderSentdate: ").Append(DtEzsignfolderSentdate).Append("\n");
            sb.Append("  DtDueDate: ").Append(DtDueDate).Append("\n");
            sb.Append("  ITotalDocument: ").Append(ITotalDocument).Append("\n");
            sb.Append("  ITotalDocumentEdm: ").Append(ITotalDocumentEdm).Append("\n");
            sb.Append("  ITotalSignature: ").Append(ITotalSignature).Append("\n");
            sb.Append("  ITotalSignatureSigned: ").Append(ITotalSignatureSigned).Append("\n");
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
            return this.Equals(input as EzsignfolderListElement);
        }

        /// <summary>
        /// Returns true if EzsignfolderListElement instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderListElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderListElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsignfolderID == input.PkiEzsignfolderID ||
                    (this.PkiEzsignfolderID != null &&
                    this.PkiEzsignfolderID.Equals(input.PkiEzsignfolderID))
                ) && 
                (
                    this.FkiEzsignfoldertypeID == input.FkiEzsignfoldertypeID ||
                    (this.FkiEzsignfoldertypeID != null &&
                    this.FkiEzsignfoldertypeID.Equals(input.FkiEzsignfoldertypeID))
                ) && 
                (
                    this.EEzsignfoldertypePrivacylevel == input.EEzsignfoldertypePrivacylevel ||
                    (this.EEzsignfoldertypePrivacylevel != null &&
                    this.EEzsignfoldertypePrivacylevel.Equals(input.EEzsignfoldertypePrivacylevel))
                ) && 
                (
                    this.SEzsignfoldertypeNameX == input.SEzsignfoldertypeNameX ||
                    (this.SEzsignfoldertypeNameX != null &&
                    this.SEzsignfoldertypeNameX.Equals(input.SEzsignfoldertypeNameX))
                ) && 
                (
                    this.SEzsignfolderDescription == input.SEzsignfolderDescription ||
                    (this.SEzsignfolderDescription != null &&
                    this.SEzsignfolderDescription.Equals(input.SEzsignfolderDescription))
                ) && 
                (
                    this.EEzsignfolderStep == input.EEzsignfolderStep ||
                    (this.EEzsignfolderStep != null &&
                    this.EEzsignfolderStep.Equals(input.EEzsignfolderStep))
                ) && 
                (
                    this.DtCreatedDate == input.DtCreatedDate ||
                    (this.DtCreatedDate != null &&
                    this.DtCreatedDate.Equals(input.DtCreatedDate))
                ) && 
                (
                    this.DtEzsignfolderSentdate == input.DtEzsignfolderSentdate ||
                    (this.DtEzsignfolderSentdate != null &&
                    this.DtEzsignfolderSentdate.Equals(input.DtEzsignfolderSentdate))
                ) && 
                (
                    this.DtDueDate == input.DtDueDate ||
                    (this.DtDueDate != null &&
                    this.DtDueDate.Equals(input.DtDueDate))
                ) && 
                (
                    this.ITotalDocument == input.ITotalDocument ||
                    (this.ITotalDocument != null &&
                    this.ITotalDocument.Equals(input.ITotalDocument))
                ) && 
                (
                    this.ITotalDocumentEdm == input.ITotalDocumentEdm ||
                    (this.ITotalDocumentEdm != null &&
                    this.ITotalDocumentEdm.Equals(input.ITotalDocumentEdm))
                ) && 
                (
                    this.ITotalSignature == input.ITotalSignature ||
                    (this.ITotalSignature != null &&
                    this.ITotalSignature.Equals(input.ITotalSignature))
                ) && 
                (
                    this.ITotalSignatureSigned == input.ITotalSignatureSigned ||
                    (this.ITotalSignatureSigned != null &&
                    this.ITotalSignatureSigned.Equals(input.ITotalSignatureSigned))
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
                if (this.PkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.PkiEzsignfolderID.GetHashCode();
                if (this.FkiEzsignfoldertypeID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfoldertypeID.GetHashCode();
                if (this.EEzsignfoldertypePrivacylevel != null)
                    hashCode = hashCode * 59 + this.EEzsignfoldertypePrivacylevel.GetHashCode();
                if (this.SEzsignfoldertypeNameX != null)
                    hashCode = hashCode * 59 + this.SEzsignfoldertypeNameX.GetHashCode();
                if (this.SEzsignfolderDescription != null)
                    hashCode = hashCode * 59 + this.SEzsignfolderDescription.GetHashCode();
                if (this.EEzsignfolderStep != null)
                    hashCode = hashCode * 59 + this.EEzsignfolderStep.GetHashCode();
                if (this.DtCreatedDate != null)
                    hashCode = hashCode * 59 + this.DtCreatedDate.GetHashCode();
                if (this.DtEzsignfolderSentdate != null)
                    hashCode = hashCode * 59 + this.DtEzsignfolderSentdate.GetHashCode();
                if (this.DtDueDate != null)
                    hashCode = hashCode * 59 + this.DtDueDate.GetHashCode();
                if (this.ITotalDocument != null)
                    hashCode = hashCode * 59 + this.ITotalDocument.GetHashCode();
                if (this.ITotalDocumentEdm != null)
                    hashCode = hashCode * 59 + this.ITotalDocumentEdm.GetHashCode();
                if (this.ITotalSignature != null)
                    hashCode = hashCode * 59 + this.ITotalSignature.GetHashCode();
                if (this.ITotalSignatureSigned != null)
                    hashCode = hashCode * 59 + this.ITotalSignatureSigned.GetHashCode();
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