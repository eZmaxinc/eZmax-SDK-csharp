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
    /// Payload for POST /2/object/ezsigntemplate/getAutocomplete
    /// </summary>
    [DataContract(Name = "ezsigntemplate-getAutocomplete-v2-Response-mPayload")]
    public partial class EzsigntemplateGetAutocompleteV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplateGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsigntemplate">An array of Ezsigntemplate autocomplete element response. (required).</param>
        public EzsigntemplateGetAutocompleteV2ResponseMPayload(List<EzsigntemplateAutocompleteElementResponse> aObjEzsigntemplate = default(List<EzsigntemplateAutocompleteElementResponse>))
        {
            // to ensure "aObjEzsigntemplate" is required (not null)
            if (aObjEzsigntemplate == null)
            {
                throw new ArgumentNullException("aObjEzsigntemplate is a required property for EzsigntemplateGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            this.AObjEzsigntemplate = aObjEzsigntemplate;
        }

        /// <summary>
        /// An array of Ezsigntemplate autocomplete element response.
        /// </summary>
        /// <value>An array of Ezsigntemplate autocomplete element response.</value>
        [DataMember(Name = "a_objEzsigntemplate", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigntemplateAutocompleteElementResponse> AObjEzsigntemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplateGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjEzsigntemplate: ").Append(AObjEzsigntemplate).Append("\n");
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
