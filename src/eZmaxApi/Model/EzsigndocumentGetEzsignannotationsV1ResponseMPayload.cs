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
    /// Payload for GET /1/object/ezsigndocument/{pkiEzsigndocument}/getEzsignannotations
    /// </summary>
    [DataContract(Name = "ezsigndocument-getEzsignannotations-v1-Response-mPayload")]
    public partial class EzsigndocumentGetEzsignannotationsV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetEzsignannotationsV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentGetEzsignannotationsV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetEzsignannotationsV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsignannotation">aObjEzsignannotation (required).</param>
        public EzsigndocumentGetEzsignannotationsV1ResponseMPayload(List<EzsignannotationResponseCompound> aObjEzsignannotation = default(List<EzsignannotationResponseCompound>))
        {
            // to ensure "aObjEzsignannotation" is required (not null)
            if (aObjEzsignannotation == null)
            {
                throw new ArgumentNullException("aObjEzsignannotation is a required property for EzsigndocumentGetEzsignannotationsV1ResponseMPayload and cannot be null");
            }
            this.AObjEzsignannotation = aObjEzsignannotation;
        }

        /// <summary>
        /// Gets or Sets AObjEzsignannotation
        /// </summary>
        [DataMember(Name = "a_objEzsignannotation", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsignannotationResponseCompound> AObjEzsignannotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigndocumentGetEzsignannotationsV1ResponseMPayload {\n");
            sb.Append("  AObjEzsignannotation: ").Append(AObjEzsignannotation).Append("\n");
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
