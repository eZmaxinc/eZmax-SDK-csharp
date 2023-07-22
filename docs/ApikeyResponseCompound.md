
# eZmaxApi.Model.ApikeyResponseCompound

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiApikeyID** | **int** | The unique ID of the Apikey | 
**FkiUserID** | **int** | The unique ID of the User | 
**ObjApikeyDescription** | [**MultilingualApikeyDescription**](MultilingualApikeyDescription.md) |  | 
**SComputedToken** | **string** | The secret token for the API key.  This will be returned only on creation. | [optional] 
**BApikeyIsactive** | **bool** | Whether the apikey is active or not | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

