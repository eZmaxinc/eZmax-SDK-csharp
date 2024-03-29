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
    /// A row in a Reportsubsectionpart 
    /// </summary>
    [DataContract]
    public partial class CommonReportrow :  IEquatable<CommonReportrow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonReportrow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonReportrow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonReportrow" /> class.
        /// </summary>
        /// <param name="aObjReportcell">aObjReportcell (required).</param>
        /// <param name="iReportrowHeight">The reportrow height in pixels (required).</param>
        public CommonReportrow(List<CommonReportcell> aObjReportcell = default(List<CommonReportcell>), int iReportrowHeight = default(int))
        {
            // to ensure "aObjReportcell" is required (not null)
            if (aObjReportcell == null)
            {
                throw new InvalidDataException("aObjReportcell is a required property for CommonReportrow and cannot be null");
            }
            else
            {
                this.AObjReportcell = aObjReportcell;
            }

            // to ensure "iReportrowHeight" is required (not null)
            if (iReportrowHeight == null)
            {
                throw new InvalidDataException("iReportrowHeight is a required property for CommonReportrow and cannot be null");
            }
            else
            {
                this.IReportrowHeight = iReportrowHeight;
            }

        }

        /// <summary>
        /// Gets or Sets AObjReportcell
        /// </summary>
        [DataMember(Name="a_objReportcell", EmitDefaultValue=true)]
        public List<CommonReportcell> AObjReportcell { get; set; }

        /// <summary>
        /// The reportrow height in pixels
        /// </summary>
        /// <value>The reportrow height in pixels</value>
        [DataMember(Name="iReportrowHeight", EmitDefaultValue=true)]
        public int IReportrowHeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonReportrow {\n");
            sb.Append("  AObjReportcell: ").Append(AObjReportcell).Append("\n");
            sb.Append("  IReportrowHeight: ").Append(IReportrowHeight).Append("\n");
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
            return this.Equals(input as CommonReportrow);
        }

        /// <summary>
        /// Returns true if CommonReportrow instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonReportrow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonReportrow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjReportcell == input.AObjReportcell ||
                    this.AObjReportcell != null &&
                    input.AObjReportcell != null &&
                    this.AObjReportcell.SequenceEqual(input.AObjReportcell)
                ) && 
                (
                    this.IReportrowHeight == input.IReportrowHeight ||
                    (this.IReportrowHeight != null &&
                    this.IReportrowHeight.Equals(input.IReportrowHeight))
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
                if (this.AObjReportcell != null)
                    hashCode = hashCode * 59 + this.AObjReportcell.GetHashCode();
                if (this.IReportrowHeight != null)
                    hashCode = hashCode * 59 + this.IReportrowHeight.GetHashCode();
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
