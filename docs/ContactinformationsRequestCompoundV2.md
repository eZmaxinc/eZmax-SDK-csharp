# eZmaxApi.Model.ContactinformationsRequestCompoundV2
A Contactinformations Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EContactinformationsType** | **FieldEContactinformationsType** |  | 
**IAddressDefault** | **int** | The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty. | 
**IPhoneDefault** | **int** | The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty. | 
**IEmailDefault** | **int** | The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty. | 
**IWebsiteDefault** | **int** | The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty. | 
**AObjAddress** | [**List&lt;AddressRequestCompound&gt;**](AddressRequestCompound.md) |  | 
**AObjPhone** | [**List&lt;PhoneRequestCompound&gt;**](PhoneRequestCompound.md) |  | 
**AObjEmail** | [**List&lt;EmailRequestCompound&gt;**](EmailRequestCompound.md) |  | 
**AObjWebsite** | [**List&lt;WebsiteRequestCompound&gt;**](WebsiteRequestCompound.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

