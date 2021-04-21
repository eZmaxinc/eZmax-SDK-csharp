/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.41
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
    /// The signature step of the Ezsignfolder.
    /// </summary>
    /// <value>The signature step of the Ezsignfolder.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEEzsignfolderStep
    {
        /// <summary>
        /// Enum Unsent for value: Unsent
        /// </summary>
        [EnumMember(Value = "Unsent")]
        Unsent = 1,

        /// <summary>
        /// Enum Sent for value: Sent
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent = 2,

        /// <summary>
        /// Enum PartiallySigned for value: PartiallySigned
        /// </summary>
        [EnumMember(Value = "PartiallySigned")]
        PartiallySigned = 3,

        /// <summary>
        /// Enum Expired for value: Expired
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired = 4,

        /// <summary>
        /// Enum Signed for value: Signed
        /// </summary>
        [EnumMember(Value = "Signed")]
        Signed = 5,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 6,

        /// <summary>
        /// Enum Archived for value: Archived
        /// </summary>
        [EnumMember(Value = "Archived")]
        Archived = 7

    }

}