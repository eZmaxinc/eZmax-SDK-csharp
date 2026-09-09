# eZmaxApi.Api.ObjectElectronicfundstransferApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ElectronicfundstransferBatchDownloadV1**](ObjectElectronicfundstransferApi.md#electronicfundstransferbatchdownloadv1) | **POST** /1/object/electronicfundstransfer/{pkiElectronicfundstransferID}/batchDownload | Download multiples attachments from an Electronicfundstransfer |
| [**ElectronicfundstransferGetAttachmentsV1**](ObjectElectronicfundstransferApi.md#electronicfundstransfergetattachmentsv1) | **GET** /1/object/electronicfundstransfer/{pkiElectronicfundstransferID}/getAttachments | Retrieve Electronicfundstransfer&#39;s attachments |
| [**ElectronicfundstransferGetCommunicationCountV1**](ObjectElectronicfundstransferApi.md#electronicfundstransfergetcommunicationcountv1) | **GET** /1/object/electronicfundstransfer/{pkiElectronicfundstransferID}/getCommunicationCount | Retrieve Communication count |
| [**ElectronicfundstransferGetCommunicationListV1**](ObjectElectronicfundstransferApi.md#electronicfundstransfergetcommunicationlistv1) | **GET** /1/object/electronicfundstransfer/{pkiElectronicfundstransferID}/getCommunicationList | Retrieve Communication list |
| [**ElectronicfundstransferGetCommunicationrecipientsV1**](ObjectElectronicfundstransferApi.md#electronicfundstransfergetcommunicationrecipientsv1) | **GET** /1/object/electronicfundstransfer/{pkiElectronicfundstransferID}/getCommunicationrecipients | Retrieve Electronicfundstransfer&#39;s Communicationrecipient |
| [**ElectronicfundstransferGetCommunicationsendersV1**](ObjectElectronicfundstransferApi.md#electronicfundstransfergetcommunicationsendersv1) | **GET** /1/object/electronicfundstransfer/{pkiElectronicfundstransferID}/getCommunicationsenders | Retrieve Electronicfundstransfer&#39;s Communicationsender |
| [**ElectronicfundstransferImportIntoEDMV1**](ObjectElectronicfundstransferApi.md#electronicfundstransferimportintoedmv1) | **POST** /1/object/electronicfundstransfer/{pkiElectronicfundstransferID}/importIntoEDM | Import attachments into the Electronicfundstransfer |

<a id="electronicfundstransferbatchdownloadv1"></a>
# **ElectronicfundstransferBatchDownloadV1**
> System.IO.Stream ElectronicfundstransferBatchDownloadV1 (int pkiElectronicfundstransferID, ElectronicfundstransferBatchDownloadV1Request electronicfundstransferBatchDownloadV1Request)

Download multiples attachments from an Electronicfundstransfer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ElectronicfundstransferBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectElectronicfundstransferApi(config);
            var pkiElectronicfundstransferID = 56;  // int | 
            var electronicfundstransferBatchDownloadV1Request = new ElectronicfundstransferBatchDownloadV1Request(); // ElectronicfundstransferBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from an Electronicfundstransfer
                System.IO.Stream result = apiInstance.ElectronicfundstransferBatchDownloadV1(pkiElectronicfundstransferID, electronicfundstransferBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ElectronicfundstransferBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from an Electronicfundstransfer
    ApiResponse<System.IO.Stream> response = apiInstance.ElectronicfundstransferBatchDownloadV1WithHttpInfo(pkiElectronicfundstransferID, electronicfundstransferBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiElectronicfundstransferID** | **int** |  |  |
| **electronicfundstransferBatchDownloadV1Request** | [**ElectronicfundstransferBatchDownloadV1Request**](ElectronicfundstransferBatchDownloadV1Request.md) |  |  |

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

<a id="electronicfundstransfergetattachmentsv1"></a>
# **ElectronicfundstransferGetAttachmentsV1**
> ElectronicfundstransferGetAttachmentsV1Response ElectronicfundstransferGetAttachmentsV1 (int pkiElectronicfundstransferID)

Retrieve Electronicfundstransfer's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ElectronicfundstransferGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectElectronicfundstransferApi(config);
            var pkiElectronicfundstransferID = 56;  // int | 

            try
            {
                // Retrieve Electronicfundstransfer's attachments
                ElectronicfundstransferGetAttachmentsV1Response result = apiInstance.ElectronicfundstransferGetAttachmentsV1(pkiElectronicfundstransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ElectronicfundstransferGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Electronicfundstransfer's attachments
    ApiResponse<ElectronicfundstransferGetAttachmentsV1Response> response = apiInstance.ElectronicfundstransferGetAttachmentsV1WithHttpInfo(pkiElectronicfundstransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiElectronicfundstransferID** | **int** |  |  |

### Return type

[**ElectronicfundstransferGetAttachmentsV1Response**](ElectronicfundstransferGetAttachmentsV1Response.md)

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

<a id="electronicfundstransfergetcommunicationcountv1"></a>
# **ElectronicfundstransferGetCommunicationCountV1**
> ElectronicfundstransferGetCommunicationCountV1Response ElectronicfundstransferGetCommunicationCountV1 (int pkiElectronicfundstransferID)

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
    public class ElectronicfundstransferGetCommunicationCountV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectElectronicfundstransferApi(config);
            var pkiElectronicfundstransferID = 56;  // int | 

            try
            {
                // Retrieve Communication count
                ElectronicfundstransferGetCommunicationCountV1Response result = apiInstance.ElectronicfundstransferGetCommunicationCountV1(pkiElectronicfundstransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationCountV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ElectronicfundstransferGetCommunicationCountV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication count
    ApiResponse<ElectronicfundstransferGetCommunicationCountV1Response> response = apiInstance.ElectronicfundstransferGetCommunicationCountV1WithHttpInfo(pkiElectronicfundstransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationCountV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiElectronicfundstransferID** | **int** |  |  |

### Return type

[**ElectronicfundstransferGetCommunicationCountV1Response**](ElectronicfundstransferGetCommunicationCountV1Response.md)

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

<a id="electronicfundstransfergetcommunicationlistv1"></a>
# **ElectronicfundstransferGetCommunicationListV1**
> ElectronicfundstransferGetCommunicationListV1Response ElectronicfundstransferGetCommunicationListV1 (int pkiElectronicfundstransferID)

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
    public class ElectronicfundstransferGetCommunicationListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectElectronicfundstransferApi(config);
            var pkiElectronicfundstransferID = 56;  // int | 

            try
            {
                // Retrieve Communication list
                ElectronicfundstransferGetCommunicationListV1Response result = apiInstance.ElectronicfundstransferGetCommunicationListV1(pkiElectronicfundstransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ElectronicfundstransferGetCommunicationListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Communication list
    ApiResponse<ElectronicfundstransferGetCommunicationListV1Response> response = apiInstance.ElectronicfundstransferGetCommunicationListV1WithHttpInfo(pkiElectronicfundstransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiElectronicfundstransferID** | **int** |  |  |

### Return type

[**ElectronicfundstransferGetCommunicationListV1Response**](ElectronicfundstransferGetCommunicationListV1Response.md)

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

<a id="electronicfundstransfergetcommunicationrecipientsv1"></a>
# **ElectronicfundstransferGetCommunicationrecipientsV1**
> ElectronicfundstransferGetCommunicationrecipientsV1Response ElectronicfundstransferGetCommunicationrecipientsV1 (int pkiElectronicfundstransferID)

Retrieve Electronicfundstransfer's Communicationrecipient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ElectronicfundstransferGetCommunicationrecipientsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectElectronicfundstransferApi(config);
            var pkiElectronicfundstransferID = 56;  // int | 

            try
            {
                // Retrieve Electronicfundstransfer's Communicationrecipient
                ElectronicfundstransferGetCommunicationrecipientsV1Response result = apiInstance.ElectronicfundstransferGetCommunicationrecipientsV1(pkiElectronicfundstransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationrecipientsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ElectronicfundstransferGetCommunicationrecipientsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Electronicfundstransfer's Communicationrecipient
    ApiResponse<ElectronicfundstransferGetCommunicationrecipientsV1Response> response = apiInstance.ElectronicfundstransferGetCommunicationrecipientsV1WithHttpInfo(pkiElectronicfundstransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationrecipientsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiElectronicfundstransferID** | **int** |  |  |

### Return type

[**ElectronicfundstransferGetCommunicationrecipientsV1Response**](ElectronicfundstransferGetCommunicationrecipientsV1Response.md)

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

<a id="electronicfundstransfergetcommunicationsendersv1"></a>
# **ElectronicfundstransferGetCommunicationsendersV1**
> ElectronicfundstransferGetCommunicationsendersV1Response ElectronicfundstransferGetCommunicationsendersV1 (int pkiElectronicfundstransferID)

Retrieve Electronicfundstransfer's Communicationsender

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ElectronicfundstransferGetCommunicationsendersV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectElectronicfundstransferApi(config);
            var pkiElectronicfundstransferID = 56;  // int | 

            try
            {
                // Retrieve Electronicfundstransfer's Communicationsender
                ElectronicfundstransferGetCommunicationsendersV1Response result = apiInstance.ElectronicfundstransferGetCommunicationsendersV1(pkiElectronicfundstransferID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationsendersV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ElectronicfundstransferGetCommunicationsendersV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Electronicfundstransfer's Communicationsender
    ApiResponse<ElectronicfundstransferGetCommunicationsendersV1Response> response = apiInstance.ElectronicfundstransferGetCommunicationsendersV1WithHttpInfo(pkiElectronicfundstransferID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferGetCommunicationsendersV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiElectronicfundstransferID** | **int** |  |  |

### Return type

[**ElectronicfundstransferGetCommunicationsendersV1Response**](ElectronicfundstransferGetCommunicationsendersV1Response.md)

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

<a id="electronicfundstransferimportintoedmv1"></a>
# **ElectronicfundstransferImportIntoEDMV1**
> ElectronicfundstransferImportIntoEDMV1Response ElectronicfundstransferImportIntoEDMV1 (int pkiElectronicfundstransferID, ElectronicfundstransferImportIntoEDMV1Request electronicfundstransferImportIntoEDMV1Request)

Import attachments into the Electronicfundstransfer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class ElectronicfundstransferImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectElectronicfundstransferApi(config);
            var pkiElectronicfundstransferID = 56;  // int | 
            var electronicfundstransferImportIntoEDMV1Request = new ElectronicfundstransferImportIntoEDMV1Request(); // ElectronicfundstransferImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Electronicfundstransfer
                ElectronicfundstransferImportIntoEDMV1Response result = apiInstance.ElectronicfundstransferImportIntoEDMV1(pkiElectronicfundstransferID, electronicfundstransferImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ElectronicfundstransferImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Electronicfundstransfer
    ApiResponse<ElectronicfundstransferImportIntoEDMV1Response> response = apiInstance.ElectronicfundstransferImportIntoEDMV1WithHttpInfo(pkiElectronicfundstransferID, electronicfundstransferImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectElectronicfundstransferApi.ElectronicfundstransferImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiElectronicfundstransferID** | **int** |  |  |
| **electronicfundstransferImportIntoEDMV1Request** | [**ElectronicfundstransferImportIntoEDMV1Request**](ElectronicfundstransferImportIntoEDMV1Request.md) |  |  |

### Return type

[**ElectronicfundstransferImportIntoEDMV1Response**](ElectronicfundstransferImportIntoEDMV1Response.md)

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

