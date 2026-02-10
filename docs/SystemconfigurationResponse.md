# eZmaxApi.Model.SystemconfigurationResponse
A Systemconfiguration Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiSystemconfigurationID** | **int** | The unique ID of the Systemconfiguration | 
**FkiSystemconfigurationtypeID** | **int** | The unique ID of the Systemconfigurationtype | 
**FkiBrandingID** | **int** | The unique ID of the Branding | [optional] 
**FkiTimezoneIDDefault** | **int** | The unique ID of the Timezone | 
**STimezoneNameDefault** | **string** | The description of the Timezone | 
**SSystemconfigurationtypeDescriptionX** | **string** | The description of the Systemconfigurationtype in the language of the requester | 
**ESystemconfigurationNewexternaluseraction** | **FieldESystemconfigurationNewexternaluseraction** |  | 
**ESystemconfigurationLanguage1** | **FieldESystemconfigurationLanguage1** |  | 
**ESystemconfigurationLanguage2** | **FieldESystemconfigurationLanguage2** |  | 
**ESystemconfigurationEzsign** | **FieldESystemconfigurationEzsign** |  | [optional] 
**ESystemconfigurationEzsignofficeplan** | **FieldESystemconfigurationEzsignofficeplan** |  | [optional] 
**BSystemconfigurationEzsignpaidbyoffice** | **bool** | Whether if Ezsign is paid by the company or not | [optional] 
**BSystemconfigurationEzsignpersonnal** | **bool** | Whether if we allow the creation of personal files in eZsign | 
**BSystemconfigurationHascreditcardmerchant** | **bool** | Whether there is a creditcard merchant configured or not | [optional] 
**BSystemconfigurationIsdisposalactive** | **bool** | Whether is Disposal processus is active or not | [optional] 
**BSystemconfigurationAllowcomplexcreditcardsignature** | **bool** | Whether is the system allows to have a complex creditcard signature | [optional] 
**BSystemconfigurationSspr** | **bool** | Whether if we allow SSPR | 
**DtSystemconfigurationReadonlyexpirationstart** | **string** | The start date where the system will be in read only | [optional] 
**DtSystemconfigurationReadonlyexpirationend** | **string** | The end date where the system will be in read only | [optional] 
**ObjBranding** | [**CustomBrandingResponse**](CustomBrandingResponse.md) |  | [optional] 
**ISystemconfigurationEzsignreminderhoursend** | **int** | The hour we will send the eZsign reminders | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

