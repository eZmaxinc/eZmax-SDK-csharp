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
    /// Indicates whether we use the name or the content to recognize the templates to be automatically applied to documents
    /// </summary>
    /// <value>Indicates whether we use the name or the content to recognize the templates to be automatically applied to documents</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldEEzsigntemplateRecognition
    {
        /// <summary>
        /// Enum No for value: No
        /// </summary>
        [EnumMember(Value = "No")]
        No = 1,

        /// <summary>
        /// Enum Filename for value: Filename
        /// </summary>
        [EnumMember(Value = "Filename")]
        Filename = 2,

        /// <summary>
        /// Enum Content for value: Content
        /// </summary>
        [EnumMember(Value = "Content")]
        Content = 3
    }

}
