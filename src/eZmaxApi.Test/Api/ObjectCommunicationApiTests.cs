/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.17
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
using NUnit.Framework;

using eZmaxApi.Client;
using eZmaxApi.Api;
using eZmaxApi.Model;

namespace eZmaxApi.Test
{
    /// <summary>
    ///  Class for testing ObjectCommunicationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectCommunicationApiTests
    {
        private ObjectCommunicationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObjectCommunicationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObjectCommunicationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ObjectCommunicationApi
            //Assert.IsInstanceOf(typeof(ObjectCommunicationApi), instance);
        }

        
        /// <summary>
        /// Test CommunicationGetObjectV2
        /// </summary>
        [Test]
        public void CommunicationGetObjectV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiCommunicationID = null;
            //var response = instance.CommunicationGetObjectV2(pkiCommunicationID);
            //Assert.IsInstanceOf(typeof(CommunicationGetObjectV2Response), response, "response is CommunicationGetObjectV2Response");
        }
        
    }

}