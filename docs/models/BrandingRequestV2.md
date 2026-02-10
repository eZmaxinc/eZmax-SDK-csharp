# eZmaxApi.Model.BrandingRequestV2
A Branding Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjBrandingDescription** | [**MultilingualBrandingDescription**](MultilingualBrandingDescription.md) |  | 
**EBrandingLogo** | **FieldEBrandingLogo** |  | 
**IBrandingColor** | **int** | The primary color. This is a RGB color converted into integer | 
**BBrandingIsactive** | **bool** | Whether the Branding is active or not | 
**PkiBrandingID** | **int** | The unique ID of the Branding | [optional] 
**FkiDomainID** | **int** | The unique ID of the Domain | [optional] 
**EBrandingAlignlogo** | **FieldEBrandingAlignlogo** |  | [optional] 
**SBrandingBase64** | **byte[]** | The Base64 encoded binary content of the branding logo. This need to match image type selected in eBrandingLogo if you supply an image. If you select &#39;Default&#39;, the logo will be deleted and the default one will be used. | [optional] 
**SBrandingName** | **string** | The name of the Branding  This value will only be set if you wish to overwrite the default name. If you want to keep the default name, leave this property empty | [optional] 
**SEmailAddress** | **string** | The email address. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

