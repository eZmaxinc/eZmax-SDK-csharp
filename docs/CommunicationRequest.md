# eZmaxApi.Model.CommunicationRequest
Request for POST /1/object/communication

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiCommunicationID** | **int** | The unique ID of the Communication. | [optional] 
**ECommunicationImportance** | **FieldECommunicationImportance** |  | [optional] 
**ECommunicationType** | **FieldECommunicationType** |  | 
**ObjCommunicationsender** | [**CustomCommunicationsenderRequest**](CustomCommunicationsenderRequest.md) |  | [optional] 
**SCommunicationSubject** | **string** | The subject of the Communication | [optional] 
**TCommunicationBody** | **string** | The Body of the Communication | 
**BCommunicationPrivate** | **bool** | Whether the Communication is private or not | 
**ECommunicationAttachmenttype** | **string** | How the attachment should be included in the email.   Only used if eCommunicationType is **Email** | [optional] 
**ICommunicationAttachmentlinkexpiration** | **int** | The number of days before the attachment link expired.   Only used if eCommunicationType is **Email** and eCommunicationattachmentType is **Link** | [optional] 
**BCommunicationReadreceipt** | **bool** | Whether we ask for a read receipt or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

