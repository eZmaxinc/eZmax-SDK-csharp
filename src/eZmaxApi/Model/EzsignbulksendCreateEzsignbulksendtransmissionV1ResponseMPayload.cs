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
    /// Payload for POST /1/object/ezsignbulksend/{pkiEzsignbulksendID}/createEzsignbulksendtransmission
    /// </summary>
    [DataContract]
    public partial class EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload :  IEquatable<EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objEzsignbulksendtransmission">objEzsignbulksendtransmission (required).</param>
        public EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload(EzsignbulksendtransmissionResponse objEzsignbulksendtransmission = default(EzsignbulksendtransmissionResponse))
        {
            // to ensure "objEzsignbulksendtransmission" is required (not null)
            if (objEzsignbulksendtransmission == null)
            {
                throw new InvalidDataException("objEzsignbulksendtransmission is a required property for EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjEzsignbulksendtransmission = objEzsignbulksendtransmission;
            }

        }

        /// <summary>
        /// Gets or Sets ObjEzsignbulksendtransmission
        /// </summary>
        [DataMember(Name="objEzsignbulksendtransmission", EmitDefaultValue=true)]
        public EzsignbulksendtransmissionResponse ObjEzsignbulksendtransmission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload {\n");
            sb.Append("  ObjEzsignbulksendtransmission: ").Append(ObjEzsignbulksendtransmission).Append("\n");
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
            return this.Equals(input as EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignbulksendCreateEzsignbulksendtransmissionV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsignbulksendtransmission == input.ObjEzsignbulksendtransmission ||
                    (this.ObjEzsignbulksendtransmission != null &&
                    this.ObjEzsignbulksendtransmission.Equals(input.ObjEzsignbulksendtransmission))
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
                if (this.ObjEzsignbulksendtransmission != null)
                    hashCode = hashCode * 59 + this.ObjEzsignbulksendtransmission.GetHashCode();
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
