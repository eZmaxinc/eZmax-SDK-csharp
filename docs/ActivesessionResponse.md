# eZmaxApi.Model.ActivesessionResponse
An Activesession Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EActivesessionUsertype** | **FieldEActivesessionUsertype** |  | 
**EActivesessionOrigin** | **FieldEActivesessionOrigin** |  | 
**EActivesessionWeekdaystart** | **FieldEActivesessionWeekdaystart** |  | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SCompanyNameX** | **string** | The Name of the Company in the language of the requester | 
**SDepartmentNameX** | **string** | The Name of the Department in the language of the requester | 
**BActivesessionDebug** | **bool** | Whether the active session is in debug or not | 
**BActivesessionIssuperadmin** | **bool** | Whether the active session is superadmin or not | 
**BActivesessionAttachment** | **bool** | Can access attachment when we clone a user | [optional] 
**BActivesessionCanafe** | **bool** | Can access canafe when we clone a user | [optional] 
**BActivesessionFinancial** | **bool** | Can access financial element when we clone a user | [optional] 
**BActivesessionRealestatecompleted** | **bool** | Can access closed realestate folders when we clone a user | [optional] 
**EActivesessionEzsign** | **FieldEActivesessionEzsign** |  | [optional] 
**EActivesessionEzsignaccess** | **FieldEActivesessionEzsignaccess** |  | 
**EActivesessionEzsignprepaid** | **FieldEActivesessionEzsignprepaid** |  | [optional] 
**EActivesessionRealestateinprogress** | **FieldEActivesessionRealestateinprogress** |  | [optional] 
**PksCustomerCode** | **string** | The customer code assigned to your account | 
**FkiSystemconfigurationtypeID** | **int** | The unique ID of the Systemconfigurationtype | 
**FkiSignatureID** | **int** | The unique ID of the Signature | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

