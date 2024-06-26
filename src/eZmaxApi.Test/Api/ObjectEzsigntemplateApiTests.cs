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
    ///  Class for testing ObjectEzsigntemplateApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsigntemplateApiTests : IDisposable
    {
        private ObjectEzsigntemplateApi instance;

        public ObjectEzsigntemplateApiTests()
        {
            instance = new ObjectEzsigntemplateApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectEzsigntemplateApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectEzsigntemplateApi
            //Assert.IsType<ObjectEzsigntemplateApi>(instance);
        }

        /// <summary>
        /// Test EzsigntemplateCopyV1
        /// </summary>
        [Fact]
        public void EzsigntemplateCopyV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigntemplateID = null;
            //EzsigntemplateCopyV1Request ezsigntemplateCopyV1Request = null;
            //var response = instance.EzsigntemplateCopyV1(pkiEzsigntemplateID, ezsigntemplateCopyV1Request);
            //Assert.IsType<EzsigntemplateCopyV1Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateCreateObjectV1
        /// </summary>
        [Fact]
        public void EzsigntemplateCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EzsigntemplateCreateObjectV1Request ezsigntemplateCreateObjectV1Request = null;
            //var response = instance.EzsigntemplateCreateObjectV1(ezsigntemplateCreateObjectV1Request);
            //Assert.IsType<EzsigntemplateCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateCreateObjectV2
        /// </summary>
        [Fact]
        public void EzsigntemplateCreateObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EzsigntemplateCreateObjectV2Request ezsigntemplateCreateObjectV2Request = null;
            //var response = instance.EzsigntemplateCreateObjectV2(ezsigntemplateCreateObjectV2Request);
            //Assert.IsType<EzsigntemplateCreateObjectV2Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateDeleteObjectV1
        /// </summary>
        [Fact]
        public void EzsigntemplateDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigntemplateID = null;
            //var response = instance.EzsigntemplateDeleteObjectV1(pkiEzsigntemplateID);
            //Assert.IsType<EzsigntemplateDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateEditObjectV1
        /// </summary>
        [Fact]
        public void EzsigntemplateEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigntemplateID = null;
            //EzsigntemplateEditObjectV1Request ezsigntemplateEditObjectV1Request = null;
            //var response = instance.EzsigntemplateEditObjectV1(pkiEzsigntemplateID, ezsigntemplateEditObjectV1Request);
            //Assert.IsType<EzsigntemplateEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateEditObjectV2
        /// </summary>
        [Fact]
        public void EzsigntemplateEditObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigntemplateID = null;
            //EzsigntemplateEditObjectV2Request ezsigntemplateEditObjectV2Request = null;
            //var response = instance.EzsigntemplateEditObjectV2(pkiEzsigntemplateID, ezsigntemplateEditObjectV2Request);
            //Assert.IsType<EzsigntemplateEditObjectV2Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateGetAutocompleteV2
        /// </summary>
        [Fact]
        public void EzsigntemplateGetAutocompleteV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sSelector = null;
            //string? eFilterActive = null;
            //string? sQuery = null;
            //HeaderAcceptLanguage? acceptLanguage = null;
            //var response = instance.EzsigntemplateGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
            //Assert.IsType<EzsigntemplateGetAutocompleteV2Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateGetListV1
        /// </summary>
        [Fact]
        public void EzsigntemplateGetListV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? eOrderBy = null;
            //int? iRowMax = null;
            //int? iRowOffset = null;
            //HeaderAcceptLanguage? acceptLanguage = null;
            //string? sFilter = null;
            //var response = instance.EzsigntemplateGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
            //Assert.IsType<EzsigntemplateGetListV1Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateGetObjectV1
        /// </summary>
        [Fact]
        public void EzsigntemplateGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigntemplateID = null;
            //var response = instance.EzsigntemplateGetObjectV1(pkiEzsigntemplateID);
            //Assert.IsType<EzsigntemplateGetObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsigntemplateGetObjectV2
        /// </summary>
        [Fact]
        public void EzsigntemplateGetObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigntemplateID = null;
            //var response = instance.EzsigntemplateGetObjectV2(pkiEzsigntemplateID);
            //Assert.IsType<EzsigntemplateGetObjectV2Response>(response);
        }
    }
}
