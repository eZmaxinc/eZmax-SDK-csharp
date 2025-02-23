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
    /// A Ezsigntemplatepublic Object
    /// </summary>
    [DataContract(Name = "ezsigntemplatepublic-ResponseCompound")]
    public partial class EzsigntemplatepublicResponseCompound : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EEzsigntemplatepublicLimittype
        /// </summary>
        [DataMember(Name = "eEzsigntemplatepublicLimittype", IsRequired = true, EmitDefaultValue = true)]
        public FieldEEzsigntemplatepublicLimittype EEzsigntemplatepublicLimittype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepublicResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigntemplatepublicResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigntemplatepublicResponseCompound" /> class.
        /// </summary>
        /// <param name="pkiEzsigntemplatepublicID">The unique ID of the Ezsigntemplatepublic (required).</param>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype. (required).</param>
        /// <param name="sEzsignfoldertypeNameX">The name of the Ezsignfoldertype in the language of the requester (required).</param>
        /// <param name="fkiUserlogintypeID">The unique ID of the Userlogintype  Valid values:  |Value|Description|Detail| |-|-|-| |1|**Email Only**|The Ezsignsigner will receive a secure link by email| |2|**Email and phone or SMS**|The Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**| |3|**Email and secret question**|The Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer| |4|**In person only**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type| |5|**In person with phone or SMS**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**| |6|**Embedded**|The Ezsignsigner will only be able to sign in the embedded solution. No email will be sent for invitation to sign. **Additional fee applies**|   |7|**Embedded with phone or SMS**|The Ezsignsigner will only be able to sign in the embedded solution and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**|   |8|**No validation**|The Ezsignsigner will not receive an email and won&#39;t have to validate his connection using 2 factor. **Additional fee applies**|      |9|**Sms only**|The Ezsignsigner will not receive an email but will will need to authenticate using SMS. **Additional fee applies**|      (required).</param>
        /// <param name="sUserlogintypeDescriptionX">The description of the Userlogintype in the language of the requester (required).</param>
        /// <param name="fkiEzsigntemplateID">The unique ID of the Ezsigntemplate.</param>
        /// <param name="fkiEzsigntemplatepackageID">The unique ID of the Ezsigntemplatepackage.</param>
        /// <param name="sEzsigntemplatepublicDescription">The description of the Ezsigntemplatepublic (required).</param>
        /// <param name="sEzsigntemplatepublicReferenceid">The referenceid of the Ezsigntemplatepublic (required).</param>
        /// <param name="bEzsigntemplatepublicIsactive">Whether the ezsigntemplatepublic is active or not (required).</param>
        /// <param name="tEzsigntemplatepublicNote">The note of the Ezsigntemplatepublic (required).</param>
        /// <param name="eEzsigntemplatepublicLimittype">eEzsigntemplatepublicLimittype (required).</param>
        /// <param name="iEzsigntemplatepublicLimit">The limit of the Ezsigntemplatepublic (required).</param>
        /// <param name="iEzsigntemplatepublicLimitexceeded">The limitexceeded of the Ezsigntemplatepublic (required).</param>
        /// <param name="dtEzsigntemplatepublicLimitexceededsince">The limitexceededsince of the Ezsigntemplatepublic (required).</param>
        /// <param name="sEzsigntemplatepublicUrl">The url of the Ezsigntemplatepublic  You can add these value as query parameters to prefill the corresponding role  |Parameter|Description| |-|-| |sEzsigntemplatesignerDescription|The role to fill| |sContactFirstname|The contact firstname| |sContactLastname|The contact lastname| |sEmailAddress|The contact email| |sPhoneE164|The contact phone number| |sPhoneE164Cell|The contact cell phone number| (required).</param>
        /// <param name="sEzsigntemplatepublicEzsigntemplatedescription">The Ezsigntemplate/Ezsigntemplatepackage description (required).</param>
        /// <param name="objAudit">objAudit.</param>
        /// <param name="aObjEzsignfolderezsigntemplatepublic">aObjEzsignfolderezsigntemplatepublic (required).</param>
        public EzsigntemplatepublicResponseCompound(int pkiEzsigntemplatepublicID = default(int), int fkiEzsignfoldertypeID = default(int), string sEzsignfoldertypeNameX = default(string), int fkiUserlogintypeID = default(int), string sUserlogintypeDescriptionX = default(string), int fkiEzsigntemplateID = default(int), int fkiEzsigntemplatepackageID = default(int), string sEzsigntemplatepublicDescription = default(string), string sEzsigntemplatepublicReferenceid = default(string), bool bEzsigntemplatepublicIsactive = default(bool), string tEzsigntemplatepublicNote = default(string), FieldEEzsigntemplatepublicLimittype eEzsigntemplatepublicLimittype = default(FieldEEzsigntemplatepublicLimittype), int iEzsigntemplatepublicLimit = default(int), int iEzsigntemplatepublicLimitexceeded = default(int), string dtEzsigntemplatepublicLimitexceededsince = default(string), string sEzsigntemplatepublicUrl = default(string), string sEzsigntemplatepublicEzsigntemplatedescription = default(string), CommonAudit objAudit = default(CommonAudit), List<CustomEzsignfolderezsigntemplatepublicResponse> aObjEzsignfolderezsigntemplatepublic = default(List<CustomEzsignfolderezsigntemplatepublicResponse>))
        {
            this.PkiEzsigntemplatepublicID = pkiEzsigntemplatepublicID;
            this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            // to ensure "sEzsignfoldertypeNameX" is required (not null)
            if (sEzsignfoldertypeNameX == null)
            {
                throw new ArgumentNullException("sEzsignfoldertypeNameX is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.SEzsignfoldertypeNameX = sEzsignfoldertypeNameX;
            this.FkiUserlogintypeID = fkiUserlogintypeID;
            // to ensure "sUserlogintypeDescriptionX" is required (not null)
            if (sUserlogintypeDescriptionX == null)
            {
                throw new ArgumentNullException("sUserlogintypeDescriptionX is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.SUserlogintypeDescriptionX = sUserlogintypeDescriptionX;
            // to ensure "sEzsigntemplatepublicDescription" is required (not null)
            if (sEzsigntemplatepublicDescription == null)
            {
                throw new ArgumentNullException("sEzsigntemplatepublicDescription is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.SEzsigntemplatepublicDescription = sEzsigntemplatepublicDescription;
            // to ensure "sEzsigntemplatepublicReferenceid" is required (not null)
            if (sEzsigntemplatepublicReferenceid == null)
            {
                throw new ArgumentNullException("sEzsigntemplatepublicReferenceid is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.SEzsigntemplatepublicReferenceid = sEzsigntemplatepublicReferenceid;
            this.BEzsigntemplatepublicIsactive = bEzsigntemplatepublicIsactive;
            // to ensure "tEzsigntemplatepublicNote" is required (not null)
            if (tEzsigntemplatepublicNote == null)
            {
                throw new ArgumentNullException("tEzsigntemplatepublicNote is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.TEzsigntemplatepublicNote = tEzsigntemplatepublicNote;
            this.EEzsigntemplatepublicLimittype = eEzsigntemplatepublicLimittype;
            this.IEzsigntemplatepublicLimit = iEzsigntemplatepublicLimit;
            this.IEzsigntemplatepublicLimitexceeded = iEzsigntemplatepublicLimitexceeded;
            // to ensure "dtEzsigntemplatepublicLimitexceededsince" is required (not null)
            if (dtEzsigntemplatepublicLimitexceededsince == null)
            {
                throw new ArgumentNullException("dtEzsigntemplatepublicLimitexceededsince is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.DtEzsigntemplatepublicLimitexceededsince = dtEzsigntemplatepublicLimitexceededsince;
            // to ensure "sEzsigntemplatepublicUrl" is required (not null)
            if (sEzsigntemplatepublicUrl == null)
            {
                throw new ArgumentNullException("sEzsigntemplatepublicUrl is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.SEzsigntemplatepublicUrl = sEzsigntemplatepublicUrl;
            // to ensure "sEzsigntemplatepublicEzsigntemplatedescription" is required (not null)
            if (sEzsigntemplatepublicEzsigntemplatedescription == null)
            {
                throw new ArgumentNullException("sEzsigntemplatepublicEzsigntemplatedescription is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.SEzsigntemplatepublicEzsigntemplatedescription = sEzsigntemplatepublicEzsigntemplatedescription;
            // to ensure "aObjEzsignfolderezsigntemplatepublic" is required (not null)
            if (aObjEzsignfolderezsigntemplatepublic == null)
            {
                throw new ArgumentNullException("aObjEzsignfolderezsigntemplatepublic is a required property for EzsigntemplatepublicResponseCompound and cannot be null");
            }
            this.AObjEzsignfolderezsigntemplatepublic = aObjEzsignfolderezsigntemplatepublic;
            this.FkiEzsigntemplateID = fkiEzsigntemplateID;
            this.FkiEzsigntemplatepackageID = fkiEzsigntemplatepackageID;
            this.ObjAudit = objAudit;
        }

        /// <summary>
        /// The unique ID of the Ezsigntemplatepublic
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatepublic</value>
        /* <example>96</example>*/
        [DataMember(Name = "pkiEzsigntemplatepublicID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiEzsigntemplatepublicID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.</value>
        /* <example>5</example>*/
        [DataMember(Name = "fkiEzsignfoldertypeID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The name of the Ezsignfoldertype in the language of the requester
        /// </summary>
        /// <value>The name of the Ezsignfoldertype in the language of the requester</value>
        /* <example>Default</example>*/
        [DataMember(Name = "sEzsignfoldertypeNameX", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsignfoldertypeNameX { get; set; }

        /// <summary>
        /// The unique ID of the Userlogintype  Valid values:  |Value|Description|Detail| |-|-|-| |1|**Email Only**|The Ezsignsigner will receive a secure link by email| |2|**Email and phone or SMS**|The Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**| |3|**Email and secret question**|The Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer| |4|**In person only**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type| |5|**In person with phone or SMS**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**| |6|**Embedded**|The Ezsignsigner will only be able to sign in the embedded solution. No email will be sent for invitation to sign. **Additional fee applies**|   |7|**Embedded with phone or SMS**|The Ezsignsigner will only be able to sign in the embedded solution and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**|   |8|**No validation**|The Ezsignsigner will not receive an email and won&#39;t have to validate his connection using 2 factor. **Additional fee applies**|      |9|**Sms only**|The Ezsignsigner will not receive an email but will will need to authenticate using SMS. **Additional fee applies**|     
        /// </summary>
        /// <value>The unique ID of the Userlogintype  Valid values:  |Value|Description|Detail| |-|-|-| |1|**Email Only**|The Ezsignsigner will receive a secure link by email| |2|**Email and phone or SMS**|The Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**| |3|**Email and secret question**|The Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer| |4|**In person only**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type| |5|**In person with phone or SMS**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**| |6|**Embedded**|The Ezsignsigner will only be able to sign in the embedded solution. No email will be sent for invitation to sign. **Additional fee applies**|   |7|**Embedded with phone or SMS**|The Ezsignsigner will only be able to sign in the embedded solution and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**|   |8|**No validation**|The Ezsignsigner will not receive an email and won&#39;t have to validate his connection using 2 factor. **Additional fee applies**|      |9|**Sms only**|The Ezsignsigner will not receive an email but will will need to authenticate using SMS. **Additional fee applies**|     </value>
        /* <example>2</example>*/
        [DataMember(Name = "fkiUserlogintypeID", IsRequired = true, EmitDefaultValue = true)]
        public int FkiUserlogintypeID { get; set; }

        /// <summary>
        /// The description of the Userlogintype in the language of the requester
        /// </summary>
        /// <value>The description of the Userlogintype in the language of the requester</value>
        /* <example>Email and phone or SMS</example>*/
        [DataMember(Name = "sUserlogintypeDescriptionX", IsRequired = true, EmitDefaultValue = true)]
        public string SUserlogintypeDescriptionX { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        /* <example>36</example>*/
        [DataMember(Name = "fkiEzsigntemplateID", EmitDefaultValue = false)]
        public int FkiEzsigntemplateID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplatepackage
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplatepackage</value>
        /* <example>99</example>*/
        [DataMember(Name = "fkiEzsigntemplatepackageID", EmitDefaultValue = false)]
        public int FkiEzsigntemplatepackageID { get; set; }

        /// <summary>
        /// The description of the Ezsigntemplatepublic
        /// </summary>
        /// <value>The description of the Ezsigntemplatepublic</value>
        /* <example>Inscription form</example>*/
        [DataMember(Name = "sEzsigntemplatepublicDescription", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsigntemplatepublicDescription { get; set; }

        /// <summary>
        /// The referenceid of the Ezsigntemplatepublic
        /// </summary>
        /// <value>The referenceid of the Ezsigntemplatepublic</value>
        /* <example>6B29FC40-CA47-1067-B31D-00DD010662DA</example>*/
        [DataMember(Name = "sEzsigntemplatepublicReferenceid", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsigntemplatepublicReferenceid { get; set; }

        /// <summary>
        /// Whether the ezsigntemplatepublic is active or not
        /// </summary>
        /// <value>Whether the ezsigntemplatepublic is active or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bEzsigntemplatepublicIsactive", IsRequired = true, EmitDefaultValue = true)]
        public bool BEzsigntemplatepublicIsactive { get; set; }

        /// <summary>
        /// The note of the Ezsigntemplatepublic
        /// </summary>
        /// <value>The note of the Ezsigntemplatepublic</value>
        /* <example>This is a note</example>*/
        [DataMember(Name = "tEzsigntemplatepublicNote", IsRequired = true, EmitDefaultValue = true)]
        public string TEzsigntemplatepublicNote { get; set; }

        /// <summary>
        /// The limit of the Ezsigntemplatepublic
        /// </summary>
        /// <value>The limit of the Ezsigntemplatepublic</value>
        /* <example>10</example>*/
        [DataMember(Name = "iEzsigntemplatepublicLimit", IsRequired = true, EmitDefaultValue = true)]
        public int IEzsigntemplatepublicLimit { get; set; }

        /// <summary>
        /// The limitexceeded of the Ezsigntemplatepublic
        /// </summary>
        /// <value>The limitexceeded of the Ezsigntemplatepublic</value>
        /* <example>5</example>*/
        [DataMember(Name = "iEzsigntemplatepublicLimitexceeded", IsRequired = true, EmitDefaultValue = true)]
        public int IEzsigntemplatepublicLimitexceeded { get; set; }

        /// <summary>
        /// The limitexceededsince of the Ezsigntemplatepublic
        /// </summary>
        /// <value>The limitexceededsince of the Ezsigntemplatepublic</value>
        /* <example>2024-05-16 15:12:45</example>*/
        [DataMember(Name = "dtEzsigntemplatepublicLimitexceededsince", IsRequired = true, EmitDefaultValue = true)]
        public string DtEzsigntemplatepublicLimitexceededsince { get; set; }

        /// <summary>
        /// The url of the Ezsigntemplatepublic  You can add these value as query parameters to prefill the corresponding role  |Parameter|Description| |-|-| |sEzsigntemplatesignerDescription|The role to fill| |sContactFirstname|The contact firstname| |sContactLastname|The contact lastname| |sEmailAddress|The contact email| |sPhoneE164|The contact phone number| |sPhoneE164Cell|The contact cell phone number|
        /// </summary>
        /// <value>The url of the Ezsigntemplatepublic  You can add these value as query parameters to prefill the corresponding role  |Parameter|Description| |-|-| |sEzsigntemplatesignerDescription|The role to fill| |sContactFirstname|The contact firstname| |sContactLastname|The contact lastname| |sEmailAddress|The contact email| |sPhoneE164|The contact phone number| |sPhoneE164Cell|The contact cell phone number|</value>
        /* <example>https://prod.ezsignsigner.ca-central-1.ezmax.com/ezsigntemplatepublic/{sEzmaxcustomerCode}/{sEzsigntemplatepublicReferenceID}</example>*/
        [DataMember(Name = "sEzsigntemplatepublicUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsigntemplatepublicUrl { get; set; }

        /// <summary>
        /// The Ezsigntemplate/Ezsigntemplatepackage description
        /// </summary>
        /// <value>The Ezsigntemplate/Ezsigntemplatepackage description</value>
        [DataMember(Name = "sEzsigntemplatepublicEzsigntemplatedescription", IsRequired = true, EmitDefaultValue = true)]
        public string SEzsigntemplatepublicEzsigntemplatedescription { get; set; }

        /// <summary>
        /// Gets or Sets ObjAudit
        /// </summary>
        [DataMember(Name = "objAudit", EmitDefaultValue = false)]
        public CommonAudit ObjAudit { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzsignfolderezsigntemplatepublic
        /// </summary>
        [DataMember(Name = "a_objEzsignfolderezsigntemplatepublic", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomEzsignfolderezsigntemplatepublicResponse> AObjEzsignfolderezsigntemplatepublic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EzsigntemplatepublicResponseCompound {\n");
            sb.Append("  PkiEzsigntemplatepublicID: ").Append(PkiEzsigntemplatepublicID).Append("\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  SEzsignfoldertypeNameX: ").Append(SEzsignfoldertypeNameX).Append("\n");
            sb.Append("  FkiUserlogintypeID: ").Append(FkiUserlogintypeID).Append("\n");
            sb.Append("  SUserlogintypeDescriptionX: ").Append(SUserlogintypeDescriptionX).Append("\n");
            sb.Append("  FkiEzsigntemplateID: ").Append(FkiEzsigntemplateID).Append("\n");
            sb.Append("  FkiEzsigntemplatepackageID: ").Append(FkiEzsigntemplatepackageID).Append("\n");
            sb.Append("  SEzsigntemplatepublicDescription: ").Append(SEzsigntemplatepublicDescription).Append("\n");
            sb.Append("  SEzsigntemplatepublicReferenceid: ").Append(SEzsigntemplatepublicReferenceid).Append("\n");
            sb.Append("  BEzsigntemplatepublicIsactive: ").Append(BEzsigntemplatepublicIsactive).Append("\n");
            sb.Append("  TEzsigntemplatepublicNote: ").Append(TEzsigntemplatepublicNote).Append("\n");
            sb.Append("  EEzsigntemplatepublicLimittype: ").Append(EEzsigntemplatepublicLimittype).Append("\n");
            sb.Append("  IEzsigntemplatepublicLimit: ").Append(IEzsigntemplatepublicLimit).Append("\n");
            sb.Append("  IEzsigntemplatepublicLimitexceeded: ").Append(IEzsigntemplatepublicLimitexceeded).Append("\n");
            sb.Append("  DtEzsigntemplatepublicLimitexceededsince: ").Append(DtEzsigntemplatepublicLimitexceededsince).Append("\n");
            sb.Append("  SEzsigntemplatepublicUrl: ").Append(SEzsigntemplatepublicUrl).Append("\n");
            sb.Append("  SEzsigntemplatepublicEzsigntemplatedescription: ").Append(SEzsigntemplatepublicEzsigntemplatedescription).Append("\n");
            sb.Append("  ObjAudit: ").Append(ObjAudit).Append("\n");
            sb.Append("  AObjEzsignfolderezsigntemplatepublic: ").Append(AObjEzsignfolderezsigntemplatepublic).Append("\n");
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
            // PkiEzsigntemplatepublicID (int) maximum
            if (this.PkiEzsigntemplatepublicID > (int)65535)
            {
                yield return new ValidationResult("Invalid value for PkiEzsigntemplatepublicID, must be a value less than or equal to 65535.", new [] { "PkiEzsigntemplatepublicID" });
            }

            // PkiEzsigntemplatepublicID (int) minimum
            if (this.PkiEzsigntemplatepublicID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiEzsigntemplatepublicID, must be a value greater than or equal to 0.", new [] { "PkiEzsigntemplatepublicID" });
            }

            // FkiEzsignfoldertypeID (int) maximum
            if (this.FkiEzsignfoldertypeID > (int)65535)
            {
                yield return new ValidationResult("Invalid value for FkiEzsignfoldertypeID, must be a value less than or equal to 65535.", new [] { "FkiEzsignfoldertypeID" });
            }

            // FkiEzsignfoldertypeID (int) minimum
            if (this.FkiEzsignfoldertypeID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsignfoldertypeID, must be a value greater than or equal to 0.", new [] { "FkiEzsignfoldertypeID" });
            }

            // FkiUserlogintypeID (int) minimum
            if (this.FkiUserlogintypeID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiUserlogintypeID, must be a value greater than or equal to 0.", new [] { "FkiUserlogintypeID" });
            }

            // FkiEzsigntemplateID (int) minimum
            if (this.FkiEzsigntemplateID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsigntemplateID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplateID" });
            }

            // FkiEzsigntemplatepackageID (int) minimum
            if (this.FkiEzsigntemplatepackageID < (int)0)
            {
                yield return new ValidationResult("Invalid value for FkiEzsigntemplatepackageID, must be a value greater than or equal to 0.", new [] { "FkiEzsigntemplatepackageID" });
            }

            if (this.SEzsigntemplatepublicDescription != null) {
                // SEzsigntemplatepublicDescription (string) pattern
                Regex regexSEzsigntemplatepublicDescription = new Regex(@"^.{0,80}$", RegexOptions.CultureInvariant);
                if (!regexSEzsigntemplatepublicDescription.Match(this.SEzsigntemplatepublicDescription).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsigntemplatepublicDescription, must match a pattern of " + regexSEzsigntemplatepublicDescription, new [] { "SEzsigntemplatepublicDescription" });
                }
            }

            if (this.SEzsigntemplatepublicReferenceid != null) {
                // SEzsigntemplatepublicReferenceid (string) pattern
                Regex regexSEzsigntemplatepublicReferenceid = new Regex(@"^.{0,36}$", RegexOptions.CultureInvariant);
                if (!regexSEzsigntemplatepublicReferenceid.Match(this.SEzsigntemplatepublicReferenceid).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsigntemplatepublicReferenceid, must match a pattern of " + regexSEzsigntemplatepublicReferenceid, new [] { "SEzsigntemplatepublicReferenceid" });
                }
            }

            if (this.TEzsigntemplatepublicNote != null) {
                // TEzsigntemplatepublicNote (string) pattern
                Regex regexTEzsigntemplatepublicNote = new Regex(@"^.{0,65535}$", RegexOptions.CultureInvariant);
                if (!regexTEzsigntemplatepublicNote.Match(this.TEzsigntemplatepublicNote).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TEzsigntemplatepublicNote, must match a pattern of " + regexTEzsigntemplatepublicNote, new [] { "TEzsigntemplatepublicNote" });
                }
            }

            // IEzsigntemplatepublicLimit (int) maximum
            if (this.IEzsigntemplatepublicLimit > (int)65535)
            {
                yield return new ValidationResult("Invalid value for IEzsigntemplatepublicLimit, must be a value less than or equal to 65535.", new [] { "IEzsigntemplatepublicLimit" });
            }

            // IEzsigntemplatepublicLimit (int) minimum
            if (this.IEzsigntemplatepublicLimit < (int)0)
            {
                yield return new ValidationResult("Invalid value for IEzsigntemplatepublicLimit, must be a value greater than or equal to 0.", new [] { "IEzsigntemplatepublicLimit" });
            }

            // IEzsigntemplatepublicLimitexceeded (int) maximum
            if (this.IEzsigntemplatepublicLimitexceeded > (int)65535)
            {
                yield return new ValidationResult("Invalid value for IEzsigntemplatepublicLimitexceeded, must be a value less than or equal to 65535.", new [] { "IEzsigntemplatepublicLimitexceeded" });
            }

            // IEzsigntemplatepublicLimitexceeded (int) minimum
            if (this.IEzsigntemplatepublicLimitexceeded < (int)0)
            {
                yield return new ValidationResult("Invalid value for IEzsigntemplatepublicLimitexceeded, must be a value greater than or equal to 0.", new [] { "IEzsigntemplatepublicLimitexceeded" });
            }

            if (this.DtEzsigntemplatepublicLimitexceededsince != null) {
                // DtEzsigntemplatepublicLimitexceededsince (string) pattern
                Regex regexDtEzsigntemplatepublicLimitexceededsince = new Regex(@"^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1]) ([01]?[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])$", RegexOptions.CultureInvariant);
                if (!regexDtEzsigntemplatepublicLimitexceededsince.Match(this.DtEzsigntemplatepublicLimitexceededsince).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DtEzsigntemplatepublicLimitexceededsince, must match a pattern of " + regexDtEzsigntemplatepublicLimitexceededsince, new [] { "DtEzsigntemplatepublicLimitexceededsince" });
                }
            }

            if (this.SEzsigntemplatepublicUrl != null) {
                // SEzsigntemplatepublicUrl (string) pattern
                Regex regexSEzsigntemplatepublicUrl = new Regex(@"^(https|http):\/\/[^\s\/$.?#].[^\s]*$", RegexOptions.CultureInvariant);
                if (!regexSEzsigntemplatepublicUrl.Match(this.SEzsigntemplatepublicUrl).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsigntemplatepublicUrl, must match a pattern of " + regexSEzsigntemplatepublicUrl, new [] { "SEzsigntemplatepublicUrl" });
                }
            }

            if (this.SEzsigntemplatepublicEzsigntemplatedescription != null) {
                // SEzsigntemplatepublicEzsigntemplatedescription (string) pattern
                Regex regexSEzsigntemplatepublicEzsigntemplatedescription = new Regex(@"^.{1,80}$", RegexOptions.CultureInvariant);
                if (!regexSEzsigntemplatepublicEzsigntemplatedescription.Match(this.SEzsigntemplatepublicEzsigntemplatedescription).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsigntemplatepublicEzsigntemplatedescription, must match a pattern of " + regexSEzsigntemplatepublicEzsigntemplatedescription, new [] { "SEzsigntemplatepublicEzsigntemplatedescription" });
                }
            }

            yield break;
        }
    }

}
