# eZmaxApi.Model.BrandingRequestCompoundV2
A Branding Object and children

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiBrandingID** | **int** | The unique ID of the Branding | [optional] 
**ObjBrandingDescription** | [**MultilingualBrandingDescription**](MultilingualBrandingDescription.md) |  | 
**EBrandingLogo** | **FieldEBrandingLogo** |  | 
**EBrandingAlignlogo** | **FieldEBrandingAlignlogo** |  | [optional] 
**SBrandingBase64** | **byte[]** | The Base64 encoded binary content of the branding logo. This need to match image type selected in eBrandingLogo if you supply an image. If you select &#39;Default&#39;, the logo will be deleted and the default one will be used. | [optional] 
**IBrandingColor** | **int** | The primary color. This is a RGB color converted into integer | 
**SBrandingName** | **string** | The name of the Branding  This value will only be set if you wish to overwrite the default name. If you want to keep the default name, leave this property empty | [optional] 
**SEmailAddress** | **string** | The email address. | [optional] 
**BBrandingIsactive** | **bool** | Whether the Branding is active or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

