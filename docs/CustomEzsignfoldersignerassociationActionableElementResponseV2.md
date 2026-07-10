# eZmaxApi.Model.CustomEzsignfoldersignerassociationActionableElementResponseV2
A Ezsignfoldersignerassociation Object with actionable elements

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfoldersignerassociationID** | **int** | The unique ID of the Ezsignfoldersignerassociation | 
**FkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**BEzsignfoldersignerassociationDelayedsend** | **bool** | If this flag is true the signatory is part of a delayed send. | 
**EEzsignfoldersignerassociationRole** | **FieldEEzsignfoldersignerassociationRole** |  | 
**TEzsignfoldersignerassociationMessage** | **string** | A custom text message that will be added to the email sent. | 
**BEzsignfoldersignerassociationAllowsigninginperson** | **bool** | If the Ezsignfoldersignerassociation is allowed to sign in person or not | 
**ObjEzsignsignergroup** | [**EzsignsignergroupResponseCompound**](EzsignsignergroupResponseCompound.md) |  | [optional] 
**ObjUser** | [**EzsignfoldersignerassociationResponseCompoundUser**](EzsignfoldersignerassociationResponseCompoundUser.md) |  | [optional] 
**ObjEzsignsigner** | [**EzsignsignerResponseCompound**](EzsignsignerResponseCompound.md) |  | [optional] 
**BEzsignfoldersignerassociationHasactionableelementsCurrent** | **bool** | Indicates if the Ezsignfoldersignerassociation has actionable elements in the current step | 
**BEzsignfoldersignerassociationHasactionableelementsFuture** | **bool** | Indicates if the Ezsignfoldersignerassociation has actionable elements in a future step | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

