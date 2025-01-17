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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionmembershipCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionmembershipApi(config);
            var discussionmembershipCreateObjectV1Request = new DiscussionmembershipCreateObjectV1Request(); // DiscussionmembershipCreateObjectV1Request | 

            try
            {
                // Create a new Discussionmembership
                DiscussionmembershipCreateObjectV1Response result = apiInstance.DiscussionmembershipCreateObjectV1(discussionmembershipCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionmembershipApi.DiscussionmembershipCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionmembershipCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Discussionmembership
    ApiResponse<DiscussionmembershipCreateObjectV1Response> response = apiInstance.DiscussionmembershipCreateObjectV1WithHttpInfo(discussionmembershipCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionmembershipApi.DiscussionmembershipCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="discussionmembershipdeleteobjectv1"></a>
# **DiscussionmembershipDeleteObjectV1**
> DiscussionmembershipDeleteObjectV1Response DiscussionmembershipDeleteObjectV1 (int pkiDiscussionmembershipID)

Delete an existing Discussionmembership

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionmembershipDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionmembershipApi(config);
            var pkiDiscussionmembershipID = 56;  // int | The unique ID of the Discussionmembership

            try
            {
                // Delete an existing Discussionmembership
                DiscussionmembershipDeleteObjectV1Response result = apiInstance.DiscussionmembershipDeleteObjectV1(pkiDiscussionmembershipID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionmembershipApi.DiscussionmembershipDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionmembershipDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Discussionmembership
    ApiResponse<DiscussionmembershipDeleteObjectV1Response> response = apiInstance.DiscussionmembershipDeleteObjectV1WithHttpInfo(pkiDiscussionmembershipID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionmembershipApi.DiscussionmembershipDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

