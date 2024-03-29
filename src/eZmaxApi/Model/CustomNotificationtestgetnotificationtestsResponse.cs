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
    /// A Notificationtest Object in the context of getNotificationtests
    /// </summary>
    [DataContract]
    public partial class CustomNotificationtestgetnotificationtestsResponse :  IEquatable<CustomNotificationtestgetnotificationtestsResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ENotificationpreferenceStatus
        /// </summary>
        [DataMember(Name="eNotificationpreferenceStatus", EmitDefaultValue=true)]
        public FieldENotificationpreferenceStatus ENotificationpreferenceStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomNotificationtestgetnotificationtestsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomNotificationtestgetnotificationtestsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomNotificationtestgetnotificationtestsResponse" /> class.
        /// </summary>
        /// <param name="pkiNotificationtestID">The unique ID of the Notificationtest (required).</param>
        /// <param name="objNotificationtestName">objNotificationtestName (required).</param>
        /// <param name="fkiNotificationsubsectionID">The unique ID of the Notificationsubsection (required).</param>
        /// <param name="sNotificationtestFunction">The function name of the Notificationtest (required).</param>
        /// <param name="sNotificationtestNameX">The name of the Notificationtest in the language of the requester (required).</param>
        /// <param name="eNotificationpreferenceStatus">eNotificationpreferenceStatus (required).</param>
        /// <param name="iNotificationtest">The number of elements returned by the Notificationtest (required).</param>
        public CustomNotificationtestgetnotificationtestsResponse(int pkiNotificationtestID = default(int), MultilingualNotificationtestName objNotificationtestName = default(MultilingualNotificationtestName), int fkiNotificationsubsectionID = default(int), string sNotificationtestFunction = default(string), string sNotificationtestNameX = default(string), FieldENotificationpreferenceStatus eNotificationpreferenceStatus = default(FieldENotificationpreferenceStatus), int iNotificationtest = default(int))
        {
            // to ensure "pkiNotificationtestID" is required (not null)
            if (pkiNotificationtestID == null)
            {
                throw new InvalidDataException("pkiNotificationtestID is a required property for CustomNotificationtestgetnotificationtestsResponse and cannot be null");
            }
            else
            {
                this.PkiNotificationtestID = pkiNotificationtestID;
            }

            // to ensure "objNotificationtestName" is required (not null)
            if (objNotificationtestName == null)
            {
                throw new InvalidDataException("objNotificationtestName is a required property for CustomNotificationtestgetnotificationtestsResponse and cannot be null");
            }
            else
            {
                this.ObjNotificationtestName = objNotificationtestName;
            }

            // to ensure "fkiNotificationsubsectionID" is required (not null)
            if (fkiNotificationsubsectionID == null)
            {
                throw new InvalidDataException("fkiNotificationsubsectionID is a required property for CustomNotificationtestgetnotificationtestsResponse and cannot be null");
            }
            else
            {
                this.FkiNotificationsubsectionID = fkiNotificationsubsectionID;
            }

            // to ensure "sNotificationtestFunction" is required (not null)
            if (sNotificationtestFunction == null)
            {
                throw new InvalidDataException("sNotificationtestFunction is a required property for CustomNotificationtestgetnotificationtestsResponse and cannot be null");
            }
            else
            {
                this.SNotificationtestFunction = sNotificationtestFunction;
            }

            // to ensure "sNotificationtestNameX" is required (not null)
            if (sNotificationtestNameX == null)
            {
                throw new InvalidDataException("sNotificationtestNameX is a required property for CustomNotificationtestgetnotificationtestsResponse and cannot be null");
            }
            else
            {
                this.SNotificationtestNameX = sNotificationtestNameX;
            }

            // to ensure "eNotificationpreferenceStatus" is required (not null)
            if (eNotificationpreferenceStatus == null)
            {
                throw new InvalidDataException("eNotificationpreferenceStatus is a required property for CustomNotificationtestgetnotificationtestsResponse and cannot be null");
            }
            else
            {
                this.ENotificationpreferenceStatus = eNotificationpreferenceStatus;
            }

            // to ensure "iNotificationtest" is required (not null)
            if (iNotificationtest == null)
            {
                throw new InvalidDataException("iNotificationtest is a required property for CustomNotificationtestgetnotificationtestsResponse and cannot be null");
            }
            else
            {
                this.INotificationtest = iNotificationtest;
            }

        }

        /// <summary>
        /// The unique ID of the Notificationtest
        /// </summary>
        /// <value>The unique ID of the Notificationtest</value>
        [DataMember(Name="pkiNotificationtestID", EmitDefaultValue=true)]
        public int PkiNotificationtestID { get; set; }

        /// <summary>
        /// Gets or Sets ObjNotificationtestName
        /// </summary>
        [DataMember(Name="objNotificationtestName", EmitDefaultValue=true)]
        public MultilingualNotificationtestName ObjNotificationtestName { get; set; }

        /// <summary>
        /// The unique ID of the Notificationsubsection
        /// </summary>
        /// <value>The unique ID of the Notificationsubsection</value>
        [DataMember(Name="fkiNotificationsubsectionID", EmitDefaultValue=true)]
        public int FkiNotificationsubsectionID { get; set; }

        /// <summary>
        /// The function name of the Notificationtest
        /// </summary>
        /// <value>The function name of the Notificationtest</value>
        [DataMember(Name="sNotificationtestFunction", EmitDefaultValue=true)]
        public string SNotificationtestFunction { get; set; }

        /// <summary>
        /// The name of the Notificationtest in the language of the requester
        /// </summary>
        /// <value>The name of the Notificationtest in the language of the requester</value>
        [DataMember(Name="sNotificationtestNameX", EmitDefaultValue=true)]
        public string SNotificationtestNameX { get; set; }


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
            sb.Append("class CustomNotificationtestgetnotificationtestsResponse {\n");
            sb.Append("  PkiNotificationtestID: ").Append(PkiNotificationtestID).Append("\n");
            sb.Append("  ObjNotificationtestName: ").Append(ObjNotificationtestName).Append("\n");
            sb.Append("  FkiNotificationsubsectionID: ").Append(FkiNotificationsubsectionID).Append("\n");
            sb.Append("  SNotificationtestFunction: ").Append(SNotificationtestFunction).Append("\n");
            sb.Append("  SNotificationtestNameX: ").Append(SNotificationtestNameX).Append("\n");
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
            return this.Equals(input as CustomNotificationtestgetnotificationtestsResponse);
        }

        /// <summary>
        /// Returns true if CustomNotificationtestgetnotificationtestsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomNotificationtestgetnotificationtestsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomNotificationtestgetnotificationtestsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiNotificationtestID == input.PkiNotificationtestID ||
                    (this.PkiNotificationtestID != null &&
                    this.PkiNotificationtestID.Equals(input.PkiNotificationtestID))
                ) && 
                (
                    this.ObjNotificationtestName == input.ObjNotificationtestName ||
                    (this.ObjNotificationtestName != null &&
                    this.ObjNotificationtestName.Equals(input.ObjNotificationtestName))
                ) && 
                (
                    this.FkiNotificationsubsectionID == input.FkiNotificationsubsectionID ||
                    (this.FkiNotificationsubsectionID != null &&
                    this.FkiNotificationsubsectionID.Equals(input.FkiNotificationsubsectionID))
                ) && 
                (
                    this.SNotificationtestFunction == input.SNotificationtestFunction ||
                    (this.SNotificationtestFunction != null &&
                    this.SNotificationtestFunction.Equals(input.SNotificationtestFunction))
                ) && 
                (
                    this.SNotificationtestNameX == input.SNotificationtestNameX ||
                    (this.SNotificationtestNameX != null &&
                    this.SNotificationtestNameX.Equals(input.SNotificationtestNameX))
                ) && 
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
                if (this.PkiNotificationtestID != null)
                    hashCode = hashCode * 59 + this.PkiNotificationtestID.GetHashCode();
                if (this.ObjNotificationtestName != null)
                    hashCode = hashCode * 59 + this.ObjNotificationtestName.GetHashCode();
                if (this.FkiNotificationsubsectionID != null)
                    hashCode = hashCode * 59 + this.FkiNotificationsubsectionID.GetHashCode();
                if (this.SNotificationtestFunction != null)
                    hashCode = hashCode * 59 + this.SNotificationtestFunction.GetHashCode();
                if (this.SNotificationtestNameX != null)
                    hashCode = hashCode * 59 + this.SNotificationtestNameX.GetHashCode();
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


            // PkiNotificationtestID (int) minimum
            if(this.PkiNotificationtestID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiNotificationtestID, must be a value greater than or equal to 0.", new [] { "PkiNotificationtestID" });
            }



            // FkiNotificationsubsectionID (int) minimum
            if(this.FkiNotificationsubsectionID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiNotificationsubsectionID, must be a value greater than or equal to 0.", new [] { "FkiNotificationsubsectionID" });
            }

            yield break;
        }
    }

}
