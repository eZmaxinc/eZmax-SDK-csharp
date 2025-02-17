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
    ///  Class for testing ObjectActivesessionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectActivesessionApiTests : IDisposable
    {
        private ObjectActivesessionApi instance;

        public ObjectActivesessionApiTests()
        {
            instance = new ObjectActivesessionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectActivesessionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectActivesessionApi
            //Assert.IsType<ObjectActivesessionApi>(instance);
        }

        /// <summary>
        /// Test ActivesessionGenerateFederationTokenV1
        /// </summary>
        [Fact]
        public void ActivesessionGenerateFederationTokenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ActivesessionGenerateFederationTokenV1Request activesessionGenerateFederationTokenV1Request = null;
            //var response = instance.ActivesessionGenerateFederationTokenV1(activesessionGenerateFederationTokenV1Request);
            //Assert.IsType<ActivesessionGenerateFederationTokenV1Response>(response);
        }

        /// <summary>
        /// Test ActivesessionGetCurrentV1
        /// </summary>
        [Fact]
        public void ActivesessionGetCurrentV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ActivesessionGetCurrentV1();
            //Assert.IsType<ActivesessionGetCurrentV1Response>(response);
        }

        /// <summary>
        /// Test ActivesessionGetCurrentV2
        /// </summary>
        [Fact]
        public void ActivesessionGetCurrentV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ActivesessionGetCurrentV2();
            //Assert.IsType<ActivesessionGetCurrentV2Response>(response);
        }

        /// <summary>
        /// Test ActivesessionGetListV1
        /// </summary>
        [Fact]
        public void ActivesessionGetListV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? eOrderBy = null;
            //int? iRowMax = null;
            //int? iRowOffset = null;
            //HeaderAcceptLanguage? acceptLanguage = null;
            //string? sFilter = null;
            //var response = instance.ActivesessionGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
            //Assert.IsType<ActivesessionGetListV1Response>(response);
        }
    }
}
