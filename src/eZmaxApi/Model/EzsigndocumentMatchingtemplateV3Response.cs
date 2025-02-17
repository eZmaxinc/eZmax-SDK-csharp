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
    /// A Ezsigndocument createObject Response
    /// </summary>
    [DataContract(Name = "ezsigndocument-matchingtemplate-v3-Response")]
    public partial class EzsigndocumentMatchingtemplateV3Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentMatchingtemplateV3Response" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplateID">The unique ID of the Ezsigntemplate.</param>
        /// <param name="pkiEzsigntemplateglobalID">The unique ID of the Ezsigntemplateglobal.</param>
        public EzsigndocumentMatchingtemplateV3Response(int pkiEzsigntemplateID = default(int), int pkiEzsigntemplateglobalID = default(int))
        {
            this.PkiEzsigntemplateID = pkiEzsigntemplateID;
            this.PkiEzsigntemplateglobalID = pkiEzsigntemplateglobalID;
        }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        /* <example>36</example>*/
        [DataMember(Name = "pkiEzsigntemplateID", EmitDefaultValue = false)]
        public int PkiEzsigntemplateID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplateglobal
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplateglobal</value>
        /* <example>36</example>*/
        [DataMember(Name = "pkiEzsigntemplateglobalID", EmitDefaultValue = false)]
        public int PkiEzsigntemplateglobalID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigndocumentMatchingtemplateV3Response {\n");
            sb.Append("  PkiEzsigntemplateID: ").Append(PkiEzsigntemplateID).Append("\n");
            sb.Append("  PkiEzsigntemplateglobalID: ").Append(PkiEzsigntemplateglobalID).Append("\n");
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
            // PkiEzsigntemplateID (int) minimum
            if (this.PkiEzsigntemplateID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzsigntemplateID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplateID" });
            }

            // PkiEzsigntemplateglobalID (int) minimum
            if (this.PkiEzsigntemplateglobalID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzsigntemplateglobalID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplateglobalID" });
            }

            yield break;
        }
    }

}
