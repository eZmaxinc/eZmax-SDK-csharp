/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// A Branding List Element
    /// </summary>
    [DataContract]
    public partial class ApikeyListElement :  IEquatable<ApikeyListElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyListElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApikeyListElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyListElement" /> class.
        /// </summary>
        /// <param name="pkiApikeyID">The unique ID of the Apikey (required).</param>
        /// <param name="sApikeyDescriptionX">The description of the Apikey in the language of the requester (required).</param>
        /// <param name="sUserFirstname">The first name of the user (required).</param>
        /// <param name="sUserLastname">The last name of the user (required).</param>
        /// <param name="bApikeyIsactive">Whether the apikey is active or not (required).</param>
        /// <param name="bApikeyIssigned">Whether the apikey is signed or not (required).</param>
        public ApikeyListElement(int pkiApikeyID = default(int), string sApikeyDescriptionX = default(string), string sUserFirstname = default(string), string sUserLastname = default(string), bool bApikeyIsactive = default(bool), bool bApikeyIssigned = default(bool))
        {
            // to ensure "pkiApikeyID" is required (not null)
            if (pkiApikeyID == null)
            {
                throw new InvalidDataException("pkiApikeyID is a required property for ApikeyListElement and cannot be null");
            }
            else
            {
                this.PkiApikeyID = pkiApikeyID;
            }

            // to ensure "sApikeyDescriptionX" is required (not null)
            if (sApikeyDescriptionX == null)
            {
                throw new InvalidDataException("sApikeyDescriptionX is a required property for ApikeyListElement and cannot be null");
            }
            else
            {
                this.SApikeyDescriptionX = sApikeyDescriptionX;
            }

            // to ensure "sUserFirstname" is required (not null)
            if (sUserFirstname == null)
            {
                throw new InvalidDataException("sUserFirstname is a required property for ApikeyListElement and cannot be null");
            }
            else
            {
                this.SUserFirstname = sUserFirstname;
            }

            // to ensure "sUserLastname" is required (not null)
            if (sUserLastname == null)
            {
                throw new InvalidDataException("sUserLastname is a required property for ApikeyListElement and cannot be null");
            }
            else
            {
                this.SUserLastname = sUserLastname;
            }

            // to ensure "bApikeyIsactive" is required (not null)
            if (bApikeyIsactive == null)
            {
                throw new InvalidDataException("bApikeyIsactive is a required property for ApikeyListElement and cannot be null");
            }
            else
            {
                this.BApikeyIsactive = bApikeyIsactive;
            }

            // to ensure "bApikeyIssigned" is required (not null)
            if (bApikeyIssigned == null)
            {
                throw new InvalidDataException("bApikeyIssigned is a required property for ApikeyListElement and cannot be null");
            }
            else
            {
                this.BApikeyIssigned = bApikeyIssigned;
            }

        }

        /// <summary>
        /// The unique ID of the Apikey
        /// </summary>
        /// <value>The unique ID of the Apikey</value>
        [DataMember(Name="pkiApikeyID", EmitDefaultValue=true)]
        public int PkiApikeyID { get; set; }

        /// <summary>
        /// The description of the Apikey in the language of the requester
        /// </summary>
        /// <value>The description of the Apikey in the language of the requester</value>
        [DataMember(Name="sApikeyDescriptionX", EmitDefaultValue=true)]
        public string SApikeyDescriptionX { get; set; }

        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        [DataMember(Name="sUserFirstname", EmitDefaultValue=true)]
        public string SUserFirstname { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        [DataMember(Name="sUserLastname", EmitDefaultValue=true)]
        public string SUserLastname { get; set; }

        /// <summary>
        /// Whether the apikey is active or not
        /// </summary>
        /// <value>Whether the apikey is active or not</value>
        [DataMember(Name="bApikeyIsactive", EmitDefaultValue=true)]
        public bool BApikeyIsactive { get; set; }

        /// <summary>
        /// Whether the apikey is signed or not
        /// </summary>
        /// <value>Whether the apikey is signed or not</value>
        [DataMember(Name="bApikeyIssigned", EmitDefaultValue=true)]
        public bool BApikeyIssigned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApikeyListElement {\n");
            sb.Append("  PkiApikeyID: ").Append(PkiApikeyID).Append("\n");
            sb.Append("  SApikeyDescriptionX: ").Append(SApikeyDescriptionX).Append("\n");
            sb.Append("  SUserFirstname: ").Append(SUserFirstname).Append("\n");
            sb.Append("  SUserLastname: ").Append(SUserLastname).Append("\n");
            sb.Append("  BApikeyIsactive: ").Append(BApikeyIsactive).Append("\n");
            sb.Append("  BApikeyIssigned: ").Append(BApikeyIssigned).Append("\n");
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
            return this.Equals(input as ApikeyListElement);
        }

        /// <summary>
        /// Returns true if ApikeyListElement instances are equal
        /// </summary>
        /// <param name="input">Instance of ApikeyListElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApikeyListElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiApikeyID == input.PkiApikeyID ||
                    (this.PkiApikeyID != null &&
                    this.PkiApikeyID.Equals(input.PkiApikeyID))
                ) && 
                (
                    this.SApikeyDescriptionX == input.SApikeyDescriptionX ||
                    (this.SApikeyDescriptionX != null &&
                    this.SApikeyDescriptionX.Equals(input.SApikeyDescriptionX))
                ) && 
                (
                    this.SUserFirstname == input.SUserFirstname ||
                    (this.SUserFirstname != null &&
                    this.SUserFirstname.Equals(input.SUserFirstname))
                ) && 
                (
                    this.SUserLastname == input.SUserLastname ||
                    (this.SUserLastname != null &&
                    this.SUserLastname.Equals(input.SUserLastname))
                ) && 
                (
                    this.BApikeyIsactive == input.BApikeyIsactive ||
                    (this.BApikeyIsactive != null &&
                    this.BApikeyIsactive.Equals(input.BApikeyIsactive))
                ) && 
                (
                    this.BApikeyIssigned == input.BApikeyIssigned ||
                    (this.BApikeyIssigned != null &&
                    this.BApikeyIssigned.Equals(input.BApikeyIssigned))
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
                if (this.PkiApikeyID != null)
                    hashCode = hashCode * 59 + this.PkiApikeyID.GetHashCode();
                if (this.SApikeyDescriptionX != null)
                    hashCode = hashCode * 59 + this.SApikeyDescriptionX.GetHashCode();
                if (this.SUserFirstname != null)
                    hashCode = hashCode * 59 + this.SUserFirstname.GetHashCode();
                if (this.SUserLastname != null)
                    hashCode = hashCode * 59 + this.SUserLastname.GetHashCode();
                if (this.BApikeyIsactive != null)
                    hashCode = hashCode * 59 + this.BApikeyIsactive.GetHashCode();
                if (this.BApikeyIssigned != null)
                    hashCode = hashCode * 59 + this.BApikeyIssigned.GetHashCode();
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


            // PkiApikeyID (int) minimum
            if(this.PkiApikeyID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiApikeyID, must be a value greater than or equal to 0.", new [] { "PkiApikeyID" });
            }

            yield break;
        }
    }

}