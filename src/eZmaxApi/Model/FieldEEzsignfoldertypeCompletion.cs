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
    /// Indicates if the Ezsigndocument is completed when all signatures of this Ezsigndocument were applied or when all signatures of all Ezsigndocument  were applied
    /// </summary>
    /// <value>Indicates if the Ezsigndocument is completed when all signatures of this Ezsigndocument were applied or when all signatures of all Ezsigndocument  were applied</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldEEzsignfoldertypeCompletion
    {
        /// <summary>
        /// Enum PerEzsigndocument for value: PerEzsigndocument
        /// </summary>
        [EnumMember(Value = "PerEzsigndocument")]
        PerEzsigndocument = 1,

        /// <summary>
        /// Enum PerEzsignfolder for value: PerEzsignfolder
        /// </summary>
        [EnumMember(Value = "PerEzsignfolder")]
        PerEzsignfolder = 2
    }

}
