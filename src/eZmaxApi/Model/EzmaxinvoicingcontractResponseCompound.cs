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
    /// A Ezmaxinvoicingcontract Object
    /// </summary>
    [DataContract(Name = "ezmaxinvoicingcontract-ResponseCompound")]
    public partial class EzmaxinvoicingcontractResponseCompound : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EEzmaxinvoicingcontractPaymenttype
        /// </summary>
        [DataMember(Name = "eEzmaxinvoicingcontractPaymenttype", IsRequired = true, EmitDefaultValue = true)]
        public FieldEEzmaxinvoicingcontractPaymenttype EEzmaxinvoicingcontractPaymenttype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingcontractResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzmaxinvoicingcontractResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingcontractResponseCompound" /> class.
        /// </summary>
        /// <param name="pkiEzmaxinvoicingcontractID">The unique ID of the Ezmaxinvoicingcontract (required).</param>
        /// <param name="eEzmaxinvoicingcontractPaymenttype">eEzmaxinvoicingcontractPaymenttype (required).</param>
        /// <param name="iEzmaxinvoicingcontractLength">The length in years of the Ezmaxinvoicingcontract (required).</param>
        /// <param name="dtEzmaxinvoicingcontractStart">The start date of the Ezmaxinvoicingcontract (required).</param>
        /// <param name="dtEzmaxinvoicingcontractEnd">The end date of the Ezmaxinvoicingcontract (required).</param>
        /// <param name="dEzmaxinvoicingcontractLicense">The price of the license (required).</param>
        /// <param name="dEzmaxinvoicingcontract121qa">The price for 121QA (required).</param>
        /// <param name="bEzmaxinvoicingcontractEzsignallagents">Whether eZsign is for all agents (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public EzmaxinvoicingcontractResponseCompound(int pkiEzmaxinvoicingcontractID = default(int), FieldEEzmaxinvoicingcontractPaymenttype eEzmaxinvoicingcontractPaymenttype = default(FieldEEzmaxinvoicingcontractPaymenttype), int iEzmaxinvoicingcontractLength = default(int), string dtEzmaxinvoicingcontractStart = default(string), string dtEzmaxinvoicingcontractEnd = default(string), string dEzmaxinvoicingcontractLicense = default(string), string dEzmaxinvoicingcontract121qa = default(string), bool bEzmaxinvoicingcontractEzsignallagents = default(bool), CommonAudit objAudit = default(CommonAudit))
        {
            this.PkiEzmaxinvoicingcontractID = pkiEzmaxinvoicingcontractID;
            this.EEzmaxinvoicingcontractPaymenttype = eEzmaxinvoicingcontractPaymenttype;
            this.IEzmaxinvoicingcontractLength = iEzmaxinvoicingcontractLength;
            // to ensure "dtEzmaxinvoicingcontractStart" is required (not null)
            if (dtEzmaxinvoicingcontractStart == null)
            {
                throw new ArgumentNullException("dtEzmaxinvoicingcontractStart is a required property for EzmaxinvoicingcontractResponseCompound and cannot be null");
            }
            this.DtEzmaxinvoicingcontractStart = dtEzmaxinvoicingcontractStart;
            // to ensure "dtEzmaxinvoicingcontractEnd" is required (not null)
            if (dtEzmaxinvoicingcontractEnd == null)
            {
                throw new ArgumentNullException("dtEzmaxinvoicingcontractEnd is a required property for EzmaxinvoicingcontractResponseCompound and cannot be null");
            }
            this.DtEzmaxinvoicingcontractEnd = dtEzmaxinvoicingcontractEnd;
            // to ensure "dEzmaxinvoicingcontractLicense" is required (not null)
            if (dEzmaxinvoicingcontractLicense == null)
            {
                throw new ArgumentNullException("dEzmaxinvoicingcontractLicense is a required property for EzmaxinvoicingcontractResponseCompound and cannot be null");
            }
            this.DEzmaxinvoicingcontractLicense = dEzmaxinvoicingcontractLicense;
            // to ensure "dEzmaxinvoicingcontract121qa" is required (not null)
            if (dEzmaxinvoicingcontract121qa == null)
            {
                throw new ArgumentNullException("dEzmaxinvoicingcontract121qa is a required property for EzmaxinvoicingcontractResponseCompound and cannot be null");
            }
            this.DEzmaxinvoicingcontract121qa = dEzmaxinvoicingcontract121qa;
            this.BEzmaxinvoicingcontractEzsignallagents = bEzmaxinvoicingcontractEzsignallagents;
            // to ensure "objAudit" is required (not null)
            if (objAudit == null)
            {
                throw new ArgumentNullException("objAudit is a required property for EzmaxinvoicingcontractResponseCompound and cannot be null");
            }
            this.ObjAudit = objAudit;
        }

        /// <summary>
        /// The unique ID of the Ezmaxinvoicingcontract
        /// </summary>
        /// <value>The unique ID of the Ezmaxinvoicingcontract</value>
        /* <example>28</example>*/
        [DataMember(Name = "pkiEzmaxinvoicingcontractID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiEzmaxinvoicingcontractID { get; set; }

        /// <summary>
        /// The length in years of the Ezmaxinvoicingcontract
        /// </summary>
        /// <value>The length in years of the Ezmaxinvoicingcontract</value>
        /* <example>3</example>*/
        [DataMember(Name = "iEzmaxinvoicingcontractLength", IsRequired = true, EmitDefaultValue = true)]
        public int IEzmaxinvoicingcontractLength { get; set; }

        /// <summary>
        /// The start date of the Ezmaxinvoicingcontract
        /// </summary>
        /// <value>The start date of the Ezmaxinvoicingcontract</value>
        /* <example>2020-12-31</example>*/
        [DataMember(Name = "dtEzmaxinvoicingcontractStart", IsRequired = true, EmitDefaultValue = true)]
        public string DtEzmaxinvoicingcontractStart { get; set; }

        /// <summary>
        /// The end date of the Ezmaxinvoicingcontract
        /// </summary>
        /// <value>The end date of the Ezmaxinvoicingcontract</value>
        /* <example>2020-12-31</example>*/
        [DataMember(Name = "dtEzmaxinvoicingcontractEnd", IsRequired = true, EmitDefaultValue = true)]
        public string DtEzmaxinvoicingcontractEnd { get; set; }

        /// <summary>
        /// The price of the license
        /// </summary>
        /// <value>The price of the license</value>
        /* <example>335.42</example>*/
        [DataMember(Name = "dEzmaxinvoicingcontractLicense", IsRequired = true, EmitDefaultValue = true)]
        public string DEzmaxinvoicingcontractLicense { get; set; }

        /// <summary>
        /// The price for 121QA
        /// </summary>
        /// <value>The price for 121QA</value>
        /* <example>295.48</example>*/
        [DataMember(Name = "dEzmaxinvoicingcontract121qa", IsRequired = true, EmitDefaultValue = true)]
        public string DEzmaxinvoicingcontract121qa { get; set; }

        /// <summary>
        /// Whether eZsign is for all agents
        /// </summary>
        /// <value>Whether eZsign is for all agents</value>
        /* <example>true</example>*/
        [DataMember(Name = "bEzmaxinvoicingcontractEzsignallagents", IsRequired = true, EmitDefaultValue = true)]
        public bool BEzmaxinvoicingcontractEzsignallagents { get; set; }

        /// <summary>
        /// Gets or Sets ObjAudit
        /// </summary>
        [DataMember(Name = "objAudit", IsRequired = true, EmitDefaultValue = true)]
        public CommonAudit ObjAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzmaxinvoicingcontractResponseCompound {\n");
            sb.Append("  PkiEzmaxinvoicingcontractID: ").Append(PkiEzmaxinvoicingcontractID).Append("\n");
            sb.Append("  EEzmaxinvoicingcontractPaymenttype: ").Append(EEzmaxinvoicingcontractPaymenttype).Append("\n");
            sb.Append("  IEzmaxinvoicingcontractLength: ").Append(IEzmaxinvoicingcontractLength).Append("\n");
            sb.Append("  DtEzmaxinvoicingcontractStart: ").Append(DtEzmaxinvoicingcontractStart).Append("\n");
            sb.Append("  DtEzmaxinvoicingcontractEnd: ").Append(DtEzmaxinvoicingcontractEnd).Append("\n");
            sb.Append("  DEzmaxinvoicingcontractLicense: ").Append(DEzmaxinvoicingcontractLicense).Append("\n");
            sb.Append("  DEzmaxinvoicingcontract121qa: ").Append(DEzmaxinvoicingcontract121qa).Append("\n");
            sb.Append("  BEzmaxinvoicingcontractEzsignallagents: ").Append(BEzmaxinvoicingcontractEzsignallagents).Append("\n");
            sb.Append("  ObjAudit: ").Append(ObjAudit).Append("\n");
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
            // PkiEzmaxinvoicingcontractID (int) minimum
            if (this.PkiEzmaxinvoicingcontractID < (int)1)
            {
                yield return new ValidationResult("Invalid value for PkiEzmaxinvoicingcontractID, must be a value greater than or equal to 1.", new [] { "PkiEzmaxinvoicingcontractID" });
            }

            // IEzmaxinvoicingcontractLength (int) minimum
            if (this.IEzmaxinvoicingcontractLength < (int)1)
            {
                yield return new ValidationResult("Invalid value for IEzmaxinvoicingcontractLength, must be a value greater than or equal to 1.", new [] { "IEzmaxinvoicingcontractLength" });
            }

            if (this.DEzmaxinvoicingcontractLicense != null) {
                // DEzmaxinvoicingcontractLicense (string) pattern
                Regex regexDEzmaxinvoicingcontractLicense = new Regex(@"^-{0,1}[\d]{1,9}?\.[\d]{2}$", RegexOptions.CultureInvariant);
                if (!regexDEzmaxinvoicingcontractLicense.Match(this.DEzmaxinvoicingcontractLicense).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DEzmaxinvoicingcontractLicense, must match a pattern of " + regexDEzmaxinvoicingcontractLicense, new [] { "DEzmaxinvoicingcontractLicense" });
                }
            }

            if (this.DEzmaxinvoicingcontract121qa != null) {
                // DEzmaxinvoicingcontract121qa (string) pattern
                Regex regexDEzmaxinvoicingcontract121qa = new Regex(@"^-{0,1}[\d]{1,9}?\.[\d]{2}$", RegexOptions.CultureInvariant);
                if (!regexDEzmaxinvoicingcontract121qa.Match(this.DEzmaxinvoicingcontract121qa).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DEzmaxinvoicingcontract121qa, must match a pattern of " + regexDEzmaxinvoicingcontract121qa, new [] { "DEzmaxinvoicingcontract121qa" });
                }
            }

            yield break;
        }
    }

}
