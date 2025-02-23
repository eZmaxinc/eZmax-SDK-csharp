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
    /// Payload for GET /1/object/ezsignsigningreason/getList
    /// </summary>
    [DataContract(Name = "ezsignsigningreason-getList-v1-Response-mPayload")]
    public partial class EzsignsigningreasonGetListV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonGetListV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsigningreasonGetListV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsigningreasonGetListV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="iRowReturned">The number of rows returned (required).</param>
        /// <param name="iRowFiltered">The number of rows matching your filters (if any) or the total number of rows (required).</param>
        /// <param name="aObjEzsignsigningreason">aObjEzsignsigningreason (required).</param>
        public EzsignsigningreasonGetListV1ResponseMPayload(int iRowReturned = default(int), int iRowFiltered = default(int), List<EzsignsigningreasonListElement> aObjEzsignsigningreason = default(List<EzsignsigningreasonListElement>))
        {
            this.IRowReturned = iRowReturned;
            this.IRowFiltered = iRowFiltered;
            // to ensure "aObjEzsignsigningreason" is required (not null)
            if (aObjEzsignsigningreason == null)
            {
                throw new ArgumentNullException("aObjEzsignsigningreason is a required property for EzsignsigningreasonGetListV1ResponseMPayload and cannot be null");
            }
            this.AObjEzsignsigningreason = aObjEzsignsigningreason;
        }

        /// <summary>
        /// The number of rows returned
        /// </summary>
        /// <value>The number of rows returned</value>
        /* <example>100</example>*/
        [DataMember(Name = "iRowReturned", IsRequired = true, EmitDefaultValue = true)]
        public int IRowReturned { get; set; }

        /// <summary>
        /// The number of rows matching your filters (if any) or the total number of rows
        /// </summary>
        /// <value>The number of rows matching your filters (if any) or the total number of rows</value>
        /* <example>533</example>*/
        [DataMember(Name = "iRowFiltered", IsRequired = true, EmitDefaultValue = true)]
        public int IRowFiltered { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsignsigningreason
        /// </summary>
        [DataMember(Name = "a_objEzsignsigningreason", IsRequired = true, EmitDefaultValue = true)]
        public List<EzsignsigningreasonListElement> AObjEzsignsigningreason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsignsigningreasonGetListV1ResponseMPayload {\n");
            sb.Append("  IRowReturned: ").Append(IRowReturned).Append("\n");
            sb.Append("  IRowFiltered: ").Append(IRowFiltered).Append("\n");
            sb.Append("  AObjEzsignsigningreason: ").Append(AObjEzsignsigningreason).Append("\n");
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
