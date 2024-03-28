# eZmaxApi.Model.EzsigntemplatepackageResponse
A Ezsigntemplatepackage Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigntemplatepackageID** | **int** | The unique ID of the Ezsigntemplatepackage | 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SLanguageNameX** | **string** | The Name of the Language in the language of the requester | 
**SEzsigntemplatepackageDescription** | **string** | The description of the Ezsigntemplatepackage | 
**BEzsigntemplatepackageAdminonly** | **bool** | Whether the Ezsigntemplatepackage can be accessed by admin users only (eUserType&#x3D;Normal) | 
**BEzsigntemplatepackageNeedvalidation** | **bool** | Whether the Ezsignbulksend was automatically modified and needs a manual validation | 
**BEzsigntemplatepackageIsactive** | **bool** | Whether the Ezsigntemplatepackage is active or not | 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | 
**BEzsigntemplatepackageEditallowed** | **bool** | Whether the Ezsigntemplatepackage if allowed to edit or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

