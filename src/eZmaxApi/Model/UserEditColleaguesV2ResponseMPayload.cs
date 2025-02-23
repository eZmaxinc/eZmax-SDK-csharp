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
    /// Payload for PUT /2/object/user/{pkiUserID}/editColleagues
    /// </summary>
    [DataContract(Name = "user-editColleagues-v2-Response-mPayload")]
    public partial class UserEditColleaguesV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEditColleaguesV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserEditColleaguesV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEditColleaguesV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiColleagueID">aPkiColleagueID (required).</param>
        public UserEditColleaguesV2ResponseMPayload(List<int> aPkiColleagueID = default(List<int>))
        {
            // to ensure "aPkiColleagueID" is required (not null)
            if (aPkiColleagueID == null)
            {
                throw new ArgumentNullException("aPkiColleagueID is a required property for UserEditColleaguesV2ResponseMPayload and cannot be null");
            }
            this.APkiColleagueID = aPkiColleagueID;
        }

        /// <summary>
        /// Gets or Sets APkiColleagueID
        /// </summary>
        [DataMember(Name = "a_pkiColleagueID", IsRequired = true, EmitDefaultValue = true)]
        public List<int> APkiColleagueID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserEditColleaguesV2ResponseMPayload {\n");
            sb.Append("  APkiColleagueID: ").Append(APkiColleagueID).Append("\n");
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
            yield break;
        }
    }

}
