# eZmaxApi.Api.ObjectEzsignbulksendsignermappingApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsignbulksendsignermappingCreateObjectV1**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappingcreateobjectv1) | **POST** /1/object/ezsignbulksendsignermapping | Create a new Ezsignbulksendsignermapping |
| [**EzsignbulksendsignermappingDeleteObjectV1**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappingdeleteobjectv1) | **DELETE** /1/object/ezsignbulksendsignermapping/{pkiEzsignbulksendsignermappingID} | Delete an existing Ezsignbulksendsignermapping |
| [**EzsignbulksendsignermappingGetObjectV2**](ObjectEzsignbulksendsignermappingApi.md#ezsignbulksendsignermappinggetobjectv2) | **GET** /2/object/ezsignbulksendsignermapping/{pkiEzsignbulksendsignermappingID} | Retrieve an existing Ezsignbulksendsignermapping |

<a id="ezsignbulksendsignermappingcreateobjectv1"></a>
# **EzsignbulksendsignermappingCreateObjectV1**
> EzsignbulksendsignermappingCreateObjectV1Response EzsignbulksendsignermappingCreateObjectV1 (EzsignbulksendsignermappingCreateObjectV1Request ezsignbulksendsignermappingCreateObjectV1Request)

Create a new Ezsignbulksendsignermapping

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ezsignbulksendsignermappingCreateObjectV1Request** | [**EzsignbulksendsignermappingCreateObjectV1Request**](EzsignbulksendsignermappingCreateObjectV1Request.md) |  |  |

### Return type

[**EzsignbulksendsignermappingCreateObjectV1Response**](EzsignbulksendsignermappingCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignbulksendsignermappingdeleteobjectv1"></a>
# **EzsignbulksendsignermappingDeleteObjectV1**
> EzsignbulksendsignermappingDeleteObjectV1Response EzsignbulksendsignermappingDeleteObjectV1 (int pkiEzsignbulksendsignermappingID)

Delete an existing Ezsignbulksendsignermapping


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendsignermappingID** | **int** |  |  |

### Return type

[**EzsignbulksendsignermappingDeleteObjectV1Response**](EzsignbulksendsignermappingDeleteObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ezsignbulksendsignermappinggetobjectv2"></a>
# **EzsignbulksendsignermappingGetObjectV2**
> EzsignbulksendsignermappingGetObjectV2Response EzsignbulksendsignermappingGetObjectV2 (int pkiEzsignbulksendsignermappingID)

Retrieve an existing Ezsignbulksendsignermapping


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsignbulksendsignermappingID** | **int** |  |  |

### Return type

[**EzsignbulksendsignermappingGetObjectV2Response**](EzsignbulksendsignermappingGetObjectV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

