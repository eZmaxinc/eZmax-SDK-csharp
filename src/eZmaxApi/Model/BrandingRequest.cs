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
    /// A Branding Object
    /// </summary>
    [DataContract]
    public partial class BrandingRequest :  IEquatable<BrandingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BrandingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandingRequest" /> class.
        /// </summary>
        /// <param name="pkiBrandingID">The unique ID of the Branding.</param>
        /// <param name="objBrandingDescription">objBrandingDescription (required).</param>
        /// <param name="eBrandingLogo">eBrandingLogo (required).</param>
        /// <param name="sBrandingBase64">The Base64 encoded binary content of the branding logo. This need to match image type selected in eBrandingLogo if you supply an image. If you select &#39;Default&#39;, the logo will be deleted and the default one will be used..</param>
        /// <param name="iBrandingColortext">The color of the text. This is a RGB color converted into integer (required).</param>
        /// <param name="iBrandingColortextlinkbox">The color of the text in the link box. This is a RGB color converted into integer (required).</param>
        /// <param name="iBrandingColortextbutton">The color of the text in the button. This is a RGB color converted into integer (required).</param>
        /// <param name="iBrandingColorbackground">The color of the background. This is a RGB color converted into integer (required).</param>
        /// <param name="iBrandingColorbackgroundbutton">The color of the background of the button. This is a RGB color converted into integer (required).</param>
        /// <param name="iBrandingColorbackgroundsmallbox">The color of the background of the small box. This is a RGB color converted into integer (required).</param>
        /// <param name="bBrandingIsactive">Whether the Branding is active or not (required).</param>
        public BrandingRequest(int pkiBrandingID = default(int), MultilingualBrandingDescription objBrandingDescription = default(MultilingualBrandingDescription), FieldEBrandingLogo eBrandingLogo = default(FieldEBrandingLogo), byte[] sBrandingBase64 = default(byte[]), int iBrandingColortext = default(int), int iBrandingColortextlinkbox = default(int), int iBrandingColortextbutton = default(int), int iBrandingColorbackground = default(int), int iBrandingColorbackgroundbutton = default(int), int iBrandingColorbackgroundsmallbox = default(int), bool bBrandingIsactive = default(bool))
        {
            // to ensure "objBrandingDescription" is required (not null)
            if (objBrandingDescription == null)
            {
                throw new InvalidDataException("objBrandingDescription is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.ObjBrandingDescription = objBrandingDescription;
            }

            // to ensure "eBrandingLogo" is required (not null)
            if (eBrandingLogo == null)
            {
                throw new InvalidDataException("eBrandingLogo is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.EBrandingLogo = eBrandingLogo;
            }

            // to ensure "iBrandingColortext" is required (not null)
            if (iBrandingColortext == null)
            {
                throw new InvalidDataException("iBrandingColortext is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.IBrandingColortext = iBrandingColortext;
            }

            // to ensure "iBrandingColortextlinkbox" is required (not null)
            if (iBrandingColortextlinkbox == null)
            {
                throw new InvalidDataException("iBrandingColortextlinkbox is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.IBrandingColortextlinkbox = iBrandingColortextlinkbox;
            }

            // to ensure "iBrandingColortextbutton" is required (not null)
            if (iBrandingColortextbutton == null)
            {
                throw new InvalidDataException("iBrandingColortextbutton is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.IBrandingColortextbutton = iBrandingColortextbutton;
            }

            // to ensure "iBrandingColorbackground" is required (not null)
            if (iBrandingColorbackground == null)
            {
                throw new InvalidDataException("iBrandingColorbackground is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.IBrandingColorbackground = iBrandingColorbackground;
            }

            // to ensure "iBrandingColorbackgroundbutton" is required (not null)
            if (iBrandingColorbackgroundbutton == null)
            {
                throw new InvalidDataException("iBrandingColorbackgroundbutton is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.IBrandingColorbackgroundbutton = iBrandingColorbackgroundbutton;
            }

            // to ensure "iBrandingColorbackgroundsmallbox" is required (not null)
            if (iBrandingColorbackgroundsmallbox == null)
            {
                throw new InvalidDataException("iBrandingColorbackgroundsmallbox is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.IBrandingColorbackgroundsmallbox = iBrandingColorbackgroundsmallbox;
            }

            // to ensure "bBrandingIsactive" is required (not null)
            if (bBrandingIsactive == null)
            {
                throw new InvalidDataException("bBrandingIsactive is a required property for BrandingRequest and cannot be null");
            }
            else
            {
                this.BBrandingIsactive = bBrandingIsactive;
            }

            this.PkiBrandingID = pkiBrandingID;
            this.SBrandingBase64 = sBrandingBase64;
        }

        /// <summary>
        /// The unique ID of the Branding
        /// </summary>
        /// <value>The unique ID of the Branding</value>
        [DataMember(Name="pkiBrandingID", EmitDefaultValue=false)]
        public int PkiBrandingID { get; set; }

        /// <summary>
        /// Gets or Sets ObjBrandingDescription
        /// </summary>
        [DataMember(Name="objBrandingDescription", EmitDefaultValue=true)]
        public MultilingualBrandingDescription ObjBrandingDescription { get; set; }

        /// <summary>
        /// Gets or Sets EBrandingLogo
        /// </summary>
        [DataMember(Name="eBrandingLogo", EmitDefaultValue=true)]
        public FieldEBrandingLogo EBrandingLogo { get; set; }

        /// <summary>
        /// The Base64 encoded binary content of the branding logo. This need to match image type selected in eBrandingLogo if you supply an image. If you select &#39;Default&#39;, the logo will be deleted and the default one will be used.
        /// </summary>
        /// <value>The Base64 encoded binary content of the branding logo. This need to match image type selected in eBrandingLogo if you supply an image. If you select &#39;Default&#39;, the logo will be deleted and the default one will be used.</value>
        [DataMember(Name="sBrandingBase64", EmitDefaultValue=false)]
        public byte[] SBrandingBase64 { get; set; }

        /// <summary>
        /// The color of the text. This is a RGB color converted into integer
        /// </summary>
        /// <value>The color of the text. This is a RGB color converted into integer</value>
        [DataMember(Name="iBrandingColortext", EmitDefaultValue=true)]
        public int IBrandingColortext { get; set; }

        /// <summary>
        /// The color of the text in the link box. This is a RGB color converted into integer
        /// </summary>
        /// <value>The color of the text in the link box. This is a RGB color converted into integer</value>
        [DataMember(Name="iBrandingColortextlinkbox", EmitDefaultValue=true)]
        public int IBrandingColortextlinkbox { get; set; }

        /// <summary>
        /// The color of the text in the button. This is a RGB color converted into integer
        /// </summary>
        /// <value>The color of the text in the button. This is a RGB color converted into integer</value>
        [DataMember(Name="iBrandingColortextbutton", EmitDefaultValue=true)]
        public int IBrandingColortextbutton { get; set; }

        /// <summary>
        /// The color of the background. This is a RGB color converted into integer
        /// </summary>
        /// <value>The color of the background. This is a RGB color converted into integer</value>
        [DataMember(Name="iBrandingColorbackground", EmitDefaultValue=true)]
        public int IBrandingColorbackground { get; set; }

        /// <summary>
        /// The color of the background of the button. This is a RGB color converted into integer
        /// </summary>
        /// <value>The color of the background of the button. This is a RGB color converted into integer</value>
        [DataMember(Name="iBrandingColorbackgroundbutton", EmitDefaultValue=true)]
        public int IBrandingColorbackgroundbutton { get; set; }

        /// <summary>
        /// The color of the background of the small box. This is a RGB color converted into integer
        /// </summary>
        /// <value>The color of the background of the small box. This is a RGB color converted into integer</value>
        [DataMember(Name="iBrandingColorbackgroundsmallbox", EmitDefaultValue=true)]
        public int IBrandingColorbackgroundsmallbox { get; set; }

        /// <summary>
        /// Whether the Branding is active or not
        /// </summary>
        /// <value>Whether the Branding is active or not</value>
        [DataMember(Name="bBrandingIsactive", EmitDefaultValue=true)]
        public bool BBrandingIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandingRequest {\n");
            sb.Append("  PkiBrandingID: ").Append(PkiBrandingID).Append("\n");
            sb.Append("  ObjBrandingDescription: ").Append(ObjBrandingDescription).Append("\n");
            sb.Append("  EBrandingLogo: ").Append(EBrandingLogo).Append("\n");
            sb.Append("  SBrandingBase64: ").Append(SBrandingBase64).Append("\n");
            sb.Append("  IBrandingColortext: ").Append(IBrandingColortext).Append("\n");
            sb.Append("  IBrandingColortextlinkbox: ").Append(IBrandingColortextlinkbox).Append("\n");
            sb.Append("  IBrandingColortextbutton: ").Append(IBrandingColortextbutton).Append("\n");
            sb.Append("  IBrandingColorbackground: ").Append(IBrandingColorbackground).Append("\n");
            sb.Append("  IBrandingColorbackgroundbutton: ").Append(IBrandingColorbackgroundbutton).Append("\n");
            sb.Append("  IBrandingColorbackgroundsmallbox: ").Append(IBrandingColorbackgroundsmallbox).Append("\n");
            sb.Append("  BBrandingIsactive: ").Append(BBrandingIsactive).Append("\n");
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
            return this.Equals(input as BrandingRequest);
        }

        /// <summary>
        /// Returns true if BrandingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiBrandingID == input.PkiBrandingID ||
                    (this.PkiBrandingID != null &&
                    this.PkiBrandingID.Equals(input.PkiBrandingID))
                ) && 
                (
                    this.ObjBrandingDescription == input.ObjBrandingDescription ||
                    (this.ObjBrandingDescription != null &&
                    this.ObjBrandingDescription.Equals(input.ObjBrandingDescription))
                ) && 
                (
                    this.EBrandingLogo == input.EBrandingLogo ||
                    (this.EBrandingLogo != null &&
                    this.EBrandingLogo.Equals(input.EBrandingLogo))
                ) && 
                (
                    this.SBrandingBase64 == input.SBrandingBase64 ||
                    (this.SBrandingBase64 != null &&
                    this.SBrandingBase64.Equals(input.SBrandingBase64))
                ) && 
                (
                    this.IBrandingColortext == input.IBrandingColortext ||
                    (this.IBrandingColortext != null &&
                    this.IBrandingColortext.Equals(input.IBrandingColortext))
                ) && 
                (
                    this.IBrandingColortextlinkbox == input.IBrandingColortextlinkbox ||
                    (this.IBrandingColortextlinkbox != null &&
                    this.IBrandingColortextlinkbox.Equals(input.IBrandingColortextlinkbox))
                ) && 
                (
                    this.IBrandingColortextbutton == input.IBrandingColortextbutton ||
                    (this.IBrandingColortextbutton != null &&
                    this.IBrandingColortextbutton.Equals(input.IBrandingColortextbutton))
                ) && 
                (
                    this.IBrandingColorbackground == input.IBrandingColorbackground ||
                    (this.IBrandingColorbackground != null &&
                    this.IBrandingColorbackground.Equals(input.IBrandingColorbackground))
                ) && 
                (
                    this.IBrandingColorbackgroundbutton == input.IBrandingColorbackgroundbutton ||
                    (this.IBrandingColorbackgroundbutton != null &&
                    this.IBrandingColorbackgroundbutton.Equals(input.IBrandingColorbackgroundbutton))
                ) && 
                (
                    this.IBrandingColorbackgroundsmallbox == input.IBrandingColorbackgroundsmallbox ||
                    (this.IBrandingColorbackgroundsmallbox != null &&
                    this.IBrandingColorbackgroundsmallbox.Equals(input.IBrandingColorbackgroundsmallbox))
                ) && 
                (
                    this.BBrandingIsactive == input.BBrandingIsactive ||
                    (this.BBrandingIsactive != null &&
                    this.BBrandingIsactive.Equals(input.BBrandingIsactive))
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
                if (this.PkiBrandingID != null)
                    hashCode = hashCode * 59 + this.PkiBrandingID.GetHashCode();
                if (this.ObjBrandingDescription != null)
                    hashCode = hashCode * 59 + this.ObjBrandingDescription.GetHashCode();
                if (this.EBrandingLogo != null)
                    hashCode = hashCode * 59 + this.EBrandingLogo.GetHashCode();
                if (this.SBrandingBase64 != null)
                    hashCode = hashCode * 59 + this.SBrandingBase64.GetHashCode();
                if (this.IBrandingColortext != null)
                    hashCode = hashCode * 59 + this.IBrandingColortext.GetHashCode();
                if (this.IBrandingColortextlinkbox != null)
                    hashCode = hashCode * 59 + this.IBrandingColortextlinkbox.GetHashCode();
                if (this.IBrandingColortextbutton != null)
                    hashCode = hashCode * 59 + this.IBrandingColortextbutton.GetHashCode();
                if (this.IBrandingColorbackground != null)
                    hashCode = hashCode * 59 + this.IBrandingColorbackground.GetHashCode();
                if (this.IBrandingColorbackgroundbutton != null)
                    hashCode = hashCode * 59 + this.IBrandingColorbackgroundbutton.GetHashCode();
                if (this.IBrandingColorbackgroundsmallbox != null)
                    hashCode = hashCode * 59 + this.IBrandingColorbackgroundsmallbox.GetHashCode();
                if (this.BBrandingIsactive != null)
                    hashCode = hashCode * 59 + this.BBrandingIsactive.GetHashCode();
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


            // PkiBrandingID (int) minimum
            if(this.PkiBrandingID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiBrandingID, must be a value greater than or equal to 0.", new [] { "PkiBrandingID" });
            }



            // IBrandingColortext (int) maximum
            if(this.IBrandingColortext > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColortext, must be a value less than or equal to 16777215.", new [] { "IBrandingColortext" });
            }

            // IBrandingColortext (int) minimum
            if(this.IBrandingColortext < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColortext, must be a value greater than or equal to 0.", new [] { "IBrandingColortext" });
            }



            // IBrandingColortextlinkbox (int) maximum
            if(this.IBrandingColortextlinkbox > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColortextlinkbox, must be a value less than or equal to 16777215.", new [] { "IBrandingColortextlinkbox" });
            }

            // IBrandingColortextlinkbox (int) minimum
            if(this.IBrandingColortextlinkbox < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColortextlinkbox, must be a value greater than or equal to 0.", new [] { "IBrandingColortextlinkbox" });
            }



            // IBrandingColortextbutton (int) maximum
            if(this.IBrandingColortextbutton > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColortextbutton, must be a value less than or equal to 16777215.", new [] { "IBrandingColortextbutton" });
            }

            // IBrandingColortextbutton (int) minimum
            if(this.IBrandingColortextbutton < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColortextbutton, must be a value greater than or equal to 0.", new [] { "IBrandingColortextbutton" });
            }



            // IBrandingColorbackground (int) maximum
            if(this.IBrandingColorbackground > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColorbackground, must be a value less than or equal to 16777215.", new [] { "IBrandingColorbackground" });
            }

            // IBrandingColorbackground (int) minimum
            if(this.IBrandingColorbackground < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColorbackground, must be a value greater than or equal to 0.", new [] { "IBrandingColorbackground" });
            }



            // IBrandingColorbackgroundbutton (int) maximum
            if(this.IBrandingColorbackgroundbutton > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColorbackgroundbutton, must be a value less than or equal to 16777215.", new [] { "IBrandingColorbackgroundbutton" });
            }

            // IBrandingColorbackgroundbutton (int) minimum
            if(this.IBrandingColorbackgroundbutton < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColorbackgroundbutton, must be a value greater than or equal to 0.", new [] { "IBrandingColorbackgroundbutton" });
            }



            // IBrandingColorbackgroundsmallbox (int) maximum
            if(this.IBrandingColorbackgroundsmallbox > (int)16777215)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColorbackgroundsmallbox, must be a value less than or equal to 16777215.", new [] { "IBrandingColorbackgroundsmallbox" });
            }

            // IBrandingColorbackgroundsmallbox (int) minimum
            if(this.IBrandingColorbackgroundsmallbox < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IBrandingColorbackgroundsmallbox, must be a value greater than or equal to 0.", new [] { "IBrandingColorbackgroundsmallbox" });
            }

            yield break;
        }
    }

}