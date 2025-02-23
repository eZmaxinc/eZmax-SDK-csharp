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
    /// Request for POST /1/object/ezsigntemplatedocumentpagerecognition
    /// </summary>
    [DataContract(Name = "ezsigntemplatedocumentpagerecognition-createObject-v1-Request")]
    public partial class EzsigntemplatedocumentpagerecognitionCreateObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatedocumentpagerecognitionCreateObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatedocumentpagerecognitionCreateObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatedocumentpagerecognitionCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="aObjEzsigntemplatedocumentpagerecognition">aObjEzsigntemplatedocumentpagerecognition (required).</param>
        public EzsigntemplatedocumentpagerecognitionCreateObjectV1Request(List<EzsigntemplatedocumentpagerecognitionRequestCompound> aObjEzsigntemplatedocumentpagerecognition = default(List<EzsigntemplatedocumentpagerecognitionRequestCompound>))
        {
            // to ensure "aObjEzsigntemplatedocumentpagerecognition" is required (not null)
            if (aObjEzsigntemplatedocumentpagerecognition == null)
            {
                throw new ArgumentNullException("aObjEzsigntemplatedocumentpagerecognition is a required property for EzsigntemplatedocumentpagerecognitionCreateObjectV1Request and cannot be null");
            }
            this.AObjEzsigntemplatedocumentpagerecognition = aObjEzsigntemplatedocumentpagerecognition;
        }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplatedocumentpagerecognition
        /// </summary>
        [DataMember(Name = "a_objEzsigntemplatedocumentpagerecognition", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigntemplatedocumentpagerecognitionRequestCompound> AObjEzsigntemplatedocumentpagerecognition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplatedocumentpagerecognitionCreateObjectV1Request {\n");
            sb.Append("  AObjEzsigntemplatedocumentpagerecognition: ").Append(AObjEzsigntemplatedocumentpagerecognition).Append("\n");
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
