# eZmaxApi.Api.ObjectPdfalevelApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PdfalevelGetAutocompleteV2**](ObjectPdfalevelApi.md#pdfalevelgetautocompletev2) | **GET** /2/object/pdfalevel/getAutocomplete/{sSelector} | Retrieve Pdfalevels and IDs |

<a id="pdfalevelgetautocompletev2"></a>
# **PdfalevelGetAutocompleteV2**
> PdfalevelGetAutocompleteV2Response PdfalevelGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Pdfalevels and IDs

Get the list of Pdfalevel to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Pdfalevels to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**PdfalevelGetAutocompleteV2Response**](PdfalevelGetAutocompleteV2Response.md)

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

