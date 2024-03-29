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
    /// The action we do when a new external user connects itself
    /// </summary>
    /// <value>The action we do when a new external user connects itself</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldESystemconfigurationNewexternaluseraction
    {
        /// <summary>
        /// Enum Stage for value: Stage
        /// </summary>
        [EnumMember(Value = "Stage")]
        Stage = 1,

        /// <summary>
        /// Enum AutoCreate for value: AutoCreate
        /// </summary>
        [EnumMember(Value = "AutoCreate")]
        AutoCreate = 2

    }

}
