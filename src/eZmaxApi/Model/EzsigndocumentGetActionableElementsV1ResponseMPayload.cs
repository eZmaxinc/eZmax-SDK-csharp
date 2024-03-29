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
    /// Payload for GET /1/object/ezsigndocument/{pkiEzsigndocumentID}/getActionableElements
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentGetActionableElementsV1ResponseMPayload :  IEquatable<EzsigndocumentGetActionableElementsV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetActionableElementsV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentGetActionableElementsV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetActionableElementsV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjEzsignsignature">aObjEzsignsignature (required).</param>
        /// <param name="aObjEzsignformfieldgroup">aObjEzsignformfieldgroup (required).</param>
        public EzsigndocumentGetActionableElementsV1ResponseMPayload(List<EzsignsignatureResponseCompound> aObjEzsignsignature = default(List<EzsignsignatureResponseCompound>), List<EzsignformfieldgroupResponseCompound> aObjEzsignformfieldgroup = default(List<EzsignformfieldgroupResponseCompound>))
        {
            // to ensure "aObjEzsignsignature" is required (not null)
            if (aObjEzsignsignature == null)
            {
                throw new InvalidDataException("aObjEzsignsignature is a required property for EzsigndocumentGetActionableElementsV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjEzsignsignature = aObjEzsignsignature;
            }

            // to ensure "aObjEzsignformfieldgroup" is required (not null)
            if (aObjEzsignformfieldgroup == null)
            {
                throw new InvalidDataException("aObjEzsignformfieldgroup is a required property for EzsigndocumentGetActionableElementsV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.AObjEzsignformfieldgroup = aObjEzsignformfieldgroup;
            }

        }

        /// <summary>
        /// Gets or Sets AObjEzsignsignature
        /// </summary>
        [DataMember(Name="a_objEzsignsignature", EmitDefaultValue=true)]
        public List<EzsignsignatureResponseCompound> AObjEzsignsignature { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsignformfieldgroup
        /// </summary>
        [DataMember(Name="a_objEzsignformfieldgroup", EmitDefaultValue=true)]
        public List<EzsignformfieldgroupResponseCompound> AObjEzsignformfieldgroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentGetActionableElementsV1ResponseMPayload {\n");
            sb.Append("  AObjEzsignsignature: ").Append(AObjEzsignsignature).Append("\n");
            sb.Append("  AObjEzsignformfieldgroup: ").Append(AObjEzsignformfieldgroup).Append("\n");
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
            return this.Equals(input as EzsigndocumentGetActionableElementsV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigndocumentGetActionableElementsV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentGetActionableElementsV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentGetActionableElementsV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjEzsignsignature == input.AObjEzsignsignature ||
                    this.AObjEzsignsignature != null &&
                    input.AObjEzsignsignature != null &&
                    this.AObjEzsignsignature.SequenceEqual(input.AObjEzsignsignature)
                ) && 
                (
                    this.AObjEzsignformfieldgroup == input.AObjEzsignformfieldgroup ||
                    this.AObjEzsignformfieldgroup != null &&
                    input.AObjEzsignformfieldgroup != null &&
                    this.AObjEzsignformfieldgroup.SequenceEqual(input.AObjEzsignformfieldgroup)
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
                if (this.AObjEzsignsignature != null)
                    hashCode = hashCode * 59 + this.AObjEzsignsignature.GetHashCode();
                if (this.AObjEzsignformfieldgroup != null)
                    hashCode = hashCode * 59 + this.AObjEzsignformfieldgroup.GetHashCode();
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
