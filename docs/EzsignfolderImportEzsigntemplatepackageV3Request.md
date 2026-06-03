# eZmaxApi.Model.EzsignfolderImportEzsigntemplatepackageV3Request
Request for POST /3/object/ezsignfolder/{pkiEzsignfolderID}/importEzsigntemplatepackage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiEzsigntemplatepackageID** | **int** | The unique ID of the Ezsigntemplatepackage | 
**DtEzsigndocumentDuedate** | **string** | The maximum date and time at which the Ezsigndocument can be signed. | 
**AObjImportEzsigntemplatepackageRelation** | [**List&lt;CustomImportEzsigntemplatepackageRelationRequest&gt;**](CustomImportEzsigntemplatepackageRelationRequest.md) |  | 
**ASEzsigntemplateannotationDescription** | **List&lt;string&gt;** |  | 
**ASEzsigntemplateannotationDefaulttext** | **List&lt;string&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

