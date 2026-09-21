# eZmaxApi.Model.InvoiceListElement
A Invoice List Element

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiInvoiceID** | **int** | The unique ID of the Invoice. | 
**FkiAgentID** | **int** | The unique ID of the Agent. | [optional] 
**FkiBrokerID** | **int** | The unique ID of the Broker. | [optional] 
**FkiCustomerID** | **int** | The unique ID of the Customer. | [optional] 
**FkiPeriodID** | **int** | The unique ID of the Period | 
**SPeriodYYYYMM** | **string** | The YYYYMM of the Period | [optional] 
**BInvoiceIspaid** | **bool** | Whether if it&#39;s an ispaid | 
**DInvoiceTotal** | **string** | The total of the Invoice | 
**DInvoicePaid** | **string** | The paid of the Invoice | 
**DInvoiceBalance** | **string** | The balance of the Invoice | [optional] 
**DtInvoiceDate** | **string** | The date of the Invoice | 
**EInvoiceType** | **FieldEInvoiceType** |  | 
**SInvoiceNumber** | **string** | The number of Invoice | [optional] 
**SInvoiceRecipient** | **string** | The recipient of Invoice | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

