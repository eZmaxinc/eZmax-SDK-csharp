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
    /// Payload for GET /2/object/variableexpense/{pkiVariableexpenseID}
    /// </summary>
    [DataContract]
    public partial class VariableexpenseGetObjectV2ResponseMPayload :  IEquatable<VariableexpenseGetObjectV2ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableexpenseGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VariableexpenseGetObjectV2ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableexpenseGetObjectV2ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objVariableexpense">objVariableexpense (required).</param>
        public VariableexpenseGetObjectV2ResponseMPayload(VariableexpenseResponseCompound objVariableexpense = default(VariableexpenseResponseCompound))
        {
            // to ensure "objVariableexpense" is required (not null)
            if (objVariableexpense == null)
            {
                throw new InvalidDataException("objVariableexpense is a required property for VariableexpenseGetObjectV2ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjVariableexpense = objVariableexpense;
            }

        }

        /// <summary>
        /// Gets or Sets ObjVariableexpense
        /// </summary>
        [DataMember(Name="objVariableexpense", EmitDefaultValue=true)]
        public VariableexpenseResponseCompound ObjVariableexpense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableexpenseGetObjectV2ResponseMPayload {\n");
            sb.Append("  ObjVariableexpense: ").Append(ObjVariableexpense).Append("\n");
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
            return this.Equals(input as VariableexpenseGetObjectV2ResponseMPayload);
        }

        /// <summary>
        /// Returns true if VariableexpenseGetObjectV2ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableexpenseGetObjectV2ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableexpenseGetObjectV2ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjVariableexpense == input.ObjVariableexpense ||
                    (this.ObjVariableexpense != null &&
                    this.ObjVariableexpense.Equals(input.ObjVariableexpense))
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
                if (this.ObjVariableexpense != null)
                    hashCode = hashCode * 59 + this.ObjVariableexpense.GetHashCode();
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
