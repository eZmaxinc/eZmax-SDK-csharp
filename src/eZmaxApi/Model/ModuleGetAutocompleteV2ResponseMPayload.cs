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
    /// Payload for POST /2/object/module/getAutocomplete
    /// </summary>
    [DataContract(Name = "module-getAutocomplete-v2-Response-mPayload")]
    public partial class ModuleGetAutocompleteV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModuleGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjModule">An array of Module autocomplete element response. (required).</param>
        public ModuleGetAutocompleteV2ResponseMPayload(List<ModuleAutocompleteElementResponse> aObjModule = default(List<ModuleAutocompleteElementResponse>))
        {
            // to ensure "aObjModule" is required (not null)
            if (aObjModule == null)
            {
                throw new ArgumentNullException("aObjModule is a required property for ModuleGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            this.AObjModule = aObjModule;
        }

        /// <summary>
        /// An array of Module autocomplete element response.
        /// </summary>
        /// <value>An array of Module autocomplete element response.</value>
        [DataMember(Name = "a_objModule", IsRequired = true, EmitDefaultValue = true)]
        public List<ModuleAutocompleteElementResponse> AObjModule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModuleGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjModule: ").Append(AObjModule).Append("\n");
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
