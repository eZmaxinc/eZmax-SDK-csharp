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
    ///  Class for testing ScimUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScimUsersApiTests
    {
        private ScimUsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScimUsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScimUsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ScimUsersApi
            //Assert.IsInstanceOf(typeof(ScimUsersApi), instance);
        }

        
        /// <summary>
        /// Test UsersCreateObjectScimV2
        /// </summary>
        [Test]
        public void UsersCreateObjectScimV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ScimUser scimUser = null;
            //var response = instance.UsersCreateObjectScimV2(scimUser);
            //Assert.IsInstanceOf(typeof(ScimUser), response, "response is ScimUser");
        }
        
        /// <summary>
        /// Test UsersDeleteObjectScimV2
        /// </summary>
        [Test]
        public void UsersDeleteObjectScimV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //instance.UsersDeleteObjectScimV2(userId);
            
        }
        
        /// <summary>
        /// Test UsersEditObjectScimV2
        /// </summary>
        [Test]
        public void UsersEditObjectScimV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //ScimUser scimUser = null;
            //var response = instance.UsersEditObjectScimV2(userId, scimUser);
            //Assert.IsInstanceOf(typeof(ScimUser), response, "response is ScimUser");
        }
        
        /// <summary>
        /// Test UsersGetListScimV2
        /// </summary>
        [Test]
        public void UsersGetListScimV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.UsersGetListScimV2(filter);
            //Assert.IsInstanceOf(typeof(ScimUserList), response, "response is ScimUserList");
        }
        
        /// <summary>
        /// Test UsersGetObjectScimV2
        /// </summary>
        [Test]
        public void UsersGetObjectScimV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.UsersGetObjectScimV2(userId);
            //Assert.IsInstanceOf(typeof(ScimUser), response, "response is ScimUser");
        }
        
    }

}