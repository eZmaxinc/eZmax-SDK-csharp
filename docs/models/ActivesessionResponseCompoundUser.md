# eZmaxApi.Model.ActivesessionResponseCompoundUser
An Activesession->User Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiUserID** | **int** | The unique ID of the User | 
**FkiTimezoneID** | **int** | The unique ID of the Timezone | 
**SUserFirstname** | **string** | The first name of the user | 
**SUserLastname** | **string** | The last name of the user | 
**BUserAddmeinezsignfolder** | **bool** | Whether if I want to automatically add myself during the creation of Ezsignfolder of which I am the owner | 
**EUserEzsignsendreminderfrequency** | **FieldEUserEzsignsendreminderfrequency** |  | 
**IUserInterfacecolor** | **int** | The int32 representation of the interface color. For example, RGB color #39435B would be 3752795 | 
**BUserInterfacedark** | **bool** | Whether to use a dark mode interface | 
**IUserListresult** | **int** | The number of rows to return by default in lists | 
**IUserFrontendgoal** | **int** | Goals save as bit wise (one bit per goal) | 
**SAvatarUrl** | **string** | The url of the picture used as avatar | [optional] 
**SEmailAddress** | **string** | The email address. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

