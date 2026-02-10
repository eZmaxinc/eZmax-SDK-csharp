# eZmaxApi.Api.ObjectUserlogintypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserlogintypeGetAutocompleteV2**](ObjectUserlogintypeApi.md#userlogintypegetautocompletev2) | **GET** /2/object/userlogintype/getAutocomplete/{sSelector} | Retrieve Userlogintypes and IDs |

<a id="userlogintypegetautocompletev2"></a>
# **UserlogintypeGetAutocompleteV2**
> UserlogintypeGetAutocompleteV2Response UserlogintypeGetAutocompleteV2 (string sSelector, int fkiEzsignfoldertypeID = null, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Userlogintypes and IDs

Get the list of Userlogintype to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Userlogintypes to return |  |
| **fkiEzsignfoldertypeID** | **int** |  | [optional]  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**UserlogintypeGetAutocompleteV2Response**](UserlogintypeGetAutocompleteV2Response.md)

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

