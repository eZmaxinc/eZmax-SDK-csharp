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
    /// A Taxassignment AutocompleteElement Response
    /// </summary>
    [DataContract(Name = "taxassignment-AutocompleteElement-Response")]
    public partial class TaxassignmentAutocompleteElementResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxassignmentAutocompleteElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxassignmentAutocompleteElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxassignmentAutocompleteElementResponse" /> class.
        /// </summary>
        /// <param name="sTaxassignmentDescriptionX">The description of the Taxassignment  in the language of the requester (required).</param>
        /// <param name="pkiTaxassignmentID">The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable| (required).</param>
        /// <param name="bTaxassignmentIsactive">Whether the Taxassignment is active or not (required).</param>
        public TaxassignmentAutocompleteElementResponse(string sTaxassignmentDescriptionX = default(string), int pkiTaxassignmentID = default(int), bool bTaxassignmentIsactive = default(bool))
        {
            // to ensure "sTaxassignmentDescriptionX" is required (not null)
            if (sTaxassignmentDescriptionX == null)
            {
                throw new ArgumentNullException("sTaxassignmentDescriptionX is a required property for TaxassignmentAutocompleteElementResponse and cannot be null");
            }
            this.STaxassignmentDescriptionX = sTaxassignmentDescriptionX;
            this.PkiTaxassignmentID = pkiTaxassignmentID;
            this.BTaxassignmentIsactive = bTaxassignmentIsactive;
        }

        /// <summary>
        /// The description of the Taxassignment  in the language of the requester
        /// </summary>
        /// <value>The description of the Taxassignment  in the language of the requester</value>
        /* <example>Default</example>*/
        [DataMember(Name = "sTaxassignmentDescriptionX", IsRequired = true, EmitDefaultValue = true)]
        public string STaxassignmentDescriptionX { get; set; }

        /// <summary>
        /// The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable|
        /// </summary>
        /// <value>The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable|</value>
        /* <example>1</example>*/
        [DataMember(Name = "pkiTaxassignmentID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiTaxassignmentID { get; set; }

        /// <summary>
        /// Whether the Taxassignment is active or not
        /// </summary>
        /// <value>Whether the Taxassignment is active or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bTaxassignmentIsactive", IsRequired = true, EmitDefaultValue = true)]
        public bool BTaxassignmentIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxassignmentAutocompleteElementResponse {\n");
            sb.Append("  STaxassignmentDescriptionX: ").Append(STaxassignmentDescriptionX).Append("\n");
            sb.Append("  PkiTaxassignmentID: ").Append(PkiTaxassignmentID).Append("\n");
            sb.Append("  BTaxassignmentIsactive: ").Append(BTaxassignmentIsactive).Append("\n");
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
            // PkiTaxassignmentID (int) maximum
            if (this.PkiTaxassignmentID > (int)15)
            {
                yield return new ValidationResult("Invalid value for PkiTaxassignmentID, must be a value less than or equal to 15.", new [] { "PkiTaxassignmentID" });
            }

            // PkiTaxassignmentID (int) minimum
            if (this.PkiTaxassignmentID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiTaxassignmentID, must be a value greater than or equal to 0.", new [] { "PkiTaxassignmentID" });
            }

            yield break;
        }
    }

}
