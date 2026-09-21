# eZmaxApi.Model.AttachmentValidateV1Request
Request for POST /1/object/attachment/{pkiAttachmentID}/validate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiAttachmentrejectreasonID** | **int** | The unique ID of the Attachmentrejectreason | [optional] 
**EAttachmentVerified** | **FieldEAttachmentVerified** |  | 
**TAttachmentRejectioncomment** | **string** | The rejectioncomment of the Attachment | [optional] 
**ASNotificationEmailAddress** | **List&lt;string&gt;** | A list of email addresses to send a rejection notification to. | [optional] 
**TNotificationMessage** | **string** | The email body to send to the notification recipients. | [optional] 
**BNotificationIncludeAttachment** | **bool** | Should a copy of the attachment be included in the email. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

