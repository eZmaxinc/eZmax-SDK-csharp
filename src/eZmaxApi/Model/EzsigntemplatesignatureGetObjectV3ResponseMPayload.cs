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
    /// Payload for GET /3/object/ezsigntemplatesignature/{pkiEzsigntemplatesignatureID}
    /// </summary>
    [DataContract(Name = "ezsigntemplatesignature-getObject-v3-Response-mPayload")]
    public partial class EzsigntemplatesignatureGetObjectV3ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureGetObjectV3ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatesignatureGetObjectV3ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignatureGetObjectV3ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objEzsigntemplatesignature">objEzsigntemplatesignature (required).</param>
        public EzsigntemplatesignatureGetObjectV3ResponseMPayload(EzsigntemplatesignatureResponseCompoundV3 objEzsigntemplatesignature = default(EzsigntemplatesignatureResponseCompoundV3))
        {
            // to ensure "objEzsigntemplatesignature" is required (not null)
            if (objEzsigntemplatesignature == null)
            {
                throw new ArgumentNullException("objEzsigntemplatesignature is a required property for EzsigntemplatesignatureGetObjectV3ResponseMPayload and cannot be null");
            }
            this.ObjEzsigntemplatesignature = objEzsigntemplatesignature;
        }

        /// <summary>
        /// Gets or Sets ObjEzsigntemplatesignature
        /// </summary>
        [DataMember(Name = "objEzsigntemplatesignature", IsRequired = true, EmitDefaultValue = true)]
        public EzsigntemplatesignatureResponseCompoundV3 ObjEzsigntemplatesignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplatesignatureGetObjectV3ResponseMPayload {\n");
            sb.Append("  ObjEzsigntemplatesignature: ").Append(ObjEzsigntemplatesignature).Append("\n");
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
