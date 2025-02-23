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
    /// A Custom Ezsignformfield Object to contain an error list
    /// </summary>
    [DataContract(Name = "Custom-Ezsignformfielderror-Response")]
    public partial class CustomEzsignformfielderrorResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignformfielderrorResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEzsignformfielderrorResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsignformfielderrorResponse" /> class.
        /// </summary>
        /// <param name="sEzsignformfieldLabel">The Label for the Ezsignformfield (required).</param>
        /// <param name="aObjEzsignformfielderrortest">aObjEzsignformfielderrortest (required).</param>
        public CustomEzsignformfielderrorResponse(string sEzsignformfieldLabel = default(string), List<CustomEzsignformfielderrortestResponse> aObjEzsignformfielderrortest = default(List<CustomEzsignformfielderrortestResponse>))
        {
            // to ensure "sEzsignformfieldLabel" is required (not null)
            if (sEzsignformfieldLabel == null)
            {
                throw new ArgumentNullException("sEzsignformfieldLabel is a required property for CustomEzsignformfielderrorResponse and cannot be null");
            }
            this.SEzsignformfieldLabel = sEzsignformfieldLabel;
            // to ensure "aObjEzsignformfielderrortest" is required (not null)
            if (aObjEzsignformfielderrortest == null)
            {
                throw new ArgumentNullException("aObjEzsignformfielderrortest is a required property for CustomEzsignformfielderrorResponse and cannot be null");
            }
            this.AObjEzsignformfielderrortest = aObjEzsignformfielderrortest;
        }

        /// <summary>
        /// The Label for the Ezsignformfield
        /// </summary>
        /// <value>The Label for the Ezsignformfield</value>
        /* <example>Peanuts</example>*/
        [DataMember(Name = "sEzsignformfieldLabel", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsignformfieldLabel { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsignformfielderrortest
        /// </summary>
        [DataMember(Name = "a_objEzsignformfielderrortest", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomEzsignformfielderrortestResponse> AObjEzsignformfielderrortest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomEzsignformfielderrorResponse {\n");
            sb.Append("  SEzsignformfieldLabel: ").Append(SEzsignformfieldLabel).Append("\n");
            sb.Append("  AObjEzsignformfielderrortest: ").Append(AObjEzsignformfielderrortest).Append("\n");
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
