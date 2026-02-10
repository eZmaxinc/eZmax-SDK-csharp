# eZmaxApi.Model.EzsignfoldertypeRequestCompoundV3
A Ezsignfoldertype Object and children

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjEzsignfoldertypeName** | [**MultilingualEzsignfoldertypeName**](MultilingualEzsignfoldertypeName.md) |  | 
**FkiBrandingID** | **int** | The unique ID of the Branding | 
**AFkiUserlogintypeID** | **List&lt;int&gt;** |  | 
**EEzsignfoldertypePrivacylevel** | **FieldEEzsignfoldertypePrivacylevel** |  | 
**IEzsignfoldertypeArchivaldays** | **int** | The number of days before the archival of Ezsignfolders created using this Ezsignfoldertype | 
**EEzsignfoldertypeDisposal** | **FieldEEzsignfoldertypeDisposal** |  | 
**EEzsignfoldertypeCompletion** | **FieldEEzsignfoldertypeCompletion** |  | 
**IEzsignfoldertypeDeadlinedays** | **int** | The number of days to get all Ezsignsignatures | 
**BEzsignfoldertypeSendsignedtodocumentowner** | **bool** | Whether we send the signed Ezsigndocument to the Ezsigndocument&#39;s owner | 
**BEzsignfoldertypeSendsignedtofolderowner** | **bool** | Whether we send the signed Ezsigndocument to the Ezsignfolder&#39;s owner | 
**BEzsignfoldertypeSendsignedtocolleague** | **bool** | Whether we send the signed Ezsigndocument to the colleagues | 
**BEzsignfoldertypeSendsummarytodocumentowner** | **bool** | Whether we send the summary to the Ezsigndocument&#39;s owner | 
**BEzsignfoldertypeSendsummarytofolderowner** | **bool** | Whether we send the summary to the Ezsignfolder&#39;s owner | 
**BEzsignfoldertypeSendsummarytocolleague** | **bool** | Whether we send the summary to the colleagues | 
**BEzsignfoldertypeIsactive** | **bool** | Whether the Ezsignfoldertype is active or not | 
**PkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | [optional] 
**FkiBillingentityinternalID** | **int** | The unique ID of the Billingentityinternal. | [optional] 
**FkiEzsigntsarequirementID** | **int** | The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| | [optional] 
**FkiFontIDAnnotation** | **int** | The unique ID of the Font | [optional] 
**FkiFontIDFormfield** | **int** | The unique ID of the Font | [optional] 
**FkiFontIDSignature** | **int** | The unique ID of the Font | [optional] 
**FkiPdfalevelIDConvert** | **int** | The unique ID of the Pdfalevel | [optional] 
**AFkiPdfalevelID** | **List&lt;int&gt;** |  | [optional] 
**AFkiUsergroupIDAll** | **List&lt;int&gt;** |  | [optional] 
**AFkiUsergroupIDRestricted** | **List&lt;int&gt;** |  | [optional] 
**AFkiUsergroupIDTemplate** | **List&lt;int&gt;** |  | [optional] 
**EEzsignfoldertypeDocumentdependency** | **FieldEEzsignfoldertypeDocumentdependency** |  | [optional] 
**EEzsignfoldertypeDocumentmerge** | **FieldEEzsignfoldertypeDocumentmerge** |  | [optional] 
**SEmailAddressSigned** | **string** | The email address. | [optional] 
**SEmailAddressSummary** | **string** | The email address. | [optional] 
**EEzsignfoldertypePdfarequirement** | **FieldEEzsignfoldertypePdfarequirement** |  | [optional] 
**EEzsignfoldertypePdfanoncompliantaction** | **FieldEEzsignfoldertypePdfanoncompliantaction** |  | [optional] 
**IEzsignfoldertypeFontsizeannotation** | **int** | Font size for annotations | [optional] 
**IEzsignfoldertypeFontsizeformfield** | **int** | Font size for form fields | [optional] 
**IEzsignfoldertypeSendreminderfirstdays** | **int** | The number of days before the the first reminder sending | [optional] 
**IEzsignfoldertypeSendreminderotherdays** | **int** | The number of days after the first reminder sending | [optional] 
**IEzsignfoldertypeDisposaldays** | **int** | The number of days after the archival before the disposal of the Ezsignfolder | [optional] 
**BEzsignfoldertypePrematurelyendautomatically** | **bool** | Wheter if document will be ended prematurely after Ezsignfolder expires. | [optional] 
**IEzsignfoldertypePrematurelyendautomaticallydays** | **int** | Number of days between Ezsignfolder expiration and automatic prematurely end of Ezsigndocuments. | [optional] 
**BEzsignfoldertypeAutomaticsignature** | **bool** | Whether we allow the automatic signature by an User | [optional] 
**BEzsignfoldertypeDelegate** | **bool** | Wheter if delegation of signature is allowed to another user or not | [optional] 
**BEzsignfoldertypeDiscussion** | **bool** | Wheter if creating a new Discussion is allowed or not | [optional] 
**BEzsignfoldertypeLogrecipientinproof** | **bool** | Whether we log recipient of signed document in proof | [optional] 
**BEzsignfoldertypeReassignezsignsigner** | **bool** | Wheter if Reassignment of signature is allowed by a signatory to another signatory or not | [optional] 
**BEzsignfoldertypeReassignuser** | **bool** | Wheter if Reassignment of signature is allowed by a user to a signatory or another user or not | [optional] 
**BEzsignfoldertypeReassigngroup** | **bool** | Wheter if Reassignment of signatures of the groups to which the user belongs is authorized by a user to himself | [optional] 
**BEzsignfoldertypeSendsignedtoezsignsigner** | **bool** | Whether we send an email to Ezsignsigner  when document is completed | [optional] 
**BEzsignfoldertypeSendsignedtouser** | **bool** | Whether we send an email to User who signed when document is completed | [optional] 
**BEzsignfoldertypeSendattachmentezsignsigner** | **bool** | Whether we send the Ezsigndocument in the email to Ezsignsigner | [optional] 
**BEzsignfoldertypeSendsignatureattachmentezsignsigner** | **bool** | Whether we send the attachments contained in the Ezsignsignatures in the email to Ezsignsigner | [optional] 
**BEzsignfoldertypeSendsignatureattachment** | **bool** | Whether we send the attachments contained in the Ezsignsignatures in the email to external recipient | [optional] 
**BEzsignfoldertypeSendproofezsignsigner** | **bool** | Whether we send the proof in the email to Ezsignsigner | [optional] 
**BEzsignfoldertypeSendattachmentuser** | **bool** | Whether we send the Ezsigndocument in the email to User | [optional] 
**BEzsignfoldertypeSendsignatureattachmentuser** | **bool** | Whether we send the attachments contained in the Ezsignsignatures in the email to User | [optional] 
**BEzsignfoldertypeSendproofuser** | **bool** | Whether we send the proof in the email to User | [optional] 
**BEzsignfoldertypeSendproofemail** | **bool** | Whether we send the proof in the email to external recipient | [optional] 
**BEzsignfoldertypeAllowdownloadattachmentezsignsigner** | **bool** | Whether we allow the Ezsigndocument to be downloaded by an Ezsignsigner | [optional] 
**BEzsignfoldertypeAllowdownloadsignatureattachmentezsignsigner** | **bool** | Whether we allow the attachments in the Ezsignsignatures to be downloaded by an Ezsignsigner | [optional] 
**BEzsignfoldertypeAllowdownloadproofezsignsigner** | **bool** | Whether we allow the proof to be downloaded by an Ezsignsigner | [optional] 
**BEzsignfoldertypeSendproofreceivealldocument** | **bool** | Whether we send the proof to user and Ezsignsigner who receive all documents. | [optional] 
**BEzsignfoldertypeSendsignatureattachmentreceivealldocument** | **bool** | Whether we send the attachments contained in the Ezsignsignatures to user and Ezsignsigner who receive all documents. | [optional] 
**BEzsignfoldertypeSendsignedtofullgroup** | **bool** | Whether we send the signed Ezsigndocument to the Usergroup that has acces to all Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsignedtolimitedgroup** | **bool** | THIS FIELD WILL BE DELETED. Whether we send the signed Ezsigndocument to the Usergroup that has acces to only their own Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsummarytofullgroup** | **bool** | Whether we send the summary to the Usergroup that has acces to all Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsummarytolimitedgroup** | **bool** | Whether we send the summary to the Usergroup that has acces to only their own Ezsignfolders | [optional] 
**EEzsignfoldertypeSigneraccess** | **FieldEEzsignfoldertypeSigneraccess** |  | [optional] 
**AFkiUserIDSigned** | **List&lt;int&gt;** |  | [optional] 
**AFkiUserIDSummary** | **List&lt;int&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

