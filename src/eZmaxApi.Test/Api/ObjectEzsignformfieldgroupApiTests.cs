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
    ///  Class for testing ObjectEzsignformfieldgroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsignformfieldgroupApiTests : IDisposable
    {
        private ObjectEzsignformfieldgroupApi instance;

        public ObjectEzsignformfieldgroupApiTests()
        {
            instance = new ObjectEzsignformfieldgroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectEzsignformfieldgroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectEzsignformfieldgroupApi
            //Assert.IsType<ObjectEzsignformfieldgroupApi>(instance);
        }

        /// <summary>
        /// Test EzsignformfieldgroupCreateObjectV1
        /// </summary>
        [Fact]
        public void EzsignformfieldgroupCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EzsignformfieldgroupCreateObjectV1Request ezsignformfieldgroupCreateObjectV1Request = null;
            //var response = instance.EzsignformfieldgroupCreateObjectV1(ezsignformfieldgroupCreateObjectV1Request);
            //Assert.IsType<EzsignformfieldgroupCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignformfieldgroupDeleteObjectV1
        /// </summary>
        [Fact]
        public void EzsignformfieldgroupDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignformfieldgroupID = null;
            //var response = instance.EzsignformfieldgroupDeleteObjectV1(pkiEzsignformfieldgroupID);
            //Assert.IsType<EzsignformfieldgroupDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignformfieldgroupEditObjectV1
        /// </summary>
        [Fact]
        public void EzsignformfieldgroupEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignformfieldgroupID = null;
            //EzsignformfieldgroupEditObjectV1Request ezsignformfieldgroupEditObjectV1Request = null;
            //var response = instance.EzsignformfieldgroupEditObjectV1(pkiEzsignformfieldgroupID, ezsignformfieldgroupEditObjectV1Request);
            //Assert.IsType<EzsignformfieldgroupEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignformfieldgroupGetObjectV2
        /// </summary>
        [Fact]
        public void EzsignformfieldgroupGetObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignformfieldgroupID = null;
            //var response = instance.EzsignformfieldgroupGetObjectV2(pkiEzsignformfieldgroupID);
            //Assert.IsType<EzsignformfieldgroupGetObjectV2Response>(response);
        }
    }
}
