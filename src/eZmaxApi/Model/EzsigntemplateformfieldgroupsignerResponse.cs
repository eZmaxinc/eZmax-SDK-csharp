/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
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
    /// A Ezsigntemplateformfieldgroupsigner Object
    /// </summary>
    [DataContract]
    public partial class EzsigntemplateformfieldgroupsignerResponse :  IEquatable<EzsigntemplateformfieldgroupsignerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateformfieldgroupsignerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplateformfieldgroupsignerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateformfieldgroupsignerResponse" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplateformfieldgroupsignerID">The unique ID of the Ezsigntemplateformfieldgroupsigner (required).</param>
        /// <param name="fkiEzsigntemplatesignerID">The unique ID of the Ezsigntemplatesigner (required).</param>
        public EzsigntemplateformfieldgroupsignerResponse(int pkiEzsigntemplateformfieldgroupsignerID = default(int), int fkiEzsigntemplatesignerID = default(int))
        {
            // to ensure "pkiEzsigntemplateformfieldgroupsignerID" is required (not null)
            if (pkiEzsigntemplateformfieldgroupsignerID == null)
            {
                throw new InvalidDataException("pkiEzsigntemplateformfieldgroupsignerID is a required property for EzsigntemplateformfieldgroupsignerResponse and cannot be null");
            }
            else
            {
                this.PkiEzsigntemplateformfieldgroupsignerID = pkiEzsigntemplateformfieldgroupsignerID;
            }

            // to ensure "fkiEzsigntemplatesignerID" is required (not null)
            if (fkiEzsigntemplatesignerID == null)
            {
                throw new InvalidDataException("fkiEzsigntemplatesignerID is a required property for EzsigntemplateformfieldgroupsignerResponse and cannot be null");
            }
            else
            {
                this.FkiEzsigntemplatesignerID = fkiEzsigntemplatesignerID;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsigntemplateformfieldgroupsigner
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplateformfieldgroupsigner</value>
        [DataMember(Name="pkiEzsigntemplateformfieldgroupsignerID", EmitDefaultValue=true)]
        public int PkiEzsigntemplateformfieldgroupsignerID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplatesigner
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatesigner</value>
        [DataMember(Name="fkiEzsigntemplatesignerID", EmitDefaultValue=true)]
        public int FkiEzsigntemplatesignerID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplateformfieldgroupsignerResponse {\n");
            sb.Append("  PkiEzsigntemplateformfieldgroupsignerID: ").Append(PkiEzsigntemplateformfieldgroupsignerID).Append("\n");
            sb.Append("  FkiEzsigntemplatesignerID: ").Append(FkiEzsigntemplatesignerID).Append("\n");
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
            return this.Equals(input as EzsigntemplateformfieldgroupsignerResponse);
        }

        /// <summary>
        /// Returns true if EzsigntemplateformfieldgroupsignerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplateformfieldgroupsignerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplateformfieldgroupsignerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsigntemplateformfieldgroupsignerID == input.PkiEzsigntemplateformfieldgroupsignerID ||
                    (this.PkiEzsigntemplateformfieldgroupsignerID != null &&
                    this.PkiEzsigntemplateformfieldgroupsignerID.Equals(input.PkiEzsigntemplateformfieldgroupsignerID))
                ) && 
                (
                    this.FkiEzsigntemplatesignerID == input.FkiEzsigntemplatesignerID ||
                    (this.FkiEzsigntemplatesignerID != null &&
                    this.FkiEzsigntemplatesignerID.Equals(input.FkiEzsigntemplatesignerID))
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
                if (this.PkiEzsigntemplateformfieldgroupsignerID != null)
                    hashCode = hashCode * 59 + this.PkiEzsigntemplateformfieldgroupsignerID.GetHashCode();
                if (this.FkiEzsigntemplatesignerID != null)
                    hashCode = hashCode * 59 + this.FkiEzsigntemplatesignerID.GetHashCode();
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


            // PkiEzsigntemplateformfieldgroupsignerID (int) minimum
            if(this.PkiEzsigntemplateformfieldgroupsignerID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsigntemplateformfieldgroupsignerID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplateformfieldgroupsignerID" });
            }



            // FkiEzsigntemplatesignerID (int) minimum
            if(this.FkiEzsigntemplatesignerID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntemplatesignerID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplatesignerID" });
            }

            yield break;
        }
    }

}