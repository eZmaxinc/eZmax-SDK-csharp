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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using eZmaxApi.Client;
using eZmaxApi.Api;
// uncomment below to import models
//using eZmaxApi.Model;

namespace eZmaxApi.Test.Api
{
    /// <summary>
    ///  Class for testing ScimServiceProviderConfigApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScimServiceProviderConfigApiTests : IDisposable
    {
        private ScimServiceProviderConfigApi instance;

        public ScimServiceProviderConfigApiTests()
        {
            instance = new ScimServiceProviderConfigApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScimServiceProviderConfigApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ScimServiceProviderConfigApi
            //Assert.IsType<ScimServiceProviderConfigApi>(instance);
        }

        /// <summary>
        /// Test ServiceProviderConfigGetObjectScimV2
        /// </summary>
        [Fact]
        public void ServiceProviderConfigGetObjectScimV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ServiceProviderConfigGetObjectScimV2();
            //Assert.IsType<ScimServiceProviderConfig>(response);
        }
    }
}
