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
    /// ScimGroupMember
    /// </summary>
    [DataContract(Name = "Scim-GroupMember")]
    public partial class ScimGroupMember : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimGroupMember" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="display">display.</param>
        /// <param name="type">type.</param>
        /// <param name="varRef">varRef.</param>
        public ScimGroupMember(string value = default(string), string display = default(string), string type = default(string), string varRef = default(string))
        {
            this.Value = value;
            this.Display = display;
            this.Type = type;
            this.VarRef = varRef;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Display
        /// </summary>
        [DataMember(Name = "display", EmitDefaultValue = false)]
        public string Display { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets VarRef
        /// </summary>
        [DataMember(Name = "$ref", EmitDefaultValue = false)]
        public string VarRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScimGroupMember {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VarRef: ").Append(VarRef).Append("\n");
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
