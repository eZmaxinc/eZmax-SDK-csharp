# eZmaxApi.Model.EzsignsignatureSignV1Request
Request for POST /1/object/ezsignsignature/{pkiEzsignsignatureID}/sign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiEzsignsigningreasonID** | **int** | The unique ID of the Ezsignsigningreason | [optional] 
**FkiFontID** | **int** | The unique ID of the Font | [optional] 
**SValue** | **string** | The value required for the Ezsignsignature.  This can only be set if eEzsignsignatureType is **City**, **FieldText** or **FieldTextarea** | [optional] 
**EAttachmentsConfirmationDecision** | **string** | Whether the attachment are accepted or refused.  This can only be set if eEzsignsignatureType is **AttachmentsConfirmation** | [optional] 
**SAttachmentsRefusalReason** | **string** | The reason of refused.  This can only be set if eEzsignsignatureType is **AttachmentsConfirmation** | [optional] 
**SSvg** | **string** | The SVG of the signature.  This can only be set if eEzsignsignatureType is **Signature**_/_**Initials** and **bIsAutomatic** is false | [optional] 
**AObjFile** | [**List&lt;CommonFile&gt;**](CommonFile.md) |  | [optional] 
**BIsAutomatic** | **bool** | Indicates if the Ezsignsignature was part of an automatic process or not.  This can only be true if eEzsignsignatureType is **Acknowledgement**, **City**, **Signature**, **Initials** or **Stamp**.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

