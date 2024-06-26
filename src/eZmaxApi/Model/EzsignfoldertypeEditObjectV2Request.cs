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
    /// Request for PUT /2/object/ezsignfoldertype/{pkiEzsignfoldertypeID}
    /// </summary>
    [DataContract(Name = "ezsignfoldertype-editObject-v2-Request")]
    public partial class EzsignfoldertypeEditObjectV2Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldertypeEditObjectV2Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldertypeEditObjectV2Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldertypeEditObjectV2Request" /> class.
        /// </summary>
        /// <param name="objEzsignfoldertype">objEzsignfoldertype (required).</param>
        public EzsignfoldertypeEditObjectV2Request(EzsignfoldertypeRequestCompoundV2 objEzsignfoldertype = default(EzsignfoldertypeRequestCompoundV2))
        {
            // to ensure "objEzsignfoldertype" is required (not null)
            if (objEzsignfoldertype == null)
            {
                throw new ArgumentNullException("objEzsignfoldertype is a required property for EzsignfoldertypeEditObjectV2Request and cannot be null");
            }
            this.ObjEzsignfoldertype = objEzsignfoldertype;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignfoldertype
        /// </summary>
        [DataMember(Name = "objEzsignfoldertype", IsRequired = true, EmitDefaultValue = true)]
        public EzsignfoldertypeRequestCompoundV2 ObjEzsignfoldertype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignfoldertypeEditObjectV2Request {\n");
            sb.Append("  ObjEzsignfoldertype: ").Append(ObjEzsignfoldertype).Append("\n");
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
