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
    /// Request for POST /1/object/ezsigntemplatepackage
    /// </summary>
    [DataContract(Name = "ezsigntemplatepackage-createObject-v1-Request")]
    public partial class EzsigntemplatepackageCreateObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackageCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatepackageCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackageCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjEzsigntemplatepackage">aObjEzsigntemplatepackage (required).</param>
        public EzsigntemplatepackageCreateObjectV1Request(List<EzsigntemplatepackageRequestCompound> aObjEzsigntemplatepackage = default(List<EzsigntemplatepackageRequestCompound>))
        {
            // to ensure "aObjEzsigntemplatepackage" is required (not null)
            if (aObjEzsigntemplatepackage == null)
            {
                throw new ArgumentNullException("aObjEzsigntemplatepackage is a required property for EzsigntemplatepackageCreateObjectV1Request and cannot be null");
            }
            this.AObjEzsigntemplatepackage = aObjEzsigntemplatepackage;
        }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplatepackage
        /// </summary>
        [DataMember(Name = "a_objEzsigntemplatepackage", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigntemplatepackageRequestCompound> AObjEzsigntemplatepackage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplatepackageCreateObjectV1Request {\n");
            sb.Append("  AObjEzsigntemplatepackage: ").Append(AObjEzsigntemplatepackage).Append("\n");
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
