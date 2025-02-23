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
    /// Payload for PUT /1/object/ezsigndocument/{pkiEzsigndocumentID}/editEzsignformfieldgroups
    /// </summary>
    [DataContract(Name = "ezsigndocument-editEzsignformfieldgroups-v1-Response-mPayload")]
    public partial class EzsigndocumentEditEzsignformfieldgroupsV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentEditEzsignformfieldgroupsV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentEditEzsignformfieldgroupsV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentEditEzsignformfieldgroupsV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiEzsignformfieldgroupID">aPkiEzsignformfieldgroupID (required).</param>
        public EzsigndocumentEditEzsignformfieldgroupsV1ResponseMPayload(List<int> aPkiEzsignformfieldgroupID = default(List<int>))
        {
            // to ensure "aPkiEzsignformfieldgroupID" is required (not null)
            if (aPkiEzsignformfieldgroupID == null)
            {
                throw new ArgumentNullException("aPkiEzsignformfieldgroupID is a required property for EzsigndocumentEditEzsignformfieldgroupsV1ResponseMPayload and cannot be null");
            }
            this.APkiEzsignformfieldgroupID = aPkiEzsignformfieldgroupID;
        }

        /// <summary>
        /// Gets or Sets APkiEzsignformfieldgroupID
        /// </summary>
        [DataMember(Name = "a_pkiEzsignformfieldgroupID", IsRequired = true, EmitDefaultValue = true)]
        public List<int> APkiEzsignformfieldgroupID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigndocumentEditEzsignformfieldgroupsV1ResponseMPayload {\n");
            sb.Append("  APkiEzsignformfieldgroupID: ").Append(APkiEzsignformfieldgroupID).Append("\n");
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
