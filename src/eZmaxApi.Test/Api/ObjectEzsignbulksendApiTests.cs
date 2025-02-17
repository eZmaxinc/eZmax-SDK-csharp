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
    ///  Class for testing ObjectEzsignbulksendApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsignbulksendApiTests : IDisposable
    {
        private ObjectEzsignbulksendApi instance;

        public ObjectEzsignbulksendApiTests()
        {
            instance = new ObjectEzsignbulksendApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectEzsignbulksendApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectEzsignbulksendApi
            //Assert.IsType<ObjectEzsignbulksendApi>(instance);
        }

        /// <summary>
        /// Test EzsignbulksendCreateEzsignbulksendtransmissionV2
        /// </summary>
        [Fact]
        public void EzsignbulksendCreateEzsignbulksendtransmissionV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //EzsignbulksendCreateEzsignbulksendtransmissionV2Request ezsignbulksendCreateEzsignbulksendtransmissionV2Request = null;
            //var response = instance.EzsignbulksendCreateEzsignbulksendtransmissionV2(pkiEzsignbulksendID, ezsignbulksendCreateEzsignbulksendtransmissionV2Request);
            //Assert.IsType<EzsignbulksendCreateEzsignbulksendtransmissionV2Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendCreateObjectV1
        /// </summary>
        [Fact]
        public void EzsignbulksendCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EzsignbulksendCreateObjectV1Request ezsignbulksendCreateObjectV1Request = null;
            //var response = instance.EzsignbulksendCreateObjectV1(ezsignbulksendCreateObjectV1Request);
            //Assert.IsType<EzsignbulksendCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendDeleteObjectV1
        /// </summary>
        [Fact]
        public void EzsignbulksendDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //var response = instance.EzsignbulksendDeleteObjectV1(pkiEzsignbulksendID);
            //Assert.IsType<EzsignbulksendDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendEditObjectV1
        /// </summary>
        [Fact]
        public void EzsignbulksendEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //EzsignbulksendEditObjectV1Request ezsignbulksendEditObjectV1Request = null;
            //var response = instance.EzsignbulksendEditObjectV1(pkiEzsignbulksendID, ezsignbulksendEditObjectV1Request);
            //Assert.IsType<EzsignbulksendEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendGetCsvTemplateV1
        /// </summary>
        [Fact]
        public void EzsignbulksendGetCsvTemplateV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //string eCsvSeparator = null;
            //var response = instance.EzsignbulksendGetCsvTemplateV1(pkiEzsignbulksendID, eCsvSeparator);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test EzsignbulksendGetEzsignbulksendtransmissionsV1
        /// </summary>
        [Fact]
        public void EzsignbulksendGetEzsignbulksendtransmissionsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //var response = instance.EzsignbulksendGetEzsignbulksendtransmissionsV1(pkiEzsignbulksendID);
            //Assert.IsType<EzsignbulksendGetEzsignbulksendtransmissionsV1Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendGetEzsignsignaturesAutomaticV1
        /// </summary>
        [Fact]
        public void EzsignbulksendGetEzsignsignaturesAutomaticV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //var response = instance.EzsignbulksendGetEzsignsignaturesAutomaticV1(pkiEzsignbulksendID);
            //Assert.IsType<EzsignbulksendGetEzsignsignaturesAutomaticV1Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendGetFormsDataV1
        /// </summary>
        [Fact]
        public void EzsignbulksendGetFormsDataV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //var response = instance.EzsignbulksendGetFormsDataV1(pkiEzsignbulksendID);
            //Assert.IsType<EzsignbulksendGetFormsDataV1Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendGetListV1
        /// </summary>
        [Fact]
        public void EzsignbulksendGetListV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? eOrderBy = null;
            //int? iRowMax = null;
            //int? iRowOffset = null;
            //HeaderAcceptLanguage? acceptLanguage = null;
            //string? sFilter = null;
            //var response = instance.EzsignbulksendGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
            //Assert.IsType<EzsignbulksendGetListV1Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendGetObjectV2
        /// </summary>
        [Fact]
        public void EzsignbulksendGetObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //var response = instance.EzsignbulksendGetObjectV2(pkiEzsignbulksendID);
            //Assert.IsType<EzsignbulksendGetObjectV2Response>(response);
        }

        /// <summary>
        /// Test EzsignbulksendReorderV1
        /// </summary>
        [Fact]
        public void EzsignbulksendReorderV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignbulksendID = null;
            //EzsignbulksendReorderV1Request ezsignbulksendReorderV1Request = null;
            //var response = instance.EzsignbulksendReorderV1(pkiEzsignbulksendID, ezsignbulksendReorderV1Request);
            //Assert.IsType<EzsignbulksendReorderV1Response>(response);
        }
    }
}
