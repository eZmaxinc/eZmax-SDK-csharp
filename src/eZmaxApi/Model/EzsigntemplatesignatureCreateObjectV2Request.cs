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
    /// Request for POST /2/object/ezsigntemplatesignature
    /// </summary>
    [DataContract(Name = "ezsigntemplatesignature-createObject-v2-Request")]
    public partial class EzsigntemplatesignatureCreateObjectV2Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureCreateObjectV2Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatesignatureCreateObjectV2Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureCreateObjectV2Request" /> class.
        /// </summary>
        /// <param name="aObjEzsigntemplatesignature">aObjEzsigntemplatesignature (required).</param>
        public EzsigntemplatesignatureCreateObjectV2Request(List<EzsigntemplatesignatureRequestCompoundV2> aObjEzsigntemplatesignature = default(List<EzsigntemplatesignatureRequestCompoundV2>))
        {
            // to ensure "aObjEzsigntemplatesignature" is required (not null)
            if (aObjEzsigntemplatesignature == null)
            {
                throw new ArgumentNullException("aObjEzsigntemplatesignature is a required property for EzsigntemplatesignatureCreateObjectV2Request and cannot be null");
            }
            this.AObjEzsigntemplatesignature = aObjEzsigntemplatesignature;
        }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplatesignature
        /// </summary>
        [DataMember(Name = "a_objEzsigntemplatesignature", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigntemplatesignatureRequestCompoundV2> AObjEzsigntemplatesignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplatesignatureCreateObjectV2Request {\n");
            sb.Append("  AObjEzsigntemplatesignature: ").Append(AObjEzsigntemplatesignature).Append("\n");
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
