/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.17
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// A Paymentterm List Element
    /// </summary>
    [DataContract]
    public partial class PaymenttermListElement :  IEquatable<PaymenttermListElement>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EPaymenttermType
        /// </summary>
        [DataMember(Name="ePaymenttermType", EmitDefaultValue=true)]
        public FieldEPaymenttermType EPaymenttermType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymenttermListElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymenttermListElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymenttermListElement" /> class.
        /// </summary>
        /// <param name="pkiPaymenttermID">The unique ID of the Paymentterm (required).</param>
        /// <param name="sPaymenttermCode">The code of the Paymentterm (required).</param>
        /// <param name="ePaymenttermType">ePaymenttermType (required).</param>
        /// <param name="iPaymenttermDay">The day of the Paymentterm (required).</param>
        /// <param name="sPaymenttermDescriptionX">The description of the Paymentterm in the language of the requester (required).</param>
        /// <param name="bPaymenttermIsactive">Whether the Paymentterm is active or not (required).</param>
        public PaymenttermListElement(int pkiPaymenttermID = default(int), string sPaymenttermCode = default(string), FieldEPaymenttermType ePaymenttermType = default(FieldEPaymenttermType), int iPaymenttermDay = default(int), string sPaymenttermDescriptionX = default(string), bool bPaymenttermIsactive = default(bool))
        {
            // to ensure "pkiPaymenttermID" is required (not null)
            if (pkiPaymenttermID == null)
            {
                throw new InvalidDataException("pkiPaymenttermID is a required property for PaymenttermListElement and cannot be null");
            }
            else
            {
                this.PkiPaymenttermID = pkiPaymenttermID;
            }

            // to ensure "sPaymenttermCode" is required (not null)
            if (sPaymenttermCode == null)
            {
                throw new InvalidDataException("sPaymenttermCode is a required property for PaymenttermListElement and cannot be null");
            }
            else
            {
                this.SPaymenttermCode = sPaymenttermCode;
            }

            // to ensure "ePaymenttermType" is required (not null)
            if (ePaymenttermType == null)
            {
                throw new InvalidDataException("ePaymenttermType is a required property for PaymenttermListElement and cannot be null");
            }
            else
            {
                this.EPaymenttermType = ePaymenttermType;
            }

            // to ensure "iPaymenttermDay" is required (not null)
            if (iPaymenttermDay == null)
            {
                throw new InvalidDataException("iPaymenttermDay is a required property for PaymenttermListElement and cannot be null");
            }
            else
            {
                this.IPaymenttermDay = iPaymenttermDay;
            }

            // to ensure "sPaymenttermDescriptionX" is required (not null)
            if (sPaymenttermDescriptionX == null)
            {
                throw new InvalidDataException("sPaymenttermDescriptionX is a required property for PaymenttermListElement and cannot be null");
            }
            else
            {
                this.SPaymenttermDescriptionX = sPaymenttermDescriptionX;
            }

            // to ensure "bPaymenttermIsactive" is required (not null)
            if (bPaymenttermIsactive == null)
            {
                throw new InvalidDataException("bPaymenttermIsactive is a required property for PaymenttermListElement and cannot be null");
            }
            else
            {
                this.BPaymenttermIsactive = bPaymenttermIsactive;
            }

        }

        /// <summary>
        /// The unique ID of the Paymentterm
        /// </summary>
        /// <value>The unique ID of the Paymentterm</value>
        [DataMember(Name="pkiPaymenttermID", EmitDefaultValue=true)]
        public int PkiPaymenttermID { get; set; }

        /// <summary>
        /// The code of the Paymentterm
        /// </summary>
        /// <value>The code of the Paymentterm</value>
        [DataMember(Name="sPaymenttermCode", EmitDefaultValue=true)]
        public string SPaymenttermCode { get; set; }


        /// <summary>
        /// The day of the Paymentterm
        /// </summary>
        /// <value>The day of the Paymentterm</value>
        [DataMember(Name="iPaymenttermDay", EmitDefaultValue=true)]
        public int IPaymenttermDay { get; set; }

        /// <summary>
        /// The description of the Paymentterm in the language of the requester
        /// </summary>
        /// <value>The description of the Paymentterm in the language of the requester</value>
        [DataMember(Name="sPaymenttermDescriptionX", EmitDefaultValue=true)]
        public string SPaymenttermDescriptionX { get; set; }

        /// <summary>
        /// Whether the Paymentterm is active or not
        /// </summary>
        /// <value>Whether the Paymentterm is active or not</value>
        [DataMember(Name="bPaymenttermIsactive", EmitDefaultValue=true)]
        public bool BPaymenttermIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymenttermListElement {\n");
            sb.Append("  PkiPaymenttermID: ").Append(PkiPaymenttermID).Append("\n");
            sb.Append("  SPaymenttermCode: ").Append(SPaymenttermCode).Append("\n");
            sb.Append("  EPaymenttermType: ").Append(EPaymenttermType).Append("\n");
            sb.Append("  IPaymenttermDay: ").Append(IPaymenttermDay).Append("\n");
            sb.Append("  SPaymenttermDescriptionX: ").Append(SPaymenttermDescriptionX).Append("\n");
            sb.Append("  BPaymenttermIsactive: ").Append(BPaymenttermIsactive).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymenttermListElement);
        }

        /// <summary>
        /// Returns true if PaymenttermListElement instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymenttermListElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymenttermListElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiPaymenttermID == input.PkiPaymenttermID ||
                    (this.PkiPaymenttermID != null &&
                    this.PkiPaymenttermID.Equals(input.PkiPaymenttermID))
                ) && 
                (
                    this.SPaymenttermCode == input.SPaymenttermCode ||
                    (this.SPaymenttermCode != null &&
                    this.SPaymenttermCode.Equals(input.SPaymenttermCode))
                ) && 
                (
                    this.EPaymenttermType == input.EPaymenttermType ||
                    (this.EPaymenttermType != null &&
                    this.EPaymenttermType.Equals(input.EPaymenttermType))
                ) && 
                (
                    this.IPaymenttermDay == input.IPaymenttermDay ||
                    (this.IPaymenttermDay != null &&
                    this.IPaymenttermDay.Equals(input.IPaymenttermDay))
                ) && 
                (
                    this.SPaymenttermDescriptionX == input.SPaymenttermDescriptionX ||
                    (this.SPaymenttermDescriptionX != null &&
                    this.SPaymenttermDescriptionX.Equals(input.SPaymenttermDescriptionX))
                ) && 
                (
                    this.BPaymenttermIsactive == input.BPaymenttermIsactive ||
                    (this.BPaymenttermIsactive != null &&
                    this.BPaymenttermIsactive.Equals(input.BPaymenttermIsactive))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PkiPaymenttermID != null)
                    hashCode = hashCode * 59 + this.PkiPaymenttermID.GetHashCode();
                if (this.SPaymenttermCode != null)
                    hashCode = hashCode * 59 + this.SPaymenttermCode.GetHashCode();
                if (this.EPaymenttermType != null)
                    hashCode = hashCode * 59 + this.EPaymenttermType.GetHashCode();
                if (this.IPaymenttermDay != null)
                    hashCode = hashCode * 59 + this.IPaymenttermDay.GetHashCode();
                if (this.SPaymenttermDescriptionX != null)
                    hashCode = hashCode * 59 + this.SPaymenttermDescriptionX.GetHashCode();
                if (this.BPaymenttermIsactive != null)
                    hashCode = hashCode * 59 + this.BPaymenttermIsactive.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {


            // SPaymenttermCode (string) pattern
            Regex regexSPaymenttermCode = new Regex(@"^[A-Z0-9]{1,4}$", RegexOptions.CultureInvariant);
            if (false == regexSPaymenttermCode.Match(this.SPaymenttermCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SPaymenttermCode, must match a pattern of " + regexSPaymenttermCode, new [] { "SPaymenttermCode" });
            }



            // IPaymenttermDay (int) maximum
            if(this.IPaymenttermDay > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IPaymenttermDay, must be a value less than or equal to 255.", new [] { "IPaymenttermDay" });
            }

            // IPaymenttermDay (int) minimum
            if(this.IPaymenttermDay < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IPaymenttermDay, must be a value greater than or equal to 0.", new [] { "IPaymenttermDay" });
            }



            // SPaymenttermDescriptionX (string) pattern
            Regex regexSPaymenttermDescriptionX = new Regex(@"^.{1,40}$", RegexOptions.CultureInvariant);
            if (false == regexSPaymenttermDescriptionX.Match(this.SPaymenttermDescriptionX).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SPaymenttermDescriptionX, must match a pattern of " + regexSPaymenttermDescriptionX, new [] { "SPaymenttermDescriptionX" });
            }

            yield break;
        }
    }

}