/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
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
    /// Variation type for eZmax
    /// </summary>
    /// <value>Variation type for eZmax</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEEzmaxinvoicingagentVariationezmax
    {
        /// <summary>
        /// Enum Charge for value: Charge
        /// </summary>
        [EnumMember(Value = "Charge")]
        Charge = 1,

        /// <summary>
        /// Enum Refund for value: Refund
        /// </summary>
        [EnumMember(Value = "Refund")]
        Refund = 2,

        /// <summary>
        /// Enum Same for value: Same
        /// </summary>
        [EnumMember(Value = "Same")]
        Same = 3

    }

}