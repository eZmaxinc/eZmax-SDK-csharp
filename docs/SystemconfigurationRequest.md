# eZmaxApi.Model.SystemconfigurationRequest
A Systemconfiguration Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiSystemconfigurationID** | **int** | The unique ID of the Systemconfiguration | [optional] 
**FkiBrandingID** | **int** | The unique ID of the Branding | [optional] 
**ESystemconfigurationNewexternaluseraction** | **FieldESystemconfigurationNewexternaluseraction** |  | 
**ESystemconfigurationLanguage1** | **FieldESystemconfigurationLanguage1** |  | 
**ESystemconfigurationLanguage2** | **FieldESystemconfigurationLanguage2** |  | 
**ESystemconfigurationEzsign** | **FieldESystemconfigurationEzsign** |  | [optional] 
**ESystemconfigurationEzsignofficeplan** | **FieldESystemconfigurationEzsignofficeplan** |  | [optional] 
**BSystemconfigurationEzsignpaidbyoffice** | **bool** | Whether if Ezsign is paid by the company or not | [optional] 
**BSystemconfigurationEzsignpersonnal** | **bool** | Whether if we allow the creation of personal files in eZsign | 
**BSystemconfigurationSspr** | **bool** | Whether if we allow SSPR | 
**DtSystemconfigurationReadonlyexpirationstart** | **string** | The start date where the system will be in read only | [optional] 
**DtSystemconfigurationReadonlyexpirationend** | **string** | The end date where the system will be in read only | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

