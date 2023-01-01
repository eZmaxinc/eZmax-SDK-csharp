
# eZmaxApi.Model.EzmaxinvoicingGetProvisionalV1ResponseMPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzmaxinvoicingID** | **int** | The unique ID of the Ezmaxinvoicing | [optional] 
**FkiEzmaxinvoicingcontractID** | **int** | The unique ID of the Ezmaxinvoicingcontract | 
**FkiEzmaxpricingID** | **int** | The unique ID of the Ezmaxpricing | 
**FkiSystemconfigurationtypeID** | **int** | The unique ID of the Systemconfigurationtype | 
**SSystemconfigurationtypeDescriptionX** | **string** | The description of the Systemconfigurationtype in the language of the requester | 
**YyyymmEzmaxinvoicing** | **string** | The YYYYMM period of the Ezmaxinvoicing | 
**IEzmaxinvoicingDays** | **int** | The number of days invoiced | 
**EEzmaxinvoicingPaymenttype** | **FieldEEzmaxinvoicingPaymenttype** |  | 
**DEzmaxinvoicingRebatepaymenttype** | **string** | The percentage of rebate depending of the payment type | 
**IEzmaxinvoicingContractlength** | **int** | The length of the contract in years | 
**DEzmaxinvoicingRebatecontractlength** | **string** | The percentage of rebate depending of the contract length | 
**BEzmaxinvoicingRebateEzsignallagents** | **bool** | Whether the rebate for eZsign is for all agents | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | [optional] 
**ObjEzmaxinvoicingcontract** | [**EzmaxinvoicingcontractResponseCompound**](EzmaxinvoicingcontractResponseCompound.md) |  | 
**ObjEzmaxpricing** | [**CustomEzmaxpricingResponse**](CustomEzmaxpricingResponse.md) |  | 
**AObjEzmaxinvoicingsummaryglobal** | [**List&lt;EzmaxinvoicingsummaryglobalResponseCompound&gt;**](EzmaxinvoicingsummaryglobalResponseCompound.md) |  | 
**AObjEzmaxinvoicingsummaryexternal** | [**List&lt;EzmaxinvoicingsummaryexternalResponseCompound&gt;**](EzmaxinvoicingsummaryexternalResponseCompound.md) |  | 
**AObjEzmaxinvoicingsummaryinternal** | [**List&lt;EzmaxinvoicingsummaryinternalResponseCompound&gt;**](EzmaxinvoicingsummaryinternalResponseCompound.md) |  | 
**AObjEzmaxinvoicingagent** | [**List&lt;EzmaxinvoicingagentResponseCompound&gt;**](EzmaxinvoicingagentResponseCompound.md) |  | 
**AObjEzmaxinvoicinguser** | [**List&lt;EzmaxinvoicinguserResponseCompound&gt;**](EzmaxinvoicinguserResponseCompound.md) |  | 
**AObjEzmaxinvoicingezsignfolder** | [**List&lt;CustomEzmaxinvoicingEzsignfolderResponse&gt;**](CustomEzmaxinvoicingEzsignfolderResponse.md) |  | 
**AObjEzmaxinvoicingezsigndocument** | [**List&lt;CustomEzmaxinvoicingEzsigndocumentResponse&gt;**](CustomEzmaxinvoicingEzsigndocumentResponse.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

