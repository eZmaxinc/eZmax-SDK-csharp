# eZmaxApi.Api.ObjectInscriptiontypeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InscriptiontypeGetAutocompleteV2**](ObjectInscriptiontypeApi.md#inscriptiontypegetautocompletev2) | **GET** /2/object/inscriptiontype/getAutocomplete/{sSelector} | Retrieve Inscriptiontypes and IDs |

<a id="inscriptiontypegetautocompletev2"></a>
# **InscriptiontypeGetAutocompleteV2**
> InscriptiontypeGetAutocompleteV2Response InscriptiontypeGetAutocompleteV2 (string sSelector, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Inscriptiontypes and IDs

Get the list of Inscriptiontype to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Inscriptiontypes to return |  |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**InscriptiontypeGetAutocompleteV2Response**](InscriptiontypeGetAutocompleteV2Response.md)

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

