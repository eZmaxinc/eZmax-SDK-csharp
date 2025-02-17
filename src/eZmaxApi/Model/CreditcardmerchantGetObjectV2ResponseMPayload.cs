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
    /// Payload for GET /2/object/creditcardmerchant/{pkiCreditcardmerchantID}
    /// </summary>
    [DataContract(Name = "creditcardmerchant-getObject-v2-Response-mPayload")]
    public partial class CreditcardmerchantGetObjectV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardmerchantGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditcardmerchantGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardmerchantGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objCreditcardmerchant">objCreditcardmerchant (required).</param>
        public CreditcardmerchantGetObjectV2ResponseMPayload(CreditcardmerchantResponseCompound objCreditcardmerchant = default(CreditcardmerchantResponseCompound))
        {
            // to ensure "objCreditcardmerchant" is required (not null)
            if (objCreditcardmerchant == null)
            {
                throw new ArgumentNullException("objCreditcardmerchant is a required property for CreditcardmerchantGetObjectV2ResponseMPayload and cannot be null");
            }
            this.ObjCreditcardmerchant = objCreditcardmerchant;
        }

        /// <summary>
        /// Gets or Sets ObjCreditcardmerchant
        /// </summary>
        [DataMember(Name = "objCreditcardmerchant", IsRequired = true, EmitDefaultValue = true)]
        public CreditcardmerchantResponseCompound ObjCreditcardmerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditcardmerchantGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjCreditcardmerchant: ").Append(ObjCreditcardmerchant).Append("\n");
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
