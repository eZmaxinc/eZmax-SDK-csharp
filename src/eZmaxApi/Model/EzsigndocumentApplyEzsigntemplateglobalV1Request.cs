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
    /// Request for POST /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyEzsigntemplateglobal
    /// </summary>
    [DataContract(Name = "ezsigndocument-applyEzsigntemplateglobal-v1-Request")]
    public partial class EzsigndocumentApplyEzsigntemplateglobalV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateglobalV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentApplyEzsigntemplateglobalV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateglobalV1Request" /> class.
        /// </summary>
        /// <param name="fkiEzsigntemplateglobalID">The unique ID of the Ezsigntemplateglobal (required).</param>
        /// <param name="aSEzsigntemplateglobalsigner">aSEzsigntemplateglobalsigner (required).</param>
        /// <param name="aPkiEzsignfoldersignerassociationID">aPkiEzsignfoldersignerassociationID (required).</param>
        public EzsigndocumentApplyEzsigntemplateglobalV1Request(int fkiEzsigntemplateglobalID = default(int), List<string> aSEzsigntemplateglobalsigner = default(List<string>), List<int> aPkiEzsignfoldersignerassociationID = default(List<int>))
        {
            this.FkiEzsigntemplateglobalID = fkiEzsigntemplateglobalID;
            // to ensure "aSEzsigntemplateglobalsigner" is required (not null)
            if (aSEzsigntemplateglobalsigner == null)
            {
                throw new ArgumentNullException("aSEzsigntemplateglobalsigner is a required property for EzsigndocumentApplyEzsigntemplateglobalV1Request and cannot be null");
            }
            this.ASEzsigntemplateglobalsigner = aSEzsigntemplateglobalsigner;
            // to ensure "aPkiEzsignfoldersignerassociationID" is required (not null)
            if (aPkiEzsignfoldersignerassociationID == null)
            {
                throw new ArgumentNullException("aPkiEzsignfoldersignerassociationID is a required property for EzsigndocumentApplyEzsigntemplateglobalV1Request and cannot be null");
            }
            this.APkiEzsignfoldersignerassociationID = aPkiEzsignfoldersignerassociationID;
        }

        /// <summary>
        /// The unique ID of the Ezsigntemplateglobal
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplateglobal</value>
        /* <example>36</example>*/
        [DataMember(Name = "fkiEzsigntemplateglobalID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiEzsigntemplateglobalID { get; set; }

        /// <summary>
        /// Gets or Sets ASEzsigntemplateglobalsigner
        /// </summary>
        [DataMember(Name = "a_sEzsigntemplateglobalsigner", IsRequired = true, EmitDefaultValue = true)]
        public List<string> ASEzsigntemplateglobalsigner { get; set; }

        /// <summary>
        /// Gets or Sets APkiEzsignfoldersignerassociationID
        /// </summary>
        [DataMember(Name = "a_pkiEzsignfoldersignerassociationID", IsRequired = true, EmitDefaultValue = true)]
        public List<int> APkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigndocumentApplyEzsigntemplateglobalV1Request {\n");
            sb.Append("  FkiEzsigntemplateglobalID: ").Append(FkiEzsigntemplateglobalID).Append("\n");
            sb.Append("  ASEzsigntemplateglobalsigner: ").Append(ASEzsigntemplateglobalsigner).Append("\n");
            sb.Append("  APkiEzsignfoldersignerassociationID: ").Append(APkiEzsignfoldersignerassociationID).Append("\n");
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
            // FkiEzsigntemplateglobalID (int) minimum
            if (this.FkiEzsigntemplateglobalID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntemplateglobalID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplateglobalID" });
            }

            yield break;
        }
    }

}