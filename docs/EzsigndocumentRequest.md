
# eZmaxApi.Model.EzsigndocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EEzsigndocumentSource** | **string** | Indicates where to look for the document binary content. | 
**EEzsigndocumentFormat** | **string** | Indicates the format of the document. | 
**SEzsigndocumentBase64** | **byte[]** | The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64. | [optional] 
**SEzsigndocumentUrl** | **string** | The url where the document content resides.  This field is Required when eEzsigndocumentSource &#x3D; Url. | [optional] 
**BEzsigndocumentForcerepair** | **bool** | Try to repair the document or flatten it if it cannot be used for electronic signature.  | [optional] [default to true]
**SEzsigndocumentPassword** | **string** | If the source document is password protected, the password to open/modify it. | [optional] [default to ""]
**FkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**DtEzsigndocumentDuedate** | **string** | The maximum date and time at which the document can be signed. | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SEzsigndocumentName** | **string** | The name of the document that will be presented to Ezsignfoldersignerassociations | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

