# eZmaxApi.Api.ObjectExternalbrokerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExternalbrokerBatchDownloadV1**](ObjectExternalbrokerApi.md#externalbrokerbatchdownloadv1) | **POST** /1/object/externalbroker/{pkiExternalbrokerID}/batchDownload | Download multiples attachments from an Externalbroker |
| [**ExternalbrokerGetAttachmentsV1**](ObjectExternalbrokerApi.md#externalbrokergetattachmentsv1) | **GET** /1/object/externalbroker/{pkiExternalbrokerID}/getAttachments | Retrieve Externalbroker&#39;s attachments |
| [**ExternalbrokerImportIntoEDMV1**](ObjectExternalbrokerApi.md#externalbrokerimportintoedmv1) | **POST** /1/object/externalbroker/{pkiExternalbrokerID}/importIntoEDM | Import attachments into the Externalbroker |

<a id="externalbrokerbatchdownloadv1"></a>
# **ExternalbrokerBatchDownloadV1**
> System.IO.Stream ExternalbrokerBatchDownloadV1 (int pkiExternalbrokerID, ExternalbrokerBatchDownloadV1Request externalbrokerBatchDownloadV1Request)

Download multiples attachments from an Externalbroker

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ExternalbrokerBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectExternalbrokerApi(config);
            var pkiExternalbrokerID = 56;  // int | 
            var externalbrokerBatchDownloadV1Request = new ExternalbrokerBatchDownloadV1Request(); // ExternalbrokerBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from an Externalbroker
                System.IO.Stream result = apiInstance.ExternalbrokerBatchDownloadV1(pkiExternalbrokerID, externalbrokerBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectExternalbrokerApi.ExternalbrokerBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalbrokerBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from an Externalbroker
    ApiResponse<System.IO.Stream> response = apiInstance.ExternalbrokerBatchDownloadV1WithHttpInfo(pkiExternalbrokerID, externalbrokerBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectExternalbrokerApi.ExternalbrokerBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiExternalbrokerID** | **int** |  |  |
| **externalbrokerBatchDownloadV1Request** | [**ExternalbrokerBatchDownloadV1Request**](ExternalbrokerBatchDownloadV1Request.md) |  |  |

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

<a id="externalbrokergetattachmentsv1"></a>
# **ExternalbrokerGetAttachmentsV1**
> ExternalbrokerGetAttachmentsV1Response ExternalbrokerGetAttachmentsV1 (int pkiExternalbrokerID)

Retrieve Externalbroker's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ExternalbrokerGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectExternalbrokerApi(config);
            var pkiExternalbrokerID = 56;  // int | 

            try
            {
                // Retrieve Externalbroker's attachments
                ExternalbrokerGetAttachmentsV1Response result = apiInstance.ExternalbrokerGetAttachmentsV1(pkiExternalbrokerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectExternalbrokerApi.ExternalbrokerGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalbrokerGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Externalbroker's attachments
    ApiResponse<ExternalbrokerGetAttachmentsV1Response> response = apiInstance.ExternalbrokerGetAttachmentsV1WithHttpInfo(pkiExternalbrokerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectExternalbrokerApi.ExternalbrokerGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiExternalbrokerID** | **int** |  |  |

### Return type

[**ExternalbrokerGetAttachmentsV1Response**](ExternalbrokerGetAttachmentsV1Response.md)

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

<a id="externalbrokerimportintoedmv1"></a>
# **ExternalbrokerImportIntoEDMV1**
> ExternalbrokerImportIntoEDMV1Response ExternalbrokerImportIntoEDMV1 (int pkiExternalbrokerID, ExternalbrokerImportIntoEDMV1Request externalbrokerImportIntoEDMV1Request)

Import attachments into the Externalbroker

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ExternalbrokerImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectExternalbrokerApi(config);
            var pkiExternalbrokerID = 56;  // int | 
            var externalbrokerImportIntoEDMV1Request = new ExternalbrokerImportIntoEDMV1Request(); // ExternalbrokerImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Externalbroker
                ExternalbrokerImportIntoEDMV1Response result = apiInstance.ExternalbrokerImportIntoEDMV1(pkiExternalbrokerID, externalbrokerImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectExternalbrokerApi.ExternalbrokerImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalbrokerImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Externalbroker
    ApiResponse<ExternalbrokerImportIntoEDMV1Response> response = apiInstance.ExternalbrokerImportIntoEDMV1WithHttpInfo(pkiExternalbrokerID, externalbrokerImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectExternalbrokerApi.ExternalbrokerImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiExternalbrokerID** | **int** |  |  |
| **externalbrokerImportIntoEDMV1Request** | [**ExternalbrokerImportIntoEDMV1Request**](ExternalbrokerImportIntoEDMV1Request.md) |  |  |

### Return type

[**ExternalbrokerImportIntoEDMV1Response**](ExternalbrokerImportIntoEDMV1Response.md)

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

