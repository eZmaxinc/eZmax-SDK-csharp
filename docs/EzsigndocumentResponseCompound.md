
# eZmaxApi.Model.EzsigndocumentResponseCompound

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**DtEzsigndocumentDuedate** | **string** | The maximum date and time at which the Ezsigndocument can be signed. | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SEzsigndocumentName** | **string** | The name of the document that will be presented to Ezsignfoldersignerassociations | 
**PkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | 
**EEzsigndocumentStep** | [**FieldEEzsigndocumentStep**](FieldEEzsigndocumentStep.md) |  | 
**DtEzsigndocumentFirstsend** | **string** | The date and time when the Ezsigndocument was first sent. | [optional] 
**DtEzsigndocumentLastsend** | **string** | The date and time when the Ezsigndocument was sent the last time. | [optional] 
**IEzsigndocumentOrder** | **int** | The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder. | 
**IEzsigndocumentPagetotal** | **int** | The number of pages in the Ezsigndocument. | 
**IEzsigndocumentSignaturesigned** | **int** | The number of signatures that were signed in the document. | 
**IEzsigndocumentSignaturetotal** | **int** | The number of total signatures that were requested in the Ezsigndocument. | 
**SEzsigndocumentMD5initial** | **string** | MD5 Hash of the initial PDF Document before signatures were applied to it. | 
**SEzsigndocumentMD5signed** | **string** | MD5 Hash of the final PDF Document after all signatures were applied to it. | 
**BEzsigndocumentEzsignform** | **bool** | If the Ezsigndocument contains an Ezsignform or not | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 
**IEzsigndocumentStepformtotal** | **int** | The total number of steps in the form filling phase | 
**IEzsigndocumentStepformcurrent** | **int** | The current step in the form filling phase | 
**IEzsigndocumentStepsignaturetotal** | **int** | The total number of steps in the signature filling phase | 
**IEzsigndocumentStepsignatureCurrent** | **int** | The current step in the signature phase | 
**AObjEzsignfoldersignerassociationstatus** | [**List&lt;CustomEzsignfoldersignerassociationstatusResponse&gt;**](CustomEzsignfoldersignerassociationstatusResponse.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

