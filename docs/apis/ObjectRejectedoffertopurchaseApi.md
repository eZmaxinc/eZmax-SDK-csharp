# eZmaxApi.Api.ObjectRejectedoffertopurchaseApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RejectedoffertopurchaseGetCommunicationCountV1**](ObjectRejectedoffertopurchaseApi.md#rejectedoffertopurchasegetcommunicationcountv1) | **GET** /1/object/rejectedoffertopurchase/{pkiRejectedoffertopurchaseID}/getCommunicationCount | Retrieve Communication count |
| [**RejectedoffertopurchaseGetCommunicationListV1**](ObjectRejectedoffertopurchaseApi.md#rejectedoffertopurchasegetcommunicationlistv1) | **GET** /1/object/rejectedoffertopurchase/{pkiRejectedoffertopurchaseID}/getCommunicationList | Retrieve Communication list |
| [**RejectedoffertopurchaseGetCommunicationrecipientsV1**](ObjectRejectedoffertopurchaseApi.md#rejectedoffertopurchasegetcommunicationrecipientsv1) | **GET** /1/object/rejectedoffertopurchase/{pkiRejectedoffertopurchaseID}/getCommunicationrecipients | Retrieve Rejectedoffertopurchase&#39;s Communicationrecipient |
| [**RejectedoffertopurchaseGetCommunicationsendersV1**](ObjectRejectedoffertopurchaseApi.md#rejectedoffertopurchasegetcommunicationsendersv1) | **GET** /1/object/rejectedoffertopurchase/{pkiRejectedoffertopurchaseID}/getCommunicationsenders | Retrieve Rejectedoffertopurchase&#39;s Communicationsender |
| [**RejectedoffertopurchaseGetListV1**](ObjectRejectedoffertopurchaseApi.md#rejectedoffertopurchasegetlistv1) | **GET** /1/object/rejectedoffertopurchase/getList | Retrieve Rejectedoffertopurchase list |
| [**RejectedoffertopurchaseImportIntoEDMV1**](ObjectRejectedoffertopurchaseApi.md#rejectedoffertopurchaseimportintoedmv1) | **POST** /1/object/rejectedoffertopurchase/{pkiRejectedoffertopurchaseID}/importIntoEDM | Import attachments into the Rejectedoffertopurchase |

<a id="rejectedoffertopurchasegetcommunicationcountv1"></a>
# **RejectedoffertopurchaseGetCommunicationCountV1**
> RejectedoffertopurchaseGetCommunicationCountV1Response RejectedoffertopurchaseGetCommunicationCountV1 (int pkiRejectedoffertopurchaseID)

Retrieve Communication count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiRejectedoffertopurchaseID** | **int** |  |  |

### Return type

[**RejectedoffertopurchaseGetCommunicationCountV1Response**](RejectedoffertopurchaseGetCommunicationCountV1Response.md)

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

<a id="rejectedoffertopurchasegetcommunicationlistv1"></a>
# **RejectedoffertopurchaseGetCommunicationListV1**
> RejectedoffertopurchaseGetCommunicationListV1Response RejectedoffertopurchaseGetCommunicationListV1 (int pkiRejectedoffertopurchaseID)

Retrieve Communication list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiRejectedoffertopurchaseID** | **int** |  |  |

### Return type

[**RejectedoffertopurchaseGetCommunicationListV1Response**](RejectedoffertopurchaseGetCommunicationListV1Response.md)

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

<a id="rejectedoffertopurchasegetcommunicationrecipientsv1"></a>
# **RejectedoffertopurchaseGetCommunicationrecipientsV1**
> RejectedoffertopurchaseGetCommunicationrecipientsV1Response RejectedoffertopurchaseGetCommunicationrecipientsV1 (int pkiRejectedoffertopurchaseID)

Retrieve Rejectedoffertopurchase's Communicationrecipient


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiRejectedoffertopurchaseID** | **int** |  |  |

### Return type

[**RejectedoffertopurchaseGetCommunicationrecipientsV1Response**](RejectedoffertopurchaseGetCommunicationrecipientsV1Response.md)

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

<a id="rejectedoffertopurchasegetcommunicationsendersv1"></a>
# **RejectedoffertopurchaseGetCommunicationsendersV1**
> RejectedoffertopurchaseGetCommunicationsendersV1Response RejectedoffertopurchaseGetCommunicationsendersV1 (int pkiRejectedoffertopurchaseID)

Retrieve Rejectedoffertopurchase's Communicationsender


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiRejectedoffertopurchaseID** | **int** |  |  |

### Return type

[**RejectedoffertopurchaseGetCommunicationsendersV1Response**](RejectedoffertopurchaseGetCommunicationsendersV1Response.md)

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

<a id="rejectedoffertopurchasegetlistv1"></a>
# **RejectedoffertopurchaseGetListV1**
> RejectedoffertopurchaseGetListV1Response RejectedoffertopurchaseGetListV1 (string eOrderBy = null, int iRowMax = null, int iRowOffset = null, HeaderAcceptLanguage acceptLanguage = null, string sFilter = null)

Retrieve Rejectedoffertopurchase list


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int** |  | [optional]  |
| **iRowOffset** | **int** |  | [optional] [default to 0] |
| **acceptLanguage** | **HeaderAcceptLanguage** |  | [optional]  |
| **sFilter** | **string** |  | [optional]  |

### Return type

[**RejectedoffertopurchaseGetListV1Response**](RejectedoffertopurchaseGetListV1Response.md)

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

<a id="rejectedoffertopurchaseimportintoedmv1"></a>
# **RejectedoffertopurchaseImportIntoEDMV1**
> RejectedoffertopurchaseImportIntoEDMV1Response RejectedoffertopurchaseImportIntoEDMV1 (int pkiRejectedoffertopurchaseID, RejectedoffertopurchaseImportIntoEDMV1Request rejectedoffertopurchaseImportIntoEDMV1Request)

Import attachments into the Rejectedoffertopurchase


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiRejectedoffertopurchaseID** | **int** |  |  |
| **rejectedoffertopurchaseImportIntoEDMV1Request** | [**RejectedoffertopurchaseImportIntoEDMV1Request**](RejectedoffertopurchaseImportIntoEDMV1Request.md) |  |  |

### Return type

[**RejectedoffertopurchaseImportIntoEDMV1Response**](RejectedoffertopurchaseImportIntoEDMV1Response.md)

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

