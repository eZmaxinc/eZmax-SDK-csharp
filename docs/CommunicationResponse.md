# eZmaxApi.Model.CommunicationResponse
A Communication Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiCommunicationID** | **int** | The unique ID of the Communication. | 
**ECommunicationImportance** | **FieldECommunicationImportance** |  | 
**ECommunicationType** | **FieldECommunicationType** |  | 
**SCommunicationSubject** | **string** | The subject of the Communication | 
**SCommunicationBodyurl** | **string** | The url of the body used as body in the Communication | [optional] 
**ECommunicationDirection** | **ComputedECommunicationDirection** |  | 
**ICommunicationrecipientCount** | **int** | The count of Communicationrecipient | 
**BCommunicationPrivate** | **bool** | Whether the Communication is private or not | 
**ObjDescriptionstaticSender** | [**DescriptionstaticResponse**](DescriptionstaticResponse.md) |  | [optional] 
**ObjEmailstaticSender** | [**EmailstaticResponse**](EmailstaticResponse.md) |  | [optional] 
**ObjPhonestaticSender** | [**PhonestaticResponse**](PhonestaticResponse.md) |  | [optional] 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

