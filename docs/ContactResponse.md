# eZmaxApi.Model.ContactResponse
A Contact Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiContactID** | **int** | The unique ID of the Contact | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**FkiContacttitleID** | **int** | The unique ID of the Contacttitle.  Valid values:  |Value|Description| |-|-| |1|Ms.| |2|Mr.| |4|(Blank)| |5|Me (For Notaries)| | 
**FkiContactinformationsID** | **int** | The unique ID of the Contactinformations | 
**DtContactBirthdate** | **string** | The Birth Date of the contact | [optional] 
**EContactType** | **FieldEContactType** |  | 
**SContactFirstname** | **string** | The First name of the contact | 
**SContactLastname** | **string** | The Last name of the contact | 
**SContactCompany** | **string** | The Company name of the contact | [optional] 
**SContactOccupation** | **string** | The occupation of the Contact | [optional] 
**TContactNote** | **string** | The note of the Contact | [optional] 
**BContactIsactive** | **bool** | Whether the contact is active or not | 
**ObjContactinformations** | [**ContactinformationsResponseCompound**](ContactinformationsResponseCompound.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

