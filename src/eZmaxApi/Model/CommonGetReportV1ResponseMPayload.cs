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
    /// Payload for POST /1/report/xxx/xxx and and /1/module/report/getReportFromCache
    /// </summary>
    [DataContract]
    public partial class CommonGetReportV1ResponseMPayload :  IEquatable<CommonGetReportV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonGetReportV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonGetReportV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonGetReportV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="objReportgroup">objReportgroup (required).</param>
        public CommonGetReportV1ResponseMPayload(CommonReportgroup objReportgroup = default(CommonReportgroup))
        {
            // to ensure "objReportgroup" is required (not null)
            if (objReportgroup == null)
            {
                throw new InvalidDataException("objReportgroup is a required property for CommonGetReportV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.ObjReportgroup = objReportgroup;
            }

        }

        /// <summary>
        /// Gets or Sets ObjReportgroup
        /// </summary>
        [DataMember(Name="objReportgroup", EmitDefaultValue=true)]
        public CommonReportgroup ObjReportgroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonGetReportV1ResponseMPayload {\n");
            sb.Append("  ObjReportgroup: ").Append(ObjReportgroup).Append("\n");
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
            return this.Equals(input as CommonGetReportV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if CommonGetReportV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonGetReportV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonGetReportV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjReportgroup == input.ObjReportgroup ||
                    (this.ObjReportgroup != null &&
                    this.ObjReportgroup.Equals(input.ObjReportgroup))
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
                if (this.ObjReportgroup != null)
                    hashCode = hashCode * 59 + this.ObjReportgroup.GetHashCode();
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