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
    /// A Ezmaxinvoicingsummaryexternal Object
    /// </summary>
    [DataContract(Name = "ezmaxinvoicingsummaryexternal-Response")]
    public partial class EzmaxinvoicingsummaryexternalResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingsummaryexternalResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzmaxinvoicingsummaryexternalResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingsummaryexternalResponse" /> class.
        /// </summary>
        /// <param name="pkiEzmaxinvoicingsummaryexternalID">The unique ID of the Ezmaxinvoicingsummaryexternal.</param>
        /// <param name="fkiEzmaxinvoicingID">The unique ID of the Ezmaxinvoicing.</param>
        /// <param name="fkiBillingentityexternalID">The unique ID of the Billingentityexternal (required).</param>
        /// <param name="sBillingentityexternalDescription">The description of the Billingentityexternal (required).</param>
        /// <param name="sEzmaxinvoicingsummaryexternalDescription">The description of the Ezmaxinvoicingsummaryexternal (required).</param>
        public EzmaxinvoicingsummaryexternalResponse(int pkiEzmaxinvoicingsummaryexternalID = default(int), int fkiEzmaxinvoicingID = default(int), int fkiBillingentityexternalID = default(int), string sBillingentityexternalDescription = default(string), string sEzmaxinvoicingsummaryexternalDescription = default(string))
        {
            this.FkiBillingentityexternalID = fkiBillingentityexternalID;
            // to ensure "sBillingentityexternalDescription" is required (not null)
            if (sBillingentityexternalDescription == null)
            {
                throw new ArgumentNullException("sBillingentityexternalDescription is a required property for EzmaxinvoicingsummaryexternalResponse and cannot be null");
            }
            this.SBillingentityexternalDescription = sBillingentityexternalDescription;
            // to ensure "sEzmaxinvoicingsummaryexternalDescription" is required (not null)
            if (sEzmaxinvoicingsummaryexternalDescription == null)
            {
                throw new ArgumentNullException("sEzmaxinvoicingsummaryexternalDescription is a required property for EzmaxinvoicingsummaryexternalResponse and cannot be null");
            }
            this.SEzmaxinvoicingsummaryexternalDescription = sEzmaxinvoicingsummaryexternalDescription;
            this.PkiEzmaxinvoicingsummaryexternalID = pkiEzmaxinvoicingsummaryexternalID;
            this.FkiEzmaxinvoicingID = fkiEzmaxinvoicingID;
        }

        /// <summary>
        /// The unique ID of the Ezmaxinvoicingsummaryexternal
        /// </summary>
        /// <value>The unique ID of the Ezmaxinvoicingsummaryexternal</value>
        /* <example>177</example>*/
        [DataMember(Name = "pkiEzmaxinvoicingsummaryexternalID", EmitDefaultValue = false)]
        public int PkiEzmaxinvoicingsummaryexternalID { get; set; }

        /// <summary>
        /// The unique ID of the Ezmaxinvoicing
        /// </summary>
        /// <value>The unique ID of the Ezmaxinvoicing</value>
        /* <example>28</example>*/
        [DataMember(Name = "fkiEzmaxinvoicingID", EmitDefaultValue = false)]
        public int FkiEzmaxinvoicingID { get; set; }

        /// <summary>
        /// The unique ID of the Billingentityexternal
        /// </summary>
        /// <value>The unique ID of the Billingentityexternal</value>
        /* <example>83</example>*/
        [DataMember(Name = "fkiBillingentityexternalID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiBillingentityexternalID { get; set; }

        /// <summary>
        /// The description of the Billingentityexternal
        /// </summary>
        /// <value>The description of the Billingentityexternal</value>
        /* <example>ACME Inc</example>*/
        [DataMember(Name = "sBillingentityexternalDescription", IsRequired = true, EmitDefaultValue = true)]
        public string SBillingentityexternalDescription { get; set; }

        /// <summary>
        /// The description of the Ezmaxinvoicingsummaryexternal
        /// </summary>
        /// <value>The description of the Ezmaxinvoicingsummaryexternal</value>
        /* <example>Company Demo</example>*/
        [DataMember(Name = "sEzmaxinvoicingsummaryexternalDescription", IsRequired = true, EmitDefaultValue = true)]
        public string SEzmaxinvoicingsummaryexternalDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzmaxinvoicingsummaryexternalResponse {\n");
            sb.Append("  PkiEzmaxinvoicingsummaryexternalID: ").Append(PkiEzmaxinvoicingsummaryexternalID).Append("\n");
            sb.Append("  FkiEzmaxinvoicingID: ").Append(FkiEzmaxinvoicingID).Append("\n");
            sb.Append("  FkiBillingentityexternalID: ").Append(FkiBillingentityexternalID).Append("\n");
            sb.Append("  SBillingentityexternalDescription: ").Append(SBillingentityexternalDescription).Append("\n");
            sb.Append("  SEzmaxinvoicingsummaryexternalDescription: ").Append(SEzmaxinvoicingsummaryexternalDescription).Append("\n");
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
            // PkiEzmaxinvoicingsummaryexternalID (int) minimum
            if (this.PkiEzmaxinvoicingsummaryexternalID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzmaxinvoicingsummaryexternalID, must be a value greater than or equal to 0.", new [] { "PkiEzmaxinvoicingsummaryexternalID" });
            }

            // FkiEzmaxinvoicingID (int) minimum
            if (this.FkiEzmaxinvoicingID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzmaxinvoicingID, must be a value greater than or equal to 0.", new [] { "FkiEzmaxinvoicingID" });
            }

            // FkiBillingentityexternalID (int) minimum
            if (this.FkiBillingentityexternalID < (int)1)
            {
                yield return new ValidationResult("Invalid value for FkiBillingentityexternalID, must be a value greater than or equal to 1.", new [] { "FkiBillingentityexternalID" });
            }

            // SEzmaxinvoicingsummaryexternalDescription (string) maxLength
            if (this.SEzmaxinvoicingsummaryexternalDescription != null && this.SEzmaxinvoicingsummaryexternalDescription.Length > 70)
            {
                yield return new ValidationResult("Invalid value for SEzmaxinvoicingsummaryexternalDescription, length must be less than 70.", new [] { "SEzmaxinvoicingsummaryexternalDescription" });
            }

            yield break;
        }
    }

}
