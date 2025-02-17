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
    /// Request for POST /2/object/ezsignfolder/{pkiEzsignfolderID}/reorder
    /// </summary>
    [DataContract(Name = "Custom-Ezsigndocument-Request")]
    public partial class CustomEzsigndocumentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsigndocumentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEzsigndocumentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEzsigndocumentRequest" /> class.
        /// </summary>
        /// <param name="pkiEzsigndocumentID">The unique ID of the Ezsigndocument (required).</param>
        /// <param name="aObjEzsigndocumentdependency">aObjEzsigndocumentdependency (required).</param>
        public CustomEzsigndocumentRequest(int pkiEzsigndocumentID = default(int), List<EzsigndocumentdependencyRequestCompound> aObjEzsigndocumentdependency = default(List<EzsigndocumentdependencyRequestCompound>))
        {
            this.PkiEzsigndocumentID = pkiEzsigndocumentID;
            // to ensure "aObjEzsigndocumentdependency" is required (not null)
            if (aObjEzsigndocumentdependency == null)
            {
                throw new ArgumentNullException("aObjEzsigndocumentdependency is a required property for CustomEzsigndocumentRequest and cannot be null");
            }
            this.AObjEzsigndocumentdependency = aObjEzsigndocumentdependency;
        }

        /// <summary>
        /// The unique ID of the Ezsigndocument
        /// </summary>
        /// <value>The unique ID of the Ezsigndocument</value>
        /* <example>97</example>*/
        [DataMember(Name = "pkiEzsigndocumentID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsigndocumentdependency
        /// </summary>
        [DataMember(Name = "a_objEzsigndocumentdependency", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsigndocumentdependencyRequestCompound> AObjEzsigndocumentdependency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomEzsigndocumentRequest {\n");
            sb.Append("  PkiEzsigndocumentID: ").Append(PkiEzsigndocumentID).Append("\n");
            sb.Append("  AObjEzsigndocumentdependency: ").Append(AObjEzsigndocumentdependency).Append("\n");
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
            // PkiEzsigndocumentID (int) minimum
            if (this.PkiEzsigndocumentID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzsigndocumentID, must be a value greater than or equal to 0.", new [] { "PkiEzsigndocumentID" });
            }

            yield break;
        }
    }

}
