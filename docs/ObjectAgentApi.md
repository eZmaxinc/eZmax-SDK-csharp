# eZmaxApi.Api.ObjectAgentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AgentBatchDownloadV1**](ObjectAgentApi.md#agentbatchdownloadv1) | **POST** /1/object/agent/{pkiAgentID}/batchDownload | Download multiples attachments from a Agent |
| [**AgentGetAttachmentsV1**](ObjectAgentApi.md#agentgetattachmentsv1) | **GET** /1/object/agent/{pkiAgentID}/getAttachments | Retrieve Agent&#39;s attachments |
| [**AgentGetAutocompleteV2**](ObjectAgentApi.md#agentgetautocompletev2) | **GET** /2/object/agent/getAutocomplete/{sSelector} | Retrieve Agents and IDs |
| [**AgentGetListV1**](ObjectAgentApi.md#agentgetlistv1) | **GET** /1/object/agent/getList | Retrieve Agent list |
| [**AgentImportIntoEDMV1**](ObjectAgentApi.md#agentimportintoedmv1) | **POST** /1/object/agent/{pkiAgentID}/importIntoEDM | Import attachments into the Agent |

<a id="agentbatchdownloadv1"></a>
# **AgentBatchDownloadV1**
> System.IO.Stream AgentBatchDownloadV1 (int pkiAgentID, AgentBatchDownloadV1Request agentBatchDownloadV1Request)

Download multiples attachments from a Agent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AgentBatchDownloadV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAgentApi(config);
            var pkiAgentID = 56;  // int | 
            var agentBatchDownloadV1Request = new AgentBatchDownloadV1Request(); // AgentBatchDownloadV1Request | 

            try
            {
                // Download multiples attachments from a Agent
                System.IO.Stream result = apiInstance.AgentBatchDownloadV1(pkiAgentID, agentBatchDownloadV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAgentApi.AgentBatchDownloadV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentBatchDownloadV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download multiples attachments from a Agent
    ApiResponse<System.IO.Stream> response = apiInstance.AgentBatchDownloadV1WithHttpInfo(pkiAgentID, agentBatchDownloadV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAgentApi.AgentBatchDownloadV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAgentID** | **int** |  |  |
| **agentBatchDownloadV1Request** | [**AgentBatchDownloadV1Request**](AgentBatchDownloadV1Request.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentgetattachmentsv1"></a>
# **AgentGetAttachmentsV1**
> AgentGetAttachmentsV1Response AgentGetAttachmentsV1 (int pkiAgentID)

Retrieve Agent's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AgentGetAttachmentsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAgentApi(config);
            var pkiAgentID = 56;  // int | 

            try
            {
                // Retrieve Agent's attachments
                AgentGetAttachmentsV1Response result = apiInstance.AgentGetAttachmentsV1(pkiAgentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAgentApi.AgentGetAttachmentsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentGetAttachmentsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Agent's attachments
    ApiResponse<AgentGetAttachmentsV1Response> response = apiInstance.AgentGetAttachmentsV1WithHttpInfo(pkiAgentID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAgentApi.AgentGetAttachmentsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAgentID** | **int** |  |  |

### Return type

[**AgentGetAttachmentsV1Response**](AgentGetAttachmentsV1Response.md)

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

<a id="agentgetautocompletev2"></a>
# **AgentGetAutocompleteV2**
> AgentGetAutocompleteV2Response AgentGetAutocompleteV2 (string sSelector, string? eFilterActive = null, string? sQuery = null, HeaderAcceptLanguage? acceptLanguage = null)

Retrieve Agents and IDs

Get the list of Agent to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AgentGetAutocompleteV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAgentApi(config);
            var sSelector = "All";  // string | The type of Agents to return
            var eFilterActive = "All";  // string? | Specify which results we want to display. (optional)  (default to Active)
            var sQuery = "sQuery_example";  // string? | Allow to filter the returned results (optional) 
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 

            try
            {
                // Retrieve Agents and IDs
                AgentGetAutocompleteV2Response result = apiInstance.AgentGetAutocompleteV2(sSelector, eFilterActive, sQuery, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAgentApi.AgentGetAutocompleteV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentGetAutocompleteV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Agents and IDs
    ApiResponse<AgentGetAutocompleteV2Response> response = apiInstance.AgentGetAutocompleteV2WithHttpInfo(sSelector, eFilterActive, sQuery, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAgentApi.AgentGetAutocompleteV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sSelector** | **string** | The type of Agents to return |  |
| **eFilterActive** | **string?** | Specify which results we want to display. | [optional] [default to Active] |
| **sQuery** | **string?** | Allow to filter the returned results | [optional]  |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |

### Return type

[**AgentGetAutocompleteV2Response**](AgentGetAutocompleteV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentgetlistv1"></a>
# **AgentGetListV1**
> AgentGetListV1Response AgentGetListV1 (string? eOrderBy = null, int? iRowMax = null, int? iRowOffset = null, HeaderAcceptLanguage? acceptLanguage = null, string? sFilter = null)

Retrieve Agent list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AgentGetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAgentApi(config);
            var eOrderBy = "pkiAgentID_ASC";  // string? | Specify how you want the results to be sorted (optional) 
            var iRowMax = 56;  // int? |  (optional) 
            var iRowOffset = 0;  // int? |  (optional)  (default to 0)
            var acceptLanguage = new HeaderAcceptLanguage?(); // HeaderAcceptLanguage? |  (optional) 
            var sFilter = "sFilter_example";  // string? |  (optional) 

            try
            {
                // Retrieve Agent list
                AgentGetListV1Response result = apiInstance.AgentGetListV1(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAgentApi.AgentGetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentGetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Agent list
    ApiResponse<AgentGetListV1Response> response = apiInstance.AgentGetListV1WithHttpInfo(eOrderBy, iRowMax, iRowOffset, acceptLanguage, sFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAgentApi.AgentGetListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eOrderBy** | **string?** | Specify how you want the results to be sorted | [optional]  |
| **iRowMax** | **int?** |  | [optional]  |
| **iRowOffset** | **int?** |  | [optional] [default to 0] |
| **acceptLanguage** | [**HeaderAcceptLanguage?**](HeaderAcceptLanguage?.md) |  | [optional]  |
| **sFilter** | **string?** |  | [optional]  |

### Return type

[**AgentGetListV1Response**](AgentGetListV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **406** | The URL is valid, but one of the Accept header is not defined or invalid. For example, you set the header \&quot;Accept: application/json\&quot; but the function can only return \&quot;Content-type: image/png\&quot; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentimportintoedmv1"></a>
# **AgentImportIntoEDMV1**
> AgentImportIntoEDMV1Response AgentImportIntoEDMV1 (int pkiAgentID, AgentImportIntoEDMV1Request agentImportIntoEDMV1Request)

Import attachments into the Agent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AgentImportIntoEDMV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectAgentApi(config);
            var pkiAgentID = 56;  // int | 
            var agentImportIntoEDMV1Request = new AgentImportIntoEDMV1Request(); // AgentImportIntoEDMV1Request | 

            try
            {
                // Import attachments into the Agent
                AgentImportIntoEDMV1Response result = apiInstance.AgentImportIntoEDMV1(pkiAgentID, agentImportIntoEDMV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectAgentApi.AgentImportIntoEDMV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentImportIntoEDMV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import attachments into the Agent
    ApiResponse<AgentImportIntoEDMV1Response> response = apiInstance.AgentImportIntoEDMV1WithHttpInfo(pkiAgentID, agentImportIntoEDMV1Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ObjectAgentApi.AgentImportIntoEDMV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pkiAgentID** | **int** |  |  |
| **agentImportIntoEDMV1Request** | [**AgentImportIntoEDMV1Request**](AgentImportIntoEDMV1Request.md) |  |  |

### Return type

[**AgentImportIntoEDMV1Response**](AgentImportIntoEDMV1Response.md)

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

