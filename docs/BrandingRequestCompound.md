# eZmaxApi.Model.BrandingRequestCompound
A Branding Object and children

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiBrandingID** | **int** | The unique ID of the Branding | [optional] 
**ObjBrandingDescription** | [**MultilingualBrandingDescription**](MultilingualBrandingDescription.md) |  | 
**EBrandingLogo** | **FieldEBrandingLogo** |  | 
**SBrandingBase64** | **byte[]** | The Base64 encoded binary content of the branding logo. This need to match image type selected in eBrandingLogo if you supply an image. If you select &#39;Default&#39;, the logo will be deleted and the default one will be used. | [optional] 
**EBrandingLogointerface** | **FieldEBrandingLogointerface** |  | [optional] 
**SBrandingLogointerfaceBase64** | **byte[]** | The Base64 encoded binary content of the branding logo. This need to match image type selected in eBrandingLogointerface if you supply an image. If you select &#39;Default&#39;, the logo will be deleted and the default one will be used. | [optional] 
**IBrandingColortext** | **int** | The color of the text. This is a RGB color converted into integer | 
**IBrandingColortextlinkbox** | **int** | The color of the text in the link box. This is a RGB color converted into integer | 
**IBrandingColortextbutton** | **int** | The color of the text in the button. This is a RGB color converted into integer | 
**IBrandingColorbackground** | **int** | The color of the background. This is a RGB color converted into integer | 
**IBrandingColorbackgroundbutton** | **int** | The color of the background of the button. This is a RGB color converted into integer | 
**IBrandingColorbackgroundsmallbox** | **int** | The color of the background of the small box. This is a RGB color converted into integer | 
**IBrandingInterfacecolor** | **int** | The color of the interface. This is a RGB color converted into integer | [optional] 
**SBrandingName** | **string** | The name of the Branding  This value will only be set if you wish to overwrite the default name. If you want to keep the default name, leave this property empty | [optional] 
**SEmailAddress** | **string** | The email address. | [optional] 
**BBrandingIsactive** | **bool** | Whether the Branding is active or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

