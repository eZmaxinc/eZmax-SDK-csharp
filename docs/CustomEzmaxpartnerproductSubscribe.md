# eZmaxApi.Model.CustomEzmaxpartnerproductSubscribe
Request for POST /1/webhookdocumentation/subscribe

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PksEzmaxcustomerCode** | **string** | The Ezmaxcustomer code | 
**SInfrastructureenvironmenttypeDescription** | **string** | The environment type Description | 
**SCompanyName1** | **string** | The Name of the Company in French | 
**SCompanyName2** | **string** | The Name of the Company in English | 
**FkiSystemconfigurationtypeID** | **int** | The unique ID of the Systemconfigurationtype | 
**SSystemconfigurationtypeDescription1** | **string** | The description of the Systemconfigurationtype in the language of the requester | 
**SSystemconfigurationtypeDescription2** | **string** | The description of the Systemconfigurationtype in the language of the requester | 
**FkiEzmaxpartnerID** | **int** | The unique ID of the Ezmaxpartner | 
**SEzmaxpartnerName1** | **string** | The name of the Ezmaxpartner in french | 
**SEzmaxpartnerName2** | **string** | The name of the Ezmaxpartner in english | 
**FkiEzmaxpartnerproductID** | **int** | The unique ID of the Ezmaxpartnerproduct | 
**SEzmaxpartnerproductName1** | **string** | The name1 of the Ezmaxpartnerproduct | 
**SEzmaxpartnerproductName2** | **string** | The name2 of the Ezmaxpartnerproduct | 
**FkiEzmaxpartnerproductstageID** | **int** | The unique ID of the Ezmaxpartnerproductstage | 
**SEzmaxpartnerproductstageCode** | **string** | The code of the sEzmaxpartnerproductstage | 
**SUserLoginName** | **string** | The login name of the User. | 
**SUserFirstName** | **string** | The first name of the user | 
**SUserLastName** | **string** | The last name of the user | 
**FkiUserID** | **int** | The unique ID of the User | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**ObjAddress** | [**AddressRequestCompound**](AddressRequestCompound.md) |  | [optional] 
**Objphone** | [**PhoneRequestCompoundV2**](PhoneRequestCompoundV2.md) |  | [optional] 
**ObjEmail** | [**EmailRequestCompound**](EmailRequestCompound.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

