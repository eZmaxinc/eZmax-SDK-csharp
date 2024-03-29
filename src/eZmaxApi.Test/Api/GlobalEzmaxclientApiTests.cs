/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.18
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
    ///  Class for testing GlobalEzmaxclientApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GlobalEzmaxclientApiTests
    {
        private GlobalEzmaxclientApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GlobalEzmaxclientApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GlobalEzmaxclientApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GlobalEzmaxclientApi
            //Assert.IsInstanceOf(typeof(GlobalEzmaxclientApi), instance);
        }

        
        /// <summary>
        /// Test GlobalEzmaxclientVersionV1
        /// </summary>
        [Test]
        public void GlobalEzmaxclientVersionV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FieldPksEzmaxclientOs pksEzmaxclientOs = null;
            //var response = instance.GlobalEzmaxclientVersionV1(pksEzmaxclientOs);
            //Assert.IsInstanceOf(typeof(GlobalEzmaxclientVersionV1Response), response, "response is GlobalEzmaxclientVersionV1Response");
        }
        
    }

}
