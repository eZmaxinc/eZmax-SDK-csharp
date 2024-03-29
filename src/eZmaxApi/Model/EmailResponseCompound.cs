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
    /// An Email Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class EmailResponseCompound :  IEquatable<EmailResponseCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailResponseCompound" /> class.
        /// </summary>
        /// <param name="pkiEmailID">The unique ID of the Email (required).</param>
        /// <param name="fkiEmailtypeID">The unique ID of the Emailtype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| (required).</param>
        /// <param name="sEmailAddress">The email address. (required).</param>
        public EmailResponseCompound(int pkiEmailID = default(int), int fkiEmailtypeID = default(int), string sEmailAddress = default(string))
        {
            // to ensure "pkiEmailID" is required (not null)
            if (pkiEmailID == null)
            {
                throw new InvalidDataException("pkiEmailID is a required property for EmailResponseCompound and cannot be null");
            }
            else
            {
                this.PkiEmailID = pkiEmailID;
            }

            // to ensure "fkiEmailtypeID" is required (not null)
            if (fkiEmailtypeID == null)
            {
                throw new InvalidDataException("fkiEmailtypeID is a required property for EmailResponseCompound and cannot be null");
            }
            else
            {
                this.FkiEmailtypeID = fkiEmailtypeID;
            }

            // to ensure "sEmailAddress" is required (not null)
            if (sEmailAddress == null)
            {
                throw new InvalidDataException("sEmailAddress is a required property for EmailResponseCompound and cannot be null");
            }
            else
            {
                this.SEmailAddress = sEmailAddress;
            }

        }

        /// <summary>
        /// The unique ID of the Email
        /// </summary>
        /// <value>The unique ID of the Email</value>
        [DataMember(Name="pkiEmailID", EmitDefaultValue=true)]
        public int PkiEmailID { get; set; }

        /// <summary>
        /// The unique ID of the Emailtype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home|
        /// </summary>
        /// <value>The unique ID of the Emailtype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home|</value>
        [DataMember(Name="fkiEmailtypeID", EmitDefaultValue=true)]
        public int FkiEmailtypeID { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name="sEmailAddress", EmitDefaultValue=true)]
        public string SEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailResponseCompound {\n");
            sb.Append("  PkiEmailID: ").Append(PkiEmailID).Append("\n");
            sb.Append("  FkiEmailtypeID: ").Append(FkiEmailtypeID).Append("\n");
            sb.Append("  SEmailAddress: ").Append(SEmailAddress).Append("\n");
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
            return this.Equals(input as EmailResponseCompound);
        }

        /// <summary>
        /// Returns true if EmailResponseCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailResponseCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailResponseCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEmailID == input.PkiEmailID ||
                    (this.PkiEmailID != null &&
                    this.PkiEmailID.Equals(input.PkiEmailID))
                ) && 
                (
                    this.FkiEmailtypeID == input.FkiEmailtypeID ||
                    (this.FkiEmailtypeID != null &&
                    this.FkiEmailtypeID.Equals(input.FkiEmailtypeID))
                ) && 
                (
                    this.SEmailAddress == input.SEmailAddress ||
                    (this.SEmailAddress != null &&
                    this.SEmailAddress.Equals(input.SEmailAddress))
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
                if (this.PkiEmailID != null)
                    hashCode = hashCode * 59 + this.PkiEmailID.GetHashCode();
                if (this.FkiEmailtypeID != null)
                    hashCode = hashCode * 59 + this.FkiEmailtypeID.GetHashCode();
                if (this.SEmailAddress != null)
                    hashCode = hashCode * 59 + this.SEmailAddress.GetHashCode();
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


            // PkiEmailID (int) maximum
            if(this.PkiEmailID > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEmailID, must be a value less than or equal to 16777215.", new [] { "PkiEmailID" });
            }

            // PkiEmailID (int) minimum
            if(this.PkiEmailID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEmailID, must be a value greater than or equal to 1.", new [] { "PkiEmailID" });
            }



            // FkiEmailtypeID (int) minimum
            if(this.FkiEmailtypeID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEmailtypeID, must be a value greater than or equal to 0.", new [] { "FkiEmailtypeID" });
            }

            yield break;
        }
    }

}
