# eZmaxApi.Model.BrandingResponse
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
**EBrandingLogointerface** | **FieldEBrandingLogointerface** |  | [optional] 
**IBrandingColortext** | **int** | The color of the text. This is a RGB color converted into integer | 
**IBrandingColortextlinkbox** | **int** | The color of the text in the link box. This is a RGB color converted into integer | 
**IBrandingColortextbutton** | **int** | The color of the text in the button. This is a RGB color converted into integer | 
**IBrandingColorbackground** | **int** | The color of the background. This is a RGB color converted into integer | 
**IBrandingColorbackgroundbutton** | **int** | The color of the background of the button. This is a RGB color converted into integer | 
**IBrandingColorbackgroundsmallbox** | **int** | The color of the background of the small box. This is a RGB color converted into integer | 
**IBrandingInterfacecolor** | **int** | The color of the interface. This is a RGB color converted into integer | [optional] 
**BBrandingIsactive** | **bool** | Whether the Branding is active or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

