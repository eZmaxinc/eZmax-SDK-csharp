# eZmaxApi.Model.EzsigntemplateglobalResponseCompound
A Ezsigntemplateglobal Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplateglobalID** | **int** | The unique ID of the Ezsigntemplateglobal | 
**FkiEzsigntemplateglobaldocumentID** | **int** | The unique ID of the Ezsigntemplateglobaldocument | 
**FkiModuleID** | **int** | The unique ID of the Module | 
**SModuleNameX** | **string** | The Name of the Module in the language of the requester | [optional] 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SLanguageNameX** | **string** | The Name of the Language in the language of the requester | 
**EEzsigntemplateglobalModule** | **FieldEEzsigntemplateglobalModule** |  | 
**EEzsigntemplateglobalSupplier** | **FieldEEzsigntemplateglobalSupplier** |  | 
**SEzsigntemplateglobalCode** | **string** | The Code of the Ezsigntemplateglobal | 
**SEzsigntemplateglobalDescription** | **string** | The description of the Ezsigntemplate | 
**ObjEzsigntemplateglobaldocument** | [**EzsigntemplateglobaldocumentResponse**](EzsigntemplateglobaldocumentResponse.md) |  | [optional] 
**AObjEzsigntemplateglobalsigner** | [**List&lt;EzsigntemplateglobalsignerResponseCompound&gt;**](EzsigntemplateglobalsignerResponseCompound.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

