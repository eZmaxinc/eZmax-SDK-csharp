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
    /// A Word Position Object
    /// </summary>
    [DataContract]
    public partial class CustomWordPositionWordResponse :  IEquatable<CustomWordPositionWordResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomWordPositionWordResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomWordPositionWordResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomWordPositionWordResponse" /> class.
        /// </summary>
        /// <param name="sWord">The searched word (required).</param>
        /// <param name="aObjWordPositionOccurence">The found occurences for the seached word (required).</param>
        public CustomWordPositionWordResponse(string sWord = default(string), List<CustomWordPositionOccurenceResponse> aObjWordPositionOccurence = default(List<CustomWordPositionOccurenceResponse>))
        {
            // to ensure "sWord" is required (not null)
            if (sWord == null)
            {
                throw new InvalidDataException("sWord is a required property for CustomWordPositionWordResponse and cannot be null");
            }
            else
            {
                this.SWord = sWord;
            }

            // to ensure "aObjWordPositionOccurence" is required (not null)
            if (aObjWordPositionOccurence == null)
            {
                throw new InvalidDataException("aObjWordPositionOccurence is a required property for CustomWordPositionWordResponse and cannot be null");
            }
            else
            {
                this.AObjWordPositionOccurence = aObjWordPositionOccurence;
            }

        }

        /// <summary>
        /// The searched word
        /// </summary>
        /// <value>The searched word</value>
        [DataMember(Name="sWord", EmitDefaultValue=true)]
        public string SWord { get; set; }

        /// <summary>
        /// The found occurences for the seached word
        /// </summary>
        /// <value>The found occurences for the seached word</value>
        [DataMember(Name="a_objWordPositionOccurence", EmitDefaultValue=true)]
        public List<CustomWordPositionOccurenceResponse> AObjWordPositionOccurence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomWordPositionWordResponse {\n");
            sb.Append("  SWord: ").Append(SWord).Append("\n");
            sb.Append("  AObjWordPositionOccurence: ").Append(AObjWordPositionOccurence).Append("\n");
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
            return this.Equals(input as CustomWordPositionWordResponse);
        }

        /// <summary>
        /// Returns true if CustomWordPositionWordResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomWordPositionWordResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomWordPositionWordResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SWord == input.SWord ||
                    (this.SWord != null &&
                    this.SWord.Equals(input.SWord))
                ) && 
                (
                    this.AObjWordPositionOccurence == input.AObjWordPositionOccurence ||
                    this.AObjWordPositionOccurence != null &&
                    input.AObjWordPositionOccurence != null &&
                    this.AObjWordPositionOccurence.SequenceEqual(input.AObjWordPositionOccurence)
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
                if (this.SWord != null)
                    hashCode = hashCode * 59 + this.SWord.GetHashCode();
                if (this.AObjWordPositionOccurence != null)
                    hashCode = hashCode * 59 + this.AObjWordPositionOccurence.GetHashCode();
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
            yield break;
        }
    }

}
