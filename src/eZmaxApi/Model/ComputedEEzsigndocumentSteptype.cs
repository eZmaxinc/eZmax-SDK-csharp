/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// Indicates whether the current step is a form or signatures.
    /// </summary>
    /// <value>Indicates whether the current step is a form or signatures.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ComputedEEzsigndocumentSteptype
    {
        /// <summary>
        /// Enum Form for value: Form
        /// </summary>
        [EnumMember(Value = "Form")]
        Form = 1,

        /// <summary>
        /// Enum Sign for value: Sign
        /// </summary>
        [EnumMember(Value = "Sign")]
        Sign = 2,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 3

    }

}