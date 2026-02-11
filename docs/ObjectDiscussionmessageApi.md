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

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionmessageCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionmessageApi(config);
            var discussionmessageCreateObjectV1Request = new DiscussionmessageCreateObjectV1Request(); // DiscussionmessageCreateObjectV1Request | 

            try
            {
                // Create a new Discussionmessage
                DiscussionmessageCreateObjectV1Response result = apiInstance.DiscussionmessageCreateObjectV1(discussionmessageCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionmessageApi.DiscussionmessageCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionmessageCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Discussionmessage
    ApiResponse<DiscussionmessageCreateObjectV1Response> response = apiInstance.DiscussionmessageCreateObjectV1WithHttpInfo(discussionmessageCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionmessageApi.DiscussionmessageCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="discussionmessagedeleteobjectv1"></a>
# **DiscussionmessageDeleteObjectV1**
> DiscussionmessageDeleteObjectV1Response DiscussionmessageDeleteObjectV1 (int pkiDiscussionmessageID)

Delete an existing Discussionmessage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionmessageDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionmessageApi(config);
            var pkiDiscussionmessageID = 56;  // int | The unique ID of the Discussionmessage

            try
            {
                // Delete an existing Discussionmessage
                DiscussionmessageDeleteObjectV1Response result = apiInstance.DiscussionmessageDeleteObjectV1(pkiDiscussionmessageID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionmessageApi.DiscussionmessageDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionmessageDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Discussionmessage
    ApiResponse<DiscussionmessageDeleteObjectV1Response> response = apiInstance.DiscussionmessageDeleteObjectV1WithHttpInfo(pkiDiscussionmessageID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionmessageApi.DiscussionmessageDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="discussionmessagepatchobjectv1"></a>
# **DiscussionmessagePatchObjectV1**
> DiscussionmessagePatchObjectV1Response DiscussionmessagePatchObjectV1 (int pkiDiscussionmessageID, DiscussionmessagePatchObjectV1Request discussionmessagePatchObjectV1Request)

Patch an existing Discussionmessage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionmessagePatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionmessageApi(config);
            var pkiDiscussionmessageID = 56;  // int | The unique ID of the Discussionmessage
            var discussionmessagePatchObjectV1Request = new DiscussionmessagePatchObjectV1Request(); // DiscussionmessagePatchObjectV1Request | 

            try
            {
                // Patch an existing Discussionmessage
                DiscussionmessagePatchObjectV1Response result = apiInstance.DiscussionmessagePatchObjectV1(pkiDiscussionmessageID, discussionmessagePatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionmessageApi.DiscussionmessagePatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionmessagePatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Discussionmessage
    ApiResponse<DiscussionmessagePatchObjectV1Response> response = apiInstance.DiscussionmessagePatchObjectV1WithHttpInfo(pkiDiscussionmessageID, discussionmessagePatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionmessageApi.DiscussionmessagePatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

