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
    ///  Class for testing ObjectClonehistoryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectClonehistoryApiTests : IDisposable
    {
        private ObjectClonehistoryApi instance;

        public ObjectClonehistoryApiTests()
        {
            instance = new ObjectClonehistoryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectClonehistoryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectClonehistoryApi
            //Assert.IsType<ObjectClonehistoryApi>(instance);
        }

        /// <summary>
        /// Test ClonehistoryGetListV1
        /// </summary>
        [Fact]
        public void ClonehistoryGetListV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? eOrderBy = null;
            //int? iRowMax = null;
            //int? iRowOffset = null;
            //HeaderAcceptLanguage? acceptLanguage = null;
            //string? sFilter = null;
            //var response = instance.ClonehistoryGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
            //Assert.IsType<ClonehistoryGetListV1Response>(response);
        }
    }
}
