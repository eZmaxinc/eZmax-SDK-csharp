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
    /// Response for GET /1/object/user/{pkiUserID}/getUsergroups
    /// </summary>
    [DataContract(Name = "user-getUsergroups-v1-Response")]
    public partial class UserGetUsergroupsV1Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetUsergroupsV1Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserGetUsergroupsV1Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetUsergroupsV1Response" /> class.
        /// </summary>
        /// <param name="objDebugPayload">objDebugPayload (required).</param>
        /// <param name="objDebug">objDebug.</param>
        /// <param name="mPayload">mPayload (required).</param>
        public UserGetUsergroupsV1Response(CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug), UserGetUsergroupsV1ResponseMPayload mPayload = default(UserGetUsergroupsV1ResponseMPayload))
        {
            // to ensure "objDebugPayload" is required (not null)
            if (objDebugPayload == null)
            {
                throw new ArgumentNullException("objDebugPayload is a required property for UserGetUsergroupsV1Response and cannot be null");
            }
            this.ObjDebugPayload = objDebugPayload;
            // to ensure "mPayload" is required (not null)
            if (mPayload == null)
            {
                throw new ArgumentNullException("mPayload is a required property for UserGetUsergroupsV1Response and cannot be null");
            }
            this.MPayload = mPayload;
            this.ObjDebug = objDebug;
        }

        /// <summary>
        /// Gets or Sets ObjDebugPayload
        /// </summary>
        [DataMember(Name = "objDebugPayload", IsRequired = true, EmitDefaultValue = true)]
        public CommonResponseObjDebugPayload ObjDebugPayload { get; set; }

        /// <summary>
        /// Gets or Sets ObjDebug
        /// </summary>
        [DataMember(Name = "objDebug", EmitDefaultValue = false)]
        public CommonResponseObjDebug ObjDebug { get; set; }

        /// <summary>
        /// Gets or Sets MPayload
        /// </summary>
        [DataMember(Name = "mPayload", IsRequired = true, EmitDefaultValue = true)]
        public UserGetUsergroupsV1ResponseMPayload MPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserGetUsergroupsV1Response {\n");
            sb.Append("  ObjDebugPayload: ").Append(ObjDebugPayload).Append("\n");
            sb.Append("  ObjDebug: ").Append(ObjDebug).Append("\n");
            sb.Append("  MPayload: ").Append(MPayload).Append("\n");
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