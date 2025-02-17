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
    /// Payload for GET /2/object/supply/{pkiSupplyID}
    /// </summary>
    [DataContract(Name = "supply-getObject-v2-Response-mPayload")]
    public partial class SupplyGetObjectV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplyGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupplyGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplyGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objSupply">objSupply (required).</param>
        public SupplyGetObjectV2ResponseMPayload(SupplyResponseCompound objSupply = default(SupplyResponseCompound))
        {
            // to ensure "objSupply" is required (not null)
            if (objSupply == null)
            {
                throw new ArgumentNullException("objSupply is a required property for SupplyGetObjectV2ResponseMPayload and cannot be null");
            }
            this.ObjSupply = objSupply;
        }

        /// <summary>
        /// Gets or Sets ObjSupply
        /// </summary>
        [DataMember(Name = "objSupply", IsRequired = true, EmitDefaultValue = true)]
        public SupplyResponseCompound ObjSupply { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupplyGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjSupply: ").Append(ObjSupply).Append("\n");
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
