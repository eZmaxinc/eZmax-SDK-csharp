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
    /// Request for PUT /1/object/ezsignsigningreason/{pkiEzsignsigningreasonID}
    /// </summary>
    [DataContract(Name = "ezsignsigningreason-editObject-v1-Request")]
    public partial class EzsignsigningreasonEditObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonEditObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsigningreasonEditObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignsigningreason">objEzsignsigningreason (required).</param>
        public EzsignsigningreasonEditObjectV1Request(EzsignsigningreasonRequestCompound objEzsignsigningreason = default(EzsignsigningreasonRequestCompound))
        {
            // to ensure "objEzsignsigningreason" is required (not null)
            if (objEzsignsigningreason == null)
            {
                throw new ArgumentNullException("objEzsignsigningreason is a required property for EzsignsigningreasonEditObjectV1Request and cannot be null");
            }
            this.ObjEzsignsigningreason = objEzsignsigningreason;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignsigningreason
        /// </summary>
        [DataMember(Name = "objEzsignsigningreason", IsRequired = true, EmitDefaultValue = true)]
        public EzsignsigningreasonRequestCompound ObjEzsignsigningreason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignsigningreasonEditObjectV1Request {\n");
            sb.Append("  ObjEzsignsigningreason: ").Append(ObjEzsignsigningreason).Append("\n");
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