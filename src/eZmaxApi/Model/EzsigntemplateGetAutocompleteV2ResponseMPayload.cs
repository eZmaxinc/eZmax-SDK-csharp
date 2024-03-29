/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.18
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// Payload for POST /2/object/ezsigntemplate/getAutocomplete
    /// </summary>
    [DataContract]
    public partial class EzsigntemplateGetAutocompleteV2ResponseMPayload :  IEquatable<EzsigntemplateGetAutocompleteV2ResponseMPayload>, IValidatableObject
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
                throw new InvalidDataException("aObjEzsigntemplate is a required property for EzsigntemplateGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjEzsigntemplate = aObjEzsigntemplate;
            }

        }

        /// <summary>
        /// An array of Ezsigntemplate autocomplete element response.
        /// </summary>
        /// <value>An array of Ezsigntemplate autocomplete element response.</value>
        [DataMember(Name="a_objEzsigntemplate", EmitDefaultValue=true)]
        public List<EzsigntemplateAutocompleteElementResponse> AObjEzsigntemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzsigntemplateGetAutocompleteV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigntemplateGetAutocompleteV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplateGetAutocompleteV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplateGetAutocompleteV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjEzsigntemplate == input.AObjEzsigntemplate ||
                    this.AObjEzsigntemplate != null &&
                    input.AObjEzsigntemplate != null &&
                    this.AObjEzsigntemplate.SequenceEqual(input.AObjEzsigntemplate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AObjEzsigntemplate != null)
                    hashCode = hashCode * 59 + this.AObjEzsigntemplate.GetHashCode();
                return hashCode;
            }
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
