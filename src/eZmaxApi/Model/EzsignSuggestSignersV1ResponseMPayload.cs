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
    /// Payload for GET /1/module/ezsign/suggestSigners
    /// </summary>
    [DataContract(Name = "ezsign-suggestSigners-v1-Response-mPayload")]
    public partial class EzsignSuggestSignersV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignSuggestSignersV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignSuggestSignersV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignSuggestSignersV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsignfoldersignerassociation">aObjEzsignfoldersignerassociation (required).</param>
        /// <param name="aObjUserTeam">aObjUserTeam (required).</param>
        /// <param name="aObjUser">aObjUser (required).</param>
        public EzsignSuggestSignersV1ResponseMPayload(List<EzsignfoldersignerassociationResponseCompound> aObjEzsignfoldersignerassociation = default(List<EzsignfoldersignerassociationResponseCompound>), List<CustomUserResponse> aObjUserTeam = default(List<CustomUserResponse>), List<CustomUserResponse> aObjUser = default(List<CustomUserResponse>))
        {
            // to ensure "aObjEzsignfoldersignerassociation" is required (not null)
            if (aObjEzsignfoldersignerassociation == null)
            {
                throw new ArgumentNullException("aObjEzsignfoldersignerassociation is a required property for EzsignSuggestSignersV1ResponseMPayload and cannot be null");
            }
            this.AObjEzsignfoldersignerassociation = aObjEzsignfoldersignerassociation;
            // to ensure "aObjUserTeam" is required (not null)
            if (aObjUserTeam == null)
            {
                throw new ArgumentNullException("aObjUserTeam is a required property for EzsignSuggestSignersV1ResponseMPayload and cannot be null");
            }
            this.AObjUserTeam = aObjUserTeam;
            // to ensure "aObjUser" is required (not null)
            if (aObjUser == null)
            {
                throw new ArgumentNullException("aObjUser is a required property for EzsignSuggestSignersV1ResponseMPayload and cannot be null");
            }
            this.AObjUser = aObjUser;
        }

        /// <summary>
        /// Gets or Sets AObjEzsignfoldersignerassociation
        /// </summary>
        [DataMember(Name = "a_objEzsignfoldersignerassociation", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsignfoldersignerassociationResponseCompound> AObjEzsignfoldersignerassociation { get; set; }

        /// <summary>
        /// Gets or Sets AObjUserTeam
        /// </summary>
        [DataMember(Name = "a_objUserTeam", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomUserResponse> AObjUserTeam { get; set; }

        /// <summary>
        /// Gets or Sets AObjUser
        /// </summary>
        [DataMember(Name = "a_objUser", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomUserResponse> AObjUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignSuggestSignersV1ResponseMPayload {\n");
            sb.Append("  AObjEzsignfoldersignerassociation: ").Append(AObjEzsignfoldersignerassociation).Append("\n");
            sb.Append("  AObjUserTeam: ").Append(AObjUserTeam).Append("\n");
            sb.Append("  AObjUser: ").Append(AObjUser).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
