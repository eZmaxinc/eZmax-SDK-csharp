# eZmaxApi.Model.VersionhistoryResponseCompound
A Versionhistory Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiVersionhistoryID** | **int** | The unique ID of the Versionhistory | 
**FkiModuleID** | **int** | The unique ID of the Module | [optional] 
**FkiModulesectionID** | **int** | The unique ID of the Modulesection | [optional] 
**SModuleNameX** | **string** | The Name of the Module in the language of the requester | [optional] 
**SModulesectionNameX** | **string** | The Name of the Modulesection in the language of the requester | [optional] 
**EVersionhistoryUsertype** | **FieldEVersionhistoryUsertype** |  | [optional] 
**ObjVersionhistoryDetail** | [**MultilingualVersionhistoryDetail**](MultilingualVersionhistoryDetail.md) |  | 
**DtVersionhistoryDate** | **string** | The date  at which the Versionhistory was published or should be published | 
**DtVersionhistoryDateend** | **string** | The date  at which the Versionhistory will no longer be visible | [optional] 
**EVersionhistoryType** | **FieldEVersionhistoryType** |  | 
**BVersionhistoryDraft** | **bool** | Whether the Versionhistory is published or still a draft | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

