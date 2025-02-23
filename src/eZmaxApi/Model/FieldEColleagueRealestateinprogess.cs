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
    /// The permission of the cloning user for Realestate
    /// </summary>
    /// <value>The permission of the cloning user for Realestate</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldEColleagueRealestateinprogess
    {
        /// <summary>
        /// Enum No for value: No
        /// </summary>
        [EnumMember(Value = "No")]
        No = 1,

        /// <summary>
        /// Enum Read for value: Read
        /// </summary>
        [EnumMember(Value = "Read")]
        Read = 2,

        /// <summary>
        /// Enum Modify for value: Modify
        /// </summary>
        [EnumMember(Value = "Modify")]
        Modify = 3,

        /// <summary>
        /// Enum Create for value: Create
        /// </summary>
        [EnumMember(Value = "Create")]
        Create = 4
    }

}
