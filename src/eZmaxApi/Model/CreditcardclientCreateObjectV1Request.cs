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
    /// Request for POST /1/object/creditcardclient
    /// </summary>
    [DataContract(Name = "creditcardclient-createObject-v1-Request")]
    public partial class CreditcardclientCreateObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardclientCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditcardclientCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardclientCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjCreditcardclient">aObjCreditcardclient (required).</param>
        public CreditcardclientCreateObjectV1Request(List<CreditcardclientRequestCompound> aObjCreditcardclient = default(List<CreditcardclientRequestCompound>))
        {
            // to ensure "aObjCreditcardclient" is required (not null)
            if (aObjCreditcardclient == null)
            {
                throw new ArgumentNullException("aObjCreditcardclient is a required property for CreditcardclientCreateObjectV1Request and cannot be null");
            }
            this.AObjCreditcardclient = aObjCreditcardclient;
        }

        /// <summary>
        /// Gets or Sets AObjCreditcardclient
        /// </summary>
        [DataMember(Name = "a_objCreditcardclient", IsRequired = true, EmitDefaultValue = true)]
        public List<CreditcardclientRequestCompound> AObjCreditcardclient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditcardclientCreateObjectV1Request {\n");
            sb.Append("  AObjCreditcardclient: ").Append(AObjCreditcardclient).Append("\n");
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