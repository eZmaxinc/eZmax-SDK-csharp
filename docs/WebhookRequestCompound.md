# eZmaxApi.Model.WebhookRequestCompound
A Webhook Object and children

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiWebhookID** | **int** | The unique ID of the Webhook | [optional] 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | [optional] 
**SWebhookDescription** | **string** | The description of the Webhook | 
**EWebhookModule** | **FieldEWebhookModule** |  | 
**EWebhookEzsignevent** | **FieldEWebhookEzsignevent** |  | [optional] 
**EWebhookManagementevent** | **FieldEWebhookManagementevent** |  | [optional] 
**SWebhookUrl** | **string** | The URL of the Webhook callback | 
**SWebhookEmailfailed** | **string** | The email that will receive the Webhook in case all attempts fail | 
**BWebhookIsactive** | **bool** | Whether the Webhook is active or not | 
**BWebhookIssigned** | **bool** | Whether the requests will be signed or not | [optional] 
**BWebhookSkipsslvalidation** | **bool** | Wheter the server&#39;s SSL certificate should be validated or not. Not recommended to skip for production use | 
**AObjWebhookheader** | [**List&lt;WebhookheaderRequestCompound&gt;**](WebhookheaderRequestCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

