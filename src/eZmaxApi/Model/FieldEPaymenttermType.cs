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
    /// The type of the Paymentterm
    /// </summary>
    /// <value>The type of the Paymentterm</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEPaymenttermType
    {
        /// <summary>
        /// Enum Days for value: Days
        /// </summary>
        [EnumMember(Value = "Days")]
        Days = 1,

        /// <summary>
        /// Enum Dayofthemonth for value: Dayofthemonth
        /// </summary>
        [EnumMember(Value = "Dayofthemonth")]
        Dayofthemonth = 2

    }

}