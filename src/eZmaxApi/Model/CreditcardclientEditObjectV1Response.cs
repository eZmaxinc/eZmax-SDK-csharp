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
    /// Response for PUT /1/object/creditcardclient/{pkiCreditcardclientID}
    /// </summary>
    [DataContract(Name = "creditcardclient-editObject-v1-Response")]
    public partial class CreditcardclientEditObjectV1Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardclientEditObjectV1Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditcardclientEditObjectV1Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardclientEditObjectV1Response" /> class.
        /// </summary>
        /// <param name="objDebugPayload">objDebugPayload (required).</param>
        /// <param name="objDebug">objDebug.</param>
        public CreditcardclientEditObjectV1Response(CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug))
        {
            // to ensure "objDebugPayload" is required (not null)
            if (objDebugPayload == null)
            {
                throw new ArgumentNullException("objDebugPayload is a required property for CreditcardclientEditObjectV1Response and cannot be null");
            }
            this.ObjDebugPayload = objDebugPayload;
            this.ObjDebug = objDebug;
        }

        /// <summary>
        /// Gets or Sets ObjDebugPayload
        /// </summary>
        [DataMember(Name = "objDebugPayload", IsRequired = true, EmitDefaultValue = true)]
        public CommonResponseObjDebugPayload ObjDebugPayload { get; set; }

        /// <summary>
        /// Gets or Sets ObjDebug
        /// </summary>
        [DataMember(Name = "objDebug", EmitDefaultValue = false)]
        public CommonResponseObjDebug ObjDebug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditcardclientEditObjectV1Response {\n");
            sb.Append("  ObjDebugPayload: ").Append(ObjDebugPayload).Append("\n");
            sb.Append("  ObjDebug: ").Append(ObjDebug).Append("\n");
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