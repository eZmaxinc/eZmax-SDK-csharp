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
    /// Response for GET /2/object/user/{pkiUserID}/getColleagues
    /// </summary>
    [DataContract(Name = "user-getColleagues-v2-Response-mPayload")]
    public partial class UserGetColleaguesV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetColleaguesV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserGetColleaguesV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetColleaguesV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjColleague">aObjColleague (required).</param>
        /// <param name="aObjColleagueClonable">aObjColleagueClonable (required).</param>
        public UserGetColleaguesV2ResponseMPayload(List<ColleagueResponseCompoundV2> aObjColleague = default(List<ColleagueResponseCompoundV2>), List<ColleagueResponseCompoundV2> aObjColleagueClonable = default(List<ColleagueResponseCompoundV2>))
        {
            // to ensure "aObjColleague" is required (not null)
            if (aObjColleague == null)
            {
                throw new ArgumentNullException("aObjColleague is a required property for UserGetColleaguesV2ResponseMPayload and cannot be null");
            }
            this.AObjColleague = aObjColleague;
            // to ensure "aObjColleagueClonable" is required (not null)
            if (aObjColleagueClonable == null)
            {
                throw new ArgumentNullException("aObjColleagueClonable is a required property for UserGetColleaguesV2ResponseMPayload and cannot be null");
            }
            this.AObjColleagueClonable = aObjColleagueClonable;
        }

        /// <summary>
        /// Gets or Sets AObjColleague
        /// </summary>
        [DataMember(Name = "a_objColleague", IsRequired = true, EmitDefaultValue = true)]
        public List<ColleagueResponseCompoundV2> AObjColleague { get; set; }

        /// <summary>
        /// Gets or Sets AObjColleagueClonable
        /// </summary>
        [DataMember(Name = "a_objColleagueClonable", IsRequired = true, EmitDefaultValue = true)]
        public List<ColleagueResponseCompoundV2> AObjColleagueClonable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserGetColleaguesV2ResponseMPayload {\n");
            sb.Append("  AObjColleague: ").Append(AObjColleague).Append("\n");
            sb.Append("  AObjColleagueClonable: ").Append(AObjColleagueClonable).Append("\n");
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
