# eZmaxApi.Api.ObjectRealestateboardApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RealestateboardGetAutocompleteV2**](ObjectRealestateboardApi.md#realestateboardgetautocompletev2) | **GET** /2/object/realestateboard/getAutocomplete/{sSelector} | Retrieve Realestateboards and IDs |

<a id="realestateboardgetautocompletev2"></a>
# **RealestateboardGetAutocompleteV2**
> RealestateboardGetAutocompleteV2Response RealestateboardGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null, string fkiProvinceID = null)

Retrieve Realestateboards and IDs

Get the list of realestateboard to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Realestateboards to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **fkiProvinceID** | **string** | The province ID to filter the results expected | [optional]  |

### Return type

[**RealestateboardGetAutocompleteV2Response**](RealestateboardGetAutocompleteV2Response.md)

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

