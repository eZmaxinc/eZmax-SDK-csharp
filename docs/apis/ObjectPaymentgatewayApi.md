# eZmaxApi.Api.ObjectPaymentgatewayApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PaymentgatewayCreateObjectV1**](ObjectPaymentgatewayApi.md#paymentgatewaycreateobjectv1) | **POST** /1/object/paymentgateway | Create a new Paymentgateway |
| [**PaymentgatewayEditObjectV1**](ObjectPaymentgatewayApi.md#paymentgatewayeditobjectv1) | **PUT** /1/object/paymentgateway/{pkiPaymentgatewayID} | Edit an existing Paymentgateway |
| [**PaymentgatewayGetAutocompleteV2**](ObjectPaymentgatewayApi.md#paymentgatewaygetautocompletev2) | **GET** /2/object/paymentgateway/getAutocomplete/{sSelector} | Retrieve Paymentgateways and IDs |
| [**PaymentgatewayGetListV1**](ObjectPaymentgatewayApi.md#paymentgatewaygetlistv1) | **GET** /1/object/paymentgateway/getList | Retrieve Paymentgateway list |
| [**PaymentgatewayGetObjectV2**](ObjectPaymentgatewayApi.md#paymentgatewaygetobjectv2) | **GET** /2/object/paymentgateway/{pkiPaymentgatewayID} | Retrieve an existing Paymentgateway |

<a id="paymentgatewaycreateobjectv1"></a>
# **PaymentgatewayCreateObjectV1**
> PaymentgatewayCreateObjectV1Response PaymentgatewayCreateObjectV1 (PaymentgatewayCreateObjectV1Request paymentgatewayCreateObjectV1Request)

Create a new Paymentgateway

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentgatewayCreateObjectV1Request** | [**PaymentgatewayCreateObjectV1Request**](PaymentgatewayCreateObjectV1Request.md) |  |  |

### Return type

[**PaymentgatewayCreateObjectV1Response**](PaymentgatewayCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymentgatewayeditobjectv1"></a>
# **PaymentgatewayEditObjectV1**
> PaymentgatewayEditObjectV1Response PaymentgatewayEditObjectV1 (int pkiPaymentgatewayID, PaymentgatewayEditObjectV1Request paymentgatewayEditObjectV1Request)

Edit an existing Paymentgateway


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPaymentgatewayID** | **int** | The unique ID of the Paymentgateway |  |
| **paymentgatewayEditObjectV1Request** | [**PaymentgatewayEditObjectV1Request**](PaymentgatewayEditObjectV1Request.md) |  |  |

### Return type

[**PaymentgatewayEditObjectV1Response**](PaymentgatewayEditObjectV1Response.md)

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

<a id="paymentgatewaygetautocompletev2"></a>
# **PaymentgatewayGetAutocompleteV2**
> PaymentgatewayGetAutocompleteV2Response PaymentgatewayGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Paymentgateways and IDs

Get the list of Paymentgateway to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Paymentgateways to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**PaymentgatewayGetAutocompleteV2Response**](PaymentgatewayGetAutocompleteV2Response.md)

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

<a id="paymentgatewaygetlistv1"></a>
# **PaymentgatewayGetListV1**
> PaymentgatewayGetListV1Response PaymentgatewayGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Paymentgateway list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | ePaymentgatewayProcessor | Moneris |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**PaymentgatewayGetListV1Response**](PaymentgatewayGetListV1Response.md)

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

<a id="paymentgatewaygetobjectv2"></a>
# **PaymentgatewayGetObjectV2**
> PaymentgatewayGetObjectV2Response PaymentgatewayGetObjectV2 (int pkiPaymentgatewayID)

Retrieve an existing Paymentgateway


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiPaymentgatewayID** | **int** | The unique ID of the Paymentgateway |  |

### Return type

[**PaymentgatewayGetObjectV2Response**](PaymentgatewayGetObjectV2Response.md)

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

