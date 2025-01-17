# eZmaxApi.Model.BrandingResponseCompoundV3
A Branding Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiBrandingID** | **int** | The unique ID of the Branding | 
**FkiEmailID** | **int** | The unique ID of the Email | [optional] 
**ObjBrandingDescription** | [**MultilingualBrandingDescription**](MultilingualBrandingDescription.md) |  | 
**SBrandingDescriptionX** | **string** | The Description of the Branding in the language of the requester | 
**SBrandingName** | **string** | The name of the Branding  This value will only be set if you wish to overwrite the default name. If you want to keep the default name, leave this property empty | [optional] 
**SEmailAddress** | **string** | The email address. | [optional] 
**EBrandingLogo** | **FieldEBrandingLogo** |  | 
**EBrandingAlignlogo** | **FieldEBrandingAlignlogo** |  | 
**IBrandingColor** | **int** | The primary color. This is a RGB color converted into integer | 
**BBrandingIsactive** | **bool** | Whether the Branding is active or not | 
**SBrandingLogourl** | **string** | The url of the picture used as logo in the Branding | [optional] 
**SBrandingLogoemailurl** | **string** | The url of the picture used in email as logo in the Branding | [optional] 
**SBrandingLogointerfaceurl** | **string** | The url of the picture used as logo in the Branding | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

