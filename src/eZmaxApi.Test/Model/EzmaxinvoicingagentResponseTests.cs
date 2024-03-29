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
    ///  Class for testing EzmaxinvoicingagentResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EzmaxinvoicingagentResponseTests
    {
        // TODO uncomment below to declare an instance variable for EzmaxinvoicingagentResponse
        //private EzmaxinvoicingagentResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EzmaxinvoicingagentResponse
            //instance = new EzmaxinvoicingagentResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EzmaxinvoicingagentResponse
        /// </summary>
        [Test]
        public void EzmaxinvoicingagentResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" EzmaxinvoicingagentResponse
            //Assert.IsInstanceOf(typeof(EzmaxinvoicingagentResponse), instance);
        }


        /// <summary>
        /// Test the property 'PkiEzmaxinvoicingagentID'
        /// </summary>
        [Test]
        public void PkiEzmaxinvoicingagentIDTest()
        {
            // TODO unit test for the property 'PkiEzmaxinvoicingagentID'
        }
        /// <summary>
        /// Test the property 'FkiEzmaxinvoicingID'
        /// </summary>
        [Test]
        public void FkiEzmaxinvoicingIDTest()
        {
            // TODO unit test for the property 'FkiEzmaxinvoicingID'
        }
        /// <summary>
        /// Test the property 'FkiBillingentityinternalID'
        /// </summary>
        [Test]
        public void FkiBillingentityinternalIDTest()
        {
            // TODO unit test for the property 'FkiBillingentityinternalID'
        }
        /// <summary>
        /// Test the property 'SBillingentityinternalDescriptionX'
        /// </summary>
        [Test]
        public void SBillingentityinternalDescriptionXTest()
        {
            // TODO unit test for the property 'SBillingentityinternalDescriptionX'
        }
        /// <summary>
        /// Test the property 'FkiAgentID'
        /// </summary>
        [Test]
        public void FkiAgentIDTest()
        {
            // TODO unit test for the property 'FkiAgentID'
        }
        /// <summary>
        /// Test the property 'FkiBrokerID'
        /// </summary>
        [Test]
        public void FkiBrokerIDTest()
        {
            // TODO unit test for the property 'FkiBrokerID'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentSession'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentSessionTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentSession'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentCloned'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentClonedTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentCloned'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentInvoice'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentInvoiceTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentInvoice'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentInscription'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentInscriptionTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentInscription'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentInscriptionactive'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentInscriptionactiveTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentInscriptionactive'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentSale'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentSaleTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentSale'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentOtherincome'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentOtherincomeTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentOtherincome'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentCommissioncalculation'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentCommissioncalculationTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentCommissioncalculation'
        }
        /// <summary>
        /// Test the property 'IEzmaxinvoicingagentEzsigndocument'
        /// </summary>
        [Test]
        public void IEzmaxinvoicingagentEzsigndocumentTest()
        {
            // TODO unit test for the property 'IEzmaxinvoicingagentEzsigndocument'
        }
        /// <summary>
        /// Test the property 'BEzmaxinvoicingagentEzsignaccount'
        /// </summary>
        [Test]
        public void BEzmaxinvoicingagentEzsignaccountTest()
        {
            // TODO unit test for the property 'BEzmaxinvoicingagentEzsignaccount'
        }
        /// <summary>
        /// Test the property 'BEzmaxinvoicingagentBillableezmax'
        /// </summary>
        [Test]
        public void BEzmaxinvoicingagentBillableezmaxTest()
        {
            // TODO unit test for the property 'BEzmaxinvoicingagentBillableezmax'
        }
        /// <summary>
        /// Test the property 'EEzmaxinvoicingagentVariationezmax'
        /// </summary>
        [Test]
        public void EEzmaxinvoicingagentVariationezmaxTest()
        {
            // TODO unit test for the property 'EEzmaxinvoicingagentVariationezmax'
        }
        /// <summary>
        /// Test the property 'BEzmaxinvoicingagentBillableezsign'
        /// </summary>
        [Test]
        public void BEzmaxinvoicingagentBillableezsignTest()
        {
            // TODO unit test for the property 'BEzmaxinvoicingagentBillableezsign'
        }
        /// <summary>
        /// Test the property 'EEzmaxinvoicingagentVariationezsign'
        /// </summary>
        [Test]
        public void EEzmaxinvoicingagentVariationezsignTest()
        {
            // TODO unit test for the property 'EEzmaxinvoicingagentVariationezsign'
        }

    }

}
