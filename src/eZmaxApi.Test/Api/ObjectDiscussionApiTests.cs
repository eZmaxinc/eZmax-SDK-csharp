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
    ///  Class for testing ObjectDiscussionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectDiscussionApiTests : IDisposable
    {
        private ObjectDiscussionApi instance;

        public ObjectDiscussionApiTests()
        {
            instance = new ObjectDiscussionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectDiscussionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectDiscussionApi
            //Assert.IsType<ObjectDiscussionApi>(instance);
        }

        /// <summary>
        /// Test DiscussionCreateObjectV1
        /// </summary>
        [Fact]
        public void DiscussionCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DiscussionCreateObjectV1Request discussionCreateObjectV1Request = null;
            //var response = instance.DiscussionCreateObjectV1(discussionCreateObjectV1Request);
            //Assert.IsType<DiscussionCreateObjectV1Response>(response);
        }

        /// <summary>
        /// Test DiscussionDeleteObjectV1
        /// </summary>
        [Fact]
        public void DiscussionDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiDiscussionID = null;
            //var response = instance.DiscussionDeleteObjectV1(pkiDiscussionID);
            //Assert.IsType<DiscussionDeleteObjectV1Response>(response);
        }

        /// <summary>
        /// Test DiscussionGetObjectV2
        /// </summary>
        [Fact]
        public void DiscussionGetObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiDiscussionID = null;
            //var response = instance.DiscussionGetObjectV2(pkiDiscussionID);
            //Assert.IsType<DiscussionGetObjectV2Response>(response);
        }

        /// <summary>
        /// Test DiscussionPatchObjectV1
        /// </summary>
        [Fact]
        public void DiscussionPatchObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiDiscussionID = null;
            //DiscussionPatchObjectV1Request discussionPatchObjectV1Request = null;
            //var response = instance.DiscussionPatchObjectV1(pkiDiscussionID, discussionPatchObjectV1Request);
            //Assert.IsType<DiscussionPatchObjectV1Response>(response);
        }

        /// <summary>
        /// Test DiscussionUpdateDiscussionreadstatusV1
        /// </summary>
        [Fact]
        public void DiscussionUpdateDiscussionreadstatusV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiDiscussionID = null;
            //DiscussionUpdateDiscussionreadstatusV1Request discussionUpdateDiscussionreadstatusV1Request = null;
            //var response = instance.DiscussionUpdateDiscussionreadstatusV1(pkiDiscussionID, discussionUpdateDiscussionreadstatusV1Request);
            //Assert.IsType<DiscussionUpdateDiscussionreadstatusV1Response>(response);
        }
    }
}