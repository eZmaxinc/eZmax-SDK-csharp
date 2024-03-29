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
    /// A Ezsigntemplatesigner Object
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatesignerResponse :  IEquatable<EzsigntemplatesignerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatesignerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatesignerResponse" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplatesignerID">The unique ID of the Ezsigntemplatesigner (required).</param>
        /// <param name="fkiEzsigntemplateID">The unique ID of the Ezsigntemplate (required).</param>
        /// <param name="sEzsigntemplatesignerDescription">The description of the Ezsigntemplatesigner (required).</param>
        public EzsigntemplatesignerResponse(int pkiEzsigntemplatesignerID = default(int), int fkiEzsigntemplateID = default(int), string sEzsigntemplatesignerDescription = default(string))
        {
            // to ensure "pkiEzsigntemplatesignerID" is required (not null)
            if (pkiEzsigntemplatesignerID == null)
            {
                throw new InvalidDataException("pkiEzsigntemplatesignerID is a required property for EzsigntemplatesignerResponse and cannot be null");
            }
            else
            {
                this.PkiEzsigntemplatesignerID = pkiEzsigntemplatesignerID;
            }

            // to ensure "fkiEzsigntemplateID" is required (not null)
            if (fkiEzsigntemplateID == null)
            {
                throw new InvalidDataException("fkiEzsigntemplateID is a required property for EzsigntemplatesignerResponse and cannot be null");
            }
            else
            {
                this.FkiEzsigntemplateID = fkiEzsigntemplateID;
            }

            // to ensure "sEzsigntemplatesignerDescription" is required (not null)
            if (sEzsigntemplatesignerDescription == null)
            {
                throw new InvalidDataException("sEzsigntemplatesignerDescription is a required property for EzsigntemplatesignerResponse and cannot be null");
            }
            else
            {
                this.SEzsigntemplatesignerDescription = sEzsigntemplatesignerDescription;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsigntemplatesigner
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatesigner</value>
        [DataMember(Name="pkiEzsigntemplatesignerID", EmitDefaultValue=true)]
        public int PkiEzsigntemplatesignerID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        [DataMember(Name="fkiEzsigntemplateID", EmitDefaultValue=true)]
        public int FkiEzsigntemplateID { get; set; }

        /// <summary>
        /// The description of the Ezsigntemplatesigner
        /// </summary>
        /// <value>The description of the Ezsigntemplatesigner</value>
        [DataMember(Name="sEzsigntemplatesignerDescription", EmitDefaultValue=true)]
        public string SEzsigntemplatesignerDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplatesignerResponse {\n");
            sb.Append("  PkiEzsigntemplatesignerID: ").Append(PkiEzsigntemplatesignerID).Append("\n");
            sb.Append("  FkiEzsigntemplateID: ").Append(FkiEzsigntemplateID).Append("\n");
            sb.Append("  SEzsigntemplatesignerDescription: ").Append(SEzsigntemplatesignerDescription).Append("\n");
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
            return this.Equals(input as EzsigntemplatesignerResponse);
        }

        /// <summary>
        /// Returns true if EzsigntemplatesignerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatesignerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatesignerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsigntemplatesignerID == input.PkiEzsigntemplatesignerID ||
                    (this.PkiEzsigntemplatesignerID != null &&
                    this.PkiEzsigntemplatesignerID.Equals(input.PkiEzsigntemplatesignerID))
                ) && 
                (
                    this.FkiEzsigntemplateID == input.FkiEzsigntemplateID ||
                    (this.FkiEzsigntemplateID != null &&
                    this.FkiEzsigntemplateID.Equals(input.FkiEzsigntemplateID))
                ) && 
                (
                    this.SEzsigntemplatesignerDescription == input.SEzsigntemplatesignerDescription ||
                    (this.SEzsigntemplatesignerDescription != null &&
                    this.SEzsigntemplatesignerDescription.Equals(input.SEzsigntemplatesignerDescription))
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
                if (this.PkiEzsigntemplatesignerID != null)
                    hashCode = hashCode * 59 + this.PkiEzsigntemplatesignerID.GetHashCode();
                if (this.FkiEzsigntemplateID != null)
                    hashCode = hashCode * 59 + this.FkiEzsigntemplateID.GetHashCode();
                if (this.SEzsigntemplatesignerDescription != null)
                    hashCode = hashCode * 59 + this.SEzsigntemplatesignerDescription.GetHashCode();
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


            // PkiEzsigntemplatesignerID (int) minimum
            if(this.PkiEzsigntemplatesignerID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsigntemplatesignerID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplatesignerID" });
            }



            // FkiEzsigntemplateID (int) minimum
            if(this.FkiEzsigntemplateID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntemplateID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplateID" });
            }

            yield break;
        }
    }

}
