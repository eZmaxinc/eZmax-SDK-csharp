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
    /// The type of the Authenticationexternal
    /// </summary>
    /// <value>The type of the Authenticationexternal</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldEAuthenticationexternalType
    {
        /// <summary>
        /// Enum Salesforce for value: Salesforce
        /// </summary>
        [EnumMember(Value = "Salesforce")]
        Salesforce = 1,

        /// <summary>
        /// Enum SalesforceSandbox for value: SalesforceSandbox
        /// </summary>
        [EnumMember(Value = "SalesforceSandbox")]
        SalesforceSandbox = 2
    }

}
