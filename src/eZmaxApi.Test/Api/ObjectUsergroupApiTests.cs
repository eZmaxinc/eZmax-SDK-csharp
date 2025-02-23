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
    ///  Class for testing ObjectUsergroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectUsergroupApiTests : IDisposable
    {
        private ObjectUsergroupApi instance;

        public ObjectUsergroupApiTests()
        {
            instance = new ObjectUsergroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectUsergroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectUsergroupApi
            //Assert.IsType<ObjectUsergroupApi>(instance);
        }

        /// <summary>
        /// Test UsergroupCreateObjectV1
        /// </summary>
        [Fact]
        public void UsergroupCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UsergroupCreateObjectV1Request usergroupCreateObjectV1Request = null;
            //var response = instance.UsergroupCreateObjectV1(usergroupCreateObjectV1Request);
            //Assert.IsType<UsergroupCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupEditObjectV1
        /// </summary>
        [Fact]
        public void UsergroupEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //UsergroupEditObjectV1Request usergroupEditObjectV1Request = null;
            //var response = instance.UsergroupEditObjectV1(pkiUsergroupID, usergroupEditObjectV1Request);
            //Assert.IsType<UsergroupEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupEditPermissionsV1
        /// </summary>
        [Fact]
        public void UsergroupEditPermissionsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //UsergroupEditPermissionsV1Request usergroupEditPermissionsV1Request = null;
            //var response = instance.UsergroupEditPermissionsV1(pkiUsergroupID, usergroupEditPermissionsV1Request);
            //Assert.IsType<UsergroupEditPermissionsV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupEditUsergroupdelegationsV1
        /// </summary>
        [Fact]
        public void UsergroupEditUsergroupdelegationsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //UsergroupEditUsergroupdelegationsV1Request usergroupEditUsergroupdelegationsV1Request = null;
            //var response = instance.UsergroupEditUsergroupdelegationsV1(pkiUsergroupID, usergroupEditUsergroupdelegationsV1Request);
            //Assert.IsType<UsergroupEditUsergroupdelegationsV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupEditUsergroupmembershipsV1
        /// </summary>
        [Fact]
        public void UsergroupEditUsergroupmembershipsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //UsergroupEditUsergroupmembershipsV1Request usergroupEditUsergroupmembershipsV1Request = null;
            //var response = instance.UsergroupEditUsergroupmembershipsV1(pkiUsergroupID, usergroupEditUsergroupmembershipsV1Request);
            //Assert.IsType<UsergroupEditUsergroupmembershipsV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupGetAutocompleteV2
        /// </summary>
        [Fact]
        public void UsergroupGetAutocompleteV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sSelector = null;
            //string? eFilterActive = null;
            //string? sQuery = null;
            //HeaderAcceptLanguage? acceptLanguage = null;
            //var response = instance.UsergroupGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
            //Assert.IsType<UsergroupGetAutocompleteV2Response>(response);
        }

        /// <summary>
        /// Test UsergroupGetListV1
        /// </summary>
        [Fact]
        public void UsergroupGetListV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? eOrderBy = null;
            //int? iRowMax = null;
            //int? iRowOffset = null;
            //HeaderAcceptLanguage? acceptLanguage = null;
            //string? sFilter = null;
            //var response = instance.UsergroupGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
            //Assert.IsType<UsergroupGetListV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupGetObjectV2
        /// </summary>
        [Fact]
        public void UsergroupGetObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //var response = instance.UsergroupGetObjectV2(pkiUsergroupID);
            //Assert.IsType<UsergroupGetObjectV2Response>(response);
        }

        /// <summary>
        /// Test UsergroupGetPermissionsV1
        /// </summary>
        [Fact]
        public void UsergroupGetPermissionsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //var response = instance.UsergroupGetPermissionsV1(pkiUsergroupID);
            //Assert.IsType<UsergroupGetPermissionsV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupGetUsergroupdelegationsV1
        /// </summary>
        [Fact]
        public void UsergroupGetUsergroupdelegationsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //var response = instance.UsergroupGetUsergroupdelegationsV1(pkiUsergroupID);
            //Assert.IsType<UsergroupGetUsergroupdelegationsV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupGetUsergroupmembershipsV1
        /// </summary>
        [Fact]
        public void UsergroupGetUsergroupmembershipsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupID = null;
            //var response = instance.UsergroupGetUsergroupmembershipsV1(pkiUsergroupID);
            //Assert.IsType<UsergroupGetUsergroupmembershipsV1Response>(response);
        }
    }
}
