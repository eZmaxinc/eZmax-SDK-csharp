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
    ///  Class for testing ObjectUsergroupdelegationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectUsergroupdelegationApiTests : IDisposable
    {
        private ObjectUsergroupdelegationApi instance;

        public ObjectUsergroupdelegationApiTests()
        {
            instance = new ObjectUsergroupdelegationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectUsergroupdelegationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectUsergroupdelegationApi
            //Assert.IsType<ObjectUsergroupdelegationApi>(instance);
        }

        /// <summary>
        /// Test UsergroupdelegationCreateObjectV1
        /// </summary>
        [Fact]
        public void UsergroupdelegationCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UsergroupdelegationCreateObjectV1Request usergroupdelegationCreateObjectV1Request = null;
            //var response = instance.UsergroupdelegationCreateObjectV1(usergroupdelegationCreateObjectV1Request);
            //Assert.IsType<UsergroupdelegationCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupdelegationDeleteObjectV1
        /// </summary>
        [Fact]
        public void UsergroupdelegationDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupdelegationID = null;
            //var response = instance.UsergroupdelegationDeleteObjectV1(pkiUsergroupdelegationID);
            //Assert.IsType<UsergroupdelegationDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupdelegationEditObjectV1
        /// </summary>
        [Fact]
        public void UsergroupdelegationEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupdelegationID = null;
            //UsergroupdelegationEditObjectV1Request usergroupdelegationEditObjectV1Request = null;
            //var response = instance.UsergroupdelegationEditObjectV1(pkiUsergroupdelegationID, usergroupdelegationEditObjectV1Request);
            //Assert.IsType<UsergroupdelegationEditObjectV1Response>(response);
        }

        /// <summary>
        /// Test UsergroupdelegationGetObjectV2
        /// </summary>
        [Fact]
        public void UsergroupdelegationGetObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiUsergroupdelegationID = null;
            //var response = instance.UsergroupdelegationGetObjectV2(pkiUsergroupdelegationID);
            //Assert.IsType<UsergroupdelegationGetObjectV2Response>(response);
        }
    }
}
