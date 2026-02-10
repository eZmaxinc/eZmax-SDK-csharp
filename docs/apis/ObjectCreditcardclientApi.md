# eZmaxApi.Api.ObjectCreditcardclientApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreditcardclientCreateObjectV1**](ObjectCreditcardclientApi.md#creditcardclientcreateobjectv1) | **POST** /1/object/creditcardclient | Create a new Creditcardclient |
| [**CreditcardclientDeleteObjectV1**](ObjectCreditcardclientApi.md#creditcardclientdeleteobjectv1) | **DELETE** /1/object/creditcardclient/{pkiCreditcardclientID} | Delete an existing Creditcardclient |
| [**CreditcardclientEditObjectV1**](ObjectCreditcardclientApi.md#creditcardclienteditobjectv1) | **PUT** /1/object/creditcardclient/{pkiCreditcardclientID} | Edit an existing Creditcardclient |
| [**CreditcardclientGetAutocompleteV2**](ObjectCreditcardclientApi.md#creditcardclientgetautocompletev2) | **GET** /2/object/creditcardclient/getAutocomplete/{sSelector} | Retrieve Creditcardclients and IDs |
| [**CreditcardclientGetListV1**](ObjectCreditcardclientApi.md#creditcardclientgetlistv1) | **GET** /1/object/creditcardclient/getList | Retrieve Creditcardclient list |
| [**CreditcardclientGetObjectV2**](ObjectCreditcardclientApi.md#creditcardclientgetobjectv2) | **GET** /2/object/creditcardclient/{pkiCreditcardclientID} | Retrieve an existing Creditcardclient |
| [**CreditcardclientPatchObjectV1**](ObjectCreditcardclientApi.md#creditcardclientpatchobjectv1) | **PATCH** /1/object/creditcardclient/{pkiCreditcardclientID} | Patch an existing Creditcardclient |

<a id="creditcardclientcreateobjectv1"></a>
# **CreditcardclientCreateObjectV1**
> CreditcardclientCreateObjectV1Response CreditcardclientCreateObjectV1 (CreditcardclientCreateObjectV1Request creditcardclientCreateObjectV1Request)

Create a new Creditcardclient

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **creditcardclientCreateObjectV1Request** | [**CreditcardclientCreateObjectV1Request**](CreditcardclientCreateObjectV1Request.md) |  |  |

### Return type

[**CreditcardclientCreateObjectV1Response**](CreditcardclientCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="creditcardclientdeleteobjectv1"></a>
# **CreditcardclientDeleteObjectV1**
> CreditcardclientDeleteObjectV1Response CreditcardclientDeleteObjectV1 (int pkiCreditcardclientID)

Delete an existing Creditcardclient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCreditcardclientID** | **int** | The unique ID of the Creditcardclient |  |

### Return type

[**CreditcardclientDeleteObjectV1Response**](CreditcardclientDeleteObjectV1Response.md)

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

<a id="creditcardclienteditobjectv1"></a>
# **CreditcardclientEditObjectV1**
> CreditcardclientEditObjectV1Response CreditcardclientEditObjectV1 (int pkiCreditcardclientID, CreditcardclientEditObjectV1Request creditcardclientEditObjectV1Request)

Edit an existing Creditcardclient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCreditcardclientID** | **int** | The unique ID of the Creditcardclient |  |
| **creditcardclientEditObjectV1Request** | [**CreditcardclientEditObjectV1Request**](CreditcardclientEditObjectV1Request.md) |  |  |

### Return type

[**CreditcardclientEditObjectV1Response**](CreditcardclientEditObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="creditcardclientgetautocompletev2"></a>
# **CreditcardclientGetAutocompleteV2**
> CreditcardclientGetAutocompleteV2Response CreditcardclientGetAutocompleteV2 (string sSelector, string eFilterActive = null, string sQuery = null, HeaderAcceptLanguage acceptLanguage = null)

Retrieve Creditcardclients and IDs

Get the list of Creditcardclient to be used in a dropdown or autocomplete control.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Creditcardclients to return |  |
| **eFilterActive** | **string** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |

### Return type

[**CreditcardclientGetAutocompleteV2Response**](CreditcardclientGetAutocompleteV2Response.md)

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

<a id="creditcardclientgetlistv1"></a>
# **CreditcardclientGetListV1**
> CreditcardclientGetListV1Response CreditcardclientGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Creditcardclient list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**CreditcardclientGetListV1Response**](CreditcardclientGetListV1Response.md)

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

<a id="creditcardclientgetobjectv2"></a>
# **CreditcardclientGetObjectV2**
> CreditcardclientGetObjectV2Response CreditcardclientGetObjectV2 (int pkiCreditcardclientID)

Retrieve an existing Creditcardclient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCreditcardclientID** | **int** | The unique ID of the Creditcardclient |  |

### Return type

[**CreditcardclientGetObjectV2Response**](CreditcardclientGetObjectV2Response.md)

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

<a id="creditcardclientpatchobjectv1"></a>
# **CreditcardclientPatchObjectV1**
> CreditcardclientPatchObjectV1Response CreditcardclientPatchObjectV1 (int pkiCreditcardclientID, CreditcardclientPatchObjectV1Request creditcardclientPatchObjectV1Request)

Patch an existing Creditcardclient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCreditcardclientID** | **int** | The unique ID of the Creditcardclient |  |
| **creditcardclientPatchObjectV1Request** | [**CreditcardclientPatchObjectV1Request**](CreditcardclientPatchObjectV1Request.md) |  |  |

### Return type

[**CreditcardclientPatchObjectV1Response**](CreditcardclientPatchObjectV1Response.md)

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

