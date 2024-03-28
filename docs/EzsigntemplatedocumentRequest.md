# eZmaxApi.Model.EzsigntemplatedocumentRequest
A Ezsigntemplatedocument Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplatedocumentID** | **int** | The unique ID of the Ezsigntemplatedocument | [optional] 
**FkiEzsigntemplateID** | **int** | The unique ID of the Ezsigntemplate | 
**FkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | [optional] 
**FkiEzsigntemplatesignerID** | **int** | The unique ID of the Ezsigntemplatesigner | [optional] 
**SEzsigntemplatedocumentName** | **string** | The name of the Ezsigntemplatedocument. | 
**EEzsigntemplatedocumentSource** | **string** | Indicates where to look for the document binary content. | 
**EEzsigntemplatedocumentFormat** | **string** | Indicates the format of the template. | [optional] 
**SEzsigntemplatedocumentBase64** | **byte[]** | The Base64 encoded binary content of the document.  This field is Required when eEzsigntemplatedocumentSource &#x3D; Base64. | [optional] 
**SEzsigntemplatedocumentUrl** | **string** | The url where the document content resides.  This field is Required when eEzsigntemplatedocumentSource &#x3D; Url. | [optional] 
**BEzsigntemplatedocumentForcerepair** | **bool** | Try to repair the document or flatten it if it cannot be used for electronic signature. | [optional] 
**EEzsigntemplatedocumentForm** | **string** | If the document contains an existing PDF form this property must be set.  **Keep** leaves the form as-is in the document.  **Convert** removes the form and convert all the existing fields to Ezsigntemplateformfieldgroups and assign them to the specified **fkiEzsigntemplatesignerID**  **Discard** removes the form from the document | [optional] 
**SEzsigntemplatedocumentPassword** | **string** | If the source template is password protected, the password to open/modify it. | [optional] [default to ""]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

