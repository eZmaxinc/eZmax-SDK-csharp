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
    /// Response for POST /2/object/ezsigndocument/{pkiEzsigndocument}/applyEzsigntemplate
    /// </summary>
    [DataContract(Name = "ezsigndocument-applyEzsigntemplate-v2-Response")]
    public partial class EzsigndocumentApplyEzsigntemplateV2Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateV2Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentApplyEzsigntemplateV2Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateV2Response" /> class.
        /// </summary>
        /// <param name="objDebugPayload">objDebugPayload (required).</param>
        /// <param name="objDebug">objDebug.</param>
        /// <param name="aObjWarning">aObjWarning.</param>
        public EzsigndocumentApplyEzsigntemplateV2Response(CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug), List<CommonResponseWarning> aObjWarning = default(List<CommonResponseWarning>))
        {
            // to ensure "objDebugPayload" is required (not null)
            if (objDebugPayload == null)
            {
                throw new ArgumentNullException("objDebugPayload is a required property for EzsigndocumentApplyEzsigntemplateV2Response and cannot be null");
            }
            this.ObjDebugPayload = objDebugPayload;
            this.ObjDebug = objDebug;
            this.AObjWarning = aObjWarning;
        }

        /// <summary>
        /// Gets or Sets ObjDebugPayload
        /// </summary>
        [DataMember(Name = "objDebugPayload", IsRequired = true, EmitDefaultValue = true)]
        public CommonResponseObjDebugPayload ObjDebugPayload { get; set; }

        /// <summary>
        /// Gets or Sets ObjDebug
        /// </summary>
        [DataMember(Name = "objDebug", EmitDefaultValue = false)]
        public CommonResponseObjDebug ObjDebug { get; set; }

        /// <summary>
        /// Gets or Sets AObjWarning
        /// </summary>
        [DataMember(Name = "a_objWarning", EmitDefaultValue = false)]
        public List<CommonResponseWarning> AObjWarning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigndocumentApplyEzsigntemplateV2Response {\n");
            sb.Append("  ObjDebugPayload: ").Append(ObjDebugPayload).Append("\n");
            sb.Append("  ObjDebug: ").Append(ObjDebug).Append("\n");
            sb.Append("  AObjWarning: ").Append(AObjWarning).Append("\n");
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
