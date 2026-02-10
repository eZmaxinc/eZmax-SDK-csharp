# eZmaxApi.Api.ObjectOtherincometypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OtherincometypeGetAutocompleteV2**](ObjectOtherincometypeApi.md#otherincometypegetautocompletev2) | **GET** /2/object/otherincometype/getAutocomplete/{sSelector} | Retrieve Otherincometypes and IDs |

<a id="otherincometypegetautocompletev2"></a>
# **OtherincometypeGetAutocompleteV2**
> OtherincometypeGetAutocompleteV2Response OtherincometypeGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Otherincometypes and IDs

Get the list of Otherincometype to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Otherincometypes to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**OtherincometypeGetAutocompleteV2Response**](OtherincometypeGetAutocompleteV2Response.md)

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

