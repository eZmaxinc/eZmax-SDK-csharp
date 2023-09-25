# eZmaxApi.Model.EzsignfoldersignerassociationGetObjectV1ResponseMPayload
Payload for GET /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfoldersignerassociationID** | **int** | The unique ID of the Ezsignfoldersignerassociation | 
**FkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**BEzsignfoldersignerassociationDelayedsend** | **bool** | If this flag is true the signatory is part of a delayed send. | 
**BEzsignfoldersignerassociationReceivecopy** | **bool** | If this flag is true. The signatory will receive a copy of every signed Ezsigndocument even if it ain&#39;t required to sign the document. | 
**TEzsignfoldersignerassociationMessage** | **string** | A custom text message that will be added to the email sent. | 
**ObjEzsignsignergroup** | [**EzsignsignergroupResponseCompound**](EzsignsignergroupResponseCompound.md) |  | [optional] 
**ObjUser** | [**EzsignfoldersignerassociationResponseCompoundUser**](EzsignfoldersignerassociationResponseCompoundUser.md) |  | [optional] 
**ObjEzsignsigner** | [**EzsignsignerResponseCompound**](EzsignsignerResponseCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

