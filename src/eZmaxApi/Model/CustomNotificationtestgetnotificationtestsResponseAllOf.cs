/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
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
    /// CustomNotificationtestgetnotificationtestsResponseAllOf
    /// </summary>
    [DataContract]
    public partial class CustomNotificationtestgetnotificationtestsResponseAllOf :  IEquatable<CustomNotificationtestgetnotificationtestsResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomNotificationtestgetnotificationtestsResponseAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomNotificationtestgetnotificationtestsResponseAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomNotificationtestgetnotificationtestsResponseAllOf" /> class.
        /// </summary>
        /// <param name="eNotificationpreferenceStatus">eNotificationpreferenceStatus (required).</param>
        /// <param name="iNotificationtest">The number of elements returned by the Notificationtest (required).</param>
        public CustomNotificationtestgetnotificationtestsResponseAllOf(FieldENotificationpreferenceStatus eNotificationpreferenceStatus = default(FieldENotificationpreferenceStatus), int iNotificationtest = default(int))
        {
            // to ensure "eNotificationpreferenceStatus" is required (not null)
            if (eNotificationpreferenceStatus == null)
            {
                throw new InvalidDataException("eNotificationpreferenceStatus is a required property for CustomNotificationtestgetnotificationtestsResponseAllOf and cannot be null");
            }
            else
            {
                this.ENotificationpreferenceStatus = eNotificationpreferenceStatus;
            }

            // to ensure "iNotificationtest" is required (not null)
            if (iNotificationtest == null)
            {
                throw new InvalidDataException("iNotificationtest is a required property for CustomNotificationtestgetnotificationtestsResponseAllOf and cannot be null");
            }
            else
            {
                this.INotificationtest = iNotificationtest;
            }

        }

        /// <summary>
        /// Gets or Sets ENotificationpreferenceStatus
        /// </summary>
        [DataMember(Name="eNotificationpreferenceStatus", EmitDefaultValue=true)]
        public FieldENotificationpreferenceStatus ENotificationpreferenceStatus { get; set; }

        /// <summary>
        /// The number of elements returned by the Notificationtest
        /// </summary>
        /// <value>The number of elements returned by the Notificationtest</value>
        [DataMember(Name="iNotificationtest", EmitDefaultValue=true)]
        public int INotificationtest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomNotificationtestgetnotificationtestsResponseAllOf {\n");
            sb.Append("  ENotificationpreferenceStatus: ").Append(ENotificationpreferenceStatus).Append("\n");
            sb.Append("  INotificationtest: ").Append(INotificationtest).Append("\n");
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
            return this.Equals(input as CustomNotificationtestgetnotificationtestsResponseAllOf);
        }

        /// <summary>
        /// Returns true if CustomNotificationtestgetnotificationtestsResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomNotificationtestgetnotificationtestsResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomNotificationtestgetnotificationtestsResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ENotificationpreferenceStatus == input.ENotificationpreferenceStatus ||
                    (this.ENotificationpreferenceStatus != null &&
                    this.ENotificationpreferenceStatus.Equals(input.ENotificationpreferenceStatus))
                ) && 
                (
                    this.INotificationtest == input.INotificationtest ||
                    (this.INotificationtest != null &&
                    this.INotificationtest.Equals(input.INotificationtest))
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
                if (this.ENotificationpreferenceStatus != null)
                    hashCode = hashCode * 59 + this.ENotificationpreferenceStatus.GetHashCode();
                if (this.INotificationtest != null)
                    hashCode = hashCode * 59 + this.INotificationtest.GetHashCode();
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