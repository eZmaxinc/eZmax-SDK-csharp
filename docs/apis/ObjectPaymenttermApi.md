# eZmaxApi.Api.ObjectPaymenttermApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PaymenttermCreateObjectV1**](ObjectPaymenttermApi.md#paymenttermcreateobjectv1) | **POST** /1/object/paymentterm | Create a new Paymentterm |
| [**PaymenttermEditObjectV1**](ObjectPaymenttermApi.md#paymenttermeditobjectv1) | **PUT** /1/object/paymentterm/{pkiPaymenttermID} | Edit an existing Paymentterm |
| [**PaymenttermGetAutocompleteV2**](ObjectPaymenttermApi.md#paymenttermgetautocompletev2) | **GET** /2/object/paymentterm/getAutocomplete/{sSelector} | Retrieve Paymentterms and IDs |
| [**PaymenttermGetListV1**](ObjectPaymenttermApi.md#paymenttermgetlistv1) | **GET** /1/object/paymentterm/getList | Retrieve Paymentterm list |
| [**PaymenttermGetObjectV2**](ObjectPaymenttermApi.md#paymenttermgetobjectv2) | **GET** /2/object/paymentterm/{pkiPaymenttermID} | Retrieve an existing Paymentterm |

<a id="paymenttermcreateobjectv1"></a>
# **PaymenttermCreateObjectV1**
> PaymenttermCreateObjectV1Response PaymenttermCreateObjectV1 (PaymenttermCreateObjectV1Request paymenttermCreateObjectV1Request)

Create a new Paymentterm

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymenttermCreateObjectV1Request** | [**PaymenttermCreateObjectV1Request**](PaymenttermCreateObjectV1Request.md) |  |  |

### Return type

[**PaymenttermCreateObjectV1Response**](PaymenttermCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymenttermeditobjectv1"></a>
# **PaymenttermEditObjectV1**
> PaymenttermEditObjectV1Response PaymenttermEditObjectV1 (int pkiPaymenttermID, PaymenttermEditObjectV1Request paymenttermEditObjectV1Request)

Edit an existing Paymentterm


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPaymenttermID** | **int** |  |  |
| **paymenttermEditObjectV1Request** | [**PaymenttermEditObjectV1Request**](PaymenttermEditObjectV1Request.md) |  |  |

### Return type

[**PaymenttermEditObjectV1Response**](PaymenttermEditObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymenttermgetautocompletev2"></a>
# **PaymenttermGetAutocompleteV2**
> PaymenttermGetAutocompleteV2Response PaymenttermGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Paymentterms and IDs

Get the list of Paymentterm to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Paymentterms to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**PaymenttermGetAutocompleteV2Response**](PaymenttermGetAutocompleteV2Response.md)

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

<a id="paymenttermgetlistv1"></a>
# **PaymenttermGetListV1**
> PaymenttermGetListV1Response PaymenttermGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Paymentterm list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**PaymenttermGetListV1Response**](PaymenttermGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymenttermgetobjectv2"></a>
# **PaymenttermGetObjectV2**
> PaymenttermGetObjectV2Response PaymenttermGetObjectV2 (int pkiPaymenttermID)

Retrieve an existing Paymentterm


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPaymenttermID** | **int** |  |  |

### Return type

[**PaymenttermGetObjectV2Response**](PaymenttermGetObjectV2Response.md)

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

