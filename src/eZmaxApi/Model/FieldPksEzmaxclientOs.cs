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
    /// The OS of the system running the application
    /// </summary>
    /// <value>The OS of the system running the application</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldPksEzmaxclientOs
    {
        /// <summary>
        /// Enum IOS for value: iOS
        /// </summary>
        [EnumMember(Value = "iOS")]
        IOS = 1,

        /// <summary>
        /// Enum MacOS for value: macOS
        /// </summary>
        [EnumMember(Value = "macOS")]
        MacOS = 2,

        /// <summary>
        /// Enum Windows for value: Windows
        /// </summary>
        [EnumMember(Value = "Windows")]
        Windows = 3

    }

}
