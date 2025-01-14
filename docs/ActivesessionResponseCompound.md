# eZmaxApi.Model.ActivesessionResponseCompound
Payload for GET /1/object/activesession/getCurrent

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
**FkiEzsignuserID** | **int** | The unique ID of the Ezsignuser | [optional] 
**BSystemconfigurationEzsignpaidbyoffice** | **bool** | Whether if Ezsign is paid by the company or not | [optional] 
**ESystemconfigurationEzsignofficeplan** | **FieldESystemconfigurationEzsignofficeplan** |  | [optional] 
**EUserEzsignaccess** | **FieldEUserEzsignaccess** |  | 
**EUserEzsignprepaid** | **FieldEUserEzsignprepaid** |  | [optional] 
**BUserEzsigntrial** | **bool** | Whether the User&#39;s eZsign subscription is a trial | [optional] 
**DtUserEzsignprepaidexpiration** | **string** | The eZsign prepaid expiration date | [optional] 
**APkiPermissionID** | **List&lt;int&gt;** | An array of permissions granted to the user or api key | 
**ObjUserReal** | [**ActivesessionResponseCompoundUser**](ActivesessionResponseCompoundUser.md) |  | 
**ObjUserCloned** | [**ActivesessionResponseCompoundUser**](ActivesessionResponseCompoundUser.md) |  | [optional] 
**ObjApikey** | [**ActivesessionResponseCompoundApikey**](ActivesessionResponseCompoundApikey.md) |  | [optional] 
**AEModuleInternalname** | **List&lt;string&gt;** | An Array of Registered modules.  These are the modules that are Licensed to be used by the User or the API Key. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

