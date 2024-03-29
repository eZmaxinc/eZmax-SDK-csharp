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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// A Ezmaxinvoicing Object
    /// </summary>
    [DataContract]
    public partial class EzmaxinvoicingResponseCompound :  IEquatable<EzmaxinvoicingResponseCompound>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EEzmaxinvoicingPaymenttype
        /// </summary>
        [DataMember(Name="eEzmaxinvoicingPaymenttype", EmitDefaultValue=true)]
        public FieldEEzmaxinvoicingPaymenttype EEzmaxinvoicingPaymenttype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzmaxinvoicingResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingResponseCompound" /> class.
        /// </summary>
        /// <param name="pkiEzmaxinvoicingID">The unique ID of the Ezmaxinvoicing.</param>
        /// <param name="fkiEzmaxinvoicingcontractID">The unique ID of the Ezmaxinvoicingcontract (required).</param>
        /// <param name="fkiEzmaxpricingID">The unique ID of the Ezmaxpricing (required).</param>
        /// <param name="fkiSystemconfigurationtypeID">The unique ID of the Systemconfigurationtype (required).</param>
        /// <param name="sSystemconfigurationtypeDescriptionX">The description of the Systemconfigurationtype in the language of the requester (required).</param>
        /// <param name="yyyymmEzmaxinvoicing">The YYYYMM period of the Ezmaxinvoicing (required).</param>
        /// <param name="iEzmaxinvoicingDays">The number of days invoiced (required).</param>
        /// <param name="eEzmaxinvoicingPaymenttype">eEzmaxinvoicingPaymenttype (required).</param>
        /// <param name="dEzmaxinvoicingRebatepaymenttype">The percentage of rebate depending of the payment type (required).</param>
        /// <param name="iEzmaxinvoicingContractlength">The length of the contract in years (required).</param>
        /// <param name="dEzmaxinvoicingRebatecontractlength">The percentage of rebate depending of the contract length (required).</param>
        /// <param name="bEzmaxinvoicingRebateEzsignallagents">Whether the rebate for eZsign is for all agents (required).</param>
        /// <param name="objAudit">objAudit.</param>
        /// <param name="objEzmaxinvoicingcontract">objEzmaxinvoicingcontract (required).</param>
        /// <param name="objEzmaxpricing">objEzmaxpricing (required).</param>
        /// <param name="aObjEzmaxinvoicingsummaryglobal">aObjEzmaxinvoicingsummaryglobal (required).</param>
        /// <param name="aObjEzmaxinvoicingsummaryexternal">aObjEzmaxinvoicingsummaryexternal (required).</param>
        /// <param name="aObjEzmaxinvoicingsummaryinternal">aObjEzmaxinvoicingsummaryinternal (required).</param>
        /// <param name="aObjEzmaxinvoicingagent">aObjEzmaxinvoicingagent (required).</param>
        /// <param name="aObjEzmaxinvoicinguser">aObjEzmaxinvoicinguser (required).</param>
        /// <param name="aObjEzmaxinvoicingezsignfolder">aObjEzmaxinvoicingezsignfolder (required).</param>
        /// <param name="aObjEzmaxinvoicingezsigndocument">aObjEzmaxinvoicingezsigndocument (required).</param>
        public EzmaxinvoicingResponseCompound(int pkiEzmaxinvoicingID = default(int), int fkiEzmaxinvoicingcontractID = default(int), int fkiEzmaxpricingID = default(int), int fkiSystemconfigurationtypeID = default(int), string sSystemconfigurationtypeDescriptionX = default(string), string yyyymmEzmaxinvoicing = default(string), int iEzmaxinvoicingDays = default(int), FieldEEzmaxinvoicingPaymenttype eEzmaxinvoicingPaymenttype = default(FieldEEzmaxinvoicingPaymenttype), string dEzmaxinvoicingRebatepaymenttype = default(string), int iEzmaxinvoicingContractlength = default(int), string dEzmaxinvoicingRebatecontractlength = default(string), bool bEzmaxinvoicingRebateEzsignallagents = default(bool), CommonAudit objAudit = default(CommonAudit), EzmaxinvoicingcontractResponseCompound objEzmaxinvoicingcontract = default(EzmaxinvoicingcontractResponseCompound), CustomEzmaxpricingResponse objEzmaxpricing = default(CustomEzmaxpricingResponse), List<EzmaxinvoicingsummaryglobalResponseCompound> aObjEzmaxinvoicingsummaryglobal = default(List<EzmaxinvoicingsummaryglobalResponseCompound>), List<EzmaxinvoicingsummaryexternalResponseCompound> aObjEzmaxinvoicingsummaryexternal = default(List<EzmaxinvoicingsummaryexternalResponseCompound>), List<EzmaxinvoicingsummaryinternalResponseCompound> aObjEzmaxinvoicingsummaryinternal = default(List<EzmaxinvoicingsummaryinternalResponseCompound>), List<EzmaxinvoicingagentResponseCompound> aObjEzmaxinvoicingagent = default(List<EzmaxinvoicingagentResponseCompound>), List<EzmaxinvoicinguserResponseCompound> aObjEzmaxinvoicinguser = default(List<EzmaxinvoicinguserResponseCompound>), List<CustomEzmaxinvoicingEzsignfolderResponse> aObjEzmaxinvoicingezsignfolder = default(List<CustomEzmaxinvoicingEzsignfolderResponse>), List<CustomEzmaxinvoicingEzsigndocumentResponse> aObjEzmaxinvoicingezsigndocument = default(List<CustomEzmaxinvoicingEzsigndocumentResponse>))
        {
            // to ensure "fkiEzmaxinvoicingcontractID" is required (not null)
            if (fkiEzmaxinvoicingcontractID == null)
            {
                throw new InvalidDataException("fkiEzmaxinvoicingcontractID is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.FkiEzmaxinvoicingcontractID = fkiEzmaxinvoicingcontractID;
            }

            // to ensure "fkiEzmaxpricingID" is required (not null)
            if (fkiEzmaxpricingID == null)
            {
                throw new InvalidDataException("fkiEzmaxpricingID is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.FkiEzmaxpricingID = fkiEzmaxpricingID;
            }

            // to ensure "fkiSystemconfigurationtypeID" is required (not null)
            if (fkiSystemconfigurationtypeID == null)
            {
                throw new InvalidDataException("fkiSystemconfigurationtypeID is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.FkiSystemconfigurationtypeID = fkiSystemconfigurationtypeID;
            }

            // to ensure "sSystemconfigurationtypeDescriptionX" is required (not null)
            if (sSystemconfigurationtypeDescriptionX == null)
            {
                throw new InvalidDataException("sSystemconfigurationtypeDescriptionX is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.SSystemconfigurationtypeDescriptionX = sSystemconfigurationtypeDescriptionX;
            }

            // to ensure "yyyymmEzmaxinvoicing" is required (not null)
            if (yyyymmEzmaxinvoicing == null)
            {
                throw new InvalidDataException("yyyymmEzmaxinvoicing is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.YyyymmEzmaxinvoicing = yyyymmEzmaxinvoicing;
            }

            // to ensure "iEzmaxinvoicingDays" is required (not null)
            if (iEzmaxinvoicingDays == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingDays is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingDays = iEzmaxinvoicingDays;
            }

            // to ensure "eEzmaxinvoicingPaymenttype" is required (not null)
            if (eEzmaxinvoicingPaymenttype == null)
            {
                throw new InvalidDataException("eEzmaxinvoicingPaymenttype is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.EEzmaxinvoicingPaymenttype = eEzmaxinvoicingPaymenttype;
            }

            // to ensure "dEzmaxinvoicingRebatepaymenttype" is required (not null)
            if (dEzmaxinvoicingRebatepaymenttype == null)
            {
                throw new InvalidDataException("dEzmaxinvoicingRebatepaymenttype is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.DEzmaxinvoicingRebatepaymenttype = dEzmaxinvoicingRebatepaymenttype;
            }

            // to ensure "iEzmaxinvoicingContractlength" is required (not null)
            if (iEzmaxinvoicingContractlength == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingContractlength is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingContractlength = iEzmaxinvoicingContractlength;
            }

            // to ensure "dEzmaxinvoicingRebatecontractlength" is required (not null)
            if (dEzmaxinvoicingRebatecontractlength == null)
            {
                throw new InvalidDataException("dEzmaxinvoicingRebatecontractlength is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.DEzmaxinvoicingRebatecontractlength = dEzmaxinvoicingRebatecontractlength;
            }

            // to ensure "bEzmaxinvoicingRebateEzsignallagents" is required (not null)
            if (bEzmaxinvoicingRebateEzsignallagents == null)
            {
                throw new InvalidDataException("bEzmaxinvoicingRebateEzsignallagents is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.BEzmaxinvoicingRebateEzsignallagents = bEzmaxinvoicingRebateEzsignallagents;
            }

            // to ensure "objEzmaxinvoicingcontract" is required (not null)
            if (objEzmaxinvoicingcontract == null)
            {
                throw new InvalidDataException("objEzmaxinvoicingcontract is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.ObjEzmaxinvoicingcontract = objEzmaxinvoicingcontract;
            }

            // to ensure "objEzmaxpricing" is required (not null)
            if (objEzmaxpricing == null)
            {
                throw new InvalidDataException("objEzmaxpricing is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.ObjEzmaxpricing = objEzmaxpricing;
            }

            // to ensure "aObjEzmaxinvoicingsummaryglobal" is required (not null)
            if (aObjEzmaxinvoicingsummaryglobal == null)
            {
                throw new InvalidDataException("aObjEzmaxinvoicingsummaryglobal is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzmaxinvoicingsummaryglobal = aObjEzmaxinvoicingsummaryglobal;
            }

            // to ensure "aObjEzmaxinvoicingsummaryexternal" is required (not null)
            if (aObjEzmaxinvoicingsummaryexternal == null)
            {
                throw new InvalidDataException("aObjEzmaxinvoicingsummaryexternal is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzmaxinvoicingsummaryexternal = aObjEzmaxinvoicingsummaryexternal;
            }

            // to ensure "aObjEzmaxinvoicingsummaryinternal" is required (not null)
            if (aObjEzmaxinvoicingsummaryinternal == null)
            {
                throw new InvalidDataException("aObjEzmaxinvoicingsummaryinternal is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzmaxinvoicingsummaryinternal = aObjEzmaxinvoicingsummaryinternal;
            }

            // to ensure "aObjEzmaxinvoicingagent" is required (not null)
            if (aObjEzmaxinvoicingagent == null)
            {
                throw new InvalidDataException("aObjEzmaxinvoicingagent is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzmaxinvoicingagent = aObjEzmaxinvoicingagent;
            }

            // to ensure "aObjEzmaxinvoicinguser" is required (not null)
            if (aObjEzmaxinvoicinguser == null)
            {
                throw new InvalidDataException("aObjEzmaxinvoicinguser is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzmaxinvoicinguser = aObjEzmaxinvoicinguser;
            }

            // to ensure "aObjEzmaxinvoicingezsignfolder" is required (not null)
            if (aObjEzmaxinvoicingezsignfolder == null)
            {
                throw new InvalidDataException("aObjEzmaxinvoicingezsignfolder is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzmaxinvoicingezsignfolder = aObjEzmaxinvoicingezsignfolder;
            }

            // to ensure "aObjEzmaxinvoicingezsigndocument" is required (not null)
            if (aObjEzmaxinvoicingezsigndocument == null)
            {
                throw new InvalidDataException("aObjEzmaxinvoicingezsigndocument is a required property for EzmaxinvoicingResponseCompound and cannot be null");
            }
            else
            {
                this.AObjEzmaxinvoicingezsigndocument = aObjEzmaxinvoicingezsigndocument;
            }

            this.PkiEzmaxinvoicingID = pkiEzmaxinvoicingID;
            this.ObjAudit = objAudit;
        }

        /// <summary>
        /// The unique ID of the Ezmaxinvoicing
        /// </summary>
        /// <value>The unique ID of the Ezmaxinvoicing</value>
        [DataMember(Name="pkiEzmaxinvoicingID", EmitDefaultValue=false)]
        public int PkiEzmaxinvoicingID { get; set; }

        /// <summary>
        /// The unique ID of the Ezmaxinvoicingcontract
        /// </summary>
        /// <value>The unique ID of the Ezmaxinvoicingcontract</value>
        [DataMember(Name="fkiEzmaxinvoicingcontractID", EmitDefaultValue=true)]
        public int FkiEzmaxinvoicingcontractID { get; set; }

        /// <summary>
        /// The unique ID of the Ezmaxpricing
        /// </summary>
        /// <value>The unique ID of the Ezmaxpricing</value>
        [DataMember(Name="fkiEzmaxpricingID", EmitDefaultValue=true)]
        public int FkiEzmaxpricingID { get; set; }

        /// <summary>
        /// The unique ID of the Systemconfigurationtype
        /// </summary>
        /// <value>The unique ID of the Systemconfigurationtype</value>
        [DataMember(Name="fkiSystemconfigurationtypeID", EmitDefaultValue=true)]
        public int FkiSystemconfigurationtypeID { get; set; }

        /// <summary>
        /// The description of the Systemconfigurationtype in the language of the requester
        /// </summary>
        /// <value>The description of the Systemconfigurationtype in the language of the requester</value>
        [DataMember(Name="sSystemconfigurationtypeDescriptionX", EmitDefaultValue=true)]
        public string SSystemconfigurationtypeDescriptionX { get; set; }

        /// <summary>
        /// The YYYYMM period of the Ezmaxinvoicing
        /// </summary>
        /// <value>The YYYYMM period of the Ezmaxinvoicing</value>
        [DataMember(Name="yyyymmEzmaxinvoicing", EmitDefaultValue=true)]
        public string YyyymmEzmaxinvoicing { get; set; }

        /// <summary>
        /// The number of days invoiced
        /// </summary>
        /// <value>The number of days invoiced</value>
        [DataMember(Name="iEzmaxinvoicingDays", EmitDefaultValue=true)]
        public int IEzmaxinvoicingDays { get; set; }


        /// <summary>
        /// The percentage of rebate depending of the payment type
        /// </summary>
        /// <value>The percentage of rebate depending of the payment type</value>
        [DataMember(Name="dEzmaxinvoicingRebatepaymenttype", EmitDefaultValue=true)]
        public string DEzmaxinvoicingRebatepaymenttype { get; set; }

        /// <summary>
        /// The length of the contract in years
        /// </summary>
        /// <value>The length of the contract in years</value>
        [DataMember(Name="iEzmaxinvoicingContractlength", EmitDefaultValue=true)]
        public int IEzmaxinvoicingContractlength { get; set; }

        /// <summary>
        /// The percentage of rebate depending of the contract length
        /// </summary>
        /// <value>The percentage of rebate depending of the contract length</value>
        [DataMember(Name="dEzmaxinvoicingRebatecontractlength", EmitDefaultValue=true)]
        public string DEzmaxinvoicingRebatecontractlength { get; set; }

        /// <summary>
        /// Whether the rebate for eZsign is for all agents
        /// </summary>
        /// <value>Whether the rebate for eZsign is for all agents</value>
        [DataMember(Name="bEzmaxinvoicingRebateEzsignallagents", EmitDefaultValue=true)]
        public bool BEzmaxinvoicingRebateEzsignallagents { get; set; }

        /// <summary>
        /// Gets or Sets ObjAudit
        /// </summary>
        [DataMember(Name="objAudit", EmitDefaultValue=false)]
        public CommonAudit ObjAudit { get; set; }

        /// <summary>
        /// Gets or Sets ObjEzmaxinvoicingcontract
        /// </summary>
        [DataMember(Name="objEzmaxinvoicingcontract", EmitDefaultValue=true)]
        public EzmaxinvoicingcontractResponseCompound ObjEzmaxinvoicingcontract { get; set; }

        /// <summary>
        /// Gets or Sets ObjEzmaxpricing
        /// </summary>
        [DataMember(Name="objEzmaxpricing", EmitDefaultValue=true)]
        public CustomEzmaxpricingResponse ObjEzmaxpricing { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzmaxinvoicingsummaryglobal
        /// </summary>
        [DataMember(Name="a_objEzmaxinvoicingsummaryglobal", EmitDefaultValue=true)]
        public List<EzmaxinvoicingsummaryglobalResponseCompound> AObjEzmaxinvoicingsummaryglobal { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzmaxinvoicingsummaryexternal
        /// </summary>
        [DataMember(Name="a_objEzmaxinvoicingsummaryexternal", EmitDefaultValue=true)]
        public List<EzmaxinvoicingsummaryexternalResponseCompound> AObjEzmaxinvoicingsummaryexternal { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzmaxinvoicingsummaryinternal
        /// </summary>
        [DataMember(Name="a_objEzmaxinvoicingsummaryinternal", EmitDefaultValue=true)]
        public List<EzmaxinvoicingsummaryinternalResponseCompound> AObjEzmaxinvoicingsummaryinternal { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzmaxinvoicingagent
        /// </summary>
        [DataMember(Name="a_objEzmaxinvoicingagent", EmitDefaultValue=true)]
        public List<EzmaxinvoicingagentResponseCompound> AObjEzmaxinvoicingagent { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzmaxinvoicinguser
        /// </summary>
        [DataMember(Name="a_objEzmaxinvoicinguser", EmitDefaultValue=true)]
        public List<EzmaxinvoicinguserResponseCompound> AObjEzmaxinvoicinguser { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzmaxinvoicingezsignfolder
        /// </summary>
        [DataMember(Name="a_objEzmaxinvoicingezsignfolder", EmitDefaultValue=true)]
        public List<CustomEzmaxinvoicingEzsignfolderResponse> AObjEzmaxinvoicingezsignfolder { get; set; }

        /// <summary>
        /// Gets or Sets AObjEzmaxinvoicingezsigndocument
        /// </summary>
        [DataMember(Name="a_objEzmaxinvoicingezsigndocument", EmitDefaultValue=true)]
        public List<CustomEzmaxinvoicingEzsigndocumentResponse> AObjEzmaxinvoicingezsigndocument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzmaxinvoicingResponseCompound {\n");
            sb.Append("  PkiEzmaxinvoicingID: ").Append(PkiEzmaxinvoicingID).Append("\n");
            sb.Append("  FkiEzmaxinvoicingcontractID: ").Append(FkiEzmaxinvoicingcontractID).Append("\n");
            sb.Append("  FkiEzmaxpricingID: ").Append(FkiEzmaxpricingID).Append("\n");
            sb.Append("  FkiSystemconfigurationtypeID: ").Append(FkiSystemconfigurationtypeID).Append("\n");
            sb.Append("  SSystemconfigurationtypeDescriptionX: ").Append(SSystemconfigurationtypeDescriptionX).Append("\n");
            sb.Append("  YyyymmEzmaxinvoicing: ").Append(YyyymmEzmaxinvoicing).Append("\n");
            sb.Append("  IEzmaxinvoicingDays: ").Append(IEzmaxinvoicingDays).Append("\n");
            sb.Append("  EEzmaxinvoicingPaymenttype: ").Append(EEzmaxinvoicingPaymenttype).Append("\n");
            sb.Append("  DEzmaxinvoicingRebatepaymenttype: ").Append(DEzmaxinvoicingRebatepaymenttype).Append("\n");
            sb.Append("  IEzmaxinvoicingContractlength: ").Append(IEzmaxinvoicingContractlength).Append("\n");
            sb.Append("  DEzmaxinvoicingRebatecontractlength: ").Append(DEzmaxinvoicingRebatecontractlength).Append("\n");
            sb.Append("  BEzmaxinvoicingRebateEzsignallagents: ").Append(BEzmaxinvoicingRebateEzsignallagents).Append("\n");
            sb.Append("  ObjAudit: ").Append(ObjAudit).Append("\n");
            sb.Append("  ObjEzmaxinvoicingcontract: ").Append(ObjEzmaxinvoicingcontract).Append("\n");
            sb.Append("  ObjEzmaxpricing: ").Append(ObjEzmaxpricing).Append("\n");
            sb.Append("  AObjEzmaxinvoicingsummaryglobal: ").Append(AObjEzmaxinvoicingsummaryglobal).Append("\n");
            sb.Append("  AObjEzmaxinvoicingsummaryexternal: ").Append(AObjEzmaxinvoicingsummaryexternal).Append("\n");
            sb.Append("  AObjEzmaxinvoicingsummaryinternal: ").Append(AObjEzmaxinvoicingsummaryinternal).Append("\n");
            sb.Append("  AObjEzmaxinvoicingagent: ").Append(AObjEzmaxinvoicingagent).Append("\n");
            sb.Append("  AObjEzmaxinvoicinguser: ").Append(AObjEzmaxinvoicinguser).Append("\n");
            sb.Append("  AObjEzmaxinvoicingezsignfolder: ").Append(AObjEzmaxinvoicingezsignfolder).Append("\n");
            sb.Append("  AObjEzmaxinvoicingezsigndocument: ").Append(AObjEzmaxinvoicingezsigndocument).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzmaxinvoicingResponseCompound);
        }

        /// <summary>
        /// Returns true if EzmaxinvoicingResponseCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzmaxinvoicingResponseCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzmaxinvoicingResponseCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzmaxinvoicingID == input.PkiEzmaxinvoicingID ||
                    (this.PkiEzmaxinvoicingID != null &&
                    this.PkiEzmaxinvoicingID.Equals(input.PkiEzmaxinvoicingID))
                ) && 
                (
                    this.FkiEzmaxinvoicingcontractID == input.FkiEzmaxinvoicingcontractID ||
                    (this.FkiEzmaxinvoicingcontractID != null &&
                    this.FkiEzmaxinvoicingcontractID.Equals(input.FkiEzmaxinvoicingcontractID))
                ) && 
                (
                    this.FkiEzmaxpricingID == input.FkiEzmaxpricingID ||
                    (this.FkiEzmaxpricingID != null &&
                    this.FkiEzmaxpricingID.Equals(input.FkiEzmaxpricingID))
                ) && 
                (
                    this.FkiSystemconfigurationtypeID == input.FkiSystemconfigurationtypeID ||
                    (this.FkiSystemconfigurationtypeID != null &&
                    this.FkiSystemconfigurationtypeID.Equals(input.FkiSystemconfigurationtypeID))
                ) && 
                (
                    this.SSystemconfigurationtypeDescriptionX == input.SSystemconfigurationtypeDescriptionX ||
                    (this.SSystemconfigurationtypeDescriptionX != null &&
                    this.SSystemconfigurationtypeDescriptionX.Equals(input.SSystemconfigurationtypeDescriptionX))
                ) && 
                (
                    this.YyyymmEzmaxinvoicing == input.YyyymmEzmaxinvoicing ||
                    (this.YyyymmEzmaxinvoicing != null &&
                    this.YyyymmEzmaxinvoicing.Equals(input.YyyymmEzmaxinvoicing))
                ) && 
                (
                    this.IEzmaxinvoicingDays == input.IEzmaxinvoicingDays ||
                    (this.IEzmaxinvoicingDays != null &&
                    this.IEzmaxinvoicingDays.Equals(input.IEzmaxinvoicingDays))
                ) && 
                (
                    this.EEzmaxinvoicingPaymenttype == input.EEzmaxinvoicingPaymenttype ||
                    (this.EEzmaxinvoicingPaymenttype != null &&
                    this.EEzmaxinvoicingPaymenttype.Equals(input.EEzmaxinvoicingPaymenttype))
                ) && 
                (
                    this.DEzmaxinvoicingRebatepaymenttype == input.DEzmaxinvoicingRebatepaymenttype ||
                    (this.DEzmaxinvoicingRebatepaymenttype != null &&
                    this.DEzmaxinvoicingRebatepaymenttype.Equals(input.DEzmaxinvoicingRebatepaymenttype))
                ) && 
                (
                    this.IEzmaxinvoicingContractlength == input.IEzmaxinvoicingContractlength ||
                    (this.IEzmaxinvoicingContractlength != null &&
                    this.IEzmaxinvoicingContractlength.Equals(input.IEzmaxinvoicingContractlength))
                ) && 
                (
                    this.DEzmaxinvoicingRebatecontractlength == input.DEzmaxinvoicingRebatecontractlength ||
                    (this.DEzmaxinvoicingRebatecontractlength != null &&
                    this.DEzmaxinvoicingRebatecontractlength.Equals(input.DEzmaxinvoicingRebatecontractlength))
                ) && 
                (
                    this.BEzmaxinvoicingRebateEzsignallagents == input.BEzmaxinvoicingRebateEzsignallagents ||
                    (this.BEzmaxinvoicingRebateEzsignallagents != null &&
                    this.BEzmaxinvoicingRebateEzsignallagents.Equals(input.BEzmaxinvoicingRebateEzsignallagents))
                ) && 
                (
                    this.ObjAudit == input.ObjAudit ||
                    (this.ObjAudit != null &&
                    this.ObjAudit.Equals(input.ObjAudit))
                ) && 
                (
                    this.ObjEzmaxinvoicingcontract == input.ObjEzmaxinvoicingcontract ||
                    (this.ObjEzmaxinvoicingcontract != null &&
                    this.ObjEzmaxinvoicingcontract.Equals(input.ObjEzmaxinvoicingcontract))
                ) && 
                (
                    this.ObjEzmaxpricing == input.ObjEzmaxpricing ||
                    (this.ObjEzmaxpricing != null &&
                    this.ObjEzmaxpricing.Equals(input.ObjEzmaxpricing))
                ) && 
                (
                    this.AObjEzmaxinvoicingsummaryglobal == input.AObjEzmaxinvoicingsummaryglobal ||
                    this.AObjEzmaxinvoicingsummaryglobal != null &&
                    input.AObjEzmaxinvoicingsummaryglobal != null &&
                    this.AObjEzmaxinvoicingsummaryglobal.SequenceEqual(input.AObjEzmaxinvoicingsummaryglobal)
                ) && 
                (
                    this.AObjEzmaxinvoicingsummaryexternal == input.AObjEzmaxinvoicingsummaryexternal ||
                    this.AObjEzmaxinvoicingsummaryexternal != null &&
                    input.AObjEzmaxinvoicingsummaryexternal != null &&
                    this.AObjEzmaxinvoicingsummaryexternal.SequenceEqual(input.AObjEzmaxinvoicingsummaryexternal)
                ) && 
                (
                    this.AObjEzmaxinvoicingsummaryinternal == input.AObjEzmaxinvoicingsummaryinternal ||
                    this.AObjEzmaxinvoicingsummaryinternal != null &&
                    input.AObjEzmaxinvoicingsummaryinternal != null &&
                    this.AObjEzmaxinvoicingsummaryinternal.SequenceEqual(input.AObjEzmaxinvoicingsummaryinternal)
                ) && 
                (
                    this.AObjEzmaxinvoicingagent == input.AObjEzmaxinvoicingagent ||
                    this.AObjEzmaxinvoicingagent != null &&
                    input.AObjEzmaxinvoicingagent != null &&
                    this.AObjEzmaxinvoicingagent.SequenceEqual(input.AObjEzmaxinvoicingagent)
                ) && 
                (
                    this.AObjEzmaxinvoicinguser == input.AObjEzmaxinvoicinguser ||
                    this.AObjEzmaxinvoicinguser != null &&
                    input.AObjEzmaxinvoicinguser != null &&
                    this.AObjEzmaxinvoicinguser.SequenceEqual(input.AObjEzmaxinvoicinguser)
                ) && 
                (
                    this.AObjEzmaxinvoicingezsignfolder == input.AObjEzmaxinvoicingezsignfolder ||
                    this.AObjEzmaxinvoicingezsignfolder != null &&
                    input.AObjEzmaxinvoicingezsignfolder != null &&
                    this.AObjEzmaxinvoicingezsignfolder.SequenceEqual(input.AObjEzmaxinvoicingezsignfolder)
                ) && 
                (
                    this.AObjEzmaxinvoicingezsigndocument == input.AObjEzmaxinvoicingezsigndocument ||
                    this.AObjEzmaxinvoicingezsigndocument != null &&
                    input.AObjEzmaxinvoicingezsigndocument != null &&
                    this.AObjEzmaxinvoicingezsigndocument.SequenceEqual(input.AObjEzmaxinvoicingezsigndocument)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PkiEzmaxinvoicingID != null)
                    hashCode = hashCode * 59 + this.PkiEzmaxinvoicingID.GetHashCode();
                if (this.FkiEzmaxinvoicingcontractID != null)
                    hashCode = hashCode * 59 + this.FkiEzmaxinvoicingcontractID.GetHashCode();
                if (this.FkiEzmaxpricingID != null)
                    hashCode = hashCode * 59 + this.FkiEzmaxpricingID.GetHashCode();
                if (this.FkiSystemconfigurationtypeID != null)
                    hashCode = hashCode * 59 + this.FkiSystemconfigurationtypeID.GetHashCode();
                if (this.SSystemconfigurationtypeDescriptionX != null)
                    hashCode = hashCode * 59 + this.SSystemconfigurationtypeDescriptionX.GetHashCode();
                if (this.YyyymmEzmaxinvoicing != null)
                    hashCode = hashCode * 59 + this.YyyymmEzmaxinvoicing.GetHashCode();
                if (this.IEzmaxinvoicingDays != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingDays.GetHashCode();
                if (this.EEzmaxinvoicingPaymenttype != null)
                    hashCode = hashCode * 59 + this.EEzmaxinvoicingPaymenttype.GetHashCode();
                if (this.DEzmaxinvoicingRebatepaymenttype != null)
                    hashCode = hashCode * 59 + this.DEzmaxinvoicingRebatepaymenttype.GetHashCode();
                if (this.IEzmaxinvoicingContractlength != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingContractlength.GetHashCode();
                if (this.DEzmaxinvoicingRebatecontractlength != null)
                    hashCode = hashCode * 59 + this.DEzmaxinvoicingRebatecontractlength.GetHashCode();
                if (this.BEzmaxinvoicingRebateEzsignallagents != null)
                    hashCode = hashCode * 59 + this.BEzmaxinvoicingRebateEzsignallagents.GetHashCode();
                if (this.ObjAudit != null)
                    hashCode = hashCode * 59 + this.ObjAudit.GetHashCode();
                if (this.ObjEzmaxinvoicingcontract != null)
                    hashCode = hashCode * 59 + this.ObjEzmaxinvoicingcontract.GetHashCode();
                if (this.ObjEzmaxpricing != null)
                    hashCode = hashCode * 59 + this.ObjEzmaxpricing.GetHashCode();
                if (this.AObjEzmaxinvoicingsummaryglobal != null)
                    hashCode = hashCode * 59 + this.AObjEzmaxinvoicingsummaryglobal.GetHashCode();
                if (this.AObjEzmaxinvoicingsummaryexternal != null)
                    hashCode = hashCode * 59 + this.AObjEzmaxinvoicingsummaryexternal.GetHashCode();
                if (this.AObjEzmaxinvoicingsummaryinternal != null)
                    hashCode = hashCode * 59 + this.AObjEzmaxinvoicingsummaryinternal.GetHashCode();
                if (this.AObjEzmaxinvoicingagent != null)
                    hashCode = hashCode * 59 + this.AObjEzmaxinvoicingagent.GetHashCode();
                if (this.AObjEzmaxinvoicinguser != null)
                    hashCode = hashCode * 59 + this.AObjEzmaxinvoicinguser.GetHashCode();
                if (this.AObjEzmaxinvoicingezsignfolder != null)
                    hashCode = hashCode * 59 + this.AObjEzmaxinvoicingezsignfolder.GetHashCode();
                if (this.AObjEzmaxinvoicingezsigndocument != null)
                    hashCode = hashCode * 59 + this.AObjEzmaxinvoicingezsigndocument.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {


            // PkiEzmaxinvoicingID (int) minimum
            if(this.PkiEzmaxinvoicingID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzmaxinvoicingID, must be a value greater than or equal to 0.", new [] { "PkiEzmaxinvoicingID" });
            }



            // FkiEzmaxinvoicingcontractID (int) minimum
            if(this.FkiEzmaxinvoicingcontractID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzmaxinvoicingcontractID, must be a value greater than or equal to 1.", new [] { "FkiEzmaxinvoicingcontractID" });
            }



            // FkiEzmaxpricingID (int) minimum
            if(this.FkiEzmaxpricingID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzmaxpricingID, must be a value greater than or equal to 1.", new [] { "FkiEzmaxpricingID" });
            }



            // FkiSystemconfigurationtypeID (int) minimum
            if(this.FkiSystemconfigurationtypeID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiSystemconfigurationtypeID, must be a value greater than or equal to 1.", new [] { "FkiSystemconfigurationtypeID" });
            }

            // YyyymmEzmaxinvoicing (string) maxLength
            if(this.YyyymmEzmaxinvoicing != null && this.YyyymmEzmaxinvoicing.Length > 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for YyyymmEzmaxinvoicing, length must be less than 7.", new [] { "YyyymmEzmaxinvoicing" });
            }




            // IEzmaxinvoicingDays (int) minimum
            if(this.IEzmaxinvoicingDays < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingDays, must be a value greater than or equal to 1.", new [] { "IEzmaxinvoicingDays" });
            }



            // DEzmaxinvoicingRebatepaymenttype (string) pattern
            Regex regexDEzmaxinvoicingRebatepaymenttype = new Regex(@"^-{0,1}[\d]{1,3}?\.[\d]{2}$", RegexOptions.CultureInvariant);
            if (false == regexDEzmaxinvoicingRebatepaymenttype.Match(this.DEzmaxinvoicingRebatepaymenttype).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DEzmaxinvoicingRebatepaymenttype, must match a pattern of " + regexDEzmaxinvoicingRebatepaymenttype, new [] { "DEzmaxinvoicingRebatepaymenttype" });
            }



            // IEzmaxinvoicingContractlength (int) minimum
            if(this.IEzmaxinvoicingContractlength < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingContractlength, must be a value greater than or equal to 1.", new [] { "IEzmaxinvoicingContractlength" });
            }



            // DEzmaxinvoicingRebatecontractlength (string) pattern
            Regex regexDEzmaxinvoicingRebatecontractlength = new Regex(@"^-{0,1}[\d]{1,3}?\.[\d]{2}$", RegexOptions.CultureInvariant);
            if (false == regexDEzmaxinvoicingRebatecontractlength.Match(this.DEzmaxinvoicingRebatecontractlength).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DEzmaxinvoicingRebatecontractlength, must match a pattern of " + regexDEzmaxinvoicingRebatecontractlength, new [] { "DEzmaxinvoicingRebatecontractlength" });
            }

            yield break;
        }
    }

}
