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
    /// Request for POST /1/object/customer
    /// </summary>
    [DataContract(Name = "customer-createObject-v1-Request")]
    public partial class CustomerCreateObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjCustomer">aObjCustomer (required).</param>
        public CustomerCreateObjectV1Request(List<CustomerRequestCompound> aObjCustomer = default(List<CustomerRequestCompound>))
        {
            // to ensure "aObjCustomer" is required (not null)
            if (aObjCustomer == null)
            {
                throw new ArgumentNullException("aObjCustomer is a required property for CustomerCreateObjectV1Request and cannot be null");
            }
            this.AObjCustomer = aObjCustomer;
        }

        /// <summary>
        /// Gets or Sets AObjCustomer
        /// </summary>
        [DataMember(Name = "a_objCustomer", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomerRequestCompound> AObjCustomer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerCreateObjectV1Request {\n");
            sb.Append("  AObjCustomer: ").Append(AObjCustomer).Append("\n");
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
