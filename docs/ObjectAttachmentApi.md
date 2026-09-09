# eZmaxApi.Api.ObjectAttachmentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AttachmentDownloadV1**](ObjectAttachmentApi.md#attachmentdownloadv1) | **GET** /1/object/attachment/{pkiAttachmentID}/download | Retrieve the content |
| [**AttachmentGetAttachmentlogsV1**](ObjectAttachmentApi.md#attachmentgetattachmentlogsv1) | **GET** /1/object/attachment/{pkiAttachmentID}/getAttachmentlogs | Retrieve the Attachmentlogs |
| [**AttachmentRenameV1**](ObjectAttachmentApi.md#attachmentrenamev1) | **POST** /1/object/attachment/{pkiAttachmentID}/rename | Rename an Attachment |

<a id="attachmentdownloadv1"></a>
# **AttachmentDownloadV1**
> void AttachmentDownloadV1 (int pkiAttachmentID)

Retrieve the content

Using this endpoint, you can retrieve the content of an attachment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AttachmentDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Presigned
            config.AddApiKey("sAuthorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sAuthorization", "Bearer");

            var apiInstance = new ObjectAttachmentApi(config);
            var pkiAttachmentID = 56;  // int | 

            try
            {
                // Retrieve the content
                apiInstance.AttachmentDownloadV1(pkiAttachmentID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAttachmentApi.AttachmentDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttachmentDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the content
    apiInstance.AttachmentDownloadV1WithHttpInfo(pkiAttachmentID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAttachmentApi.AttachmentDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAttachmentID** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization), [Presigned](../README.md#Presigned)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | The user has been redirected |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="attachmentgetattachmentlogsv1"></a>
# **AttachmentGetAttachmentlogsV1**
> AttachmentGetAttachmentlogsV1Response AttachmentGetAttachmentlogsV1 (int pkiAttachmentID)

Retrieve the Attachmentlogs

Using this endpoint, you can retrieve the Attachmentlogs of an attachment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AttachmentGetAttachmentlogsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAttachmentApi(config);
            var pkiAttachmentID = 56;  // int | 

            try
            {
                // Retrieve the Attachmentlogs
                AttachmentGetAttachmentlogsV1Response result = apiInstance.AttachmentGetAttachmentlogsV1(pkiAttachmentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAttachmentApi.AttachmentGetAttachmentlogsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttachmentGetAttachmentlogsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the Attachmentlogs
    ApiResponse<AttachmentGetAttachmentlogsV1Response> response = apiInstance.AttachmentGetAttachmentlogsV1WithHttpInfo(pkiAttachmentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAttachmentApi.AttachmentGetAttachmentlogsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAttachmentID** | **int** |  |  |

### Return type

[**AttachmentGetAttachmentlogsV1Response**](AttachmentGetAttachmentlogsV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="attachmentrenamev1"></a>
# **AttachmentRenameV1**
> AttachmentRenameV1Response AttachmentRenameV1 (int pkiAttachmentID, AttachmentRenameV1Request attachmentRenameV1Request)

Rename an Attachment

The endpoint allows to change the attachment's file name and category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AttachmentRenameV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAttachmentApi(config);
            var pkiAttachmentID = 56;  // int | 
            var attachmentRenameV1Request = new AttachmentRenameV1Request(); // AttachmentRenameV1Request | 

            try
            {
                // Rename an Attachment
                AttachmentRenameV1Response result = apiInstance.AttachmentRenameV1(pkiAttachmentID, attachmentRenameV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAttachmentApi.AttachmentRenameV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttachmentRenameV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename an Attachment
    ApiResponse<AttachmentRenameV1Response> response = apiInstance.AttachmentRenameV1WithHttpInfo(pkiAttachmentID, attachmentRenameV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAttachmentApi.AttachmentRenameV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAttachmentID** | **int** |  |  |
| **attachmentRenameV1Request** | [**AttachmentRenameV1Request**](AttachmentRenameV1Request.md) |  |  |

### Return type

[**AttachmentRenameV1Response**](AttachmentRenameV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **403** | The request is not allowed to be executed. Look for detail about the error in the body. |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |
| **409** | The request failed due to a conflict with the resource state. Look for detail about the error in the body. |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

