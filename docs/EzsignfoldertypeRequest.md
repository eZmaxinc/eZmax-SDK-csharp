# eZmaxApi.Model.EzsignfoldertypeRequest
A Ezsignfoldertype Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | [optional] 
**ObjEzsignfoldertypeName** | [**MultilingualEzsignfoldertypeName**](MultilingualEzsignfoldertypeName.md) |  | 
**FkiBrandingID** | **int** | The unique ID of the Branding | 
**FkiBillingentityinternalID** | **int** | The unique ID of the Billingentityinternal. | [optional] 
**FkiUsergroupID** | **int** | The unique ID of the Usergroup | [optional] 
**FkiUsergroupIDRestricted** | **int** | The unique ID of the Usergroup | [optional] 
**FkiEzsigntsarequirementID** | **int** | The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| | [optional] 
**SEmailAddressSigned** | **string** | The email address. | [optional] 
**SEmailAddressSummary** | **string** | The email address. | [optional] 
**EEzsignfoldertypePrivacylevel** | **FieldEEzsignfoldertypePrivacylevel** |  | 
**EEzsignfoldertypeSendreminderfrequency** | **FieldEEzsignfoldertypeSendreminderfrequency** |  | [optional] 
**IEzsignfoldertypeArchivaldays** | **int** | The number of days before the archival of Ezsignfolders created using this Ezsignfoldertype | 
**EEzsignfoldertypeDisposal** | **FieldEEzsignfoldertypeDisposal** |  | 
**EEzsignfoldertypeCompletion** | **FieldEEzsignfoldertypeCompletion** |  | 
**IEzsignfoldertypeDisposaldays** | **int** | The number of days after the archival before the disposal of the Ezsignfolder | [optional] 
**IEzsignfoldertypeDeadlinedays** | **int** | The number of days to get all Ezsignsignatures | 
**BEzsignfoldertypeDelegate** | **bool** | Wheter if delegation of signature is allowed to another user or not | [optional] 
**BEzsignfoldertypeDiscussion** | **bool** | Wheter if creating a new Discussion is allowed or not | [optional] 
**BEzsignfoldertypeReassignezsignsigner** | **bool** | Wheter if Reassignment of signature is allowed by a signatory to another signatory or not | [optional] 
**BEzsignfoldertypeReassignuser** | **bool** | Wheter if Reassignment of signature is allowed by a user to a signatory or another user or not | [optional] 
**BEzsignfoldertypeSendsignedtoezsignsigner** | **bool** | Whether we send an email to Ezsignsigner  when document is completed | [optional] 
**BEzsignfoldertypeSendsignedtouser** | **bool** | Whether we send an email to User who signed when document is completed | [optional] 
**BEzsignfoldertypeSendattachmentezsignsigner** | **bool** | Whether we send the Ezsigndocument in the email to Ezsignsigner | [optional] 
**BEzsignfoldertypeSendproofezsignsigner** | **bool** | Whether we send the proof in the email to Ezsignsigner | [optional] 
**BEzsignfoldertypeSendattachmentuser** | **bool** | Whether we send the Ezsigndocument in the email to User | [optional] 
**BEzsignfoldertypeSendproofuser** | **bool** | Whether we send the proof in the email to User | [optional] 
**BEzsignfoldertypeSendproofemail** | **bool** | Whether we send the proof in the email to external recipient | [optional] 
**BEzsignfoldertypeAllowdownloadattachmentezsignsigner** | **bool** | Whether we allow the Ezsigndocument to be downloaded by an Ezsignsigner | [optional] 
**BEzsignfoldertypeAllowdownloadproofezsignsigner** | **bool** | Whether we allow the proof to be downloaded by an Ezsignsigner | [optional] 
**BEzsignfoldertypeSendproofreceivealldocument** | **bool** | Whether we send the proof to user and Ezsignsigner who receive all documents. | [optional] 
**BEzsignfoldertypeSendsignedtodocumentowner** | **bool** | Whether we send the signed Ezsigndocument to the Ezsigndocument&#39;s owner | 
**BEzsignfoldertypeSendsignedtofolderowner** | **bool** | Whether we send the signed Ezsigndocument to the Ezsignfolder&#39;s owner | 
**BEzsignfoldertypeSendsignedtofullgroup** | **bool** | Whether we send the signed Ezsigndocument to the Usergroup that has acces to all Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsignedtolimitedgroup** | **bool** | THIS FIELD WILL BE DELETED. Whether we send the signed Ezsigndocument to the Usergroup that has acces to only their own Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsignedtocolleague** | **bool** | Whether we send the signed Ezsigndocument to the colleagues | 
**BEzsignfoldertypeSendsummarytodocumentowner** | **bool** | Whether we send the summary to the Ezsigndocument&#39;s owner | 
**BEzsignfoldertypeSendsummarytofolderowner** | **bool** | Whether we send the summary to the Ezsignfolder&#39;s owner | 
**BEzsignfoldertypeSendsummarytofullgroup** | **bool** | Whether we send the summary to the Usergroup that has acces to all Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsummarytolimitedgroup** | **bool** | Whether we send the summary to the Usergroup that has acces to only their own Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsummarytocolleague** | **bool** | Whether we send the summary to the colleagues | 
**BEzsignfoldertypeIsactive** | **bool** | Whether the Ezsignfoldertype is active or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

