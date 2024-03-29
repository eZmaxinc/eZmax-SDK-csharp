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
    /// Request for PATCH /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}
    /// </summary>
    [DataContract]
    public partial class EzsignfoldersignerassociationPatchObjectV1Request :  IEquatable<EzsignfoldersignerassociationPatchObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationPatchObjectV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldersignerassociationPatchObjectV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationPatchObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignfoldersignerassociation">objEzsignfoldersignerassociation (required).</param>
        public EzsignfoldersignerassociationPatchObjectV1Request(EzsignfoldersignerassociationRequestPatch objEzsignfoldersignerassociation = default(EzsignfoldersignerassociationRequestPatch))
        {
            // to ensure "objEzsignfoldersignerassociation" is required (not null)
            if (objEzsignfoldersignerassociation == null)
            {
                throw new InvalidDataException("objEzsignfoldersignerassociation is a required property for EzsignfoldersignerassociationPatchObjectV1Request and cannot be null");
            }
            else
            {
                this.ObjEzsignfoldersignerassociation = objEzsignfoldersignerassociation;
            }

        }

        /// <summary>
        /// Gets or Sets ObjEzsignfoldersignerassociation
        /// </summary>
        [DataMember(Name="objEzsignfoldersignerassociation", EmitDefaultValue=true)]
        public EzsignfoldersignerassociationRequestPatch ObjEzsignfoldersignerassociation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationPatchObjectV1Request {\n");
            sb.Append("  ObjEzsignfoldersignerassociation: ").Append(ObjEzsignfoldersignerassociation).Append("\n");
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
            return this.Equals(input as EzsignfoldersignerassociationPatchObjectV1Request);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationPatchObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationPatchObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationPatchObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsignfoldersignerassociation == input.ObjEzsignfoldersignerassociation ||
                    (this.ObjEzsignfoldersignerassociation != null &&
                    this.ObjEzsignfoldersignerassociation.Equals(input.ObjEzsignfoldersignerassociation))
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
                if (this.ObjEzsignfoldersignerassociation != null)
                    hashCode = hashCode * 59 + this.ObjEzsignfoldersignerassociation.GetHashCode();
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
