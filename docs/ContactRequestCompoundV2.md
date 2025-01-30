# eZmaxApi.Model.ContactRequestCompoundV2
A Contact Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiContacttitleID** | **int** | The unique ID of the Contacttitle.  Valid values:  |Value|Description| |-|-| |1|Ms.| |2|Mr.| |4|(Blank)| |5|Me (For Notaries)| | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**EContactType** | **FieldEContactType** |  | 
**SContactFirstname** | **string** | The First name of the contact | 
**SContactLastname** | **string** | The Last name of the contact | 
**SContactCompany** | **string** | The Company name of the contact | [optional] 
**DtContactBirthdate** | **string** | The Birth Date of the contact | [optional] 
**SContactOccupation** | **string** | The occupation of the Contact | [optional] 
**TContactNote** | **string** | The note of the Contact | [optional] 
**BContactIsactive** | **bool** | Whether the contact is active or not | [optional] 
**ObjContactinformations** | [**ContactinformationsRequestCompoundV2**](ContactinformationsRequestCompoundV2.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

