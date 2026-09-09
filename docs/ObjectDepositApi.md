# eZmaxApi.Api.ObjectDepositApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DepositBatchDownloadV1**](ObjectDepositApi.md#depositbatchdownloadv1) | **POST** /1/object/deposit/{pkiDepositID}/batchDownload | Download multiples attachments from a Deposit |
| [**DepositGetAttachmentsV1**](ObjectDepositApi.md#depositgetattachmentsv1) | **GET** /1/object/deposit/{pkiDepositID}/getAttachments | Retrieve Deposit&#39;s attachments |
| [**DepositImportIntoEDMV1**](ObjectDepositApi.md#depositimportintoedmv1) | **POST** /1/object/deposit/{pkiDepositID}/importIntoEDM | Import attachments into the Deposit |

<a id="depositbatchdownloadv1"></a>
# **DepositBatchDownloadV1**
> System.IO.Stream DepositBatchDownloadV1 (int pkiDepositID, DepositBatchDownloadV1Request depositBatchDownloadV1Request)

Download multiples attachments from a Deposit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DepositBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDepositApi(config);
            var pkiDepositID = 56;  // int | 
            var depositBatchDownloadV1Request = new DepositBatchDownloadV1Request(); // DepositBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Deposit
                System.IO.Stream result = apiInstance.DepositBatchDownloadV1(pkiDepositID, depositBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDepositApi.DepositBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepositBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Deposit
    ApiResponse<System.IO.Stream> response = apiInstance.DepositBatchDownloadV1WithHttpInfo(pkiDepositID, depositBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDepositApi.DepositBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDepositID** | **int** |  |  |
| **depositBatchDownloadV1Request** | [**DepositBatchDownloadV1Request**](DepositBatchDownloadV1Request.md) |  |  |

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

<a id="depositgetattachmentsv1"></a>
# **DepositGetAttachmentsV1**
> DepositGetAttachmentsV1Response DepositGetAttachmentsV1 (int pkiDepositID)

Retrieve Deposit's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DepositGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDepositApi(config);
            var pkiDepositID = 56;  // int | 

            try
            {
                // Retrieve Deposit's attachments
                DepositGetAttachmentsV1Response result = apiInstance.DepositGetAttachmentsV1(pkiDepositID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDepositApi.DepositGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepositGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Deposit's attachments
    ApiResponse<DepositGetAttachmentsV1Response> response = apiInstance.DepositGetAttachmentsV1WithHttpInfo(pkiDepositID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDepositApi.DepositGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDepositID** | **int** |  |  |

### Return type

[**DepositGetAttachmentsV1Response**](DepositGetAttachmentsV1Response.md)

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

<a id="depositimportintoedmv1"></a>
# **DepositImportIntoEDMV1**
> DepositImportIntoEDMV1Response DepositImportIntoEDMV1 (int pkiDepositID, DepositImportIntoEDMV1Request depositImportIntoEDMV1Request)

Import attachments into the Deposit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DepositImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDepositApi(config);
            var pkiDepositID = 56;  // int | 
            var depositImportIntoEDMV1Request = new DepositImportIntoEDMV1Request(); // DepositImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Deposit
                DepositImportIntoEDMV1Response result = apiInstance.DepositImportIntoEDMV1(pkiDepositID, depositImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDepositApi.DepositImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepositImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Deposit
    ApiResponse<DepositImportIntoEDMV1Response> response = apiInstance.DepositImportIntoEDMV1WithHttpInfo(pkiDepositID, depositImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDepositApi.DepositImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDepositID** | **int** |  |  |
| **depositImportIntoEDMV1Request** | [**DepositImportIntoEDMV1Request**](DepositImportIntoEDMV1Request.md) |  |  |

### Return type

[**DepositImportIntoEDMV1Response**](DepositImportIntoEDMV1Response.md)

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

