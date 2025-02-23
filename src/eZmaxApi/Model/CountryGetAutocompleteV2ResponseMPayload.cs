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
    /// Payload for POST /2/object/country/getAutocomplete
    /// </summary>
    [DataContract(Name = "country-getAutocomplete-v2-Response-mPayload")]
    public partial class CountryGetAutocompleteV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CountryGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjCountry">An array of Country autocomplete element response. (required).</param>
        public CountryGetAutocompleteV2ResponseMPayload(List<CountryAutocompleteElementResponse> aObjCountry = default(List<CountryAutocompleteElementResponse>))
        {
            // to ensure "aObjCountry" is required (not null)
            if (aObjCountry == null)
            {
                throw new ArgumentNullException("aObjCountry is a required property for CountryGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            this.AObjCountry = aObjCountry;
        }

        /// <summary>
        /// An array of Country autocomplete element response.
        /// </summary>
        /// <value>An array of Country autocomplete element response.</value>
        [DataMember(Name = "a_objCountry", IsRequired = true, EmitDefaultValue = true)]
        public List<CountryAutocompleteElementResponse> AObjCountry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CountryGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjCountry: ").Append(AObjCountry).Append("\n");
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
