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
    /// Payload for GET /1/module/ezsign/suggestTemplates
    /// </summary>
    [DataContract(Name = "ezsign-suggestTemplates-v1-Response-mPayload")]
    public partial class EzsignSuggestTemplatesV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignSuggestTemplatesV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignSuggestTemplatesV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignSuggestTemplatesV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsigntemplate">aObjEzsigntemplate (required).</param>
        /// <param name="aObjEzsigntemplatepackage">aObjEzsigntemplatepackage (required).</param>
        /// <param name="aObjEzsigntemplateglobal">aObjEzsigntemplateglobal (required).</param>
        public EzsignSuggestTemplatesV1ResponseMPayload(List<EzsigntemplateResponseCompound> aObjEzsigntemplate = default(List<EzsigntemplateResponseCompound>), List<EzsigntemplatepackageResponseCompound> aObjEzsigntemplatepackage = default(List<EzsigntemplatepackageResponseCompound>), List<EzsigntemplateglobalResponseCompound> aObjEzsigntemplateglobal = default(List<EzsigntemplateglobalResponseCompound>))
        {
            // to ensure "aObjEzsigntemplate" is required (not null)
            if (aObjEzsigntemplate == null)
            {
                throw new ArgumentNullException("aObjEzsigntemplate is a required property for EzsignSuggestTemplatesV1ResponseMPayload and cannot be null");
            }
            this.AObjEzsigntemplate = aObjEzsigntemplate;
            // to ensure "aObjEzsigntemplatepackage" is required (not null)
            if (aObjEzsigntemplatepackage == null)
            {
                throw new ArgumentNullException("aObjEzsigntemplatepackage is a required property for EzsignSuggestTemplatesV1ResponseMPayload and cannot be null");
            }
            this.AObjEzsigntemplatepackage = aObjEzsigntemplatepackage;
            // to ensure "aObjEzsigntemplateglobal" is required (not null)
            if (aObjEzsigntemplateglobal == null)
            {
                throw new ArgumentNullException("aObjEzsigntemplateglobal is a required property for EzsignSuggestTemplatesV1ResponseMPayload and cannot be null");
            }
            this.AObjEzsigntemplateglobal = aObjEzsigntemplateglobal;
        }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplate
        /// </summary>
        [DataMember(Name = "a_objEzsigntemplate", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigntemplateResponseCompound> AObjEzsigntemplate { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplatepackage
        /// </summary>
        [DataMember(Name = "a_objEzsigntemplatepackage", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigntemplatepackageResponseCompound> AObjEzsigntemplatepackage { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplateglobal
        /// </summary>
        [DataMember(Name = "a_objEzsigntemplateglobal", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigntemplateglobalResponseCompound> AObjEzsigntemplateglobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignSuggestTemplatesV1ResponseMPayload {\n");
            sb.Append("  AObjEzsigntemplate: ").Append(AObjEzsigntemplate).Append("\n");
            sb.Append("  AObjEzsigntemplatepackage: ").Append(AObjEzsigntemplatepackage).Append("\n");
            sb.Append("  AObjEzsigntemplateglobal: ").Append(AObjEzsigntemplateglobal).Append("\n");
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
