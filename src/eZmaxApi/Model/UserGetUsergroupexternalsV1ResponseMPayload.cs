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
    /// Response for GET /1/object/user/{pkiUserID}/getUsergroupexternals
    /// </summary>
    [DataContract(Name = "user-getUsergroupexternals-v1-Response-mPayload")]
    public partial class UserGetUsergroupexternalsV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetUsergroupexternalsV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserGetUsergroupexternalsV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetUsergroupexternalsV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjUsergroupexternal">aObjUsergroupexternal (required).</param>
        public UserGetUsergroupexternalsV1ResponseMPayload(List<UsergroupexternalResponseCompound> aObjUsergroupexternal = default(List<UsergroupexternalResponseCompound>))
        {
            // to ensure "aObjUsergroupexternal" is required (not null)
            if (aObjUsergroupexternal == null)
            {
                throw new ArgumentNullException("aObjUsergroupexternal is a required property for UserGetUsergroupexternalsV1ResponseMPayload and cannot be null");
            }
            this.AObjUsergroupexternal = aObjUsergroupexternal;
        }

        /// <summary>
        /// Gets or Sets AObjUsergroupexternal
        /// </summary>
        [DataMember(Name = "a_objUsergroupexternal", IsRequired = true, EmitDefaultValue = true)]
        public List<UsergroupexternalResponseCompound> AObjUsergroupexternal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserGetUsergroupexternalsV1ResponseMPayload {\n");
            sb.Append("  AObjUsergroupexternal: ").Append(AObjUsergroupexternal).Append("\n");
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
