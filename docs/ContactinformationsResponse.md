# eZmaxApi.Model.ContactinformationsResponse
A Contactinformations Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiContactinformationsID** | **int** | The unique ID of the Contactinformations | 
**FkiAddressIDDefault** | **int** | The unique ID of the Address | [optional] 
**FkiPhoneIDDefault** | **int** | The unique ID of the Phone. | [optional] 
**FkiEmailIDDefault** | **int** | The unique ID of the Email | [optional] 
**FkiWebsiteIDDefault** | **int** | The unique ID of the Website Default | [optional] 
**EContactinformationsType** | **FieldEContactinformationsType** |  | 
**SContactinformationsUrl** | **string** | The url of the Contactinformations | [optional] 
**ObjAddressDefault** | [**AddressResponse**](AddressResponse.md) | An Address Object and children to create a complete structure | [optional] 
**ObjPhoneDefault** | [**PhoneResponseCompound**](PhoneResponseCompound.md) |  | [optional] 
**ObjEmailDefault** | [**EmailResponse**](EmailResponse.md) | An Email Object and children to create a complete structure | [optional] 
**ObjWebsiteDefault** | [**WebsiteResponse**](WebsiteResponse.md) | A Website Object and children to create a complete structure | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

