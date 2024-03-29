
# eZmaxApi.Model.EzsignfoldertypeResponseCompound

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | 
**ObjEzsignfoldertypeName** | [**MultilingualEzsignfoldertypeName**](MultilingualEzsignfoldertypeName.md) |  | 
**FkiBrandingID** | **int** | The unique ID of the Branding | 
**FkiBillingentityinternalID** | **int** | The unique ID of the Billingentityinternal. | [optional] 
**FkiUsergroupID** | **int** | The unique ID of the Usergroup | [optional] 
**FkiUsergroupIDRestricted** | **int** | The unique ID of the Usergroup | [optional] 
**FkiEzsigntsarequirementID** | **int** | The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| | [optional] 
**SBrandingDescriptionX** | **string** | The Description of the Branding in the language of the requester | 
**SBillingentityinternalDescriptionX** | **string** | The description of the Billingentityinternal in the language of the requester | [optional] 
**SEzsigntsarequirementDescriptionX** | **string** | The description of the Ezsigntsarequirement in the language of the requester | [optional] 
**SEmailAddressSigned** | **string** | The email address. | [optional] 
**SEmailAddressSummary** | **string** | The email address. | [optional] 
**SUsergroupNameX** | **string** | The Name of the Usergroup in the language of the requester | [optional] 
**SUsergroupNameXRestricted** | **string** | The Name of the Usergroup in the language of the requester | [optional] 
**EEzsignfoldertypePrivacylevel** | **FieldEEzsignfoldertypePrivacylevel** |  | 
**EEzsignfoldertypeSendreminderfrequency** | **FieldEEzsignfoldertypeSendreminderfrequency** |  | [optional] 
**IEzsignfoldertypeArchivaldays** | **int** | The number of days before the archival of Ezsignfolders created using this Ezsignfoldertype | 
**EEzsignfoldertypeDisposal** | **FieldEEzsignfoldertypeDisposal** |  | 
**IEzsignfoldertypeDisposaldays** | **int** | The number of days after the archival before the disposal of the Ezsignfolder | [optional] 
**IEzsignfoldertypeDeadlinedays** | **int** | The number of days to get all Ezsignsignatures | 
**BEzsignfoldertypeSendattatchmentsigner** | **bool** | Whether we send the Ezsigndocument and the proof as attachment in the email | 
**BEzsignfoldertypeSendsignedtodocumentowner** | **bool** | Whether we send the signed Ezsigndocument to the Ezsigndocument&#39;s owner | 
**BEzsignfoldertypeSendsignedtofolderowner** | **bool** | Whether we send the signed Ezsigndocument to the Ezsignfolder&#39;s owner | 
**BEzsignfoldertypeSendsignedtofullgroup** | **bool** | Whether we send the signed Ezsigndocument to the Usergroup that has acces to all Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsignedtolimitedgroup** | **bool** | Whether we send the signed Ezsigndocument to the Usergroup that has acces to only their own Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsignedtocolleague** | **bool** | Whether we send the signed Ezsigndocument to the colleagues | 
**BEzsignfoldertypeSendsummarytodocumentowner** | **bool** | Whether we send the summary to the Ezsigndocument&#39;s owner | 
**BEzsignfoldertypeSendsummarytofolderowner** | **bool** | Whether we send the summary to the Ezsignfolder&#39;s owner | 
**BEzsignfoldertypeSendsummarytofullgroup** | **bool** | Whether we send the summary to the Usergroup that has acces to all Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsummarytolimitedgroup** | **bool** | Whether we send the summary to the Usergroup that has acces to only their own Ezsignfolders | [optional] 
**BEzsignfoldertypeSendsummarytocolleague** | **bool** | Whether we send the summary to the colleagues | 
**BEzsignfoldertypeIncludeproofsigner** | **bool** | Whether we include the proof with the signed Ezsigndocument for Ezsignsigners | 
**BEzsignfoldertypeIncludeproofuser** | **bool** | Whether we include the proof with the signed Ezsigndocument for users | 
**BEzsignfoldertypeIsactive** | **bool** | Whether the Ezsignfoldertype is active or not | 
**AFkiUserIDSigned** | **List&lt;int&gt;** |  | [optional] 
**AFkiUserIDSummary** | **List&lt;int&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

