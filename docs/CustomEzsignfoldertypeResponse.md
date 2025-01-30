# eZmaxApi.Model.CustomEzsignfoldertypeResponse
A Custom Ezsignfoldertype Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiEzsignfoldertypeID** | **int** | The unique ID of the Ezsignfoldertype. | 
**FkiFontIDAnnotation** | **int** | The unique ID of the Font | [optional] 
**FkiFontIDFormfield** | **int** | The unique ID of the Font | [optional] 
**FkiFontIDSignature** | **int** | The unique ID of the Font | [optional] 
**SEzsignfoldertypeNameX** | **string** | The name of the Ezsignfoldertype in the language of the requester | [optional] 
**BEzsignfoldertypeSendproofezsignsigner** | **bool** | Whether we send the proof in the email to Ezsignsigner | [optional] 
**BEzsignfoldertypeAllowdownloadattachmentezsignsigner** | **bool** | Whether we allow the Ezsigndocument to be downloaded by an Ezsignsigner | [optional] 
**BEzsignfoldertypeAllowdownloadproofezsignsigner** | **bool** | Whether we allow the proof to be downloaded by an Ezsignsigner | [optional] 
**BEzsignfoldertypeAutomaticsignature** | **bool** | Whether we allow the automatic signature by an User | [optional] 
**BEzsignfoldertypeDelegate** | **bool** | Wheter if delegation of signature is allowed to another user or not | [optional] 
**BEzsignfoldertypeDiscussion** | **bool** | Wheter if creating a new Discussion is allowed or not | [optional] 
**BEzsignfoldertypeReassignezsignsigner** | **bool** | Wheter if Reassignment of signature is allowed by a signatory to another signatory or not | [optional] 
**BEzsignfoldertypeReassignuser** | **bool** | Wheter if Reassignment of signature is allowed by a user to a signatory or another user or not | [optional] 
**BEzsignfoldertypeReassigngroup** | **bool** | Wheter if Reassignment of signatures of the groups to which the user belongs is authorized by a user to himself | [optional] 
**IEzsignfoldertypeDeadlinedays** | **int** | The number of days to get all Ezsignsignatures | [optional] 
**IEzsignfoldertypeFontsizeannotation** | **int** | Font size for annotations | [optional] 
**IEzsignfoldertypeFontsizeformfield** | **int** | Font size for form fields | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

