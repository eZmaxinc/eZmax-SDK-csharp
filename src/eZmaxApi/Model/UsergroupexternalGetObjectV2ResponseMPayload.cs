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
    /// Payload for GET /2/object/usergroupexternal/{pkiUsergroupexternalID}
    /// </summary>
    [DataContract(Name = "usergroupexternal-getObject-v2-Response-mPayload")]
    public partial class UsergroupexternalGetObjectV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupexternalGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupexternalGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupexternalGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objUsergroupexternal">objUsergroupexternal (required).</param>
        public UsergroupexternalGetObjectV2ResponseMPayload(UsergroupexternalResponseCompound objUsergroupexternal = default(UsergroupexternalResponseCompound))
        {
            // to ensure "objUsergroupexternal" is required (not null)
            if (objUsergroupexternal == null)
            {
                throw new ArgumentNullException("objUsergroupexternal is a required property for UsergroupexternalGetObjectV2ResponseMPayload and cannot be null");
            }
            this.ObjUsergroupexternal = objUsergroupexternal;
        }

        /// <summary>
        /// Gets or Sets ObjUsergroupexternal
        /// </summary>
        [DataMember(Name = "objUsergroupexternal", IsRequired = true, EmitDefaultValue = true)]
        public UsergroupexternalResponseCompound ObjUsergroupexternal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsergroupexternalGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjUsergroupexternal: ").Append(ObjUsergroupexternal).Append("\n");
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