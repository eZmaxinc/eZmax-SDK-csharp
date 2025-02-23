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
    ///  Class for testing ModuleUserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModuleUserApiTests : IDisposable
    {
        private ModuleUserApi instance;

        public ModuleUserApiTests()
        {
            instance = new ModuleUserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModuleUserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ModuleUserApi
            //Assert.IsType<ModuleUserApi>(instance);
        }

        /// <summary>
        /// Test UserCreateEzsignuserV1
        /// </summary>
        [Fact]
        public void UserCreateEzsignuserV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request = null;
            //var response = instance.UserCreateEzsignuserV1(userCreateEzsignuserV1Request);
            //Assert.IsType<UserCreateEzsignuserV1Response>(response);
        }
    }
}
