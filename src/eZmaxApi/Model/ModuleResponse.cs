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
    /// A Module Object
    /// </summary>
    [DataContract]
    public partial class ModuleResponse :  IEquatable<ModuleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModuleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleResponse" /> class.
        /// </summary>
        /// <param name="pkiModuleID">The unique ID of the Module (required).</param>
        /// <param name="fkiModulegroupID">The unique ID of the Modulegroup (required).</param>
        /// <param name="eModuleInternalname">The Internal name of the Module.  This is theoretically an enum field but there are so many possibles values we decided not to list them all. (required).</param>
        /// <param name="sModuleNameX">The Name of the Module in the language of the requester (required).</param>
        /// <param name="bModuleRegistered">Whether the Module is registered or not (required).</param>
        /// <param name="bModuleRegisteredapi">Whether the Module is registered or not for api use (required).</param>
        public ModuleResponse(int pkiModuleID = default(int), int fkiModulegroupID = default(int), string eModuleInternalname = default(string), string sModuleNameX = default(string), bool bModuleRegistered = default(bool), bool bModuleRegisteredapi = default(bool))
        {
            // to ensure "pkiModuleID" is required (not null)
            if (pkiModuleID == null)
            {
                throw new InvalidDataException("pkiModuleID is a required property for ModuleResponse and cannot be null");
            }
            else
            {
                this.PkiModuleID = pkiModuleID;
            }

            // to ensure "fkiModulegroupID" is required (not null)
            if (fkiModulegroupID == null)
            {
                throw new InvalidDataException("fkiModulegroupID is a required property for ModuleResponse and cannot be null");
            }
            else
            {
                this.FkiModulegroupID = fkiModulegroupID;
            }

            // to ensure "eModuleInternalname" is required (not null)
            if (eModuleInternalname == null)
            {
                throw new InvalidDataException("eModuleInternalname is a required property for ModuleResponse and cannot be null");
            }
            else
            {
                this.EModuleInternalname = eModuleInternalname;
            }

            // to ensure "sModuleNameX" is required (not null)
            if (sModuleNameX == null)
            {
                throw new InvalidDataException("sModuleNameX is a required property for ModuleResponse and cannot be null");
            }
            else
            {
                this.SModuleNameX = sModuleNameX;
            }

            // to ensure "bModuleRegistered" is required (not null)
            if (bModuleRegistered == null)
            {
                throw new InvalidDataException("bModuleRegistered is a required property for ModuleResponse and cannot be null");
            }
            else
            {
                this.BModuleRegistered = bModuleRegistered;
            }

            // to ensure "bModuleRegisteredapi" is required (not null)
            if (bModuleRegisteredapi == null)
            {
                throw new InvalidDataException("bModuleRegisteredapi is a required property for ModuleResponse and cannot be null");
            }
            else
            {
                this.BModuleRegisteredapi = bModuleRegisteredapi;
            }

        }

        /// <summary>
        /// The unique ID of the Module
        /// </summary>
        /// <value>The unique ID of the Module</value>
        [DataMember(Name="pkiModuleID", EmitDefaultValue=true)]
        public int PkiModuleID { get; set; }

        /// <summary>
        /// The unique ID of the Modulegroup
        /// </summary>
        /// <value>The unique ID of the Modulegroup</value>
        [DataMember(Name="fkiModulegroupID", EmitDefaultValue=true)]
        public int FkiModulegroupID { get; set; }

        /// <summary>
        /// The Internal name of the Module.  This is theoretically an enum field but there are so many possibles values we decided not to list them all.
        /// </summary>
        /// <value>The Internal name of the Module.  This is theoretically an enum field but there are so many possibles values we decided not to list them all.</value>
        [DataMember(Name="eModuleInternalname", EmitDefaultValue=true)]
        public string EModuleInternalname { get; set; }

        /// <summary>
        /// The Name of the Module in the language of the requester
        /// </summary>
        /// <value>The Name of the Module in the language of the requester</value>
        [DataMember(Name="sModuleNameX", EmitDefaultValue=true)]
        public string SModuleNameX { get; set; }

        /// <summary>
        /// Whether the Module is registered or not
        /// </summary>
        /// <value>Whether the Module is registered or not</value>
        [DataMember(Name="bModuleRegistered", EmitDefaultValue=true)]
        public bool BModuleRegistered { get; set; }

        /// <summary>
        /// Whether the Module is registered or not for api use
        /// </summary>
        /// <value>Whether the Module is registered or not for api use</value>
        [DataMember(Name="bModuleRegisteredapi", EmitDefaultValue=true)]
        public bool BModuleRegisteredapi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModuleResponse {\n");
            sb.Append("  PkiModuleID: ").Append(PkiModuleID).Append("\n");
            sb.Append("  FkiModulegroupID: ").Append(FkiModulegroupID).Append("\n");
            sb.Append("  EModuleInternalname: ").Append(EModuleInternalname).Append("\n");
            sb.Append("  SModuleNameX: ").Append(SModuleNameX).Append("\n");
            sb.Append("  BModuleRegistered: ").Append(BModuleRegistered).Append("\n");
            sb.Append("  BModuleRegisteredapi: ").Append(BModuleRegisteredapi).Append("\n");
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
            return this.Equals(input as ModuleResponse);
        }

        /// <summary>
        /// Returns true if ModuleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ModuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiModuleID == input.PkiModuleID ||
                    (this.PkiModuleID != null &&
                    this.PkiModuleID.Equals(input.PkiModuleID))
                ) && 
                (
                    this.FkiModulegroupID == input.FkiModulegroupID ||
                    (this.FkiModulegroupID != null &&
                    this.FkiModulegroupID.Equals(input.FkiModulegroupID))
                ) && 
                (
                    this.EModuleInternalname == input.EModuleInternalname ||
                    (this.EModuleInternalname != null &&
                    this.EModuleInternalname.Equals(input.EModuleInternalname))
                ) && 
                (
                    this.SModuleNameX == input.SModuleNameX ||
                    (this.SModuleNameX != null &&
                    this.SModuleNameX.Equals(input.SModuleNameX))
                ) && 
                (
                    this.BModuleRegistered == input.BModuleRegistered ||
                    (this.BModuleRegistered != null &&
                    this.BModuleRegistered.Equals(input.BModuleRegistered))
                ) && 
                (
                    this.BModuleRegisteredapi == input.BModuleRegisteredapi ||
                    (this.BModuleRegisteredapi != null &&
                    this.BModuleRegisteredapi.Equals(input.BModuleRegisteredapi))
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
                if (this.PkiModuleID != null)
                    hashCode = hashCode * 59 + this.PkiModuleID.GetHashCode();
                if (this.FkiModulegroupID != null)
                    hashCode = hashCode * 59 + this.FkiModulegroupID.GetHashCode();
                if (this.EModuleInternalname != null)
                    hashCode = hashCode * 59 + this.EModuleInternalname.GetHashCode();
                if (this.SModuleNameX != null)
                    hashCode = hashCode * 59 + this.SModuleNameX.GetHashCode();
                if (this.BModuleRegistered != null)
                    hashCode = hashCode * 59 + this.BModuleRegistered.GetHashCode();
                if (this.BModuleRegisteredapi != null)
                    hashCode = hashCode * 59 + this.BModuleRegisteredapi.GetHashCode();
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


            // PkiModuleID (int) minimum
            if(this.PkiModuleID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiModuleID, must be a value greater than or equal to 0.", new [] { "PkiModuleID" });
            }



            // FkiModulegroupID (int) maximum
            if(this.FkiModulegroupID > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiModulegroupID, must be a value less than or equal to 255.", new [] { "FkiModulegroupID" });
            }

            // FkiModulegroupID (int) minimum
            if(this.FkiModulegroupID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiModulegroupID, must be a value greater than or equal to 1.", new [] { "FkiModulegroupID" });
            }

            yield break;
        }
    }

}