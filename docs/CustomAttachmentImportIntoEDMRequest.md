# eZmaxApi.Model.CustomAttachmentImportIntoEDMRequest
A AttachmentImportIntoEDM object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EAttachmentSource** | **string** | The source of the Attachment | 
**FkiAttachmentID** | **int** | The unique ID of the Attachment. | [optional] 
**FkiInscriptionchecklistID** | **int** | The unique ID of the Inscriptionchecklist | [optional] 
**SAttachmentUrl** | **string** | The url of the file to import | [optional] 
**SAttachmentBase64** | **byte[]** | The Base64 encoded binary content of the attachment. | [optional] 
**SAttachmentName** | **string** | The name of the Attachment | 
**SAttachmentCategory** | **string** | The attachment category | 
**EAttachmentPrivacy** | **FieldEAttachmentPrivacy** |  | 
**FkiUserIDSpecific** | **int** | The unique ID of the User | [optional] 
**SAttachmentMD5** | **string** | The MD5 of the Attachment | [optional] 
**BAttachmentForceoverwrite** | **bool** | Whether we force an overwrite of an existing file | [optional] 
**BAttachmentForcerestore** | **bool** | Whether we force a restore of a deleted file | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

