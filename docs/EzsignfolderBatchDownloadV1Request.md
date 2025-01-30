# eZmaxApi.Model.EzsignfolderBatchDownloadV1Request
Request for POST /1/object/ezsignfolder/{pkiEzsignfolderID}/batchDownload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**APkiEzsigndocumentID** | **List&lt;int&gt;** |  | 
**AEDocumentType** | **List&lt;EzsignfolderBatchDownloadV1Request.AEDocumentTypeEnum&gt;** | The type of document to retrieve.  1. **Signed** Is the final document once all signatures were applied. 2. **Proofdocument** Is the evidence report. 3. **Proof** Is the complete evidence archive including all of the above and more. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

