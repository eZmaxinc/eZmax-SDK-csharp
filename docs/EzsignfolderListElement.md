# eZmaxApi.Model.EzsignfolderListElement
An Ezsignfolder List Element

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | 
**EEzsignfoldertypePrivacylevel** | **FieldEEzsignfoldertypePrivacylevel** |  | 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | 
**SEzsignfolderDescription** | **string** | The description of the Ezsignfolder | 
**EEzsignfolderStep** | **FieldEEzsignfolderStep** |  | 
**DtCreatedDate** | **string** | The date and time at which the object was created | 
**DtEzsignfolderDelayedsenddate** | **string** | The date and time at which the Ezsignfolder will be sent in the future. | [optional] 
**DtEzsignfolderSentdate** | **string** | The date and time at which the Ezsignfolder was sent the last time. | [optional] 
**DtEzsignfolderDuedate** | **string** | The maximum date and time at which the Ezsignfolder can be signed. | [optional] 
**IEzsigndocument** | **int** | The total number of Ezsigndocument in the folder | 
**IEzsigndocumentEdm** | **int** | The total number of Ezsigndocument in the folder that were saved in the edm system | 
**IEzsignsignature** | **int** | The total number of signature blocks in all Ezsigndocuments in the folder | 
**IEzsignsignatureSigned** | **int** | The total number of already signed signature blocks in all Ezsigndocuments in the folder | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

