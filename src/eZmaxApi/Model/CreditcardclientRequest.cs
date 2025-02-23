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
    /// A Creditcardclient Object
    /// </summary>
    [DataContract(Name = "creditcardclient-Request")]
    public partial class CreditcardclientRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardclientRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditcardclientRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditcardclientRequest" /> class.
        /// </summary>
        /// <param name="pkiCreditcardclientID">The unique ID of the Creditcardclient.</param>
        /// <param name="fksCreditcardtokenID">The creditcard token identifier.</param>
        /// <param name="bCreditcardclientrelationIsdefault">Whether if it&#39;s the creditcardclient is the default one (required).</param>
        /// <param name="sCreditcardclientDescription">The description of the Creditcardclient (required).</param>
        /// <param name="bCreditcardclientAllowedcompanypayment">Whether if it&#39;s an allowedagencypayment (required).</param>
        /// <param name="bCreditcardclientAllowedezsign">Whether if it&#39;s an allowedroyallepageprotection (required).</param>
        /// <param name="bCreditcardclientAllowedtranquillit">Whether if it&#39;s an allowedtranquillit (required).</param>
        /// <param name="objCreditcarddetail">objCreditcarddetail (required).</param>
        /// <param name="sCreditcardclientCVV">The creditcard card CVV (required).</param>
        public CreditcardclientRequest(int pkiCreditcardclientID = default(int), string fksCreditcardtokenID = default(string), bool bCreditcardclientrelationIsdefault = default(bool), string sCreditcardclientDescription = default(string), bool bCreditcardclientAllowedcompanypayment = default(bool), bool bCreditcardclientAllowedezsign = default(bool), bool bCreditcardclientAllowedtranquillit = default(bool), CreditcarddetailRequest objCreditcarddetail = default(CreditcarddetailRequest), string sCreditcardclientCVV = default(string))
        {
            this.BCreditcardclientrelationIsdefault = bCreditcardclientrelationIsdefault;
            // to ensure "sCreditcardclientDescription" is required (not null)
            if (sCreditcardclientDescription == null)
            {
                throw new ArgumentNullException("sCreditcardclientDescription is a required property for CreditcardclientRequest and cannot be null");
            }
            this.SCreditcardclientDescription = sCreditcardclientDescription;
            this.BCreditcardclientAllowedcompanypayment = bCreditcardclientAllowedcompanypayment;
            this.BCreditcardclientAllowedezsign = bCreditcardclientAllowedezsign;
            this.BCreditcardclientAllowedtranquillit = bCreditcardclientAllowedtranquillit;
            // to ensure "objCreditcarddetail" is required (not null)
            if (objCreditcarddetail == null)
            {
                throw new ArgumentNullException("objCreditcarddetail is a required property for CreditcardclientRequest and cannot be null");
            }
            this.ObjCreditcarddetail = objCreditcarddetail;
            // to ensure "sCreditcardclientCVV" is required (not null)
            if (sCreditcardclientCVV == null)
            {
                throw new ArgumentNullException("sCreditcardclientCVV is a required property for CreditcardclientRequest and cannot be null");
            }
            this.SCreditcardclientCVV = sCreditcardclientCVV;
            this.PkiCreditcardclientID = pkiCreditcardclientID;
            this.FksCreditcardtokenID = fksCreditcardtokenID;
        }

        /// <summary>
        /// The unique ID of the Creditcardclient
        /// </summary>
        /// <value>The unique ID of the Creditcardclient</value>
        /* <example>114</example>*/
        [DataMember(Name = "pkiCreditcardclientID", EmitDefaultValue = false)]
        public int PkiCreditcardclientID { get; set; }

        /// <summary>
        /// The creditcard token identifier
        /// </summary>
        /// <value>The creditcard token identifier</value>
        /* <example>6B29FC40-CA47-1067-B31D-00DD010662DA</example>*/
        [DataMember(Name = "fksCreditcardtokenID", EmitDefaultValue = false)]
        public string FksCreditcardtokenID { get; set; }

        /// <summary>
        /// Whether if it&#39;s the creditcardclient is the default one
        /// </summary>
        /// <value>Whether if it&#39;s the creditcardclient is the default one</value>
        /* <example>true</example>*/
        [DataMember(Name = "bCreditcardclientrelationIsdefault", IsRequired = true, EmitDefaultValue = true)]
        public bool BCreditcardclientrelationIsdefault { get; set; }

        /// <summary>
        /// The description of the Creditcardclient
        /// </summary>
        /// <value>The description of the Creditcardclient</value>
        /* <example>Visa</example>*/
        [DataMember(Name = "sCreditcardclientDescription", IsRequired = true, EmitDefaultValue = true)]
        public string SCreditcardclientDescription { get; set; }

        /// <summary>
        /// Whether if it&#39;s an allowedagencypayment
        /// </summary>
        /// <value>Whether if it&#39;s an allowedagencypayment</value>
        /* <example>true</example>*/
        [DataMember(Name = "bCreditcardclientAllowedcompanypayment", IsRequired = true, EmitDefaultValue = true)]
        public bool BCreditcardclientAllowedcompanypayment { get; set; }

        /// <summary>
        /// Whether if it&#39;s an allowedroyallepageprotection
        /// </summary>
        /// <value>Whether if it&#39;s an allowedroyallepageprotection</value>
        /* <example>true</example>*/
        [DataMember(Name = "bCreditcardclientAllowedezsign", IsRequired = true, EmitDefaultValue = true)]
        public bool BCreditcardclientAllowedezsign { get; set; }

        /// <summary>
        /// Whether if it&#39;s an allowedtranquillit
        /// </summary>
        /// <value>Whether if it&#39;s an allowedtranquillit</value>
        /* <example>true</example>*/
        [DataMember(Name = "bCreditcardclientAllowedtranquillit", IsRequired = true, EmitDefaultValue = true)]
        public bool BCreditcardclientAllowedtranquillit { get; set; }

        /// <summary>
        /// Gets or Sets ObjCreditcarddetail
        /// </summary>
        [DataMember(Name = "objCreditcarddetail", IsRequired = true, EmitDefaultValue = true)]
        public CreditcarddetailRequest ObjCreditcarddetail { get; set; }

        /// <summary>
        /// The creditcard card CVV
        /// </summary>
        /// <value>The creditcard card CVV</value>
        [DataMember(Name = "sCreditcardclientCVV", IsRequired = true, EmitDefaultValue = true)]
        public string SCreditcardclientCVV { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditcardclientRequest {\n");
            sb.Append("  PkiCreditcardclientID: ").Append(PkiCreditcardclientID).Append("\n");
            sb.Append("  FksCreditcardtokenID: ").Append(FksCreditcardtokenID).Append("\n");
            sb.Append("  BCreditcardclientrelationIsdefault: ").Append(BCreditcardclientrelationIsdefault).Append("\n");
            sb.Append("  SCreditcardclientDescription: ").Append(SCreditcardclientDescription).Append("\n");
            sb.Append("  BCreditcardclientAllowedcompanypayment: ").Append(BCreditcardclientAllowedcompanypayment).Append("\n");
            sb.Append("  BCreditcardclientAllowedezsign: ").Append(BCreditcardclientAllowedezsign).Append("\n");
            sb.Append("  BCreditcardclientAllowedtranquillit: ").Append(BCreditcardclientAllowedtranquillit).Append("\n");
            sb.Append("  ObjCreditcarddetail: ").Append(ObjCreditcarddetail).Append("\n");
            sb.Append("  SCreditcardclientCVV: ").Append(SCreditcardclientCVV).Append("\n");
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
            // PkiCreditcardclientID (int) maximum
            if (this.PkiCreditcardclientID > (int)65535)
            {
                yield return new ValidationResult("Invalid value for PkiCreditcardclientID, must be a value less than or equal to 65535.", new [] { "PkiCreditcardclientID" });
            }

            // PkiCreditcardclientID (int) minimum
            if (this.PkiCreditcardclientID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiCreditcardclientID, must be a value greater than or equal to 0.", new [] { "PkiCreditcardclientID" });
            }

            if (this.FksCreditcardtokenID != null) {
                // FksCreditcardtokenID (string) pattern
                Regex regexFksCreditcardtokenID = new Regex(@"^\{?[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}\}?$", RegexOptions.CultureInvariant);
                if (!regexFksCreditcardtokenID.Match(this.FksCreditcardtokenID).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FksCreditcardtokenID, must match a pattern of " + regexFksCreditcardtokenID, new [] { "FksCreditcardtokenID" });
                }
            }

            if (this.SCreditcardclientDescription != null) {
                // SCreditcardclientDescription (string) pattern
                Regex regexSCreditcardclientDescription = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSCreditcardclientDescription.Match(this.SCreditcardclientDescription).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SCreditcardclientDescription, must match a pattern of " + regexSCreditcardclientDescription, new [] { "SCreditcardclientDescription" });
                }
            }

            if (this.SCreditcardclientCVV != null) {
                // SCreditcardclientCVV (string) pattern
                Regex regexSCreditcardclientCVV = new Regex(@"^[0-9]{3,4}$", RegexOptions.CultureInvariant);
                if (!regexSCreditcardclientCVV.Match(this.SCreditcardclientCVV).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SCreditcardclientCVV, must match a pattern of " + regexSCreditcardclientCVV, new [] { "SCreditcardclientCVV" });
                }
            }

            yield break;
        }
    }

}
