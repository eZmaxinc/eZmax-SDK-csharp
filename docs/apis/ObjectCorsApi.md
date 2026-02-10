# eZmaxApi.Api.ObjectCorsApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CorsCreateObjectV1**](ObjectCorsApi.md#corscreateobjectv1) | **POST** /1/object/cors | Create a new Cors |
| [**CorsDeleteObjectV1**](ObjectCorsApi.md#corsdeleteobjectv1) | **DELETE** /1/object/cors/{pkiCorsID} | Delete an existing Cors |
| [**CorsEditObjectV1**](ObjectCorsApi.md#corseditobjectv1) | **PUT** /1/object/cors/{pkiCorsID} | Edit an existing Cors |
| [**CorsGetObjectV2**](ObjectCorsApi.md#corsgetobjectv2) | **GET** /2/object/cors/{pkiCorsID} | Retrieve an existing Cors |

<a id="corscreateobjectv1"></a>
# **CorsCreateObjectV1**
> CorsCreateObjectV1Response CorsCreateObjectV1 (CorsCreateObjectV1Request corsCreateObjectV1Request)

Create a new Cors

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **corsCreateObjectV1Request** | [**CorsCreateObjectV1Request**](CorsCreateObjectV1Request.md) |  |  |

### Return type

[**CorsCreateObjectV1Response**](CorsCreateObjectV1Response.md)

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

<a id="corsdeleteobjectv1"></a>
# **CorsDeleteObjectV1**
> CorsDeleteObjectV1Response CorsDeleteObjectV1 (int pkiCorsID)

Delete an existing Cors


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCorsID** | **int** | The unique ID of the Cors |  |

### Return type

[**CorsDeleteObjectV1Response**](CorsDeleteObjectV1Response.md)

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

<a id="corseditobjectv1"></a>
# **CorsEditObjectV1**
> CorsEditObjectV1Response CorsEditObjectV1 (int pkiCorsID, CorsEditObjectV1Request corsEditObjectV1Request)

Edit an existing Cors


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCorsID** | **int** | The unique ID of the Cors |  |
| **corsEditObjectV1Request** | [**CorsEditObjectV1Request**](CorsEditObjectV1Request.md) |  |  |

### Return type

[**CorsEditObjectV1Response**](CorsEditObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="corsgetobjectv2"></a>
# **CorsGetObjectV2**
> CorsGetObjectV2Response CorsGetObjectV2 (int pkiCorsID)

Retrieve an existing Cors


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCorsID** | **int** | The unique ID of the Cors |  |

### Return type

[**CorsGetObjectV2Response**](CorsGetObjectV2Response.md)

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

