/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// A Ezsigntemplateglobalsigner Object
    /// </summary>
    [DataContract(Name = "ezsigntemplateglobalsigner-ResponseCompound")]
    public partial class EzsigntemplateglobalsignerResponseCompound : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateglobalsignerResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplateglobalsignerResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplateglobalsignerResponseCompound" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplateglobalsignerID">The unique ID of the Ezsigntemplateglobalsigner (required).</param>
        /// <param name="fkiEzsigntemplateglobalID">The unique ID of the Ezsigntemplateglobal (required).</param>
        /// <param name="sEzsigntemplateglobalsignerDescription">The description of the Ezsigntemplateglobalsigner (required).</param>
        public EzsigntemplateglobalsignerResponseCompound(int pkiEzsigntemplateglobalsignerID = default(int), int fkiEzsigntemplateglobalID = default(int), string sEzsigntemplateglobalsignerDescription = default(string))
        {
            this.PkiEzsigntemplateglobalsignerID = pkiEzsigntemplateglobalsignerID;
            this.FkiEzsigntemplateglobalID = fkiEzsigntemplateglobalID;
            // to ensure "sEzsigntemplateglobalsignerDescription" is required (not null)
            if (sEzsigntemplateglobalsignerDescription == null)
            {
                throw new ArgumentNullException("sEzsigntemplateglobalsignerDescription is a required property for EzsigntemplateglobalsignerResponseCompound and cannot be null");
            }
            this.SEzsigntemplateglobalsignerDescription = sEzsigntemplateglobalsignerDescription;
        }

        /// <summary>
        /// The unique ID of the Ezsigntemplateglobalsigner
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplateglobalsigner</value>
        /* <example>9</example>*/
        [DataMember(Name = "pkiEzsigntemplateglobalsignerID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiEzsigntemplateglobalsignerID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplateglobal
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplateglobal</value>
        /* <example>36</example>*/
        [DataMember(Name = "fkiEzsigntemplateglobalID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiEzsigntemplateglobalID { get; set; }

        /// <summary>
        /// The description of the Ezsigntemplateglobalsigner
        /// </summary>
        /// <value>The description of the Ezsigntemplateglobalsigner</value>
        /* <example>Customer</example>*/
        [DataMember(Name = "sEzsigntemplateglobalsignerDescription", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsigntemplateglobalsignerDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplateglobalsignerResponseCompound {\n");
            sb.Append("  PkiEzsigntemplateglobalsignerID: ").Append(PkiEzsigntemplateglobalsignerID).Append("\n");
            sb.Append("  FkiEzsigntemplateglobalID: ").Append(FkiEzsigntemplateglobalID).Append("\n");
            sb.Append("  SEzsigntemplateglobalsignerDescription: ").Append(SEzsigntemplateglobalsignerDescription).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PkiEzsigntemplateglobalsignerID (int) minimum
            if (this.PkiEzsigntemplateglobalsignerID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsigntemplateglobalsignerID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplateglobalsignerID" });
            }

            // FkiEzsigntemplateglobalID (int) minimum
            if (this.FkiEzsigntemplateglobalID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntemplateglobalID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplateglobalID" });
            }

            if (this.SEzsigntemplateglobalsignerDescription != null) {
                // SEzsigntemplateglobalsignerDescription (string) pattern
                Regex regexSEzsigntemplateglobalsignerDescription = new Regex(@"^.{1,50}$", RegexOptions.CultureInvariant);
                if (!regexSEzsigntemplateglobalsignerDescription.Match(this.SEzsigntemplateglobalsignerDescription).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsigntemplateglobalsignerDescription, must match a pattern of " + regexSEzsigntemplateglobalsignerDescription, new [] { "SEzsigntemplateglobalsignerDescription" });
                }
            }

            yield break;
        }
    }

}