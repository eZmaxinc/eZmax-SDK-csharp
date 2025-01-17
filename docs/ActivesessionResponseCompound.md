# eZmaxApi.Model.ActivesessionResponseCompound
Payload for GET /1/object/activesession/getCurrent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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

