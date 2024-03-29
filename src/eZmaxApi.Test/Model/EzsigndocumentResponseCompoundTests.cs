/*
 * eZmax API Definition (Full)
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.1.18
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using eZmaxApi.Api;
using eZmaxApi.Model;
using eZmaxApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace eZmaxApi.Test
{
    /// <summary>
    ///  Class for testing EzsigndocumentResponseCompound
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EzsigndocumentResponseCompoundTests
    {
        // TODO uncomment below to declare an instance variable for EzsigndocumentResponseCompound
        //private EzsigndocumentResponseCompound instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EzsigndocumentResponseCompound
            //instance = new EzsigndocumentResponseCompound();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EzsigndocumentResponseCompound
        /// </summary>
        [Test]
        public void EzsigndocumentResponseCompoundInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" EzsigndocumentResponseCompound
            //Assert.IsInstanceOf(typeof(EzsigndocumentResponseCompound), instance);
        }


        /// <summary>
        /// Test the property 'PkiEzsigndocumentID'
        /// </summary>
        [Test]
        public void PkiEzsigndocumentIDTest()
        {
            // TODO unit test for the property 'PkiEzsigndocumentID'
        }
        /// <summary>
        /// Test the property 'FkiEzsignfolderID'
        /// </summary>
        [Test]
        public void FkiEzsignfolderIDTest()
        {
            // TODO unit test for the property 'FkiEzsignfolderID'
        }
        /// <summary>
        /// Test the property 'FkiEzsignfoldersignerassociationIDDeclinedtosign'
        /// </summary>
        [Test]
        public void FkiEzsignfoldersignerassociationIDDeclinedtosignTest()
        {
            // TODO unit test for the property 'FkiEzsignfoldersignerassociationIDDeclinedtosign'
        }
        /// <summary>
        /// Test the property 'DtEzsigndocumentDuedate'
        /// </summary>
        [Test]
        public void DtEzsigndocumentDuedateTest()
        {
            // TODO unit test for the property 'DtEzsigndocumentDuedate'
        }
        /// <summary>
        /// Test the property 'DtEzsignformCompleted'
        /// </summary>
        [Test]
        public void DtEzsignformCompletedTest()
        {
            // TODO unit test for the property 'DtEzsignformCompleted'
        }
        /// <summary>
        /// Test the property 'FkiLanguageID'
        /// </summary>
        [Test]
        public void FkiLanguageIDTest()
        {
            // TODO unit test for the property 'FkiLanguageID'
        }
        /// <summary>
        /// Test the property 'SEzsigndocumentName'
        /// </summary>
        [Test]
        public void SEzsigndocumentNameTest()
        {
            // TODO unit test for the property 'SEzsigndocumentName'
        }
        /// <summary>
        /// Test the property 'EEzsigndocumentStep'
        /// </summary>
        [Test]
        public void EEzsigndocumentStepTest()
        {
            // TODO unit test for the property 'EEzsigndocumentStep'
        }
        /// <summary>
        /// Test the property 'DtEzsigndocumentFirstsend'
        /// </summary>
        [Test]
        public void DtEzsigndocumentFirstsendTest()
        {
            // TODO unit test for the property 'DtEzsigndocumentFirstsend'
        }
        /// <summary>
        /// Test the property 'DtEzsigndocumentLastsend'
        /// </summary>
        [Test]
        public void DtEzsigndocumentLastsendTest()
        {
            // TODO unit test for the property 'DtEzsigndocumentLastsend'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentOrder'
        /// </summary>
        [Test]
        public void IEzsigndocumentOrderTest()
        {
            // TODO unit test for the property 'IEzsigndocumentOrder'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentPagetotal'
        /// </summary>
        [Test]
        public void IEzsigndocumentPagetotalTest()
        {
            // TODO unit test for the property 'IEzsigndocumentPagetotal'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentSignaturesigned'
        /// </summary>
        [Test]
        public void IEzsigndocumentSignaturesignedTest()
        {
            // TODO unit test for the property 'IEzsigndocumentSignaturesigned'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentSignaturetotal'
        /// </summary>
        [Test]
        public void IEzsigndocumentSignaturetotalTest()
        {
            // TODO unit test for the property 'IEzsigndocumentSignaturetotal'
        }
        /// <summary>
        /// Test the property 'SEzsigndocumentMD5initial'
        /// </summary>
        [Test]
        public void SEzsigndocumentMD5initialTest()
        {
            // TODO unit test for the property 'SEzsigndocumentMD5initial'
        }
        /// <summary>
        /// Test the property 'TEzsigndocumentDeclinedtosignreason'
        /// </summary>
        [Test]
        public void TEzsigndocumentDeclinedtosignreasonTest()
        {
            // TODO unit test for the property 'TEzsigndocumentDeclinedtosignreason'
        }
        /// <summary>
        /// Test the property 'SEzsigndocumentMD5signed'
        /// </summary>
        [Test]
        public void SEzsigndocumentMD5signedTest()
        {
            // TODO unit test for the property 'SEzsigndocumentMD5signed'
        }
        /// <summary>
        /// Test the property 'BEzsigndocumentEzsignform'
        /// </summary>
        [Test]
        public void BEzsigndocumentEzsignformTest()
        {
            // TODO unit test for the property 'BEzsigndocumentEzsignform'
        }
        /// <summary>
        /// Test the property 'BEzsigndocumentHassignedsignatures'
        /// </summary>
        [Test]
        public void BEzsigndocumentHassignedsignaturesTest()
        {
            // TODO unit test for the property 'BEzsigndocumentHassignedsignatures'
        }
        /// <summary>
        /// Test the property 'ObjAudit'
        /// </summary>
        [Test]
        public void ObjAuditTest()
        {
            // TODO unit test for the property 'ObjAudit'
        }
        /// <summary>
        /// Test the property 'SEzsigndocumentExternalid'
        /// </summary>
        [Test]
        public void SEzsigndocumentExternalidTest()
        {
            // TODO unit test for the property 'SEzsigndocumentExternalid'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentStepformtotal'
        /// </summary>
        [Test]
        public void IEzsigndocumentStepformtotalTest()
        {
            // TODO unit test for the property 'IEzsigndocumentStepformtotal'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentStepformcurrent'
        /// </summary>
        [Test]
        public void IEzsigndocumentStepformcurrentTest()
        {
            // TODO unit test for the property 'IEzsigndocumentStepformcurrent'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentStepsignaturetotal'
        /// </summary>
        [Test]
        public void IEzsigndocumentStepsignaturetotalTest()
        {
            // TODO unit test for the property 'IEzsigndocumentStepsignaturetotal'
        }
        /// <summary>
        /// Test the property 'IEzsigndocumentStepsignatureCurrent'
        /// </summary>
        [Test]
        public void IEzsigndocumentStepsignatureCurrentTest()
        {
            // TODO unit test for the property 'IEzsigndocumentStepsignatureCurrent'
        }
        /// <summary>
        /// Test the property 'AObjEzsignfoldersignerassociationstatus'
        /// </summary>
        [Test]
        public void AObjEzsignfoldersignerassociationstatusTest()
        {
            // TODO unit test for the property 'AObjEzsignfoldersignerassociationstatus'
        }

    }

}
