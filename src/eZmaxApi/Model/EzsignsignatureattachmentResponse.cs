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
    /// An Ezsignsignatureattachment Object
    /// </summary>
    [DataContract]
    public partial class EzsignsignatureattachmentResponse :  IEquatable<EzsignsignatureattachmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureattachmentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignatureattachmentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureattachmentResponse" /> class.
        /// </summary>
        /// <param name="pkiEzsignsignatureattachmentID">The unique ID of the Ezsignsignatureattachment (required).</param>
        /// <param name="fkiEzsignsignatureID">The unique ID of the Ezsignsignature (required).</param>
        /// <param name="binEzsignsignatureattachmentMD5">The md5 of the Ezsignsignatureattachment (required).</param>
        /// <param name="sEzsignsignatureattachmentName">The name of the Ezsignsignatureattachment (required).</param>
        /// <param name="sDownloadUrl">The Url to the requested document.  Url will expire after 3 hours. (required).</param>
        public EzsignsignatureattachmentResponse(int pkiEzsignsignatureattachmentID = default(int), int fkiEzsignsignatureID = default(int), string binEzsignsignatureattachmentMD5 = default(string), string sEzsignsignatureattachmentName = default(string), string sDownloadUrl = default(string))
        {
            // to ensure "pkiEzsignsignatureattachmentID" is required (not null)
            if (pkiEzsignsignatureattachmentID == null)
            {
                throw new InvalidDataException("pkiEzsignsignatureattachmentID is a required property for EzsignsignatureattachmentResponse and cannot be null");
            }
            else
            {
                this.PkiEzsignsignatureattachmentID = pkiEzsignsignatureattachmentID;
            }

            // to ensure "fkiEzsignsignatureID" is required (not null)
            if (fkiEzsignsignatureID == null)
            {
                throw new InvalidDataException("fkiEzsignsignatureID is a required property for EzsignsignatureattachmentResponse and cannot be null");
            }
            else
            {
                this.FkiEzsignsignatureID = fkiEzsignsignatureID;
            }

            // to ensure "binEzsignsignatureattachmentMD5" is required (not null)
            if (binEzsignsignatureattachmentMD5 == null)
            {
                throw new InvalidDataException("binEzsignsignatureattachmentMD5 is a required property for EzsignsignatureattachmentResponse and cannot be null");
            }
            else
            {
                this.BinEzsignsignatureattachmentMD5 = binEzsignsignatureattachmentMD5;
            }

            // to ensure "sEzsignsignatureattachmentName" is required (not null)
            if (sEzsignsignatureattachmentName == null)
            {
                throw new InvalidDataException("sEzsignsignatureattachmentName is a required property for EzsignsignatureattachmentResponse and cannot be null");
            }
            else
            {
                this.SEzsignsignatureattachmentName = sEzsignsignatureattachmentName;
            }

            // to ensure "sDownloadUrl" is required (not null)
            if (sDownloadUrl == null)
            {
                throw new InvalidDataException("sDownloadUrl is a required property for EzsignsignatureattachmentResponse and cannot be null");
            }
            else
            {
                this.SDownloadUrl = sDownloadUrl;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsignsignatureattachment
        /// </summary>
        /// <value>The unique ID of the Ezsignsignatureattachment</value>
        [DataMember(Name="pkiEzsignsignatureattachmentID", EmitDefaultValue=true)]
        public int PkiEzsignsignatureattachmentID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignsignature
        /// </summary>
        /// <value>The unique ID of the Ezsignsignature</value>
        [DataMember(Name="fkiEzsignsignatureID", EmitDefaultValue=true)]
        public int FkiEzsignsignatureID { get; set; }

        /// <summary>
        /// The md5 of the Ezsignsignatureattachment
        /// </summary>
        /// <value>The md5 of the Ezsignsignatureattachment</value>
        [DataMember(Name="binEzsignsignatureattachmentMD5", EmitDefaultValue=true)]
        public string BinEzsignsignatureattachmentMD5 { get; set; }

        /// <summary>
        /// The name of the Ezsignsignatureattachment
        /// </summary>
        /// <value>The name of the Ezsignsignatureattachment</value>
        [DataMember(Name="sEzsignsignatureattachmentName", EmitDefaultValue=true)]
        public string SEzsignsignatureattachmentName { get; set; }

        /// <summary>
        /// The Url to the requested document.  Url will expire after 3 hours.
        /// </summary>
        /// <value>The Url to the requested document.  Url will expire after 3 hours.</value>
        [DataMember(Name="sDownloadUrl", EmitDefaultValue=true)]
        public string SDownloadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureattachmentResponse {\n");
            sb.Append("  PkiEzsignsignatureattachmentID: ").Append(PkiEzsignsignatureattachmentID).Append("\n");
            sb.Append("  FkiEzsignsignatureID: ").Append(FkiEzsignsignatureID).Append("\n");
            sb.Append("  BinEzsignsignatureattachmentMD5: ").Append(BinEzsignsignatureattachmentMD5).Append("\n");
            sb.Append("  SEzsignsignatureattachmentName: ").Append(SEzsignsignatureattachmentName).Append("\n");
            sb.Append("  SDownloadUrl: ").Append(SDownloadUrl).Append("\n");
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
            return this.Equals(input as EzsignsignatureattachmentResponse);
        }

        /// <summary>
        /// Returns true if EzsignsignatureattachmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignatureattachmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignatureattachmentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsignsignatureattachmentID == input.PkiEzsignsignatureattachmentID ||
                    (this.PkiEzsignsignatureattachmentID != null &&
                    this.PkiEzsignsignatureattachmentID.Equals(input.PkiEzsignsignatureattachmentID))
                ) && 
                (
                    this.FkiEzsignsignatureID == input.FkiEzsignsignatureID ||
                    (this.FkiEzsignsignatureID != null &&
                    this.FkiEzsignsignatureID.Equals(input.FkiEzsignsignatureID))
                ) && 
                (
                    this.BinEzsignsignatureattachmentMD5 == input.BinEzsignsignatureattachmentMD5 ||
                    (this.BinEzsignsignatureattachmentMD5 != null &&
                    this.BinEzsignsignatureattachmentMD5.Equals(input.BinEzsignsignatureattachmentMD5))
                ) && 
                (
                    this.SEzsignsignatureattachmentName == input.SEzsignsignatureattachmentName ||
                    (this.SEzsignsignatureattachmentName != null &&
                    this.SEzsignsignatureattachmentName.Equals(input.SEzsignsignatureattachmentName))
                ) && 
                (
                    this.SDownloadUrl == input.SDownloadUrl ||
                    (this.SDownloadUrl != null &&
                    this.SDownloadUrl.Equals(input.SDownloadUrl))
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
                if (this.PkiEzsignsignatureattachmentID != null)
                    hashCode = hashCode * 59 + this.PkiEzsignsignatureattachmentID.GetHashCode();
                if (this.FkiEzsignsignatureID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignsignatureID.GetHashCode();
                if (this.BinEzsignsignatureattachmentMD5 != null)
                    hashCode = hashCode * 59 + this.BinEzsignsignatureattachmentMD5.GetHashCode();
                if (this.SEzsignsignatureattachmentName != null)
                    hashCode = hashCode * 59 + this.SEzsignsignatureattachmentName.GetHashCode();
                if (this.SDownloadUrl != null)
                    hashCode = hashCode * 59 + this.SDownloadUrl.GetHashCode();
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


            // PkiEzsignsignatureattachmentID (int) maximum
            if(this.PkiEzsignsignatureattachmentID > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsignsignatureattachmentID, must be a value less than or equal to 16777215.", new [] { "PkiEzsignsignatureattachmentID" });
            }

            // PkiEzsignsignatureattachmentID (int) minimum
            if(this.PkiEzsignsignatureattachmentID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsignsignatureattachmentID, must be a value greater than or equal to 1.", new [] { "PkiEzsignsignatureattachmentID" });
            }



            // FkiEzsignsignatureID (int) minimum
            if(this.FkiEzsignsignatureID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignsignatureID, must be a value greater than or equal to 0.", new [] { "FkiEzsignsignatureID" });
            }



            // SEzsignsignatureattachmentName (string) pattern
            Regex regexSEzsignsignatureattachmentName = new Regex(@"^.{0,75}$", RegexOptions.CultureInvariant);
            if (false == regexSEzsignsignatureattachmentName.Match(this.SEzsignsignatureattachmentName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignsignatureattachmentName, must match a pattern of " + regexSEzsignsignatureattachmentName, new [] { "SEzsignsignatureattachmentName" });
            }

            yield break;
        }
    }

}