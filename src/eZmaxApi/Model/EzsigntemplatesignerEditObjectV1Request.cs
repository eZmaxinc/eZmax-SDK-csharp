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
    /// Request for PUT /1/object/ezsigntemplatesigner/{pkiEzsigntemplatesignerID}
    /// </summary>
    [DataContract(Name = "ezsigntemplatesigner-editObject-v1-Request")]
    public partial class EzsigntemplatesignerEditObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignerEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatesignerEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignerEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsigntemplatesigner">objEzsigntemplatesigner (required).</param>
        public EzsigntemplatesignerEditObjectV1Request(EzsigntemplatesignerRequestCompound objEzsigntemplatesigner = default(EzsigntemplatesignerRequestCompound))
        {
            // to ensure "objEzsigntemplatesigner" is required (not null)
            if (objEzsigntemplatesigner == null)
            {
                throw new ArgumentNullException("objEzsigntemplatesigner is a required property for EzsigntemplatesignerEditObjectV1Request and cannot be null");
            }
            this.ObjEzsigntemplatesigner = objEzsigntemplatesigner;
        }

        /// <summary>
        /// Gets or Sets ObjEzsigntemplatesigner
        /// </summary>
        [DataMember(Name = "objEzsigntemplatesigner", IsRequired = true, EmitDefaultValue = true)]
        public EzsigntemplatesignerRequestCompound ObjEzsigntemplatesigner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplatesignerEditObjectV1Request {\n");
            sb.Append("  ObjEzsigntemplatesigner: ").Append(ObjEzsigntemplatesigner).Append("\n");
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
