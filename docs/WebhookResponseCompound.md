# eZmaxApi.Model.WebhookResponseCompound
A Webhook Object

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
**SWebhookApikey** | **string** | The Apikey for the Webhook.  This will be hidden if we are not creating or regenerating the Apikey. | [optional] 
**SWebhookSecret** | **string** | The Secret for the Webhook.  This will be hidden if we are not creating or regenerating the Apikey. | [optional] 
**BWebhookIsactive** | **bool** | Whether the Webhook is active or not | 
**BWebhookIssigned** | **bool** | Whether the requests will be signed or not | 
**BWebhookSkipsslvalidation** | **bool** | Wheter the server&#39;s SSL certificate should be validated or not. Not recommended to skip for production use | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 
**SWebhookEvent** | **string** | The concatenated string to describe the Webhook event | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

