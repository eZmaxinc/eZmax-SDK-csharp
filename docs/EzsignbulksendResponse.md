# eZmaxApi.Model.EzsignbulksendResponse
An Ezsignbulksend Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignbulksendID** | **int** | The unique ID of the Ezsignbulksend | 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SLanguageNameX** | **string** | The Name of the Language in the language of the requester | 
**EEzsignfoldertypePrivacylevel** | **FieldEEzsignfoldertypePrivacylevel** |  | 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | 
**SEzsignbulksendDescription** | **string** | The description of the Ezsignbulksend | 
**TEzsignbulksendNote** | **string** | Note about the Ezsignbulksend | 
**BEzsignbulksendNeedvalidation** | **bool** | Whether the Ezsigntemplatepackage was automatically modified and needs a manual validation | 
**BEzsignbulksendIsactive** | **bool** | Whether the Ezsignbulksend is active or not | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

