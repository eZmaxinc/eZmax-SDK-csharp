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
    /// Request for POST /1/object/ezsignfoldersignerassociation
    /// </summary>
    [DataContract(Name = "ezsignfoldersignerassociation-createObject-v1-Request")]
    public partial class EzsignfoldersignerassociationCreateObjectV1Request : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignfoldersignerassociation">objEzsignfoldersignerassociation.</param>
        /// <param name="objEzsignfoldersignerassociationCompound">objEzsignfoldersignerassociationCompound.</param>
        public EzsignfoldersignerassociationCreateObjectV1Request(EzsignfoldersignerassociationRequest objEzsignfoldersignerassociation = default(EzsignfoldersignerassociationRequest), EzsignfoldersignerassociationRequestCompound objEzsignfoldersignerassociationCompound = default(EzsignfoldersignerassociationRequestCompound))
        {
            this.ObjEzsignfoldersignerassociation = objEzsignfoldersignerassociation;
            this.ObjEzsignfoldersignerassociationCompound = objEzsignfoldersignerassociationCompound;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignfoldersignerassociation
        /// </summary>
        [DataMember(Name = "objEzsignfoldersignerassociation", EmitDefaultValue = false)]
        public EzsignfoldersignerassociationRequest ObjEzsignfoldersignerassociation { get; set; }

        /// <summary>
        /// Gets or Sets ObjEzsignfoldersignerassociationCompound
        /// </summary>
        [DataMember(Name = "objEzsignfoldersignerassociationCompound", EmitDefaultValue = false)]
        public EzsignfoldersignerassociationRequestCompound ObjEzsignfoldersignerassociationCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationCreateObjectV1Request {\n");
            sb.Append("  ObjEzsignfoldersignerassociation: ").Append(ObjEzsignfoldersignerassociation).Append("\n");
            sb.Append("  ObjEzsignfoldersignerassociationCompound: ").Append(ObjEzsignfoldersignerassociationCompound).Append("\n");
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
            yield break;
        }
    }

}
