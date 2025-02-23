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
    /// Request for POST /1/object/domain
    /// </summary>
    [DataContract(Name = "domain-createObject-v1-Request")]
    public partial class DomainCreateObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjDomain">aObjDomain (required).</param>
        public DomainCreateObjectV1Request(List<DomainRequestCompound> aObjDomain = default(List<DomainRequestCompound>))
        {
            // to ensure "aObjDomain" is required (not null)
            if (aObjDomain == null)
            {
                throw new ArgumentNullException("aObjDomain is a required property for DomainCreateObjectV1Request and cannot be null");
            }
            this.AObjDomain = aObjDomain;
        }

        /// <summary>
        /// Gets or Sets AObjDomain
        /// </summary>
        [DataMember(Name = "a_objDomain", IsRequired = true, EmitDefaultValue = true)]
        public List<DomainRequestCompound> AObjDomain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainCreateObjectV1Request {\n");
            sb.Append("  AObjDomain: ").Append(AObjDomain).Append("\n");
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
