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
    /// Response for GET /1/object/inscription/{pkiInscriptionID}/getAttachments
    /// </summary>
    [DataContract(Name = "inscription-getAttachments-v1-Response-mPayload")]
    public partial class InscriptionGetAttachmentsV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InscriptionGetAttachmentsV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InscriptionGetAttachmentsV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InscriptionGetAttachmentsV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjAttachmentdocumenttype">aObjAttachmentdocumenttype (required).</param>
        public InscriptionGetAttachmentsV1ResponseMPayload(List<CustomAttachmentdocumenttypeResponse> aObjAttachmentdocumenttype = default(List<CustomAttachmentdocumenttypeResponse>))
        {
            // to ensure "aObjAttachmentdocumenttype" is required (not null)
            if (aObjAttachmentdocumenttype == null)
            {
                throw new ArgumentNullException("aObjAttachmentdocumenttype is a required property for InscriptionGetAttachmentsV1ResponseMPayload and cannot be null");
            }
            this.AObjAttachmentdocumenttype = aObjAttachmentdocumenttype;
        }

        /// <summary>
        /// Gets or Sets AObjAttachmentdocumenttype
        /// </summary>
        [DataMember(Name = "a_objAttachmentdocumenttype", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomAttachmentdocumenttypeResponse> AObjAttachmentdocumenttype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InscriptionGetAttachmentsV1ResponseMPayload {\n");
            sb.Append("  AObjAttachmentdocumenttype: ").Append(AObjAttachmentdocumenttype).Append("\n");
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
            yield break;
        }
    }

}