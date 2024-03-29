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
    ///  Class for testing ModuleUserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModuleUserApiTests
    {
        private ModuleUserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ModuleUserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModuleUserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ModuleUserApi
            //Assert.IsInstanceOf(typeof(ModuleUserApi), instance);
        }

        
        /// <summary>
        /// Test UserCreateEzsignuserV1
        /// </summary>
        [Test]
        public void UserCreateEzsignuserV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request = null;
            //var response = instance.UserCreateEzsignuserV1(userCreateEzsignuserV1Request);
            //Assert.IsInstanceOf(typeof(UserCreateEzsignuserV1Response), response, "response is UserCreateEzsignuserV1Response");
        }
        
    }

}
