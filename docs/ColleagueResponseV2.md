# eZmaxApi.Model.ColleagueResponseV2
A Colleague Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiColleagueID** | **int** | The unique ID of the Colleague | 
**FkiUserID** | **int** | The unique ID of the User | 
**FkiUserIDColleague** | **int** | The unique ID of the User | 
**BColleagueEzsignemail** | **bool** | Whether the email can be used by the cloning user in Ezsign | 
**BColleagueFinancial** | **bool** | Whether the cloning user has access to the financial | 
**BColleagueUsecloneemail** | **bool** | Whether the cloning user has access to the cloned user email to send communications | 
**BColleagueAttachment** | **bool** | Whether the cloning user has access to the attachment | 
**BColleagueCanafe** | **bool** | Whether the cloning user has access to canafe | 
**BColleaguePermission** | **bool** | Whether the cloning user copies the permission of the cloned user | 
**BColleagueRealestatecompleted** | **bool** | Whether if the cloning user has access to the completed folders in real estate | 
**DtColleagueFrom** | **string** | The from of the Colleague | [optional] 
**DtColleagueTo** | **string** | The to of the Colleague | [optional] 
**EColleagueEzsign** | **FieldEColleagueEzsign** |  | 
**EColleagueRealestateinprogress** | **FieldEColleagueRealestateinprogess** |  | 
**ObjUserName** | [**CustomUserNameResponse**](CustomUserNameResponse.md) |  | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

