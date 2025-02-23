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
    /// A Ezsignsigningreason List Element
    /// </summary>
    [DataContract(Name = "ezsignsigningreason-ListElement")]
    public partial class EzsignsigningreasonListElement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonListElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsigningreasonListElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonListElement" /> class.
        /// </summary>
        /// <param name="pkiEzsignsigningreasonID">The unique ID of the Ezsignsigningreason (required).</param>
        /// <param name="sEzsignsigningreasonDescriptionX">The description of the Ezsignsigningreason in the language of the requester (required).</param>
        /// <param name="bEzsignsigningreasonIsactive">Whether the ezsignsigningreason is active or not (required).</param>
        public EzsignsigningreasonListElement(int pkiEzsignsigningreasonID = default(int), string sEzsignsigningreasonDescriptionX = default(string), bool bEzsignsigningreasonIsactive = default(bool))
        {
            this.PkiEzsignsigningreasonID = pkiEzsignsigningreasonID;
            // to ensure "sEzsignsigningreasonDescriptionX" is required (not null)
            if (sEzsignsigningreasonDescriptionX == null)
            {
                throw new ArgumentNullException("sEzsignsigningreasonDescriptionX is a required property for EzsignsigningreasonListElement and cannot be null");
            }
            this.SEzsignsigningreasonDescriptionX = sEzsignsigningreasonDescriptionX;
            this.BEzsignsigningreasonIsactive = bEzsignsigningreasonIsactive;
        }

        /// <summary>
        /// The unique ID of the Ezsignsigningreason
        /// </summary>
        /// <value>The unique ID of the Ezsignsigningreason</value>
        /* <example>194</example>*/
        [DataMember(Name = "pkiEzsignsigningreasonID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiEzsignsigningreasonID { get; set; }

        /// <summary>
        /// The description of the Ezsignsigningreason in the language of the requester
        /// </summary>
        /// <value>The description of the Ezsignsigningreason in the language of the requester</value>
        /* <example>I approve this document</example>*/
        [DataMember(Name = "sEzsignsigningreasonDescriptionX", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsignsigningreasonDescriptionX { get; set; }

        /// <summary>
        /// Whether the ezsignsigningreason is active or not
        /// </summary>
        /// <value>Whether the ezsignsigningreason is active or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bEzsignsigningreasonIsactive", IsRequired = true, EmitDefaultValue = true)]
        public bool BEzsignsigningreasonIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignsigningreasonListElement {\n");
            sb.Append("  PkiEzsignsigningreasonID: ").Append(PkiEzsignsigningreasonID).Append("\n");
            sb.Append("  SEzsignsigningreasonDescriptionX: ").Append(SEzsignsigningreasonDescriptionX).Append("\n");
            sb.Append("  BEzsignsigningreasonIsactive: ").Append(BEzsignsigningreasonIsactive).Append("\n");
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
            // PkiEzsignsigningreasonID (int) maximum
            if (this.PkiEzsignsigningreasonID > (int)255)
            {
                yield return new ValidationResult("Invalid value for PkiEzsignsigningreasonID, must be a value less than or equal to 255.", new [] { "PkiEzsignsigningreasonID" });
            }

            // PkiEzsignsigningreasonID (int) minimum
            if (this.PkiEzsignsigningreasonID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzsignsigningreasonID, must be a value greater than or equal to 0.", new [] { "PkiEzsignsigningreasonID" });
            }

            if (this.SEzsignsigningreasonDescriptionX != null) {
                // SEzsignsigningreasonDescriptionX (string) pattern
                Regex regexSEzsignsigningreasonDescriptionX = new Regex(@"^.{0,50}$", RegexOptions.CultureInvariant);
                if (!regexSEzsignsigningreasonDescriptionX.Match(this.SEzsignsigningreasonDescriptionX).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignsigningreasonDescriptionX, must match a pattern of " + regexSEzsignsigningreasonDescriptionX, new [] { "SEzsignsigningreasonDescriptionX" });
                }
            }

            yield break;
        }
    }

}
