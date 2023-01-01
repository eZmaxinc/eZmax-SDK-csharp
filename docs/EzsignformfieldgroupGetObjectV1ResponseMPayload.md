
# eZmaxApi.Model.EzsignformfieldgroupGetObjectV1ResponseMPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignformfieldgroupID** | **int** | The unique ID of the Ezsignformfieldgroup | 
**FkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | 
**EEzsignformfieldgroupType** | **FieldEEzsignformfieldgroupType** |  | 
**EEzsignformfieldgroupSignerrequirement** | **FieldEEzsignformfieldgroupSignerrequirement** |  | 
**SEzsignformfieldgroupLabel** | **string** | The Label for the Ezsignformfieldgroup | 
**IEzsignformfieldgroupStep** | **int** | The step when the Ezsignsigner will be invited to fill the form fields | 
**SEzsignformfieldgroupDefaultvalue** | **string** | The default value for the Ezsignformfieldgroup | [optional] 
**IEzsignformfieldgroupFilledmin** | **int** | The minimum number of Ezsignformfield that must be filled in the Ezsignformfieldgroup | 
**IEzsignformfieldgroupFilledmax** | **int** | The maximum number of Ezsignformfield that must be filled in the Ezsignformfieldgroup | 
**BEzsignformfieldgroupReadonly** | **bool** | Whether the Ezsignformfieldgroup is read only or not. | 
**IEzsignformfieldgroupMaxlength** | **int** | The maximum length for the value in the Ezsignformfieldgroup  This can only be set if eEzsignformfieldgroupType is **Text** or **Textarea** | [optional] 
**BEzsignformfieldgroupEncrypted** | **bool** | Whether the Ezsignformfieldgroup is encrypted in the database or not. Encrypted values are not displayed on the Ezsigndocument. This can only be set if eEzsignformfieldgroupType is **Text** or **Textarea** | [optional] 
**SEzsignformfieldgroupRegexp** | **string** | A regular expression to indicate what values are acceptable for the Ezsignformfieldgroup.  This can only be set if eEzsignformfieldgroupType is **Text** or **Textarea** | [optional] 
**TEzsignformfieldgroupTooltip** | **string** | A tooltip that will be presented to Ezsignsigner about the Ezsignformfieldgroup | [optional] 
**EEzsignformfieldgroupTooltipposition** | **FieldEEzsignformfieldgroupTooltipposition** |  | [optional] 
**AObjEzsignformfield** | [**List&lt;EzsignformfieldResponseCompound&gt;**](EzsignformfieldResponseCompound.md) |  | 
**AObjDropdownElement** | [**List&lt;CustomDropdownElementResponseCompound&gt;**](CustomDropdownElementResponseCompound.md) |  | [optional] 
**AObjEzsignformfieldgroupsigner** | [**List&lt;EzsignformfieldgroupsignerResponseCompound&gt;**](EzsignformfieldgroupsignerResponseCompound.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

