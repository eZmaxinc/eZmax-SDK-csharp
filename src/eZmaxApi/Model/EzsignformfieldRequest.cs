/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.7
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
    /// A Ezsignformfield Object
    /// </summary>
    [DataContract]
    public partial class EzsignformfieldRequest :  IEquatable<EzsignformfieldRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignformfieldRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignformfieldRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignformfieldRequest" /> class.
        /// </summary>
        /// <param name="pkiEzsignformfieldID">The unique ID of the Ezsignformfield.</param>
        /// <param name="iEzsignpagePagenumber">The page number in the Ezsigndocument (required).</param>
        /// <param name="sEzsignformfieldLabel">The Label for the Ezsignformfield (required).</param>
        /// <param name="sEzsignformfieldValue">The value for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is Checkbox or Radio.</param>
        /// <param name="iEzsignformfieldX">The X coordinate (Horizontal) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. (required).</param>
        /// <param name="iEzsignformfieldY">The Y coordinate (Vertical) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. (required).</param>
        /// <param name="iEzsignformfieldWidth">The Width of the Ezsignformfield in pixels calculated at 100 DPI  The allowed values are varying based on the eEzsignformfieldgroupType.  | eEzsignformfieldgroupType | Valid values | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | | Checkbox                  | 22           | | Dropdown                  | 22-65535     | | Radio                     | 22           | | Text                      | 22-65535     | | Textarea                  | 22-65535     | (required).</param>
        /// <param name="iEzsignformfieldHeight">The Height of the Ezsignformfield in pixels calculated at 100 DPI  The allowed values are varying based on the eEzsignformfieldgroupType.  | eEzsignformfieldgroupType | Valid values | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | | Checkbox                  | 22           | | Dropdown                  | 22           | | Radio                     | 22           | | Text                      | 22           | | Textarea                  | 22-65535     |  (required).</param>
        /// <param name="bEzsignformfieldSelected">Whether the Ezsignformfield is selected or not by default.  This can only be set if eEzsignformfieldgroupType is **Checkbox** or **Radio**.</param>
        /// <param name="sEzsignformfieldEnteredvalue">This is the value enterred for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is **Dropdown**, **Text** or **Textarea**.</param>
        public EzsignformfieldRequest(int pkiEzsignformfieldID = default(int), int iEzsignpagePagenumber = default(int), string sEzsignformfieldLabel = default(string), string sEzsignformfieldValue = default(string), int iEzsignformfieldX = default(int), int iEzsignformfieldY = default(int), int iEzsignformfieldWidth = default(int), int iEzsignformfieldHeight = default(int), bool bEzsignformfieldSelected = default(bool), string sEzsignformfieldEnteredvalue = default(string))
        {
            // to ensure "iEzsignpagePagenumber" is required (not null)
            if (iEzsignpagePagenumber == null)
            {
                throw new InvalidDataException("iEzsignpagePagenumber is a required property for EzsignformfieldRequest and cannot be null");
            }
            else
            {
                this.IEzsignpagePagenumber = iEzsignpagePagenumber;
            }

            // to ensure "sEzsignformfieldLabel" is required (not null)
            if (sEzsignformfieldLabel == null)
            {
                throw new InvalidDataException("sEzsignformfieldLabel is a required property for EzsignformfieldRequest and cannot be null");
            }
            else
            {
                this.SEzsignformfieldLabel = sEzsignformfieldLabel;
            }

            // to ensure "iEzsignformfieldX" is required (not null)
            if (iEzsignformfieldX == null)
            {
                throw new InvalidDataException("iEzsignformfieldX is a required property for EzsignformfieldRequest and cannot be null");
            }
            else
            {
                this.IEzsignformfieldX = iEzsignformfieldX;
            }

            // to ensure "iEzsignformfieldY" is required (not null)
            if (iEzsignformfieldY == null)
            {
                throw new InvalidDataException("iEzsignformfieldY is a required property for EzsignformfieldRequest and cannot be null");
            }
            else
            {
                this.IEzsignformfieldY = iEzsignformfieldY;
            }

            // to ensure "iEzsignformfieldWidth" is required (not null)
            if (iEzsignformfieldWidth == null)
            {
                throw new InvalidDataException("iEzsignformfieldWidth is a required property for EzsignformfieldRequest and cannot be null");
            }
            else
            {
                this.IEzsignformfieldWidth = iEzsignformfieldWidth;
            }

            // to ensure "iEzsignformfieldHeight" is required (not null)
            if (iEzsignformfieldHeight == null)
            {
                throw new InvalidDataException("iEzsignformfieldHeight is a required property for EzsignformfieldRequest and cannot be null");
            }
            else
            {
                this.IEzsignformfieldHeight = iEzsignformfieldHeight;
            }

            this.PkiEzsignformfieldID = pkiEzsignformfieldID;
            this.SEzsignformfieldValue = sEzsignformfieldValue;
            this.BEzsignformfieldSelected = bEzsignformfieldSelected;
            this.SEzsignformfieldEnteredvalue = sEzsignformfieldEnteredvalue;
        }

        /// <summary>
        /// The unique ID of the Ezsignformfield
        /// </summary>
        /// <value>The unique ID of the Ezsignformfield</value>
        [DataMember(Name="pkiEzsignformfieldID", EmitDefaultValue=false)]
        public int PkiEzsignformfieldID { get; set; }

        /// <summary>
        /// The page number in the Ezsigndocument
        /// </summary>
        /// <value>The page number in the Ezsigndocument</value>
        [DataMember(Name="iEzsignpagePagenumber", EmitDefaultValue=true)]
        public int IEzsignpagePagenumber { get; set; }

        /// <summary>
        /// The Label for the Ezsignformfield
        /// </summary>
        /// <value>The Label for the Ezsignformfield</value>
        [DataMember(Name="sEzsignformfieldLabel", EmitDefaultValue=true)]
        public string SEzsignformfieldLabel { get; set; }

        /// <summary>
        /// The value for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is Checkbox or Radio
        /// </summary>
        /// <value>The value for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is Checkbox or Radio</value>
        [DataMember(Name="sEzsignformfieldValue", EmitDefaultValue=false)]
        public string SEzsignformfieldValue { get; set; }

        /// <summary>
        /// The X coordinate (Horizontal) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.
        /// </summary>
        /// <value>The X coordinate (Horizontal) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.</value>
        [DataMember(Name="iEzsignformfieldX", EmitDefaultValue=true)]
        public int IEzsignformfieldX { get; set; }

        /// <summary>
        /// The Y coordinate (Vertical) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.
        /// </summary>
        /// <value>The Y coordinate (Vertical) where to put the Ezsignformfield on the Ezsignpage.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the Ezsignformfield 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.</value>
        [DataMember(Name="iEzsignformfieldY", EmitDefaultValue=true)]
        public int IEzsignformfieldY { get; set; }

        /// <summary>
        /// The Width of the Ezsignformfield in pixels calculated at 100 DPI  The allowed values are varying based on the eEzsignformfieldgroupType.  | eEzsignformfieldgroupType | Valid values | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | | Checkbox                  | 22           | | Dropdown                  | 22-65535     | | Radio                     | 22           | | Text                      | 22-65535     | | Textarea                  | 22-65535     |
        /// </summary>
        /// <value>The Width of the Ezsignformfield in pixels calculated at 100 DPI  The allowed values are varying based on the eEzsignformfieldgroupType.  | eEzsignformfieldgroupType | Valid values | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | | Checkbox                  | 22           | | Dropdown                  | 22-65535     | | Radio                     | 22           | | Text                      | 22-65535     | | Textarea                  | 22-65535     |</value>
        [DataMember(Name="iEzsignformfieldWidth", EmitDefaultValue=true)]
        public int IEzsignformfieldWidth { get; set; }

        /// <summary>
        /// The Height of the Ezsignformfield in pixels calculated at 100 DPI  The allowed values are varying based on the eEzsignformfieldgroupType.  | eEzsignformfieldgroupType | Valid values | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | | Checkbox                  | 22           | | Dropdown                  | 22           | | Radio                     | 22           | | Text                      | 22           | | Textarea                  | 22-65535     | 
        /// </summary>
        /// <value>The Height of the Ezsignformfield in pixels calculated at 100 DPI  The allowed values are varying based on the eEzsignformfieldgroupType.  | eEzsignformfieldgroupType | Valid values | | - -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- - | | Checkbox                  | 22           | | Dropdown                  | 22           | | Radio                     | 22           | | Text                      | 22           | | Textarea                  | 22-65535     | </value>
        [DataMember(Name="iEzsignformfieldHeight", EmitDefaultValue=true)]
        public int IEzsignformfieldHeight { get; set; }

        /// <summary>
        /// Whether the Ezsignformfield is selected or not by default.  This can only be set if eEzsignformfieldgroupType is **Checkbox** or **Radio**
        /// </summary>
        /// <value>Whether the Ezsignformfield is selected or not by default.  This can only be set if eEzsignformfieldgroupType is **Checkbox** or **Radio**</value>
        [DataMember(Name="bEzsignformfieldSelected", EmitDefaultValue=false)]
        public bool BEzsignformfieldSelected { get; set; }

        /// <summary>
        /// This is the value enterred for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is **Dropdown**, **Text** or **Textarea**
        /// </summary>
        /// <value>This is the value enterred for the Ezsignformfield  This can only be set if eEzsignformfieldgroupType is **Dropdown**, **Text** or **Textarea**</value>
        [DataMember(Name="sEzsignformfieldEnteredvalue", EmitDefaultValue=false)]
        public string SEzsignformfieldEnteredvalue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignformfieldRequest {\n");
            sb.Append("  PkiEzsignformfieldID: ").Append(PkiEzsignformfieldID).Append("\n");
            sb.Append("  IEzsignpagePagenumber: ").Append(IEzsignpagePagenumber).Append("\n");
            sb.Append("  SEzsignformfieldLabel: ").Append(SEzsignformfieldLabel).Append("\n");
            sb.Append("  SEzsignformfieldValue: ").Append(SEzsignformfieldValue).Append("\n");
            sb.Append("  IEzsignformfieldX: ").Append(IEzsignformfieldX).Append("\n");
            sb.Append("  IEzsignformfieldY: ").Append(IEzsignformfieldY).Append("\n");
            sb.Append("  IEzsignformfieldWidth: ").Append(IEzsignformfieldWidth).Append("\n");
            sb.Append("  IEzsignformfieldHeight: ").Append(IEzsignformfieldHeight).Append("\n");
            sb.Append("  BEzsignformfieldSelected: ").Append(BEzsignformfieldSelected).Append("\n");
            sb.Append("  SEzsignformfieldEnteredvalue: ").Append(SEzsignformfieldEnteredvalue).Append("\n");
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
            return this.Equals(input as EzsignformfieldRequest);
        }

        /// <summary>
        /// Returns true if EzsignformfieldRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignformfieldRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignformfieldRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzsignformfieldID == input.PkiEzsignformfieldID ||
                    (this.PkiEzsignformfieldID != null &&
                    this.PkiEzsignformfieldID.Equals(input.PkiEzsignformfieldID))
                ) && 
                (
                    this.IEzsignpagePagenumber == input.IEzsignpagePagenumber ||
                    (this.IEzsignpagePagenumber != null &&
                    this.IEzsignpagePagenumber.Equals(input.IEzsignpagePagenumber))
                ) && 
                (
                    this.SEzsignformfieldLabel == input.SEzsignformfieldLabel ||
                    (this.SEzsignformfieldLabel != null &&
                    this.SEzsignformfieldLabel.Equals(input.SEzsignformfieldLabel))
                ) && 
                (
                    this.SEzsignformfieldValue == input.SEzsignformfieldValue ||
                    (this.SEzsignformfieldValue != null &&
                    this.SEzsignformfieldValue.Equals(input.SEzsignformfieldValue))
                ) && 
                (
                    this.IEzsignformfieldX == input.IEzsignformfieldX ||
                    (this.IEzsignformfieldX != null &&
                    this.IEzsignformfieldX.Equals(input.IEzsignformfieldX))
                ) && 
                (
                    this.IEzsignformfieldY == input.IEzsignformfieldY ||
                    (this.IEzsignformfieldY != null &&
                    this.IEzsignformfieldY.Equals(input.IEzsignformfieldY))
                ) && 
                (
                    this.IEzsignformfieldWidth == input.IEzsignformfieldWidth ||
                    (this.IEzsignformfieldWidth != null &&
                    this.IEzsignformfieldWidth.Equals(input.IEzsignformfieldWidth))
                ) && 
                (
                    this.IEzsignformfieldHeight == input.IEzsignformfieldHeight ||
                    (this.IEzsignformfieldHeight != null &&
                    this.IEzsignformfieldHeight.Equals(input.IEzsignformfieldHeight))
                ) && 
                (
                    this.BEzsignformfieldSelected == input.BEzsignformfieldSelected ||
                    (this.BEzsignformfieldSelected != null &&
                    this.BEzsignformfieldSelected.Equals(input.BEzsignformfieldSelected))
                ) && 
                (
                    this.SEzsignformfieldEnteredvalue == input.SEzsignformfieldEnteredvalue ||
                    (this.SEzsignformfieldEnteredvalue != null &&
                    this.SEzsignformfieldEnteredvalue.Equals(input.SEzsignformfieldEnteredvalue))
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
                if (this.PkiEzsignformfieldID != null)
                    hashCode = hashCode * 59 + this.PkiEzsignformfieldID.GetHashCode();
                if (this.IEzsignpagePagenumber != null)
                    hashCode = hashCode * 59 + this.IEzsignpagePagenumber.GetHashCode();
                if (this.SEzsignformfieldLabel != null)
                    hashCode = hashCode * 59 + this.SEzsignformfieldLabel.GetHashCode();
                if (this.SEzsignformfieldValue != null)
                    hashCode = hashCode * 59 + this.SEzsignformfieldValue.GetHashCode();
                if (this.IEzsignformfieldX != null)
                    hashCode = hashCode * 59 + this.IEzsignformfieldX.GetHashCode();
                if (this.IEzsignformfieldY != null)
                    hashCode = hashCode * 59 + this.IEzsignformfieldY.GetHashCode();
                if (this.IEzsignformfieldWidth != null)
                    hashCode = hashCode * 59 + this.IEzsignformfieldWidth.GetHashCode();
                if (this.IEzsignformfieldHeight != null)
                    hashCode = hashCode * 59 + this.IEzsignformfieldHeight.GetHashCode();
                if (this.BEzsignformfieldSelected != null)
                    hashCode = hashCode * 59 + this.BEzsignformfieldSelected.GetHashCode();
                if (this.SEzsignformfieldEnteredvalue != null)
                    hashCode = hashCode * 59 + this.SEzsignformfieldEnteredvalue.GetHashCode();
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