# eZmaxApi.Api.ObjectBillingentityexternalApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BillingentityexternalGenerateFederationTokenV1**](ObjectBillingentityexternalApi.md#billingentityexternalgeneratefederationtokenv1) | **POST** /1/object/billingentityexternal/{pkiBillingentityexternalID}/generateFederationToken | Generate a federation token |
| [**BillingentityexternalGetAutocompleteV2**](ObjectBillingentityexternalApi.md#billingentityexternalgetautocompletev2) | **GET** /2/object/billingentityexternal/getAutocomplete/{sSelector} | Retrieve Billingentityexternals and IDs |

<a id="billingentityexternalgeneratefederationtokenv1"></a>
# **BillingentityexternalGenerateFederationTokenV1**
> BillingentityexternalGenerateFederationTokenV1Response BillingentityexternalGenerateFederationTokenV1 (int pkiBillingentityexternalID, BillingentityexternalGenerateFederationTokenV1Request billingentityexternalGenerateFederationTokenV1Request)

Generate a federation token


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBillingentityexternalID** | **int** |  |  |
| **billingentityexternalGenerateFederationTokenV1Request** | [**BillingentityexternalGenerateFederationTokenV1Request**](BillingentityexternalGenerateFederationTokenV1Request.md) |  |  |

### Return type

[**BillingentityexternalGenerateFederationTokenV1Response**](BillingentityexternalGenerateFederationTokenV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="billingentityexternalgetautocompletev2"></a>
# **BillingentityexternalGetAutocompleteV2**
> BillingentityexternalGetAutocompleteV2Response BillingentityexternalGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Billingentityexternals and IDs

Get the list of Billingentityexternal to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Billingentityexternals to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**BillingentityexternalGetAutocompleteV2Response**](BillingentityexternalGetAutocompleteV2Response.md)

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

