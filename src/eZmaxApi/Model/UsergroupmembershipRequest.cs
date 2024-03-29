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
    /// A Usergroupmembership Object
    /// </summary>
    [DataContract]
    public partial class UsergroupmembershipRequest :  IEquatable<UsergroupmembershipRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupmembershipRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupmembershipRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupmembershipRequest" /> class.
        /// </summary>
        /// <param name="pkiUsergroupmembershipID">The unique ID of the Usergroupmembership.</param>
        /// <param name="fkiUsergroupID">The unique ID of the Usergroup (required).</param>
        /// <param name="fkiUserID">The unique ID of the User (required).</param>
        public UsergroupmembershipRequest(int pkiUsergroupmembershipID = default(int), int fkiUsergroupID = default(int), int fkiUserID = default(int))
        {
            // to ensure "fkiUsergroupID" is required (not null)
            if (fkiUsergroupID == null)
            {
                throw new InvalidDataException("fkiUsergroupID is a required property for UsergroupmembershipRequest and cannot be null");
            }
            else
            {
                this.FkiUsergroupID = fkiUsergroupID;
            }

            // to ensure "fkiUserID" is required (not null)
            if (fkiUserID == null)
            {
                throw new InvalidDataException("fkiUserID is a required property for UsergroupmembershipRequest and cannot be null");
            }
            else
            {
                this.FkiUserID = fkiUserID;
            }

            this.PkiUsergroupmembershipID = pkiUsergroupmembershipID;
        }

        /// <summary>
        /// The unique ID of the Usergroupmembership
        /// </summary>
        /// <value>The unique ID of the Usergroupmembership</value>
        [DataMember(Name="pkiUsergroupmembershipID", EmitDefaultValue=false)]
        public int PkiUsergroupmembershipID { get; set; }

        /// <summary>
        /// The unique ID of the Usergroup
        /// </summary>
        /// <value>The unique ID of the Usergroup</value>
        [DataMember(Name="fkiUsergroupID", EmitDefaultValue=true)]
        public int FkiUsergroupID { get; set; }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name="fkiUserID", EmitDefaultValue=true)]
        public int FkiUserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsergroupmembershipRequest {\n");
            sb.Append("  PkiUsergroupmembershipID: ").Append(PkiUsergroupmembershipID).Append("\n");
            sb.Append("  FkiUsergroupID: ").Append(FkiUsergroupID).Append("\n");
            sb.Append("  FkiUserID: ").Append(FkiUserID).Append("\n");
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
            return this.Equals(input as UsergroupmembershipRequest);
        }

        /// <summary>
        /// Returns true if UsergroupmembershipRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UsergroupmembershipRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsergroupmembershipRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiUsergroupmembershipID == input.PkiUsergroupmembershipID ||
                    (this.PkiUsergroupmembershipID != null &&
                    this.PkiUsergroupmembershipID.Equals(input.PkiUsergroupmembershipID))
                ) && 
                (
                    this.FkiUsergroupID == input.FkiUsergroupID ||
                    (this.FkiUsergroupID != null &&
                    this.FkiUsergroupID.Equals(input.FkiUsergroupID))
                ) && 
                (
                    this.FkiUserID == input.FkiUserID ||
                    (this.FkiUserID != null &&
                    this.FkiUserID.Equals(input.FkiUserID))
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
                if (this.PkiUsergroupmembershipID != null)
                    hashCode = hashCode * 59 + this.PkiUsergroupmembershipID.GetHashCode();
                if (this.FkiUsergroupID != null)
                    hashCode = hashCode * 59 + this.FkiUsergroupID.GetHashCode();
                if (this.FkiUserID != null)
                    hashCode = hashCode * 59 + this.FkiUserID.GetHashCode();
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


            // PkiUsergroupmembershipID (int) maximum
            if(this.PkiUsergroupmembershipID > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiUsergroupmembershipID, must be a value less than or equal to 65535.", new [] { "PkiUsergroupmembershipID" });
            }

            // PkiUsergroupmembershipID (int) minimum
            if(this.PkiUsergroupmembershipID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiUsergroupmembershipID, must be a value greater than or equal to 0.", new [] { "PkiUsergroupmembershipID" });
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



            // FkiUserID (int) minimum
            if(this.FkiUserID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiUserID, must be a value greater than or equal to 0.", new [] { "FkiUserID" });
            }

            yield break;
        }
    }

}
