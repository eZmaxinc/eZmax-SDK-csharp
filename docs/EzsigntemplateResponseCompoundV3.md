# eZmaxApi.Model.EzsigntemplateResponseCompoundV3
A Ezsigntemplate Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplateID** | **int** | The unique ID of the Ezsigntemplate | 
**FkiEzsigntemplatedocumentID** | **int** | The unique ID of the Ezsigntemplatedocument | [optional] 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | [optional] 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**FkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument | [optional] 
**SEzdoctemplatedocumentNameX** | **string** | The name of the Ezdoctemplatedocument in the language of the requester | [optional] 
**SLanguageNameX** | **string** | The Name of the Language in the language of the requester | 
**SEzsigntemplateDescription** | **string** | The description of the Ezsigntemplate | 
**SEzsigntemplateExternaldescription** | **string** | The external description of the Ezsigntemplate | [optional] 
**TEzsigntemplateComment** | **string** | The comment of the Ezsigntemplate | [optional] 
**EEzsigntemplateRecognition** | **FieldEEzsigntemplateRecognition** |  | [optional] 
**SEzsigntemplateFilenameregexp** | **string** | The filename regexp of the Ezsigntemplate. | [optional] 
**BEzsigntemplateAdminonly** | **bool** | Whether the Ezsigntemplate can be accessed by admin users only (eUserType&#x3D;Normal) | 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | [optional] 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 
**BEzsigntemplateEditallowed** | **bool** | Whether the Ezsigntemplate if allowed to edit or not | 
**EEzsigntemplateType** | **FieldEEzsigntemplateType** |  | [optional] 
**ObjEzsigntemplatedocument** | [**EzsigntemplatedocumentResponse**](EzsigntemplatedocumentResponse.md) |  | [optional] 
**AObjEzsigntemplatesigner** | [**List&lt;EzsigntemplatesignerResponseCompound&gt;**](EzsigntemplatesignerResponseCompound.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

