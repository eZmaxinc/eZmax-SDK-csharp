# eZmaxApi.Api.ObjectReconciliationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReconciliationBatchDownloadV1**](ObjectReconciliationApi.md#reconciliationbatchdownloadv1) | **POST** /1/object/reconciliation/{pkiReconciliationID}/batchDownload | Download multiples attachments from a Reconciliation |
| [**ReconciliationGetAttachmentsV1**](ObjectReconciliationApi.md#reconciliationgetattachmentsv1) | **GET** /1/object/reconciliation/{pkiReconciliationID}/getAttachments | Retrieve Reconciliation&#39;s attachments |
| [**ReconciliationImportIntoEDMV1**](ObjectReconciliationApi.md#reconciliationimportintoedmv1) | **POST** /1/object/reconciliation/{pkiReconciliationID}/importIntoEDM | Import attachments into the Reconciliation |

<a id="reconciliationbatchdownloadv1"></a>
# **ReconciliationBatchDownloadV1**
> System.IO.Stream ReconciliationBatchDownloadV1 (int pkiReconciliationID, ReconciliationBatchDownloadV1Request reconciliationBatchDownloadV1Request)

Download multiples attachments from a Reconciliation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ReconciliationBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectReconciliationApi(config);
            var pkiReconciliationID = 56;  // int | 
            var reconciliationBatchDownloadV1Request = new ReconciliationBatchDownloadV1Request(); // ReconciliationBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Reconciliation
                System.IO.Stream result = apiInstance.ReconciliationBatchDownloadV1(pkiReconciliationID, reconciliationBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectReconciliationApi.ReconciliationBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconciliationBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Reconciliation
    ApiResponse<System.IO.Stream> response = apiInstance.ReconciliationBatchDownloadV1WithHttpInfo(pkiReconciliationID, reconciliationBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectReconciliationApi.ReconciliationBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiReconciliationID** | **int** |  |  |
| **reconciliationBatchDownloadV1Request** | [**ReconciliationBatchDownloadV1Request**](ReconciliationBatchDownloadV1Request.md) |  |  |

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

<a id="reconciliationgetattachmentsv1"></a>
# **ReconciliationGetAttachmentsV1**
> ReconciliationGetAttachmentsV1Response ReconciliationGetAttachmentsV1 (int pkiReconciliationID)

Retrieve Reconciliation's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ReconciliationGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectReconciliationApi(config);
            var pkiReconciliationID = 56;  // int | 

            try
            {
                // Retrieve Reconciliation's attachments
                ReconciliationGetAttachmentsV1Response result = apiInstance.ReconciliationGetAttachmentsV1(pkiReconciliationID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectReconciliationApi.ReconciliationGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconciliationGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Reconciliation's attachments
    ApiResponse<ReconciliationGetAttachmentsV1Response> response = apiInstance.ReconciliationGetAttachmentsV1WithHttpInfo(pkiReconciliationID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectReconciliationApi.ReconciliationGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiReconciliationID** | **int** |  |  |

### Return type

[**ReconciliationGetAttachmentsV1Response**](ReconciliationGetAttachmentsV1Response.md)

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

<a id="reconciliationimportintoedmv1"></a>
# **ReconciliationImportIntoEDMV1**
> ReconciliationImportIntoEDMV1Response ReconciliationImportIntoEDMV1 (int pkiReconciliationID, ReconciliationImportIntoEDMV1Request reconciliationImportIntoEDMV1Request)

Import attachments into the Reconciliation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ReconciliationImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectReconciliationApi(config);
            var pkiReconciliationID = 56;  // int | 
            var reconciliationImportIntoEDMV1Request = new ReconciliationImportIntoEDMV1Request(); // ReconciliationImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Reconciliation
                ReconciliationImportIntoEDMV1Response result = apiInstance.ReconciliationImportIntoEDMV1(pkiReconciliationID, reconciliationImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectReconciliationApi.ReconciliationImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconciliationImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Reconciliation
    ApiResponse<ReconciliationImportIntoEDMV1Response> response = apiInstance.ReconciliationImportIntoEDMV1WithHttpInfo(pkiReconciliationID, reconciliationImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectReconciliationApi.ReconciliationImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiReconciliationID** | **int** |  |  |
| **reconciliationImportIntoEDMV1Request** | [**ReconciliationImportIntoEDMV1Request**](ReconciliationImportIntoEDMV1Request.md) |  |  |

### Return type

[**ReconciliationImportIntoEDMV1Response**](ReconciliationImportIntoEDMV1Response.md)

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

