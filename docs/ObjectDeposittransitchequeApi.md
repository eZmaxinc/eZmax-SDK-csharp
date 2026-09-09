# eZmaxApi.Api.ObjectDeposittransitchequeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeposittransitchequeBatchDownloadV1**](ObjectDeposittransitchequeApi.md#deposittransitchequebatchdownloadv1) | **POST** /1/object/deposittransitcheque/{pkiDeposittransitchequeID}/batchDownload | Download multiples attachments from a Deposittransitcheque |
| [**DeposittransitchequeGetAttachmentsV1**](ObjectDeposittransitchequeApi.md#deposittransitchequegetattachmentsv1) | **GET** /1/object/deposittransitcheque/{pkiDeposittransitchequeID}/getAttachments | Retrieve Deposittransitcheque&#39;s attachments |
| [**DeposittransitchequeImportIntoEDMV1**](ObjectDeposittransitchequeApi.md#deposittransitchequeimportintoedmv1) | **POST** /1/object/deposittransitcheque/{pkiDeposittransitchequeID}/importIntoEDM | Import attachments into the Deposittransitcheque |

<a id="deposittransitchequebatchdownloadv1"></a>
# **DeposittransitchequeBatchDownloadV1**
> System.IO.Stream DeposittransitchequeBatchDownloadV1 (int pkiDeposittransitchequeID, DeposittransitchequeBatchDownloadV1Request deposittransitchequeBatchDownloadV1Request)

Download multiples attachments from a Deposittransitcheque

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DeposittransitchequeBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDeposittransitchequeApi(config);
            var pkiDeposittransitchequeID = 56;  // int | 
            var deposittransitchequeBatchDownloadV1Request = new DeposittransitchequeBatchDownloadV1Request(); // DeposittransitchequeBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Deposittransitcheque
                System.IO.Stream result = apiInstance.DeposittransitchequeBatchDownloadV1(pkiDeposittransitchequeID, deposittransitchequeBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDeposittransitchequeApi.DeposittransitchequeBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeposittransitchequeBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Deposittransitcheque
    ApiResponse<System.IO.Stream> response = apiInstance.DeposittransitchequeBatchDownloadV1WithHttpInfo(pkiDeposittransitchequeID, deposittransitchequeBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDeposittransitchequeApi.DeposittransitchequeBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDeposittransitchequeID** | **int** |  |  |
| **deposittransitchequeBatchDownloadV1Request** | [**DeposittransitchequeBatchDownloadV1Request**](DeposittransitchequeBatchDownloadV1Request.md) |  |  |

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

<a id="deposittransitchequegetattachmentsv1"></a>
# **DeposittransitchequeGetAttachmentsV1**
> DeposittransitchequeGetAttachmentsV1Response DeposittransitchequeGetAttachmentsV1 (int pkiDeposittransitchequeID)

Retrieve Deposittransitcheque's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DeposittransitchequeGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDeposittransitchequeApi(config);
            var pkiDeposittransitchequeID = 56;  // int | 

            try
            {
                // Retrieve Deposittransitcheque's attachments
                DeposittransitchequeGetAttachmentsV1Response result = apiInstance.DeposittransitchequeGetAttachmentsV1(pkiDeposittransitchequeID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDeposittransitchequeApi.DeposittransitchequeGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeposittransitchequeGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Deposittransitcheque's attachments
    ApiResponse<DeposittransitchequeGetAttachmentsV1Response> response = apiInstance.DeposittransitchequeGetAttachmentsV1WithHttpInfo(pkiDeposittransitchequeID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDeposittransitchequeApi.DeposittransitchequeGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDeposittransitchequeID** | **int** |  |  |

### Return type

[**DeposittransitchequeGetAttachmentsV1Response**](DeposittransitchequeGetAttachmentsV1Response.md)

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

<a id="deposittransitchequeimportintoedmv1"></a>
# **DeposittransitchequeImportIntoEDMV1**
> DeposittransitchequeImportIntoEDMV1Response DeposittransitchequeImportIntoEDMV1 (int pkiDeposittransitchequeID, DeposittransitchequeImportIntoEDMV1Request deposittransitchequeImportIntoEDMV1Request)

Import attachments into the Deposittransitcheque

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class DeposittransitchequeImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectDeposittransitchequeApi(config);
            var pkiDeposittransitchequeID = 56;  // int | 
            var deposittransitchequeImportIntoEDMV1Request = new DeposittransitchequeImportIntoEDMV1Request(); // DeposittransitchequeImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Deposittransitcheque
                DeposittransitchequeImportIntoEDMV1Response result = apiInstance.DeposittransitchequeImportIntoEDMV1(pkiDeposittransitchequeID, deposittransitchequeImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectDeposittransitchequeApi.DeposittransitchequeImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeposittransitchequeImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Deposittransitcheque
    ApiResponse<DeposittransitchequeImportIntoEDMV1Response> response = apiInstance.DeposittransitchequeImportIntoEDMV1WithHttpInfo(pkiDeposittransitchequeID, deposittransitchequeImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectDeposittransitchequeApi.DeposittransitchequeImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiDeposittransitchequeID** | **int** |  |  |
| **deposittransitchequeImportIntoEDMV1Request** | [**DeposittransitchequeImportIntoEDMV1Request**](DeposittransitchequeImportIntoEDMV1Request.md) |  |  |

### Return type

[**DeposittransitchequeImportIntoEDMV1Response**](DeposittransitchequeImportIntoEDMV1Response.md)

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

