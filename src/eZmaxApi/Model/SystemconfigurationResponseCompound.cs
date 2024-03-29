/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.18
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
    /// A Systemconfiguration Object
    /// </summary>
    [DataContract]
    public partial class SystemconfigurationResponseCompound :  IEquatable<SystemconfigurationResponseCompound>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ESystemconfigurationNewexternaluseraction
        /// </summary>
        [DataMember(Name="eSystemconfigurationNewexternaluseraction", EmitDefaultValue=true)]
        public FieldESystemconfigurationNewexternaluseraction ESystemconfigurationNewexternaluseraction { get; set; }
        /// <summary>
        /// Gets or Sets ESystemconfigurationLanguage1
        /// </summary>
        [DataMember(Name="eSystemconfigurationLanguage1", EmitDefaultValue=true)]
        public FieldESystemconfigurationLanguage1 ESystemconfigurationLanguage1 { get; set; }
        /// <summary>
        /// Gets or Sets ESystemconfigurationLanguage2
        /// </summary>
        [DataMember(Name="eSystemconfigurationLanguage2", EmitDefaultValue=true)]
        public FieldESystemconfigurationLanguage2 ESystemconfigurationLanguage2 { get; set; }
        /// <summary>
        /// Gets or Sets ESystemconfigurationEzsign
        /// </summary>
        [DataMember(Name="eSystemconfigurationEzsign", EmitDefaultValue=true)]
        public FieldESystemconfigurationEzsign ESystemconfigurationEzsign { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemconfigurationResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemconfigurationResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemconfigurationResponseCompound" /> class.
        /// </summary>
        /// <param name="pkiSystemconfigurationID">The unique ID of the Systemconfiguration (required).</param>
        /// <param name="fkiSystemconfigurationtypeID">The unique ID of the Systemconfigurationtype (required).</param>
        /// <param name="sSystemconfigurationtypeDescriptionX">The description of the Systemconfigurationtype in the language of the requester (required).</param>
        /// <param name="eSystemconfigurationNewexternaluseraction">eSystemconfigurationNewexternaluseraction (required).</param>
        /// <param name="eSystemconfigurationLanguage1">eSystemconfigurationLanguage1 (required).</param>
        /// <param name="eSystemconfigurationLanguage2">eSystemconfigurationLanguage2 (required).</param>
        /// <param name="eSystemconfigurationEzsign">eSystemconfigurationEzsign (required).</param>
        /// <param name="bSystemconfigurationEzsignpersonnal">Whether if we allow the creation of personal files in eZsign (required).</param>
        /// <param name="bSystemconfigurationSspr">Whether if we allow SSPR (required).</param>
        /// <param name="dtSystemconfigurationReadonlyexpirationstart">The start date where the system will be in read only.</param>
        /// <param name="dtSystemconfigurationReadonlyexpirationend">The end date where the system will be in read only.</param>
        public SystemconfigurationResponseCompound(int pkiSystemconfigurationID = default(int), int fkiSystemconfigurationtypeID = default(int), string sSystemconfigurationtypeDescriptionX = default(string), FieldESystemconfigurationNewexternaluseraction eSystemconfigurationNewexternaluseraction = default(FieldESystemconfigurationNewexternaluseraction), FieldESystemconfigurationLanguage1 eSystemconfigurationLanguage1 = default(FieldESystemconfigurationLanguage1), FieldESystemconfigurationLanguage2 eSystemconfigurationLanguage2 = default(FieldESystemconfigurationLanguage2), FieldESystemconfigurationEzsign eSystemconfigurationEzsign = default(FieldESystemconfigurationEzsign), bool bSystemconfigurationEzsignpersonnal = default(bool), bool bSystemconfigurationSspr = default(bool), string dtSystemconfigurationReadonlyexpirationstart = default(string), string dtSystemconfigurationReadonlyexpirationend = default(string))
        {
            // to ensure "pkiSystemconfigurationID" is required (not null)
            if (pkiSystemconfigurationID == null)
            {
                throw new InvalidDataException("pkiSystemconfigurationID is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.PkiSystemconfigurationID = pkiSystemconfigurationID;
            }

            // to ensure "fkiSystemconfigurationtypeID" is required (not null)
            if (fkiSystemconfigurationtypeID == null)
            {
                throw new InvalidDataException("fkiSystemconfigurationtypeID is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.FkiSystemconfigurationtypeID = fkiSystemconfigurationtypeID;
            }

            // to ensure "sSystemconfigurationtypeDescriptionX" is required (not null)
            if (sSystemconfigurationtypeDescriptionX == null)
            {
                throw new InvalidDataException("sSystemconfigurationtypeDescriptionX is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.SSystemconfigurationtypeDescriptionX = sSystemconfigurationtypeDescriptionX;
            }

            // to ensure "eSystemconfigurationNewexternaluseraction" is required (not null)
            if (eSystemconfigurationNewexternaluseraction == null)
            {
                throw new InvalidDataException("eSystemconfigurationNewexternaluseraction is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.ESystemconfigurationNewexternaluseraction = eSystemconfigurationNewexternaluseraction;
            }

            // to ensure "eSystemconfigurationLanguage1" is required (not null)
            if (eSystemconfigurationLanguage1 == null)
            {
                throw new InvalidDataException("eSystemconfigurationLanguage1 is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.ESystemconfigurationLanguage1 = eSystemconfigurationLanguage1;
            }

            // to ensure "eSystemconfigurationLanguage2" is required (not null)
            if (eSystemconfigurationLanguage2 == null)
            {
                throw new InvalidDataException("eSystemconfigurationLanguage2 is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.ESystemconfigurationLanguage2 = eSystemconfigurationLanguage2;
            }

            // to ensure "eSystemconfigurationEzsign" is required (not null)
            if (eSystemconfigurationEzsign == null)
            {
                throw new InvalidDataException("eSystemconfigurationEzsign is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.ESystemconfigurationEzsign = eSystemconfigurationEzsign;
            }

            // to ensure "bSystemconfigurationEzsignpersonnal" is required (not null)
            if (bSystemconfigurationEzsignpersonnal == null)
            {
                throw new InvalidDataException("bSystemconfigurationEzsignpersonnal is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.BSystemconfigurationEzsignpersonnal = bSystemconfigurationEzsignpersonnal;
            }

            // to ensure "bSystemconfigurationSspr" is required (not null)
            if (bSystemconfigurationSspr == null)
            {
                throw new InvalidDataException("bSystemconfigurationSspr is a required property for SystemconfigurationResponseCompound and cannot be null");
            }
            else
            {
                this.BSystemconfigurationSspr = bSystemconfigurationSspr;
            }

            this.DtSystemconfigurationReadonlyexpirationstart = dtSystemconfigurationReadonlyexpirationstart;
            this.DtSystemconfigurationReadonlyexpirationend = dtSystemconfigurationReadonlyexpirationend;
        }

        /// <summary>
        /// The unique ID of the Systemconfiguration
        /// </summary>
        /// <value>The unique ID of the Systemconfiguration</value>
        [DataMember(Name="pkiSystemconfigurationID", EmitDefaultValue=true)]
        public int PkiSystemconfigurationID { get; set; }

        /// <summary>
        /// The unique ID of the Systemconfigurationtype
        /// </summary>
        /// <value>The unique ID of the Systemconfigurationtype</value>
        [DataMember(Name="fkiSystemconfigurationtypeID", EmitDefaultValue=true)]
        public int FkiSystemconfigurationtypeID { get; set; }

        /// <summary>
        /// The description of the Systemconfigurationtype in the language of the requester
        /// </summary>
        /// <value>The description of the Systemconfigurationtype in the language of the requester</value>
        [DataMember(Name="sSystemconfigurationtypeDescriptionX", EmitDefaultValue=true)]
        public string SSystemconfigurationtypeDescriptionX { get; set; }





        /// <summary>
        /// Whether if we allow the creation of personal files in eZsign
        /// </summary>
        /// <value>Whether if we allow the creation of personal files in eZsign</value>
        [DataMember(Name="bSystemconfigurationEzsignpersonnal", EmitDefaultValue=true)]
        public bool BSystemconfigurationEzsignpersonnal { get; set; }

        /// <summary>
        /// Whether if we allow SSPR
        /// </summary>
        /// <value>Whether if we allow SSPR</value>
        [DataMember(Name="bSystemconfigurationSspr", EmitDefaultValue=true)]
        public bool BSystemconfigurationSspr { get; set; }

        /// <summary>
        /// The start date where the system will be in read only
        /// </summary>
        /// <value>The start date where the system will be in read only</value>
        [DataMember(Name="dtSystemconfigurationReadonlyexpirationstart", EmitDefaultValue=false)]
        public string DtSystemconfigurationReadonlyexpirationstart { get; set; }

        /// <summary>
        /// The end date where the system will be in read only
        /// </summary>
        /// <value>The end date where the system will be in read only</value>
        [DataMember(Name="dtSystemconfigurationReadonlyexpirationend", EmitDefaultValue=false)]
        public string DtSystemconfigurationReadonlyexpirationend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemconfigurationResponseCompound {\n");
            sb.Append("  PkiSystemconfigurationID: ").Append(PkiSystemconfigurationID).Append("\n");
            sb.Append("  FkiSystemconfigurationtypeID: ").Append(FkiSystemconfigurationtypeID).Append("\n");
            sb.Append("  SSystemconfigurationtypeDescriptionX: ").Append(SSystemconfigurationtypeDescriptionX).Append("\n");
            sb.Append("  ESystemconfigurationNewexternaluseraction: ").Append(ESystemconfigurationNewexternaluseraction).Append("\n");
            sb.Append("  ESystemconfigurationLanguage1: ").Append(ESystemconfigurationLanguage1).Append("\n");
            sb.Append("  ESystemconfigurationLanguage2: ").Append(ESystemconfigurationLanguage2).Append("\n");
            sb.Append("  ESystemconfigurationEzsign: ").Append(ESystemconfigurationEzsign).Append("\n");
            sb.Append("  BSystemconfigurationEzsignpersonnal: ").Append(BSystemconfigurationEzsignpersonnal).Append("\n");
            sb.Append("  BSystemconfigurationSspr: ").Append(BSystemconfigurationSspr).Append("\n");
            sb.Append("  DtSystemconfigurationReadonlyexpirationstart: ").Append(DtSystemconfigurationReadonlyexpirationstart).Append("\n");
            sb.Append("  DtSystemconfigurationReadonlyexpirationend: ").Append(DtSystemconfigurationReadonlyexpirationend).Append("\n");
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
            return this.Equals(input as SystemconfigurationResponseCompound);
        }

        /// <summary>
        /// Returns true if SystemconfigurationResponseCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemconfigurationResponseCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemconfigurationResponseCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiSystemconfigurationID == input.PkiSystemconfigurationID ||
                    (this.PkiSystemconfigurationID != null &&
                    this.PkiSystemconfigurationID.Equals(input.PkiSystemconfigurationID))
                ) && 
                (
                    this.FkiSystemconfigurationtypeID == input.FkiSystemconfigurationtypeID ||
                    (this.FkiSystemconfigurationtypeID != null &&
                    this.FkiSystemconfigurationtypeID.Equals(input.FkiSystemconfigurationtypeID))
                ) && 
                (
                    this.SSystemconfigurationtypeDescriptionX == input.SSystemconfigurationtypeDescriptionX ||
                    (this.SSystemconfigurationtypeDescriptionX != null &&
                    this.SSystemconfigurationtypeDescriptionX.Equals(input.SSystemconfigurationtypeDescriptionX))
                ) && 
                (
                    this.ESystemconfigurationNewexternaluseraction == input.ESystemconfigurationNewexternaluseraction ||
                    (this.ESystemconfigurationNewexternaluseraction != null &&
                    this.ESystemconfigurationNewexternaluseraction.Equals(input.ESystemconfigurationNewexternaluseraction))
                ) && 
                (
                    this.ESystemconfigurationLanguage1 == input.ESystemconfigurationLanguage1 ||
                    (this.ESystemconfigurationLanguage1 != null &&
                    this.ESystemconfigurationLanguage1.Equals(input.ESystemconfigurationLanguage1))
                ) && 
                (
                    this.ESystemconfigurationLanguage2 == input.ESystemconfigurationLanguage2 ||
                    (this.ESystemconfigurationLanguage2 != null &&
                    this.ESystemconfigurationLanguage2.Equals(input.ESystemconfigurationLanguage2))
                ) && 
                (
                    this.ESystemconfigurationEzsign == input.ESystemconfigurationEzsign ||
                    (this.ESystemconfigurationEzsign != null &&
                    this.ESystemconfigurationEzsign.Equals(input.ESystemconfigurationEzsign))
                ) && 
                (
                    this.BSystemconfigurationEzsignpersonnal == input.BSystemconfigurationEzsignpersonnal ||
                    (this.BSystemconfigurationEzsignpersonnal != null &&
                    this.BSystemconfigurationEzsignpersonnal.Equals(input.BSystemconfigurationEzsignpersonnal))
                ) && 
                (
                    this.BSystemconfigurationSspr == input.BSystemconfigurationSspr ||
                    (this.BSystemconfigurationSspr != null &&
                    this.BSystemconfigurationSspr.Equals(input.BSystemconfigurationSspr))
                ) && 
                (
                    this.DtSystemconfigurationReadonlyexpirationstart == input.DtSystemconfigurationReadonlyexpirationstart ||
                    (this.DtSystemconfigurationReadonlyexpirationstart != null &&
                    this.DtSystemconfigurationReadonlyexpirationstart.Equals(input.DtSystemconfigurationReadonlyexpirationstart))
                ) && 
                (
                    this.DtSystemconfigurationReadonlyexpirationend == input.DtSystemconfigurationReadonlyexpirationend ||
                    (this.DtSystemconfigurationReadonlyexpirationend != null &&
                    this.DtSystemconfigurationReadonlyexpirationend.Equals(input.DtSystemconfigurationReadonlyexpirationend))
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
                if (this.PkiSystemconfigurationID != null)
                    hashCode = hashCode * 59 + this.PkiSystemconfigurationID.GetHashCode();
                if (this.FkiSystemconfigurationtypeID != null)
                    hashCode = hashCode * 59 + this.FkiSystemconfigurationtypeID.GetHashCode();
                if (this.SSystemconfigurationtypeDescriptionX != null)
                    hashCode = hashCode * 59 + this.SSystemconfigurationtypeDescriptionX.GetHashCode();
                if (this.ESystemconfigurationNewexternaluseraction != null)
                    hashCode = hashCode * 59 + this.ESystemconfigurationNewexternaluseraction.GetHashCode();
                if (this.ESystemconfigurationLanguage1 != null)
                    hashCode = hashCode * 59 + this.ESystemconfigurationLanguage1.GetHashCode();
                if (this.ESystemconfigurationLanguage2 != null)
                    hashCode = hashCode * 59 + this.ESystemconfigurationLanguage2.GetHashCode();
                if (this.ESystemconfigurationEzsign != null)
                    hashCode = hashCode * 59 + this.ESystemconfigurationEzsign.GetHashCode();
                if (this.BSystemconfigurationEzsignpersonnal != null)
                    hashCode = hashCode * 59 + this.BSystemconfigurationEzsignpersonnal.GetHashCode();
                if (this.BSystemconfigurationSspr != null)
                    hashCode = hashCode * 59 + this.BSystemconfigurationSspr.GetHashCode();
                if (this.DtSystemconfigurationReadonlyexpirationstart != null)
                    hashCode = hashCode * 59 + this.DtSystemconfigurationReadonlyexpirationstart.GetHashCode();
                if (this.DtSystemconfigurationReadonlyexpirationend != null)
                    hashCode = hashCode * 59 + this.DtSystemconfigurationReadonlyexpirationend.GetHashCode();
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


            // PkiSystemconfigurationID (int) maximum
            if(this.PkiSystemconfigurationID > (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiSystemconfigurationID, must be a value less than or equal to 1.", new [] { "PkiSystemconfigurationID" });
            }

            // PkiSystemconfigurationID (int) minimum
            if(this.PkiSystemconfigurationID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiSystemconfigurationID, must be a value greater than or equal to 1.", new [] { "PkiSystemconfigurationID" });
            }



            // FkiSystemconfigurationtypeID (int) minimum
            if(this.FkiSystemconfigurationtypeID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiSystemconfigurationtypeID, must be a value greater than or equal to 1.", new [] { "FkiSystemconfigurationtypeID" });
            }



            // DtSystemconfigurationReadonlyexpirationstart (string) pattern
            Regex regexDtSystemconfigurationReadonlyexpirationstart = new Regex(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$", RegexOptions.CultureInvariant);
            if (false == regexDtSystemconfigurationReadonlyexpirationstart.Match(this.DtSystemconfigurationReadonlyexpirationstart).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DtSystemconfigurationReadonlyexpirationstart, must match a pattern of " + regexDtSystemconfigurationReadonlyexpirationstart, new [] { "DtSystemconfigurationReadonlyexpirationstart" });
            }



            // DtSystemconfigurationReadonlyexpirationend (string) pattern
            Regex regexDtSystemconfigurationReadonlyexpirationend = new Regex(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$", RegexOptions.CultureInvariant);
            if (false == regexDtSystemconfigurationReadonlyexpirationend.Match(this.DtSystemconfigurationReadonlyexpirationend).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DtSystemconfigurationReadonlyexpirationend, must match a pattern of " + regexDtSystemconfigurationReadonlyexpirationend, new [] { "DtSystemconfigurationReadonlyexpirationend" });
            }

            yield break;
        }
    }

}
