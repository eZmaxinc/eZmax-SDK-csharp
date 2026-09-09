# eZmaxApi.Api.ObjectAdjustmentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdjustmentBatchDownloadV1**](ObjectAdjustmentApi.md#adjustmentbatchdownloadv1) | **POST** /1/object/adjustment/{pkiAdjustmentID}/batchDownload | Download multiples attachments from an Adjustment |
| [**AdjustmentGetAttachmentsV1**](ObjectAdjustmentApi.md#adjustmentgetattachmentsv1) | **GET** /1/object/adjustment/{pkiAdjustmentID}/getAttachments | Retrieve Adjustment&#39;s attachments |
| [**AdjustmentGetCommunicationCountV1**](ObjectAdjustmentApi.md#adjustmentgetcommunicationcountv1) | **GET** /1/object/adjustment/{pkiAdjustmentID}/getCommunicationCount | Retrieve Communication count |
| [**AdjustmentGetCommunicationListV1**](ObjectAdjustmentApi.md#adjustmentgetcommunicationlistv1) | **GET** /1/object/adjustment/{pkiAdjustmentID}/getCommunicationList | Retrieve Communication list |
| [**AdjustmentGetCommunicationrecipientsV1**](ObjectAdjustmentApi.md#adjustmentgetcommunicationrecipientsv1) | **GET** /1/object/adjustment/{pkiAdjustmentID}/getCommunicationrecipients | Retrieve Communication recipients |
| [**AdjustmentGetCommunicationsendersV1**](ObjectAdjustmentApi.md#adjustmentgetcommunicationsendersv1) | **GET** /1/object/adjustment/{pkiAdjustmentID}/getCommunicationsenders | Retrieve Communication senders |
| [**AdjustmentImportIntoEDMV1**](ObjectAdjustmentApi.md#adjustmentimportintoedmv1) | **POST** /1/object/adjustment/{pkiAdjustmentID}/importIntoEDM | Import attachments into the Adjustment |

<a id="adjustmentbatchdownloadv1"></a>
# **AdjustmentBatchDownloadV1**
> System.IO.Stream AdjustmentBatchDownloadV1 (int pkiAdjustmentID, AdjustmentBatchDownloadV1Request adjustmentBatchDownloadV1Request)

Download multiples attachments from an Adjustment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AdjustmentBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAdjustmentApi(config);
            var pkiAdjustmentID = 56;  // int | 
            var adjustmentBatchDownloadV1Request = new AdjustmentBatchDownloadV1Request(); // AdjustmentBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from an Adjustment
                System.IO.Stream result = apiInstance.AdjustmentBatchDownloadV1(pkiAdjustmentID, adjustmentBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustmentBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from an Adjustment
    ApiResponse<System.IO.Stream> response = apiInstance.AdjustmentBatchDownloadV1WithHttpInfo(pkiAdjustmentID, adjustmentBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAdjustmentID** | **int** |  |  |
| **adjustmentBatchDownloadV1Request** | [**AdjustmentBatchDownloadV1Request**](AdjustmentBatchDownloadV1Request.md) |  |  |

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

<a id="adjustmentgetattachmentsv1"></a>
# **AdjustmentGetAttachmentsV1**
> AdjustmentGetAttachmentsV1Response AdjustmentGetAttachmentsV1 (int pkiAdjustmentID)

Retrieve Adjustment's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AdjustmentGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAdjustmentApi(config);
            var pkiAdjustmentID = 56;  // int | 

            try
            {
                // Retrieve Adjustment's attachments
                AdjustmentGetAttachmentsV1Response result = apiInstance.AdjustmentGetAttachmentsV1(pkiAdjustmentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustmentGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Adjustment's attachments
    ApiResponse<AdjustmentGetAttachmentsV1Response> response = apiInstance.AdjustmentGetAttachmentsV1WithHttpInfo(pkiAdjustmentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAdjustmentID** | **int** |  |  |

### Return type

[**AdjustmentGetAttachmentsV1Response**](AdjustmentGetAttachmentsV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adjustmentgetcommunicationcountv1"></a>
# **AdjustmentGetCommunicationCountV1**
> AdjustmentGetCommunicationCountV1Response AdjustmentGetCommunicationCountV1 (int pkiAdjustmentID)

Retrieve Communication count

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AdjustmentGetCommunicationCountV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAdjustmentApi(config);
            var pkiAdjustmentID = 56;  // int | 

            try
            {
                // Retrieve Communication count
                AdjustmentGetCommunicationCountV1Response result = apiInstance.AdjustmentGetCommunicationCountV1(pkiAdjustmentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationCountV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustmentGetCommunicationCountV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication count
    ApiResponse<AdjustmentGetCommunicationCountV1Response> response = apiInstance.AdjustmentGetCommunicationCountV1WithHttpInfo(pkiAdjustmentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationCountV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAdjustmentID** | **int** |  |  |

### Return type

[**AdjustmentGetCommunicationCountV1Response**](AdjustmentGetCommunicationCountV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adjustmentgetcommunicationlistv1"></a>
# **AdjustmentGetCommunicationListV1**
> AdjustmentGetCommunicationListV1Response AdjustmentGetCommunicationListV1 (int pkiAdjustmentID)

Retrieve Communication list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AdjustmentGetCommunicationListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAdjustmentApi(config);
            var pkiAdjustmentID = 56;  // int | 

            try
            {
                // Retrieve Communication list
                AdjustmentGetCommunicationListV1Response result = apiInstance.AdjustmentGetCommunicationListV1(pkiAdjustmentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustmentGetCommunicationListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication list
    ApiResponse<AdjustmentGetCommunicationListV1Response> response = apiInstance.AdjustmentGetCommunicationListV1WithHttpInfo(pkiAdjustmentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAdjustmentID** | **int** |  |  |

### Return type

[**AdjustmentGetCommunicationListV1Response**](AdjustmentGetCommunicationListV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adjustmentgetcommunicationrecipientsv1"></a>
# **AdjustmentGetCommunicationrecipientsV1**
> AdjustmentGetCommunicationrecipientsV1Response AdjustmentGetCommunicationrecipientsV1 (int pkiAdjustmentID)

Retrieve Communication recipients

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AdjustmentGetCommunicationrecipientsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAdjustmentApi(config);
            var pkiAdjustmentID = 56;  // int | 

            try
            {
                // Retrieve Communication recipients
                AdjustmentGetCommunicationrecipientsV1Response result = apiInstance.AdjustmentGetCommunicationrecipientsV1(pkiAdjustmentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationrecipientsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustmentGetCommunicationrecipientsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication recipients
    ApiResponse<AdjustmentGetCommunicationrecipientsV1Response> response = apiInstance.AdjustmentGetCommunicationrecipientsV1WithHttpInfo(pkiAdjustmentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationrecipientsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAdjustmentID** | **int** |  |  |

### Return type

[**AdjustmentGetCommunicationrecipientsV1Response**](AdjustmentGetCommunicationrecipientsV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adjustmentgetcommunicationsendersv1"></a>
# **AdjustmentGetCommunicationsendersV1**
> AdjustmentGetCommunicationsendersV1Response AdjustmentGetCommunicationsendersV1 (int pkiAdjustmentID)

Retrieve Communication senders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AdjustmentGetCommunicationsendersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAdjustmentApi(config);
            var pkiAdjustmentID = 56;  // int | 

            try
            {
                // Retrieve Communication senders
                AdjustmentGetCommunicationsendersV1Response result = apiInstance.AdjustmentGetCommunicationsendersV1(pkiAdjustmentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationsendersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustmentGetCommunicationsendersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication senders
    ApiResponse<AdjustmentGetCommunicationsendersV1Response> response = apiInstance.AdjustmentGetCommunicationsendersV1WithHttpInfo(pkiAdjustmentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentGetCommunicationsendersV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAdjustmentID** | **int** |  |  |

### Return type

[**AdjustmentGetCommunicationsendersV1Response**](AdjustmentGetCommunicationsendersV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adjustmentimportintoedmv1"></a>
# **AdjustmentImportIntoEDMV1**
> AdjustmentImportIntoEDMV1Response AdjustmentImportIntoEDMV1 (int pkiAdjustmentID, AdjustmentImportIntoEDMV1Request adjustmentImportIntoEDMV1Request)

Import attachments into the Adjustment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AdjustmentImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAdjustmentApi(config);
            var pkiAdjustmentID = 56;  // int | 
            var adjustmentImportIntoEDMV1Request = new AdjustmentImportIntoEDMV1Request(); // AdjustmentImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Adjustment
                AdjustmentImportIntoEDMV1Response result = apiInstance.AdjustmentImportIntoEDMV1(pkiAdjustmentID, adjustmentImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustmentImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Adjustment
    ApiResponse<AdjustmentImportIntoEDMV1Response> response = apiInstance.AdjustmentImportIntoEDMV1WithHttpInfo(pkiAdjustmentID, adjustmentImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAdjustmentApi.AdjustmentImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAdjustmentID** | **int** |  |  |
| **adjustmentImportIntoEDMV1Request** | [**AdjustmentImportIntoEDMV1Request**](AdjustmentImportIntoEDMV1Request.md) |  |  |

### Return type

[**AdjustmentImportIntoEDMV1Response**](AdjustmentImportIntoEDMV1Response.md)

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
| **422** | The request was syntactically valid but failed because of an interdependance condition. Look for detail about the error in the body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

