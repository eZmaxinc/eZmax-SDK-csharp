# eZmaxApi.Api.ObjectWebhookApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookCreateObjectV2**](ObjectWebhookApi.md#webhookcreateobjectv2) | **POST** /2/object/webhook | Create a new Webhook |
| [**WebhookDeleteObjectV1**](ObjectWebhookApi.md#webhookdeleteobjectv1) | **DELETE** /1/object/webhook/{pkiWebhookID} | Delete an existing Webhook |
| [**WebhookEditObjectV1**](ObjectWebhookApi.md#webhookeditobjectv1) | **PUT** /1/object/webhook/{pkiWebhookID} | Edit an existing Webhook |
| [**WebhookGetHistoryV1**](ObjectWebhookApi.md#webhookgethistoryv1) | **GET** /1/object/webhook/{pkiWebhookID}/getHistory | Retrieve the logs for recent Webhook calls |
| [**WebhookGetListV1**](ObjectWebhookApi.md#webhookgetlistv1) | **GET** /1/object/webhook/getList | Retrieve Webhook list |
| [**WebhookGetObjectV2**](ObjectWebhookApi.md#webhookgetobjectv2) | **GET** /2/object/webhook/{pkiWebhookID} | Retrieve an existing Webhook |
| [**WebhookRegenerateApikeyV1**](ObjectWebhookApi.md#webhookregenerateapikeyv1) | **POST** /1/object/webhook/{pkiWebhookID}/regenerateApikey | Regenerate the Apikey |
| [**WebhookSendWebhookV1**](ObjectWebhookApi.md#webhooksendwebhookv1) | **POST** /1/object/webhook/sendWebhook | Emit a Webhook event |
| [**WebhookTestV1**](ObjectWebhookApi.md#webhooktestv1) | **POST** /1/object/webhook/{pkiWebhookID}/test | Test the Webhook by calling the Url |

<a id="webhookcreateobjectv2"></a>
# **WebhookCreateObjectV2**
> WebhookCreateObjectV2Response WebhookCreateObjectV2 (WebhookCreateObjectV2Request webhookCreateObjectV2Request)

Create a new Webhook

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookCreateObjectV2Request** | [**WebhookCreateObjectV2Request**](WebhookCreateObjectV2Request.md) |  |  |

### Return type

[**WebhookCreateObjectV2Response**](WebhookCreateObjectV2Response.md)

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

<a id="webhookdeleteobjectv1"></a>
# **WebhookDeleteObjectV1**
> WebhookDeleteObjectV1Response WebhookDeleteObjectV1 (int pkiWebhookID)

Delete an existing Webhook


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |

### Return type

[**WebhookDeleteObjectV1Response**](WebhookDeleteObjectV1Response.md)

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

<a id="webhookeditobjectv1"></a>
# **WebhookEditObjectV1**
> WebhookEditObjectV1Response WebhookEditObjectV1 (int pkiWebhookID, WebhookEditObjectV1Request webhookEditObjectV1Request)

Edit an existing Webhook


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
| **webhookEditObjectV1Request** | [**WebhookEditObjectV1Request**](WebhookEditObjectV1Request.md) |  |  |

### Return type

[**WebhookEditObjectV1Response**](WebhookEditObjectV1Response.md)

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

<a id="webhookgethistoryv1"></a>
# **WebhookGetHistoryV1**
> WebhookGetHistoryV1Response WebhookGetHistoryV1 (int pkiWebhookID, string eWebhookHistoryinterval)

Retrieve the logs for recent Webhook calls


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
| **eWebhookHistoryinterval** | **string** | The number of days to return |  |

### Return type

[**WebhookGetHistoryV1Response**](WebhookGetHistoryV1Response.md)

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
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookgetlistv1"></a>
# **WebhookGetListV1**
> WebhookGetListV1Response WebhookGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Webhook list

Enum values that can be filtered in query parameter *sFilter*:  | Variable | Valid values | |- --|- --| | eWebhookModule | Ezsign<br>Management | | eWebhookEzsignevent | DocumentCompleted<br>FolderCompleted | | eWebhookManagementevent | UserCreated |


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**WebhookGetListV1Response**](WebhookGetListV1Response.md)

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

<a id="webhookgetobjectv2"></a>
# **WebhookGetObjectV2**
> WebhookGetObjectV2Response WebhookGetObjectV2 (int pkiWebhookID)

Retrieve an existing Webhook


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |

### Return type

[**WebhookGetObjectV2Response**](WebhookGetObjectV2Response.md)

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

<a id="webhookregenerateapikeyv1"></a>
# **WebhookRegenerateApikeyV1**
> WebhookRegenerateApikeyV1Response WebhookRegenerateApikeyV1 (int pkiWebhookID, WebhookRegenerateApikeyV1Request webhookRegenerateApikeyV1Request)

Regenerate the Apikey


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
| **webhookRegenerateApikeyV1Request** | [**WebhookRegenerateApikeyV1Request**](WebhookRegenerateApikeyV1Request.md) |  |  |

### Return type

[**WebhookRegenerateApikeyV1Response**](WebhookRegenerateApikeyV1Response.md)

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

<a id="webhooksendwebhookv1"></a>
# **WebhookSendWebhookV1**
> WebhookSendWebhookV1Response WebhookSendWebhookV1 (WebhookSendWebhookV1Request webhookSendWebhookV1Request)

Emit a Webhook event


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookSendWebhookV1Request** | [**WebhookSendWebhookV1Request**](WebhookSendWebhookV1Request.md) |  |  |

### Return type

[**WebhookSendWebhookV1Response**](WebhookSendWebhookV1Response.md)

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

<a id="webhooktestv1"></a>
# **WebhookTestV1**
> WebhookTestV1Response WebhookTestV1 (int pkiWebhookID, Object body)

Test the Webhook by calling the Url


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiWebhookID** | **int** |  |  |
| **body** | **Object** |  |  |

### Return type

[**WebhookTestV1Response**](WebhookTestV1Response.md)

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

