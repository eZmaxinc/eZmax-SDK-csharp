# eZmaxApi.Api.ObjectSupplyApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SupplyCreateObjectV1**](ObjectSupplyApi.md#supplycreateobjectv1) | **POST** /1/object/supply | Create a new Supply |
| [**SupplyDeleteObjectV1**](ObjectSupplyApi.md#supplydeleteobjectv1) | **DELETE** /1/object/supply/{pkiSupplyID} | Delete an existing Supply |
| [**SupplyEditObjectV1**](ObjectSupplyApi.md#supplyeditobjectv1) | **PUT** /1/object/supply/{pkiSupplyID} | Edit an existing Supply |
| [**SupplyGetAutocompleteV2**](ObjectSupplyApi.md#supplygetautocompletev2) | **GET** /2/object/supply/getAutocomplete/{sSelector} | Retrieve Supplys and IDs |
| [**SupplyGetListV1**](ObjectSupplyApi.md#supplygetlistv1) | **GET** /1/object/supply/getList | Retrieve Supply list |
| [**SupplyGetObjectV2**](ObjectSupplyApi.md#supplygetobjectv2) | **GET** /2/object/supply/{pkiSupplyID} | Retrieve an existing Supply |

<a id="supplycreateobjectv1"></a>
# **SupplyCreateObjectV1**
> SupplyCreateObjectV1Response SupplyCreateObjectV1 (SupplyCreateObjectV1Request supplyCreateObjectV1Request)

Create a new Supply

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supplyCreateObjectV1Request** | [**SupplyCreateObjectV1Request**](SupplyCreateObjectV1Request.md) |  |  |

### Return type

[**SupplyCreateObjectV1Response**](SupplyCreateObjectV1Response.md)

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

<a id="supplydeleteobjectv1"></a>
# **SupplyDeleteObjectV1**
> SupplyDeleteObjectV1Response SupplyDeleteObjectV1 (int pkiSupplyID)

Delete an existing Supply


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSupplyID** | **int** | The unique ID of the Supply |  |

### Return type

[**SupplyDeleteObjectV1Response**](SupplyDeleteObjectV1Response.md)

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

<a id="supplyeditobjectv1"></a>
# **SupplyEditObjectV1**
> SupplyEditObjectV1Response SupplyEditObjectV1 (int pkiSupplyID, SupplyEditObjectV1Request supplyEditObjectV1Request)

Edit an existing Supply


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSupplyID** | **int** | The unique ID of the Supply |  |
| **supplyEditObjectV1Request** | [**SupplyEditObjectV1Request**](SupplyEditObjectV1Request.md) |  |  |

### Return type

[**SupplyEditObjectV1Response**](SupplyEditObjectV1Response.md)

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

<a id="supplygetautocompletev2"></a>
# **SupplyGetAutocompleteV2**
> SupplyGetAutocompleteV2Response SupplyGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Supplys and IDs

Get the list of Supply to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Supplys to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**SupplyGetAutocompleteV2Response**](SupplyGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="supplygetlistv1"></a>
# **SupplyGetListV1**
> SupplyGetListV1Response SupplyGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Supply list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**SupplyGetListV1Response**](SupplyGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="supplygetobjectv2"></a>
# **SupplyGetObjectV2**
> SupplyGetObjectV2Response SupplyGetObjectV2 (int pkiSupplyID)

Retrieve an existing Supply


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSupplyID** | **int** | The unique ID of the Supply |  |

### Return type

[**SupplyGetObjectV2Response**](SupplyGetObjectV2Response.md)

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

