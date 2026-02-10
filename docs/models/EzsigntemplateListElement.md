# eZmaxApi.Model.EzsigntemplateListElement
A Ezsigntemplate List Element

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplateID** | **int** | The unique ID of the Ezsigntemplate | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SEzsigntemplateDescription** | **string** | The description of the Ezsigntemplate | 
**BEzsigntemplateIncomplete** | **bool** | Indicate the Ezsigntemplate is incomplete and cannot be used | 
**EEzsigntemplateType** | **FieldEEzsigntemplateType** |  | 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | [optional] 
**IEzsigntemplatedocumentPagetotal** | **int** | The number of pages in the Ezsigntemplatedocument. | [optional] 
**IEzsigntemplateSignaturetotal** | **int** | The number of total signatures in the Ezsigntemplate. | [optional] 
**IEzsigntemplateFormfieldtotal** | **int** | The number of total form fields in the Ezsigntemplate. | [optional] 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

