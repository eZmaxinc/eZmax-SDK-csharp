# eZmaxApi.Model.CustomCommunicationsenderResponse
Generic Communicationsender Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiAgentID** | **int** | The unique ID of the Agent. | [optional] 
**FkiBrokerID** | **int** | The unique ID of the Broker. | [optional] 
**FkiUserID** | **int** | The unique ID of the User | [optional] 
**FkiMailboxsharedID** | **int** | The unique ID of the Mailboxshared | [optional] 
**FkiPhonelinesharedID** | **int** | The unique ID of the Phonelineshared | [optional] 
**ECommunicationsenderObjecttype** | **string** |  | 
**ObjContactName** | [**CustomContactNameResponse**](CustomContactNameResponse.md) |  | 
**ObjEmail** | [**EmailResponse**](EmailResponse.md) | An Email Object and children to create a complete structure | [optional] 
**ObjPhoneFax** | [**PhoneResponseCompound**](PhoneResponseCompound.md) |  | [optional] 
**ObjPhoneSMS** | [**PhoneResponseCompound**](PhoneResponseCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

