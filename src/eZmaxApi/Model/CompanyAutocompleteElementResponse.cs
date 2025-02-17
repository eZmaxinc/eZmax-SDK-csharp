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
    /// A Company AutocompleteElement Response
    /// </summary>
    [DataContract(Name = "company-AutocompleteElement-Response")]
    public partial class CompanyAutocompleteElementResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyAutocompleteElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyAutocompleteElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyAutocompleteElementResponse" /> class.
        /// </summary>
        /// <param name="pkiCompanyID">The unique ID of the Company (required).</param>
        /// <param name="sCompanyNameX">The Name of the Company in the language of the requester (required).</param>
        /// <param name="bCompanyIsactive">Whether the Company is active or not (required).</param>
        public CompanyAutocompleteElementResponse(int pkiCompanyID = default(int), string sCompanyNameX = default(string), bool bCompanyIsactive = default(bool))
        {
            this.PkiCompanyID = pkiCompanyID;
            // to ensure "sCompanyNameX" is required (not null)
            if (sCompanyNameX == null)
            {
                throw new ArgumentNullException("sCompanyNameX is a required property for CompanyAutocompleteElementResponse and cannot be null");
            }
            this.SCompanyNameX = sCompanyNameX;
            this.BCompanyIsactive = bCompanyIsactive;
        }

        /// <summary>
        /// The unique ID of the Company
        /// </summary>
        /// <value>The unique ID of the Company</value>
        /* <example>1</example>*/
        [DataMember(Name = "pkiCompanyID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiCompanyID { get; set; }

        /// <summary>
        /// The Name of the Company in the language of the requester
        /// </summary>
        /// <value>The Name of the Company in the language of the requester</value>
        /* <example>Acme inc.</example>*/
        [DataMember(Name = "sCompanyNameX", IsRequired = true, EmitDefaultValue = true)]
        public string SCompanyNameX { get; set; }

        /// <summary>
        /// Whether the Company is active or not
        /// </summary>
        /// <value>Whether the Company is active or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bCompanyIsactive", IsRequired = true, EmitDefaultValue = true)]
        public bool BCompanyIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyAutocompleteElementResponse {\n");
            sb.Append("  PkiCompanyID: ").Append(PkiCompanyID).Append("\n");
            sb.Append("  SCompanyNameX: ").Append(SCompanyNameX).Append("\n");
            sb.Append("  BCompanyIsactive: ").Append(BCompanyIsactive).Append("\n");
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
            // PkiCompanyID (int) maximum
            if (this.PkiCompanyID > (int)255)
            {
                yield return new ValidationResult("Invalid value for PkiCompanyID, must be a value less than or equal to 255.", new [] { "PkiCompanyID" });
            }

            // PkiCompanyID (int) minimum
            if (this.PkiCompanyID < (int)1)
            {
                yield return new ValidationResult("Invalid value for PkiCompanyID, must be a value greater than or equal to 1.", new [] { "PkiCompanyID" });
            }

            yield break;
        }
    }

}
