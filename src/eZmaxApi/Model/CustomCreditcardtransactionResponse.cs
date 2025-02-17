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
    /// A custom Creditcardtransaction Object
    /// </summary>
    [DataContract(Name = "Custom-Creditcardtransaction-Response")]
    public partial class CustomCreditcardtransactionResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ECreditcardtypeCodename
        /// </summary>
        [DataMember(Name = "eCreditcardtypeCodename", IsRequired = true, EmitDefaultValue = true)]
        public FieldECreditcardtypeCodename ECreditcardtypeCodename { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCreditcardtransactionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomCreditcardtransactionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCreditcardtransactionResponse" /> class.
        /// </summary>
        /// <param name="eCreditcardtypeCodename">eCreditcardtypeCodename (required).</param>
        /// <param name="dCreditcardtransactionAmount">The amount of the Creditcardtransaction (required).</param>
        /// <param name="sCreditcardtransactionPartiallydecryptednumber">The partially decrypted credit card number used in the Creditcardtransaction (required).</param>
        /// <param name="sCreditcardtransactionReferencenumber">The reference number on the creditcard service for the Creditcardtransaction (required).</param>
        public CustomCreditcardtransactionResponse(FieldECreditcardtypeCodename eCreditcardtypeCodename = default(FieldECreditcardtypeCodename), string dCreditcardtransactionAmount = default(string), string sCreditcardtransactionPartiallydecryptednumber = default(string), string sCreditcardtransactionReferencenumber = default(string))
        {
            this.ECreditcardtypeCodename = eCreditcardtypeCodename;
            // to ensure "dCreditcardtransactionAmount" is required (not null)
            if (dCreditcardtransactionAmount == null)
            {
                throw new ArgumentNullException("dCreditcardtransactionAmount is a required property for CustomCreditcardtransactionResponse and cannot be null");
            }
            this.DCreditcardtransactionAmount = dCreditcardtransactionAmount;
            // to ensure "sCreditcardtransactionPartiallydecryptednumber" is required (not null)
            if (sCreditcardtransactionPartiallydecryptednumber == null)
            {
                throw new ArgumentNullException("sCreditcardtransactionPartiallydecryptednumber is a required property for CustomCreditcardtransactionResponse and cannot be null");
            }
            this.SCreditcardtransactionPartiallydecryptednumber = sCreditcardtransactionPartiallydecryptednumber;
            // to ensure "sCreditcardtransactionReferencenumber" is required (not null)
            if (sCreditcardtransactionReferencenumber == null)
            {
                throw new ArgumentNullException("sCreditcardtransactionReferencenumber is a required property for CustomCreditcardtransactionResponse and cannot be null");
            }
            this.SCreditcardtransactionReferencenumber = sCreditcardtransactionReferencenumber;
        }

        /// <summary>
        /// The amount of the Creditcardtransaction
        /// </summary>
        /// <value>The amount of the Creditcardtransaction</value>
        /* <example>167.58</example>*/
        [DataMember(Name = "dCreditcardtransactionAmount", IsRequired = true, EmitDefaultValue = true)]
        public string DCreditcardtransactionAmount { get; set; }

        /// <summary>
        /// The partially decrypted credit card number used in the Creditcardtransaction
        /// </summary>
        /// <value>The partially decrypted credit card number used in the Creditcardtransaction</value>
        /* <example>XXXX XXXX XXXX 1234</example>*/
        [DataMember(Name = "sCreditcardtransactionPartiallydecryptednumber", IsRequired = true, EmitDefaultValue = true)]
        public string SCreditcardtransactionPartiallydecryptednumber { get; set; }

        /// <summary>
        /// The reference number on the creditcard service for the Creditcardtransaction
        /// </summary>
        /// <value>The reference number on the creditcard service for the Creditcardtransaction</value>
        /* <example>651447854715478415</example>*/
        [DataMember(Name = "sCreditcardtransactionReferencenumber", IsRequired = true, EmitDefaultValue = true)]
        public string SCreditcardtransactionReferencenumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomCreditcardtransactionResponse {\n");
            sb.Append("  ECreditcardtypeCodename: ").Append(ECreditcardtypeCodename).Append("\n");
            sb.Append("  DCreditcardtransactionAmount: ").Append(DCreditcardtransactionAmount).Append("\n");
            sb.Append("  SCreditcardtransactionPartiallydecryptednumber: ").Append(SCreditcardtransactionPartiallydecryptednumber).Append("\n");
            sb.Append("  SCreditcardtransactionReferencenumber: ").Append(SCreditcardtransactionReferencenumber).Append("\n");
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
            if (this.DCreditcardtransactionAmount != null) {
                // DCreditcardtransactionAmount (string) pattern
                Regex regexDCreditcardtransactionAmount = new Regex(@"^-{0,1}[\d]{1,9}?\.[\d]{2}$", RegexOptions.CultureInvariant);
                if (!regexDCreditcardtransactionAmount.Match(this.DCreditcardtransactionAmount).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DCreditcardtransactionAmount, must match a pattern of " + regexDCreditcardtransactionAmount, new [] { "DCreditcardtransactionAmount" });
                }
            }

            if (this.SCreditcardtransactionPartiallydecryptednumber != null) {
                // SCreditcardtransactionPartiallydecryptednumber (string) pattern
                Regex regexSCreditcardtransactionPartiallydecryptednumber = new Regex(@"^([X]{4}[ ]){3}(\d){4}$", RegexOptions.CultureInvariant);
                if (!regexSCreditcardtransactionPartiallydecryptednumber.Match(this.SCreditcardtransactionPartiallydecryptednumber).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SCreditcardtransactionPartiallydecryptednumber, must match a pattern of " + regexSCreditcardtransactionPartiallydecryptednumber, new [] { "SCreditcardtransactionPartiallydecryptednumber" });
                }
            }

            if (this.SCreditcardtransactionReferencenumber != null) {
                // SCreditcardtransactionReferencenumber (string) pattern
                Regex regexSCreditcardtransactionReferencenumber = new Regex(@"^[\d]{18}$", RegexOptions.CultureInvariant);
                if (!regexSCreditcardtransactionReferencenumber.Match(this.SCreditcardtransactionReferencenumber).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SCreditcardtransactionReferencenumber, must match a pattern of " + regexSCreditcardtransactionReferencenumber, new [] { "SCreditcardtransactionReferencenumber" });
                }
            }

            yield break;
        }
    }

}
