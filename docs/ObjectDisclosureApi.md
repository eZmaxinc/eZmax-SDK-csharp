# eZmaxApi.Api.ObjectDisclosureApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DisclosureBatchDownloadV1**](ObjectDisclosureApi.md#disclosurebatchdownloadv1) | **POST** /1/object/disclosure/{pkiDisclosureID}/batchDownload | Download multiples attachments from a Disclosure |
| [**DisclosureGetAttachmentsV1**](ObjectDisclosureApi.md#disclosuregetattachmentsv1) | **GET** /1/object/disclosure/{pkiDisclosureID}/getAttachments | Retrieve Disclosure&#39;s attachments |
| [**DisclosureImportIntoEDMV1**](ObjectDisclosureApi.md#disclosureimportintoedmv1) | **POST** /1/object/disclosure/{pkiDisclosureID}/importIntoEDM | Import attachments into the Disclosure |

<a id="disclosurebatchdownloadv1"></a>
# **DisclosureBatchDownloadV1**
> System.IO.Stream DisclosureBatchDownloadV1 (int pkiDisclosureID, DisclosureBatchDownloadV1Request disclosureBatchDownloadV1Request)

Download multiples attachments from a Disclosure

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DisclosureBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDisclosureApi(config);
            var pkiDisclosureID = 56;  // int | 
            var disclosureBatchDownloadV1Request = new DisclosureBatchDownloadV1Request(); // DisclosureBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Disclosure
                System.IO.Stream result = apiInstance.DisclosureBatchDownloadV1(pkiDisclosureID, disclosureBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDisclosureApi.DisclosureBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisclosureBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Disclosure
    ApiResponse<System.IO.Stream> response = apiInstance.DisclosureBatchDownloadV1WithHttpInfo(pkiDisclosureID, disclosureBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDisclosureApi.DisclosureBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDisclosureID** | **int** |  |  |
| **disclosureBatchDownloadV1Request** | [**DisclosureBatchDownloadV1Request**](DisclosureBatchDownloadV1Request.md) |  |  |

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

<a id="disclosuregetattachmentsv1"></a>
# **DisclosureGetAttachmentsV1**
> DisclosureGetAttachmentsV1Response DisclosureGetAttachmentsV1 (int pkiDisclosureID)

Retrieve Disclosure's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DisclosureGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDisclosureApi(config);
            var pkiDisclosureID = 56;  // int | 

            try
            {
                // Retrieve Disclosure's attachments
                DisclosureGetAttachmentsV1Response result = apiInstance.DisclosureGetAttachmentsV1(pkiDisclosureID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDisclosureApi.DisclosureGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisclosureGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Disclosure's attachments
    ApiResponse<DisclosureGetAttachmentsV1Response> response = apiInstance.DisclosureGetAttachmentsV1WithHttpInfo(pkiDisclosureID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDisclosureApi.DisclosureGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDisclosureID** | **int** |  |  |

### Return type

[**DisclosureGetAttachmentsV1Response**](DisclosureGetAttachmentsV1Response.md)

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

<a id="disclosureimportintoedmv1"></a>
# **DisclosureImportIntoEDMV1**
> DisclosureImportIntoEDMV1Response DisclosureImportIntoEDMV1 (int pkiDisclosureID, DisclosureImportIntoEDMV1Request disclosureImportIntoEDMV1Request)

Import attachments into the Disclosure

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DisclosureImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDisclosureApi(config);
            var pkiDisclosureID = 56;  // int | 
            var disclosureImportIntoEDMV1Request = new DisclosureImportIntoEDMV1Request(); // DisclosureImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Disclosure
                DisclosureImportIntoEDMV1Response result = apiInstance.DisclosureImportIntoEDMV1(pkiDisclosureID, disclosureImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDisclosureApi.DisclosureImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisclosureImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Disclosure
    ApiResponse<DisclosureImportIntoEDMV1Response> response = apiInstance.DisclosureImportIntoEDMV1WithHttpInfo(pkiDisclosureID, disclosureImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDisclosureApi.DisclosureImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDisclosureID** | **int** |  |  |
| **disclosureImportIntoEDMV1Request** | [**DisclosureImportIntoEDMV1Request**](DisclosureImportIntoEDMV1Request.md) |  |  |

### Return type

[**DisclosureImportIntoEDMV1Response**](DisclosureImportIntoEDMV1Response.md)

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

