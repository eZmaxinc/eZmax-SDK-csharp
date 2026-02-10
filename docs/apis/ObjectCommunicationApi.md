# eZmaxApi.Api.ObjectCommunicationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CommunicationGetCommunicationBodyV1**](ObjectCommunicationApi.md#communicationgetcommunicationbodyv1) | **GET** /1/object/communication/{pkiCommunicationID}/getCommunicationBody | Retrieve the communication body |
| [**CommunicationSendV1**](ObjectCommunicationApi.md#communicationsendv1) | **POST** /1/object/communication/send | Send a new Communication |

<a id="communicationgetcommunicationbodyv1"></a>
# **CommunicationGetCommunicationBodyV1**
> void CommunicationGetCommunicationBodyV1 (int pkiCommunicationID)

Retrieve the communication body

This endpoint returns the communication body.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCommunicationID** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="communicationsendv1"></a>
# **CommunicationSendV1**
> CommunicationSendV1Response CommunicationSendV1 (CommunicationSendV1Request communicationSendV1Request)

Send a new Communication

The endpoint allows to send one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **communicationSendV1Request** | [**CommunicationSendV1Request**](CommunicationSendV1Request.md) |  |  |

### Return type

[**CommunicationSendV1Response**](CommunicationSendV1Response.md)

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

