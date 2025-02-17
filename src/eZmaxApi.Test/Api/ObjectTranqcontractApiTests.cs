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
    ///  Class for testing ObjectTranqcontractApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectTranqcontractApiTests : IDisposable
    {
        private ObjectTranqcontractApi instance;

        public ObjectTranqcontractApiTests()
        {
            instance = new ObjectTranqcontractApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ObjectTranqcontractApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ObjectTranqcontractApi
            //Assert.IsType<ObjectTranqcontractApi>(instance);
        }

        /// <summary>
        /// Test TranqcontractGetCommunicationCountV1
        /// </summary>
        [Fact]
        public void TranqcontractGetCommunicationCountV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiTranqcontractID = null;
            //var response = instance.TranqcontractGetCommunicationCountV1(pkiTranqcontractID);
            //Assert.IsType<TranqcontractGetCommunicationCountV1Response>(response);
        }

        /// <summary>
        /// Test TranqcontractGetCommunicationListV1
        /// </summary>
        [Fact]
        public void TranqcontractGetCommunicationListV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiTranqcontractID = null;
            //var response = instance.TranqcontractGetCommunicationListV1(pkiTranqcontractID);
            //Assert.IsType<TranqcontractGetCommunicationListV1Response>(response);
        }

        /// <summary>
        /// Test TranqcontractGetCommunicationrecipientsV1
        /// </summary>
        [Fact]
        public void TranqcontractGetCommunicationrecipientsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiTranqcontractID = null;
            //var response = instance.TranqcontractGetCommunicationrecipientsV1(pkiTranqcontractID);
            //Assert.IsType<TranqcontractGetCommunicationrecipientsV1Response>(response);
        }

        /// <summary>
        /// Test TranqcontractGetCommunicationsendersV1
        /// </summary>
        [Fact]
        public void TranqcontractGetCommunicationsendersV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiTranqcontractID = null;
            //var response = instance.TranqcontractGetCommunicationsendersV1(pkiTranqcontractID);
            //Assert.IsType<TranqcontractGetCommunicationsendersV1Response>(response);
        }
    }
}
