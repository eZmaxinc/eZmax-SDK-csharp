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
    /// A Ezmaxproduct AutocompleteElement Response
    /// </summary>
    [DataContract]
    public partial class EzmaxproductAutocompleteElementResponse :  IEquatable<EzmaxproductAutocompleteElementResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxproductAutocompleteElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzmaxproductAutocompleteElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxproductAutocompleteElementResponse" /> class.
        /// </summary>
        /// <param name="pkiEzmaxproductID">The unique ID of the Ezmaxproduct (required).</param>
        /// <param name="sEzmaxproductDescriptionX">The description of the Ezmaxproduct in the language of the requester (required).</param>
        /// <param name="bEzmaxproductIsactive">Whether the Ezmaxproduct is active or not (required).</param>
        public EzmaxproductAutocompleteElementResponse(int pkiEzmaxproductID = default(int), string sEzmaxproductDescriptionX = default(string), bool bEzmaxproductIsactive = default(bool))
        {
            // to ensure "pkiEzmaxproductID" is required (not null)
            if (pkiEzmaxproductID == null)
            {
                throw new InvalidDataException("pkiEzmaxproductID is a required property for EzmaxproductAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.PkiEzmaxproductID = pkiEzmaxproductID;
            }

            // to ensure "sEzmaxproductDescriptionX" is required (not null)
            if (sEzmaxproductDescriptionX == null)
            {
                throw new InvalidDataException("sEzmaxproductDescriptionX is a required property for EzmaxproductAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.SEzmaxproductDescriptionX = sEzmaxproductDescriptionX;
            }

            // to ensure "bEzmaxproductIsactive" is required (not null)
            if (bEzmaxproductIsactive == null)
            {
                throw new InvalidDataException("bEzmaxproductIsactive is a required property for EzmaxproductAutocompleteElementResponse and cannot be null");
            }
            else
            {
                this.BEzmaxproductIsactive = bEzmaxproductIsactive;
            }

        }

        /// <summary>
        /// The unique ID of the Ezmaxproduct
        /// </summary>
        /// <value>The unique ID of the Ezmaxproduct</value>
        [DataMember(Name="pkiEzmaxproductID", EmitDefaultValue=true)]
        public int PkiEzmaxproductID { get; set; }

        /// <summary>
        /// The description of the Ezmaxproduct in the language of the requester
        /// </summary>
        /// <value>The description of the Ezmaxproduct in the language of the requester</value>
        [DataMember(Name="sEzmaxproductDescriptionX", EmitDefaultValue=true)]
        public string SEzmaxproductDescriptionX { get; set; }

        /// <summary>
        /// Whether the Ezmaxproduct is active or not
        /// </summary>
        /// <value>Whether the Ezmaxproduct is active or not</value>
        [DataMember(Name="bEzmaxproductIsactive", EmitDefaultValue=true)]
        public bool BEzmaxproductIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzmaxproductAutocompleteElementResponse {\n");
            sb.Append("  PkiEzmaxproductID: ").Append(PkiEzmaxproductID).Append("\n");
            sb.Append("  SEzmaxproductDescriptionX: ").Append(SEzmaxproductDescriptionX).Append("\n");
            sb.Append("  BEzmaxproductIsactive: ").Append(BEzmaxproductIsactive).Append("\n");
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
            return this.Equals(input as EzmaxproductAutocompleteElementResponse);
        }

        /// <summary>
        /// Returns true if EzmaxproductAutocompleteElementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzmaxproductAutocompleteElementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzmaxproductAutocompleteElementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzmaxproductID == input.PkiEzmaxproductID ||
                    (this.PkiEzmaxproductID != null &&
                    this.PkiEzmaxproductID.Equals(input.PkiEzmaxproductID))
                ) && 
                (
                    this.SEzmaxproductDescriptionX == input.SEzmaxproductDescriptionX ||
                    (this.SEzmaxproductDescriptionX != null &&
                    this.SEzmaxproductDescriptionX.Equals(input.SEzmaxproductDescriptionX))
                ) && 
                (
                    this.BEzmaxproductIsactive == input.BEzmaxproductIsactive ||
                    (this.BEzmaxproductIsactive != null &&
                    this.BEzmaxproductIsactive.Equals(input.BEzmaxproductIsactive))
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
                if (this.PkiEzmaxproductID != null)
                    hashCode = hashCode * 59 + this.PkiEzmaxproductID.GetHashCode();
                if (this.SEzmaxproductDescriptionX != null)
                    hashCode = hashCode * 59 + this.SEzmaxproductDescriptionX.GetHashCode();
                if (this.BEzmaxproductIsactive != null)
                    hashCode = hashCode * 59 + this.BEzmaxproductIsactive.GetHashCode();
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


            // PkiEzmaxproductID (int) minimum
            if(this.PkiEzmaxproductID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzmaxproductID, must be a value greater than or equal to 1.", new [] { "PkiEzmaxproductID" });
            }

            yield break;
        }
    }

}
