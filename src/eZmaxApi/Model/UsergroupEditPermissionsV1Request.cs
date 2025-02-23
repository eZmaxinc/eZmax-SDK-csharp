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
    /// Request for PUT /1/object/usergroup/{pkiUsergroupID}/editPermissions
    /// </summary>
    [DataContract(Name = "usergroup-editPermissions-v1-Request")]
    public partial class UsergroupEditPermissionsV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupEditPermissionsV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsergroupEditPermissionsV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupEditPermissionsV1Request" /> class.
        /// </summary>
        /// <param name="aObjPermission">aObjPermission (required).</param>
        public UsergroupEditPermissionsV1Request(List<PermissionRequestCompound> aObjPermission = default(List<PermissionRequestCompound>))
        {
            // to ensure "aObjPermission" is required (not null)
            if (aObjPermission == null)
            {
                throw new ArgumentNullException("aObjPermission is a required property for UsergroupEditPermissionsV1Request and cannot be null");
            }
            this.AObjPermission = aObjPermission;
        }

        /// <summary>
        /// Gets or Sets AObjPermission
        /// </summary>
        [DataMember(Name = "a_objPermission", IsRequired = true, EmitDefaultValue = true)]
        public List<PermissionRequestCompound> AObjPermission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsergroupEditPermissionsV1Request {\n");
            sb.Append("  AObjPermission: ").Append(AObjPermission).Append("\n");
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
