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
    /// Request for PUT /1/object/ezsigndocument/{pkiEzsigndocumentID}
    /// </summary>
    [DataContract(Name = "ezsigndocument-editObject-v1-Request")]
    public partial class EzsigndocumentEditObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsigndocument">objEzsigndocument (required).</param>
        public EzsigndocumentEditObjectV1Request(EzsigndocumentRequestCompound objEzsigndocument = default(EzsigndocumentRequestCompound))
        {
            // to ensure "objEzsigndocument" is required (not null)
            if (objEzsigndocument == null)
            {
                throw new ArgumentNullException("objEzsigndocument is a required property for EzsigndocumentEditObjectV1Request and cannot be null");
            }
            this.ObjEzsigndocument = objEzsigndocument;
        }

        /// <summary>
        /// Gets or Sets ObjEzsigndocument
        /// </summary>
        [DataMember(Name = "objEzsigndocument", IsRequired = true, EmitDefaultValue = true)]
        public EzsigndocumentRequestCompound ObjEzsigndocument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigndocumentEditObjectV1Request {\n");
            sb.Append("  ObjEzsigndocument: ").Append(ObjEzsigndocument).Append("\n");
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
