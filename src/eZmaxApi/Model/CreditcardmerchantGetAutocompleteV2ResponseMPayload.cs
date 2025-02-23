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
    /// Payload for POST /2/object/creditcardmerchant/getAutocomplete
    /// </summary>
    [DataContract(Name = "creditcardmerchant-getAutocomplete-v2-Response-mPayload")]
    public partial class CreditcardmerchantGetAutocompleteV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardmerchantGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditcardmerchantGetAutocompleteV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardmerchantGetAutocompleteV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjCreditcardmerchant">An array of Creditcardmerchant autocomplete element response. (required).</param>
        public CreditcardmerchantGetAutocompleteV2ResponseMPayload(List<CreditcardmerchantAutocompleteElementResponse> aObjCreditcardmerchant = default(List<CreditcardmerchantAutocompleteElementResponse>))
        {
            // to ensure "aObjCreditcardmerchant" is required (not null)
            if (aObjCreditcardmerchant == null)
            {
                throw new ArgumentNullException("aObjCreditcardmerchant is a required property for CreditcardmerchantGetAutocompleteV2ResponseMPayload and cannot be null");
            }
            this.AObjCreditcardmerchant = aObjCreditcardmerchant;
        }

        /// <summary>
        /// An array of Creditcardmerchant autocomplete element response.
        /// </summary>
        /// <value>An array of Creditcardmerchant autocomplete element response.</value>
        [DataMember(Name = "a_objCreditcardmerchant", IsRequired = true, EmitDefaultValue = true)]
        public List<CreditcardmerchantAutocompleteElementResponse> AObjCreditcardmerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditcardmerchantGetAutocompleteV2ResponseMPayload {\n");
            sb.Append("  AObjCreditcardmerchant: ").Append(AObjCreditcardmerchant).Append("\n");
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
