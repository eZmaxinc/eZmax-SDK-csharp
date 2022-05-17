
# eZmaxApi.Model.EzsignfolderResponseCompound

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**FkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | 
**FkiBillingentityinternalID** | **int** | The unique ID of the Billingentityinternal. | 
**SBillingentityinternalDescriptionX** | **string** | The description of the Billingentityinternal in the language of the requester | 
**FkiEzsigntsarequirementID** | **int** | The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| | 
**SEzsigntsarequirementDescriptionX** | **string** | The description of the Ezsigntsarequirement in the language of the requester | 
**SEzsignfolderDescription** | **string** | The description of the Ezsignfolder | 
**TEzsignfolderNote** | **string** | Note about the Ezsignfolder | 
**EEzsignfolderSendreminderfrequency** | [**FieldEEzsignfolderSendreminderfrequency**](FieldEEzsignfolderSendreminderfrequency.md) |  | 
**DtEzsignfolderDuedate** | **string** | The maximum date and time at which the Ezsignfolder can be signed. | [optional] 
**DtEzsignfolderSentdate** | **string** | The date and time at which the Ezsign folder was sent the last time. | [optional] 
**DtEzsignfolderScheduledarchive** | **string** | The scheduled date and time at which the Ezsignfolder should be archived. | 
**DtEzsignfolderScheduleddestruction** | **string** | The scheduled date and time at which the Ezsignfolder should be Destroyed. | 
**EEzsignfolderStep** | [**FieldEEzsignfolderStep**](FieldEEzsignfolderStep.md) |  | 
**DtEzsignfolderClose** | **string** | The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely. | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

