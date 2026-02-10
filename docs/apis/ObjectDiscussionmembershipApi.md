# eZmaxApi.Api.ObjectDiscussionmembershipApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiscussionmembershipCreateObjectV1**](ObjectDiscussionmembershipApi.md#discussionmembershipcreateobjectv1) | **POST** /1/object/discussionmembership | Create a new Discussionmembership |
| [**DiscussionmembershipDeleteObjectV1**](ObjectDiscussionmembershipApi.md#discussionmembershipdeleteobjectv1) | **DELETE** /1/object/discussionmembership/{pkiDiscussionmembershipID} | Delete an existing Discussionmembership |

<a id="discussionmembershipcreateobjectv1"></a>
# **DiscussionmembershipCreateObjectV1**
> DiscussionmembershipCreateObjectV1Response DiscussionmembershipCreateObjectV1 (DiscussionmembershipCreateObjectV1Request discussionmembershipCreateObjectV1Request)

Create a new Discussionmembership

The endpoint allows to create one or many elements at once.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **discussionmembershipCreateObjectV1Request** | [**DiscussionmembershipCreateObjectV1Request**](DiscussionmembershipCreateObjectV1Request.md) |  |  |

### Return type

[**DiscussionmembershipCreateObjectV1Response**](DiscussionmembershipCreateObjectV1Response.md)

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

<a id="discussionmembershipdeleteobjectv1"></a>
# **DiscussionmembershipDeleteObjectV1**
> DiscussionmembershipDeleteObjectV1Response DiscussionmembershipDeleteObjectV1 (int pkiDiscussionmembershipID)

Delete an existing Discussionmembership


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionmembershipID** | **int** | The unique ID of the Discussionmembership |  |

### Return type

[**DiscussionmembershipDeleteObjectV1Response**](DiscussionmembershipDeleteObjectV1Response.md)

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

