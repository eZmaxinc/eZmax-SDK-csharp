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
    /// A Usergroup List Element
    /// </summary>
    [DataContract]
    public partial class UsergroupListElement :  IEquatable<UsergroupListElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupListElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupListElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupListElement" /> class.
        /// </summary>
        /// <param name="pkiUsergroupID">The unique ID of the Usergroup (required).</param>
        /// <param name="sUsergroupNameX">The Name of the Usergroup in the language of the requester (required).</param>
        /// <param name="iCountUser">Number of users in group (required).</param>
        public UsergroupListElement(int pkiUsergroupID = default(int), string sUsergroupNameX = default(string), int iCountUser = default(int))
        {
            // to ensure "pkiUsergroupID" is required (not null)
            if (pkiUsergroupID == null)
            {
                throw new InvalidDataException("pkiUsergroupID is a required property for UsergroupListElement and cannot be null");
            }
            else
            {
                this.PkiUsergroupID = pkiUsergroupID;
            }

            // to ensure "sUsergroupNameX" is required (not null)
            if (sUsergroupNameX == null)
            {
                throw new InvalidDataException("sUsergroupNameX is a required property for UsergroupListElement and cannot be null");
            }
            else
            {
                this.SUsergroupNameX = sUsergroupNameX;
            }

            // to ensure "iCountUser" is required (not null)
            if (iCountUser == null)
            {
                throw new InvalidDataException("iCountUser is a required property for UsergroupListElement and cannot be null");
            }
            else
            {
                this.ICountUser = iCountUser;
            }

        }

        /// <summary>
        /// The unique ID of the Usergroup
        /// </summary>
        /// <value>The unique ID of the Usergroup</value>
        [DataMember(Name="pkiUsergroupID", EmitDefaultValue=true)]
        public int PkiUsergroupID { get; set; }

        /// <summary>
        /// The Name of the Usergroup in the language of the requester
        /// </summary>
        /// <value>The Name of the Usergroup in the language of the requester</value>
        [DataMember(Name="sUsergroupNameX", EmitDefaultValue=true)]
        public string SUsergroupNameX { get; set; }

        /// <summary>
        /// Number of users in group
        /// </summary>
        /// <value>Number of users in group</value>
        [DataMember(Name="iCountUser", EmitDefaultValue=true)]
        public int ICountUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupListElement {\n");
            sb.Append("  PkiUsergroupID: ").Append(PkiUsergroupID).Append("\n");
            sb.Append("  SUsergroupNameX: ").Append(SUsergroupNameX).Append("\n");
            sb.Append("  ICountUser: ").Append(ICountUser).Append("\n");
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
            return this.Equals(input as UsergroupListElement);
        }

        /// <summary>
        /// Returns true if UsergroupListElement instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupListElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupListElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiUsergroupID == input.PkiUsergroupID ||
                    (this.PkiUsergroupID != null &&
                    this.PkiUsergroupID.Equals(input.PkiUsergroupID))
                ) && 
                (
                    this.SUsergroupNameX == input.SUsergroupNameX ||
                    (this.SUsergroupNameX != null &&
                    this.SUsergroupNameX.Equals(input.SUsergroupNameX))
                ) && 
                (
                    this.ICountUser == input.ICountUser ||
                    (this.ICountUser != null &&
                    this.ICountUser.Equals(input.ICountUser))
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
                if (this.PkiUsergroupID != null)
                    hashCode = hashCode * 59 + this.PkiUsergroupID.GetHashCode();
                if (this.SUsergroupNameX != null)
                    hashCode = hashCode * 59 + this.SUsergroupNameX.GetHashCode();
                if (this.ICountUser != null)
                    hashCode = hashCode * 59 + this.ICountUser.GetHashCode();
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


            // PkiUsergroupID (int) maximum
            if(this.PkiUsergroupID > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiUsergroupID, must be a value less than or equal to 255.", new [] { "PkiUsergroupID" });
            }

            // PkiUsergroupID (int) minimum
            if(this.PkiUsergroupID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiUsergroupID, must be a value greater than or equal to 0.", new [] { "PkiUsergroupID" });
            }



            // SUsergroupNameX (string) pattern
            Regex regexSUsergroupNameX = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
            if (false == regexSUsergroupNameX.Match(this.SUsergroupNameX).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SUsergroupNameX, must match a pattern of " + regexSUsergroupNameX, new [] { "SUsergroupNameX" });
            }



            // ICountUser (int) maximum
            if(this.ICountUser > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ICountUser, must be a value less than or equal to 16777215.", new [] { "ICountUser" });
            }

            // ICountUser (int) minimum
            if(this.ICountUser < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ICountUser, must be a value greater than or equal to 0.", new [] { "ICountUser" });
            }

            yield break;
        }
    }

}
