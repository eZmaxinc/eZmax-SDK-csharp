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
    /// ScimServiceProviderConfig
    /// </summary>
    [DataContract(Name = "Scim-ServiceProviderConfig")]
    public partial class ScimServiceProviderConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScimServiceProviderConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfig" /> class.
        /// </summary>
        /// <param name="authenticationSchemes">A multi-valued complex type that specifies supported authentication scheme properties. (required).</param>
        /// <param name="bulk">bulk (required).</param>
        /// <param name="changePassword">changePassword (required).</param>
        /// <param name="documentationUri">An HTTP-addressable URL pointing to the service provider&#39;s human-consumable help documentation (required).</param>
        /// <param name="etag">etag (required).</param>
        /// <param name="filter">filter (required).</param>
        /// <param name="patch">patch (required).</param>
        /// <param name="sort">sort (required).</param>
        public ScimServiceProviderConfig(List<ScimAuthenticationScheme> authenticationSchemes = default(List<ScimAuthenticationScheme>), ScimServiceProviderConfigBulk bulk = default(ScimServiceProviderConfigBulk), ScimServiceProviderConfigChangePassword changePassword = default(ScimServiceProviderConfigChangePassword), string documentationUri = default(string), ScimServiceProviderConfigEtag etag = default(ScimServiceProviderConfigEtag), ScimServiceProviderConfigFilter filter = default(ScimServiceProviderConfigFilter), ScimServiceProviderConfigPatch patch = default(ScimServiceProviderConfigPatch), ScimServiceProviderConfigSort sort = default(ScimServiceProviderConfigSort))
        {
            // to ensure "authenticationSchemes" is required (not null)
            if (authenticationSchemes == null)
            {
                throw new ArgumentNullException("authenticationSchemes is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.AuthenticationSchemes = authenticationSchemes;
            // to ensure "bulk" is required (not null)
            if (bulk == null)
            {
                throw new ArgumentNullException("bulk is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.Bulk = bulk;
            // to ensure "changePassword" is required (not null)
            if (changePassword == null)
            {
                throw new ArgumentNullException("changePassword is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.ChangePassword = changePassword;
            // to ensure "documentationUri" is required (not null)
            if (documentationUri == null)
            {
                throw new ArgumentNullException("documentationUri is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.DocumentationUri = documentationUri;
            // to ensure "etag" is required (not null)
            if (etag == null)
            {
                throw new ArgumentNullException("etag is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.Etag = etag;
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.Filter = filter;
            // to ensure "patch" is required (not null)
            if (patch == null)
            {
                throw new ArgumentNullException("patch is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.Patch = patch;
            // to ensure "sort" is required (not null)
            if (sort == null)
            {
                throw new ArgumentNullException("sort is a required property for ScimServiceProviderConfig and cannot be null");
            }
            this.Sort = sort;
        }

        /// <summary>
        /// A multi-valued complex type that specifies supported authentication scheme properties.
        /// </summary>
        /// <value>A multi-valued complex type that specifies supported authentication scheme properties.</value>
        [DataMember(Name = "authenticationSchemes", IsRequired = true, EmitDefaultValue = true)]
        public List<ScimAuthenticationScheme> AuthenticationSchemes { get; set; }

        /// <summary>
        /// Gets or Sets Bulk
        /// </summary>
        [DataMember(Name = "bulk", IsRequired = true, EmitDefaultValue = true)]
        public ScimServiceProviderConfigBulk Bulk { get; set; }

        /// <summary>
        /// Gets or Sets ChangePassword
        /// </summary>
        [DataMember(Name = "changePassword", IsRequired = true, EmitDefaultValue = true)]
        public ScimServiceProviderConfigChangePassword ChangePassword { get; set; }

        /// <summary>
        /// An HTTP-addressable URL pointing to the service provider&#39;s human-consumable help documentation
        /// </summary>
        /// <value>An HTTP-addressable URL pointing to the service provider&#39;s human-consumable help documentation</value>
        /* <example>https://github.com/eZmaxinc/eZmax-API</example>*/
        [DataMember(Name = "documentationUri", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentationUri { get; set; }

        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name = "etag", IsRequired = true, EmitDefaultValue = true)]
        public ScimServiceProviderConfigEtag Etag { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public ScimServiceProviderConfigFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Patch
        /// </summary>
        [DataMember(Name = "patch", IsRequired = true, EmitDefaultValue = true)]
        public ScimServiceProviderConfigPatch Patch { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", IsRequired = true, EmitDefaultValue = true)]
        public ScimServiceProviderConfigSort Sort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScimServiceProviderConfig {\n");
            sb.Append("  AuthenticationSchemes: ").Append(AuthenticationSchemes).Append("\n");
            sb.Append("  Bulk: ").Append(Bulk).Append("\n");
            sb.Append("  ChangePassword: ").Append(ChangePassword).Append("\n");
            sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Patch: ").Append(Patch).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
