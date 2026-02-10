# eZmaxApi.Api.ObjectEzmaxinvoicingApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EzmaxinvoicingGetAutocompleteV2**](ObjectEzmaxinvoicingApi.md#ezmaxinvoicinggetautocompletev2) | **GET** /2/object/ezmaxinvoicing/getAutocomplete/{sSelector} | Retrieve Ezmaxinvoicings and IDs |
| [**EzmaxinvoicingGetObjectV2**](ObjectEzmaxinvoicingApi.md#ezmaxinvoicinggetobjectv2) | **GET** /2/object/ezmaxinvoicing/{pkiEzmaxinvoicingID} | Retrieve an existing Ezmaxinvoicing |
| [**EzmaxinvoicingGetProvisionalV1**](ObjectEzmaxinvoicingApi.md#ezmaxinvoicinggetprovisionalv1) | **GET** /1/object/ezmaxinvoicing/getProvisional | Retrieve provisional Ezmaxinvoicing |

<a id="ezmaxinvoicinggetautocompletev2"></a>
# **EzmaxinvoicingGetAutocompleteV2**
> EzmaxinvoicingGetAutocompleteV2Response EzmaxinvoicingGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Ezmaxinvoicings and IDs

Get the list of Ezmaxinvoicing to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Ezmaxinvoicings to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**EzmaxinvoicingGetAutocompleteV2Response**](EzmaxinvoicingGetAutocompleteV2Response.md)

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

<a id="ezmaxinvoicinggetobjectv2"></a>
# **EzmaxinvoicingGetObjectV2**
> EzmaxinvoicingGetObjectV2Response EzmaxinvoicingGetObjectV2 (int pkiEzmaxinvoicingID)

Retrieve an existing Ezmaxinvoicing


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiEzmaxinvoicingID** | **int** |  |  |

### Return type

[**EzmaxinvoicingGetObjectV2Response**](EzmaxinvoicingGetObjectV2Response.md)

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

<a id="ezmaxinvoicinggetprovisionalv1"></a>
# **EzmaxinvoicingGetProvisionalV1**
> EzmaxinvoicingGetProvisionalV1Response EzmaxinvoicingGetProvisionalV1 ()

Retrieve provisional Ezmaxinvoicing


### Parameters
This endpoint does not need any parameter.
### Return type

[**EzmaxinvoicingGetProvisionalV1Response**](EzmaxinvoicingGetProvisionalV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

