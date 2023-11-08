# eZmaxApi.Model.CustomWebhookResponse
A custom Webhook object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiWebhookID** | **int** | The unique ID of the Webhook | 
**SWebhookDescription** | **string** | The description of the Webhook | 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | [optional] 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | [optional] 
**EWebhookModule** | **FieldEWebhookModule** |  | 
**EWebhookEzsignevent** | **FieldEWebhookEzsignevent** |  | [optional] 
**EWebhookManagementevent** | **FieldEWebhookManagementevent** |  | [optional] 
**SWebhookUrl** | **string** | The URL of the Webhook callback | 
**SWebhookEmailfailed** | **string** | The email that will receive the Webhook in case all attempts fail | 
**BWebhookIsactive** | **bool** | Whether the Webhook is active or not | 
**BWebhookSkipsslvalidation** | **bool** | Wheter the server&#39;s SSL certificate should be validated or not. Not recommended to skip for production use | 
**PksCustomerCode** | **string** | The customer code assigned to your account | 
**BWebhookTest** | **bool** | Wheter the webhook received is a manual test or a real event | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

