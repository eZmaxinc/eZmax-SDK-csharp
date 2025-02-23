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
    ///  Class for testing ObjectAttachmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectAttachmentApiTests : IDisposable
    {
        private ObjectAttachmentApi instance;

        public ObjectAttachmentApiTests()
        {
            instance = new ObjectAttachmentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectAttachmentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectAttachmentApi
            //Assert.IsType<ObjectAttachmentApi>(instance);
        }

        /// <summary>
        /// Test AttachmentDownloadV1
        /// </summary>
        [Fact]
        public void AttachmentDownloadV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiAttachmentID = null;
            //instance.AttachmentDownloadV1(pkiAttachmentID);
        }

        /// <summary>
        /// Test AttachmentGetAttachmentlogsV1
        /// </summary>
        [Fact]
        public void AttachmentGetAttachmentlogsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiAttachmentID = null;
            //var response = instance.AttachmentGetAttachmentlogsV1(pkiAttachmentID);
            //Assert.IsType<AttachmentGetAttachmentlogsV1Response>(response);
        }
    }
}
