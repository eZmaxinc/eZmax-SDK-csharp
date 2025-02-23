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
    /// Request for PUT /3/object/ezsignfolder/{pkiEzsignfolderID}
    /// </summary>
    [DataContract(Name = "ezsignfolder-editObject-v3-Request")]
    public partial class EzsignfolderEditObjectV3Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderEditObjectV3Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderEditObjectV3Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderEditObjectV3Request" /> class.
        /// </summary>
        /// <param name="objEzsignfolder">objEzsignfolder (required).</param>
        public EzsignfolderEditObjectV3Request(EzsignfolderRequestCompoundV3 objEzsignfolder = default(EzsignfolderRequestCompoundV3))
        {
            // to ensure "objEzsignfolder" is required (not null)
            if (objEzsignfolder == null)
            {
                throw new ArgumentNullException("objEzsignfolder is a required property for EzsignfolderEditObjectV3Request and cannot be null");
            }
            this.ObjEzsignfolder = objEzsignfolder;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignfolder
        /// </summary>
        [DataMember(Name = "objEzsignfolder", IsRequired = true, EmitDefaultValue = true)]
        public EzsignfolderRequestCompoundV3 ObjEzsignfolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignfolderEditObjectV3Request {\n");
            sb.Append("  ObjEzsignfolder: ").Append(ObjEzsignfolder).Append("\n");
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
