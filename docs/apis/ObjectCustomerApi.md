# eZmaxApi.Api.ObjectCustomerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomerGetAutocompleteV2**](ObjectCustomerApi.md#customergetautocompletev2) | **GET** /2/object/customer/getAutocomplete/{sSelector} | Retrieve Customers and IDs |
| [**CustomerGetObjectV2**](ObjectCustomerApi.md#customergetobjectv2) | **GET** /2/object/customer/{pkiCustomerID} | Retrieve an existing Customer |
| [**CustomerImportIntoEDMV1**](ObjectCustomerApi.md#customerimportintoedmv1) | **POST** /1/object/customer/{pkiCustomerID}/importIntoEDM | Import attachments into the Customer |

<a id="customergetautocompletev2"></a>
# **CustomerGetAutocompleteV2**
> CustomerGetAutocompleteV2Response CustomerGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Customers and IDs

Get the list of Customer to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Customers to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**CustomerGetAutocompleteV2Response**](CustomerGetAutocompleteV2Response.md)

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

<a id="customergetobjectv2"></a>
# **CustomerGetObjectV2**
> CustomerGetObjectV2Response CustomerGetObjectV2 (int pkiCustomerID)

Retrieve an existing Customer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCustomerID** | **int** | The unique ID of the Customer |  |

### Return type

[**CustomerGetObjectV2Response**](CustomerGetObjectV2Response.md)

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

<a id="customerimportintoedmv1"></a>
# **CustomerImportIntoEDMV1**
> CustomerImportIntoEDMV1Response CustomerImportIntoEDMV1 (int pkiCustomerID, CustomerImportIntoEDMV1Request customerImportIntoEDMV1Request)

Import attachments into the Customer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCustomerID** | **int** |  |  |
| **customerImportIntoEDMV1Request** | [**CustomerImportIntoEDMV1Request**](CustomerImportIntoEDMV1Request.md) |  |  |

### Return type

[**CustomerImportIntoEDMV1Response**](CustomerImportIntoEDMV1Response.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

