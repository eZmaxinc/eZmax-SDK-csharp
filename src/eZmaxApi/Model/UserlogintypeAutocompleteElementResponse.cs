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
    /// A Userlogintype AutocompleteElement Response
    /// </summary>
    [DataContract(Name = "userlogintype-AutocompleteElement-Response")]
    public partial class UserlogintypeAutocompleteElementResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserlogintypeAutocompleteElementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserlogintypeAutocompleteElementResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserlogintypeAutocompleteElementResponse" /> class.
        /// </summary>
        /// <param name="pkiUserlogintypeID">The unique ID of the Userlogintype  Valid values:  |Value|Description|Detail| |-|-|-| |1|**Email Only**|The Ezsignsigner will receive a secure link by email| |2|**Email and phone or SMS**|The Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**| |3|**Email and secret question**|The Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer| |4|**In person only**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type| |5|**In person with phone or SMS**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**| |6|**Embedded**|The Ezsignsigner will only be able to sign in the embedded solution. No email will be sent for invitation to sign. **Additional fee applies**|   |7|**Embedded with phone or SMS**|The Ezsignsigner will only be able to sign in the embedded solution and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**|   |8|**No validation**|The Ezsignsigner will not receive an email and won&#39;t have to validate his connection using 2 factor. **Additional fee applies**|      |9|**Sms only**|The Ezsignsigner will not receive an email but will will need to authenticate using SMS. **Additional fee applies**|      (required).</param>
        /// <param name="sUserlogintypeDescriptionX">The description of the Userlogintype in the language of the requester (required).</param>
        /// <param name="bUserlogintypeIsactive">Whether the Userlogintype is active or not (required).</param>
        public UserlogintypeAutocompleteElementResponse(int pkiUserlogintypeID = default(int), string sUserlogintypeDescriptionX = default(string), bool bUserlogintypeIsactive = default(bool))
        {
            this.PkiUserlogintypeID = pkiUserlogintypeID;
            // to ensure "sUserlogintypeDescriptionX" is required (not null)
            if (sUserlogintypeDescriptionX == null)
            {
                throw new ArgumentNullException("sUserlogintypeDescriptionX is a required property for UserlogintypeAutocompleteElementResponse and cannot be null");
            }
            this.SUserlogintypeDescriptionX = sUserlogintypeDescriptionX;
            this.BUserlogintypeIsactive = bUserlogintypeIsactive;
        }

        /// <summary>
        /// The unique ID of the Userlogintype  Valid values:  |Value|Description|Detail| |-|-|-| |1|**Email Only**|The Ezsignsigner will receive a secure link by email| |2|**Email and phone or SMS**|The Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**| |3|**Email and secret question**|The Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer| |4|**In person only**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type| |5|**In person with phone or SMS**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**| |6|**Embedded**|The Ezsignsigner will only be able to sign in the embedded solution. No email will be sent for invitation to sign. **Additional fee applies**|   |7|**Embedded with phone or SMS**|The Ezsignsigner will only be able to sign in the embedded solution and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**|   |8|**No validation**|The Ezsignsigner will not receive an email and won&#39;t have to validate his connection using 2 factor. **Additional fee applies**|      |9|**Sms only**|The Ezsignsigner will not receive an email but will will need to authenticate using SMS. **Additional fee applies**|     
        /// </summary>
        /// <value>The unique ID of the Userlogintype  Valid values:  |Value|Description|Detail| |-|-|-| |1|**Email Only**|The Ezsignsigner will receive a secure link by email| |2|**Email and phone or SMS**|The Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**| |3|**Email and secret question**|The Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer| |4|**In person only**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type| |5|**In person with phone or SMS**|The Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**| |6|**Embedded**|The Ezsignsigner will only be able to sign in the embedded solution. No email will be sent for invitation to sign. **Additional fee applies**|   |7|**Embedded with phone or SMS**|The Ezsignsigner will only be able to sign in the embedded solution and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**|   |8|**No validation**|The Ezsignsigner will not receive an email and won&#39;t have to validate his connection using 2 factor. **Additional fee applies**|      |9|**Sms only**|The Ezsignsigner will not receive an email but will will need to authenticate using SMS. **Additional fee applies**|     </value>
        /* <example>2</example>*/
        [DataMember(Name = "pkiUserlogintypeID", IsRequired = true, EmitDefaultValue = true)]
        public int PkiUserlogintypeID { get; set; }

        /// <summary>
        /// The description of the Userlogintype in the language of the requester
        /// </summary>
        /// <value>The description of the Userlogintype in the language of the requester</value>
        /* <example>Email and phone or SMS</example>*/
        [DataMember(Name = "sUserlogintypeDescriptionX", IsRequired = true, EmitDefaultValue = true)]
        public string SUserlogintypeDescriptionX { get; set; }

        /// <summary>
        /// Whether the Userlogintype is active or not
        /// </summary>
        /// <value>Whether the Userlogintype is active or not</value>
        /* <example>true</example>*/
        [DataMember(Name = "bUserlogintypeIsactive", IsRequired = true, EmitDefaultValue = true)]
        public bool BUserlogintypeIsactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserlogintypeAutocompleteElementResponse {\n");
            sb.Append("  PkiUserlogintypeID: ").Append(PkiUserlogintypeID).Append("\n");
            sb.Append("  SUserlogintypeDescriptionX: ").Append(SUserlogintypeDescriptionX).Append("\n");
            sb.Append("  BUserlogintypeIsactive: ").Append(BUserlogintypeIsactive).Append("\n");
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
            // PkiUserlogintypeID (int) minimum
            if (this.PkiUserlogintypeID < (int)0)
            {
                yield return new ValidationResult("Invalid value for PkiUserlogintypeID, must be a value greater than or equal to 0.", new [] { "PkiUserlogintypeID" });
            }

            yield break;
        }
    }

}
