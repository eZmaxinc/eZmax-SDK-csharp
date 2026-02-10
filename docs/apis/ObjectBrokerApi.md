# eZmaxApi.Api.ObjectBrokerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BrokerGetAutocompleteV2**](ObjectBrokerApi.md#brokergetautocompletev2) | **GET** /2/object/broker/getAutocomplete/{sSelector} | Retrieve Brokers and IDs |
| [**BrokerGetListV1**](ObjectBrokerApi.md#brokergetlistv1) | **GET** /1/object/broker/getList | Retrieve Broker list |
| [**BrokerImportIntoEDMV1**](ObjectBrokerApi.md#brokerimportintoedmv1) | **POST** /1/object/broker/{pkiBrokerID}/importIntoEDM | Import attachments into the Broker |

<a id="brokergetautocompletev2"></a>
# **BrokerGetAutocompleteV2**
> BrokerGetAutocompleteV2Response BrokerGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Brokers and IDs

Get the list of Broker to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Brokers to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**BrokerGetAutocompleteV2Response**](BrokerGetAutocompleteV2Response.md)

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

<a id="brokergetlistv1"></a>
# **BrokerGetListV1**
> BrokerGetListV1Response BrokerGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Broker list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**BrokerGetListV1Response**](BrokerGetListV1Response.md)

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

<a id="brokerimportintoedmv1"></a>
# **BrokerImportIntoEDMV1**
> BrokerImportIntoEDMV1Response BrokerImportIntoEDMV1 (int pkiBrokerID, BrokerImportIntoEDMV1Request brokerImportIntoEDMV1Request)

Import attachments into the Broker


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiBrokerID** | **int** |  |  |
| **brokerImportIntoEDMV1Request** | [**BrokerImportIntoEDMV1Request**](BrokerImportIntoEDMV1Request.md) |  |  |

### Return type

[**BrokerImportIntoEDMV1Response**](BrokerImportIntoEDMV1Response.md)

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

