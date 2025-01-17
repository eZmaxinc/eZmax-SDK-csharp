# eZmaxApi.Model.EzsigndocumentResponseCompound
An Ezsigndocument Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsigndocumentID** | **int** | The unique ID of the Ezsigndocument | 
**FkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**FkiEzsignfoldersignerassociationIDDeclinedtosign** | **int** | The unique ID of the Ezsignfoldersignerassociation | [optional] 
**DtEzsigndocumentDuedate** | **string** | The maximum date and time at which the Ezsigndocument can be signed. | 
**DtEzsignformCompleted** | **string** | The date and time at which the Ezsignform has been completed. | [optional] 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | [optional] 
**SEzsigndocumentName** | **string** | The name of the document that will be presented to Ezsignfoldersignerassociations | 
**EEzsigndocumentStep** | **FieldEEzsigndocumentStep** |  | 
**DtEzsigndocumentFirstsend** | **string** | The date and time when the Ezsigndocument was first sent. | [optional] 
**DtEzsigndocumentLastsend** | **string** | The date and time when the Ezsigndocument was sent the last time. | [optional] 
**IEzsigndocumentOrder** | **int** | The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder. | 
**IEzsigndocumentPagetotal** | **int** | The number of pages in the Ezsigndocument. | 
**IEzsigndocumentSignaturesigned** | **int** | The number of signatures that were signed in the document. | 
**IEzsigndocumentSignaturetotal** | **int** | The number of total signatures that were requested in the Ezsigndocument. | 
**IEzsigndocumentFormfieldtotal** | **int** | The number of total Ezsignformfield that were requested in the Ezsigndocument. | 
**SEzsigndocumentMD5initial** | **string** | MD5 Hash of the initial PDF Document before signatures were applied to it. | [optional] 
**TEzsigndocumentDeclinedtosignreason** | **string** | A custom text message that will contain the refusal message if the Ezsigndocument is declined to sign | [optional] 
**SEzsigndocumentMD5signed** | **string** | MD5 Hash of the final PDF Document after all signatures were applied to it. | [optional] 
**BEzsigndocumentEzsignform** | **bool** | If the Ezsigndocument contains an Ezsignform or not | [optional] 
**BEzsigndocumentHassignedsignatures** | **bool** | If the Ezsigndocument contains signed signatures (From internal or external sources) | [optional] 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | [optional] 
**SEzsigndocumentExternalid** | **string** | This field can be used to store an External ID from the client&#39;s system.  Anything can be stored in this field, it will never be evaluated by the eZmax system and will be returned AS-IS.  To store multiple values, consider using a JSON formatted structure, a URL encoded string, a CSV or any other custom format.  | [optional] 
**IEzsigndocumentEzsignsignatureattachmenttotal** | **int** | The number of Ezsigndocumentattachment total | 
**IEzsigndocumentEzsigndiscussiontotal** | **int** | The total number of Ezsigndiscussions | 
**EEzsigndocumentSteptype** | **ComputedEEzsigndocumentSteptype** |  | 
**IEzsigndocumentStepformtotal** | **int** | The total number of steps in the form filling phase | 
**IEzsigndocumentStepformcurrent** | **int** | The current step in the form filling phase | 
**IEzsigndocumentStepsignaturetotal** | **int** | The total number of steps in the signature filling phase | 
**IEzsigndocumentStepsignatureCurrent** | **int** | The current step in the signature phase | 
**AObjEzsignfoldersignerassociationstatus** | [**List&lt;CustomEzsignfoldersignerassociationstatusResponse&gt;**](CustomEzsignfoldersignerassociationstatusResponse.md) |  | 
**AObjEzsigndocumentdependency** | [**List&lt;EzsigndocumentdependencyResponse&gt;**](EzsigndocumentdependencyResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

