# eZmaxApi.Api.ObjectContacttitleApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContacttitleGetAutocompleteV2**](ObjectContacttitleApi.md#contacttitlegetautocompletev2) | **GET** /2/object/contacttitle/getAutocomplete/{sSelector} | Retrieve Contacttitles and IDs |

<a id="contacttitlegetautocompletev2"></a>
# **ContacttitleGetAutocompleteV2**
> ContacttitleGetAutocompleteV2Response ContacttitleGetAutocompleteV2 (string sSelector, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Contacttitles and IDs

Get the list of Contacttitle to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Contacttitles to return |  |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**ContacttitleGetAutocompleteV2Response**](ContacttitleGetAutocompleteV2Response.md)

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

