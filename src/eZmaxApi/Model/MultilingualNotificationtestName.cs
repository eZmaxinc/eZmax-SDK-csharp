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
    /// Name of the Notificationtest
    /// </summary>
    [DataContract]
    public partial class MultilingualNotificationtestName :  IEquatable<MultilingualNotificationtestName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualNotificationtestName" /> class.
        /// </summary>
        /// <param name="sNotificationtestName1">The name of the Notificationtest in French.</param>
        /// <param name="sNotificationtestName2">The name of the Notificationtest in English.</param>
        public MultilingualNotificationtestName(string sNotificationtestName1 = default(string), string sNotificationtestName2 = default(string))
        {
            this.SNotificationtestName1 = sNotificationtestName1;
            this.SNotificationtestName2 = sNotificationtestName2;
        }

        /// <summary>
        /// The name of the Notificationtest in French
        /// </summary>
        /// <value>The name of the Notificationtest in French</value>
        [DataMember(Name="sNotificationtestName1", EmitDefaultValue=false)]
        public string SNotificationtestName1 { get; set; }

        /// <summary>
        /// The name of the Notificationtest in English
        /// </summary>
        /// <value>The name of the Notificationtest in English</value>
        [DataMember(Name="sNotificationtestName2", EmitDefaultValue=false)]
        public string SNotificationtestName2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultilingualNotificationtestName {\n");
            sb.Append("  SNotificationtestName1: ").Append(SNotificationtestName1).Append("\n");
            sb.Append("  SNotificationtestName2: ").Append(SNotificationtestName2).Append("\n");
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
            return this.Equals(input as MultilingualNotificationtestName);
        }

        /// <summary>
        /// Returns true if MultilingualNotificationtestName instances are equal
        /// </summary>
        /// <param name="input">Instance of MultilingualNotificationtestName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultilingualNotificationtestName input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SNotificationtestName1 == input.SNotificationtestName1 ||
                    (this.SNotificationtestName1 != null &&
                    this.SNotificationtestName1.Equals(input.SNotificationtestName1))
                ) && 
                (
                    this.SNotificationtestName2 == input.SNotificationtestName2 ||
                    (this.SNotificationtestName2 != null &&
                    this.SNotificationtestName2.Equals(input.SNotificationtestName2))
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
                if (this.SNotificationtestName1 != null)
                    hashCode = hashCode * 59 + this.SNotificationtestName1.GetHashCode();
                if (this.SNotificationtestName2 != null)
                    hashCode = hashCode * 59 + this.SNotificationtestName2.GetHashCode();
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