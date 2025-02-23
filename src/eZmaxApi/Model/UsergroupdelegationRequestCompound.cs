/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.1
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// A Usergroupdelegation Object and children
    /// </summary>
    [DataContract(Name = "usergroupdelegation-RequestCompound")]
    public partial class UsergroupdelegationRequestCompound : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupdelegationRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupdelegationRequestCompound" /> class.
        /// </summary>
        /// <param name="pkiUsergroupdelegationID">The unique ID of the Usergroupdelegation.</param>
        /// <param name="fkiUsergroupID">The unique ID of the Usergroup (required).</param>
        /// <param name="fkiUserID">The unique ID of the User (required).</param>
        public UsergroupdelegationRequestCompound(int pkiUsergroupdelegationID = default(int), int fkiUsergroupID = default(int), int fkiUserID = default(int))
        {
            this.FkiUsergroupID = fkiUsergroupID;
            this.FkiUserID = fkiUserID;
            this.PkiUsergroupdelegationID = pkiUsergroupdelegationID;
        }

        /// <summary>
        /// The unique ID of the Usergroupdelegation
        /// </summary>
        /// <value>The unique ID of the Usergroupdelegation</value>
        /* <example>141</example>*/
        [DataMember(Name = "pkiUsergroupdelegationID", EmitDefaultValue = false)]
        public int PkiUsergroupdelegationID { get; set; }

        /// <summary>
        /// The unique ID of the Usergroup
        /// </summary>
        /// <value>The unique ID of the Usergroup</value>
        /* <example>2</example>*/
        [DataMember(Name = "fkiUsergroupID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiUsergroupID { get; set; }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        /* <example>70</example>*/
        [DataMember(Name = "fkiUserID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiUserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsergroupdelegationRequestCompound {\n");
            sb.Append("  PkiUsergroupdelegationID: ").Append(PkiUsergroupdelegationID).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PkiUsergroupdelegationID (int) maximum
            if (this.PkiUsergroupdelegationID > (int)65535)
            {
                yield return new ValidationResult("Invalid value for PkiUsergroupdelegationID, must be a value less than or equal to 65535.", new [] { "PkiUsergroupdelegationID" });
            }

            // PkiUsergroupdelegationID (int) minimum
            if (this.PkiUsergroupdelegationID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiUsergroupdelegationID, must be a value greater than or equal to 0.", new [] { "PkiUsergroupdelegationID" });
            }

            // FkiUsergroupID (int) maximum
            if (this.FkiUsergroupID > (int)255)
            {
                yield return new ValidationResult("Invalid value for FkiUsergroupID, must be a value less than or equal to 255.", new [] { "FkiUsergroupID" });
            }

            // FkiUsergroupID (int) minimum
            if (this.FkiUsergroupID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiUsergroupID, must be a value greater than or equal to 0.", new [] { "FkiUsergroupID" });
            }

            // FkiUserID (int) minimum
            if (this.FkiUserID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiUserID, must be a value greater than or equal to 0.", new [] { "FkiUserID" });
            }

            yield break;
        }
    }

}
