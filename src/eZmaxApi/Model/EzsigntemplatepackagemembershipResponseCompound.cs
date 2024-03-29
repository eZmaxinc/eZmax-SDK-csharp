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
    /// A Ezsigntemplatepackagemembership Object
    /// </summary>
    [DataContract]
    public partial class EzsigntemplatepackagemembershipResponseCompound :  IEquatable<EzsigntemplatepackagemembershipResponseCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackagemembershipResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatepackagemembershipResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepackagemembershipResponseCompound" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplatepackagemembershipID">The unique ID of the Ezsigntemplatepackagemembership (required).</param>
        /// <param name="fkiEzsigntemplatepackageID">The unique ID of the Ezsigntemplatepackage (required).</param>
        /// <param name="fkiEzsigntemplateID">The unique ID of the Ezsigntemplate (required).</param>
        /// <param name="iEzsigntemplatepackagemembershipOrder">The order in which the Ezsigntemplate will be imported when using an Ezsigntemplatepackage. (required).</param>
        /// <param name="objEzsigntemplate">objEzsigntemplate (required).</param>
        /// <param name="aObjEzsigntemplatepackagesignermembership">aObjEzsigntemplatepackagesignermembership (required).</param>
        public EzsigntemplatepackagemembershipResponseCompound(int pkiEzsigntemplatepackagemembershipID = default(int), int fkiEzsigntemplatepackageID = default(int), int fkiEzsigntemplateID = default(int), int iEzsigntemplatepackagemembershipOrder = default(int), EzsigntemplateResponseCompound objEzsigntemplate = default(EzsigntemplateResponseCompound), List<EzsigntemplatepackagesignermembershipResponseCompound> aObjEzsigntemplatepackagesignermembership = default(List<EzsigntemplatepackagesignermembershipResponseCompound>))
        {
            // to ensure "pkiEzsigntemplatepackagemembershipID" is required (not null)
            if (pkiEzsigntemplatepackagemembershipID == null)
            {
                throw new InvalidDataException("pkiEzsigntemplatepackagemembershipID is a required property for EzsigntemplatepackagemembershipResponseCompound and cannot be null");
            }
            else
            {
                this.PkiEzsigntemplatepackagemembershipID = pkiEzsigntemplatepackagemembershipID;
            }

            // to ensure "fkiEzsigntemplatepackageID" is required (not null)
            if (fkiEzsigntemplatepackageID == null)
            {
                throw new InvalidDataException("fkiEzsigntemplatepackageID is a required property for EzsigntemplatepackagemembershipResponseCompound and cannot be null");
            }
            else
            {
                this.FkiEzsigntemplatepackageID = fkiEzsigntemplatepackageID;
            }

            // to ensure "fkiEzsigntemplateID" is required (not null)
            if (fkiEzsigntemplateID == null)
            {
                throw new InvalidDataException("fkiEzsigntemplateID is a required property for EzsigntemplatepackagemembershipResponseCompound and cannot be null");
            }
            else
            {
                this.FkiEzsigntemplateID = fkiEzsigntemplateID;
            }

            // to ensure "iEzsigntemplatepackagemembershipOrder" is required (not null)
            if (iEzsigntemplatepackagemembershipOrder == null)
            {
                throw new InvalidDataException("iEzsigntemplatepackagemembershipOrder is a required property for EzsigntemplatepackagemembershipResponseCompound and cannot be null");
            }
            else
            {
                this.IEzsigntemplatepackagemembershipOrder = iEzsigntemplatepackagemembershipOrder;
            }

            // to ensure "objEzsigntemplate" is required (not null)
            if (objEzsigntemplate == null)
            {
                throw new InvalidDataException("objEzsigntemplate is a required property for EzsigntemplatepackagemembershipResponseCompound and cannot be null");
            }
            else
            {
                this.ObjEzsigntemplate = objEzsigntemplate;
            }

            // to ensure "aObjEzsigntemplatepackagesignermembership" is required (not null)
            if (aObjEzsigntemplatepackagesignermembership == null)
            {
                throw new InvalidDataException("aObjEzsigntemplatepackagesignermembership is a required property for EzsigntemplatepackagemembershipResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzsigntemplatepackagesignermembership = aObjEzsigntemplatepackagesignermembership;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsigntemplatepackagemembership
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatepackagemembership</value>
        [DataMember(Name="pkiEzsigntemplatepackagemembershipID", EmitDefaultValue=true)]
        public int PkiEzsigntemplatepackagemembershipID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplatepackage
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatepackage</value>
        [DataMember(Name="fkiEzsigntemplatepackageID", EmitDefaultValue=true)]
        public int FkiEzsigntemplatepackageID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        [DataMember(Name="fkiEzsigntemplateID", EmitDefaultValue=true)]
        public int FkiEzsigntemplateID { get; set; }

        /// <summary>
        /// The order in which the Ezsigntemplate will be imported when using an Ezsigntemplatepackage.
        /// </summary>
        /// <value>The order in which the Ezsigntemplate will be imported when using an Ezsigntemplatepackage.</value>
        [DataMember(Name="iEzsigntemplatepackagemembershipOrder", EmitDefaultValue=true)]
        public int IEzsigntemplatepackagemembershipOrder { get; set; }

        /// <summary>
        /// Gets or Sets ObjEzsigntemplate
        /// </summary>
        [DataMember(Name="objEzsigntemplate", EmitDefaultValue=true)]
        public EzsigntemplateResponseCompound ObjEzsigntemplate { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsigntemplatepackagesignermembership
        /// </summary>
        [DataMember(Name="a_objEzsigntemplatepackagesignermembership", EmitDefaultValue=true)]
        public List<EzsigntemplatepackagesignermembershipResponseCompound> AObjEzsigntemplatepackagesignermembership { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigntemplatepackagemembershipResponseCompound {\n");
            sb.Append("  PkiEzsigntemplatepackagemembershipID: ").Append(PkiEzsigntemplatepackagemembershipID).Append("\n");
            sb.Append("  FkiEzsigntemplatepackageID: ").Append(FkiEzsigntemplatepackageID).Append("\n");
            sb.Append("  FkiEzsigntemplateID: ").Append(FkiEzsigntemplateID).Append("\n");
            sb.Append("  IEzsigntemplatepackagemembershipOrder: ").Append(IEzsigntemplatepackagemembershipOrder).Append("\n");
            sb.Append("  ObjEzsigntemplate: ").Append(ObjEzsigntemplate).Append("\n");
            sb.Append("  AObjEzsigntemplatepackagesignermembership: ").Append(AObjEzsigntemplatepackagesignermembership).Append("\n");
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
            return this.Equals(input as EzsigntemplatepackagemembershipResponseCompound);
        }

        /// <summary>
        /// Returns true if EzsigntemplatepackagemembershipResponseCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigntemplatepackagemembershipResponseCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigntemplatepackagemembershipResponseCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsigntemplatepackagemembershipID == input.PkiEzsigntemplatepackagemembershipID ||
                    (this.PkiEzsigntemplatepackagemembershipID != null &&
                    this.PkiEzsigntemplatepackagemembershipID.Equals(input.PkiEzsigntemplatepackagemembershipID))
                ) && 
                (
                    this.FkiEzsigntemplatepackageID == input.FkiEzsigntemplatepackageID ||
                    (this.FkiEzsigntemplatepackageID != null &&
                    this.FkiEzsigntemplatepackageID.Equals(input.FkiEzsigntemplatepackageID))
                ) && 
                (
                    this.FkiEzsigntemplateID == input.FkiEzsigntemplateID ||
                    (this.FkiEzsigntemplateID != null &&
                    this.FkiEzsigntemplateID.Equals(input.FkiEzsigntemplateID))
                ) && 
                (
                    this.IEzsigntemplatepackagemembershipOrder == input.IEzsigntemplatepackagemembershipOrder ||
                    (this.IEzsigntemplatepackagemembershipOrder != null &&
                    this.IEzsigntemplatepackagemembershipOrder.Equals(input.IEzsigntemplatepackagemembershipOrder))
                ) && 
                (
                    this.ObjEzsigntemplate == input.ObjEzsigntemplate ||
                    (this.ObjEzsigntemplate != null &&
                    this.ObjEzsigntemplate.Equals(input.ObjEzsigntemplate))
                ) && 
                (
                    this.AObjEzsigntemplatepackagesignermembership == input.AObjEzsigntemplatepackagesignermembership ||
                    this.AObjEzsigntemplatepackagesignermembership != null &&
                    input.AObjEzsigntemplatepackagesignermembership != null &&
                    this.AObjEzsigntemplatepackagesignermembership.SequenceEqual(input.AObjEzsigntemplatepackagesignermembership)
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
                if (this.PkiEzsigntemplatepackagemembershipID != null)
                    hashCode = hashCode * 59 + this.PkiEzsigntemplatepackagemembershipID.GetHashCode();
                if (this.FkiEzsigntemplatepackageID != null)
                    hashCode = hashCode * 59 + this.FkiEzsigntemplatepackageID.GetHashCode();
                if (this.FkiEzsigntemplateID != null)
                    hashCode = hashCode * 59 + this.FkiEzsigntemplateID.GetHashCode();
                if (this.IEzsigntemplatepackagemembershipOrder != null)
                    hashCode = hashCode * 59 + this.IEzsigntemplatepackagemembershipOrder.GetHashCode();
                if (this.ObjEzsigntemplate != null)
                    hashCode = hashCode * 59 + this.ObjEzsigntemplate.GetHashCode();
                if (this.AObjEzsigntemplatepackagesignermembership != null)
                    hashCode = hashCode * 59 + this.AObjEzsigntemplatepackagesignermembership.GetHashCode();
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


            // PkiEzsigntemplatepackagemembershipID (int) minimum
            if(this.PkiEzsigntemplatepackagemembershipID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzsigntemplatepackagemembershipID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplatepackagemembershipID" });
            }



            // FkiEzsigntemplatepackageID (int) minimum
            if(this.FkiEzsigntemplatepackageID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntemplatepackageID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplatepackageID" });
            }



            // FkiEzsigntemplateID (int) minimum
            if(this.FkiEzsigntemplateID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntemplateID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplateID" });
            }



            // IEzsigntemplatepackagemembershipOrder (int) minimum
            if(this.IEzsigntemplatepackagemembershipOrder < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzsigntemplatepackagemembershipOrder, must be a value greater than or equal to 1.", new [] { "IEzsigntemplatepackagemembershipOrder" });
            }

            yield break;
        }
    }

}
