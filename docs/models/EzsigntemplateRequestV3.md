# eZmaxApi.Model.EzsigntemplateRequestV3
A Ezsigntemplate Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SEzsigntemplateDescription** | **string** | The description of the Ezsigntemplate | 
**BEzsigntemplateAdminonly** | **bool** | Whether the Ezsigntemplate can be accessed by admin users only (eUserType&#x3D;Normal) | 
**EEzsigntemplateType** | **FieldEEzsigntemplateType** |  | 
**PkiEzsigntemplateID** | **int** | The unique ID of the Ezsigntemplate | [optional] 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | [optional] 
**FkiEzdoctemplatedocumentID** | **int** | The unique ID of the Ezdoctemplatedocument | [optional] 
**SEzsigntemplateExternaldescription** | **string** | The external description of the Ezsigntemplate | [optional] 
**TEzsigntemplateComment** | **string** | The comment of the Ezsigntemplate | [optional] 
**EEzsigntemplateRecognition** | **FieldEEzsigntemplateRecognition** |  | [optional] 
**SEzsigntemplateFilenameregexp** | **string** | The filename regexp of the Ezsigntemplate. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

