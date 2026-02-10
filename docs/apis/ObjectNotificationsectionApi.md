# eZmaxApi.Api.ObjectNotificationsectionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NotificationsectionGetNotificationtestsV1**](ObjectNotificationsectionApi.md#notificationsectiongetnotificationtestsv1) | **GET** /1/object/notificationsection/{pkiNotificationsectionID}/getNotificationtests | Retrieve an existing Notificationsection&#39;s Notificationtests |

<a id="notificationsectiongetnotificationtestsv1"></a>
# **NotificationsectionGetNotificationtestsV1**
> NotificationsectionGetNotificationtestsV1Response NotificationsectionGetNotificationtestsV1 (int pkiNotificationsectionID, bool bShowHidden)

Retrieve an existing Notificationsection's Notificationtests


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiNotificationsectionID** | **int** |  |  |
| **bShowHidden** | **bool** | Whether or not to return the hidden Notificationtests |  |

### Return type

[**NotificationsectionGetNotificationtestsV1Response**](NotificationsectionGetNotificationtestsV1Response.md)

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

