
# eZmaxApi.Model.ApikeyResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiApikeyID** | **int** | The unique ID of the Apikey | 
**FkiUserID** | **int** | The unique ID of the User | 
**ObjApikeyDescription** | [**MultilingualApikeyDescription**](MultilingualApikeyDescription.md) |  | 
**ObjContactName** | [**CustomContactNameResponse**](CustomContactNameResponse.md) |  | 
**SApikeyApikey** | **string** | The Apikey for the API key.  This will be hidden if we are not creating or regenerating the Apikey. | [optional] 
**SApikeySecret** | **string** | The Secret for the API key.  This will be hidden if we are not creating or regenerating the Apikey. | [optional] 
**BApikeyIsactive** | **bool** | Whether the apikey is active or not | 
**BApikeyIssigned** | **bool** | Whether the apikey is signed or not | [optional] 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

