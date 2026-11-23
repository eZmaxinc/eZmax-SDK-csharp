# eZmaxApi.Model.WebhookEzmaxpartnerproductSubscribe
This is the base Webhook object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjWebhook** | [**CustomWebhookResponse**](CustomWebhookResponse.md) |  | 
**AObjAttempt** | [**List&lt;AttemptResponseCompound&gt;**](AttemptResponseCompound.md) | An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt. | 
**ObjEzmaxpartnerproduct** | [**CustomEzmaxpartnerproductSubscribe**](CustomEzmaxpartnerproductSubscribe.md) |  | 
**SExternalID** | **string** |  | [optional] 
**SApikeyApikey** | **string** | The Apikey for the API key.  This will be hidden if we are not creating or regenerating the Apikey. | 
**SApikeySecret** | **string** | The secret of the Apikey | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

