/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// Payload for GET /2/object/ezsigntemplate/{pkiEzsigntemplateID}
    /// </summary>
    [DataContract(Name = "ezsigntemplate-getObject-v2-Response-mPayload")]
    public partial class EzsigntemplateGetObjectV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplateGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objEzsigntemplate">objEzsigntemplate (required).</param>
        public EzsigntemplateGetObjectV2ResponseMPayload(EzsigntemplateResponseCompound objEzsigntemplate = default(EzsigntemplateResponseCompound))
        {
            // to ensure "objEzsigntemplate" is required (not null)
            if (objEzsigntemplate == null)
            {
                throw new ArgumentNullException("objEzsigntemplate is a required property for EzsigntemplateGetObjectV2ResponseMPayload and cannot be null");
            }
            this.ObjEzsigntemplate = objEzsigntemplate;
        }

        /// <summary>
        /// Gets or Sets ObjEzsigntemplate
        /// </summary>
        [DataMember(Name = "objEzsigntemplate", IsRequired = true, EmitDefaultValue = true)]
        public EzsigntemplateResponseCompound ObjEzsigntemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplateGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjEzsigntemplate: ").Append(ObjEzsigntemplate).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
