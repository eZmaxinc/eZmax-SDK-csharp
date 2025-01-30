# eZmaxApi.Model.UserRequestV2
A User Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiUserID** | **int** | The unique ID of the User | [optional] 
**FkiAgentID** | **int** | The unique ID of the Agent. | [optional] 
**FkiBrokerID** | **int** | The unique ID of the Broker. | [optional] 
**FkiAssistantID** | **int** | The unique ID of the Assistant. | [optional] 
**FkiEmployeeID** | **int** | The unique ID of the Employee. | [optional] 
**FkiCompanyIDDefault** | **int** | The unique ID of the Company | 
**FkiDepartmentIDDefault** | **int** | The unique ID of the Department | 
**FkiTimezoneID** | **int** | The unique ID of the Timezone | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**ObjEmail** | [**EmailRequestCompound**](EmailRequestCompound.md) |  | 
**FkiBillingentityinternalID** | **int** | The unique ID of the Billingentityinternal. | 
**ObjPhoneHome** | [**PhoneRequestCompoundV2**](PhoneRequestCompoundV2.md) |  | [optional] 
**ObjPhoneSMS** | [**PhoneRequestCompoundV2**](PhoneRequestCompoundV2.md) |  | [optional] 
**FkiSecretquestionID** | **int** | The unique ID of the Secretquestion.  Valid values:  |Value|Description| |-|-| |1|The name of the hospital in which you were born| |2|The name of your grade school| |3|The last name of your favorite teacher| |4|Your favorite sports team| |5|Your favorite TV show| |6|Your favorite movie| |7|The name of the street on which you grew up| |8|The name of your first employer| |9|Your first car| |10|Your favorite food| |11|The name of your first pet| |12|Favorite musician/band| |13|What instrument you play| |14|Your father&#39;s middle name| |15|Your mother&#39;s maiden name| |16|Name of your eldest child| |17|Your spouse&#39;s middle name| |18|Favorite restaurant| |19|Childhood nickname| |20|Favorite vacation destination| |21|Your boat&#39;s name| |22|Date of Birth (YYYY-MM-DD)| |22|Secret Code| |22|Your reference code| | [optional] 
**SUserSecretresponse** | **string** | The answer to the Secretquestion | [optional] 
**FkiModuleIDForm** | **int** | The unique ID of the Module | [optional] 
**EUserType** | **FieldEUserType** |  | 
**EUserLogintype** | **FieldEUserLogintype** |  | 
**SUserFirstname** | **string** | The first name of the user | 
**SUserLastname** | **string** | The last name of the user | 
**SUserLoginname** | **string** | The login name of the User. | 
**SUserJobtitle** | **string** | The job title of the user | [optional] 
**EUserEzsignaccess** | **FieldEUserEzsignaccess** |  | 
**BUserIsactive** | **bool** | Whether the User is active or not | 
**BUserValidatebyadministration** | **bool** | Whether if the transactions in which the User is implicated must be validated by administrative personnel or not | [optional] 
**BUserValidatebydirector** | **bool** | Whether if the transactions in which the User is implicated must be validated by a director or not | [optional] 
**BUserAttachmentautoverified** | **bool** | Whether if Attachments uploaded by the User must be validated or not | [optional] 
**BUserChangepassword** | **bool** | Whether if the User is forced to change its password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

