# eZmaxApi.Model.CommonAuditdetail
Gives informations about the user that created the object or the last user to have modified it.  If the object was never modified after creation, both Created and Modified informations will be the same. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiUserID** | **int** | The unique ID of the User | 
**FkiApikeyID** | **int** | The unique ID of the Apikey | [optional] 
**SUserLoginname** | **string** | The login name of the User. | 
**SUserLastname** | **string** | The last name of the user | 
**SUserFirstname** | **string** | The first name of the user | 
**SApikeyDescriptionX** | **string** | The description of the Apikey in the language of the requester | [optional] 
**DtAuditdetailDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

