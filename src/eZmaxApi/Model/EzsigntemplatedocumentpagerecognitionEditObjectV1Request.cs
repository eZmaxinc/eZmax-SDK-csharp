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
    /// Request for PUT /1/object/ezsigntemplatedocumentpagerecognition/{pkiEzsigntemplatedocumentpagerecognitionID}
    /// </summary>
    [DataContract(Name = "ezsigntemplatedocumentpagerecognition-editObject-v1-Request")]
    public partial class EzsigntemplatedocumentpagerecognitionEditObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatedocumentpagerecognitionEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatedocumentpagerecognitionEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatedocumentpagerecognitionEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsigntemplatedocumentpagerecognition">objEzsigntemplatedocumentpagerecognition (required).</param>
        public EzsigntemplatedocumentpagerecognitionEditObjectV1Request(EzsigntemplatedocumentpagerecognitionRequestCompound objEzsigntemplatedocumentpagerecognition = default(EzsigntemplatedocumentpagerecognitionRequestCompound))
        {
            // to ensure "objEzsigntemplatedocumentpagerecognition" is required (not null)
            if (objEzsigntemplatedocumentpagerecognition == null)
            {
                throw new ArgumentNullException("objEzsigntemplatedocumentpagerecognition is a required property for EzsigntemplatedocumentpagerecognitionEditObjectV1Request and cannot be null");
            }
            this.ObjEzsigntemplatedocumentpagerecognition = objEzsigntemplatedocumentpagerecognition;
        }

        /// <summary>
        /// Gets or Sets ObjEzsigntemplatedocumentpagerecognition
        /// </summary>
        [DataMember(Name = "objEzsigntemplatedocumentpagerecognition", IsRequired = true, EmitDefaultValue = true)]
        public EzsigntemplatedocumentpagerecognitionRequestCompound ObjEzsigntemplatedocumentpagerecognition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplatedocumentpagerecognitionEditObjectV1Request {\n");
            sb.Append("  ObjEzsigntemplatedocumentpagerecognition: ").Append(ObjEzsigntemplatedocumentpagerecognition).Append("\n");
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
