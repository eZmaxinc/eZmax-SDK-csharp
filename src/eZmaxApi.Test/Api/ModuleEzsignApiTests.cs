/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.15
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
    ///  Class for testing ModuleEzsignApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModuleEzsignApiTests
    {
        private ModuleEzsignApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ModuleEzsignApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModuleEzsignApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ModuleEzsignApi
            //Assert.IsInstanceOf(typeof(ModuleEzsignApi), instance);
        }

        
        /// <summary>
        /// Test EzsignSuggestSignersV1
        /// </summary>
        [Test]
        public void EzsignSuggestSignersV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.EzsignSuggestSignersV1();
            //Assert.IsInstanceOf(typeof(EzsignSuggestSignersV1Response), response, "response is EzsignSuggestSignersV1Response");
        }
        
        /// <summary>
        /// Test EzsignSuggestTemplatesV1
        /// </summary>
        [Test]
        public void EzsignSuggestTemplatesV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fkiEzsignfoldertypeID = null;
            //var response = instance.EzsignSuggestTemplatesV1(fkiEzsignfoldertypeID);
            //Assert.IsInstanceOf(typeof(EzsignSuggestTemplatesV1Response), response, "response is EzsignSuggestTemplatesV1Response");
        }
        
    }

}