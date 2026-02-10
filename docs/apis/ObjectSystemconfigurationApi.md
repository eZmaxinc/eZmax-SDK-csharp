# eZmaxApi.Api.ObjectSystemconfigurationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SystemconfigurationEditObjectV2**](ObjectSystemconfigurationApi.md#systemconfigurationeditobjectv2) | **PUT** /2/object/systemconfiguration/{pkiSystemconfigurationID} | Edit an existing Systemconfiguration |
| [**SystemconfigurationGetObjectV2**](ObjectSystemconfigurationApi.md#systemconfigurationgetobjectv2) | **GET** /2/object/systemconfiguration/{pkiSystemconfigurationID} | Retrieve an existing Systemconfiguration |

<a id="systemconfigurationeditobjectv2"></a>
# **SystemconfigurationEditObjectV2**
> SystemconfigurationEditObjectV2Response SystemconfigurationEditObjectV2 (int pkiSystemconfigurationID, SystemconfigurationEditObjectV2Request systemconfigurationEditObjectV2Request)

Edit an existing Systemconfiguration


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSystemconfigurationID** | **int** | The unique ID of the Systemconfiguration |  |
| **systemconfigurationEditObjectV2Request** | [**SystemconfigurationEditObjectV2Request**](SystemconfigurationEditObjectV2Request.md) |  |  |

### Return type

[**SystemconfigurationEditObjectV2Response**](SystemconfigurationEditObjectV2Response.md)

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

<a id="systemconfigurationgetobjectv2"></a>
# **SystemconfigurationGetObjectV2**
> SystemconfigurationGetObjectV2Response SystemconfigurationGetObjectV2 (int pkiSystemconfigurationID)

Retrieve an existing Systemconfiguration


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiSystemconfigurationID** | **int** | The unique ID of the Systemconfiguration |  |

### Return type

[**SystemconfigurationGetObjectV2Response**](SystemconfigurationGetObjectV2Response.md)

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

