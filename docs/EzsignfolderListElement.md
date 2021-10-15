
# eZmaxApi.Model.EzsignfolderListElement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | 
**SEzsignfolderDescription** | **string** | The description of the Ezsign Folder | 
**EEzsignfolderStep** | [**FieldEEzsignfolderStep**](FieldEEzsignfolderStep.md) |  | 
**DtCreatedDate** | **string** | The date and time at which the object was created | 
**DtEzsignfolderSentdate** | [**OneOfstringnull**](OneOfstringnull.md) |  | 
**DtDueDate** | [**OneOfstringnull**](OneOfstringnull.md) | The date at which no more signature will be accepted on the folder | 
**ITotalDocument** | **int** | The total number of Ezsigndocument in the folder | 
**ITotalDocumentEdm** | **int** | The total number of Ezsigndocument in the folder that were saved in the edm system | 
**ITotalSignature** | **int** | The total number of signature blocks in all Ezsigndocuments in the folder | 
**ITotalSignatureSigned** | **int** | The total number of already signed signature blocks in all Ezsigndocuments in the folder | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

