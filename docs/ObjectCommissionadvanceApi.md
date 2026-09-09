# eZmaxApi.Api.ObjectCommissionadvanceApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CommissionadvanceBatchDownloadV1**](ObjectCommissionadvanceApi.md#commissionadvancebatchdownloadv1) | **POST** /1/object/commissionadvance/{pkiCommissionadvanceID}/batchDownload | Download multiples attachments from a Commission advance |
| [**CommissionadvanceGetAttachmentsV1**](ObjectCommissionadvanceApi.md#commissionadvancegetattachmentsv1) | **GET** /1/object/commissionadvance/{pkiCommissionadvanceID}/getAttachments | Retrieve Commissionadvance&#39;s attachments |
| [**CommissionadvanceImportIntoEDMV1**](ObjectCommissionadvanceApi.md#commissionadvanceimportintoedmv1) | **POST** /1/object/commissionadvance/{pkiCommissionadvanceID}/importIntoEDM | Import attachments into the Commissionadvance |

<a id="commissionadvancebatchdownloadv1"></a>
# **CommissionadvanceBatchDownloadV1**
> System.IO.Stream CommissionadvanceBatchDownloadV1 (int pkiCommissionadvanceID, CommissionadvanceBatchDownloadV1Request commissionadvanceBatchDownloadV1Request)

Download multiples attachments from a Commission advance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CommissionadvanceBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectCommissionadvanceApi(config);
            var pkiCommissionadvanceID = 56;  // int | 
            var commissionadvanceBatchDownloadV1Request = new CommissionadvanceBatchDownloadV1Request(); // CommissionadvanceBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Commission advance
                System.IO.Stream result = apiInstance.CommissionadvanceBatchDownloadV1(pkiCommissionadvanceID, commissionadvanceBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectCommissionadvanceApi.CommissionadvanceBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommissionadvanceBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Commission advance
    ApiResponse<System.IO.Stream> response = apiInstance.CommissionadvanceBatchDownloadV1WithHttpInfo(pkiCommissionadvanceID, commissionadvanceBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectCommissionadvanceApi.CommissionadvanceBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCommissionadvanceID** | **int** |  |  |
| **commissionadvanceBatchDownloadV1Request** | [**CommissionadvanceBatchDownloadV1Request**](CommissionadvanceBatchDownloadV1Request.md) |  |  |

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

<a id="commissionadvancegetattachmentsv1"></a>
# **CommissionadvanceGetAttachmentsV1**
> CommissionadvanceGetAttachmentsV1Response CommissionadvanceGetAttachmentsV1 (int pkiCommissionadvanceID)

Retrieve Commissionadvance's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CommissionadvanceGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectCommissionadvanceApi(config);
            var pkiCommissionadvanceID = 56;  // int | 

            try
            {
                // Retrieve Commissionadvance's attachments
                CommissionadvanceGetAttachmentsV1Response result = apiInstance.CommissionadvanceGetAttachmentsV1(pkiCommissionadvanceID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectCommissionadvanceApi.CommissionadvanceGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommissionadvanceGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Commissionadvance's attachments
    ApiResponse<CommissionadvanceGetAttachmentsV1Response> response = apiInstance.CommissionadvanceGetAttachmentsV1WithHttpInfo(pkiCommissionadvanceID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectCommissionadvanceApi.CommissionadvanceGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCommissionadvanceID** | **int** |  |  |

### Return type

[**CommissionadvanceGetAttachmentsV1Response**](CommissionadvanceGetAttachmentsV1Response.md)

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

<a id="commissionadvanceimportintoedmv1"></a>
# **CommissionadvanceImportIntoEDMV1**
> CommissionadvanceImportIntoEDMV1Response CommissionadvanceImportIntoEDMV1 (int pkiCommissionadvanceID, CommissionadvanceImportIntoEDMV1Request commissionadvanceImportIntoEDMV1Request)

Import attachments into the Commissionadvance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class CommissionadvanceImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectCommissionadvanceApi(config);
            var pkiCommissionadvanceID = 56;  // int | 
            var commissionadvanceImportIntoEDMV1Request = new CommissionadvanceImportIntoEDMV1Request(); // CommissionadvanceImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Commissionadvance
                CommissionadvanceImportIntoEDMV1Response result = apiInstance.CommissionadvanceImportIntoEDMV1(pkiCommissionadvanceID, commissionadvanceImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectCommissionadvanceApi.CommissionadvanceImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommissionadvanceImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Commissionadvance
    ApiResponse<CommissionadvanceImportIntoEDMV1Response> response = apiInstance.CommissionadvanceImportIntoEDMV1WithHttpInfo(pkiCommissionadvanceID, commissionadvanceImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectCommissionadvanceApi.CommissionadvanceImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiCommissionadvanceID** | **int** |  |  |
| **commissionadvanceImportIntoEDMV1Request** | [**CommissionadvanceImportIntoEDMV1Request**](CommissionadvanceImportIntoEDMV1Request.md) |  |  |

### Return type

[**CommissionadvanceImportIntoEDMV1Response**](CommissionadvanceImportIntoEDMV1Response.md)

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

