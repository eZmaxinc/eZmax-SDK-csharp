/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// A form Data Signer Object
    /// </summary>
    [DataContract]
    public partial class CustomFormDataSignerResponse :  IEquatable<CustomFormDataSignerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormDataSignerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomFormDataSignerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormDataSignerResponse" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldersignerassociationID">The unique ID of the Ezsignfoldersignerassociation (required).</param>
        /// <param name="fkiUserID">The unique ID of the User.</param>
        /// <param name="sContactFirstname">The First name of the contact (required).</param>
        /// <param name="sContactLastname">The Last name of the contact (required).</param>
        /// <param name="aObjEzsignformfieldgroupCompound">aObjEzsignformfieldgroupCompound (required).</param>
        public CustomFormDataSignerResponse(int fkiEzsignfoldersignerassociationID = default(int), int fkiUserID = default(int), string sContactFirstname = default(string), string sContactLastname = default(string), List<EzsignformfieldgroupResponseCompound> aObjEzsignformfieldgroupCompound = default(List<EzsignformfieldgroupResponseCompound>))
        {
            // to ensure "fkiEzsignfoldersignerassociationID" is required (not null)
            if (fkiEzsignfoldersignerassociationID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldersignerassociationID is a required property for CustomFormDataSignerResponse and cannot be null");
            }
            else
            {
                this.FkiEzsignfoldersignerassociationID = fkiEzsignfoldersignerassociationID;
            }

            // to ensure "sContactFirstname" is required (not null)
            if (sContactFirstname == null)
            {
                throw new InvalidDataException("sContactFirstname is a required property for CustomFormDataSignerResponse and cannot be null");
            }
            else
            {
                this.SContactFirstname = sContactFirstname;
            }

            // to ensure "sContactLastname" is required (not null)
            if (sContactLastname == null)
            {
                throw new InvalidDataException("sContactLastname is a required property for CustomFormDataSignerResponse and cannot be null");
            }
            else
            {
                this.SContactLastname = sContactLastname;
            }

            // to ensure "aObjEzsignformfieldgroupCompound" is required (not null)
            if (aObjEzsignformfieldgroupCompound == null)
            {
                throw new InvalidDataException("aObjEzsignformfieldgroupCompound is a required property for CustomFormDataSignerResponse and cannot be null");
            }
            else
            {
                this.AObjEzsignformfieldgroupCompound = aObjEzsignformfieldgroupCompound;
            }

            this.FkiUserID = fkiUserID;
        }

        /// <summary>
        /// The unique ID of the Ezsignfoldersignerassociation
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldersignerassociation</value>
        [DataMember(Name="fkiEzsignfoldersignerassociationID", EmitDefaultValue=true)]
        public int FkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name="fkiUserID", EmitDefaultValue=false)]
        public int FkiUserID { get; set; }

        /// <summary>
        /// The First name of the contact
        /// </summary>
        /// <value>The First name of the contact</value>
        [DataMember(Name="sContactFirstname", EmitDefaultValue=true)]
        public string SContactFirstname { get; set; }

        /// <summary>
        /// The Last name of the contact
        /// </summary>
        /// <value>The Last name of the contact</value>
        [DataMember(Name="sContactLastname", EmitDefaultValue=true)]
        public string SContactLastname { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsignformfieldgroupCompound
        /// </summary>
        [DataMember(Name="a_objEzsignformfieldgroupCompound", EmitDefaultValue=true)]
        public List<EzsignformfieldgroupResponseCompound> AObjEzsignformfieldgroupCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFormDataSignerResponse {\n");
            sb.Append("  FkiEzsignfoldersignerassociationID: ").Append(FkiEzsignfoldersignerassociationID).Append("\n");
            sb.Append("  FkiUserID: ").Append(FkiUserID).Append("\n");
            sb.Append("  SContactFirstname: ").Append(SContactFirstname).Append("\n");
            sb.Append("  SContactLastname: ").Append(SContactLastname).Append("\n");
            sb.Append("  AObjEzsignformfieldgroupCompound: ").Append(AObjEzsignformfieldgroupCompound).Append("\n");
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
            return this.Equals(input as CustomFormDataSignerResponse);
        }

        /// <summary>
        /// Returns true if CustomFormDataSignerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomFormDataSignerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFormDataSignerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiEzsignfoldersignerassociationID == input.FkiEzsignfoldersignerassociationID ||
                    (this.FkiEzsignfoldersignerassociationID != null &&
                    this.FkiEzsignfoldersignerassociationID.Equals(input.FkiEzsignfoldersignerassociationID))
                ) && 
                (
                    this.FkiUserID == input.FkiUserID ||
                    (this.FkiUserID != null &&
                    this.FkiUserID.Equals(input.FkiUserID))
                ) && 
                (
                    this.SContactFirstname == input.SContactFirstname ||
                    (this.SContactFirstname != null &&
                    this.SContactFirstname.Equals(input.SContactFirstname))
                ) && 
                (
                    this.SContactLastname == input.SContactLastname ||
                    (this.SContactLastname != null &&
                    this.SContactLastname.Equals(input.SContactLastname))
                ) && 
                (
                    this.AObjEzsignformfieldgroupCompound == input.AObjEzsignformfieldgroupCompound ||
                    this.AObjEzsignformfieldgroupCompound != null &&
                    input.AObjEzsignformfieldgroupCompound != null &&
                    this.AObjEzsignformfieldgroupCompound.SequenceEqual(input.AObjEzsignformfieldgroupCompound)
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
                if (this.FkiEzsignfoldersignerassociationID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfoldersignerassociationID.GetHashCode();
                if (this.FkiUserID != null)
                    hashCode = hashCode * 59 + this.FkiUserID.GetHashCode();
                if (this.SContactFirstname != null)
                    hashCode = hashCode * 59 + this.SContactFirstname.GetHashCode();
                if (this.SContactLastname != null)
                    hashCode = hashCode * 59 + this.SContactLastname.GetHashCode();
                if (this.AObjEzsignformfieldgroupCompound != null)
                    hashCode = hashCode * 59 + this.AObjEzsignformfieldgroupCompound.GetHashCode();
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