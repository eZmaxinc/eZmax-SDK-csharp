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
    /// Payload for GET /2/object/subnet/{pkiSubnetID}
    /// </summary>
    [DataContract(Name = "subnet-getObject-v2-Response-mPayload")]
    public partial class SubnetGetObjectV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubnetGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubnetGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubnetGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objSubnet">objSubnet (required).</param>
        public SubnetGetObjectV2ResponseMPayload(SubnetResponseCompound objSubnet = default(SubnetResponseCompound))
        {
            // to ensure "objSubnet" is required (not null)
            if (objSubnet == null)
            {
                throw new ArgumentNullException("objSubnet is a required property for SubnetGetObjectV2ResponseMPayload and cannot be null");
            }
            this.ObjSubnet = objSubnet;
        }

        /// <summary>
        /// Gets or Sets ObjSubnet
        /// </summary>
        [DataMember(Name = "objSubnet", IsRequired = true, EmitDefaultValue = true)]
        public SubnetResponseCompound ObjSubnet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubnetGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjSubnet: ").Append(ObjSubnet).Append("\n");
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
