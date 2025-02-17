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
    /// Payload for GET /2/object/ezsignfoldertype/{pkiEzsignfoldertypeID}
    /// </summary>
    [DataContract(Name = "ezsignfoldertype-getObject-v2-Response-mPayload")]
    public partial class EzsignfoldertypeGetObjectV2ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldertypeGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldertypeGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldertypeGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objEzsignfoldertype">objEzsignfoldertype (required).</param>
        public EzsignfoldertypeGetObjectV2ResponseMPayload(EzsignfoldertypeResponseCompound objEzsignfoldertype = default(EzsignfoldertypeResponseCompound))
        {
            // to ensure "objEzsignfoldertype" is required (not null)
            if (objEzsignfoldertype == null)
            {
                throw new ArgumentNullException("objEzsignfoldertype is a required property for EzsignfoldertypeGetObjectV2ResponseMPayload and cannot be null");
            }
            this.ObjEzsignfoldertype = objEzsignfoldertype;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignfoldertype
        /// </summary>
        [DataMember(Name = "objEzsignfoldertype", IsRequired = true, EmitDefaultValue = true)]
        public EzsignfoldertypeResponseCompound ObjEzsignfoldertype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignfoldertypeGetObjectV2ResponseMPayload {\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
