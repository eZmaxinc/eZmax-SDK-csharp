/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.17
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
    /// The type for the Communicationrecipient
    /// </summary>
    /// <value>The type for the Communicationrecipient</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldECommunicationrecipientType
    {
        /// <summary>
        /// Enum To for value: To
        /// </summary>
        [EnumMember(Value = "To")]
        To = 1,

        /// <summary>
        /// Enum Cc for value: Cc
        /// </summary>
        [EnumMember(Value = "Cc")]
        Cc = 2,

        /// <summary>
        /// Enum Bcc for value: Bcc
        /// </summary>
        [EnumMember(Value = "Bcc")]
        Bcc = 3

    }

}