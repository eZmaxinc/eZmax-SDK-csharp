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
    /// A Ezmaxinvoicingagent Object
    /// </summary>
    [DataContract]
    public partial class EzmaxinvoicingagentResponse :  IEquatable<EzmaxinvoicingagentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingagentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzmaxinvoicingagentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzmaxinvoicingagentResponse" /> class.
        /// </summary>
        /// <param name="pkiEzmaxinvoicingagentID">The unique ID of the Ezmaxinvoicingagent.</param>
        /// <param name="fkiEzmaxinvoicingID">The unique ID of the Ezmaxinvoicing.</param>
        /// <param name="fkiBillingentityinternalID">The unique ID of the Billingentityinternal. (required).</param>
        /// <param name="sBillingentityinternalDescriptionX">The description of the Billingentityinternal in the language of the requester (required).</param>
        /// <param name="fkiAgentID">The unique ID of the Agent..</param>
        /// <param name="fkiBrokerID">The unique ID of the Broker..</param>
        /// <param name="iEzmaxinvoicingagentSession">The number of sessions (required).</param>
        /// <param name="iEzmaxinvoicingagentCloned">The number of times this user was cloned (required).</param>
        /// <param name="iEzmaxinvoicingagentInvoice">The number of invoices (required).</param>
        /// <param name="iEzmaxinvoicingagentInscription">The number of inscriptions (required).</param>
        /// <param name="iEzmaxinvoicingagentInscriptionactive">The number of active inscriptions (required).</param>
        /// <param name="iEzmaxinvoicingagentSale">The number of sales (required).</param>
        /// <param name="iEzmaxinvoicingagentOtherincome">The number of otherincomes (required).</param>
        /// <param name="iEzmaxinvoicingagentCommissioncalculation">The number of commission calculations (required).</param>
        /// <param name="iEzmaxinvoicingagentEzsigndocument">The number of ezsign documents (required).</param>
        /// <param name="bEzmaxinvoicingagentEzsignaccount">Whether the agent has an eZsign account (required).</param>
        /// <param name="bEzmaxinvoicingagentBillableezmax">Whether it is billable for eZmax (required).</param>
        /// <param name="eEzmaxinvoicingagentVariationezmax">eEzmaxinvoicingagentVariationezmax (required).</param>
        /// <param name="bEzmaxinvoicingagentBillableezsign">Whether it is billable for eZsign (required).</param>
        /// <param name="eEzmaxinvoicingagentVariationezsign">eEzmaxinvoicingagentVariationezsign (required).</param>
        public EzmaxinvoicingagentResponse(int pkiEzmaxinvoicingagentID = default(int), int fkiEzmaxinvoicingID = default(int), int fkiBillingentityinternalID = default(int), string sBillingentityinternalDescriptionX = default(string), int fkiAgentID = default(int), int fkiBrokerID = default(int), int iEzmaxinvoicingagentSession = default(int), int iEzmaxinvoicingagentCloned = default(int), int iEzmaxinvoicingagentInvoice = default(int), int iEzmaxinvoicingagentInscription = default(int), int iEzmaxinvoicingagentInscriptionactive = default(int), int iEzmaxinvoicingagentSale = default(int), int iEzmaxinvoicingagentOtherincome = default(int), int iEzmaxinvoicingagentCommissioncalculation = default(int), int iEzmaxinvoicingagentEzsigndocument = default(int), bool bEzmaxinvoicingagentEzsignaccount = default(bool), bool bEzmaxinvoicingagentBillableezmax = default(bool), FieldEEzmaxinvoicingagentVariationezmax eEzmaxinvoicingagentVariationezmax = default(FieldEEzmaxinvoicingagentVariationezmax), bool bEzmaxinvoicingagentBillableezsign = default(bool), FieldEEzmaxinvoicingagentVariationezsign eEzmaxinvoicingagentVariationezsign = default(FieldEEzmaxinvoicingagentVariationezsign))
        {
            // to ensure "fkiBillingentityinternalID" is required (not null)
            if (fkiBillingentityinternalID == null)
            {
                throw new InvalidDataException("fkiBillingentityinternalID is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.FkiBillingentityinternalID = fkiBillingentityinternalID;
            }

            // to ensure "sBillingentityinternalDescriptionX" is required (not null)
            if (sBillingentityinternalDescriptionX == null)
            {
                throw new InvalidDataException("sBillingentityinternalDescriptionX is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.SBillingentityinternalDescriptionX = sBillingentityinternalDescriptionX;
            }

            // to ensure "iEzmaxinvoicingagentSession" is required (not null)
            if (iEzmaxinvoicingagentSession == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentSession is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentSession = iEzmaxinvoicingagentSession;
            }

            // to ensure "iEzmaxinvoicingagentCloned" is required (not null)
            if (iEzmaxinvoicingagentCloned == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentCloned is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentCloned = iEzmaxinvoicingagentCloned;
            }

            // to ensure "iEzmaxinvoicingagentInvoice" is required (not null)
            if (iEzmaxinvoicingagentInvoice == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentInvoice is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentInvoice = iEzmaxinvoicingagentInvoice;
            }

            // to ensure "iEzmaxinvoicingagentInscription" is required (not null)
            if (iEzmaxinvoicingagentInscription == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentInscription is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentInscription = iEzmaxinvoicingagentInscription;
            }

            // to ensure "iEzmaxinvoicingagentInscriptionactive" is required (not null)
            if (iEzmaxinvoicingagentInscriptionactive == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentInscriptionactive is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentInscriptionactive = iEzmaxinvoicingagentInscriptionactive;
            }

            // to ensure "iEzmaxinvoicingagentSale" is required (not null)
            if (iEzmaxinvoicingagentSale == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentSale is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentSale = iEzmaxinvoicingagentSale;
            }

            // to ensure "iEzmaxinvoicingagentOtherincome" is required (not null)
            if (iEzmaxinvoicingagentOtherincome == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentOtherincome is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentOtherincome = iEzmaxinvoicingagentOtherincome;
            }

            // to ensure "iEzmaxinvoicingagentCommissioncalculation" is required (not null)
            if (iEzmaxinvoicingagentCommissioncalculation == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentCommissioncalculation is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentCommissioncalculation = iEzmaxinvoicingagentCommissioncalculation;
            }

            // to ensure "iEzmaxinvoicingagentEzsigndocument" is required (not null)
            if (iEzmaxinvoicingagentEzsigndocument == null)
            {
                throw new InvalidDataException("iEzmaxinvoicingagentEzsigndocument is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.IEzmaxinvoicingagentEzsigndocument = iEzmaxinvoicingagentEzsigndocument;
            }

            // to ensure "bEzmaxinvoicingagentEzsignaccount" is required (not null)
            if (bEzmaxinvoicingagentEzsignaccount == null)
            {
                throw new InvalidDataException("bEzmaxinvoicingagentEzsignaccount is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.BEzmaxinvoicingagentEzsignaccount = bEzmaxinvoicingagentEzsignaccount;
            }

            // to ensure "bEzmaxinvoicingagentBillableezmax" is required (not null)
            if (bEzmaxinvoicingagentBillableezmax == null)
            {
                throw new InvalidDataException("bEzmaxinvoicingagentBillableezmax is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.BEzmaxinvoicingagentBillableezmax = bEzmaxinvoicingagentBillableezmax;
            }

            // to ensure "eEzmaxinvoicingagentVariationezmax" is required (not null)
            if (eEzmaxinvoicingagentVariationezmax == null)
            {
                throw new InvalidDataException("eEzmaxinvoicingagentVariationezmax is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.EEzmaxinvoicingagentVariationezmax = eEzmaxinvoicingagentVariationezmax;
            }

            // to ensure "bEzmaxinvoicingagentBillableezsign" is required (not null)
            if (bEzmaxinvoicingagentBillableezsign == null)
            {
                throw new InvalidDataException("bEzmaxinvoicingagentBillableezsign is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.BEzmaxinvoicingagentBillableezsign = bEzmaxinvoicingagentBillableezsign;
            }

            // to ensure "eEzmaxinvoicingagentVariationezsign" is required (not null)
            if (eEzmaxinvoicingagentVariationezsign == null)
            {
                throw new InvalidDataException("eEzmaxinvoicingagentVariationezsign is a required property for EzmaxinvoicingagentResponse and cannot be null");
            }
            else
            {
                this.EEzmaxinvoicingagentVariationezsign = eEzmaxinvoicingagentVariationezsign;
            }

            this.PkiEzmaxinvoicingagentID = pkiEzmaxinvoicingagentID;
            this.FkiEzmaxinvoicingID = fkiEzmaxinvoicingID;
            this.FkiAgentID = fkiAgentID;
            this.FkiBrokerID = fkiBrokerID;
        }

        /// <summary>
        /// The unique ID of the Ezmaxinvoicingagent
        /// </summary>
        /// <value>The unique ID of the Ezmaxinvoicingagent</value>
        [DataMember(Name="pkiEzmaxinvoicingagentID", EmitDefaultValue=false)]
        public int PkiEzmaxinvoicingagentID { get; set; }

        /// <summary>
        /// The unique ID of the Ezmaxinvoicing
        /// </summary>
        /// <value>The unique ID of the Ezmaxinvoicing</value>
        [DataMember(Name="fkiEzmaxinvoicingID", EmitDefaultValue=false)]
        public int FkiEzmaxinvoicingID { get; set; }

        /// <summary>
        /// The unique ID of the Billingentityinternal.
        /// </summary>
        /// <value>The unique ID of the Billingentityinternal.</value>
        [DataMember(Name="fkiBillingentityinternalID", EmitDefaultValue=true)]
        public int FkiBillingentityinternalID { get; set; }

        /// <summary>
        /// The description of the Billingentityinternal in the language of the requester
        /// </summary>
        /// <value>The description of the Billingentityinternal in the language of the requester</value>
        [DataMember(Name="sBillingentityinternalDescriptionX", EmitDefaultValue=true)]
        public string SBillingentityinternalDescriptionX { get; set; }

        /// <summary>
        /// The unique ID of the Agent.
        /// </summary>
        /// <value>The unique ID of the Agent.</value>
        [DataMember(Name="fkiAgentID", EmitDefaultValue=false)]
        public int FkiAgentID { get; set; }

        /// <summary>
        /// The unique ID of the Broker.
        /// </summary>
        /// <value>The unique ID of the Broker.</value>
        [DataMember(Name="fkiBrokerID", EmitDefaultValue=false)]
        public int FkiBrokerID { get; set; }

        /// <summary>
        /// The number of sessions
        /// </summary>
        /// <value>The number of sessions</value>
        [DataMember(Name="iEzmaxinvoicingagentSession", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentSession { get; set; }

        /// <summary>
        /// The number of times this user was cloned
        /// </summary>
        /// <value>The number of times this user was cloned</value>
        [DataMember(Name="iEzmaxinvoicingagentCloned", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentCloned { get; set; }

        /// <summary>
        /// The number of invoices
        /// </summary>
        /// <value>The number of invoices</value>
        [DataMember(Name="iEzmaxinvoicingagentInvoice", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentInvoice { get; set; }

        /// <summary>
        /// The number of inscriptions
        /// </summary>
        /// <value>The number of inscriptions</value>
        [DataMember(Name="iEzmaxinvoicingagentInscription", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentInscription { get; set; }

        /// <summary>
        /// The number of active inscriptions
        /// </summary>
        /// <value>The number of active inscriptions</value>
        [DataMember(Name="iEzmaxinvoicingagentInscriptionactive", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentInscriptionactive { get; set; }

        /// <summary>
        /// The number of sales
        /// </summary>
        /// <value>The number of sales</value>
        [DataMember(Name="iEzmaxinvoicingagentSale", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentSale { get; set; }

        /// <summary>
        /// The number of otherincomes
        /// </summary>
        /// <value>The number of otherincomes</value>
        [DataMember(Name="iEzmaxinvoicingagentOtherincome", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentOtherincome { get; set; }

        /// <summary>
        /// The number of commission calculations
        /// </summary>
        /// <value>The number of commission calculations</value>
        [DataMember(Name="iEzmaxinvoicingagentCommissioncalculation", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentCommissioncalculation { get; set; }

        /// <summary>
        /// The number of ezsign documents
        /// </summary>
        /// <value>The number of ezsign documents</value>
        [DataMember(Name="iEzmaxinvoicingagentEzsigndocument", EmitDefaultValue=true)]
        public int IEzmaxinvoicingagentEzsigndocument { get; set; }

        /// <summary>
        /// Whether the agent has an eZsign account
        /// </summary>
        /// <value>Whether the agent has an eZsign account</value>
        [DataMember(Name="bEzmaxinvoicingagentEzsignaccount", EmitDefaultValue=true)]
        public bool BEzmaxinvoicingagentEzsignaccount { get; set; }

        /// <summary>
        /// Whether it is billable for eZmax
        /// </summary>
        /// <value>Whether it is billable for eZmax</value>
        [DataMember(Name="bEzmaxinvoicingagentBillableezmax", EmitDefaultValue=true)]
        public bool BEzmaxinvoicingagentBillableezmax { get; set; }

        /// <summary>
        /// Gets or Sets EEzmaxinvoicingagentVariationezmax
        /// </summary>
        [DataMember(Name="eEzmaxinvoicingagentVariationezmax", EmitDefaultValue=true)]
        public FieldEEzmaxinvoicingagentVariationezmax EEzmaxinvoicingagentVariationezmax { get; set; }

        /// <summary>
        /// Whether it is billable for eZsign
        /// </summary>
        /// <value>Whether it is billable for eZsign</value>
        [DataMember(Name="bEzmaxinvoicingagentBillableezsign", EmitDefaultValue=true)]
        public bool BEzmaxinvoicingagentBillableezsign { get; set; }

        /// <summary>
        /// Gets or Sets EEzmaxinvoicingagentVariationezsign
        /// </summary>
        [DataMember(Name="eEzmaxinvoicingagentVariationezsign", EmitDefaultValue=true)]
        public FieldEEzmaxinvoicingagentVariationezsign EEzmaxinvoicingagentVariationezsign { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzmaxinvoicingagentResponse {\n");
            sb.Append("  PkiEzmaxinvoicingagentID: ").Append(PkiEzmaxinvoicingagentID).Append("\n");
            sb.Append("  FkiEzmaxinvoicingID: ").Append(FkiEzmaxinvoicingID).Append("\n");
            sb.Append("  FkiBillingentityinternalID: ").Append(FkiBillingentityinternalID).Append("\n");
            sb.Append("  SBillingentityinternalDescriptionX: ").Append(SBillingentityinternalDescriptionX).Append("\n");
            sb.Append("  FkiAgentID: ").Append(FkiAgentID).Append("\n");
            sb.Append("  FkiBrokerID: ").Append(FkiBrokerID).Append("\n");
            sb.Append("  IEzmaxinvoicingagentSession: ").Append(IEzmaxinvoicingagentSession).Append("\n");
            sb.Append("  IEzmaxinvoicingagentCloned: ").Append(IEzmaxinvoicingagentCloned).Append("\n");
            sb.Append("  IEzmaxinvoicingagentInvoice: ").Append(IEzmaxinvoicingagentInvoice).Append("\n");
            sb.Append("  IEzmaxinvoicingagentInscription: ").Append(IEzmaxinvoicingagentInscription).Append("\n");
            sb.Append("  IEzmaxinvoicingagentInscriptionactive: ").Append(IEzmaxinvoicingagentInscriptionactive).Append("\n");
            sb.Append("  IEzmaxinvoicingagentSale: ").Append(IEzmaxinvoicingagentSale).Append("\n");
            sb.Append("  IEzmaxinvoicingagentOtherincome: ").Append(IEzmaxinvoicingagentOtherincome).Append("\n");
            sb.Append("  IEzmaxinvoicingagentCommissioncalculation: ").Append(IEzmaxinvoicingagentCommissioncalculation).Append("\n");
            sb.Append("  IEzmaxinvoicingagentEzsigndocument: ").Append(IEzmaxinvoicingagentEzsigndocument).Append("\n");
            sb.Append("  BEzmaxinvoicingagentEzsignaccount: ").Append(BEzmaxinvoicingagentEzsignaccount).Append("\n");
            sb.Append("  BEzmaxinvoicingagentBillableezmax: ").Append(BEzmaxinvoicingagentBillableezmax).Append("\n");
            sb.Append("  EEzmaxinvoicingagentVariationezmax: ").Append(EEzmaxinvoicingagentVariationezmax).Append("\n");
            sb.Append("  BEzmaxinvoicingagentBillableezsign: ").Append(BEzmaxinvoicingagentBillableezsign).Append("\n");
            sb.Append("  EEzmaxinvoicingagentVariationezsign: ").Append(EEzmaxinvoicingagentVariationezsign).Append("\n");
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
            return this.Equals(input as EzmaxinvoicingagentResponse);
        }

        /// <summary>
        /// Returns true if EzmaxinvoicingagentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzmaxinvoicingagentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzmaxinvoicingagentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkiEzmaxinvoicingagentID == input.PkiEzmaxinvoicingagentID ||
                    (this.PkiEzmaxinvoicingagentID != null &&
                    this.PkiEzmaxinvoicingagentID.Equals(input.PkiEzmaxinvoicingagentID))
                ) && 
                (
                    this.FkiEzmaxinvoicingID == input.FkiEzmaxinvoicingID ||
                    (this.FkiEzmaxinvoicingID != null &&
                    this.FkiEzmaxinvoicingID.Equals(input.FkiEzmaxinvoicingID))
                ) && 
                (
                    this.FkiBillingentityinternalID == input.FkiBillingentityinternalID ||
                    (this.FkiBillingentityinternalID != null &&
                    this.FkiBillingentityinternalID.Equals(input.FkiBillingentityinternalID))
                ) && 
                (
                    this.SBillingentityinternalDescriptionX == input.SBillingentityinternalDescriptionX ||
                    (this.SBillingentityinternalDescriptionX != null &&
                    this.SBillingentityinternalDescriptionX.Equals(input.SBillingentityinternalDescriptionX))
                ) && 
                (
                    this.FkiAgentID == input.FkiAgentID ||
                    (this.FkiAgentID != null &&
                    this.FkiAgentID.Equals(input.FkiAgentID))
                ) && 
                (
                    this.FkiBrokerID == input.FkiBrokerID ||
                    (this.FkiBrokerID != null &&
                    this.FkiBrokerID.Equals(input.FkiBrokerID))
                ) && 
                (
                    this.IEzmaxinvoicingagentSession == input.IEzmaxinvoicingagentSession ||
                    (this.IEzmaxinvoicingagentSession != null &&
                    this.IEzmaxinvoicingagentSession.Equals(input.IEzmaxinvoicingagentSession))
                ) && 
                (
                    this.IEzmaxinvoicingagentCloned == input.IEzmaxinvoicingagentCloned ||
                    (this.IEzmaxinvoicingagentCloned != null &&
                    this.IEzmaxinvoicingagentCloned.Equals(input.IEzmaxinvoicingagentCloned))
                ) && 
                (
                    this.IEzmaxinvoicingagentInvoice == input.IEzmaxinvoicingagentInvoice ||
                    (this.IEzmaxinvoicingagentInvoice != null &&
                    this.IEzmaxinvoicingagentInvoice.Equals(input.IEzmaxinvoicingagentInvoice))
                ) && 
                (
                    this.IEzmaxinvoicingagentInscription == input.IEzmaxinvoicingagentInscription ||
                    (this.IEzmaxinvoicingagentInscription != null &&
                    this.IEzmaxinvoicingagentInscription.Equals(input.IEzmaxinvoicingagentInscription))
                ) && 
                (
                    this.IEzmaxinvoicingagentInscriptionactive == input.IEzmaxinvoicingagentInscriptionactive ||
                    (this.IEzmaxinvoicingagentInscriptionactive != null &&
                    this.IEzmaxinvoicingagentInscriptionactive.Equals(input.IEzmaxinvoicingagentInscriptionactive))
                ) && 
                (
                    this.IEzmaxinvoicingagentSale == input.IEzmaxinvoicingagentSale ||
                    (this.IEzmaxinvoicingagentSale != null &&
                    this.IEzmaxinvoicingagentSale.Equals(input.IEzmaxinvoicingagentSale))
                ) && 
                (
                    this.IEzmaxinvoicingagentOtherincome == input.IEzmaxinvoicingagentOtherincome ||
                    (this.IEzmaxinvoicingagentOtherincome != null &&
                    this.IEzmaxinvoicingagentOtherincome.Equals(input.IEzmaxinvoicingagentOtherincome))
                ) && 
                (
                    this.IEzmaxinvoicingagentCommissioncalculation == input.IEzmaxinvoicingagentCommissioncalculation ||
                    (this.IEzmaxinvoicingagentCommissioncalculation != null &&
                    this.IEzmaxinvoicingagentCommissioncalculation.Equals(input.IEzmaxinvoicingagentCommissioncalculation))
                ) && 
                (
                    this.IEzmaxinvoicingagentEzsigndocument == input.IEzmaxinvoicingagentEzsigndocument ||
                    (this.IEzmaxinvoicingagentEzsigndocument != null &&
                    this.IEzmaxinvoicingagentEzsigndocument.Equals(input.IEzmaxinvoicingagentEzsigndocument))
                ) && 
                (
                    this.BEzmaxinvoicingagentEzsignaccount == input.BEzmaxinvoicingagentEzsignaccount ||
                    (this.BEzmaxinvoicingagentEzsignaccount != null &&
                    this.BEzmaxinvoicingagentEzsignaccount.Equals(input.BEzmaxinvoicingagentEzsignaccount))
                ) && 
                (
                    this.BEzmaxinvoicingagentBillableezmax == input.BEzmaxinvoicingagentBillableezmax ||
                    (this.BEzmaxinvoicingagentBillableezmax != null &&
                    this.BEzmaxinvoicingagentBillableezmax.Equals(input.BEzmaxinvoicingagentBillableezmax))
                ) && 
                (
                    this.EEzmaxinvoicingagentVariationezmax == input.EEzmaxinvoicingagentVariationezmax ||
                    (this.EEzmaxinvoicingagentVariationezmax != null &&
                    this.EEzmaxinvoicingagentVariationezmax.Equals(input.EEzmaxinvoicingagentVariationezmax))
                ) && 
                (
                    this.BEzmaxinvoicingagentBillableezsign == input.BEzmaxinvoicingagentBillableezsign ||
                    (this.BEzmaxinvoicingagentBillableezsign != null &&
                    this.BEzmaxinvoicingagentBillableezsign.Equals(input.BEzmaxinvoicingagentBillableezsign))
                ) && 
                (
                    this.EEzmaxinvoicingagentVariationezsign == input.EEzmaxinvoicingagentVariationezsign ||
                    (this.EEzmaxinvoicingagentVariationezsign != null &&
                    this.EEzmaxinvoicingagentVariationezsign.Equals(input.EEzmaxinvoicingagentVariationezsign))
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
                if (this.PkiEzmaxinvoicingagentID != null)
                    hashCode = hashCode * 59 + this.PkiEzmaxinvoicingagentID.GetHashCode();
                if (this.FkiEzmaxinvoicingID != null)
                    hashCode = hashCode * 59 + this.FkiEzmaxinvoicingID.GetHashCode();
                if (this.FkiBillingentityinternalID != null)
                    hashCode = hashCode * 59 + this.FkiBillingentityinternalID.GetHashCode();
                if (this.SBillingentityinternalDescriptionX != null)
                    hashCode = hashCode * 59 + this.SBillingentityinternalDescriptionX.GetHashCode();
                if (this.FkiAgentID != null)
                    hashCode = hashCode * 59 + this.FkiAgentID.GetHashCode();
                if (this.FkiBrokerID != null)
                    hashCode = hashCode * 59 + this.FkiBrokerID.GetHashCode();
                if (this.IEzmaxinvoicingagentSession != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentSession.GetHashCode();
                if (this.IEzmaxinvoicingagentCloned != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentCloned.GetHashCode();
                if (this.IEzmaxinvoicingagentInvoice != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentInvoice.GetHashCode();
                if (this.IEzmaxinvoicingagentInscription != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentInscription.GetHashCode();
                if (this.IEzmaxinvoicingagentInscriptionactive != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentInscriptionactive.GetHashCode();
                if (this.IEzmaxinvoicingagentSale != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentSale.GetHashCode();
                if (this.IEzmaxinvoicingagentOtherincome != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentOtherincome.GetHashCode();
                if (this.IEzmaxinvoicingagentCommissioncalculation != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentCommissioncalculation.GetHashCode();
                if (this.IEzmaxinvoicingagentEzsigndocument != null)
                    hashCode = hashCode * 59 + this.IEzmaxinvoicingagentEzsigndocument.GetHashCode();
                if (this.BEzmaxinvoicingagentEzsignaccount != null)
                    hashCode = hashCode * 59 + this.BEzmaxinvoicingagentEzsignaccount.GetHashCode();
                if (this.BEzmaxinvoicingagentBillableezmax != null)
                    hashCode = hashCode * 59 + this.BEzmaxinvoicingagentBillableezmax.GetHashCode();
                if (this.EEzmaxinvoicingagentVariationezmax != null)
                    hashCode = hashCode * 59 + this.EEzmaxinvoicingagentVariationezmax.GetHashCode();
                if (this.BEzmaxinvoicingagentBillableezsign != null)
                    hashCode = hashCode * 59 + this.BEzmaxinvoicingagentBillableezsign.GetHashCode();
                if (this.EEzmaxinvoicingagentVariationezsign != null)
                    hashCode = hashCode * 59 + this.EEzmaxinvoicingagentVariationezsign.GetHashCode();
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


            // PkiEzmaxinvoicingagentID (int) minimum
            if(this.PkiEzmaxinvoicingagentID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PkiEzmaxinvoicingagentID, must be a value greater than or equal to 0.", new [] { "PkiEzmaxinvoicingagentID" });
            }



            // FkiEzmaxinvoicingID (int) minimum
            if(this.FkiEzmaxinvoicingID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzmaxinvoicingID, must be a value greater than or equal to 0.", new [] { "FkiEzmaxinvoicingID" });
            }



            // FkiBillingentityinternalID (int) minimum
            if(this.FkiBillingentityinternalID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiBillingentityinternalID, must be a value greater than or equal to 0.", new [] { "FkiBillingentityinternalID" });
            }



            // FkiAgentID (int) minimum
            if(this.FkiAgentID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiAgentID, must be a value greater than or equal to 0.", new [] { "FkiAgentID" });
            }



            // FkiBrokerID (int) minimum
            if(this.FkiBrokerID < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiBrokerID, must be a value greater than or equal to 0.", new [] { "FkiBrokerID" });
            }



            // IEzmaxinvoicingagentSession (int) minimum
            if(this.IEzmaxinvoicingagentSession < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentSession, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentSession" });
            }



            // IEzmaxinvoicingagentCloned (int) minimum
            if(this.IEzmaxinvoicingagentCloned < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentCloned, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentCloned" });
            }



            // IEzmaxinvoicingagentInvoice (int) minimum
            if(this.IEzmaxinvoicingagentInvoice < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentInvoice, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentInvoice" });
            }



            // IEzmaxinvoicingagentInscription (int) minimum
            if(this.IEzmaxinvoicingagentInscription < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentInscription, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentInscription" });
            }



            // IEzmaxinvoicingagentInscriptionactive (int) minimum
            if(this.IEzmaxinvoicingagentInscriptionactive < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentInscriptionactive, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentInscriptionactive" });
            }



            // IEzmaxinvoicingagentSale (int) minimum
            if(this.IEzmaxinvoicingagentSale < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentSale, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentSale" });
            }



            // IEzmaxinvoicingagentOtherincome (int) minimum
            if(this.IEzmaxinvoicingagentOtherincome < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentOtherincome, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentOtherincome" });
            }



            // IEzmaxinvoicingagentCommissioncalculation (int) minimum
            if(this.IEzmaxinvoicingagentCommissioncalculation < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentCommissioncalculation, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentCommissioncalculation" });
            }



            // IEzmaxinvoicingagentEzsigndocument (int) minimum
            if(this.IEzmaxinvoicingagentEzsigndocument < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IEzmaxinvoicingagentEzsigndocument, must be a value greater than or equal to 0.", new [] { "IEzmaxinvoicingagentEzsigndocument" });
            }

            yield break;
        }
    }

}