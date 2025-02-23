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
    /// Request for PUT /1/object/ezsignbulksend/{pkiEzsignbulksendID}
    /// </summary>
    [DataContract(Name = "ezsignbulksend-editObject-v1-Request")]
    public partial class EzsignbulksendEditObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignbulksendEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignbulksend">objEzsignbulksend (required).</param>
        public EzsignbulksendEditObjectV1Request(EzsignbulksendRequestCompound objEzsignbulksend = default(EzsignbulksendRequestCompound))
        {
            // to ensure "objEzsignbulksend" is required (not null)
            if (objEzsignbulksend == null)
            {
                throw new ArgumentNullException("objEzsignbulksend is a required property for EzsignbulksendEditObjectV1Request and cannot be null");
            }
            this.ObjEzsignbulksend = objEzsignbulksend;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignbulksend
        /// </summary>
        [DataMember(Name = "objEzsignbulksend", IsRequired = true, EmitDefaultValue = true)]
        public EzsignbulksendRequestCompound ObjEzsignbulksend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignbulksendEditObjectV1Request {\n");
            sb.Append("  ObjEzsignbulksend: ").Append(ObjEzsignbulksend).Append("\n");
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
