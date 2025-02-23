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
    /// Payload for POST /2/object/ezsignsigningreason/getAutocomplete
    /// </summary>
    [DataContract(Name = "ezsignsigningreason-getAutocomplete-v2-Response-mPayload")]
    public partial class EzsignsigningreasonGetAutocompleteV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsigningreasonGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsignsigningreason">An array of Ezsignsigningreason autocomplete element response. (required).</param>
        public EzsignsigningreasonGetAutocompleteV2ResponseMPayload(List<EzsignsigningreasonAutocompleteElementResponse> aObjEzsignsigningreason = default(List<EzsignsigningreasonAutocompleteElementResponse>))
        {
            // to ensure "aObjEzsignsigningreason" is required (not null)
            if (aObjEzsignsigningreason == null)
            {
                throw new ArgumentNullException("aObjEzsignsigningreason is a required property for EzsignsigningreasonGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            this.AObjEzsignsigningreason = aObjEzsignsigningreason;
        }

        /// <summary>
        /// An array of Ezsignsigningreason autocomplete element response.
        /// </summary>
        /// <value>An array of Ezsignsigningreason autocomplete element response.</value>
        [DataMember(Name = "a_objEzsignsigningreason", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsignsigningreasonAutocompleteElementResponse> AObjEzsignsigningreason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignsigningreasonGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjEzsignsigningreason: ").Append(AObjEzsignsigningreason).Append("\n");
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
