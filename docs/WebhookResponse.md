
# eZmaxApi.Model.WebhookResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PksCustomerCode** | **string** | The customer code assigned to your account | 
**PkiWebhookID** | **int** | The Webhook ID. This value is visible in the admin interface. | 
**EWebhookModule** | **string** | The Module generating the Event. | 
**EWebhookEzsignevent** | **string** | This Ezsign Event. This property will be set only if the Module is \&quot;Ezsign\&quot;. | [optional] 
**EWebhookManagementevent** | **string** | This Management Event. This property will be set only if the Module is \&quot;Management\&quot;. | [optional] 
**SWebhookUrl** | **string** | The url being called | 
**BWebhookTest** | **bool** | Wheter the webhook received is a manual test or a real event | 
**BWebhookSkipsslvalidation** | **bool** | Wheter the server&#39;s SSL certificate should be validated or not. Not recommended for production use. | 
**SWebhookEmailfailed** | **string** | The email that will receive the webhook in case all attempts fail. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

