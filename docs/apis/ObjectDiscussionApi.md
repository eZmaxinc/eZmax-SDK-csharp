# eZmaxApi.Api.ObjectDiscussionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiscussionChatV1**](ObjectDiscussionApi.md#discussionchatv1) | **POST** /1/object/discussion/chat | Have a Discussion with the AI Chatbot |
| [**DiscussionCreateObjectV1**](ObjectDiscussionApi.md#discussioncreateobjectv1) | **POST** /1/object/discussion | Create a new Discussion |
| [**DiscussionDeleteObjectV1**](ObjectDiscussionApi.md#discussiondeleteobjectv1) | **DELETE** /1/object/discussion/{pkiDiscussionID} | Delete an existing Discussion |
| [**DiscussionGetObjectV2**](ObjectDiscussionApi.md#discussiongetobjectv2) | **GET** /2/object/discussion/{pkiDiscussionID} | Retrieve an existing Discussion |
| [**DiscussionPatchObjectV1**](ObjectDiscussionApi.md#discussionpatchobjectv1) | **PATCH** /1/object/discussion/{pkiDiscussionID} | Patch an existing Discussion |
| [**DiscussionUpdateDiscussionreadstatusV1**](ObjectDiscussionApi.md#discussionupdatediscussionreadstatusv1) | **POST** /1/object/discussion/{pkiDiscussionID}/updateDiscussionreadstatus | Update the read status of the discussion |

<a id="discussionchatv1"></a>
# **DiscussionChatV1**
> DiscussionChatV1200Response DiscussionChatV1 (DiscussionChatV1Request discussionChatV1Request)

Have a Discussion with the AI Chatbot

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **discussionChatV1Request** | [**DiscussionChatV1Request**](DiscussionChatV1Request.md) |  |  |

### Return type

[**DiscussionChatV1200Response**](DiscussionChatV1200Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/event-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="discussioncreateobjectv1"></a>
# **DiscussionCreateObjectV1**
> DiscussionCreateObjectV1Response DiscussionCreateObjectV1 (DiscussionCreateObjectV1Request discussionCreateObjectV1Request)

Create a new Discussion

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **discussionCreateObjectV1Request** | [**DiscussionCreateObjectV1Request**](DiscussionCreateObjectV1Request.md) |  |  |

### Return type

[**DiscussionCreateObjectV1Response**](DiscussionCreateObjectV1Response.md)

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

<a id="discussiondeleteobjectv1"></a>
# **DiscussionDeleteObjectV1**
> DiscussionDeleteObjectV1Response DiscussionDeleteObjectV1 (int pkiDiscussionID)

Delete an existing Discussion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionID** | **int** | The unique ID of the Discussion |  |

### Return type

[**DiscussionDeleteObjectV1Response**](DiscussionDeleteObjectV1Response.md)

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

<a id="discussiongetobjectv2"></a>
# **DiscussionGetObjectV2**
> DiscussionGetObjectV2Response DiscussionGetObjectV2 (int pkiDiscussionID)

Retrieve an existing Discussion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionID** | **int** | The unique ID of the Discussion |  |

### Return type

[**DiscussionGetObjectV2Response**](DiscussionGetObjectV2Response.md)

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

<a id="discussionpatchobjectv1"></a>
# **DiscussionPatchObjectV1**
> DiscussionPatchObjectV1Response DiscussionPatchObjectV1 (int pkiDiscussionID, DiscussionPatchObjectV1Request discussionPatchObjectV1Request)

Patch an existing Discussion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionID** | **int** | The unique ID of the Discussion |  |
| **discussionPatchObjectV1Request** | [**DiscussionPatchObjectV1Request**](DiscussionPatchObjectV1Request.md) |  |  |

### Return type

[**DiscussionPatchObjectV1Response**](DiscussionPatchObjectV1Response.md)

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

<a id="discussionupdatediscussionreadstatusv1"></a>
# **DiscussionUpdateDiscussionreadstatusV1**
> DiscussionUpdateDiscussionreadstatusV1Response DiscussionUpdateDiscussionreadstatusV1 (int pkiDiscussionID, DiscussionUpdateDiscussionreadstatusV1Request discussionUpdateDiscussionreadstatusV1Request)

Update the read status of the discussion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionID** | **int** |  |  |
| **discussionUpdateDiscussionreadstatusV1Request** | [**DiscussionUpdateDiscussionreadstatusV1Request**](DiscussionUpdateDiscussionreadstatusV1Request.md) |  |  |

### Return type

[**DiscussionUpdateDiscussionreadstatusV1Response**](DiscussionUpdateDiscussionreadstatusV1Response.md)

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

