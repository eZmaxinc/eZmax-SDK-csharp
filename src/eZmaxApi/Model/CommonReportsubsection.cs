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
    /// A Subsection in a Reportsection. It contains 3 Reportsubsectionparts (Header, Body and Footer) 
    /// </summary>
    [DataContract]
    public partial class CommonReportsubsection :  IEquatable<CommonReportsubsection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonReportsubsection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonReportsubsection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonReportsubsection" /> class.
        /// </summary>
        /// <param name="objReportsubsectionpartHeader">objReportsubsectionpartHeader (required).</param>
        /// <param name="objReportsubsectionpartBody">objReportsubsectionpartBody (required).</param>
        /// <param name="objReportsubsectionpartFooter">objReportsubsectionpartFooter (required).</param>
        public CommonReportsubsection(CommonReportsubsectionpart objReportsubsectionpartHeader = default(CommonReportsubsectionpart), CommonReportsubsectionpart objReportsubsectionpartBody = default(CommonReportsubsectionpart), CommonReportsubsectionpart objReportsubsectionpartFooter = default(CommonReportsubsectionpart))
        {
            // to ensure "objReportsubsectionpartHeader" is required (not null)
            if (objReportsubsectionpartHeader == null)
            {
                throw new InvalidDataException("objReportsubsectionpartHeader is a required property for CommonReportsubsection and cannot be null");
            }
            else
            {
                this.ObjReportsubsectionpartHeader = objReportsubsectionpartHeader;
            }

            // to ensure "objReportsubsectionpartBody" is required (not null)
            if (objReportsubsectionpartBody == null)
            {
                throw new InvalidDataException("objReportsubsectionpartBody is a required property for CommonReportsubsection and cannot be null");
            }
            else
            {
                this.ObjReportsubsectionpartBody = objReportsubsectionpartBody;
            }

            // to ensure "objReportsubsectionpartFooter" is required (not null)
            if (objReportsubsectionpartFooter == null)
            {
                throw new InvalidDataException("objReportsubsectionpartFooter is a required property for CommonReportsubsection and cannot be null");
            }
            else
            {
                this.ObjReportsubsectionpartFooter = objReportsubsectionpartFooter;
            }

        }

        /// <summary>
        /// Gets or Sets ObjReportsubsectionpartHeader
        /// </summary>
        [DataMember(Name="objReportsubsectionpartHeader", EmitDefaultValue=true)]
        public CommonReportsubsectionpart ObjReportsubsectionpartHeader { get; set; }

        /// <summary>
        /// Gets or Sets ObjReportsubsectionpartBody
        /// </summary>
        [DataMember(Name="objReportsubsectionpartBody", EmitDefaultValue=true)]
        public CommonReportsubsectionpart ObjReportsubsectionpartBody { get; set; }

        /// <summary>
        /// Gets or Sets ObjReportsubsectionpartFooter
        /// </summary>
        [DataMember(Name="objReportsubsectionpartFooter", EmitDefaultValue=true)]
        public CommonReportsubsectionpart ObjReportsubsectionpartFooter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonReportsubsection {\n");
            sb.Append("  ObjReportsubsectionpartHeader: ").Append(ObjReportsubsectionpartHeader).Append("\n");
            sb.Append("  ObjReportsubsectionpartBody: ").Append(ObjReportsubsectionpartBody).Append("\n");
            sb.Append("  ObjReportsubsectionpartFooter: ").Append(ObjReportsubsectionpartFooter).Append("\n");
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
            return this.Equals(input as CommonReportsubsection);
        }

        /// <summary>
        /// Returns true if CommonReportsubsection instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonReportsubsection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonReportsubsection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjReportsubsectionpartHeader == input.ObjReportsubsectionpartHeader ||
                    (this.ObjReportsubsectionpartHeader != null &&
                    this.ObjReportsubsectionpartHeader.Equals(input.ObjReportsubsectionpartHeader))
                ) && 
                (
                    this.ObjReportsubsectionpartBody == input.ObjReportsubsectionpartBody ||
                    (this.ObjReportsubsectionpartBody != null &&
                    this.ObjReportsubsectionpartBody.Equals(input.ObjReportsubsectionpartBody))
                ) && 
                (
                    this.ObjReportsubsectionpartFooter == input.ObjReportsubsectionpartFooter ||
                    (this.ObjReportsubsectionpartFooter != null &&
                    this.ObjReportsubsectionpartFooter.Equals(input.ObjReportsubsectionpartFooter))
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
                if (this.ObjReportsubsectionpartHeader != null)
                    hashCode = hashCode * 59 + this.ObjReportsubsectionpartHeader.GetHashCode();
                if (this.ObjReportsubsectionpartBody != null)
                    hashCode = hashCode * 59 + this.ObjReportsubsectionpartBody.GetHashCode();
                if (this.ObjReportsubsectionpartFooter != null)
                    hashCode = hashCode * 59 + this.ObjReportsubsectionpartFooter.GetHashCode();
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