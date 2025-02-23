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
    /// Request for PUT /1/object/creditcardmerchant/{pkiCreditcardmerchantID}
    /// </summary>
    [DataContract(Name = "creditcardmerchant-editObject-v1-Request")]
    public partial class CreditcardmerchantEditObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardmerchantEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditcardmerchantEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardmerchantEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objCreditcardmerchant">objCreditcardmerchant (required).</param>
        public CreditcardmerchantEditObjectV1Request(CreditcardmerchantRequestCompound objCreditcardmerchant = default(CreditcardmerchantRequestCompound))
        {
            // to ensure "objCreditcardmerchant" is required (not null)
            if (objCreditcardmerchant == null)
            {
                throw new ArgumentNullException("objCreditcardmerchant is a required property for CreditcardmerchantEditObjectV1Request and cannot be null");
            }
            this.ObjCreditcardmerchant = objCreditcardmerchant;
        }

        /// <summary>
        /// Gets or Sets ObjCreditcardmerchant
        /// </summary>
        [DataMember(Name = "objCreditcardmerchant", IsRequired = true, EmitDefaultValue = true)]
        public CreditcardmerchantRequestCompound ObjCreditcardmerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditcardmerchantEditObjectV1Request {\n");
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
