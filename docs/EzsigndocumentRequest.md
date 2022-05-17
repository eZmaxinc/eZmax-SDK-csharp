
# eZmaxApi.Model.EzsigndocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | [optional] 
**FkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**FkiEzsigntemplateID** | **int** | The unique ID of the Ezsigntemplate | [optional] 
**FkiEzsignfoldersignerassociationID** | **int** | The unique ID of the Ezsignfoldersignerassociation | [optional] 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**EEzsigndocumentSource** | **string** | Indicates where to look for the document binary content. | 
**EEzsigndocumentFormat** | **string** | Indicates the format of the document. | [optional] 
**SEzsigndocumentBase64** | **byte[]** | The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64. | [optional] 
**SEzsigndocumentUrl** | **string** | The url where the document content resides.  This field is Required when eEzsigndocumentSource &#x3D; Url. | [optional] 
**BEzsigndocumentForcerepair** | **bool** | Try to repair the document or flatten it if it cannot be used for electronic signature.  | [optional] [default to true]
**SEzsigndocumentPassword** | **string** | If the source document is password protected, the password to open/modify it. | [optional] 
**EEzsigndocumentForm** | **string** | If the document contains an existing PDF form this property must be set.  **Keep** leaves the form as-is in the document.  **Convert** removes the form and convert all the existing fields to Ezsignformfieldgroups and assign them to the specified **fkiEzsignfoldersignerassociationID** | [optional] 
**DtEzsigndocumentDuedate** | **string** | The maximum date and time at which the Ezsigndocument can be signed. | 
**SEzsigndocumentName** | **string** | The name of the document that will be presented to Ezsignfoldersignerassociations | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

