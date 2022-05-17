# eZmaxApi.Api.ObjectNotificationsectionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotificationsectionGetNotificationtestsV1**](ObjectNotificationsectionApi.md#notificationsectiongetnotificationtestsv1) | **GET** /1/object/notificationsection/{pkiNotificationsectionID}/getNotificationtests | Retrieve an existing Notificationsection&#39;s Notificationtests



## NotificationsectionGetNotificationtestsV1

> NotificationsectionGetNotificationtestsV1Response NotificationsectionGetNotificationtestsV1 (int pkiNotificationsectionID, bool bShowHidden)

Retrieve an existing Notificationsection's Notificationtests

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class NotificationsectionGetNotificationtestsV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectNotificationsectionApi(Configuration.Default);
            var pkiNotificationsectionID = 56;  // int | 
            var bShowHidden = true;  // bool | Whether or not to return the hidden Notificationtests

            try
            {
                // Retrieve an existing Notificationsection's Notificationtests
                NotificationsectionGetNotificationtestsV1Response result = apiInstance.NotificationsectionGetNotificationtestsV1(pkiNotificationsectionID, bShowHidden);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectNotificationsectionApi.NotificationsectionGetNotificationtestsV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiNotificationsectionID** | **int**|  | 
 **bShowHidden** | **bool**| Whether or not to return the hidden Notificationtests | 

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
| **404** | The element you are trying to work on does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

