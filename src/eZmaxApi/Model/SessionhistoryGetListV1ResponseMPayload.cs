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
    /// Payload for GET /1/object/sessionhistory/getList
    /// </summary>
    [DataContract(Name = "sessionhistory-getList-v1-Response-mPayload")]
    public partial class SessionhistoryGetListV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionhistoryGetListV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionhistoryGetListV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionhistoryGetListV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="iRowReturned">The number of rows returned (required).</param>
        /// <param name="iRowFiltered">The number of rows matching your filters (if any) or the total number of rows (required).</param>
        /// <param name="aObjSessionhistory">aObjSessionhistory (required).</param>
        public SessionhistoryGetListV1ResponseMPayload(int iRowReturned = default(int), int iRowFiltered = default(int), List<SessionhistoryListElement> aObjSessionhistory = default(List<SessionhistoryListElement>))
        {
            this.IRowReturned = iRowReturned;
            this.IRowFiltered = iRowFiltered;
            // to ensure "aObjSessionhistory" is required (not null)
            if (aObjSessionhistory == null)
            {
                throw new ArgumentNullException("aObjSessionhistory is a required property for SessionhistoryGetListV1ResponseMPayload and cannot be null");
            }
            this.AObjSessionhistory = aObjSessionhistory;
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
        /// Gets or Sets AObjSessionhistory
        /// </summary>
        [DataMember(Name = "a_objSessionhistory", IsRequired = true, EmitDefaultValue = true)]
        public List<SessionhistoryListElement> AObjSessionhistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SessionhistoryGetListV1ResponseMPayload {\n");
            sb.Append("  IRowReturned: ").Append(IRowReturned).Append("\n");
            sb.Append("  IRowFiltered: ").Append(IRowFiltered).Append("\n");
            sb.Append("  AObjSessionhistory: ").Append(AObjSessionhistory).Append("\n");
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
