# eZmaxApi.Api.ObjectDiscussionmessageApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiscussionmessageCreateObjectV1**](ObjectDiscussionmessageApi.md#discussionmessagecreateobjectv1) | **POST** /1/object/discussionmessage | Create a new Discussionmessage |
| [**DiscussionmessageDeleteObjectV1**](ObjectDiscussionmessageApi.md#discussionmessagedeleteobjectv1) | **DELETE** /1/object/discussionmessage/{pkiDiscussionmessageID} | Delete an existing Discussionmessage |
| [**DiscussionmessagePatchObjectV1**](ObjectDiscussionmessageApi.md#discussionmessagepatchobjectv1) | **PATCH** /1/object/discussionmessage/{pkiDiscussionmessageID} | Patch an existing Discussionmessage |

<a id="discussionmessagecreateobjectv1"></a>
# **DiscussionmessageCreateObjectV1**
> DiscussionmessageCreateObjectV1Response DiscussionmessageCreateObjectV1 (DiscussionmessageCreateObjectV1Request discussionmessageCreateObjectV1Request)

Create a new Discussionmessage

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **discussionmessageCreateObjectV1Request** | [**DiscussionmessageCreateObjectV1Request**](DiscussionmessageCreateObjectV1Request.md) |  |  |

### Return type

[**DiscussionmessageCreateObjectV1Response**](DiscussionmessageCreateObjectV1Response.md)

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

<a id="discussionmessagedeleteobjectv1"></a>
# **DiscussionmessageDeleteObjectV1**
> DiscussionmessageDeleteObjectV1Response DiscussionmessageDeleteObjectV1 (int pkiDiscussionmessageID)

Delete an existing Discussionmessage


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionmessageID** | **int** | The unique ID of the Discussionmessage |  |

### Return type

[**DiscussionmessageDeleteObjectV1Response**](DiscussionmessageDeleteObjectV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="discussionmessagepatchobjectv1"></a>
# **DiscussionmessagePatchObjectV1**
> DiscussionmessagePatchObjectV1Response DiscussionmessagePatchObjectV1 (int pkiDiscussionmessageID, DiscussionmessagePatchObjectV1Request discussionmessagePatchObjectV1Request)

Patch an existing Discussionmessage


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionmessageID** | **int** | The unique ID of the Discussionmessage |  |
| **discussionmessagePatchObjectV1Request** | [**DiscussionmessagePatchObjectV1Request**](DiscussionmessagePatchObjectV1Request.md) |  |  |

### Return type

[**DiscussionmessagePatchObjectV1Response**](DiscussionmessagePatchObjectV1Response.md)

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

