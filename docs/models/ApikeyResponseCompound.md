# eZmaxApi.Model.ApikeyResponseCompound
An Apikey Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiApikeyID** | **int** | The unique ID of the Apikey | 
**FkiUserID** | **int** | The unique ID of the User | 
**ObjApikeyDescription** | [**MultilingualApikeyDescription**](MultilingualApikeyDescription.md) |  | 
**ObjContactName** | [**CustomContactNameResponse**](CustomContactNameResponse.md) |  | 
**BApikeyIsactive** | **bool** | Whether the apikey is active or not | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 
**SApikeyApikey** | **string** | The Apikey for the API key.  This will be hidden if we are not creating or regenerating the Apikey. | [optional] 
**SApikeySecret** | **string** | The Secret for the API key.  This will be hidden if we are not creating or regenerating the Apikey. | [optional] 
**BApikeyIssigned** | **bool** | Whether the apikey is signed or not | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

