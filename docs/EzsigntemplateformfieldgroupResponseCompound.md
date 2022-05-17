
# eZmaxApi.Model.EzsigntemplateformfieldgroupResponseCompound

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplateformfieldgroupID** | **int** | The unique ID of the Ezsigntemplateformfieldgroup | 
**FkiEzsigntemplatedocumentID** | **int** | The unique ID of the Ezsigntemplatedocument | 
**EEzsigntemplateformfieldgroupType** | [**FieldEEzsigntemplateformfieldgroupType**](FieldEEzsigntemplateformfieldgroupType.md) |  | 
**EEzsigntemplateformfieldgroupSignerrequirement** | [**FieldEEzsigntemplateformfieldgroupSignerrequirement**](FieldEEzsigntemplateformfieldgroupSignerrequirement.md) |  | 
**SEzsigntemplateformfieldgroupLabel** | **string** | The Label for the Ezsigntemplateformfieldgroup | 
**IEzsigntemplateformfieldgroupStep** | **int** | The step when the Ezsigntemplatesigner will be invited to fill the form fields | 
**SEzsigntemplateformfieldgroupDefaultvalue** | **string** | The default value for the Ezsigntemplateformfieldgroup | 
**IEzsigntemplateformfieldgroupFilledmin** | **int** | The minimum number of Ezsigntemplateformfield that must be filled in the Ezsigntemplateformfieldgroup | 
**IEzsigntemplateformfieldgroupFilledmax** | **int** | The maximum number of Ezsigntemplateformfield that must be filled in the Ezsigntemplateformfieldgroup | 
**BEzsigntemplateformfieldgroupReadonly** | **bool** | Whether the Ezsigntemplateformfieldgroup is read only or not. | 
**IEzsigntemplateformfieldgroupMaxlength** | **int** | The maximum length for the value in the Ezsigntemplateformfieldgroup  This can only be set if eEzsigntemplateformfieldgroupType is **Text** or **Textarea** | [optional] 
**BEzsigntemplateformfieldgroupEncrypted** | **bool** | Whether the Ezsigntemplateformfieldgroup is encrypted in the database or not. Encrypted values are not displayed on the Ezsigndocument. This can only be set if eEzsigntemplateformfieldgroupType is **Text** or **Textarea** | [optional] 
**SEzsigntemplateformfieldgroupRegexp** | **string** | A regular expression to indicate what values are acceptable for the Ezsigntemplateformfieldgroup.  This can only be set if eEzsigntemplateformfieldgroupType is **Text** or **Textarea** | [optional] 
**TEzsigntemplateformfieldgroupTooltip** | **string** | A tooltip that will be presented to Ezsigntemplatesigner about the Ezsigntemplateformfieldgroup | [optional] 
**EEzsigntemplateformfieldgroupTooltipposition** | [**FieldEEzsigntemplateformfieldgroupTooltipposition**](FieldEEzsigntemplateformfieldgroupTooltipposition.md) |  | [optional] 
**AObjEzsigntemplateformfieldgroupsigner** | [**List&lt;EzsigntemplateformfieldgroupsignerResponseCompound&gt;**](EzsigntemplateformfieldgroupsignerResponseCompound.md) |  | 
**AObjDropdownElement** | [**List&lt;CustomDropdownElementResponseCompound&gt;**](CustomDropdownElementResponseCompound.md) |  | [optional] 
**AObjEzsigntemplateformfield** | [**List&lt;EzsigntemplateformfieldResponseCompound&gt;**](EzsigntemplateformfieldResponseCompound.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

