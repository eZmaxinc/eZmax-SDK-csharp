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
    /// A complex type that specifies configuration options related to changing a password.
    /// </summary>
    [DataContract(Name = "Scim_ServiceProviderConfig_changePassword")]
    public partial class ScimServiceProviderConfigChangePassword : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfigChangePassword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScimServiceProviderConfigChangePassword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfigChangePassword" /> class.
        /// </summary>
        /// <param name="supported">A Boolean value specifying whether or not the operation is supported. (required).</param>
        public ScimServiceProviderConfigChangePassword(bool supported = default(bool))
        {
            this.Supported = supported;
        }

        /// <summary>
        /// A Boolean value specifying whether or not the operation is supported.
        /// </summary>
        /// <value>A Boolean value specifying whether or not the operation is supported.</value>
        /* <example>false</example>*/
        [DataMember(Name = "supported", IsRequired = true, EmitDefaultValue = true)]
        public bool Supported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScimServiceProviderConfigChangePassword {\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
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
