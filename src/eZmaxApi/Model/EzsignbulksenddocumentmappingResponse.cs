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
    /// A Ezsignbulksenddocumentmapping Object
    /// </summary>
    [DataContract(Name = "ezsignbulksenddocumentmapping-Response")]
    public partial class EzsignbulksenddocumentmappingResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksenddocumentmappingResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignbulksenddocumentmappingResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksenddocumentmappingResponse" /> class.
        /// </summary>
        /// <param name="pkiEzsignbulksenddocumentmappingID">The unique ID of the Ezsignbulksenddocumentmapping. (required).</param>
        /// <param name="fkiEzsignbulksendID">The unique ID of the Ezsignbulksend (required).</param>
        /// <param name="fkiEzsigntemplatepackageID">The unique ID of the Ezsigntemplatepackage.</param>
        /// <param name="fkiEzsigntemplateID">The unique ID of the Ezsigntemplate.</param>
        /// <param name="iEzsignbulksenddocumentmappingOrder">The order in which the Ezsigntemplate or Ezsigntemplatepackage will be presented to the signatory in the Ezsignfolder. (required).</param>
        public EzsignbulksenddocumentmappingResponse(int pkiEzsignbulksenddocumentmappingID = default(int), int fkiEzsignbulksendID = default(int), int fkiEzsigntemplatepackageID = default(int), int fkiEzsigntemplateID = default(int), int iEzsignbulksenddocumentmappingOrder = default(int))
        {
            this.PkiEzsignbulksenddocumentmappingID = pkiEzsignbulksenddocumentmappingID;
            this.FkiEzsignbulksendID = fkiEzsignbulksendID;
            this.IEzsignbulksenddocumentmappingOrder = iEzsignbulksenddocumentmappingOrder;
            this.FkiEzsigntemplatepackageID = fkiEzsigntemplatepackageID;
            this.FkiEzsigntemplateID = fkiEzsigntemplateID;
        }

        /// <summary>
        /// The unique ID of the Ezsignbulksenddocumentmapping.
        /// </summary>
        /// <value>The unique ID of the Ezsignbulksenddocumentmapping.</value>
        /* <example>48</example>*/
        [DataMember(Name = "pkiEzsignbulksenddocumentmappingID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiEzsignbulksenddocumentmappingID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignbulksend
        /// </summary>
        /// <value>The unique ID of the Ezsignbulksend</value>
        /* <example>8</example>*/
        [DataMember(Name = "fkiEzsignbulksendID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiEzsignbulksendID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplatepackage
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatepackage</value>
        /* <example>99</example>*/
        [DataMember(Name = "fkiEzsigntemplatepackageID", EmitDefaultValue = false)]
        public int FkiEzsigntemplatepackageID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        /* <example>36</example>*/
        [DataMember(Name = "fkiEzsigntemplateID", EmitDefaultValue = false)]
        public int FkiEzsigntemplateID { get; set; }

        /// <summary>
        /// The order in which the Ezsigntemplate or Ezsigntemplatepackage will be presented to the signatory in the Ezsignfolder.
        /// </summary>
        /// <value>The order in which the Ezsigntemplate or Ezsigntemplatepackage will be presented to the signatory in the Ezsignfolder.</value>
        /* <example>1</example>*/
        [DataMember(Name = "iEzsignbulksenddocumentmappingOrder", IsRequired = true, EmitDefaultValue = true)]
        public int IEzsignbulksenddocumentmappingOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignbulksenddocumentmappingResponse {\n");
            sb.Append("  PkiEzsignbulksenddocumentmappingID: ").Append(PkiEzsignbulksenddocumentmappingID).Append("\n");
            sb.Append("  FkiEzsignbulksendID: ").Append(FkiEzsignbulksendID).Append("\n");
            sb.Append("  FkiEzsigntemplatepackageID: ").Append(FkiEzsigntemplatepackageID).Append("\n");
            sb.Append("  FkiEzsigntemplateID: ").Append(FkiEzsigntemplateID).Append("\n");
            sb.Append("  IEzsignbulksenddocumentmappingOrder: ").Append(IEzsignbulksenddocumentmappingOrder).Append("\n");
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
            // PkiEzsignbulksenddocumentmappingID (int) minimum
            if (this.PkiEzsignbulksenddocumentmappingID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzsignbulksenddocumentmappingID, must be a value greater than or equal to 0.", new [] { "PkiEzsignbulksenddocumentmappingID" });
            }

            // FkiEzsignbulksendID (int) minimum
            if (this.FkiEzsignbulksendID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsignbulksendID, must be a value greater than or equal to 0.", new [] { "FkiEzsignbulksendID" });
            }

            // FkiEzsigntemplatepackageID (int) minimum
            if (this.FkiEzsigntemplatepackageID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsigntemplatepackageID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplatepackageID" });
            }

            // FkiEzsigntemplateID (int) minimum
            if (this.FkiEzsigntemplateID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsigntemplateID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplateID" });
            }

            // IEzsignbulksenddocumentmappingOrder (int) minimum
            if (this.IEzsignbulksenddocumentmappingOrder < (int)0)
            {
                yield return new ValidationResult("Invalid value for IEzsignbulksenddocumentmappingOrder, must be a value greater than or equal to 0.", new [] { "IEzsignbulksenddocumentmappingOrder" });
            }

            yield break;
        }
    }

}
