# eZmaxApi.Model.CustomEzmaxpartnerproductSubscribe
Request for POST /1/webhookdocumentation/subscribe

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PksEzmaxcustomerCode** | **string** | The Ezmaxcustomer code | [optional] 
**SInfrastructureenvironmenttypeDescription** | **string** | The environment type Description | [optional] 
**SCompanyName1** | **string** | The Name of the Company in French | [optional] 
**SCompanyName2** | **string** | The Name of the Company in English | [optional] 
**FkiSystemconfigurationtypeID** | **int** | The unique ID of the Systemconfigurationtype | [optional] 
**SSystemconfigurationtypeDescription1** | **string** | The description of the Systemconfigurationtype in the language of the requester | [optional] 
**SSystemconfigurationtypeDescription2** | **string** | The description of the Systemconfigurationtype in the language of the requester | [optional] 
**FkiEzmaxpartnerID** | **int** | The unique ID of the Ezmaxpartner | [optional] 
**SEzmaxpartnerName1** | **string** | The name of the Ezmaxpartner in french | [optional] 
**SEzmaxpartnerName2** | **string** | The name of the Ezmaxpartner in english | [optional] 
**FkiEzmaxpartnerproductID** | **int** | The unique ID of the Ezmaxpartnerproduct | [optional] 
**SEzmaxpartnerproductName1** | **string** | The name1 of the Ezmaxpartnerproduct | [optional] 
**SEzmaxpartnerproductName2** | **string** | The name2 of the Ezmaxpartnerproduct | [optional] 
**FkiEzmaxpartnerproductstageID** | **int** | The unique ID of the Ezmaxpartnerproductstage | [optional] 
**SEzmaxpartnerproductstageCode** | **string** | The code of the sEzmaxpartnerproductstage | [optional] 
**SUserLoginName** | **string** | The login name of the User. | [optional] 
**SUserFirstName** | **string** | The first name of the user | [optional] 
**SUserLastName** | **string** | The last name of the user | [optional] 
**FkiUserID** | **int** | The unique ID of the User | [optional] 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | [optional] 
**ObjAddress** | [**AddressRequestCompound**](AddressRequestCompound.md) |  | [optional] 
**Objphone** | [**PhoneRequestCompoundV2**](PhoneRequestCompoundV2.md) |  | [optional] 
**ObjEmail** | [**EmailRequestCompound**](EmailRequestCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

