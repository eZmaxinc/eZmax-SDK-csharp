# eZmaxApi.Api.ObjectNotaryApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NotaryBatchDownloadV1**](ObjectNotaryApi.md#notarybatchdownloadv1) | **POST** /1/object/notary/{pkiNotaryID}/batchDownload | Download multiples attachments from a Notary |
| [**NotaryGetAttachmentsV1**](ObjectNotaryApi.md#notarygetattachmentsv1) | **GET** /1/object/notary/{pkiNotaryID}/getAttachments | Retrieve Notary&#39;s attachments |
| [**NotaryImportIntoEDMV1**](ObjectNotaryApi.md#notaryimportintoedmv1) | **POST** /1/object/notary/{pkiNotaryID}/importIntoEDM | Import attachments into the Notary |

<a id="notarybatchdownloadv1"></a>
# **NotaryBatchDownloadV1**
> System.IO.Stream NotaryBatchDownloadV1 (int pkiNotaryID, NotaryBatchDownloadV1Request notaryBatchDownloadV1Request)

Download multiples attachments from a Notary

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class NotaryBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectNotaryApi(config);
            var pkiNotaryID = 56;  // int | 
            var notaryBatchDownloadV1Request = new NotaryBatchDownloadV1Request(); // NotaryBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Notary
                System.IO.Stream result = apiInstance.NotaryBatchDownloadV1(pkiNotaryID, notaryBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectNotaryApi.NotaryBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotaryBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Notary
    ApiResponse<System.IO.Stream> response = apiInstance.NotaryBatchDownloadV1WithHttpInfo(pkiNotaryID, notaryBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectNotaryApi.NotaryBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiNotaryID** | **int** |  |  |
| **notaryBatchDownloadV1Request** | [**NotaryBatchDownloadV1Request**](NotaryBatchDownloadV1Request.md) |  |  |

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/zip, text/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notarygetattachmentsv1"></a>
# **NotaryGetAttachmentsV1**
> NotaryGetAttachmentsV1Response NotaryGetAttachmentsV1 (int pkiNotaryID)

Retrieve Notary's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class NotaryGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectNotaryApi(config);
            var pkiNotaryID = 56;  // int | 

            try
            {
                // Retrieve Notary's attachments
                NotaryGetAttachmentsV1Response result = apiInstance.NotaryGetAttachmentsV1(pkiNotaryID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectNotaryApi.NotaryGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotaryGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Notary's attachments
    ApiResponse<NotaryGetAttachmentsV1Response> response = apiInstance.NotaryGetAttachmentsV1WithHttpInfo(pkiNotaryID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectNotaryApi.NotaryGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiNotaryID** | **int** |  |  |

### Return type

[**NotaryGetAttachmentsV1Response**](NotaryGetAttachmentsV1Response.md)

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

<a id="notaryimportintoedmv1"></a>
# **NotaryImportIntoEDMV1**
> NotaryImportIntoEDMV1Response NotaryImportIntoEDMV1 (int pkiNotaryID, NotaryImportIntoEDMV1Request notaryImportIntoEDMV1Request)

Import attachments into the Notary

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class NotaryImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectNotaryApi(config);
            var pkiNotaryID = 56;  // int | 
            var notaryImportIntoEDMV1Request = new NotaryImportIntoEDMV1Request(); // NotaryImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Notary
                NotaryImportIntoEDMV1Response result = apiInstance.NotaryImportIntoEDMV1(pkiNotaryID, notaryImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectNotaryApi.NotaryImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotaryImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Notary
    ApiResponse<NotaryImportIntoEDMV1Response> response = apiInstance.NotaryImportIntoEDMV1WithHttpInfo(pkiNotaryID, notaryImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectNotaryApi.NotaryImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiNotaryID** | **int** |  |  |
| **notaryImportIntoEDMV1Request** | [**NotaryImportIntoEDMV1Request**](NotaryImportIntoEDMV1Request.md) |  |  |

### Return type

[**NotaryImportIntoEDMV1Response**](NotaryImportIntoEDMV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The request failed. The element on which you were trying to work does not exists. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

