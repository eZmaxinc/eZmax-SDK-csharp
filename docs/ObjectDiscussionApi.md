# eZmaxApi.Api.ObjectDiscussionApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DiscussionCreateObjectV1**](ObjectDiscussionApi.md#discussioncreateobjectv1) | **POST** /1/object/discussion | Create a new Discussion |
| [**DiscussionDeleteObjectV1**](ObjectDiscussionApi.md#discussiondeleteobjectv1) | **DELETE** /1/object/discussion/{pkiDiscussionID} | Delete an existing Discussion |
| [**DiscussionGetObjectV2**](ObjectDiscussionApi.md#discussiongetobjectv2) | **GET** /2/object/discussion/{pkiDiscussionID} | Retrieve an existing Discussion |
| [**DiscussionPatchObjectV1**](ObjectDiscussionApi.md#discussionpatchobjectv1) | **PATCH** /1/object/discussion/{pkiDiscussionID} | Patch an existing Discussion |
| [**DiscussionUpdateDiscussionreadstatusV1**](ObjectDiscussionApi.md#discussionupdatediscussionreadstatusv1) | **POST** /1/object/discussion/{pkiDiscussionID}/updateDiscussionreadstatus | Update the read status of the discussion |

<a id="discussioncreateobjectv1"></a>
# **DiscussionCreateObjectV1**
> DiscussionCreateObjectV1Response DiscussionCreateObjectV1 (DiscussionCreateObjectV1Request discussionCreateObjectV1Request)

Create a new Discussion

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
    public class DiscussionCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionApi(config);
            var discussionCreateObjectV1Request = new DiscussionCreateObjectV1Request(); // DiscussionCreateObjectV1Request | 

            try
            {
                // Create a new Discussion
                DiscussionCreateObjectV1Response result = apiInstance.DiscussionCreateObjectV1(discussionCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionCreateObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionCreateObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Discussion
    ApiResponse<DiscussionCreateObjectV1Response> response = apiInstance.DiscussionCreateObjectV1WithHttpInfo(discussionCreateObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionCreateObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="discussiondeleteobjectv1"></a>
# **DiscussionDeleteObjectV1**
> CommonResponse DiscussionDeleteObjectV1 (int pkiDiscussionID)

Delete an existing Discussion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionApi(config);
            var pkiDiscussionID = 56;  // int | The unique ID of the Discussion

            try
            {
                // Delete an existing Discussion
                CommonResponse result = apiInstance.DiscussionDeleteObjectV1(pkiDiscussionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionDeleteObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionDeleteObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing Discussion
    ApiResponse<CommonResponse> response = apiInstance.DiscussionDeleteObjectV1WithHttpInfo(pkiDiscussionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionDeleteObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionID** | **int** | The unique ID of the Discussion |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

<a id="discussiongetobjectv2"></a>
# **DiscussionGetObjectV2**
> DiscussionGetObjectV2Response DiscussionGetObjectV2 (int pkiDiscussionID)

Retrieve an existing Discussion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionGetObjectV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionApi(config);
            var pkiDiscussionID = 56;  // int | The unique ID of the Discussion

            try
            {
                // Retrieve an existing Discussion
                DiscussionGetObjectV2Response result = apiInstance.DiscussionGetObjectV2(pkiDiscussionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionGetObjectV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionGetObjectV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an existing Discussion
    ApiResponse<DiscussionGetObjectV2Response> response = apiInstance.DiscussionGetObjectV2WithHttpInfo(pkiDiscussionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionGetObjectV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="discussionpatchobjectv1"></a>
# **DiscussionPatchObjectV1**
> CommonResponse DiscussionPatchObjectV1 (int pkiDiscussionID, DiscussionPatchObjectV1Request discussionPatchObjectV1Request)

Patch an existing Discussion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionPatchObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionApi(config);
            var pkiDiscussionID = 56;  // int | The unique ID of the Discussion
            var discussionPatchObjectV1Request = new DiscussionPatchObjectV1Request(); // DiscussionPatchObjectV1Request | 

            try
            {
                // Patch an existing Discussion
                CommonResponse result = apiInstance.DiscussionPatchObjectV1(pkiDiscussionID, discussionPatchObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionPatchObjectV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionPatchObjectV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch an existing Discussion
    ApiResponse<CommonResponse> response = apiInstance.DiscussionPatchObjectV1WithHttpInfo(pkiDiscussionID, discussionPatchObjectV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionPatchObjectV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionID** | **int** | The unique ID of the Discussion |  |
| **discussionPatchObjectV1Request** | [**DiscussionPatchObjectV1Request**](DiscussionPatchObjectV1Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

<a id="discussionupdatediscussionreadstatusv1"></a>
# **DiscussionUpdateDiscussionreadstatusV1**
> CommonResponse DiscussionUpdateDiscussionreadstatusV1 (int pkiDiscussionID, DiscussionUpdateDiscussionreadstatusV1Request discussionUpdateDiscussionreadstatusV1Request)

Update the read status of the discussion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DiscussionUpdateDiscussionreadstatusV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDiscussionApi(config);
            var pkiDiscussionID = 56;  // int | 
            var discussionUpdateDiscussionreadstatusV1Request = new DiscussionUpdateDiscussionreadstatusV1Request(); // DiscussionUpdateDiscussionreadstatusV1Request | 

            try
            {
                // Update the read status of the discussion
                CommonResponse result = apiInstance.DiscussionUpdateDiscussionreadstatusV1(pkiDiscussionID, discussionUpdateDiscussionreadstatusV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionUpdateDiscussionreadstatusV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DiscussionUpdateDiscussionreadstatusV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the read status of the discussion
    ApiResponse<CommonResponse> response = apiInstance.DiscussionUpdateDiscussionreadstatusV1WithHttpInfo(pkiDiscussionID, discussionUpdateDiscussionreadstatusV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDiscussionApi.DiscussionUpdateDiscussionreadstatusV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDiscussionID** | **int** |  |  |
| **discussionUpdateDiscussionreadstatusV1Request** | [**DiscussionUpdateDiscussionreadstatusV1Request**](DiscussionUpdateDiscussionreadstatusV1Request.md) |  |  |

### Return type

[**CommonResponse**](CommonResponse.md)

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

