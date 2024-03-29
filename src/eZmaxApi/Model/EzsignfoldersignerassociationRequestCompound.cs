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
    /// An Ezsignfoldersignerassociation Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class EzsignfoldersignerassociationRequestCompound :  IEquatable<EzsignfoldersignerassociationRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldersignerassociationRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationRequestCompound" /> class.
        /// </summary>
        /// <param name="pkiEzsignfoldersignerassociationID">The unique ID of the Ezsignfoldersignerassociation.</param>
        /// <param name="fkiUserID">The unique ID of the User.</param>
        /// <param name="fkiUsergroupID">The unique ID of the Usergroup.</param>
        /// <param name="fkiEzsignsignergroupID">The unique ID of the Ezsignsignergroup.</param>
        /// <param name="fkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="bEzsignfoldersignerassociationReceivecopy">If this flag is true. The signatory will receive a copy of every signed Ezsigndocument even if it ain&#39;t required to sign the document..</param>
        /// <param name="tEzsignfoldersignerassociationMessage">A custom text message that will be added to the email sent..</param>
        /// <param name="objEzsignsigner">objEzsignsigner.</param>
        public EzsignfoldersignerassociationRequestCompound(int pkiEzsignfoldersignerassociationID = default(int), int fkiUserID = default(int), int fkiUsergroupID = default(int), int fkiEzsignsignergroupID = default(int), int fkiEzsignfolderID = default(int), bool bEzsignfoldersignerassociationReceivecopy = default(bool), string tEzsignfoldersignerassociationMessage = default(string), EzsignsignerRequestCompound objEzsignsigner = default(EzsignsignerRequestCompound))
        {
            // to ensure "fkiEzsignfolderID" is required (not null)
            if (fkiEzsignfolderID == null)
            {
                throw new InvalidDataException("fkiEzsignfolderID is a required property for EzsignfoldersignerassociationRequestCompound and cannot be null");
            }
            else
            {
                this.FkiEzsignfolderID = fkiEzsignfolderID;
            }

            this.PkiEzsignfoldersignerassociationID = pkiEzsignfoldersignerassociationID;
            this.FkiUserID = fkiUserID;
            this.FkiUsergroupID = fkiUsergroupID;
            this.FkiEzsignsignergroupID = fkiEzsignsignergroupID;
            this.BEzsignfoldersignerassociationReceivecopy = bEzsignfoldersignerassociationReceivecopy;
            this.TEzsignfoldersignerassociationMessage = tEzsignfoldersignerassociationMessage;
            this.ObjEzsignsigner = objEzsignsigner;
        }

        /// <summary>
        /// The unique ID of the Ezsignfoldersignerassociation
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldersignerassociation</value>
        [DataMember(Name="pkiEzsignfoldersignerassociationID", EmitDefaultValue=false)]
        public int PkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name="fkiUserID", EmitDefaultValue=false)]
        public int FkiUserID { get; set; }

        /// <summary>
        /// The unique ID of the Usergroup
        /// </summary>
        /// <value>The unique ID of the Usergroup</value>
        [DataMember(Name="fkiUsergroupID", EmitDefaultValue=false)]
        public int FkiUsergroupID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignsignergroup
        /// </summary>
        /// <value>The unique ID of the Ezsignsignergroup</value>
        [DataMember(Name="fkiEzsignsignergroupID", EmitDefaultValue=false)]
        public int FkiEzsignsignergroupID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name="fkiEzsignfolderID", EmitDefaultValue=true)]
        public int FkiEzsignfolderID { get; set; }

        /// <summary>
        /// If this flag is true. The signatory will receive a copy of every signed Ezsigndocument even if it ain&#39;t required to sign the document.
        /// </summary>
        /// <value>If this flag is true. The signatory will receive a copy of every signed Ezsigndocument even if it ain&#39;t required to sign the document.</value>
        [DataMember(Name="bEzsignfoldersignerassociationReceivecopy", EmitDefaultValue=false)]
        public bool BEzsignfoldersignerassociationReceivecopy { get; set; }

        /// <summary>
        /// A custom text message that will be added to the email sent.
        /// </summary>
        /// <value>A custom text message that will be added to the email sent.</value>
        [DataMember(Name="tEzsignfoldersignerassociationMessage", EmitDefaultValue=false)]
        public string TEzsignfoldersignerassociationMessage { get; set; }

        /// <summary>
        /// Gets or Sets ObjEzsignsigner
        /// </summary>
        [DataMember(Name="objEzsignsigner", EmitDefaultValue=false)]
        public EzsignsignerRequestCompound ObjEzsignsigner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationRequestCompound {\n");
            sb.Append("  PkiEzsignfoldersignerassociationID: ").Append(PkiEzsignfoldersignerassociationID).Append("\n");
            sb.Append("  FkiUserID: ").Append(FkiUserID).Append("\n");
            sb.Append("  FkiUsergroupID: ").Append(FkiUsergroupID).Append("\n");
            sb.Append("  FkiEzsignsignergroupID: ").Append(FkiEzsignsignergroupID).Append("\n");
            sb.Append("  FkiEzsignfolderID: ").Append(FkiEzsignfolderID).Append("\n");
            sb.Append("  BEzsignfoldersignerassociationReceivecopy: ").Append(BEzsignfoldersignerassociationReceivecopy).Append("\n");
            sb.Append("  TEzsignfoldersignerassociationMessage: ").Append(TEzsignfoldersignerassociationMessage).Append("\n");
            sb.Append("  ObjEzsignsigner: ").Append(ObjEzsignsigner).Append("\n");
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
            return this.Equals(input as EzsignfoldersignerassociationRequestCompound);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsignfoldersignerassociationID == input.PkiEzsignfoldersignerassociationID ||
                    (this.PkiEzsignfoldersignerassociationID != null &&
                    this.PkiEzsignfoldersignerassociationID.Equals(input.PkiEzsignfoldersignerassociationID))
                ) && 
                (
                    this.FkiUserID == input.FkiUserID ||
                    (this.FkiUserID != null &&
                    this.FkiUserID.Equals(input.FkiUserID))
                ) && 
                (
                    this.FkiUsergroupID == input.FkiUsergroupID ||
                    (this.FkiUsergroupID != null &&
                    this.FkiUsergroupID.Equals(input.FkiUsergroupID))
                ) && 
                (
                    this.FkiEzsignsignergroupID == input.FkiEzsignsignergroupID ||
                    (this.FkiEzsignsignergroupID != null &&
                    this.FkiEzsignsignergroupID.Equals(input.FkiEzsignsignergroupID))
                ) && 
                (
                    this.FkiEzsignfolderID == input.FkiEzsignfolderID ||
                    (this.FkiEzsignfolderID != null &&
                    this.FkiEzsignfolderID.Equals(input.FkiEzsignfolderID))
                ) && 
                (
                    this.BEzsignfoldersignerassociationReceivecopy == input.BEzsignfoldersignerassociationReceivecopy ||
                    (this.BEzsignfoldersignerassociationReceivecopy != null &&
                    this.BEzsignfoldersignerassociationReceivecopy.Equals(input.BEzsignfoldersignerassociationReceivecopy))
                ) && 
                (
                    this.TEzsignfoldersignerassociationMessage == input.TEzsignfoldersignerassociationMessage ||
                    (this.TEzsignfoldersignerassociationMessage != null &&
                    this.TEzsignfoldersignerassociationMessage.Equals(input.TEzsignfoldersignerassociationMessage))
                ) && 
                (
                    this.ObjEzsignsigner == input.ObjEzsignsigner ||
                    (this.ObjEzsignsigner != null &&
                    this.ObjEzsignsigner.Equals(input.ObjEzsignsigner))
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
                if (this.PkiEzsignfoldersignerassociationID != null)
                    hashCode = hashCode * 59 + this.PkiEzsignfoldersignerassociationID.GetHashCode();
                if (this.FkiUserID != null)
                    hashCode = hashCode * 59 + this.FkiUserID.GetHashCode();
                if (this.FkiUsergroupID != null)
                    hashCode = hashCode * 59 + this.FkiUsergroupID.GetHashCode();
                if (this.FkiEzsignsignergroupID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignsignergroupID.GetHashCode();
                if (this.FkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfolderID.GetHashCode();
                if (this.BEzsignfoldersignerassociationReceivecopy != null)
                    hashCode = hashCode * 59 + this.BEzsignfoldersignerassociationReceivecopy.GetHashCode();
                if (this.TEzsignfoldersignerassociationMessage != null)
                    hashCode = hashCode * 59 + this.TEzsignfoldersignerassociationMessage.GetHashCode();
                if (this.ObjEzsignsigner != null)
                    hashCode = hashCode * 59 + this.ObjEzsignsigner.GetHashCode();
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


            // PkiEzsignfoldersignerassociationID (int) minimum
            if(this.PkiEzsignfoldersignerassociationID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsignfoldersignerassociationID, must be a value greater than or equal to 0.", new [] { "PkiEzsignfoldersignerassociationID" });
            }



            // FkiUserID (int) minimum
            if(this.FkiUserID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiUserID, must be a value greater than or equal to 0.", new [] { "FkiUserID" });
            }



            // FkiUsergroupID (int) maximum
            if(this.FkiUsergroupID > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiUsergroupID, must be a value less than or equal to 255.", new [] { "FkiUsergroupID" });
            }

            // FkiUsergroupID (int) minimum
            if(this.FkiUsergroupID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiUsergroupID, must be a value greater than or equal to 0.", new [] { "FkiUsergroupID" });
            }



            // FkiEzsignsignergroupID (int) maximum
            if(this.FkiEzsignsignergroupID > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignsignergroupID, must be a value less than or equal to 65535.", new [] { "FkiEzsignsignergroupID" });
            }

            // FkiEzsignsignergroupID (int) minimum
            if(this.FkiEzsignsignergroupID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignsignergroupID, must be a value greater than or equal to 0.", new [] { "FkiEzsignsignergroupID" });
            }



            // FkiEzsignfolderID (int) minimum
            if(this.FkiEzsignfolderID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignfolderID, must be a value greater than or equal to 0.", new [] { "FkiEzsignfolderID" });
            }

            yield break;
        }
    }

}
