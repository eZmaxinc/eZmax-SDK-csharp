# eZmaxApi.Api.ObjectEzsigntemplateglobalApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzsigntemplateglobalGetAutocompleteV2**](ObjectEzsigntemplateglobalApi.md#ezsigntemplateglobalgetautocompletev2) | **GET** /2/object/ezsigntemplateglobal/getAutocomplete/{sSelector} | Retrieve Ezsigntemplateglobals and IDs |
| [**EzsigntemplateglobalGetObjectV2**](ObjectEzsigntemplateglobalApi.md#ezsigntemplateglobalgetobjectv2) | **GET** /2/object/ezsigntemplateglobal/{pkiEzsigntemplateglobalID} | Retrieve an existing Ezsigntemplateglobal |

<a id="ezsigntemplateglobalgetautocompletev2"></a>
# **EzsigntemplateglobalGetAutocompleteV2**
> EzsigntemplateglobalGetAutocompleteV2Response EzsigntemplateglobalGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Ezsigntemplateglobals and IDs

Get the list of Ezsigntemplateglobal to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezsigntemplateglobals to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**EzsigntemplateglobalGetAutocompleteV2Response**](EzsigntemplateglobalGetAutocompleteV2Response.md)

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

<a id="ezsigntemplateglobalgetobjectv2"></a>
# **EzsigntemplateglobalGetObjectV2**
> EzsigntemplateglobalGetObjectV2Response EzsigntemplateglobalGetObjectV2 (int pkiEzsigntemplateglobalID)

Retrieve an existing Ezsigntemplateglobal


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzsigntemplateglobalID** | **int** |  |  |

### Return type

[**EzsigntemplateglobalGetObjectV2Response**](EzsigntemplateglobalGetObjectV2Response.md)

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

