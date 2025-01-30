# eZmaxApi.Model.SupplyResponse
A Supply Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiSupplyID** | **int** | The unique ID of the Supply | 
**FkiGlaccountID** | **int** | The unique ID of the Glaccount | [optional] 
**FkiGlaccountcontainerID** | **int** | The unique ID of the Glaccountcontainer | [optional] 
**FkiVariableexpenseID** | **int** | The unique ID of the Variableexpense | 
**SSupplyCode** | **string** | The code of the Supply | 
**ObjSupplyDescription** | [**MultilingualSupplyDescription**](MultilingualSupplyDescription.md) |  | 
**DSupplyUnitprice** | **string** | The unit price of the Supply | 
**BSupplyIsactive** | **bool** | Whether the supply is active or not | 
**BSupplyVariableprice** | **bool** | Whether if the price is variable | 
**SGlaccountDescriptionX** | **string** | The Description for the Glaccount in the language of the requester | [optional] 
**SGlaccountcontainerLongdescriptionX** | **string** | The Description for the Glaccountcontainer in the language of the requester | [optional] 
**SVariableexpenseDescriptionX** | **string** | The description of the Variableexpense in the language of the requester | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

